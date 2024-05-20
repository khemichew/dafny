using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata459
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT459");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
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

    }
}

namespace Microsoft.Dafny
{
    public class ProvideRevealAllRewriter : IRewriter
    {
        public ProvideRevealAllRewriter(ErrorReporter reporter)
          : base(reporter)
        {
            Contract.Requires(reporter != null);
        }

        internal override void PreResolve(ModuleDefinition m)
        {
            var declarations = m.TopLevelDecls;

            foreach (var d in declarations)
            {
                if (d is ModuleExportDecl me)
                {
                    var revealAll = MutateCSharp.Schemata459.ReplaceBinExprOp_0(1L, () => me.RevealAll, () => Reporter.Options.DisableScopes);

                    HashSet<string> explicitlyRevealedTopLevelIDs = null;
                    if (!revealAll)
                    {
                        explicitlyRevealedTopLevelIDs = new HashSet<string>();
                        foreach (var esig in me.Exports)
                        {
                            if (MutateCSharp.Schemata459.ReplaceBinExprOp_1(7L, () => esig.ClassId == null, () => !esig.Opaque))
                            {
                                explicitlyRevealedTopLevelIDs.Add(esig.Id);
                            }
                        }
                    }

                    if (MutateCSharp.Schemata459.ReplaceBinExprOp_0(13L, () => revealAll, () => me.ProvideAll))
                    {
                        foreach (var newt in declarations)
                        {
                            if (!newt.CanBeExported())
                            {
                                continue;
                            }

                            if (newt is not DefaultClassDecl)
                            {
                                me.Exports.Add(new ExportSignature(newt.tok, newt.Name, MutateCSharp.Schemata459.ReplaceBinExprOp_0(19L, () => !revealAll, () => !newt.CanBeRevealed())));
                            }

                            if (newt is TopLevelDeclWithMembers cl)
                            {
                                var newtIsRevealed = MutateCSharp.Schemata459.ReplaceBinExprOp_0(25L, () => revealAll, () => explicitlyRevealedTopLevelIDs.Contains(newt.Name));

                                foreach (var mem in cl.Members)
                                {
                                    var opaque = MutateCSharp.Schemata459.ReplaceBinExprOp_0(31L, () => !revealAll, () => !mem.CanBeRevealed());
                                    if (newt is DefaultClassDecl)
                                    {
                                        // add everything from the default class
                                        me.Exports.Add(new ExportSignature(mem.tok, mem.Name, opaque));
                                    }
                                    else if (MutateCSharp.Schemata459.ReplaceBinExprOp_1(37L, () => mem is Constructor, () => !newtIsRevealed))
                                    {
                                        // "provides *" does not pick up class constructors, unless the class is to be revealed
                                    }
                                    else if (opaque && mem is Field field && !(mem is ConstantField) && !newtIsRevealed)
                                    {
                                        // "provides *" does not pick up mutable fields, unless the class is to be revealed
                                    }
                                    else
                                    {
                                        me.Exports.Add(new ExportSignature(cl.tok, cl.Name, mem.tok, mem.Name, opaque));
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}