using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Numerics;
namespace MutateCSharp
{
    internal class Schemata51
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT51");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_18(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, Microsoft.Dafny.LiteralExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBinExprOp_16(long mutantId, System.Collections.Generic.Dictionary<Microsoft.Dafny.TypeParameter, Microsoft.Dafny.Type> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_3(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static int ReplaceNumericConstant_10(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument1, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.UnaryOpExpr.Opcode argument1, Microsoft.Dafny.UnaryOpExpr.Opcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument1, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.ConcreteSyntaxExpression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePrefixUnaryExprOp_13(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return +argument1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return ~argument1; }
            return -argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_17(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.PreType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, Microsoft.Dafny.StringLiteralExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, int argument1, int argument2)
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
    public abstract class Expression : TokenNode
    {
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(tok != null);
        }

        [System.Diagnostics.Contracts.Pure]
        public bool WasResolved()
        {
            return MutateCSharp.Schemata51.ReplaceBinExprOp_2(3L, () => MutateCSharp.Schemata51.ReplaceBinExprOp_0(1L, PreType, null), () => MutateCSharp.Schemata51.ReplaceBinExprOp_1(2L, Type, null));
        }

        public Expression Resolved
        {
            get
            {
                Contract.Requires(WasResolved());  // should be called only on resolved expressions; this approximates that precondition
                Expression r = this;
                while (MutateCSharp.Schemata51.ReplaceBooleanConstant_3(9L, true))
                {
                    Contract.Assert(r.WasResolved());  // this.WasResolved() implies anything it reaches is also resolved
                    var rr = r as ConcreteSyntaxExpression;
                    if (MutateCSharp.Schemata51.ReplaceBinExprOp_4(10L, rr, null))
                    {
                        return r;
                    }
                    r = rr.ResolvedExpression;
                    if (MutateCSharp.Schemata51.ReplaceBinExprOp_5(11L, r, null))
                    {
                        // for a NegationExpression, we're willing to return its non-ResolveExpression form (since it is filled in
                        // during a resolution phase after type checking and we may be called here during type checking)
                        return rr is NegationExpression ? rr : null;
                    }
                }

                return default;
            }
        }

        public PreType PreType;

        public virtual IEnumerable<Expression> TerminalExpressions
        {
            get
            {
                yield return this;
            }
        }

        [FilledInDuringResolution] protected Type type;
        public Type Type
        {
            get
            {
                Contract.Ensures(type != null || Contract.Result<Type>() == null);  // useful in conjunction with postcondition of constructor
                return MutateCSharp.Schemata51.ReplaceBinExprOp_6(12L, type, null) ? null : type.Normalize();
            }
            set
            {
                Contract.Requires(!WasResolved());  // set it only once
                Contract.Requires(value != null);

                //modifies type;
                type = value.Normalize();
            }
        }

        /// <summary>
        /// The new type inference includes a "type refinement" phase, which determines the best subset types for a program. This phase works
        /// by refining (mutating in the direction from bottom, meaning un ansatisfiable constraint, to top, meaning no constraint) types in place,
        /// using "TypeRefinementWrapper" type proxies. During that phase, it is necessary to obtain the
        /// un-normalized type stored in each AST node, which is what the "UnnormalizedType" property does. This property should only be used
        /// during the type refinement phase. After type inference is complete, use ".Type" instead.
        /// </summary>
        public Type UnnormalizedType
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        /// <summary>
        /// This method can be used when .Type has been found to be erroneous and its current value
        /// would be unexpected by the rest of the resolver. This method then sets .Type to a neutral
        /// value.
        /// </summary>
        public void ResetTypeAssignment()
        {
            Contract.Requires(WasResolved());
            type = new InferredTypeProxy();
        }
#if TEST_TYPE_SYNONYM_TRANSPARENCY
    public void DebugTest_ChangeType(Type ty) {
      Contract.Requires(WasResolved());  // we're here to set it again
      Contract.Requires(ty != null);
      type = ty;
    }
#endif

        public Expression(IToken tok)
        {
            Contract.Requires(tok != null);
            Contract.Ensures(type == null);  // we would have liked to have written Type==null, but that's not admissible or provable

            this.tok = tok;
        }

        protected Expression(Cloner cloner, Expression original)
        {

            tok = cloner.Tok(original.tok);
            RangeToken = cloner.Range(original.RangeToken);

            if (MutateCSharp.Schemata51.ReplaceBinExprOp_7(14L, () => cloner.CloneResolvedFields, () => MutateCSharp.Schemata51.ReplaceBinExprOp_1(13L, original.Type, null)))
            {
                Type = original.Type;
            }
        }

        public override string ToString()
        {
            try
            {
                return Printer.ExprToString(DafnyOptions.DefaultImmutableOptions, this);
            }
            catch (Exception e)
            {
                return $"couldn't print expr because: {e.Message}";
            }

            return default;
        }

        /// <summary>
        /// Returns the non-null subexpressions of the Expression.  To be called after the expression has been resolved; this
        /// means, for example, that any concrete syntax that resolves to some other expression will return the subexpressions
        /// of the resolved expression.
        /// </summary>
        public virtual IEnumerable<Expression> SubExpressions
        {
            get { yield break; }
        }

        /// <summary>
        /// Returns the list of types that appear in this expression proper (that is, not including types that
        /// may appear in subexpressions). Types occurring in substatements of the expression are not included.
        /// To be called after the expression has been resolved.
        /// </summary>
        public virtual IEnumerable<Type> ComponentTypes
        {
            get { yield break; }
        }

        public virtual bool IsImplicit
        {
            get { return MutateCSharp.Schemata51.ReplaceBooleanConstant_3(20L, false); }
        }

