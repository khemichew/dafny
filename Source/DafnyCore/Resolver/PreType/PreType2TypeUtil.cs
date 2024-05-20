//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

using System.Diagnostics.Contracts;
using System.Collections.Generic;
using JetBrains.Annotations;
namespace MutateCSharp
{
    internal class Schemata416
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT416");
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

        internal static string ReplaceStringConstant_2(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Type> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_6(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static int ReplaceNumericConstant_4(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.DPreType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public static class PreType2TypeUtil
    {
        public static Type PreType2Type(PreType preType, bool allowFutureRefinements, TypeParameter.TPVariance futureRefinements)
        {
            if (allowFutureRefinements)
            {
                return PreType2RefinableType(preType, futureRefinements);
            }
            else
            {
                return PreType2FixedType(preType);
            }

            return default;
        }

        public static Type PreType2FixedType(PreType preType)
        {
            return PreType2TypeCore(preType, MutateCSharp.Schemata416.ReplaceBooleanConstant_0(1L, false), TypeParameter.TPVariance.Co);
        }

        public static Type PreType2RefinableType(PreType preType, TypeParameter.TPVariance futureRefinements)
        {
            var ty = PreType2TypeCore(preType, MutateCSharp.Schemata416.ReplaceBooleanConstant_0(2L, true), futureRefinements);
            switch (futureRefinements)
            {
                case TypeParameter.TPVariance.Co:
                    ty = new BottomTypePlaceholder(ty);
                    break;
                    break;
                default:
                    break;
                    break;
            }

            return new TypeRefinementWrapper(ty);
        }

        /// <summary>
        /// The "futureRefinements" parameter is relevant only if "allowFutureRefinements" is "true".
        /// </summary>
        private static Type PreType2TypeCore(PreType preType, bool allowFutureRefinements, TypeParameter.TPVariance futureRefinements)
        {
            var pt = (DPreType)preType.Normalize(); // all pre-types should have been filled in and resolved to a non-proxy
            if (MutateCSharp.Schemata416.ReplaceBinExprOp_1(3L, pt.PrintablePreType, null))
            {
                pt = pt.PrintablePreType;
            }

            Type ArgumentAsCo(int i)
            {
                return PreType2Type(pt.Arguments[i], MutateCSharp.Schemata416.ReplaceBooleanConstant_0(4L, true), futureRefinements);
            }

            switch (pt.Decl.Name)
            {
                case PreType.TypeNameBool:
                    return Type.Bool;
                    break;
                case PreType.TypeNameChar:
                    return Type.Char;
                    break;
                case PreType.TypeNameInt:
                    return Type.Int;
                    break;
                case PreType.TypeNameReal:
                    return Type.Real;
                    break;
                case PreType.TypeNameORDINAL:
                    return Type.BigOrdinal;
                    break;
                case PreType.TypeNameSet:
                    return new SetType(true, ArgumentAsCo(0));
                    break;
                case PreType.TypeNameIset:
                    return new SetType(false, ArgumentAsCo(0));
                    break;
                case PreType.TypeNameMultiset:
                    return new MultiSetType(ArgumentAsCo(0));
                    break;
                case PreType.TypeNameSeq:
                    return new SeqType(ArgumentAsCo(0));
                    break;
                case PreType.TypeNameMap:
                    return new MapType(true, ArgumentAsCo(0), ArgumentAsCo(1));
                    break;
                case PreType.TypeNameImap:
                    return new MapType(false, ArgumentAsCo(0), ArgumentAsCo(1));
                    break;
                default:
                    break;
                    break;
            }

            var arguments = pt.Arguments.ConvertAll(preType => PreType2RefinableType(preType, futureRefinements));
            if (pt.Decl is ArrowTypeDecl arrowTypeDecl)
            {
                return new ArrowType(pt.Decl.tok, arrowTypeDecl, arguments);
            }
            else if (pt.Decl is ValuetypeDecl valuetypeDecl)
            {
                return valuetypeDecl.CreateType(arguments);
            }
            else if (pt.Decl is ClassLikeDecl { IsReferenceTypeDecl: true })
            {
                return new UserDefinedType(pt.Decl.tok, pt.Decl.Name + MutateCSharp.Schemata416.ReplaceStringConstant_2(5L, "?"), pt.Decl, arguments);
            }
            else
            {
                return new UserDefinedType(pt.Decl.tok, pt.Decl.Name, pt.Decl, arguments);
            }

            return default;
        }

        public static void Combine(Type userSuppliedType, PreType preType, bool allowFutureRefinements)
        {
            var preTypeConverted = PreType2Type(preType, allowFutureRefinements, TypeParameter.TPVariance.Co);
            Combine(userSuppliedType, preTypeConverted);
        }

        /// <summary>
        /// This method combines the respective user-supplied types with the inferred pre-types. It expects that either
        ///     - "types" is null, which represents the case where the types are inferred. In this case, the method returns a new
        ///       list that contains the converted pre-types.
        ///     - "types" is non-null, which represents the case where the user supplied types. In this case, "types" and
        ///       "preTypes" are expected to have the same length. The respective types and pre-types are combined in "types",
        ///       and then "types" is returned.
        /// </summary>
        public static List<Type> Combine([CanBeNull] List<Type> types, List<PreType> preTypes, bool allowFutureRefinements)
        {
            Contract.Requires(types == null || types.Count == preTypes.Count);
            if (MutateCSharp.Schemata416.ReplaceBinExprOp_3(6L, types, null))
            {
                if (allowFutureRefinements)
                {
                    return preTypes.ConvertAll(preType => PreType2RefinableType(preType, TypeParameter.TPVariance.Co));
                }
                else
                {
                    return preTypes.ConvertAll(PreType2FixedType);
                }
            }

            Contract.Assert(types.Count == preTypes.Count);
            for (var i = MutateCSharp.Schemata416.ReplaceNumericConstant_4(7L, 0); MutateCSharp.Schemata416.ReplaceBinExprOp_5(11L, i, types.Count); MutateCSharp.Schemata416.ReplacePostfixUnaryExprOp_6(16L, ref i))
            {
                Combine(types[i], preTypes[i], allowFutureRefinements);
            }
            return types;
        }

        private static void Combine(Type type, Type preTypeConverted)
        {
            Contract.Requires(type != null);
            Contract.Requires(preTypeConverted != null);

            type = type.NormalizeAndAdjustForScope();
            if (type is TypeProxy { T: null } typeProxy)
            {
                typeProxy.T = preTypeConverted;
            }
            else
            {
                // Even if the head type of preTypeConverted is a refinement wrapper, we're going to stick with the user-defined type, so we Normalize() here.
                preTypeConverted = preTypeConverted.Normalize();

                Contract.Assert((type as UserDefinedType)?.ResolvedClass == (preTypeConverted as UserDefinedType)?.ResolvedClass);
                Contract.Assert(type.TypeArgs.Count == preTypeConverted.TypeArgs.Count);
                for (var i = MutateCSharp.Schemata416.ReplaceNumericConstant_4(17L, 0); MutateCSharp.Schemata416.ReplaceBinExprOp_5(21L, i, type.TypeArgs.Count); MutateCSharp.Schemata416.ReplacePostfixUnaryExprOp_6(26L, ref i))
                {
                    // TODO: the following should take variance into consideration
                    Combine(type.TypeArgs[i], preTypeConverted.TypeArgs[i]);
                }
            }
        }

    }
}