using System;
using System.Collections.Generic;
using System.Linq;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
namespace MutateCSharp
{
    internal class Schemata96
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT96");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public interface IDeclarationOrUsage : INode
    {
        IToken NameToken { get; }
    }

    public interface IHasUsages : IDeclarationOrUsage
    {
        public IEnumerable<IDeclarationOrUsage> GetResolvedDeclarations();
    }

    /// <summary>
    /// A symbol that potential has something to verify
    /// </summary>
    public interface ICanVerify : ISymbol
    {
        ModuleDefinition ContainingModule { get; }

        /// <summary>
        /// Return true if this symbol has something to verify.
        /// If true is incorrectly returned, the IDE will allow the user to verify this but it'll pass immediately.
        /// </summary>
        bool ShouldVerify { get; }
        string FullDafnyName { get; }
    }

    public interface IFrameScope
    {
        string Designator { get; }
    }

    public static class AstExtensions
    {

        public static string GetMemberQualification(MemberDecl memberDecl)
        {
            if (MutateCSharp.Schemata96.ReplaceBinExprOp_0(1L, memberDecl.EnclosingClass, null))
            {
                // If traversing up the AST is already made available after parsing, this branch can be removed.
                return "";
            }
            return MutateCSharp.Schemata96.ReplaceBinExprOp_2(3L, memberDecl.EnclosingClass.Name, MutateCSharp.Schemata96.ReplaceStringConstant_1(2L, "_default")) ? "" : $"{memberDecl.EnclosingClass.Name}.";
        }

        /// <summary>
        /// Returns a text representation of the given variable.
        /// </summary>
        /// <param name="variable">The variable to get a text representation of.</param>
        /// <returns>The text representation of the variable.</returns>
        public static string AsText(this IVariable variable)
        {
            var ghost = variable.IsGhost ? MutateCSharp.Schemata96.ReplaceStringConstant_1(4L, "ghost ") : "";
            string type;
            try
            {
                type = variable.Type.ToString();
            }
            catch (Exception e)
            {
                type = $"<Internal error: {e.Message}>";
            }
            return $"{ghost}{variable.Name}: {type}";
        }
    }

    public interface ISymbol : IDeclarationOrUsage
    {
        SymbolKind Kind { get; }

        string GetDescription(DafnyOptions options);
    }

    public interface IHasSymbolChildren : ISymbol
    {
        IEnumerable<ISymbol> ChildSymbols { get; }
    }

    public static class SymbolExtensions
    {

        public static ISet<ISymbol> GetSymbolDescendants(ISymbol node)
        {
            var todo = new Stack<ISymbol>();
            todo.Push(node);
            var result = new HashSet<ISymbol>();
            while (todo.Any())
            {
                var current = todo.Pop();
                result.Add(current);
                if (current is IHasSymbolChildren hasChildren)
                {
                    foreach (var child in hasChildren.ChildSymbols)
                    {
                        todo.Push(child);
                    }
                }
            }
            return result;
        }
    }
}