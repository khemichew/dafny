using System.Diagnostics.Contracts;
using System.Linq;
using JetBrains.Annotations;
using static Microsoft.Dafny.ResolutionErrors;
namespace MutateCSharp
{
    internal class Schemata401
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT401");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_24(long mutantId, Microsoft.Dafny.MatchCaseStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_13(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.ConcreteUpdateStatement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, Microsoft.Dafny.ForallStmt.BodyKind argument1, Microsoft.Dafny.ForallStmt.BodyKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.FrameExpression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_5(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, Microsoft.Dafny.AssignStmt.NonGhostKind argument1, Microsoft.Dafny.AssignStmt.NonGhostKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_22(long mutantId, Microsoft.Dafny.ForallStmt.BodyKind argument1, Microsoft.Dafny.ForallStmt.BodyKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, Microsoft.Dafny.CallStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, Microsoft.Dafny.DatatypeCtor argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.AttributedToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.ConcreteUpdateStatement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.AssignStmt.NonGhostKind argument1, Microsoft.Dafny.AssignStmt.NonGhostKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.AssertStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.UpdateStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.AttributedToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceNumericConstant_12(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_28(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

    }
}

namespace Microsoft.Dafny
{
    public
class GhostInterestVisitor
    {
        readonly ICodeContext codeContext;
        readonly ModuleResolver resolver;
        private readonly ErrorReporter reporter;
        private readonly bool inConstructorInitializationPhase;
        private readonly bool allowAssumptionVariables;
        public GhostInterestVisitor(ICodeContext codeContext, ModuleResolver resolver, ErrorReporter reporter, bool inConstructorInitializationPhase, bool allowAssumptionVariables)
        {
            Contract.Requires(codeContext != null);
            Contract.Requires(resolver != null);
            this.codeContext = codeContext;
            this.resolver = resolver;
            this.reporter = reporter;
            this.inConstructorInitializationPhase = inConstructorInitializationPhase;
            this.allowAssumptionVariables = allowAssumptionVariables;
        }
        protected void Error(ErrorId errorId, Statement stmt, string msg, params object[] msgArgs)
        {
            Contract.Requires(stmt != null);
            Contract.Requires(msg != null);
            Contract.Requires(msgArgs != null);
            reporter.Error(MessageSource.Resolver, errorId, stmt, msg, msgArgs);
        }
        protected void Error(ErrorId errorId, Expression expr, string msg, params object[] msgArgs)
        {
            Contract.Requires(expr != null);
            Contract.Requires(msg != null);
            Contract.Requires(msgArgs != null);
            reporter.Error(MessageSource.Resolver, errorId, expr, msg, msgArgs);
        }
        protected void Error(ErrorId errorId, IToken tok, string msg, params object[] msgArgs)
        {
            Contract.Requires(tok != null);
            Contract.Requires(msg != null);
            Contract.Requires(msgArgs != null);
            reporter.Error(MessageSource.Resolver, errorId, tok, msg, msgArgs);
        }
        /// <summary>
        /// There are three kinds of contexts for statements.
        ///   - compiled contexts, where the statement must be compilable
        ///     -- !mustBeErasable && proofContext == null
        ///   - ghost contexts that allow the allocation of new object
        ///     -- mustBeErasable && proofContext == null
        ///   - lemma/proof contexts, which are ghost and are not allowed to allocate new objects
        ///     -- mustBeErasable && proofContext != null
        /// 
        /// This method does three things, in order:
        /// 0. Sets .IsGhost to "true" if the statement is ghost.  This often depends on some guard of the statement
        ///    (like the guard of an "if" statement) or the LHS of the statement (if it is an assignment).
        ///    Note, if "mustBeErasable", then the statement is already in a ghost context.
        /// 1. Determines if the statement and all its subparts are legal under its computed .IsGhost setting.
        /// 2. ``Upgrades'' .IsGhost to "true" if, after investigation of the substatements of the statement, it
        ///    turns out that the statement can be erased during compilation.
        /// Notes:
        /// * Both step (0) and step (2) sets the .IsGhost field.  What step (0) does affects only the
        ///   rules of resolution, whereas step (2) makes a note for the later compilation phase.
        /// * It is important to do step (0) before step (1)--that is, it is important to set the statement's ghost
        ///   status before descending into its substatements--because break statements look at the ghost status of
        ///   its enclosing statements.
        /// * The method called by a StmtExpr must be ghost; however, this is checked elsewhere.  For
        ///   this reason, it is not necessary to visit all subexpressions, unless the subexpression
        ///   matter for the ghost checking/recording of "stmt".
        ///
        /// If "proofContext" is non-null, then this method also checks that "stmt" does not allocate
        /// memory or modify the heap, either directly or indirectly using a statement like "modify", a loop with
        /// an explicit "modifies" clause, or a call to a method that may allocate memory or modify the heap.
        /// The "proofContext" string is something that can be printed as part of an error message.
        /// </summary>
        public void Visit(Statement stmt, bool mustBeErasable, [CanBeNull] string proofContext)
        {
            Contract.Requires(stmt != null);
            Contract.Assume(!codeContext.IsGhost || mustBeErasable); // (this is really a precondition) CodeContext.IsGhost ==> mustBeErasable
            Contract.Assume(mustBeErasable || proofContext == null); // (this is really a precondition) !mustBeErasable ==> proofContext == null 

            if (MutateCSharp.Schemata401.ReplaceBinExprOp_0(1L, () => stmt is AssertStmt, () => stmt is AssumeStmt))
            {
                stmt.IsGhost = MutateCSharp.Schemata401.ReplaceBooleanConstant_1(7L, true);
                var assertStmt = stmt as AssertStmt;
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(10L, () => MutateCSharp.Schemata401.ReplaceBinExprOp_2(8L, assertStmt, null), () => MutateCSharp.Schemata401.ReplaceBinExprOp_3(9L, assertStmt.Proof, null)))
                {
                    Visit(assertStmt.Proof, MutateCSharp.Schemata401.ReplaceBooleanConstant_1(16L, true), MutateCSharp.Schemata401.ReplaceStringConstant_5(17L, "an assert-by body"));
                }

            }
            else if (stmt is ExpectStmt)
            {
                stmt.IsGhost = MutateCSharp.Schemata401.ReplaceBooleanConstant_1(18L, false);
                var s = (ExpectStmt)stmt;
                if (mustBeErasable)
                {
                    Error(ErrorId.r_expect_statement_is_not_ghost, stmt, MutateCSharp.Schemata401.ReplaceStringConstant_5(19L, "expect statement is not allowed in this context (because this is a ghost method or because the statement is guarded by a specification-only expression)"));
                }
                else
                {
                    ExpressionTester.CheckIsCompilable(resolver, reporter, s.Expr, codeContext);
                    // If not provided, the message is populated with a default value in resolution
                    Contract.Assert(s.Message != null);
                    ExpressionTester.CheckIsCompilable(resolver, reporter, s.Message, codeContext);
                }

            }
            else if (stmt is PrintStmt)
            {
                var s = (PrintStmt)stmt;
                if (mustBeErasable)
                {
                    Error(ErrorId.r_print_statement_is_not_ghost, stmt, MutateCSharp.Schemata401.ReplaceStringConstant_5(20L, "print statement is not allowed in this context (because this is a ghost method or because the statement is guarded by a specification-only expression)"));
                }
                else
                {
                    s.Args.ForEach(ee => ExpressionTester.CheckIsCompilable(resolver, reporter, ee, codeContext));
                }

            }
            else if (stmt is RevealStmt)
            {
                var s = (RevealStmt)stmt;
                s.ResolvedStatements.ForEach(ss => Visit(ss, MutateCSharp.Schemata401.ReplaceBooleanConstant_1(21L, true), MutateCSharp.Schemata401.ReplaceStringConstant_5(22L, "a reveal statement")));
                s.IsGhost = s.ResolvedStatements.All(ss => ss.IsGhost);

            }
            else if (stmt is BreakStmt)
            {
                var s = (BreakStmt)stmt;
                s.IsGhost = mustBeErasable;
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(23L, () => s.IsGhost, () => !s.TargetStmt.IsGhost))
                {
                    var targetKind = s.TargetStmt is LoopStmt ? MutateCSharp.Schemata401.ReplaceStringConstant_5(29L, "loop") : MutateCSharp.Schemata401.ReplaceStringConstant_5(30L, "structure");
                    Error(ErrorId.r_ghost_break, stmt, $"ghost-context {s.Kind} statement is not allowed to {s.Kind} out of non-ghost {targetKind}");
                }

            }
            else if (stmt is ProduceStmt)
            {
                var s = (ProduceStmt)stmt;
                var kind = stmt is YieldStmt ? MutateCSharp.Schemata401.ReplaceStringConstant_5(31L, "yield") : MutateCSharp.Schemata401.ReplaceStringConstant_5(32L, "return");
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(33L, () => mustBeErasable, () => !codeContext.IsGhost))
                {
                    Error(ErrorId.r_produce_statement_not_allowed_in_ghost, stmt, MutateCSharp.Schemata401.ReplaceStringConstant_5(39L, "{0} statement is not allowed in this context (because it is guarded by a specification-only expression)"), kind);
                }
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_6(40L, s.HiddenUpdate, null))
                {
                    Visit(s.HiddenUpdate, mustBeErasable, proofContext);
                }

            }
            else if (stmt is AssignSuchThatStmt)
            {
                var s = (AssignSuchThatStmt)stmt;
                s.IsGhost = MutateCSharp.Schemata401.ReplaceBinExprOp_0(48L, () => MutateCSharp.Schemata401.ReplaceBinExprOp_0(42L, () => mustBeErasable, () => MutateCSharp.Schemata401.ReplaceBinExprOp_7(41L, s.AssumeToken, null)), () => s.Lhss.Any(AssignStmt.LhsIsToGhost));
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(54L, () => mustBeErasable, () => !codeContext.IsGhost))
                {
                    foreach (var lhs in s.Lhss)
                    {
                        var gk = AssignStmt.LhsIsToGhost_Which(lhs);
                        if (MutateCSharp.Schemata401.ReplaceBinExprOp_8(60L, gk, AssignStmt.NonGhostKind.IsGhost))
                        {
                            Error(ErrorId.r_no_assign_to_var_in_ghost, lhs, MutateCSharp.Schemata401.ReplaceStringConstant_5(61L, "cannot assign to {0} in a ghost context"), AssignStmt.NonGhostKind_To_String(gk));
                        }
                    }
                }
                else if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(69L, () => MutateCSharp.Schemata401.ReplaceBinExprOp_4(63L, () => !mustBeErasable, () => MutateCSharp.Schemata401.ReplaceBinExprOp_9(62L, s.AssumeToken, null)), () => ExpressionTester.UsesSpecFeatures(s.Expr)))
                {
                    foreach (var lhs in s.Lhss)
                    {
                        var gk = AssignStmt.LhsIsToGhost_Which(lhs);
                        if (MutateCSharp.Schemata401.ReplaceBinExprOp_8(75L, gk, AssignStmt.NonGhostKind.IsGhost))
                        {
                            Error(ErrorId.r_no_assign_ghost_to_var, lhs, MutateCSharp.Schemata401.ReplaceStringConstant_5(76L, "{0} cannot be assigned a value that depends on a ghost"), AssignStmt.NonGhostKind_To_String(gk));
                        }
                    }
                }

            }
            else if (stmt is UpdateStmt)
            {
                var s = (UpdateStmt)stmt;
                s.ResolvedStatements.ForEach(ss => Visit(ss, mustBeErasable, proofContext));
                s.IsGhost = s.ResolvedStatements.All(ss => ss.IsGhost);

            }
            else if (stmt is AssignOrReturnStmt)
            {
                var s = (AssignOrReturnStmt)stmt;
                s.ResolvedStatements.ForEach(ss => Visit(ss, mustBeErasable, proofContext));
                s.IsGhost = s.ResolvedStatements.All(ss => ss.IsGhost);

            }
            else if (stmt is VarDeclStmt)
            {
                var s = (VarDeclStmt)stmt;
                if (mustBeErasable)
                {
                    foreach (var local in s.Locals)
                    {
                        // a local variable in a specification-only context might as well be ghost
                        local.MakeGhost();
                    }
                }
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_10(77L, s.Update, null))
                {
                    Visit(s.Update, mustBeErasable, proofContext);
                }
                s.IsGhost = MutateCSharp.Schemata401.ReplaceBinExprOp_4(85L, () => (MutateCSharp.Schemata401.ReplaceBinExprOp_0(79L, () => MutateCSharp.Schemata401.ReplaceBinExprOp_11(78L, s.Update, null), () => s.Update.IsGhost)), () => s.Locals.All(v => v.IsGhost));

                // Check on "assumption" variables
                foreach (var local in s.Locals)
                {
                    if (Attributes.Contains(local.Attributes, MutateCSharp.Schemata401.ReplaceStringConstant_5(91L, "assumption")))
                    {
                        if (allowAssumptionVariables)
                        {
                            if (!local.Type.IsBoolType)
                            {
                                Error(ErrorId.r_assumption_var_must_be_bool, local.Tok, MutateCSharp.Schemata401.ReplaceStringConstant_5(92L, "assumption variable must be of type 'bool'"));
                            }
                            if (!local.IsGhost)
                            {
                                Error(ErrorId.r_assumption_var_must_be_ghost, local.Tok, MutateCSharp.Schemata401.ReplaceStringConstant_5(93L, "assumption variable must be ghost"));
                            }
                        }
                        else
                        {
                            Error(ErrorId.r_assumption_var_must_be_in_method, local.Tok, MutateCSharp.Schemata401.ReplaceStringConstant_5(94L, "assumption variable can only be declared in a method"));
                        }
                    }
                }

            }
            else if (stmt is VarDeclPattern)
            {
                var s = (VarDeclPattern)stmt;

                if (mustBeErasable)
                {
                    foreach (var local in s.LocalVars)
                    {
                        local.MakeGhost();
                    }
                }
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_0(95L, () => s.HasGhostModifier, () => mustBeErasable))
                {
                    s.IsGhost = s.LocalVars.All(v => v.IsGhost);
                }
                else
                {
                    var spec = ExpressionTester.UsesSpecFeatures(s.RHS);
                    if (spec)
                    {
                        foreach (var local in s.LocalVars)
                        {
                            local.MakeGhost();
                        }
                    }
                    else
                    {
                        ExpressionTester.CheckIsCompilable(resolver, reporter, s.RHS, codeContext);
                    }
                    s.IsGhost = spec;
                }

            }
            else if (stmt is AssignStmt)
            {
                var s = (AssignStmt)stmt;
                CheckAssignStmt(s, mustBeErasable, proofContext);

            }
            else if (stmt is CallStmt)
            {
                var s = (CallStmt)stmt;
                var callee = s.Method;
                Contract.Assert(callee != null);  // follows from the invariant of CallStmt
                s.IsGhost = callee.IsGhost;
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(101L, () => proofContext != null, () => !callee.IsLemmaLike))
                {
                    Error(ErrorId.r_no_calls_in_proof, s, $"in {proofContext}, calls are allowed only to lemmas");
                }
                else if (mustBeErasable)
                {
                    if (!s.IsGhost)
                    {
                        Error(ErrorId.r_only_ghost_calls, s, MutateCSharp.Schemata401.ReplaceStringConstant_5(107L, "only ghost methods can be called from this context"));
                    }
                }
                else
                {
                    int j;
                    if (!callee.IsGhost)
                    {
                        // check in-parameters
                        ExpressionTester.CheckIsCompilable(resolver, reporter, s.Receiver, codeContext);
                        j = MutateCSharp.Schemata401.ReplaceNumericConstant_12(108L, 0);
                        foreach (var e in s.Args)
                        {
                            Contract.Assume(j < callee.Ins.Count);  // this should have already been checked by the resolver
                            if (!callee.Ins[j].IsGhost)
                            {
                                ExpressionTester.CheckIsCompilable(resolver, reporter, e, codeContext);
                            }

                            MutateCSharp.Schemata401.ReplacePostfixUnaryExprOp_13(112L, ref j);
                        }
                    }
                    j = MutateCSharp.Schemata401.ReplaceNumericConstant_12(113L, 0);
                    foreach (var e in s.Lhs)
                    {
                        var resolvedLhs = e.Resolved;
                        if (MutateCSharp.Schemata401.ReplaceBinExprOp_0(117L, () => callee.IsGhost, () => callee.Outs[j].IsGhost))
                        {
                            // LHS must denote a ghost
                            if (resolvedLhs is IdentifierExpr)
                            {
                                var ll = (IdentifierExpr)resolvedLhs;
                                if (!ll.Var.IsGhost)
                                {
                                    if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(123L, () => ll is AutoGhostIdentifierExpr, () => ll.Var is LocalVariable))
                                    {
                                        // the variable was actually declared in this statement, so auto-declare it as ghost
                                        ((LocalVariable)ll.Var).MakeGhost();
                                    }
                                    else
                                    {
                                        Error(ErrorId.r_out_parameter_must_be_ghost, s, MutateCSharp.Schemata401.ReplaceStringConstant_5(129L, "actual out-parameter{0} is required to be a ghost variable"), MutateCSharp.Schemata401.ReplaceBinExprOp_14(134L, s.Lhs.Count, MutateCSharp.Schemata401.ReplaceNumericConstant_12(130L, 1)) ? "" : MutateCSharp.Schemata401.ReplaceStringConstant_5(139L, " ") + j);
                                    }
                                }
                            }
                            else if (resolvedLhs is MemberSelectExpr)
                            {
                                var ll = (MemberSelectExpr)resolvedLhs;
                                if (!ll.Member.IsGhost)
                                {
                                    Error(ErrorId.r_out_parameter_must_be_ghost_field, s, MutateCSharp.Schemata401.ReplaceStringConstant_5(140L, "actual out-parameter{0} is required to be a ghost field"), MutateCSharp.Schemata401.ReplaceBinExprOp_14(145L, s.Lhs.Count, MutateCSharp.Schemata401.ReplaceNumericConstant_12(141L, 1)) ? "" : MutateCSharp.Schemata401.ReplaceStringConstant_5(150L, " ") + j);
                                }
                            }
                            else
                            {
                                // this is an array update, and arrays are always non-ghost
                                Error(ErrorId.r_out_parameter_must_be_ghost, s, MutateCSharp.Schemata401.ReplaceStringConstant_5(151L, "actual out-parameter{0} is required to be a ghost variable"), MutateCSharp.Schemata401.ReplaceBinExprOp_14(156L, s.Lhs.Count, MutateCSharp.Schemata401.ReplaceNumericConstant_12(152L, 1)) ? "" : MutateCSharp.Schemata401.ReplaceStringConstant_5(161L, " ") + j);
                            }
                        }

                        MutateCSharp.Schemata401.ReplacePostfixUnaryExprOp_13(162L, ref j);
                    }
                }

            }
            else if (stmt is BlockStmt)
            {
                var s = (BlockStmt)stmt;
                s.IsGhost = mustBeErasable;  // set .IsGhost before descending into substatements (since substatements may do a 'break' out of this block)
                if (s is DividedBlockStmt ds)
                {
                    var giv = new GhostInterestVisitor(this.codeContext, this.resolver, this.reporter, MutateCSharp.Schemata401.ReplaceBooleanConstant_1(163L, true), allowAssumptionVariables);
                    ds.BodyInit.ForEach(ss => giv.Visit(ss, mustBeErasable, proofContext));
                    ds.BodyProper.ForEach(ss => Visit(ss, mustBeErasable, proofContext));
                }
                else
                {
                    s.Body.ForEach(ss => Visit(ss, mustBeErasable, proofContext));
                }
                s.IsGhost = MutateCSharp.Schemata401.ReplaceBinExprOp_0(164L, () => s.IsGhost, () => s.Body.All(ss => ss.IsGhost));  // mark the block statement as ghost if all its substatements are ghost

            }
            else if (stmt is IfStmt)
            {
                var s = (IfStmt)stmt;
                s.IsGhost = MutateCSharp.Schemata401.ReplaceBinExprOp_0(177L, () => mustBeErasable, () => (MutateCSharp.Schemata401.ReplaceBinExprOp_4(171L, () => MutateCSharp.Schemata401.ReplaceBinExprOp_15(170L, s.Guard, null), () => ExpressionTester.UsesSpecFeatures(s.Guard))));
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(183L, () => !mustBeErasable, () => s.IsGhost))
                {
                    reporter.Info(MessageSource.Resolver, s.Tok, MutateCSharp.Schemata401.ReplaceStringConstant_5(189L, "ghost if"));
                }
                Visit(s.Thn, s.IsGhost, proofContext);
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_16(190L, s.Els, null))
                {
                    Visit(s.Els, s.IsGhost, proofContext);
                }
                // if both branches were all ghost, then we can mark the enclosing statement as ghost as well
                s.IsGhost = MutateCSharp.Schemata401.ReplaceBinExprOp_0(204L, () => s.IsGhost, () => (MutateCSharp.Schemata401.ReplaceBinExprOp_4(198L, () => s.Thn.IsGhost, () => (MutateCSharp.Schemata401.ReplaceBinExprOp_0(192L, () => MutateCSharp.Schemata401.ReplaceBinExprOp_17(191L, s.Els, null), () => s.Els.IsGhost)))));
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(211L, () => !s.IsGhost, () => MutateCSharp.Schemata401.ReplaceBinExprOp_15(210L, s.Guard, null)))
                {
                    // If there were features in the guard that are treated differently in ghost and non-ghost
                    // contexts, make sure they get treated for non-ghost use.
                    ExpressionTester.CheckIsCompilable(resolver, reporter, s.Guard, codeContext);
                }

            }
            else if (stmt is AlternativeStmt)
            {
                var s = (AlternativeStmt)stmt;
                s.IsGhost = MutateCSharp.Schemata401.ReplaceBinExprOp_0(217L, () => mustBeErasable, () => s.Alternatives.Exists(alt => ExpressionTester.UsesSpecFeatures(alt.Guard)));
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(223L, () => !mustBeErasable, () => s.IsGhost))
                {
                    reporter.Info(MessageSource.Resolver, s.Tok, MutateCSharp.Schemata401.ReplaceStringConstant_5(229L, "ghost if"));
                }
                s.Alternatives.ForEach(alt => alt.Body.ForEach(ss => Visit(ss, s.IsGhost, proofContext)));
                s.IsGhost = MutateCSharp.Schemata401.ReplaceBinExprOp_0(230L, () => s.IsGhost, () => s.Alternatives.All(alt => alt.Body.All(ss => ss.IsGhost)));
                if (!s.IsGhost)
                {
                    // If there were features in the guards that are treated differently in ghost and non-ghost
                    // contexts, make sure they get treated for non-ghost use.
                    foreach (var alt in s.Alternatives)
                    {
                        ExpressionTester.CheckIsCompilable(resolver, reporter, alt.Guard, codeContext);
                    }
                }

            }
            else if (stmt is WhileStmt)
            {
                var s = (WhileStmt)stmt;
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(252L, () => MutateCSharp.Schemata401.ReplaceBinExprOp_4(237L, () => proofContext != null, () => MutateCSharp.Schemata401.ReplaceBinExprOp_18(236L, s.Mod.Expressions, null)), () => MutateCSharp.Schemata401.ReplaceBinExprOp_19(247L, s.Mod.Expressions.Count, MutateCSharp.Schemata401.ReplaceNumericConstant_12(243L, 0))))
                {
                    Error(ErrorId.r_loop_may_not_use_modifies, s.Mod.Expressions[MutateCSharp.Schemata401.ReplaceNumericConstant_12(258L, 0)].tok, $"a loop in {proofContext} is not allowed to use 'modifies' clauses");
                }

                s.IsGhost = MutateCSharp.Schemata401.ReplaceBinExprOp_0(269L, () => mustBeErasable, () => (MutateCSharp.Schemata401.ReplaceBinExprOp_4(263L, () => MutateCSharp.Schemata401.ReplaceBinExprOp_15(262L, s.Guard, null), () => ExpressionTester.UsesSpecFeatures(s.Guard))));
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(275L, () => !mustBeErasable, () => s.IsGhost))
                {
                    reporter.Info(MessageSource.Resolver, s.Tok, MutateCSharp.Schemata401.ReplaceStringConstant_5(281L, "ghost while"));
                }
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(282L, () => s.IsGhost, () => s.Decreases.Expressions.Exists(e => e is WildcardExpr)))
                {
                    Error(ErrorId.r_decreases_forbidden_on_ghost_loops, s, MutateCSharp.Schemata401.ReplaceStringConstant_5(288L, "'decreases *' is not allowed on ghost loops"));
                }
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(290L, () => s.IsGhost, () => MutateCSharp.Schemata401.ReplaceBinExprOp_18(289L, s.Mod.Expressions, null)))
                {
                    s.Mod.Expressions.ForEach(resolver.DisallowNonGhostFieldSpecifiers);
                }
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_3(296L, s.Body, null))
                {
                    Visit(s.Body, s.IsGhost, proofContext);
                    if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(297L, () => s.Body.IsGhost, () => !s.Decreases.Expressions.Exists(e => e is WildcardExpr)))
                    {
                        s.IsGhost = MutateCSharp.Schemata401.ReplaceBooleanConstant_1(303L, true);
                    }
                }
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(305L, () => !s.IsGhost, () => MutateCSharp.Schemata401.ReplaceBinExprOp_15(304L, s.Guard, null)))
                {
                    // If there were features in the guard that are treated differently in ghost and non-ghost
                    // contexts, make sure they get treated for non-ghost use.
                    ExpressionTester.CheckIsCompilable(resolver, reporter, s.Guard, codeContext);
                }

            }
            else if (stmt is AlternativeLoopStmt)
            {
                var s = (AlternativeLoopStmt)stmt;
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(327L, () => MutateCSharp.Schemata401.ReplaceBinExprOp_4(312L, () => proofContext != null, () => MutateCSharp.Schemata401.ReplaceBinExprOp_18(311L, s.Mod.Expressions, null)), () => MutateCSharp.Schemata401.ReplaceBinExprOp_19(322L, s.Mod.Expressions.Count, MutateCSharp.Schemata401.ReplaceNumericConstant_12(318L, 0))))
                {
                    Error(ErrorId.r_loop_in_proof_may_not_use_modifies, s.Mod.Expressions[MutateCSharp.Schemata401.ReplaceNumericConstant_12(333L, 0)].tok, $"a loop in {proofContext} is not allowed to use 'modifies' clauses");
                }

                s.IsGhost = MutateCSharp.Schemata401.ReplaceBinExprOp_0(337L, () => mustBeErasable, () => s.Alternatives.Exists(alt => ExpressionTester.UsesSpecFeatures(alt.Guard)));
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(343L, () => !mustBeErasable, () => s.IsGhost))
                {
                    reporter.Info(MessageSource.Resolver, s.Tok, MutateCSharp.Schemata401.ReplaceStringConstant_5(349L, "ghost while"));
                }
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(350L, () => s.IsGhost, () => s.Decreases.Expressions.Exists(e => e is WildcardExpr)))
                {
                    Error(ErrorId.r_decreases_forbidden_on_ghost_loops, s, MutateCSharp.Schemata401.ReplaceStringConstant_5(356L, "'decreases *' is not allowed on ghost loops"));
                }
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(358L, () => s.IsGhost, () => MutateCSharp.Schemata401.ReplaceBinExprOp_18(357L, s.Mod.Expressions, null)))
                {
                    s.Mod.Expressions.ForEach(resolver.DisallowNonGhostFieldSpecifiers);
                }
                s.Alternatives.ForEach(alt => alt.Body.ForEach(ss => Visit(ss, s.IsGhost, proofContext)));
                s.IsGhost = MutateCSharp.Schemata401.ReplaceBinExprOp_0(370L, () => s.IsGhost, () => (MutateCSharp.Schemata401.ReplaceBinExprOp_4(364L, () => !s.Decreases.Expressions.Exists(e => e is WildcardExpr), () => s.Alternatives.All(alt => alt.Body.All(ss => ss.IsGhost)))));
                if (!s.IsGhost)
                {
                    // If there were features in the guards that are treated differently in ghost and non-ghost
                    // contexts, make sure they get treated for non-ghost use.
                    foreach (var alt in s.Alternatives)
                    {
                        ExpressionTester.CheckIsCompilable(resolver, reporter, alt.Guard, codeContext);
                    }
                }

            }
            else if (stmt is ForLoopStmt)
            {
                var s = (ForLoopStmt)stmt;
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(392L, () => MutateCSharp.Schemata401.ReplaceBinExprOp_4(377L, () => proofContext != null, () => MutateCSharp.Schemata401.ReplaceBinExprOp_18(376L, s.Mod.Expressions, null)), () => MutateCSharp.Schemata401.ReplaceBinExprOp_19(387L, s.Mod.Expressions.Count, MutateCSharp.Schemata401.ReplaceNumericConstant_12(383L, 0))))
                {
                    Error(ErrorId.r_loop_in_proof_may_not_use_modifies, s.Mod.Expressions[MutateCSharp.Schemata401.ReplaceNumericConstant_12(398L, 0)].tok, $"a loop in {proofContext} is not allowed to use 'modifies' clauses");
                }

                s.IsGhost = MutateCSharp.Schemata401.ReplaceBinExprOp_0(415L, () => MutateCSharp.Schemata401.ReplaceBinExprOp_0(402L, () => mustBeErasable, () => ExpressionTester.UsesSpecFeatures(s.Start)), () => (MutateCSharp.Schemata401.ReplaceBinExprOp_4(409L, () => MutateCSharp.Schemata401.ReplaceBinExprOp_15(408L, s.End, null), () => ExpressionTester.UsesSpecFeatures(s.End))));
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(421L, () => !mustBeErasable, () => s.IsGhost))
                {
                    reporter.Info(MessageSource.Resolver, s.Tok, MutateCSharp.Schemata401.ReplaceStringConstant_5(427L, "ghost for-loop"));
                }
                if (s.IsGhost)
                {
                    if (s.Decreases.Expressions.Exists(e => e is WildcardExpr))
                    {
                        Error(ErrorId.r_decreases_forbidden_on_ghost_loops, s, MutateCSharp.Schemata401.ReplaceStringConstant_5(428L, "'decreases *' is not allowed on ghost loops"));
                    }
                    else if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(439L, () => MutateCSharp.Schemata401.ReplaceBinExprOp_20(429L, s.End, null), () => MutateCSharp.Schemata401.ReplaceBinExprOp_14(434L, s.Decreases.Expressions.Count, MutateCSharp.Schemata401.ReplaceNumericConstant_12(430L, 0))))
                    {
                        Error(ErrorId.r_ghost_loop_must_terminate, s, MutateCSharp.Schemata401.ReplaceStringConstant_5(445L, "a ghost loop must be terminating; make the end-expression specific or add a 'decreases' clause"));
                    }
                }
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(447L, () => s.IsGhost, () => MutateCSharp.Schemata401.ReplaceBinExprOp_18(446L, s.Mod.Expressions, null)))
                {
                    s.Mod.Expressions.ForEach(resolver.DisallowNonGhostFieldSpecifiers);
                }
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_3(453L, s.Body, null))
                {
                    Visit(s.Body, s.IsGhost, proofContext);
                    if (s.Body.IsGhost)
                    {
                        s.IsGhost = MutateCSharp.Schemata401.ReplaceBooleanConstant_1(454L, true);
                    }
                }
                if (!s.IsGhost)
                {
                    // If there were features in the bounds that are treated differently in ghost and non-ghost
                    // contexts, make sure they get treated for non-ghost use.
                    ExpressionTester.CheckIsCompilable(resolver, reporter, s.Start, codeContext);
                    if (MutateCSharp.Schemata401.ReplaceBinExprOp_15(455L, s.End, null))
                    {
                        ExpressionTester.CheckIsCompilable(resolver, reporter, s.End, codeContext);
                    }
                }

            }
            else if (stmt is ForallStmt)
            {
                var s = (ForallStmt)stmt;
                s.IsGhost = MutateCSharp.Schemata401.ReplaceBinExprOp_0(463L, () => MutateCSharp.Schemata401.ReplaceBinExprOp_0(457L, () => mustBeErasable, () => MutateCSharp.Schemata401.ReplaceBinExprOp_21(456L, s.Kind, ForallStmt.BodyKind.Assign)), () => ExpressionTester.UsesSpecFeatures(s.Range));
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(470L, () => proofContext != null, () => MutateCSharp.Schemata401.ReplaceBinExprOp_22(469L, s.Kind, ForallStmt.BodyKind.Assign)))
                {
                    Error(ErrorId.r_no_aggregate_heap_update_in_proof, s, $"{proofContext} is not allowed to perform an aggregate heap update");
                }
                else if (MutateCSharp.Schemata401.ReplaceBinExprOp_16(476L, s.Body, null))
                {
                    Visit(s.Body, s.IsGhost, MutateCSharp.Schemata401.ReplaceBinExprOp_22(477L, s.Kind, ForallStmt.BodyKind.Assign) ? proofContext : MutateCSharp.Schemata401.ReplaceStringConstant_5(478L, "a forall statement"));
                }
                s.IsGhost = MutateCSharp.Schemata401.ReplaceBinExprOp_0(486L, () => MutateCSharp.Schemata401.ReplaceBinExprOp_0(480L, () => s.IsGhost, () => MutateCSharp.Schemata401.ReplaceBinExprOp_17(479L, s.Body, null)), () => s.Body.IsGhost);

                if (!s.IsGhost)
                {
                    // Since we've determined this is a non-ghost forall statement, we now check that the bound variables have compilable bounds.
                    var uncompilableBoundVars = s.UncompilableBoundVars();
                    if (MutateCSharp.Schemata401.ReplaceBinExprOp_19(496L, uncompilableBoundVars.Count, MutateCSharp.Schemata401.ReplaceNumericConstant_12(492L, 0)))
                    {
                        foreach (var bv in uncompilableBoundVars)
                        {
                            Error(ErrorId.r_unknown_bounds_for_forall, s, MutateCSharp.Schemata401.ReplaceStringConstant_5(501L, "forall statements in non-ghost contexts must be compilable, but Dafny's heuristics can't figure out how to produce or compile a bounded set of values for '{0}'"), bv.Name);
                        }
                    }

                    // If there were features in the range that are treated differently in ghost and non-ghost
                    // contexts, make sure they get treated for non-ghost use.
                    ExpressionTester.CheckIsCompilable(resolver, reporter, s.Range, codeContext);
                }

            }
            else if (stmt is ModifyStmt)
            {
                var s = (ModifyStmt)stmt;
                if (proofContext != null)
                {
                    Error(ErrorId.r_modify_forbidden_in_proof, stmt, $"a modify statement is not allowed in {proofContext}");
                }

                s.IsGhost = mustBeErasable;
                if (s.IsGhost)
                {
                    s.Mod.Expressions.ForEach(resolver.DisallowNonGhostFieldSpecifiers);
                }
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_3(502L, s.Body, null))
                {
                    Visit(s.Body, mustBeErasable, proofContext);
                }

            }
            else if (stmt is CalcStmt)
            {
                var s = (CalcStmt)stmt;
                s.IsGhost = MutateCSharp.Schemata401.ReplaceBooleanConstant_1(503L, true);
                foreach (var h in s.Hints)
                {
                    Visit(h, MutateCSharp.Schemata401.ReplaceBooleanConstant_1(504L, true), MutateCSharp.Schemata401.ReplaceStringConstant_5(505L, "a hint"));
                }

            }
            else if (stmt is NestedMatchStmt nestedMatchStmt)
            {
                var hasGhostPattern = nestedMatchStmt.Cases.
                  SelectMany(caze => caze.Pat.DescendantsAndSelf)
                  .OfType<IdPattern>().Any(idPattern => MutateCSharp.Schemata401.ReplaceBinExprOp_4(507L, () => MutateCSharp.Schemata401.ReplaceBinExprOp_23(506L, idPattern.Ctor, null), () => idPattern.Ctor.IsGhost));
                nestedMatchStmt.IsGhost = MutateCSharp.Schemata401.ReplaceBinExprOp_0(519L, () => MutateCSharp.Schemata401.ReplaceBinExprOp_0(513L, () => mustBeErasable, () => ExpressionTester.UsesSpecFeatures(nestedMatchStmt.Source)), () => hasGhostPattern);

                foreach (var kase in nestedMatchStmt.Cases)
                {
                    ExpressionTester.MakeGhostAsNeeded(kase.Pat, nestedMatchStmt.IsGhost);
                }

                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(525L, () => !mustBeErasable, () => nestedMatchStmt.IsGhost))
                {
                    reporter.Info(MessageSource.Resolver, nestedMatchStmt.Tok, MutateCSharp.Schemata401.ReplaceStringConstant_5(531L, "ghost match"));
                }
                nestedMatchStmt.Cases.ForEach(kase => kase.Body.ForEach(ss => Visit(ss, nestedMatchStmt.IsGhost, proofContext)));
                nestedMatchStmt.IsGhost = MutateCSharp.Schemata401.ReplaceBinExprOp_0(532L, () => nestedMatchStmt.IsGhost, () => nestedMatchStmt.Cases.All(kase => kase.Body.All(ss => ss.IsGhost)));
                if (!nestedMatchStmt.IsGhost)
                {
                    // If there were features in the source expression that are treated differently in ghost and non-ghost
                    // contexts, make sure they get treated for non-ghost use.
                    ExpressionTester.CheckIsCompilable(resolver, reporter, nestedMatchStmt.Source, codeContext);
                }
            }
            else if (stmt is MatchStmt)
            {
                var s = (MatchStmt)stmt;
                s.IsGhost = MutateCSharp.Schemata401.ReplaceBinExprOp_0(545L, () => MutateCSharp.Schemata401.ReplaceBinExprOp_0(538L, () => mustBeErasable, () => ExpressionTester.UsesSpecFeatures(s.Source)), () => MutateCSharp.Schemata401.ReplaceBinExprOp_24(544L, ExpressionTester.FirstCaseThatDependsOnGhostCtor(s.Cases), null));
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(551L, () => !mustBeErasable, () => s.IsGhost))
                {
                    reporter.Info(MessageSource.Resolver, s.Tok, MutateCSharp.Schemata401.ReplaceStringConstant_5(557L, "ghost match"));
                }
                s.Cases.ForEach(kase => kase.Body.ForEach(ss => Visit(ss, s.IsGhost, proofContext)));
                s.IsGhost = MutateCSharp.Schemata401.ReplaceBinExprOp_0(558L, () => s.IsGhost, () => s.Cases.All(kase => kase.Body.All(ss => ss.IsGhost)));
                if (!s.IsGhost)
                {
                    // If there were features in the source expression that are treated differently in ghost and non-ghost
                    // contexts, make sure they get treated for non-ghost use.
                    ExpressionTester.CheckIsCompilable(resolver, reporter, s.Source, codeContext);
                }

            }
            else if (stmt is SkeletonStatement)
            {
                var s = (SkeletonStatement)stmt;
                s.IsGhost = mustBeErasable;
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_16(564L, s.S, null))
                {
                    Visit(s.S, mustBeErasable, proofContext);
                    s.IsGhost = MutateCSharp.Schemata401.ReplaceBinExprOp_0(565L, () => s.IsGhost, () => s.S.IsGhost);
                }

            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();
            }
        }

        private void CheckAssignStmt(AssignStmt s, bool mustBeErasable, [CanBeNull] string proofContext)
        {
            Contract.Requires(s != null);
            Contract.Requires(mustBeErasable || proofContext == null);

            var lhs = s.Lhs.Resolved;

            // Make an auto-ghost variable a ghost if the RHS is a ghost
            if (lhs.Resolved is AutoGhostIdentifierExpr autoGhostIdExpr)
            {
                if (s.Rhs is ExprRhs eRhs && ExpressionTester.UsesSpecFeatures(eRhs.Expr))
                {
                    autoGhostIdExpr.Var.MakeGhost();
                }
                else if (s.Rhs is TypeRhs tRhs)
                {
                    if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(572L, () => MutateCSharp.Schemata401.ReplaceBinExprOp_25(571L, tRhs.InitCall, null), () => tRhs.InitCall.Method.IsGhost))
                    {
                        autoGhostIdExpr.Var.MakeGhost();
                    }
                    else if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(579L, () => MutateCSharp.Schemata401.ReplaceBinExprOp_26(578L, tRhs.ArrayDimensions, null), () => tRhs.ArrayDimensions.Exists(ExpressionTester.UsesSpecFeatures)))
                    {
                        autoGhostIdExpr.Var.MakeGhost();
                    }
                    else if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(586L, () => MutateCSharp.Schemata401.ReplaceBinExprOp_15(585L, tRhs.ElementInit, null), () => ExpressionTester.UsesSpecFeatures(tRhs.ElementInit)))
                    {
                        autoGhostIdExpr.Var.MakeGhost();
                    }
                    else if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(593L, () => MutateCSharp.Schemata401.ReplaceBinExprOp_26(592L, tRhs.InitDisplay, null), () => tRhs.InitDisplay.Any(ExpressionTester.UsesSpecFeatures)))
                    {
                        autoGhostIdExpr.Var.MakeGhost();
                    }
                }
            }

            if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(599L, () => proofContext != null, () => s.Rhs is TypeRhs))
            {
                Error(ErrorId.r_new_forbidden_in_proof, s.Rhs.Tok, $"{proofContext} is not allowed to use 'new'");
            }

            var gk = AssignStmt.LhsIsToGhost_Which(lhs);
            if (MutateCSharp.Schemata401.ReplaceBinExprOp_27(605L, gk, AssignStmt.NonGhostKind.IsGhost))
            {
                s.IsGhost = MutateCSharp.Schemata401.ReplaceBooleanConstant_1(606L, true);
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(607L, () => proofContext != null, () => !(lhs is IdentifierExpr)))
                {
                    Error(ErrorId.r_no_heap_update_in_proof, lhs.tok, $"{proofContext} is not allowed to make heap updates");
                }
                if (s.Rhs is TypeRhs tRhs && MutateCSharp.Schemata401.ReplaceBinExprOp_25(613L, tRhs.InitCall, null))
                {
                    Visit(tRhs.InitCall, MutateCSharp.Schemata401.ReplaceBooleanConstant_1(614L, true), proofContext);
                }
            }
            else if (MutateCSharp.Schemata401.ReplaceBinExprOp_4(616L, () => MutateCSharp.Schemata401.ReplaceBinExprOp_27(615L, gk, AssignStmt.NonGhostKind.Variable), () => codeContext.IsGhost))
            {
                // cool
            }
            else if (mustBeErasable)
            {
                if (inConstructorInitializationPhase && codeContext is Constructor && codeContext.IsGhost && lhs is MemberSelectExpr mse &&
                    mse.Obj.Resolved is ThisExpr)
                {
                    // in this first division (before "new;") of a ghost constructor, allow assignment to non-ghost field of the object being constructed
                }
                else
                {
                    string reason;
                    if (codeContext.IsGhost)
                    {
                        reason = string.Format(MutateCSharp.Schemata401.ReplaceStringConstant_5(622L, "this is a ghost {0}"), codeContext is MemberDecl member ? member.WhatKind : MutateCSharp.Schemata401.ReplaceStringConstant_5(623L, "context"));
                    }
                    else
                    {
                        reason = MutateCSharp.Schemata401.ReplaceStringConstant_5(624L, "the statement is in a ghost context; e.g., it may be guarded by a specification-only expression");
                    }
                    Error(ErrorId.r_assignment_forbidden_in_context, s, $"assignment to {AssignStmt.NonGhostKind_To_String(gk)} is not allowed in this context, because {reason}");
                }
            }
            else
            {
                if (MutateCSharp.Schemata401.ReplaceBinExprOp_27(625L, gk, AssignStmt.NonGhostKind.Field))
                {
                    var mse = (MemberSelectExpr)lhs;
                    ExpressionTester.CheckIsCompilable(resolver, reporter, mse.Obj, codeContext);
                }
                else if (MutateCSharp.Schemata401.ReplaceBinExprOp_27(626L, gk, AssignStmt.NonGhostKind.ArrayElement))
                {
                    ExpressionTester.CheckIsCompilable(resolver, reporter, lhs, codeContext);
                }

                if (s.Rhs is ExprRhs)
                {
                    var rhs = (ExprRhs)s.Rhs;
                    if (!AssignStmt.LhsIsToGhost(lhs))
                    {
                        ExpressionTester.CheckIsCompilable(resolver, reporter, rhs.Expr, codeContext);
                    }
                }
                else if (s.Rhs is HavocRhs)
                {
                    // cool
                }
                else
                {
                    var rhs = (TypeRhs)s.Rhs;
                    if (MutateCSharp.Schemata401.ReplaceBinExprOp_26(627L, rhs.ArrayDimensions, null))
                    {
                        rhs.ArrayDimensions.ForEach(ee => ExpressionTester.CheckIsCompilable(resolver, reporter, ee, codeContext));
                        if (MutateCSharp.Schemata401.ReplaceBinExprOp_15(628L, rhs.ElementInit, null))
                        {
                            ExpressionTester.CheckIsCompilable(resolver, reporter, rhs.ElementInit, codeContext);
                        }
                        if (MutateCSharp.Schemata401.ReplaceBinExprOp_26(629L, rhs.InitDisplay, null))
                        {
                            rhs.InitDisplay.ForEach(ee => ExpressionTester.CheckIsCompilable(resolver, reporter, ee, codeContext));
                        }
                    }
                    if (MutateCSharp.Schemata401.ReplaceBinExprOp_25(630L, rhs.InitCall, null))
                    {
                        var callee = rhs.InitCall.Method;
                        if (callee.IsGhost)
                        {
                            Error(ErrorId.r_assignment_to_ghost_constructor_only_in_ghost, rhs.InitCall, MutateCSharp.Schemata401.ReplaceStringConstant_5(631L, "the result of a ghost constructor can only be assigned to a ghost variable"));
                        }
                        for (var i = MutateCSharp.Schemata401.ReplaceNumericConstant_12(632L, 0); MutateCSharp.Schemata401.ReplaceBinExprOp_28(636L, i, rhs.InitCall.Args.Count); MutateCSharp.Schemata401.ReplacePostfixUnaryExprOp_13(641L, ref i))
                        {
                            if (!callee.Ins[i].IsGhost)
                            {
                                ExpressionTester.CheckIsCompilable(resolver, reporter, rhs.InitCall.Args[i], codeContext);
                            }
                        }
                    }
                }
            }
        }
    }
}
