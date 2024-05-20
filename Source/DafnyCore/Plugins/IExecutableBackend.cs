// SPDX-License-Identifier: MIT
#nullable enable

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DafnyCore;
using DafnyCore.Options;
using Microsoft.Dafny.Compilers;
namespace MutateCSharp
{
    internal class Schemata359
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT359");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceNumericConstant_0(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny.Plugins
{

    /// <summary>
    /// A class that plugins should extend in order to provide an extra Compiler to the pipeline.
    ///
    /// If the plugin defines no PluginConfiguration, then Dafny will instantiate every sub-class
    /// of IExecutableBackend from the plugin.
    /// </summary>
    public abstract class IExecutableBackend
    {
        protected DafnyOptions Options { get; }

        /// <summary>
        /// Supported file extensions for additional compilation units (e.g. <c>.cs</c> for C#).
        /// </summary>
        public abstract IReadOnlySet<string> SupportedExtensions { get; }

        /// <summary>
        /// Human-readable string describing the target of this compiler.
        /// </summary>
        public abstract string TargetName { get; }

        /// <summary>
        /// Is this a stable, supported backend (should it be run in integration tests).
        /// </summary>
        public abstract bool IsStable { get; }

        /// <summary>
        /// Extension given to generated code files (e.g. <c>cs</c> for C#)
        /// </summary>
        public abstract string TargetExtension { get; }

        /// <summary>
        /// Value passed to the <c>/compileTarget:</c> command line flag to select this compiler (e.g. <c>cs</c> for C#)
        /// </summary>
        public virtual string TargetId => TargetExtension;
        /// <summary>
        /// Spaces added by a single indentation level.
        /// </summary>
        public virtual int TargetIndentSize => MutateCSharp.Schemata359.ReplaceNumericConstant_0(1L, 2);

        /// <summary>
        /// Convert a Dafny file name into a file name without extension suitable for the target language (needed in e.g.
        /// in Java where the file name must match the class name).
        /// </summary>
        public virtual string TargetBasename(string dafnyProgramName) =>
          Path.GetFileNameWithoutExtension(dafnyProgramName);
        /// <summary>
        /// Compute where to store code files generated from a given Dafny file.  For most languages there is no need to
        /// create a separate directory for compilation, so this can be <c>""</c>.
        /// </summary>
        /// <returns>A directory name.</returns>
        public virtual string TargetBaseDir(string dafnyProgramName) =>
          "";

        /// <summary>
        /// Change <c>name</c> into a valid identifier in the target language.
        /// </summary>
        public abstract string PublicIdProtect(string name);

        /// <summary>
        /// Qualify the name <c>compileName</c> in module <c>moduleName</c>.
        /// </summary>
        public virtual string GetCompileName(bool isDefaultModule, string moduleName, string compileName) =>
          $"{PublicIdProtect(moduleName)}.{PublicIdProtect(compileName)}";

        /// <summary>
        /// Which native formats this compiler supports (members of <c>Dafny.NativeType.Selection</c>).
        /// </summary>
        public virtual IReadOnlySet<string> SupportedNativeTypes =>
          new HashSet<string> { MutateCSharp.Schemata359.ReplaceStringConstant_1(5L, "byte"), MutateCSharp.Schemata359.ReplaceStringConstant_1(6L, "sbyte"), MutateCSharp.Schemata359.ReplaceStringConstant_1(7L, "ushort"), MutateCSharp.Schemata359.ReplaceStringConstant_1(8L, "short"), MutateCSharp.Schemata359.ReplaceStringConstant_1(9L, "uint"), MutateCSharp.Schemata359.ReplaceStringConstant_1(10L, "int"), MutateCSharp.Schemata359.ReplaceStringConstant_1(11L, "ulong"), MutateCSharp.Schemata359.ReplaceStringConstant_1(12L, "long") };

        /// <summary>
        /// Whether compiled code can be run without being compiled (e.g. Python but not Java).
        /// </summary>
        public abstract bool TextualTargetIsExecutable { get; }

        /// <summary>
        /// Whether generated code can be compiled without being written to disk.
        /// </summary>
        public abstract bool SupportsInMemoryCompilation { get; }

        /// <summary>
        /// Whether or not the compiler turns
        ///     datatype Record = R(oneThing: X)
        /// into just X, including the case where "Record" is a tuple type with 1 non-ghost component.
        /// </summary>
        public virtual bool SupportsDatatypeWrapperErasure => MutateCSharp.Schemata359.ReplaceBooleanConstant_2(13L, true);

        /// <summary>
        /// Dafny features this compiler is known to not support.
        /// </summary>
        public virtual IReadOnlySet<Feature> UnsupportedFeatures => new HashSet<Feature>();

        /// <summary>
        /// Marks backends that should not be documented in the reference manual.
        /// </summary>
        public virtual bool IsInternal => MutateCSharp.Schemata359.ReplaceBooleanConstant_2(14L, false);

        public abstract string ModuleSeparator { get; }

        // The following two fields are not initialized until OnPreCompile
        protected ErrorReporter? Reporter;
        protected ReadOnlyCollection<string>? OtherFileNames;

        // The following lists are the Options supported by the backend.
        public virtual IEnumerable<Option<string>> SupportedOptions => new List<Option<string>>();

        protected IExecutableBackend(DafnyOptions options)
        {
            Options = options;
        }

        /// <summary>
        /// Initialize <c>Reporter</c> and <c>OtherFileNames</c>.
        ///
        /// This method exists because compilers are constructed very early in the pipeline (to consult their
        /// <c>SupportedExtensions</c>, <c>TargetLanguage</c>, etc.).  C# doesn't support static fields in abstract classes,
        /// so we have to create an instance to access these parameters.  The alternative is to have a factory class, but we
        /// deemed the added complexity unnecessary.
        /// </summary>
        public virtual void OnPreCompile(ErrorReporter reporter, ReadOnlyCollection<string> otherFileNames)
        {
            Reporter = reporter;
            OtherFileNames = otherFileNames;
        }

        /// <summary>
        /// Perform any required processing after generating code with <c>Compile</c> and <c>EmitCallToMain</c>.
        /// </summary>
        public abstract Task<bool> OnPostGenerate(string dafnyProgramName, string targetDirectory, TextWriter outputWriter);

        /// <summary>
        /// Remove previously generated source files.  This is only applicable to compilers that put sources in a separate
        /// directory (e.g. Java).  For other compilers, this method should do nothing.
        /// </summary>
        /// <param name="sourceDirectory">Name of the directory to delete.</param>
        public virtual void CleanSourceDirectory(string sourceDirectory) { }

        public abstract void Compile(Program dafnyProgram, string dafnyProgramName, ConcreteSyntaxTree output);

        /// <summary>
        /// Emits a call to <c>mainMethod</c> as the program's entry point, if such an explicit call is
        /// required in the target language.
        /// </summary>
        public abstract void EmitCallToMain(Method mainMethod, string baseName, ConcreteSyntaxTree callToMainTree);

        /// <summary>
        /// Compile the target program known as <c>dafnyProgramName</c>.
        /// <c>targetProgramText</c> contains the program text.
        /// If <c>targetFilename</c> is non-null, it is the name of the target program text stored as a
        /// file. <c>targetFileName</c> must be non-null if <c>otherFileNames</c> is nonempty.
        /// <c>otherFileNames</c> is a list of other files to include in the compilation.
        ///
        /// When <c>callToMain</c> is non-null, the program contains a <c>Main()</c> program.
        ///
        /// Upon successful compilation, <c>runAfterCompile</c> says whether or not to execute the program.
        ///
        /// Output any errors to <c>outputWriter</c>.
        /// Returns <c>false</c> if there were errors. Then, <c>compilationResult</c> should not be used.
        /// Returns <c>true</c> on success. Then, <c>compilationResult</c> is a value that can be passed in to
        /// the instance's <c>RunTargetProgram</c> method.
        /// </summary>
        public abstract Task<(bool Success, object CompilationResult)> CompileTargetProgram(string dafnyProgramName,
          string targetProgramText, string callToMain,
          string targetFilename,
          ReadOnlyCollection<string> otherFileNames, bool runAfterCompile, TextWriter outputWriter);

        /// <summary>
        /// Runs a target program after it has been successfully compiled.
        /// dafnyProgram, targetProgramText, targetFilename, and otherFileNames are the same as the corresponding parameters to <c>CompileTargetProgram</c>.
        /// <c>callToMain</c> is an explicit call to Main, as required by the target compilation language.
        /// <c>compilationResult</c> is a value returned by <c>CompileTargetProgram</c> for these parameters.
        ///
        /// Returns <c>true</c> on success, <c>false</c> on error. Any errors are output to <c>outputWriter</c>.
        /// </summary>
        public abstract Task<bool> RunTargetProgram(string dafnyProgramName, string targetProgramText, string callToMain,
          string pathsFilename,
          ReadOnlyCollection<string> otherFileNames, object compilationResult, TextWriter outputWriter,
          TextWriter errorWriter);

        /// <summary>
        /// Instruments the underlying SinglePassCompiler, if it exists.
        /// </summary>
        public abstract void InstrumentCompiler(CompilerInstrumenter instrumenter, Program dafnyProgram);

        public static readonly Option<string> OuterModule =
          new(MutateCSharp.Schemata359.ReplaceStringConstant_1(15L, "--outer-module"), MutateCSharp.Schemata359.ReplaceStringConstant_1(16L, "Nest all code in this module. Can be used to customize generated code. Use dots as separators (foo.baz.zoo) for deeper nesting. The first specified module will be the outermost one."));

        public static readonly Option<IList<FileInfo>> TranslationRecords = new(MutateCSharp.Schemata359.ReplaceStringConstant_1(17L, "--translation-record"),
      MutateCSharp.Schemata359.ReplaceStringConstant_1(18L, @"
A translation record file for previously translated Dafny code. Can be specified multiple times. See https://dafny.org/dafny/DafnyRef/DafnyRef#sec-dtr-files for details.").TrimStart())
        {
        };

        public static readonly Option<FileInfo> TranslationRecordOutput = new(MutateCSharp.Schemata359.ReplaceStringConstant_1(19L, "--translation-record-output"),
      MutateCSharp.Schemata359.ReplaceStringConstant_1(20L, @"
Where to output the translation record file. Defaults to the output directory. See https://dafny.org/dafny/DafnyRef/DafnyRef#sec-dtr-files for details.").TrimStart())
        {
        };

        static IExecutableBackend()
        {
            DooFile.RegisterNoChecksNeeded(OuterModule, MutateCSharp.Schemata359.ReplaceBooleanConstant_2(21L, false));
            DooFile.RegisterNoChecksNeeded(TranslationRecords, MutateCSharp.Schemata359.ReplaceBooleanConstant_2(22L, false));
            DooFile.RegisterNoChecksNeeded(TranslationRecordOutput, MutateCSharp.Schemata359.ReplaceBooleanConstant_2(23L, false));
            TranslationRecord.RegisterLibraryChecks(
              new Dictionary<Option, OptionCompatibility.OptionCheck> {
        { OuterModule, OptionCompatibility.NoOpOptionCheck },
              }
            );
        }

        public virtual Command GetCommand()
        {
            var cmd = new Command(TargetId, $"Translate Dafny sources to {TargetName} source and build files.");
            foreach (var supportedOption in SupportedOptions)
            {
                cmd.AddOption(supportedOption);
            }
            return cmd;
        }

        public virtual void PopulateCoverageReport(CoverageReport coverageReport)
        {
            throw new NotImplementedException();
        }
    }
}
