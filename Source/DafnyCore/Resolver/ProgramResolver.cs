using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Dafny.Compilers;
namespace MutateCSharp
{
    internal class Schemata431
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT431");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, Microsoft.Dafny.ModuleDefinition argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.ModuleKindEnum argument1, Microsoft.Dafny.ModuleKindEnum argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.ModuleDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.Implements argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.NonNullTypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class ProgramResolver
    {
        public Program Program { get; }

        private readonly Dictionary<TopLevelDeclWithMembers, Dictionary<string, MemberDecl>> classMembers = new();

        protected readonly Graph<ModuleDecl> dependencies = new();
        public DafnyOptions Options => Program.Options;
        public SystemModuleManager SystemModuleManager => Program.SystemModuleManager;
        public ErrorReporter Reporter => Program.Reporter;

        public ProgramResolver(Program program)
        {
            Program = program;
        }

        public Dictionary<string, MemberDecl> GetClassMembers(TopLevelDeclWithMembers key)
        {
            if (classMembers.TryGetValue(key, out var result))
            {
                return result;
            }
            return null;
        }

        public virtual Task Resolve(CancellationToken cancellationToken)
        {
            Type.ResetScopes();

            Type.EnableScopes();
            // For the formatter, we ensure we take snapshots of the PrefixNamedModules and topleveldecls
            Program.DefaultModuleDef.PreResolveSnapshotForFormatter();

            // Changing modules at this stage without changing their CloneId doesn't break resolution caching,
            // because ResolvedPrefixNamedModules end up in the dependencies of a module so they change its hash anyways
            Program.DefaultModuleDef.ProcessPrefixNamedModules();

            var startingErrorCount = Reporter.ErrorCount;
            ComputeModuleDependencyGraph(Program, out var moduleDeclarationPointers);

            if (MutateCSharp.Schemata431.ReplaceBinExprOp_0(1L, Reporter.ErrorCount, startingErrorCount))
            {
                return Task.CompletedTask;
            }

            var sortedDecls = dependencies.TopologicallySortedComponents();
            Program.ModuleSigs = new();

            SetHeights(sortedDecls);

            var systemClassMembers = ResolveSystemModule(Program);
            foreach (var moduleClassMembers in systemClassMembers)
            {
                classMembers[moduleClassMembers.Key] = moduleClassMembers.Value;
            }

            var rewriters = RewriterCollection.GetRewriters(Reporter, Program);

            var compilation = Program.Compilation;
            foreach (var rewriter in rewriters)
            {
                cancellationToken.ThrowIfCancellationRequested();
                rewriter.PreResolve(Program);
            }

            foreach (var decl in sortedDecls)
            {
                cancellationToken.ThrowIfCancellationRequested();
                var moduleResolutionResult = ResolveModuleDeclaration(compilation, decl);
                ProcessDeclarationResolutionResult(moduleDeclarationPointers, decl, moduleResolutionResult);
            }

            if (MutateCSharp.Schemata431.ReplaceBinExprOp_0(6L, Reporter.ErrorCount, startingErrorCount))
            {
                return Task.CompletedTask;
            }

            Type.DisableScopes();

            InstantiateReplaceableModules(Program);
            CheckDuplicateModuleNames(Program);

            foreach (var rewriter in rewriters)
            {
                cancellationToken.ThrowIfCancellationRequested();
                rewriter.PostResolve(Program);
            }
            return Task.CompletedTask;
        }

        public void AddSystemClass(TopLevelDeclWithMembers topLevelDeclWithMembers, Dictionary<string, MemberDecl> memberDictionary)
        {
            classMembers[topLevelDeclWithMembers] = memberDictionary;
        }

        private void ProcessDeclarationResolutionResult(Dictionary<ModuleDecl, Action<ModuleDecl>> moduleDeclarationPointers, ModuleDecl decl,
          ModuleResolutionResult moduleResolutionResult)
        {
            moduleDeclarationPointers[decl](moduleResolutionResult.ResolvedDeclaration);

            foreach (var sig in moduleResolutionResult.Signatures)
            {
                Program.ModuleSigs[sig.Key] = sig.Value;
            }

            foreach (var moduleClassMembers in moduleResolutionResult.ClassMembers)
            {
                classMembers[moduleClassMembers.Key] = moduleClassMembers.Value;
            }

            foreach (var diagnostic in moduleResolutionResult.ErrorReporter.AllMessages)
            {
                Reporter.Message(diagnostic.Source, diagnostic.Level, diagnostic.ErrorId, diagnostic.Token,
                  diagnostic.Message);
            }
        }

        /// <summary>
        /// We determine where pointers to module declarations occur, and store those so caching can later set those.
        /// </summary>
        private void ComputeModuleDependencyGraph(Program program, out Dictionary<ModuleDecl, Action<ModuleDecl>> moduleDeclarationPointers)
        {
            var startingErrorCount = Reporter.ErrorCount;
            var rootBindings = new ModuleBindings(null);
            // TODO can we delete rootBindings and pass null instead?
            var defaultModuleBindings = program.DefaultModuleDef.BindModuleNames(this, rootBindings);
            rootBindings.BindName(program.DefaultModule.Name, program.DefaultModule, defaultModuleBindings);

            if (MutateCSharp.Schemata431.ReplaceBinExprOp_0(11L, Reporter.ErrorCount, startingErrorCount))
            {
                // if there were errors, then the implicit ModuleBindings data structure invariant
                // is violated, so Processing dependencies will not succeed.
                moduleDeclarationPointers = null;
                return;
            }

            moduleDeclarationPointers = new();
            moduleDeclarationPointers[program.DefaultModule] = v => program.DefaultModule = (LiteralModuleDecl)v;
            ProcessDependencies(program.DefaultModule, defaultModuleBindings, moduleDeclarationPointers);

            // check for cycles in the import graph
            foreach (var cycle in dependencies.AllCycles())
            {
                ModuleResolver.ReportCycleError(Reporter, cycle, m => m.tok,
                  m => (m is AliasModuleDecl ? MutateCSharp.Schemata431.ReplaceStringConstant_1(16L, "import ") : MutateCSharp.Schemata431.ReplaceStringConstant_1(17L, "module ")) + m.Name,
          MutateCSharp.Schemata431.ReplaceStringConstant_1(18L, "module definition contains a cycle (note: parent modules implicitly depend on submodules)"));
            }
        }

        protected virtual Dictionary<TopLevelDeclWithMembers, Dictionary<string, MemberDecl>> ResolveSystemModule(Program program)
        {
            var systemModuleResolver = new ModuleResolver(this, Options);

            SystemModuleManager.systemNameInfo = SystemModuleManager.SystemModule.RegisterTopLevelDecls(systemModuleResolver, MutateCSharp.Schemata431.ReplaceBooleanConstant_2(19L, false));
            systemModuleResolver.moduleInfo = SystemModuleManager.systemNameInfo;

            systemModuleResolver.RevealAllInScope(SystemModuleManager.SystemModule.TopLevelDecls, SystemModuleManager.systemNameInfo.VisibilityScope);
            SystemModuleManager.ResolveValueTypeDecls(this);

            if (Options.Get(CommonOptionBag.TypeSystemRefresh))
            {
                PreTypeResolver.ResolveDeclarations(
                  SystemModuleManager.SystemModule.TopLevelDecls.Where(d => d is not ClassDecl).ToList(),
                  systemModuleResolver, MutateCSharp.Schemata431.ReplaceBooleanConstant_2(20L, true));
            }

            // The SystemModule is constructed with all its members already being resolved. Except for
            // the non-null type corresponding to class types.  They are resolved here:
            var systemModuleClassesWithNonNullTypes =
              SystemModuleManager.SystemModule.TopLevelDecls.Where(d => MutateCSharp.Schemata431.ReplaceBinExprOp_3(21L, (d as ClassLikeDecl)?.NonNullTypeDecl, null)).ToList();
            foreach (var cl in systemModuleClassesWithNonNullTypes)
            {
                var d = ((ClassLikeDecl)cl).NonNullTypeDecl;
                systemModuleResolver.allTypeParameters.PushMarker();
                systemModuleResolver.ResolveTypeParameters(d.TypeArgs, MutateCSharp.Schemata431.ReplaceBooleanConstant_2(22L, true), d);
                systemModuleResolver.ResolveType(d.tok, d.Rhs, d, ResolveTypeOptionEnum.AllowPrefix, d.TypeArgs);
                systemModuleResolver.allTypeParameters.PopMarker();
            }

            systemModuleResolver.ResolveTopLevelDecls_Core(
              ModuleDefinition.AllDeclarationsAndNonNullTypeDecls(systemModuleClassesWithNonNullTypes).ToList(),
              new Graph<IndDatatypeDecl>(), new Graph<CoDatatypeDecl>(), SystemModuleManager.SystemModule.Name, MutateCSharp.Schemata431.ReplaceBooleanConstant_2(23L, false));

            return systemModuleResolver.moduleClassMembers;
        }

        protected virtual ModuleResolutionResult ResolveModuleDeclaration(CompilationData compilation, ModuleDecl decl)
        {
            var moduleResolver = new ModuleResolver(this, decl.Options);
            return moduleResolver.ResolveModuleDeclaration(compilation, decl);
        }

        private static void SetHeights(IEnumerable<ModuleDecl> sortedDecls)
        {
            foreach (var withIndex in sortedDecls.Zip(Enumerable.Range(MutateCSharp.Schemata431.ReplaceNumericConstant_4(24L, 0), int.MaxValue)))
            {
                var md = withIndex.First;
                md.Height = withIndex.Second;
                if (md is LiteralModuleDecl literalModuleDecl)
                {
                    var mdef = literalModuleDecl.ModuleDef;
                    mdef.Height = withIndex.Second;
                }
            }
        }

        /// <summary>
        /// Check that no two modules that are being compiled have the same CompileName.
        ///
        /// This could happen if they are given the same name using the 'extern' declaration modifier.
        /// </summary>
        /// <param name="program">The Dafny program being compiled.</param>
        private void CheckDuplicateModuleNames(Program program)
        {
            // Check that none of the modules have the same CompileName.
            Dictionary<string, ModuleDefinition> compileNameMap = new Dictionary<string, ModuleDefinition>();
            foreach (ModuleDefinition m in program.CompileModules)
            {
                if (MutateCSharp.Schemata431.ReplaceBinExprOp_5(28L, () => !m.CanCompile(), () => !ShouldCompile(m)))
                {
                    // the purpose of an abstract module is to skip compilation
                    continue;
                }

                string compileName = m.GetCompileName(Options);
                if (compileNameMap.TryGetValue(compileName, out var priorModDef))
                {
                    Reporter.Error(MessageSource.Resolver, m.tok,
            MutateCSharp.Schemata431.ReplaceStringConstant_1(34L, "modules '{0}' and '{1}' both have CompileName '{2}'"),
                      priorModDef.tok.val, m.tok.val, compileName);
                }
                else
                {
                    compileNameMap.Add(compileName, m);
                }
            }
        }

        public static bool ShouldCompile(IAttributeBearingDeclaration m)
        {
            var compileIt = MutateCSharp.Schemata431.ReplaceBooleanConstant_2(35L, true);
            Attributes.ContainsBool(m.Attributes, MutateCSharp.Schemata431.ReplaceStringConstant_1(36L, "compile"), ref compileIt);
            return compileIt;
        }

        protected void InstantiateReplaceableModules(Program dafnyProgram)
        {
            foreach (var compiledModule in dafnyProgram.Modules().OrderByDescending(m => m.Height))
            {
                if (compiledModule.Implements is { Kind: ImplementationKind.Replacement })
                {
                    var target = compiledModule.Implements.Target.Def;
                    var replacement = Program.Replacements.GetValueOrDefault(target);
                    if (MutateCSharp.Schemata431.ReplaceBinExprOp_6(37L, replacement, null))
                    {
                        Reporter!.Error(MessageSource.Resolver, new NestedToken(compiledModule.Tok, replacement.Tok,
                            $"other replacing module"),
              MutateCSharp.Schemata431.ReplaceStringConstant_1(38L, "a replaceable module may only be replaced once"));
                    }
                    else
                    {
                        Program.Replacements[target] = Program.Replacements.GetValueOrDefault(compiledModule, compiledModule);
                    }
                }
            }
        }

        public static string ModuleNotFoundErrorMessage(int i, List<Name> path, string tail = "")
        {
            Contract.Requires(path != null);
            Contract.Requires(0 <= i && i < path.Count);
            var addendum = MutateCSharp.Schemata431.ReplaceBinExprOp_7(43L, MutateCSharp.Schemata431.ReplaceNumericConstant_4(39L, 1), path.Count) ? $" (position {i} in path {Util.Comma(MutateCSharp.Schemata431.ReplaceStringConstant_1(48L, "."), path, x => x.Value)}){tail}" : "";
            return
              $"module {path[i].Value} does not exist" + addendum;
        }

        private void ProcessDependenciesDefinition(LiteralModuleDecl literalDecl, ModuleBindings bindings,
          IDictionary<ModuleDecl, Action<ModuleDecl>> declarationPointers)
        {
            var module = literalDecl.ModuleDef;
            if (MutateCSharp.Schemata431.ReplaceBinExprOp_8(49L, module.Implements, null))
            {
                var refinementTarget = module.Implements.Target;
                bool res = bindings.ResolveQualifiedModuleIdRootRefines(literalDecl.ModuleDef, refinementTarget, out var other);
                refinementTarget.Root = other;
                if (!res)
                {
                    Reporter.Error(MessageSource.Resolver, refinementTarget.RootToken(),
                      $"module {module.Implements.Target} named as {module.Implements.Kind.ToString().ToLower()} base does not exist");
                }
                else
                {
                    declarationPointers.AddOrUpdate(other, v => refinementTarget.Root = v, Util.Concat);
                    if (other is LiteralModuleDecl otherLiteral && MutateCSharp.Schemata431.ReplaceBinExprOp_9(50L, otherLiteral.ModuleDef, module))
                    {
                        Reporter.Error(MessageSource.Resolver, refinementTarget.RootToken(), MutateCSharp.Schemata431.ReplaceStringConstant_1(51L, "module cannot refine itself: {0}"),
                          module.Implements.Target.ToString());
                    }
                    else
                    {
                        Contract.Assert(other != null); // follows from postcondition of TryGetValue
                        dependencies.AddEdge(literalDecl, other);
                    }
                }
            }

            foreach (var pointer in module.TopLevelDeclPointers)
            {
                if (pointer.Get() is ModuleDecl moduleDecl)
                {
                    declarationPointers.Add(moduleDecl, v =>
                    {
                        pointer.Set(v);
                        v.EnclosingModuleDefinition = module;
                        if (v is LiteralModuleDecl literalModuleDecl)
                        {
                            literalModuleDecl.ModuleDef.EnclosingModule = module;
                        }
                    });
                }
            }

            foreach (var toplevel in module.TopLevelDecls)
            {
                if (toplevel is not ModuleDecl moduleDecl)
                {
                    continue;
                }

                if (toplevel is ModuleExportDecl)
                {
                    dependencies.AddEdge(moduleDecl, literalDecl);
                }
                else
                {
                    dependencies.AddEdge(literalDecl, moduleDecl);
                }

                var subBindings = bindings.SubBindings(moduleDecl.Name);
                ProcessDependencies(moduleDecl, subBindings ?? bindings, declarationPointers);
                if (MutateCSharp.Schemata431.ReplaceBinExprOp_12(54L, () => MutateCSharp.Schemata431.ReplaceBinExprOp_10(52L, module.ModuleKind, ModuleKindEnum.Concrete), () => MutateCSharp.Schemata431.ReplaceBinExprOp_11(53L, (moduleDecl as AbstractModuleDecl)?.QId.Root, null)))
                {
                    Reporter.Error(MessageSource.Resolver, moduleDecl.tok,
            MutateCSharp.Schemata431.ReplaceStringConstant_1(60L, "The abstract import named {0} (using :) may only be used in an abstract or replaceable module declaration"),
                      moduleDecl.Name);
                }
            }
        }

        private void ProcessDependencies(ModuleDecl moduleDecl, ModuleBindings bindings,
          IDictionary<ModuleDecl, Action<ModuleDecl>> declarationPointers)
        {
            dependencies.AddVertex(moduleDecl);
            if (moduleDecl is LiteralModuleDecl literalDecl)
            {
                ProcessDependenciesDefinition(literalDecl, bindings, declarationPointers);
            }
            else if (moduleDecl is AliasModuleDecl aliasDecl)
            {
                // TryLookupFilter works outward, looking for a match to the filter for
                // each enclosing module.
                if (!bindings.ResolveQualifiedModuleIdRootImport(aliasDecl, aliasDecl.TargetQId, out var root))
                {
                    //        if (!bindings.TryLookupFilter(alias.TargetQId.rootToken(), out root, m => alias != m)
                    Reporter.Error(MessageSource.Resolver, aliasDecl.TargetQId.Tok, ModuleNotFoundErrorMessage(MutateCSharp.Schemata431.ReplaceNumericConstant_4(61L, 0), aliasDecl.TargetQId.Path));
                }
                else
                {
                    aliasDecl.TargetQId.Root = root;
                    declarationPointers.AddOrUpdate(root, v => aliasDecl.TargetQId.Root = v, Util.Concat);
                    dependencies.AddEdge(aliasDecl, root);
                }
            }
            else if (moduleDecl is AbstractModuleDecl abstractDecl)
            {
                if (!bindings.ResolveQualifiedModuleIdRootAbstract(abstractDecl, abstractDecl.QId, out var root))
                {
                    //if (!bindings.TryLookupFilter(abs.QId.rootToken(), out root,
                    //  m => abs != m && (((abs.EnclosingModuleDefinition == m.EnclosingModuleDefinition) && (abs.Exports.Count == 0)) || m is LiteralModuleDecl)))
                    Reporter.Error(MessageSource.Resolver, abstractDecl.tok, ModuleNotFoundErrorMessage(MutateCSharp.Schemata431.ReplaceNumericConstant_4(65L, 0), abstractDecl.QId.Path));
                }
                else
                {
                    abstractDecl.QId.Root = root;
                    declarationPointers.AddOrUpdate(root, v => abstractDecl.QId.Root = v, Util.Concat);
                    dependencies.AddEdge(abstractDecl, root);
                }
            }
        }
    }
}
