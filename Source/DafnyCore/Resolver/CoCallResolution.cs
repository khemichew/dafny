using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata392
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT392");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplacePostfixUnaryExprOp_10(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_8(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static int ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 - argument2;
        }

        internal static int ReplaceNumericConstant_1(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument1, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.Function argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_9(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.DatatypeValue argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.TernaryExpr.Opcode argument1, Microsoft.Dafny.TernaryExpr.Opcode argument2)
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
class CoCallResolution
    {
        readonly Function currentFunction;
        readonly bool dealsWithCodatatypes;
        public bool HasIntraClusterCallsInDestructiveContexts = MutateCSharp.Schemata392.ReplaceBooleanConstant_0(1L, false);
        public readonly List<CoCallInfo> FinalCandidates = new List<CoCallInfo>();

        public CoCallResolution(Function currentFunction, bool dealsWithCodatatypes)
        {
            Contract.Requires(currentFunction != null);
            this.currentFunction = currentFunction;
            this.dealsWithCodatatypes = dealsWithCodatatypes;
        }

        /// <summary>
        /// Determines which calls in "expr" can be considered to be co-calls, which co-constructor
        /// invocations host such co-calls, and which destructor operations are not allowed.
        /// Also records whether or not there are any intra-cluster calls in a destructive context.
        /// Assumes "expr" to have been successfully resolved.
        /// </summary>
        public void CheckCoCalls(Expression expr)
        {
            Contract.Requires(expr != null);
            CheckCoCalls(expr, MutateCSharp.Schemata392.ReplaceNumericConstant_1(2L, 0), null, FinalCandidates);
        }

        public struct CoCallInfo
        {
            public readonly FunctionCallExpr CandidateCall;
            public readonly DatatypeValue EnclosingCoConstructor;
            public CoCallInfo(FunctionCallExpr candidateCall, DatatypeValue enclosingCoConstructor)
            {
                Contract.Requires(candidateCall != null);
                Contract.Requires(enclosingCoConstructor != null);
                CandidateCall = candidateCall;
                EnclosingCoConstructor = enclosingCoConstructor;
            }
        }

        /// <summary>
        /// Recursively goes through the entire "expr".  Every call within the same recursive cluster is a potential
        /// co-call.  If the call is determined not to be a co-recursive call, then its .CoCall field is filled in;
        /// if the situation deals with co-datatypes, then one of the NoBecause... values is chosen (rather
        /// than just No), so that any error message that may later be produced when trying to prove termination of the
        /// recursive call can include a note pointing out that the call was not selected to be a co-call.
        /// If the call looks like it is guarded, then it is added to the list "coCandicates", so that a later analysis
        /// can either set all of those .CoCall fields to Yes or to NoBecauseRecursiveCallsInDestructiveContext, depending
        /// on other intra-cluster calls.
        /// The "destructionLevel" indicates how many pending co-destructors the context has.  It may be infinity (int.MaxValue)
        /// if the enclosing context has no easy way of controlling the uses of "expr" (for example, if the enclosing context
        /// passes "expr" to a function or binds "expr" to a variable).  It is never negative -- excess co-constructors are
        /// not considered an asset, and any immediately enclosing co-constructor is passed in as a non-null "coContext" anyway.
        /// "coContext" is non-null if the immediate context is a co-constructor.
        /// </summary>
        void CheckCoCalls(Expression expr, int destructionLevel, DatatypeValue coContext, List<CoCallInfo> coCandidates, Function functionYouMayWishWereAbstemious = null)
        {
            Contract.Requires(expr != null);

            Contract.Requires(0 <= destructionLevel);
            Contract.Requires(coCandidates != null);
            expr = expr.Resolved;
            if (expr is DatatypeValue)
            {
                var e = (DatatypeValue)expr;
                if (e.Ctor.EnclosingDatatype is CoDatatypeDecl)
                {
                    int dl = MutateCSharp.Schemata392.ReplaceBinExprOp_2(6L, destructionLevel, int.MaxValue) ? int.MaxValue : MutateCSharp.Schemata392.ReplaceBinExprOp_2(15L, destructionLevel, MutateCSharp.Schemata392.ReplaceNumericConstant_1(11L, 0)) ? MutateCSharp.Schemata392.ReplaceNumericConstant_1(20L, 0) : MutateCSharp.Schemata392.ReplaceBinExprOp_3(28L, destructionLevel, MutateCSharp.Schemata392.ReplaceNumericConstant_1(24L, 1));
                    foreach (var arg in e.Arguments)
                    {
                        CheckCoCalls(arg, dl, e, coCandidates);
                    }
                    return;
                }
            }
            else if (expr is MemberSelectExpr)
            {
                var e = (MemberSelectExpr)expr;
                if (e.Member.EnclosingClass is CoDatatypeDecl)
                {
                    int dl = MutateCSharp.Schemata392.ReplaceBinExprOp_2(37L, destructionLevel, int.MaxValue) ? int.MaxValue : MutateCSharp.Schemata392.ReplaceBinExprOp_4(46L, destructionLevel, MutateCSharp.Schemata392.ReplaceNumericConstant_1(42L, 1));
                    CheckCoCalls(e.Obj, dl, coContext, coCandidates);
                    return;
                }
            }
            else if (expr is BinaryExpr)
            {
                var e = (BinaryExpr)expr;
                if (MutateCSharp.Schemata392.ReplaceBinExprOp_6(57L, () => MutateCSharp.Schemata392.ReplaceBinExprOp_5(55L, e.ResolvedOp, BinaryExpr.ResolvedOpcode.EqCommon), () => MutateCSharp.Schemata392.ReplaceBinExprOp_5(56L, e.ResolvedOp, BinaryExpr.ResolvedOpcode.NeqCommon)))
                {
                    // Equality and disequality (for any type that may contain a co-datatype) are as destructive as can be--in essence,
                    // they destruct the values indefinitely--so don't allow any co-recursive calls in the operands.
                    CheckCoCalls(e.E0, int.MaxValue, null, coCandidates);
                    CheckCoCalls(e.E1, int.MaxValue, null, coCandidates);
                    return;
                }
            }
            else if (expr is TernaryExpr)
            {
                var e = (TernaryExpr)expr;
                if (MutateCSharp.Schemata392.ReplaceBinExprOp_6(65L, () => MutateCSharp.Schemata392.ReplaceBinExprOp_7(63L, e.Op, TernaryExpr.Opcode.PrefixEqOp), () => MutateCSharp.Schemata392.ReplaceBinExprOp_7(64L, e.Op, TernaryExpr.Opcode.PrefixNeqOp)))
                {
                    // Prefix equality and disequality (for any type that may contain a co-datatype) are destructive.
                    CheckCoCalls(e.E0, int.MaxValue, null, coCandidates);
                    CheckCoCalls(e.E1, int.MaxValue, null, coCandidates);
                    CheckCoCalls(e.E2, int.MaxValue, null, coCandidates);
                    return;
                }
            }
            else if (expr is NestedMatchExpr)
            {
                var e = (NestedMatchExpr)expr;
                foreach (var child in e.SubExpressions)
                {
                    CheckCoCalls(child, destructionLevel, coContext, coCandidates);
                }
            }
            else if (expr is MatchExpr)
            {
                var e = (MatchExpr)expr;
                CheckCoCalls(e.Source, int.MaxValue, null, coCandidates);
                foreach (var kase in e.Cases)
                {
                    CheckCoCalls(kase.Body, destructionLevel, coContext, coCandidates);
                }
                return;
            }
            else if (expr is ITEExpr)
            {
                var e = (ITEExpr)expr;
                CheckCoCalls(e.Test, int.MaxValue, null, coCandidates);
                CheckCoCalls(e.Thn, destructionLevel, coContext, coCandidates);
                CheckCoCalls(e.Els, destructionLevel, coContext, coCandidates);
                return;
            }
            else if (expr is FunctionCallExpr)
            {
                var e = (FunctionCallExpr)expr;
                // First, consider the arguments of the call, making sure that they do not include calls within the recursive cluster,
                // unless the callee is abstemious.
                var abstemious = MutateCSharp.Schemata392.ReplaceBooleanConstant_0(71L, true);
                if (!Attributes.ContainsBool(e.Function.Attributes, MutateCSharp.Schemata392.ReplaceStringConstant_8(72L, "abstemious"), ref abstemious))
                {
                    abstemious = MutateCSharp.Schemata392.ReplaceBooleanConstant_0(73L, false);
                }
                Contract.Assert(e.Args.Count == e.Function.Ins.Count);
                for (var i = MutateCSharp.Schemata392.ReplaceNumericConstant_1(74L, 0); MutateCSharp.Schemata392.ReplaceBinExprOp_9(78L, i, e.Args.Count); MutateCSharp.Schemata392.ReplacePostfixUnaryExprOp_10(83L, ref i))
                {
                    var arg = e.Args[i];
                    if (!e.Function.Ins[i].Type.IsCoDatatype)
                    {
                        CheckCoCalls(arg, int.MaxValue, null, coCandidates);
                    }
                    else if (abstemious)
                    {
                        CheckCoCalls(arg, MutateCSharp.Schemata392.ReplaceNumericConstant_1(84L, 0), coContext, coCandidates);
                    }
                    else
                    {
                        // don't you wish the callee were abstemious
                        CheckCoCalls(arg, int.MaxValue, null, coCandidates, e.Function);
                    }
                }
                // Second, investigate the possibility that this call itself may be a candidate co-call
                if (MutateCSharp.Schemata392.ReplaceBinExprOp_12(90L, () => MutateCSharp.Schemata392.ReplaceBinExprOp_11(89L, e.Name, MutateCSharp.Schemata392.ReplaceStringConstant_8(88L, "requires")), () => ModuleDefinition.InSameSCC(currentFunction, e.Function)))
                {
                    // This call goes to another function in the same recursive cluster
                    if (MutateCSharp.Schemata392.ReplaceBinExprOp_12(110L, () => MutateCSharp.Schemata392.ReplaceBinExprOp_13(100L, destructionLevel, MutateCSharp.Schemata392.ReplaceNumericConstant_1(96L, 0)), () => MutateCSharp.Schemata392.ReplaceBinExprOp_14(105L, GuaranteedCoCtors(e.Function), destructionLevel)))
                    {
                        // a potentially destructive context
                        HasIntraClusterCallsInDestructiveContexts = MutateCSharp.Schemata392.ReplaceBooleanConstant_0(116L, true);  // this says we found an intra-cluster call unsuitable for recursion, if there were any co-recursive calls
                        if (!dealsWithCodatatypes)
                        {
                            e.CoCall = FunctionCallExpr.CoCallResolution.No;
                        }
                        else
                        {
                            e.CoCall = FunctionCallExpr.CoCallResolution.NoBecauseRecursiveCallsAreNotAllowedInThisContext;
                            if (MutateCSharp.Schemata392.ReplaceBinExprOp_15(117L, functionYouMayWishWereAbstemious, null))
                            {
                                e.CoCallHint = string.Format(MutateCSharp.Schemata392.ReplaceStringConstant_8(118L, "perhaps try declaring function '{0}' with '{{:abstemious}}'"), functionYouMayWishWereAbstemious.Name);
                            }
                        }
                    }
                    else if (MutateCSharp.Schemata392.ReplaceBinExprOp_16(119L, coContext, null))
                    {
                        // no immediately enclosing co-constructor
                        if (!dealsWithCodatatypes)
                        {
                            e.CoCall = FunctionCallExpr.CoCallResolution.No;
                        }
                        else
                        {
                            e.CoCall = FunctionCallExpr.CoCallResolution.NoBecauseIsNotGuarded;
                        }
                    }
                    else if (MutateCSharp.Schemata392.ReplaceBinExprOp_13(124L, e.Function.Reads.Expressions.Count, MutateCSharp.Schemata392.ReplaceNumericConstant_1(120L, 0)))
                    {
                        // this call is disqualified from being a co-call, because of side effects
                        if (!dealsWithCodatatypes)
                        {
                            e.CoCall = FunctionCallExpr.CoCallResolution.No;
                        }
                        else
                        {
                            e.CoCall = FunctionCallExpr.CoCallResolution.NoBecauseFunctionHasSideEffects;
                        }
                    }
                    else if (MutateCSharp.Schemata392.ReplaceBinExprOp_13(133L, e.Function.Ens.Count, MutateCSharp.Schemata392.ReplaceNumericConstant_1(129L, 0)))
                    {
                        // this call is disqualified from being a co-call, because it has a postcondition
                        // (a postcondition could be allowed, as long as it does not get to be used with
                        // co-recursive calls, because that could be unsound; for example, consider
                        // "ensures false")
                        if (!dealsWithCodatatypes)
                        {
                            e.CoCall = FunctionCallExpr.CoCallResolution.No;
                        }
                        else
                        {
                            e.CoCall = FunctionCallExpr.CoCallResolution.NoBecauseFunctionHasPostcondition;
                        }
                    }
                    else
                    {
                        // e.CoCall is not filled in here, but will be filled in when the list of candidates are processed
                        coCandidates.Add(new CoCallInfo(e, coContext));
                    }
                }
                return;
            }
            else if (expr is LambdaExpr)
            {
                var e = (LambdaExpr)expr;
                CheckCoCalls(e.Term, destructionLevel, coContext, coCandidates);
                if (MutateCSharp.Schemata392.ReplaceBinExprOp_17(138L, e.Range, null))
                {
                    CheckCoCalls(e.Range, int.MaxValue, null, coCandidates);
                }
                foreach (var read in e.Reads.Expressions)
                {
                    CheckCoCalls(read.E, int.MaxValue, null, coCandidates);
                }
                return;
            }
            else if (expr is MapComprehension)
            {
                var e = (MapComprehension)expr;
                foreach (var ee in Attributes.SubExpressions(e.Attributes))
                {
                    CheckCoCalls(ee, int.MaxValue, null, coCandidates);
                }
                if (MutateCSharp.Schemata392.ReplaceBinExprOp_17(139L, e.Range, null))
                {
                    CheckCoCalls(e.Range, int.MaxValue, null, coCandidates);
                }
                // allow co-calls in the term
                if (MutateCSharp.Schemata392.ReplaceBinExprOp_17(140L, e.TermLeft, null))
                {
                    CheckCoCalls(e.TermLeft, destructionLevel, coContext, coCandidates);
                }
                CheckCoCalls(e.Term, destructionLevel, coContext, coCandidates);
                return;
            }
            else if (expr is OldExpr)
            {
                var e = (OldExpr)expr;
                // here, "coContext" is passed along (the use of "old" says this must be ghost code, so the compiler does not need to handle this case)
                CheckCoCalls(e.E, destructionLevel, coContext, coCandidates);
                return;
            }
            else if (expr is LetExpr)
            {
                var e = (LetExpr)expr;
                foreach (var rhs in e.RHSs)
                {
                    CheckCoCalls(rhs, int.MaxValue, null, coCandidates);
                }
                CheckCoCalls(e.Body, destructionLevel, coContext, coCandidates);
                return;
            }
            else if (expr is ApplyExpr)
            {
                var e = (ApplyExpr)expr;
                CheckCoCalls(e.Function, int.MaxValue, null, coCandidates);
                foreach (var ee in e.Args)
                {
                    CheckCoCalls(ee, destructionLevel, null, coCandidates);
                }
                return;
            }

            // Default handling:
            foreach (var ee in expr.SubExpressions)
            {
                CheckCoCalls(ee, destructionLevel, null, coCandidates);
            }
        }

        public static int GuaranteedCoCtors(Function function)
        {
            Contract.Requires(function != null);
            return MutateCSharp.Schemata392.ReplaceBinExprOp_17(141L, function.Body, null) ? GuaranteedCoCtorsAux(function.Body) : MutateCSharp.Schemata392.ReplaceNumericConstant_1(142L, 0);
        }

        private static int GuaranteedCoCtorsAux(Expression expr)
        {
            Contract.Requires(expr != null);
            expr = expr.Resolved;
            if (expr is DatatypeValue)
            {
                var e = (DatatypeValue)expr;
                if (e.Ctor.EnclosingDatatype is CoDatatypeDecl)
                {
                    var minOfArgs = int.MaxValue;  // int.MaxValue means: not yet encountered a formal whose type is a co-datatype
                    Contract.Assert(e.Arguments.Count == e.Ctor.Formals.Count);
                    for (var i = MutateCSharp.Schemata392.ReplaceNumericConstant_1(146L, 0); MutateCSharp.Schemata392.ReplaceBinExprOp_9(150L, i, e.Arguments.Count); MutateCSharp.Schemata392.ReplacePostfixUnaryExprOp_10(155L, ref i))
                    {
                        if (e.Ctor.Formals[i].Type.IsCoDatatype)
                        {
                            var n = GuaranteedCoCtorsAux(e.Arguments[i]);
                            minOfArgs = Math.Min(minOfArgs, n);
                        }
                    }
                    return MutateCSharp.Schemata392.ReplaceBinExprOp_2(156L, minOfArgs, int.MaxValue) ? MutateCSharp.Schemata392.ReplaceNumericConstant_1(161L, 1) : MutateCSharp.Schemata392.ReplaceBinExprOp_4(169L, MutateCSharp.Schemata392.ReplaceNumericConstant_1(165L, 1), minOfArgs);
                }
            }
            else if (expr is ITEExpr)
            {
                var e = (ITEExpr)expr;
                var thn = GuaranteedCoCtorsAux(e.Thn);
                var els = GuaranteedCoCtorsAux(e.Els);
                return MutateCSharp.Schemata392.ReplaceBinExprOp_9(178L, thn, els) ? thn : els;
            }
            else if (expr is NestedMatchExpr nestedMatchExpr)
            {
                var childValues = nestedMatchExpr.Cases.Select(child => GuaranteedCoCtorsAux(child.Body)).ToList();
                return childValues.Any() ? childValues.Min() : MutateCSharp.Schemata392.ReplaceNumericConstant_1(183L, 0);
            }
            else if (expr is MatchExpr)
            {
                var e = (MatchExpr)expr;
                var min = int.MaxValue;
                foreach (var kase in e.Cases)
                {
                    var n = GuaranteedCoCtorsAux(kase.Body);
                    min = Math.Min(min, n);
                }
                return MutateCSharp.Schemata392.ReplaceBinExprOp_2(187L, min, int.MaxValue) ? MutateCSharp.Schemata392.ReplaceNumericConstant_1(192L, 0) : min;
            }
            else if (expr is LetExpr)
            {
                var e = (LetExpr)expr;
                return GuaranteedCoCtorsAux(e.Body);
            }
            else if (expr is IdentifierExpr)
            {
                var e = (IdentifierExpr)expr;
                if (MutateCSharp.Schemata392.ReplaceBinExprOp_12(196L, () => e.Type.IsCoDatatype, () => e.Var is Formal))
                {
                    // even though this is not a co-constructor, count this as 1, since that's what we would have done if it were, e.g., "Cons(s.head, s.tail)" instead of "s"
                    return MutateCSharp.Schemata392.ReplaceNumericConstant_1(202L, 1);
                }
            }
            return MutateCSharp.Schemata392.ReplaceNumericConstant_1(206L, 0);
        }
    }
}