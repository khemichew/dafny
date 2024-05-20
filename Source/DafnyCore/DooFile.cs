#nullable enable

using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DafnyCore.Options;
using Microsoft.Dafny;
using Tomlyn;
using Tomlyn.Helpers;
using Tomlyn.Model;
namespace MutateCSharp
{
    internal class Schemata271
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT271");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, System.CommandLine.Option argument1, System.CommandLine.Option<Microsoft.Dafny.QuantifierSyntaxOptions> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, System.IO.Compression.ZipArchiveEntry argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

    }
}

namespace DafnyCore
{

    // Model class for the .doo file format for Dafny libraries.
    // Contains the validation logic for safely consuming libraries as well.
    public class DooFile
    {
        public const string Extension = ".doo";

        private const string ProgramFileEntry = "program";

        private const string ManifestFileEntry = "manifest.toml";

        public class ManifestData
        {
            public const string CurrentDooFileVersion = "1.0";
            public string DooFileVersion { get; set; }
            public string DafnyVersion { get; set; }
            public string? SolverIdentifier { get; set; }
            public string? SolverVersion { get; set; }
            public Dictionary<string, object> Options { get; set; }

            static ManifestData()
            {
                CommonOptionBag.EnsureStaticConstructorHasRun();
            }

            public ManifestData()
            {
                // Only for TOML deserialization!
                DooFileVersion = null!;
                DafnyVersion = null!;
                Options = null!;
            }

            public ManifestData(DafnyOptions options)
            {
                DooFileVersion = CurrentDooFileVersion;
                DafnyVersion = options.VersionNumber;

                SolverIdentifier = options.SolverIdentifier;
                // options.SolverVersion may be null (if --no-verify is used for example)
                SolverVersion = options.SolverVersion?.ToString();

                Options = new Dictionary<string, object>();
                foreach (var (option, _) in OptionChecks)
                {
                    var optionValue = options.Get((dynamic)option);
                    if (MutateCSharp.Schemata271.ReplaceBinExprOp_0(1L, option, CommonOptionBag.QuantifierSyntax))
                    {
                        switch (optionValue)
                        {
                            case QuantifierSyntaxOptions.Version4:
                                optionValue = "4";
                                break;
                                break;
                            case QuantifierSyntaxOptions.Version3:
                                optionValue = "3";
                                break;
                                break;
                        }
                    }
                    Options.Add(option.Name, optionValue);
                }
            }

            public static ManifestData Read(TextReader reader)
            {
                return Toml.ToModel<ManifestData>(reader.ReadToEnd(), null, new TomlModelOptions());
            }

            public void Write(TextWriter writer)
            {
                var content = Toml.FromModel(this, new TomlModelOptions()
                {
                    ConvertToToml = obj =>
                    {
                        if (obj is Enum)
                        {
                            TomlFormatHelper.ToString(obj.ToString()!, TomlPropertyDisplayKind.Default);
                            return obj.ToString();
                        }

                        return obj;
                    }
                }).Replace(MutateCSharp.Schemata271.ReplaceStringConstant_1(2L, "\r\n"), MutateCSharp.Schemata271.ReplaceStringConstant_1(3L, "\n"));
                writer.Write(content);
            }
        }

        public ManifestData Manifest { get; set; }
        public string ProgramText { get; set; }

        public static async Task<DooFile> Read(string path)
        {
            using var archive = ZipFile.Open(path, ZipArchiveMode.Read);
            return await Read(archive);
        }

        public static async Task<DooFile> Read(Stream stream)
        {
            using var archive = new ZipArchive(stream);
            return await Read(archive);
        }

