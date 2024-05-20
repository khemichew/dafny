using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata155
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT155");
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

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class IfStmt : Statement, ICloneable<IfStmt>, ICanFormat
    {
        public readonly bool IsBindingGuard;
        public readonly Expression Guard;
        public readonly BlockStmt Thn;
        public readonly Statement Els;
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(!IsBindingGuard || (Guard is ExistsExpr && ((ExistsExpr)Guard).Range == null));
            Contract.Invariant(Thn != null);
            Contract.Invariant(Els == null || Els is BlockStmt || Els is IfStmt || Els is SkeletonStatement);
        }

        public IfStmt Clone(Cloner cloner)
        {
            return new IfStmt(cloner, this);
        }

        public IfStmt(Cloner cloner, IfStmt original) : base(cloner, original)
        {
            IsBindingGuard = original.IsBindingGuard;
            Guard = cloner.CloneExpr(original.Guard);
            Thn = cloner.CloneBlockStmt(original.Thn);
            Els = cloner.CloneStmt(original.Els, MutateCSharp.Schemata155.ReplaceBooleanConstant_0(1L, false));
        }

        public IfStmt(RangeToken rangeToken, bool isBindingGuard, Expression guard, BlockStmt thn, Statement els)
          : base(rangeToken)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(!isBindingGuard || (guard is ExistsExpr && ((ExistsExpr)guard).Range == null));
            Contract.Requires(thn != null);
            Contract.Requires(els == null || els is BlockStmt || els is IfStmt || els is SkeletonStatement);
            this.IsBindingGuard = isBindingGuard;
            this.Guard = guard;
            this.Thn = thn;
            this.Els = els;
        }
        public IfStmt(RangeToken rangeToken, bool isBindingGuard, Expression guard, BlockStmt thn, Statement els, Attributes attrs)
          : base(rangeToken, attrs)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(!isBindingGuard || (guard is ExistsExpr && ((ExistsExpr)guard).Range == null));
            Contract.Requires(thn != null);
            Contract.Requires(els == null || els is BlockStmt || els is IfStmt || els is SkeletonStatement);
            this.IsBindingGuard = isBindingGuard;
            this.Guard = guard;
            this.Thn = thn;
            this.Els = els;
        }
        public override IEnumerable<Statement> SubStatements
        {
            get
            {
                yield return Thn;
                if (MutateCSharp.Schemata155.ReplaceBinExprOp_1(2L, Els, null))
                {
                    yield return Els;
                }

                yield break;
            }
        }

        public override IEnumerable<Expression> NonSpecificationSubExpressions
        {
            get
            {
                foreach (var e in base.NonSpecificationSubExpressions) { yield return e; }
                if (MutateCSharp.Schemata155.ReplaceBinExprOp_2(3L, Guard, null))
                {
                    yield return Guard;
                }

                yield break;
            }
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            foreach (var token in OwnedTokens)
            {
                if (formatter.SetIndentLabelTokens(token, indentBefore))
                {
                    continue;
                }
                switch (token.val)
                {
                    case "if":
                        {
                            formatter.SetOpeningIndentedRegion(token, indentBefore);
                            formatter.Visit(Guard, indentBefore);
                            formatter.SetIndentBody(Thn, indentBefore);
                            break;
                        }

                        break;
                    case "else":
                        {
                            formatter.SetKeywordWithoutSurroundingIndentation(token, indentBefore);
                            formatter.SetIndentBody(Els, indentBefore);
                            break;
                        }

                        break;
                }
            }
            return MutateCSharp.Schemata155.ReplaceBooleanConstant_0(4L, false);
        }
    }
}