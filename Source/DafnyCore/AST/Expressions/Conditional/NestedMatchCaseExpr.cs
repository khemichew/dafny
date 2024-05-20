using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata39
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT39");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
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

        internal static string ReplaceStringConstant_3(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public class NestedMatchCaseExpr : NestedMatchCase, IAttributeBearingDeclaration
    {
        public Expression Body;
        public Attributes Attributes { get; set; }

        public NestedMatchCaseExpr(IToken tok, ExtendedPattern pat, Expression body, Attributes attrs) : base(tok, pat)
        {
            Contract.Requires(body != null);
            this.Body = body;
            this.Attributes = attrs;
        }

        public override IEnumerable<INode> Children =>
          (MutateCSharp.Schemata39.ReplaceBinExprOp_0(1L, Attributes, null) ? new Node[] { Attributes } : Enumerable.Empty<Node>()).Concat(new Node[] { Body, Pat });

        public override IEnumerable<INode> PreResolveChildren => Children;

        public void Resolve(ModuleResolver resolver,
          ResolutionContext resolutionContext,
          Type resultType,
          Type sourceType)
        {
            var beforeResolveErrorCount = resolver.reporter.ErrorCount;

            Pat.Resolve(resolver, resolutionContext, sourceType, resolutionContext.IsGhost, MutateCSharp.Schemata39.ReplaceBooleanConstant_1(2L, false), MutateCSharp.Schemata39.ReplaceBooleanConstant_1(3L, false), MutateCSharp.Schemata39.ReplaceBooleanConstant_1(4L, false));

            resolver.ResolveAttributes(this, resolutionContext);
            var afterResolveErrorCount = resolver.reporter.ErrorCount;
            if (MutateCSharp.Schemata39.ReplaceBinExprOp_2(5L, beforeResolveErrorCount, afterResolveErrorCount))
            {
                resolver.ResolveExpression(Body, resolutionContext);
                resolver.ConstrainSubtypeRelation(resultType, Body.Type, Body.tok, MutateCSharp.Schemata39.ReplaceStringConstant_3(10L, "type of case bodies do not agree (found {0}, previous types {1})"), Body.Type, resultType);
            }
        }
    }
}
