using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using Microsoft.Dafny.Auditor;
namespace MutateCSharp
{
    internal class Schemata152
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT152");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceNumericConstant_2(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static int ReplaceBinExprOp_9(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, int? argument1, int? argument2)
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
    public class ForallStmt : Statement, ICloneable<ForallStmt>, ICanFormat
    {
        public readonly List<BoundVar> BoundVars;  // note, can be the empty list, in which case Range denotes "true"
        public Expression Range;  // mostly readonly, except that it may in some cases be updated during resolution to conjoin the precondition of the call in the body
        public readonly List<AttributedExpression> Ens;
        public readonly Statement Body;
        [FilledInDuringResolution]
        public List<Expression> EffectiveEnsuresClauses;   // fill in by rewriter.
        public bool CanConvert = MutateCSharp.Schemata152.ReplaceBooleanConstant_0(1L, true); //  can convert to ForallExpressions

        [FilledInDuringResolution] public List<BoundedPool> Bounds;
        // invariant: if successfully resolved, Bounds.Count == BoundVars.Count;

        /// <summary>
        /// Assign means there are no ensures clauses and the body consists of one update statement,
        ///   either to an object field or to an array.
        /// Call means there are no ensures clauses and the body consists of a single call to a (presumably
        ///   ghost, but non-ghost is also allowed) method with no out-parameters and an empty modifies
        ///   clause.
        /// Proof means there is at least one ensures clause, and the body consists of any (presumably ghost,
        ///   but non-ghost is also allowed) code without side effects on variables (including fields and array
        ///   elements) declared outside the body itself.
        /// Notes:
        /// * More kinds may be allowed in the future.
        /// * One could also allow Call to call non-ghost methods without side effects.  However, that
        ///   would seem pointless in the program, so they are disallowed (to avoid any confusion that
        ///   such use of the forall statement might actually have a point).
        /// * One could allow Proof even without ensures clauses that "export" what was learned.
        ///   However, that might give the false impression that the body is nevertheless exported.
        /// </summary>
        public enum BodyKind { Assign, Call, Proof }
        [FilledInDuringResolution] public BodyKind Kind;

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(BoundVars != null);
            Contract.Invariant(Range != null);
            Contract.Invariant(BoundVars.Count != 0 || LiteralExpr.IsTrue(Range));
            Contract.Invariant(Ens != null);
        }

        public ForallStmt Clone(Cloner cloner)
        {
            return new ForallStmt(cloner, this);
        }

        public ForallStmt(Cloner cloner, ForallStmt original) : base(cloner, original)
        {
            BoundVars = original.BoundVars.ConvertAll(bv => cloner.CloneBoundVar(bv, MutateCSharp.Schemata152.ReplaceBooleanConstant_0(2L, false)));
            Range = cloner.CloneExpr(original.Range);
            Ens = original.Ens.Select(cloner.CloneAttributedExpr).ToList();
            Body = cloner.CloneStmt(original.Body, MutateCSharp.Schemata152.ReplaceBooleanConstant_0(3L, false));
            Attributes = cloner.CloneAttributes(original.Attributes);

            if (cloner.CloneResolvedFields)
            {
                Bounds = original.Bounds.ConvertAll(bp => bp.Clone(cloner));
                Kind = original.Kind;
                EffectiveEnsuresClauses = original.EffectiveEnsuresClauses?.Select(cloner.CloneExpr).ToList();
            }
        }

