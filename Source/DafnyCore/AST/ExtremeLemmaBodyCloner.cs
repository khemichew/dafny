using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata82
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT82");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.ExtremePredicate argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static string ReplaceStringConstant_5(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.MemberSelectExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.FunctionCallExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Type> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.ExprRhs argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public
/// <summary>
/// The task of the ExtremeLemmaBodyCloner is to fill in the implicit _k-1 arguments in recursive least/greatest lemma calls
/// and in calls to the focal predicates.
/// The source statement and the given "k" are assumed to have been resolved.
/// </summary>
class ExtremeLemmaBodyCloner : ExtremeCloner
    {
        readonly ExtremeLemma context;
        readonly ISet<ExtremePredicate> focalPredicates;
        public ExtremeLemmaBodyCloner(ExtremeLemma context, Expression k, ISet<ExtremePredicate> focalPredicates, ErrorReporter reporter)
          : base(k, reporter)
        {
            Contract.Requires(context != null);
            Contract.Requires(k != null);
            Contract.Requires(reporter != null);
            this.context = context;
            this.focalPredicates = focalPredicates;
        }

        public override Expression CloneExpr(Expression expr)
        {
            if (reporter.Options.RewriteFocalPredicates)
            {
                if (expr is FunctionCallExpr)
                {
                    var e = (FunctionCallExpr)expr;
#if DEBUG_PRINT
          if (e.Function.Name.EndsWith("#") && Contract.Exists(focalPredicates, p => e.Function.Name == p.Name + "#")) {
            Options.Writer.WriteLine("{0}({1},{2}): DEBUG: Possible opportunity to rely on new rewrite: {3}", e.tok.filename, e.tok.line, e.tok.col, Printer.ExprToString(e));
          }
#endif
                    // Note, we don't actually ever get here, because all calls will have been parsed as ApplySuffix.
                    // However, if something changes in the future (for example, some rewrite that changing an ApplySuffix
                    // to its resolved FunctionCallExpr), then we do want this code, so with the hope of preventing
                    // some error in the future, this case is included.  (Of course, it is currently completely untested!)
                    var f = e.Function as ExtremePredicate;
                    if (MutateCSharp.Schemata82.ReplaceBinExprOp_1(2L, () => MutateCSharp.Schemata82.ReplaceBinExprOp_0(1L, f, null), () => focalPredicates.Contains(f)))
                    {
#if DEBUG_PRINT
            var r = CloneCallAndAddK(e);
            Options.Writer.WriteLine("{0}({1},{2}): DEBUG: Rewrote extreme predicate into prefix predicate: {3}", e.tok.filename, e.tok.line, e.tok.col, Printer.ExprToString(r));
            return r;
#else
                        return CloneCallAndAddK(e);
#endif
                    }
                }
                else if (expr is StaticReceiverExpr ee)
                {
                    return new StaticReceiverExpr(Tok(ee.tok), ee.Type, ee.IsImplicit);
                }
                else if (expr is ApplySuffix)
                {
                    var apply = (ApplySuffix)expr;
                    if (!apply.WasResolved())
                    {
                        // Since we're assuming the enclosing statement to have been resolved, this ApplySuffix must
                        // be part of an ExprRhs that actually designates a method call.  Such an ApplySuffix does
                        // not get listed as being resolved, but its components (like its .Lhs) are resolved.
                        var mse = (MemberSelectExpr)apply.Lhs.Resolved;
                        Contract.Assume(mse.Member is Method);
                    }
                    else
                    {
                        var fce = apply.Resolved as FunctionCallExpr;
                        if (MutateCSharp.Schemata82.ReplaceBinExprOp_2(8L, fce, null))
                        {
#if DEBUG_PRINT
              if (fce.Function.Name.EndsWith("#") && Contract.Exists(focalPredicates, p => fce.Function.Name == p.Name + "#")) {
                Options.Writer.WriteLine("{0}({1},{2}): DEBUG: Possible opportunity to rely on new rewrite: {3}", fce.tok.filename, fce.tok.line, fce.tok.col, Printer.ExprToString(fce));
              }
#endif
                            var f = fce.Function as ExtremePredicate;
                            if (MutateCSharp.Schemata82.ReplaceBinExprOp_1(10L, () => MutateCSharp.Schemata82.ReplaceBinExprOp_0(9L, f, null), () => focalPredicates.Contains(f)))
                            {
#if DEBUG_PRINT
                var r = CloneCallAndAddK(fce);
                Options.Writer.WriteLine("{0}({1},{2}): DEBUG: Rewrote extreme predicate into prefix predicate: {3}", fce.tok.filename, fce.tok.line, fce.tok.col, Printer.ExprToString(r));
                return r;
#else
                                return CloneCallAndAddK(fce);
#endif
                            }
                        }
                    }
                }
            }
            return base.CloneExpr(expr);
        }
        public override AssignmentRhs CloneRHS(AssignmentRhs rhs)
        {
            var r = rhs as ExprRhs;
            if (MutateCSharp.Schemata82.ReplaceBinExprOp_1(17L, () => MutateCSharp.Schemata82.ReplaceBinExprOp_3(16L, r, null), () => r.Expr is ApplySuffix))
            {
                var apply = (ApplySuffix)r.Expr;
                var mse = apply.Lhs.Resolved as MemberSelectExpr;
                if (MutateCSharp.Schemata82.ReplaceBinExprOp_1(30L, () => MutateCSharp.Schemata82.ReplaceBinExprOp_1(24L, () => MutateCSharp.Schemata82.ReplaceBinExprOp_4(23L, mse, null), () => mse.Member is ExtremeLemma), () => ModuleDefinition.InSameSCC(context, (ExtremeLemma)mse.Member)))
                {
                    // we're looking at a recursive call to an extreme lemma
                    Contract.Assert(apply.Lhs is NameSegment || apply.Lhs is ExprDotName);  // this is the only way a call statement can have been parsed
                                                                                            // clone "apply.Lhs", changing the least/greatest lemma to the prefix lemma; then clone "apply", adding in the extra argument
                    Expression lhsClone;
                    if (apply.Lhs is NameSegment)
                    {
                        var lhs = (NameSegment)apply.Lhs;
                        lhsClone = new NameSegment(Tok(lhs.tok), lhs.Name + MutateCSharp.Schemata82.ReplaceStringConstant_5(36L, "#"), MutateCSharp.Schemata82.ReplaceBinExprOp_6(37L, lhs.OptTypeArguments, null) ? null : lhs.OptTypeArguments.ConvertAll(CloneType));
                    }
                    else
                    {
                        var lhs = (ExprDotName)apply.Lhs;
                        lhsClone = new ExprDotName(Tok(lhs.tok), CloneExpr(lhs.Lhs), lhs.SuffixName + MutateCSharp.Schemata82.ReplaceStringConstant_5(38L, "#"), MutateCSharp.Schemata82.ReplaceBinExprOp_6(39L, lhs.OptTypeArguments, null) ? null : lhs.OptTypeArguments.ConvertAll(CloneType));
                    }
                    var args = new List<ActualBinding>();
                    args.Add(new ActualBinding(null, k));
                    apply.Bindings.ArgumentBindings.ForEach(arg => args.Add(CloneActualBinding(arg)));
                    var applyClone = new ApplySuffix(Tok(apply.tok), MutateCSharp.Schemata82.ReplaceBinExprOp_7(40L, apply.AtTok, null) ? null : Tok(apply.AtTok),
                      lhsClone, args, Tok(apply.CloseParen));
                    var c = new ExprRhs(applyClone, CloneAttributes(rhs.Attributes));
                    reporter.Info(MessageSource.Cloner, apply.Lhs.tok, mse.Member.Name + suffix);
                    return c;
                }
            }
            return base.CloneRHS(rhs);
        }
    }
}
