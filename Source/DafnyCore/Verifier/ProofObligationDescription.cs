using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;
using JetBrains.Annotations;
using Microsoft.Boogie;
namespace MutateCSharp
{
    internal class Schemata509
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT509");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplacePostfixUnaryExprOp_14(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
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

        internal static bool ReplaceBinExprOp_12(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 >= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 > argument2; }
            return argument1 >= argument2;
        }

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.LambdaExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_6(long mutantId, int argument1, int argument2)
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

        internal static int ReplaceNumericConstant_2(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.LambdaExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.Function.CoCallClusterInvolvement argument1, Microsoft.Dafny.Function.CoCallClusterInvolvement argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_13(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
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

    }
}

namespace Microsoft.Dafny.ProofObligationDescription
{
    public abstract class ProofObligationDescription : Boogie.ProofObligationDescription
    {
        public virtual bool IsImplicit => MutateCSharp.Schemata509.ReplaceBooleanConstant_0(1L, true);
        // An expression that, if verified, would trigger a success for this ProofObligationDescription
        // It is only printed for the user, so it does not need to be resolved.
        public virtual Expression GetAssertedExpr(DafnyOptions options)
        {
            return null;
        }

        // Substituting replaces the token of a substituting expression by the token of the identifierExpr being susbstituted,
        // Since the printer requires the token of IdentifierExpr to be Token.NoToken to print the custom name in Dafny mode,
        // we just wrap the identifierExpr into a ParensExpression, as it is the case for any other expression.
        protected static Expression ToSubstitutableExpression(BoundVar bvar)
        {
            var expression = new IdentifierExpr(bvar.tok, bvar);
            return new ParensExpression(bvar.tok, expression) { Type = bvar.Type, ResolvedExpression = expression };
        }

        public virtual bool ProvedOutsideUserCode => MutateCSharp.Schemata509.ReplaceBooleanConstant_0(2L, false);
    }

    //// Arithmetic and logical operators, conversions

    public class DivisorNonZero : ProofObligationDescription
    {
        public override string SuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(3L, "divisor is always non-zero.");

        public override string FailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(4L, "possible division by zero");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(5L, "non-zero divisor");

        private readonly Expression divisor;