        public static IEnumerable<Expression> Conjuncts(Expression expr)
        {
            Contract.Requires(expr != null);
            Contract.Requires(expr.Type.IsBoolType);
            Contract.Ensures(cce.NonNullElements(Contract.Result<IEnumerable<Expression>>()));

            expr = StripParens(expr);
            if (expr is UnaryOpExpr unary && MutateCSharp.Schemata51.ReplaceBinExprOp_8(21L, unary.Op, UnaryOpExpr.Opcode.Not))
            {
                foreach (Expression e in Disjuncts(unary.E))
                {
                    yield return Expression.CreateNot(e.tok, e);
                }
                yield break;

            }
            else if (expr is BinaryExpr bin)
            {
                if (MutateCSharp.Schemata51.ReplaceBinExprOp_9(22L, bin.ResolvedOp, BinaryExpr.ResolvedOpcode.And))
                {
                    foreach (Expression e in Conjuncts(bin.E0))
                    {
                        yield return e;
                    }
                    foreach (Expression e in Conjuncts(bin.E1))
                    {
                        yield return e;
                    }
                    yield break;
                }
            }

            yield return expr;
        }

        public static IEnumerable<Expression> Disjuncts(Expression expr)
        {
            Contract.Requires(expr != null);
            Contract.Requires(expr.Type.IsBoolType);
            Contract.Ensures(cce.NonNullElements(Contract.Result<IEnumerable<Expression>>()));

            expr = StripParens(expr);
            if (expr is UnaryOpExpr unary && MutateCSharp.Schemata51.ReplaceBinExprOp_8(23L, unary.Op, UnaryOpExpr.Opcode.Not))
            {
                foreach (Expression e in Conjuncts(unary.E))
                {
                    yield return Expression.CreateNot(e.tok, e);
                }
                yield break;

            }
            else if (expr is BinaryExpr bin)
            {
                if (MutateCSharp.Schemata51.ReplaceBinExprOp_9(24L, bin.ResolvedOp, BinaryExpr.ResolvedOpcode.Or))
                {
                    foreach (Expression e in Conjuncts(bin.E0))
                    {
                        yield return e;
                    }
                    foreach (Expression e in Conjuncts(bin.E1))
                    {
                        yield return e;
                    }
                    yield break;
                }
                else if (MutateCSharp.Schemata51.ReplaceBinExprOp_9(25L, bin.ResolvedOp, BinaryExpr.ResolvedOpcode.Imp))
                {
                    foreach (Expression e in Conjuncts(bin.E0))
                    {
                        yield return Expression.CreateNot(e.tok, e);
                    }
                    foreach (Expression e in Conjuncts(bin.E1))
                    {
                        yield return e;
                    }
                    yield break;
                }
            }

            yield return expr;
        }

        /// <summary>
        /// Create a resolved expression of the form "e0 + e1"
        /// </summary>
        public static Expression CreateAdd(Expression e0, Expression e1)
        {
            Contract.Requires(e0 != null);
            Contract.Requires(e1 != null);
            Contract.Requires(
              (e0.Type.IsNumericBased(Type.NumericPersuasion.Int) && e1.Type.IsNumericBased(Type.NumericPersuasion.Int)) ||
              (e0.Type.IsNumericBased(Type.NumericPersuasion.Real) && e1.Type.IsNumericBased(Type.NumericPersuasion.Real)));
            Contract.Ensures(Contract.Result<Expression>() != null);
            var s = new BinaryExpr(e0.tok, BinaryExpr.Opcode.Add, e0, e1);
            s.ResolvedOp = BinaryExpr.ResolvedOpcode.Add;  // resolve here
            s.Type = e0.Type.NormalizeExpand();  // resolve here
            return s;
        }

        /// <summary>
        /// Create a resolved expression of the form "e0 * e1"
        /// </summary>
        public static Expression CreateMul(Expression e0, Expression e1)
        {
            Contract.Requires(e0 != null);
            Contract.Requires(e1 != null);
            Contract.Requires(
              (e0.Type.IsNumericBased(Type.NumericPersuasion.Int) && e1.Type.IsNumericBased(Type.NumericPersuasion.Int)) ||
              (e0.Type.IsNumericBased(Type.NumericPersuasion.Real) && e1.Type.IsNumericBased(Type.NumericPersuasion.Real)));
            Contract.Ensures(Contract.Result<Expression>() != null);
            var s = new BinaryExpr(e0.tok, BinaryExpr.Opcode.Mul, e0, e1);
            s.ResolvedOp = BinaryExpr.ResolvedOpcode.Mul;  // resolve here
            s.Type = e0.Type.NormalizeExpand();  // resolve here
            return s;
        }

        /// <summary>
        /// Create a resolved expression of the form "CVT(e0) - CVT(e1)", where "CVT" is either "int" (if
        /// e0.Type is an integer-based numeric type) or "real" (if e0.Type is a real-based numeric type).
        /// </summary>
        public static Expression CreateSubtract_TypeConvert(Expression e0, Expression e1)
        {
            Contract.Requires(e0 != null);
            Contract.Requires(e1 != null);
            Contract.Requires(
              (e0.Type.IsNumericBased(Type.NumericPersuasion.Int) && e1.Type.IsNumericBased(Type.NumericPersuasion.Int)) ||
              (e0.Type.IsNumericBased(Type.NumericPersuasion.Real) && e1.Type.IsNumericBased(Type.NumericPersuasion.Real)) ||
              (e0.Type.IsBitVectorType && e1.Type.IsBitVectorType) ||
              (e0.Type.IsCharType && e1.Type.IsCharType));
            Contract.Ensures(Contract.Result<Expression>() != null);

            Type toType;
            if (e0.Type.IsNumericBased(Type.NumericPersuasion.Int))
            {
                toType = Type.Int;
            }
            else if (e0.Type.IsNumericBased(Type.NumericPersuasion.Real))
            {
                toType = Type.Real;
            }
            else
            {
                Contract.Assert(e0.Type.IsBitVectorType || e0.Type.IsCharType);
                toType = Type.Int; // convert char and bitvectors to int
            }
            e0 = CastIfNeeded(e0, toType);
            e1 = CastIfNeeded(e1, toType);
            return CreateSubtract(e0, e1);
        }

