//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata429
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT429");
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

        internal static string ReplaceStringConstant_2(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_1(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static int ReplaceNumericConstant_0(long mutantId, int argument1)
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
    public class TypeRefinementWrapper : TypeProxy
    {
        private static int count = MutateCSharp.Schemata429.ReplaceNumericConstant_0(1L, 0);
        public readonly int UniqueId = MutateCSharp.Schemata429.ReplacePostfixUnaryExprOp_1(5L, ref count);
        public TypeRefinementWrapper(Type type) : base()
        {
            T = type;
        }

        public bool IsBottomType => T is BottomTypePlaceholder;

        public override string TypeName(DafnyOptions options, ModuleDefinition context, bool parseAble)
        {
            var baseName = base.TypeName(options, context, parseAble);
            if (options.Get(CommonOptionBag.NewTypeInferenceDebug))
            {
                return $"/*%{UniqueId}*/{baseName}";
            }
            else
            {
                return baseName;
            }

            return default;
        }

        /// <summary>
        /// Normalize, but don't skip over any TypeRefinementWrapper
        /// </summary>
        public static Type NormalizeSansRefinementWrappers(Type ty)
        {
            while (ty is not TypeRefinementWrapper)
            {
                if (ty is TypeProxy { T: { } proxyFor })
                {
                    ty = proxyFor;
                }
                else
                {
                    break;
                }
            }
            return ty;
        }

        public static Type NormalizeSansBottom(Expression expr)
        {
            return NormalizeSansBottom(expr.UnnormalizedType);
        }

        public static Type NormalizeSansBottom(IVariable variable)
        {
            return NormalizeSansBottom(variable.UnnormalizedType);
        }

        public static Type NormalizeSansBottom(Type unnormalizedType)
        {
            var normalizedType = TypeRefinementWrapper.NormalizeSansRefinementWrappers(unnormalizedType);
            return (normalizedType as TypeRefinementWrapper)?.T ?? normalizedType;
        }

        public static string ToStringShowingWrapper(Type type)
        {
            type = NormalizeSansRefinementWrappers(type);
            if (type is TypeRefinementWrapper utp)
            {
                return $"%{utp.UniqueId}";
            }
            if (type is BasicType)
            {
                return type.ToString();
            }
            if (type.AsArrowType is { } arrowType)
            {
                string arrow = type is ArrowType
                  ? MutateCSharp.Schemata429.ReplaceStringConstant_2(6L, "~>"
          ) : type is UserDefinedType userDefinedType
                    ? ArrowType.IsPartialArrowTypeName(userDefinedType.Name)
                      ? MutateCSharp.Schemata429.ReplaceStringConstant_2(7L, "-->"
          ) : ArrowType.IsTotalArrowTypeName(userDefinedType.Name)
                        ? MutateCSharp.Schemata429.ReplaceStringConstant_2(8L, "->"
          ) : null
                    : null;
                if (arrow != null)
                {
                    return $"({arrowType.Args.Comma(ToStringShowingWrapper)}) {arrow} {ToStringShowingWrapper(arrowType.Result)}";
                }
            }
            string headName;
            if (type is CollectionType collectionType)
            {
                headName = collectionType.CollectionTypeName;
            }
            else if (type is UserDefinedType udt)
            {
                headName = udt.Name;
            }
            else
            {
                Contract.Assert(type.TypeArgs.Count == 0);
                headName = type.ToString();
            }
            if (MutateCSharp.Schemata429.ReplaceBinExprOp_3(13L, type.TypeArgs.Count, MutateCSharp.Schemata429.ReplaceNumericConstant_0(9L, 0)))
            {
                return headName;
            }
            return $"{headName}<{type.TypeArgs.Comma(ToStringShowingWrapper)}>";
        }

        public static string ToStringAsBottom(Type type)
        {
            if (type is BottomTypePlaceholder)
            {
                return MutateCSharp.Schemata429.ReplaceStringConstant_2(18L, "\\bot");
            }
            type = NormalizeSansRefinementWrappers(type);
            if (type is TypeRefinementWrapper { IsBottomType: true })
            {
                return MutateCSharp.Schemata429.ReplaceStringConstant_2(19L, "\\bot");
            }
            else
            {
                return type.ToString();
            }

            return default;
        }

        public static bool NormalizesToBottom(Type type)
        {
            if (type is BottomTypePlaceholder)
            {
                return MutateCSharp.Schemata429.ReplaceBooleanConstant_4(20L, true);
            }
            while (MutateCSharp.Schemata429.ReplaceBooleanConstant_4(21L, true))
            {
                type = NormalizeSansRefinementWrappers(type);
                if (type is TypeRefinementWrapper updatableTypeProxy)
                {
                    if (updatableTypeProxy.IsBottomType)
                    {
                        return MutateCSharp.Schemata429.ReplaceBooleanConstant_4(22L, true);
                    }
                    type = updatableTypeProxy.T;
                }
                else
                {
                    return MutateCSharp.Schemata429.ReplaceBooleanConstant_4(23L, false);
                }
            }

            return default;
        }
    }

    public class BottomTypePlaceholder : TypeProxy
    {
        public BottomTypePlaceholder(Type baseType)
        {
            T = baseType;
        }

        public override string TypeName(DafnyOptions options, ModuleDefinition context, bool parseAble)
        {
            var baseName = base.TypeName(options, context, parseAble);
            if (options.Get(CommonOptionBag.NewTypeInferenceDebug))
            {
                return $"/*\\bot*/{baseName}";
            }
            else
            {
                return baseName;
            }

            return default;
        }
    }
}