        public ForallStmt(RangeToken rangeToken, List<BoundVar> boundVars, Attributes attrs, Expression range, List<AttributedExpression> ens, Statement body)
          : base(rangeToken, attrs)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(cce.NonNullElements(boundVars));
            Contract.Requires(range != null);
            Contract.Requires(boundVars.Count != 0 || LiteralExpr.IsTrue(range));
            Contract.Requires(cce.NonNullElements(ens));
            this.BoundVars = boundVars;
            this.Range = range;
            this.Ens = ens;
            this.Body = body;
        }

        public Statement S0
        {
            get
            {
                // dig into Body to find a single statement
                Statement s = this.Body;
                while (MutateCSharp.Schemata152.ReplaceBooleanConstant_0(4L, true))
                {
                    var block = s as BlockStmt;
                    if (MutateCSharp.Schemata152.ReplaceBinExprOp_4(15L, () => MutateCSharp.Schemata152.ReplaceBinExprOp_1(5L, block, null), () => MutateCSharp.Schemata152.ReplaceBinExprOp_3(10L, block.Body.Count, MutateCSharp.Schemata152.ReplaceNumericConstant_2(6L, 1))))
                    {
                        s = block.Body[MutateCSharp.Schemata152.ReplaceNumericConstant_2(21L, 0)];
                        // dig further into s
                    }
                    else if (s is UpdateStmt)
                    {
                        var update = (UpdateStmt)s;
                        if (MutateCSharp.Schemata152.ReplaceBinExprOp_5(29L, update.ResolvedStatements?.Count, MutateCSharp.Schemata152.ReplaceNumericConstant_2(25L, 1)))
                        {
                            s = update.ResolvedStatements[MutateCSharp.Schemata152.ReplaceNumericConstant_2(34L, 0)];
                            // dig further into s
                        }
                        else
                        {
                            return s;
                        }
                    }
                    else
                    {
                        return s;
                    }
                }

                return default;
            }
        }

        public override IEnumerable<Statement> SubStatements
        {
            get
            {
                if (MutateCSharp.Schemata152.ReplaceBinExprOp_6(38L, Body, null))
                {
                    yield return Body;
                }

                yield break;
            }
        }

        public override IEnumerable<Expression> NonSpecificationSubExpressions
        {
            get
            {
                foreach (var e in base.NonSpecificationSubExpressions)
                {
                    yield return e;
                }

                yield return Range;
            }
        }

        public override IEnumerable<Expression> SpecificationSubExpressions
        {
            get
            {
                foreach (var e in base.SpecificationSubExpressions)
                {
                    yield return e;
                }
                foreach (var ee in Ens)
                {
                    foreach (var e in Attributes.SubExpressions(ee.Attributes)) { yield return e; }
                    yield return ee.E;
                }

                if (MutateCSharp.Schemata152.ReplaceBinExprOp_7(39L, EffectiveEnsuresClauses, null))
                {
                    foreach (var e in EffectiveEnsuresClauses)
                    {
                        yield return e;
                    }
                }

                yield break;
            }
        }

        public override IEnumerable<Assumption> Assumptions(Declaration decl)
        {
            if (Body is null)
            {
                yield return new Assumption(decl, tok, AssumptionDescription.ForallWithoutBody);
            }

            yield break;
        }

        public List<BoundVar> UncompilableBoundVars()
        {
            Contract.Ensures(Contract.Result<List<BoundVar>>() != null);
            var v = BoundedPool.PoolVirtues.Finite | BoundedPool.PoolVirtues.Enumerable;
            return BoundedPool.MissingBounds(BoundVars, Bounds, v);
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            formatter.SetIndentLikeLoop(OwnedTokens, Body, indentBefore);
            if (MutateCSharp.Schemata152.ReplaceBinExprOp_8(40L, Range, null))
            {
                formatter.Visit(Range, MutateCSharp.Schemata152.ReplaceBinExprOp_9(41L, indentBefore, formatter.SpaceTab));
            }
            foreach (var ens in Ens)
            {
                formatter.SetAttributedExpressionIndentation(ens, MutateCSharp.Schemata152.ReplaceBinExprOp_9(50L, indentBefore, formatter.SpaceTab));
            }

            formatter.SetClosingIndentedRegion(EndToken, indentBefore);
            return MutateCSharp.Schemata152.ReplaceBooleanConstant_0(59L, false);
        }
    }
}