        private static Expression CastIfNeeded(Expression expr, Type toType)
        {
            if (!expr.Type.Equals(toType))
            {
                var cast = new ConversionExpr(expr.tok, expr, toType);
                cast.Type = toType;
                return cast;
            }
            else
            {
                return expr;
            }

            return default;
        }

        /// <summary>
        /// Create a resolved expression of the form "e0 - e1"
        /// </summary>
        public static Expression CreateSubtract(Expression e0, Expression e1)
        {
            Contract.Requires(e0 != null);
            Contract.Requires(e0.Type != null);
            Contract.Requires(e1 != null);
            Contract.Requires(e1.Type != null);
            Contract.Requires(
              (e0.Type.IsNumericBased(Type.NumericPersuasion.Int) && e1.Type.IsNumericBased(Type.NumericPersuasion.Int)) ||
              (e0.Type.IsNumericBased(Type.NumericPersuasion.Real) && e1.Type.IsNumericBased(Type.NumericPersuasion.Real)) ||
              (e0.Type.IsBigOrdinalType && e1.Type.IsBigOrdinalType));
            Contract.Ensures(Contract.Result<Expression>() != null);
            var s = new BinaryExpr(e0.tok, BinaryExpr.Opcode.Sub, e0, e1);
            s.ResolvedOp = BinaryExpr.ResolvedOpcode.Sub;  // resolve here
            s.Type = e0.Type.NormalizeExpand();  // resolve here (and it's important to remove any constraints)
            return s;
        }

        /// <summary>
        /// Create a resolved expression of the form "e0 - e1".
        /// Optimization: If either "e0" or "e1" is the literal denoting the empty set, then just return "e0".
        /// </summary>
        public static Expression CreateSetDifference(Expression e0, Expression e1)
        {
            Contract.Requires(e0 != null);
            Contract.Requires(e0.Type != null);
            Contract.Requires(e1 != null);
            Contract.Requires(e1.Type != null);
            Contract.Requires(e0.Type.AsSetType != null && e1.Type.AsSetType != null);
            Contract.Ensures(Contract.Result<Expression>() != null);
            if (MutateCSharp.Schemata51.ReplaceBinExprOp_2(26L, () => LiteralExpr.IsEmptySet(e0), () => LiteralExpr.IsEmptySet(e1)))
            {
                return e0;
            }
            var s = new BinaryExpr(e0.tok, BinaryExpr.Opcode.Sub, e0, e1)
            {
                ResolvedOp = BinaryExpr.ResolvedOpcode.SetDifference,
                Type = e0.Type.NormalizeExpand() // important to remove any constraints
            };
            return s;
        }

        /// <summary>
        /// Create a resolved expression of the form "e0 - e1".
        /// Optimization: If either "e0" or "e1" is the literal denoting the empty multiset, then just return "e0".
        /// </summary>
        public static Expression CreateMultisetDifference(Expression e0, Expression e1)
        {
            Contract.Requires(e0 != null);
            Contract.Requires(e0.Type != null);
            Contract.Requires(e1 != null);
            Contract.Requires(e1.Type != null);
            Contract.Requires(e0.Type.AsMultiSetType != null && e1.Type.AsMultiSetType != null);
            Contract.Ensures(Contract.Result<Expression>() != null);
            if (MutateCSharp.Schemata51.ReplaceBinExprOp_2(32L, () => LiteralExpr.IsEmptyMultiset(e0), () => LiteralExpr.IsEmptyMultiset(e1)))
            {
                return e0;
            }
            var s = new BinaryExpr(e0.tok, BinaryExpr.Opcode.Sub, e0, e1)
            {
                ResolvedOp = BinaryExpr.ResolvedOpcode.MultiSetDifference,
                Type = e0.Type.NormalizeExpand() // important to remove any constraints
            };
            return s;
        }

        /// <summary>
        /// Create a resolved expression of the form "|e|"
        /// </summary>
        public static Expression CreateCardinality(Expression e, SystemModuleManager systemModuleManager)
        {
            Contract.Requires(e != null);
            Contract.Requires(e.Type != null);
            Contract.Requires(e.Type.AsSetType != null || e.Type.AsMultiSetType != null || e.Type.AsSeqType != null);
            Contract.Ensures(Contract.Result<Expression>() != null);
            var s = new UnaryOpExpr(e.tok, UnaryOpExpr.Opcode.Cardinality, e)
            {
                Type = systemModuleManager.Nat()
            };
            return s;
        }

        /// <summary>
        /// Create a resolved expression of the form "e + n"
        /// </summary>
        public static Expression CreateIncrement(Expression e, int n)
        {
            Contract.Requires(e != null);
            Contract.Requires(e.Type != null);
            Contract.Requires(e.Type.IsNumericBased(Type.NumericPersuasion.Int));
            Contract.Requires(0 <= n);
            Contract.Ensures(Contract.Result<Expression>() != null);
            if (MutateCSharp.Schemata51.ReplaceBinExprOp_11(42L, n, MutateCSharp.Schemata51.ReplaceNumericConstant_10(38L, 0)))
            {
                return e;
            }
            var nn = CreateIntLiteral(e.tok, n);
            return CreateAdd(e, nn);
        }

