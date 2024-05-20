using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata207
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT207");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceNumericConstant_6(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_10(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.Type.AutoInitInfo argument1, Microsoft.Dafny.Type.AutoInitInfo argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.TypeParameter.EqualitySupportValue argument1, Microsoft.Dafny.TypeParameter.EqualitySupportValue argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_4(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.TypeParameter.EqualitySupportValue argument1, Microsoft.Dafny.TypeParameter.EqualitySupportValue argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() && argument2();
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.Type.AutoInitInfo argument1, Microsoft.Dafny.Type.AutoInitInfo argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class TypeParameter : TopLevelDecl
    {
        public interface ParentType
        {
            string FullName { get; }
        }

        public override string WhatKind => MutateCSharp.Schemata207.ReplaceStringConstant_0(1L, "type parameter");

        ParentType parent;
        public ParentType Parent
        {
            get
            {
                return parent;
            }
            set
            {
                Contract.Requires(Parent == null);  // set it only once
                Contract.Requires(value != null);
                parent = value;
            }
        }

        public override string SanitizedName
        {
            get
            {
                if (sanitizedName == null)
                {
                    var name = Name;
                    if (MutateCSharp.Schemata207.ReplaceBinExprOp_1(3L, () => parent is MemberDecl, () => !name.StartsWith(MutateCSharp.Schemata207.ReplaceStringConstant_0(2L, "_"))))
                    {
                        // prepend "_" to type parameters of functions and methods, to ensure they don't clash with type parameters of the enclosing type
                        name = MutateCSharp.Schemata207.ReplaceStringConstant_0(9L, "_") + name;
                    }
                    sanitizedName = NonglobalVariable.SanitizeName(name);
                }
                return sanitizedName;
            }
        }

        public override string GetCompileName(DafnyOptions options) => SanitizedName;

        /// <summary>
        /// NonVariant_Strict     (default) - non-variant, no uses left of an arrow
        /// NonVariant_Permissive    !      - non-variant
        /// Covariant_Strict         +      - co-variant, no uses left of an arrow
        /// Covariant_Permissive     *      - co-variant
        /// Contravariant            -      - contra-variant
        /// </summary>
        public enum TPVarianceSyntax { NonVariant_Strict, NonVariant_Permissive, Covariant_Strict, Covariant_Permissive, Contravariance }
        public static string VarianceString(TPVarianceSyntax varianceSyntax)
        {
            switch (varianceSyntax)
            {
                case TPVarianceSyntax.NonVariant_Strict:
                    return "";
                    break;
                case TPVarianceSyntax.NonVariant_Permissive:
                    return "!";
                    break;
                case TPVarianceSyntax.Covariant_Strict:
                    return "+";
                    break;
                case TPVarianceSyntax.Covariant_Permissive:
                    return "*";
                    break;
                case TPVarianceSyntax.Contravariance:
                    return "-";
                    break;
            }
            return ""; // Should not happen, but compiler complains
        }
        public enum TPVariance { Co, Non, Contra }
        public static TPVariance Negate(TPVariance v)
        {
            switch (v)
            {
                case TPVariance.Co:
                    return TPVariance.Contra;
                    break;
                case TPVariance.Contra:
                    return TPVariance.Co;
                    break;
                default:
                    return v;
                    break;
            }

            return default;
        }
        public static int Direction(TPVariance v)
        {
            switch (v)
            {
                case TPVariance.Co:
                    return 1;
                    break;
                case TPVariance.Contra:
                    return -1;
                    break;
                default:
                    return 0;
                    break;
            }

            return default;
        }
        public TPVarianceSyntax VarianceSyntax;
        public TPVariance Variance
        {
            get
            {
                switch (VarianceSyntax)
                {
                    case TPVarianceSyntax.Covariant_Strict:
                    case TPVarianceSyntax.Covariant_Permissive:
                        return TPVariance.Co;
                        break;
                    case TPVarianceSyntax.NonVariant_Strict:
                    case TPVarianceSyntax.NonVariant_Permissive:
                        return TPVariance.Non;
                        break;
                    case TPVarianceSyntax.Contravariance:
                        return TPVariance.Contra;
                        break;
                    default:
                        Contract.Assert(false);  // unexpected VarianceSyntax
                        throw new cce.UnreachableException();
                        break;
                }

                return default;
            }
        }

        public bool StrictVariance
        {
            get
            {
                switch (VarianceSyntax)
                {
                    case TPVarianceSyntax.Covariant_Strict:
                    case TPVarianceSyntax.NonVariant_Strict:
                        return true;
                        break;
                    case TPVarianceSyntax.Covariant_Permissive:
                    case TPVarianceSyntax.NonVariant_Permissive:
                    case TPVarianceSyntax.Contravariance:
                        return false;
                        break;
                    default:
                        Contract.Assert(false);  // unexpected VarianceSyntax
                        throw new cce.UnreachableException();
                        break;
                }

                return default;
            }
        }

        public static List<TPVariance> Variances(List<TypeParameter> typeParameters, bool negate = false)
        {
            if (negate)
            {
                return typeParameters.ConvertAll(tp => Negate(tp.Variance));
            }
            else
            {
                return typeParameters.ConvertAll(tp => tp.Variance);
            }

            return default;
        }

        public enum EqualitySupportValue { Required, InferredRequired, Unspecified }
        public struct TypeParameterCharacteristics
        {
            public RangeToken RangeToken = null;
            public EqualitySupportValue EqualitySupport;  // the resolver may change this value from Unspecified to InferredRequired (for some signatures that may immediately imply that equality support is required)
            public Type.AutoInitInfo AutoInit;
            public bool HasCompiledValue => MutateCSharp.Schemata207.ReplaceBinExprOp_2(10L, AutoInit, Type.AutoInitInfo.CompilableValue);
            public bool IsNonempty => MutateCSharp.Schemata207.ReplaceBinExprOp_3(11L, AutoInit, Type.AutoInitInfo.MaybeEmpty);
            public bool ContainsNoReferenceTypes;
            public TypeParameterCharacteristics(bool dummy)
            {
                EqualitySupport = EqualitySupportValue.Unspecified;
                AutoInit = Type.AutoInitInfo.MaybeEmpty;
                ContainsNoReferenceTypes = MutateCSharp.Schemata207.ReplaceBooleanConstant_4(12L, false);
            }
            public TypeParameterCharacteristics(EqualitySupportValue eqSupport, Type.AutoInitInfo autoInit, bool containsNoReferenceTypes)
            {
                EqualitySupport = eqSupport;
                AutoInit = autoInit;
                ContainsNoReferenceTypes = containsNoReferenceTypes;
            }
            public override string ToString()
            {
                string result = "";
                if (MutateCSharp.Schemata207.ReplaceBinExprOp_5(13L, EqualitySupport, EqualitySupportValue.Required))
                {
                    result += MutateCSharp.Schemata207.ReplaceStringConstant_0(14L, ",==");
                }
                if (HasCompiledValue)
                {
                    result += MutateCSharp.Schemata207.ReplaceStringConstant_0(15L, ",0");
                }
                if (MutateCSharp.Schemata207.ReplaceBinExprOp_2(16L, AutoInit, Type.AutoInitInfo.Nonempty))
                {
                    result += MutateCSharp.Schemata207.ReplaceStringConstant_0(17L, ",00");
                }
                if (ContainsNoReferenceTypes)
                {
                    result += MutateCSharp.Schemata207.ReplaceStringConstant_0(18L, ",!new");
                }
                if (MutateCSharp.Schemata207.ReplaceBinExprOp_7(23L, result.Length, MutateCSharp.Schemata207.ReplaceNumericConstant_6(19L, 0)))
                {
                    result = MutateCSharp.Schemata207.ReplaceStringConstant_0(28L, "(") + result.Substring(MutateCSharp.Schemata207.ReplaceNumericConstant_6(29L, 1)) + MutateCSharp.Schemata207.ReplaceStringConstant_0(33L, ")");
                }
                return result;
            }
        }
        public TypeParameterCharacteristics Characteristics;
        public bool SupportsEquality
        {
            get { return MutateCSharp.Schemata207.ReplaceBinExprOp_8(34L, Characteristics.EqualitySupport, EqualitySupportValue.Unspecified); }
        }

        public bool NecessaryForEqualitySupportOfSurroundingInductiveDatatype = MutateCSharp.Schemata207.ReplaceBooleanConstant_4(35L, false);  // computed during resolution; relevant only when Parent denotes an IndDatatypeDecl

        public bool IsToplevelScope
        {
            get { return parent is TopLevelDecl; }
        }

        public int PositionalIndex; // which type parameter this is (ie. in C<S, T, U>, S is 0, T is 1 and U is 2).

        public TypeParameter(RangeToken rangeToken, Name name, TPVarianceSyntax varianceS, TypeParameterCharacteristics characteristics)
          : base(rangeToken, name, null, new List<TypeParameter>(), null, MutateCSharp.Schemata207.ReplaceBooleanConstant_4(36L, false))
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Characteristics = characteristics;
            VarianceSyntax = varianceS;
        }

        public TypeParameter(RangeToken rangeToken, Name name, TPVarianceSyntax varianceS)
          : this(rangeToken, name, varianceS, new TypeParameterCharacteristics(MutateCSharp.Schemata207.ReplaceBooleanConstant_4(37L, false)))
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
        }

        public TypeParameter(RangeToken tok, Name name, int positionalIndex, ParentType parent)
          : this(tok, name, TPVarianceSyntax.NonVariant_Strict)
        {
            PositionalIndex = positionalIndex;
            Parent = parent;
        }

        public override string FullName
        {
            get
            {
                // when debugging, print it all:
                return /* Parent.FullName + "." + */ Name;
            }
        }

        public static TypeParameterCharacteristics GetExplicitCharacteristics(TopLevelDecl d)
        {
            Contract.Requires(d != null);
            TypeParameterCharacteristics characteristics = new TypeParameterCharacteristics(MutateCSharp.Schemata207.ReplaceBooleanConstant_4(38L, false));
            if (d is AbstractTypeDecl)
            {
                var dd = (AbstractTypeDecl)d;
                characteristics = dd.Characteristics;
            }
            else if (d is TypeSynonymDecl)
            {
                var dd = (TypeSynonymDecl)d;
                characteristics = dd.Characteristics;
            }
            if (MutateCSharp.Schemata207.ReplaceBinExprOp_5(39L, characteristics.EqualitySupport, EqualitySupportValue.InferredRequired))
            {
                return new TypeParameterCharacteristics(EqualitySupportValue.Unspecified, characteristics.AutoInit, characteristics.ContainsNoReferenceTypes);
            }
            else
            {
                return characteristics;
            }

            return default;
        }

        public static Dictionary<TypeParameter, Type> SubstitutionMap(List<TypeParameter> formals, List<Type> actuals)
        {
            Contract.Requires(formals != null);
            Contract.Requires(actuals != null);
            Contract.Requires(formals.Count == actuals.Count);
            var subst = new Dictionary<TypeParameter, Type>();
            for (int i = MutateCSharp.Schemata207.ReplaceNumericConstant_6(40L, 0); MutateCSharp.Schemata207.ReplaceBinExprOp_9(44L, i, formals.Count); MutateCSharp.Schemata207.ReplacePostfixUnaryExprOp_10(49L, ref i))
            {
                subst.Add(formals[i], actuals[i]);
            }
            return subst;
        }

    }
}