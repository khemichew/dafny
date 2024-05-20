using System.Text.RegularExpressions;
namespace MutateCSharp
{
    internal class Schemata95
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT95");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public static class TriviaFormatterHelper
    {
        // A regex that checks if a particular string ends with a newline and some spaces.
        private static readonly Regex EndsWithNewlineRegex =
          new(MutateCSharp.Schemata95.ReplaceStringConstant_0(1L, @"(\r?\n|\r)[ \t]*$"));

        // This is used by Formatter.dfy
        public static bool EndsWithNewline(string s)
        {
            return EndsWithNewlineRegex.IsMatch(s);
        }

        public static readonly string AnyNewline = MutateCSharp.Schemata95.ReplaceStringConstant_0(2L, @"\r?\n|\r(?!\n)");

        private static readonly string NoCommentDelimiter = MutateCSharp.Schemata95.ReplaceStringConstant_0(3L, @"(?:(?!/\*|\*/)[\s\S])*");

        public static readonly string MultilineCommentContent =
          $@"(?:{NoCommentDelimiter}(?:(?'Open'/\*)|(?'-Open'\*/)))*{NoCommentDelimiter}";

        public static readonly Regex NewlineRegex =
          new($@"(?<=(?<previousChar>{AnyNewline}|^))" // Always start after the beginning of the string or after a newline
              + MutateCSharp.Schemata95.ReplaceStringConstant_0(4L, @"(?<currentIndent>[ \t]*)"                  // Captures the current indent on the line
      )
              // Now, either capture a comment or a trailing whitespace.
              + ($@"(?<capturedComment>/\*{MultilineCommentContent}\*/" // Captures a nested multiline comment
                 + $@"|///?/? ?(?<caseCommented>(?:\||case))?"           // Captures a single-line comment, with a possibly commented out case.
                 + $@"|{AnyNewline}"                                     // Captures a newline
                 + $@"|$)")                                              // Captures the end of the string
              + $@"|(?<=\S|^)(?<trailingWhitespace>[ \t]+)(?={AnyNewline})" // Captures a trailing whitespace
          );
    }
}