        /// <summary>
        /// Create a resolved expression of the form "e - n"
        /// </summary>
        public static Expression CreateDecrement(Expression e, int n, Type ty = null)
        {
            Contract.Requires(e != null);
            Contract.Requires(e.Type.IsNumericBased(Type.NumericPersuasion.Int));
            Contract.Requires(0 <= n);
            Contract.Ensures(Contract.Result<Expression>() != null);
            if (MutateCSharp.Schemata51.ReplaceBinExprOp_11(51L, n, MutateCSharp.Schemata51.ReplaceNumericConstant_10(47L, 0)))
            {
                return e;
            }
            var nn = CreateIntLiteral(e.tok, n, ty);
            return CreateSubtract(e, nn);
        }

        /// <summary>
        /// Create a resolved expression of the form "n"
        /// </summary>
        public static Expression CreateIntLiteral(IToken tok, int n, Type ty = null)
        {
            Contract.Requires(tok != null);
            Contract.Requires(n != int.MinValue);
            if (MutateCSharp.Schemata51.ReplaceBinExprOp_12(60L, MutateCSharp.Schemata51.ReplaceNumericConstant_10(56L, 0), n))
            {
                var nn = new LiteralExpr(tok, n);
                nn.Type = ty ?? Type.Int;
                return nn;
            }
            else
            {
                return CreateDecrement(CreateIntLiteral(tok, MutateCSharp.Schemata51.ReplaceNumericConstant_10(65L, 0), ty), MutateCSharp.Schemata51.ReplacePrefixUnaryExprOp_13(69L, n), ty);
            }

            return default;
        }

        /// <summary>
        /// Create a resolved expression of the form "x"
        /// </summary>
        public static Expression CreateRealLiteral(IToken tok, BaseTypes.BigDec x)
        {
            Contract.Requires(tok != null);
            var nn = new LiteralExpr(tok, x);
            nn.Type = Type.Real;
            return nn;
        }

        /// <summary>
        /// Create a resolved expression of the form "n", for either type "int" or type "ORDINAL".
        /// </summary>
        public static Expression CreateNatLiteral(IToken tok, int n, Type ty)
        {
            Contract.Requires(tok != null);
            Contract.Requires(0 <= n);
            Contract.Requires(ty.IsNumericBased(Type.NumericPersuasion.Int) || ty is BigOrdinalType);
            var nn = new LiteralExpr(tok, n);
            nn.Type = ty;
            return nn;
        }

        /// <summary>
        /// Create a resolved expression for a bool b
        /// </summary>
        public static LiteralExpr CreateBoolLiteral(IToken tok, bool b)
        {
            Contract.Requires(tok != null);
            var lit = new LiteralExpr(tok, b)
            {
                Type = Type.Bool
            };
            return lit;
        }

        /// <summary>
        /// Create a resolved expression for a string s
        /// </summary>
        public static LiteralExpr CreateStringLiteral(IToken tok, string s)
        {
            Contract.Requires(tok != null);
            Contract.Requires(s != null);
            var lit = new StringLiteralExpr(tok, s, MutateCSharp.Schemata51.ReplaceBooleanConstant_3(71L, true))
            {
                Type = new SeqType(new CharType())
            };
            return lit;
        }

        /// <summary>
        /// Returns "expr", but with all outer layers of parentheses removed.
        /// This method can be called before resolution.
        /// </summary>
        public static Expression StripParens(Expression expr)
        {
            while (MutateCSharp.Schemata51.ReplaceBooleanConstant_3(72L, true))
            {
                if (expr is not ParensExpression e)
                {
                    return expr;
                }
                expr = e.E;
            }

            return default;
        }

        /// <summary>
        /// Returns "expr", but with all outer layers of parentheses and casts removed.
        /// This method can be called before resolution.
        /// </summary>
        public static Expression StripParensAndCasts(Expression expr)
        {
            while (MutateCSharp.Schemata51.ReplaceBooleanConstant_3(73L, true))
            {
                if (expr is ParensExpression parens)
                {
                    expr = parens.E;
                }
                else if (expr is ConversionExpr cast)
                {
                    expr = cast.E;
                }
                else
                {
                    return expr;
                }
            }

            return default;
        }

        public static ThisExpr AsThis(Expression expr)
        {
            Contract.Requires(expr != null);
            return StripParens(expr) as ThisExpr;
        }

        /// <summary>
        /// If "expr" denotes a boolean literal "b", then return "true" and set "value" to "b".
        /// Otherwise, return "false" (and the value of "value" should not be used by the caller).
        /// This method can be called before resolution.
        /// </summary>
        public static bool IsBoolLiteral(Expression expr, out bool value)
        {
            Contract.Requires(expr != null);
            var e = StripParens(expr) as LiteralExpr;
            if (MutateCSharp.Schemata51.ReplaceBinExprOp_7(75L, () => MutateCSharp.Schemata51.ReplaceBinExprOp_14(74L, e, null), () => e.Value is bool))
            {
                value = (bool)e.Value;
                return MutateCSharp.Schemata51.ReplaceBooleanConstant_3(81L, true);
            }
            else
            {
                value = MutateCSharp.Schemata51.ReplaceBooleanConstant_3(82L, false);  // to please compiler
                return MutateCSharp.Schemata51.ReplaceBooleanConstant_3(83L, false);
            }

            return default;
        }

