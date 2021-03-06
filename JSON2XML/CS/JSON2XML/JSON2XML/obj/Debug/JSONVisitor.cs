//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\Practice\JSON2XML\CS\JSON2XML\JSON2XML\JSON.g4 by ANTLR 4.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace JSON2XML {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="JSONParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
[System.CLSCompliant(false)]
public interface IJSONVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>ObjectValue</c>
	/// labeled alternative in <see cref="JSONParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitObjectValue([NotNull] JSONParser.ObjectValueContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ArrayValue</c>
	/// labeled alternative in <see cref="JSONParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayValue([NotNull] JSONParser.ArrayValueContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AnObject</c>
	/// labeled alternative in <see cref="JSONParser.object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAnObject([NotNull] JSONParser.AnObjectContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ArrayOfValues</c>
	/// labeled alternative in <see cref="JSONParser.array"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayOfValues([NotNull] JSONParser.ArrayOfValuesContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Atom</c>
	/// labeled alternative in <see cref="JSONParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtom([NotNull] JSONParser.AtomContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="JSONParser.pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPair([NotNull] JSONParser.PairContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="JSONParser.json"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJson([NotNull] JSONParser.JsonContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>String</c>
	/// labeled alternative in <see cref="JSONParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString([NotNull] JSONParser.StringContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>EmptyArray</c>
	/// labeled alternative in <see cref="JSONParser.array"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEmptyArray([NotNull] JSONParser.EmptyArrayContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>EmptyObject</c>
	/// labeled alternative in <see cref="JSONParser.object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEmptyObject([NotNull] JSONParser.EmptyObjectContext context);
}
} // namespace JSON2XML
