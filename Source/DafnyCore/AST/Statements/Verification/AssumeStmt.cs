using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Microsoft.Dafny.Auditor;
namespace MutateCSharp
{
    internal class Schemata173
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT173");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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
    public class AssumeStmt : PredicateStmt, ICloneable<AssumeStmt>, ICanFormat
    {
        public AssumeStmt Clone(Cloner cloner)
        {
            return new AssumeStmt(cloner, this);
        }

        public AssumeStmt(Cloner cloner, AssumeStmt original) : base(cloner, original)
        {
        }

        public AssumeStmt(RangeToken rangeToken, Expression expr, Attributes attrs)
          : base(rangeToken, expr, attrs)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(expr != null);
        }
        public override IEnumerable<Expression> SpecificationSubExpressions
        {
            get
            {
                foreach (var e in base.SpecificationSubExpressions) { yield return e; }
                yield return Expr;
            }
        }

        public override IEnumerable<Assumption> Assumptions(Declaration decl)
        {
            yield return new Assumption(decl, tok, AssumptionDescription.AssumeStatement(
              Attributes.Contains(Attributes, Attributes.AxiomAttributeName)));
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            return formatter.SetIndentAssertLikeStatement(this, indentBefore);
        }

        public override void GenResolve(INewOrOldResolver resolver, ResolutionContext context)
        {
            base.GenResolve(resolver, context);

            if (MutateCSharp.Schemata173.ReplaceBinExprOp_0(1L, () => !resolver.Options.Get(CommonOptionBag.AllowAxioms), () => !this.IsExplicitAxiom()))
            {
                resolver.Reporter.Warning(MessageSource.Verifier, ResolutionErrors.ErrorId.r_assume_statement_without_axiom, Tok, MutateCSharp.Schemata173.ReplaceStringConstant_1(7L, "assume statement has no {:axiom} annotation"));
            }
        }
    }
}
