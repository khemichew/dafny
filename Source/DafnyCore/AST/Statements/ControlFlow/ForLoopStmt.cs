using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata153
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT153");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_3(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
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

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class ForLoopStmt : OneBodyLoopStmt, ICloneable<ForLoopStmt>, ICanFormat
    {
        public readonly BoundVar LoopIndex;
        public readonly Expression Start;
        public readonly Expression/*?*/ End;
        public readonly bool GoingUp;

        public ForLoopStmt Clone(Cloner cloner)
        {
            return new ForLoopStmt(cloner, this);
        }

        public ForLoopStmt(Cloner cloner, ForLoopStmt original) : base(cloner, original)
        {
            LoopIndex = cloner.CloneBoundVar(original.LoopIndex, MutateCSharp.Schemata153.ReplaceBooleanConstant_0(1L, false));
            Start = cloner.CloneExpr(original.Start);
            End = cloner.CloneExpr(original.End);
            GoingUp = original.GoingUp;
        }

        public ForLoopStmt(RangeToken rangeToken, BoundVar loopIndexVariable, Expression start, Expression/*?*/ end, bool goingUp,
          List<AttributedExpression> invariants, Specification<Expression> decreases, Specification<FrameExpression> mod,
          BlockStmt /*?*/ body, Attributes attrs)
          : base(rangeToken, invariants, decreases, mod, body, attrs)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(loopIndexVariable != null);
            Contract.Requires(start != null);
            Contract.Requires(invariants != null);
            Contract.Requires(decreases != null);
            Contract.Requires(mod != null);
            LoopIndex = loopIndexVariable;
            Start = start;
            End = end;
            GoingUp = goingUp;
        }

        public override IEnumerable<Expression> NonSpecificationSubExpressions
        {
            get
            {
                foreach (var e in base.NonSpecificationSubExpressions) { yield return e; }
                yield return Start;
                if (MutateCSharp.Schemata153.ReplaceBinExprOp_1(2L, End, null))
                {
                    yield return End;
                }

                yield break;
            }
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            var forReached = MutateCSharp.Schemata153.ReplaceBooleanConstant_0(3L, false);
            var specification = MutateCSharp.Schemata153.ReplaceBooleanConstant_0(4L, false);
            foreach (var token in OwnedTokens)
            {
                if (formatter.SetIndentLabelTokens(token, indentBefore))
                {
                    continue;
                }
                if (MutateCSharp.Schemata153.ReplaceBinExprOp_3(6L, token.val, MutateCSharp.Schemata153.ReplaceStringConstant_2(5L, "for")))
                {
                    formatter.SetOpeningIndentedRegion(token, indentBefore);
                    forReached = MutateCSharp.Schemata153.ReplaceBooleanConstant_0(7L, true);
                    continue;
                }

                if (!forReached)
                {
                    continue;
                }

                if (specification)
                {
                    formatter.SetOpeningIndentedRegion(token, MutateCSharp.Schemata153.ReplaceBinExprOp_4(8L, indentBefore, formatter.SpaceTab));
                }

                if (token.val is "to" or "downto")
                {
                    specification = MutateCSharp.Schemata153.ReplaceBooleanConstant_0(17L, true);
                }
            }

            foreach (var ens in Invariants)
            {
                formatter.SetAttributedExpressionIndentation(ens, MutateCSharp.Schemata153.ReplaceBinExprOp_4(18L, indentBefore, formatter.SpaceTab));
            }

            formatter.SetIndentBody(Body, indentBefore);
            formatter.SetClosingIndentedRegion(EndToken, indentBefore);
            return MutateCSharp.Schemata153.ReplaceBooleanConstant_0(27L, false);
        }
    }
}
