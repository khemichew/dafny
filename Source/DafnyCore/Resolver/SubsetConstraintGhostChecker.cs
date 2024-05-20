using JetBrains.Annotations;
namespace MutateCSharp
{
    internal class Schemata437
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT437");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceNumericConstant_3(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.BlockStmt argument1, Microsoft.Dafny.BlockStmt argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.ErrorLevel argument1, Microsoft.Dafny.ErrorLevel argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_8(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{

    /// <summary>
    /// Looks for every non-ghost comprehensions, and if they are using a subset type,
    /// check that the subset constraint is compilable. If it is not compilable, raises an error.
    /// </summary>
    public class SubsetConstraintGhostChecker : ProgramTraverser
    {
        public class FirstErrorCollector : ErrorReporter
        {
            public string FirstCollectedMessage = "";
            public IToken FirstCollectedToken = Token.NoToken;
            public bool Collected = MutateCSharp.Schemata437.ReplaceBooleanConstant_0(1L, false);

            public bool Message(MessageSource source, ErrorLevel level, IToken tok, string msg)
            {
                return Message(source, level, ErrorRegistry.NoneId, tok, msg);
            }

            protected override bool MessageCore(MessageSource source, ErrorLevel level, string errorId, IToken tok, string msg)
            {
                if (MutateCSharp.Schemata437.ReplaceBinExprOp_2(3L, () => !Collected, () => MutateCSharp.Schemata437.ReplaceBinExprOp_1(2L, level, ErrorLevel.Error)))
                {
                    FirstCollectedMessage = msg;
                    FirstCollectedToken = tok;
                    Collected = MutateCSharp.Schemata437.ReplaceBooleanConstant_0(9L, true);
                }
                return MutateCSharp.Schemata437.ReplaceBooleanConstant_0(10L, true);
            }

            public override int Count(ErrorLevel level)
            {
                return MutateCSharp.Schemata437.ReplaceBinExprOp_2(12L, () => MutateCSharp.Schemata437.ReplaceBinExprOp_1(11L, level, ErrorLevel.Error), () => Collected) ? MutateCSharp.Schemata437.ReplaceNumericConstant_3(18L, 1) : MutateCSharp.Schemata437.ReplaceNumericConstant_3(22L, 0);
            }

            public override int CountExceptVerifierAndCompiler(ErrorLevel level)
            {
                return Count(level);
            }

            public FirstErrorCollector(DafnyOptions options) : base(options)
            {
            }
        }

        public ErrorReporter reporter;

        public SubsetConstraintGhostChecker(ErrorReporter reporter)
        {
            this.reporter = reporter;
        }

        protected override ContinuationStatus OnEnter(Statement stmt, string field, object parent)
        {
            return MutateCSharp.Schemata437.ReplaceBinExprOp_2(27L, () => MutateCSharp.Schemata437.ReplaceBinExprOp_4(26L, stmt, null), () => stmt.IsGhost) ? skip : ok;
        }

        protected override ContinuationStatus OnEnter(MemberDecl memberDecl, string field, object parent)
        {
            // Includes functions and methods as well.
            // Ghost functions can have a compiled implementation.
            // We want to recurse only on the by method, not on the sub expressions of the function
            if (MutateCSharp.Schemata437.ReplaceBinExprOp_6(34L, () => MutateCSharp.Schemata437.ReplaceBinExprOp_5(33L, memberDecl, null), () => !memberDecl.IsGhost)) { return ok; }
            if (memberDecl is Function f)
            {
                if (MutateCSharp.Schemata437.ReplaceBinExprOp_2(42L, () => MutateCSharp.Schemata437.ReplaceBinExprOp_7(40L, f.ByMethodDecl, null), () => Traverse(f.ByMethodDecl, MutateCSharp.Schemata437.ReplaceStringConstant_8(41L, "ByMethodDecl"), f))) { return stop; }
                if (MutateCSharp.Schemata437.ReplaceBinExprOp_6(50L, () => MutateCSharp.Schemata437.ReplaceBinExprOp_9(48L, f.ByMethodDecl, null), () => MutateCSharp.Schemata437.ReplaceBinExprOp_10(49L, f.ByMethodDecl.Body, f.ByMethodBody)))
                {
                    if (MutateCSharp.Schemata437.ReplaceBinExprOp_2(58L, () => MutateCSharp.Schemata437.ReplaceBinExprOp_11(56L, f.ByMethodBody, null), () => Traverse(f.ByMethodBody, MutateCSharp.Schemata437.ReplaceStringConstant_8(57L, "ByMethodBody"), f))) { return stop; }
                }
            }
            return skip;
        }

