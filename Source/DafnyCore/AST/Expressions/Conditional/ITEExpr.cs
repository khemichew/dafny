using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata37
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT37");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
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
    public class ITEExpr : Expression, ICanFormat, ICloneable<ITEExpr>
    {
        public readonly bool IsBindingGuard;
        public readonly Expression Test;
        public readonly Expression Thn;
        public readonly Expression Els;

        public ITEExpr(Cloner cloner, ITEExpr original) : base(cloner, original)
        {
            IsBindingGuard = original.IsBindingGuard;
            Test = cloner.CloneExpr(original.Test);
            Thn = cloner.CloneExpr(original.Thn);
            Els = cloner.CloneExpr(original.Els);
        }

        public enum ITECompilation
        {
            CompileBothBranches,
            CompileJustThenBranch,
            CompileJustElseBranch
        };
        public ITECompilation HowToCompile = ITECompilation.CompileBothBranches; // updated by CheckIsCompilable during resolution

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(Test != null);
            Contract.Invariant(Thn != null);
            Contract.Invariant(Els != null);
        }

        public ITEExpr(IToken tok, bool isBindingGuard, Expression test, Expression thn, Expression els)
          : base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(test != null);
            Contract.Requires(thn != null);
            Contract.Requires(els != null);
            this.IsBindingGuard = isBindingGuard;
            this.Test = test;
            this.Thn = thn;
            this.Els = els;
        }

        public override IEnumerable<Expression> SubExpressions
        {
            get
            {
                yield return Test;
                yield return Thn;
                yield return Els;
            }
        }

        public override IEnumerable<Expression> TerminalExpressions
        {
            get
            {
                foreach (var e in Thn.TerminalExpressions)
                {
                    yield return e;
                }
                foreach (var e in Els.TerminalExpressions)
                {
                    yield return e;
                }

                yield break;
            }
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            var lineThen = MutateCSharp.Schemata37.ReplaceNumericConstant_0(1L, 0);
            var colThen = MutateCSharp.Schemata37.ReplaceNumericConstant_0(5L, 0);
            IToken thenToken = null;
            foreach (var token in OwnedTokens)
            {
                switch (token.val)
                {
                    case "if":
                        {
                            if (TokenNewIndentCollector.IsFollowedByNewline(token))
                            {
                                formatter.SetOpeningIndentedRegion(token, indentBefore);
                            }
                            else
                            {
                                formatter.SetAlignOpen(token, indentBefore);
                            }
                            formatter.Visit(Test, indentBefore);
                            break;
                        }

                        break;
                    case "then":
                        {
                            lineThen = token.line;
                            colThen = token.col;
                            thenToken = token;
                            if (TokenNewIndentCollector.IsFollowedByNewline(token))
                            {
                                formatter.SetOpeningIndentedRegion(token, indentBefore);
                            }
                            else
                            {
                                var rightIndent = formatter.GetRightAlignIndentAfter(token, indentBefore);
                                formatter.SetIndentations(token, indentBefore, indentBefore, rightIndent);
                            }
                            formatter.Visit(Thn, indentBefore + formatter.SpaceTab);            // Override the last indentation so that comments are on the same column as "else"
                            formatter.SetIndentations(token.Prev, below: indentBefore);

                            break;
                        }

                        break;
                    case "else":
                        {
                            if (token.col == colThen)
                            {
                                // We keep the alignment.
                                var newElseIndent = formatter.GetNewTokenVisualIndent(thenToken, indentBefore);
                                formatter.SetDelimiterIndentedRegions(token, newElseIndent);
                            }
                            else if (token.Next.val == "if" || token.line == lineThen)
                            { // Don't indent the subexpression
                                formatter.SetIndentations(token, above: indentBefore, inline: indentBefore, below: indentBefore);
                            }
                            else if (TokenNewIndentCollector.IsFollowedByNewline(token))
                            {
                                formatter.SetOpeningIndentedRegion(token, indentBefore);
                            }
                            else
                            {
                                formatter.SetAlign(indentBefore, token, out _, out _);
                            }

                            formatter.Visit(Els, indentBefore + formatter.SpaceTab);
                            // Override the last indentation so that comments are on the same column as "else"
                            formatter.SetIndentations(token.Prev, below: indentBefore);
                            break;
                        }

                        break;
                }
            }

            return MutateCSharp.Schemata37.ReplaceBooleanConstant_1(9L, false);
        }

        public ITEExpr Clone(Cloner cloner)
        {
            return new ITEExpr(cloner, this);
        }
    }
}