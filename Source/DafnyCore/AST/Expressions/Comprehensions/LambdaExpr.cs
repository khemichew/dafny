using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata32
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT32");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_2(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static int ReplaceNumericConstant_0(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBooleanConstant_5(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
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

        internal static bool ReplaceBinExprOp_1(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class LambdaExpr : ComprehensionExpr, ICloneable<LambdaExpr>, IFrameScope
    {
        public override string WhatKind => MutateCSharp.Schemata32.ReplaceBinExprOp_1(5L, Reads.Expressions.Count, MutateCSharp.Schemata32.ReplaceNumericConstant_0(1L, 0)) ? MutateCSharp.Schemata32.ReplaceStringConstant_2(10L, "lambda") : MutateCSharp.Schemata32.ReplaceBinExprOp_3(11L, Range, null) ? MutateCSharp.Schemata32.ReplaceStringConstant_2(12L, "partial lambda") : MutateCSharp.Schemata32.ReplaceStringConstant_2(13L, "total lambda");

        public Expression Body => Term;

        public readonly Specification<FrameExpression> Reads;

        public LambdaExpr(IToken tok, RangeToken rangeToken, List<BoundVar> bvars, Expression requires, Specification<FrameExpression> reads, Expression body)
          : base(tok, rangeToken, bvars, requires, body, null)
        {
            Contract.Requires(reads != null);
            Reads = reads;
        }

        public override IEnumerable<Expression> SubExpressions
        {
            get
            {
                yield return Term;
                if (MutateCSharp.Schemata32.ReplaceBinExprOp_3(14L, Range, null))
                {
                    yield return Range;
                }
                foreach (var read in Reads.Expressions)
                {
                    yield return read.E;
                }

                yield break;
            }
        }

        public LambdaExpr(Cloner cloner, LambdaExpr original) : base(cloner, original)
        {
            Reads = cloner.CloneSpecFrameExpr(original.Reads);
        }

        public LambdaExpr Clone(Cloner cloner)
        {
            return new LambdaExpr(cloner, this);
        }

        public override bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            var itemIndent = MutateCSharp.Schemata32.ReplaceBinExprOp_4(15L, indentBefore, formatter.SpaceTab);
            var commaIndent = indentBefore;
            var firstSpec = MutateCSharp.Schemata32.ReplaceBooleanConstant_5(24L, true);
            var specIndent = MutateCSharp.Schemata32.ReplaceBinExprOp_4(25L, indentBefore, formatter.SpaceTab);
            foreach (var token in OwnedTokens)
            {
                switch (token.val)
                {
                    case "(":
                        {
                            if (TokenNewIndentCollector.IsFollowedByNewline(token))
                            {
                                formatter.SetIndentations(token, indentBefore, indentBefore, itemIndent);
                            }
                            else
                            {
                                formatter.SetAlign(indentBefore, token, out itemIndent, out commaIndent);
                            }

                            break;
                        }

                        break;
                    case ")":
                        {
                            formatter.SetIndentations(token, itemIndent, indentBefore, indentBefore);
                            break;
                        }

                        break;
                    case ",":
                        {
                            formatter.SetIndentations(token, itemIndent, commaIndent, itemIndent);
                            break;
                        }

                        break;
                    case "requires":
                    case "reads":
                        {
                            if (firstSpec)
                            {
                                specIndent = formatter.GetNewTokenVisualIndent(token, indentBefore);
                                firstSpec = false;
                            }
                            formatter.SetIndentations(token, specIndent, specIndent, specIndent + formatter.SpaceTab);
                            break;
                        }

                        break;
                    case "=>":
                        {
                            formatter.SetIndentations(token, itemIndent, indentBefore, indentBefore + formatter.SpaceTab);
                            break;
                        }

                        break;
                }
            }

            foreach (var bv in BoundVars)
            {
                if (MutateCSharp.Schemata32.ReplaceBinExprOp_6(34L, bv.SyntacticType, null))
                {
                    formatter.SetTypeIndentation(bv.SyntacticType);
                }
            }

            return MutateCSharp.Schemata32.ReplaceBooleanConstant_5(35L, true);
        }

        public string Designator => MutateCSharp.Schemata32.ReplaceStringConstant_2(36L, "lambda");
    }
}