        /// <summary>
        /// If "expr" denotes an integer literal "x", then return "true" and set "value" to "x".
        /// Otherwise, return "false" (and the value of "value" should not be used by the caller).
        /// This method can be called before resolution.
        /// </summary>
        public static bool IsIntLiteral(Expression expr, out BigInteger value)
        {
            Contract.Requires(expr != null);
            var e = StripParensAndCasts(expr) as LiteralExpr;
            if (e is { Value: int x })
            {
                value = new BigInteger(x);
                return MutateCSharp.Schemata51.ReplaceBooleanConstant_3(84L, true);
            }
            else if (e is { Value: BigInteger xx })
            {
                value = xx;
                return MutateCSharp.Schemata51.ReplaceBooleanConstant_3(85L, true);
            }
            else
            {
                value = BigInteger.Zero; // to please compiler
                return MutateCSharp.Schemata51.ReplaceBooleanConstant_3(86L, false);
            }

            return default;
        }

        /// <summary>
        /// Returns "true" if "expr" denotes the empty set (for "iset", "set", or "multiset").
        /// This method can be called before resolution.
        /// </summary>
        public static bool IsEmptySetOrMultiset(Expression expr)
        {
            Contract.Requires(expr != null);
            expr = StripParens(expr);
            return MutateCSharp.Schemata51.ReplaceBinExprOp_2(117L, () => (MutateCSharp.Schemata51.ReplaceBinExprOp_7(96L, () => expr is SetDisplayExpr, () => MutateCSharp.Schemata51.ReplaceBinExprOp_11(91L, ((SetDisplayExpr)expr).Elements.Count, MutateCSharp.Schemata51.ReplaceNumericConstant_10(87L, 0)))), () => (MutateCSharp.Schemata51.ReplaceBinExprOp_7(111L, () => expr is MultiSetDisplayExpr, () => MutateCSharp.Schemata51.ReplaceBinExprOp_11(106L, ((MultiSetDisplayExpr)expr).Elements.Count, MutateCSharp.Schemata51.ReplaceNumericConstant_10(102L, 0)))));
        }

        /// <summary>
        /// Create a resolved ParensExpression around a given resolved expression "e".
        /// </summary>
        public static Expression CreateParensExpression(IToken tok, Expression e)
        {
            return new ParensExpression(tok, e) { Type = e.Type, ResolvedExpression = e };
        }

        public static Expression CreateNot(IToken tok, Expression e)
        {
            Contract.Requires(tok != null);
            Contract.Requires(e != null && e.Type != null && e.Type.IsBoolType);

            e = StripParens(e);
            if (e is UnaryOpExpr unary && MutateCSharp.Schemata51.ReplaceBinExprOp_8(123L, unary.Op, UnaryOpExpr.Opcode.Not))
            {
                return unary.E;
            }

            if (e is BinaryExpr bin)
            {
                var negatedOp = BinaryExpr.ResolvedOpcode.Add; // let "Add" stand for "no negated operator"
                switch (bin.ResolvedOp)
                {
                    case BinaryExpr.ResolvedOpcode.EqCommon:
                        negatedOp = BinaryExpr.ResolvedOpcode.NeqCommon;
                        break;
                        break;
                    case BinaryExpr.ResolvedOpcode.SetEq:
                        negatedOp = BinaryExpr.ResolvedOpcode.SetNeq;
                        break;
                        break;
                    case BinaryExpr.ResolvedOpcode.MultiSetEq:
                        negatedOp = BinaryExpr.ResolvedOpcode.MultiSetNeq;
                        break;
                        break;
                    case BinaryExpr.ResolvedOpcode.SeqEq:
                        negatedOp = BinaryExpr.ResolvedOpcode.SeqNeq;
                        break;
                        break;
                    case BinaryExpr.ResolvedOpcode.MapEq:
                        negatedOp = BinaryExpr.ResolvedOpcode.MapNeq;
                        break;
                        break;
                    case BinaryExpr.ResolvedOpcode.NeqCommon:
                        negatedOp = BinaryExpr.ResolvedOpcode.EqCommon;
                        break;
                        break;
                    case BinaryExpr.ResolvedOpcode.SetNeq:
                        negatedOp = BinaryExpr.ResolvedOpcode.SetEq;
                        break;
                        break;
                    case BinaryExpr.ResolvedOpcode.MultiSetNeq:
                        negatedOp = BinaryExpr.ResolvedOpcode.MultiSetEq;
                        break;
                        break;
                    case BinaryExpr.ResolvedOpcode.SeqNeq:
                        negatedOp = BinaryExpr.ResolvedOpcode.SeqEq;
                        break;
                        break;
                    case BinaryExpr.ResolvedOpcode.MapNeq:
                        negatedOp = BinaryExpr.ResolvedOpcode.MapEq;
                        break;
                        break;
                    default:
                        break;
                        break;
                }
                if (MutateCSharp.Schemata51.ReplaceBinExprOp_15(124L, negatedOp, BinaryExpr.ResolvedOpcode.Add))
                {
                    return new BinaryExpr(bin.tok, BinaryExpr.ResolvedOp2SyntacticOp(negatedOp), bin.E0, bin.E1)
                    {
                        ResolvedOp = negatedOp,
                        Type = bin.Type
                    };
                }
            }

            return new UnaryOpExpr(tok, UnaryOpExpr.Opcode.Not, e)
            {
                Type = Type.Bool
            };
        }

        /// <summary>
        /// Create a resolved expression of the form "e0 LESS e1"
        /// Works for integers, reals, bitvectors, chars, and ORDINALs.
        /// </summary>
        public static Expression CreateLess(Expression e0, Expression e1)
        {
            Contract.Requires(e0 != null && e0.Type != null);
            Contract.Requires(e1 != null && e1.Type != null);
            Contract.Requires(
              (e0.Type.IsNumericBased(Type.NumericPersuasion.Int) && e1.Type.IsNumericBased(Type.NumericPersuasion.Int)) ||
              (e0.Type.IsNumericBased(Type.NumericPersuasion.Real) && e1.Type.IsNumericBased(Type.NumericPersuasion.Real)) ||
              (e0.Type.IsBitVectorType && e1.Type.IsBitVectorType) ||
              (e0.Type.IsCharType && e1.Type.IsCharType) ||
              (e0.Type.IsBigOrdinalType && e1.Type.IsBigOrdinalType));
            Contract.Ensures(Contract.Result<Expression>() != null);
            return new BinaryExpr(e0.tok, BinaryExpr.Opcode.Lt, e0, e1)
            {
                ResolvedOp = e0.Type.IsCharType ? BinaryExpr.ResolvedOpcode.LtChar : BinaryExpr.ResolvedOpcode.Lt,
                Type = Type.Bool
            };
        }

