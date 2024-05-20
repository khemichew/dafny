using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata9
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT9");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_4(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.ActualBinding> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.ActualBindings argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{

    /// <summary>
    /// An ApplySuffix desugars into either an ApplyExpr or a FunctionCallExpr
    /// </summary>
    public class ApplySuffix : SuffixExpr, ICloneable<ApplySuffix>, ICanFormat
    {
        public readonly IToken/*?*/ AtTok;
        public readonly IToken CloseParen;
        public readonly ActualBindings Bindings;
        public List<Expression> Args => Bindings.Arguments;
        [FilledInDuringResolution] public MethodCallInformation MethodCallInfo = null; // resolution will set to a non-null value if ApplySuffix makes a method call

        public override IEnumerable<INode> Children => MutateCSharp.Schemata9.ReplaceBinExprOp_0(1L, ResolvedExpression, null
      ) ? base.Children.Concat(MutateCSharp.Schemata9.ReplaceBinExprOp_1(2L, Bindings, null) ? new List<Node>() : Args ?? Enumerable.Empty<Node>()) : new[] { ResolvedExpression };
        public override IEnumerable<INode> PreResolveChildren => new List<Node> { Lhs, Bindings };

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(Args != null);
        }

        public ApplySuffix Clone(Cloner cloner)
        {
            return new ApplySuffix(cloner, this);
        }

        public ApplySuffix(Cloner cloner, ApplySuffix original) :
          base(cloner, original)
        {
            AtTok = MutateCSharp.Schemata9.ReplaceBinExprOp_2(3L, original.AtTok, null) ? null : cloner.Tok(original.AtTok);
            CloseParen = cloner.Tok(original.CloseParen);
            FormatTokens = original.FormatTokens;
            Bindings = new ActualBindings(cloner, original.Bindings);
        }

        public ApplySuffix(IToken tok, IToken/*?*/ atLabel, Expression lhs, List<ActualBinding> args, IToken closeParen)
          : base(tok, lhs)
        {
            Contract.Requires(tok != null);
            Contract.Requires(lhs != null);
            Contract.Requires(cce.NonNullElements(args));
            AtTok = atLabel;
            CloseParen = closeParen;
            Bindings = new ActualBindings(args);
            if (MutateCSharp.Schemata9.ReplaceBinExprOp_3(4L, closeParen, null))
            {
                FormatTokens = new[] { closeParen };
            }
        }

        public override IEnumerable<Expression> PreResolveSubExpressions
        {
            get
            {
                yield return Lhs;
                if (MutateCSharp.Schemata9.ReplaceBinExprOp_4(5L, Bindings.ArgumentBindings, null))
                {
                    foreach (var binding in Bindings.ArgumentBindings)
                    {
                        yield return binding.Actual;
                    }
                }

                yield break;
            }
        }

        /// <summary>
        /// Create an ApplySuffix expression using the most basic pieces: a target name and a list of expressions.
        /// </summary>
        /// <param name="tok">The location to associate with the new ApplySuffix expression.</param>
        /// <param name="name">The name of the target function or method.</param>
        /// <param name="args">The arguments to apply the function or method to.</param>
        /// <returns></returns>
        public static Expression MakeRawApplySuffix(IToken tok, string name, List<Expression> args)
        {
            var nameExpr = new NameSegment(tok, name, null);
            var argBindings = args.ConvertAll(arg => new ActualBinding(null, arg));
            return new ApplySuffix(tok, null, nameExpr, argBindings, tok);
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            var reindent = formatter.ReduceBlockiness ? indentBefore
              : formatter.GetNewTokenVisualIndent(StartToken, indentBefore);
            return formatter.SetIndentParensExpression(reindent, OwnedTokens);
        }
    }
}