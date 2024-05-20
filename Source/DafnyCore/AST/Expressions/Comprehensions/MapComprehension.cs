using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata33
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT33");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.IVariable argument1, Microsoft.Dafny.BoundVar argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static int ReplaceNumericConstant_3(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class MapComprehension : ComprehensionExpr, ICloneable<MapComprehension>
    {
        public override string WhatKind => MutateCSharp.Schemata33.ReplaceStringConstant_0(1L, "map comprehension");

        public readonly bool Finite;
        public readonly Expression TermLeft;

        public List<Boogie.Function> ProjectionFunctions;  // filled in during translation (and only for general map comprehensions where "TermLeft != null")

        public MapComprehension Clone(Cloner cloner)
        {
            return new MapComprehension(cloner, this);
        }

        public MapComprehension(Cloner cloner, MapComprehension original) : base(cloner, original)
        {
            TermLeft = cloner.CloneExpr(original.TermLeft);
            Finite = original.Finite;
        }

        public MapComprehension(IToken tok, RangeToken rangeToken, bool finite, List<BoundVar> bvars, Expression range, Expression/*?*/ termLeft, Expression termRight, Attributes attrs)
          : base(tok, rangeToken, bvars, range, termRight, attrs)
        {
            Contract.Requires(tok != null);
            Contract.Requires(cce.NonNullElements(bvars));
            Contract.Requires(1 <= bvars.Count);
            Contract.Requires(range != null);
            Contract.Requires(termRight != null);
            Contract.Requires(termLeft != null || bvars.Count == 1);

            Finite = finite;
            TermLeft = termLeft;
        }

        /// <summary>
        /// IsGeneralMapComprehension returns true for general map comprehensions.
        /// In other words, it returns false if either no TermLeft was given or if
        /// the given TermLeft is the sole bound variable.
        /// This property getter requires that the expression has been successfully
        /// resolved.
        /// </summary>
        public bool IsGeneralMapComprehension
        {
            get
            {
                Contract.Requires(WasResolved());
                if (MutateCSharp.Schemata33.ReplaceBinExprOp_1(2L, TermLeft, null))
                {
                    return MutateCSharp.Schemata33.ReplaceBooleanConstant_2(3L, false);
                }
                else if (MutateCSharp.Schemata33.ReplaceBinExprOp_4(8L, BoundVars.Count, MutateCSharp.Schemata33.ReplaceNumericConstant_3(4L, 1)))
                {
                    return MutateCSharp.Schemata33.ReplaceBooleanConstant_2(13L, true);
                }
                var lhs = StripParens(TermLeft).Resolved;
                if (lhs is IdentifierExpr ide && MutateCSharp.Schemata33.ReplaceBinExprOp_5(18L, ide.Var, BoundVars[MutateCSharp.Schemata33.ReplaceNumericConstant_3(14L, 0)]))
                {
                    // TermLeft is the sole bound variable, so this is the same as
                    // if TermLeft wasn't given at all
                    return MutateCSharp.Schemata33.ReplaceBooleanConstant_2(19L, false);
                }
                return MutateCSharp.Schemata33.ReplaceBooleanConstant_2(20L, true);
            }
        }

        public override IEnumerable<Expression> SubExpressions
        {
            get
            {
                foreach (var e in Attributes.SubExpressions(Attributes))
                {
                    yield return e;
                }
                if (MutateCSharp.Schemata33.ReplaceBinExprOp_6(21L, Range, null)) { yield return Range; }
                if (MutateCSharp.Schemata33.ReplaceBinExprOp_6(22L, TermLeft, null)) { yield return TermLeft; }
                yield return Term;
            }
        }
    }
}