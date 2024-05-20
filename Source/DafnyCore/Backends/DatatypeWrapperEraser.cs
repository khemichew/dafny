//-----------------------------------------------------------------------------
//
// Copyright (C) Microsoft Corporation.  All Rights Reserved.
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata227
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT227");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplacePostfixUnaryExprOp_4(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.Type argument1, Microsoft.Dafny.Type argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.DatatypeDestructor argument1, Microsoft.Dafny.MemberDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, Microsoft.Dafny.TopLevelDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.TupleTypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny.Compilers
{
    public class DatatypeWrapperEraser
    {

        public static bool CanBeLeftUninitialized(DafnyOptions options, Type type)
        {
            if (type.NormalizeExpandKeepConstraints() is UserDefinedType udt && udt.ResolvedClass is DatatypeDecl dt)
            {
                if (dt.GetGroundingCtor().IsGhost)
                {
                    return MutateCSharp.Schemata227.ReplaceBooleanConstant_0(1L, true);
                }
                if (GetInnerTypeOfErasableDatatypeWrapper(options, dt, out var innerType))
                {
                    var typeSubst = TypeParameter.SubstitutionMap(dt.TypeArgs, udt.TypeArgs);
                    return CanBeLeftUninitialized(options, innerType.Subst(typeSubst));
                }
            }
            return MutateCSharp.Schemata227.ReplaceBooleanConstant_0(2L, false);
        }

        public static Type SimplifyTypeAndTrimSubsetTypes(DafnyOptions options, Type ty)
        {
            return SimplifyTypeWorker(options, ty, SimplifyTypeExpandMode.ExpandSynonymsOnly);
        }

        public static Type SimplifyType(DafnyOptions options, Type ty)
        {
            return SimplifyTypeWorker(options, ty, SimplifyTypeExpandMode.ExpandSynonymsAndSubsetTypes);
        }

        public static Type SimplifyTypeAndTrimNewtypes(DafnyOptions options, Type ty)
        {
            return SimplifyTypeWorker(options, ty, SimplifyTypeExpandMode.ExpandSynonymsAndSubsetTypesAndNewtypesExceptNativeTypes);
        }

        public enum SimplifyTypeExpandMode
        {
            ExpandSynonymsOnly,
            ExpandSynonymsAndSubsetTypes,
            ExpandSynonymsAndSubsetTypesAndNewtypesExceptNativeTypes
        }

        /// <summary>
        /// Remove any erasable type wrappers and simplify ghost tuple types.
        /// </summary>
        private static Type SimplifyTypeWorker(DafnyOptions options, Type ty, SimplifyTypeExpandMode expandMode)
        {
            Contract.Requires(ty != null);
            Contract.Requires(ty is not TypeProxy);

            Type ExpandType(Type typ)
            {
                switch (expandMode)
                {
                    case SimplifyTypeExpandMode.ExpandSynonymsOnly:
                        return typ.NormalizeExpandKeepConstraints();
                        break;
                    case SimplifyTypeExpandMode.ExpandSynonymsAndSubsetTypes:
                        return typ.NormalizeExpand();
                        break;
                    case SimplifyTypeExpandMode.ExpandSynonymsAndSubsetTypesAndNewtypesExceptNativeTypes:
                        return typ.GetRuntimeType();
                        break;
                    default:
                        Contract.Assert(false); // unexpected case
                        throw new cce.UnreachableException();
                        break;
                }

                return default;
            }

            ty = ExpandType(ty);
            Contract.Assert(ty is NonProxyType);

            if (ty is UserDefinedType udt)
            {
                if (udt.ResolvedClass is TupleTypeDecl tupleTypeDecl && MutateCSharp.Schemata227.ReplaceBinExprOp_1(3L, tupleTypeDecl.NonGhostTupleTypeDecl, null))
                {
                    var nonGhostTupleTypeDecl = tupleTypeDecl.NonGhostTupleTypeDecl;
                    var typeArgsForNonGhostTuple = new List<Type>();
                    var n = tupleTypeDecl.TypeArgs.Count;
                    Contract.Assert(tupleTypeDecl.ArgumentGhostness.Count == n);
                    Contract.Assert(udt.TypeArgs.Count == n);
                    for (var i = MutateCSharp.Schemata227.ReplaceNumericConstant_2(4L, 0); MutateCSharp.Schemata227.ReplaceBinExprOp_3(8L, i, n); MutateCSharp.Schemata227.ReplacePostfixUnaryExprOp_4(13L, ref i))
                    {
                        if (!tupleTypeDecl.ArgumentGhostness[i])
                        {
                            typeArgsForNonGhostTuple.Add(udt.TypeArgs[i]);
                        }
                    }
                    Contract.Assert(typeArgsForNonGhostTuple.Count == nonGhostTupleTypeDecl.Dims);
                    Contract.Assert(nonGhostTupleTypeDecl.NonGhostDims == nonGhostTupleTypeDecl.Dims);
                    return new UserDefinedType(udt.tok, nonGhostTupleTypeDecl.Name, nonGhostTupleTypeDecl, typeArgsForNonGhostTuple);

                }
                else if (udt.ResolvedClass is DatatypeDecl datatypeDecl && GetInnerTypeOfErasableDatatypeWrapper(options, datatypeDecl, out var innerType))
                {
                    var typeSubst = TypeParameter.SubstitutionMap(datatypeDecl.TypeArgs, udt.TypeArgs);
                    var stype = ExpandType(innerType.Subst(typeSubst));
                    return SimplifyTypeWorker(options, stype, expandMode);
                }
            }

            // Simplify the type arguments of "ty"
            if (MutateCSharp.Schemata227.ReplaceBinExprOp_5(18L, ty.TypeArgs.Count, MutateCSharp.Schemata227.ReplaceNumericConstant_2(14L, 0)))
            {
                var simplifiedArguments = ty.TypeArgs.ConvertAll(typeArg => SimplifyTypeWorker(options, typeArg, expandMode));
                if (Enumerable.Range(MutateCSharp.Schemata227.ReplaceNumericConstant_2(23L, 0), ty.TypeArgs.Count).Any(i => MutateCSharp.Schemata227.ReplaceBinExprOp_6(27L, ExpandType(ty.TypeArgs[i]), simplifiedArguments[i])))
                {
                    ty.ReplaceTypeArguments(simplifiedArguments);
                }
            }
            return ty;
        }

        public enum MemberCompileStatus { Ordinary, Identity, AlwaysTrue }

        public static MemberCompileStatus GetMemberStatus(DafnyOptions options, MemberDecl member)
        {
            if (member.EnclosingClass is DatatypeDecl dt)
            {
                if (IsErasableDatatypeWrapper(options, dt, out var dtor) && MutateCSharp.Schemata227.ReplaceBinExprOp_7(28L, dtor, member))
                {
                    // "member" is the sole destructor of an erasable datatype wrapper
                    return MemberCompileStatus.Identity;
                }
                else if (member is DatatypeDiscriminator)
                {
                    // a discriminator of an inductive or coinductive datatype
                    return MutateCSharp.Schemata227.ReplaceBinExprOp_8(33L, dt.Ctors.Count(c => !c.IsGhost), MutateCSharp.Schemata227.ReplaceNumericConstant_2(29L, 1)) ? MemberCompileStatus.AlwaysTrue : MemberCompileStatus.Ordinary;
                }
            }

            return MemberCompileStatus.Ordinary;
        }

        /// <summary>
        /// If "dt" is an erasable datatype wrapper (see description of IsErasableDatatypeWrapper), then return "true" and
        /// set the out-parameter to the inner type. Otherwise, return "false" and sets the out-parameter to null.
        /// </summary>
        public static bool GetInnerTypeOfErasableDatatypeWrapper(DafnyOptions options, DatatypeDecl dt, out Type innerType)
        {
            if (IsErasableDatatypeWrapper(options, dt, out var coreDestructor))
            {
                innerType = coreDestructor.Type;
                return MutateCSharp.Schemata227.ReplaceBooleanConstant_0(38L, true);
            }
            innerType = null;
            return MutateCSharp.Schemata227.ReplaceBooleanConstant_0(39L, false);
        }

        /// <summary>
        /// This method determines whether or not "dt" is an "erasable datatype wrapper" that can be optimized away during compilation.
        /// First off, this applies only if
        ///   0 -- the compiler supports this kind of optimization (currently, only the C++ compiles does not support the optimization), and
        ///   1 -- the user doesn't disable the optimization from the command-line using /optimizeerasableDatatypeWrappers:0.
        /// To be an erasable wrapper, the datatype has to:
        ///   2 -- be an inductive datatype (not a "codatatype"), and
        ///   3 -- have exactly one non-ghost constructor, and
        ///   4 -- that constructor must have exactly one non-ghost destructor parameter (say, "d" of type "D"), and
        ///   5 -- have no non-ghost fields declared as members, and
        ///   6 -- have no parent traits, and
        ///   7 -- the compiled parts of type "D" must not include the datatype itself, and
        ///   8 -- not be declared with {:extern} (since extern code may rely on it being there).
        ///
        /// If the conditions above apply, then the method returns true and sets the out-parameter to the core DatatypeDestructor "d".
        /// From this return, the compiler (that is, the caller) will arrange to compile type "dt" as type "D".
        /// If according to the conditions above, "dt" is not an erasable wrapper, the method returns false; the out-parameter should
        /// then not be used by the caller.
        /// </summary>
        public static bool IsErasableDatatypeWrapper(DafnyOptions options, DatatypeDecl dt, out DatatypeDestructor coreDestructor)
        {
            if (MutateCSharp.Schemata227.ReplaceBinExprOp_9(40L, () => options.Backend.SupportsDatatypeWrapperErasure, () => options.Get(CommonOptionBag.OptimizeErasableDatatypeWrapper)))
            {
                // First, check for all conditions except the non-cycle condition
                if (FindUnwrappedCandidate(options, dt, out var candidateCoreDestructor))
                {
                    // Now, check if the type of the destructor contains "datatypeDecl" itself
                    if (!CompiledTypeContains(options, candidateCoreDestructor.Type, dt, ImmutableHashSet<TopLevelDecl>.Empty))
                    {
                        coreDestructor = candidateCoreDestructor;
                        return MutateCSharp.Schemata227.ReplaceBooleanConstant_0(46L, true);
                    }
                }
            }
            coreDestructor = null;
            return MutateCSharp.Schemata227.ReplaceBooleanConstant_0(47L, false);
        }

        /// <summary>
        /// Check for conditions 2, 3, 4, 5, 6, and 8 (but not 0, 1, and 7) mentioned in the description of IsErasableDatatypeWrapper.
        /// </summary>
        private static bool FindUnwrappedCandidate(DafnyOptions options, DatatypeDecl datatypeDecl, out DatatypeDestructor coreDtor)
        {
            if (datatypeDecl is IndDatatypeDecl &&
                !datatypeDecl.IsExtern(options, out _, out _) &&
                !datatypeDecl.Members.Any(member => member is Field { IsGhost: false }) &&
      MutateCSharp.Schemata227.ReplaceBinExprOp_8(52L, datatypeDecl.ParentTraits.Count, MutateCSharp.Schemata227.ReplaceNumericConstant_2(48L, 0)))
            {
                var nonGhostConstructors = datatypeDecl.Ctors.Where(ctor => !ctor.IsGhost).ToList();
                if (MutateCSharp.Schemata227.ReplaceBinExprOp_8(61L, nonGhostConstructors.Count, MutateCSharp.Schemata227.ReplaceNumericConstant_2(57L, 1)))
                {
                    // there is exactly one non-ghost constructor
                    var ctor = nonGhostConstructors[MutateCSharp.Schemata227.ReplaceNumericConstant_2(66L, 0)];
                    var nonGhostDestructors = ctor.Destructors.Where(dtor => !dtor.IsGhost).ToList();
                    if (MutateCSharp.Schemata227.ReplaceBinExprOp_8(74L, nonGhostDestructors.Count, MutateCSharp.Schemata227.ReplaceNumericConstant_2(70L, 1)))
                    {
                        // there is exactly one non-ghost parameter to "ctor"
                        coreDtor = nonGhostDestructors[MutateCSharp.Schemata227.ReplaceNumericConstant_2(79L, 0)];
                        return MutateCSharp.Schemata227.ReplaceBooleanConstant_0(83L, true);
                    }
                }
            }
            coreDtor = null;
            return MutateCSharp.Schemata227.ReplaceBooleanConstant_0(84L, false);
        }

        /// <summary>
        /// Return "true" if a traversal into the components of "type" finds "lookingFor" before passing through any type in "visited".
        /// "lookingFor" is expected not to be a subset type, and "visited" is expected not to contain any subset types.
        /// </summary>
        private static bool CompiledTypeContains(DafnyOptions options, Type type, TopLevelDecl lookingFor, IImmutableSet<TopLevelDecl> visited)
        {
            type = type.NormalizeExpand();
            if (type is UserDefinedType udt)
            {
                if (MutateCSharp.Schemata227.ReplaceBinExprOp_10(85L, udt.ResolvedClass, lookingFor))
                {
                    return MutateCSharp.Schemata227.ReplaceBooleanConstant_0(86L, true);
                }
                if (visited.Contains(udt.ResolvedClass))
                {
                    return MutateCSharp.Schemata227.ReplaceBooleanConstant_0(87L, false);
                }
                visited = visited.Union(ImmutableHashSet.Create(udt.ResolvedClass));
                // (a) IF "udt.ResolvedClass" is an erasable type wrapper, then we want to continue the search with
                // its core destructor, suitably substituting type arguments for type parameters.
                // (b) If it is NOT, then we just want to search in its type arguments (like we would for non-UserDefinedType's).
                //
                // However, we don't know which of (a) or (b) we're looking at. So, we first explore (a), and if that
                // shows that the core destructor of "udt.ResolvedClass" has no cycles, then "udt.ResolvedClass" is
                // indeed an erasable type wrapper. If "udt.ResolvedClass" is involved in some cycle, then it is not
                // an erasable type wrapper, so we abandon (a) and instead do (b).
                if (udt.ResolvedClass is DatatypeDecl d && FindUnwrappedCandidate(options, d, out var dtor))
                {
                    var typeSubst = TypeParameter.SubstitutionMap(d.TypeArgs, udt.TypeArgs);
                    if (CompiledTypeContains(options, dtor.Type.Subst(typeSubst), lookingFor, visited))
                    {
                        return MutateCSharp.Schemata227.ReplaceBooleanConstant_0(88L, true);
                    }
                }
            }
            return type.TypeArgs.Any(ty => CompiledTypeContains(options, ty, lookingFor, visited));
        }

    }
}
