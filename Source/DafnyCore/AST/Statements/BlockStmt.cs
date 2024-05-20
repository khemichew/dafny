using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata147
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT147");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
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

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

    }
}

namespace Microsoft.Dafny
{
    public class BlockStmt : Statement, ICloneable<BlockStmt>, ICanFormat
    {
        public readonly List<Statement> Body;

        public BlockStmt Clone(Cloner cloner)
        {
            return new BlockStmt(cloner, this);
        }

        protected BlockStmt(Cloner cloner, BlockStmt original) : base(cloner, original)
        {
            Body = original.Body.Select(stmt => cloner.CloneStmt(stmt, MutateCSharp.Schemata147.ReplaceBooleanConstant_0(1L, false))).ToList();
        }

        public BlockStmt(RangeToken rangeToken, [Captured] List<Statement> body)
          : base(rangeToken)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(cce.NonNullElements(body));
            this.Body = body;
        }

        public override IEnumerable<Statement> SubStatements => Body;

        public virtual void AppendStmt(Statement s)
        {
            Contract.Requires(s != null);
            Body.Add(s);
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            var braceIndent = indentBefore;
            var innerBlockIndent = MutateCSharp.Schemata147.ReplaceBinExprOp_1(2L, indentBefore, formatter.SpaceTab);
            foreach (var token in OwnedTokens)
            {
                if (formatter.SetIndentLabelTokens(token, indentBefore))
                {
                    continue;
                }
                switch (token.val)
                {
                    case "{":
                        {
                            if (!formatter.TryGetIndentInline(token, out var indentLineBefore))
                            {
                                formatter.SetDelimiterIndentedRegions(token, braceIndent);
                            }
                            else
                            {
                                braceIndent = indentLineBefore;
                                if (!formatter.TryGetIndentAbove(token, out _))
                                {
                                    formatter.SetDelimiterIndentedRegions(token, braceIndent);
                                }

                                if (!TokenNewIndentCollector.IsFollowedByNewline(token))
                                {
                                    // Align statements
                                    formatter.SetAlign(indentBefore, token, out innerBlockIndent, out braceIndent);
                                }
                            }

                            break;
                        }

                        break;
                    case "}":
                        {
                            formatter.SetIndentations(token, braceIndent + formatter.SpaceTab, braceIndent, indentBefore);
                            break;
                        }

                        break;
                }
            }

            foreach (var blockStmtBody in Body)
            {
                if (MutateCSharp.Schemata147.ReplaceBinExprOp_2(11L, () => blockStmtBody is not BlockStmt, () => OwnedTokens.Any()))
                {
                    formatter.SetIndentations(blockStmtBody.StartToken, innerBlockIndent, innerBlockIndent);
                }

                formatter.Visit(blockStmtBody, MutateCSharp.Schemata147.ReplaceBinExprOp_1(17L, indentBefore, formatter.SpaceTab));
            }

            return MutateCSharp.Schemata147.ReplaceBooleanConstant_0(26L, false);
        }
    }
}