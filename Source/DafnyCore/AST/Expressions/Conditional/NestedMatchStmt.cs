using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata42
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT42");
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

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.DatatypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class NestedMatchStmt : Statement, ICloneable<NestedMatchStmt>, ICanFormat, INestedMatch, ICanResolve
    {
        public Expression Source { get; }

        public string MatchTypeName => MutateCSharp.Schemata42.ReplaceStringConstant_0(1L, "statement");
        public readonly List<NestedMatchCaseStmt> Cases;
        public readonly bool UsesOptionalBraces;

        [FilledInDuringResolution]
        public Statement Flattened { get; set; }

        private void InitializeAttributes()
        {
            // Default case for match is false
            bool splitMatch = Attributes.Contains(this.Attributes, MutateCSharp.Schemata42.ReplaceStringConstant_0(2L, "split"));
            Attributes.ContainsBool(this.Attributes, MutateCSharp.Schemata42.ReplaceStringConstant_0(3L, "split"), ref splitMatch);
            foreach (var c in this.Cases)
            {
                if (!Attributes.Contains(c.Attributes, MutateCSharp.Schemata42.ReplaceStringConstant_0(4L, "split")))
                {
                    List<Expression> args = new List<Expression>();
                    args.Add(Expression.CreateBoolLiteral(c.Tok, splitMatch));
                    Attributes attrs = new Attributes(MutateCSharp.Schemata42.ReplaceStringConstant_0(5L, "split"), args, c.Attributes);
                    c.Attributes = attrs;
                }
            }
        }

        public NestedMatchStmt Clone(Cloner cloner)
        {
            return new NestedMatchStmt(cloner, this);
        }

        public NestedMatchStmt(Cloner cloner, NestedMatchStmt original) : base(cloner, original)
        {
            Source = cloner.CloneExpr(original.Source);
            Cases = original.Cases.ConvertAll(cloner.CloneNestedMatchCaseStmt);
            UsesOptionalBraces = original.UsesOptionalBraces;
            if (cloner.CloneResolvedFields)
            {
                Flattened = cloner.CloneStmt(original.Flattened, MutateCSharp.Schemata42.ReplaceBooleanConstant_1(6L, false));
            }
        }

        public override IEnumerable<INode> Children => new[] { Source }.Concat<Node>(Cases);

        public override IEnumerable<Statement> SubStatements => Cases.SelectMany(c => c.Body);

        public override IEnumerable<Statement> PreResolveSubStatements { get => this.Cases.SelectMany(oneCase => oneCase.Body); }

        public override IEnumerable<Expression> NonSpecificationSubExpressions
        {
            get
            {
                foreach (var e in base.NonSpecificationSubExpressions)
                {
                    yield return e;
                }
                yield return Source;
                foreach (var mc in Cases)
                {
                    foreach (var ee in mc.Pat.SubExpressions)
                    {
                        yield return ee;
                    }
                }

                yield break;
            }
        }

        public NestedMatchStmt(RangeToken rangeToken, Expression source, [Captured] List<NestedMatchCaseStmt> cases, bool usesOptionalBraces, Attributes attrs = null)
          : base(rangeToken, attrs)
        {
            Contract.Requires(source != null);
            Contract.Requires(cce.NonNullElements(cases));
            this.Source = source;
            this.Cases = cases;
            this.UsesOptionalBraces = usesOptionalBraces;
            InitializeAttributes();
        }

        /// <summary>
        /// Resolves a NestedMatchStmt by
        /// 1 - checking that all of its patterns are linear
        /// 2 - desugaring it into a decision tree of MatchStmt and IfStmt (for constant matching)
        /// 3 - resolving the generated (sub)statement.
        /// </summary>
        public void Resolve(ModuleResolver resolver, ResolutionContext resolutionContext)
        {
            resolver.ResolveExpression(Source, resolutionContext);

            if (Source.Type is TypeProxy)
            {
                resolver.PartiallySolveTypeConstraints(MutateCSharp.Schemata42.ReplaceBooleanConstant_1(7L, true));

                if (Source.Type is TypeProxy)
                {
                    resolver.Reporter.Error(MessageSource.Resolver, Tok, MutateCSharp.Schemata42.ReplaceStringConstant_0(8L, "Could not resolve the type of the source of the match statement. Please provide additional typing annotations."));
                    return;
                }
            }

            var errorCount = resolver.Reporter.Count(ErrorLevel.Error);
            var sourceType = resolver.PartiallyResolveTypeForMemberSelection(Source.tok, Source.Type).NormalizeExpand();
            this.CheckLinearNestedMatchStmt(sourceType, resolutionContext, resolver);
            if (MutateCSharp.Schemata42.ReplaceBinExprOp_2(9L, resolver.Reporter.Count(ErrorLevel.Error), errorCount))
            {
                return;
            }

            var dtd = sourceType.AsDatatype;
            var subst = new Dictionary<TypeParameter, Type>();
            if (MutateCSharp.Schemata42.ReplaceBinExprOp_3(14L, dtd, null))
            {
                // build the type-parameter substitution map for this use of the datatype
                subst = TypeParameter.SubstitutionMap(dtd.TypeArgs, sourceType.TypeArgs);
            }

            foreach (var _case in Cases)
            {
                resolver.Scope.PushMarker();
                _case.Resolve(resolver, resolutionContext, subst, sourceType);
                resolver.Scope.PopMarker();
            }
        }

        public void CheckLinearNestedMatchStmt(Type dtd, ResolutionContext resolutionContext, ModuleResolver resolver)
        {
            foreach (NestedMatchCaseStmt mc in this.Cases)
            {
                resolver.scope.PushMarker();
                resolver.ResolveAttributes(mc, resolutionContext);
                mc.CheckLinearNestedMatchCase(dtd, resolutionContext, resolver);
                resolver.scope.PopMarker();
            }
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            return formatter.SetIndentCases(indentBefore, OwnedTokens.Concat(Cases.SelectMany(oneCase => oneCase.OwnedTokens)).OrderBy(token => token.pos), () =>
            {
                foreach (var e in PreResolveSubExpressions)
                {
                    formatter.Visit(e, indentBefore);
                }
                foreach (var s in PreResolveSubStatements)
                {
                    formatter.Visit(s, indentBefore);
                }
            });
        }
    }
}