        public DivisorNonZero(Expression divisor)
        {
            this.divisor = divisor;
        }

        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            return new BinaryExpr(divisor.tok, BinaryExpr.Opcode.Neq, divisor, new LiteralExpr(divisor.tok, MutateCSharp.Schemata509.ReplaceNumericConstant_2(6L, 0)));
        }
    }

    public abstract class ShiftOrRotateBound : ProofObligationDescription
    {
        protected readonly string shiftOrRotate;
        protected readonly Expression amount;

        public ShiftOrRotateBound(bool shift, Expression amount)
        {
            shiftOrRotate = shift ? MutateCSharp.Schemata509.ReplaceStringConstant_1(10L, "shift") : MutateCSharp.Schemata509.ReplaceStringConstant_1(11L, "rotate");
            this.amount = amount;
        }
    }

    public class ShiftLowerBound : ShiftOrRotateBound
    {
        public override string SuccessDescription =>
          $"{shiftOrRotate} amount is always non-negative";

        public override string FailureDescription =>
          $"{shiftOrRotate} amount must be non-negative";

        public override string ShortDescription => $"{shiftOrRotate} lower bound";

        public ShiftLowerBound(bool shift, Expression amount)
          : base(shift, amount)
        {
        }

        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            return new BinaryExpr(amount.tok, BinaryExpr.Opcode.Le, Expression.CreateIntLiteral(amount.tok, MutateCSharp.Schemata509.ReplaceNumericConstant_2(12L, 0)), amount);
        }
    }

    public class ShiftUpperBound : ShiftOrRotateBound
    {
        public override string SuccessDescription =>
          $"{shiftOrRotate} amount is always within the width of the result ({width})";

        public override string FailureDescription =>
          $"{shiftOrRotate} amount must not exceed the width of the result ({width})";

        public override string ShortDescription => $"{shiftOrRotate} upper bound";

        private readonly int width;

        public ShiftUpperBound(int width, bool shift, Expression amount)
          : base(shift, amount)
        {
            this.width = width;
        }

        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            return new BinaryExpr(amount.tok, BinaryExpr.Opcode.Le, amount, Expression.CreateIntLiteral(amount.tok, width));
        }
    }

    public class ConversionIsNatural : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"{prefix}value to be converted is always a natural number";

        public override string FailureDescription =>
          $"{prefix}value to be converted might be bigger than every natural number";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(16L, "converted value is natural");

        private readonly string prefix;
        private readonly Expression value;

        public ConversionIsNatural(string prefix, Expression value)
        {
            this.prefix = prefix;
            this.value = value;
        }

        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            return new TypeTestExpr(value.tok, value, Type.Nat());
        }
    }

    public class ConversionSatisfiesConstraints : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"{prefix}result of operation never violates {kind} constraints for '{name}'";

        public override string FailureDescription =>
          $"{prefix}result of operation might violate {kind} constraint for '{name}'";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(17L, "conversion satisfies type constraints");

        private readonly string prefix;
        private readonly string kind;
        private readonly string name;
        private readonly Expression constraint;

        public ConversionSatisfiesConstraints(string prefix, string kind, string name, Expression constraint)
        {
            this.prefix = prefix;
            this.kind = kind;
            this.name = name;
            this.constraint = constraint;
        }

        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            return constraint;
        }
    }

    public class OrdinalSubtractionIsNatural : ProofObligationDescription
    {
        public override string SuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(18L, "RHS of ORDINAL subtraction is always a natural number");

        public override string FailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(19L, "RHS of ORDINAL subtraction must be a natural number, but the given RHS might be larger");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(20L, "ordinal subtraction is natural");

        private readonly Expression rhs;

        public OrdinalSubtractionIsNatural(Expression rhs)
        {
            this.rhs = rhs;
        }

        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            return new ExprDotName(rhs.tok, rhs, MutateCSharp.Schemata509.ReplaceStringConstant_1(21L, "IsNat"), null);
        }
    }

    public class OrdinalSubtractionUnderflow : ProofObligationDescription
    {
        public override string SuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(22L, "ORDINAL subtraction will never go below limit ordinal");

        public override string FailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(23L, "ORDINAL subtraction might underflow a limit ordinal (that is, RHS might be too large)");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(24L, "ordinal subtraction underflow");

        private readonly Expression lhs;
        private readonly Expression rhs;

        public OrdinalSubtractionUnderflow(Expression lhs, Expression rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }

        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            return new BinaryExpr(
              rhs.tok,
              BinaryExpr.Opcode.Le,
              new ExprDotName(rhs.tok, rhs, MutateCSharp.Schemata509.ReplaceStringConstant_1(25L, "Offset"), null),
              new ExprDotName(lhs.tok, lhs, MutateCSharp.Schemata509.ReplaceStringConstant_1(26L, "Offset"), null)
            );
        }
    }

    public class CharOverflow : ProofObligationDescription
    {
        public override string SuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(27L, "char addition will not overflow");

        public override string FailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(28L, "char addition might overflow");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(29L, "char overflow");

        private readonly Expression e0;
        private readonly Expression e1;

        public CharOverflow(Expression e0, Expression e1)
        {
            this.e0 = e0;
            this.e1 = e1;
        }

        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            var sum = new BinaryExpr(
              e0.tok,
              BinaryExpr.Opcode.Add,
              new ConversionExpr(e0.tok, e0, Type.Int),
              new ConversionExpr(e1.tok, e1, Type.Int)
            );
            return Utils.MakeCharBoundsCheck(options, sum);
        }
    }

    public class CharUnderflow : ProofObligationDescription
    {
        public override string SuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(30L, "char subtraction will not underflow");

        public override string FailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(31L, "char subtraction might underflow");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(32L, "char underflow");

        private readonly Expression e0;
        private readonly Expression e1;

        public CharUnderflow(Expression e0, Expression e1)
        {
            this.e0 = e0;
            this.e1 = e1;
        }

        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            var diff = new BinaryExpr(
              e0.tok,
              BinaryExpr.Opcode.Sub,
              new ConversionExpr(e0.tok, e0, Type.Int),
              new ConversionExpr(e1.tok, e1, Type.Int)
            );
            return Utils.MakeCharBoundsCheck(options, diff);
        }
    }

    public class ConversionFit : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"{prefix}{what} to be converted will always fit in {toType}";

        public override string FailureDescription =>
          $"{prefix}{what} to be converted might not fit in {toType}";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(33L, "conversion fit");

        private readonly string prefix;
        private readonly string what;
        private readonly Type toType;
        private readonly Expression boundsCheck;

        public ConversionFit(string what, Type toType, Expression boundsCheck, string prefix = "")
        {
            this.prefix = prefix;
            this.what = what;
            this.boundsCheck = boundsCheck;
            this.toType = toType;
        }

        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            return boundsCheck;
        }
    }

    public class NonNegative : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"{what} is never negative";

        public override string FailureDescription =>
          $"{what} might be negative";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(34L, "non-negative");

        private readonly string what;
        private readonly Expression expr;

        public NonNegative(string what, Expression expr)
        {
            this.what = what;
            this.expr = expr;
        }

        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            return new BinaryExpr(
              expr.tok,
              BinaryExpr.Opcode.Le,
              Expression.CreateIntLiteral(expr.tok, MutateCSharp.Schemata509.ReplaceNumericConstant_2(35L, 0)),
              expr
            );
        }
    }

    public class ConversionPositive : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"{prefix}{what} is always positive";

        public override string FailureDescription =>
          $"{prefix}a negative {what} cannot be converted to an {toType}";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(39L, "conversion positive");

        private readonly string prefix;
        private readonly string what;
        private readonly Type toType;
        private readonly Expression expr;

        public ConversionPositive(string what, Type toType, Expression expr, string prefix = "")
        {
            this.prefix = prefix;
            this.what = what;
            this.toType = toType;
            this.expr = expr;
        }

        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            return new BinaryExpr(
              expr.tok,
              BinaryExpr.Opcode.Le,
              Expression.CreateIntLiteral(expr.tok, MutateCSharp.Schemata509.ReplaceNumericConstant_2(40L, 0)),
              expr
            );
        }
    }

    public class IsInteger : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"{prefix}the real-based number is an integer";

        public override string FailureDescription =>
          $"{prefix}the real-based number must be an integer (if you want truncation, apply .Floor to the real-based number)";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(44L, "is integer");

        private readonly string prefix;
        private readonly Expression expr;

        public IsInteger(Expression expr, string prefix = "")
        {
            this.expr = expr;
            this.prefix = prefix;
        }

        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            return new BinaryExpr(
              expr.tok,
              BinaryExpr.Opcode.Eq,
              expr,
              new ConversionExpr(expr.tok, new ExprDotName(expr.tok, expr, MutateCSharp.Schemata509.ReplaceStringConstant_1(45L, "Floor"), null), Type.Real)
            );
        }
    }

    //// Object properties

    public class NonNull : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"{PluralSuccess}{what} is never null";

        public override string FailureDescription =>
          $"{PluralFailure}{what} might be null";

        public override string ShortDescription => $"{what} non-null";
        private readonly string what;
        private readonly Expression expr;
        private bool plural;
        private string PluralSuccess => plural ? MutateCSharp.Schemata509.ReplaceStringConstant_1(46L, "each ") : "";
        private string PluralFailure => plural ? MutateCSharp.Schemata509.ReplaceStringConstant_1(47L, "some ") : "";

        public NonNull(string what, Expression expr, bool plural = false)
        {
            this.what = what;
            this.expr = expr;
            this.plural = plural;
        }

        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            return new BinaryExpr(expr.tok, BinaryExpr.Opcode.Neq, expr, new LiteralExpr(expr.tok));
        }
    }

    public class IsAllocated : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"{PluralSuccess}{what} is always allocated{WhenSuffix}";

        public override string FailureDescription =>
          $"{PluralFailure}{what} could not be proved to be allocated{WhenSuffix}";

        public override string ShortDescription => $"{what} allocated";

        private readonly string what;
        [CanBeNull] private readonly string when;
        private readonly Expression expr;
        [CanBeNull] private readonly Label atLabel;
        private bool plural;
        private string WhenSuffix => when is null ? "" : $" {when}";
        private string PluralSuccess => plural ? MutateCSharp.Schemata509.ReplaceStringConstant_1(48L, "each ") : "";
        private string PluralFailure => plural ? MutateCSharp.Schemata509.ReplaceStringConstant_1(49L, "some ") : "";

        public static string HelperFormal(Formal formal)
        {
            return $" -- if you add 'new' before the parameter declaration, like 'new {formal.Name}: {formal.Type.ToString()}',"
                   + MutateCSharp.Schemata509.ReplaceStringConstant_1(50L, " arguments can refer to expressions possibly unallocated in the previous state");
        }

        public IsAllocated(string what, string when, Expression expr, [CanBeNull] Label atLabel = null, bool plural = false)
        {
            this.what = what;
            this.when = when;
            this.expr = expr;
            this.atLabel = atLabel;
            this.plural = plural;
        }

        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            return new OldExpr(expr.tok, new UnaryOpExpr(expr.tok, UnaryOpExpr.Opcode.Allocated, expr), atLabel?.Name);
        }
    }

    public class IsOlderProofObligation : ProofObligationDescription
    {
        public override string SuccessDescription
        {
            get
            {
                var successOlder = MutateCSharp.Schemata509.ReplaceBinExprOp_3(55L, olderParameterCount, MutateCSharp.Schemata509.ReplaceNumericConstant_2(51L, 1)) ? MutateCSharp.Schemata509.ReplaceStringConstant_1(60L, " is") : MutateCSharp.Schemata509.ReplaceStringConstant_1(61L, "s are");
                var successOther = MutateCSharp.Schemata509.ReplaceBinExprOp_3(66L, otherParameterCount, MutateCSharp.Schemata509.ReplaceNumericConstant_2(62L, 1)) ? MutateCSharp.Schemata509.ReplaceStringConstant_1(71L, "the") : MutateCSharp.Schemata509.ReplaceStringConstant_1(72L, "any");
                return $"the 'older' parameter{successOlder} not newer than {successOther} other parameter when the predicate returns 'true'";
            }
        }

        public override string FailureDescription
        {
            get
            {
                var failureOlder = MutateCSharp.Schemata509.ReplaceBinExprOp_3(77L, olderParameterCount, MutateCSharp.Schemata509.ReplaceNumericConstant_2(73L, 1)) ? MutateCSharp.Schemata509.ReplaceStringConstant_1(82L, "the") : MutateCSharp.Schemata509.ReplaceStringConstant_1(83L, "an");
                var failureOther = MutateCSharp.Schemata509.ReplaceBinExprOp_4(102L, () => MutateCSharp.Schemata509.ReplaceBinExprOp_3(88L, olderParameterCount, MutateCSharp.Schemata509.ReplaceNumericConstant_2(84L, 1)), () => MutateCSharp.Schemata509.ReplaceBinExprOp_3(97L, otherParameterCount, MutateCSharp.Schemata509.ReplaceNumericConstant_2(93L, 1))) ? MutateCSharp.Schemata509.ReplaceStringConstant_1(108L, "the other parameter") : MutateCSharp.Schemata509.ReplaceBinExprOp_3(113L, otherParameterCount, MutateCSharp.Schemata509.ReplaceNumericConstant_2(109L, 1)) ? MutateCSharp.Schemata509.ReplaceStringConstant_1(118L, "the non-'older' parameter") : MutateCSharp.Schemata509.ReplaceStringConstant_1(119L, "all non-'older' parameters");
                return $"{failureOlder} 'older' parameter might be newer than {failureOther} when the predicate returns 'true'";
            }
        }

        public override string ShortDescription => $"older parameter{(MutateCSharp.Schemata509.ReplaceBinExprOp_5(124L, MutateCSharp.Schemata509.ReplaceNumericConstant_2(120L, 2), olderParameterCount) ? MutateCSharp.Schemata509.ReplaceStringConstant_1(129L, "s") : "")}";

        private readonly int olderParameterCount;
        private readonly int otherParameterCount;

        public IsOlderProofObligation(int olderParameterCount, int allParameterCount)
        {
            Contract.Requires(1 <= olderParameterCount);
            Contract.Requires(olderParameterCount <= allParameterCount);
            this.olderParameterCount = olderParameterCount;
            this.otherParameterCount = MutateCSharp.Schemata509.ReplaceBinExprOp_6(130L, allParameterCount, olderParameterCount);
        }
    }

    //// Contract constraints

    public abstract class ProofObligationDescriptionCustomMessages : ProofObligationDescription
    {
        protected readonly string customErrMsg;
        private readonly string customSuccessMsg;

        public override string SuccessDescription =>
          customSuccessMsg ?? DefaultSuccessDescription;

        public abstract string DefaultSuccessDescription { get; }

        public override string FailureDescription =>
          customErrMsg ?? DefaultFailureDescription;
        public abstract string DefaultFailureDescription { get; }

        public ProofObligationDescriptionCustomMessages([CanBeNull] string customErrMsg, [CanBeNull] string customSuccessMsg)
        {
            this.customErrMsg = customErrMsg;
            this.customSuccessMsg = customSuccessMsg;
        }
    }

    public class PreconditionSatisfied : ProofObligationDescriptionCustomMessages
    {
        public override string DefaultSuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(139L, "function precondition satisfied");

        public override string DefaultFailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(140L, "function precondition could not be proved");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(141L, "precondition");

        public PreconditionSatisfied([CanBeNull] string customErrMsg, [CanBeNull] string customSuccessMsg)
          : base(customErrMsg, customSuccessMsg)
        {
        }
    }

    public class AssertStatementDescription : ProofObligationDescriptionCustomMessages
    {
        public override string DefaultSuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(142L, "assertion always holds");

        public override string DefaultFailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(143L, "assertion might not hold");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(144L, "assert statement");

        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            return AssertStatement.Expr;
        }

        public AssertStmt AssertStatement { get; }

        // We provide a way to mark an assertion as an intentional element of a
        // proof by contradiction with the `{:contradiction}` attribute. Dafny
        // skips warning about such assertions being proved due to contradictory
        // assumptions.
        public bool IsIntentionalContradiction => Attributes.Contains(AssertStatement.Attributes, MutateCSharp.Schemata509.ReplaceStringConstant_1(145L, "contradiction"));

        public AssertStatementDescription(AssertStmt assertStmt, [CanBeNull] string customErrMsg, [CanBeNull] string customSuccessMsg)
          : base(customErrMsg, customSuccessMsg)
        {
            this.AssertStatement = assertStmt;
        }

        public override bool IsImplicit => MutateCSharp.Schemata509.ReplaceBooleanConstant_0(146L, false);
    }

    // The Boogie version does not support custom error messages yet
    public class RequiresDescription : ProofObligationDescriptionCustomMessages
    {
        public override string DefaultSuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(147L, "the precondition always holds");

        public override string DefaultFailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(148L, "this is the precondition that could not be proved");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(149L, "requires");

        public RequiresDescription([CanBeNull] string customErrMsg, [CanBeNull] string customSuccessMsg)
          : base(customErrMsg, customSuccessMsg)
        {
        }
    }

    // The Boogie version does not support custom error messages yet
    public class EnsuresDescription : ProofObligationDescriptionCustomMessages
    {
        public override string DefaultSuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(150L, "this postcondition holds");

        public override string DefaultFailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(151L, "this is the postcondition that could not be proved");

        // Same as FailureDescription but used not as a "related" error, but as an error by itself
        public string FailureDescriptionSingle =>
          customErrMsg ?? MutateCSharp.Schemata509.ReplaceStringConstant_1(152L, "this postcondition could not be proved on a return path");

        public string FailureAtPathDescription =>
          customErrMsg ?? new PostconditionDescription().FailureDescription;

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(153L, "ensures");

        public EnsuresDescription([CanBeNull] string customErrMsg, [CanBeNull] string customSuccessMsg)
          : base(customErrMsg, customSuccessMsg)
        {
        }

        public override bool IsImplicit => MutateCSharp.Schemata509.ReplaceBooleanConstant_0(154L, false);
    }

    public class LoopInvariant : ProofObligationDescriptionCustomMessages
    {
        public override string DefaultSuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(155L, "loop invariant always holds");

        public override string DefaultFailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(156L, "loop invariant violation");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(157L, "loop invariant");

        public LoopInvariant([CanBeNull] string customErrMsg, [CanBeNull] string customSuccessMsg)
          : base(customErrMsg, customSuccessMsg)
        {
        }
    }

    public class CalculationStep : ProofObligationDescription
    {
        public override string SuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(158L, "the calculation step between the previous line and this line always holds");

        public override string FailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(159L, "the calculation step between the previous line and this line could not be proved");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(160L, "calc step");
    }

    public class EnsuresStronger : ProofObligationDescription
    {
        public override string SuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(161L, "the method provides a postcondition equal to or more detailed than in its parent trait");

        public override string FailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(162L, "the method must provide an equal or more detailed postcondition than in its parent trait");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(163L, "ensures stronger");

        public override bool ProvedOutsideUserCode => MutateCSharp.Schemata509.ReplaceBooleanConstant_0(164L, true);
    }

    public class RequiresWeaker : ProofObligationDescription
    {
        public override string SuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(165L, "the method provides a precondition equal to or more permissive than in its parent trait");

        public override string FailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(166L, "the method must provide an equal or more permissive precondition than in its parent trait");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(167L, "requires weaker");

        public override bool ProvedOutsideUserCode => MutateCSharp.Schemata509.ReplaceBooleanConstant_0(168L, true);
    }

    public class ForallPostcondition : ProofObligationDescription
    {
        public override string SuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(169L, "postcondition of forall statement always holds");

        public override string FailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(170L, "possible violation of postcondition of forall statement");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(171L, "forall ensures");

        private readonly Expression expr;

        public ForallPostcondition(Expression expr)
        {
            this.expr = expr;
        }

        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            return expr;
        }
    }

    public class YieldEnsures : ProofObligationDescription
    {
        public override string SuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(172L, "yield-ensures condition always holds");

        public override string FailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(173L, "possible violation of yield-ensures condition");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(174L, "yield ensures");
    }

    public class TraitFrame : ProofObligationDescription
    {
        public override string SuccessDescription =>
          isModify
            ? $"{whatKind} abides by trait context's modifies clause"
            : $"{whatKind} abides by trait context's reads clause";

        public override string FailureDescription =>
          isModify
            ? $"{whatKind} might modify an object not in the parent trait context's modifies clause"
            : $"{whatKind} might read an object not in the parent trait context's reads clause";

        public override string ShortDescription =>
          isModify ? MutateCSharp.Schemata509.ReplaceStringConstant_1(175L, "trait modifies") : MutateCSharp.Schemata509.ReplaceStringConstant_1(176L, "trait reads");

        private readonly string whatKind;
        private bool isModify;

        public TraitFrame(string whatKind, bool isModify)
        {
            this.whatKind = whatKind;
            this.isModify = isModify;
        }
    }

    public class TraitDecreases : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"{whatKind}'s decreases clause is below or equal to that in the trait";

        public override string FailureDescription =>
          $"{whatKind}'s (possibly automatically generated) decreases clause must be below or equal to that in the trait";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(177L, "trait decreases");

        public override bool ProvedOutsideUserCode => MutateCSharp.Schemata509.ReplaceBooleanConstant_0(178L, true);

        private readonly string whatKind;

        public TraitDecreases(string whatKind)
        {
            this.whatKind = whatKind;
        }
    }

    public class ReadFrameSubset : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"sufficient reads clause to {whatKind}";

        public override string FailureDescription =>
          $"insufficient reads clause to {whatKind}" + ExtendedFailureHint();

        public string ExtendedFailureHint()
        {
            if (readExpression is null)
            {
                return "";
            }
            if (scope is { Designator: var designator })
            {
                var lambdaScope = scope as LambdaExpr;
                var extraHint = "";
                var obj = MutateCSharp.Schemata509.ReplaceStringConstant_1(179L, "object");
                if (readExpression is MemberSelectExpr e)
                {
                    obj = Printer.ExprToString(DafnyOptions.DefaultImmutableOptions, e.Obj, new PrintFlags(UseOriginalDafnyNames: MutateCSharp.Schemata509.ReplaceBooleanConstant_0(180L, true)));
                }
                else if (readExpression is SeqSelectExpr s)
                {
                    obj = Printer.ExprToString(DafnyOptions.DefaultImmutableOptions, s.Seq, new PrintFlags(UseOriginalDafnyNames: MutateCSharp.Schemata509.ReplaceBooleanConstant_0(181L, true)));
                }
                else if (readExpression is MultiSelectExpr m)
                {
                    obj = Printer.ExprToString(DafnyOptions.DefaultImmutableOptions, m.Array,
                      new PrintFlags(UseOriginalDafnyNames: MutateCSharp.Schemata509.ReplaceBooleanConstant_0(182L, true)));
                }

                if (scope is Function { CoClusterTarget: var x } && MutateCSharp.Schemata509.ReplaceBinExprOp_7(183L, x, Function.CoCallClusterInvolvement.None))
                {
                }
                else
                {
                    if (MutateCSharp.Schemata509.ReplaceBinExprOp_8(184L, lambdaScope, null) && readExpression is MemberSelectExpr { MemberName: var field })
                    {
                        extraHint = $" or 'reads {obj}`{field}'";
                    }
                    var hint = $"adding 'reads {obj}'{extraHint} in the enclosing {designator} specification for resolution";
                    if (MutateCSharp.Schemata509.ReplaceBinExprOp_4(195L, () => MutateCSharp.Schemata509.ReplaceBinExprOp_9(185L, lambdaScope, null), () => MutateCSharp.Schemata509.ReplaceBinExprOp_3(190L, lambdaScope.Reads.Expressions.Count, MutateCSharp.Schemata509.ReplaceNumericConstant_2(186L, 0))))
                    {
                        hint = $"extracting {readExpression} to a local variable before the lambda expression, or {hint}";
                    }

                    return $"; Consider {hint}";
                }
            }

            string whyNotWhat = MutateCSharp.Schemata509.ReplaceStringConstant_1(201L, "Memory locations");

            if (MutateCSharp.Schemata509.ReplaceBinExprOp_10(203L, whatKind, MutateCSharp.Schemata509.ReplaceStringConstant_1(202L, "read field")))
            {
                whyNotWhat = MutateCSharp.Schemata509.ReplaceStringConstant_1(204L, "Mutable fields");
            }
            else if (whatKind is "read array element" or "read the indicated range of array elements")
            {
                whyNotWhat = MutateCSharp.Schemata509.ReplaceStringConstant_1(205L, "Array elements");
            }
            return $"; {whyNotWhat} cannot be accessed within certain scopes, such as default values, the right-hand side of constants, or co-recursive calls";

        }

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(206L, "read frame subset");

        private readonly string whatKind;
        private readonly Expression readExpression;
        [CanBeNull] private readonly IFrameScope scope;

        public ReadFrameSubset(string whatKind, Expression readExpression = null, [CanBeNull] IFrameScope scope = null)
        {
            this.whatKind = whatKind;
            this.readExpression = readExpression;
            this.scope = scope;
        }
    }

    public class ModifyFrameSubset : ProofObligationDescription
    {
        public override string SuccessDescription =>
            $"{whatKind} is allowed by context's modifies clause";

        public override string FailureDescription =>
            $"{whatKind} might violate context's modifies clause";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(207L, "modify frame subset");

        private readonly string whatKind;

        public ModifyFrameSubset(string whatKind)
        {
            this.whatKind = whatKind;
        }
    }

    public class FrameDereferenceNonNull : ProofObligationDescription
    {
        public override string SuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(208L, "frame expression does not dereference null");

        public override string FailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(209L, "frame expression might dereference null");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(210L, "frame dereference");
    }

    public class Terminates : ProofObligationDescription
    {
        public override string SuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(211L, "loop or recursion terminates");

        public override string FailureDescription =>
          (inferredDescreases
            ? (MutateCSharp.Schemata509.ReplaceStringConstant_1(212L, "cannot prove termination; try supplying a decreases clause") + (isLoop ? MutateCSharp.Schemata509.ReplaceStringConstant_1(213L, " for the loop") : ""))
            : $"decreases {FormDescription} might not decrease") +
          (hint is null ? "" : $" ({hint})");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(214L, "termination");

        private readonly bool inferredDescreases;
        private bool isLoop => prevGhostLocals is not null;
        private readonly string hint;
        private string FormDescription => isLoop ? MutateCSharp.Schemata509.ReplaceStringConstant_1(215L, "expression") : MutateCSharp.Schemata509.ReplaceStringConstant_1(216L, "clause");

        private readonly Expression allowance;
        private readonly List<Expression> oldExpressions;
        private readonly List<Expression> newExpressions;
        private readonly List<VarDeclStmt> prevGhostLocals;

        public Terminates(bool inferredDescreases, List<VarDeclStmt> prevGhostLocals, Expression allowance, List<Expression> oldExpressions, List<Expression> newExpressions, string hint = null)
        {
            this.inferredDescreases = inferredDescreases;
            this.prevGhostLocals = prevGhostLocals;
            this.allowance = allowance;
            this.oldExpressions = oldExpressions;
            this.newExpressions = newExpressions;
            this.hint = hint;
        }
    }

    public class DecreasesBoundedBelow : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"decreases {component} is bounded below by {zeroStr}";

        public override string FailureDescription =>
          $"decreases {component} must be bounded below by {zeroStr}{suffix}";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(217L, "bounded decreases expression");

        public override bool ProvedOutsideUserCode => MutateCSharp.Schemata509.ReplaceBooleanConstant_0(218L, true);

        private string component => MutateCSharp.Schemata509.ReplaceBinExprOp_3(223L, N, MutateCSharp.Schemata509.ReplaceNumericConstant_2(219L, 1)) ? MutateCSharp.Schemata509.ReplaceStringConstant_1(228L, "expression") : $"expression at index {k}";
        private readonly string zeroStr;
        private readonly string suffix;
        private readonly int N, k;

        public DecreasesBoundedBelow(int N, int k, string zeroStr, string suffix)
        {
            this.N = N;
            this.k = k;
            this.zeroStr = zeroStr;
            this.suffix = suffix;
        }
    }

    public class Modifiable : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"{description} is in the enclosing context's modifies clause";

        public override string FailureDescription =>
          $"assignment might update {description} not in the enclosing context's modifies clause";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(229L, "modifiable");

        private readonly string description;

        public Modifiable(string description)
        {
            this.description = description;
        }
    }

    public class FunctionContractOverride : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"the function provides an equal or {RestrictionDesc} than in its parent trait";

        public override string FailureDescription =>
          $"the function must provide an equal or {RestrictionDesc} than in its parent trait";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(230L, "contract override valid");

        public override bool ProvedOutsideUserCode => MutateCSharp.Schemata509.ReplaceBooleanConstant_0(231L, true);

        private readonly bool isEnsures;
        private string RestrictionDesc =>
          isEnsures ? MutateCSharp.Schemata509.ReplaceStringConstant_1(232L, "more detailed postcondition") : MutateCSharp.Schemata509.ReplaceStringConstant_1(233L, "more permissive precondition");

        public FunctionContractOverride(bool isEnsures)
        {
            this.isEnsures = isEnsures;
        }
    }

    //// Structural constraints

    public class MatchIsComplete : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"match {matchForm} covers all cases";

        public override string FailureDescription =>
          $"missing case in match {matchForm}: {missing}";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(234L, "match complete");

        public override bool ProvedOutsideUserCode => MutateCSharp.Schemata509.ReplaceBooleanConstant_0(235L, true);

        private readonly string matchForm;
        private readonly string missing;
        public MatchIsComplete(string matchForm, string missing)
        {
            this.matchForm = matchForm;
            this.missing = missing;
        }
    }

    public class AlternativeIsComplete : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"alternative cases cover all possibilities";

        public override string FailureDescription =>
          $"alternative cases fail to cover all possibilities";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(236L, "alternative complete");

        public override bool ProvedOutsideUserCode => MutateCSharp.Schemata509.ReplaceBooleanConstant_0(237L, true);
    }

    public class PatternShapeIsValid : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"RHS will always match the pattern '{ctorName}'";

        public override string FailureDescription =>
          $"RHS is not certain to look like the pattern '{ctorName}'";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(238L, "pattern shape valid");

        private readonly string ctorName;

        public PatternShapeIsValid(string ctorName)
        {
            this.ctorName = ctorName;
        }
    }

    public class ValidConstructorNames : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"source of datatype update is constructed by {ctorNames}";

        public override string FailureDescription =>
          $"source of datatype update must be constructed by {ctorNames}";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(239L, "valid constructor names");

        private readonly string ctorNames;

        public ValidConstructorNames(string ctorNames)
        {
            this.ctorNames = ctorNames;
        }
    }

    public class DestructorValid : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"destructor '{dtorName}' is only applied to datatype values constructed by {ctorNames}";

        public override string FailureDescription =>
          $"destructor '{dtorName}' can only be applied to datatype values constructed by {ctorNames}";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(240L, "destructor valid");

        private readonly string dtorName;
        private readonly string ctorNames;

        public DestructorValid(string dtorName, string ctorNames)
        {
            this.dtorName = dtorName;
            this.ctorNames = ctorNames;
        }
    }

    public class NotGhostVariant : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"in a compiled context, {subject} is not applied to a datatype value of a ghost variant (ghost constructor {ctorNames})";

        public override string FailureDescription =>
          $"in a compiled context, {subject} cannot be applied to a datatype value of a ghost variant (ghost constructor {ctorNames})";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(241L, "not ghost variant");

        private readonly string subject;
        private readonly string ctorNames;

        public NotGhostVariant(string subject, List<DatatypeCtor> ctors)
        {
            this.subject = subject;
            this.ctorNames = DatatypeDestructor.PrintableCtorNameList(ctors, MutateCSharp.Schemata509.ReplaceStringConstant_1(242L, "or"));
        }

        public NotGhostVariant(string whatKind, string dtorNames, List<DatatypeCtor> ctors)
        {
            this.subject = $"{whatKind} {dtorNames}";
            this.ctorNames = DatatypeDestructor.PrintableCtorNameList(ctors, MutateCSharp.Schemata509.ReplaceStringConstant_1(243L, "or"));
        }
    }


    //// Misc constraints

    public class IndicesInDomain : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"all {objType} indices are in the domain of the initialization function";

        public override string FailureDescription =>
          $"all {objType} indices must be in the domain of the initialization function";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(244L, "indices in domain");

        private readonly string objType;

        public IndicesInDomain(string objType)
        {
            this.objType = objType;
        }
    }

    public class SubrangeCheck : ProofObligationDescription
    {
        public override string SuccessDescription =>
          isSubset
            ? $"value always satisfies the subset constraints of '{targetType}'"
            : $"value of expression (of type '{sourceType}') is always an instance of type '{targetType}'";

        public override string FailureDescription => BaseFailureDescription + (isCertain ? "" : cause);

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(245L, "subrange check");

        private string BaseFailureDescription =>
          isSubset
            ? $"{prefix}value does not satisfy the subset constraints of '{targetType}'"
            : $"{prefix}value of expression (of type '{sourceType}') is not known to be an instance of type '{targetType}'" +
              (isCertain ? MutateCSharp.Schemata509.ReplaceStringConstant_1(246L, ", because it might be null") : "");

        private readonly string prefix;
        private readonly string sourceType;
        private readonly string targetType;
        private readonly bool isSubset;
        private readonly bool isCertain;
        private readonly string cause;

        public SubrangeCheck(string prefix, string sourceType, string targetType, bool isSubset, bool isCertain, [CanBeNull] string cause)
        {
            this.prefix = prefix;
            this.sourceType = sourceType;
            this.targetType = targetType;
            this.isSubset = isSubset;
            this.isCertain = isCertain;
            this.cause = cause is null ? "" : $" (possible cause: {cause})";
        }
    }

    public class WitnessCheck : ProofObligationDescription
    {
        public override string SuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(247L, "type is inhabited");

        public override string FailureDescription =>
          witnessString is null
            ? MutateCSharp.Schemata509.ReplaceStringConstant_1(248L, "the given witness expression might not satisfy constraint"
      ) : (MutateCSharp.Schemata509.ReplaceBinExprOp_10(249L, witnessString, "") ? $"{errMsg}{hintMsg}" : $"{errMsg} (only tried {witnessString}){hintMsg}");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(250L, "witness check");

        public override bool ProvedOutsideUserCode => MutateCSharp.Schemata509.ReplaceBooleanConstant_0(251L, true);

        private readonly string errMsg = MutateCSharp.Schemata509.ReplaceStringConstant_1(252L, "cannot find witness that shows type is inhabited");
        private readonly string hintMsg = MutateCSharp.Schemata509.ReplaceStringConstant_1(253L, "; try giving a hint through a 'witness' or 'ghost witness' clause, or use 'witness *' to treat as a possibly empty type");
        private readonly string witnessString;
        [CanBeNull] private readonly Expression witnessExpr;

        public WitnessCheck(string witnessString, Expression witnessExpr = null)
        {
            this.witnessString = witnessString;
            this.witnessExpr = witnessExpr;
        }

        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            return witnessExpr ?? base.GetAssertedExpr(options);
        }
    }

    public class PrefixEqualityLimit : ProofObligationDescription
    {
        public override string SuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(254L, "prefix-equality limit is at least 0");

        public override string FailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(255L, "prefix-equality limit must be at least 0");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(256L, "prefix-equality limit");
    }

    public class ForRangeBoundsValid : ProofObligationDescription
    {
        public override string SuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(257L, "lower bound does not exceed upper bound");

        public override string FailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(258L, "lower bound must not exceed upper bound");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(259L, "for range bounds");

        private readonly Expression lo;
        private readonly Expression hi;

        public ForRangeBoundsValid(Expression lo, Expression hi)
        {
            this.lo = lo;
            this.hi = hi;
        }

        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            return new BinaryExpr(lo.tok, BinaryExpr.Opcode.Le, lo, hi);
        }
    }

    public class ForRangeAssignable : ProofObligationDescription
    {
        public override string SuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(260L, "entire range is assignable to index variable");

        public override string FailureDescription =>
          $"entire range must be assignable to index variable, but some {desc.FailureDescription}";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(261L, "for range assignable");

        private readonly ProofObligationDescription desc;
        private readonly Expression expr;

        public ForRangeAssignable(ProofObligationDescription desc, Expression expr)
        {
            this.desc = desc;
            this.expr = expr;
        }

        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            return expr;
        }
    }

    public class ValidInRecursion : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"{what} is valid in recursive setting";

        public override string FailureDescription =>
          $"cannot use {what} in recursive setting.{hint ?? ""}";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(262L, "valid in recursion");

        public override bool ProvedOutsideUserCode => MutateCSharp.Schemata509.ReplaceBooleanConstant_0(263L, true);

        private readonly string what;
        private readonly string hint;

        public ValidInRecursion(string what, string hint)
        {
            this.what = what;
            this.hint = hint;
        }
    }

    public class IsNonRecursive : ProofObligationDescription
    {
        public override string SuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(264L, "default value is non-recursive");

        public override string FailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(265L, "default-value expression is not allowed to involve recursive or mutually recursive calls");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(266L, "default nonrecursive");
    }

    public class ForallLHSUnique : ProofObligationDescription
    {
        public override string SuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(267L, "left-hand sides of forall-statement bound variables are unique");

        public override string FailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(268L, "left-hand sides for different forall-statement bound variables might refer to the same location");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(269L, "forall bound unique");
    }

    public class ElementInDomain : ProofObligationDescription
    {
        private readonly Expression sequence;
        private readonly Expression index;
        public override string SuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(270L, "element is in domain");

        public override string FailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(271L, "element might not be in domain");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(272L, "element in domain");

        public ElementInDomain(Expression sequence, Expression index)
        {
            this.sequence = sequence;
            this.index = index;
        }
        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            return new BinaryExpr(sequence.tok, BinaryExpr.Opcode.In,
              index,
              sequence
            );
        }
    }

    public class DefiniteAssignment : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"{what}, which is subject to definite-assignment rules, is always initialized {where}";

        public override string FailureDescription =>
          $"{what}, which is subject to definite-assignment rules, might be uninitialized {where}";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(273L, "definite assignment");

        private readonly string what;
        private readonly string where;

        public DefiniteAssignment(string what, string where)
        {
            this.what = what;
            this.where = where;
        }
    }

    public class InRange : ProofObligationDescription
    {
        private readonly Expression sequence;
        private readonly Expression index;
        private readonly bool upperExcluded;
        private readonly string what;
        private readonly int dimension;
        public override string SuccessDescription => $"{what} in range";

        public override string FailureDescription => $"{what} out of range";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(274L, "in range");

        public InRange(Expression sequence, Expression index, bool upperExcluded, string what, int dimension = -1)
        {
            this.sequence = sequence;
            this.index = index;
            this.what = what;
            this.upperExcluded = upperExcluded;
            this.dimension = dimension;
        }
        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            if (MutateCSharp.Schemata509.ReplaceBinExprOp_11(275L, () => sequence.Type is SeqType, () => sequence.Type.IsArrayType))
            {
                Expression bound = sequence.Type.IsArrayType ?
                    new MemberSelectExpr(sequence.tok, sequence, MutateCSharp.Schemata509.ReplaceStringConstant_1(281L, "Length") + (MutateCSharp.Schemata509.ReplaceBinExprOp_12(286L, dimension, MutateCSharp.Schemata509.ReplaceNumericConstant_2(282L, 0)) ? "" + dimension : ""))
                  : new UnaryOpExpr(sequence.tok, UnaryOpExpr.Opcode.Cardinality, sequence);
                return new ChainingExpression(sequence.tok, new List<Expression>() {
        new LiteralExpr(sequence.tok, MutateCSharp.Schemata509.ReplaceNumericConstant_2(291L, 0)),
        index,
        bound
      }, new List<BinaryExpr.Opcode>() {
        BinaryExpr.Opcode.Le,
        upperExcluded ? BinaryExpr.Opcode.Lt : BinaryExpr.Opcode.Le
      }, new List<IToken>() { Token.NoToken, Token.NoToken },
                  new List<Expression>() { null, null });
            }

            return new BinaryExpr(sequence.tok, BinaryExpr.Opcode.In,
              index,
              sequence
            );
        }
    }

    public class SequenceSelectRangeValid : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"upper bound within range of {what}";

        public override string FailureDescription =>
          $"upper bound below lower bound or above length of {what}";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(295L, "sequence select range valid");

        private readonly string what;
        private readonly Expression sequence;
        private readonly Expression lowerBound;
        private readonly Expression upperBound;

        public SequenceSelectRangeValid(Expression sequence, Expression lowerBound, Expression upperBound, string what)
        {
            this.what = what;
            this.sequence = sequence;
            this.lowerBound = lowerBound;
            this.upperBound = upperBound;
        }

        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            return new ChainingExpression(sequence.tok, new List<Expression>() {
      lowerBound,
      upperBound,
      new UnaryOpExpr(sequence.tok, UnaryOpExpr.Opcode.Cardinality, sequence)
    }, new List<BinaryExpr.Opcode>() {
      BinaryExpr.Opcode.Le,
      BinaryExpr.Opcode.Le
    }, new List<IToken>() { Token.NoToken, Token.NoToken }, new List<Expression>() { null, null });
        }
    }

    public class ComprehensionNoAlias : ProofObligationDescription
    {
        public override string SuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(296L, "key expressions refer to unique values");

        public override string FailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(297L, "key expressions might be referring to the same value");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(298L, "unique key expressions");
    }

    public class DistinctLHS : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"left-hand sides {lhsa} and {lhsb} are distinct";

        public override string FailureDescription =>
          $"{when}left-hand sides {lhsa} and {lhsb} {might}refer to the same location{whenSuffix}";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(299L, "distinct lhs");

        private readonly string lhsa;
        private readonly string lhsb;
        private readonly string might;
        private readonly string when;
        private readonly string whenSuffix;

        public DistinctLHS(string lhsa, string lhsb, bool useMight, bool useWhen)
        {
            this.lhsa = lhsa;
            this.lhsb = lhsb;
            this.might = useMight ? MutateCSharp.Schemata509.ReplaceStringConstant_1(300L, "might ") : "";
            this.when = useWhen ? MutateCSharp.Schemata509.ReplaceStringConstant_1(301L, "when ") : "";
            this.whenSuffix = useWhen ? MutateCSharp.Schemata509.ReplaceStringConstant_1(302L, ", they must be assigned the same value") : "";
        }
    }

    public class ArrayInitSizeValid : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"given array size agrees with the number of expressions in the initializing display ({size})";

        public override string FailureDescription =>
          $"given array size must agree with the number of expressions in the initializing display ({size})";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(303L, "array initializer size");

        private readonly TypeRhs rhs;
        private readonly Expression dim;
        private int size => rhs.InitDisplay.Count;

        public ArrayInitSizeValid(TypeRhs rhs, Expression dim)
        {
            this.rhs = rhs;
            this.dim = dim;
        }

        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            var initDisplaySize = new UnaryOpExpr(rhs.tok, UnaryOpExpr.Opcode.Cardinality, new SeqDisplayExpr(rhs.tok, rhs.InitDisplay));
            return new BinaryExpr(dim.tok, BinaryExpr.Opcode.Eq, dim, initDisplaySize);
        }
    }

    public class ArrayInitEmpty : ProofObligationDescription
    {
        public override string SuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(304L, "array initializer has empty size");

        public override string FailureDescription =>
          $"unless an initializer is provided for the array elements, a new array of '{typeDesc}' must have empty size";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(305L, "array initializer empty");

        private readonly string typeDesc;
        private readonly ImmutableList<Expression> dims;

        public ArrayInitEmpty(string typeDesc, List<Expression> dims)
        {
            this.typeDesc = typeDesc;
            this.dims = dims.ToImmutableList();
        }

        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            Expression zero = Expression.CreateIntLiteral(dims[MutateCSharp.Schemata509.ReplaceNumericConstant_2(306L, 0)].tok, MutateCSharp.Schemata509.ReplaceNumericConstant_2(310L, 0));
            Expression zeroSize = new BinaryExpr(dims[MutateCSharp.Schemata509.ReplaceNumericConstant_2(314L, 0)].tok, BinaryExpr.Opcode.Eq, dims[MutateCSharp.Schemata509.ReplaceNumericConstant_2(318L, 0)], zero);
            foreach (Expression dim in dims.Skip(MutateCSharp.Schemata509.ReplaceNumericConstant_2(322L, 1)))
            {
                zeroSize = new BinaryExpr(
                  dim.tok,
                  BinaryExpr.Opcode.Or,
                  zeroSize,
                  new BinaryExpr(dim.tok, BinaryExpr.Opcode.Eq, dim, zero)
                );
            }
            return zeroSize;
        }
    }

    public class LetSuchThatUnique : ProofObligationDescription
    {
        private readonly Expression condition;
        private readonly List<BoundVar> bvars;
        public override string SuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(326L, "the value of this let-such-that expression is uniquely determined");

        public override string FailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(327L, "to be compilable, the value of a let-such-that expression must be uniquely determined");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(328L, "let-such-that unique");

        public LetSuchThatUnique(Expression condition, List<BoundVar> bvars)
        {
            this.condition = condition;
            this.bvars = bvars;
        }
        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            var bvarsExprs = bvars.Select(bvar => new IdentifierExpr(bvar.tok, bvar)).ToList();
            var bvarprimes = bvars.Select(bvar => new BoundVar(Token.NoToken, bvar.DafnyName + MutateCSharp.Schemata509.ReplaceStringConstant_1(329L, "'"), bvar.Type)).ToList();
            var bvarprimesExprs = bvarprimes.Select(ToSubstitutableExpression).ToList();
            var subContract = new Substituter(null,
              Enumerable.Zip(bvars, bvarprimesExprs).ToDictionary<(BoundVar, Expression), IVariable, Expression>(
                item => item.Item1, item => item.Item2),
              new Dictionary<TypeParameter, Type>()
            );
            var conditionSecondBoundVar = subContract.Substitute(condition);
            var conclusion = new BinaryExpr(Token.NoToken, BinaryExpr.Opcode.Eq, bvarsExprs[MutateCSharp.Schemata509.ReplaceNumericConstant_2(330L, 0)], bvarprimesExprs[MutateCSharp.Schemata509.ReplaceNumericConstant_2(334L, 0)]);
            for (var i = MutateCSharp.Schemata509.ReplaceNumericConstant_2(338L, 1); MutateCSharp.Schemata509.ReplaceBinExprOp_13(342L, i, bvarsExprs.Count); MutateCSharp.Schemata509.ReplacePostfixUnaryExprOp_14(347L, ref i))
            {
                conclusion = new BinaryExpr(Token.NoToken, BinaryExpr.Opcode.And,
                  conclusion,
                  new BinaryExpr(Token.NoToken, BinaryExpr.Opcode.Eq, bvarsExprs[i], bvarprimesExprs[i])
                  );
            }
            return new ForallExpr(Token.NoToken, RangeToken.NoToken, bvars.Concat(bvarprimes).ToList(),
              new BinaryExpr(Token.NoToken, BinaryExpr.Opcode.And, condition, conditionSecondBoundVar),

              conclusion, null);
        }
    }

    public class LetSuchThatExists : ProofObligationDescription
    {
        private readonly Expression condition;
        private readonly List<BoundVar> bvars;

        public override string SuccessDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(348L, "a value exists that satisfies this let-such-that expression");

        public override string FailureDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(349L, "cannot establish the existence of LHS values that satisfy the such-that predicate");

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(350L, "let-such-that exists");

        public LetSuchThatExists(List<BoundVar> bvars, Expression condition)
        {
            this.condition = condition;
            this.bvars = bvars;
        }
        public override Expression GetAssertedExpr(DafnyOptions options)
        {
            return new ExistsExpr(bvars[MutateCSharp.Schemata509.ReplaceNumericConstant_2(351L, 0)].tok, bvars[MutateCSharp.Schemata509.ReplaceNumericConstant_2(355L, 0)].RangeToken, bvars,
              null, condition, null);
        }
    }

    public class AssignmentShrinks : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"the assignment to {fieldName} always shrinks the set";

        public override string FailureDescription =>
          $"an assignment to {fieldName} is only allowed to shrink the set";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(359L, "assignment shrinks");

        private readonly string fieldName;

        public AssignmentShrinks(string fieldName)
        {
            this.fieldName = fieldName;
        }
    }

    public class ConcurrentFrameEmpty : ProofObligationDescription
    {
        public override string SuccessDescription =>
          $"{frameName} is empty ({{:concurrent}} restriction)";

        public override string FailureDescription =>
          $"{frameName} could not be proved to be empty ({{:concurrent}} restriction)";

        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(360L, "concurrency safety");

        public override bool ProvedOutsideUserCode => MutateCSharp.Schemata509.ReplaceBooleanConstant_0(361L, true);

        private readonly string frameName;

        public ConcurrentFrameEmpty(string frameName)
        {
            this.frameName = frameName;
        }
    }

    public class BoilerplateTriple : ProofObligationDescriptionCustomMessages
    {
        public override string ShortDescription => MutateCSharp.Schemata509.ReplaceStringConstant_1(362L, "boilerplate triple");

        public override string DefaultSuccessDescription { get; }
        public override string DefaultFailureDescription { get; }

        public BoilerplateTriple(string errorMessage, string successMessage, string comment)
          : base(errorMessage, successMessage)
        {
            this.DefaultSuccessDescription = comment;
            this.DefaultFailureDescription = comment;
        }
    }

    public class Utils
    {
        public static Expression MakeCharBoundsCheck(DafnyOptions options, Expression expr)
        {
            return options.Get(CommonOptionBag.UnicodeCharacters)
              ? MakeCharBoundsCheckUnicode(expr)
              : MakeCharBoundsCheckNonUnicode(expr);
        }

        public static Expression MakeCharBoundsCheckNonUnicode(Expression expr)
        {
            return new BinaryExpr(
              expr.tok,
              BinaryExpr.Opcode.And,
              new BinaryExpr(
                expr.tok, BinaryExpr.Opcode.Le, Expression.CreateIntLiteral(Token.NoToken, MutateCSharp.Schemata509.ReplaceNumericConstant_2(363L, 0)), expr),
              new BinaryExpr(
                expr.tok, BinaryExpr.Opcode.Lt, expr, Expression.CreateIntLiteral(expr.tok, MutateCSharp.Schemata509.ReplaceNumericConstant_2(367L, 0x1_0000)))
            );
        }

        public static Expression MakeCharBoundsCheckUnicode(Expression expr)
        {
            Expression lowRange = new BinaryExpr(
              expr.tok,
              BinaryExpr.Opcode.And,
              new BinaryExpr(expr.tok, BinaryExpr.Opcode.Le, Expression.CreateIntLiteral(Token.NoToken, MutateCSharp.Schemata509.ReplaceNumericConstant_2(371L, 0)), expr),
              new BinaryExpr(expr.tok, BinaryExpr.Opcode.Lt, expr, Expression.CreateIntLiteral(expr.tok, MutateCSharp.Schemata509.ReplaceNumericConstant_2(375L, 0xD800)))
            );
            Expression highRange = new BinaryExpr(
              expr.tok,
              BinaryExpr.Opcode.And,
              new BinaryExpr(expr.tok, BinaryExpr.Opcode.Le, Expression.CreateIntLiteral(Token.NoToken, MutateCSharp.Schemata509.ReplaceNumericConstant_2(379L, 0xE000)), expr),
              new BinaryExpr(expr.tok, BinaryExpr.Opcode.Lt, expr, Expression.CreateIntLiteral(expr.tok, MutateCSharp.Schemata509.ReplaceNumericConstant_2(383L, 0x11_0000)))
            );
            return new BinaryExpr(lowRange.tok, BinaryExpr.Opcode.Or, lowRange, highRange);
        }
    }
}