        /// <summary>
        /// Create a resolved expression of the form "e0 ATMOST e1".
        /// Works for integers, reals, bitvectors, chars, and ORDINALs.
        /// </summary>
        public static Expression CreateAtMost(Expression e0, Expression e1)
        {
            Contract.Requires(e0 != null && e0.Type != null);
            Contract.Requires(e1 != null && e1.Type != null);
            Contract.Requires(
              (e0.Type.IsNumericBased(Type.NumericPersuasion.Int) && e1.Type.IsNumericBased(Type.NumericPersuasion.Int)) ||
              (e0.Type.IsNumericBased(Type.NumericPersuasion.Real) && e1.Type.IsNumericBased(Type.NumericPersuasion.Real)) ||
              (e0.Type.IsBitVectorType && e1.Type.IsBitVectorType) ||
              (e0.Type.IsCharType && e1.Type.IsCharType) ||
              (e0.Type.IsBigOrdinalType && e1.Type.IsBigOrdinalType));
            Contract.Ensures(Contract.Result<Expression>() != null);
            return new BinaryExpr(e0.tok, BinaryExpr.Opcode.Le, e0, e1)
            {
                ResolvedOp = e0.Type.IsCharType ? BinaryExpr.ResolvedOpcode.LeChar : BinaryExpr.ResolvedOpcode.Le,
                Type = Type.Bool
            };
        }

        public static Expression CreateEq(Expression e0, Expression e1, Type ty)
        {
            Contract.Requires(e0 != null);
            Contract.Requires(e1 != null);
            Contract.Requires(ty != null);
            var eq = new BinaryExpr(e0.tok, BinaryExpr.Opcode.Eq, e0, e1);
            if (ty is SetType)
            {
                eq.ResolvedOp = BinaryExpr.ResolvedOpcode.SetEq;
            }
            else if (ty is SeqType)
            {
                eq.ResolvedOp = BinaryExpr.ResolvedOpcode.SeqEq;
            }
            else if (ty is MultiSetType)
            {
                eq.ResolvedOp = BinaryExpr.ResolvedOpcode.MultiSetEq;
            }
            else if (ty is MapType)
            {
                eq.ResolvedOp = BinaryExpr.ResolvedOpcode.MapEq;
            }
            else
            {
                eq.ResolvedOp = BinaryExpr.ResolvedOpcode.EqCommon;
            }
            eq.type = Type.Bool;
            return eq;
        }

        /// <summary>
        /// Create a resolved expression of the form "e0 && e1"
        /// </summary>
        public static Expression CreateAnd(Expression a, Expression b, bool allowSimplification = true)
        {
            Contract.Requires(a != null);
            Contract.Requires(b != null);
            Contract.Requires(a.Type.IsBoolType && b.Type.IsBoolType);
            Contract.Ensures(Contract.Result<Expression>() != null);
            if (MutateCSharp.Schemata51.ReplaceBinExprOp_7(125L, () => allowSimplification, () => LiteralExpr.IsTrue(a)))
            {
                return b;
            }
            else if (MutateCSharp.Schemata51.ReplaceBinExprOp_7(131L, () => allowSimplification, () => LiteralExpr.IsTrue(b)))
            {
                return a;
            }
            else
            {
                var and = new BinaryExpr(a.tok, BinaryExpr.Opcode.And, a, b);
                and.ResolvedOp = BinaryExpr.ResolvedOpcode.And;  // resolve here
                and.Type = Type.Bool;  // resolve here
                return and;
            }

            return default;
        }

        /// <summary>
        /// Create a resolved expression of the form "e0 ==> e1"
        /// </summary>
        public static Expression CreateImplies(Expression a, Expression b, bool allowSimplification = true)
        {
            Contract.Requires(a != null);
            Contract.Requires(b != null);
            Contract.Requires(a.Type.IsBoolType && b.Type.IsBoolType);
            Contract.Ensures(Contract.Result<Expression>() != null);
            if (MutateCSharp.Schemata51.ReplaceBinExprOp_7(143L, () => allowSimplification, () => (MutateCSharp.Schemata51.ReplaceBinExprOp_2(137L, () => LiteralExpr.IsTrue(a), () => LiteralExpr.IsTrue(b)))))
            {
                return b;
            }
            else
            {
                var imp = new BinaryExpr(a.tok, BinaryExpr.Opcode.Imp, a, b);
                imp.ResolvedOp = BinaryExpr.ResolvedOpcode.Imp;  // resolve here
                imp.Type = Type.Bool;  // resolve here
                return imp;
            }

            return default;
        }

        /// <summary>
        /// Create a resolved expression of the form "e0 || e1"
        /// </summary>
        public static Expression CreateOr(Expression a, Expression b, bool allowSimplification = true)
        {
            Contract.Requires(a != null);
            Contract.Requires(b != null);
            Contract.Requires(a.Type.IsBoolType && b.Type.IsBoolType);
            Contract.Ensures(Contract.Result<Expression>() != null);
            if (MutateCSharp.Schemata51.ReplaceBinExprOp_7(149L, () => allowSimplification, () => LiteralExpr.IsTrue(a)))
            {
                return a;
            }
            else if (MutateCSharp.Schemata51.ReplaceBinExprOp_7(155L, () => allowSimplification, () => LiteralExpr.IsTrue(b)))
            {
                return b;
            }
            else
            {
                var or = new BinaryExpr(a.tok, BinaryExpr.Opcode.Or, a, b);
                or.ResolvedOp = BinaryExpr.ResolvedOpcode.Or;  // resolve here
                or.Type = Type.Bool;  // resolve here
                return or;
            }

            return default;
        }

