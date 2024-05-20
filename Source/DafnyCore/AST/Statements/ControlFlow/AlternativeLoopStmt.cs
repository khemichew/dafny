using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata149
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT149");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceBinExprOp_0(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 + argument2;
        }

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class AlternativeLoopStmt : LoopStmt, ICloneable<AlternativeLoopStmt>, ICanFormat
    {
        public readonly bool UsesOptionalBraces;
        public readonly List<GuardedAlternative> Alternatives;
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(Alternatives != null);
        }

        public AlternativeLoopStmt Clone(Cloner cloner)
        {
            return new AlternativeLoopStmt(cloner, this);
        }

        public AlternativeLoopStmt(Cloner cloner, AlternativeLoopStmt original) : base(cloner, original)
        {
            Alternatives = original.Alternatives.ConvertAll(cloner.CloneGuardedAlternative);
            UsesOptionalBraces = original.UsesOptionalBraces;
        }

        public AlternativeLoopStmt(RangeToken rangeToken,
          List<AttributedExpression> invariants, Specification<Expression> decreases, Specification<FrameExpression> mod,
          List<GuardedAlternative> alternatives, bool usesOptionalBraces)
          : base(rangeToken, invariants, decreases, mod)
        {
            Contract.Requires(alternatives != null);
            this.Alternatives = alternatives;
            this.UsesOptionalBraces = usesOptionalBraces;
        }
        public AlternativeLoopStmt(RangeToken rangeToken,
          List<AttributedExpression> invariants, Specification<Expression> decreases, Specification<FrameExpression> mod,
          List<GuardedAlternative> alternatives, bool usesOptionalBraces, Attributes attrs)
          : base(rangeToken, invariants, decreases, mod, attrs)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(alternatives != null);
            this.Alternatives = alternatives;
            this.UsesOptionalBraces = usesOptionalBraces;
        }
        public override IEnumerable<Statement> SubStatements
        {
            get
            {
                foreach (var alt in Alternatives)
                {
                    foreach (var s in alt.Body)
                    {
                        yield return s;
                    }
                }

                yield break;
            }
        }

        public override IEnumerable<Expression> SpecificationSubExpressions
        {
            get
            {
                foreach (var e in base.SpecificationSubExpressions) { yield return e; }
                foreach (var alt in Alternatives)
                {
                    foreach (var e in Attributes.SubExpressions(alt.Attributes))
                    {
                        yield return e;
                    }
                }

                yield break;
            }
        }

        public override IEnumerable<Expression> NonSpecificationSubExpressions
        {
            get
            {
                foreach (var e in base.NonSpecificationSubExpressions) { yield return e; }
                foreach (var alt in Alternatives)
                {
                    yield return alt.Guard;
                }

                yield break;
            }
        }

        public override IEnumerable<INode> Children => SpecificationSubExpressions.Concat<Node>(Alternatives);
        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            return formatter.SetIndentCases(indentBefore, OwnedTokens.Concat(Alternatives.SelectMany(alternative => alternative.OwnedTokens)), () =>
            {
                foreach (var ens in Invariants)
                {
                    formatter.SetAttributedExpressionIndentation(ens, MutateCSharp.Schemata149.ReplaceBinExprOp_0(1L, indentBefore, formatter.SpaceTab));
                }

                foreach (var dec in Decreases.Expressions)
                {
                    formatter.SetDecreasesExpressionIndentation(dec, MutateCSharp.Schemata149.ReplaceBinExprOp_0(10L, indentBefore, formatter.SpaceTab));
                }

                formatter.VisitAlternatives(Alternatives, indentBefore);
                if (MutateCSharp.Schemata149.ReplaceBinExprOp_2(20L, EndToken.val, MutateCSharp.Schemata149.ReplaceStringConstant_1(19L, "}")))
                {
                    formatter.SetClosingIndentedRegion(EndToken, indentBefore);
                }
            });
        }
    }
}