using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata192
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT192");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBooleanConstant_4(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_3(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
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

    }
}

namespace Microsoft.Dafny
{
    public class IndDatatypeDecl : DatatypeDecl
    {
        public override string WhatKind
        {
            get { return MutateCSharp.Schemata192.ReplaceStringConstant_0(1L, "datatype"); }
        }

        [FilledInDuringResolution] public DatatypeCtor GroundingCtor; // set during resolution (possibly to null)

        public override DatatypeCtor GetGroundingCtor()
        {
            return GroundingCtor ?? Ctors.FirstOrDefault(ctor => ctor.IsGhost, Ctors[MutateCSharp.Schemata192.ReplaceNumericConstant_1(2L, 0)]);
        }

        private bool[] typeParametersUsedInConstructionByGroundingCtor;

        public bool[] TypeParametersUsedInConstructionByGroundingCtor
        {
            get
            {
                if (typeParametersUsedInConstructionByGroundingCtor == null)
                {
                    typeParametersUsedInConstructionByGroundingCtor = new bool[TypeArgs.Count];
                    for (var i = MutateCSharp.Schemata192.ReplaceNumericConstant_1(6L, 0); MutateCSharp.Schemata192.ReplaceBinExprOp_2(10L, i, typeParametersUsedInConstructionByGroundingCtor.Length); MutateCSharp.Schemata192.ReplacePostfixUnaryExprOp_3(15L, ref i))
                    {
                        typeParametersUsedInConstructionByGroundingCtor[i] = MutateCSharp.Schemata192.ReplaceBooleanConstant_4(16L, true);
                    }
                }
                return typeParametersUsedInConstructionByGroundingCtor;
            }
            set
            {
                typeParametersUsedInConstructionByGroundingCtor = value;
            }
        }

        public enum ES { NotYetComputed, Never, ConsultTypeArguments }
        public ES EqualitySupport = ES.NotYetComputed;

        public IndDatatypeDecl(RangeToken rangeToken, Name name, ModuleDefinition module, List<TypeParameter> typeArgs,
          [Captured] List<DatatypeCtor> ctors, List<Type> parentTraits, List<MemberDecl> members, Attributes attributes, bool isRefining)
          : base(rangeToken, name, module, typeArgs, ctors, parentTraits, members, attributes, isRefining)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(module != null);
            Contract.Requires(cce.NonNullElements(typeArgs));
            Contract.Requires(cce.NonNullElements(ctors));
            Contract.Requires(cce.NonNullElements(members));
            Contract.Requires((isRefining && ctors.Count == 0) || (!isRefining && 1 <= ctors.Count));
        }

        public override bool AcceptThis => MutateCSharp.Schemata192.ReplaceBooleanConstant_4(17L, true);
    }
}