//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata373
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT373");
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

namespace Microsoft.Dafny
{
    public abstract class CollectionBoundedPool : BoundedPool
    {
        public readonly Type BoundVariableType;
        public readonly Type CollectionElementType;
        public readonly bool IsFiniteCollection;

        public CollectionBoundedPool(Type bvType, Type collectionElementType, bool isFiniteCollection)
        {
            Contract.Requires(bvType != null);
            Contract.Requires(collectionElementType != null);

            BoundVariableType = bvType;
            CollectionElementType = collectionElementType;
            IsFiniteCollection = isFiniteCollection;
        }

        public override PoolVirtues Virtues
        {
            get
            {
                var v = PoolVirtues.IndependentOfAlloc | PoolVirtues.IndependentOfAlloc_or_ExplicitAlloc | PoolVirtues.Enumerable;
                if (IsFiniteCollection)
                {
                    v |= PoolVirtues.Finite;
                }
                return v;
            }
        }

        public override int Preference() => MutateCSharp.Schemata373.ReplaceNumericConstant_0(1L, 10);
        public override bool IsCompilable(Type boundVariableType)
        {
            Contract.Assert(boundVariableType.Equals(BoundVariableType));
            return ExpressionTester.IsTypeTestCompilable(CollectionElementType, BoundVariableType);
        }

    }
}
