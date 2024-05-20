using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata77
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT77");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.BoundVar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.BoogieGenerator argument1, Microsoft.Dafny.BoogieGenerator argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceNumericConstant_3(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_5(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

    }
}

namespace Microsoft.Dafny
{
    public class LetExpr : Expression, IAttributeBearingDeclaration, IBoundVarsBearingExpression, ICloneable<LetExpr>, ICanFormat
    {
        public readonly List<CasePattern<BoundVar>> LHSs;
        public readonly List<Expression> RHSs;
        public readonly Expression Body;
        public readonly bool Exact;  // Exact==true means a regular let expression; Exact==false means an assign-such-that expression
        public Attributes Attributes { get; set; }

        [FilledInDuringResolution] public List<BoundedPool> Constraint_Bounds;  // null for Exact=true and for when expression is in a ghost context
                                                                                // invariant Constraint_Bounds == null || Constraint_Bounds.Count == BoundVars.Count;
        private Expression translationDesugaring;  // filled in during translation, lazily; to be accessed only via Translation.LetDesugaring; always null when Exact==true
        private BoogieGenerator lastBoogieGeneratorUsed; // avoid clashing desugaring between translators

        public void SetTranslationDesugaring(BoogieGenerator trans, Expression expr)
        {
            lastBoogieGeneratorUsed = trans;
            translationDesugaring = expr;
        }

        public Expression GetTranslationDesugaring(BoogieGenerator trans)
        {
            if (MutateCSharp.Schemata77.ReplaceBinExprOp_0(1L, lastBoogieGeneratorUsed, trans))
            {
                return translationDesugaring;
            }
            else
            {
                return null;
            }

            return default;
        }

        public LetExpr Clone(Cloner cloner)
        {
            return new LetExpr(cloner, this);
        }

        public LetExpr(Cloner cloner, LetExpr original) : base(cloner, original)
        {
            LHSs = original.LHSs.ConvertAll(cloner.CloneCasePattern);
            RHSs = original.RHSs.ConvertAll(cloner.CloneExpr);
            Body = cloner.CloneExpr(original.Body);
            Exact = original.Exact;
            Attributes = cloner.CloneAttributes(original.Attributes);
            if (cloner.CloneResolvedFields)
            {
                Constraint_Bounds = original.Constraint_Bounds;
            }
        }

        public LetExpr(IToken tok, List<CasePattern<BoundVar>> lhss, List<Expression> rhss, Expression body, bool exact, Attributes attrs = null)
          : base(tok)
        {
            LHSs = lhss;
            RHSs = rhss;
            Body = body;
            Exact = exact;
            Attributes = attrs;
        }

        public static LetExpr Havoc(IToken tok, Type type = null)
        {
            type ??= new InferredTypeProxy();
            var boundVar = new BoundVar(tok, MutateCSharp.Schemata77.ReplaceStringConstant_1(2L, "x"), type);
            var casePatterns = new List<CasePattern<BoundVar>>() { new(tok, boundVar) };
            return new LetExpr(tok, casePatterns, new List<Expression>() { CreateBoolLiteral(tok, MutateCSharp.Schemata77.ReplaceBooleanConstant_2(3L, true)) },
              new IdentifierExpr(tok, boundVar), MutateCSharp.Schemata77.ReplaceBooleanConstant_2(4L, false))
            {
                Type = type
            };
        }

        public override IEnumerable<Expression> SubExpressions
        {
            get
            {
                foreach (var e in Attributes.SubExpressions(Attributes))
                {
                    yield return e;
                }
                foreach (var rhs in RHSs)
                {
                    yield return rhs;
                }
                yield return Body;
            }
        }

        public override IEnumerable<Expression> TerminalExpressions
        {
            get
            {
                // The terminal expressions of a let expression are usually the terminal expressions of
                // the let's body. However, if anyone of those terminal expressions is a simple bound
                // variable of an exact let expression, then that terminal expression is replaced by
                // the terminal expressions of the corresponding RHS.
                // For example, the terminal expressions of
                //     var x := E;
                //     assert P(x);
                //     x
                // are the terminal expressions of E.
                Contract.Assert(!Exact || LHSs.Count == RHSs.Count);
                var rhsUsed = new bool[LHSs.Count];
                foreach (var e in Body.TerminalExpressions)
                {
                    if (Exact)
                    {
                        for (var i = MutateCSharp.Schemata77.ReplaceNumericConstant_3(5L, 0); MutateCSharp.Schemata77.ReplaceBinExprOp_4(9L, i, LHSs.Count); MutateCSharp.Schemata77.ReplacePostfixUnaryExprOp_5(14L, ref i))
                        {
                            if (MutateCSharp.Schemata77.ReplaceBinExprOp_7(16L, () => MutateCSharp.Schemata77.ReplaceBinExprOp_6(15L, LHSs[i].Var, null), () => IdentifierExpr.Is(e, LHSs[i].Var)))
                            {
                                if (!rhsUsed[i])
                                {
                                    foreach (var ee in RHSs[i].TerminalExpressions)
                                    {
                                        yield return ee;
                                    }
                                    rhsUsed[i] = MutateCSharp.Schemata77.ReplaceBooleanConstant_2(22L, true);
                                }
                                goto Next;
                            }
                        }
                    }
                    yield return e;
                Next: { }
                }

                yield break;
            }
        }

        public override IEnumerable<Type> ComponentTypes => BoundVars.Select(bv => bv.Type);

        public IEnumerable<BoundVar> BoundVars
        {
            get
            {
                foreach (var lhs in LHSs)
                {
                    foreach (var bv in lhs.Vars)
                    {
                        yield return bv;
                    }
                }

                yield break;
            }
        }

        public IEnumerable<BoundVar> AllBoundVars => BoundVars;

        public override IEnumerable<INode> Children =>
          (MutateCSharp.Schemata77.ReplaceBinExprOp_8(23L, Attributes, null) ? new List<Node> { Attributes } : Enumerable.Empty<Node>())
          .Concat(LHSs)
          .Concat(base.Children);

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            return formatter.SetIndentVarDeclStmt(indentBefore, OwnedTokens, MutateCSharp.Schemata77.ReplaceBooleanConstant_2(24L, false), MutateCSharp.Schemata77.ReplaceBooleanConstant_2(25L, true));
        }
    }
}
