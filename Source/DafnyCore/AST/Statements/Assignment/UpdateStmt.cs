using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata144
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT144");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_9(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static int ReplacePostfixUnaryExprOp_11(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static int ReplaceNumericConstant_6(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static string ReplaceStringConstant_8(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.IToken argument1, Microsoft.Dafny.IToken argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.MethodCallInformation argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.MethodCallInformation argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.CallStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
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
    public class UpdateStmt : ConcreteUpdateStatement, ICloneable<UpdateStmt>, ICanResolve
    {
        public readonly List<AssignmentRhs> Rhss;
        public readonly bool CanMutateKnownState;
        public Expression OriginalInitialLhs = null;

        public override IToken Tok
        {
            get
            {
                var firstRhs = Rhss.First();
                if (MutateCSharp.Schemata144.ReplaceBinExprOp_0(1L, firstRhs.StartToken, StartToken))
                {
                    // If there is an operator, use it as a token
                    return firstRhs.StartToken.Prev;
                }

                return firstRhs.Tok;
            }
        }

        [FilledInDuringResolution] public List<Statement> ResolvedStatements;
        public override IEnumerable<Statement> SubStatements => Children.OfType<Statement>();

        public override IEnumerable<INode> Children => ResolvedStatements ?? Lhss.Concat<Node>(Rhss);
        public override IEnumerable<INode> PreResolveChildren => Lhss.Concat<Node>(Rhss);

        public override IEnumerable<Statement> PreResolveSubStatements => Enumerable.Empty<Statement>();

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(cce.NonNullElements(Lhss));
            Contract.Invariant(cce.NonNullElements(Rhss));
        }

        public UpdateStmt Clone(Cloner cloner)
        {
            return new UpdateStmt(cloner, this);
        }

        public UpdateStmt(Cloner cloner, UpdateStmt original) : base(cloner, original)
        {
            Rhss = original.Rhss.Select(cloner.CloneRHS).ToList();
            CanMutateKnownState = original.CanMutateKnownState;
            if (cloner.CloneResolvedFields)
            {
                ResolvedStatements = original.ResolvedStatements.Select(stmt => cloner.CloneStmt(stmt, MutateCSharp.Schemata144.ReplaceBooleanConstant_1(2L, false))).ToList();
            }
        }

        public UpdateStmt(RangeToken rangeToken, List<Expression> lhss, List<AssignmentRhs> rhss)
          : base(rangeToken, lhss)
        {
            Contract.Requires(cce.NonNullElements(lhss));
            Contract.Requires(cce.NonNullElements(rhss));
            Contract.Requires(lhss.Count != 0 || rhss.Count == 1);
            Rhss = rhss;
            CanMutateKnownState = MutateCSharp.Schemata144.ReplaceBooleanConstant_1(3L, false);
        }
        public UpdateStmt(RangeToken rangeToken, List<Expression> lhss, List<AssignmentRhs> rhss, bool mutate)
          : base(rangeToken, lhss)
        {
            Contract.Requires(cce.NonNullElements(lhss));
            Contract.Requires(cce.NonNullElements(rhss));
            Contract.Requires(lhss.Count != 0 || rhss.Count == 1);
            Rhss = rhss;
            CanMutateKnownState = mutate;
        }
        public override IEnumerable<Expression> PreResolveSubExpressions
        {
            get
            {
                foreach (var e in base.PreResolveSubExpressions)
                {
                    yield return e;
                }
                foreach (var rhs in Rhss)
                {
                    foreach (var e in rhs.PreResolveSubExpressions)
                    {
                        yield return e;
                    }
                }

                yield break;
            }
        }

        /// <summary>
        /// Resolve the RHSs and entire UpdateStmt (LHSs should already have been checked by the caller).
        /// errorCountBeforeCheckingLhs is passed in so that this method can determined if any resolution errors were found during
        /// LHS or RHS checking, because only if no errors were found is update.ResolvedStmt changed.
        /// </summary>
        public override void Resolve(ModuleResolver resolver, ResolutionContext resolutionContext)
        {
            Contract.Requires(this != null);
            Contract.Requires(resolutionContext != null);

            int errorCountBeforeCheckingLhs = resolver.Reporter.Count(ErrorLevel.Error);

            base.Resolve(resolver, resolutionContext);

            IToken firstEffectfulRhs = null;
            MethodCallInformation methodCallInfo = null;
            ResolvedStatements = new();
            foreach (var rhs in Rhss)
            {
                bool isEffectful;
                if (rhs is TypeRhs)
                {
                    var tr = (TypeRhs)rhs;
                    resolver.ResolveTypeRhs(tr, this, resolutionContext);
                    isEffectful = MutateCSharp.Schemata144.ReplaceBinExprOp_2(4L, tr.InitCall, null);
                }
                else if (rhs is HavocRhs)
                {
                    isEffectful = MutateCSharp.Schemata144.ReplaceBooleanConstant_1(5L, false);
                }
                else
                {
                    var er = (ExprRhs)rhs;
                    if (er.Expr is ApplySuffix)
                    {
                        var a = (ApplySuffix)er.Expr;
                        var cRhs = resolver.ResolveApplySuffix(a, resolutionContext, MutateCSharp.Schemata144.ReplaceBooleanConstant_1(6L, true));
                        isEffectful = MutateCSharp.Schemata144.ReplaceBinExprOp_3(7L, cRhs, null);
                        methodCallInfo = methodCallInfo ?? cRhs;
                    }
                    else
                    {
                        resolver.ResolveExpression(er.Expr, resolutionContext);
                        isEffectful = MutateCSharp.Schemata144.ReplaceBooleanConstant_1(8L, false);
                    }
                }
                if (MutateCSharp.Schemata144.ReplaceBinExprOp_5(10L, () => isEffectful, () => MutateCSharp.Schemata144.ReplaceBinExprOp_4(9L, firstEffectfulRhs, null)))
                {
                    firstEffectfulRhs = rhs.Tok;
                }

                resolver.ResolveAttributes(rhs, resolutionContext);
            }

            // figure out what kind of UpdateStmt this is
            if (MutateCSharp.Schemata144.ReplaceBinExprOp_4(16L, firstEffectfulRhs, null))
            {
                if (MutateCSharp.Schemata144.ReplaceBinExprOp_7(21L, Lhss.Count, MutateCSharp.Schemata144.ReplaceNumericConstant_6(17L, 0)))
                {
                    Contract.Assert(Rhss.Count == 1);  // guaranteed by the parser
                    resolver.Reporter.Error(MessageSource.Resolver, this, MutateCSharp.Schemata144.ReplaceStringConstant_8(26L, "expected method call, found expression"));
                }
                else if (MutateCSharp.Schemata144.ReplaceBinExprOp_9(27L, Lhss.Count, Rhss.Count))
                {
                    resolver.Reporter.Error(MessageSource.Resolver, this, MutateCSharp.Schemata144.ReplaceStringConstant_8(32L, "the number of left-hand sides ({0}) and right-hand sides ({1}) must match for a multi-assignment"), Lhss.Count, Rhss.Count);
                }
                else if (MutateCSharp.Schemata144.ReplaceBinExprOp_7(33L, resolver.Reporter.Count(ErrorLevel.Error), errorCountBeforeCheckingLhs))
                {
                    // add the statements here in a sequence, but don't use that sequence later for translation (instead, should translate properly as multi-assignment)
                    for (int i = MutateCSharp.Schemata144.ReplaceNumericConstant_6(38L, 0); MutateCSharp.Schemata144.ReplaceBinExprOp_10(42L, i, Lhss.Count); MutateCSharp.Schemata144.ReplacePostfixUnaryExprOp_11(47L, ref i))
                    {
                        var a = new AssignStmt(RangeToken, Lhss[i].Resolved, Rhss[i]);
                        ResolvedStatements.Add(a);
                    }
                }

            }
            else if (CanMutateKnownState)
            {
                if (MutateCSharp.Schemata144.ReplaceBinExprOp_10(52L, MutateCSharp.Schemata144.ReplaceNumericConstant_6(48L, 1), Rhss.Count))
                {
                    resolver.Reporter.Error(MessageSource.Resolver, firstEffectfulRhs, MutateCSharp.Schemata144.ReplaceStringConstant_8(57L, "cannot have effectful parameter in multi-return statement."));
                }
                else
                { // it might be ok, if it is a TypeRhs
                    Contract.Assert(Rhss.Count == 1);
                    if (MutateCSharp.Schemata144.ReplaceBinExprOp_3(58L, methodCallInfo, null))
                    {
                        resolver.Reporter.Error(MessageSource.Resolver, methodCallInfo.Tok, MutateCSharp.Schemata144.ReplaceStringConstant_8(59L, "cannot have method call in return statement."));
                    }
                    else
                    {
                        // we have a TypeRhs
                        Contract.Assert(Rhss[0] is TypeRhs);
                        var tr = (TypeRhs)Rhss[MutateCSharp.Schemata144.ReplaceNumericConstant_6(60L, 0)];
                        Contract.Assert(tr.InitCall != null); // there were effects, so this must have been a call.
                        if (tr.CanAffectPreviouslyKnownExpressions)
                        {
                            resolver.Reporter.Error(MessageSource.Resolver, tr.Tok, MutateCSharp.Schemata144.ReplaceStringConstant_8(64L, "can only have initialization methods which modify at most 'this'."));
                        }
                        else if (MutateCSharp.Schemata144.ReplaceBinExprOp_7(65L, resolver.Reporter.Count(ErrorLevel.Error), errorCountBeforeCheckingLhs))
                        {
                            var a = new AssignStmt(RangeToken, Lhss[MutateCSharp.Schemata144.ReplaceNumericConstant_6(70L, 0)].Resolved, tr);
                            ResolvedStatements.Add(a);
                        }
                    }
                }

            }
            else
            {
                // if there was an effectful RHS, that must be the only RHS
                if (MutateCSharp.Schemata144.ReplaceBinExprOp_9(78L, Rhss.Count, MutateCSharp.Schemata144.ReplaceNumericConstant_6(74L, 1)))
                {
                    resolver.Reporter.Error(MessageSource.Resolver, firstEffectfulRhs, MutateCSharp.Schemata144.ReplaceStringConstant_8(83L, "an update statement is allowed an effectful RHS only if there is just one RHS"));
                }
                else if (MutateCSharp.Schemata144.ReplaceBinExprOp_12(84L, methodCallInfo, null))
                {
                    // must be a single TypeRhs
                    if (MutateCSharp.Schemata144.ReplaceBinExprOp_9(89L, Lhss.Count, MutateCSharp.Schemata144.ReplaceNumericConstant_6(85L, 1)))
                    {
                        Contract.Assert(2 <= Lhss.Count);  // the parser allows 0 Lhss only if the whole statement looks like an expression (not a TypeRhs)
                        resolver.Reporter.Error(MessageSource.Resolver, Lhss[MutateCSharp.Schemata144.ReplaceNumericConstant_6(94L, 1)].tok, MutateCSharp.Schemata144.ReplaceStringConstant_8(98L, "the number of left-hand sides ({0}) and right-hand sides ({1}) must match for a multi-assignment"), Lhss.Count, Rhss.Count);
                    }
                    else if (MutateCSharp.Schemata144.ReplaceBinExprOp_7(99L, resolver.Reporter.Count(ErrorLevel.Error), errorCountBeforeCheckingLhs))
                    {
                        var a = new AssignStmt(RangeToken, Lhss[MutateCSharp.Schemata144.ReplaceNumericConstant_6(104L, 0)].Resolved, Rhss[MutateCSharp.Schemata144.ReplaceNumericConstant_6(108L, 0)]);
                        ResolvedStatements.Add(a);
                    }
                }
                else if (MutateCSharp.Schemata144.ReplaceBinExprOp_7(112L, resolver.Reporter.Count(ErrorLevel.Error), errorCountBeforeCheckingLhs))
                {
                    // a call statement
                    var resolvedLhss = new List<Expression>();
                    foreach (var ll in Lhss)
                    {
                        resolvedLhss.Add(ll.Resolved);
                    }
                    CallStmt a = new CallStmt(RangeToken, resolvedLhss, methodCallInfo.Callee, methodCallInfo.ActualParameters, methodCallInfo.Tok);
                    a.OriginalInitialLhs = OriginalInitialLhs;
                    ResolvedStatements.Add(a);
                }
            }

            foreach (var a in ResolvedStatements)
            {
                resolver.ResolveStatement(a, resolutionContext);
            }
        }
    }
}