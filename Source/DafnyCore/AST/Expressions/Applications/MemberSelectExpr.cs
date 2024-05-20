using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata12
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT12");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
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

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.Field argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_6(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.UserDefinedType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_2(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

    }
}

namespace Microsoft.Dafny
{
    public class MemberSelectExpr : Expression, IHasUsages, ICloneable<MemberSelectExpr>
    {
        public readonly Expression Obj;
        public string MemberName;
        [FilledInDuringResolution] public MemberDecl Member;    // will be a Field or Function
        [FilledInDuringResolution] public Label /*?*/ AtLabel;  // non-null for a two-state selection
        [FilledInDuringResolution] public bool InCompiledContext;

        /// <summary>
        /// PreTypeApplication_AtEnclosingClass is the list of type arguments used to instantiate the type that
        /// declares Member (which is some supertype of the receiver type).
        /// </summary>
        [FilledInDuringResolution] public List<PreType> PreTypeApplication_AtEnclosingClass;

        /// <summary>
        /// PreTypeApplication_JustMember is the list of type arguments used to instantiate the type parameters
        /// of Member.
        /// </summary>
        [FilledInDuringResolution] public List<PreType> PreTypeApplication_JustMember;

        /// <summary>
        /// TypeApplication_AtEnclosingClass is the list of type arguments used to instantiate the type that
        /// declares Member (which is some supertype of the receiver type).
        /// </summary>
        [FilledInDuringResolution] public List<Type> TypeApplication_AtEnclosingClass;

        /// <summary>
        /// TypeApplication_JustMember is the list of type arguments used to instantiate the type parameters
        /// of Member.
        /// </summary>
        [FilledInDuringResolution] public List<Type> TypeApplication_JustMember;

        /// <summary>
        /// Returns a mapping from formal type parameters to actual type arguments. For example, given
        ///     trait T<A> {
        ///       function F<X>(): bv8 { ... }
        ///     }
        ///     class C<B, D> extends T<map<B, D>> { }
        /// and MemberSelectExpr o.F<int> where o has type C<real, bool>, the type map returned is
        ///     A -> map<real, bool>
        ///     X -> int
        /// To also include B and D in the mapping, use TypeArgumentSubstitutionsWithParents instead.
        /// </summary>
        public Dictionary<TypeParameter, Type> TypeArgumentSubstitutionsAtMemberDeclaration()
        {
            Contract.Requires(WasResolved());
            Contract.Ensures(Contract.Result<Dictionary<TypeParameter, Type>>() != null);

            var subst = new Dictionary<TypeParameter, Type>();

            // Add the mappings from the member's own type parameters
            if (Member is ICallable icallable)
            {
                Contract.Assert(TypeApplication_JustMember.Count == icallable.TypeArgs.Count);
                for (var i = MutateCSharp.Schemata12.ReplaceNumericConstant_0(1L, 0); MutateCSharp.Schemata12.ReplaceBinExprOp_1(5L, i, icallable.TypeArgs.Count); MutateCSharp.Schemata12.ReplacePostfixUnaryExprOp_2(10L, ref i))
                {
                    subst.Add(icallable.TypeArgs[i], TypeApplication_JustMember[i]);
                }
            }
            else
            {
                Contract.Assert(TypeApplication_JustMember.Count == 0);
            }

            // Add the mappings from the enclosing class.
            TopLevelDecl cl = Member.EnclosingClass;
            // Expand the type down to its non-null type, if any
            if (MutateCSharp.Schemata12.ReplaceBinExprOp_3(11L, cl, null))
            {
                Contract.Assert(cl.TypeArgs.Count == TypeApplication_AtEnclosingClass.Count);
                for (var i = MutateCSharp.Schemata12.ReplaceNumericConstant_0(12L, 0); MutateCSharp.Schemata12.ReplaceBinExprOp_1(16L, i, cl.TypeArgs.Count); MutateCSharp.Schemata12.ReplacePostfixUnaryExprOp_2(21L, ref i))
                {
                    subst.Add(cl.TypeArgs[i], TypeApplication_AtEnclosingClass[i]);
                }
            }

            return subst;
        }

