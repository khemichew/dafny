using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Dafny;
namespace MutateCSharp
{
    internal class Schemata468
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT468");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceNumericConstant_2(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static int ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static int ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace DafnyCore
{
    public class Snippets
    {
        public static readonly Option<bool> ShowSnippets = new(MutateCSharp.Schemata468.ReplaceStringConstant_0(1L, "--show-snippets"), () => MutateCSharp.Schemata468.ReplaceBooleanConstant_1(2L, true),
      MutateCSharp.Schemata468.ReplaceStringConstant_0(3L, "Show a source code snippet for each Dafny message."));

        static Snippets()
        {
            DooFile.RegisterNoChecksNeeded(ShowSnippets, MutateCSharp.Schemata468.ReplaceBooleanConstant_1(4L, false));
        }

        public static void WriteSourceCodeSnippet(DafnyOptions options, IToken tok, TextWriter tw)
        {
            string line = GetFileLine(options, tok.Uri, MutateCSharp.Schemata468.ReplaceBinExprOp_3(9L, tok.line, MutateCSharp.Schemata468.ReplaceNumericConstant_2(5L, 1)));
            if (line == null)
            {
                return;
            }

            string lineNumber = tok.line.ToString();
            string lineNumberSpaces = new string(' ', lineNumber.Length);
            string columnSpaces = new string(' ', MutateCSharp.Schemata468.ReplaceBinExprOp_3(22L, tok.col, MutateCSharp.Schemata468.ReplaceNumericConstant_2(18L, 1)));
            var lineStartPos = MutateCSharp.Schemata468.ReplaceBinExprOp_4(44L, MutateCSharp.Schemata468.ReplaceBinExprOp_3(31L, tok.pos, tok.col), MutateCSharp.Schemata468.ReplaceNumericConstant_2(40L, 1));
            var lineEndPos = MutateCSharp.Schemata468.ReplaceBinExprOp_4(53L, lineStartPos, line.Length);

            var tokEndPos = MutateCSharp.Schemata468.ReplaceBinExprOp_4(62L, tok.pos, tok.val.Length);
            if (tok is RangeToken rangeToken)
            {
                tokEndPos = MutateCSharp.Schemata468.ReplaceBinExprOp_4(71L, rangeToken.EndToken.pos, rangeToken.EndToken.val.Length);
            }
            var underlineLength = Math.Max(MutateCSharp.Schemata468.ReplaceNumericConstant_2(80L, 1), Math.Min(MutateCSharp.Schemata468.ReplaceBinExprOp_3(84L, tokEndPos, tok.pos), MutateCSharp.Schemata468.ReplaceBinExprOp_3(93L, lineEndPos, tok.pos)));
            string underline = new string('^', underlineLength);
            tw.WriteLine($"{lineNumberSpaces} |");
            tw.WriteLine($"{lineNumber} | {line}");
            tw.WriteLine($"{lineNumberSpaces} | {columnSpaces}{underline}");
            tw.WriteLine("");
        }

        private static string GetFileLine(DafnyOptions options, Uri uri, int lineIndex)
        {
            var fsCache = FsCaches.GetOrCreateValue(options)!;
            List<string> lines = fsCache.GetOrAdd(uri, key =>
            {
                try
                {
                    // Note: This is not guaranteed to be the same file that Dafny parsed. To ensure that, Dafny should keep
                    // an in-memory version of each file it parses.
                    var file = DafnyFile.HandleDafnyFile(OnDiskFileSystem.Instance, new ErrorReporterSink(options), options, uri, Token.NoToken);
                    using var reader = file.GetContent();
                    lines = Util.Lines(reader).ToList();
                }
                catch (Exception)
                {
                    lines = new List<string>();
                }
                return lines;
            });
            if (MutateCSharp.Schemata468.ReplaceBinExprOp_7(116L, () => MutateCSharp.Schemata468.ReplaceBinExprOp_5(106L, MutateCSharp.Schemata468.ReplaceNumericConstant_2(102L, 0), lineIndex), () => MutateCSharp.Schemata468.ReplaceBinExprOp_6(111L, lineIndex, lines.Count)))
            {
                return lines[lineIndex];
            }
            return null;
        }

        private static readonly ConditionalWeakTable<DafnyOptions, ConcurrentDictionary<Uri, List<string>>> FsCaches = new();
    }
}