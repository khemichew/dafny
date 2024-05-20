using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata52
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT52");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.Field argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class FrameExpression : TokenNode, IHasUsages
    {
        public readonly Expression OriginalExpression; // may be a WildcardExpr
        [FilledInDuringResolution] public Expression DesugaredExpression; // may be null for modifies clauses, even after resolution

        /// <summary>
        /// .E starts off as OriginalExpression; destructively updated to its desugared version during resolution
        /// </summary>
        public Expression E => DesugaredExpression ?? OriginalExpression;

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(E != null);
            Contract.Invariant(!(E is WildcardExpr) || (FieldName == null && Field == null));
        }

        public readonly string FieldName;
        [FilledInDuringResolution] public Field Field;  // null if FieldName is

        /// <summary>
        /// If a "fieldName" is given, then "tok" denotes its source location.  Otherwise, "tok"
        /// denotes the source location of "e".
        /// </summary>
        public FrameExpression(IToken tok, Expression e, string fieldName)
        {
            Contract.Requires(tok != null);
            Contract.Requires(e != null);
            Contract.Requires(!(e is WildcardExpr) || fieldName == null);
            this.tok = tok;
            OriginalExpression = e;
            FieldName = fieldName;
        }

        public FrameExpression(Cloner cloner, FrameExpression original)
        {
            this.tok = cloner.Tok(original.tok);
            OriginalExpression = cloner.CloneExpr(original.OriginalExpression);
            FieldName = original.FieldName;

            if (cloner.CloneResolvedFields)
            {
                Field = original.Field;
                if (MutateCSharp.Schemata52.ReplaceBinExprOp_0(1L, original.DesugaredExpression, null))
                {
                    DesugaredExpression = cloner.CloneExpr(original.DesugaredExpression);
                }
            }
        }

        public IToken NameToken => tok;
        public override IEnumerable<INode> Children => new[] { E };
        public override IEnumerable<INode> PreResolveChildren => Children;
        public IEnumerable<IDeclarationOrUsage> GetResolvedDeclarations()
        {
            return new[] { Field }.Where(x => MutateCSharp.Schemata52.ReplaceBinExprOp_1(2L, x, null));
        }
    }
}