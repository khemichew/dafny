using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata40
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT40");
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

        internal static bool ReplaceBinExprOp_1(long mutantId, int argument1, int argument2)
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
    public class NestedMatchCaseStmt : NestedMatchCase, IAttributeBearingDeclaration, ICloneable<NestedMatchCaseStmt>
    {
        public readonly List<Statement> Body;
        public Attributes Attributes { get; set; }

        public NestedMatchCaseStmt(RangeToken rangeToken, ExtendedPattern pat, List<Statement> body) : base(rangeToken.StartToken, pat)
        {
            RangeToken = rangeToken;
            Contract.Requires(body != null);
            this.Body = body;
            this.Attributes = null;
        }
        public NestedMatchCaseStmt(IToken tok, ExtendedPattern pat, List<Statement> body, Attributes attrs) : base(tok, pat)
        {
            Contract.Requires(body != null);
            this.Body = body;
            this.Attributes = attrs;
        }

        private NestedMatchCaseStmt(Cloner cloner, NestedMatchCaseStmt original) : base(original.tok, original.Pat)
        {
            this.Body = original.Body.Select(stmt => cloner.CloneStmt(stmt, MutateCSharp.Schemata40.ReplaceBooleanConstant_0(1L, false))).ToList();
            this.Attributes = cloner.CloneAttributes(original.Attributes);
        }

        public NestedMatchCaseStmt Clone(Cloner cloner)
        {
            return new NestedMatchCaseStmt(cloner, this);
        }
        public override IEnumerable<INode> Children => new[] { Pat }.Concat<Node>(Body).Concat(Attributes?.Args ?? Enumerable.Empty<Node>());
        public override IEnumerable<INode> PreResolveChildren => Children;

        public void Resolve(
          ModuleResolver resolver,
          ResolutionContext resolutionContext,
          Dictionary<TypeParameter, Type> subst,
          Type sourceType)
        {
            var beforeResolveErrorCount = resolver.Reporter.ErrorCount;

            Pat.Resolve(resolver, resolutionContext, sourceType, resolutionContext.IsGhost, MutateCSharp.Schemata40.ReplaceBooleanConstant_0(2L, true), MutateCSharp.Schemata40.ReplaceBooleanConstant_0(3L, false), MutateCSharp.Schemata40.ReplaceBooleanConstant_0(4L, false));

            // In Dafny, any bound variables introduced in a pattern are in scope throughout the case body, and cannot be shadowed at the top-level
            // of the case body. Because the machinery above creates, for each bound variable, a local variable with the same name and declares that
            // local variable in the case body, we introduce a new scope boundary around the body.
            resolver.Scope.PushMarker();
            resolver.ResolveAttributes(this, resolutionContext);
            var afterResolveErrorCount = resolver.Reporter.ErrorCount;
            if (MutateCSharp.Schemata40.ReplaceBinExprOp_1(5L, beforeResolveErrorCount, afterResolveErrorCount))
            {
                resolver.DominatingStatementLabels.PushMarker();
                foreach (Statement ss in Body)
                {
                    resolver.ResolveStatementWithLabels(ss, resolutionContext);
                }
                resolver.DominatingStatementLabels.PopMarker();
            }
            resolver.Scope.PopMarker();
        }
    }
}
