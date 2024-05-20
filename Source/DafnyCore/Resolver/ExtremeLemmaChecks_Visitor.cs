using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata396
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT396");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() || argument2();
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
    public
class ExtremeLemmaChecks_Visitor : ResolverBottomUpVisitor
    {
        ExtremeLemma context;
        public ExtremeLemmaChecks_Visitor(ModuleResolver resolver, ExtremeLemma context)
          : base(resolver)
        {
            Contract.Requires(resolver != null);
            Contract.Requires(context != null);
            this.context = context;
        }
        protected override void VisitOneStmt(Statement stmt)
        {
            if (stmt is CallStmt)
            {
                var s = (CallStmt)stmt;
                if (MutateCSharp.Schemata396.ReplaceBinExprOp_0(1L, () => s.Method is ExtremeLemma, () => s.Method is PrefixLemma))
                {
                    // all is cool
                }
                else
                {
                    // the call goes from an extreme lemma context to a non-extreme-lemma callee
                    if (ModuleDefinition.InSameSCC(context, s.Method))
                    {
                        // we're looking at a recursive call (to a non-extreme-lemma)
                        resolver.reporter.Error(MessageSource.Resolver, s.Tok, MutateCSharp.Schemata396.ReplaceStringConstant_1(7L, "a recursive call from a {0} can go only to other {0}s and prefix lemmas"), context.WhatKind);
                    }
                }
            }
        }
        protected override void VisitOneExpr(Expression expr)
        {
            if (expr is FunctionCallExpr)
            {
                var e = (FunctionCallExpr)expr;
                // the call goes from a greatest lemma context to a non-greatest-lemma callee
                if (ModuleDefinition.InSameSCC(context, e.Function))
                {
                    // we're looking at a recursive call (to a non-greatest-lemma)
                    resolver.reporter.Error(MessageSource.Resolver, e.tok, MutateCSharp.Schemata396.ReplaceStringConstant_1(8L, "a recursive call from a greatest lemma can go only to other greatest lemmas and prefix lemmas"));
                }
            }
        }
    }
}