namespace MutateCSharp
{
    internal class Schemata389
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT389");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_4(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static string ReplaceStringConstant_2(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
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

    }
}
//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

namespace Microsoft.Dafny
{
    public
/// <summary>
/// This checker ensures that if the set of values or the set of items
/// of a map is used, then its range type supports equality.
/// </summary>
class CheckMapRangeSupportsEquality : ASTVisitor<IASTVisitorContext>
    {
        private readonly ErrorReporter reporter;

        public CheckMapRangeSupportsEquality(ErrorReporter reporter)
        {
            this.reporter = reporter;
        }

        public override IASTVisitorContext GetContext(IASTVisitorContext astVisitorContext, bool inFunctionPostcondition)
        {
            return astVisitorContext;
        }

        protected override bool VisitOneExpression(Expression expr, IASTVisitorContext context)
        {

            if (context is MemberDecl)
            {
                var member = (MemberDecl)context;
                if (member.IsGhost)
                {
                    return base.VisitOneExpression(expr, context);
                }
            }

            if (expr is ExprDotName)
            {
                var e = (ExprDotName)expr;
                // Condition 1: the left-hand side is not a module and has a type
                // Condition 2: the left-hand side is a map
                // Condition 3: the expression produces a set that contains values from the range
                if (MutateCSharp.Schemata389.ReplaceBinExprOp_1(18L, () => MutateCSharp.Schemata389.ReplaceBinExprOp_1(2L, () => MutateCSharp.Schemata389.ReplaceBinExprOp_0(1L, e.Lhs.Type, null), () => e.Lhs.Type.IsMapType), () => (MutateCSharp.Schemata389.ReplaceBinExprOp_4(12L, () => MutateCSharp.Schemata389.ReplaceBinExprOp_3(9L, e.SuffixName, MutateCSharp.Schemata389.ReplaceStringConstant_2(8L, "Values")), () => MutateCSharp.Schemata389.ReplaceBinExprOp_3(11L, e.SuffixName, MutateCSharp.Schemata389.ReplaceStringConstant_2(10L, "Items"))))))
                {
                    // The type of the range must support equality
                    if (!e.Lhs.Type.AsMapType.Range.SupportsEquality)
                    {
                        reporter.Error(MessageSource.Resolver, expr,
                          $"Cannot compute the set of {e.SuffixName} because the type of the range of the map ({e.Lhs.Type.AsMapType.Range}) does not support equality.");
                    }
                }
            }
            return base.VisitOneExpression(expr, context);
        }
    }
}