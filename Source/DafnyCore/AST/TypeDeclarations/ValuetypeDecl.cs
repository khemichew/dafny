using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata204
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT204");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_2(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.TypeParameter.TPVarianceSyntax> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_6(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 + argument2;
        }

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
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

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_5(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static int ReplaceNumericConstant_3(long mutantId, int argument1)
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

    /// <summary>
    /// The "ValuetypeDecl" class models the built-in value types (like bool, int, set, and seq.
    /// Its primary function is to hold the formal type parameters and built-in members of these types.
    /// </summary>
    public class ValuetypeDecl : TopLevelDeclWithMembers
    {
        public override string WhatKind
        {
            get { return MutateCSharp.Schemata204.ReplaceStringConstant_0(1L, "type"); }
        }

        readonly Func<Type, bool> typeTester;
        readonly Func<List<Type>, Type>/*?*/ typeCreator;

        public override bool AcceptThis => MutateCSharp.Schemata204.ReplaceBooleanConstant_1(2L, true);

        public ValuetypeDecl(string name, ModuleDefinition module, Func<Type, bool> typeTester, Func<List<Type>, Type> typeCreator /*?*/)
          : base(RangeToken.NoToken, new Name(name), module, new List<TypeParameter>(), new List<MemberDecl>(), null, MutateCSharp.Schemata204.ReplaceBooleanConstant_1(3L, false), null)
        {
            Contract.Requires(name != null);
            Contract.Requires(module != null);
            Contract.Requires(typeTester != null);
            this.typeTester = typeTester;
            this.typeCreator = typeCreator;
        }

        public ValuetypeDecl(string name, ModuleDefinition module, List<TypeParameter.TPVarianceSyntax> typeParameterVariance,
          Func<Type, bool> typeTester, Func<List<Type>, Type>/*?*/ typeCreator)
          : this(name, module, typeTester, typeCreator)
        {
            Contract.Requires(name != null);
            Contract.Requires(module != null);
            Contract.Requires(typeTester != null);
            // fill in the type parameters
            if (MutateCSharp.Schemata204.ReplaceBinExprOp_2(4L, typeParameterVariance, null))
            {
                for (int i = MutateCSharp.Schemata204.ReplaceNumericConstant_3(5L, 0); MutateCSharp.Schemata204.ReplaceBinExprOp_4(9L, i, typeParameterVariance.Count); MutateCSharp.Schemata204.ReplacePostfixUnaryExprOp_5(14L, ref i))
                {
                    var variance = typeParameterVariance[i];
                    var tp = new TypeParameter(RangeToken.NoToken, new Name(((char)(MutateCSharp.Schemata204.ReplaceBinExprOp_6(15L, 'T', i))).ToString()), variance)
                    {
                        Parent = this,
                        PositionalIndex = i
                    };
                    TypeArgs.Add(tp);
                }
            }
        }

        public ValuetypeDecl(string name, ModuleDefinition module, List<TypeParameter> typeParameters,
          List<MemberDecl> members, Attributes attributes, Func<Type, bool> typeTester, Func<List<Type>, Type> /*?*/ typeCreator)
          : base(RangeToken.NoToken, new Name(name), module, typeParameters, members, attributes, MutateCSharp.Schemata204.ReplaceBooleanConstant_1(24L, false))
        {
            this.typeTester = typeTester;
            this.typeCreator = typeCreator;
        }

        public bool IsThisType(Type t)
        {
            Contract.Assert(t != null);
            return typeTester(t);
        }

        public Type CreateType(List<Type> typeArgs)
        {
            Contract.Requires(typeArgs != null);
            Contract.Requires(typeArgs.Count == TypeArgs.Count);
            Contract.Assume(typeCreator != null);  // can only call CreateType for a ValuetypeDecl with a type creator (this is up to the caller to ensure)
            return typeCreator(typeArgs);
        }
    }
}