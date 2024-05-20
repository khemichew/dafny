using System.Collections.Generic;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata145
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT145");
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

    }
}

namespace Microsoft.Dafny
{
    public class VarDeclPattern : Statement, ICloneable<VarDeclPattern>, ICanFormat
    {
        public readonly CasePattern<LocalVariable> LHS;
        public readonly Expression RHS;
        public bool HasGhostModifier;

        public VarDeclPattern Clone(Cloner cloner)
        {
            return new VarDeclPattern(cloner, this);
        }

        public VarDeclPattern(Cloner cloner, VarDeclPattern original) : base(cloner, original)
        {
            LHS = cloner.CloneCasePattern(original.LHS);
            RHS = cloner.CloneExpr(original.RHS);
            HasGhostModifier = original.HasGhostModifier;
        }

        public VarDeclPattern(RangeToken rangeToken, CasePattern<LocalVariable> lhs, Expression rhs, bool hasGhostModifier)
          : base(rangeToken)
        {
            LHS = lhs;
            RHS = rhs;
            HasGhostModifier = hasGhostModifier;
        }

        public override IEnumerable<Expression> NonSpecificationSubExpressions
        {
            get
            {
                foreach (var e in base.NonSpecificationSubExpressions)
                {
                    yield return e;
                }
                yield return RHS;
            }
        }

        public override IEnumerable<INode> Children =>
          new List<Node> { LHS }.Concat(base.Children);

        public IEnumerable<LocalVariable> LocalVars
        {
            get
            {
                foreach (var bv in LHS.Vars)
                {
                    yield return bv;
                }

                yield break;
            }
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            return formatter.SetIndentVarDeclStmt(indentBefore, OwnedTokens, MutateCSharp.Schemata145.ReplaceBooleanConstant_0(1L, false), MutateCSharp.Schemata145.ReplaceBooleanConstant_0(2L, true));
        }
    }
}