using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
namespace MutateCSharp
{
    internal class Schemata126
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT126");
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

        internal static int ReplaceNumericConstant_1(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
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

    /// <summary>
    /// Represents a submodule declaration at module level scope
    /// </summary>
    public abstract class ModuleDecl : TopLevelDecl, IHasDocstring, ISymbol
    {

        public DafnyOptions Options { get; }

        /// <summary>
        /// Only equivalent between modules if one is a clone of the other.
        /// This property is used to determine if two module declarations have the same contents when doing resolution caching
        /// This should be replaced by using content hashes of module declaration contents, at which point this property
        /// becomes obsolete.
        /// </summary>
        public Guid CloneId { get; }

        public override string WhatKind => MutateCSharp.Schemata126.ReplaceStringConstant_0(1L, "module");

        [FilledInDuringResolution]
        public ModuleSignature Signature { get; set; }

        public virtual ModuleSignature AccessibleSignature(bool ignoreExports)
        {
            Contract.Requires(Signature != null);
            return Signature;
        }
        public virtual ModuleSignature AccessibleSignature()
        {
            Contract.Requires(Signature != null);
            return Signature;
        }
        public int Height;

        public readonly bool Opened; // TODO: Only true for Abstract and Alias module declarations. It seems like they need a common superclass since there's also code of the form 'd is AliasModuleDecl || d is AbstractModuleDecl'

        protected ModuleDecl(Cloner cloner, ModuleDecl original, ModuleDefinition parent)
          : base(cloner, original, parent)
        {
            Options = original.Options;
            Opened = original.Opened;
            CloneId = original.CloneId;
        }

        protected ModuleDecl(DafnyOptions options, RangeToken rangeToken, Name name, ModuleDefinition parent, bool opened, bool isRefining, Guid cloneId)
          : base(rangeToken, name, parent, new List<TypeParameter>(), null, isRefining)
        {
            Options = options;
            Height = MutateCSharp.Schemata126.ReplaceNumericConstant_1(2L, -1);
            Signature = null;
            Opened = opened;
            CloneId = cloneId;
        }
        public abstract object Dereference();

        public override bool IsEssentiallyEmpty()
        {
            // A module or import is considered "essentially empty" to its parents, but the module is going to be resolved by itself.
            return MutateCSharp.Schemata126.ReplaceBooleanConstant_2(6L, true);
        }

        public virtual string GetTriviaContainingDocstring()
        {
            IToken candidate = null;
            var tokens = OwnedTokens.Any() ?
              OwnedTokens :
              PreResolveChildren.Any() ? PreResolveChildren.First().OwnedTokens : Enumerable.Empty<IToken>();
            foreach (var token in tokens)
            {
                if (MutateCSharp.Schemata126.ReplaceBinExprOp_3(8L, token.val, MutateCSharp.Schemata126.ReplaceStringConstant_0(7L, "{")))
                {
                    candidate = token.Prev;
                    if (MutateCSharp.Schemata126.ReplaceBinExprOp_4(9L, candidate.TrailingTrivia.Trim(), ""))
                    {
                        return candidate.TrailingTrivia;
                    }
                }
            }

            if (MutateCSharp.Schemata126.ReplaceBinExprOp_6(12L, () => MutateCSharp.Schemata126.ReplaceBinExprOp_5(10L, candidate, null), () => MutateCSharp.Schemata126.ReplaceBinExprOp_4(11L, EndToken.TrailingTrivia.Trim(), "")))
            {
                return EndToken.TrailingTrivia;
            }

            return GetTriviaContainingDocstringFromStartTokenOrNull();
        }

        public SymbolKind Kind => SymbolKind.Namespace;
        public string GetDescription(DafnyOptions options)
        {
            return $"module {Name}";
        }
    }
}