        /// <summary>
        /// Returns a mapping from formal type parameters to actual pre-type arguments. For example, given
        ///     trait T<A> {
        ///       function F<X>(): bv8 { ... }
        ///     }
        ///     class C<B, D> extends T<map<B, D>> { }
        /// and MemberSelectExpr o.F<int> where o has type C<real, bool>, the type map returned is
        ///     A -> map<real, bool>
        ///     X -> int
        /// To also include B and D in the mapping, use PreTypeArgumentSubstitutionsWithParents instead.
        /// </summary>
        public Dictionary<TypeParameter, PreType> PreTypeArgumentSubstitutionsAtMemberDeclaration()
        {
            Contract.Requires(WasResolved());
            Contract.Ensures(Contract.Result<Dictionary<TypeParameter, Type>>() != null);

            var subst = new Dictionary<TypeParameter, PreType>();

            // Add the mappings from the member's own type parameters
            if (Member is ICallable icallable)
            {
                Contract.Assert(PreTypeApplication_JustMember.Count == icallable.TypeArgs.Count);
                for (var i = MutateCSharp.Schemata12.ReplaceNumericConstant_0(22L, 0); MutateCSharp.Schemata12.ReplaceBinExprOp_1(26L, i, icallable.TypeArgs.Count); MutateCSharp.Schemata12.ReplacePostfixUnaryExprOp_2(31L, ref i))
                {
                    subst.Add(icallable.TypeArgs[i], PreTypeApplication_JustMember[i]);
                }
            }
            else
            {
                Contract.Assert(PreTypeApplication_JustMember.Count == 0);
            }

            // Add the mappings from the enclosing class.
            TopLevelDecl cl = Member.EnclosingClass;
            // Expand the type down to its non-null type, if any
            if (MutateCSharp.Schemata12.ReplaceBinExprOp_3(32L, cl, null))
            {
                Contract.Assert(cl.TypeArgs.Count == PreTypeApplication_AtEnclosingClass.Count);
                for (var i = MutateCSharp.Schemata12.ReplaceNumericConstant_0(33L, 0); MutateCSharp.Schemata12.ReplaceBinExprOp_1(37L, i, cl.TypeArgs.Count); MutateCSharp.Schemata12.ReplacePostfixUnaryExprOp_2(42L, ref i))
                {
                    subst.Add(cl.TypeArgs[i], PreTypeApplication_AtEnclosingClass[i]);
                }
            }

            return subst;
        }

        /// <summary>
        /// Returns a mapping from formal type parameters to actual type arguments. For example, given
        ///     trait T<A> {
        ///       function F<X>(): bv8 { ... }
        ///     }
        ///     class C<B, D> extends T<map<B, D>> { }
        /// and MemberSelectExpr o.F<int> where o has type C<real, bool>, the type map returned is
        ///     A -> map<real, bool>
        ///     B -> real
        ///     D -> bool
        ///     X -> int
        /// NOTE: This method should be called only when all types have been fully and successfully
        /// resolved. During type inference, when there may still be some unresolved proxies, use
        /// TypeArgumentSubstitutionsAtMemberDeclaration instead.
        /// </summary>
        public Dictionary<TypeParameter, Type> TypeArgumentSubstitutionsWithParents()
        {
            Contract.Requires(WasResolved());
            Contract.Ensures(Contract.Result<Dictionary<TypeParameter, Type>>() != null);

            return TypeArgumentSubstitutionsWithParentsAux(Obj.Type, Member, TypeApplication_JustMember);
        }

