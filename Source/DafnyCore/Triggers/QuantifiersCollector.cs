// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata473
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT473");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.OldExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceNumericConstant_0(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBooleanConstant_4(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.ComprehensionExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny.Triggers
{
    public class QuantifierCollector : TopDownVisitor<OldExpr/*?*/>
    {
        readonly ErrorReporter reporter;
        private readonly HashSet<Expression> quantifiers = new HashSet<Expression>();
        internal readonly Dictionary<Expression, HashSet<OldExpr>> exprsInOldContext = new Dictionary<Expression, HashSet<OldExpr>>();
        internal readonly List<ComprehensionTriggerGenerator> quantifierCollections = new List<ComprehensionTriggerGenerator>();

        public QuantifierCollector(ErrorReporter reporter)
        {
            Contract.Requires(reporter != null);
            this.reporter = reporter;
        }

        protected override bool VisitOneExpr(Expression expr, ref OldExpr/*?*/ enclosingOldContext)
        {
            // only consider quantifiers that are not empty (Bound.Vars.Count > 0)
            if (expr is ComprehensionExpr e && e.BoundVars.Count > 0 && !quantifiers.Contains(e))
            {
                if (e is SetComprehension or MapComprehension)
                {
                    quantifiers.Add(e);
                    quantifierCollections.Add(new ComprehensionTriggerGenerator(e, Enumerable.Repeat(e, MutateCSharp.Schemata473.ReplaceNumericConstant_0(1L, 1)), reporter));
                }
                else if (e is QuantifierExpr quantifier)
                {
                    quantifiers.Add(quantifier);
                    if (MutateCSharp.Schemata473.ReplaceBinExprOp_1(5L, quantifier.SplitQuantifier, null))
                    {
                        var collection = quantifier.SplitQuantifier.Select(q => q as ComprehensionExpr).Where(q => MutateCSharp.Schemata473.ReplaceBinExprOp_2(6L, q, null));
                        quantifierCollections.Add(new ComprehensionTriggerGenerator(e, collection, reporter));
                        quantifiers.UnionWith(quantifier.SplitQuantifier);
                    }
                    else
                    {
                        quantifierCollections.Add(new ComprehensionTriggerGenerator(e, Enumerable.Repeat(quantifier, MutateCSharp.Schemata473.ReplaceNumericConstant_0(7L, 1)), reporter));
                    }
                }
            }

            if (expr is OldExpr oldExpr)
            {
                enclosingOldContext = oldExpr;
            }
            else if (MutateCSharp.Schemata473.ReplaceBinExprOp_3(11L, enclosingOldContext, null))
            { // FIXME be more restrctive on the type of stuff that we annotate
              // Add the association (expr, oldContext) to exprsInOldContext. However, due to chaining expressions,
              // expr may already be a key in exprsInOldContext.
                if (exprsInOldContext.TryGetValue(expr, out var prevValue))
                {
                    prevValue.Add(enclosingOldContext);
                }
                else
                {
                    var single = new HashSet<OldExpr>() { enclosingOldContext };
                    exprsInOldContext.Add(expr, single);
                }
            }

            return MutateCSharp.Schemata473.ReplaceBooleanConstant_4(12L, true);
        }

        protected override bool VisitOneStmt(Statement stmt, ref OldExpr/*?*/ st)
        {
            if (stmt is ForallStmt)
            {
                ForallStmt s = (ForallStmt)stmt;
                if (MutateCSharp.Schemata473.ReplaceBinExprOp_1(13L, s.EffectiveEnsuresClauses, null))
                {
                    foreach (Expression expr in s.EffectiveEnsuresClauses)
                    {
                        VisitOneExpr(expr, ref st);
                    }
                }
            }
            return MutateCSharp.Schemata473.ReplaceBooleanConstant_4(14L, true);
        }
    }
}
