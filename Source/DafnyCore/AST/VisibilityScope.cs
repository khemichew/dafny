using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata210
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT210");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static uint ReplacePostfixUnaryExprOp_6(long mutantId, ref uint argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, uint argument1, uint argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_3(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.VisibilityScope argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static int ReplaceNumericConstant_4(long mutantId, int argument1)
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
    /// <summary>
    /// A scope consists of a set of identifiers.
    /// Two scopes overlap if the intersections of their identifiers is not empty
    /// </summary>
    public class VisibilityScope
    {
        private static uint maxScopeId;

        private readonly SortedSet<uint> scopeTokens = new();

        // Only for debugging
        private readonly SortedSet<string> scopeIds = new();

        private static bool Overlaps(SortedSet<uint> set1, SortedSet<uint> set2)
        {
            // This conditional implements a performance optimization,
            // since there is an iteration over the second argument to Overlaps
            if (MutateCSharp.Schemata210.ReplaceBinExprOp_0(1L, set1.Count, set2.Count))
            {
                return set2.Overlaps(set1);
            }
            else
            {
                return set1.Overlaps(set2);
            }

            return default;
        }

        private Dictionary<VisibilityScope, Tuple<int, bool>> cached = new();

        // By convention, the "null" scope sees all
        public bool VisibleInScope(VisibilityScope other)
        {
            if (MutateCSharp.Schemata210.ReplaceBinExprOp_1(6L, other, null))
            {
                if (cached.TryGetValue(other, out var result))
                {
                    if (MutateCSharp.Schemata210.ReplaceBinExprOp_2(7L, result.Item1, other.scopeTokens.Count))
                    {
                        // If the second scope did not change, then we can use the cached result.
                        // If this scoped changed, the cache would have been cleared.
                        return result.Item2;
                    }
                    else
                    {
                        // If the scoped used to overlap, they still do, since scopes only grow.
                        if (result.Item2)
                        {
                            return MutateCSharp.Schemata210.ReplaceBooleanConstant_3(12L, true);
                        }
                    }
                }
                var overlaps = Overlaps(other.scopeTokens, scopeTokens);
                cached[other] = new Tuple<int, bool>(other.scopeTokens.Count, overlaps);
                return overlaps;

            }
            return MutateCSharp.Schemata210.ReplaceBooleanConstant_3(13L, true);
        }

        [Pure]
        public bool IsEmpty()
        {
            return MutateCSharp.Schemata210.ReplaceBinExprOp_2(18L, scopeTokens.Count, MutateCSharp.Schemata210.ReplaceNumericConstant_4(14L, 0));
        }

        //However augmenting with a null scope does nothing
        public void Augment(VisibilityScope other)
        {
            if (MutateCSharp.Schemata210.ReplaceBinExprOp_1(23L, other, null))
            {
                scopeTokens.UnionWith(other.scopeTokens);
                scopeIds.UnionWith(other.scopeIds);
                cached.Clear();
            }
        }

        public VisibilityScope(string name)
        {
            scopeTokens.Add(maxScopeId);
            scopeIds.Add(name);
            if (MutateCSharp.Schemata210.ReplaceBinExprOp_5(24L, maxScopeId, uint.MaxValue))
            {
                Contract.Assert(false);
            }

            MutateCSharp.Schemata210.ReplacePostfixUnaryExprOp_6(29L, ref maxScopeId);
        }

        public VisibilityScope()
        {
        }
    }
}