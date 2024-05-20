using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.AccessControl;
namespace MutateCSharp
{
    internal class Schemata128
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT128");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.ModuleKindEnum argument1, Microsoft.Dafny.ModuleKindEnum argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
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

    /// <summary>
    /// Represents the exports of a module.
    /// </summary>
    public class ModuleExportDecl : ModuleDecl, ICanFormat
    {
        public readonly bool IsDefault;
        public List<ExportSignature> Exports; // list of TopLevelDecl that are included in the export
        public List<IToken> Extends; // list of exports that are extended
        [FilledInDuringResolution] public readonly List<ModuleExportDecl> ExtendDecls = new();
        public bool RevealAll; // only kept for initial rewriting, then discarded
        public bool ProvideAll;
        public override IEnumerable<INode> Children => Exports;
        public override IEnumerable<INode> PreResolveChildren => Exports;

        public readonly VisibilityScope ThisScope;

        public ModuleDefinition EffectiveModule = null;

        public ModuleExportDecl(Cloner cloner, ModuleExportDecl original, ModuleDefinition parent)
          : base(cloner, original, parent)
        {
            Exports = original.Exports.Select(s => new ExportSignature(cloner, s)).ToList();
            Extends = original.Extends.Select(cloner.Tok).ToList();
            ProvideAll = original.ProvideAll;
            RevealAll = original.RevealAll;
            IsRefining = original.IsRefining;
            IsDefault = original.IsDefault;
            ThisScope = new VisibilityScope(FullSanitizedName);
            SetupDefaultSignature();
        }

        public ModuleExportDecl(DafnyOptions options, RangeToken rangeToken, Name name, ModuleDefinition parent,
          List<ExportSignature> exports, List<IToken> extends,
          bool provideAll, bool revealAll, bool isDefault, bool isRefining, Guid cloneId)
          : base(options, rangeToken, name, parent, MutateCSharp.Schemata128.ReplaceBooleanConstant_0(1L, false), isRefining, cloneId)
        {
            Contract.Requires(exports != null);
            IsDefault = isDefault;
            Exports = exports;
            Extends = extends;
            ProvideAll = provideAll;
            RevealAll = revealAll;
            ThisScope = new VisibilityScope(this.FullSanitizedName);
            SetupDefaultSignature();
        }

        public void SetupDefaultSignature()
        {
            Contract.Requires(this.Signature == null);
            var sig = new ModuleSignature();
            sig.ModuleDef = this.EnclosingModuleDefinition;
            sig.IsAbstract = MutateCSharp.Schemata128.ReplaceBinExprOp_1(2L, this.EnclosingModuleDefinition.ModuleKind, ModuleKindEnum.Abstract);
            sig.VisibilityScope = new VisibilityScope();
            sig.VisibilityScope.Augment(ThisScope);
            this.Signature = sig;
        }

        public override object Dereference() { return this; }
        public override bool CanBeExported()
        {
            return MutateCSharp.Schemata128.ReplaceBooleanConstant_0(3L, false);
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            var innerIndent = MutateCSharp.Schemata128.ReplaceBinExprOp_2(4L, indentBefore, formatter.SpaceTab);
            var revealExportIndent = MutateCSharp.Schemata128.ReplaceBinExprOp_2(13L, innerIndent, formatter.SpaceTab);
            var commaIndent = innerIndent;
            foreach (var token in OwnedTokens)
            {
                switch (token.val)
                {
                    case "export":
                        {
                            formatter.SetOpeningIndentedRegion(token, indentBefore);
                            break;
                        }

                        break;
                    case "extends":
                    case "reveals":
                    case "provides":
                        {
                            if (TokenNewIndentCollector.IsFollowedByNewline(token))
                            {
                                formatter.SetOpeningIndentedRegion(token, innerIndent);
                                revealExportIndent = innerIndent + formatter.SpaceTab;
                                commaIndent = innerIndent + formatter.SpaceTab;
                            }
                            else
                            {
                                formatter.SetAlign(innerIndent, token, out revealExportIndent, out commaIndent);
                            }

                            break;
                        }

                        break;
                    case ",":
                        {
                            formatter.SetIndentations(token, above: revealExportIndent, inline: commaIndent, below: revealExportIndent);
                            break;
                        }

                        break;
                }
            }

            return MutateCSharp.Schemata128.ReplaceBooleanConstant_0(22L, true);
        }

        public override string GetTriviaContainingDocstring()
        {
            if (MutateCSharp.Schemata128.ReplaceBinExprOp_3(23L, Tok.TrailingTrivia.Trim(), ""))
            {
                return Tok.TrailingTrivia;
            }

            return GetTriviaContainingDocstringFromStartTokenOrNull();
        }
    }
}