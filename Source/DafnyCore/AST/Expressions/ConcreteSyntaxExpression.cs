using System;
using System.Collections.Generic;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata36
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT36");
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

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.RangeToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{

    /// <summary>
    /// This class represents a piece of concrete syntax in the parse tree.  During resolution,
    /// it gets "replaced" by the expression in "ResolvedExpression".
    /// </summary>
    public abstract class ConcreteSyntaxExpression : Expression
    {
        protected ConcreteSyntaxExpression(Cloner cloner, ConcreteSyntaxExpression original) : base(cloner, original)
        {
            if (MutateCSharp.Schemata36.ReplaceBinExprOp_1(2L, () => cloner.CloneResolvedFields, () => MutateCSharp.Schemata36.ReplaceBinExprOp_0(1L, original.ResolvedExpression, null)))
            {
                ResolvedExpression = cloner.CloneExpr(original.ResolvedExpression);
            }
        }

        [FilledInDuringResolution]
        private Expression resolvedExpression;

        public Expression ResolvedExpression
        {
            get => resolvedExpression;
            set
            {
                resolvedExpression = value;
                if (MutateCSharp.Schemata36.ReplaceBinExprOp_1(10L, () => MutateCSharp.Schemata36.ReplaceBinExprOp_2(8L, rangeToken, null), () => MutateCSharp.Schemata36.ReplaceBinExprOp_0(9L, resolvedExpression, null)))
                {
                    resolvedExpression.RangeToken = rangeToken;
                }
            }
        }

        public ConcreteSyntaxExpression(IToken tok)
          : base(tok)
        {
        }
        public override IEnumerable<INode> Children => MutateCSharp.Schemata36.ReplaceBinExprOp_3(16L, ResolvedExpression, null) ? Array.Empty<Node>() : new[] { ResolvedExpression };
        public override IEnumerable<Expression> SubExpressions
        {
            get
            {
                if (MutateCSharp.Schemata36.ReplaceBinExprOp_0(17L, ResolvedExpression, null))
                {
                    yield return ResolvedExpression;
                }

                yield break;
            }
        }

        public override IEnumerable<Expression> TerminalExpressions
        {
            get
            {
                foreach (var e in ResolvedExpression.TerminalExpressions)
                {
                    yield return e;
                }

                yield break;
            }
        }

        public virtual IEnumerable<Expression> PreResolveSubExpressions => Enumerable.Empty<Expression>();
        public override IEnumerable<INode> PreResolveChildren => PreResolveSubExpressions;

        public override IEnumerable<Type> ComponentTypes => ResolvedExpression.ComponentTypes;
    }
}