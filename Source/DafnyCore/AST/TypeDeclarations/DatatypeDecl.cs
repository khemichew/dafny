using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
namespace MutateCSharp
{
    internal class Schemata190
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT190");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
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

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
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

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static int ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_10(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static string ReplaceStringConstant_8(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public abstract class DatatypeDecl : TopLevelDeclWithMembers, RevealableTypeDecl, ICallable, ICanFormat, IHasDocstring, ICanAutoRevealDependencies
    {
        public override bool CanBeRevealed() { return MutateCSharp.Schemata190.ReplaceBooleanConstant_0(1L, true); }
        public readonly List<DatatypeCtor> Ctors;

        [FilledInDuringResolution]
        public Dictionary<string, DatatypeCtor> ConstructorsByName { get; set; }

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(cce.NonNullElements(Ctors));
            Contract.Invariant(1 <= Ctors.Count);
        }

        public override IEnumerable<INode> Children => Ctors.Concat(base.Children);

        public override IEnumerable<INode> PreResolveChildren => Ctors.Concat(base.PreResolveChildren);

        public DatatypeDecl(RangeToken rangeToken, Name name, ModuleDefinition module, List<TypeParameter> typeArgs,
          [Captured] List<DatatypeCtor> ctors, List<Type> parentTraits, List<MemberDecl> members, Attributes attributes, bool isRefining)
          : base(rangeToken, name, module, typeArgs, members, attributes, isRefining, parentTraits)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(module != null);
            Contract.Requires(cce.NonNullElements(typeArgs));
            Contract.Requires(cce.NonNullElements(ctors));
            Contract.Requires(cce.NonNullElements(members));
            Contract.Requires((isRefining && ctors.Count == 0) || (!isRefining && 1 <= ctors.Count));
            Ctors = ctors;
            this.NewSelfSynonym();
        }
        public bool HasFinitePossibleValues
        {
            get
            {
                // Note, to determine finiteness, it doesn't matter if the constructors are ghost or non-ghost.
                return (MutateCSharp.Schemata190.ReplaceBinExprOp_3(20L, () => MutateCSharp.Schemata190.ReplaceBinExprOp_2(6L, TypeArgs.Count, MutateCSharp.Schemata190.ReplaceNumericConstant_1(2L, 0)), () => Ctors.TrueForAll(ctr => MutateCSharp.Schemata190.ReplaceBinExprOp_2(15L, ctr.Formals.Count, MutateCSharp.Schemata190.ReplaceNumericConstant_1(11L, 0)))));
            }
        }

        public bool IsRecordType
        {
            get { return MutateCSharp.Schemata190.ReplaceBinExprOp_3(45L, () => MutateCSharp.Schemata190.ReplaceBinExprOp_3(35L, () => this is IndDatatypeDecl, () => MutateCSharp.Schemata190.ReplaceBinExprOp_2(30L, Ctors.Count, MutateCSharp.Schemata190.ReplaceNumericConstant_1(26L, 1))), () => !Ctors[MutateCSharp.Schemata190.ReplaceNumericConstant_1(41L, 0)].IsGhost); }
        }

        public bool HasGhostVariant => Ctors.Any(ctor => ctor.IsGhost);

        public TopLevelDecl AsTopLevelDecl => this;
        public TypeDeclSynonymInfo SynonymInfo { get; set; }

        bool ICodeContext.IsGhost
        {
            get { return MutateCSharp.Schemata190.ReplaceBooleanConstant_0(51L, true); }
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
            get { return MutateCSharp.Schemata190.ReplaceBooleanConstant_0(52L, false); }
        }

        bool ICodeContext.AllowsNontermination
        {
            get { return MutateCSharp.Schemata190.ReplaceBooleanConstant_0(53L, false); }
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

        /// <summary>
        /// For information about the grounding constructor, see docs/Compilation/AutoInitialization.md.
        /// </summary>
        public abstract DatatypeCtor GetGroundingCtor();


        public override bool IsEssentiallyEmpty()
        {
            if (Ctors.Any(ctor => MutateCSharp.Schemata190.ReplaceBinExprOp_6(64L, () => MutateCSharp.Schemata190.ReplaceBinExprOp_4(54L, ctor.Attributes, null), () => MutateCSharp.Schemata190.ReplaceBinExprOp_5(59L, ctor.Formals.Count, MutateCSharp.Schemata190.ReplaceNumericConstant_1(55L, 0)))))
            {
                return MutateCSharp.Schemata190.ReplaceBooleanConstant_0(70L, false);
            }
            return base.IsEssentiallyEmpty();
        }

        public override IEnumerable<ISymbol> ChildSymbols => base.ChildSymbols.Concat(Ctors);
        public override SymbolKind Kind => SymbolKind.Enum;

        public bool SetIndent(int indent, TokenNewIndentCollector formatter)
        {
            var indent2 = MutateCSharp.Schemata190.ReplaceBinExprOp_7(71L, indent, formatter.SpaceTab);
            var verticalBarIndent = indent2;
            var rightOfVerticalBarIndent = MutateCSharp.Schemata190.ReplaceBinExprOp_7(80L, indent2, formatter.SpaceTab);
            if (OwnedTokens.All(token => MutateCSharp.Schemata190.ReplaceBinExprOp_6(102L, () => MutateCSharp.Schemata190.ReplaceBinExprOp_6(91L, () => MutateCSharp.Schemata190.ReplaceBinExprOp_9(90L, token.val, MutateCSharp.Schemata190.ReplaceStringConstant_8(89L, "|")), () => TokenNewIndentCollector.IsFollowedByNewline(token)), () => MutateCSharp.Schemata190.ReplaceBinExprOp_2(97L, token.Next.line, token.Prev.line))))
            {
                rightOfVerticalBarIndent = indent2;
            }

            var commaIndent = indent2;
            var rightIndent = indent2;
            var noExtraIndent = MutateCSharp.Schemata190.ReplaceBinExprOp_3(151L, () => MutateCSharp.Schemata190.ReplaceBinExprOp_3(136L, () => MutateCSharp.Schemata190.ReplaceBinExprOp_3(117L, () => formatter.ReduceBlockiness, () => MutateCSharp.Schemata190.ReplaceBinExprOp_2(112L, Ctors.Count, MutateCSharp.Schemata190.ReplaceNumericConstant_1(108L, 1
                                ))), () => MutateCSharp.Schemata190.ReplaceBinExprOp_10(131L, Ctors[MutateCSharp.Schemata190.ReplaceNumericConstant_1(123L, 0)].Formals.Count, MutateCSharp.Schemata190.ReplaceNumericConstant_1(127L, 0
                                ))), () => MutateCSharp.Schemata190.ReplaceBinExprOp_2(146L, Ctors[MutateCSharp.Schemata190.ReplaceNumericConstant_1(142L, 0)].StartToken.line, StartToken.line));
            if (noExtraIndent)
            {
                rightOfVerticalBarIndent = indent;
            }

            var ownedTokens = OwnedTokens.Concat(this.Ctors.SelectMany(ctor => ctor.OwnedTokens))
              .OrderBy(token => token.pos);
            foreach (var token in ownedTokens)
            {
                switch (token.val)
                {
                    case "datatype":
                        {
                            formatter.SetOpeningIndentedRegion(token, indent);
                            break;
                        }

                        break;
                    case "=":
                        {
                            if (TokenNewIndentCollector.IsFollowedByNewline(token) || noExtraIndent)
                            {
                                formatter.SetIndentations(token, rightOfVerticalBarIndent, indent + formatter.SpaceTab, rightOfVerticalBarIndent);
                            }
                            else
                            {
                                formatter.SetAlign(indent2, token, out rightOfVerticalBarIndent, out verticalBarIndent);
                            }

                            break;
                        }

                        break;
                    case "|":
                        {
                            formatter.SetIndentations(token, rightOfVerticalBarIndent, verticalBarIndent, rightOfVerticalBarIndent);
                            break;
                        }

                        break;
                    case "(":
                        {
                            if (TokenNewIndentCollector.IsFollowedByNewline(token))
                            {
                                formatter.SetOpeningIndentedRegion(token, rightOfVerticalBarIndent);
                                commaIndent = rightOfVerticalBarIndent;
                                rightIndent = commaIndent + formatter.SpaceTab;
                            }
                            else
                            {
                                formatter.SetAlign(rightOfVerticalBarIndent + formatter.SpaceTab, token, out rightIndent, out commaIndent);
                            }

                            break;
                        }

                        break;
                    case ")":
                        {
                            formatter.SetIndentations(token.Prev, below: rightIndent);
                            formatter.SetClosingIndentedRegionAligned(token, rightIndent, rightOfVerticalBarIndent);
                            break;
                        }

                        break;
                    case ",":
                        {
                            formatter.SetIndentations(token, rightIndent, commaIndent, rightIndent);
                            break;
                        }

                        break;
                    case ";":
                        {
                            break;
                        }

                        break;
                    case "{":
                        {
                            formatter.SetOpeningIndentedRegion(token, indent);
                            break;
                        }

                        break;
                    case "}":
                        {
                            formatter.SetClosingIndentedRegion(token, indent);
                            break;
                        }

                        break;
                }
            }

            foreach (var ctor in this.Ctors)
            {
                formatter.SetFormalsIndentation(ctor.Formals);
            }

            if (MutateCSharp.Schemata190.ReplaceBinExprOp_11(157L, EndToken.TrailingTrivia.Trim(), ""))
            {
                formatter.SetIndentations(this.EndToken, below: indent);
            }

            return MutateCSharp.Schemata190.ReplaceBooleanConstant_0(158L, true);
        }

        public string GetTriviaContainingDocstring()
        {
            foreach (var token in OwnedTokens)
            {
                if (MutateCSharp.Schemata190.ReplaceBinExprOp_3(162L, () => MutateCSharp.Schemata190.ReplaceBinExprOp_11(160L, token.val, MutateCSharp.Schemata190.ReplaceStringConstant_8(159L, "=")), () => MutateCSharp.Schemata190.ReplaceBinExprOp_9(161L, token.TrailingTrivia.Trim(), "")))
                {
                    return token.TrailingTrivia;
                }
            }

            return GetTriviaContainingDocstringFromStartTokenOrNull();
        }

        public void AutoRevealDependencies(AutoRevealFunctionDependencies Rewriter, DafnyOptions Options, ErrorReporter Reporter)
        {
            foreach (var ctor in Ctors)
            {
                foreach (var formal in ctor.Formals)
                {
                    if (formal.DefaultValue is null)
                    {
                        continue;
                    }

                    var addedReveals = Rewriter.ExprToFunctionalDependencies(formal.DefaultValue, EnclosingModuleDefinition);
                    formal.DefaultValue = Rewriter.AddRevealStmtsToExpression(formal.DefaultValue, addedReveals);

                    if (addedReveals.Any())
                    {
                        Reporter.Message(MessageSource.Rewriter, ErrorLevel.Info, null, formal.tok,
                          AutoRevealFunctionDependencies.GenerateMessage(addedReveals.ToList()));
                    }
                }
            }
        }
        public string Designator => WhatKind;
    }
}