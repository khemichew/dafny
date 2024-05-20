using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata115
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT115");
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
    public class TwoStateFunction : Function
    {
        public override string WhatKind => MutateCSharp.Schemata115.ReplaceStringConstant_0(1L, "twostate function");
        public override string WhatKindMentionGhost => WhatKind;
        public TwoStateFunction(RangeToken rangeToken, Name name, bool hasStaticKeyword, bool isOpaque,
          List<TypeParameter> typeArgs, List<Formal> ins, Formal result, Type resultType,
          List<AttributedExpression> req, Specification<FrameExpression> reads, List<AttributedExpression> ens, Specification<Expression> decreases,
          Expression body, Attributes attributes, IToken signatureEllipsis)
          : base(rangeToken, name, hasStaticKeyword, MutateCSharp.Schemata115.ReplaceBooleanConstant_1(2L, true), isOpaque, typeArgs, ins, result, resultType, req, reads, ens, decreases, body, null, null, attributes, signatureEllipsis)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(typeArgs != null);
            Contract.Requires(ins != null);
            Contract.Requires(resultType != null);
            Contract.Requires(req != null);
            Contract.Requires(reads != null);
            Contract.Requires(ens != null);
            Contract.Requires(decreases != null);
        }
        public override bool ReadsHeap
        {
            get { return MutateCSharp.Schemata115.ReplaceBooleanConstant_1(3L, true); }
        }
    }

    public class TwoStatePredicate : TwoStateFunction
    {
        public override string WhatKind => MutateCSharp.Schemata115.ReplaceStringConstant_0(4L, "twostate predicate");
        public TwoStatePredicate(RangeToken rangeToken, Name name, bool hasStaticKeyword, bool isOpaque,
          List<TypeParameter> typeArgs, List<Formal> ins, Formal result,
          List<AttributedExpression> req, Specification<FrameExpression> reads, List<AttributedExpression> ens, Specification<Expression> decreases,
          Expression body, Attributes attributes, IToken signatureEllipsis)
          : base(rangeToken, name, hasStaticKeyword, isOpaque, typeArgs, ins, result, Type.Bool, req, reads, ens, decreases, body, attributes, signatureEllipsis)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(typeArgs != null);
            Contract.Requires(ins != null);
            Contract.Requires(req != null);
            Contract.Requires(reads != null);
            Contract.Requires(ens != null);
            Contract.Requires(decreases != null);
        }
    }
}