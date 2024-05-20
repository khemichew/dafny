using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
namespace MutateCSharp
{
    internal class Schemata94
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT94");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_16(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_11(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.IToken argument1, Microsoft.Dafny.Token argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_12(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 - argument2;
        }

        internal static int ReplaceNumericConstant_1(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
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

        internal static bool ReplaceBinExprOp_22(long mutantId, Microsoft.Dafny.BoundVar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, System.Uri argument1, System.Uri argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_10(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_13(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{

    /** The first Dafny formatter
     * 
     * We want the guarantee that the reprinted program should be the same as the previous one, modulo whitespace.
     * Our approach in this formatter consists of three phases:
     * 1. Convert tokens to a double linked list so that we can traverse them from the beginning to the end and store the first token in the program (Scanner.frame, and all AST nodes)
     * 2. Traverse the program on pre-resolved nodes, and decide on the indentation of each token when it's associated to a declaration, a node, a statement, etc.
     * 3. Reprint the tokens in their original order by replacing their leading and trailing whitespace by their correctly indented counterpart
     *
     * Step 3. has been entirely written in Dafny, and offers the interesting guarantee that the final reprinted program will contain all the "val" of every token reachable from the first token provided in input.
     *
     * ## What is the indentation of a "token"?
     *
     * This formatter considers that each token has to be associated with 3 types of indentation.
     * 1. The indentation of comments that are before this token
     * 2. The indentation of this token itself if it starts a new line
     * 3. The indentation of comments and other non-marked tokens that are after this token.
     * 
     * Because the token printer will traverse the tokens in order, the indentation 1. is used only
     * for the trivia associated to the token in the leading whitespace of that token,
     * like `/* Comment about X * /` in the following example, which is in the leading
     * trivia of `const`
     *
     * ```
     * datatype Y :=
     * | C
     * // Comment about C
     * | D
     * // Comment about D
     * 
     * /* Comment about X * /
     * const X := 2
     * ```
     * Note that in this same example, the indentation of `Comment about D` is possible because of the indentation stored in 3.
     * The indentation of 2. makes is possible to have the token to be a delimiter of two indented regions, like this:
     * 
     * ```dafny
     * if X then
     * Y
     * else // Here "else" has its own indentation
     * Z
     * ```
     */
    public class TokenNewIndentCollector : TopDownVisitor<int>
    {
        private readonly Program program;

        /* If true, the indentation will be
         * var name := method(
         *   x,
         *   y
         * );
         * If false, the indentation will be
         * var name := method(
         *               x,
         *               y
         *             );
         */
        public bool ReduceBlockiness = MutateCSharp.Schemata94.ReplaceBooleanConstant_0(1L, true);

        public readonly int SpaceTab = MutateCSharp.Schemata94.ReplaceNumericConstant_1(2L, 2);

        public class Indentations
        {
            public int Above = MutateCSharp.Schemata94.ReplaceNumericConstant_1(6L, -1);
            public int Inline = MutateCSharp.Schemata94.ReplaceNumericConstant_1(10L, -1);
            public int Below = MutateCSharp.Schemata94.ReplaceNumericConstant_1(14L, -1);
        }

        private readonly Dictionary<int, Indentations> posToIndentations = new();

        private Indentations PosToIndentations(int pos)
        {
            return posToIndentations.GetOrCreate(pos, () => new Indentations());
        }

        // Used for bullet points && and ||
        public int binOpIndent = MutateCSharp.Schemata94.ReplaceNumericConstant_1(18L, -1);
        public int binOpArgIndent = MutateCSharp.Schemata94.ReplaceNumericConstant_1(22L, -1);

        internal TokenNewIndentCollector(Program program, Uri fileToFormat)
        {
            this.program = program;
            this.fileToFormat = fileToFormat;
            preResolve = MutateCSharp.Schemata94.ReplaceBooleanConstant_0(26L, true);
        }

        public IEnumerable<Expression> SubExpressions(Expression expr)
        {
            return expr is ConcreteSyntaxExpression concreteSyntaxExpression
              ? concreteSyntaxExpression.PreResolveSubExpressions
              : expr.SubExpressions;
        }


        protected override bool VisitOneExpr(Expression expr, ref int unusedIndent)
        {
            if (MutateCSharp.Schemata94.ReplaceBinExprOp_2(27L, expr, null))
            {
                return MutateCSharp.Schemata94.ReplaceBooleanConstant_0(28L, false);
            }

            var firstToken = expr.StartToken;
            var indentBefore = GetIndentInlineOrAbove(firstToken);
            if (expr is ICanFormat canFormatNode)
            {
                return canFormatNode.SetIndent(indentBefore, this);
            }

            return MutateCSharp.Schemata94.ReplaceBooleanConstant_0(29L, true);
        }

        protected override bool VisitOneStmt(Statement stmt, ref int unusedIndent)
        {
            if (MutateCSharp.Schemata94.ReplaceBinExprOp_3(30L, stmt, null))
            {
                return MutateCSharp.Schemata94.ReplaceBooleanConstant_0(31L, false);
            }

            var firstToken = stmt.StartToken;
            var indentBefore = GetIndentInlineOrAbove(firstToken);
            if (stmt is ICanFormat canFormatNode)
            {
                return canFormatNode.SetIndent(indentBefore, this);
            }

            // Best heuristic for new elements is to indent them using the method's formatting
            SetMethodLikeIndent(stmt.Tok, stmt.OwnedTokens, indentBefore);
            SetIndentations(stmt.EndToken, MutateCSharp.Schemata94.ReplaceNumericConstant_1(32L, -1), MutateCSharp.Schemata94.ReplaceNumericConstant_1(36L, -1), indentBefore);

            return MutateCSharp.Schemata94.ReplaceBooleanConstant_0(40L, true);
        }

        /// If the first token on the line of the given token satisfies the given predicate.
        /// Used to detect commented cases or datatype constructors
        public static bool FirstTokenOnLineIs(IToken token, Func<IToken, bool> predicate)
        {
            if (MutateCSharp.Schemata94.ReplaceBinExprOp_6(47L, () => MutateCSharp.Schemata94.ReplaceBinExprOp_4(41L, token.Prev, null), () => MutateCSharp.Schemata94.ReplaceBinExprOp_5(42L, token.Prev.line, token.line)))
            {
                return predicate(token);
            }

            return FirstTokenOnLineIs(token.Prev, predicate);
        }

        // Given a token, finds the indentation that was expected before it.
        // Used for frame expressions to initially copy the indentation of "reads", "requires", etc.

        public int GetIndentAbove(IToken token)
        {
            if (PosToIndentations(token.pos).Above is var aboveIndentation and not -1)
            {
                return aboveIndentation;
            }

            return GetIndentBelowOrInlineOrAbove(token.Prev);
        }

        public int GetIndentInlineOrAbove(IToken token)
        {
            if (PosToIndentations(token.pos).Inline is var indentation and not -1)
            {
                return indentation;
            }

            return GetIndentAbove(token);
        }

        public int GetIndentBelowOrInlineOrAbove(IToken token)
        {
            if (MutateCSharp.Schemata94.ReplaceBinExprOp_6(55L, () => MutateCSharp.Schemata94.ReplaceBinExprOp_4(53L, token, null), () => MutateCSharp.Schemata94.ReplaceBinExprOp_7(54L, token, Token.NoToken)))
            {
                return MutateCSharp.Schemata94.ReplaceNumericConstant_1(61L, 0);
            }

            if (PosToIndentations(token.pos).Below is var indentation and not -1)
            {
                return indentation;
            }

            return GetIndentInlineOrAbove(token);
        }


        // Get the precise column this token will be at after reformatting.
        // Requires all tokens before to have been formatted.

        public int GetNewTokenVisualIndent(IToken token, int defaultIndent)
        {
            var previousTrivia = MutateCSharp.Schemata94.ReplaceBinExprOp_8(65L, token.Prev, null) ? token.Prev.TrailingTrivia : "";
            previousTrivia += token.LeadingTrivia;
            var lastNL = previousTrivia.LastIndexOf('\n');
            var lastCR = previousTrivia.LastIndexOf('\r');
            if (MutateCSharp.Schemata94.ReplaceBinExprOp_6(84L, () => MutateCSharp.Schemata94.ReplaceBinExprOp_9(70L, lastNL, MutateCSharp.Schemata94.ReplaceNumericConstant_1(66L, 0)), () => MutateCSharp.Schemata94.ReplaceBinExprOp_9(79L, lastCR, MutateCSharp.Schemata94.ReplaceNumericConstant_1(75L, 0))))
            {
                // If the leading trivia contains an inline comment after the last newline, it can change the position.
                var lastCharacterAfterNewline = MutateCSharp.Schemata94.ReplaceBinExprOp_10(94L, Math.Max(lastNL, lastCR), MutateCSharp.Schemata94.ReplaceNumericConstant_1(90L, 1));
                var lastTrivia = previousTrivia.Substring(lastCharacterAfterNewline);
                if (MutateCSharp.Schemata94.ReplaceBinExprOp_9(108L, lastTrivia.IndexOf(MutateCSharp.Schemata94.ReplaceStringConstant_11(103L, "*/"), StringComparison.Ordinal), MutateCSharp.Schemata94.ReplaceNumericConstant_1(104L, 0)))
                {
                    return lastTrivia.Length;
                }

                if (PosToIndentations(token.pos).Inline is var indentation and not -1)
                {
                    return indentation;
                }

                if (MutateCSharp.Schemata94.ReplaceBinExprOp_8(113L, token.Prev, null) &&
                    PosToIndentations(token.Prev.pos).Below is var indentation2 and not -1)
                {
                    return indentation2;
                }

                return defaultIndent;
            }

            // No newline, so no re-indentation.
            if (MutateCSharp.Schemata94.ReplaceBinExprOp_8(114L, token.Prev, null))
            {
                return MutateCSharp.Schemata94.ReplaceBinExprOp_10(124L, MutateCSharp.Schemata94.ReplaceBinExprOp_10(115L, GetNewTokenVisualIndent(token.Prev, defaultIndent), token.Prev.val.Length), previousTrivia.Length);
            }

            return MutateCSharp.Schemata94.ReplaceBinExprOp_12(137L, token.col, MutateCSharp.Schemata94.ReplaceNumericConstant_1(133L, 1));
        }

        private static int GetTrailingSpace(IToken token)
        {
            var c = MutateCSharp.Schemata94.ReplaceNumericConstant_1(146L, 0);
            while (MutateCSharp.Schemata94.ReplaceBinExprOp_15(160L, () => MutateCSharp.Schemata94.ReplaceBinExprOp_13(150L, c, token.TrailingTrivia.Length), () => MutateCSharp.Schemata94.ReplaceBinExprOp_14(155L, token.TrailingTrivia[c], ' ')))
            {
                MutateCSharp.Schemata94.ReplacePostfixUnaryExprOp_16(166L, ref c);
            }

            return c;
        }

        // Given a token such as `var ` immediately followed by another token
        // returns the indent so that everything after it is aligned with the first token.
        public int GetRightAlignIndentAfter(IToken token, int indentFallback)
        {
            var trailingSpace = GetTrailingSpace(token);
            return MutateCSharp.Schemata94.ReplaceBinExprOp_10(176L, MutateCSharp.Schemata94.ReplaceBinExprOp_10(167L, GetNewTokenVisualIndent(token, indentFallback), token.val.Length), trailingSpace);
        }

        private static readonly Regex FollowedByNewlineRegex = new Regex(MutateCSharp.Schemata94.ReplaceStringConstant_11(185L, "^[ \t]*([\r\n]|//)"));
        private readonly Uri fileToFormat;

        public static bool IsFollowedByNewline(IToken token)
        {
            return FollowedByNewlineRegex.IsMatch(token.TrailingTrivia);
        }

        // 'above' is the hypothetical indentation of a comment attached to that token on the line before
        // 'inline' is the hypothetical indentation of this token if it was on its own line
        // 'below' is the hypothetical indentation of a comment after that token, and of the next token if it does not have a set indentation
        public void SetIndentations(IToken token, int above = -1, int inline = -1, int below = -1)
        {
            if (MutateCSharp.Schemata94.ReplaceBinExprOp_6(211L, () => MutateCSharp.Schemata94.ReplaceBinExprOp_17(186L, token.Uri, fileToFormat), () => (MutateCSharp.Schemata94.ReplaceBinExprOp_15(205L, () => MutateCSharp.Schemata94.ReplaceBinExprOp_14(191L, token.line, MutateCSharp.Schemata94.ReplaceNumericConstant_1(187L, 0)), () => MutateCSharp.Schemata94.ReplaceBinExprOp_14(200L, token.col, MutateCSharp.Schemata94.ReplaceNumericConstant_1(196L, 0))))))
            {
                // Just ignore this token.
                return;
            }

            if (MutateCSharp.Schemata94.ReplaceBinExprOp_9(221L, above, MutateCSharp.Schemata94.ReplaceNumericConstant_1(217L, 0)))
            {
                PosToIndentations(token.pos).Above = above;
            }

            if (MutateCSharp.Schemata94.ReplaceBinExprOp_9(230L, inline, MutateCSharp.Schemata94.ReplaceNumericConstant_1(226L, 0)))
            {
                PosToIndentations(token.pos).Inline = inline;
            }

            if (MutateCSharp.Schemata94.ReplaceBinExprOp_9(239L, below, MutateCSharp.Schemata94.ReplaceNumericConstant_1(235L, 0)))
            {
                PosToIndentations(token.pos).Below = below;
            }
        }

        // functions, methods, predicates, iterators, can all be formatted using this method.
        // See FormatterWorksForMethodsInModule in Formatter.cs to see how methods are formatted.
        public void SetMethodLikeIndent(IToken startToken, IEnumerable<IToken> ownedTokens, int indent)
        {
            var indent2 = MutateCSharp.Schemata94.ReplaceBinExprOp_10(244L, indent, SpaceTab);
            if (MutateCSharp.Schemata94.ReplaceBinExprOp_18(254L, startToken.val, MutateCSharp.Schemata94.ReplaceStringConstant_11(253L, "{")))
            {
                SetIndentations(startToken, indent, indent, indent2);
            }

            var rightIndent = MutateCSharp.Schemata94.ReplaceBinExprOp_10(255L, indent2, SpaceTab);
            var commaIndent = indent2;
            var extraParenIndent = MutateCSharp.Schemata94.ReplaceNumericConstant_1(264L, 0);
            var firstParensClosed = MutateCSharp.Schemata94.ReplaceBooleanConstant_0(268L, false);
            foreach (var token in ownedTokens)
            {
                switch (token.val)
                {
                    case "{":
                        SetDelimiterIndentedRegions(token, indent);
                        break;
                        break;
                    case "<" or "[" when IsFollowedByNewline(token):
                        rightIndent = indent2 + SpaceTab;
                        commaIndent = indent2;
                        SetIndentations(token, commaIndent, commaIndent, rightIndent);
                        break;
                        break;
                    case "<" or "[":
                        // Align capabilities
                        SetAlign(indent2, token, out rightIndent, out commaIndent);
                        break;
                        break;
                    case "(" when IsFollowedByNewline(token):
                        rightIndent = indent2 + extraParenIndent;
                        commaIndent = indent + extraParenIndent;
                        SetIndentations(token, commaIndent, commaIndent, rightIndent);
                        break;
                        break;
                    case "(":
                        // Align capabilities
                        SetAlign(indent + extraParenIndent, token, out rightIndent, out commaIndent);
                        break;
                        break;
                    case ",":
                        SetIndentations(token, rightIndent, commaIndent, rightIndent);
                        break;
                        break;
                    case ")":
                        firstParensClosed = true;
                        SetIndentations(token, rightIndent, indent + extraParenIndent, indent2);
                        break;
                        break;
                    case ">" or "]":
                        SetIndentations(token, rightIndent, indent2, indent2);
                        break;
                        break;
                    case "}" when PosToIndentations(token.pos).Inline == -1:
                        SetClosingIndentedRegion(token, indent);
                        break;
                        break;
                    case "returns":
                    case ":":
                        if (firstParensClosed)
                        {
                            extraParenIndent = SpaceTab;
                        }

                        break;
                        break;
                    case "reads" or "modifies" or "decreases" or "requires" or "ensures" or "invariant" or "yield":
                        {
                            if (IsFollowedByNewline(token))
                            {
                                // In the future, we might want to use this to reduce blockiness as well
                                // However, it has some undesirable side-effects which would need to be fixed
                                SetOpeningIndentedRegion(token, indent2);
                            }
                            else
                            {
                                SetAlign(indent2, token, out rightIndent, out commaIndent);
                            }

                            commaIndent = indent2;
                            break;
                        }

                        break;
                }
            }
        }

        public void SetTypeLikeIndentation(int indent, IEnumerable<IToken> tokens)
        {
            var commaIndent = MutateCSharp.Schemata94.ReplaceBinExprOp_10(269L, indent, SpaceTab);
            var rightIndent = MutateCSharp.Schemata94.ReplaceBinExprOp_10(278L, indent, SpaceTab);
            foreach (var token in tokens)
            {
                switch (token.val)
                {
                    case "<":
                        {
                            if (IsFollowedByNewline(token))
                            {
                                SetOpeningIndentedRegion(token, indent);
                            }
                            else
                            {
                                SetAlign(indent + SpaceTab, token, out rightIndent, out commaIndent);
                            }

                            break;
                        }

                        break;
                    case ",":
                        {
                            SetIndentations(token, rightIndent, commaIndent, rightIndent);
                            break;
                        }

                        break;
                    case ">":
                        {
                            SetClosingIndentedRegionAligned(token, rightIndent, indent);
                            break;
                        }

                        break;
                }
            }
        }

        public void SetTypeIndentation(Type type)
        {
            var tokens = type.OwnedTokens.ToList();
            if (tokens.Any())
            {

                var indent = GetIndentInlineOrAbove(tokens[MutateCSharp.Schemata94.ReplaceNumericConstant_1(287L, 0)]);
                if (MutateCSharp.Schemata94.ReplaceBinExprOp_19(295L, tokens.Count, MutateCSharp.Schemata94.ReplaceNumericConstant_1(291L, 1)))
                {
                    SetIndentations(tokens[MutateCSharp.Schemata94.ReplaceNumericConstant_1(300L, 0)], below: MutateCSharp.Schemata94.ReplaceBinExprOp_10(308L, indent, MutateCSharp.Schemata94.ReplaceNumericConstant_1(304L, 2)));
                }

                SetTypeLikeIndentation(indent, tokens);
            }

            if (type is UserDefinedType userDefinedType)
            {
                foreach (var subtype in userDefinedType.PreResolveChildren)
                {
                    if (subtype is Type subType2)
                    {
                        SetTypeIndentation(subType2);
                    }
                    else if (subtype is Expression expr)
                    {
                        Visit(expr, MutateCSharp.Schemata94.ReplaceNumericConstant_1(317L, 0));
                    }
                }
            }
        }

        // ReSharper disable once UnusedParameter.Local
        void SetAttributeIndentation(Attributes attributes)
        {
            // If we ever need multiline attributes, here is the place to format them appropriatedly
        }

        public void SetDecreasesExpressionIndentation(Expression expression, int indent)
        {
            SetExpressionIndentation(expression);
            SetIndentations(expression.EndToken, below: indent);
        }

        public void SetAttributedExpressionIndentation(AttributedExpression attrExpression, int indent)
        {
            SetAttributeIndentation(attrExpression.Attributes);
            SetExpressionIndentation(attrExpression.E);
            SetIndentations(attrExpression.E.EndToken, below: indent);
        }

        public void SetFrameExpressionIndentation(FrameExpression frameExpression, int indent)
        {
            SetExpressionIndentation(frameExpression.E);
            SetIndentations(frameExpression.E.EndToken, below: indent);
        }

        public void SetExpressionIndentation(Expression expression)
        {
            if (MutateCSharp.Schemata94.ReplaceBinExprOp_20(321L, expression, null))
            {
                Visit(expression, GetIndentInlineOrAbove(expression.StartToken));
            }
        }

        public void SetStatementIndentation(Statement statement)
        {
            Visit(statement, MutateCSharp.Schemata94.ReplaceNumericConstant_1(322L, 0));
        }

        public void SetDeclIndentation(TopLevelDecl topLevelDecl, int indent)
        {
            if (topLevelDecl.tok.FromIncludeDirective(program))
            {
                return;
            }

            var indent2 = MutateCSharp.Schemata94.ReplaceBinExprOp_10(326L, indent, SpaceTab);
            if (MutateCSharp.Schemata94.ReplaceBinExprOp_19(339L, topLevelDecl.StartToken.line, MutateCSharp.Schemata94.ReplaceNumericConstant_1(335L, 0)))
            {
                SetDelimiterIndentedRegions(topLevelDecl.BodyStartTok, indent);
                SetOpeningIndentedRegion(topLevelDecl.StartToken, indent);
            }

            if (topLevelDecl is ICanFormat declCanFormat && topLevelDecl is not TopLevelDeclWithMembers)
            {
                declCanFormat.SetIndent(indent, this);
            }
            else if (topLevelDecl is TopLevelDeclWithMembers declWithMembers)
            {
                if (topLevelDecl is ICanFormat canFormat)
                {
                    canFormat.SetIndent(indent, this);
                }
                else if (declWithMembers is RedirectingTypeDecl redirectingTypeDecl)
                {
                    SetRedirectingTypeDeclDeclIndentation(indent, redirectingTypeDecl);
                }

                var initialMemberIndent = MutateCSharp.Schemata94.ReplaceBinExprOp_14(348L, declWithMembers.tok.line, MutateCSharp.Schemata94.ReplaceNumericConstant_1(344L, 0)) ? indent : indent2;
                foreach (var member in declWithMembers.PreResolveChildren)
                {
                    if (member.Tok.FromIncludeDirective(program))
                    {
                        continue;
                    }

                    if (member is MemberDecl memberDecl)
                    {
                        SetMemberIndentation(memberDecl, initialMemberIndent);
                    }
                }
            }
            else if (topLevelDecl is SubsetTypeDecl subsetTypeDecl)
            {
                SetRedirectingTypeDeclDeclIndentation(indent, subsetTypeDecl);
            }
            else if (topLevelDecl is TypeSynonymDecl typeSynonymDecl)
            {
                SetRedirectingTypeDeclDeclIndentation(indent, typeSynonymDecl);
            }

            if (MutateCSharp.Schemata94.ReplaceBinExprOp_15(364L, () => MutateCSharp.Schemata94.ReplaceBinExprOp_19(357L, topLevelDecl.StartToken.line, MutateCSharp.Schemata94.ReplaceNumericConstant_1(353L, 0)), () => MutateCSharp.Schemata94.ReplaceBinExprOp_21(363L, topLevelDecl.EndToken.val, MutateCSharp.Schemata94.ReplaceStringConstant_11(362L, "}"))))
            {
                SetIndentations(topLevelDecl.EndToken, indent2, indent, indent);
            }
        }

        private void SetMemberIndentation(MemberDecl member, int indent)
        {
            if (member is ICanFormat canFormat)
            {
                canFormat.SetIndent(indent, this);
            }
            else
            {
                SetMethodLikeIndent(member.StartToken, member.OwnedTokens, indent);
                if (MutateCSharp.Schemata94.ReplaceBinExprOp_19(374L, member.BodyStartTok.line, MutateCSharp.Schemata94.ReplaceNumericConstant_1(370L, 0)))
                {
                    SetDelimiterIndentedRegions(member.BodyStartTok, indent);
                }
            }

            PosToIndentations(member.EndToken.pos).Below = indent;
        }

        private void SetRedirectingTypeDeclDeclIndentation(int indent, RedirectingTypeDecl redirectingTypeDecl)
        {
            SetOpeningIndentedRegion(redirectingTypeDecl.StartToken, indent);
            var indent2 = MutateCSharp.Schemata94.ReplaceBinExprOp_10(379L, indent, SpaceTab);
            var rightOfVerticalBarIndent = MutateCSharp.Schemata94.ReplaceBinExprOp_10(388L, indent2, SpaceTab);
            var verticalBarIndent = indent2;
            foreach (var token in redirectingTypeDecl.OwnedTokens)
            {
                switch (token.val)
                {
                    case "newtype":
                    case "type":
                        {
                            SetOpeningIndentedRegion(token, indent);
                            break;
                        }

                        break;
                    case "=":
                        {
                            SetDelimiterInsideIndentedRegions(token, indent);
                            break;
                        }

                        break;
                    case "|":
                        {
                            SetIndentations(token, rightOfVerticalBarIndent, verticalBarIndent, rightOfVerticalBarIndent);
                            break;
                        }

                        break;
                    case "ghost":
                        {
                            SetIndentations(token, rightOfVerticalBarIndent, verticalBarIndent, verticalBarIndent);
                            break;
                        }

                        break;
                    case "witness":
                        {
                            if (rightOfVerticalBarIndent == indent2)
                            {
                                rightOfVerticalBarIndent = indent2 + SpaceTab;
                            }

                            SetIndentations(token, rightOfVerticalBarIndent, verticalBarIndent, rightOfVerticalBarIndent);
                            break;
                        }

                        break;
                    case "{":
                        {
                            SetOpeningIndentedRegion(token, indent);
                            break;
                        }

                        break;
                    case "}":
                        {
                            SetClosingIndentedRegion(token, indent);
                            break;
                        }

                        break;
                    case "*":
                        {
                            // Nothing to add here.
                            break;
                        }

                        break;
                    case ";":
                        {
                            break;
                        }

                        break;
                }
            }

            if (redirectingTypeDecl is SubsetTypeDecl subsetTypeDecl)
            {
                SetExpressionIndentation(subsetTypeDecl.Constraint);
                SetExpressionIndentation(subsetTypeDecl.Witness);
                SetTypeIndentation(subsetTypeDecl.Var.SyntacticType);
                SetIndentations(subsetTypeDecl.EndToken, below: indent);
            }
            else if (redirectingTypeDecl is NewtypeDecl newtypeDecl)
            {
                SetExpressionIndentation(newtypeDecl.Constraint);
                SetExpressionIndentation(newtypeDecl.Witness);
                if (MutateCSharp.Schemata94.ReplaceBinExprOp_22(397L, newtypeDecl.Var, null))
                {
                    SetTypeIndentation(newtypeDecl.Var.SyntacticType);
                }

                SetIndentations(newtypeDecl.EndToken, below: indent);
            }
            else if (redirectingTypeDecl is TypeSynonymDecl typeSynonymDecl)
            {
                SetIndentations(typeSynonymDecl.EndToken, below: indent);
            }
        }

        public void SetFormalsIndentation(List<Formal> ctorFormals)
        {
            foreach (var formal in ctorFormals)
            {
                SetTypeIndentation(formal.SyntacticType);
            }
        }

        // All SetIndent* methods

        public bool SetIndentAssertLikeStatement(Statement stmt, int indent)
        {
            var ownedTokens = stmt.OwnedTokens;
            foreach (var token in ownedTokens)
            {
                if (SetIndentLabelTokens(token, indent))
                {
                    continue;
                }

                switch (token.val)
                {
                    case "assume":
                    case "expect":
                    case "assert":
                    case "yield":
                        SetOpeningIndentedRegion(token, indent);
                        break;
                        break;
                    case "}":
                    case "by":
                        SetClosingIndentedRegion(token, indent);
                        break;
                        break;
                    case ";":
                        SetClosingIndentedRegionInside(token, indent);
                        break;
                        break;
                    case "{":
                        SetOpeningIndentedRegion(token, indent);
                        break;
                        break;
                }
            }

            if (stmt is AssertStmt { Proof: { StartToken: { } startToken } })
            {
                SetOpeningIndentedRegion(startToken, indent);
            }

            return MutateCSharp.Schemata94.ReplaceBooleanConstant_0(398L, true);
        }

        public void SetIndentBody(Statement body, int indent)
        {
            if (MutateCSharp.Schemata94.ReplaceBinExprOp_3(399L, body, null))
            {
                return;
            }

            SetDelimiterIndentedRegions(body.StartToken, indent);
            SetClosingIndentedRegion(body.EndToken, indent);
            Visit(body, indent);
        }

        public bool SetIndentPrintRevealStmt(int indent, IEnumerable<IToken> ownedTokens)
        {
            var commaIndent = MutateCSharp.Schemata94.ReplaceBinExprOp_10(400L, indent, SpaceTab);
            var innerIndent = MutateCSharp.Schemata94.ReplaceBinExprOp_10(409L, indent, SpaceTab);
            var afterSemicolonIndent = indent;
            foreach (var token in ownedTokens)
            {
                if (SetIndentLabelTokens(token, indent))
                {
                    continue;
                }

                switch (token.val)
                {
                    case "reveal":
                    case "print":
                        if (IsFollowedByNewline(token))
                        {
                            SetOpeningIndentedRegion(token, indent);
                        }
                        else
                        {
                            SetAlign(indent, token, out innerIndent, out commaIndent);
                        }

                        afterSemicolonIndent = GetNewTokenVisualIndent(token, indent);

                        break;
                        break;
                    case ",":
                        SetIndentations(token, innerIndent, commaIndent, innerIndent);
                        break;
                        break;
                    case ";":
                        SetClosingIndentedRegionInside(token, afterSemicolonIndent);
                        break;
                        break;
                }
            }

            return MutateCSharp.Schemata94.ReplaceBooleanConstant_0(418L, true);
        }

        public bool SetIndentUpdateStmt(ConcreteUpdateStatement stmt, int indent, bool inner)
        {
            var ownedTokens = stmt.OwnedTokens.ToList();
            var opIndentDefault =
              stmt is AssignOrReturnStmt assignStmt && MutateCSharp.Schemata94.ReplaceBinExprOp_14(423L, assignStmt.Lhss.Count, MutateCSharp.Schemata94.ReplaceNumericConstant_1(419L, 0
        )) ? indent
                : MutateCSharp.Schemata94.ReplaceBinExprOp_10(428L, indent, SpaceTab);
            var startToken = stmt.StartToken;
            int startAssignmentIndent = inner ? MutateCSharp.Schemata94.ReplaceBinExprOp_10(437L, indent, SpaceTab) : indent;
            int afterStartIndent = MutateCSharp.Schemata94.ReplaceBinExprOp_10(446L, indent, SpaceTab);
            var rightIndent = MutateCSharp.Schemata94.ReplaceBinExprOp_10(455L, indent, SpaceTab);
            var commaIndent = MutateCSharp.Schemata94.ReplaceBinExprOp_10(464L, indent, SpaceTab);
            SetIndentations(startToken, startAssignmentIndent, startAssignmentIndent, afterStartIndent);

            var rhss = stmt is UpdateStmt updateStmt ? updateStmt.Rhss
              : stmt is AssignOrReturnStmt assignOrReturnStmt ? new List<AssignmentRhs> { assignOrReturnStmt.Rhs }
                .Concat(assignOrReturnStmt.Rhss).ToList()
              : new List<AssignmentRhs>();

            // For single Rhs that are of the form [new] X(args....),
            // we can even further decrease the indent so that the last parenthesis
            // is aligned with the beginning of the declaration. 
            var firstRhsOneSingleLine = MutateCSharp.Schemata94.ReplaceBinExprOp_15(495L, () => MutateCSharp.Schemata94.ReplaceBinExprOp_9(477L, rhss.Count, MutateCSharp.Schemata94.ReplaceNumericConstant_1(473L, 1)), () => MutateCSharp.Schemata94.ReplaceBinExprOp_14(490L, rhss[MutateCSharp.Schemata94.ReplaceNumericConstant_1(482L, 0)].StartToken.line, rhss[MutateCSharp.Schemata94.ReplaceNumericConstant_1(486L, 0)].EndToken.line));
            var assignmentOperator = ownedTokens.Find(token => MutateCSharp.Schemata94.ReplaceBinExprOp_6(513L, () => MutateCSharp.Schemata94.ReplaceBinExprOp_6(505L, () => MutateCSharp.Schemata94.ReplaceBinExprOp_21(502L, token.val, MutateCSharp.Schemata94.ReplaceStringConstant_11(501L, ":=")), () => MutateCSharp.Schemata94.ReplaceBinExprOp_21(504L, token.val, MutateCSharp.Schemata94.ReplaceStringConstant_11(503L, ":-"))), () => MutateCSharp.Schemata94.ReplaceBinExprOp_21(512L, token.val, MutateCSharp.Schemata94.ReplaceStringConstant_11(511L, ":|"))));
            if (MutateCSharp.Schemata94.ReplaceBinExprOp_4(519L, assignmentOperator, null))
            {
                rightIndent = startAssignmentIndent;
            }

            void InferRightIndentFromRhs()
            {
                if (!rhss.Any())
                {
                    return;
                }

                var rhs = rhss[MutateCSharp.Schemata94.ReplaceNumericConstant_1(520L, 0)];
                if (ReduceBlockiness)
                {
                    rightIndent = indent;
                    return;
                }

                rightIndent = GetNewTokenVisualIndent(rhs.RangeToken.StartToken, rightIndent);
            }

            if (!ownedTokens.Any(token => MutateCSharp.Schemata94.ReplaceBinExprOp_6(536L, () => MutateCSharp.Schemata94.ReplaceBinExprOp_6(528L, () => MutateCSharp.Schemata94.ReplaceBinExprOp_21(525L, token.val, MutateCSharp.Schemata94.ReplaceStringConstant_11(524L, ":=")), () => MutateCSharp.Schemata94.ReplaceBinExprOp_21(527L, token.val, MutateCSharp.Schemata94.ReplaceStringConstant_11(526L, ":-"))), () => MutateCSharp.Schemata94.ReplaceBinExprOp_21(535L, token.val, MutateCSharp.Schemata94.ReplaceStringConstant_11(534L, ":|")))))
            {
                InferRightIndentFromRhs();
            }

            foreach (var token in ownedTokens)
            {
                if (SetIndentLabelTokens(token, startAssignmentIndent))
                {
                    continue;
                }

                switch (token.val)
                {
                    case ",":
                        SetDelimiterSpeciallyIndentedRegions(token, commaIndent, rightIndent);
                        break;
                        break;
                    case ":|":
                    case ":-":
                    case ":=":
                        {
                            if (!IsFollowedByNewline(assignmentOperator))
                            {
                                if (ReduceBlockiness && !firstRhsOneSingleLine)
                                {
                                    if (rhss.Count == 1 && rhss[0] is not ExprRhs { Expr: LambdaExpr })
                                    {
                                        rightIndent = indent;
                                        commaIndent = indent;
                                    }
                                    else
                                    {
                                        rightIndent = indent + SpaceTab;
                                        commaIndent = indent + SpaceTab;
                                    }

                                    SetIndentations(assignmentOperator, afterStartIndent, opIndentDefault, rightIndent);
                                }
                                else
                                {
                                    SetAlign(opIndentDefault, assignmentOperator, out rightIndent, out commaIndent);
                                }
                            }
                            else
                            {
                                rightIndent = afterStartIndent;
                                SetIndentations(assignmentOperator, afterStartIndent, opIndentDefault, rightIndent);
                            }

                            break;
                        }

                        break;
                    case ";":
                        SetClosingIndentedRegionInside(token, indent);
                        break;
                        break;
                        // Otherwise, these are identifiers, We don't need to specify their indentation.
                }
            }

            foreach (var rhs in rhss)
            {
                if (rhs.OwnedTokens.Any(token => MutateCSharp.Schemata94.ReplaceBinExprOp_21(543L, token.val, MutateCSharp.Schemata94.ReplaceStringConstant_11(542L, "("))))
                {
                    SetIndentParensExpression(rightIndent, rhs.OwnedTokens);
                }

                foreach (var node in rhs.PreResolveSubExpressions)
                {
                    Visit(node, rightIndent);
                }
            }

            if (stmt is AssignSuchThatStmt assignSuchThatStmt)
            {
                Visit(assignSuchThatStmt.Expr, rightIndent);
            }

            return MutateCSharp.Schemata94.ReplaceBooleanConstant_0(544L, false);
        }

        public void VisitAlternatives(List<GuardedAlternative> alternatives, int indent)
        {
            foreach (var alternative in alternatives)
            {
                Visit(alternative.Guard, MutateCSharp.Schemata94.ReplaceBinExprOp_10(545L, indent, SpaceTab));
                foreach (var bodyStmt in alternative.Body)
                {
                    Visit(bodyStmt, MutateCSharp.Schemata94.ReplaceBinExprOp_10(554L, indent, SpaceTab));
                }
            }
        }

        public bool SetIndentParensExpression(int indent, IEnumerable<IToken> ownedTokens)
        {
            var itemIndent = MutateCSharp.Schemata94.ReplaceBinExprOp_10(563L, indent, SpaceTab);
            var commaIndent = indent;

            foreach (var token in ownedTokens)
            {
                switch (token.val)
                {
                    case "[":
                    case "{":
                    case "(":
                        {
                            if (IsFollowedByNewline(token))
                            {
                                SetIndentations(token, indent, indent, itemIndent);
                            }
                            else
                            {
                                SetAlign(indent, token, out itemIndent, out commaIndent);
                            }

                            break;
                        }

                        break;
                    case ",":
                        {
                            SetIndentations(token, itemIndent, commaIndent, itemIndent);
                            break;
                        }

                        break;
                    case ":=":
                        {
                            SetIndentations(token, itemIndent, itemIndent,
                              IsFollowedByNewline(token) ? itemIndent + SpaceTab : itemIndent);

                            break;
                        }

                        break;
                    case "]":
                    case "}":
                    case ")":
                        {
                            SetIndentations(token, itemIndent, indent, indent);
                            break;
                        }

                        break;
                }
            }

            return MutateCSharp.Schemata94.ReplaceBooleanConstant_0(572L, true);
        }

        public bool SetIndentCases(int indent, IEnumerable<IToken> ownedTokens, Action indentInside)
        {
            var caseIndent = indent;
            var afterArrowIndent = MutateCSharp.Schemata94.ReplaceBinExprOp_10(573L, indent, SpaceTab);
            var decreasesElemIndent = MutateCSharp.Schemata94.ReplaceBinExprOp_10(591L, MutateCSharp.Schemata94.ReplaceBinExprOp_10(582L, indent, SpaceTab), SpaceTab);
            var commaIndent = decreasesElemIndent;
            // Need to ensure that the "case" is at least left aligned with the match/if/while keyword
            IToken decisionToken = null;
            var allTokens = ownedTokens as IToken[] ?? ownedTokens.ToArray();
            foreach (var token in allTokens)
            {
                if (SetIndentLabelTokens(token, indent))
                {
                    continue;
                }

                switch (token.val)
                {
                    case "if":
                    case "while":
                    case "match":
                        {
                            decisionToken = token;
                            if (ReduceBlockiness && token.Prev.val is "=>" or ":=" or ":-" or ":|" && token.Prev.line == token.line)
                            {
                                caseIndent = GetIndentInlineOrAbove(token.Prev);
                                indent = caseIndent - SpaceTab;
                            }
                            else
                            {
                                caseIndent = GetNewTokenVisualIndent(token, indent);
                            }

                            afterArrowIndent = caseIndent + SpaceTab;
                            SetOpeningIndentedRegion(token, indent);
                            break;
                        }

                        break;
                    case "{":
                        caseIndent = indent + SpaceTab;
                        afterArrowIndent = caseIndent + SpaceTab;
                        SetDelimiterIndentedRegions(token, indent);
                        break;
                        break;
                    case "}":
                        SetClosingIndentedRegion(token, indent);
                        break;
                        break;
                    case "case":
                        if (decisionToken != null && decisionToken.line == token.line)
                        {
                            caseIndent = GetNewTokenVisualIndent(token, indent);
                        }

                        SetOpeningIndentedRegion(token, caseIndent);
                        break;
                        break;
                    case "=>":
                        if (!IsFollowedByNewline(token))
                        {
                            if (ReduceBlockiness)
                            {
                                SetIndentations(token, afterArrowIndent, afterArrowIndent, caseIndent);
                            }
                            else
                            {
                                SetAlign(afterArrowIndent, token, out _, out _);
                            }
                        }
                        else
                        {
                            SetIndentations(token, afterArrowIndent, afterArrowIndent, afterArrowIndent);
                        }

                        break;
                        break;
                    case ",":
                        {
                            // For decreases clauses
                            SetIndentations(token, decreasesElemIndent, commaIndent, decreasesElemIndent);
                            break;
                        }

                        break;
                    case "decreases":
                        {
                            if (IsFollowedByNewline(token))
                            {
                                SetOpeningIndentedRegion(token, indent + SpaceTab);
                                decreasesElemIndent = indent + SpaceTab + SpaceTab;
                                commaIndent = decreasesElemIndent;
                            }
                            else
                            {
                                SetAlign(indent + SpaceTab, token, out decreasesElemIndent, out commaIndent);
                            }

                            break;
                        }

                        break;
                    case "invariant":
                        {
                            SetOpeningIndentedRegion(token, indent + SpaceTab);
                            break;
                        }

                        break;
                }
            }

            indentInside();

            // Ensure comments just before a "case" are aligned with this case.
            foreach (var token in allTokens)
            {
                switch (token.val)
                {
                    case "case":
                        SetIndentations(token.Prev, below: caseIndent);
                        break;
                        break;
                }
            }

            return MutateCSharp.Schemata94.ReplaceBooleanConstant_0(600L, false);
        }

        public bool SetIndentVarDeclStmt(int indent, IEnumerable<IToken> ownedTokens, bool noLHS, bool isLetExpr)
        {
            var rightIndent = MutateCSharp.Schemata94.ReplaceBinExprOp_10(601L, indent, SpaceTab);
            var commaIndent = MutateCSharp.Schemata94.ReplaceBinExprOp_10(610L, indent, SpaceTab);
            var afterSemicolonIndent = indent;
            var hadGhost = MutateCSharp.Schemata94.ReplaceBooleanConstant_0(619L, false);
            var assignOpIndent = noLHS ? indent : MutateCSharp.Schemata94.ReplaceBinExprOp_10(620L, indent, SpaceTab);
            var isAmpVar = MutateCSharp.Schemata94.ReplaceBooleanConstant_0(629L, false);
            var ampVarIndent = indent;
            foreach (var token in ownedTokens)
            {
                if (SetIndentLabelTokens(token, indent))
                {
                    continue;
                }

                switch (token.val)
                {
                    case "ghost":
                        {
                            afterSemicolonIndent = GetNewTokenVisualIndent(token, indent);
                            SetOpeningIndentedRegion(token, indent);
                            hadGhost = true;
                            break;
                        }

                        break;
                    case "var":
                        {
                            if (token.Prev.val == "&&" && token.Prev.line == token.line)
                            {
                                isAmpVar = true;
                                ampVarIndent = GetNewTokenVisualIndent(token.Prev, indent);
                            }

                            if (!hadGhost)
                            {
                                afterSemicolonIndent = GetNewTokenVisualIndent(token, indent);
                            }

                            if (IsFollowedByNewline(token))
                            {
                                SetOpeningIndentedRegion(token, indent);
                            }
                            else
                            {
                                SetAlign(indent, token, out rightIndent, out commaIndent);
                            }

                            break;
                        }

                        break;
                    case ",":
                        SetDelimiterSpeciallyIndentedRegions(token, commaIndent, rightIndent);
                        break;
                        break;
                    case ":|":
                    case ":-":
                    case ":=":
                        {
                            if (isLetExpr)
                            {
                                if (!IsFollowedByNewline(token))
                                {
                                    SetAlign(assignOpIndent, token, out rightIndent, out commaIndent);
                                }
                                else
                                {
                                    SetIndentations(token, assignOpIndent, assignOpIndent, indent + SpaceTab);
                                    commaIndent = indent + SpaceTab;
                                    rightIndent = indent + SpaceTab;
                                }
                            }
                            else
                            {
                                // For variable declarations, :=, :| and :- is part of the UpdateStmt
                            }

                            break;
                        }

                        break;
                    case ";":
                        SetIndentations(token, afterSemicolonIndent + SpaceTab,
                          afterSemicolonIndent + SpaceTab,
                          isAmpVar ? ampVarIndent : afterSemicolonIndent);
                        break;
                        break;
                        // Otherwise, these are identifiers, We don't need to specify their indentation.
                }
            }

            return MutateCSharp.Schemata94.ReplaceBooleanConstant_0(630L, true);
        }

        public bool SetIndentLabelTokens(IToken token, int indent)
        {
            if (MutateCSharp.Schemata94.ReplaceBinExprOp_21(632L, token.val, MutateCSharp.Schemata94.ReplaceStringConstant_11(631L, "label")))
            {
                SetOpeningIndentedRegion(token, indent);
            }
            else if (MutateCSharp.Schemata94.ReplaceBinExprOp_15(637L, () => MutateCSharp.Schemata94.ReplaceBinExprOp_21(634L, token.val, MutateCSharp.Schemata94.ReplaceStringConstant_11(633L, ":")), () => MutateCSharp.Schemata94.ReplaceBinExprOp_21(636L, token.Prev.Prev.val, MutateCSharp.Schemata94.ReplaceStringConstant_11(635L, "label"))))
            {
                SetClosingIndentedRegion(token, indent);
            }
            else if (MutateCSharp.Schemata94.ReplaceBinExprOp_18(644L, token.Prev.val, MutateCSharp.Schemata94.ReplaceStringConstant_11(643L, "label")))
            {
                return MutateCSharp.Schemata94.ReplaceBooleanConstant_0(645L, false);
            }

            return MutateCSharp.Schemata94.ReplaceBooleanConstant_0(646L, true);
        }

        public void SetIndentLikeLoop(IEnumerable<IToken> ownedTokens, Statement body, int indent)
        {
            var decreasesElemIndent = MutateCSharp.Schemata94.ReplaceBinExprOp_10(647L, indent, SpaceTab);
            var commaIndent = MutateCSharp.Schemata94.ReplaceBinExprOp_10(656L, indent, SpaceTab);
            var first = MutateCSharp.Schemata94.ReplaceBooleanConstant_0(665L, true);
            foreach (var token in ownedTokens)
            {
                if (first)
                {
                    SetOpeningIndentedRegion(token, indent);
                    first = MutateCSharp.Schemata94.ReplaceBooleanConstant_0(666L, false);
                }

                if (SetIndentLabelTokens(token, indent))
                {
                    continue;
                }

                switch (token.val)
                {
                    case "while":
                    case "forall":
                        {
                            SetOpeningIndentedRegion(token, indent);
                            break;
                        }

                        break;
                    case ",":
                        {
                            // For decreases clauses
                            SetIndentations(token, decreasesElemIndent, commaIndent, decreasesElemIndent);
                            break;
                        }

                        break;
                    case "decreases":
                        {
                            if (IsFollowedByNewline(token))
                            {
                                SetOpeningIndentedRegion(token, indent + SpaceTab);
                                decreasesElemIndent = indent + SpaceTab + SpaceTab;
                                commaIndent = decreasesElemIndent;
                            }
                            else
                            {
                                SetAlign(indent + SpaceTab, token, out decreasesElemIndent, out commaIndent);
                            }

                            break;
                        }

                        break;
                    case "...":
                        {
                            SetDelimiterInsideIndentedRegions(token, indent);
                            break;
                        }

                        break;
                    case "ensures":
                    case "invariant":
                        {
                            if (IsFollowedByNewline(token))
                            {
                                SetOpeningIndentedRegion(token, indent + SpaceTab);
                            }
                            else
                            {
                                SetAlign(indent + SpaceTab, token, out _, out _);
                            }

                            break;
                        }

                        break;
                }
            }

            if (MutateCSharp.Schemata94.ReplaceBinExprOp_23(667L, body, null))
            {
                SetDelimiterIndentedRegions(body.Tok, indent);
                if (MutateCSharp.Schemata94.ReplaceBinExprOp_21(669L, body.EndToken.val, MutateCSharp.Schemata94.ReplaceStringConstant_11(668L, "}")))
                {
                    SetClosingIndentedRegion(body.EndToken, indent);
                }

                Visit(body, indent);
            }
        }

        public bool TryGetIndentAbove(IToken token, out int indent)
        {
            if (PosToIndentations(token.pos).Above is var aboveIndent and not -1)
            {
                indent = aboveIndent;
                return MutateCSharp.Schemata94.ReplaceBooleanConstant_0(670L, true);
            }

            indent = MutateCSharp.Schemata94.ReplaceNumericConstant_1(671L, 0);
            return MutateCSharp.Schemata94.ReplaceBooleanConstant_0(675L, false);
        }

        public bool TryGetIndentInline(IToken token, out int indent)
        {
            if (PosToIndentations(token.pos).Inline is var inlineIndent and not -1)
            {
                indent = inlineIndent;
                return MutateCSharp.Schemata94.ReplaceBooleanConstant_0(676L, true);
            }

            indent = MutateCSharp.Schemata94.ReplaceNumericConstant_1(677L, 0);
            return MutateCSharp.Schemata94.ReplaceBooleanConstant_0(681L, false);
        }

        /// For example, the "if" keyword in the context of a statement
        ///
        /// // Not indented
        /// if       // line not indented
        ///   x == 2 // Line indented
        public void SetOpeningIndentedRegion(IToken token, int indent)
        {
            SetIndentations(token, indent, indent, MutateCSharp.Schemata94.ReplaceBinExprOp_10(682L, indent, SpaceTab));
        }

        /// For example, a "," keyword in a specially indented list:
        ///
        /// var x, y :=   A()
        ///               // rightIndent
        ///           ,   // indent
        ///               // rightIndent
        ///               B();
        /// 
        private void SetDelimiterSpeciallyIndentedRegions(IToken token, int indent, int rightIndent)
        {
            SetIndentations(token, rightIndent, indent, rightIndent);
        }

        /// For example, a "else" keyword in an expression
        ///
        /// if true then
        ///   1
        ///   // indented
        /// else     // line not indented
        ///   x == 2 // Line indented
        public void SetDelimiterIndentedRegions(IToken token, int indent)
        {
            SetIndentations(token, MutateCSharp.Schemata94.ReplaceBinExprOp_10(691L, indent, SpaceTab), indent, MutateCSharp.Schemata94.ReplaceBinExprOp_10(700L, indent, SpaceTab));
        }

        /// For example, a ":=" token in an update statement
        ///
        /// x, y
        ///   // indented
        ///   := // indented
        ///   // indented
        ///   1, 2
        /// 
        public void SetDelimiterInsideIndentedRegions(IToken token, int indent)
        {
            SetIndentations(token, MutateCSharp.Schemata94.ReplaceBinExprOp_10(709L, indent, SpaceTab), MutateCSharp.Schemata94.ReplaceBinExprOp_10(718L, indent, SpaceTab), MutateCSharp.Schemata94.ReplaceBinExprOp_10(727L, indent, SpaceTab));
        }

        // For example, a closing brace
        //
        // var x: map<   T
        //           ,
        //               U
        //               // beforeIndent
        //           >   // this line indent's
        //           //  after liene indent
        // // not indented
        public void SetClosingIndentedRegionAligned(IToken token, int beforeIndent, int indent)
        {
            SetIndentations(token, beforeIndent, indent, indent);
        }

        /// For example, a closing brace
        ///
        /// if true {
        ///   // indented
        /// } // not indented
        /// // not indented
        public void SetClosingIndentedRegion(IToken token, int indent)
        {
            SetIndentations(token, MutateCSharp.Schemata94.ReplaceBinExprOp_10(736L, indent, SpaceTab), indent, indent);
        }

        /// For example, a semicolon
        ///
        /// var x := 2
        ///   // indented
        ///   ; // indented
        /// // not indented
        public void SetClosingIndentedRegionInside(IToken token, int indent)
        {
            SetIndentations(token, MutateCSharp.Schemata94.ReplaceBinExprOp_10(745L, indent, SpaceTab), MutateCSharp.Schemata94.ReplaceBinExprOp_10(754L, indent, SpaceTab), indent);
        }

        /// For example, a "else" keyword for a statement
        ///
        /// if x == 2 {
        /// }
        /// // not indented
        /// else // not indented
        /// // not indented
        /// {
        /// }
        /// // not indented
        public void SetKeywordWithoutSurroundingIndentation(IToken token, int indent)
        {
            SetIndentations(token, indent, indent, indent);
        }

        /// For example, an "equal" sign not followed by a space which indicates that things should be aligned
        ///
        /// var x, y :=    A()      //  The token ':=' is being considered
        ///           ,    B();
        /// ^indent and indentBefore
        ///                ^rightIndent
        ///           ^commaIndent
        /// 
        public void SetAlign(int indent, IToken token, out int rightIndent, out int commaIndent)
        {
            SetIndentations(token, indent, indent);
            rightIndent = GetRightAlignIndentAfter(token, indent);
            commaIndent = MutateCSharp.Schemata94.ReplaceBinExprOp_12(776L, MutateCSharp.Schemata94.ReplaceBinExprOp_10(763L, GetNewTokenVisualIndent(token, indent), token.val.Length), MutateCSharp.Schemata94.ReplaceNumericConstant_1(772L, 1));
            SetIndentations(token, below: rightIndent);
        }

        /// For example, a "then" keyword not followed by a newline, indicating that the content should be aligned with the first character.
        ///
        /// if X
        /// then   proofY();
        ///        result
        /// ^indent
        ///        ^ rightIndent
        /// else Z
        /// 
        public void SetAlignOpen(IToken token, int indent)
        {
            var rightIndent = GetRightAlignIndentAfter(token, indent);
            SetIndentations(token, indent, indent, rightIndent);
        }
    }
}