        public static Dictionary<TypeParameter, Type> TypeArgumentSubstitutionsWithParentsAux(Type receiverType, MemberDecl member, List<Type> typeApplicationMember)
        {
            Contract.Requires(receiverType != null);
            Contract.Requires(member != null);
            Contract.Requires(typeApplicationMember != null);
            Contract.Ensures(Contract.Result<Dictionary<TypeParameter, Type>>() != null);

            var subst = new Dictionary<TypeParameter, Type>();

            // Add the mappings from the member's own type parameters
            if (member is ICallable)
            {
                // Make sure to include the member's type parameters all the way up the inheritance chain
                for (var ancestor = member; MutateCSharp.Schemata12.ReplaceBinExprOp_4(43L, ancestor, null); ancestor = ancestor.OverriddenMember)
                {
                    var icallable = (ICallable)ancestor;
                    Contract.Assert(typeApplicationMember.Count == icallable.TypeArgs.Count);
                    for (var i = MutateCSharp.Schemata12.ReplaceNumericConstant_0(44L, 0); MutateCSharp.Schemata12.ReplaceBinExprOp_1(48L, i, icallable.TypeArgs.Count); MutateCSharp.Schemata12.ReplacePostfixUnaryExprOp_2(53L, ref i))
                    {
                        subst.Add(icallable.TypeArgs[i], typeApplicationMember[i]);
                    }
                }
            }
            else
            {
                Contract.Assert(typeApplicationMember.Count == 0);
            }

            // Add the mappings from the receiver's type "cl"
            var udt = receiverType.NormalizeExpand() as UserDefinedType;
            if (MutateCSharp.Schemata12.ReplaceBinExprOp_5(54L, udt, null))
            {
                if (udt.ResolvedClass is InternalTypeSynonymDecl isyn)
                {
                    udt = isyn.RhsWithArgumentIgnoringScope(udt.TypeArgs) as UserDefinedType;
                }
                if (udt.ResolvedClass is NonNullTypeDecl nntd)
                {
                    udt = nntd.RhsWithArgumentIgnoringScope(udt.TypeArgs) as UserDefinedType;
                }
            }
            var cl = udt?.ResolvedClass;

            if (MutateCSharp.Schemata12.ReplaceBinExprOp_3(55L, cl, null))
            {
                Contract.Assert(cl.TypeArgs.Count == udt.TypeArgs.Count);
                for (var i = MutateCSharp.Schemata12.ReplaceNumericConstant_0(56L, 0); MutateCSharp.Schemata12.ReplaceBinExprOp_1(60L, i, cl.TypeArgs.Count); MutateCSharp.Schemata12.ReplacePostfixUnaryExprOp_2(65L, ref i))
                {
                    subst.Add(cl.TypeArgs[i], udt.TypeArgs[i]);
                }

                // Add in the mappings from parent types' formal type parameters to types
                if (cl is TopLevelDeclWithMembers cls)
                {
                    foreach (var entry in cls.ParentFormalTypeParametersToActuals)
                    {
                        var v = entry.Value.Subst(subst);
                        subst.Add(entry.Key, v);
                    }
                }
            }

            return subst;
        }

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(Obj != null);
            Contract.Invariant(MemberName != null);
            Contract.Invariant((Member != null) == (TypeApplication_AtEnclosingClass != null));  // TypeApplication_* are set whenever Member is set
            Contract.Invariant((Member != null) == (TypeApplication_JustMember != null));  // TypeApplication_* are set whenever Member is set
        }

        public MemberSelectExpr Clone(Cloner cloner)
        {
            return new MemberSelectExpr(cloner, this);
        }

        public MemberSelectExpr(Cloner cloner, MemberSelectExpr original) : base(cloner, original)
        {
            Obj = cloner.CloneExpr(original.Obj);
            MemberName = original.MemberName;

            if (cloner.CloneResolvedFields)
            {
                Member = cloner.CloneMember(original.Member, MutateCSharp.Schemata12.ReplaceBooleanConstant_6(66L, true));
                AtLabel = original.AtLabel;
                InCompiledContext = original.InCompiledContext;
                TypeApplication_AtEnclosingClass = original.TypeApplication_AtEnclosingClass;
                TypeApplication_JustMember = original.TypeApplication_JustMember;
            }
        }

