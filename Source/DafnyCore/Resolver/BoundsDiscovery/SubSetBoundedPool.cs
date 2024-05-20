namespace MutateCSharp
{
    internal class Schemata385
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT385");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceNumericConstant_0(long mutantId, int argument1)
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
//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

namespace Microsoft.Dafny
{
    public class SubSetBoundedPool : BoundedPool
    {
        public readonly Expression UpperBound;
        public readonly bool IsFiniteCollection;
        public SubSetBoundedPool(Expression set, bool isFiniteCollection)
        {
            UpperBound = set;
            IsFiniteCollection = isFiniteCollection;
        }
        public override PoolVirtues Virtues
        {
            get
            {
                if (IsFiniteCollection)
                {
                    return PoolVirtues.Finite | PoolVirtues.Enumerable | PoolVirtues.IndependentOfAlloc | PoolVirtues.IndependentOfAlloc_or_ExplicitAlloc;
                }
                else
                {
                    // it's still enumerable, because at run time, all sets are finite after all
                    return PoolVirtues.Enumerable | PoolVirtues.IndependentOfAlloc | PoolVirtues.IndependentOfAlloc_or_ExplicitAlloc;
                }

                return default;
            }
        }

        public override int Preference() => MutateCSharp.Schemata385.ReplaceNumericConstant_0(1L, 3);
        public override BoundedPool Clone(Cloner cloner)
        {
            return new SubSetBoundedPool(cloner.CloneExpr(UpperBound), IsFiniteCollection);
        }
    }
}
