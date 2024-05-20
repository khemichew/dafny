using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
namespace MutateCSharp
{
    internal class Schemata313
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT313");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplacePostfixUnaryExprOp_2(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_1(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static int ReplaceBinExprOp_8(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.IToken argument1, Microsoft.Dafny.Token argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, System.Uri argument1, System.Uri argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 >= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 > argument2; }
            return argument1 >= argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, System.Uri argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.LList<Microsoft.Dafny.INode> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.IToken argument1, Microsoft.Dafny.Token argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static int ReplaceNumericConstant_0(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static string ReplaceStringConstant_3(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBooleanConstant_4(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public interface IHasDocstring
    {
        /// <summary>
        /// Unfiltered version that only returns the trivia containing the docstring
        /// </summary>
        public string GetTriviaContainingDocstring();
    }

    public static class NodeExtensions
    {

        /// <summary>
        /// // Applies plugin-defined docstring filters
        /// </summary>
        public static string GetDocstring(this IHasDocstring node, DafnyOptions options)
        {
            var plugins = options.Plugins;
            string trivia = node.GetTriviaContainingDocstring();
            if (string.IsNullOrEmpty(trivia))
            {
                return null;
            }

            var rawDocstring = ExtractDocstring(trivia);
            foreach (var plugin in plugins)
            {
                foreach (var docstringRewriter in plugin.GetDocstringRewriters(options))
                {
                    rawDocstring = docstringRewriter.RewriteDocstring(rawDocstring) ?? rawDocstring;
                }
            }

            return rawDocstring;
        }

        private static string ExtractDocstring(string trivia)
        {
            var extraction = new Regex(
              $@"(?<multiline>(?<indentation>[ \t]*)/\*(?<multilinecontent>{TriviaFormatterHelper.MultilineCommentContent})\*/)" +
              $@"|(?<singleline>// ?(?<singlelinecontent>[^\r\n]*?)[ \t]*(?:{TriviaFormatterHelper.AnyNewline}|$))");
            var rawDocstring = new List<string>() { };
            var matches = extraction.Matches(trivia);
            for (var i = MutateCSharp.Schemata313.ReplaceNumericConstant_0(1L, 0); MutateCSharp.Schemata313.ReplaceBinExprOp_1(5L, i, matches.Count); MutateCSharp.Schemata313.ReplacePostfixUnaryExprOp_2(10L, ref i))
            {
                var match = matches[i];
                if (match.Groups[MutateCSharp.Schemata313.ReplaceStringConstant_3(11L, "multiline")].Success)
                {
                    // For each line except the first,
                    // we need to remove the indentation on every line.
                    // The length of removed indentation is maximum the space before the first "/*" + 3 characters
                    // Additionally, if there is a "* " or a " *" or a "  * ", we remove it as well
                    // provided it always started with a star.
                    var indentation = match.Groups[MutateCSharp.Schemata313.ReplaceStringConstant_3(12L, "indentation")].Value;
                    var multilineContent = match.Groups[MutateCSharp.Schemata313.ReplaceStringConstant_3(13L, "multilinecontent")].Value;
                    var newlineRegex = new Regex(TriviaFormatterHelper.AnyNewline);
                    var contentLines = newlineRegex.Split(multilineContent);
                    var starRegex = new Regex(MutateCSharp.Schemata313.ReplaceStringConstant_3(14L, @"^[ \t]*\*\ ?(?<remaining>.*)$"));
                    var wasNeverInterrupted = MutateCSharp.Schemata313.ReplaceBooleanConstant_4(15L, true);
                    var localDocstring = "";
                    for (var j = MutateCSharp.Schemata313.ReplaceNumericConstant_0(16L, 0); MutateCSharp.Schemata313.ReplaceBinExprOp_1(20L, j, contentLines.Length); MutateCSharp.Schemata313.ReplacePostfixUnaryExprOp_2(25L, ref j))
                    {
                        if (MutateCSharp.Schemata313.ReplaceBinExprOp_5(30L, j, MutateCSharp.Schemata313.ReplaceNumericConstant_0(26L, 0)))
                        {
                            localDocstring += MutateCSharp.Schemata313.ReplaceStringConstant_3(35L, "\n");
                        }
                        var contentLine = contentLines[j];
                        var lineMatch = starRegex.Match(contentLine);
                        if (MutateCSharp.Schemata313.ReplaceBinExprOp_6(36L, () => lineMatch.Success, () => wasNeverInterrupted))
                        {
                            localDocstring += lineMatch.Groups[MutateCSharp.Schemata313.ReplaceStringConstant_3(42L, "remaining")].Value;
                        }
                        else
                        {
                            if (MutateCSharp.Schemata313.ReplaceBinExprOp_7(47L, j, MutateCSharp.Schemata313.ReplaceNumericConstant_0(43L, 0)))
                            {
                                localDocstring += contentLine.TrimStart();
                            }
                            else
                            {
                                wasNeverInterrupted = MutateCSharp.Schemata313.ReplaceBooleanConstant_4(52L, false);
                                if (contentLine.StartsWith(indentation))
                                {
                                    var trimmedIndentation =
                                      contentLine.Substring(MutateCSharp.Schemata313.ReplaceNumericConstant_0(53L, 0), Math.Min(MutateCSharp.Schemata313.ReplaceBinExprOp_8(61L, indentation.Length, MutateCSharp.Schemata313.ReplaceNumericConstant_0(57L, 3)), contentLine.Length)).TrimStart();
                                    var remaining = (MutateCSharp.Schemata313.ReplaceBinExprOp_9(83L, contentLine.Length, MutateCSharp.Schemata313.ReplaceBinExprOp_8(74L, indentation.Length, MutateCSharp.Schemata313.ReplaceNumericConstant_0(70L, 3
                    ))) ? contentLine.Substring(MutateCSharp.Schemata313.ReplaceBinExprOp_8(92L, indentation.Length, MutateCSharp.Schemata313.ReplaceNumericConstant_0(88L, 3)))
                                      : "");
                                    localDocstring += trimmedIndentation + remaining;
                                }
                                else
                                {
                                    localDocstring += contentLine.Trim();
                                }
                            }
                        }
                    }

                    localDocstring = localDocstring.Trim();
                    rawDocstring.Add(localDocstring);
                }
                else if (match.Groups[MutateCSharp.Schemata313.ReplaceStringConstant_3(101L, "singleline")].Success)
                {
                    rawDocstring.Add(match.Groups[MutateCSharp.Schemata313.ReplaceStringConstant_3(102L, "singlelinecontent")].Value);
                }
            }

            return string.Join(MutateCSharp.Schemata313.ReplaceStringConstant_3(103L, "\n"), rawDocstring);
        }

        public static IEnumerable<INode> Descendants(this INode node)
        {
            return node.Children.Concat(node.Children.SelectMany(n => n.Descendants()));
        }

        public static T FindNode<T>(this INode root, Uri uri, DafnyPosition position)
        {
            return (T)root.FindNodeChain(uri, position, null, node => node is T)?.Data;
        }

        public static INode FindNode(this INode node, Uri uri, DafnyPosition position, Func<INode, bool> predicate)
        {
            return node.FindNodeChain(uri, position, null, predicate)?.Data;
        }

        public static IEnumerable<INode> FindNodesInUris(this INode node, Uri uri)
        {
            return node.FindNodeChainsInUri(uri, null).Select(c => c.Data);
        }

        public static IEnumerable<LList<INode>> FindNodeChainsInUri(this INode node, Uri uri, LList<INode> parent)
        {
            if (MutateCSharp.Schemata313.ReplaceBinExprOp_10(104L, node.RangeToken.Uri, null))
            {
                if (MutateCSharp.Schemata313.ReplaceBinExprOp_11(105L, node.RangeToken.Uri, uri))
                {
                    return new[] { new LList<INode>(node, parent) };
                }

                return new LList<INode>[] { };
            }

            var newParent = new LList<INode>(node, parent);
            return node.Children.SelectMany(child => child.FindNodeChainsInUri(uri, newParent));
        }

        private static LList<INode> FindNodeChain(this INode node, Uri uri, DafnyPosition position, LList<INode> parent,
          Func<INode, bool> predicate)
        {
            if (MutateCSharp.Schemata313.ReplaceBinExprOp_10(106L, node.RangeToken.Uri, null))
            {
                if (MutateCSharp.Schemata313.ReplaceBinExprOp_11(107L, node.RangeToken.Uri, uri))
                {
                    return node.FindNodeChain(position, parent, predicate);
                }

                return null;
            }

            var newParent = new LList<INode>(node, parent);
            foreach (var child in node.Children)
            {
                var result = child.FindNodeChain(uri, position, newParent, predicate);
                if (MutateCSharp.Schemata313.ReplaceBinExprOp_12(108L, result, null))
                {
                    return result;
                }
            }

            return null;
        }

        public static LList<INode> FindNodeChain(this INode node, DafnyPosition position, Func<INode, bool> predicate)
        {
            return FindNodeChain(node, position, new LList<INode>(node, null), predicate);
        }

        private static LList<INode> FindNodeChain(this INode node, DafnyPosition position, LList<INode> parent,
          Func<INode, bool> predicate)
        {
            if (MutateCSharp.Schemata313.ReplaceBinExprOp_14(116L, () => node.Tok is AutoGeneratedToken, () => (MutateCSharp.Schemata313.ReplaceBinExprOp_6(110L, () => MutateCSharp.Schemata313.ReplaceBinExprOp_13(109L, node.Tok, Token.NoToken), () => !node.RangeToken.ToDafnyRange().Contains(position)))))
            {
                return null;
            }

            var newParent = new LList<INode>(node, parent);
            foreach (var child in node.Children)
            {
                var result = child.FindNodeChain(position, newParent, predicate);
                if (MutateCSharp.Schemata313.ReplaceBinExprOp_12(122L, result, null))
                {
                    return result;
                }
            }

            if (MutateCSharp.Schemata313.ReplaceBinExprOp_14(124L, () => MutateCSharp.Schemata313.ReplaceBinExprOp_15(123L, node.Tok, Token.NoToken), () => !predicate(node)))
            {
                return null;
            }

            return new LList<INode>(node, parent);
        }
    }
}