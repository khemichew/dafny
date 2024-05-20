using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata157
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT157");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.FrameExpression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public abstract class LoopStmt : Statement, IDeclarationOrUsage
    {
        public readonly List<AttributedExpression> Invariants;
        public readonly Specification<Expression> Decreases;
        [FilledInDuringResolution] public bool InferredDecreases;  // says that no explicit "decreases" clause was given and an attempt was made to find one automatically (which may or may not have produced anything)
        public readonly Specification<FrameExpression> Mod;
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(cce.NonNullElements(Invariants));
            Contract.Invariant(Decreases != null);
            Contract.Invariant(Mod != null);
        }

        protected LoopStmt(Cloner cloner, LoopStmt original) : base(cloner, original)
        {
            Invariants = original.Invariants.ConvertAll(cloner.CloneAttributedExpr);
            Decreases = cloner.CloneSpecExpr(original.Decreases);
            Mod = cloner.CloneSpecFrameExpr(original.Mod);

            if (cloner.CloneResolvedFields)
            {
                InferredDecreases = original.InferredDecreases;
            }
        }

        public LoopStmt(RangeToken rangeToken, List<AttributedExpression> invariants, Specification<Expression> decreases, Specification<FrameExpression> mod)
          : base(rangeToken)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(cce.NonNullElements(invariants));
            Contract.Requires(decreases != null);
            Contract.Requires(mod != null);

            this.Invariants = invariants;
            this.Decreases = decreases;
            this.Mod = mod;
        }
        public LoopStmt(RangeToken rangeToken, List<AttributedExpression> invariants, Specification<Expression> decreases, Specification<FrameExpression> mod, Attributes attrs)
          : base(rangeToken, attrs)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(cce.NonNullElements(invariants));
            Contract.Requires(decreases != null);
            Contract.Requires(mod != null);

            this.Invariants = invariants;
            this.Decreases = decreases;
            this.Mod = mod;
        }
        public IEnumerable<Expression> LoopSpecificationExpressions
        {
            get
            {
                foreach (var mfe in Invariants)
                {
                    foreach (var e in Attributes.SubExpressions(mfe.Attributes)) { yield return e; }
                    yield return mfe.E;
                }
                foreach (var e in Attributes.SubExpressions(Decreases.Attributes)) { yield return e; }
                if (MutateCSharp.Schemata157.ReplaceBinExprOp_0(1L, Decreases.Expressions, null))
                {
                    foreach (var e in Decreases.Expressions)
                    {
                        yield return e;
                    }
                }
                foreach (var e in Attributes.SubExpressions(Mod.Attributes)) { yield return e; }
                if (MutateCSharp.Schemata157.ReplaceBinExprOp_1(2L, Mod.Expressions, null))
                {
                    foreach (var fe in Mod.Expressions)
                    {
                        yield return fe.E;
                    }
                }

                yield break;
            }
        }

        public override IEnumerable<Expression> NonSpecificationSubExpressions
        {
            get
            {
                foreach (var e in base.NonSpecificationSubExpressions)
                {
                    yield return e;
                }

                yield break;
            }
        }

        public override IEnumerable<Expression> SpecificationSubExpressions
        {
            get
            {
                foreach (var e in LoopSpecificationExpressions)
                {
                    yield return e;
                }

                yield break;
            }
        }

        public IToken NameToken => Tok;
    }
}