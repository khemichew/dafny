using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata410
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT410");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_6(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceNumericConstant_2(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.Type argument1, Microsoft.Dafny.TypeProxy argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.TypeProxy argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() || argument2();
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.TypeProxy argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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
    public class XConstraint
    {
        public readonly IToken tok;
        public readonly string ConstraintName;
        public readonly Type[] Types;
        public readonly TypeConstraint.ErrorMsg errorMsg;
        public XConstraint(IToken tok, string constraintName, Type[] types, TypeConstraint.ErrorMsg errMsg)
        {
            Contract.Requires(tok != null);
            Contract.Requires(constraintName != null);
            Contract.Requires(types != null);
            Contract.Requires(errMsg != null);
            this.tok = tok;
            ConstraintName = constraintName;
            Types = types;
            errorMsg = errMsg;
        }

        public override string ToString()
        {
            var s = ConstraintName + MutateCSharp.Schemata410.ReplaceStringConstant_0(1L, ":");
            foreach (var t in Types)
            {
                s += MutateCSharp.Schemata410.ReplaceStringConstant_0(2L, " ") + t;
            }
            return s;
        }

        /// <summary>
        /// Tries to confirm the XConstraint.
        /// If the XConstraint can be confirmed, or at least is plausible enough to have been converted into other type
        /// constraints or more XConstraints, then "true" is returned and the out-parameters "convertedIntoOtherTypeConstraints"
        /// and "moreXConstraints" are set to true accordingly.
        /// If the XConstraint can be refuted, then an error message will be produced and "true" is returned (to indicate
        /// that this XConstraint has finished serving its purpose).
        /// If there's not enough information to confirm or refute the XConstraint, then "false" is returned.
        /// </summary>
        public bool Confirm(ModuleResolver resolver, bool fullstrength, out bool convertedIntoOtherTypeConstraints, out bool moreXConstraints)
        {
            Contract.Requires(resolver != null);
            convertedIntoOtherTypeConstraints = MutateCSharp.Schemata410.ReplaceBooleanConstant_1(3L, false);
            moreXConstraints = MutateCSharp.Schemata410.ReplaceBooleanConstant_1(4L, false);
            var t = Types[MutateCSharp.Schemata410.ReplaceNumericConstant_2(5L, 0)].NormalizeExpand();
            if (t is TypeProxy)
            {
                switch (ConstraintName)
                {
                    case "Assignable":
                    case "Equatable":
                    case "EquatableArg":
                    case "Indexable":
                    case "Innable":
                    case "MultiIndexable":
                    case "IntOrORDINAL":
                        // have a go downstairs
                        break;
                        break;
                    default:
                        return false;  // there's not enough information to confirm or refute this XConstraint
                        break;
                }
            }
            bool satisfied;
            switch (ConstraintName)
            {
                case "Assignable":
                    {
                        Contract.Assert(t == t.Normalize());  // it's already been normalized above
                        var u = Types[1].NormalizeExpand();
                        if (CheckTypeInferenceVisitor.IsDetermined(t) &&
                            (fullstrength
                             || !ProxyWithNoSubTypeConstraint(u, resolver)
                             || (u is TypeProxy
                                 && Types[0].NormalizeExpandKeepConstraints() is var t0constrained
                                 && (t0constrained.IsNonNullRefType || t0constrained.AsSubsetType != null)
                                 && resolver.HasApplicableNullableRefTypeConstraint(new HashSet<TypeProxy>() { (TypeProxy)u }))))
                        {
                            // This is the best case.  We convert Assignable(t, u) to the subtype constraint base(t) :> u.
                            if (CheckTypeInferenceVisitor.IsDetermined(u) && t.IsSubtypeOf(u, false, true) && t.IsRefType)
                            {
                                // But we also allow cases where the rhs is a proper supertype of the lhs, and let the verifier
                                // determine whether the rhs is provably an instance of the lhs.
                                resolver.ConstrainAssignable((NonProxyType)u, (NonProxyType)t, errorMsg, out moreXConstraints, fullstrength);
                            }
                            else
                            {
                                resolver.ConstrainAssignable((NonProxyType)t, u, errorMsg, out moreXConstraints, fullstrength);
                            }
                            convertedIntoOtherTypeConstraints = true;
                            return true;
                        }
                        else if (u.IsTypeParameter)
                        {
                            // we need the constraint base(t) :> u, which for a type parameter t can happen iff t :> u
                            resolver.ConstrainSubtypeRelation(t, u, errorMsg);
                            convertedIntoOtherTypeConstraints = true;
                            return true;
                        }
                        else if (Type.FromSameHead(t, u, out var tUp, out var uUp))
                        {
                            resolver.ConstrainAssignableTypeArgs(tUp, tUp.TypeArgs, uUp.TypeArgs, errorMsg, out moreXConstraints);
                            return true;
                        }
                        else if (fullstrength && t is NonProxyType)
                        {
                            // We convert Assignable(t, u) to the subtype constraint base(t) :> u.
                            resolver.ConstrainAssignable((NonProxyType)t, u, errorMsg, out moreXConstraints, fullstrength);
                            convertedIntoOtherTypeConstraints = true;
                            return true;
                        }
                        else if (fullstrength && u is NonProxyType)
                        {
                            // We're willing to change "base(t) :> u" to the stronger constraint "t :> u" for the sake of making progress.
                            resolver.ConstrainSubtypeRelation(t, u, errorMsg);
                            convertedIntoOtherTypeConstraints = true;
                            return true;
                        }
                        // There's not enough information to say anything
                        return false;
                    }

                    break;
                case "NumericType":
                    satisfied = t.IsNumericBased();
                    break;
                    break;
                case "IntegerType":
                    satisfied = t.IsNumericBased(Type.NumericPersuasion.Int);
                    break;
                    break;
                case "IsBitvector":
                    satisfied = t.IsBitVectorType;
                    break;
                    break;
                case "IsRefType":
                    satisfied = t.IsRefType;
                    break;
                    break;
                case "IsNullableRefType":
                    satisfied = t.IsRefType && !t.IsNonNullRefType;
                    break;
                    break;
                case "Orderable_Lt":
                    satisfied = t.IsNumericBased() || t.IsBitVectorType || t.IsBigOrdinalType || t.IsCharType || t is SeqType || t is SetType || t is MultiSetType;
                    break;
                    break;
                case "Orderable_Gt":
                    satisfied = t.IsNumericBased() || t.IsBitVectorType || t.IsBigOrdinalType || t.IsCharType || t is SetType || t is MultiSetType;
                    break;
                    break;
                case "RankOrderable":
                    {
                        var u = Types[1].NormalizeExpand();
                        if (u is TypeProxy)
                        {
                            return false;  // not enough information
                        }
                        satisfied = (t.IsIndDatatype || t.IsTypeParameter) && u.IsIndDatatype;
                        break;
                    }

                    break;
                case "Plussable":
                    satisfied = t.IsNumericBased() || t.IsBitVectorType || t.IsBigOrdinalType || t.IsCharType || t is SeqType || t is SetType || t is MultiSetType || t is MapType;
                    break;
                    break;
                case "Minusable":
                    satisfied = t.IsNumericBased() || t.IsBitVectorType || t.IsBigOrdinalType || t.IsCharType || t is SetType || t is MultiSetType || t is MapType;
                    break;
                    break;
                case "Mullable":
                    satisfied = t.IsNumericBased() || t.IsBitVectorType || t is SetType || t is MultiSetType;
                    break;
                    break;
                case "IntOrORDINAL":
                    if (!(t is TypeProxy))
                    {
                        satisfied = t.IsNumericBased(Type.NumericPersuasion.Int) || t.IsBigOrdinalType;
                    }
                    else if (fullstrength)
                    {
                        var proxy = (TypeProxy)t;
                        // let's choose ORDINAL over int
                        resolver.AssignProxyAndHandleItsConstraints(proxy, Type.BigOrdinal);
                        convertedIntoOtherTypeConstraints = true;
                        satisfied = true;
                    }
                    else
                    {
                        return false;
                    }
                    break;
                    break;
                case "NumericOrBitvector":
                    satisfied = t.IsNumericBased() || t.IsBitVectorType;
                    break;
                    break;
                case "NumericOrBitvectorOrCharOrORDINAL":
                    satisfied = t.IsNumericBased() || t.IsBitVectorType || t.IsCharType || t.IsBigOrdinalType;
                    break;
                    break;
                case "IntLikeOrBitvector":
                    satisfied = t.IsNumericBased(Type.NumericPersuasion.Int) || t.IsBitVectorType;
                    break;
                    break;
                case "BooleanBits":
                    satisfied = t.IsBoolType || t.IsBitVectorType;
                    break;
                    break;
                case "Sizeable":
                    satisfied = (t is SetType && ((SetType)t).Finite) || t is MultiSetType || t is SeqType || (t is MapType && ((MapType)t).Finite);
                    break;
                    break;
                case "Disjointable":
                    satisfied = t is SetType || t is MultiSetType;
                    break;
                    break;
                case "MultiSetConvertible":
                    satisfied = (t is SetType && ((SetType)t).Finite) || t is SeqType;
                    if (satisfied)
                    {
                        Type elementType = ((CollectionType)t).Arg;
                        var u = Types[1];  // note, it's okay if "u" is a TypeProxy
                        var em = new TypeConstraint.ErrorMsgWithBase(errorMsg, "expecting element type {0} (got {1})", u, elementType);
                        resolver.ConstrainSubtypeRelation_Equal(elementType, u, em);
                        convertedIntoOtherTypeConstraints = true;
                    }
                    break;
                    break;
                case "IsCoDatatype":
                    satisfied = t.IsCoDatatype;
                    break;
                    break;
                case "Indexable":
                    if (!(t is TypeProxy))
                    {
                        satisfied = t is SeqType || t is MultiSetType || t is MapType || (t.IsArrayType && t.AsArrayType.Dims == 1);
                    }
                    else
                    {
                        // t is a proxy, but perhaps it stands for something between "object" and "array<?>".  If so, we can add a constraint
                        // that it does have the form "array<?>", since "object" would not be Indexable.
                        var proxy = (TypeProxy)t;
                        Type join = null;
                        if (resolver.JoinOfAllSubtypes(proxy, ref join, new HashSet<TypeProxy>()) && join != null)
                        {
                            var headWithProxyArgs = Type.HeadWithProxyArgs(join);
                            var tt = headWithProxyArgs.NormalizeExpand();
                            satisfied = tt is SeqType || tt is MultiSetType || tt is MapType || (tt.IsArrayType && tt.AsArrayType.Dims == 1);
                            if (satisfied)
                            {
                                resolver.AssignProxyAndHandleItsConstraints(proxy, headWithProxyArgs, true);
                                convertedIntoOtherTypeConstraints = true;
                            }
                        }
                        else
                        {
                            return false;  // we can't determine the answer
                        }
                    }
                    break;
                    break;
                case "MultiIndexable":
                    if (!(t is TypeProxy))
                    {
                        satisfied = t is SeqType || (t.IsArrayType && t.AsArrayType.Dims == 1);
                    }
                    else
                    {
                        // t is a proxy, but perhaps it stands for something between "object" and "array<?>".  If so, we can add a constraint
                        // that it does have the form "array<?>", since "object" would not be Indexable.
                        var proxy = (TypeProxy)t;
                        Type join = null;
                        if (resolver.JoinOfAllSubtypes(proxy, ref join, new HashSet<TypeProxy>()) && join != null)
                        {
                            var headWithProxyArgs = Type.HeadWithProxyArgs(join);
                            var tt = headWithProxyArgs.NormalizeExpand();
                            satisfied = tt is SeqType || (tt.IsArrayType && tt.AsArrayType.Dims == 1);
                            if (satisfied)
                            {
                                resolver.AssignProxyAndHandleItsConstraints(proxy, headWithProxyArgs, true);
                                convertedIntoOtherTypeConstraints = true;
                            }
                        }
                        else
                        {
                            return false;  // we can't determine the answer
                        }
                    }
                    break;
                    break;
                case "Innable":
                    {
                        var elementType = FindCollectionType(resolver.Options, t, true, new HashSet<TypeProxy>()) ?? FindCollectionType(resolver.Options, t, false, new HashSet<TypeProxy>());
                        if (elementType != null)
                        {
                            var u = Types[1];  // note, it's okay if "u" is a TypeProxy
                            resolver.AddXConstraint(this.tok, "Equatable", elementType, u, new TypeConstraint.ErrorMsgWithBase(errorMsg, "expecting element type to be assignable to {1} (got {0})", u, elementType));
                            moreXConstraints = true;
                            return true;
                        }
                        if (t is TypeProxy)
                        {
                            return false;  // not enough information to do anything
                        }
                        satisfied = false;
                        break;
                    }

                    break;
                case "SeqUpdatable":
                    {
                        var xcWithExprs = (XConstraintWithExprs)this;
                        var index = xcWithExprs.Exprs[0];
                        var value = xcWithExprs.Exprs[1];
                        if (t is SeqType)
                        {
                            var s = (SeqType)t;
                            resolver.ConstrainToIntegerType(index, true, "sequence update requires integer- or bitvector-based index (got {0})");
                            resolver.ConstrainSubtypeRelation(s.Arg, value.Type, value, "sequence update requires the value to have the element type of the sequence (got {0})", value.Type);
                        }
                        else if (t is MapType)
                        {
                            var s = (MapType)t;
                            if (s.Finite)
                            {
                                resolver.ConstrainSubtypeRelation(s.Domain, index.Type, index, "map update requires domain element to be of type {0} (got {1})", s.Domain, index.Type);
                                resolver.ConstrainSubtypeRelation(s.Range, value.Type, value, "map update requires the value to have the range type {0} (got {1})", s.Range, value.Type);
                            }
                            else
                            {
                                resolver.ConstrainSubtypeRelation(s.Domain, index.Type, index, "imap update requires domain element to be of type {0} (got {1})", s.Domain, index.Type);
                                resolver.ConstrainSubtypeRelation(s.Range, value.Type, value, "imap update requires the value to have the range type {0} (got {1})", s.Range, value.Type);
                            }
                        }
                        else if (t is MultiSetType)
                        {
                            var s = (MultiSetType)t;
                            resolver.ConstrainSubtypeRelation(s.Arg, index.Type, index, "multiset update requires domain element to be of type {0} (got {1})", s.Arg, index.Type);
                            resolver.ConstrainToIntegerType(value, false, "multiset update requires integer-based numeric value (got {0})");
                        }
                        else
                        {
                            satisfied = false;
                            break;
                        }
                        convertedIntoOtherTypeConstraints = true;
                        return true;
                    }

                    break;
                case "ContainerIndex":
                    // The semantics of this XConstraint is that *if* the head is seq/array/map/multiset, then its element/domain type must a supertype of "u"
                    Type indexType;
                    if (t is SeqType || t.IsArrayType)
                    {
                        resolver.ConstrainToIntegerType(errorMsg.Tok, Types[1], true, errorMsg);
                        convertedIntoOtherTypeConstraints = true;
                        return true;
                    }
                    else if (t is MapType)
                    {
                        indexType = ((MapType)t).Domain;
                    }
                    else if (t is MultiSetType)
                    {
                        indexType = ((MultiSetType)t).Arg;
                    }
                    else
                    {
                        // some other head symbol; that's cool
                        return true;
                    }
                    // note, it's okay if "Types[1]" is a TypeProxy
                    resolver.ConstrainSubtypeRelation(indexType, Types[1], errorMsg);  // use the same error message
                    convertedIntoOtherTypeConstraints = true;
                    return true;
                    break;
                case "ContainerResult":
                    // The semantics of this XConstraint is that *if* the head is seq/array/map/multiset, then the type of a selection must a subtype of "u"
                    Type resultType;
                    if (t is SeqType)
                    {
                        resultType = ((SeqType)t).Arg;
                    }
                    else if (t.IsArrayType)
                    {
                        resultType = UserDefinedType.ArrayElementType(t);
                    }
                    else if (t is MapType)
                    {
                        resultType = ((MapType)t).Range;
                    }
                    else if (t is MultiSetType)
                    {
                        resultType = resolver.SystemModuleManager.Nat();
                    }
                    else
                    {
                        // some other head symbol; that's cool
                        return true;
                    }
                    // note, it's okay if "Types[1]" is a TypeProxy
                    resolver.ConstrainSubtypeRelation(Types[1], resultType, errorMsg);
                    convertedIntoOtherTypeConstraints = true;
                    return true;
                    break;
                case "Equatable":
                    {
                        t = Types[0].NormalizeExpandKeepConstraints();
                        var u = Types[1].NormalizeExpandKeepConstraints();
                        if (object.ReferenceEquals(t, u))
                        {
                            return true;
                        }
                        if (t is TypeProxy && u is TypeProxy)
                        {
                            return false;  // not enough information to do anything sensible
                        }
                        else if (t is TypeProxy || u is TypeProxy)
                        {
                            TypeProxy proxy;
                            Type other;
                            if (t is TypeProxy)
                            {
                                proxy = (TypeProxy)t;
                                other = u;
                            }
                            else
                            {
                                proxy = (TypeProxy)u;
                                other = t;
                            }
                            if (other.IsNumericBased() || other.IsBitVectorType || other.IsBigOrdinalType)
                            {
                                resolver.ConstrainSubtypeRelation(other.NormalizeExpand(), proxy, errorMsg, true);
                                convertedIntoOtherTypeConstraints = true;
                                return true;
                            }
                            else if (fullstrength)
                            {
                                // the following is rather aggressive
                                if (ModuleResolver.TypeConstraintsIncludeProxy(other, proxy))
                                {
                                    return false;
                                }
                                else
                                {
                                    if (other.IsRefType && resolver.HasApplicableNullableRefTypeConstraint_SubDirection(proxy))
                                    {
                                        other = other.NormalizeExpand();  // shave off all constraints
                                    }
                                    satisfied = resolver.AssignProxyAndHandleItsConstraints(proxy, other, true);
                                    convertedIntoOtherTypeConstraints = true;
                                    break;
                                }
                            }
                            else
                            {
                                return false;  // not enough information
                            }
                        }

                        satisfied = Type.FromSameHead_Subtype(t, u, out var a, out var b);
                        if (satisfied)
                        {
                            Contract.Assert(a.TypeArgs.Count == b.TypeArgs.Count);
                            var cl = a is UserDefinedType ? ((UserDefinedType)a).ResolvedClass : null;
                            for (int i = 0; i < a.TypeArgs.Count; i++)
                            {
                                resolver.AllXConstraints.Add(new XConstraint_EquatableArg(tok,
                                  a.TypeArgs[i], b.TypeArgs[i],
                                  a is CollectionType || (cl != null && cl.TypeArgs[i].Variance != TypeParameter.TPVariance.Non),
                                  a.IsRefType,
                                  errorMsg));
                                moreXConstraints = true;
                            }
                        }
                        break;
                    }

                    break;
                case "EquatableArg":
                    {
                        t = Types[0].NormalizeExpandKeepConstraints();
                        var u = Types[1].NormalizeExpandKeepConstraints();
                        var moreExactThis = (XConstraint_EquatableArg)this;
                        if (t is TypeProxy && u is TypeProxy)
                        {
                            return false;  // not enough information to do anything sensible
                        }
                        else if (t is TypeProxy || u is TypeProxy)
                        {
                            TypeProxy proxy;
                            Type other;
                            if (t is TypeProxy)
                            {
                                proxy = (TypeProxy)t;
                                other = u;
                            }
                            else
                            {
                                proxy = (TypeProxy)u;
                                other = t;
                            }
                            if (other.IsNumericBased() || other.IsBitVectorType || other.IsBigOrdinalType)
                            {
                                resolver.ConstrainSubtypeRelation(other.NormalizeExpand(), proxy, errorMsg, true);
                                convertedIntoOtherTypeConstraints = true;
                                return true;
                            }
                            else if (fullstrength)
                            {
                                // the following is rather aggressive
                                if (ModuleResolver.TypeConstraintsIncludeProxy(other, proxy))
                                {
                                    return false;
                                }
                                else
                                {
                                    if (other.IsRefType && resolver.HasApplicableNullableRefTypeConstraint_SubDirection(proxy))
                                    {
                                        other = other.NormalizeExpand();  // shave off all constraints
                                    }
                                    satisfied = resolver.AssignProxyAndHandleItsConstraints(proxy, other, true);
                                    convertedIntoOtherTypeConstraints = true;
                                    break;
                                }
                            }
                            else
                            {
                                return false;  // not enough information
                            }
                        }
                        if (moreExactThis.TreatTypeParamAsWild && (t.IsTypeParameter || u.IsTypeParameter || t.IsAbstractType || u.IsAbstractType))
                        {
                            return true;
                        }
                        else if (!moreExactThis.AllowSuperSub)
                        {
                            resolver.ConstrainSubtypeRelation_Equal(t, u, errorMsg);
                            convertedIntoOtherTypeConstraints = true;
                            return true;
                        }

                        // okay if t<:u or u<:t (this makes type inference more manageable, though it is more liberal than one might wish)
                        satisfied = Type.FromSameHead_Subtype(t, u, out var a, out var b);
                        if (satisfied)
                        {
                            Contract.Assert(a.TypeArgs.Count == b.TypeArgs.Count);
                            var cl = a is UserDefinedType ? ((UserDefinedType)a).ResolvedClass : null;
                            for (int i = 0; i < a.TypeArgs.Count; i++)
                            {
                                resolver.AllXConstraints.Add(new XConstraint_EquatableArg(tok,
                                  a.TypeArgs[i], b.TypeArgs[i],
                                  a is CollectionType || (cl != null && cl.TypeArgs[i].Variance != TypeParameter.TPVariance.Non),
                                  false,
                                  errorMsg));
                                moreXConstraints = true;
                            }
                        }
                        break;
                    }

                    break;
                case "Freshable":
                    {
                        var collType = t.AsCollectionType;
                        if (collType is SetType || collType is SeqType)
                        {
                            t = collType.Arg.NormalizeExpand();
                        }
                        if (t is TypeProxy)
                        {
                            return false;  // there is not enough information
                        }
                        satisfied = t.IsRefType;
                        break;
                    }

                    break;
                case "ModifiesFrame":
                    {
                        var u = Types[1].NormalizeExpand();  // eventual ref type
                        var collType = t is MapType ? null : t.AsCollectionType;
                        if (collType != null)
                        {
                            t = collType.Arg.NormalizeExpand();
                        }
                        if (t is TypeProxy)
                        {
                            if (collType != null)
                            {
                                // we know enough to convert into a subtyping constraint
                                resolver.AddXConstraint(Token.NoToken/*bogus, but it seems this token would be used only when integers are involved*/, "IsRefType", t, errorMsg);
                                moreXConstraints = true;
                                resolver.ConstrainSubtypeRelation_Equal(u, t, errorMsg);
                                moreXConstraints = true;
                                convertedIntoOtherTypeConstraints = true;
                                return true;
                            }
                            else
                            {
                                return false;  // there is not enough information
                            }
                        }
                        if (t.IsRefType)
                        {
                            resolver.ConstrainSubtypeRelation_Equal(u, t, errorMsg);
                            convertedIntoOtherTypeConstraints = true;
                            return true;
                        }
                        satisfied = false;
                        break;
                    }

                    break;
                case "ReadsFrame":
                    {
                        var u = Types[1].NormalizeExpand();  // eventual ref type
                        var arrTy = t.AsArrowType;
                        if (arrTy != null)
                        {
                            t = arrTy.Result.NormalizeExpand();
                        }
                        var collType = t is MapType ? null : t.AsCollectionType;
                        if (collType != null)
                        {
                            t = collType.Arg.NormalizeExpand();
                        }
                        if (t is TypeProxy)
                        {
                            if (collType != null)
                            {
                                // we know enough to convert into a subtyping constraint
                                resolver.AddXConstraint(Token.NoToken/*bogus, but it seems this token would be used only when integers are involved*/, "IsRefType", t, errorMsg);
                                resolver.ConstrainSubtypeRelation_Equal(u, t, errorMsg);
                                moreXConstraints = true;
                                convertedIntoOtherTypeConstraints = true;
                                return true;
                            }
                            else
                            {
                                return false;  // there is not enough information
                            }
                        }
                        if (t.IsRefType && (arrTy == null || collType != null))
                        {
                            resolver.ConstrainSubtypeRelation_Equal(u, t, errorMsg);
                            convertedIntoOtherTypeConstraints = true;
                            return true;
                        }
                        satisfied = false;
                        break;
                    }

                    break;
                default:
                    Contract.Assume(false);  // unknown XConstraint
                    return false;  // to please the compiler
                    break;
            }
            if (!satisfied)
            {
                errorMsg.FlagAsError(resolver);
            }
            return MutateCSharp.Schemata410.ReplaceBooleanConstant_1(9L, true);  // the XConstraint has served its purpose
        }

        public bool ProxyWithNoSubTypeConstraint(Type u, ModuleResolver resolver)
        {
            Contract.Requires(u != null);
            Contract.Requires(resolver != null);
            var proxy = u as TypeProxy;
            if (MutateCSharp.Schemata410.ReplaceBinExprOp_3(10L, proxy, null))
            {
                if (proxy.SubtypeConstraints.Any())
                {
                    return MutateCSharp.Schemata410.ReplaceBooleanConstant_1(11L, false);
                }
                foreach (var xc in resolver.AllXConstraints)
                {
                    if (MutateCSharp.Schemata410.ReplaceBinExprOp_6(19L, () => MutateCSharp.Schemata410.ReplaceBinExprOp_4(13L, xc.ConstraintName, MutateCSharp.Schemata410.ReplaceStringConstant_0(12L, "Assignable")), () => MutateCSharp.Schemata410.ReplaceBinExprOp_5(18L, xc.Types[MutateCSharp.Schemata410.ReplaceNumericConstant_2(14L, 0)], proxy)))
                    {
                        return MutateCSharp.Schemata410.ReplaceBooleanConstant_1(25L, false);
                    }
                }
                return MutateCSharp.Schemata410.ReplaceBooleanConstant_1(26L, true);
            }
            return MutateCSharp.Schemata410.ReplaceBooleanConstant_1(27L, false);
        }

        internal bool CouldBeAnything()
        {
            return Types.All(t => t.NormalizeExpand() is TypeProxy);
        }

        /// <summary>
        /// If "t" or any type among its transitive sub/super-types (depending on "towardsSub")
        /// is a collection type, then returns the element/domain type of that collection.
        /// Otherwise, returns null.
        /// </summary>
        Type FindCollectionType(DafnyOptions options, Type t, bool towardsSub, ISet<TypeProxy> visited)
        {
            Contract.Requires(t != null);
            Contract.Requires(visited != null);
            t = t.NormalizeExpand();
            if (options.Get(CommonOptionBag.TypeInferenceDebug))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata410.ReplaceStringConstant_0(28L, "DEBUG: FindCollectionType({0}, {1})"), t, towardsSub ? MutateCSharp.Schemata410.ReplaceStringConstant_0(29L, "sub") : MutateCSharp.Schemata410.ReplaceStringConstant_0(30L, "super"));
            }
            if (t is CollectionType)
            {
                if (options.Get(CommonOptionBag.TypeInferenceDebug))
                {
                    options.OutputWriter.WriteLine(MutateCSharp.Schemata410.ReplaceStringConstant_0(31L, "DEBUG: FindCollectionType({0}) = {1}"), t, ((CollectionType)t).Arg);
                }
                return ((CollectionType)t).Arg;
            }
            var proxy = t as TypeProxy;
            if (MutateCSharp.Schemata410.ReplaceBinExprOp_8(33L, () => MutateCSharp.Schemata410.ReplaceBinExprOp_7(32L, proxy, null), () => visited.Contains(proxy)))
            {
                return null;
            }
            visited.Add(proxy);
            foreach (var sub in towardsSub ? proxy.Subtypes : proxy.Supertypes)
            {
                var e = FindCollectionType(options, sub, towardsSub, visited);
                if (MutateCSharp.Schemata410.ReplaceBinExprOp_9(39L, e, null))
                {
                    return e;
                }
            }
            return null;
        }
    }

    public class XConstraintWithExprs : XConstraint
    {
        public readonly Expression[] Exprs;
        public XConstraintWithExprs(IToken tok, string constraintName, Type[] types, Expression[] exprs, TypeConstraint.ErrorMsg errMsg)
          : base(tok, constraintName, types, errMsg)
        {
            Contract.Requires(tok != null);
            Contract.Requires(constraintName != null);
            Contract.Requires(types != null);
            Contract.Requires(exprs != null);
            Contract.Requires(errMsg != null);
            this.Exprs = exprs;
        }
    }

    public class XConstraint_EquatableArg : XConstraint
    {
        public bool AllowSuperSub;
        public bool TreatTypeParamAsWild;
        public XConstraint_EquatableArg(IToken tok, Type a, Type b, bool allowSuperSub, bool treatTypeParamAsWild, TypeConstraint.ErrorMsg errMsg)
          : base(tok, MutateCSharp.Schemata410.ReplaceStringConstant_0(40L, "EquatableArg"), new Type[] { a, b }, errMsg)
        {
            Contract.Requires(tok != null);
            Contract.Requires(a != null);
            Contract.Requires(b != null);
            Contract.Requires(errMsg != null);
            AllowSuperSub = allowSuperSub;
            TreatTypeParamAsWild = treatTypeParamAsWild;
        }
    }
}