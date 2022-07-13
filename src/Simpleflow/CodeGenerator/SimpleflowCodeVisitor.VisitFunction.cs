﻿// Copyright (c) navtech.io. All rights reserved.
// See License in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

using Simpleflow.Exceptions;
using Simpleflow.Parser;

namespace Simpleflow.CodeGenerator
{
    partial class SimpleflowCodeVisitor<TArg>
    {

        // Use this field to add additional attributes to use in visitors methods

        public override Expression VisitFunction([NotNull] SimpleflowParser.FunctionContext context)
        {
            var functionName = context.FunctionName().GetText();

            // Get registered function
            var function = FunctionRegister.GetFunction(functionName.Substring(1)); // Remove $ symbol

            if (function == null)
            {
                throw new InvalidFunctionException(functionName);
            }

            // Get actual method meta-data info and parameters
            var methodInfo = function.GetMethodInfo();

            // Map script arguments to method parameters
            var argumentsExpressions = GetArgumentExpressions(context, methodInfo);

            var exp = Expression.Call(null, methodInfo, argumentsExpressions);
            return exp;
        }

        private List<Expression> GetArgumentExpressions(SimpleflowParser.FunctionContext context, MethodInfo methodInfo)
        {
            var actualMethodParameters = methodInfo.GetParameters();
            var parameters = context.functionParameter();
            var argumentsExpressions = new List<Expression>();

            if (parameters == null)
            {
                return argumentsExpressions;
            }

            CheckInvalidParameters(actualMethodParameters, parameters);
            CheckRepeatedParameters(parameters);

            foreach (var methodParameter in actualMethodParameters)
            {

                //Parameter Syntax:  ParmeterName ':' (Number|String|Bool|None|objectIdentifier)
                var scriptArgument = parameters.SingleOrDefault(parameter => string.Equals(parameter.Identifier().GetText(), methodParameter.Name, System.StringComparison.OrdinalIgnoreCase));

                if (scriptArgument == null)
                {
                    argumentsExpressions.Add(Expression.Default(methodParameter.ParameterType));
                    // AddDefaultIfMatches(argumentsExpressions, methodParameter, parameterValueContext: null);
                    continue;
                }

                var parameterExpression = CreateFunctionParameterExpression(methodParameter, scriptArgument);

                // Add result expression
                if (parameterExpression != null)
                {
                    argumentsExpressions.Add(parameterExpression);
                }
            }

            return argumentsExpressions;
        }

        private Expression CreateFunctionParameterExpression(ParameterInfo methodParameter, SimpleflowParser.FunctionParameterContext scriptArgument)
        {
            var parameterValueContext = scriptArgument.functionParameterValue().GetChild(0);

            if (parameterValueContext is SimpleflowParser.ObjectIdentifierContext oic)
            {
                return VisitParameterObjectIdentifer(oic, methodParameter.ParameterType);
            }

            return VisitWithType(parameterValueContext, methodParameter.ParameterType);
        }

        private void CheckRepeatedParameters(SimpleflowParser.FunctionParameterContext[] parameters)
        {
            var repeatedParameter = (from parameter in parameters
                                     group parameter by parameter.Identifier().GetText() into g
                                     where g.Count() > 1
                                     select g.Key).ToList();

            if (repeatedParameter.Count > 0)
            {
                throw new DuplicateParametersException(string.Join(',', repeatedParameter));
            }
        }

        private void CheckInvalidParameters(ParameterInfo[] actualMethodParameters, SimpleflowParser.FunctionParameterContext[] parameters)
        {
            foreach (var parameter in parameters)
            {
                var paramterName = parameter.Identifier().GetText();
                if (!actualMethodParameters.Any(p => string.Equals(p.Name, paramterName, System.StringComparison.OrdinalIgnoreCase)))
                {
                    throw new InvalidFunctionParameterNameException(paramterName);
                }
            }
        }

        private Expression VisitParameterObjectIdentifer(SimpleflowParser.ObjectIdentifierContext objectIdentifier, Type targetType)
        {
            var objectIdentieferText = objectIdentifier.GetText();
            
            if (objectIdentieferText.Contains(".") 
                || Variables.Any(v => string.Equals(v.Name,  objectIdentieferText, StringComparison.OrdinalIgnoreCase)))
            {
                return Visit(objectIdentifier); // regular object identifier used from variables
            }

            return CreateSmartVariableIfObjectIdentiferNotDefined(targetType, objectIdentieferText);
        }

        private Expression CreateSmartVariableIfObjectIdentiferNotDefined(Type targetType, string name)
        {
            // Variable names are not case sensitive
            var smartVar = GetSmartVariable(name);

            if (smartVar == null)
            {
                throw new InvalidFunctionParameterNameException(name);
            }

            // Return if already created
            if (smartVar.VariableExpression != null)
            {
                return smartVar.VariableExpression;
            }

            // Create
            var pairs = smartVar.Context.jsonObj().pair();
            var memberBindings = new List<MemberBinding>();

            foreach (var pair in pairs)
            {
                // Property name
                var prop = pair.Identifier().GetText();

                // Property Type
                var member = targetType.GetProperty(prop);

                // Property Value
                var value = pair.value().GetChild(0);

                // Create Property Expression
                Expression valueExpression;
                if (value is SimpleflowParser.ObjectIdentifierContext oic)
                {
                    valueExpression = VisitParameterObjectIdentifer(oic, member.PropertyType);
                }
                else
                {
                    valueExpression = VisitWithType(value, member.PropertyType);
                }

                // Bind member
                memberBindings.Add(Expression.Bind(member, valueExpression));
            }

            // Create new instance and assign member bindings
            Expression membersInitialization = Expression.MemberInit(Expression.New(targetType),memberBindings);

            // Store created smart variable to further reuse and replace.
            smartVar.VariableExpression = Expression.Assign(Expression.Variable(targetType), membersInitialization);

            return membersInitialization;
        }

        private Expression VisitWithType(IParseTree tree, Type type)
        {
            TargetTypeParserContextAnnotation.Put(tree, type);
            var expression = Visit(tree);
            TargetTypeParserContextAnnotation.RemoveFrom(tree);

            return expression;
        }

    }
}
