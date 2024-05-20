using System.Collections.Generic;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
namespace MutateCSharp
{
    internal class Schemata202
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT202");
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

    }
}

namespace Microsoft.Dafny
{
    public class TypeSynonymDecl : TypeSynonymDeclBase, RevealableTypeDecl
    {
        public override string WhatKind => MutateCSharp.Schemata202.ReplaceStringConstant_0(1L, "type synonym");

        public TypeSynonymDecl(RangeToken rangeToken, Name name, TypeParameter.TypeParameterCharacteristics characteristics, List<TypeParameter> typeArgs, ModuleDefinition module, Type rhs, Attributes attributes)
          : base(rangeToken, name, characteristics, typeArgs, module, rhs, attributes)
        {
            this.NewSelfSynonym();
        }
        public TopLevelDecl AsTopLevelDecl => this;
        public TypeDeclSynonymInfo SynonymInfo { get; set; }

        public override SymbolKind Kind => SymbolKind.Class;
        public override string GetDescription(DafnyOptions options)
        {
            return MutateCSharp.Schemata202.ReplaceStringConstant_0(2L, "type synonym");
        }
    }

    public class InternalTypeSynonymDecl : TypeSynonymDeclBase
    {
        public override string WhatKind
        {
            get { return MutateCSharp.Schemata202.ReplaceStringConstant_0(3L, "export-provided type"); }
        }

        public InternalTypeSynonymDecl(RangeToken rangeToken, Name name, TypeParameter.TypeParameterCharacteristics characteristics, List<TypeParameter> typeArgs, ModuleDefinition module, Type rhs, Attributes attributes)
          : base(rangeToken, name, characteristics, typeArgs, module, rhs, attributes)
        {
        }

        public override SymbolKind Kind => SymbolKind.Class;
        public override string GetDescription(DafnyOptions options)
        {
            return MutateCSharp.Schemata202.ReplaceStringConstant_0(4L, "type synonym");
        }
    }
}