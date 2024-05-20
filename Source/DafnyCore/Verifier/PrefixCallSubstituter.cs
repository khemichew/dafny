using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata506
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT506");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.ExtremePredicate argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() && argument2();
        }

    }
}

namespace Microsoft.Dafny
{
    public class PrefixCallSubstituter : Substituter
    {
        readonly ExtremePredicate extremePred;
        readonly Expression unrollDepth;
        readonly ModuleDefinition module;
        public PrefixCallSubstituter(Expression receiverReplacement, Dictionary<IVariable, Expression/*!*/>/*!*/ substMap, Dictionary<TypeParameter, Type> tySubstMap, ExtremePredicate extremePredicate, Expression depth)
          : base(receiverReplacement, substMap, tySubstMap)
        {
            Contract.Requires(extremePredicate != null);
            Contract.Requires(depth != null);
            extremePred = extremePredicate;
            unrollDepth = depth;
            module = extremePredicate.EnclosingClass.EnclosingModuleDefinition;
        }
        public override Expression Substitute(Expression expr)
        {
            if (expr is FunctionCallExpr)
            {
                var e = (FunctionCallExpr)expr;
                var cof = e.Function as ExtremePredicate;
                if (MutateCSharp.Schemata506.ReplaceBinExprOp_1(2L, () => MutateCSharp.Schemata506.ReplaceBinExprOp_0(1L, cof, null), () => ModuleDefinition.InSameSCC(cof, extremePred)))
                {
                    expr = cof.CreatePrefixPredicateCall(e, unrollDepth);
                }
            }
            return base.Substitute(expr);
        }
    }
}