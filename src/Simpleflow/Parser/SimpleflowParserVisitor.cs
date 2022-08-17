//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.10.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Navtech\Opensource\Simpleflow\src\Simpleflow\Parser\Grammar\SimpleflowParser.g4 by ANTLR 4.10.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Simpleflow.Parser {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="SimpleflowParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.CLSCompliant(false)]
internal interface ISimpleflowParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] SimpleflowParser.ProgramContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.letStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLetStmt([NotNull] SimpleflowParser.LetStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.ruleStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRuleStmt([NotNull] SimpleflowParser.RuleStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.generalStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGeneralStatement([NotNull] SimpleflowParser.GeneralStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.endRuleStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEndRuleStmt([NotNull] SimpleflowParser.EndRuleStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.setStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSetStmt([NotNull] SimpleflowParser.SetStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.messageStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMessageStmt([NotNull] SimpleflowParser.MessageStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.errorStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitErrorStmt([NotNull] SimpleflowParser.ErrorStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.outputStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOutputStmt([NotNull] SimpleflowParser.OutputStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.functionStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionStmt([NotNull] SimpleflowParser.FunctionStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.exitStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExitStmt([NotNull] SimpleflowParser.ExitStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ParenthesizedExpression</c>
	/// labeled alternative in <see cref="SimpleflowParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesizedExpression([NotNull] SimpleflowParser.ParenthesizedExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AdditiveExpression</c>
	/// labeled alternative in <see cref="SimpleflowParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAdditiveExpression([NotNull] SimpleflowParser.AdditiveExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>RelationalExpression</c>
	/// labeled alternative in <see cref="SimpleflowParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRelationalExpression([NotNull] SimpleflowParser.RelationalExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LogicalExpression</c>
	/// labeled alternative in <see cref="SimpleflowParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLogicalExpression([NotNull] SimpleflowParser.LogicalExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ObjectIdentiferExpression</c>
	/// labeled alternative in <see cref="SimpleflowParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitObjectIdentiferExpression([NotNull] SimpleflowParser.ObjectIdentiferExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FunctionExpression</c>
	/// labeled alternative in <see cref="SimpleflowParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionExpression([NotNull] SimpleflowParser.FunctionExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ArrayLiteralExpression</c>
	/// labeled alternative in <see cref="SimpleflowParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayLiteralExpression([NotNull] SimpleflowParser.ArrayLiteralExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>SimpleLiteralExpression</c>
	/// labeled alternative in <see cref="SimpleflowParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleLiteralExpression([NotNull] SimpleflowParser.SimpleLiteralExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NotExpression</c>
	/// labeled alternative in <see cref="SimpleflowParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNotExpression([NotNull] SimpleflowParser.NotExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>JsonObjLiteralExpression</c>
	/// labeled alternative in <see cref="SimpleflowParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJsonObjLiteralExpression([NotNull] SimpleflowParser.JsonObjLiteralExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MultiplicativeExpression</c>
	/// labeled alternative in <see cref="SimpleflowParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplicativeExpression([NotNull] SimpleflowParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.simpleLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleLiteral([NotNull] SimpleflowParser.SimpleLiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.templateStringLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTemplateStringLiteral([NotNull] SimpleflowParser.TemplateStringLiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.templateStringAtom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTemplateStringAtom([NotNull] SimpleflowParser.TemplateStringAtomContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction([NotNull] SimpleflowParser.FunctionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.functionArguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionArguments([NotNull] SimpleflowParser.FunctionArgumentsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.functionArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionArgument([NotNull] SimpleflowParser.FunctionArgumentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.objectIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitObjectIdentifier([NotNull] SimpleflowParser.ObjectIdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.identifierIndex"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifierIndex([NotNull] SimpleflowParser.IdentifierIndexContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIndex([NotNull] SimpleflowParser.IndexContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.stringLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStringLiteral([NotNull] SimpleflowParser.StringLiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.numberLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumberLiteral([NotNull] SimpleflowParser.NumberLiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.boolLeteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolLeteral([NotNull] SimpleflowParser.BoolLeteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.noneLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNoneLiteral([NotNull] SimpleflowParser.NoneLiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.arrayLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayLiteral([NotNull] SimpleflowParser.ArrayLiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.jsonObjLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJsonObjLiteral([NotNull] SimpleflowParser.JsonObjLiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPair([NotNull] SimpleflowParser.PairContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SimpleflowParser.eos"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEos([NotNull] SimpleflowParser.EosContext context);
}
} // namespace Simpleflow.Parser
