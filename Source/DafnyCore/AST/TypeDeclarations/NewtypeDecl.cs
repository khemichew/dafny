using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Numerics;
namespace MutateCSharp
{
    internal class Schemata194
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT194");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_8(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.RevealableTypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBinExprOp_6(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, string argument1, string argument2)
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
    public class NewtypeDecl : TopLevelDeclWithMembers, RevealableTypeDecl, RedirectingTypeDecl, IHasDocstring, ICanVerify
    {
        public override string WhatKind
        {
            get { return MutateCSharp.Schemata194.ReplaceStringConstant_0(1L, "newtype"); }
        }

        public override bool CanBeRevealed() { return MutateCSharp.Schemata194.ReplaceBooleanConstant_1(2L, true); }
        public PreType BasePreType;
        public Type BaseType { get; set; }
        public BoundVar Var { get; set; }
        public Expression Constraint { get; set; }
        public SubsetTypeDecl.WKind WitnessKind { get; set; } = SubsetTypeDecl.WKind.CompiledZero;
        public Expression/*?*/ Witness { get; set; }

        [FilledInDuringResolution] public NativeType NativeType; // non-null for fixed-size representations (otherwise, use BigIntegers for integers)

        private bool? constraintIsCompilable = null;
        [FilledInDuringResolution]
        bool RedirectingTypeDecl.ConstraintIsCompilable
        {
            get
            {
                Contract.Assert(constraintIsCompilable != null);
                return (bool)constraintIsCompilable;
            }
            set
            {
                Contract.Assert(constraintIsCompilable == null);
                constraintIsCompilable = value;
            }
        }

        [FilledInDuringResolution] public bool TargetTypeCoversAllBitPatterns; // "target complete" -- indicates that any bit pattern that can fill the target type is a value of the newtype

