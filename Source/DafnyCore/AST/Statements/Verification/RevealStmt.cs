using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata177
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT177");
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

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() || argument2();
        }

    }
}

namespace Microsoft.Dafny
{
    public class RevealStmt : Statement, ICloneable<RevealStmt>, ICanFormat
    {
        public const string RevealLemmaPrefix = "reveal_";

        public readonly List<Expression> Exprs;
        [FilledInDuringResolution] public readonly List<AssertLabel> LabeledAsserts = new List<AssertLabel>();  // to indicate that "Expr" denotes a labeled assertion
        [FilledInDuringResolution] public readonly List<Statement> ResolvedStatements = new List<Statement>();

        public override IEnumerable<Statement> SubStatements
        {
            get { return ResolvedStatements; }
        }

        public override IEnumerable<Statement> PreResolveSubStatements => Enumerable.Empty<Statement>();

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(Exprs != null);
            Contract.Invariant(LabeledAsserts.Count <= Exprs.Count);
        }

        public RevealStmt Clone(Cloner cloner)
        {
            return new RevealStmt(cloner, this);
        }

        public RevealStmt(Cloner cloner, RevealStmt original) : base(cloner, original)
        {
            Exprs = original.Exprs.Select(cloner.CloneExpr).ToList();
            if (cloner.CloneResolvedFields)
            {
                LabeledAsserts = original.LabeledAsserts.Select(a => new AssertLabel(cloner.Tok(a.Tok), a.Name)).ToList();
                ResolvedStatements = original.ResolvedStatements.Select(stmt => cloner.CloneStmt(stmt, MutateCSharp.Schemata177.ReplaceBooleanConstant_0(1L, false))).ToList();
            }
        }

        public RevealStmt(RangeToken rangeToken, List<Expression> exprs)
          : base(rangeToken)
        {
            Contract.Requires(exprs != null);
            this.Exprs = exprs;
        }

        public static string SingleName(Expression e)
        {
            Contract.Requires(e != null);
            if (MutateCSharp.Schemata177.ReplaceBinExprOp_1(2L, () => e is NameSegment, () => e is LiteralExpr))
            {
                return e.tok.val;
            }
            else
            {
                return null;
            }

            return default;
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            return formatter.SetIndentPrintRevealStmt(indentBefore, OwnedTokens);
        }
    }
}