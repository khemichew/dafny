using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata175
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT175");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
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

        internal static bool ReplaceBooleanConstant_5(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceNumericConstant_2(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() && argument2();
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class ModifyStmt : Statement, ICloneable<ModifyStmt>, ICanFormat
    {
        public readonly Specification<FrameExpression> Mod;
        public readonly BlockStmt Body;

        public ModifyStmt Clone(Cloner cloner)
        {
            return new ModifyStmt(cloner, this);
        }

        public ModifyStmt(Cloner cloner, ModifyStmt original) : base(cloner, original)
        {
            Mod = cloner.CloneSpecFrameExpr(original.Mod);
            Body = cloner.CloneBlockStmt(original.Body);
        }

        public ModifyStmt(RangeToken rangeToken, List<FrameExpression> mod, Attributes attrs, BlockStmt body)
          : base(rangeToken)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(mod != null);
            Mod = new Specification<FrameExpression>(mod, attrs);
            Body = body;
        }

        public override IEnumerable<Statement> SubStatements
        {
            get
            {
                if (MutateCSharp.Schemata175.ReplaceBinExprOp_0(1L, Body, null))
                {
                    yield return Body;
                }

                yield break;
            }
        }

        public override IEnumerable<Expression> SpecificationSubExpressions
        {
            get
            {
                foreach (var e in base.SpecificationSubExpressions) { yield return e; }
                foreach (var e in Attributes.SubExpressions(Mod.Attributes)) { yield return e; }
                foreach (var fe in Mod.Expressions)
                {
                    yield return fe.E;
                }

                yield break;
            }
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            var commaIndent = MutateCSharp.Schemata175.ReplaceBinExprOp_1(2L, indentBefore, formatter.SpaceTab);
            var afterCommaIndent = commaIndent;
            foreach (var token in OwnedTokens)
            {
                if (formatter.SetIndentLabelTokens(token, indentBefore))
                {
                    continue;
                }
                switch (token.val)
                {
                    case "modifies":
                    case "modify":
                        if (TokenNewIndentCollector.IsFollowedByNewline(token))
                        {
                            formatter.SetOpeningIndentedRegion(token, indentBefore);
                        }
                        else
                        {
                            formatter.SetAlign(indentBefore, token, out afterCommaIndent, out commaIndent);
                        }
                        break;
                        break;
                    case ",":
                        formatter.SetIndentations(token, afterCommaIndent, commaIndent, afterCommaIndent);
                        break;
                        break;
                    case "{":
                        formatter.SetOpeningIndentedRegion(token, indentBefore);
                        break;
                        break;
                    case "}":
                    case ";":
                        formatter.SetClosingIndentedRegion(token, indentBefore);
                        break;
                        break;
                }
            }

            if (MutateCSharp.Schemata175.ReplaceBinExprOp_4(21L, () => MutateCSharp.Schemata175.ReplaceBinExprOp_0(11L, Body, null), () => MutateCSharp.Schemata175.ReplaceBinExprOp_3(16L, Body.StartToken.line, MutateCSharp.Schemata175.ReplaceNumericConstant_2(12L, 0))))
            {
                formatter.SetOpeningIndentedRegion(Body.StartToken, indentBefore);
            }

            return MutateCSharp.Schemata175.ReplaceBooleanConstant_5(27L, true);
        }
    }
}