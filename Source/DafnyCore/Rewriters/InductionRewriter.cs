using System.Collections.Generic;
using System.Diagnostics.Contracts;
using static Microsoft.Dafny.RewriterErrors;
namespace MutateCSharp
{
    internal class Schemata450
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT450");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, Microsoft.Dafny.QuantifierExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static string ReplaceStringConstant_6(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_13(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.IdentifierExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_12(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 + argument2;
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

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_14(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

    }
}

namespace Microsoft.Dafny
{
    public class InductionRewriter : IRewriter
    {
        internal InductionRewriter(ErrorReporter reporter) : base(reporter)
        {
            Contract.Requires(reporter != null);
        }

        internal override void PostDecreasesResolve(ModuleDefinition m)
        {
            if (MutateCSharp.Schemata450.ReplaceBinExprOp_1(5L, Reporter.Options.Induction, MutateCSharp.Schemata450.ReplaceNumericConstant_0(1L, 0)))
            {
                // Don't bother inferring :induction attributes.  This will also have the effect of not warning about malformed :induction attributes
            }
            else
            {
                foreach (var decl in m.TopLevelDecls)
                {
                    if (decl is TopLevelDeclWithMembers)
                    {
                        var cl = (TopLevelDeclWithMembers)decl;
                        foreach (var member in cl.Members)
                        {
                            if (member is ExtremeLemma)
                            {
                                var method = (ExtremeLemma)member;
                                ProcessMethodExpressions(method);
                                ComputeLemmaInduction(method.PrefixLemma);
                                ProcessMethodExpressions(method.PrefixLemma);
                            }
                            else if (member is Method)
                            {
                                var method = (Method)member;
                                ComputeLemmaInduction(method);
                                ProcessMethodExpressions(method);
                            }
                            else if (member is ExtremePredicate)
                            {
                                var function = (ExtremePredicate)member;
                                ProcessFunctionExpressions(function);
                                ProcessFunctionExpressions(function.PrefixPredicate);
                            }
                            else if (member is Function)
                            {
                                var function = (Function)member;
                                ProcessFunctionExpressions(function);
                                if (MutateCSharp.Schemata450.ReplaceBinExprOp_2(10L, function.ByMethodDecl, null))
                                {
                                    ProcessMethodExpressions(function.ByMethodDecl);
                                }
                            }
                        }
                    }

                    if (decl is NewtypeDecl)
                    {
                        var nt = (NewtypeDecl)decl;
                        if (MutateCSharp.Schemata450.ReplaceBinExprOp_3(11L, nt.Constraint, null))
                        {
                            var visitor = new Induction_Visitor(this);
                            visitor.Visit(nt.Constraint);
                        }
                    }
                }
            }
        }

        void ProcessMethodExpressions(Method method)
        {
            Contract.Requires(method != null);
            var visitor = new Induction_Visitor(this);
            method.Req.ForEach(mfe => visitor.Visit(mfe.E));
            method.Ens.ForEach(mfe => visitor.Visit(mfe.E));
            if (MutateCSharp.Schemata450.ReplaceBinExprOp_4(12L, method.Body, null))
            {
                visitor.Visit(method.Body);
            }
        }

        void ProcessFunctionExpressions(Function function)
        {
            Contract.Requires(function != null);
            var visitor = new Induction_Visitor(this);
            function.Req.ForEach(visitor.Visit);
            function.Ens.ForEach(visitor.Visit);
            if (MutateCSharp.Schemata450.ReplaceBinExprOp_3(13L, function.Body, null))
            {
                visitor.Visit(function.Body);
            }
        }

