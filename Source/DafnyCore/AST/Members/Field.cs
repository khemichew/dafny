using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
namespace MutateCSharp
{
    internal class Schemata102
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT102");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class Field : MemberDecl, ICanFormat, IHasDocstring, ISymbol
    {
        public override string WhatKind => MutateCSharp.Schemata102.ReplaceStringConstant_0(1L, "field");
        public readonly bool IsMutable;  // says whether or not the field can ever change values
        public readonly bool IsUserMutable;  // says whether or not code is allowed to assign to the field (IsUserMutable implies IsMutable)
        public PreType PreType;

        public readonly Type Type; // Might be null after parsing and set during resolution
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(Type != null);
            Contract.Invariant(!IsUserMutable || IsMutable);  // IsUserMutable ==> IsMutable
        }

        public override IEnumerable<INode> Children => Type?.Nodes ?? Enumerable.Empty<INode>();

        public Field(RangeToken rangeToken, Name name, bool isGhost, Type type, Attributes attributes)
          : this(rangeToken, name, MutateCSharp.Schemata102.ReplaceBooleanConstant_1(2L, false), isGhost, MutateCSharp.Schemata102.ReplaceBooleanConstant_1(3L, true), MutateCSharp.Schemata102.ReplaceBooleanConstant_1(4L, true), type, attributes)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(type != null);
        }

        public Field(RangeToken rangeToken, Name name, bool hasStaticKeyword, bool isGhost, bool isMutable, bool isUserMutable, Type type, Attributes attributes)
          : base(rangeToken, name, hasStaticKeyword, isGhost, attributes, MutateCSharp.Schemata102.ReplaceBooleanConstant_1(5L, false))
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(type != null);
            Contract.Requires(!isUserMutable || isMutable);
            IsMutable = isMutable;
            IsUserMutable = isUserMutable;
            Type = type;
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            formatter.SetOpeningIndentedRegion(StartToken, indentBefore);
            formatter.SetIndentations(EndToken, below: indentBefore);
            var hasComma = OwnedTokens.Any(token => MutateCSharp.Schemata102.ReplaceBinExprOp_2(7L, token.val, MutateCSharp.Schemata102.ReplaceStringConstant_0(6L, ",")));
            switch (this)
            {
                case ConstantField constantField:
                    var ownedTokens = constantField.OwnedTokens;
                    var commaIndent = indentBefore + formatter.SpaceTab;
                    var rightIndent = indentBefore + formatter.SpaceTab;
                    foreach (var token in ownedTokens)
                    {
                        switch (token.val)
                        {
                            case ":=":
                                {
                                    if (TokenNewIndentCollector.IsFollowedByNewline(token))
                                    {
                                        formatter.SetDelimiterInsideIndentedRegions(token, indentBefore);
                                    }
                                    else if (formatter.ReduceBlockiness && token.Next.val is "{" or "[" or "(")
                                    {
                                        if (!hasComma)
                                        {
                                            rightIndent = indentBefore;
                                            commaIndent = indentBefore;
                                        }
                                        else
                                        {
                                            rightIndent = indentBefore + formatter.SpaceTab;
                                            commaIndent = indentBefore + formatter.SpaceTab;
                                        }

                                        formatter.SetIndentations(token, indentBefore, indentBefore, rightIndent);
                                    }
                                    else
                                    {
                                        formatter.SetAlign(indentBefore + formatter.SpaceTab, token, out rightIndent, out commaIndent);
                                    }

                                    break;
                                }
                            case ",":
                                {
                                    formatter.SetIndentations(token, rightIndent, commaIndent, rightIndent);
                                    break;
                                }
                            case ";":
                                {
                                    break;
                                }
                        }
                    }

                    if (constantField.Rhs is { } constantFieldRhs)
                    {
                        formatter.SetExpressionIndentation(constantFieldRhs);
                    }

                    break;
                    break;
            }

            return MutateCSharp.Schemata102.ReplaceBooleanConstant_1(8L, true);
        }

        public string GetTriviaContainingDocstring()
        {
            if (MutateCSharp.Schemata102.ReplaceBinExprOp_3(9L, EndToken.TrailingTrivia.Trim(), ""))
            {
                return EndToken.TrailingTrivia;
            }

            return GetTriviaContainingDocstringFromStartTokenOrNull();
        }

        public virtual SymbolKind Kind => SymbolKind.Field;

        public string GetDescription(DafnyOptions options)
        {
            var prefix = IsMutable ? MutateCSharp.Schemata102.ReplaceStringConstant_0(10L, "var") : MutateCSharp.Schemata102.ReplaceStringConstant_0(11L, "const");
            return $"{prefix} {AstExtensions.GetMemberQualification(this)}{Name}: {Type}";
        }
    }
}