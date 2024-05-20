using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Dafny.Compilers;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using static Microsoft.Dafny.ParseErrors;
namespace MutateCSharp
{
    internal class Schemata93
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT93");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceNumericConstant_6(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
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

        internal static bool ReplaceBooleanConstant_4(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.DafnyFile argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_10(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.PrefixNameModule> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.DafnyOptions.IncludesModes argument1, Microsoft.Dafny.DafnyOptions.IncludesModes argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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
    public record DfyParseResult(
      BatchErrorReporter ErrorReporter,
      FileModuleDefinition Module,
      IReadOnlyList<Action<SystemModuleManager>> ModifyBuiltins
      );

    public class ProgramParser
    {
        protected readonly ILogger<ProgramParser> logger;
        private readonly IFileSystem fileSystem;

        public ProgramParser() : this(NullLogger<ProgramParser>.Instance, OnDiskFileSystem.Instance)
        {
        }

        public ProgramParser(ILogger<ProgramParser> logger, IFileSystem fileSystem)
        {
            this.logger = logger;
            this.fileSystem = fileSystem;
        }

        public virtual async Task<Program> ParseFiles(string programName, IReadOnlyList<DafnyFile> files,
          ErrorReporter errorReporter,
          CancellationToken cancellationToken)
        {
            var options = errorReporter.Options;
            var builtIns = new SystemModuleManager(options);
            var defaultModule = new DefaultModuleDefinition();

            var rootSourceUris = files.Select(f => f.Uri).ToList();
            var verifiedRoots = files.Where(df => df.ShouldNotVerify).Select(df => df.Uri).ToHashSet();
            var compiledRoots = files.Where(df => df.ShouldNotCompile).Select(df => df.Uri).ToHashSet();
            var compilation = new CompilationData(errorReporter, defaultModule.Includes, rootSourceUris, verifiedRoots,
              compiledRoots);
            var program = new Program(
              programName,
              new LiteralModuleDecl(options, defaultModule, null, Guid.NewGuid()),
              builtIns,
              errorReporter, compilation
            );

            foreach (var dafnyFile in files)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (options.Trace)
                {
                    await options.OutputWriter.WriteLineAsync(MutateCSharp.Schemata93.ReplaceStringConstant_0(1L, "Parsing ") + dafnyFile.FilePath);
                }

                if (MutateCSharp.Schemata93.ReplaceBinExprOp_1(2L, () => options.XmlSink is { IsOpen: true }, () => dafnyFile.Uri.IsFile))
                {
                    options.XmlSink.WriteFileFragment(dafnyFile.Uri.LocalPath);
                }

                var parseResult = ParseFileWithErrorHandling(
                  dafnyFile.FileOptions,
                  dafnyFile.GetContent,
                  dafnyFile.Origin,
                  dafnyFile.Uri,
                  cancellationToken);
                if (parseResult.ErrorReporter.HasErrors)
                {
                    logger.LogDebug($"encountered {parseResult.ErrorReporter.ErrorCount} errors while parsing {dafnyFile.Uri}");
                }

                AddParseResultToProgram(parseResult, program);
            }

            if (!(MutateCSharp.Schemata93.ReplaceBinExprOp_3(9L, () => options.DisallowIncludes, () => MutateCSharp.Schemata93.ReplaceBinExprOp_2(8L, options.PrintIncludesMode, DafnyOptions.IncludesModes.Immediate))))
            {
                var includedModules = TryParseIncludes(files, defaultModule.Includes.ToList(),
                  builtIns, errorReporter, cancellationToken);

                foreach (var module in includedModules)
                {
                    AddParseResultToProgram(module, program);
                }
            }

            if (MutateCSharp.Schemata93.ReplaceBinExprOp_2(15L, options.PrintIncludesMode, DafnyOptions.IncludesModes.Immediate))
            {
                var dependencyMap = new DependencyMap();
                dependencyMap.AddIncludes(defaultModule.Includes);
                dependencyMap.PrintMap(options);
            }

            if (!errorReporter.HasErrors)
            {
                DafnyMain.MaybePrintProgram(program, options.DafnyPrintFile, MutateCSharp.Schemata93.ReplaceBooleanConstant_4(16L, false));

                // Capture the original program text before resolution
                // if we're building a .doo file.
                // See comment on LibraryBackend.DooFile.
                if (program.Options.Backend is LibraryBackend libBackend)
                {
                    program.AfterParsingClone = new Program(new Cloner(MutateCSharp.Schemata93.ReplaceBooleanConstant_4(17L, true)), program);
                }
            }

            ShowWarningsForIncludeCycles(program);

            return program;
        }

        private DfyParseResult ParseFileWithErrorHandling(DafnyOptions options,
          Func<TextReader> getContent,
          IToken origin,
          Uri uri,
          CancellationToken cancellationToken)
        {
            try
            {
                return ParseFile(options, getContent, uri, cancellationToken);
            }
            catch (IOException e)
            {
                if (MutateCSharp.Schemata93.ReplaceBinExprOp_5(18L, origin, null))
                {
                    throw;
                }

                var reporter = new BatchErrorReporter(options);
                reporter.Error(MessageSource.Parser, origin,
                  $"Unable to open the file {uri} because {e.Message}.");
                return new DfyParseResult(reporter, new FileModuleDefinition(Token.NoToken), new Action<SystemModuleManager>[] { });
            }
            catch (OperationCanceledException)
            {
                throw;
            }
            catch (Exception e)
            {
                var internalErrorDummyToken = new Token
                {
                    Uri = uri,
                    line = MutateCSharp.Schemata93.ReplaceNumericConstant_6(19L, 1),
                    col = MutateCSharp.Schemata93.ReplaceNumericConstant_6(23L, 1),
                    pos = MutateCSharp.Schemata93.ReplaceNumericConstant_6(27L, 0),
                    val = string.Empty
                };

                var reporter = new BatchErrorReporter(options);
                reporter.Error(MessageSource.Parser, ErrorId.p_internal_exception, internalErrorDummyToken,
          MutateCSharp.Schemata93.ReplaceStringConstant_0(31L, "[internal error] Parser exception: ") + e.Message + (!options.Verbose ? "" : MutateCSharp.Schemata93.ReplaceStringConstant_0(32L, "\n") + e.StackTrace));
                return new DfyParseResult(reporter, new FileModuleDefinition(Token.NoToken), new Action<SystemModuleManager>[] { });
            }

            return default;
        }

        private void ShowWarningsForIncludeCycles(Program program)
        {
            var graph = new Graph<Uri>();
            foreach (var edgesForUri in program.Compilation.Includes.GroupBy(i => i.IncluderFilename))
            {
                foreach (var edge in edgesForUri)
                {
                    graph.AddEdge(edge.IncluderFilename, edge.IncludedFilename);
                }
            }

            var sortedSccRoots = graph.TopologicallySortedComponents();
            var includeCycles = sortedSccRoots.Select(graph.GetSCC).Where(scc => MutateCSharp.Schemata93.ReplaceBinExprOp_7(37L, scc.Count, MutateCSharp.Schemata93.ReplaceNumericConstant_6(33L, 1)));
            foreach (var cycle in includeCycles)
            {
                program.Reporter.Info(MessageSource.Parser, program.GetStartOfFirstFileToken(),
                  $"Program contains a cycle of includes, consisting of:\n{string.Join(MutateCSharp.Schemata93.ReplaceStringConstant_0(42L, "\n"), cycle.Select(c => c.LocalPath))}");
            }
        }

        private static void AddParseResultToProgram(DfyParseResult parseResult, Program program)
        {
            var defaultModule = program.DefaultModuleDef;
            var fileModule = parseResult.Module;
            program.Files.Add(fileModule);

            foreach (var modify in parseResult.ModifyBuiltins)
            {
                modify(program.SystemModuleManager);
            }

            parseResult.ErrorReporter.CopyDiagnostics(program.Reporter);

            ModuleDefinition sourceModule = fileModule;
            ModuleDefinition targetModule = defaultModule;

            MoveModuleContents(sourceModule, targetModule);

            foreach (var include in fileModule.Includes)
            {
                defaultModule.Includes.Add(include);
            }

            foreach (var prefixNamedModule in fileModule.PrefixNamedModules)
            {
                defaultModule.PrefixNamedModules.Add(prefixNamedModule);
            }

            defaultModule.DefaultClass.SetMembersBeforeResolution();
        }

        public static void MoveModuleContents(ModuleDefinition sourceModule, ModuleDefinition targetModule)
        {
            foreach (var declToMove in sourceModule.DefaultClasses.Concat(sourceModule.SourceDecls))
            {
                declToMove.EnclosingModuleDefinition = targetModule;
                if (declToMove is LiteralModuleDecl literalModuleDecl)
                {
                    literalModuleDecl.ModuleDef.EnclosingModule = targetModule;
                }

                if (declToMove is ClassLikeDecl { NonNullTypeDecl: { } nonNullTypeDecl })
                {
                    nonNullTypeDecl.EnclosingModuleDefinition = targetModule;
                }

                if (declToMove is DefaultClassDecl defaultClassDecl)
                {
                    foreach (var member in defaultClassDecl.Members)
                    {
                        targetModule.DefaultClass.Members.Add(member);
                        member.EnclosingClass = targetModule.DefaultClass;
                    }
                }
                else
                {
                    targetModule.SourceDecls.Add(declToMove);
                }
            }
        }

        public IList<DfyParseResult> TryParseIncludes(
          IReadOnlyList<DafnyFile> files,
          IEnumerable<Include> roots,
          SystemModuleManager systemModuleManager,
          ErrorReporter errorReporter,
          CancellationToken cancellationToken
        )
        {
            var stack = new Stack<DafnyFile>();
            var result = new List<DfyParseResult>();
            var resolvedFiles = new HashSet<Uri>();
            foreach (var rootFile in files)
            {
                resolvedFiles.Add(rootFile.Uri);
            }

            foreach (var root in roots)
            {
                var dafnyFile = IncludeToDafnyFile(errorReporter, root);
                if (MutateCSharp.Schemata93.ReplaceBinExprOp_8(43L, dafnyFile, null))
                {
                    stack.Push(dafnyFile);
                }
            }

            while (stack.Any())
            {
                var top = stack.Pop();
                if (!resolvedFiles.Add(top.Uri))
                {
                    continue;
                }

                cancellationToken.ThrowIfCancellationRequested();
                var parseIncludeResult = ParseFileWithErrorHandling(
                  top.FileOptions,
                  top.GetContent,
                  top.Origin,
                  top.Uri,
                  cancellationToken);
                result.Add(parseIncludeResult);

                foreach (var include in parseIncludeResult.Module.Includes)
                {
                    var dafnyFile = IncludeToDafnyFile(errorReporter, include);
                    if (MutateCSharp.Schemata93.ReplaceBinExprOp_8(44L, dafnyFile, null))
                    {
                        stack.Push(dafnyFile);
                    }
                }
            }

            return result;
        }

        private DafnyFile IncludeToDafnyFile(ErrorReporter errorReporter, Include include)
        {
            return DafnyFile.HandleDafnyFile(fileSystem, errorReporter, include.ParseOptions, include.IncludedFilename, include.tok, MutateCSharp.Schemata93.ReplaceBooleanConstant_4(45L, false));
        }

        ///<summary>
        /// Parses top-level things (modules, classes, datatypes, class members) from "filename"
        /// and appends them in appropriate form to "module".
        /// Returns the number of parsing errors encountered.
        /// Note: first initialize the Scanner.
        ///</summary>
        protected virtual DfyParseResult ParseFile(DafnyOptions options, Func<TextReader> getReader,
          Uri uri, CancellationToken cancellationToken) /* throws System.IO.IOException */
        {
            Contract.Requires(uri != null);
            using var reader = getReader();
            var text = SourcePreprocessor.ProcessDirectives(reader, new List<string>());
            return ParseFile(options, text, uri, cancellationToken);
        }

        ///<summary>
        /// Parses top-level things (modules, classes, datatypes, class members)
        /// and appends them in appropriate form to "module".
        /// Returns the number of parsing errors encountered.
        /// Note: first initialize the Scanner with the given Errors sink.
        ///</summary>
        private static DfyParseResult ParseFile(DafnyOptions options, string /*!*/ content, Uri /*!*/ uri, CancellationToken cancellationToken)
        {
            var batchErrorReporter = new BatchErrorReporter(options);
            Parser parser = SetupParser(content, uri, batchErrorReporter, cancellationToken);
            parser.Parse();

            if (MutateCSharp.Schemata93.ReplaceBinExprOp_1(92L, () => MutateCSharp.Schemata93.ReplaceBinExprOp_1(70L, () => MutateCSharp.Schemata93.ReplaceBinExprOp_1(64L, () => MutateCSharp.Schemata93.ReplaceBinExprOp_9(50L, parser.theModule.DefaultClass.Members.Count, MutateCSharp.Schemata93.ReplaceNumericConstant_6(46L, 0)), () => MutateCSharp.Schemata93.ReplaceBinExprOp_9(59L, parser.theModule.Includes.Count, MutateCSharp.Schemata93.ReplaceNumericConstant_6(55L, 0))), () => !parser.theModule.SourceDecls.Any()
        ), () => (MutateCSharp.Schemata93.ReplaceBinExprOp_3(86L, () => MutateCSharp.Schemata93.ReplaceBinExprOp_10(76L, parser.theModule.PrefixNamedModules, null), () => MutateCSharp.Schemata93.ReplaceBinExprOp_9(81L, parser.theModule.PrefixNamedModules.Count, MutateCSharp.Schemata93.ReplaceNumericConstant_6(77L, 0))))))
            {
                batchErrorReporter.Warning(MessageSource.Parser, ErrorId.p_file_has_no_code, new Token(MutateCSharp.Schemata93.ReplaceNumericConstant_6(98L, 1), MutateCSharp.Schemata93.ReplaceNumericConstant_6(102L, 1)) { Uri = uri }, MutateCSharp.Schemata93.ReplaceStringConstant_0(106L, "File contains no code"));
            }

            return new DfyParseResult(batchErrorReporter, parser.theModule, parser.SystemModuleModifiers);
        }

        private static Parser SetupParser(string s /*!*/, Uri uri /*!*/,
          ErrorReporter errorReporter /*!*/, CancellationToken cancellationToken)
        {
            Contract.Requires(s != null);
            Contract.Requires(uri != null);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(ParseErrors).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(ResolutionErrors).TypeHandle);
            byte[] /*!*/ buffer = cce.NonNull(Encoding.Default.GetBytes(s));
            var ms = new MemoryStream(buffer, MutateCSharp.Schemata93.ReplaceBooleanConstant_4(107L, false));
            var firstToken = new Token
            {
                Uri = uri
            };

            var errors = new Errors(errorReporter);

            var scanner = new Scanner(ms, errors, uri, firstToken: firstToken);
            return new Parser(errorReporter.Options, scanner, errors, cancellationToken);
        }

        public async Task<Program> Parse(string source, Uri uri, ErrorReporter reporter)
        {
            var fs = new InMemoryFileSystem(ImmutableDictionary<Uri, string>.Empty.Add(uri, source));
            var file = DafnyFile.HandleDafnyFile(fs, reporter, reporter.Options, uri, Token.NoToken, MutateCSharp.Schemata93.ReplaceBooleanConstant_4(108L, false));
            var files = new[] { file };
            return await ParseFiles(uri.ToString(), files, reporter, CancellationToken.None);
        }
    }
}
