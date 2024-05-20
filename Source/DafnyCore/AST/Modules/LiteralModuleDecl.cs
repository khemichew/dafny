using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata124
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT124");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_6(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static int ReplaceNumericConstant_3(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.ModuleSignature argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static int ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.Implements argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_9(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{

    /// <summary>
    /// Represents module X { ... }
    /// </summary>
    public class LiteralModuleDecl : ModuleDecl, ICanFormat, IHasSymbolChildren
    {
        public readonly ModuleDefinition ModuleDef;

        [FilledInDuringResolution] public ModuleSignature DefaultExport;  // the default export set of the module.

        private ModuleSignature emptySignature;
        public override ModuleSignature AccessibleSignature(bool ignoreExports)
        {
            if (ignoreExports)
            {
                return Signature;
            }
            return this.AccessibleSignature();
        }
        public override ModuleSignature AccessibleSignature()
        {
            if (MutateCSharp.Schemata124.ReplaceBinExprOp_0(1L, DefaultExport, null))
            {
                if (MutateCSharp.Schemata124.ReplaceBinExprOp_0(2L, emptySignature, null))
                {
                    emptySignature = new ModuleSignature();
                }
                return emptySignature;
            }
            return DefaultExport;
        }

        public override IEnumerable<INode> Children => new[] { ModuleDef };
        public override IEnumerable<INode> PreResolveChildren => Children;

        public LiteralModuleDecl(Cloner cloner, LiteralModuleDecl original, ModuleDefinition parent)
          : base(cloner, original, parent)
        {
            var newModuleDefinition = cloner.CloneLiteralModuleDefinition ? cloner.CloneModuleDefinition(original.ModuleDef, parent) : original.ModuleDef;
            ModuleDef = newModuleDefinition;
            DefaultExport = original.DefaultExport;
            BodyStartTok = ModuleDef.BodyStartTok;
            TokenWithTrailingDocString = ModuleDef.TokenWithTrailingDocString;
        }

        public LiteralModuleDecl(DafnyOptions options, ModuleDefinition module, ModuleDefinition parent, Guid cloneId)
          : base(options, module.RangeToken, module.NameNode, parent, MutateCSharp.Schemata124.ReplaceBooleanConstant_1(3L, false), MutateCSharp.Schemata124.ReplaceBooleanConstant_1(4L, false), cloneId)
        {
            ModuleDef = module;
            BodyStartTok = module.BodyStartTok;
            TokenWithTrailingDocString = module.TokenWithTrailingDocString;
        }

        public override object Dereference() { return ModuleDef; }
        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            var innerIndent = MutateCSharp.Schemata124.ReplaceBinExprOp_2(5L, indentBefore, formatter.SpaceTab);
            var allTokens = ModuleDef.OwnedTokens.ToList();
            if (allTokens.Any())
            {
                formatter.SetOpeningIndentedRegion(allTokens[MutateCSharp.Schemata124.ReplaceNumericConstant_3(14L, 0)], indentBefore);
            }

            foreach (var token in allTokens)
            {
                switch (token.val)
                {
                    case "abstract":
                    case "module":
                        {
                            break;
                        }

                        break;
                    case "{":
                        {
                            if (TokenNewIndentCollector.IsFollowedByNewline(token))
                            {
                                formatter.SetOpeningIndentedRegion(token, indentBefore);
                            }
                            else
                            {
                                formatter.SetAlign(indentBefore, token, out innerIndent, out _);
                            }

                            break;
                        }

                        break;
                    case "}":
                        {
                            formatter.SetClosingIndentedRegionAligned(token, innerIndent, indentBefore);
                            break;
                        }

                        break;
                }
            }

            foreach (var decl2 in ModuleDef.TopLevelDecls)
            {
                formatter.SetDeclIndentation(decl2, innerIndent);
            }

            foreach (var decl2 in ModuleDef.PrefixNamedModules)
            {
                formatter.SetDeclIndentation(decl2.Module, innerIndent);
            }

            return MutateCSharp.Schemata124.ReplaceBooleanConstant_1(18L, true);
        }

        public ModuleSignature Resolve(ModuleResolver resolver, CompilationData compilation)
        {
            // The declaration is a literal module, so it has members and such that we need
            // to resolve. First we do refinement transformation. Then we construct the signature
            // of the module. This is the public, externally visible signature. Then we add in
            // everything that the system defines, as well as any "import" (i.e. "opened" modules)
            // directives (currently not supported, but this is where we would do it.) This signature,
            // which is only used while resolving the members of the module is stored in the (basically)
            // global variable moduleInfo. Then the signatures of the module members are resolved, followed
            // by the bodies.
            var module = ModuleDef;

            var errorCount = resolver.reporter.ErrorCount;
            if (MutateCSharp.Schemata124.ReplaceBinExprOp_4(19L, module.Implements, null))
            {
                var md = module.Implements.Target.ResolveTarget(resolver.reporter);
                module.Implements.Target.SetTarget(md); // If module is not found, md is null and an error message has been emitted
            }

            var rewriters = RewriterCollection.GetRewriters(resolver.Reporter, resolver.ProgramResolver.Program);
            foreach (var rewriter in rewriters)
            {
                rewriter.PreResolve(module);
            }

            Signature = module.RegisterTopLevelDecls(resolver, MutateCSharp.Schemata124.ReplaceBooleanConstant_1(20L, true));
            Signature.Refines = module.Implements?.Target.Sig;

            var sig = Signature;
            // set up environment
            var preResolveErrorCount = resolver.reporter.ErrorCount;

            resolver.ResolveModuleExport(this, sig);
            var good = module.Resolve(sig, resolver);

            if (MutateCSharp.Schemata124.ReplaceBinExprOp_6(26L, () => good, () => MutateCSharp.Schemata124.ReplaceBinExprOp_5(21L, resolver.reporter.ErrorCount, preResolveErrorCount)))
            {
                // Check that the module export gives a self-contained view of the module.
                resolver.CheckModuleExportConsistency(compilation, module);
            }

            var tempVis = new VisibilityScope();
            tempVis.Augment(sig.VisibilityScope);
            tempVis.Augment(resolver.ProgramResolver.SystemModuleManager.systemNameInfo.VisibilityScope);
            Type.PushScope(tempVis);

            foreach (var rewriter in rewriters)
            {
                if (MutateCSharp.Schemata124.ReplaceBinExprOp_8(37L, () => !good, () => MutateCSharp.Schemata124.ReplaceBinExprOp_7(32L, resolver.reporter.ErrorCount, preResolveErrorCount)))
                {
                    break;
                }

                rewriter.PostResolveIntermediate(module);
            }

            if (MutateCSharp.Schemata124.ReplaceBinExprOp_6(48L, () => good, () => MutateCSharp.Schemata124.ReplaceBinExprOp_5(43L, resolver.reporter.ErrorCount, errorCount)))
            {
                module.SuccessfullyResolved = MutateCSharp.Schemata124.ReplaceBooleanConstant_1(54L, true);
            }

            Type.PopScope(tempVis);

            if (MutateCSharp.Schemata124.ReplaceBinExprOp_8(55L, () => !good, () => resolver.reporter.HasErrors))
            {
                return sig;
            }

            Type.PushScope(tempVis);
            resolver.ComputeIsRecursiveBit(compilation, module, rewriters);
            resolver.FillInDecreasesClauses(module);
            foreach (var iter in module.TopLevelDecls.OfType<IteratorDecl>())
            {
                resolver.reporter.Info(MessageSource.Resolver, iter.tok, Printer.IteratorClassToString(resolver.Reporter.Options, iter));
            }

            foreach (var rewriter in rewriters)
            {
                rewriter.PostDecreasesResolve(module);
            }

            resolver.FillInAdditionalInformation(module);
            FuelAdjustment.CheckForFuelAdjustments(resolver.reporter, module);

            foreach (var rewriter in rewriters)
            {
                rewriter.PostResolve(module);
            }

            Type.PopScope(tempVis);
            return sig;
        }

        public void BindModuleNames(ProgramResolver resolver, ModuleBindings parentBindings)
        {
            Contract.Requires(this != null);
            Contract.Requires(parentBindings != null);

            var bindings = ModuleDef.BindModuleNames(resolver, parentBindings);
            if (!parentBindings.BindName(Name, this, bindings))
            {
                parentBindings.TryLookup(Name, out var otherModule);
                resolver.Reporter.Error(MessageSource.Resolver, new NestedToken(tok, otherModule.tok), MutateCSharp.Schemata124.ReplaceStringConstant_9(61L, "Duplicate module name: {0}"), Name);
            }
        }

        public IEnumerable<ISymbol> ChildSymbols => ModuleDef.ChildSymbols;
    }
}