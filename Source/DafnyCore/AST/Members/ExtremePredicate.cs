using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata101
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT101");
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
    public abstract class ExtremePredicate : Function
    {
        public override string WhatKindMentionGhost => WhatKind;
        public enum KType { Unspecified, Nat, ORDINAL }
        public readonly KType TypeOfK;
        public bool KNat
        {
            get
            {
                return MutateCSharp.Schemata101.ReplaceBinExprOp_0(1L, TypeOfK, KType.Nat);
            }
        }

        [FilledInDuringResolution] public readonly List<FunctionCallExpr> Uses = new List<FunctionCallExpr>();  // used by verifier
        [FilledInDuringResolution] public PrefixPredicate PrefixPredicate;  // (name registration)

        public override IEnumerable<INode> Children => base.Children.Concat(new[] { PrefixPredicate });
        public override IEnumerable<INode> PreResolveChildren => base.Children;

        public ExtremePredicate(RangeToken rangeToken, Name name, bool hasStaticKeyword, bool isOpaque, KType typeOfK,
          List<TypeParameter> typeArgs, List<Formal> ins, Formal result,
          List<AttributedExpression> req, Specification<FrameExpression> reads, List<AttributedExpression> ens,
          Expression body, Attributes attributes, IToken signatureEllipsis)
          : base(rangeToken, name, hasStaticKeyword, MutateCSharp.Schemata101.ReplaceBooleanConstant_1(2L, true), isOpaque, typeArgs, ins, result, Type.Bool,
            req, reads, ens, new Specification<Expression>(new List<Expression>(), null), body, null, null, attributes, signatureEllipsis)
        {
            TypeOfK = typeOfK;
        }

        /// <summary>
        /// For the given call P(s), return P#[depth](s).  The resulting expression shares some of the subexpressions
        /// with 'fexp' (that is, what is returned is not necessarily a clone).
        /// </summary>
        public FunctionCallExpr CreatePrefixPredicateCall(FunctionCallExpr fexp, Expression depth)
        {
            Contract.Requires(fexp != null);
            Contract.Requires(fexp.Function == this);
            Contract.Requires(depth != null);
            Contract.Ensures(Contract.Result<FunctionCallExpr>() != null);

            var args = new List<Expression>() { depth };
            args.AddRange(fexp.Args);
            var prefixPredCall = new FunctionCallExpr(fexp.Tok, this.PrefixPredicate.Name, fexp.Receiver, fexp.OpenParen, fexp.CloseParen, args);
            prefixPredCall.Function = this.PrefixPredicate;  // resolve here
            prefixPredCall.TypeApplication_AtEnclosingClass = fexp.TypeApplication_AtEnclosingClass;  // resolve here
            prefixPredCall.TypeApplication_JustFunction = fexp.TypeApplication_JustFunction;  // resolve here
            prefixPredCall.Type = fexp.Type;  // resolve here
            prefixPredCall.CoCall = fexp.CoCall;  // resolve here
            return prefixPredCall;
        }
    }

    public class GreatestPredicate : ExtremePredicate
    {
        public override string WhatKind => MutateCSharp.Schemata101.ReplaceStringConstant_2(3L, "greatest predicate");
        public GreatestPredicate(RangeToken rangeToken, Name name, bool hasStaticKeyword, bool isOpaque, KType typeOfK,
          List<TypeParameter> typeArgs, List<Formal> ins, Formal result,
          List<AttributedExpression> req, Specification<FrameExpression> reads, List<AttributedExpression> ens,
          Expression body, Attributes attributes, IToken signatureEllipsis)
          : base(rangeToken, name, hasStaticKeyword, isOpaque, typeOfK, typeArgs, ins, result,
            req, reads, ens, body, attributes, signatureEllipsis)
        {
        }
    }

    public class LeastPredicate : ExtremePredicate
    {
        public override string WhatKind => MutateCSharp.Schemata101.ReplaceStringConstant_2(4L, "least predicate");
        public LeastPredicate(RangeToken rangeToken, Name name, bool hasStaticKeyword, bool isOpaque, KType typeOfK,
          List<TypeParameter> typeArgs, List<Formal> ins, Formal result,
          List<AttributedExpression> req, Specification<FrameExpression> reads, List<AttributedExpression> ens,
          Expression body, Attributes attributes, IToken signatureEllipsis)
          : base(rangeToken, name, hasStaticKeyword, isOpaque, typeOfK, typeArgs, ins, result,
            req, reads, ens, body, attributes, signatureEllipsis)
        {
        }
    }
}