        void ComputeLemmaInduction(Method method)
        {
            Contract.Requires(method != null);
            if (MutateCSharp.Schemata450.ReplaceBinExprOp_5(51L, () => MutateCSharp.Schemata450.ReplaceBinExprOp_5(45L, () => MutateCSharp.Schemata450.ReplaceBinExprOp_5(30L, () => MutateCSharp.Schemata450.ReplaceBinExprOp_5(15L, () => MutateCSharp.Schemata450.ReplaceBinExprOp_4(14L, method.Body, null), () => method.IsGhost), () => MutateCSharp.Schemata450.ReplaceBinExprOp_1(25L, method.Mod.Expressions.Count, MutateCSharp.Schemata450.ReplaceNumericConstant_0(21L, 0))), () => MutateCSharp.Schemata450.ReplaceBinExprOp_1(40L, method.Outs.Count, MutateCSharp.Schemata450.ReplaceNumericConstant_0(36L, 0))), () => !(method is ExtremeLemma)))
            {
                var specs = new List<Expression>();
                method.Req.ForEach(mfe => specs.Add(mfe.E));
                method.Ens.ForEach(mfe => specs.Add(mfe.E));
                ComputeInductionVariables(method.tok, method.Ins, specs, method, ref method.Attributes);
            }
        }

