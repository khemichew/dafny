using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata187
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT187");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
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

        internal static int ReplaceNumericConstant_4(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
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

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public abstract class ClassLikeDecl : TopLevelDeclWithMembers, RevealableTypeDecl, ICanFormat, IHasDocstring
    {
        public NonNullTypeDecl NonNullTypeDecl; // returns non-null value iff IsReferenceTypeDecl

        public override bool CanBeRevealed() { return MutateCSharp.Schemata187.ReplaceBooleanConstant_0(1L, true); }

        public bool IsObjectTrait { get => MutateCSharp.Schemata187.ReplaceBinExprOp_2(3L, Name, MutateCSharp.Schemata187.ReplaceStringConstant_1(2L, "object")); }

        /// <summary>
        /// The IsReferenceTypeDecl getter must not be called before this information is available.
        /// For most types, this information is known immediately, but for a TraitDecl, the information is not known until
        /// SetUpAsReferenceType has been called. The SetUpAsReferenceType method is called very early during resolution,
        /// namely during name registration of the enclosing module.
        /// </summary>
        public abstract bool IsReferenceTypeDecl { get; }

        public TopLevelDecl AsTopLevelDecl => this;
        public TypeDeclSynonymInfo SynonymInfo { get; set; }

        public ClassLikeDecl(RangeToken rangeToken, Name name, ModuleDefinition module,
          List<TypeParameter> typeArgs, [Captured] List<MemberDecl> members, Attributes attributes, bool isRefining, List<Type>/*?*/ traits)
          : base(rangeToken, name, module, typeArgs, members, attributes, isRefining, traits)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(module != null);
            Contract.Requires(cce.NonNullElements(typeArgs));
            Contract.Requires(cce.NonNullElements(members));
        }

        public virtual bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            IToken classToken = null;
            var parentTraitIndent = MutateCSharp.Schemata187.ReplaceBinExprOp_3(4L, indentBefore, formatter.SpaceTab);
            var commaIndent = indentBefore;
            var extraIndent = MutateCSharp.Schemata187.ReplaceNumericConstant_4(13L, 0);

            foreach (var token in OwnedTokens)
            {
                switch (token.val)
                {
                    case "class":
                        {
                            classToken = token;
                            break;
                        }

                        break;
                    case "extends":
                        {
                            if (token.line != token.Next.line)
                            {
                                extraIndent = classToken != null && classToken.line == token.line ? 0 : formatter.SpaceTab;
                                commaIndent += extraIndent;
                                formatter.SetIndentations(token, below: indentBefore + formatter.SpaceTab + extraIndent);
                            }
                            else
                            {
                                extraIndent += 2;
                                commaIndent = indentBefore + formatter.SpaceTab;
                                formatter.SetIndentations(token, below: indentBefore + formatter.SpaceTab);
                            }

                            break;
                        }

                        break;
                    case ",":
                        {
                            formatter.SetIndentations(token, parentTraitIndent + extraIndent, commaIndent, parentTraitIndent + extraIndent);
                            break;
                        }

                        break;
                }
            }

            foreach (var parent in ParentTraits)
            {
                formatter.SetTypeIndentation(parent);
            }

            return MutateCSharp.Schemata187.ReplaceBooleanConstant_0(17L, true);
        }

        public virtual string GetTriviaContainingDocstring()
        {
            IToken candidate = null;
            foreach (var token in OwnedTokens)
            {
                if (MutateCSharp.Schemata187.ReplaceBinExprOp_2(19L, token.val, MutateCSharp.Schemata187.ReplaceStringConstant_1(18L, "{")))
                {
                    candidate = token.Prev;
                    if (MutateCSharp.Schemata187.ReplaceBinExprOp_5(20L, candidate.TrailingTrivia.Trim(), ""))
                    {
                        return candidate.TrailingTrivia;
                    }
                }
            }

            if (MutateCSharp.Schemata187.ReplaceBinExprOp_7(23L, () => MutateCSharp.Schemata187.ReplaceBinExprOp_6(21L, candidate, null), () => MutateCSharp.Schemata187.ReplaceBinExprOp_5(22L, EndToken.TrailingTrivia.Trim(), "")))
            {
                return EndToken.TrailingTrivia;
            }

            return GetTriviaContainingDocstringFromStartTokenOrNull();
        }
    }
}