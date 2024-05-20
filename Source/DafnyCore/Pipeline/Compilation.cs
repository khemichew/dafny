#nullable enable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Subjects;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Boogie;
using Microsoft.Extensions.Logging;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
using VC;
using VCGeneration;
using Range = OmniSharp.Extensions.LanguageServer.Protocol.Models.Range;
namespace MutateCSharp
{
    internal class Schemata333
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT333");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.ResolutionResult argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.ErrorLevel argument1, Microsoft.Dafny.ErrorLevel argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceNumericConstant_9(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.ICanVerify argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_2(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.Program argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.ICanVerify argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, System.IObservable<Microsoft.Boogie.IVerificationStatus> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public delegate Compilation CreateCompilation(
      ExecutionEngine boogieEngine,
      CompilationInput compilation);

    public record FilePosition(Uri Uri, Position Position);
    /// <summary>
    /// The compilation of a single version of a program
    /// After calling Start, the document will be parsed and resolved.
    ///
    /// To verify a symbol, VerifySymbol must be called.
    /// </summary>
    public class Compilation : IDisposable
    {

        private readonly ILogger logger;
        private readonly IFileSystem fileSystem;
        private readonly ITextDocumentLoader documentLoader;
        private readonly IProgramVerifier verifier;

        private readonly TaskCompletionSource started = new();
        private readonly CancellationTokenSource cancellationSource;

        public bool Started => started.Task.IsCompleted;

        private readonly ConcurrentDictionary<Uri, ConcurrentStack<DafnyDiagnostic>> staticDiagnostics = new();

        /// <summary>
        /// FilePosition is required because the default module lives in multiple files
        /// </summary>
        private readonly LazyConcurrentDictionary<ModuleDefinition,
          Task<IReadOnlyDictionary<FilePosition, IReadOnlyList<IVerificationTask>>>> translatedModules = new();

        private readonly ConcurrentDictionary<ICanVerify, Unit> verifyingOrVerifiedSymbols = new();
        private readonly LazyConcurrentDictionary<ICanVerify, IReadOnlyList<IVerificationTask>> tasksPerVerifiable = new();

        public DafnyOptions Options => Input.Options;
        public CompilationInput Input { get; }

        public DafnyProject Project => Input.Project;
        private readonly ExecutionEngine boogieEngine;

        private readonly Subject<ICompilationEvent> updates = new();
        public IObservable<ICompilationEvent> Updates => updates;

        private Program? programAfterParsing;
        private Program? transformedProgram;
        private readonly IDisposable staticDiagnosticsSubscription;

        private bool disposed;
        private readonly ObservableErrorReporter errorReporter;

        public Task<Program?> ParsedProgram { get; }
        public Task<ResolutionResult?> Resolution { get; }

        public ErrorReporter Reporter => errorReporter;

        public Task<IReadOnlyList<DafnyFile>> RootFiles { get; set; }
        public bool HasErrors { get; private set; }

        public Compilation(
          ILogger<Compilation> logger,
          IFileSystem fileSystem,
          ITextDocumentLoader documentLoader,
          IProgramVerifier verifier,
          ExecutionEngine boogieEngine,
          CompilationInput input
          )
        {
            Input = input;
            this.boogieEngine = boogieEngine;

            this.documentLoader = documentLoader;
            this.logger = logger;
            this.fileSystem = fileSystem;
            this.verifier = verifier;

            errorReporter = new ObservableErrorReporter(Options, Project.Uri);
            errorReporter.Updates.Subscribe(updates);
            staticDiagnosticsSubscription = errorReporter.Updates.Subscribe(newDiagnostic =>
            {
                if (MutateCSharp.Schemata333.ReplaceBinExprOp_0(1L, newDiagnostic.Diagnostic.Level, ErrorLevel.Error))
                {
                    HasErrors = MutateCSharp.Schemata333.ReplaceBooleanConstant_1(2L, true);
                }
                staticDiagnostics.GetOrAdd(newDiagnostic.Uri, _ => new()).Push(newDiagnostic.Diagnostic);
            });

            cancellationSource = new();
            cancellationSource.Token.Register(() => started.TrySetCanceled(cancellationSource.Token));

            verificationTickets.Enqueue(Unit.Default);

            RootFiles = DetermineRootFiles();
            ParsedProgram = ParseAsync();
            Resolution = ResolveAsync();
        }

        public void Start()
        {
            if (Started)
            {
                throw new InvalidOperationException(MutateCSharp.Schemata333.ReplaceStringConstant_2(3L, "Compilation was already started"));
            }

            Project.Errors.CopyDiagnostics(errorReporter);

            started.TrySetResult();
        }

        private ImmutableList<FileDiagnostic> GetDiagnosticsCopyAndClear()
        {
            var result = staticDiagnostics.SelectMany(k =>
              k.Value.Select(v => new FileDiagnostic(k.Key, v.ToLspDiagnostic()))).ToImmutableList();
            staticDiagnostics.Clear();
            return result;
        }



        private async Task<IReadOnlyList<DafnyFile>> DetermineRootFiles()
        {
            await started.Task;

            var result = new List<DafnyFile>();
            var includedFiles = new List<DafnyFile>();
            foreach (var uri in Input.Project.GetRootSourceUris(fileSystem))
            {
                await foreach (var file in DafnyFile.CreateAndValidate(fileSystem, errorReporter, Options, uri,
                                 Project.StartingToken))
                {
                    result.Add(file);
                    includedFiles.Add(file);
                }
            }

            foreach (var uri in Options.CliRootSourceUris)
            {
                var shortPath = Path.GetRelativePath(Directory.GetCurrentDirectory(), uri.LocalPath);
                await foreach (var file in DafnyFile.CreateAndValidate(fileSystem, errorReporter, Options, uri, Token.Cli,
          MutateCSharp.Schemata333.ReplaceBooleanConstant_1(4L, false),
                                 $"command-line argument '{shortPath}' is neither a recognized option nor a Dafny input file (.dfy, .doo, or .toml)."))
                {
                    result.Add(file);
                }
            }
            if (Options.UseStdin)
            {
                result.Add(DafnyFile.HandleStandardInput(Options, Token.Cli));
            }

            if (MutateCSharp.Schemata333.ReplaceBinExprOp_3(5L, () => !HasErrors, () => !result.Any()))
            {
                errorReporter.Error(MessageSource.Project, GeneratorErrors.ErrorId.None, Project.StartingToken,
          MutateCSharp.Schemata333.ReplaceStringConstant_2(11L, "no Dafny source files were specified as input"));
            }

            if (Options.Get(CommonOptionBag.UseStandardLibraries))
            {
                // For now the standard libraries are still translated from scratch.
                // This breaks separate compilation and will be addressed in https://github.com/dafny-lang/dafny/pull/4877
                var asLibrary = MutateCSharp.Schemata333.ReplaceBooleanConstant_1(12L, false);

                if (Options.CompilerName is null or "cs" or "java" or "go" or "py" or "js")
                {
                    var targetName = Options.CompilerName ?? MutateCSharp.Schemata333.ReplaceStringConstant_2(13L, "notarget");
                    var stdlibDooUri = DafnyMain.StandardLibrariesDooUriTarget[targetName];
                    await foreach (var targetSpecificFile in DafnyFile.CreateAndValidate(OnDiskFileSystem.Instance, errorReporter,
                                     Options, stdlibDooUri, Project.StartingToken, asLibrary))
                    {
                        result.Add(targetSpecificFile);
                    }
                }

                await foreach (var file in DafnyFile.CreateAndValidate(fileSystem, errorReporter, Options,
                                 DafnyMain.StandardLibrariesDooUri, Project.StartingToken, asLibrary))
                {
                    result.Add(file);
                }
            }

            var libraryDafnyFiles = new List<DafnyFile>();
            var libraryPaths = CommonOptionBag.SplitOptionValueIntoFiles(Options.Get(CommonOptionBag.Libraries).Select(f => f.FullName));
            foreach (var library in libraryPaths)
            {
                await foreach (var file in DafnyFile.CreateAndValidate(fileSystem, errorReporter, Options, new Uri(library), Project.StartingToken, MutateCSharp.Schemata333.ReplaceBooleanConstant_1(14L, true)))
                {
                    result.Add(file);
                    libraryDafnyFiles.Add(file);
                }
            }

            if (Project.UsesProjectFile)
            {
                var projectDirectory = Path.GetDirectoryName(Project.Uri.LocalPath)!;
                var includedRootsMessage = string.Join(MutateCSharp.Schemata333.ReplaceStringConstant_2(15L, "\n"), includedFiles.Select(dafnyFile => Path.GetRelativePath(projectDirectory, dafnyFile.Uri.LocalPath)));
                if (MutateCSharp.Schemata333.ReplaceBinExprOp_4(16L, includedRootsMessage, ""))
                {
                    includedRootsMessage = MutateCSharp.Schemata333.ReplaceStringConstant_2(17L, "none");
                }
                errorReporter.Info(MessageSource.Project, Project.StartingToken, MutateCSharp.Schemata333.ReplaceStringConstant_2(18L, "Files included by project are:") + Environment.NewLine + includedRootsMessage);
            }

            // Allow specifying the same file twice on the CLI
            var distinctResults = result.DistinctBy(d => d.Uri).ToList();

            updates.OnNext(new DeterminedRootFiles(Project, distinctResults, GetDiagnosticsCopyAndClear()));
            return distinctResults;
        }

        private async Task<Program?> ParseAsync()
        {
            try
            {
                await RootFiles;
                if (HasErrors)
                {
                    return null;
                }

                transformedProgram = await documentLoader.ParseAsync(this, cancellationSource.Token);
                transformedProgram.HasParseErrors = HasErrors;

                var cloner = new Cloner(MutateCSharp.Schemata333.ReplaceBooleanConstant_1(19L, true));
                programAfterParsing = new Program(cloner, transformedProgram);

                updates.OnNext(new FinishedParsing(programAfterParsing, GetDiagnosticsCopyAndClear()));
                logger.LogDebug(
                  $"Passed parsedCompilation to documentUpdates.OnNext, resolving ParsedCompilation task for version {Input.Version}.");
                return programAfterParsing;

            }
            catch (OperationCanceledException)
            {
                throw;
            }
            catch (Exception e)
            {
                updates.OnNext(new InternalCompilationException(new MessageSourceBasedPhase(MessageSource.Parser), e));
                throw;
            }

            return default;
        }

        private async Task<ResolutionResult?> ResolveAsync()
        {
            try
            {
                await ParsedProgram;
                if (MutateCSharp.Schemata333.ReplaceBinExprOp_5(20L, transformedProgram, null))
                {
                    return null;
                }
                var resolution = await documentLoader.ResolveAsync(this, transformedProgram!, cancellationSource.Token);
                if (MutateCSharp.Schemata333.ReplaceBinExprOp_6(21L, resolution, null))
                {
                    return null;
                }

                updates.OnNext(new FinishedResolution(
                  resolution,
                  GetDiagnosticsCopyAndClear()));
                staticDiagnosticsSubscription.Dispose();
                logger.LogDebug($"Passed resolvedCompilation to documentUpdates.OnNext, resolving ResolvedCompilation task for version {Input.Version}.");
                return resolution;

            }
            catch (OperationCanceledException)
            {
                throw;
            }
            catch (Exception e)
            {
                updates.OnNext(new InternalCompilationException(new MessageSourceBasedPhase(MessageSource.Resolver), e));
                throw;
            }

            return default;
        }

        public static string GetTaskName(IVerificationTask task)
        {
            var prefix = task.ScopeId + task.Split.SplitIndex;

            // Refining declarations get the token of what they're refining, so to distinguish them we need to
            // add the refining module name to the prefix.
            if (task.ScopeToken is RefinementToken refinementToken)
            {
                prefix += MutateCSharp.Schemata333.ReplaceStringConstant_2(22L, ".") + refinementToken.InheritingModule.Name;
            }

            return prefix;
        }

        private int runningVerificationJobs;

        // When verifying a symbol, a ticket must be acquired before the SMT part of verification may start.
        private readonly AsyncQueue<Unit> verificationTickets = new();
        public async Task<bool> VerifyLocation(FilePosition verifiableLocation, bool onlyPrepareVerificationForGutterTests = false)
        {
            cancellationSource.Token.ThrowIfCancellationRequested();

            var resolution = await Resolution;
            if (MutateCSharp.Schemata333.ReplaceBinExprOp_7(24L, () => MutateCSharp.Schemata333.ReplaceBinExprOp_6(23L, resolution, null), () => resolution.HasErrors))
            {
                return MutateCSharp.Schemata333.ReplaceBooleanConstant_1(30L, false);
            }

            var canVerify = resolution.ResolvedProgram.FindNode(verifiableLocation.Uri, verifiableLocation.Position.ToDafnyPosition(),
              node =>
              {
                  if (node is not ICanVerify)
                  {
                      return MutateCSharp.Schemata333.ReplaceBooleanConstant_1(31L, false);
                  }
                  // Sometimes traversing the AST can return different versions of a single source AST node,
                  // for example in the case of a LeastLemma, which is later also represented as a PrefixLemma.
                  // This check ensures that we consistently use the same version of an AST node. 
                  return resolution.CanVerifies!.Contains(node);
              }) as ICanVerify;

            if (MutateCSharp.Schemata333.ReplaceBinExprOp_8(32L, canVerify, null))
            {
                return MutateCSharp.Schemata333.ReplaceBooleanConstant_1(33L, false);
            }

            return await VerifyCanVerify(canVerify, _ => MutateCSharp.Schemata333.ReplaceBooleanConstant_1(34L, true), null, onlyPrepareVerificationForGutterTests);
        }

        public async Task<bool> VerifyCanVerify(ICanVerify canVerify, Func<IVerificationTask, bool> taskFilter,
          int? randomSeed = 0,
          bool onlyPrepareVerificationForGutterTests = false)
        {

            var resolution = await Resolution;
            if (MutateCSharp.Schemata333.ReplaceBinExprOp_6(35L, resolution, null))
            {
                return MutateCSharp.Schemata333.ReplaceBooleanConstant_1(36L, false);
            }

            var containingModule = canVerify.ContainingModule;
            if (!containingModule.ShouldVerify(resolution.ResolvedProgram.Compilation))
            {
                return MutateCSharp.Schemata333.ReplaceBooleanConstant_1(37L, false);
            }

            if (MutateCSharp.Schemata333.ReplaceBinExprOp_3(44L, () => !onlyPrepareVerificationForGutterTests, () => (MutateCSharp.Schemata333.ReplaceBinExprOp_3(38L, () => randomSeed == null, () => !verifyingOrVerifiedSymbols.TryAdd(canVerify, Unit.Default)))))
            {
                return MutateCSharp.Schemata333.ReplaceBooleanConstant_1(50L, false);
            }

            updates.OnNext(new ScheduledVerification(canVerify));

            if (onlyPrepareVerificationForGutterTests)
            {
                await VerifyUnverifiedSymbol(onlyPrepareVerificationForGutterTests, canVerify, resolution, taskFilter, randomSeed);
                return MutateCSharp.Schemata333.ReplaceBooleanConstant_1(51L, true);
            }

            _ = VerifyUnverifiedSymbol(onlyPrepareVerificationForGutterTests, canVerify, resolution, taskFilter, randomSeed);
            return MutateCSharp.Schemata333.ReplaceBooleanConstant_1(52L, true);
        }

        private async Task VerifyUnverifiedSymbol(bool onlyPrepareVerificationForGutterTests, ICanVerify canVerify,
          ResolutionResult resolution, Func<IVerificationTask, bool> taskFilter, int? randomSeed)
        {
            try
            {

                var ticket = verificationTickets.Dequeue(CancellationToken.None);
                var containingModule = canVerify.ContainingModule;

                IReadOnlyDictionary<FilePosition, IReadOnlyList<IVerificationTask>> tasksForModule;
                try
                {
                    tasksForModule = await translatedModules.GetOrAdd(containingModule, async () =>
                    {
                        var result = await verifier.GetVerificationTasksAsync(boogieEngine, resolution, containingModule,
                          cancellationSource.Token);
                        foreach (var task in result)
                        {
                            cancellationSource.Token.Register(task.Cancel);
                        }

                        return result.GroupBy(t => ((IToken)t.ScopeToken).GetFilePosition()).ToDictionary(
                          g => g.Key,
                          g => (IReadOnlyList<IVerificationTask>)g.ToList());
                    });
                }
                catch (OperationCanceledException)
                {
                    throw;
                }
                catch (Exception e)
                {
                    updates.OnNext(new InternalCompilationException(new MessageSourceBasedPhase(MessageSource.Verifier), e));
                    throw;
                }

                // For updated to be reliable, tasksPerVerifiable must be Lazy
                var updated = MutateCSharp.Schemata333.ReplaceBooleanConstant_1(53L, false);
                var tasks = tasksPerVerifiable.GetOrAdd(canVerify, () =>
                {
                    var result =
                      tasksForModule.GetValueOrDefault(canVerify.NameToken.GetFilePosition()) ??
                      new List<IVerificationTask>(MutateCSharp.Schemata333.ReplaceNumericConstant_9(54L, 0));

                    updated = MutateCSharp.Schemata333.ReplaceBooleanConstant_1(58L, true);
                    return result;
                });
                if (MutateCSharp.Schemata333.ReplaceBinExprOp_7(59L, () => updated, () => randomSeed != null))
                {
                    updates.OnNext(new CanVerifyPartsIdentified(canVerify,
                      tasksPerVerifiable[canVerify].ToList()));
                }

                // When multiple calls to VerifyUnverifiedSymbol are made, the order in which they pass this await matches the call order.
                await ticket;

                if (!onlyPrepareVerificationForGutterTests)
                {
                    foreach (var task in tasks.Where(taskFilter))
                    {
                        var seededTask = randomSeed == null ? task : task.FromSeed(randomSeed.Value);
                        VerifyTask(canVerify, seededTask);
                    }
                }

            }
            finally
            {
                verificationTickets.Enqueue(Unit.Default);
            }
        }

        private void VerifyTask(ICanVerify canVerify, IVerificationTask task)
        {
            var statusUpdates = task.TryRun();
            if (MutateCSharp.Schemata333.ReplaceBinExprOp_10(65L, statusUpdates, null))
            {
                if (task.CacheStatus is Completed completedCache)
                {
                    HandleStatusUpdate(canVerify, task, completedCache);
                }

                return;
            }

            var incrementedJobs = Interlocked.Increment(ref runningVerificationJobs);
            logger.LogDebug(
              $"Incremented jobs for task, remaining jobs {incrementedJobs}, {Input.Uri} version {Input.Version}");

            statusUpdates.Subscribe(
              update =>
              {
                  try
                  {
                      HandleStatusUpdate(canVerify, task, update);
                  }
                  catch (Exception e)
                  {
                      logger.LogError(e, MutateCSharp.Schemata333.ReplaceStringConstant_2(66L, "Caught exception in statusUpdates OnNext."));
                  }
              },
              e =>
              {
                  updates.OnNext(new BoogieException(canVerify, task, e));
                  if (e is not OperationCanceledException)
                  {
                      logger.LogError(e, $"Caught error in statusUpdates observable.");
                  }
              }
            );
        }

        public async Task Cancel(FilePosition filePosition)
        {
            var resolution = await Resolution;
            if (MutateCSharp.Schemata333.ReplaceBinExprOp_6(67L, resolution, null))
            {
                return;
            }

            var canVerify = resolution.ResolvedProgram.FindNode<ICanVerify>(filePosition.Uri, filePosition.Position.ToDafnyPosition());
            if (MutateCSharp.Schemata333.ReplaceBinExprOp_11(68L, canVerify, null))
            {
                var implementations = tasksPerVerifiable.TryGetValue(canVerify, out var implementationsPerName)
                  ? implementationsPerName! : Enumerable.Empty<IVerificationTask>();
                foreach (var view in implementations)
                {
                    view.Cancel();
                }
                verifyingOrVerifiedSymbols.TryRemove(canVerify, out _);
            }
        }

        private void HandleStatusUpdate(ICanVerify canVerify, IVerificationTask verificationTask, IVerificationStatus boogieStatus)
        {
            var tokenString = BoogieGenerator.ToDafnyToken(MutateCSharp.Schemata333.ReplaceBooleanConstant_1(69L, true), verificationTask.Split.Token).TokenToString(Options);
            logger.LogDebug($"Received Boogie status {boogieStatus} for {tokenString}, version {Input.Version}");

            updates.OnNext(new BoogieUpdate(transformedProgram!.ProofDependencyManager, canVerify,
              verificationTask,
              boogieStatus));
        }

        public void CancelPendingUpdates()
        {
            cancellationSource.Cancel();
        }

        public async Task<TextEditContainer?> GetTextEditToFormatCode(Uri uri)
        {
            // TODO https://github.com/dafny-lang/dafny/issues/3416
            var program = await ParsedProgram;
            if (MutateCSharp.Schemata333.ReplaceBinExprOp_5(70L, program, null))
            {
                return null;
            }

            if (program.HasParseErrors)
            {
                return null;
            }

            var firstToken = program.GetFirstTokenForUri(uri);
            if (MutateCSharp.Schemata333.ReplaceBinExprOp_12(71L, firstToken, null))
            {
                return null;
            }

            // Make sure that we capture the legacy include tokens
            while (firstToken.Prev is { line: >= 1, Filepath: var filePath } && MutateCSharp.Schemata333.ReplaceBinExprOp_4(72L, filePath, firstToken.Filepath))
            {
                firstToken = firstToken.Prev;
            }
            var result = Formatting.__default.ReindentProgramFromFirstToken(firstToken,
              IndentationFormatter.ForProgram(program, firstToken.Uri));

            var lastToken = firstToken;
            while (MutateCSharp.Schemata333.ReplaceBinExprOp_13(73L, lastToken.Next, null))
            {
                lastToken = lastToken.Next;
            }
            // TODO: end position doesn't take into account trailing trivia: https://github.com/dafny-lang/dafny/issues/3415
            return new TextEditContainer(new TextEdit[] {
      new() {NewText = result, Range = new Range(new Position(MutateCSharp.Schemata333.ReplaceNumericConstant_9(74L, 0), MutateCSharp.Schemata333.ReplaceNumericConstant_9(78L, 0)), lastToken.GetLspPosition())}
    });

        }

        public void Dispose()
        {
            if (disposed)
            {
                return;
            }

            disposed = MutateCSharp.Schemata333.ReplaceBooleanConstant_1(82L, true);
            CancelPendingUpdates();
        }

        public static List<DafnyDiagnostic> GetDiagnosticsFromResult(DafnyOptions options, Uri uri, ICanVerify canVerify,
          IVerificationTask task, VerificationRunResult result)
        {
            var errorReporter = new ObservableErrorReporter(options, uri);
            List<DafnyDiagnostic> diagnostics = new();
            errorReporter.Updates.Subscribe(d => diagnostics.Add(d.Diagnostic));

            ReportDiagnosticsInResult(options, canVerify.NameToken.val, task.ScopeToken,
              task.Split.Implementation.GetTimeLimit(options), result, errorReporter);

            return diagnostics.OrderBy(d => d.Token.GetLspPosition()).ToList();
        }

        public static void ReportDiagnosticsInResult(DafnyOptions options, string name, Boogie.IToken token,
          uint timeLimit,
          VerificationRunResult result,
          ErrorReporter errorReporter)
        {
            var outcome = GetOutcome(result.Outcome);
            result.CounterExamples.Sort(new CounterexampleComparer());
            foreach (var counterExample in result.CounterExamples) //.OrderBy(d => d.GetLocation()))
            {
                var errorInformation = counterExample.CreateErrorInformation(outcome, options.ForceBplErrors);
                if (options.ShowProofObligationExpressions)
                {
                    AddAssertedExprToCounterExampleErrorInfo(options, counterExample, errorInformation);
                }
                var dafnyCounterExampleModel = options.ExtractCounterexample ? new DafnyModel(counterExample.Model, options) : null;
                errorReporter.ReportBoogieError(errorInformation, dafnyCounterExampleModel);
            }

            // This reports problems that are not captured by counter-examples, like a time-out
            // The Boogie API forces us to create a temporary engine here to report the outcome, even though it only uses the options.
            var boogieEngine = new ExecutionEngine(options, new VerificationResultCache(),
              CustomStackSizePoolTaskScheduler.Create(MutateCSharp.Schemata333.ReplaceNumericConstant_9(83L, 0), MutateCSharp.Schemata333.ReplaceNumericConstant_9(87L, 0)));
            boogieEngine.ReportOutcome(null, outcome, outcomeError => errorReporter.ReportBoogieError(outcomeError, null, MutateCSharp.Schemata333.ReplaceBooleanConstant_1(91L, false)),
              name, token, null, TextWriter.Null,
              timeLimit, result.CounterExamples);
        }

        private static void AddAssertedExprToCounterExampleErrorInfo(
            DafnyOptions options, Counterexample counterExample, ErrorInformation errorInformation)
        {
            Boogie.ProofObligationDescription? boogieProofObligationDesc = null;
            switch (errorInformation.Kind)
            {
                case ErrorKind.Assertion:
                    boogieProofObligationDesc = ((AssertCounterexample)counterExample).FailingAssert.Description;
                    break;
                    break;
                case ErrorKind.Precondition:
                    boogieProofObligationDesc = ((CallCounterexample)counterExample).FailingCall.Description;
                    break;
                    break;
                case ErrorKind.Postcondition:
                    boogieProofObligationDesc = ((ReturnCounterexample)counterExample).FailingReturn.Description;
                    break;
                    break;
                case ErrorKind.InvariantEntry:
                case ErrorKind.InvariantMaintainance:
                    AssertCmd failingAssert = ((AssertCounterexample)counterExample).FailingAssert;
                    if (failingAssert is LoopInitAssertCmd loopInitAssertCmd)
                    {
                        boogieProofObligationDesc = loopInitAssertCmd.originalAssert.Description;
                    }
                    else if (failingAssert is LoopInvMaintainedAssertCmd maintainedAssertCmd)
                    {
                        boogieProofObligationDesc = maintainedAssertCmd.originalAssert.Description;
                    }
                    break;
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"Unexpected ErrorKind: {errorInformation.Kind}");
                    break;
            }

            if (boogieProofObligationDesc is ProofObligationDescription.ProofObligationDescription dafnyProofObligationDesc)
            {
                var expr = dafnyProofObligationDesc.GetAssertedExpr(options);
                if (MutateCSharp.Schemata333.ReplaceBinExprOp_14(92L, expr, null))
                {
                    errorInformation.AddAuxInfo(errorInformation.Tok, expr.ToString(), ErrorReporterExtensions.AssertedExprCategory);
                }
            }
        }

        public static VcOutcome GetOutcome(SolverOutcome outcome)
        {
            switch (outcome)
            {
                case SolverOutcome.Valid:
                    return VcOutcome.Correct;
                    break;
                case SolverOutcome.Invalid:
                    return VcOutcome.Errors;
                    break;
                case SolverOutcome.TimeOut:
                    return VcOutcome.TimedOut;
                    break;
                case SolverOutcome.OutOfMemory:
                    return VcOutcome.OutOfMemory;
                    break;
                case SolverOutcome.OutOfResource:
                    return VcOutcome.OutOfResource;
                    break;
                case SolverOutcome.Undetermined:
                    return VcOutcome.Inconclusive;
                    break;
                case SolverOutcome.Bounded:
                    return VcOutcome.ReachedBound;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(outcome), outcome, null);
                    break;
            }

            return default;
        }
    }
}