        public MemberSelectExpr(IToken tok, Expression obj, string memberName)
          : base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(obj != null);
            Contract.Requires(memberName != null);
            this.Obj = obj;
            this.MemberName = memberName;
        }

        /// <summary>
        /// Returns a resolved MemberSelectExpr for a field.
        /// </summary>
        public MemberSelectExpr(IToken tok, Expression obj, Field field)
          : this(tok, obj, field.Name)
        {
            Contract.Requires(tok != null);
            Contract.Requires(obj != null);
            Contract.Requires(field != null);
            Contract.Requires(obj.Type != null);  // "obj" is required to be resolved

            this.Member = field;  // resolve here

            var receiverType = obj.Type.NormalizeExpand();
            this.TypeApplication_AtEnclosingClass = receiverType.TypeArgs;
            this.TypeApplication_JustMember = new List<Type>();
            this.ResolvedOutparameterTypes = new List<Type>();

            var typeMap = new Dictionary<TypeParameter, Type>();
            if (receiverType is UserDefinedType udt)
            {
                var cl = udt.ResolvedClass as TopLevelDeclWithMembers;
                Contract.Assert(cl != null);
                Contract.Assert(cl.TypeArgs.Count == TypeApplication_AtEnclosingClass.Count);
                for (var i = MutateCSharp.Schemata12.ReplaceNumericConstant_0(67L, 0); MutateCSharp.Schemata12.ReplaceBinExprOp_1(71L, i, cl.TypeArgs.Count); MutateCSharp.Schemata12.ReplacePostfixUnaryExprOp_2(76L, ref i))
                {
                    typeMap.Add(cl.TypeArgs[i], TypeApplication_AtEnclosingClass[i]);
                }
                foreach (var entry in cl.ParentFormalTypeParametersToActuals)
                {
                    var v = entry.Value.Subst(typeMap);
                    typeMap.Add(entry.Key, v);
                }
            }
            else if (MutateCSharp.Schemata12.ReplaceBinExprOp_7(77L, field.EnclosingClass, null))
            {
                // leave typeMap as the empty substitution
            }
            else
            {
                Contract.Assert(field.EnclosingClass.TypeArgs.Count == TypeApplication_AtEnclosingClass.Count);
                for (var i = MutateCSharp.Schemata12.ReplaceNumericConstant_0(78L, 0); MutateCSharp.Schemata12.ReplaceBinExprOp_1(82L, i, field.EnclosingClass.TypeArgs.Count); MutateCSharp.Schemata12.ReplacePostfixUnaryExprOp_2(87L, ref i))
                {
                    typeMap.Add(field.EnclosingClass.TypeArgs[i], TypeApplication_AtEnclosingClass[i]);
                }
            }
            this.Type = field.Type.Subst(typeMap);  // resolve here
        }

        public void MemberSelectCase(Action<Field> fieldK, Action<Function> functionK)
        {
            MemberSelectCase<bool>(
              f =>
              {
                  fieldK(f);
                  return MutateCSharp.Schemata12.ReplaceBooleanConstant_6(88L, true);
              },
              f =>
              {
                  functionK(f);
                  return MutateCSharp.Schemata12.ReplaceBooleanConstant_6(89L, true);
              });
        }

        public A MemberSelectCase<A>(Func<Field, A> fieldK, Func<Function, A> functionK)
        {
            var field = Member as Field;
            var function = Member as Function;
            if (MutateCSharp.Schemata12.ReplaceBinExprOp_8(90L, field, null))
            {
                return fieldK(field);
            }
            else
            {
                Contract.Assert(function != null);
                return functionK(function);
            }

            return default;
        }

        public override IEnumerable<Expression> SubExpressions
        {
            get { yield return Obj; }
        }

        public override IEnumerable<Type> ComponentTypes => Util.Concat(TypeApplication_AtEnclosingClass, TypeApplication_JustMember);

        [FilledInDuringResolution] public List<Type> ResolvedOutparameterTypes;

        public IEnumerable<IDeclarationOrUsage> GetResolvedDeclarations()
        {
            return new[] { Member };
        }

        public IToken NameToken => tok;
    }
}