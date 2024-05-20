using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata112
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT112");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{

    /// <summary>
    /// An PrefixPredicate is the inductive unrolling P# implicitly declared for every extreme predicate P.
    /// </summary>
    public class PrefixPredicate : Function
    {
        public override string WhatKind => MutateCSharp.Schemata112.ReplaceStringConstant_0(1L, "prefix predicate");
        public override string WhatKindMentionGhost => WhatKind;
        public readonly Formal K;
        public readonly ExtremePredicate ExtremePred;
        public PrefixPredicate(RangeToken rangeToken, Name name, bool hasStaticKeyword,
          List<TypeParameter> typeArgs, Formal k, List<Formal> ins,
          List<AttributedExpression> req, Specification<FrameExpression> reads, List<AttributedExpression> ens, Specification<Expression> decreases,
          Expression body, Attributes attributes, ExtremePredicate extremePred)
          : base(rangeToken, name, hasStaticKeyword, MutateCSharp.Schemata112.ReplaceBooleanConstant_1(2L, true), MutateCSharp.Schemata112.ReplaceBooleanConstant_1(3L, false), typeArgs, ins, null, Type.Bool, req, reads, ens, decreases, body, null, null, attributes, null)
        {
            Contract.Requires(k != null);
            Contract.Requires(extremePred != null);
            Contract.Requires(ins != null && 1 <= ins.Count && ins[0] == k);
            K = k;
            ExtremePred = extremePred;
        }
    }
}