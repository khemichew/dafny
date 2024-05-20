#nullable enable

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using VCGeneration;
using static Microsoft.Dafny.ErrorRegistry;
namespace MutateCSharp
{
    internal class Schemata320
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT320");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
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

        internal static int ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.ErrorLevel argument1, Microsoft.Dafny.ErrorLevel argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_3(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
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

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.ErrorLevel argument1, Microsoft.Dafny.ErrorLevel argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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
    public
record DiagnosticMessageData(MessageSource source, ErrorLevel level, Boogie.IToken tok, string? category, string message, List<ErrorInformation.AuxErrorInfo>? related)
    {
        private static JsonObject SerializePosition(Boogie.IToken tok)
        {
            return new JsonObject
            {
                [MutateCSharp.Schemata320.ReplaceStringConstant_0(1L, "pos")] = tok.pos,
                [MutateCSharp.Schemata320.ReplaceStringConstant_0(2L, "line")] = tok.line,
                [MutateCSharp.Schemata320.ReplaceStringConstant_0(3L, "character")] = MutateCSharp.Schemata320.ReplaceBinExprOp_2(8L, tok.col, MutateCSharp.Schemata320.ReplaceNumericConstant_1(4L, 1
        ))
            };
        }

        private static JsonObject SerializeRange(Boogie.IToken tok)
        {
            var range = new JsonObject
            {
                [MutateCSharp.Schemata320.ReplaceStringConstant_0(17L, "start")] = SerializePosition(tok),
            };
            if (tok is RangeToken rangeToken1)
            {
                range[MutateCSharp.Schemata320.ReplaceStringConstant_0(18L, "end")] = SerializePosition(rangeToken1.EndToken);
            }
            else if (tok is BoogieRangeToken rangeToken2)
            {
                range[MutateCSharp.Schemata320.ReplaceStringConstant_0(19L, "end")] = SerializePosition(rangeToken2.EndToken);
            }
            return range;
        }

        private static JsonObject SerializeToken(Boogie.IToken tok)
        {
            return new JsonObject
            {
                [MutateCSharp.Schemata320.ReplaceStringConstant_0(20L, "filename")] = tok.filename,
                [MutateCSharp.Schemata320.ReplaceStringConstant_0(21L, "uri")] = ((IToken)tok).Uri.AbsoluteUri,
                [MutateCSharp.Schemata320.ReplaceStringConstant_0(22L, "range")] = SerializeRange(tok)
            };
        }

        private static int SerializeErrorLevel(ErrorLevel lvl)
        {
            return lvl switch
            {
                ErrorLevel.Error => MutateCSharp.Schemata320.ReplaceNumericConstant_1(23L, 1),
                ErrorLevel.Warning => MutateCSharp.Schemata320.ReplaceNumericConstant_1(27L, 2),
                ErrorLevel.Info => MutateCSharp.Schemata320.ReplaceNumericConstant_1(31L, 4),
                _ => throw new ArgumentException()
            };
        }

        private static string SerializeMessage(string? category, string message)
        {
            return category == null ? message : $"{category}: {message}";
        }

        private static JsonObject SerializeRelated(Boogie.IToken tok, string? category, string message)
        {
            return new JsonObject
            {
                [MutateCSharp.Schemata320.ReplaceStringConstant_0(35L, "location")] = SerializeToken(tok),
                [MutateCSharp.Schemata320.ReplaceStringConstant_0(36L, "message")] = SerializeMessage(category, message),
            };
        }

        private static IEnumerable<JsonNode> SerializeInnerTokens(Boogie.IToken tok)
        {
            while (tok is NestedToken nestedToken)
            {
                tok = nestedToken.Inner;
                var message = nestedToken.Message != null ? MutateCSharp.Schemata320.ReplaceStringConstant_0(37L, "Related location: ") + nestedToken.Message : MutateCSharp.Schemata320.ReplaceStringConstant_0(38L, "Related location");
                yield return SerializeRelated(tok, null, message);
            }

            yield break;
        }

        private static IEnumerable<JsonNode> SerializeAuxInfo(ErrorInformation.AuxErrorInfo aux)
        {
            yield return SerializeRelated(aux.Tok, aux.Category, aux.Msg);
            foreach (var n in SerializeInnerTokens(aux.Tok))
            {
                yield return n;
            }

            yield break;
        }

        public JsonNode ToJson()
        {
            var auxRelated = related?.SelectMany(SerializeAuxInfo) ?? Enumerable.Empty<JsonNode>();
            var innerRelated = SerializeInnerTokens(tok);
            return new JsonObject
            {
                [MutateCSharp.Schemata320.ReplaceStringConstant_0(39L, "location")] = SerializeToken(tok),
                [MutateCSharp.Schemata320.ReplaceStringConstant_0(40L, "severity")] = SerializeErrorLevel(level),
                [MutateCSharp.Schemata320.ReplaceStringConstant_0(41L, "message")] = SerializeMessage(category, message),
                [MutateCSharp.Schemata320.ReplaceStringConstant_0(42L, "source")] = source.ToString(),
                [MutateCSharp.Schemata320.ReplaceStringConstant_0(43L, "relatedInformation")] = new JsonArray(auxRelated.Concat(innerRelated).ToArray())
            };
        }

        public void WriteJsonTo(TextWriter wr)
        {
            wr.WriteLine(ToJson().ToJsonString(new JsonSerializerOptions { WriteIndented = MutateCSharp.Schemata320.ReplaceBooleanConstant_3(44L, false) }));
        }
    }

    public class DafnyJsonConsolePrinter : DafnyConsolePrinter
    {
        public override void ReportBplError(Boogie.IToken tok, string message, bool error, TextWriter tw, string? category = null)
        {
            var level = error ? ErrorLevel.Error : ErrorLevel.Warning;
            new DiagnosticMessageData(MessageSource.Verifier, level, tok, category, message, null).WriteJsonTo(tw);
        }

        public override void WriteErrorInformation(VCGeneration.ErrorInformation errorInfo, TextWriter tw, bool skipExecutionTrace = true)
        {
            var related = errorInfo.Aux.Where(e =>
              !(MutateCSharp.Schemata320.ReplaceBinExprOp_4(46L, () => skipExecutionTrace, () => (e.Category ?? "").Contains(MutateCSharp.Schemata320.ReplaceStringConstant_0(45L, "Execution trace"))))).ToList();
            new DiagnosticMessageData(MessageSource.Verifier, ErrorLevel.Error,
              errorInfo.Tok, errorInfo.Category, errorInfo.Msg, related).WriteJsonTo(tw);
            tw.Flush();
        }

        public DafnyJsonConsolePrinter(DafnyOptions options) : base(options)
        {
        }
    }

    public class JsonConsoleErrorReporter : BatchErrorReporter
    {
        protected override bool MessageCore(MessageSource source, ErrorLevel level, string errorID, Dafny.IToken tok, string msg)
        {
            if (MutateCSharp.Schemata320.ReplaceBinExprOp_4(59L, () => base.MessageCore(source, level, errorID, tok, msg), () => (MutateCSharp.Schemata320.ReplaceBinExprOp_6(53L, () => Options is { PrintTooltips: true }, () => MutateCSharp.Schemata320.ReplaceBinExprOp_5(52L, level, ErrorLevel.Info)))))
            {
                new DiagnosticMessageData(source, level, tok, MutateCSharp.Schemata320.ReplaceBinExprOp_7(65L, level, ErrorLevel.Error) ? MutateCSharp.Schemata320.ReplaceStringConstant_0(66L, "Error") : null, msg, null).WriteJsonTo(Options.OutputWriter);
                return MutateCSharp.Schemata320.ReplaceBooleanConstant_3(67L, true);
            }

            return MutateCSharp.Schemata320.ReplaceBooleanConstant_3(68L, false);
        }

        public JsonConsoleErrorReporter(DafnyOptions options) : base(options)
        {
        }
    }
}