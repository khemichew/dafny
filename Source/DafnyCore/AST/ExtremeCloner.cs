using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata81
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT81");
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

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public
/// <summary>
/// Subclass of Cloner that collects some common functionality between ExtremeLemmaSpecificationSubstituter and
/// ExtremeLemmaBodyCloner.
/// </summary>
abstract class ExtremeCloner : Cloner
    {
        protected readonly Expression k;
        protected readonly ErrorReporter reporter;
        protected readonly string suffix;
        protected ExtremeCloner(Expression k, ErrorReporter reporter)
        {
            Contract.Requires(k != null);
            Contract.Requires(reporter != null);
            this.k = k;
            this.reporter = reporter;
            this.suffix = string.Format(MutateCSharp.Schemata81.ReplaceStringConstant_0(1L, "#[{0}]"), Printer.ExprToString(reporter.Options, k));
        }
        protected Expression CloneCallAndAddK(ApplySuffix e)
        {
            Contract.Requires(e != null);
            Contract.Requires(e.Resolved is FunctionCallExpr && ((FunctionCallExpr)e.Resolved).Function is ExtremePredicate);
            Contract.Requires(e.Lhs is NameSegment || e.Lhs is ExprDotName);
            if (this.CloneResolvedFields)
            {
                throw new NotImplementedException();
            }

            Expression lhs;
            string name;
            if (e.Lhs is NameSegment ns)
            {
                name = ns.Name;
                lhs = new NameSegment(Tok(ns.tok), name + MutateCSharp.Schemata81.ReplaceStringConstant_0(2L, "#"), ns.OptTypeArguments?.ConvertAll(CloneType));
            }
            else
            {
                var edn = (ExprDotName)e.Lhs;
                name = edn.SuffixName;
                lhs = new ExprDotName(Tok(edn.tok), CloneExpr(edn.Lhs), name + MutateCSharp.Schemata81.ReplaceStringConstant_0(3L, "#"), edn.OptTypeArguments?.ConvertAll(CloneType));
            }
            var args = new List<ActualBinding>();
            args.Add(new ActualBinding(null, k));
            foreach (var arg in e.Bindings.ArgumentBindings)
            {
                args.Add(CloneActualBinding(arg));
            }
            var apply = new ApplySuffix(Tok(e.tok), MutateCSharp.Schemata81.ReplaceBinExprOp_1(4L, e.AtTok, null) ? null : Tok(e.AtTok), lhs, args, Tok(e.CloseParen));
            reporter.Info(MessageSource.Cloner, e.tok, name + suffix);
            return apply;
        }

        protected Expression CloneCallAndAddK(FunctionCallExpr e)
        {
            Contract.Requires(e != null);
            Contract.Requires(e.Function is ExtremePredicate);
            if (CloneResolvedFields)
            {
                throw new NotImplementedException();
            }
            var receiver = CloneExpr(e.Receiver);
            var args = new List<ActualBinding>();
            args.Add(new ActualBinding(null, k));
            foreach (var binding in e.Bindings.ArgumentBindings)
            {
                args.Add(CloneActualBinding(binding));
            }
            var fexp = new FunctionCallExpr(Tok(e.tok), e.Name + MutateCSharp.Schemata81.ReplaceStringConstant_0(5L, "#"), receiver, e.OpenParen, e.CloseParen, args, e.AtLabel);
            reporter.Info(MessageSource.Cloner, e.tok, e.Name + suffix);
            return fexp;
        }
    }
}