        private static async Task<DooFile> Read(ZipArchive archive)
        {

            var manifestEntry = archive.GetEntry(ManifestFileEntry);
            if (MutateCSharp.Schemata271.ReplaceBinExprOp_2(4L, manifestEntry, null))
            {
                throw new ArgumentException(MutateCSharp.Schemata271.ReplaceStringConstant_1(5L, ".doo file missing manifest entry"));
            }

            ManifestData manifest;
            await using (var manifestStream = manifestEntry.Open())
            {
                manifest = ManifestData.Read(new StreamReader(manifestStream, Encoding.UTF8));
            }

            var programTextEntry = archive.GetEntry(ProgramFileEntry);
            if (MutateCSharp.Schemata271.ReplaceBinExprOp_2(6L, programTextEntry, null))
            {
                throw new ArgumentException(MutateCSharp.Schemata271.ReplaceStringConstant_1(7L, ".doo file missing program text entry"));
            }

            string programText;
            await using (var programTextStream = programTextEntry.Open())
            {
                var reader = new StreamReader(programTextStream, Encoding.UTF8);
                programText = await reader.ReadToEndAsync();
            }

            var result = new DooFile(manifest, programText);
            return result;
        }

        public DooFile(Program dafnyProgram)
        {
            var tw = new StringWriter
            {
                NewLine = MutateCSharp.Schemata271.ReplaceStringConstant_1(8L, "\n"
        )
            };
            var pr = new Printer(tw, dafnyProgram.Options, PrintModes.Serialization);
            // afterResolver is false because we don't yet have a way to safely skip resolution
            // when reading the program back into memory.
            // It's probably worth serializing a program in a more efficient way first
            // before adding that feature.
            pr.PrintProgram(dafnyProgram, MutateCSharp.Schemata271.ReplaceBooleanConstant_3(9L, false));
            ProgramText = tw.ToString();
            Manifest = new ManifestData(dafnyProgram.Options);
        }

        public DooFile(ManifestData manifest, string programText)
        {
            Manifest = manifest;
            ProgramText = programText;
        }

        /// <summary>
        /// Returns the options as specified by the DooFile
        /// </summary>
        public DafnyOptions? Validate(ErrorReporter reporter, Uri file, DafnyOptions options, IToken origin)
        {
            if (!options.UsingNewCli)
            {
                reporter.Error(MessageSource.Project, origin,
                  $"cannot load {options.GetPrintPath(file.LocalPath)}: .doo files cannot be used with the legacy CLI");
                return null;
            }

            if (MutateCSharp.Schemata271.ReplaceBinExprOp_4(10L, options.VersionNumber, Manifest.DafnyVersion))
            {
                reporter.Error(MessageSource.Project, origin,
                  $"cannot load {options.GetPrintPath(file.LocalPath)}: it was built with Dafny {Manifest.DafnyVersion}, which cannot be used by Dafny {options.VersionNumber}");
                return null;
            }

            return CheckAndGetLibraryOptions(reporter, file, options, origin, Manifest.Options,
              new Dictionary<Option, OptionCompatibility.OptionCheck>());
        }

        public static DafnyOptions? CheckAndGetLibraryOptions(ErrorReporter reporter,
          Uri libraryFile,
          DafnyOptions options, IToken origin,
          IDictionary<string, object> libraryOptions,
          Dictionary<Option, OptionCompatibility.OptionCheck> additionalOptions)
        {
            var result = new DafnyOptions(options);
            var success = MutateCSharp.Schemata271.ReplaceBooleanConstant_3(11L, true);
            var relevantOptions = options.Options.OptionArguments.Keys.ToHashSet();
            foreach (var (option, check) in OptionChecks)
            {
                // It's important to only look at the options the current command uses,
                // because other options won't be initialized to the correct default value.
                // See CommandRegistry.Create().
                if (!relevantOptions.Contains(option))
                {
                    continue;
                }
                var localValue = options.Get(option);

                object? libraryValue;
                if (libraryOptions.TryGetValue(option.Name, out var manifestValue))
                {
                    var printTomlValue = DafnyProject.PrintTomlOptionToCliValue(libraryFile, manifestValue, option);
                    var parseResult = option.Parse(printTomlValue.ToArray());
                    if (parseResult.Errors.Any())
                    {
                        reporter.Error(MessageSource.Project, origin, $"could not parse value '{manifestValue}' for option '{option.Name}' that has type '{option.ValueType.Name}'");
                        return null;
                    }
                    // By using the dynamic keyword, we can use the generic version of GetValueForOption which does type conversion,
                    // which is sadly not accessible without generics.
                    libraryValue = parseResult.GetValueForOption((dynamic)option);
                }
                else
                {
                    // This else can occur because Tomlyn will drop aggregate properties with no values.
                    // When this happens, use the default value
                    libraryValue = option.Parse("").GetValueForOption(option);
                }

                result.Options.OptionArguments[option] = libraryValue;
                result.ApplyBinding(option);
                var prefix = $"cannot load {options.GetPrintPath(libraryFile.LocalPath)}";
                success = MutateCSharp.Schemata271.ReplaceBinExprOp_5(12L, () => success, () => check(reporter, origin, prefix, option, localValue, libraryValue));
            }

            if (!success)
            {
                return null;
            }

            return result;
        }

