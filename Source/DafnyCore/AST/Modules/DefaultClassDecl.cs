using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata120
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT120");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public class DefaultClassDecl : TopLevelDeclWithMembers, RevealableTypeDecl
    {
        public override string WhatKind => MutateCSharp.Schemata120.ReplaceStringConstant_0(1L, "top-level module declaration");
        public override bool AcceptThis => MutateCSharp.Schemata120.ReplaceBooleanConstant_1(2L, false);

        public TopLevelDecl AsTopLevelDecl => this;
        public TypeDeclSynonymInfo SynonymInfo { get; set; }

        public DefaultClassDecl(ModuleDefinition module, [Captured] List<MemberDecl> members)
          : base(RangeToken.NoToken, new Name(MutateCSharp.Schemata120.ReplaceStringConstant_0(3L, "_default")), module, new List<TypeParameter>(), members, null, MutateCSharp.Schemata120.ReplaceBooleanConstant_1(4L, false), null)
        {
            Contract.Requires(module != null);
            Contract.Requires(cce.NonNullElements(members));
            this.NewSelfSynonym();
        }
    }
}