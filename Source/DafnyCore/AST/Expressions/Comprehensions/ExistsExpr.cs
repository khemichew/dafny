using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata30
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT30");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class ExistsExpr : QuantifierExpr, ICloneable<ExistsExpr>
    {
        public override string WhatKind => MutateCSharp.Schemata30.ReplaceStringConstant_0(1L, "exists expression");
        protected override BinaryExpr.ResolvedOpcode SplitResolvedOp
        {
            get { return BinaryExpr.ResolvedOpcode.Or; }
        }

        public ExistsExpr(IToken tok, RangeToken rangeToken, List<BoundVar> bvars, Expression range, Expression term, Attributes attrs)
          : base(tok, rangeToken, bvars, range, term, attrs)
        {
            Contract.Requires(cce.NonNullElements(bvars));
            Contract.Requires(tok != null);
            Contract.Requires(term != null);
        }

        public ExistsExpr Clone(Cloner cloner)
        {
            return new ExistsExpr(cloner, this);
        }

        public ExistsExpr(Cloner cloner, ExistsExpr existsExpr) : base(cloner, existsExpr)
        {
        }

        public override Expression LogicalBody(bool bypassSplitQuantifier = false)
        {
            if (MutateCSharp.Schemata30.ReplaceBinExprOp_1(2L, Range, null))
            {
                return Term;
            }
            var body = new BinaryExpr(Term.tok, BinaryExpr.Opcode.And, Range, Term);
            body.ResolvedOp = BinaryExpr.ResolvedOpcode.And;
            body.Type = Term.Type;
            return body;
        }

        /// <summary>
        /// Returns an expression like 'exists' but where the bound variables have been renamed to have
        /// 'prefix' as a prefix to their previous names.
        /// Assumes the expression has been resolved.
        /// </summary>
        public Expression AlphaRename(string prefix)
        {
            Contract.Requires(this != null);
            Contract.Requires(prefix != null);

            if (MutateCSharp.Schemata30.ReplaceBinExprOp_2(3L, SplitQuantifier, null))
            {
                // TODO: what to do?  Substitute(exists.SplitQuantifierExpression);
            }

            var substMap = new Dictionary<IVariable, Expression>();
            var var4var = new Dictionary<BoundVar, BoundVar>();
            var bvars = new List<BoundVar>();
            foreach (var bv in BoundVars)
            {
                var newBv = new BoundVar(bv.tok, prefix + bv.Name, bv.Type);
                bvars.Add(newBv);
                var4var.Add(bv, newBv);
                var ie = new IdentifierExpr(newBv.tok, newBv.Name);
                ie.Var = newBv;  // resolve here
                ie.Type = newBv.Type;  // resolve here
                substMap.Add(bv, ie);
            }
            var s = new Substituter(null, substMap, new Dictionary<TypeParameter, Type>());
            var range = MutateCSharp.Schemata30.ReplaceBinExprOp_1(4L, Range, null) ? null : s.Substitute(Range);
            var term = s.Substitute(Term);
            var attrs = s.SubstAttributes(Attributes);
            var ex = new ExistsExpr(tok, RangeToken, bvars, range, term, attrs);
            ex.Type = Type.Bool;
            ex.Bounds = s.SubstituteBoundedPoolList(Bounds);
            return ex;
        }
    }
}