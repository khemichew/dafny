using System.Collections.Generic;
namespace MutateCSharp
{
    internal class Schemata201
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT201");
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
    public class TypeDeclSynonymInfo
    {
        public readonly InternalTypeSynonymDecl SelfSynonymDecl;

        public TypeDeclSynonymInfo(TopLevelDecl d)
        {
            var thisType = UserDefinedType.FromTopLevelDecl(d.Tok, d);
            SelfSynonymDecl = new InternalTypeSynonymDecl(d.RangeToken, d.NameNode, TypeParameter.GetExplicitCharacteristics(d),
              d.TypeArgs, d.EnclosingModuleDefinition, thisType, d.Attributes);
            SelfSynonymDecl.InheritVisibility(d, MutateCSharp.Schemata201.ReplaceBooleanConstant_0(1L, false));
        }

        public UserDefinedType SelfSynonym(List<Type> args, Expression /*?*/ namePath = null)
        {
            return new UserDefinedType(SelfSynonymDecl.Tok, SelfSynonymDecl.Name, SelfSynonymDecl, args, namePath);
        }
    }
}