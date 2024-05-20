//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata380
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT380");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public class MultiSetBoundedPool : CollectionBoundedPool
    {
        public readonly Expression MultiSet;

        public MultiSetBoundedPool(Expression multiset, Type bvType, Type collectionElementType)
          : base(bvType, collectionElementType, MutateCSharp.Schemata380.ReplaceBooleanConstant_0(1L, true))
        {
            Contract.Requires(multiset != null);
            Contract.Requires(bvType != null);
            Contract.Requires(collectionElementType != null);
            MultiSet = multiset;
        }

        public override BoundedPool Clone(Cloner cloner)
        {
            return new MultiSetBoundedPool(cloner.CloneExpr(MultiSet), BoundVariableType, CollectionElementType);
        }
    }
}
