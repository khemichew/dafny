using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata215
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT215");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceNumericConstant_4(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
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

        internal static int ReplacePostfixUnaryExprOp_6(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_3(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Collections.Generic.List<(Microsoft.Dafny.IToken, string)> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_2(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny.Compilers
{
    public class CoverageInstrumenter
    {
        private readonly SinglePassCodeGenerator codeGenerator;
        private List<(IToken, string)>/*?*/ legend;  // non-null implies options.CoverageLegendFile is non-null
        private string talliesFilePath;

        public CoverageInstrumenter(SinglePassCodeGenerator codeGenerator)
        {
            this.codeGenerator = codeGenerator;
            if (MutateCSharp.Schemata215.ReplaceBinExprOp_0(1L, () => codeGenerator.Options?.CoverageLegendFile != null
        , () => codeGenerator.Options?.Get(CommonOptionBag.ExecutionCoverageReport) != null))
            {
                legend = new List<(IToken, string)>();
            }

            if (codeGenerator.Options?.Get(CommonOptionBag.ExecutionCoverageReport) != null)
            {
                talliesFilePath = Path.GetTempFileName();
            }
        }

        public bool IsRecording { get => MutateCSharp.Schemata215.ReplaceBinExprOp_1(7L, legend, null); }

        public void Instrument(IToken tok, string description, ConcreteSyntaxTree wr)
        {
            Contract.Requires(tok != null);
            Contract.Requires(description != null);
            Contract.Requires(wr != null || !IsRecording);
            if (MutateCSharp.Schemata215.ReplaceBinExprOp_1(8L, legend, null))
            {
                wr.Write(MutateCSharp.Schemata215.ReplaceStringConstant_2(9L, "DafnyProfiling.CodeCoverage.Record({0})"), legend.Count);
                codeGenerator.EndStmt(wr);
                legend.Add((tok, description));
            }
        }

        public void UnusedInstrumentationPoint(IToken tok, string description)
        {
            Contract.Requires(tok != null);
            Contract.Requires(description != null);
            if (MutateCSharp.Schemata215.ReplaceBinExprOp_1(10L, legend, null))
            {
                legend.Add((tok, description));
            }
        }

        public void InstrumentExpr(IToken tok, string description, bool resultValue, ConcreteSyntaxTree wr)
        {
            Contract.Requires(tok != null);
            Contract.Requires(description != null);
            Contract.Requires(wr != null || !IsRecording);
            if (MutateCSharp.Schemata215.ReplaceBinExprOp_1(11L, legend, null))
            {
                // The "Record" call always returns "true", so we negate it to get the value "false"
                wr.Write(MutateCSharp.Schemata215.ReplaceStringConstant_2(12L, "{1}DafnyProfiling.CodeCoverage.Record({0})"), legend.Count, resultValue ? "" : MutateCSharp.Schemata215.ReplaceStringConstant_2(13L, "!"));
                legend.Add((tok, description));
            }
        }

        /// <summary>
        /// Should be called once "n" has reached its final value
        /// </summary>
        public void EmitSetup(ConcreteSyntaxTree wr)
        {
            Contract.Requires(wr != null);
            if (MutateCSharp.Schemata215.ReplaceBinExprOp_1(14L, legend, null))
            {
                wr.Write(MutateCSharp.Schemata215.ReplaceStringConstant_2(15L, "DafnyProfiling.CodeCoverage.Setup({0}"), legend.Count);
                if (talliesFilePath != null)
                {
                    wr.Write($", @\"{talliesFilePath}\"");
                }
                wr.Write(MutateCSharp.Schemata215.ReplaceStringConstant_2(16L, ")"));
                codeGenerator.EndStmt(wr);
            }
        }

        public void EmitTearDown(ConcreteSyntaxTree wr)
        {
            Contract.Requires(wr != null);
            if (MutateCSharp.Schemata215.ReplaceBinExprOp_1(17L, legend, null))
            {
                wr.Write(MutateCSharp.Schemata215.ReplaceStringConstant_2(18L, "DafnyProfiling.CodeCoverage.TearDown()"));
                codeGenerator.EndStmt(wr);
            }
        }

        public void WriteLegendFile()
        {
            if (codeGenerator.Options?.CoverageLegendFile != null)
            {
                var filename = codeGenerator.Options.CoverageLegendFile;
                Contract.Assert(filename != null);
                TextWriter wr = MutateCSharp.Schemata215.ReplaceBinExprOp_3(20L, filename, MutateCSharp.Schemata215.ReplaceStringConstant_2(19L, "-")) ? codeGenerator.Options.OutputWriter : new StreamWriter(new FileStream(Path.GetFullPath(filename), FileMode.Create));
                {
                    for (var i = MutateCSharp.Schemata215.ReplaceNumericConstant_4(21L, 0); MutateCSharp.Schemata215.ReplaceBinExprOp_5(25L, i, legend.Count); MutateCSharp.Schemata215.ReplacePostfixUnaryExprOp_6(30L, ref i))
                    {
                        var e = legend[i];
                        wr.WriteLine($"{i}: {e.Item1.TokenToString(codeGenerator.Options)}: {e.Item2}");
                    }
                }
                legend = null;
            }
        }

        public void PopulateCoverageReport(CoverageReport coverageReport)
        {
            var coverageReportDir = codeGenerator.Options?.Get(CommonOptionBag.ExecutionCoverageReport);
            if (coverageReportDir != null)
            {
                var tallies = File.ReadLines(talliesFilePath).Select(int.Parse).ToArray();
                foreach (var ((token, _), tally) in legend.Zip(tallies))
                {
                    var label = MutateCSharp.Schemata215.ReplaceBinExprOp_7(35L, tally, MutateCSharp.Schemata215.ReplaceNumericConstant_4(31L, 0)) ? CoverageLabel.NotCovered : CoverageLabel.FullyCovered;
                    // For now we only identify branches at the line granularity,
                    // which matches what `dafny generate-tests ... --coverage-report` does as well.
                    var rangeToken = new RangeToken(new Token(token.line, MutateCSharp.Schemata215.ReplaceNumericConstant_4(40L, 1)), new Token(MutateCSharp.Schemata215.ReplaceBinExprOp_8(48L, token.line, MutateCSharp.Schemata215.ReplaceNumericConstant_4(44L, 1)), MutateCSharp.Schemata215.ReplaceNumericConstant_4(57L, 0)));
                    rangeToken.Uri = token.Uri;
                    coverageReport.LabelCode(rangeToken, label);
                }
            }
        }

    }
}
