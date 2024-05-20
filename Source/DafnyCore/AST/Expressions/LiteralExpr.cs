using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Numerics;
namespace MutateCSharp
{
    internal class Schemata57
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT57");
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

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class LiteralExpr : Expression, ICloneable<LiteralExpr>
    {
        /// <summary>
        /// One of the following:
        ///   * 'null' for the 'null' literal (a special case of which is the subclass StaticReceiverExpr)
        ///   * a bool for a bool literal
        ///   * a BigInteger for int literal
        ///   * a BaseTypes.BigDec for a (rational) real literal
        ///   * a string for a char literal
        ///     This case always uses the subclass CharLiteralExpr.
        ///     Note, a string is stored to keep any escape sequence, since this simplifies printing of the character
        ///     literal, both when pretty printed as a Dafny expression and when being compiled into C# code.  The
        ///     parser checks the validity of any escape sequence and the verifier deals with turning such into a
        ///     single character value.
        ///   * a string for a string literal
        ///     This case always uses the subclass StringLiteralExpr.
        ///     Note, the string is stored with all escapes as characters.  For example, the input string "hello\n" is
        ///     stored in a LiteralExpr has being 7 characters long, whereas the Dafny (and C#) length of this string is 6.
        ///     This simplifies printing of the string, both when pretty printed as a Dafny expression and when being
        ///     compiled into C# code.  The parser checks the validity of the escape sequences and the verifier deals
        ///     with turning them into single characters.
        /// </summary>
        public readonly object Value;

        [System.Diagnostics.Contracts.Pure]
        public static bool IsTrue(Expression e)
        {
            Contract.Requires(e != null);
            return Expression.IsBoolLiteral(e, out var value) && value;
        }

        public static bool IsEmptySet(Expression e)
        {
            Contract.Requires(e != null);
            return StripParens(e) is SetDisplayExpr display && MutateCSharp.Schemata57.ReplaceBinExprOp_1(5L, display.Elements.Count, MutateCSharp.Schemata57.ReplaceNumericConstant_0(1L, 0));
        }

        public static bool IsEmptyMultiset(Expression e)
        {
            Contract.Requires(e != null);
            return StripParens(e) is MultiSetDisplayExpr display && MutateCSharp.Schemata57.ReplaceBinExprOp_1(14L, display.Elements.Count, MutateCSharp.Schemata57.ReplaceNumericConstant_0(10L, 0));
        }

        public static bool IsEmptySequence(Expression e)
        {
            Contract.Requires(e != null);
            return StripParens(e) is SeqDisplayExpr display && MutateCSharp.Schemata57.ReplaceBinExprOp_1(23L, display.Elements.Count, MutateCSharp.Schemata57.ReplaceNumericConstant_0(19L, 0));
        }

        public LiteralExpr(IToken tok)
          : base(tok)
        {  // represents the Dafny literal "null"
            Contract.Requires(tok != null);
            this.Value = null;
        }

        public LiteralExpr(IToken tok, BigInteger n)
          : base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(0 <= n.Sign);
            this.Value = n;
        }

        public LiteralExpr(IToken tok, BaseTypes.BigDec n)
          : base(tok)
        {
            Contract.Requires(0 <= n.Mantissa.Sign);
            Contract.Requires(tok != null);
            this.Value = n;
        }

        public LiteralExpr(IToken tok, int n)
          : base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(0 <= n);
            this.Value = new BigInteger(n);
        }

        public LiteralExpr(IToken tok, bool b)
          : base(tok)
        {
            Contract.Requires(tok != null);
            this.Value = b;
        }

        /// <summary>
        /// This constructor is to be used only with the StringLiteralExpr and CharLiteralExpr subclasses, for
        /// two reasons:  both of these literals store a string in .Value, and string literals also carry an
        /// additional field.
        /// </summary>
        protected LiteralExpr(IToken tok, string s)
          : base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(s != null);
            this.Value = s;
        }

        public LiteralExpr(Cloner cloner, LiteralExpr original) : base(cloner, original)
        {
            Value = original.Value;
        }

        public LiteralExpr Clone(Cloner cloner)
        {
            return new LiteralExpr(cloner, this);
        }
    }

    public class CharLiteralExpr : LiteralExpr, ICloneable<CharLiteralExpr>
    {
        public CharLiteralExpr(IToken tok, string s)
          : base(tok, s)
        {
            Contract.Requires(s != null);
        }

        public CharLiteralExpr(Cloner cloner, CharLiteralExpr original) : base(cloner, original)
        {
        }

        public new CharLiteralExpr Clone(Cloner cloner)
        {
            return new CharLiteralExpr(cloner, this);
        }
    }

    public class StringLiteralExpr : LiteralExpr, ICloneable<StringLiteralExpr>
    {
        public readonly bool IsVerbatim;
        public StringLiteralExpr(IToken tok, string s, bool isVerbatim)
          : base(tok, s)
        {
            Contract.Requires(s != null);
            IsVerbatim = isVerbatim;
        }

        public StringLiteralExpr(Cloner cloner, StringLiteralExpr original) : base(cloner, original)
        {
            IsVerbatim = original.IsVerbatim;
        }

        public new StringLiteralExpr Clone(Cloner cloner)
        {
            return new StringLiteralExpr(cloner, this);
        }
    }

    /// <summary>
    /// A NegationExpression e represents the value -e and is syntactic shorthand
    /// for 0-e (for integers) or 0.0-e (for reals).
    /// </summary>
    public class NegationExpression : ConcreteSyntaxExpression, ICloneable<NegationExpression>
    {
        public readonly Expression E;

        public NegationExpression Clone(Cloner cloner)
        {
            return new NegationExpression(cloner, this);
        }

        public NegationExpression(Cloner cloner, NegationExpression original) : base(cloner, original)
        {
            E = cloner.CloneExpr(original.E);
        }

        public NegationExpression(IToken tok, Expression e)
          : base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(e != null);
            E = e;
        }
        public override IEnumerable<Expression> SubExpressions
        {
            get
            {
                if (MutateCSharp.Schemata57.ReplaceBinExprOp_2(28L, ResolvedExpression, null))
                {
                    // the expression hasn't yet been turned into a resolved expression, so use .E as the subexpression
                    yield return E;
                }
                else
                {
                    foreach (var ee in base.SubExpressions)
                    {
                        yield return ee;
                    }
                }

                yield break;
            }
        }

        public override IEnumerable<Expression> PreResolveSubExpressions
        {
            get
            {
                yield return E;
            }
        }
    }
}