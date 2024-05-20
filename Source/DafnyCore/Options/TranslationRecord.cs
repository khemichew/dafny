using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using DafnyCore.Generic;
using Microsoft.Dafny;
using Tomlyn;
namespace MutateCSharp
{
    internal class Schemata331
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT331");
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

        internal static int ReplaceNumericConstant_5(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
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

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace DafnyCore.Options
{

    // Model class for the .dtr file format for Dafny Translation Records.
    // Contains the validation logic for safely consuming pre-translated libraries as well.
    // See https://dafny.org/dafny/DafnyRef/DafnyRef#sec-dtr-files.
    public class TranslationRecord
    {

        public const string CurrentFileFormatVersion = "1.0";
        public string FileFormatVersion { get; set; }
        public string DafnyVersion { get; set; }
        public Dictionary<string, Dictionary<string, object>> OptionsByModule { get; set; }

        public TranslationRecord(Program program)
        {
            FileFormatVersion = CurrentFileFormatVersion;
            DafnyVersion = program.Options.VersionNumber;

            OptionsByModule = new();

            foreach (var module in program.RawModules())
            {
                if (MutateCSharp.Schemata331.ReplaceBinExprOp_0(1L, () => module is DefaultModuleDefinition, () => !module.ShouldCompile(program.Compilation)))
                {
                    continue;
                }

                Dictionary<string, object> recordedOptions = new();
                OptionsByModule[module.FullDafnyName] = recordedOptions;

                foreach (var (option, _) in OptionChecks)
                {
                    var optionValue = program.Options.Get((dynamic)option);
                    recordedOptions.Add(option.Name, optionValue);
                }
            }
        }

        public static TranslationRecord Empty(Program program)
        {
            return new TranslationRecord()
            {
                FileFormatVersion = CurrentFileFormatVersion,
                DafnyVersion = program.Options.VersionNumber,
                OptionsByModule = new()
            };
        }

        public TranslationRecord()
        {
            // Only for TOML deserialization!
        }

        public static void ReadValidateAndMerge(Program program, string filePath, IToken origin)
        {
            var pathForErrors = program.Options.GetPrintPath(filePath);
            try
            {
                using TextReader reader = new StreamReader(filePath);
                var record = Read(reader);
                if (record.Validate(program, pathForErrors, origin))
                {
                    program.Compilation.AlreadyTranslatedRecord.Merge(program.Reporter, record, pathForErrors, origin);
                }
            }
            catch (FileNotFoundException)
            {
                program.Reporter.Error(MessageSource.Project, origin, $"file {pathForErrors} not found");
            }
            catch (TomlException)
            {
                program.Reporter.Error(MessageSource.Project, origin, $"malformed dtr file {pathForErrors}");
            }
        }

        private static TranslationRecord Read(TextReader reader)
        {
            return Toml.ToModel<TranslationRecord>(reader.ReadToEnd(), null, new TomlModelOptions());
        }

        public void Write(TextWriter writer)
        {
            writer.Write(Toml.FromModel(this, new TomlModelOptions()).Replace(MutateCSharp.Schemata331.ReplaceStringConstant_1(7L, "\r\n"), MutateCSharp.Schemata331.ReplaceStringConstant_1(8L, "\n")));
        }

        public void Write(ConcreteSyntaxTree writer)
        {
            using var textWriter = new StringWriter();
            Write(textWriter);
            writer.Write(textWriter.ToString());
        }

        private bool Validate(Program dafnyProgram, string filePath, IToken origin)
        {
            var messagePrefix = $"cannot load {filePath}";
            if (!dafnyProgram.Options.UsingNewCli)
            {
                dafnyProgram.Reporter.Error(MessageSource.Project, origin,
                  $"{messagePrefix}: .dtr files cannot be used with the legacy CLI");
                return MutateCSharp.Schemata331.ReplaceBooleanConstant_2(9L, false);
            }

            if (MutateCSharp.Schemata331.ReplaceBinExprOp_3(10L, dafnyProgram.Options.VersionNumber, DafnyVersion))
            {
                dafnyProgram.Reporter.Error(MessageSource.Project, origin,
                  $"{messagePrefix}: it was built with Dafny {DafnyVersion}, which cannot be used by Dafny {dafnyProgram.Options.VersionNumber}");
                return MutateCSharp.Schemata331.ReplaceBooleanConstant_2(11L, false);
            }

            // Modules should be either previously compiled or to be compiled now, not both
            foreach (var module in dafnyProgram.CompileModules)
            {
                if (MutateCSharp.Schemata331.ReplaceBinExprOp_4(12L, () => module.ShouldCompile(dafnyProgram.Compilation), () => OptionsByModule.ContainsKey(module.FullDafnyName)))
                {
                    dafnyProgram.Reporter.Error(MessageSource.Project, origin,
                      $"{messagePrefix}: it contains translation metadata for the module {module.FullDafnyName}, which is in scope for translation in the current program");
                }
            }

            var success = MutateCSharp.Schemata331.ReplaceBooleanConstant_2(18L, true);
            // Yo dawg, we heard you liked options so we put Options in your Options... :)
            var relevantOptions = dafnyProgram.Options.Options.OptionArguments.Keys.ToHashSet();
            foreach (var (option, check) in OptionChecks)
            {
                // It's important to only look at the options the current command uses,
                // because other options won't be initialized to the correct default value.
                // See CommandRegistry.Create().
                if (!relevantOptions.Contains(option))
                {
                    continue;
                }

                var localValue = dafnyProgram.Options.Get(option);

                foreach (var moduleName in OptionsByModule.Keys)
                {
                    var libraryValue = Get(dafnyProgram.Reporter, moduleName, option);
                    success = MutateCSharp.Schemata331.ReplaceBinExprOp_4(19L, () => success, () => check(dafnyProgram.Reporter, origin, messagePrefix, option, localValue, libraryValue));
                }
            }

            return success;
        }

        public object Get(ErrorReporter reporter, string moduleName, Option option)
        {
            if (OptionsByModule.TryGetValue(moduleName, out var moduleOptions))
            {
                if (moduleOptions.TryGetValue(option.Name, out var manifestValue))
                {
                    if (TomlUtil.TryGetValueFromToml(reporter, Token.NoToken, null,
                          option.Name, option.ValueType, manifestValue, out var libraryValue))
                    {
                        return libraryValue;
                    }
                }
            }

            return null;
        }

        private void Merge(ErrorReporter reporter, TranslationRecord other, string filePath, IToken origin)
        {
            // Assume both this and other have been Validate()-d already.

            var duplicateModules = OptionsByModule
              .Union(other.OptionsByModule)
              .GroupBy(p => p.Key)
              .Where(g => MutateCSharp.Schemata331.ReplaceBinExprOp_6(29L, g.Count(), MutateCSharp.Schemata331.ReplaceNumericConstant_5(25L, 1)))
              .Select(g => g.Key)
              .ToList();
            if (duplicateModules.Any())
            {
                var messagePrefix = $"cannot load {filePath}";
                foreach (var duplicateModule in duplicateModules)
                {
                    reporter.Error(MessageSource.Project, origin,
                      $"{messagePrefix}: module {duplicateModule} already appears in another translation record");
                }
                return;
            }

            OptionsByModule = OptionsByModule.Union(other.OptionsByModule).ToDictionary(p => p.Key, p => p.Value);
        }

        private static readonly Dictionary<Option, OptionCompatibility.OptionCheck> OptionChecks = new();

        public static void RegisterLibraryChecks(IDictionary<Option, OptionCompatibility.OptionCheck> checks)
        {
            foreach (var (option, check) in checks)
            {
                OptionChecks.Add(option, check);
            }
        }
    }
}