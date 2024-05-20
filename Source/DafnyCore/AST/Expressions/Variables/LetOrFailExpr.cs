using System.Collections.Generic;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata78
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT78");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.CasePattern<Microsoft.Dafny.BoundVar> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.CasePattern<Microsoft.Dafny.BoundVar> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public class LetOrFailExpr : ConcreteSyntaxExpression, ICloneable<LetOrFailExpr>, ICanFormat
    {
        public readonly CasePattern<BoundVar>/*?*/ Lhs; // null means void-error handling: ":- E; F", non-null means "var pat :- E; F"
        public readonly Expression Rhs;
        public readonly Expression Body;

        public LetOrFailExpr(IToken tok, CasePattern<BoundVar>/*?*/ lhs, Expression rhs, Expression body) : base(tok)
        {
            Lhs = lhs;
            Rhs = rhs;
            Body = body;
        }

        public override IEnumerable<Expression> PreResolveSubExpressions
        {
            get
            {
                yield return Rhs;
                yield return Body;
            }
        }

        public LetOrFailExpr Clone(Cloner cloner)
        {
            return new LetOrFailExpr(cloner, this);
        }

        public LetOrFailExpr(Cloner cloner, LetOrFailExpr original) : base(cloner, original)
        {
            Lhs = MutateCSharp.Schemata78.ReplaceBinExprOp_0(1L, original.Lhs, null) ? null : cloner.CloneCasePattern(original.Lhs);
            Rhs = cloner.CloneExpr(original.Rhs);
            Body = cloner.CloneExpr(original.Body);
        }

        public override IEnumerable<INode> Children =>
          (MutateCSharp.Schemata78.ReplaceBinExprOp_1(2L, Lhs, null) ?
            new List<Node> { Lhs } : Enumerable.Empty<Node>()).Concat(base.Children);

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            return formatter.SetIndentVarDeclStmt(indentBefore, OwnedTokens, MutateCSharp.Schemata78.ReplaceBinExprOp_0(3L, Lhs, null), MutateCSharp.Schemata78.ReplaceBooleanConstant_2(4L, true));
        }
    }
}