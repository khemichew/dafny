using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata7
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT7");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.Node argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class ActualBindings : TokenNode
    {
        public readonly List<ActualBinding> ArgumentBindings;

        public ActualBindings(List<ActualBinding> argumentBindings)
        {
            Contract.Requires(argumentBindings != null);
            ArgumentBindings = argumentBindings;
        }

        public ActualBindings(Cloner cloner, ActualBindings original)
        {
            ArgumentBindings = original.ArgumentBindings.Select(actualBinding => new ActualBinding(
        MutateCSharp.Schemata7.ReplaceBinExprOp_0(1L, actualBinding.FormalParameterName, null) ? null : cloner.Tok((IToken)actualBinding.FormalParameterName),
              cloner.CloneExpr(actualBinding.Actual))).ToList();
            if (cloner.CloneResolvedFields)
            {
                arguments = original.Arguments?.Select(cloner.CloneExpr).ToList();
            }
        }

        public ActualBindings(List<Expression> actuals)
        {
            Contract.Requires(actuals != null);
            ArgumentBindings = actuals.ConvertAll(actual => new ActualBinding(null, actual));
        }

        [FilledInDuringResolution]
        private List<Expression> arguments; // set by ResolveActualParameters during resolution

        public bool WasResolved => MutateCSharp.Schemata7.ReplaceBinExprOp_1(2L, arguments, null);

        public List<Expression> Arguments => arguments;

        public void AcceptArgumentExpressionsAsExactParameterList(List<Expression> args = null)
        {
            Contract.Requires(!WasResolved); // this operation should be done at most once
            Contract.Assume(ArgumentBindings.TrueForAll(arg => arg.Actual.WasResolved()));
            arguments = args ?? ArgumentBindings.ConvertAll(binding => binding.Actual);
        }

        public override IEnumerable<INode> Children => MutateCSharp.Schemata7.ReplaceBinExprOp_2(3L, arguments, null) ? ArgumentBindings : arguments;
        public override IEnumerable<INode> PreResolveChildren => Children;
    }

    public class ActualBinding : TokenNode
    {
        public readonly IToken /*?*/ FormalParameterName;
        public readonly Expression Actual;
        public readonly bool IsGhost;

        public override IEnumerable<INode> Children => new List<Node> { Actual }.Where(x => MutateCSharp.Schemata7.ReplaceBinExprOp_3(4L, x, null));

        public override IEnumerable<INode> PreResolveChildren => Children;

        public ActualBinding(IToken /*?*/ formalParameterName, Expression actual, bool isGhost = false)
        {
            Contract.Requires(actual != null);
            FormalParameterName = formalParameterName;
            Actual = actual;
            IsGhost = isGhost;
        }
    }
}