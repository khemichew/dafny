using System;
using System.IO;
using DafnyCore;
namespace MutateCSharp
{
    internal class Schemata302
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT302");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_7(long mutantId, System.Uri argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBooleanConstant_3(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, System.IO.TextWriter argument1, System.IO.TextWriter argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_4(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.ErrorLevel argument1, Microsoft.Dafny.ErrorLevel argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, int argument1, int argument2)
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
    public class ConsoleErrorReporter : BatchErrorReporter
    {
        private ConsoleColor ColorForLevel(ErrorLevel level)
        {
            switch (level)
            {
                case ErrorLevel.Error:
                    return ConsoleColor.Red;
                    break;
                case ErrorLevel.Warning:
                    return ConsoleColor.Yellow;
                    break;
                case ErrorLevel.Info:
                    return ConsoleColor.Green;
                    break;
                default:
                    throw new cce.UnreachableException();
                    break;
            }

            return default;
        }

        protected override bool MessageCore(MessageSource source, ErrorLevel level, string errorId, IToken tok, string msg)
        {
            var printMessage = MutateCSharp.Schemata302.ReplaceBinExprOp_2(8L, () => base.MessageCore(source, level, errorId, tok, msg), () => (MutateCSharp.Schemata302.ReplaceBinExprOp_1(2L, () => Options is { PrintTooltips: true }, () => MutateCSharp.Schemata302.ReplaceBinExprOp_0(1L, level, ErrorLevel.Info))));
            if (!printMessage)
            {
                return MutateCSharp.Schemata302.ReplaceBooleanConstant_3(14L, false);
            }

            // Extra indent added to make it easier to distinguish multiline error messages for clients that rely on the CLI
            msg = msg.Replace(MutateCSharp.Schemata302.ReplaceStringConstant_4(15L, "\n"), MutateCSharp.Schemata302.ReplaceStringConstant_4(16L, "\n "));

            ConsoleColor previousColor = Console.ForegroundColor;
            if (MutateCSharp.Schemata302.ReplaceBinExprOp_5(17L, Options.OutputWriter, Console.Out))
            {
                Console.ForegroundColor = ColorForLevel(level);
            }
            var errorLine = ErrorToString(level, tok, msg);

            if (MutateCSharp.Schemata302.ReplaceBinExprOp_2(26L, () => MutateCSharp.Schemata302.ReplaceBinExprOp_2(18L, () => Options.Verbose, () => !String.IsNullOrEmpty(errorId)), () => MutateCSharp.Schemata302.ReplaceBinExprOp_6(25L, errorId, MutateCSharp.Schemata302.ReplaceStringConstant_4(24L, "none"))))
            {
                errorLine += MutateCSharp.Schemata302.ReplaceStringConstant_4(32L, " (ID: ") + errorId + MutateCSharp.Schemata302.ReplaceStringConstant_4(33L, ")\n");
                var info = ErrorRegistry.GetDetail(errorId);
                if (info != null)
                {
                    errorLine += info; // already ends with eol character
                }
            }
            else
            {
                errorLine += MutateCSharp.Schemata302.ReplaceStringConstant_4(34L, "\n");
            }

            if (MutateCSharp.Schemata302.ReplaceBinExprOp_2(36L, () => Options.Get(Snippets.ShowSnippets), () => MutateCSharp.Schemata302.ReplaceBinExprOp_7(35L, tok.Uri, null)))
            {
                var tw = new StringWriter();
                Snippets.WriteSourceCodeSnippet(Options, tok.ToRange(), tw);
                errorLine += tw.ToString();
            }

            var innerToken = tok;
            while (innerToken is NestedToken nestedToken)
            {
                innerToken = nestedToken.Inner;
                if (MutateCSharp.Schemata302.ReplaceBinExprOp_2(59L, () => MutateCSharp.Schemata302.ReplaceBinExprOp_2(48L, () => MutateCSharp.Schemata302.ReplaceBinExprOp_8(42L, innerToken.Filepath, nestedToken.Filepath), () => MutateCSharp.Schemata302.ReplaceBinExprOp_9(43L, innerToken.line, nestedToken.line)), () => MutateCSharp.Schemata302.ReplaceBinExprOp_9(54L, innerToken.col, nestedToken.col)))
                {
                    continue;
                }

                var innerMessage = nestedToken.Message;
                if (innerMessage == null)
                {
                    innerMessage = MutateCSharp.Schemata302.ReplaceStringConstant_4(65L, "Related location");
                }
                else
                {
                    innerMessage = MutateCSharp.Schemata302.ReplaceStringConstant_4(66L, "Related location: ") + innerMessage;
                }

                errorLine += $"{innerToken.TokenToString(Options)}: {innerMessage}\n";
                if (MutateCSharp.Schemata302.ReplaceBinExprOp_2(68L, () => Options.Get(Snippets.ShowSnippets), () => MutateCSharp.Schemata302.ReplaceBinExprOp_7(67L, tok.Uri, null)))
                {
                    var tw = new StringWriter();
                    Snippets.WriteSourceCodeSnippet(Options, innerToken.ToRange(), tw);
                    errorLine += tw.ToString();
                }
            }

            Options.OutputWriter.Write(errorLine);

            if (MutateCSharp.Schemata302.ReplaceBinExprOp_5(74L, Options.OutputWriter, Console.Out))
            {
                Console.ForegroundColor = previousColor;
            }

            return MutateCSharp.Schemata302.ReplaceBooleanConstant_3(75L, true);
        }

        public ConsoleErrorReporter(DafnyOptions options) : base(options)
        {
        }
    }
}