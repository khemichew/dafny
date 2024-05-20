using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata100
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT100");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.ExtremePredicate.KType argument1, Microsoft.Dafny.ExtremePredicate.KType argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_2(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public abstract class ExtremeLemma : Method
    {
        public override string WhatKindMentionGhost => WhatKind;
        public readonly ExtremePredicate.KType TypeOfK;
        public bool KNat => MutateCSharp.Schemata100.ReplaceBinExprOp_0(1L, TypeOfK, ExtremePredicate.KType.Nat);
        [FilledInDuringResolution] public PrefixLemma PrefixLemma;  // (name registration)

        public override IEnumerable<INode> Children => base.Children.Concat(new[] { PrefixLemma });

        public override IEnumerable<INode> PreResolveChildren => base.Children;

        public ExtremeLemma(Cloner cloner, ExtremeLemma lemma) : base(cloner, lemma)
        {
            TypeOfK = lemma.TypeOfK;
        }

        public ExtremeLemma(RangeToken rangeToken, Name name,
          bool hasStaticKeyword, ExtremePredicate.KType typeOfK,
          List<TypeParameter> typeArgs,
          List<Formal> ins, [Captured] List<Formal> outs,
          List<AttributedExpression> req,
          Specification<FrameExpression> reads,
          [Captured] Specification<FrameExpression> mod,
          List<AttributedExpression> ens,
          Specification<Expression> decreases,
          BlockStmt body,
          Attributes attributes, IToken signatureEllipsis)
          : base(rangeToken, name, hasStaticKeyword, MutateCSharp.Schemata100.ReplaceBooleanConstant_1(2L, true), typeArgs, ins, outs, req, reads, mod, ens, decreases, body, attributes, signatureEllipsis)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(cce.NonNullElements(typeArgs));
            Contract.Requires(cce.NonNullElements(ins));
            Contract.Requires(cce.NonNullElements(outs));
            Contract.Requires(cce.NonNullElements(req));
            Contract.Requires(mod != null);
            Contract.Requires(cce.NonNullElements(ens));
            Contract.Requires(decreases != null);
            TypeOfK = typeOfK;
        }

        public override bool AllowsAllocation => MutateCSharp.Schemata100.ReplaceBooleanConstant_1(3L, false);
    }

    public class LeastLemma : ExtremeLemma
    {
        public override string WhatKind => MutateCSharp.Schemata100.ReplaceStringConstant_2(4L, "least lemma");

        public LeastLemma(RangeToken rangeToken, Name name,
          bool hasStaticKeyword, ExtremePredicate.KType typeOfK,
          List<TypeParameter> typeArgs,
          List<Formal> ins, [Captured] List<Formal> outs,
          List<AttributedExpression> req,
          Specification<FrameExpression> reads,
          [Captured] Specification<FrameExpression> mod,
          List<AttributedExpression> ens,
          Specification<Expression> decreases,
          BlockStmt body,
          Attributes attributes, IToken signatureEllipsis)
          : base(rangeToken, name, hasStaticKeyword, typeOfK, typeArgs, ins, outs, req, reads, mod, ens, decreases, body, attributes, signatureEllipsis)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(cce.NonNullElements(typeArgs));
            Contract.Requires(cce.NonNullElements(ins));
            Contract.Requires(cce.NonNullElements(outs));
            Contract.Requires(cce.NonNullElements(req));
            Contract.Requires(mod != null);
            Contract.Requires(cce.NonNullElements(ens));
            Contract.Requires(decreases != null);
        }

        public LeastLemma(Cloner cloner, LeastLemma leastLemma) : base(cloner, leastLemma)
        {
        }
    }

    public class GreatestLemma : ExtremeLemma
    {
        public override string WhatKind => MutateCSharp.Schemata100.ReplaceStringConstant_2(5L, "greatest lemma");

        public GreatestLemma(RangeToken rangeToken, Name name,
          bool hasStaticKeyword, ExtremePredicate.KType typeOfK,
          List<TypeParameter> typeArgs,
          List<Formal> ins, [Captured] List<Formal> outs,
          List<AttributedExpression> req,
          Specification<FrameExpression> reads,
          [Captured] Specification<FrameExpression> mod,
          List<AttributedExpression> ens,
          Specification<Expression> decreases,
          BlockStmt body,
          Attributes attributes, IToken signatureEllipsis)
          : base(rangeToken, name, hasStaticKeyword, typeOfK, typeArgs, ins, outs, req, reads, mod, ens, decreases, body, attributes, signatureEllipsis)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(cce.NonNullElements(typeArgs));
            Contract.Requires(cce.NonNullElements(ins));
            Contract.Requires(cce.NonNullElements(outs));
            Contract.Requires(cce.NonNullElements(req));
            Contract.Requires(mod != null);
            Contract.Requires(cce.NonNullElements(ens));
            Contract.Requires(decreases != null);
        }

        public GreatestLemma(Cloner cloner, GreatestLemma greatestLemma) : base(cloner, greatestLemma)
        {
        }
    }
}
