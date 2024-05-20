using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata129
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT129");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.ModuleDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_3(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static int ReplacePrefixUnaryExprOp_2(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return ++argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return +argument1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return ~argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return --argument1; }
            return ++argument1;
        }

        internal static int ReplacePostfixUnaryExprOp_5(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.ModuleSignature argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class ModuleQualifiedId : Node, IHasUsages
    {
        public readonly List<Name> Path; // Path != null && Path.Count > 0

        // The following are filled in during resolution
        // Note that the root (first path segment) is resolved initially,
        // as it is needed to determine dependency relationships.
        // Then later the rest of the path is resolved, at which point all of the
        // ids in the path have been fully resolved
        // Note also that the resolution of the root depends on the syntactice location
        // of the qualified id; the resolution of subsequent ids depends on the
        // default export set of the previous id.
        [FilledInDuringResolution]
        public ModuleDecl Root { get; set; }
        [FilledInDuringResolution]
        public ModuleDecl Decl { get; private set; }
        [FilledInDuringResolution]
        public ModuleDefinition Def { get; private set; }
        [FilledInDuringResolution]
        public ModuleSignature Sig { get; set; }

        public ModuleQualifiedId(List<Name> path)
        {
            Contract.Assert(path != null && path.Count > 0);
            Path = path; // note that the list is aliased -- not to be modified after construction
        }

        public ModuleQualifiedId(Cloner cloner, ModuleQualifiedId original)
        {
            Path = original.Path.Select(n => n.Clone(cloner)).ToList();
            if (cloner.CloneResolvedFields)
            {
                Root = original.Root;
            }
        }

        public string RootName()
        {
            return Path[MutateCSharp.Schemata129.ReplaceNumericConstant_0(1L, 0)].Value;
        }

        public IToken RootToken()
        {
            return Path[MutateCSharp.Schemata129.ReplaceNumericConstant_0(5L, 0)].StartToken;
        }

        public override string ToString()
        {
            string s = Path[MutateCSharp.Schemata129.ReplaceNumericConstant_0(9L, 0)].Value;
            for (int i = MutateCSharp.Schemata129.ReplaceNumericConstant_0(13L, 1); MutateCSharp.Schemata129.ReplaceBinExprOp_1(17L, i, Path.Count); MutateCSharp.Schemata129.ReplacePrefixUnaryExprOp_2(22L, ref i))
            {
                s = s + MutateCSharp.Schemata129.ReplaceStringConstant_3(26L, ".") + Path[i].Value;
            }

            return s;
        }

        public void SetTarget(ModuleDecl m)
        {
            if (MutateCSharp.Schemata129.ReplaceBinExprOp_4(27L, m, null))
            {
                Decl = null;
                Def = null;
                Sig = null;
            }
            else
            {
                Decl = m;
                Def = m.Signature.ModuleDef;
                Sig = m.Signature;
            }
        }

        public override IToken Tok => Path.Last().Tok;
        public override IEnumerable<INode> Children => Enumerable.Empty<Node>();
        public override IEnumerable<INode> PreResolveChildren => Children;

        public override RangeToken RangeToken { get => new(Path.First().StartToken, Path.Last().EndToken);
    set => throw new NotSupportedException(); }

        public IToken NameToken => Path.Last().StartToken;

        public IEnumerable<IDeclarationOrUsage> GetResolvedDeclarations()
        {
            // Normally the target should already have been resolved, but in certain conditions like an unused alias module decl,
            // Decl might not be set yet so we need to resolve it here.
            return Enumerable.Repeat(ResolveTarget(new ErrorReporterSink(DafnyOptions.Default)), MutateCSharp.Schemata129.ReplaceNumericConstant_0(28L, 1));
        }

        /// <summary>
        /// Returns the resolved Module declaration corresponding to the qualified module id
        /// Requires the root to have been resolved
        /// Issues an error and returns null if the path is not valid
        /// </summary>
        public ModuleDecl ResolveTarget(ErrorReporter reporter)
        {

            Contract.Requires(this != null);
            Contract.Requires(Path.Count > 0);

            if (MutateCSharp.Schemata129.ReplaceBinExprOp_4(32L, Decl, null))
            {
                Decl = ResolveTargetUncached(reporter);
            }

            return Decl;
        }

        private ModuleDecl ResolveTargetUncached(ErrorReporter reporter)
        {
            if (MutateCSharp.Schemata129.ReplaceBinExprOp_4(33L, Root, null))
            {
                return null;
            }

            var decl = Root;
            for (int k = MutateCSharp.Schemata129.ReplaceNumericConstant_0(34L, 1); MutateCSharp.Schemata129.ReplaceBinExprOp_1(38L, k, Path.Count); MutateCSharp.Schemata129.ReplacePostfixUnaryExprOp_5(43L, ref k))
            {
                ModuleSignature p;
                if (decl is LiteralModuleDecl literalModuleDecl)
                {
                    p = literalModuleDecl.DefaultExport;
                    if (MutateCSharp.Schemata129.ReplaceBinExprOp_6(44L, p, null))
                    {
                        reporter.Error(MessageSource.Resolver, Path[k],
                          ProgramResolver.ModuleNotFoundErrorMessage(k, Path, $" because {decl.Name} does not have a default export"));
                        return null;
                    }
                }
                else
                {
                    p = decl.Signature;
                }

                var tld = p.TopLevels.GetValueOrDefault(Path[k].Value, null);
                if (tld is not ModuleDecl dd)
                {
                    if (MutateCSharp.Schemata129.ReplaceBinExprOp_7(45L, decl.Signature.ModuleDef, null))
                    {
                        reporter.Error(MessageSource.Resolver, Path[k],
                          ProgramResolver.ModuleNotFoundErrorMessage(k, Path, MutateCSharp.Schemata129.ReplaceStringConstant_3(46L, " because of previous error")));
                    }
                    else
                    {
                        reporter.Error(MessageSource.Resolver, Path[k], ProgramResolver.ModuleNotFoundErrorMessage(k, Path));
                    }

                    return null;
                }

                // Any aliases along the qualified path ought to be already resolved,
                // else the modules are not being resolved in the right order
                if (dd is AliasModuleDecl amd)
                {
                    Contract.Assert(amd.Signature != null);
                }

                decl = dd;
            }

            return decl;
        }
    }
}