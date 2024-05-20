using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata48
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT48");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.Expression argument1, Microsoft.Dafny.Expression argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.Expression argument1, Microsoft.Dafny.Expression argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class DatatypeUpdateExpr : ConcreteSyntaxExpression, IHasUsages, ICloneable<DatatypeUpdateExpr>
    {
        public readonly Expression Root;
        public readonly List<Tuple<IToken, string, Expression>> Updates;
        [FilledInDuringResolution] public List<MemberDecl> Members;
        [FilledInDuringResolution] public List<DatatypeCtor> LegalSourceConstructors;
        [FilledInDuringResolution] public bool InCompiledContext;
        [FilledInDuringResolution] public Expression ResolvedCompiledExpression; // see comment for Resolver.ResolveDatatypeUpdate

        public DatatypeUpdateExpr Clone(Cloner cloner)
        {
            return new DatatypeUpdateExpr(cloner, this);
        }

        public DatatypeUpdateExpr(Cloner cloner, DatatypeUpdateExpr original) : base(cloner, original)
        {
            Root = cloner.CloneExpr(original.Root);
            Updates = original.Updates.Select(t => Tuple.Create<IToken, string, Expression>(cloner.Tok((IToken)t.Item1), t.Item2, cloner.CloneExpr(t.Item3)))
              .ToList();

            if (cloner.CloneResolvedFields)
            {
                Members = original.Members;
                LegalSourceConstructors = original.LegalSourceConstructors;
                InCompiledContext = original.InCompiledContext;
                if (MutateCSharp.Schemata48.ReplaceBinExprOp_0(1L, original.ResolvedExpression, original.ResolvedCompiledExpression))
                {
                    ResolvedCompiledExpression = ResolvedExpression;
                }
                else
                {
                    ResolvedCompiledExpression = cloner.CloneExpr(original.ResolvedCompiledExpression);
                }
            }
        }

        public DatatypeUpdateExpr(IToken tok, Expression root, List<Tuple<IToken, string, Expression>> updates)
          : base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(root != null);
            Contract.Requires(updates != null);
            Contract.Requires(updates.Count != 0);
            Root = root;
            Updates = updates;
        }

        public override IEnumerable<Expression> SubExpressions
        {
            get
            {
                if (MutateCSharp.Schemata48.ReplaceBinExprOp_1(2L, ResolvedExpression, null))
                {
                    Contract.Assert(ResolvedCompiledExpression == null);
                    foreach (var preResolved in PreResolveSubExpressions)
                    {
                        yield return preResolved;
                    }
                }
                else
                {
                    foreach (var e in base.SubExpressions)
                    {
                        yield return e;
                    }
                    if (MutateCSharp.Schemata48.ReplaceBinExprOp_2(3L, ResolvedExpression, ResolvedCompiledExpression))
                    {
                        yield return ResolvedCompiledExpression;
                    }
                }

                yield break;
            }
        }

        public IEnumerable<IDeclarationOrUsage> GetResolvedDeclarations()
        {
            return (IEnumerable<IDeclarationOrUsage>)LegalSourceConstructors ?? Array.Empty<IDeclarationOrUsage>();
        }

        public IToken NameToken => tok;

        public override IEnumerable<Expression> PreResolveSubExpressions
        {
            get
            {
                yield return Root;
                foreach (var update in Updates)
                {
                    yield return update.Item3;
                }

                yield break;
            }
        }
    }
}