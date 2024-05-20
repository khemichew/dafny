using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata111
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT111");
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
    /// A PrefixLemma is the inductive unrolling M# implicitly declared for every extreme lemma M.
    /// </summary>
    public class PrefixLemma : Method
    {
        public override string WhatKind => MutateCSharp.Schemata111.ReplaceStringConstant_0(1L, "prefix lemma");
        public override string WhatKindMentionGhost => WhatKind;

        public readonly Formal K;
        public readonly ExtremeLemma ExtremeLemma;
        public PrefixLemma(RangeToken rangeToken, Name name, bool hasStaticKeyword,
          List<TypeParameter> typeArgs, Formal k, List<Formal> ins, List<Formal> outs,
          List<AttributedExpression> req, [Captured] Specification<FrameExpression> reads,
          Specification<FrameExpression> mod, List<AttributedExpression> ens, Specification<Expression> decreases,
          BlockStmt body, Attributes attributes, ExtremeLemma extremeLemma)
          : base(rangeToken, name, hasStaticKeyword, MutateCSharp.Schemata111.ReplaceBooleanConstant_1(2L, true), typeArgs, ins, outs, req, reads, mod, ens, decreases, body, attributes, null)
        {
            Contract.Requires(k != null);
            Contract.Requires(ins != null && 1 <= ins.Count && ins[0] == k);
            Contract.Requires(extremeLemma != null);
            K = k;
            ExtremeLemma = extremeLemma;
        }

        public override bool AllowsAllocation => MutateCSharp.Schemata111.ReplaceBooleanConstant_1(3L, false);
    }
}