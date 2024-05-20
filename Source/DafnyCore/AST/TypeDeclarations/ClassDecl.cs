using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata186
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT186");
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
    public class ClassDecl : ClassLikeDecl, IHasDocstring
    {
        public override string WhatKind => MutateCSharp.Schemata186.ReplaceStringConstant_0(1L, "class");
        public override bool IsReferenceTypeDecl => MutateCSharp.Schemata186.ReplaceBooleanConstant_1(2L, true);
        public override bool AcceptThis => MutateCSharp.Schemata186.ReplaceBooleanConstant_1(3L, true);

        [FilledInDuringResolution] public bool HasConstructor;  // filled in (early) during resolution; true iff there exists a member that is a Constructor
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(cce.NonNullElements(Members));
            Contract.Invariant(ParentTraits != null);
        }

        public ClassDecl(RangeToken rangeToken, Name name, ModuleDefinition module,
          List<TypeParameter> typeArgs, [Captured] List<MemberDecl> members, Attributes attributes, bool isRefining, List<Type>/*?*/ traits)
          : base(rangeToken, name, module, typeArgs, members, attributes, isRefining, traits)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(module != null);
            Contract.Requires(cce.NonNullElements(typeArgs));
            Contract.Requires(cce.NonNullElements(members));
            NonNullTypeDecl = new NonNullTypeDecl(this);
            this.NewSelfSynonym();
        }
    }
}