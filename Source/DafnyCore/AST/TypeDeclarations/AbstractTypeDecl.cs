using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata183
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT183");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.TypeParameter.EqualitySupportValue argument1, Microsoft.Dafny.TypeParameter.EqualitySupportValue argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static int ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
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

        internal static bool ReplaceBinExprOp_6(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class AbstractTypeDecl : TopLevelDeclWithMembers, RevealableTypeDecl, ICanFormat, IHasDocstring
    {
        public override string WhatKind
        {
            get { return MutateCSharp.Schemata183.ReplaceStringConstant_0(1L, "abstract type"); }
        }

        public override bool CanBeRevealed() { return MutateCSharp.Schemata183.ReplaceBooleanConstant_1(2L, true); }
        public readonly TypeParameter.TypeParameterCharacteristics Characteristics;
        public bool SupportsEquality
        {
            get { return MutateCSharp.Schemata183.ReplaceBinExprOp_2(3L, Characteristics.EqualitySupport, TypeParameter.EqualitySupportValue.Unspecified); }
        }

        public AbstractTypeDecl(RangeToken rangeToken, Name name, ModuleDefinition module, TypeParameter.TypeParameterCharacteristics characteristics,
          List<TypeParameter> typeArgs, List<Type> parentTraits, List<MemberDecl> members, Attributes attributes, bool isRefining)
          : base(rangeToken, name, module, typeArgs, members, attributes, isRefining, parentTraits)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(module != null);
            Contract.Requires(typeArgs != null);
            Characteristics = characteristics;
            this.NewSelfSynonym();
        }

        public TopLevelDecl AsTopLevelDecl => this;
        public TypeDeclSynonymInfo SynonymInfo { get; set; }

        public override bool AcceptThis => MutateCSharp.Schemata183.ReplaceBooleanConstant_1(4L, true);
        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            var indent2 = MutateCSharp.Schemata183.ReplaceBinExprOp_3(5L, indentBefore, formatter.SpaceTab);
            var typeArgumentIndent = indent2;
            var commaIndent = indent2;
            var rightIndent = indent2;
            foreach (var token in OwnedTokens)
            {
                switch (token.val)
                {
                    case "type":
                        {
                            formatter.SetOpeningIndentedRegion(token, indentBefore);
                            break;
                        }

                        break;
                    case "=":
                        {
                            if (TokenNewIndentCollector.IsFollowedByNewline(token))
                            {
                                formatter.SetDelimiterInsideIndentedRegions(token, indent2);
                            }
                            else
                            {
                                formatter.SetAlign(indent2, token, out typeArgumentIndent, out _);
                            }

                            break;
                        }

                        break;
                    case "<":
                        {
                            if (TokenNewIndentCollector.IsFollowedByNewline(token))
                            {
                                formatter.SetOpeningIndentedRegion(token, typeArgumentIndent);
                                commaIndent = typeArgumentIndent;
                                rightIndent = commaIndent + formatter.SpaceTab;
                            }
                            else
                            {
                                formatter.SetAlign(typeArgumentIndent + formatter.SpaceTab, token, out rightIndent, out commaIndent);
                            }

                            break;
                        }

                        break;
                    case ">":
                        {
                            formatter.SetIndentations(token.Prev, below: rightIndent);
                            formatter.SetClosingIndentedRegionAligned(token, rightIndent, typeArgumentIndent);
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
                            formatter.SetOpeningIndentedRegion(token, indentBefore);
                            break;
                        }

                        break;
                    case "}":
                        {
                            formatter.SetClosingIndentedRegion(token, indentBefore);
                            break;
                        }

                        break;
                }
            }

            if (MutateCSharp.Schemata183.ReplaceBinExprOp_4(14L, EndToken.TrailingTrivia.Trim(), ""))
            {
                formatter.SetIndentations(EndToken, below: indentBefore);
            }

            return MutateCSharp.Schemata183.ReplaceBooleanConstant_1(15L, true);
        }

        public string GetTriviaContainingDocstring()
        {
            IToken openingBlock = null;
            foreach (var token in OwnedTokens)
            {
                if (MutateCSharp.Schemata183.ReplaceBinExprOp_4(17L, token.val, MutateCSharp.Schemata183.ReplaceStringConstant_0(16L, "{")))
                {
                    openingBlock = token;
                }
            }

            if (MutateCSharp.Schemata183.ReplaceBinExprOp_7(20L, () => MutateCSharp.Schemata183.ReplaceBinExprOp_5(18L, openingBlock, null), () => MutateCSharp.Schemata183.ReplaceBinExprOp_6(19L, openingBlock.Prev.TrailingTrivia.Trim(), "")))
            {
                return openingBlock.Prev.TrailingTrivia;
            }

            if (MutateCSharp.Schemata183.ReplaceBinExprOp_7(28L, () => MutateCSharp.Schemata183.ReplaceBinExprOp_8(26L, openingBlock, null), () => MutateCSharp.Schemata183.ReplaceBinExprOp_6(27L, EndToken.TrailingTrivia.Trim(), "")))
            {
                return EndToken.TrailingTrivia;
            }

            return GetTriviaContainingDocstringFromStartTokenOrNull();
        }
    }
}