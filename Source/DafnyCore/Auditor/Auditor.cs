#nullable enable
using System;
using System.IO;
using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
using System.Text.RegularExpressions;
using DafnyCore;
namespace MutateCSharp
{
    internal class Schemata212
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT212");
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

        internal static int ReplaceNumericConstant_1(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
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

namespace Microsoft.Dafny.Auditor
{

    /// <summary>
    /// A rewriter pass that produces an AuditReport and writes it to either
    /// standard output or a file, in one of several formats. If neither a file
    /// or a format is provided, it reports all assumptions as warnings.
    /// </summary>
    public class Auditor : IRewriter
    {
        public enum ReportFormat { HTML, MarkdownTable, MarkdownIETF, Text }

        public static readonly Option<string> ReportFileOption = new(MutateCSharp.Schemata212.ReplaceStringConstant_0(1L, "--report-file"),
      MutateCSharp.Schemata212.ReplaceStringConstant_0(2L, "Specify a path to store the audit report file. Without this, the report will take the form of standard warnings."));
        public static readonly Option<bool> CompareReportOption = new(MutateCSharp.Schemata212.ReplaceStringConstant_0(3L, "--compare-report"),
      MutateCSharp.Schemata212.ReplaceStringConstant_0(4L, "Compare the report that would have been generated with the existing file given by --report-file, and fail if they differ."));

        public static string SupportedReportFormats = MutateCSharp.Schemata212.ReplaceStringConstant_0(5L, "plain text in the format of warnings ('txt', 'text'); standalone HTML ('html'); a Markdown table ('md', 'markdown', 'md-table', 'markdown-table'); or an IETF-language document in Markdown format ('md-ietf', 'markdown-ietf')");

        public static Option<ReportFormat?> ReportFormatOption =
          new(MutateCSharp.Schemata212.ReplaceStringConstant_0(6L, "--report-format"),
            arg =>
            {
                if (arg.Tokens.Any())
                {
                    switch (arg.Tokens[MutateCSharp.Schemata212.ReplaceNumericConstant_1(7L, 0)].Value)
                    {
                        case "md":
                        case "md-table":
                        case "markdown":
                        case "markdown-table":
                            return ReportFormat.MarkdownTable;
                            break;
                        case "md-ietf":
                        case "markdown-ietf":
                            return ReportFormat.MarkdownIETF;
                            break;
                        case "html":
                            return ReportFormat.HTML;
                            break;
                        case "text":
                        case "txt":
                            return ReportFormat.Text;
                            break;
                        default:
                            arg.ErrorMessage =
                        $"Unsupported report format. Supported formats are: {SupportedReportFormats}";
                            return null;
                            break;
                    }
                }

                return null;
            },
      MutateCSharp.Schemata212.ReplaceBooleanConstant_2(11L, false),
            $"Specify the file format to use for the audit report. Supported options include: {SupportedReportFormats}. " +
      MutateCSharp.Schemata212.ReplaceStringConstant_0(12L, "With no option given, the format will be inferred from the filename extension. ") +
      MutateCSharp.Schemata212.ReplaceStringConstant_0(13L, "With no filename or format given, the report will consist of standard Dafny warnings."))
          {
              ArgumentHelpName = MutateCSharp.Schemata212.ReplaceStringConstant_0(14L, "format")
          };

        private readonly string? reportFileName;
        private readonly ReportFormat? reportFormat;
        private readonly bool compareReport;

        static Auditor()
        {
            ReportFormatOption.FromAmong(MutateCSharp.Schemata212.ReplaceStringConstant_0(15L, "html"),
        MutateCSharp.Schemata212.ReplaceStringConstant_0(16L, "md"), MutateCSharp.Schemata212.ReplaceStringConstant_0(17L, "markdown"), MutateCSharp.Schemata212.ReplaceStringConstant_0(18L, "md-table"), MutateCSharp.Schemata212.ReplaceStringConstant_0(19L, "markdown-table"),
        MutateCSharp.Schemata212.ReplaceStringConstant_0(20L, "md-ietf"), MutateCSharp.Schemata212.ReplaceStringConstant_0(21L, "markdown-ietf"),
        MutateCSharp.Schemata212.ReplaceStringConstant_0(22L, "txt"));

            DooFile.RegisterNoChecksNeeded(ReportFileOption, MutateCSharp.Schemata212.ReplaceBooleanConstant_2(23L, false));
            DooFile.RegisterNoChecksNeeded(ReportFormatOption, MutateCSharp.Schemata212.ReplaceBooleanConstant_2(24L, false));
            DooFile.RegisterNoChecksNeeded(CompareReportOption, MutateCSharp.Schemata212.ReplaceBooleanConstant_2(25L, false));
        }

        /// <summary>
        /// Construct an auditor to write to or compare to the given file in the
        /// given format.
        /// </summary>
        /// <param name="reporter">
        /// the reporter to use to emit errors and warnings
        /// </param>
        public Auditor(ErrorReporter reporter) : base(reporter)
        {
            reportFileName = reporter.Options.Get(ReportFileOption);
            compareReport = reporter.Options.Get(CompareReportOption);
            var format = reporter.Options.Get(ReportFormatOption);
            if (format is null)
            {
                if (reportFileName is null)
                {
                    return;
                }

                if (reportFileName.EndsWith(MutateCSharp.Schemata212.ReplaceStringConstant_0(26L, ".html")))
                {
                    reportFormat = ReportFormat.HTML;
                }
                else if (reportFileName.EndsWith(MutateCSharp.Schemata212.ReplaceStringConstant_0(27L, ".md")))
                {
                    reportFormat = ReportFormat.MarkdownTable;
                }
                else if (reportFileName.EndsWith(MutateCSharp.Schemata212.ReplaceStringConstant_0(28L, ".txt")))
                {
                    reportFormat = ReportFormat.Text;
                }
                else
                {
                    Reporter.Error(MessageSource.Verifier, Token.NoToken,
                      $"Unsupported extension on report filename: {reportFileName}, using plain text. " +
            MutateCSharp.Schemata212.ReplaceStringConstant_0(29L, "Supported extensions are: .html, .md, .txt"));
                }
            }
            else
            {
                reportFormat = format;
            }
        }

        private static Regex TableRegex = new Regex(MutateCSharp.Schemata212.ReplaceStringConstant_0(30L, @"\{\{TABLE\}\}\r?\n"));

        private string GenerateHtmlReport(AuditReport report)
        {
            var table = report.RenderHTMLTable();
            var assembly = System.Reflection.Assembly.GetCallingAssembly();
            var templateStream = assembly.GetManifestResourceStream(MutateCSharp.Schemata212.ReplaceStringConstant_0(31L, "audit_template.html"));
            if (templateStream is null)
            {
                Reporter.Warning(MessageSource.Verifier, ErrorRegistry.NoneId, Token.NoToken, MutateCSharp.Schemata212.ReplaceStringConstant_0(32L, "Embedded HTML template not found. Returning raw HTML."));
                return table;
            }
            var templateText = new StreamReader(templateStream).ReadToEnd();
            return TableRegex.Replace(templateText, table);
        }

        internal override void PostResolve(Program program)
        {
            var report = AuditReport.BuildReport(program);

            if (MutateCSharp.Schemata212.ReplaceBinExprOp_3(33L, () => reportFileName is null, () => reportFormat is null))
            {
                foreach (var (_, assumptions) in report.AllAssumptions())
                {
                    foreach (var assumption in assumptions)
                    {
                        Reporter.Warning(MessageSource.Verifier, ErrorRegistry.NoneId, assumption.tok, assumption.Warning());
                    }
                }
            }
            else
            {
                var text = reportFormat switch
                {
                    ReportFormat.HTML => GenerateHtmlReport(report),
                    ReportFormat.MarkdownTable => report.RenderMarkdownTable(),
                    ReportFormat.MarkdownIETF => report.RenderMarkdownIETF(),
                    ReportFormat.Text => report.RenderText(),
                    _ => $"Internal error: unknown format {reportFormat}"
                };
                if (reportFileName is null)
                {
                    Options.OutputWriter.Write(text);
                }
                else
                {
                    if (compareReport)
                    {
                        try
                        {
                            var matches = File.ReadAllText(reportFileName).Equals(text);
                            if (!matches)
                            {
                                Reporter.Error(MessageSource.Verifier, Token.NoToken,
                                  $"Given report file ({reportFileName}) does not match text generated (and saved in {reportFileName}.expect).");
                                File.WriteAllText(reportFileName + MutateCSharp.Schemata212.ReplaceStringConstant_0(39L, ".expect"), text);
                            }
                        }
                        catch (IOException ioe)
                        {
                            Reporter.Error(MessageSource.Verifier, Token.NoToken, $"I/O exception trying to read {reportFileName} ({ioe.Message}).");
                        }
                    }
                    else
                    {
                        File.WriteAllText(reportFileName, text);
                    }
                }
            }

            var findingCount = report.AllAssumptions().SelectMany(d => d.Value).Count();
            Options.OutputWriter.WriteLine($"Dafny auditor completed with {findingCount} findings");
        }
    }
}
