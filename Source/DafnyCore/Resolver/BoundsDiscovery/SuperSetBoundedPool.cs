namespace MutateCSharp
{
    internal class Schemata386
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT386");
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
    public class SuperSetBoundedPool : BoundedPool
    {
        public readonly Expression LowerBound;
        public SuperSetBoundedPool(Expression set) { LowerBound = set; }
        public override int Preference() => MutateCSharp.Schemata386.ReplaceNumericConstant_0(1L, 2);
        public override BoundedPool Clone(Cloner cloner)
        {
            return new SuperSetBoundedPool(cloner.CloneExpr(LowerBound));
        }

        public override PoolVirtues Virtues
        {
            get
            {
                if (LowerBound.Type.MayInvolveReferences)
                {
                    return PoolVirtues.None;
                }
                else
                {
                    return PoolVirtues.IndependentOfAlloc | PoolVirtues.IndependentOfAlloc_or_ExplicitAlloc;
                }

                return default;
            }
        }
    }
}
