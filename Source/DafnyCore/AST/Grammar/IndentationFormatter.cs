using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Formatting;
namespace MutateCSharp
{
    internal class Schemata87
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT87");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_4(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static int ReplaceBinExprOp_9(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_8(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Uri argument1, System.Uri argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_6(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
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

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_7(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public class IndentationFormatter : IIndentationFormatter
    {
        // If we ever decide that blank lines should keep spaces, we can set this to false. 
        public static readonly bool BlankNewlinesWithoutSpaces = MutateCSharp.Schemata87.ReplaceBooleanConstant_0(1L, true);

        // If we remove whitespace (tabs or space) at the end of lines. 
        public static readonly bool RemoveTrailingWhitespace = MutateCSharp.Schemata87.ReplaceBooleanConstant_0(2L, true);

        private TokenNewIndentCollector formatter;
        public IndentationFormatter(TokenNewIndentCollector formatter)
        {
            this.formatter = formatter;
        }

        /// <summary>
        /// Creates an IndentationFormatter for the given program,
        /// by immediately processing all nodes and assigning indentations to most structural tokens 
        /// </summary>
        public static IndentationFormatter ForProgram(Program program, Uri fileToFormat, bool reduceBlockiness = true)
        {
            var tokenNewIndentCollector = new TokenNewIndentCollector(program, fileToFormat)
            {
                ReduceBlockiness = reduceBlockiness
            };
            foreach (var child in program.DefaultModuleDef.PreResolveChildren)
            {
                var isPhysicalToken = MutateCSharp.Schemata87.ReplaceBinExprOp_2(7L, child.Tok.line, MutateCSharp.Schemata87.ReplaceNumericConstant_1(3L, 0));
                if (MutateCSharp.Schemata87.ReplaceBinExprOp_4(13L, () => isPhysicalToken, () => MutateCSharp.Schemata87.ReplaceBinExprOp_3(12L, child.Tok.Uri, fileToFormat)))
                {
                    continue;
                }
                if (child is TopLevelDecl topLevelDecl)
                {
                    tokenNewIndentCollector.SetDeclIndentation(topLevelDecl, MutateCSharp.Schemata87.ReplaceNumericConstant_1(19L, 0));
                }
                else if (child is Include include)
                {
                    if (include.OwnedTokens.Any())
                    {
                        tokenNewIndentCollector.SetOpeningIndentedRegion(include.OwnedTokens.First(), MutateCSharp.Schemata87.ReplaceNumericConstant_1(23L, 0));
                    }
                }
            }

            return new IndentationFormatter(tokenNewIndentCollector);
        }


        #region Override for implementing IIndentationFormatter

        public string GetNewLeadingTrivia(IToken token)
        {
            return GetNewTrivia(token, MutateCSharp.Schemata87.ReplaceBooleanConstant_0(27L, false));
        }

        public string GetNewTrailingTrivia(IToken token)
        {
            return GetNewTrivia(token, MutateCSharp.Schemata87.ReplaceBooleanConstant_0(28L, true));
        }

        /// This method implements IIndentationFormatter.Reindent and is called by Formatter.dfy
        /// It considers the space (trivia) before a token (if trailingTrivia == false)
        /// or the space after a token (if trailingTrivia == true)
        /// and add or remove spaces after every newline to adjust the indentation.
        ///
        /// It uses indentationBefore to fix the indentation everywhere, except if
        /// the space is a leading trivia (trailingTrivia == false)
        /// and it's the last consecutive space without newlines before the token,
        /// in which case it uses indentationInline
        ///
        /// Options:
        /// * If precededByNewline == true, it means that it's possible
        /// to add/remove spaces at the beginning of the string. Used only for leading trivia.
        /// * if trailingTrivia == true, then no indentation is added after
        ///   the eventual last newline  `\n`. Instead, when formatting the leading trivia.
        ///   of the next token, precededByNewline will be set to true.
        ///
        /// # Example
        /// 
        /// For example, consider the consecutive tokens ')' and 'const' in the following unformatted code,
        /// as well as the token 'b' and the final token '}' 
        ///
        /// ```
        /// module X {
        /// datatype A =
        ///     C()
        ///   // Comment
        ///         // continued
        ///
        ///       // Comment here
        ///  const b := 1
        ///
        /// // One last word
        ///   }
        /// ```
        ///
        /// 1. The trailing trivia of the token `)` is
        /// "\n  // Comment\n        // continued\n\n"
        ///
        /// That trivia will be processed with the options
        /// * trailingTrivia == true
        /// * precededByNewline == false (irrelevant, a trailing trivia is preceded by a token)
        /// * indentationBefore == "    " (4 spaces)
        /// * indentationInline == "    " (irrelevant)
        /// The method will return:
        /// "\n    // Comment\n    // continued\n\n"
        ///
        /// 2. The leading trivia of the token `const` is
        /// "      // Comment here\n "
        /// That trivia will be processed with the options
        /// * trailingTrivia == false
        /// * precededByNewline == true
        /// * indentationBefore == "  " (2 spaces, it's indentation for any comment before the constant)
        /// * indentationInline == "  " (2 spaces, it's the indentation in front of the "const" token if it's on its own line)
        /// The method will return:
        /// "  // Comment here\n  "
        ///
        /// 3. The leading trivia of the token `b``is
        /// " "
        /// That trivia will be processed with the options
        /// * trailingTrivia == false
        /// * precededByNewline == false
        /// * indentationBefore == "    "
        /// * indentationInline == "    "
        /// However, because there are no newlines and it's not preceded
        /// by a newline, the method will return the same:
        /// " "
        /// 
        /// 4. The leading trivia of the token `}` is
        /// "// One last word\n"
        /// That trivia will be processed with the options
        /// * trailingTrivia == false
        /// * precededByNewline == true
        /// * indentationBefore == "  "
        /// * indentationInline == ""
        /// This is an example where a comment before this token should not
        /// be aligned with that token, the method will return:
        /// "  // One last word\n"
        ///
        /// After all these formattings, the final result will be the expected one
        /// ```
        /// module X {
        ///   datatype A =
        ///     C()
        ///     // Comment
        ///     // continued
        ///
        ///   // Comment here
        ///   const b := 1
        ///
        ///   // One last word
        /// }
        /// ```
        public string GetNewTrivia(IToken token, bool trailingTrivia)
        {
            var precededByNewline = MutateCSharp.Schemata87.ReplaceBinExprOp_4(36L, () => MutateCSharp.Schemata87.ReplaceBinExprOp_4(30L, () => MutateCSharp.Schemata87.ReplaceBinExprOp_5(29L, token.Prev, null), () => !trailingTrivia), () => TriviaFormatterHelper.EndsWithNewline(token.Prev.TrailingTrivia));
            if (MutateCSharp.Schemata87.ReplaceBinExprOp_6(42L, token.val, ""))
            {
                return trailingTrivia ? token.TrailingTrivia : token.LeadingTrivia;
            }
            var indentationBefore = Whitespace(
              trailingTrivia ?
                formatter.GetIndentBelowOrInlineOrAbove(token) :
                formatter.GetIndentAbove(token));
            var indentationInline = trailingTrivia ?
              Whitespace(formatter.GetIndentBelowOrInlineOrAbove(token)) :
              Whitespace(formatter.GetIndentInlineOrAbove(token));
            //indentationBefore = GetIndentInlineOrAbove(token);
            var input = trailingTrivia ? token.TrailingTrivia : token.LeadingTrivia;
            // Invariant: Relative indentation inside a multi-line comment should be unchanged
            var originalCommentIndent = MutateCSharp.Schemata87.ReplaceNumericConstant_1(43L, 0);
            var newCommentIndent = MutateCSharp.Schemata87.ReplaceNumericConstant_1(47L, 0);
            var previousMatchWasSingleLineCommentToAlign = MutateCSharp.Schemata87.ReplaceBooleanConstant_0(51L, false);


            return TriviaFormatterHelper.NewlineRegex.Replace(input, match =>
            {
                // Apply the given rules on a match of a (newline|beginning) + space + optional comment
                if (match.Groups[MutateCSharp.Schemata87.ReplaceStringConstant_7(52L, "trailingWhitespace")].Success)
                {
                    return RemoveTrailingWhitespace ? "" : match.Groups[MutateCSharp.Schemata87.ReplaceStringConstant_7(53L, "trailingWhitespace")].Value;
                }

                var startOfString = MutateCSharp.Schemata87.ReplaceBinExprOp_6(55L, match.Groups[MutateCSharp.Schemata87.ReplaceStringConstant_7(54L, "previousChar")].Value, "");
                var capturedComment = match.Groups[MutateCSharp.Schemata87.ReplaceStringConstant_7(56L, "capturedComment")].Value;
                var currentIndent = match.Groups[MutateCSharp.Schemata87.ReplaceStringConstant_7(57L, "currentIndent")].Value.Length;
                var entireMatch = match.Groups[MutateCSharp.Schemata87.ReplaceNumericConstant_1(58L, 0)].Value;
                var caseCommented = match.Groups[MutateCSharp.Schemata87.ReplaceStringConstant_7(62L, "caseCommented")];
                if (MutateCSharp.Schemata87.ReplaceBinExprOp_4(63L, () => startOfString, () => !precededByNewline))
                {
                    if (MutateCSharp.Schemata87.ReplaceBinExprOp_4(79L, () => capturedComment.StartsWith(MutateCSharp.Schemata87.ReplaceStringConstant_7(69L, "//")), () => MutateCSharp.Schemata87.ReplaceBinExprOp_8(74L, originalCommentIndent, MutateCSharp.Schemata87.ReplaceNumericConstant_1(70L, 0))))
                    {
                        // Possibly align consecutive // trailing comments
                        originalCommentIndent = MutateCSharp.Schemata87.ReplaceBinExprOp_10(107L, MutateCSharp.Schemata87.ReplaceBinExprOp_10(98L, MutateCSharp.Schemata87.ReplaceBinExprOp_9(89L, token.col, MutateCSharp.Schemata87.ReplaceNumericConstant_1(85L, 1)), token.val.Length), currentIndent);
                        newCommentIndent = MutateCSharp.Schemata87.ReplaceBinExprOp_10(129L, MutateCSharp.Schemata87.ReplaceBinExprOp_10(120L, formatter.GetNewTokenVisualIndent(token, MutateCSharp.Schemata87.ReplaceNumericConstant_1(116L, 0)), token.val.Length), currentIndent);
                        previousMatchWasSingleLineCommentToAlign = MutateCSharp.Schemata87.ReplaceBooleanConstant_0(138L, true);
                    }

                    var isTrailingWhitespace = MutateCSharp.Schemata87.ReplaceBinExprOp_11(141L, () => capturedComment.StartsWith(MutateCSharp.Schemata87.ReplaceStringConstant_7(139L, "\r")), () => capturedComment.StartsWith(MutateCSharp.Schemata87.ReplaceStringConstant_7(140L, "\n")));
                    if (MutateCSharp.Schemata87.ReplaceBinExprOp_4(147L, () => RemoveTrailingWhitespace, () => isTrailingWhitespace))
                    {
                        precededByNewline = MutateCSharp.Schemata87.ReplaceBooleanConstant_0(153L, true);
                        return capturedComment;
                    }

                    if (!capturedComment.StartsWith(MutateCSharp.Schemata87.ReplaceStringConstant_7(154L, "/*")))
                    {
                        return entireMatch;
                    }
                }

                var noMoreComment = MutateCSharp.Schemata87.ReplaceBinExprOp_8(159L, capturedComment.Length, MutateCSharp.Schemata87.ReplaceNumericConstant_1(155L, 0));
                if (noMoreComment)
                {
                    //If no comment was captured, it means we reached the end of the trivia. Do we indent or not?
                    return trailingTrivia ? "" : (precededByNewline ? indentationInline : entireMatch);
                }

                if (!startOfString)
                {
                    precededByNewline = MutateCSharp.Schemata87.ReplaceBooleanConstant_0(164L, true);
                }

                if (capturedComment.StartsWith(MutateCSharp.Schemata87.ReplaceStringConstant_7(165L, "/*")))
                {
                    return ReIndentMultilineComment(token, capturedComment, currentIndent, indentationBefore, precededByNewline, out previousMatchWasSingleLineCommentToAlign);
                }

                if (capturedComment.StartsWith(MutateCSharp.Schemata87.ReplaceStringConstant_7(166L, "//")))
                {
                    return ReIndentSingleLineComment(token, capturedComment, originalCommentIndent, currentIndent, newCommentIndent, caseCommented, ref previousMatchWasSingleLineCommentToAlign, ref indentationBefore);
                }

                if (MutateCSharp.Schemata87.ReplaceBinExprOp_11(169L, () => capturedComment.StartsWith(MutateCSharp.Schemata87.ReplaceStringConstant_7(167L, "\r")), () => capturedComment.StartsWith(MutateCSharp.Schemata87.ReplaceStringConstant_7(168L, "\n"))))
                {
                    previousMatchWasSingleLineCommentToAlign = MutateCSharp.Schemata87.ReplaceBooleanConstant_0(175L, false);
                    return (BlankNewlinesWithoutSpaces ? "" : indentationBefore) + capturedComment;
                }

                previousMatchWasSingleLineCommentToAlign = MutateCSharp.Schemata87.ReplaceBooleanConstant_0(176L, false);

                // Last line
                return indentationInline;
            });
        }

        private string ReIndentMultilineComment(IToken token, string capturedComment, int currentIndent,
          string indentationBefore, bool precededByNewline, out bool previousMatchWasSingleLineCommentToAlign)
        {
            var doubleStar = MutateCSharp.Schemata87.ReplaceBinExprOp_4(179L, () => capturedComment.StartsWith(MutateCSharp.Schemata87.ReplaceStringConstant_7(177L, "/**")), () => !capturedComment.StartsWith(MutateCSharp.Schemata87.ReplaceStringConstant_7(178L, "/***")));

            var absoluteOriginalIndent = currentIndent;
            var newAbsoluteIndent = indentationBefore.Length;
            if (!precededByNewline)
            {
                // It has to be the trailing trivia of that token.
                absoluteOriginalIndent = MutateCSharp.Schemata87.ReplaceBinExprOp_10(207L, MutateCSharp.Schemata87.ReplaceBinExprOp_10(198L, MutateCSharp.Schemata87.ReplaceBinExprOp_9(189L, token.col, MutateCSharp.Schemata87.ReplaceNumericConstant_1(185L, 1)), token.val.Length), absoluteOriginalIndent);
                newAbsoluteIndent = MutateCSharp.Schemata87.ReplaceBinExprOp_10(225L, MutateCSharp.Schemata87.ReplaceBinExprOp_10(216L, formatter.GetNewTokenVisualIndent(token, indentationBefore.Length), token.val.Length), currentIndent);
            }

            var relativeIndent = MutateCSharp.Schemata87.ReplaceBinExprOp_9(234L, newAbsoluteIndent, absoluteOriginalIndent);
            var initialRelativeIndent = relativeIndent;
            var tryAgain = MutateCSharp.Schemata87.ReplaceBooleanConstant_0(243L, true);
            var result = "";
            // This loop executes at most two times. The second time is necessary only if the indentation before the first /* decreases
            // and there were items that would have been moved into a negative column.
            // e.g.
            //
            // const x := 2;
            //     /* Start of comment
            //   end of comment */
            //
            // would be, after the first iteration
            //
            // const x := 2;
            // /* Start of comment
            // end of comment */
            //
            // which breaks the alignment. So with `tryAgain`, it  corrects the offset so that the comment becomes:
            //
            // const x := 2;
            //   /* Start of comment
            // end of comment */
            //
            while (tryAgain)
            // decreases newAbsoluteIndent - relativeIndent
            {
                var canIndentLinesStartingWithStar = MutateCSharp.Schemata87.ReplaceBooleanConstant_0(244L, true);
                tryAgain = MutateCSharp.Schemata87.ReplaceBooleanConstant_0(245L, false);
                result = new Regex($@"(?<=\r?\n|\r(?!\n))(?<existingIndent>[ \t]*)(?<star>\*)?").Replace(capturedComment,
                  match1 =>
                  {
                      if (MutateCSharp.Schemata87.ReplaceBinExprOp_4(247L, () => canIndentLinesStartingWithStar, () => match1.Groups[MutateCSharp.Schemata87.ReplaceStringConstant_7(246L, "star")].Success))
                      {
                          return indentationBefore + (doubleStar ? MutateCSharp.Schemata87.ReplaceStringConstant_7(253L, "  *") : MutateCSharp.Schemata87.ReplaceStringConstant_7(254L, " *"));
                      }

                      canIndentLinesStartingWithStar = MutateCSharp.Schemata87.ReplaceBooleanConstant_0(255L, false);
                      // Reindent in block:
                      var newIndent = MutateCSharp.Schemata87.ReplaceBinExprOp_10(257L, match1.Groups[MutateCSharp.Schemata87.ReplaceStringConstant_7(256L, "existingIndent")].Value.Length, relativeIndent);
                      if (MutateCSharp.Schemata87.ReplaceBinExprOp_12(270L, newIndent, MutateCSharp.Schemata87.ReplaceNumericConstant_1(266L, 0)))
                      {
                          relativeIndent -= newIndent;
                          tryAgain = MutateCSharp.Schemata87.ReplaceBooleanConstant_0(275L, true);
                          newIndent = MutateCSharp.Schemata87.ReplaceNumericConstant_1(276L, 0);
                      }

                      return Whitespace(newIndent) + (match1.Groups[MutateCSharp.Schemata87.ReplaceStringConstant_7(280L, "star")].Success ? match1.Groups[MutateCSharp.Schemata87.ReplaceStringConstant_7(281L, "star")].Value : "");
                  });
            }

            previousMatchWasSingleLineCommentToAlign = MutateCSharp.Schemata87.ReplaceBooleanConstant_0(282L, false);
            if (precededByNewline)
            {
                return Whitespace(MutateCSharp.Schemata87.ReplaceBinExprOp_10(283L, absoluteOriginalIndent, relativeIndent)) + result;
            }

            return Whitespace(MutateCSharp.Schemata87.ReplaceBinExprOp_9(301L, MutateCSharp.Schemata87.ReplaceBinExprOp_10(292L, currentIndent, relativeIndent), initialRelativeIndent)) + result;
        }

        private string ReIndentSingleLineComment(IToken token, string capturedComment, int originalCommentIndent,
          int currentIndent, int newCommentIndent, Group caseCommented, ref bool previousMatchWasSingleLineCommentToAlign,
          ref string indentationBefore)
        {
            if (MutateCSharp.Schemata87.ReplaceBinExprOp_4(312L, () => capturedComment.StartsWith(MutateCSharp.Schemata87.ReplaceStringConstant_7(310L, "///")), () => !capturedComment.StartsWith(MutateCSharp.Schemata87.ReplaceStringConstant_7(311L, "////"))))
            {
                // No indentation
                return capturedComment;
            }

            if (previousMatchWasSingleLineCommentToAlign && MutateCSharp.Schemata87.ReplaceBinExprOp_8(318L, originalCommentIndent, currentIndent))
            {
                return Whitespace(newCommentIndent) + capturedComment;
            }

            var referenceToken = token.Next;
            var isCommentedCaseFollowedByCase = MutateCSharp.Schemata87.ReplaceBinExprOp_4(338L, () => MutateCSharp.Schemata87.ReplaceBinExprOp_4(324L, () => caseCommented.Success, () => MutateCSharp.Schemata87.ReplaceBinExprOp_5(323L, token.Next, null)), () => (MutateCSharp.Schemata87.ReplaceBinExprOp_11(332L, () => MutateCSharp.Schemata87.ReplaceBinExprOp_6(330L, token.Next.val, caseCommented.Value), () => TokenNewIndentCollector.FirstTokenOnLineIs(
                                                        token, t =>
                                                        {
                                                            referenceToken = t;
                                                            return MutateCSharp.Schemata87.ReplaceBinExprOp_6(331L, t.val, caseCommented.Value);
                                                        }))));
            if (isCommentedCaseFollowedByCase)
            {
                indentationBefore = Whitespace(formatter.GetNewTokenVisualIndent(referenceToken, indentationBefore.Length));
            }

            previousMatchWasSingleLineCommentToAlign = MutateCSharp.Schemata87.ReplaceBooleanConstant_0(344L, false);

            return indentationBefore + capturedComment;
        }

        private static readonly ConcurrentDictionary<int, string> WhitespaceCache = new();

        public static string Whitespace(int characters)
        {
            return WhitespaceCache.GetOrAdd(characters, _ => new string(' ', characters));
        }

        #endregion
    }
}
