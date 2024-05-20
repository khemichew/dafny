using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata398
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT398");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
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

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.MultiSetType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_4(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.SetType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.SeqType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_10(long mutantId, string argument1)
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
class FillInDefaultLoopDecreases_Visitor : ResolverBottomUpVisitor
    {
        readonly ICallable EnclosingMethod;
        public FillInDefaultLoopDecreases_Visitor(ModuleResolver resolver, ICallable enclosingMethod)
          : base(resolver)
        {
            Contract.Requires(resolver != null);
            Contract.Requires(enclosingMethod != null);
            EnclosingMethod = enclosingMethod;
        }
        protected override void VisitOneStmt(Statement stmt)
        {
            if (stmt is WhileStmt)
            {
                var s = (WhileStmt)stmt;
                FillInDefaultLoopDecreases(resolver, s, s.Guard, s.Decreases.Expressions, EnclosingMethod);
            }
            else if (stmt is AlternativeLoopStmt)
            {
                var s = (AlternativeLoopStmt)stmt;
                FillInDefaultLoopDecreases(resolver, s, null, s.Decreases.Expressions, EnclosingMethod);
            }
        }

        private static void FillInDefaultLoopDecreases(ModuleResolver resolver, LoopStmt loopStmt, Expression guard, List<Expression> theDecreases, ICallable enclosingMethod)
        {
            Contract.Requires(loopStmt != null);
            Contract.Requires(theDecreases != null);

            if (MutateCSharp.Schemata398.ReplaceBinExprOp_3(11L, () => MutateCSharp.Schemata398.ReplaceBinExprOp_1(5L, theDecreases.Count, MutateCSharp.Schemata398.ReplaceNumericConstant_0(1L, 0)), () => MutateCSharp.Schemata398.ReplaceBinExprOp_2(10L, guard, null)))
            {
                loopStmt.InferredDecreases = MutateCSharp.Schemata398.ReplaceBooleanConstant_4(17L, true);
                Expression prefix = null;
                foreach (Expression guardConjunct in Expression.Conjuncts(guard))
                {
                    Expression guess = null;
                    var neutralValue = Expression.CreateIntLiteral(guardConjunct.tok, MutateCSharp.Schemata398.ReplaceNumericConstant_0(18L, -1));
                    if (guardConjunct is BinaryExpr bin)
                    {
                        switch (bin.ResolvedOp)
                        {
                            case BinaryExpr.ResolvedOpcode.Lt:
                            case BinaryExpr.ResolvedOpcode.Le:
                            case BinaryExpr.ResolvedOpcode.LtChar:
                            case BinaryExpr.ResolvedOpcode.LeChar:
                                if (bin.E0.Type.IsBigOrdinalType)
                                {
                                    // we can't rely on subtracting ORDINALs, so let's just pick the upper bound and hope that works
                                    guess = bin.E1;
                                }
                                else
                                {
                                    // for A < B and A <= B, use the decreases B - A
                                    guess = Expression.CreateSubtract_TypeConvert(bin.E1, bin.E0);
                                }
                                break;
                                break;
                            case BinaryExpr.ResolvedOpcode.Ge:
                            case BinaryExpr.ResolvedOpcode.Gt:
                            case BinaryExpr.ResolvedOpcode.GeChar:
                            case BinaryExpr.ResolvedOpcode.GtChar:
                                if (bin.E0.Type.IsBigOrdinalType)
                                {
                                    // we can't rely on subtracting ORDINALs, so let's just pick the upper bound and hope that works
                                    guess = bin.E0;
                                }
                                else
                                {
                                    // for A >= B and A > B, use the decreases A - B
                                    guess = Expression.CreateSubtract_TypeConvert(bin.E0, bin.E1);
                                }
                                break;
                                break;
                            case BinaryExpr.ResolvedOpcode.ProperSubset:
                            case BinaryExpr.ResolvedOpcode.Subset:
                                if (bin.E0.Type.AsSetType.Finite)
                                {
                                    // for A < B and A <= B, use the decreases |B - A|
                                    guess = Expression.CreateCardinality(Expression.CreateSetDifference(bin.E1, bin.E0), resolver.SystemModuleManager);
                                }
                                break;
                                break;
                            case BinaryExpr.ResolvedOpcode.Superset:
                            case BinaryExpr.ResolvedOpcode.ProperSuperset:
                                if (bin.E0.Type.AsSetType.Finite)
                                {
                                    // for A >= B and A > B, use the decreases |A - B|
                                    guess = Expression.CreateCardinality(Expression.CreateSetDifference(bin.E0, bin.E1), resolver.SystemModuleManager);
                                }
                                break;
                                break;
                            case BinaryExpr.ResolvedOpcode.ProperMultiSubset:
                            case BinaryExpr.ResolvedOpcode.MultiSubset:
                                // for A < B and A <= B, use the decreases |B - A|
                                guess = Expression.CreateCardinality(Expression.CreateMultisetDifference(bin.E1, bin.E0), resolver.SystemModuleManager);
                                break;
                                break;
                            case BinaryExpr.ResolvedOpcode.MultiSuperset:
                            case BinaryExpr.ResolvedOpcode.ProperMultiSuperset:
                                // for A >= B and A > B, use the decreases |A - B|
                                guess = Expression.CreateCardinality(Expression.CreateMultisetDifference(bin.E0, bin.E1), resolver.SystemModuleManager);
                                break;
                                break;
                            case BinaryExpr.ResolvedOpcode.Prefix:
                            case BinaryExpr.ResolvedOpcode.ProperPrefix:
                                // for "[] < B" and "[] <= B", use B
                                if (LiteralExpr.IsEmptySequence(bin.E0))
                                {
                                    guess = bin.E1;
                                }
                                break;
                                break;
                            case BinaryExpr.ResolvedOpcode.NeqCommon:
                                if (bin.E0.Type.IsNumericBased() || bin.E0.Type.IsBitVectorType || bin.E0.Type.IsCharType)
                                {
                                    // for A != B where A and B are numeric, use the absolute difference between A and B (that is: if A <= B then B-A else A-B)
                                    var AminusB = Expression.CreateSubtract_TypeConvert(bin.E0, bin.E1);
                                    var BminusA = Expression.CreateSubtract_TypeConvert(bin.E1, bin.E0);
                                    var test = Expression.CreateAtMost(bin.E0, bin.E1);
                                    guess = Expression.CreateITE(test, BminusA, AminusB);
                                }
                                else if (bin.E0.Type.IsBigOrdinalType)
                                {
                                    // if either of the operands is a literal, pick the other; otherwise, don't make any guess
                                    if (Expression.StripParens(bin.E0) is LiteralExpr)
                                    {
                                        guess = bin.E1;
                                    }
                                    else if (Expression.StripParens(bin.E1) is LiteralExpr)
                                    {
                                        guess = bin.E0;
                                    }
                                }
                                break;
                                break;
                            case BinaryExpr.ResolvedOpcode.SetNeq:
                                if (bin.E0.Type.AsSetType.Finite)
                                {
                                    // use |A - B| + |B - A|, but specialize it for the case where A or B is the empty set
                                    if (LiteralExpr.IsEmptySet(bin.E0))
                                    {
                                        guess = bin.E1;
                                    }
                                    else if (LiteralExpr.IsEmptySet(bin.E1))
                                    {
                                        guess = bin.E0;
                                    }
                                    else
                                    {
                                        var x = Expression.CreateCardinality(Expression.CreateSetDifference(bin.E0, bin.E1), resolver.SystemModuleManager);
                                        var y = Expression.CreateCardinality(Expression.CreateSetDifference(bin.E1, bin.E0), resolver.SystemModuleManager);
                                        guess = Expression.CreateAdd(x, y);
                                    }
                                }
                                break;
                                break;
                            case BinaryExpr.ResolvedOpcode.MultiSetNeq:
                                // use |A - B| + |B - A|, but specialize it for the case where A or B is the empty multiset
                                if (LiteralExpr.IsEmptyMultiset(bin.E0))
                                {
                                    guess = bin.E1;
                                }
                                else if (LiteralExpr.IsEmptyMultiset(bin.E1))
                                {
                                    guess = bin.E0;
                                }
                                else
                                {
                                    var x = Expression.CreateCardinality(Expression.CreateMultisetDifference(bin.E0, bin.E1), resolver.SystemModuleManager);
                                    var y = Expression.CreateCardinality(Expression.CreateMultisetDifference(bin.E1, bin.E0), resolver.SystemModuleManager);
                                    guess = Expression.CreateAdd(x, y);
                                }
                                break;
                                break;
                            case BinaryExpr.ResolvedOpcode.SeqNeq:
                                // if either operand is [], then use the other
                                if (LiteralExpr.IsEmptySequence(bin.E0))
                                {
                                    guess = bin.E1;
                                }
                                else if (LiteralExpr.IsEmptySequence(bin.E1))
                                {
                                    guess = bin.E0;
                                }
                                break;
                                break;
                            default:
                                break;
                                break;
                        }
                        if (MutateCSharp.Schemata398.ReplaceBinExprOp_5(22L, bin.E0.Type.AsSetType, null))
                        {
                            neutralValue = new SetDisplayExpr(bin.tok, bin.E0.Type.AsSetType.Finite, new List<Expression>())
                            {
                                Type = bin.E0.Type.NormalizeExpand()
                            };
                        }
                        else if (MutateCSharp.Schemata398.ReplaceBinExprOp_6(23L, bin.E0.Type.AsMultiSetType, null))
                        {
                            neutralValue = new MultiSetDisplayExpr(bin.tok, new List<Expression>())
                            {
                                Type = bin.E0.Type.NormalizeExpand()
                            };
                        }
                        else if (MutateCSharp.Schemata398.ReplaceBinExprOp_7(24L, bin.E0.Type.AsSeqType, null))
                        {
                            neutralValue = new SeqDisplayExpr(bin.tok, new List<Expression>())
                            {
                                Type = bin.E0.Type.NormalizeExpand()
                            };
                        }
                        else if (bin.E0.Type.IsNumericBased(Type.NumericPersuasion.Real))
                        {
                            neutralValue = Expression.CreateRealLiteral(bin.tok, BaseTypes.BigDec.FromInt(MutateCSharp.Schemata398.ReplaceNumericConstant_0(25L, -1)));
                        }
                    }
                    if (MutateCSharp.Schemata398.ReplaceBinExprOp_2(29L, guess, null))
                    {
                        if (MutateCSharp.Schemata398.ReplaceBinExprOp_2(30L, prefix, null))
                        {
                            // Make the following guess:  if prefix then guess else neutralValue
                            guess = Expression.CreateITE(prefix, guess, neutralValue);
                        }
                        theDecreases.Add(AutoGeneratedExpression.Create(guess));
                    }
                    if (MutateCSharp.Schemata398.ReplaceBinExprOp_8(31L, prefix, null))
                    {
                        prefix = guardConjunct;
                    }
                    else
                    {
                        prefix = Expression.CreateAnd(prefix, guardConjunct);
                    }
                }
            }
            if (enclosingMethod is IteratorDecl)
            {
                var iter = (IteratorDecl)enclosingMethod;
                var ie = new IdentifierExpr(loopStmt.Tok, iter.YieldCountVariable.Name);
                ie.Var = iter.YieldCountVariable;  // resolve here
                ie.Type = iter.YieldCountVariable.Type;  // resolve here
                theDecreases.Insert(MutateCSharp.Schemata398.ReplaceNumericConstant_0(32L, 0), AutoGeneratedExpression.Create(ie));
                loopStmt.InferredDecreases = MutateCSharp.Schemata398.ReplaceBooleanConstant_4(36L, true);
            }
            if (MutateCSharp.Schemata398.ReplaceBinExprOp_3(46L, () => loopStmt.InferredDecreases, () => MutateCSharp.Schemata398.ReplaceBinExprOp_9(41L, theDecreases.Count, MutateCSharp.Schemata398.ReplaceNumericConstant_0(37L, 0))))
            {
                string s = MutateCSharp.Schemata398.ReplaceStringConstant_10(52L, "decreases ") + Util.Comma(theDecreases, expr => Printer.ExprToString(resolver.Options, expr));
                resolver.reporter.Info(MessageSource.Resolver, loopStmt.Tok, s);
            }
        }
    }
}