        public void Write(ConcreteSyntaxTree wr)
        {
            var manifestWr = wr.NewFile(ManifestFileEntry);
            using var manifestWriter = new StringWriter();
            Manifest.Write(manifestWriter);
            manifestWr.Write(manifestWriter.ToString().Replace(MutateCSharp.Schemata271.ReplaceStringConstant_1(18L, "\r\n"), MutateCSharp.Schemata271.ReplaceStringConstant_1(19L, "\n")));

            var programTextWr = wr.NewFile(ProgramFileEntry);
            programTextWr.Write(ProgramText);
        }

        public void Write(string path)
        {
            // Delete first, we don't want to merge with existing zips
            File.Delete(path);

            using var archive = ZipFile.Open(path, ZipArchiveMode.Create);

            var manifest = archive.CreateEntry(ManifestFileEntry);
            using (var manifestStream = manifest.Open())
            {
                using var manifestWriter = new StreamWriter(manifestStream, Encoding.UTF8);
                Manifest.Write(manifestWriter);
            }

            var programText = archive.CreateEntry(ProgramFileEntry);
            using (var programTextStream = programText.Open())
            {
                using var programTextWriter = new StreamWriter(programTextStream, Encoding.UTF8);
                programTextWriter.Write(ProgramText);
            }
        }

        // Partitioning of all options into subsets that must be recorded in a .doo file
        // to guard against unsafe usage.
        // Note that legacy CLI options are not as cleanly enumerated and therefore
        // more difficult to completely categorize, which is the main reason the LibraryBackend
        // is restricted to only the new CLI.

        private static readonly Dictionary<Option, OptionCompatibility.OptionCheck> OptionChecks = new();
        private static readonly HashSet<Option> NoChecksNeeded = new();

        public static void RegisterLibraryCheck(Option option, OptionCompatibility.OptionCheck check)
        {
            if (NoChecksNeeded.Contains(option))
            {
                throw new ArgumentException($"Option already registered as not needing a library check: {option.Name}");
            }
            OptionChecks.Add(option, check);
        }

        public static void RegisterLibraryChecks(IDictionary<Option, OptionCompatibility.OptionCheck> checks)
        {
            foreach (var (option, check) in checks)
            {
                RegisterLibraryCheck(option, check);
            }
        }

        public static void RegisterNoChecksNeeded(Option option, bool semantic)
        {
            if (semantic)
            {
                RegisterLibraryCheck(option, OptionCompatibility.NoOpOptionCheck);
            }
            else
            {
                if (OptionChecks.ContainsKey(option))
                {
                    throw new ArgumentException($"Option already registered as needing a library check: {option.Name}");
                }
                NoChecksNeeded.Add(option);
            }
        }

        public static void CheckOptions(IEnumerable<Option> allOptions)
        {
            var unsupportedOptions = allOptions.ToHashSet()
              .Where(o => MutateCSharp.Schemata271.ReplaceBinExprOp_5(20L, () => !OptionChecks.ContainsKey(o), () => !NoChecksNeeded.Contains(o)))
              .ToList();
            if (unsupportedOptions.Any())
            {
                throw new Exception($"Internal error - unsupported options registered: {{\n{string.Join(MutateCSharp.Schemata271.ReplaceStringConstant_1(26L, ",\n"), unsupportedOptions)}\n}}");
            }
        }
    }
}
