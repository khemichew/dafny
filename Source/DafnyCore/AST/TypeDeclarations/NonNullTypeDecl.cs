using System.Collections.Generic;
using System.Diagnostics.Contracts;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
namespace MutateCSharp
{
    internal class Schemata195
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT195");
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

        internal static int ReplaceNumericConstant_1(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class NonNullTypeDecl : SubsetTypeDecl
    {
        public override string WhatKind => MutateCSharp.Schemata195.ReplaceStringConstant_0(1L, "non-null type");
        public readonly ClassLikeDecl Class;

        /// <summary>
        /// The public constructor is NonNullTypeDecl(ClassDecl cl). The rest is pretty crazy: There are stages of "this"-constructor calls
        /// in order to build values that depend on previously computed parameters.
        /// </summary>
        public NonNullTypeDecl(ClassLikeDecl cl)
          : this(cl, cl.TypeArgs.ConvertAll(tp => new TypeParameter(tp.RangeToken, tp.NameNode, tp.VarianceSyntax, tp.Characteristics)))
        {
            Contract.Requires(cl != null);
        }

        private NonNullTypeDecl(ClassLikeDecl cl, List<TypeParameter> tps)
          : this(cl, tps,
            new BoundVar(cl.Tok, MutateCSharp.Schemata195.ReplaceStringConstant_0(2L, "c"), new UserDefinedType(cl.Tok, cl.Name + MutateCSharp.Schemata195.ReplaceStringConstant_0(3L, "?"), MutateCSharp.Schemata195.ReplaceBinExprOp_2(8L, tps.Count, MutateCSharp.Schemata195.ReplaceNumericConstant_1(4L, 0)) ? null : tps.ConvertAll(tp => (Type)new UserDefinedType(tp)))))
        {
            Contract.Requires(cl != null);
            Contract.Requires(tps != null);
        }

        private NonNullTypeDecl(ClassLikeDecl cl, List<TypeParameter> tps, BoundVar id)
          : base(cl.RangeToken, cl.NameNode, new TypeParameter.TypeParameterCharacteristics(), tps, cl.EnclosingModuleDefinition, id,
            new BinaryExpr(cl.Tok, BinaryExpr.Opcode.Neq, new IdentifierExpr(cl.Tok, id), new LiteralExpr(cl.Tok)),
            SubsetTypeDecl.WKind.Special, null, SystemModuleManager.AxiomAttribute())
        {
            Contract.Requires(cl != null);
            Contract.Requires(tps != null);
            Contract.Requires(id != null);
            Class = cl;
        }

        public override List<Type> ParentTypes(List<Type> typeArgs)
        {
            List<Type> result = new List<Type>(base.ParentTypes(typeArgs));

            foreach (var rhsParentType in Class.ParentTypes(typeArgs))
            {
                var rhsParentUdt = (UserDefinedType)rhsParentType; // all parent types of .Class are expected to be possibly-null class types
                Contract.Assert(rhsParentUdt.ResolvedClass is TraitDecl);
                result.Add(UserDefinedType.CreateNonNullTypeIfReferenceType(rhsParentUdt));
            }

            return result;
        }

        public override SymbolKind Kind => Class.Kind;

        public override string GetDescription(DafnyOptions options)
        {
            return Class.GetDescription(options);
        }
    }
}