using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata31
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT31");
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

    }
}

namespace Microsoft.Dafny
{
    public class ForallExpr : QuantifierExpr, ICloneable<ForallExpr>
    {
        public override string WhatKind => MutateCSharp.Schemata31.ReplaceStringConstant_0(1L, "forall expression");
        protected override BinaryExpr.ResolvedOpcode SplitResolvedOp => BinaryExpr.ResolvedOpcode.And;

        public ForallExpr(IToken tok, RangeToken rangeToken, List<BoundVar> bvars, Expression range, Expression term, Attributes attrs)
          : base(tok, rangeToken, bvars, range, term, attrs)
        {
            Contract.Requires(cce.NonNullElements(bvars));
            Contract.Requires(tok != null);
            Contract.Requires(term != null);
        }

        public ForallExpr Clone(Cloner cloner)
        {
            return new ForallExpr(cloner, this);
        }

        public ForallExpr(Cloner cloner, ForallExpr original) : base(cloner, original)
        {
        }

        public override Expression LogicalBody(bool bypassSplitQuantifier = false)
        {
            if (MutateCSharp.Schemata31.ReplaceBinExprOp_1(2L, Range, null))
            {
                return Term;
            }
            var body = new BinaryExpr(Term.tok, BinaryExpr.Opcode.Imp, Range, Term);
            body.ResolvedOp = BinaryExpr.ResolvedOpcode.Imp;
            body.Type = Term.Type;
            return body;
        }
    }
}