        public NewtypeDecl(RangeToken rangeToken, Name name, ModuleDefinition module, Type baseType, List<Type> parentTraits,
          List<MemberDecl> members, Attributes attributes, bool isRefining)
          : base(rangeToken, name, module, new List<TypeParameter>(), members, attributes, isRefining, parentTraits)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(module != null);
            Contract.Requires(isRefining ^ (baseType != null));
            Contract.Requires(members != null);
            BaseType = baseType;
            this.NewSelfSynonym();
        }
        public NewtypeDecl(RangeToken rangeToken, Name name, ModuleDefinition module, BoundVar bv, Expression constraint,
          SubsetTypeDecl.WKind witnessKind, Expression witness, List<Type> parentTraits, List<MemberDecl> members, Attributes attributes, bool isRefining) : base(rangeToken, name, module, new List<TypeParameter>(), members, attributes, isRefining, parentTraits)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(module != null);
            Contract.Requires(bv != null && bv.Type != null);
            Contract.Requires((witnessKind == SubsetTypeDecl.WKind.Compiled || witnessKind == SubsetTypeDecl.WKind.Ghost) == (witness != null));
            Contract.Requires(members != null);
            BaseType = bv.Type;
            Var = bv;
            Constraint = constraint;
            Witness = witness;
            WitnessKind = witnessKind;
            this.NewSelfSynonym();
        }

        public Type ConcreteBaseType(List<Type> typeArguments)
        {
            Contract.Requires(TypeArgs.Count == typeArguments.Count);
            var subst = TypeParameter.SubstitutionMap(TypeArgs, typeArguments);
            return BaseType.Subst(subst);
        }

        /// <summary>  /// Return .BaseType instantiated with "typeArgs", but only look at the part of .BaseType that is in scope.
        /// </summary>
        public Type RhsWithArgument(List<Type> typeArgs)
        {
            Contract.Requires(typeArgs != null);
            Contract.Requires(typeArgs.Count == TypeArgs.Count);
            var scope = Type.GetScope();
            var rtd = BaseType.AsRevealableType;
            if (MutateCSharp.Schemata194.ReplaceBinExprOp_2(3L, rtd, null))
            {
                Contract.Assume(rtd.AsTopLevelDecl.IsVisibleInScope(scope));
                if (!rtd.IsRevealedInScope(scope))
                {
                    // type is actually hidden in this scope
                    return rtd.SelfSynonym(typeArgs);
                }
            }
            return RhsWithArgumentIgnoringScope(typeArgs);
        }
        /// <summary>
        /// Returns the declared .BaseType but with formal type arguments replaced by the given actuals.
        /// </summary>
        public Type RhsWithArgumentIgnoringScope(List<Type> typeArgs)
        {
            Contract.Requires(typeArgs != null);
            Contract.Requires(typeArgs.Count == TypeArgs.Count);
            // Instantiate with the actual type arguments
            if (MutateCSharp.Schemata194.ReplaceBinExprOp_4(8L, typeArgs.Count, MutateCSharp.Schemata194.ReplaceNumericConstant_3(4L, 0)))
            {
                // this optimization seems worthwhile
                return BaseType;
            }
            else
            {
                return ConcreteBaseType(typeArgs);
            }

            return default;
        }

        public TopLevelDecl AsTopLevelDecl => this;
        public TypeDeclSynonymInfo SynonymInfo { get; set; }

        public TypeParameter.EqualitySupportValue EqualitySupport
        {
            get
            {
                if (this.BaseType.SupportsEquality)
                {
                    return TypeParameter.EqualitySupportValue.Required;
                }
                else
                {
                    return TypeParameter.EqualitySupportValue.Unspecified;
                }

                return default;
            }
        }

        string RedirectingTypeDecl.Name
        {
            get { return Name; }
        }

        IToken RedirectingTypeDecl.tok
        {
            get { return tok; }
        }

        Attributes RedirectingTypeDecl.Attributes
        {
            get { return Attributes; }
        }

        ModuleDefinition RedirectingTypeDecl.Module
        {
            get { return EnclosingModuleDefinition; }
        }

        BoundVar RedirectingTypeDecl.Var
        {
            get { return Var; }
        }

        Expression RedirectingTypeDecl.Constraint
        {
            get { return Constraint; }
        }

        SubsetTypeDecl.WKind RedirectingTypeDecl.WitnessKind
        {
            get { return WitnessKind; }
        }

        Expression RedirectingTypeDecl.Witness
        {
            get { return Witness; }
        }

        FreshIdGenerator RedirectingTypeDecl.IdGenerator
        {
            get { return IdGenerator; }
        }

        bool ICodeContext.IsGhost
        {
            get
            {
                throw new NotSupportedException();
                return default;
            }  // if .IsGhost is needed, the object should always be wrapped in an CodeContextWrapper
        }

        List<TypeParameter> ICodeContext.TypeArgs
        {
            get { return new List<TypeParameter>(); }
        }

        List<Formal> ICodeContext.Ins
        {
            get { return new List<Formal>(); }
        }

        ModuleDefinition IASTVisitorContext.EnclosingModule
        {
            get { return EnclosingModuleDefinition; }
        }

        bool ICodeContext.MustReverify
        {
            get { return MutateCSharp.Schemata194.ReplaceBooleanConstant_1(13L, false); }
        }

        bool ICodeContext.AllowsNontermination
        {
            get { return MutateCSharp.Schemata194.ReplaceBooleanConstant_1(14L, false); }
        }

        string ICallable.NameRelativeToModule
        {
            get { return Name; }
        }

        Specification<Expression> ICallable.Decreases
        {
            get
            {
                // The resolver checks that a NewtypeDecl sits in its own SSC in the call graph.  Therefore,
                // the question of what its Decreases clause is should never arise.
                throw new cce.UnreachableException();
                return default;
            }
        }

        bool ICallable.InferredDecreases
        {
            get
            {
                throw new cce.UnreachableException();
                return default;
            }  // see comment above about ICallable.Decreases
            set { throw new cce.UnreachableException(); }  // see comment above about ICallable.Decreases
        }

        public override bool AcceptThis => MutateCSharp.Schemata194.ReplaceBooleanConstant_1(15L, true);

        public override bool IsEssentiallyEmpty()
        {
            // A "newtype" is not considered "essentially empty", because it always has a parent type to be resolved.
            return MutateCSharp.Schemata194.ReplaceBooleanConstant_1(16L, false);
        }

        public string GetTriviaContainingDocstring()
        {
            IToken candidate = null;
            foreach (var token in OwnedTokens)
            {
                if (MutateCSharp.Schemata194.ReplaceBinExprOp_5(18L, token.val, MutateCSharp.Schemata194.ReplaceStringConstant_0(17L, "{")))
                {
                    candidate = token.Prev;
                    if (MutateCSharp.Schemata194.ReplaceBinExprOp_6(19L, candidate.TrailingTrivia.Trim(), ""))
                    {
                        return candidate.TrailingTrivia;
                    }
                }
            }

            if (MutateCSharp.Schemata194.ReplaceBinExprOp_8(22L, () => MutateCSharp.Schemata194.ReplaceBinExprOp_7(20L, candidate, null), () => MutateCSharp.Schemata194.ReplaceBinExprOp_6(21L, EndToken.TrailingTrivia.Trim(), "")))
            {
                return EndToken.TrailingTrivia;
            }

            return GetTriviaContainingDocstringFromStartTokenOrNull();
        }

        public ModuleDefinition ContainingModule => EnclosingModuleDefinition;
        public bool ShouldVerify => MutateCSharp.Schemata194.ReplaceBooleanConstant_1(28L, true); // This could be made more accurate
        public string Designator => WhatKind;
    }

    public class NativeType
    {
        public readonly string Name;
        public readonly BigInteger LowerBound;
        public readonly BigInteger UpperBound;
        public readonly int Bitwidth;  // for unassigned types, this shows the number of bits in the type; else is 0
        public enum Selection { Byte, SByte, UShort, Short, UInt, Int, Number, ULong, Long, UDoubleLong, DoubleLong }
        public readonly Selection Sel;
        public NativeType(string Name, BigInteger LowerBound, BigInteger UpperBound, int bitwidth, Selection sel)
        {
            Contract.Requires(Name != null);
            Contract.Requires(0 <= bitwidth && (bitwidth == 0 || LowerBound == 0));
            this.Name = Name;
            this.LowerBound = LowerBound;
            this.UpperBound = UpperBound;
            this.Bitwidth = bitwidth;
            this.Sel = sel;
        }

        public Selection? UnsignedCounterpart()
        {
            switch (Sel)
            {
                case Selection.SByte:
                    return Selection.Byte;
                    break;
                case Selection.Short:
                    return Selection.UShort;
                    break;
                case Selection.Int:
                    return Selection.UInt;
                    break;
                case Selection.Long:
                    return Selection.ULong;
                    break;
                default:
                    return null;
                    break;
            }

            return default;
        }
    }

    public interface RevealableTypeDecl
    {
        TopLevelDecl AsTopLevelDecl { get; }
        TypeDeclSynonymInfo SynonymInfo { get; set; }
    }
}