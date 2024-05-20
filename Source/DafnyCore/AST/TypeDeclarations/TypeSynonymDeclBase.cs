using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
namespace MutateCSharp
{
    internal class Schemata203
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT203");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.RevealableTypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.TypeParameter.EqualitySupportValue argument1, Microsoft.Dafny.TypeParameter.EqualitySupportValue argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_6(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
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

        internal static bool ReplaceBinExprOp_7(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

    }
}

namespace Microsoft.Dafny
{
    public abstract class TypeSynonymDeclBase : TopLevelDecl, RedirectingTypeDecl, IHasDocstring
    {
        public TypeParameter.TypeParameterCharacteristics Characteristics;  // the resolver may change the .EqualitySupport component of this value from Unspecified to InferredRequired (for some signatures that may immediately imply that equality support is required)
        public bool SupportsEquality
        {
            get { return MutateCSharp.Schemata203.ReplaceBinExprOp_0(1L, Characteristics.EqualitySupport, TypeParameter.EqualitySupportValue.Unspecified); }
        }

        public readonly Type Rhs;

        protected TypeSynonymDeclBase(RangeToken rangeToken, Name name, TypeParameter.TypeParameterCharacteristics characteristics, List<TypeParameter> typeArgs, ModuleDefinition module, Type rhs, Attributes attributes)
          : base(rangeToken, name, module, typeArgs, attributes, MutateCSharp.Schemata203.ReplaceBooleanConstant_1(2L, false))
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(typeArgs != null);
            Contract.Requires(module != null);
            Contract.Requires(rhs != null);
            Characteristics = characteristics;
            Rhs = rhs;
        }
        /// <summary>
        /// Return .Rhs instantiated with "typeArgs", but only look at the part of .Rhs that is in scope.
        /// </summary>
        public Type RhsWithArgument(List<Type> typeArgs)
        {
            Contract.Requires(typeArgs != null);
            Contract.Requires(typeArgs.Count == TypeArgs.Count);
            var scope = Type.GetScope();
            var rtd = Rhs.AsRevealableType;
            if (MutateCSharp.Schemata203.ReplaceBinExprOp_2(3L, rtd, null))
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
        /// Returns the declared .Rhs but with formal type arguments replaced by the given actuals.
        /// </summary>
        public Type RhsWithArgumentIgnoringScope(List<Type> typeArgs)
        {
            Contract.Requires(typeArgs != null);
            Contract.Requires(typeArgs.Count == TypeArgs.Count);
            // Instantiate with the actual type arguments
            if (MutateCSharp.Schemata203.ReplaceBinExprOp_4(8L, typeArgs.Count, MutateCSharp.Schemata203.ReplaceNumericConstant_3(4L, 0)))
            {
                // this optimization seems worthwhile
                return Rhs;
            }
            else
            {
                var subst = TypeParameter.SubstitutionMap(TypeArgs, typeArgs);
                return Rhs.Subst(subst);
            }

            return default;
        }

        public override IEnumerable<INode> Children => base.Children.Concat(
      MutateCSharp.Schemata203.ReplaceBinExprOp_5(13L, Rhs, null) ? new List<Node>() { Rhs } : Enumerable.Empty<Node>());

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
            get { return null; }
        }

        Expression RedirectingTypeDecl.Constraint
        {
            get { return null; }
        }

        bool RedirectingTypeDecl.ConstraintIsCompilable { get => throw new NotSupportedException();
    set => throw new NotSupportedException(); }

        SubsetTypeDecl.WKind RedirectingTypeDecl.WitnessKind
        {
            get { return SubsetTypeDecl.WKind.CompiledZero; }
        }

        Expression RedirectingTypeDecl.Witness
        {
            get { return null; }
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
            get { return TypeArgs; }
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
            get { return MutateCSharp.Schemata203.ReplaceBooleanConstant_1(14L, false); }
        }

        bool ICodeContext.AllowsNontermination
        {
            get { return MutateCSharp.Schemata203.ReplaceBooleanConstant_1(15L, false); }
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

        public override bool CanBeRevealed()
        {
            return MutateCSharp.Schemata203.ReplaceBooleanConstant_1(16L, true);
        }

        public override bool IsEssentiallyEmpty()
        {
            // A synonym/subset type is not considered "essentially empty", because it always has a parent type to be resolved.
            return MutateCSharp.Schemata203.ReplaceBooleanConstant_1(17L, false);
        }

        public string GetTriviaContainingDocstring()
        {
            IToken openingBlock = null;
            foreach (var token in OwnedTokens)
            {
                if (MutateCSharp.Schemata203.ReplaceBinExprOp_7(19L, token.val, MutateCSharp.Schemata203.ReplaceStringConstant_6(18L, "{")))
                {
                    openingBlock = token;
                }
            }

            if (MutateCSharp.Schemata203.ReplaceBinExprOp_10(22L, () => MutateCSharp.Schemata203.ReplaceBinExprOp_8(20L, openingBlock, null), () => MutateCSharp.Schemata203.ReplaceBinExprOp_9(21L, openingBlock.Prev.TrailingTrivia.Trim(), "")))
            {
                return openingBlock.Prev.TrailingTrivia;
            }

            if (MutateCSharp.Schemata203.ReplaceBinExprOp_10(30L, () => MutateCSharp.Schemata203.ReplaceBinExprOp_11(28L, openingBlock, null), () => MutateCSharp.Schemata203.ReplaceBinExprOp_9(29L, EndToken.TrailingTrivia.Trim(), "")))
            {
                return EndToken.TrailingTrivia;
            }

            return GetTriviaContainingDocstringFromStartTokenOrNull();
        }

        public abstract SymbolKind Kind { get; }

        public abstract string GetDescription(DafnyOptions options);
        public string Designator => WhatKind;
    }
}