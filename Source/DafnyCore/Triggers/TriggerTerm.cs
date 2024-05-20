using System.Collections.Generic;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata482
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT482");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.BoundVar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.Triggers.TriggerTerm argument1, Microsoft.Dafny.Triggers.TriggerTerm argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny.Triggers
{
    public class TriggerTerm
    {
        internal Expression Expr { get; init; }
        internal Expression OriginalExpr { get; set; }
        internal ISet<IVariable> Variables { get; init; }

        internal IEnumerable<BoundVar> BoundVars => Variables.Select(v => v as BoundVar).Where(v => MutateCSharp.Schemata482.ReplaceBinExprOp_0(1L, v, null));

        public override string ToString()
        {
            return Printer.ExprToString(DafnyOptions.DefaultImmutableOptions, Expr);
            // NOTE: Using OriginalExpr here could cause some confusion:
            // for example, {a !in b} is a binary expression, yielding
            // trigger {a in b}. Saying the trigger is a !in b would be
            // rather misleading.
        }

        public enum TermComparison
        {
            SameStrength = 0, Stronger = 1, NotStronger = -1
        }

        internal TermComparison CompareTo(TriggerTerm other)
        {
            if (MutateCSharp.Schemata482.ReplaceBinExprOp_1(2L, this, other))
            {
                return TermComparison.SameStrength;
            }
            else if (Expr.AllSubExpressions(MutateCSharp.Schemata482.ReplaceBooleanConstant_2(3L, true), MutateCSharp.Schemata482.ReplaceBooleanConstant_2(4L, true)).Any(other.Expr.ExpressionEq))
            {
                return TermComparison.Stronger;
            }
            else
            {
                return TermComparison.NotStronger;
            }

            return default;
        }

        internal static bool Eq(TriggerTerm t1, TriggerTerm t2)
        {
            return t1.Expr.ExpressionEq(t2.Expr);
        }
    }
}