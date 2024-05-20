using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata106
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT106");
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
    public class Lemma : Method
    {
        public override string WhatKind => MutateCSharp.Schemata106.ReplaceStringConstant_0(1L, "lemma");
        public override string WhatKindMentionGhost => WhatKind;
        public Lemma(RangeToken rangeToken, Name name,
          bool hasStaticKeyword,
          [Captured] List<TypeParameter> typeArgs,
          [Captured] List<Formal> ins, [Captured] List<Formal> outs,
          [Captured] List<AttributedExpression> req,
          [Captured] Specification<FrameExpression> reads,
          [Captured] Specification<FrameExpression> mod,
          [Captured] List<AttributedExpression> ens,
          [Captured] Specification<Expression> decreases,
          [Captured] BlockStmt body,
          Attributes attributes, IToken signatureEllipsis)
          : base(rangeToken, name, hasStaticKeyword, MutateCSharp.Schemata106.ReplaceBooleanConstant_1(2L, true), typeArgs, ins, outs, req, reads, mod, ens, decreases, body, attributes, signatureEllipsis)
        {
        }

        public Lemma(Cloner cloner, Lemma lemma) : base(cloner, lemma)
        {
        }

        public override bool AllowsAllocation => MutateCSharp.Schemata106.ReplaceBooleanConstant_1(3L, false);
    }

    public class TwoStateLemma : Method
    {
        public override string WhatKind => MutateCSharp.Schemata106.ReplaceStringConstant_0(4L, "twostate lemma");
        public override string WhatKindMentionGhost => WhatKind;

        public TwoStateLemma(RangeToken rangeToken, Name name,
          bool hasStaticKeyword,
          [Captured] List<TypeParameter> typeArgs,
          [Captured] List<Formal> ins, [Captured] List<Formal> outs,
          [Captured] List<AttributedExpression> req,
          [Captured] Specification<FrameExpression> reads,
          [Captured] Specification<FrameExpression> mod,
          [Captured] List<AttributedExpression> ens,
          [Captured] Specification<Expression> decreases,
          [Captured] BlockStmt body,
          Attributes attributes, IToken signatureEllipsis)
          : base(rangeToken, name, hasStaticKeyword, MutateCSharp.Schemata106.ReplaceBooleanConstant_1(5L, true), typeArgs, ins, outs, req, reads, mod, ens, decreases, body, attributes, signatureEllipsis)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(typeArgs != null);
            Contract.Requires(ins != null);
            Contract.Requires(outs != null);
            Contract.Requires(req != null);
            Contract.Requires(mod != null);
            Contract.Requires(ens != null);
            Contract.Requires(decreases != null);
        }

        public TwoStateLemma(Cloner cloner, TwoStateLemma lemma) : base(cloner, lemma)
        {
        }

        public override bool AllowsAllocation => MutateCSharp.Schemata106.ReplaceBooleanConstant_1(6L, false);
    }
}