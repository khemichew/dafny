using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata133
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT133");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_2(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.IToken argument1, Microsoft.Dafny.Token argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.CommonOptionBag.SystemModuleMode argument1, Microsoft.Dafny.CommonOptionBag.SystemModuleMode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_5(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, System.Collections.Generic.ISet<System.Uri> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.CommonOptionBag.SystemModuleMode argument1, Microsoft.Dafny.CommonOptionBag.SystemModuleMode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public static class ShouldCompileOrVerify
    {

        public static bool ShouldCompile(this ModuleDefinition module, CompilationData program)
        {
            if (MutateCSharp.Schemata133.ReplaceBinExprOp_0(1L, program.UrisToCompile, null))
            {
                program.UrisToCompile = ComputeUrisToCompile(program);
            }

            if (MutateCSharp.Schemata133.ReplaceBinExprOp_2(3L, module.FullName, MutateCSharp.Schemata133.ReplaceStringConstant_1(2L, "_System")))
            {
                return MutateCSharp.Schemata133.ReplaceBinExprOp_3(4L, program.Options.SystemModuleTranslationMode, CommonOptionBag.SystemModuleMode.Omit);
            }
            if (MutateCSharp.Schemata133.ReplaceBinExprOp_4(5L, program.Options.SystemModuleTranslationMode, CommonOptionBag.SystemModuleMode.OmitAllOtherModules))
            {
                return MutateCSharp.Schemata133.ReplaceBooleanConstant_5(6L, false);
            }

            if (module is DefaultModuleDefinition)
            {
                // If things from precompiled files live in the default module, that can cause downstream compilation issues:
                // https://github.com/dafny-lang/dafny/issues/4009
                return MutateCSharp.Schemata133.ReplaceBooleanConstant_5(7L, true);
            }

            if (MutateCSharp.Schemata133.ReplaceBinExprOp_6(9L, program.Options.Backend?.TargetId, MutateCSharp.Schemata133.ReplaceStringConstant_1(8L, "lib")))
            {
                if (!ProgramResolver.ShouldCompile(module))
                {
                    return MutateCSharp.Schemata133.ReplaceBooleanConstant_5(10L, false);
                }
            }

            return program.UrisToCompile.Contains(module.Tok.Uri);
        }

        public static bool ShouldVerify(this INode declaration, CompilationData compilation)
        {
            if (MutateCSharp.Schemata133.ReplaceBinExprOp_7(11L, declaration.Tok, Token.NoToken))
            {
                // Required for DefaultModuleDefinition.
                return MutateCSharp.Schemata133.ReplaceBooleanConstant_5(12L, true);
            }
            if (MutateCSharp.Schemata133.ReplaceBinExprOp_0(13L, compilation.UrisToVerify, null))
            {
                compilation.UrisToVerify = ComputeUrisToVerify(compilation);
            }
            if (!compilation.UrisToVerify.Contains(declaration.Tok.Uri))
            {
                return MutateCSharp.Schemata133.ReplaceBooleanConstant_5(14L, false);
            }

            if (compilation.Options.VerifyAllModules)
            {
                return MutateCSharp.Schemata133.ReplaceBooleanConstant_5(15L, true);
            }

            return !declaration.Tok.FromIncludeDirective(compilation);
        }

        public static bool FromIncludeDirective(this IToken token, CompilationData outerModule)
        {
            if (token is RefinementToken)
            {
                return MutateCSharp.Schemata133.ReplaceBooleanConstant_5(16L, false);
            }

            if (MutateCSharp.Schemata133.ReplaceBinExprOp_7(17L, token, Token.NoToken))
            {
                return MutateCSharp.Schemata133.ReplaceBooleanConstant_5(18L, false);
            }

            var files = outerModule.RootSourceUris;
            if (files.Contains(token.Uri))
            {
                return MutateCSharp.Schemata133.ReplaceBooleanConstant_5(19L, false);
            }

            return MutateCSharp.Schemata133.ReplaceBooleanConstant_5(20L, true);
        }

        public static bool FromIncludeDirective(this IToken token, Program program)
        {
            return token.FromIncludeDirective(program.Compilation);
        }

        private static ISet<Uri> ComputeUrisToCompile(CompilationData program)
        {
            var compiledRoots = program.AlreadyCompiledRoots;
            return GetReachableUris(program, compiledRoots);
        }

        private static ISet<Uri> ComputeUrisToVerify(CompilationData program)
        {
            var verifiedRoots = program.AlreadyVerifiedRoots;
            return GetReachableUris(program, verifiedRoots);
        }

        private static ISet<Uri> GetReachableUris(CompilationData compilation, ISet<Uri> stopUris)
        {
            var edges = compilation.Includes.GroupBy(i => i.IncluderFilename)
              .ToDictionary(g => g.Key, g => g.Select(x => x.IncludedFilename).ToList());

            ISet<Uri> Visit(Stack<Uri> roots, ISet<Uri> excluded)
            {
                var toVisit = roots;

                var visited = new HashSet<Uri>();

                while (toVisit.Any())
                {
                    var uri = toVisit.Pop();
                    if (excluded.Contains(uri))
                    {
                        continue;
                    }

                    if (!visited.Add(uri))
                    {
                        continue;
                    }

                    foreach (var included in edges.GetOrDefault(uri, Enumerable.Empty<Uri>))
                    {
                        toVisit.Push(included);
                    }
                }

                return visited;
            }

            var excluded = Visit(new Stack<Uri>(stopUris), new HashSet<Uri>());

            return Visit(new Stack<Uri>(compilation.RootSourceUris), excluded);
        }

    }
}