        void ComputeInductionVariables<VarType>(IToken tok, List<VarType> boundVars, List<Expression> searchExprs,
          Method lemma, ref Attributes attributes) where VarType : class, IVariable
        {
            Contract.Requires(tok != null);
            Contract.Requires(boundVars != null);
            Contract.Requires(searchExprs != null);
            Contract.Requires(Reporter.Options.Induction != 0);

            var args = Attributes.FindExpressions(attributes,
        MutateCSharp.Schemata450.ReplaceStringConstant_6(57L, "induction")); // we only look at the first one we find, since it overrides any other ones
            if (MutateCSharp.Schemata450.ReplaceBinExprOp_7(58L, args, null))
            {
                if (MutateCSharp.Schemata450.ReplaceBinExprOp_8(63L, Reporter.Options.Induction, MutateCSharp.Schemata450.ReplaceNumericConstant_0(59L, 2)))
                {
                    // No explicit induction variables and we're asked not to infer anything, so we're done
                    return;
                }
                else if (MutateCSharp.Schemata450.ReplaceBinExprOp_5(78L, () => MutateCSharp.Schemata450.ReplaceBinExprOp_1(72L, Reporter.Options.Induction, MutateCSharp.Schemata450.ReplaceNumericConstant_0(68L, 2)), () => MutateCSharp.Schemata450.ReplaceBinExprOp_2(77L, lemma, null)))
                {
                    // We're asked to infer induction variables only for quantifiers, not for lemmas
                    return;
                }
                else if (MutateCSharp.Schemata450.ReplaceBinExprOp_5(94L, () => MutateCSharp.Schemata450.ReplaceBinExprOp_1(88L, Reporter.Options.Induction, MutateCSharp.Schemata450.ReplaceNumericConstant_0(84L, 4)), () => MutateCSharp.Schemata450.ReplaceBinExprOp_9(93L, lemma, null)))
                {
                    // We're asked to infer induction variables only for lemmas, not for quantifiers
                    return;
                }
                // GO INFER below (only select boundVars)
            }
            else if (MutateCSharp.Schemata450.ReplaceBinExprOp_1(104L, args.Count, MutateCSharp.Schemata450.ReplaceNumericConstant_0(100L, 0)))
            {
                // {:induction} is treated the same as {:induction true}, which says to automatically infer induction variables
                // GO INFER below (all boundVars)
            }
            else if (MutateCSharp.Schemata450.ReplaceBinExprOp_5(132L, () => MutateCSharp.Schemata450.ReplaceBinExprOp_5(122L, () => MutateCSharp.Schemata450.ReplaceBinExprOp_1(113L, args.Count, MutateCSharp.Schemata450.ReplaceNumericConstant_0(109L, 1)), () => args[MutateCSharp.Schemata450.ReplaceNumericConstant_0(118L, 0)] is LiteralExpr), () => ((LiteralExpr)args[MutateCSharp.Schemata450.ReplaceNumericConstant_0(128L, 0)]).Value is bool))
            {
                // {:induction false} or {:induction true}
                if (!(bool)((LiteralExpr)args[MutateCSharp.Schemata450.ReplaceNumericConstant_0(138L, 0)]).Value)
                {
                    // we're told not to infer anything
                    return;
                }
                // GO INFER below (all boundVars)
            }
            else
            {
                // Here, we're expecting the arguments to {:induction args} to be a sublist of "this;boundVars", where "this" is allowed only
                // if "lemma" denotes an instance lemma.
                var goodArguments = new List<Expression>();
                var i = MutateCSharp.Schemata450.ReplaceBinExprOp_5(143L, () => MutateCSharp.Schemata450.ReplaceBinExprOp_2(142L, lemma, null), () => !lemma.IsStatic
          ) ? MutateCSharp.Schemata450.ReplaceNumericConstant_0(149L, -1
          ) : MutateCSharp.Schemata450.ReplaceNumericConstant_0(153L, 0); // -1 says it's okay to see "this" or any other parameter; 0 <= i says it's okay to see parameter i or higher
                foreach (var arg in args)
                {
                    var ie = arg.Resolved as IdentifierExpr;
                    if (MutateCSharp.Schemata450.ReplaceBinExprOp_10(157L, ie, null))
                    {
                        var j = boundVars.FindIndex(v => v == ie.Var);
                        if (MutateCSharp.Schemata450.ReplaceBinExprOp_5(172L, () => MutateCSharp.Schemata450.ReplaceBinExprOp_11(162L, MutateCSharp.Schemata450.ReplaceNumericConstant_0(158L, 0), j), () => MutateCSharp.Schemata450.ReplaceBinExprOp_11(167L, i, j)))
                        {
                            goodArguments.Add(ie);
                            i = MutateCSharp.Schemata450.ReplaceBinExprOp_12(182L, j, MutateCSharp.Schemata450.ReplaceNumericConstant_0(178L, 1));
                            continue;
                        }

                        if (MutateCSharp.Schemata450.ReplaceBinExprOp_11(195L, MutateCSharp.Schemata450.ReplaceNumericConstant_0(191L, 0), j))
                        {
                            ReportWarning(ErrorId.rw_induction_arguments_quantifier_mismatch, arg.tok,
                MutateCSharp.Schemata450.ReplaceStringConstant_6(200L, "{0}s given as :induction arguments must be given in the same order as in the {1}; ignoring attribute"),
                MutateCSharp.Schemata450.ReplaceBinExprOp_2(201L, lemma, null) ? MutateCSharp.Schemata450.ReplaceStringConstant_6(202L, "lemma parameter") : MutateCSharp.Schemata450.ReplaceStringConstant_6(203L, "bound variable"), MutateCSharp.Schemata450.ReplaceBinExprOp_2(204L, lemma, null) ? MutateCSharp.Schemata450.ReplaceStringConstant_6(205L, "lemma") : MutateCSharp.Schemata450.ReplaceStringConstant_6(206L, "quantifier"));
                            return;
                        }
                        // fall through for j < 0
                    }
                    else if (MutateCSharp.Schemata450.ReplaceBinExprOp_5(208L, () => MutateCSharp.Schemata450.ReplaceBinExprOp_2(207L, lemma, null), () => arg.Resolved is ThisExpr))
                    {
                        if (MutateCSharp.Schemata450.ReplaceBinExprOp_8(218L, i, MutateCSharp.Schemata450.ReplaceNumericConstant_0(214L, 0)))
                        {
                            goodArguments.Add(arg.Resolved);
                            i = MutateCSharp.Schemata450.ReplaceNumericConstant_0(223L, 0);
                            continue;
                        }

                        ReportWarning(ErrorId.rw_induction_arguments_lemma_mismatch, arg.tok,
              MutateCSharp.Schemata450.ReplaceStringConstant_6(227L, "lemma parameters given as :induction arguments must be given in the same order as in the lemma; ignoring attribute"));
                        return;
                    }

                    ReportWarning(ErrorId.rw_invalid_induction_attribute, arg.tok,
            MutateCSharp.Schemata450.ReplaceStringConstant_6(228L, "invalid :induction attribute argument; expected {0}{1}; ignoring attribute"),
            MutateCSharp.Schemata450.ReplaceBinExprOp_1(233L, i, MutateCSharp.Schemata450.ReplaceNumericConstant_0(229L, 0)) ? MutateCSharp.Schemata450.ReplaceStringConstant_6(238L, "'false' or 'true' or ") : "",
            MutateCSharp.Schemata450.ReplaceBinExprOp_2(239L, lemma, null) ? MutateCSharp.Schemata450.ReplaceStringConstant_6(240L, "lemma parameter") : MutateCSharp.Schemata450.ReplaceStringConstant_6(241L, "bound variable"));
                    return;
                }

                // The argument list was legal, so let's use it for the _induction attribute
                attributes = new Attributes(MutateCSharp.Schemata450.ReplaceStringConstant_6(242L, "_induction"), goodArguments, attributes);
                return;
            }

            // Okay, here we go, coming up with good induction setting for the given situation
            var inductionVariables = new List<Expression>();
            if (MutateCSharp.Schemata450.ReplaceBinExprOp_5(244L, () => MutateCSharp.Schemata450.ReplaceBinExprOp_2(243L, lemma, null), () => !lemma.IsStatic))
            {
                if (MutateCSharp.Schemata450.ReplaceBinExprOp_15(252L, () => MutateCSharp.Schemata450.ReplaceBinExprOp_13(250L, args, null), () => searchExprs.Exists(expr => FreeVariablesUtil.ContainsFreeVariable(expr, MutateCSharp.Schemata450.ReplaceBooleanConstant_14(251L, true), null))))
                {
                    inductionVariables.Add(new ThisExpr(lemma));
                }
            }

            foreach (IVariable n in boundVars)
            {
                if (MutateCSharp.Schemata450.ReplaceBinExprOp_5(277L, () => !(MutateCSharp.Schemata450.ReplaceBinExprOp_15(264L, () => MutateCSharp.Schemata450.ReplaceBinExprOp_15(258L, () => n.Type.IsTypeParameter, () => n.Type.IsAbstractType), () => n.Type.IsInternalTypeSynonym)), () => (MutateCSharp.Schemata450.ReplaceBinExprOp_15(271L, () => MutateCSharp.Schemata450.ReplaceBinExprOp_13(270L, args, null), () => searchExprs.Exists(expr => InductionHeuristic.VarOccursInArgumentToRecursiveFunction(Reporter.Options, expr, n))))))
                {
                    inductionVariables.Add(new IdentifierExpr(n.Tok, n));
                }
            }

            if (MutateCSharp.Schemata450.ReplaceBinExprOp_16(287L, inductionVariables.Count, MutateCSharp.Schemata450.ReplaceNumericConstant_0(283L, 0)))
            {
                // We found something usable, so let's record that in an attribute
                attributes = new Attributes(MutateCSharp.Schemata450.ReplaceStringConstant_6(292L, "_induction"), inductionVariables, attributes);
                // And since we're inferring something, let's also report that in a hover text.
                var s = Printer.OneAttributeToString(Reporter.Options, attributes, MutateCSharp.Schemata450.ReplaceStringConstant_6(293L, "induction"));
                if (lemma is PrefixLemma)
                {
                    s = lemma.Name + MutateCSharp.Schemata450.ReplaceStringConstant_6(294L, " ") + s;
                }

                Reporter.Info(MessageSource.Rewriter, tok, s);
            }
        }

        public
          class Induction_Visitor : BottomUpVisitor
        {
            readonly InductionRewriter IndRewriter;

            public Induction_Visitor(InductionRewriter inductionRewriter)
            {
                Contract.Requires(inductionRewriter != null);
                IndRewriter = inductionRewriter;
            }

            protected override void VisitOneExpr(Expression expr)
            {
                var q = expr as QuantifierExpr;
                if (MutateCSharp.Schemata450.ReplaceBinExprOp_5(297L, () => MutateCSharp.Schemata450.ReplaceBinExprOp_17(295L, q, null), () => MutateCSharp.Schemata450.ReplaceBinExprOp_7(296L, q.SplitQuantifier, null)))
                {
                    IndRewriter.ComputeInductionVariables(q.tok, q.BoundVars, new List<Expression>() { q.LogicalBody() }, null,
                      ref q.Attributes);
                }
            }
        }
    }
}