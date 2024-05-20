using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Bpl = Microsoft.Boogie;
namespace MutateCSharp
{
    internal class Schemata503
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT503");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.TestGenerationOptions.Modes argument1, Microsoft.Dafny.TestGenerationOptions.Modes argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
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

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

    }
}

namespace Microsoft.Dafny
{
    public static class CaptureStateExtensions
    {

        public const string AfterLoopIterationsStateMarker = "after some loop iterations";

        internal static void AddCaptureState(this BoogieStmtListBuilder builder, Statement statement)
        {
            if (MutateCSharp.Schemata503.ReplaceBinExprOp_1(2L, () => builder.Options.ExpectingModel, () => MutateCSharp.Schemata503.ReplaceBinExprOp_0(1L, builder.Options.TestGenOptions.Mode, TestGenerationOptions.Modes.None)))
            {
                builder.Add(CaptureState(builder.Options, statement));
            }
        }

        private static Bpl.Cmd CaptureState(DafnyOptions options, Statement stmt)
        {
            Contract.Requires(stmt != null);
            Contract.Ensures(Contract.Result<Bpl.Cmd>() != null);
            return CaptureState(options, stmt.RangeToken.EndToken, MutateCSharp.Schemata503.ReplaceBooleanConstant_2(8L, true), null);
        }

        internal static void AddCaptureState(this BoogieStmtListBuilder builder, IToken tok, bool isEndToken, string /*?*/ additionalInfo)
        {
            if (MutateCSharp.Schemata503.ReplaceBinExprOp_1(10L, () => builder.Options.ExpectingModel, () => MutateCSharp.Schemata503.ReplaceBinExprOp_0(9L, builder.Options.TestGenOptions.Mode, TestGenerationOptions.Modes.None)))
            {
                builder.Add(CaptureState(builder.Options, tok, isEndToken, additionalInfo));
            }
        }

        private static Bpl.Cmd CaptureState(DafnyOptions options, IToken tok, bool isEndToken, string/*?*/ additionalInfo)
        {
            Contract.Requires(tok != null);
            Contract.Ensures(Contract.Result<Bpl.Cmd>() != null);
            string description;
            if (MutateCSharp.Schemata503.ReplaceBinExprOp_3(24L, () => MutateCSharp.Schemata503.ReplaceBinExprOp_3(17L, () => MutateCSharp.Schemata503.ReplaceBinExprOp_0(16L, options.TestGenOptions.Mode, TestGenerationOptions.Modes.None), () => tok.val != null), () => tok.val.StartsWith(MutateCSharp.Schemata503.ReplaceStringConstant_4(23L, "#"))))
            {
                description = $"{tok.TokenToString(options)}{(additionalInfo == null ? tok.val : (MutateCSharp.Schemata503.ReplaceStringConstant_4(30L, ": ") + additionalInfo))}";
            }
            else
            {
                description = $"{tok.TokenToString(options)}{(additionalInfo == null ? "" : (MutateCSharp.Schemata503.ReplaceStringConstant_4(31L, ": ") + additionalInfo))}";
            }
            Bpl.QKeyValue kv = new Bpl.QKeyValue(tok, MutateCSharp.Schemata503.ReplaceStringConstant_4(32L, "captureState"), new List<object>() { description }, null);
            return BoogieGenerator.TrAssumeCmd(tok, Bpl.Expr.True, kv);
        }
    }
}