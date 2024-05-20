//-----------------------------------------------------------------------------
//
// Copyright (C) Microsoft Corporation.  All Rights Reserved.
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

using System.Linq;
using Microsoft.Boogie;
using static Microsoft.Dafny.RewriterErrors;
namespace MutateCSharp
{
    internal class Schemata457
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT457");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceBinExprOp_14(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 - argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, System.Uri argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() && argument2();
        }

        internal static bool ReplaceBooleanConstant_4(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.Expression argument1, Microsoft.Dafny.Expression argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_13(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static int ReplaceNumericConstant_11(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.BinaryExpr.Opcode argument1, Microsoft.Dafny.BinaryExpr.Opcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_12(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 + argument2;
        }

        internal static string ReplaceStringConstant_9(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() || argument2();
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.RangeToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.LeftMargin argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{

    public class PrecedenceLinter : IRewriter
    {
        private readonly CompilationData compilation;
        // Don't perform linting on doo files in general, since the source has already been processed.
        internal override void PostResolve(ModuleDefinition moduleDefinition)
        {
            if (MutateCSharp.Schemata457.ReplaceBinExprOp_1(2L, () => MutateCSharp.Schemata457.ReplaceBinExprOp_0(1L, moduleDefinition.tok.Uri, null), () => !moduleDefinition.ShouldVerify(compilation)))
            {
                return;
            }
            foreach (var topLevelDecl in moduleDefinition.TopLevelDecls.OfType<TopLevelDeclWithMembers>())
            {
                foreach (var callable in topLevelDecl.Members.OfType<ICallable>())
                {
                    var visitor = new PrecedenceLinterVisitor(compilation, Reporter);
                    visitor.Visit(callable, null);
                }
            }
        }

        public PrecedenceLinter(ErrorReporter reporter, CompilationData compilation) : base(reporter)
        {
            this.compilation = compilation;
        }
    }

    public
      class LeftMargin
    {
        public int Column;

        public LeftMargin(int column)
        {
            Column = column;
        }
    }

    public
      /// <summary>
      /// The PrecedenceLinterVisitor builds on Dafny's general TopDownVisitor. During the traversal, the overridable method VisitOneExpr
      /// performs some action on the given expression expr and parameter "st". The design of TopDownVisitor makes it possible for
      /// VisitOneExpr(expr, ...) to affect the traversal in the following ways:
      ///
      /// * It can request that no child of expr be visited. This is indicated by returning false.
      /// * It can request that the children of expr be visited using the same parameter value st. This is indicated by returning
      ///   true (and not assigning to st).
      /// * It can request that the children of expr be visited and provide a new parameter value st that will be passed to those
      ///   children. This is done by returning true and setting st to a different value.
      ///
      /// So, essentially, the traversal passes in one st value and gets a bool and an st back. This is encoded by making the bool
      /// be the method return value and making st a ref parameter.
      ///
      /// PrecedenceLinterVisitor.VisitOneExpr sometimes returns false, indicating that the main traversal should not go into the
      /// children of expr. Those children will therefore not be included in the stats gathered in st. Instead, PrecedenceLinterVisitor.VisitOneExpr
      /// will kick off a new visitation of its children, using a separate st object. This is how PrecedenceLinterVisitor can let the
      /// minimum-left-margin information be computed for just a part of the tree.
      ///
      /// The PrecedenceLinterVisitor also needs to be able to gather stats for all the nodes that are being visited. The design of
      /// TopDownVisitor does not use the ref parameter to accumulate values across the children; instead, it passes the same st to all
      /// children of expr. For this reason, PrecedenceLinterVisitor chooses the type of st to be a pointer to an integer.
      ///
      /// But PrecedenceLinterVisitor never uses the third case above. PrecedenceLinterVisitor would therefore be simpler if st were
      /// not a ref parameter in what is inherited from TopDownVisitor. Indeed, if we had another TopDownVisitor that streamlined this
      /// functionality, we could use it. Such a TopDownVisitor would then declare st (or, then more appropriately named "context") as
      /// an ordinary in-parameter to VisitOneExpr, since the method would only need to return a bool.
      /// </summary>
      class PrecedenceLinterVisitor : TopDownVisitor<LeftMargin>
    {
        private readonly CompilationData compilation;
        private readonly ErrorReporter reporter;

        public PrecedenceLinterVisitor(CompilationData compilation, ErrorReporter reporter)
        {
            this.compilation = compilation;
            this.reporter = reporter;
        }

        /// <summary>
        /// Regarding the "st" parameter, see the comment above the class.
        /// </summary>
        protected override bool VisitOneExpr(Expression expr, ref LeftMargin st)
        {
            if (MutateCSharp.Schemata457.ReplaceBinExprOp_2(15L, () => MutateCSharp.Schemata457.ReplaceBinExprOp_2(8L, () => AutoGeneratedToken.Is(expr.tok), () => expr is DefaultValueExpression), () => MutateCSharp.Schemata457.ReplaceBinExprOp_3(14L, expr.RangeToken, null)))
            {
                return MutateCSharp.Schemata457.ReplaceBooleanConstant_4(21L, false); // don't traverse further
            }

            if (MutateCSharp.Schemata457.ReplaceBinExprOp_5(22L, st, null))
            {
                int column;
                if (expr is DatatypeUpdateExpr or SeqSelectExpr or SeqUpdateExpr or MultiSelectExpr or TernaryExpr)
                {
                    // These expressions are handled below as being all-independent components, which means the
                    // formatting of their internal structure is not relevant to the enclosing context. Yet, the .tok of
                    // these expressions sits someone inside that internal structure (for example, the .tok of
                    // a SeqSelectExpr is the open-bracket). To avoid looking at that internal structure, we instead
                    // use the .StartToken for these expressions.
                    column = expr.StartToken.col;
                }
                else
                {
                    column = expr.tok.col;
                }
                if (MutateCSharp.Schemata457.ReplaceBinExprOp_6(23L, column, st.Column))
                {
                    st.Column = column;
                }
            }

            // Our aim is to try to detect if some expressions are longer than the user intended.
            // This can happen if the user accidentally left off parentheses around a lower-precedence
            // operator (e.g., ==>). As a guide, we look at how the user formatted the code,
            // that is, we inspect line and column information.

            if (expr is BinaryExpr bin && (MutateCSharp.Schemata457.ReplaceBinExprOp_2(37L, () => MutateCSharp.Schemata457.ReplaceBinExprOp_2(30L, () => MutateCSharp.Schemata457.ReplaceBinExprOp_7(28L, bin.Op, BinaryExpr.Opcode.Imp), () => MutateCSharp.Schemata457.ReplaceBinExprOp_7(29L, bin.Op, BinaryExpr.Opcode.Exp)), () => MutateCSharp.Schemata457.ReplaceBinExprOp_7(36L, bin.Op, BinaryExpr.Opcode.Iff))))
            {
                // For
                //   a)  LHS ==> RHS
                //   b)  LHS ==>
                //         RHS-somewhere-on-this-line
                // use LHS.StartToken as the left margin.
                // For
                //   c)  LHS0 &&
                //       LHS1 ==> RHS
                // use expr.tok (that is, the location of ==>) as the left margin. This is bound to generate a warning.
                // For
                //   d)  LHS0 &&
                //       LHS1 ==>
                //         RHS-somewhere-on-this-line
                //   e)  LHS0 &&
                //       LHS1
                //       ==>
                //         RHS-somewhere-on-this-line
                // use LHS.StartToken as the left margin.
                VisitLhsComponent(expr.tok, bin.E0,
        MutateCSharp.Schemata457.ReplaceBinExprOp_8(43L, bin.E0.StartToken.line, expr.tok.line) ? bin.E0.StartToken.col : MutateCSharp.Schemata457.ReplaceBinExprOp_8(48L, bin.E1.StartToken.line, expr.tok.line) ? expr.tok.col :
                  bin.E0.StartToken.col,
        MutateCSharp.Schemata457.ReplaceStringConstant_9(53L, "left-hand operand of ") + BinaryExpr.OpcodeString(bin.Op));
                VisitRhsComponent(expr.tok, bin.E1, MutateCSharp.Schemata457.ReplaceStringConstant_9(54L, "right-hand operand of ") + BinaryExpr.OpcodeString(bin.Op));
                return MutateCSharp.Schemata457.ReplaceBooleanConstant_4(55L, false); // indicate that we've already processed expr's subexpressions

            }
            else if (expr is ITEExpr ifThenElse)
            {
                VisitIndependentComponent(ifThenElse.Test);
                VisitIndependentComponent(ifThenElse.Thn);
                VisitRhsComponent(expr.tok, ifThenElse.Els, MutateCSharp.Schemata457.ReplaceStringConstant_9(56L, "else branch of if-then-else"));
                return MutateCSharp.Schemata457.ReplaceBooleanConstant_4(57L, false); // indicate that we've already processed expr's subexpressions

            }
            else if (expr is QuantifierExpr quantifierExpr)
            {
                Attributes.SubExpressions(quantifierExpr.Attributes).ForEach(VisitIndependentComponent);
                if (MutateCSharp.Schemata457.ReplaceBinExprOp_10(58L, quantifierExpr.Range, null))
                {
                    VisitIndependentComponent(quantifierExpr.Range);
                }
                VisitRhsComponent(expr.tok, quantifierExpr.Term,
        MutateCSharp.Schemata457.ReplaceBinExprOp_8(59L, expr.tok.line, quantifierExpr.Term.StartToken.line) ? MutateCSharp.Schemata457.ReplaceBinExprOp_12(68L, expr.tok.col, MutateCSharp.Schemata457.ReplaceNumericConstant_11(64L, 1)) : quantifierExpr.Term.StartToken.col,
        MutateCSharp.Schemata457.ReplaceStringConstant_9(77L, "body of ") + (expr is ForallExpr ? MutateCSharp.Schemata457.ReplaceStringConstant_9(78L, "forall") : MutateCSharp.Schemata457.ReplaceStringConstant_9(79L, "exists")));
                return MutateCSharp.Schemata457.ReplaceBooleanConstant_4(80L, false); // indicate that we've already processed expr's subexpressions

            }
            else if (expr is LetExpr letExpr)
            {
                Attributes.SubExpressions(letExpr.Attributes).ForEach(VisitIndependentComponent);
                letExpr.RHSs.ForEach(VisitIndependentComponent);
                VisitRhsComponent(expr.tok, letExpr.Body, MutateCSharp.Schemata457.ReplaceStringConstant_9(81L, "body of let-expression"));
                return MutateCSharp.Schemata457.ReplaceBooleanConstant_4(82L, false); // indicate that we've already processed expr's subexpressions

            }
            else if (expr is OldExpr or FreshExpr or UnchangedExpr or DatatypeValue or DisplayExpression or MapDisplayExpr)
            {
                // In these expressions, all subexpressions are contained in parentheses, so there's no risk of precedence confusion
                expr.SubExpressions.ForEach(VisitIndependentComponent);
                return MutateCSharp.Schemata457.ReplaceBooleanConstant_4(83L, false); // indicate that we've already processed expr's subexpressions

            }
            else if (expr is FunctionCallExpr functionCallExpr)
            {
                return VisitComponentsAsIndependentExceptOne(expr, functionCallExpr.Receiver, st);
            }
            else if (expr is ApplyExpr applyExpr)
            {
                return VisitComponentsAsIndependentExceptOne(expr, applyExpr.Function, st);
            }
            else if (expr is DatatypeUpdateExpr datatypeUpdateExpr)
            {
                return VisitComponentsAsIndependentExceptOne(expr, datatypeUpdateExpr.Root, st);
            }
            else if (expr is SeqSelectExpr selectExpr)
            {
                return VisitComponentsAsIndependentExceptOne(expr, selectExpr.Seq, st);
            }
            else if (expr is SeqUpdateExpr seqUpdateExpr)
            {
                return VisitComponentsAsIndependentExceptOne(expr, seqUpdateExpr.Seq, st);
            }
            else if (expr is MultiSelectExpr multiSelectExpr)
            {
                return VisitComponentsAsIndependentExceptOne(expr, multiSelectExpr.Array, st);

            }
            else if (expr is TernaryExpr ternaryExpr)
            {
                VisitIndependentComponent(ternaryExpr.E0);
                Visit(ternaryExpr.E1, st);
                Visit(ternaryExpr.E2, st);
                return MutateCSharp.Schemata457.ReplaceBooleanConstant_4(84L, false); // indicate that we've already processed expr's subexpressions

            }
            else if (expr is NestedMatchExpr nestedMatchExpr)
            {
                // Handle each case like the "else" of an if-then-else
                Attributes.SubExpressions(nestedMatchExpr.Attributes).ForEach(VisitIndependentComponent);
                VisitIndependentComponent(nestedMatchExpr.Source);
                var n = nestedMatchExpr.Cases.Count;
                for (var i = MutateCSharp.Schemata457.ReplaceNumericConstant_11(85L, 0); MutateCSharp.Schemata457.ReplaceBinExprOp_6(89L, i, n); MutateCSharp.Schemata457.ReplacePostfixUnaryExprOp_13(94L, ref i))
                {
                    var body = nestedMatchExpr.Cases[i].Body;
                    if (MutateCSharp.Schemata457.ReplaceBinExprOp_1(113L, () => MutateCSharp.Schemata457.ReplaceBinExprOp_8(108L, i, MutateCSharp.Schemata457.ReplaceBinExprOp_14(99L, n, MutateCSharp.Schemata457.ReplaceNumericConstant_11(95L, 1))), () => !nestedMatchExpr.UsesOptionalBraces))
                    {
                        VisitRhsComponent(body.StartToken, body, MutateCSharp.Schemata457.ReplaceStringConstant_9(119L, "case expression"));
                    }
                    else
                    {
                        VisitIndependentComponent(body);
                    }
                }

                return MutateCSharp.Schemata457.ReplaceBooleanConstant_4(120L, false); // indicate that we've already processed expr's subexpressions
            }

            return base.VisitOneExpr(expr, ref st);
        }

        /// <summary>
        /// For each subexpression of "expr", call "VisitIndependentComponent" unless the subexpression
        /// is "exception", in which case call "Visit(exception, st)".
        /// For convenience to the caller, this method always returns "false".
        /// </summary>
        bool VisitComponentsAsIndependentExceptOne(Expression expr, Expression exception, LeftMargin st)
        {
            foreach (var e in expr.SubExpressions)
            {
                if (MutateCSharp.Schemata457.ReplaceBinExprOp_15(121L, e, exception))
                {
                    Visit(e, st);
                }
                else
                {
                    VisitIndependentComponent(e);
                }
            }
            return MutateCSharp.Schemata457.ReplaceBooleanConstant_4(122L, false);
        }

        void VisitIndependentComponent(Expression expr)
        {
            Visit(expr, null);
        }

        void VisitLhsComponent(IToken errorToken, Expression expr, int leftMargin, string what)
        {
            if (MutateCSharp.Schemata457.ReplaceBinExprOp_2(128L, () => expr is ParensExpression, () => MutateCSharp.Schemata457.ReplaceBinExprOp_8(123L, expr.StartToken.line, errorToken.line)))
            {
                VisitIndependentComponent(expr);
            }
            else
            {
                var st = new LeftMargin(leftMargin);
                Visit(expr, st);
                if (MutateCSharp.Schemata457.ReplaceBinExprOp_6(134L, st.Column, leftMargin))
                {
                    reporter.Warning(MessageSource.Rewriter, ErrorId.rw_unusual_indentation_start, errorToken,
                      $"unusual indentation in {what} (which starts at {LineCol(expr.StartToken)}); do you perhaps need parentheses?");
                }
            }
        }

        void VisitRhsComponent(IToken errorToken, Expression expr, string what)
        {
            if (MutateCSharp.Schemata457.ReplaceBinExprOp_16(139L, expr.StartToken, null))
            {
                // Might be a resolved expression.
                VisitIndependentComponent(expr);
            }
            else
            {
                VisitRhsComponent(errorToken, expr, expr.StartToken.col, what);
            }
        }

        void VisitRhsComponent(IToken errorToken, Expression expr, int rightMargin, string what)
        {
            if (MutateCSharp.Schemata457.ReplaceBinExprOp_2(140L, () => expr is ParensExpression, () => errorToken.FromIncludeDirective(compilation)))
            {
                VisitIndependentComponent(expr);
            }
            else
            {
                var st = new LeftMargin(rightMargin);
                Visit(expr, st);
                if (MutateCSharp.Schemata457.ReplaceBinExprOp_6(146L, st.Column, rightMargin))
                {
                    reporter.Warning(MessageSource.Rewriter, ErrorId.rw_unusual_indentation_end, errorToken,
                      $"unusual indentation in {what} (which ends at {LineCol(expr.RangeToken.EndToken)}); do you perhaps need parentheses?");
                }
            }
        }

        static string LineCol(IToken tok)
        {
            return $"line {tok.line}, column {tok.col}";
        }
    }
}
