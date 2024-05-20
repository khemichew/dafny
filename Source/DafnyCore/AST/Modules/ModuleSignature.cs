using System;
using System.Collections.Generic;
namespace MutateCSharp
{
    internal class Schemata130
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT130");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public class ModuleSignature
    {
        public VisibilityScope VisibilityScope = null;
        public readonly Dictionary<string, ModuleDecl> ShadowedImportedModules = new();
        public readonly Dictionary<string, TopLevelDecl> TopLevels = new();
        public readonly Dictionary<string, ModuleExportDecl> ExportSets = new();
        public readonly Dictionary<string, Tuple<DatatypeCtor, bool>> Ctors = new();
        public readonly Dictionary<string, MemberDecl> StaticMembers = new();
        public ModuleDefinition ModuleDef = null; // Note: this is null if this signature does not correspond to a specific definition (i.e.
                                                  // it is abstract). Otherwise, it points to that definition.
        public ModuleSignature Refines = null;
        public bool IsAbstract = MutateCSharp.Schemata130.ReplaceBooleanConstant_0(1L, false);
        public ModuleSignature() { }
        public int? ResolvedHash { get; set; }

        // Qualified accesses follow module imports
        public bool FindImport(string name, out ModuleDecl decl)
        {
            if (TopLevels.TryGetValue(name, out var top) && top is ModuleDecl)
            {
                decl = (ModuleDecl)top;
                return MutateCSharp.Schemata130.ReplaceBooleanConstant_0(2L, true);
            }
            else
            {
                decl = null;
                return MutateCSharp.Schemata130.ReplaceBooleanConstant_0(3L, false);
            }

            return default;
        }
    }
}