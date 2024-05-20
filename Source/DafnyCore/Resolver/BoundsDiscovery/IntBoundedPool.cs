//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata378
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT378");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
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

        internal static int ReplaceNumericConstant_2(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public class IntBoundedPool : BoundedPool
    {
        public readonly Expression LowerBound;
        public readonly Expression UpperBound;
        public IntBoundedPool(Expression lowerBound, Expression upperBound)
        {
            Contract.Requires(lowerBound != null || upperBound != null);
            LowerBound = lowerBound;
            UpperBound = upperBound;
        }
        public override PoolVirtues Virtues
        {
            get
            {
                if (MutateCSharp.Schemata378.ReplaceBinExprOp_1(3L, () => MutateCSharp.Schemata378.ReplaceBinExprOp_0(1L, LowerBound, null), () => MutateCSharp.Schemata378.ReplaceBinExprOp_0(2L, UpperBound, null)))
                {
                    return PoolVirtues.Finite | PoolVirtues.Enumerable | PoolVirtues.IndependentOfAlloc | PoolVirtues.IndependentOfAlloc_or_ExplicitAlloc;
                }
                else
                {
                    return PoolVirtues.Enumerable | PoolVirtues.IndependentOfAlloc | PoolVirtues.IndependentOfAlloc_or_ExplicitAlloc;
                }

                return default;
            }
        }

        public override int Preference() => MutateCSharp.Schemata378.ReplaceBinExprOp_1(11L, () => MutateCSharp.Schemata378.ReplaceBinExprOp_0(9L, LowerBound, null), () => MutateCSharp.Schemata378.ReplaceBinExprOp_0(10L, UpperBound, null)) ? MutateCSharp.Schemata378.ReplaceNumericConstant_2(17L, 5) : MutateCSharp.Schemata378.ReplaceNumericConstant_2(21L, 4);

        public override BoundedPool Clone(Cloner cloner)
        {
            return new IntBoundedPool(cloner.CloneExpr(LowerBound), cloner.CloneExpr(UpperBound));
        }
    }
}