        private bool IsFieldSpecification(string field, object parent)
        {
            return MutateCSharp.Schemata437.ReplaceBinExprOp_2(102L, () => MutateCSharp.Schemata437.ReplaceBinExprOp_2(64L, () => field != null, () => parent != null), () => (
        MutateCSharp.Schemata437.ReplaceBinExprOp_6(96L, () => MutateCSharp.Schemata437.ReplaceBinExprOp_6(84L, () => (MutateCSharp.Schemata437.ReplaceBinExprOp_2(72L, () => parent is Statement, () => MutateCSharp.Schemata437.ReplaceBinExprOp_12(71L, field, MutateCSharp.Schemata437.ReplaceStringConstant_8(70L, "SpecificationSubExpressions")))), () => (MutateCSharp.Schemata437.ReplaceBinExprOp_2(78L, () => parent is Function, () => (field is "Req.E" or "Reads.E" or "Ens.E" or "Decreases.Expressions")))), () => (MutateCSharp.Schemata437.ReplaceBinExprOp_2(90L, () => parent is Method, () => (field is "Req.E" or "Reads.E" or "Mod.E" or "Ens.E" or "Decreases.Expressions")))
        )));
        }

        public override bool Traverse(Expression expr, [CanBeNull] string field, [CanBeNull] object parent)
        {
            if (MutateCSharp.Schemata437.ReplaceBinExprOp_13(108L, expr, null))
            {
                return MutateCSharp.Schemata437.ReplaceBooleanConstant_0(109L, false);
            }
            if (IsFieldSpecification(field, parent))
            {
                return MutateCSharp.Schemata437.ReplaceBooleanConstant_0(110L, false);
            }
            // Since we skipped ghost code, the code has to be compiled here. 
            if (expr is not ComprehensionExpr e)
            {
                return base.Traverse(expr, field, parent);
            }

            if (e is QuantifierExpr or SetComprehension or MapComprehension)
            {
                foreach (var boundVar in e.BoundVars)
                {
                    if (boundVar.Type.NormalizeExpandKeepConstraints().AsRedirectingType is (SubsetTypeDecl or NewtypeDecl) and var declWithConstraints)
                    {
                        if (!declWithConstraints.ConstraintIsCompilable)
                        {

                            IToken finalToken = boundVar.tok;
                            if (MutateCSharp.Schemata437.ReplaceBinExprOp_2(121L, () => MutateCSharp.Schemata437.ReplaceBinExprOp_14(111L, declWithConstraints.Constraint, null), () => MutateCSharp.Schemata437.ReplaceBinExprOp_15(116L, declWithConstraints.Constraint.tok.line, MutateCSharp.Schemata437.ReplaceNumericConstant_3(112L, 0))))
                            {
                                var errorCollector = new FirstErrorCollector(reporter.Options);
                                ExpressionTester.CheckIsCompilable(null, errorCollector, declWithConstraints.Constraint,
                                  new CodeContextWrapper(declWithConstraints, MutateCSharp.Schemata437.ReplaceBooleanConstant_0(127L, true)));
                                if (errorCollector.Collected)
                                {
                                    finalToken = new NestedToken(finalToken, errorCollector.FirstCollectedToken,
                    MutateCSharp.Schemata437.ReplaceStringConstant_8(128L, "The constraint is not compilable because ") + errorCollector.FirstCollectedMessage
                                    );
                                }
                            }
                            this.reporter.Error(MessageSource.Resolver, finalToken,
                              $"{boundVar.Type} is a {declWithConstraints.WhatKind} and its constraint is not compilable, " +
                              $"hence it cannot yet be used as the type of a bound variable in {e.WhatKind}.");
                        }
                    }
                }
            }
            return base.Traverse(e, field, parent);
        }
    }
}
