using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata135
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT135");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePrefixUnaryExprOp_23(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return ++argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return +argument1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return ~argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return --argument1; }
            return ++argument1;
        }

        internal static string ReplaceStringConstant_8(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.ExprRhs argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.AssignmentRhs> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, Microsoft.Dafny.AttributedToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, Microsoft.Dafny.ExprDotName argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_17(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.AttributedToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static int ReplaceBinExprOp_18(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_19(long mutantId, Microsoft.Dafny.ThisExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.AssignmentRhs> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

    }
}

namespace Microsoft.Dafny
{
    public class AssignOrReturnStmt : ConcreteUpdateStatement, ICloneable<AssignOrReturnStmt>, ICanResolve
    {
        public readonly ExprRhs Rhs; // this is the unresolved RHS, and thus can also be a method call
        public readonly List<AssignmentRhs> Rhss;
        public readonly AttributedToken KeywordToken;
        [FilledInDuringResolution] public readonly List<Statement> ResolvedStatements = new List<Statement>();
        public override IEnumerable<Statement> SubStatements => ResolvedStatements;
        public override IToken Tok
        {
            get
            {
                var result = Rhs.StartToken.Prev;
                if (char.IsLetter(result.val[MutateCSharp.Schemata135.ReplaceNumericConstant_0(1L, 0)]))
                {
                    // Jump to operator if we're on an assume/expect/assert keyword.
                    result = result.Prev;
                }
                return result;
            }
        }

        public override IEnumerable<INode> Children => ResolvedStatements;
        public override IEnumerable<Statement> PreResolveSubStatements => Enumerable.Empty<Statement>();

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(Lhss != null);
            Contract.Invariant(
              Lhss.Count == 0 ||                   // ":- MethodOrExpression;" which returns void success or an error
              (Lhss.Count == 1 && Lhss[0] != null)   // "y :- MethodOrExpression;"
            );
            Contract.Invariant(Rhs != null);
        }

        public AssignOrReturnStmt Clone(Cloner cloner)
        {
            return new AssignOrReturnStmt(cloner, this);
        }

        public AssignOrReturnStmt(Cloner cloner, AssignOrReturnStmt original) : base(cloner, original)
        {
            Rhs = (ExprRhs)cloner.CloneRHS(original.Rhs);
            Rhss = original.Rhss.ConvertAll(cloner.CloneRHS);
            KeywordToken = cloner.AttributedTok(original.KeywordToken);

            if (cloner.CloneResolvedFields)
            {
                ResolvedStatements = original.ResolvedStatements.Select(stmt => cloner.CloneStmt(stmt, MutateCSharp.Schemata135.ReplaceBooleanConstant_1(5L, false))).ToList();
            }
        }

        public AssignOrReturnStmt(RangeToken rangeToken, List<Expression> lhss, ExprRhs rhs, AttributedToken keywordToken, List<AssignmentRhs> rhss)
          : base(rangeToken, lhss)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(lhss != null);
            Contract.Requires(lhss.Count <= 1);
            Contract.Requires(rhs != null);
            Contract.Requires(rhss != null);
            Rhs = rhs;
            Rhss = rhss;
            KeywordToken = keywordToken;
        }

        public override IEnumerable<Expression> PreResolveSubExpressions
        {
            get
            {
                foreach (var e in base.SpecificationSubExpressions)
                {
                    yield return e;
                }
                foreach (var e in base.Lhss)
                {
                    yield return e;
                }
                if (MutateCSharp.Schemata135.ReplaceBinExprOp_2(6L, Rhs, null))
                {
                    yield return Rhs.Expr;
                }
                foreach (var rhs in Rhss)
                {
                    foreach (var e in rhs.SubExpressions)
                    {
                        yield return e;
                    }
                }

                yield break;
            }
        }

        /// <summary>
        /// Desugars "y, ... :- MethodOrExpression" into
        /// var temp;
        /// temp, ... := MethodOrExpression;
        /// if temp.IsFailure() { return temp.PropagateFailure(); }
        /// y := temp.Extract();
        ///
        /// If the type of MethodExpression does not have an Extract, then the desugaring is
        /// var temp;
        /// temp, y, ... := MethodOrExpression;
        /// if temp.IsFailure() { return temp.PropagateFailure(); }
        ///
        /// If there are multiple RHSs then "y, ... :- Expression, ..." becomes
        /// var temp;
        /// temp, ... := Expression, ...;
        /// if temp.IsFailure() { return temp.PropagateFailure(); }
        /// y := temp.Extract();
        /// OR
        /// var temp;
        /// temp, y, ... := Expression, ...;
        /// if temp.IsFailure() { return temp.PropagateFailure(); }
        ///
        /// and "y, ... :- expect MethodOrExpression, ..." into
        /// var temp, [y, ] ... := MethodOrExpression, ...;
        /// expect !temp.IsFailure(), temp.PropagateFailure();
        /// [y := temp.Extract();]
        ///
        /// and saves the result into s.ResolvedStatements.
        /// This is also known as the "elephant operator"
        /// </summary>
        public override void Resolve(ModuleResolver resolver, ResolutionContext resolutionContext)
        {
            base.Resolve(resolver, resolutionContext);

            ResolveKeywordToken(resolver, resolutionContext);

            // We need to figure out whether we are using a status type that has Extract or not,
            // as that determines how the AssignOrReturnStmt is desugared. Thus if the Rhs is a
            // method call we need to know which one (to inspect its first output); if RHs is a
            // list of expressions, we need to know the type of the first one. For all of this we have
            // to do some partial type resolution.

            bool expectExtract = MutateCSharp.Schemata135.ReplaceBinExprOp_3(11L, Lhss.Count, MutateCSharp.Schemata135.ReplaceNumericConstant_0(7L, 0)); // default value if we cannot determine and inspect the type
            Type firstType = null;
            Method call = null;
            if ((MutateCSharp.Schemata135.ReplaceBinExprOp_6(26L, () => MutateCSharp.Schemata135.ReplaceBinExprOp_4(16L, Rhss, null), () => MutateCSharp.Schemata135.ReplaceBinExprOp_5(21L, Rhss.Count, MutateCSharp.Schemata135.ReplaceNumericConstant_0(17L, 0)))) && Rhs.Expr is ApplySuffix asx)
            {
                resolver.ResolveApplySuffix(asx, resolutionContext, MutateCSharp.Schemata135.ReplaceBooleanConstant_1(32L, true));
                call = (asx.Lhs.Resolved as MemberSelectExpr)?.Member as Method;
                if (MutateCSharp.Schemata135.ReplaceBinExprOp_7(33L, call, null))
                {
                    // We're looking at a method call
                    var typeMap = (asx.Lhs.Resolved as MemberSelectExpr)?.TypeArgumentSubstitutionsWithParents();
                    if (MutateCSharp.Schemata135.ReplaceBinExprOp_3(38L, call.Outs.Count, MutateCSharp.Schemata135.ReplaceNumericConstant_0(34L, 0)))
                    {
                        firstType = call.Outs[MutateCSharp.Schemata135.ReplaceNumericConstant_0(43L, 0)].Type.Subst(typeMap);
                    }
                    else
                    {
                        resolver.Reporter.Error(MessageSource.Resolver, Rhs.tok, MutateCSharp.Schemata135.ReplaceStringConstant_8(47L, "Expected {0} to have a Success/Failure output value, but the method returns nothing."), call.Name);
                    }
                }
                else
                {
                    // We're looking at a call to a function. Treat it like any other expression.
                    firstType = asx.Type;
                }
            }
            else
            {
                resolver.ResolveExpression(Rhs.Expr, resolutionContext);
                firstType = Rhs.Expr.Type;
            }

            var method = (Method)resolutionContext.CodeContext;
            if (MutateCSharp.Schemata135.ReplaceBinExprOp_10(58L, () => MutateCSharp.Schemata135.ReplaceBinExprOp_5(52L, method.Outs.Count, MutateCSharp.Schemata135.ReplaceNumericConstant_0(48L, 0)), () => MutateCSharp.Schemata135.ReplaceBinExprOp_9(57L, KeywordToken, null)))
            {
                resolver.Reporter.Error(MessageSource.Resolver, Tok, MutateCSharp.Schemata135.ReplaceStringConstant_8(64L, "A method containing a :- statement must have an out-parameter ({0})"), method.Name);
                return;
            }
            if (MutateCSharp.Schemata135.ReplaceBinExprOp_11(65L, firstType, null))
            {
                firstType = resolver.PartiallyResolveTypeForMemberSelection(Rhs.tok, firstType);
                if (MutateCSharp.Schemata135.ReplaceBinExprOp_12(66L, firstType.AsTopLevelTypeWithMembers, null))
                {
                    if (MutateCSharp.Schemata135.ReplaceBinExprOp_14(69L, firstType.AsTopLevelTypeWithMembers.Members.Find(x => MutateCSharp.Schemata135.ReplaceBinExprOp_13(68L, x.Name, MutateCSharp.Schemata135.ReplaceStringConstant_8(67L, "IsFailure"))), null))
                    {
                        resolver.Reporter.Error(MessageSource.Resolver, Tok,
              MutateCSharp.Schemata135.ReplaceStringConstant_8(70L, "member IsFailure does not exist in {0}, in :- statement"), firstType);
                        return;
                    }
                    expectExtract = MutateCSharp.Schemata135.ReplaceBinExprOp_15(73L, firstType.AsTopLevelTypeWithMembers.Members.Find(x => MutateCSharp.Schemata135.ReplaceBinExprOp_13(72L, x.Name, MutateCSharp.Schemata135.ReplaceStringConstant_8(71L, "Extract"))), null);
                    if (MutateCSharp.Schemata135.ReplaceBinExprOp_10(99L, () => MutateCSharp.Schemata135.ReplaceBinExprOp_10(75L, () => expectExtract, () => MutateCSharp.Schemata135.ReplaceBinExprOp_16(74L, call, null)), () => MutateCSharp.Schemata135.ReplaceBinExprOp_3(94L, Lhss.Count, MutateCSharp.Schemata135.ReplaceBinExprOp_17(85L, MutateCSharp.Schemata135.ReplaceNumericConstant_0(81L, 1), Rhss.Count))))
                    {
                        resolver.Reporter.Error(MessageSource.Resolver, Tok,
              MutateCSharp.Schemata135.ReplaceStringConstant_8(105L, "number of lhs ({0}) must match number of rhs ({1}) for a rhs type ({2}) with member Extract"),
                          Lhss.Count, MutateCSharp.Schemata135.ReplaceBinExprOp_17(110L, MutateCSharp.Schemata135.ReplaceNumericConstant_0(106L, 1), Rhss.Count), firstType);
                        return;
                    }
                    else if (MutateCSharp.Schemata135.ReplaceBinExprOp_10(131L, () => MutateCSharp.Schemata135.ReplaceBinExprOp_10(120L, () => expectExtract, () => MutateCSharp.Schemata135.ReplaceBinExprOp_7(119L, call, null)), () => MutateCSharp.Schemata135.ReplaceBinExprOp_3(126L, Lhss.Count, call.Outs.Count)))
                    {
                        resolver.Reporter.Error(MessageSource.Resolver, Tok,
              MutateCSharp.Schemata135.ReplaceStringConstant_8(137L, "wrong number of method result arguments (got {0}, expected {1}) for a rhs type ({2}) with member Extract"),
                          Lhss.Count, call.Outs.Count, firstType);
                        return;

                    }
                    else if (MutateCSharp.Schemata135.ReplaceBinExprOp_10(150L, () => MutateCSharp.Schemata135.ReplaceBinExprOp_10(139L, () => !expectExtract, () => MutateCSharp.Schemata135.ReplaceBinExprOp_16(138L, call, null)), () => MutateCSharp.Schemata135.ReplaceBinExprOp_3(145L, Lhss.Count, Rhss.Count)))
                    {
                        resolver.Reporter.Error(MessageSource.Resolver, Tok,
              MutateCSharp.Schemata135.ReplaceStringConstant_8(156L, "number of lhs ({0}) must be one less than number of rhs ({1}) for a rhs type ({2}) without member Extract"), Lhss.Count, MutateCSharp.Schemata135.ReplaceBinExprOp_17(161L, MutateCSharp.Schemata135.ReplaceNumericConstant_0(157L, 1), Rhss.Count), firstType);
                        return;

                    }
                    else if (MutateCSharp.Schemata135.ReplaceBinExprOp_10(195L, () => MutateCSharp.Schemata135.ReplaceBinExprOp_10(171L, () => !expectExtract, () => MutateCSharp.Schemata135.ReplaceBinExprOp_7(170L, call, null)), () => MutateCSharp.Schemata135.ReplaceBinExprOp_3(190L, Lhss.Count, MutateCSharp.Schemata135.ReplaceBinExprOp_18(181L, call.Outs.Count, MutateCSharp.Schemata135.ReplaceNumericConstant_0(177L, 1)))))
                    {
                        resolver.Reporter.Error(MessageSource.Resolver, Tok,
              MutateCSharp.Schemata135.ReplaceStringConstant_8(201L, "wrong number of method result arguments (got {0}, expected {1}) for a rhs type ({2}) without member Extract"), Lhss.Count, MutateCSharp.Schemata135.ReplaceBinExprOp_18(206L, call.Outs.Count, MutateCSharp.Schemata135.ReplaceNumericConstant_0(202L, 1)), firstType);
                        return;
                    }
                }
                else
                {
                    resolver.Reporter.Error(MessageSource.Resolver, Tok,
                      $"The type of the first expression to the right of ':-' could not be determined to be a failure type (got '{firstType}')");
                    return;
                }
            }
            else
            {
                resolver.Reporter.Error(MessageSource.Resolver, Tok,
          MutateCSharp.Schemata135.ReplaceStringConstant_8(215L, "Internal Error: Unknown failure type in :- statement"));
                return;
            }

            Expression lhsExtract = null;
            if (expectExtract)
            {
                if (resolutionContext.CodeContext is Method caller && caller.Outs.Count == 0 && MutateCSharp.Schemata135.ReplaceBinExprOp_9(216L, KeywordToken, null))
                {
                    resolver.Reporter.Error(MessageSource.Resolver, Rhs.tok, MutateCSharp.Schemata135.ReplaceStringConstant_8(217L, "Expected {0} to have a Success/Failure output value"), caller.Name);
                    return;
                }

                lhsExtract = Lhss[MutateCSharp.Schemata135.ReplaceNumericConstant_0(218L, 0)];
                var lhsResolved = Lhss[MutateCSharp.Schemata135.ReplaceNumericConstant_0(222L, 0)].Resolved;
                // Make a new unresolved expression
                if (lhsResolved is MemberSelectExpr lexr)
                {
                    Expression id = MutateCSharp.Schemata135.ReplaceBinExprOp_19(226L, Expression.AsThis(lexr.Obj), null) ? lexr.Obj : resolver.makeTemp(MutateCSharp.Schemata135.ReplaceStringConstant_8(227L, "recv"), this, resolutionContext, lexr.Obj);
                    var lex = lhsExtract as ExprDotName; // might be just a NameSegment
                    lhsExtract = new ExprDotName(lexr.tok, id, lexr.MemberName, MutateCSharp.Schemata135.ReplaceBinExprOp_20(228L, lex, null) ? null : lex.OptTypeArguments);
                }
                else if (lhsResolved is SeqSelectExpr lseq)
                {
                    if (MutateCSharp.Schemata135.ReplaceBinExprOp_6(230L, () => !lseq.SelectOne, () => MutateCSharp.Schemata135.ReplaceBinExprOp_21(229L, lseq.E0, null)))
                    {
                        resolver.Reporter.Error(MessageSource.Resolver, Tok,
              MutateCSharp.Schemata135.ReplaceStringConstant_8(236L, "Element ranges not allowed as l-values"));
                        return;
                    }
                    Expression id = resolver.makeTemp(MutateCSharp.Schemata135.ReplaceStringConstant_8(237L, "recv"), this, resolutionContext, lseq.Seq);
                    Expression id0 = id0 = resolver.makeTemp(MutateCSharp.Schemata135.ReplaceStringConstant_8(238L, "idx"), this, resolutionContext, lseq.E0);
                    lhsExtract = new SeqSelectExpr(lseq.tok, lseq.SelectOne, id, id0, null, lseq.CloseParen);
                    lhsExtract.Type = lseq.Type;
                }
                else if (lhsResolved is MultiSelectExpr lmulti)
                {
                    Expression id = resolver.makeTemp(MutateCSharp.Schemata135.ReplaceStringConstant_8(239L, "recv"), this, resolutionContext, lmulti.Array);
                    var idxs = new List<Expression>();
                    foreach (var i in lmulti.Indices)
                    {
                        Expression idx = resolver.makeTemp(MutateCSharp.Schemata135.ReplaceStringConstant_8(240L, "idx"), this, resolutionContext, i);
                        idxs.Add(idx);
                    }
                    lhsExtract = new MultiSelectExpr(lmulti.tok, id, idxs);
                    lhsExtract.Type = lmulti.Type;
                }
                else if (lhsResolved is IdentifierExpr)
                {
                    // do nothing
                }
                else if (MutateCSharp.Schemata135.ReplaceBinExprOp_21(241L, lhsResolved, null))
                {
                    // LHS failed to resolve. Abort trying to resolve assign or return stmt
                    return;
                }
                else
                {
                    throw new InvalidOperationException(MutateCSharp.Schemata135.ReplaceStringConstant_8(242L, "Internal error: unexpected option in ResolveAssignOrReturnStmt"));
                }
            }

            DesugarElephantStatement(expectExtract, lhsExtract, firstType, resolver, (Method)resolutionContext.CodeContext);
            ResolvedStatements.ForEach(a => resolver.ResolveStatement(a, resolutionContext));
            resolver.EnsureSupportsErrorHandling(Tok, firstType, expectExtract, KeywordToken?.Token.val);
        }

        public void ResolveKeywordToken(INewOrOldResolver resolver, ResolutionContext resolutionContext)
        {
            if (MutateCSharp.Schemata135.ReplaceBinExprOp_9(243L, KeywordToken, null))
            {
                return;
            }

            if (MutateCSharp.Schemata135.ReplaceBinExprOp_10(252L, () => MutateCSharp.Schemata135.ReplaceBinExprOp_10(246L, () => !resolver.Options.Get(CommonOptionBag.AllowAxioms), () => MutateCSharp.Schemata135.ReplaceBinExprOp_13(245L, KeywordToken.Token.val, MutateCSharp.Schemata135.ReplaceStringConstant_8(244L, "assume"))), () => !KeywordToken.IsExplicitAxiom()))
            {
                resolver.Reporter.Warning(MessageSource.Verifier, ResolutionErrors.ErrorId.none, KeywordToken.Token, MutateCSharp.Schemata135.ReplaceStringConstant_8(258L, "assume keyword in update-with-failure statement has no {:axiom} annotation"));
            }

            resolver.ResolveAttributes(KeywordToken, resolutionContext);
        }

        /// <summary>
        /// Add to .Resolved
        /// </summary>
        /// <param name="expectExtract"></param>
        /// <param name="lhsExtract"></param>
        /// <param name="firstType"></param>
        /// <param name="resolver"></param>
        /// <param name="enclosingMethod"></param>
        private void DesugarElephantStatement(bool expectExtract, Expression lhsExtract, Type firstType,
          ModuleResolver resolver, Method enclosingMethod)
        {

            var temp = resolver.FreshTempVarName(MutateCSharp.Schemata135.ReplaceStringConstant_8(259L, "valueOrError"), enclosingMethod);
            var lhss = new List<LocalVariable>() { new LocalVariable(RangeToken, temp, new InferredTypeProxy(), MutateCSharp.Schemata135.ReplaceBooleanConstant_1(260L, false)) };
            // "var temp ;"
            ResolvedStatements.Add(new VarDeclStmt(RangeToken, lhss, null));
            var lhss2 = new List<Expression>() { new IdentifierExpr(Tok, temp) };
            for (int k = (expectExtract ? MutateCSharp.Schemata135.ReplaceNumericConstant_0(261L, 1) : MutateCSharp.Schemata135.ReplaceNumericConstant_0(265L, 0)); MutateCSharp.Schemata135.ReplaceBinExprOp_22(269L, k, Lhss.Count); MutateCSharp.Schemata135.ReplacePrefixUnaryExprOp_23(274L, ref k))
            {
                lhss2.Add(Lhss[k]);
            }
            List<AssignmentRhs> rhss2 = new List<AssignmentRhs>() { Rhs };
            if (MutateCSharp.Schemata135.ReplaceBinExprOp_24(278L, Rhss, null))
            {
                Rhss.ForEach(e => rhss2.Add(e));
            }
            if (MutateCSharp.Schemata135.ReplaceBinExprOp_10(289L, () => MutateCSharp.Schemata135.ReplaceBinExprOp_24(279L, Rhss, null), () => MutateCSharp.Schemata135.ReplaceBinExprOp_25(284L, Rhss.Count, MutateCSharp.Schemata135.ReplaceNumericConstant_0(280L, 0))))
            {
                if (MutateCSharp.Schemata135.ReplaceBinExprOp_3(295L, lhss2.Count, rhss2.Count))
                {
                    resolver.reporter.Error(MessageSource.Resolver, Tok,
            MutateCSharp.Schemata135.ReplaceStringConstant_8(300L, "Mismatch in expected number of LHSs and RHSs"));
                    if (MutateCSharp.Schemata135.ReplaceBinExprOp_22(301L, lhss2.Count, rhss2.Count))
                    {
                        rhss2.RemoveRange(lhss2.Count, MutateCSharp.Schemata135.ReplaceBinExprOp_18(306L, rhss2.Count, lhss2.Count));
                    }
                    else
                    {
                        lhss2.RemoveRange(rhss2.Count, MutateCSharp.Schemata135.ReplaceBinExprOp_18(315L, lhss2.Count, rhss2.Count));
                    }
                }
            }
            // " temp, ... := MethodOrExpression, ...;"
            UpdateStmt up = new UpdateStmt(RangeToken, lhss2, rhss2);
            if (expectExtract)
            {
                up.OriginalInitialLhs = MutateCSharp.Schemata135.ReplaceBinExprOp_5(328L, Lhss.Count, MutateCSharp.Schemata135.ReplaceNumericConstant_0(324L, 0)) ? null : Lhss[MutateCSharp.Schemata135.ReplaceNumericConstant_0(333L, 0)];
            }
            ResolvedStatements.Add(up);

            if (MutateCSharp.Schemata135.ReplaceBinExprOp_26(337L, KeywordToken, null))
            {
                var token = KeywordToken.Token;
                var notFailureExpr = new UnaryOpExpr(token, UnaryOpExpr.Opcode.Not, resolver.VarDotMethod(Tok, temp, MutateCSharp.Schemata135.ReplaceStringConstant_8(338L, "IsFailure")));
                Statement ss = null;
                if (MutateCSharp.Schemata135.ReplaceBinExprOp_13(340L, token.val, MutateCSharp.Schemata135.ReplaceStringConstant_8(339L, "expect")))
                {
                    // "expect !temp.IsFailure(), temp"
                    ss = new ExpectStmt(new RangeToken(token, EndToken), notFailureExpr, new IdentifierExpr(Tok, temp), KeywordToken.Attrs);
                }
                else if (MutateCSharp.Schemata135.ReplaceBinExprOp_13(342L, token.val, MutateCSharp.Schemata135.ReplaceStringConstant_8(341L, "assume")))
                {
                    ss = new AssumeStmt(new RangeToken(token, EndToken), notFailureExpr, SystemModuleManager.AxiomAttribute(KeywordToken.Attrs));
                }
                else if (MutateCSharp.Schemata135.ReplaceBinExprOp_13(344L, token.val, MutateCSharp.Schemata135.ReplaceStringConstant_8(343L, "assert")))
                {
                    ss = new AssertStmt(new RangeToken(token, EndToken), notFailureExpr, null, null, KeywordToken.Attrs);
                }
                else
                {
                    Contract.Assert(false, $"Invalid token in :- statement: {token.val}");
                }
                ResolvedStatements.Add(ss);
            }
            else
            {
                var enclosingOutParameter = enclosingMethod.Outs[MutateCSharp.Schemata135.ReplaceNumericConstant_0(345L, 0)];
                var ident = new IdentifierExpr(Tok, enclosingOutParameter.Name);
                // resolve it here to avoid capture into more closely declared local variables
                Contract.Assert(enclosingOutParameter.Type != null); // this confirms our belief that the out-parameter has already been resolved
                ident.Var = enclosingOutParameter;
                ident.Type = ident.Var.Type;

                ResolvedStatements.Add(
                  // "if temp.IsFailure()"
                  new IfStmt(RangeToken, MutateCSharp.Schemata135.ReplaceBooleanConstant_1(349L, false), resolver.VarDotMethod(Tok, temp, MutateCSharp.Schemata135.ReplaceStringConstant_8(350L, "IsFailure")),
                    // THEN: { out := temp.PropagateFailure(); return; }
                    new BlockStmt(RangeToken, new List<Statement>() {
            new UpdateStmt(RangeToken,
              new List<Expression>() { ident },
              new List<AssignmentRhs>() { new ExprRhs(resolver.VarDotMethod(Tok, temp, MutateCSharp.Schemata135.ReplaceStringConstant_8(351L, "PropagateFailure"))) }
            ),
            new ReturnStmt(RangeToken, null),
                    }),
                    // ELSE: no else block
                    null
                  ));
            }

            if (expectExtract)
            {
                // "y := temp.Extract();"
                var lhs = Lhss[MutateCSharp.Schemata135.ReplaceNumericConstant_0(352L, 0)];
                ResolvedStatements.Add(
                  new UpdateStmt(RangeToken,
                    new List<Expression>() { lhsExtract },
                    new List<AssignmentRhs>() { new ExprRhs(resolver.VarDotMethod(Tok, temp, MutateCSharp.Schemata135.ReplaceStringConstant_8(356L, "Extract"))) }
                  ));
                // The following check is not necessary, because the ghost mismatch is caught later.
                // However the error message here is much clearer.
                var m = resolver.ResolveMember(Tok, firstType, MutateCSharp.Schemata135.ReplaceStringConstant_8(357L, "Extract"), out _);
                if (MutateCSharp.Schemata135.ReplaceBinExprOp_10(365L, () => MutateCSharp.Schemata135.ReplaceBinExprOp_10(359L, () => MutateCSharp.Schemata135.ReplaceBinExprOp_15(358L, m, null), () => m.IsGhost), () => !AssignStmt.LhsIsToGhostOrAutoGhost(lhs)))
                {
                    resolver.reporter.Error(MessageSource.Resolver, lhs.tok,
            MutateCSharp.Schemata135.ReplaceStringConstant_8(371L, "The Extract member may not be ghost unless the initial LHS is ghost"));
                }
            }
        }
    }
}
