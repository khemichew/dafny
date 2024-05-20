using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata1
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT1");
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

        internal static bool ReplaceBinExprOp_1(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_2(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    /// <summary>
    /// This substituter performs substitutions in such a way that it's okay to print the resulting expression without a human getting confused.
    /// More precisely, bound variables first gets alpha-renamed.  Also, "this" is never left implicit, including in the
    /// case where "receiverReplacement" is given as ImplicitThisExpr (but no attempt is made to substitute for all ImplicitThisExpr's in
    /// "receiverReplacement" and the range of "substMap").
    /// </summary>
    public class AlphaConvertingSubstituter : Substituter
    {
        public AlphaConvertingSubstituter(Expression receiverReplacement, Dictionary<IVariable, Expression> substMap, Dictionary<TypeParameter, Type> typeMap)
          : base(receiverReplacement is ImplicitThisExpr ? new ThisExpr(receiverReplacement.tok) { Type = receiverReplacement.Type } : receiverReplacement, substMap, typeMap)
        {
            Contract.Requires(substMap != null);
            Contract.Requires(typeMap != null);
        }
        protected override List<BoundVar> CreateBoundVarSubstitutions(List<BoundVar> vars, bool forceSubstitutionOfBoundVars)
        {
            var newBoundVars = MutateCSharp.Schemata1.ReplaceBinExprOp_1(5L, vars.Count, MutateCSharp.Schemata1.ReplaceNumericConstant_0(1L, 0)) ? vars : new List<BoundVar>();
            foreach (var bv in vars)
            {
                var tt = bv.Type.Subst(typeMap);
                var newBv = new BoundVar(bv.tok, MutateCSharp.Schemata1.ReplaceStringConstant_2(10L, "_'") + bv.Name, tt);
                newBoundVars.Add(newBv);
                // update substMap to reflect the new BoundVar substitutions
                var ie = new IdentifierExpr(newBv.tok, newBv.Name) { Var = newBv, Type = newBv.Type };
                substMap.Add(bv, ie);
            }
            return newBoundVars;
        }
    }
}