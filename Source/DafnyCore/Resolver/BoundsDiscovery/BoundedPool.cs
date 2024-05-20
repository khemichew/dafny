//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Numerics;
using JetBrains.Annotations;
namespace MutateCSharp
{
    internal class Schemata370
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT370");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.BoundedPool.PoolVirtues argument1, Microsoft.Dafny.BoundedPool.PoolVirtues argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_7(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.BoundedPool argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static int ReplaceNumericConstant_5(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.IntBoundedPool argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.BoundedPool argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.BoundedPool.PoolVirtues argument1, Microsoft.Dafny.BoundedPool.PoolVirtues argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_6(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.BoundedPool> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public abstract class BoundedPool : ICloneable<BoundedPool>
    {
        [Flags]
        public enum PoolVirtues
        {
            None = 0,
            Finite = 1,
            Enumerable = 2,
            IndependentOfAlloc = 4,
            IndependentOfAlloc_or_ExplicitAlloc = 8
        }

        public abstract PoolVirtues Virtues { get; }

        /// <summary>
        /// A higher preference is better.
        /// A preference below 2 is a last-resort bounded pool. Bounds discovery will not consider
        /// such a pool to be final until there are no other choices.
        ///
        /// For easy reference, here is the BoundedPool hierarchy and their preference levels:
        ///
        /// 0: AllocFreeBoundedPool
        /// 0: ExplicitAllocatedBoundedPool
        /// 0: SpecialAllocIndependenceAllocatedBoundedPool
        /// 0: OlderBoundedPool
        ///
        /// 1: WiggleWaggleBound
        ///
        /// 2: SuperSetBoundedPool
        /// 2: DatatypeInclusionBoundedPool
        ///
        /// 3: SubSetBoundedPool
        ///
        /// 4: IntBoundedPool with one bound
        /// 5: IntBoundedPool with both bounds
        /// 5: CharBoundedPool
        ///
        /// 8: DatatypeBoundedPool
        ///
        /// 10: CollectionBoundedPool
        ///     - SetBoundedPool
        ///     - MultiSetBoundedPool
        ///     - MapBoundedPool
        ///     - SeqBoundedPool
        ///
        /// 14: BoolBoundedPool
        ///
        /// 15: ExactBoundedPool
        /// </summary>
        public abstract int Preference(); // higher is better

        public static BoundedPool GetBest(List<BoundedPool> bounds)
        {
            Contract.Requires(bounds != null);
            bounds = CombineIntegerBounds(bounds);
            BoundedPool best = null;
            foreach (var bound in bounds)
            {
                if (best is IntBoundedPool ibp0 && bound is IntBoundedPool ibp1)
                {
                    best = new IntBoundedPool(
                      ChooseBestIntegerBound(ibp0.LowerBound, ibp1.LowerBound, MutateCSharp.Schemata370.ReplaceBooleanConstant_0(1L, true)),
                      ChooseBestIntegerBound(ibp0.UpperBound, ibp1.UpperBound, MutateCSharp.Schemata370.ReplaceBooleanConstant_0(2L, false)));
                }
                else if (MutateCSharp.Schemata370.ReplaceBinExprOp_3(9L, () => MutateCSharp.Schemata370.ReplaceBinExprOp_1(3L, best, null), () => MutateCSharp.Schemata370.ReplaceBinExprOp_2(4L, bound.Preference(), best.Preference())))
                {
                    best = bound;
                }
            }
            return best;
        }

        [CanBeNull]
        static Expression ChooseBestIntegerBound([CanBeNull] Expression a, [CanBeNull] Expression b, bool pickMax)
        {
            if (MutateCSharp.Schemata370.ReplaceBinExprOp_3(17L, () => MutateCSharp.Schemata370.ReplaceBinExprOp_4(15L, a, null), () => MutateCSharp.Schemata370.ReplaceBinExprOp_4(16L, b, null)))
            {
                return a ?? b;
            }

            if (Expression.IsIntLiteral(a, out var aa) && Expression.IsIntLiteral(b, out var bb))
            {
                var x = pickMax ? BigInteger.Max(aa, bb) : BigInteger.Min(aa, bb);
                return new LiteralExpr(a.tok, x) { Type = a.Type };
            }
            // we don't know how to determine which of "a" or "b" is better, so we'll just return "a"
            // (better would be to return an expression that computes to the minimum of "a" and "b")
            return a;
        }

        public static List<VT> MissingBounds<VT>(List<VT> vars, List<BoundedPool> bounds, PoolVirtues requiredVirtues) where VT : IVariable
        {
            Contract.Requires(vars != null);
            Contract.Requires(bounds == null || vars.Count == bounds.Count);
            Contract.Ensures(Contract.Result<List<VT>>() != null);
            var missing = new List<VT>();
            for (var i = MutateCSharp.Schemata370.ReplaceNumericConstant_5(23L, 0); MutateCSharp.Schemata370.ReplaceBinExprOp_6(27L, i, vars.Count); MutateCSharp.Schemata370.ReplacePostfixUnaryExprOp_7(32L, ref i))
            {
                if (MutateCSharp.Schemata370.ReplaceBinExprOp_3(54L, () => MutateCSharp.Schemata370.ReplaceBinExprOp_3(42L, () => MutateCSharp.Schemata370.ReplaceBinExprOp_3(35L, () => MutateCSharp.Schemata370.ReplaceBinExprOp_8(33L, bounds, null), () => MutateCSharp.Schemata370.ReplaceBinExprOp_1(34L, bounds[i], null)), () => MutateCSharp.Schemata370.ReplaceBinExprOp_9(41L, (bounds[i].Virtues & requiredVirtues), requiredVirtues)), () => (MutateCSharp.Schemata370.ReplaceBinExprOp_10(48L, () => (requiredVirtues & PoolVirtues.Enumerable) != 0, () => !bounds[i].IsCompilable(vars[i].Type)))))
                {
                    missing.Add(vars[i]);
                }
            }
            return missing;
        }

        public static List<bool> HasBounds(List<BoundedPool> bounds, PoolVirtues requiredVirtues = PoolVirtues.None)
        {
            Contract.Requires(bounds != null);
            Contract.Ensures(Contract.Result<List<bool>>() != null);
            Contract.Ensures(Contract.Result<List<bool>>().Count == bounds.Count);
            return bounds.ConvertAll(bound => MutateCSharp.Schemata370.ReplaceBinExprOp_10(62L, () => MutateCSharp.Schemata370.ReplaceBinExprOp_11(60L, bound, null), () => MutateCSharp.Schemata370.ReplaceBinExprOp_12(61L, (bound.Virtues & requiredVirtues), requiredVirtues)));
        }

        static List<BoundedPool> CombineIntegerBounds(List<BoundedPool> bounds)
        {
            var lowerBounds = new List<IntBoundedPool>();
            var upperBounds = new List<IntBoundedPool>();
            var others = new List<BoundedPool>();
            foreach (var b in bounds)
            {
                var ib = b as IntBoundedPool;
                if (MutateCSharp.Schemata370.ReplaceBinExprOp_10(70L, () => MutateCSharp.Schemata370.ReplaceBinExprOp_13(68L, ib, null), () => MutateCSharp.Schemata370.ReplaceBinExprOp_4(69L, ib.UpperBound, null)))
                {
                    lowerBounds.Add(ib);
                }
                else if (MutateCSharp.Schemata370.ReplaceBinExprOp_10(78L, () => MutateCSharp.Schemata370.ReplaceBinExprOp_13(76L, ib, null), () => MutateCSharp.Schemata370.ReplaceBinExprOp_4(77L, ib.LowerBound, null)))
                {
                    upperBounds.Add(ib);
                }
                else
                {
                    others.Add(b);
                }
            }
            // pair up the bounds
            var n = Math.Min(lowerBounds.Count, upperBounds.Count);
            for (var i = MutateCSharp.Schemata370.ReplaceNumericConstant_5(84L, 0); MutateCSharp.Schemata370.ReplaceBinExprOp_6(88L, i, n); MutateCSharp.Schemata370.ReplacePostfixUnaryExprOp_7(93L, ref i))
            {
                others.Add(new IntBoundedPool(lowerBounds[i].LowerBound, upperBounds[i].UpperBound));
            }
            for (var i = n; MutateCSharp.Schemata370.ReplaceBinExprOp_6(94L, i, lowerBounds.Count); MutateCSharp.Schemata370.ReplacePostfixUnaryExprOp_7(99L, ref i))
            {
                others.Add(lowerBounds[i]);
            }
            for (var i = n; MutateCSharp.Schemata370.ReplaceBinExprOp_6(100L, i, upperBounds.Count); MutateCSharp.Schemata370.ReplacePostfixUnaryExprOp_7(105L, ref i))
            {
                others.Add(upperBounds[i]);
            }
            return others;
        }

        public virtual bool IsCompilable(Type boundVariableType) =>
          ExpressionTester.IsTypeTestCompilable(boundVariableType.NormalizeToAncestorType(), boundVariableType);

        public abstract BoundedPool Clone(Cloner cloner);
    }
}