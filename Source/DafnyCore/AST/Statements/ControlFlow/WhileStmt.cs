using System.Collections.Generic;
namespace MutateCSharp
{
    internal class Schemata160
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT160");
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

        internal static int ReplaceBinExprOp_1(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBooleanConstant_4(long mutantId, bool argument1)
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

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class WhileStmt : OneBodyLoopStmt, ICloneable<WhileStmt>, ICanFormat
    {
        public readonly Expression/*?*/ Guard;

        public class LoopBodySurrogate
        {
            public readonly List<IVariable> LocalLoopTargets;
            public readonly bool UsesHeap;

            public LoopBodySurrogate(List<IVariable> localLoopTargets, bool usesHeap)
            {
                LocalLoopTargets = localLoopTargets;
                UsesHeap = usesHeap;
            }
        }

        public WhileStmt Clone(Cloner cloner)
        {
            return new WhileStmt(cloner, this);
        }

        public WhileStmt(Cloner cloner, WhileStmt original) : base(cloner, original)
        {
            Guard = cloner.CloneExpr(original.Guard);
        }

        public WhileStmt(RangeToken rangeToken, Expression guard,
          List<AttributedExpression> invariants, Specification<Expression> decreases, Specification<FrameExpression> mod,
          BlockStmt body)
          : base(rangeToken, invariants, decreases, mod, body, null)
        {
            this.Guard = guard;
        }

        public WhileStmt(RangeToken rangeToken, Expression guard,
          List<AttributedExpression> invariants, Specification<Expression> decreases, Specification<FrameExpression> mod,
          BlockStmt body, Attributes attrs)
          : base(rangeToken, invariants, decreases, mod, body, attrs)
        {
            this.Guard = guard;
        }

        public override IEnumerable<Expression> NonSpecificationSubExpressions
        {
            get
            {
                foreach (var e in base.NonSpecificationSubExpressions) { yield return e; }
                if (MutateCSharp.Schemata160.ReplaceBinExprOp_0(1L, Guard, null))
                {
                    yield return Guard;
                }

                yield break;
            }
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            formatter.SetIndentLikeLoop(OwnedTokens, Body, indentBefore);
            foreach (var ens in Invariants)
            {
                formatter.SetAttributedExpressionIndentation(ens, MutateCSharp.Schemata160.ReplaceBinExprOp_1(2L, indentBefore, formatter.SpaceTab));
            }

            foreach (var dec in Decreases.Expressions)
            {
                formatter.SetDecreasesExpressionIndentation(dec, MutateCSharp.Schemata160.ReplaceBinExprOp_1(11L, indentBefore, formatter.SpaceTab));
            }

            if (MutateCSharp.Schemata160.ReplaceBinExprOp_3(21L, EndToken.val, MutateCSharp.Schemata160.ReplaceStringConstant_2(20L, "}")))
            {
                formatter.SetClosingIndentedRegion(EndToken, indentBefore);
            }

            return MutateCSharp.Schemata160.ReplaceBooleanConstant_4(22L, false);
        }
    }
}