        /// <summary>
        /// Create a resolved expression of the form "if test then e0 else e1"
        /// </summary>
        public static Expression CreateITE(Expression test, Expression e0, Expression e1)
        {
            Contract.Requires(test != null);
            Contract.Requires(e0 != null);
            Contract.Requires(e1 != null);
            Contract.Requires(test.Type.IsBoolType && e0.Type.Equals(e1.Type));
            Contract.Ensures(Contract.Result<Expression>() != null);
            var ite = new ITEExpr(test.tok, MutateCSharp.Schemata51.ReplaceBooleanConstant_3(161L, false), test, e0, e1);
            ite.Type = e0.type;  // resolve here
            return ite;
        }

        /// <summary>
        /// Create a resolved function-call expression. The returned expression will have syntactic scaffolding, which
        /// enables resolving a syntactic clone of this resolved expression.
        /// Expects "receiver" and each of the "arguments" to be a resolved expression.
        /// </summary>
        public static Expression CreateResolvedCall(IToken tok, Expression receiver, Function function, List<Expression> arguments,
          List<Type> typeArguments, SystemModuleManager systemModuleManager)
        {
            Contract.Requires(function.Ins.Count == arguments.Count);
            Contract.Requires(function.TypeArgs.Count == typeArguments.Count);

            var call = new FunctionCallExpr(tok, function.Name, receiver, tok, tok, arguments)
            {
                Function = function,
                Type = function.ResultType,
                TypeApplication_AtEnclosingClass = receiver.Type.TypeArgs,
                TypeApplication_JustFunction = typeArguments
            };

            return WrapResolvedCall(call, systemModuleManager);
        }

        /// <summary>
        /// Wrap the resolved call in the usual unresolved structure, in case the expression is cloned and re-resolved.
        /// </summary>
        public static Expression WrapResolvedCall(FunctionCallExpr call, SystemModuleManager systemModuleManager)
        {
            // Wrap the resolved call in the usual unresolved structure, in case the expression is cloned and re-resolved.
            var receiverType = (UserDefinedType)call.Receiver.Type.NormalizeExpand();
            var subst = TypeParameter.SubstitutionMap(receiverType.ResolvedClass.TypeArgs, receiverType.TypeArgs);
            subst = ModuleResolver.AddParentTypeParameterSubstitutions(subst, receiverType);
            var exprDotName = new ExprDotName(call.tok, call.Receiver, call.Function.Name, call.TypeApplication_JustFunction)
            {
                Type = ModuleResolver.SelectAppropriateArrowTypeForFunction(call.Function, subst, systemModuleManager)
            };

            subst = TypeParameter.SubstitutionMap(call.Function.TypeArgs, call.TypeApplication_JustFunction);
            return new ApplySuffix(call.tok, null, exprDotName, new ActualBindings(call.Args).ArgumentBindings, call.tok)
            {
                ResolvedExpression = call,
                Type = call.Function.ResultType.Subst(subst)
            };
        }

        /// <summary>
        /// Create a resolved field-selection expression.
        /// Expects "receiver" to be a resolved expression.
        /// </summary>
        public static Expression CreateFieldSelect(IToken tok, Expression receiver, Field field)
        {
            var memberSelectExpr = new MemberSelectExpr(tok, receiver, field);
            return WrapResolvedMemberSelect(memberSelectExpr);
        }

        /// <summary>
        /// Wrap the resolved MemberSelectExpr in the usual unresolved structure, in case the expression is cloned and re-resolved.
        /// </summary>
        public static Expression WrapResolvedMemberSelect(MemberSelectExpr memberSelectExpr)
        {
            List<Type> optTypeArguments = MutateCSharp.Schemata51.ReplaceBinExprOp_11(166L, memberSelectExpr.TypeApplication_JustMember.Count, MutateCSharp.Schemata51.ReplaceNumericConstant_10(162L, 0)) ? null : memberSelectExpr.TypeApplication_JustMember;
            return new ExprDotName(memberSelectExpr.tok, memberSelectExpr.Obj, memberSelectExpr.MemberName, optTypeArguments)
            {
                ResolvedExpression = memberSelectExpr,
                Type = memberSelectExpr.Type
            };
        }

        /// <summary>
        /// If "expr" is an expression that exists only as a resolved expression, then wrap it in the usual unresolved structure.
        /// </summary>
        public static Expression WrapAsParsedStructureIfNecessary(Expression expr, SystemModuleManager systemModuleManager)
        {
            if (expr is FunctionCallExpr functionCallExpr)
            {
                return WrapResolvedCall(functionCallExpr, systemModuleManager);
            }
            else if (expr is MemberSelectExpr memberSelectExpr)
            {
                return WrapResolvedMemberSelect(memberSelectExpr);
            }
            return expr;
        }

