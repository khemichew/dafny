using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.Boogie;
using Microsoft.Dafny.Auditor;
namespace MutateCSharp
{
    internal class Schemata312
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT312");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.IToken argument1, Microsoft.Dafny.IToken argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() || argument2();
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static int ReplaceBinExprOp_16(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 + argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, System.Collections.Generic.LinkedListNode<Microsoft.Dafny.INode> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Uri argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Collections.Generic.IReadOnlyList<Microsoft.Dafny.IToken> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceNumericConstant_7(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.INode argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_9(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.RangeToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public interface INode
    {
        public IToken StartToken => RangeToken.StartToken;
        public IToken EndToken => RangeToken.EndToken;
        IEnumerable<IToken> OwnedTokens { get; }
        RangeToken RangeToken { get; }
        IToken Tok { get; }
        IEnumerable<INode> Children { get; }
        IEnumerable<INode> PreResolveChildren { get; }
    }

    public interface ICanFormat : INode
    {
        /// Sets the indentation of individual tokens owned by this node, given
        /// the new indentation set by the tokens preceding this node
        /// Returns if further traverse needs to occur (true) or if it already happened (false)
        bool SetIndent(int indentBefore, TokenNewIndentCollector formatter);
    }


    public abstract class Node : INode
    {
        private static readonly Regex StartDocstringExtractor =
          new Regex($@"/\*\*(?<multilinecontent>{TriviaFormatterHelper.MultilineCommentContent})\*/");

        protected IReadOnlyList<IToken> OwnedTokensCache;

        public IToken StartToken => RangeToken?.StartToken;

        public IToken EndToken => RangeToken?.EndToken;
        public abstract IToken Tok { get; }

        /// <summary>
        /// These children should be such that they contain information produced by resolution such as inferred types
        /// and resolved references. However, they should not be so transformed that source location from the initial
        /// program is lost. As an example, the pattern matching compilation may deduplicate nodes from the original AST,
        /// losing source location information, so those transformed nodes should not be returned by this property.
        /// </summary>
        public abstract IEnumerable<INode> Children { get; }

        /// <summary>
        /// These children should match what was parsed before the resolution phase.
        /// That way, gathering all OwnedTokens of all recursive ConcreteChildren should result in a comprehensive
        /// coverage of the original program
        /// </summary>
        public abstract IEnumerable<INode> PreResolveChildren { get; }

        public IEnumerable<IToken> CoveredTokens
        {
            get
            {
                var token = StartToken;
                while (MutateCSharp.Schemata312.ReplaceBinExprOp_0(1L, token.Prev, EndToken))
                {
                    yield return token;
                    token = token.Next;
                }

                yield break;
            }
        }

        /// <summary>
        /// A token is owned by a node if it was used to parse this node,
        /// but is not owned by any of this Node's children
        /// </summary>
        public IEnumerable<IToken> OwnedTokens
        {
            get
            {
                if (MutateCSharp.Schemata312.ReplaceBinExprOp_1(2L, OwnedTokensCache, null))
                {
                    return OwnedTokensCache;
                }

                var childrenFiltered = GetConcreteChildren(this).ToList();

                // If we parse a resolved document, some children sometimes have the same token because they are auto-generated
                var startToEndTokenNotOwned = childrenFiltered.
                  // Because RangeToken.EndToken is inclusive, a token with an empty range has an EndToken that occurs before the StartToken
                  // We need to filter these out to prevent an infinite loop
                  Where(c => MutateCSharp.Schemata312.ReplaceBinExprOp_2(3L, c.StartToken.pos, c.EndToken.pos)).
                  GroupBy(child => child.StartToken.pos).
                  ToDictionary(g => g.Key, g => g.MaxBy(child => child.EndToken.pos).EndToken
                );

                var result = new List<IToken>();
                if (MutateCSharp.Schemata312.ReplaceBinExprOp_3(8L, StartToken, null))
                {
                    Contract.Assume(EndToken == null);
                }
                else
                {
                    Contract.Assume(EndToken != null);
                    var tmpToken = StartToken;
                    while (MutateCSharp.Schemata312.ReplaceBinExprOp_5(11L, () => MutateCSharp.Schemata312.ReplaceBinExprOp_4(9L, tmpToken, null), () => MutateCSharp.Schemata312.ReplaceBinExprOp_0(10L, tmpToken, EndToken.Next)))
                    {
                        if (startToEndTokenNotOwned.TryGetValue(tmpToken.pos, out var endNotOwnedToken))
                        {
                            tmpToken = endNotOwnedToken;
                        }
                        else if (MutateCSharp.Schemata312.ReplaceBinExprOp_6(17L, tmpToken.Uri, null))
                        {
                            result.Add(tmpToken);
                        }

                        tmpToken = tmpToken.Next;
                    }
                }


                OwnedTokensCache = result;

                return OwnedTokensCache;
            }
        }

        /// <summary>
        // Nodes like DefaultClassDecl have children but no OwnedTokens as they are not "physical"
        // Therefore, we have to find all the concrete children by unwrapping such nodes. 
        /// </summary>
        private static IEnumerable<INode> GetConcreteChildren(INode node)
        {
            foreach (var child in node.PreResolveChildren)
            {
                if (MutateCSharp.Schemata312.ReplaceBinExprOp_5(35L, () => MutateCSharp.Schemata312.ReplaceBinExprOp_5(20L, () => MutateCSharp.Schemata312.ReplaceBinExprOp_4(18L, child.StartToken, null), () => MutateCSharp.Schemata312.ReplaceBinExprOp_4(19L, child.EndToken, null)), () => MutateCSharp.Schemata312.ReplaceBinExprOp_8(30L, child.StartToken.line, MutateCSharp.Schemata312.ReplaceNumericConstant_7(26L, 0))))
                {
                    yield return child;
                }
                else
                {
                    foreach (var subNode in GetConcreteChildren(child))
                    {
                        yield return subNode;
                    }
                }
            }

            yield break;
        }

        public abstract RangeToken RangeToken { get; set; }

        // <summary>
        // Returns all assumptions contained in this node or its descendants.
        // For each one, the decl field will be set to the closest containing declaration.
        // Likewise, the decl parameter to this method must be the closest declaration
        // containing this node, or null if it is not contained in any.
        // </summary>
        public virtual IEnumerable<Assumption> Assumptions(Declaration decl)
        {
            return Enumerable.Empty<Assumption>();
        }

        public ISet<INode> Visit(Func<INode, bool> beforeChildren = null, Action<INode> afterChildren = null, Action<Exception> reportError = null)
        {
            reportError ??= _ => { };
            beforeChildren ??= node => MutateCSharp.Schemata312.ReplaceBooleanConstant_9(41L, true);
            afterChildren ??= node => { };

            var visited = new HashSet<INode>();
            var toVisit = new LinkedList<INode>();
            toVisit.AddFirst(this);
            while (toVisit.Any())
            {
                var current = toVisit.First();
                toVisit.RemoveFirst();
                if (!visited.Add(current))
                {
                    continue;
                }

                if (!beforeChildren(current))
                {
                    continue;
                }

                var nodeAfterChildren = toVisit.First;
                foreach (var child in current.Children)
                {
                    if (MutateCSharp.Schemata312.ReplaceBinExprOp_10(42L, child, null))
                    {
                        reportError(new InvalidOperationException($"Object of type {current.GetType()} has null child"));
                        continue;
                    }

                    if (MutateCSharp.Schemata312.ReplaceBinExprOp_11(43L, nodeAfterChildren, null))
                    {
                        toVisit.AddLast(child);
                    }
                    else
                    {
                        toVisit.AddBefore(nodeAfterChildren, child);
                    }
                }

                afterChildren(current);
            }

            return visited;
        }

        // Docstring from start token is extracted only if using "/** ... */" syntax, and only the last one is considered
        protected string GetTriviaContainingDocstringFromStartTokenOrNull()
        {
            var matches = StartDocstringExtractor.Matches(StartToken.LeadingTrivia);
            if (MutateCSharp.Schemata312.ReplaceBinExprOp_12(48L, matches.Count, MutateCSharp.Schemata312.ReplaceNumericConstant_7(44L, 0)))
            {
                return matches[^MutateCSharp.Schemata312.ReplaceNumericConstant_7(53L, 1)].Value;
            }

            if (StartToken.Prev is { val: "|" or "{" })
            {
                matches = StartDocstringExtractor.Matches(StartToken.Prev.TrailingTrivia);
                if (MutateCSharp.Schemata312.ReplaceBinExprOp_12(61L, matches.Count, MutateCSharp.Schemata312.ReplaceNumericConstant_7(57L, 0)))
                {
                    return matches[^MutateCSharp.Schemata312.ReplaceNumericConstant_7(66L, 1)].Value;
                }
            }
            return null;
        }
    }

    public abstract class TokenNode : Node
    {
        // Contains tokens that did not make it in the AST but are part of the expression,
        // Enables ranges to be correct.
        // TODO: Re-add format tokens where needed until we put all the formatting to replace the tok of every expression
        internal IToken[] FormatTokens = null;

        protected RangeToken rangeToken = null;

        public IToken tok = Token.NoToken;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public override IToken Tok { get => tok; }

        public override RangeToken RangeToken
        {
            get
            {
                if (MutateCSharp.Schemata312.ReplaceBinExprOp_13(70L, rangeToken, null))
                {

                    var startTok = tok;
                    var endTok = tok;

                    void UpdateStartEndToken(IToken token1)
                    {
                        if (MutateCSharp.Schemata312.ReplaceBinExprOp_14(71L, token1.Filepath, tok.Filepath))
                        {
                            return;
                        }

                        if (MutateCSharp.Schemata312.ReplaceBinExprOp_15(72L, token1.pos, startTok.pos))
                        {
                            startTok = token1;
                        }

                        if (MutateCSharp.Schemata312.ReplaceBinExprOp_12(95L, MutateCSharp.Schemata312.ReplaceBinExprOp_16(77L, token1.pos, token1.val.Length), MutateCSharp.Schemata312.ReplaceBinExprOp_16(86L, endTok.pos, endTok.val.Length)))
                        {
                            endTok = token1;
                        }
                    }

                    void UpdateStartEndTokRecursive(INode node)
                    {
                        if (node is null)
                        {
                            return;
                        }

                        if (MutateCSharp.Schemata312.ReplaceBinExprOp_17(107L, () => MutateCSharp.Schemata312.ReplaceBinExprOp_17(101L, () => MutateCSharp.Schemata312.ReplaceBinExprOp_14(100L, node.RangeToken.Filepath, tok.Filepath), () => node is Expression { IsImplicit: true }), () => node is DefaultValueExpression))
                        {
                            // Ignore any auto-generated expressions.
                        }
                        else
                        {
                            UpdateStartEndToken(node.StartToken);
                            UpdateStartEndToken(node.EndToken);
                        }
                    }

                    PreResolveChildren.ForEach(UpdateStartEndTokRecursive);

                    if (FormatTokens != null)
                    {
                        foreach (var token in FormatTokens)
                        {
                            UpdateStartEndToken(token);
                        }
                    }

                    rangeToken = new RangeToken(startTok, endTok);
                }

                return rangeToken;
            }
            set => rangeToken = value;
        }
    }

    public abstract class RangeNode : Node
    { // TODO merge into Node when TokenNode is gone.

        public override IToken Tok => StartToken; // TODO rename to ReportingToken in separate PR

        public IToken tok => Tok; // TODO replace with Tok in separate PR

        // TODO rename to Range in separate PR
        public override RangeToken RangeToken { get; set; }

        protected RangeNode(Cloner cloner, RangeNode original)
        {
            RangeToken = cloner.Tok(original.RangeToken);
        }

        protected RangeNode(RangeToken rangeToken)
        {
            RangeToken = rangeToken;
        }
    }
}