        /// <summary>
        /// Create a resolved case expression for a match expression
        /// </summary>
        public static MatchCaseExpr CreateMatchCase(MatchCaseExpr old_case, Expression new_body)
        {
            Contract.Requires(old_case != null);
            Contract.Requires(new_body != null);
            Contract.Ensures(Contract.Result<MatchCaseExpr>() != null);

            var cloner = new Cloner(MutateCSharp.Schemata51.ReplaceBooleanConstant_3(171L, false), MutateCSharp.Schemata51.ReplaceBooleanConstant_3(172L, true));
            var newVars = old_case.Arguments.ConvertAll(bv => cloner.CloneBoundVar(bv, MutateCSharp.Schemata51.ReplaceBooleanConstant_3(173L, false)));
            new_body = VarSubstituter(old_case.Arguments.ConvertAll<NonglobalVariable>(x => (NonglobalVariable)x), newVars, new_body);

            var new_case = new MatchCaseExpr(old_case.tok, old_case.Ctor, old_case.FromBoundVar, newVars, new_body, old_case.Attributes);

            new_case.Ctor = old_case.Ctor; // resolve here
            return new_case;
        }

        /// <summary>
        /// Create a match expression with a resolved type
        /// </summary>
        public static Expression CreateMatch(IToken tok, Expression src, List<MatchCaseExpr> cases, Type type)
        {
            MatchExpr e = new MatchExpr(tok, src, cases, MutateCSharp.Schemata51.ReplaceBooleanConstant_3(174L, false));
            e.Type = type;  // resolve here

            return e;
        }

        /// <summary>
        /// Create a let expression with a resolved type and fresh variables
        /// </summary>
        public static Expression CreateLet(IToken tok, List<CasePattern<BoundVar>> LHSs, List<Expression> RHSs, Expression body, bool exact)
        {
            Contract.Requires(tok != null);
            Contract.Requires(LHSs != null && RHSs != null);
            Contract.Requires(LHSs.Count == RHSs.Count);
            Contract.Requires(body != null);

            var cloner = new Cloner(MutateCSharp.Schemata51.ReplaceBooleanConstant_3(175L, false), MutateCSharp.Schemata51.ReplaceBooleanConstant_3(176L, true));
            var newLHSs = LHSs.ConvertAll(cloner.CloneCasePattern);

            var oldVars = new List<BoundVar>();
            LHSs.ForEach(p => oldVars.AddRange(p.Vars));
            var newVars = new List<BoundVar>();
            newLHSs.ForEach(p => newVars.AddRange(p.Vars));
            body = VarSubstituter(oldVars.ConvertAll<NonglobalVariable>(x => (NonglobalVariable)x), newVars, body);

            var let = new LetExpr(tok, newLHSs, RHSs, body, exact);
            let.Type = body.Type;  // resolve here
            return let;
        }

        /// <summary>
        /// Create a quantifier expression with a resolved type and fresh variables
        /// Optionally replace the old body with the supplied argument
        /// </summary>
        public static Expression CreateQuantifier(QuantifierExpr expr, bool forall, Expression body = null)
        {
            Contract.Requires(expr != null);

            var cloner = new Cloner(MutateCSharp.Schemata51.ReplaceBooleanConstant_3(177L, false), MutateCSharp.Schemata51.ReplaceBooleanConstant_3(178L, true));
            var newVars = expr.BoundVars.ConvertAll(bv => cloner.CloneBoundVar(bv, MutateCSharp.Schemata51.ReplaceBooleanConstant_3(179L, false)));

            if (MutateCSharp.Schemata51.ReplaceBinExprOp_5(180L, body, null))
            {
                body = expr.Term;
            }

            body = VarSubstituter(expr.BoundVars.ConvertAll<NonglobalVariable>(x => (NonglobalVariable)x), newVars, body);

            QuantifierExpr q;
            if (forall)
            {
                q = new ForallExpr(expr.tok, expr.RangeToken, newVars, expr.Range, body, expr.Attributes);
            }
            else
            {
                q = new ExistsExpr(expr.tok, expr.RangeToken, newVars, expr.Range, body, expr.Attributes);
            }
            q.Type = Type.Bool;

            return q;
        }

        /// <summary>
        /// Create a resolved IdentifierExpr (whose token is that of the variable)
        /// </summary>
        public static Expression CreateIdentExpr(IVariable v)
        {
            Contract.Requires(v != null);
            return new IdentifierExpr(v.Tok, v.Name)
            {
                Var = v,
                type = v.Type
            };
        }

        public static Expression VarSubstituter(List<NonglobalVariable> oldVars, List<BoundVar> newVars, Expression e, Dictionary<TypeParameter, Type> typeMap = null)
        {
            Contract.Requires(oldVars != null && newVars != null);
            Contract.Requires(oldVars.Count == newVars.Count);

            Dictionary<IVariable, Expression/*!*/> substMap = new Dictionary<IVariable, Expression>();
            if (MutateCSharp.Schemata51.ReplaceBinExprOp_16(181L, typeMap, null))
            {
                typeMap = new Dictionary<TypeParameter, Type>();
            }

            for (int i = MutateCSharp.Schemata51.ReplaceNumericConstant_10(182L, 0); MutateCSharp.Schemata51.ReplaceBinExprOp_17(186L, i, oldVars.Count); MutateCSharp.Schemata51.ReplacePostfixUnaryExprOp_18(191L, ref i))
            {
                var id = new IdentifierExpr(newVars[i].tok, newVars[i].Name);
                id.Var = newVars[i];    // Resolve here manually
                id.Type = newVars[i].Type;  // Resolve here manually
                substMap.Add(oldVars[i], id);
            }

            Substituter sub = new Substituter(null, substMap, typeMap);
            return sub.Substitute(e);
        }

        /// <summary>
        /// Returns the string literal underlying an actual string literal (not as a sequence display of characters)
        /// </summary>
        /// <returns></returns>
        public string AsStringLiteral()
        {
            var le = this as StringLiteralExpr;
            return MutateCSharp.Schemata51.ReplaceBinExprOp_19(192L, le, null) ? null : le.Value as string;
        }

        public override IEnumerable<INode> Children => SubExpressions;
        public override IEnumerable<INode> PreResolveChildren => Children;
    }
}