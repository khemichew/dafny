using System;
using System.Collections.Generic;
using System.Linq;
using System.CommandLine;
using System.Diagnostics.Contracts;
using System.Threading;
using static Microsoft.Dafny.ParseErrors;
namespace MutateCSharp
{
    internal class Schemata89
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT89");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
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

        internal static int ReplaceNumericConstant_6(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
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

        internal static string ReplaceStringConstant_9(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static int ReplacePostfixUnaryExprOp_12(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static int ReplaceBinExprOp_11(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static int ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_8(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.QuantifierSyntaxOptions argument1, Microsoft.Dafny.QuantifierSyntaxOptions argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public partial class Parser
    {

        public Parser(DafnyOptions options, Scanner/*!*/ scanner, Errors/*!*/ errors, CancellationToken cancellationToken)
          : this(scanner, errors, cancellationToken)  // the real work
        {
            // initialize readonly fields
            dummyExpr = new LiteralExpr(Token.NoToken);
            dummyRhs = new ExprRhs(dummyExpr);
            dummyFrameExpr = new FrameExpression(dummyExpr.tok, dummyExpr, null);
            dummyStmt = new ReturnStmt(Token.NoToken.ToRange(), null);
            var dummyBlockStmt = new BlockStmt(Token.NoToken.ToRange(), new List<Statement>());
            dummyIfStmt = new IfStmt(Token.NoToken.ToRange(), MutateCSharp.Schemata89.ReplaceBooleanConstant_0(1L, false), null, dummyBlockStmt, null);

            theOptions = new DafnyOptions(options);
            theModule = new FileModuleDefinition(scanner.FirstToken);
        }

        bool IsIdentifier(int kind)
        {
            return MutateCSharp.Schemata89.ReplaceBinExprOp_2(45L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_2(34L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_2(23L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_2(12L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(2L, kind, _ident), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(7L, kind, _least)), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(18L, kind, _greatest)), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(29L, kind, _older)), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(40L, kind, _opaque));
        }

        bool IsQuantifierVariableDecl(QuantifiedVar previousVar)
        {
            // Introducing per-quantified variable ranges creates some ambiguities in the grammar,
            // since before that the range would terminate the quantifed domain. For example, the following statement:
            //
            // print set x | E, y;
            //
            // This would previously parse as two separate arguments to the print statement, but
            // could now also be parsed as a single set comprehension argument with two quantified variables
            // (and an invalid one since it would need an explicit ":: <Term>" section).
            //
            // Even worse:
            //
            // print set x | E, y <- C;
            //
            // This was a valid statement before as well, because "y <- C" would be parsed as the expression
            // "y < (-C)".
            //
            // The /quantifierSyntax option is used to help migrate this otherwise breaking change:
            // * /quantifierSyntax:3 keeps the old behaviour where a "| <Range>" always terminates the list of quantified variables.
            // * /quantifierSyntax:4 instead attempts to parse additional quantified variables.
            if (MutateCSharp.Schemata89.ReplaceBinExprOp_5(53L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_3(51L, previousVar.Range, null), () => MutateCSharp.Schemata89.ReplaceBinExprOp_4(52L, theOptions.QuantifierSyntax, QuantifierSyntaxOptions.Version3)))
            {
                return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(59L, false);
            }

            scanner.ResetPeek();
            IToken x = scanner.Peek();
            return MutateCSharp.Schemata89.ReplaceBinExprOp_5(65L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(60L, la.kind, _comma), () => IsIdentifier(x.kind));
        }

        // Checks for "<-", which has to be parsed as two separate tokens,
        // but ensures no whitespace between them.
        bool IsFromArrow()
        {
            scanner.ResetPeek();
            IToken x = scanner.Peek();
            return MutateCSharp.Schemata89.ReplaceBinExprOp_5(116L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_5(92L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_5(81L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(71L, la.kind, _openAngleBracket), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(76L, x.kind, _minus
        )), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(87L, la.line, x.line)), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(111L, la.col, MutateCSharp.Schemata89.ReplaceBinExprOp_7(102L, x.col, MutateCSharp.Schemata89.ReplaceNumericConstant_6(98L, 1))));
        }

        bool IsLabel(bool allowLabel)
        {
            if (!allowLabel)
            {
                return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(122L, false);
            }
            scanner.ResetPeek();
            IToken x = scanner.Peek();
            return MutateCSharp.Schemata89.ReplaceBinExprOp_5(139L, () => (MutateCSharp.Schemata89.ReplaceBinExprOp_2(128L, () => IsIdentifier(la.kind), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(123L, la.kind, _digits))), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(134L, x.kind, _colon));
        }

        bool IsKeywordForFormal()
        {
            scanner.ResetPeek();
            if (MutateCSharp.Schemata89.ReplaceBinExprOp_2(166L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_2(155L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(145L, la.kind, _ghost), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(150L, la.kind, _new)), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(161L, la.kind, _nameonly)))
            {
                return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(172L, true);
            }
            else if (MutateCSharp.Schemata89.ReplaceBinExprOp_1(173L, la.kind, _older))
            {
                // "older" is just a contextual keyword, so don't recognize it as a keyword if it must be an identifier
                IToken x = scanner.Peek();
                return MutateCSharp.Schemata89.ReplaceBinExprOp_8(178L, x.kind, _colon);
            }
            return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(183L, false);
        }

        bool IsBinding()
        {
            scanner.ResetPeek();
            IToken x = scanner.Peek();
            return MutateCSharp.Schemata89.ReplaceBinExprOp_5(200L, () => (MutateCSharp.Schemata89.ReplaceBinExprOp_2(189L, () => IsIdentifier(la.kind), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(184L, la.kind, _digits))), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(195L, x.kind, _gets));
        }

        bool IsAlternative()
        {
            IToken x = scanner.Peek();
            return MutateCSharp.Schemata89.ReplaceBinExprOp_2(227L, () => (MutateCSharp.Schemata89.ReplaceBinExprOp_5(216L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(206L, la.kind, _lbrace), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(211L, x.kind, _case)))
        , () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(222L, la.kind, _case));
        }

        bool IsParenIdentsColon()
        {
            IToken x = la;
            if (MutateCSharp.Schemata89.ReplaceBinExprOp_8(233L, x.kind, _openparen))
            {
                return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(238L, false);
            }
            x = scanner.Peek();
            var oneOrMoreIdentifiers = MutateCSharp.Schemata89.ReplaceBooleanConstant_0(239L, false);
            while (MutateCSharp.Schemata89.ReplaceBinExprOp_2(245L, () => IsIdentifier(x.kind), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(240L, x.kind, _ghost)))
            { /* ghost is illegal here, but checking for it allows better error messages and recovery */
                x = scanner.Peek();
                oneOrMoreIdentifiers = MutateCSharp.Schemata89.ReplaceBooleanConstant_0(251L, true);
            }
            return MutateCSharp.Schemata89.ReplaceBinExprOp_5(257L, () => oneOrMoreIdentifiers, () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(252L, x.kind, _colon));
        }

        bool IsGets()
        {
            return MutateCSharp.Schemata89.ReplaceBinExprOp_1(263L, la.kind, _gets);
        }

        bool IsPeekVar()
        {
            scanner.ResetPeek();
            IToken x = scanner.Peek();
            return MutateCSharp.Schemata89.ReplaceBinExprOp_1(268L, x.kind, _var);
        }

        // an existential guard starts with an identifier and is then followed by
        // * a colon (if the first identifier is given an explicit type),
        // * a comma (if there's a list of bound variables and the first one is not given an explicit type),
        // * a start-attribute (if there's one bound variable and it is not given an explicit type and there are attributes), or
        // * a bored smiley (if there's one bound variable and it is not given an explicit type).
        bool IsBindingGuard()
        {
            scanner.ResetPeek();
            if (IsIdentifier(la.kind))
            {
                Token x = scanner.Peek();
                if (MutateCSharp.Schemata89.ReplaceBinExprOp_2(305L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_2(294L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_2(283L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(273L, x.kind, _colon), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(278L, x.kind, _comma)), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(289L, x.kind, _boredSmiley)), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(300L, x.kind, _lbracecolon)))
                {
                    return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(311L, true);
                }
            }
            return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(312L, false);
        }

        bool IsLoopSpec()
        {
            return MutateCSharp.Schemata89.ReplaceBinExprOp_2(334L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_2(323L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(313L, la.kind, _invariant), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(318L, la.kind, _decreases)), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(329L, la.kind, _modifies));
        }

        bool IsWitness()
        {
            scanner.ResetPeek();
            if (MutateCSharp.Schemata89.ReplaceBinExprOp_1(340L, la.kind, _witness))
            {
                return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(345L, true);
            }
            else if (MutateCSharp.Schemata89.ReplaceBinExprOp_1(346L, la.kind, _ghost))
            {
                Token x = scanner.Peek();
                return MutateCSharp.Schemata89.ReplaceBinExprOp_1(351L, x.kind, _witness);
            }
            return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(356L, false);
        }

        bool IsFunctionDecl()
        {
            switch (la.kind)
            {
                case _function:
                case _predicate:
                case _copredicate:
                    return true;
                    break;
                case _least:
                case _greatest:
                case _inductive:
                    return scanner.Peek().kind != _lemma;
                    break;
                case _twostate:
                    var x = scanner.Peek();
                    return x.kind == _function || x.kind == _predicate;
                    break;
                default:
                    return false;
                    break;
            }

            return default;
        }

        bool IsParenStar()
        {
            scanner.ResetPeek();
            Token x = scanner.Peek();
            return MutateCSharp.Schemata89.ReplaceBinExprOp_5(367L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(357L, la.kind, _openparen), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(362L, x.kind, _star));
        }

        bool IsEquivOp() => IsEquivOp(la);
        bool IsImpliesOp() => IsImpliesOp(la);
        bool IsExpliesOp() => IsExpliesOp(la);
        bool IsAndOp() => IsAndOp(la);
        bool IsOrOp() => IsOrOp(la);
        static bool IsEquivOp(IToken la)
        {
            return MutateCSharp.Schemata89.ReplaceBinExprOp_10(374L, la.val, MutateCSharp.Schemata89.ReplaceStringConstant_9(373L, "<==>"));
        }
        static bool IsImpliesOp(IToken la)
        {
            return MutateCSharp.Schemata89.ReplaceBinExprOp_10(376L, la.val, MutateCSharp.Schemata89.ReplaceStringConstant_9(375L, "==>"));
        }
        static bool IsExpliesOp(IToken la)
        {
            return MutateCSharp.Schemata89.ReplaceBinExprOp_10(378L, la.val, MutateCSharp.Schemata89.ReplaceStringConstant_9(377L, "<=="));
        }
        static bool IsAndOp(IToken la)
        {
            return MutateCSharp.Schemata89.ReplaceBinExprOp_10(380L, la.val, MutateCSharp.Schemata89.ReplaceStringConstant_9(379L, "&&"));
        }
        static bool IsOrOp(IToken la)
        {
            return MutateCSharp.Schemata89.ReplaceBinExprOp_10(382L, la.val, MutateCSharp.Schemata89.ReplaceStringConstant_9(381L, "||"));
        }
        bool IsBitwiseAndOp()
        {
            return MutateCSharp.Schemata89.ReplaceBinExprOp_10(384L, la.val, MutateCSharp.Schemata89.ReplaceStringConstant_9(383L, "&"));
        }
        bool IsBitwiseOrOp()
        {
            return MutateCSharp.Schemata89.ReplaceBinExprOp_10(386L, la.val, MutateCSharp.Schemata89.ReplaceStringConstant_9(385L, "|"));
        }
        bool IsBitwiseXorOp()
        {
            return MutateCSharp.Schemata89.ReplaceBinExprOp_10(388L, la.val, MutateCSharp.Schemata89.ReplaceStringConstant_9(387L, "^"));
        }
        bool IsBitwiseOp()
        {
            return MutateCSharp.Schemata89.ReplaceBinExprOp_2(395L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_2(389L, () => IsBitwiseAndOp(), () => IsBitwiseOrOp()), () => IsBitwiseXorOp());
        }
        bool IsAsOrIs()
        {
            return MutateCSharp.Schemata89.ReplaceBinExprOp_2(411L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(401L, la.kind, _as), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(406L, la.kind, _is));
        }
        bool IsRelOp()
        {
            return MutateCSharp.Schemata89.ReplaceBinExprOp_2(480L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_2(472L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_2(461L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_2(453L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_2(445L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_2(437L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_2(429L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_2(421L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_10(418L, la.val, MutateCSharp.Schemata89.ReplaceStringConstant_9(417L, "=="
        )), () => MutateCSharp.Schemata89.ReplaceBinExprOp_10(420L, la.val, MutateCSharp.Schemata89.ReplaceStringConstant_9(419L, "<"
        ))), () => MutateCSharp.Schemata89.ReplaceBinExprOp_10(428L, la.val, MutateCSharp.Schemata89.ReplaceStringConstant_9(427L, ">"
        ))), () => MutateCSharp.Schemata89.ReplaceBinExprOp_10(436L, la.val, MutateCSharp.Schemata89.ReplaceStringConstant_9(435L, "<="
        ))), () => MutateCSharp.Schemata89.ReplaceBinExprOp_10(444L, la.val, MutateCSharp.Schemata89.ReplaceStringConstant_9(443L, ">="
        ))), () => MutateCSharp.Schemata89.ReplaceBinExprOp_10(452L, la.val, MutateCSharp.Schemata89.ReplaceStringConstant_9(451L, "!="
        ))), () => MutateCSharp.Schemata89.ReplaceBinExprOp_10(460L, la.val, MutateCSharp.Schemata89.ReplaceStringConstant_9(459L, "in"
        ))), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(467L, la.kind, _notIn
        )), () => MutateCSharp.Schemata89.ReplaceBinExprOp_10(479L, la.val, MutateCSharp.Schemata89.ReplaceStringConstant_9(478L, "!")));
        }
        bool IsShiftOp()
        {
            if (MutateCSharp.Schemata89.ReplaceBinExprOp_1(486L, la.kind, _openAngleBracket))
            {
            }
            else if (MutateCSharp.Schemata89.ReplaceBinExprOp_1(491L, la.kind, _closeAngleBracket))
            {
            }
            else
            {
                return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(496L, false);
            }
            scanner.ResetPeek();
            var x = scanner.Peek();
            if (MutateCSharp.Schemata89.ReplaceBinExprOp_8(497L, x.kind, la.kind))
            {
                return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(502L, false);
            }
            return MutateCSharp.Schemata89.ReplaceBinExprOp_1(516L, x.pos, MutateCSharp.Schemata89.ReplaceBinExprOp_11(507L, la.pos, MutateCSharp.Schemata89.ReplaceNumericConstant_6(503L, 1)));  // return true only if the tokens are adjacent to each other
        }
        bool IsAddOp()
        {
            return MutateCSharp.Schemata89.ReplaceBinExprOp_2(525L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_10(522L, la.val, MutateCSharp.Schemata89.ReplaceStringConstant_9(521L, "+")), () => MutateCSharp.Schemata89.ReplaceBinExprOp_10(524L, la.val, MutateCSharp.Schemata89.ReplaceStringConstant_9(523L, "-")));
        }
        bool IsMulOp()
        {
            return MutateCSharp.Schemata89.ReplaceBinExprOp_2(546L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_2(538L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(531L, la.kind, _star), () => MutateCSharp.Schemata89.ReplaceBinExprOp_10(537L, la.val, MutateCSharp.Schemata89.ReplaceStringConstant_9(536L, "/"))), () => MutateCSharp.Schemata89.ReplaceBinExprOp_10(545L, la.val, MutateCSharp.Schemata89.ReplaceStringConstant_9(544L, "%")));
        }
        bool IsQSep()
        {
            return MutateCSharp.Schemata89.ReplaceBinExprOp_1(552L, la.kind, _doublecolon);
        }

        bool IsNonFinalColon()
        {
            return MutateCSharp.Schemata89.ReplaceBinExprOp_5(567L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(557L, la.kind, _colon), () => MutateCSharp.Schemata89.ReplaceBinExprOp_8(562L, scanner.Peek().kind, _rbracket));
        }

        bool ExprIsMapDisplay()
        {
            scanner.ResetPeek();
            return MutateCSharp.Schemata89.ReplaceBinExprOp_5(594L, () => (MutateCSharp.Schemata89.ReplaceBinExprOp_2(583L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(573L, la.kind, _map), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(578L, la.kind, _imap))), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(589L, scanner.Peek().kind, _lbracket));
        }

        bool ExprIsSetDisplay()
        {
            scanner.ResetPeek();
            if (MutateCSharp.Schemata89.ReplaceBinExprOp_1(600L, la.kind, _lbrace))
            {
                return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(605L, true);
            }

            int k = scanner.Peek().kind;
            if (MutateCSharp.Schemata89.ReplaceBinExprOp_5(616L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(606L, la.kind, _iset), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(611L, k, _lbrace)))
            {
                return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(622L, true);
            }

            if (MutateCSharp.Schemata89.ReplaceBinExprOp_1(623L, la.kind, _multiset))
            {
                return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(628L, true);
            }

            return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(629L, false);
        }

        bool IsSuffix()
        {
            return MutateCSharp.Schemata89.ReplaceBinExprOp_2(651L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_2(640L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(630L, la.kind, _dot), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(635L, la.kind, _lbracket)), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(646L, la.kind, _openparen));
        }

        string UnwildIdent(IToken x, bool allowWildcardId)
        {
            if (x.val.StartsWith(MutateCSharp.Schemata89.ReplaceStringConstant_9(657L, "_")))
            {
                if (MutateCSharp.Schemata89.ReplaceBinExprOp_5(667L, () => allowWildcardId, () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(662L, x.val.Length, MutateCSharp.Schemata89.ReplaceNumericConstant_6(658L, 1))))
                {
                    return MutateCSharp.Schemata89.ReplaceStringConstant_9(673L, "_v") + MutateCSharp.Schemata89.ReplacePostfixUnaryExprOp_12(674L, ref anonymousIds);
                }
                else
                {
                    SemErr(ErrorId.p_no_leading_underscore, x, MutateCSharp.Schemata89.ReplaceStringConstant_9(675L, "cannot declare identifier beginning with underscore"));
                }
            }
            return x.val;
        }

        bool IsLambda(bool allowLambda)
        {
            if (!allowLambda)
            {
                return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(676L, false);
            }
            scanner.ResetPeek();
            Token x;
            // peek at what might be a signature of a lambda expression
            if (IsIdentifier(la.kind))
            {
                // cool, that's the entire candidate signature
            }
            else if (MutateCSharp.Schemata89.ReplaceBinExprOp_8(677L, la.kind, _openparen))
            {
                return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(682L, false);  // this is not a lambda expression
            }
            else
            {
                int identCount = MutateCSharp.Schemata89.ReplaceNumericConstant_6(683L, 0);
                x = scanner.Peek();
                while (MutateCSharp.Schemata89.ReplaceBinExprOp_8(687L, x.kind, _closeparen))
                {
                    if (MutateCSharp.Schemata89.ReplaceBinExprOp_8(696L, identCount, MutateCSharp.Schemata89.ReplaceNumericConstant_6(692L, 0)))
                    {
                        if (MutateCSharp.Schemata89.ReplaceBinExprOp_8(701L, x.kind, _comma))
                        {
                            return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(706L, false);  // not the signature of a lambda
                        }
                        x = scanner.Peek();
                    }
                    if (!IsIdentifier(x.kind))
                    {
                        return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(707L, false);  // not a lambda expression
                    }

                    MutateCSharp.Schemata89.ReplacePostfixUnaryExprOp_12(708L, ref identCount);
                    x = scanner.Peek();
                    if (MutateCSharp.Schemata89.ReplaceBinExprOp_1(709L, x.kind, _colon))
                    {
                        // a colon belongs only in a lamdba signature, so this must be a lambda (or something ill-formed)
                        return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(714L, true);
                    }
                }
            }
            // What we have seen so far could have been a lambda signature or could have been some
            // other expression (in particular, an identifier, a parenthesized identifier, or a
            // tuple all of whose subexpressions are identifiers).
            // It is a lambda expression if what follows is something that must be a lambda.
            x = scanner.Peek();
            return MutateCSharp.Schemata89.ReplaceBinExprOp_2(736L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_2(725L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(715L, x.kind, _darrow), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(720L, x.kind, _reads)), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(731L, x.kind, _requires));
        }

        bool IsIdentParen()
        {
            scanner.ResetPeek();
            Token x = scanner.Peek();
            return MutateCSharp.Schemata89.ReplaceBinExprOp_5(747L, () => IsIdentifier(la.kind), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(742L, x.kind, _openparen));
        }

        /* Used to disambiguate the LHS of a VarDeclStmt. If it looks like the start of a CasePattern,
         * we consider it to be a VarDeclPattern. But if we are looking at a simple identifier, then we
         * consider it to be a VarDeclStmt.
         */
        bool IsPatternDecl()
        {
            return MutateCSharp.Schemata89.ReplaceBinExprOp_2(758L, () => IsIdentParen(), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(753L, la.kind, _openparen));
        }

        bool IsIdentColonOrBar()
        {
            Token x = scanner.Peek();
            return MutateCSharp.Schemata89.ReplaceBinExprOp_5(780L, () => IsIdentifier(la.kind), () => (MutateCSharp.Schemata89.ReplaceBinExprOp_2(774L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(764L, x.kind, _colon), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(769L, x.kind, _verticalbar))));
        }

        bool SemiFollowsCall(bool allowLemma, Expression e)
        {
            return MutateCSharp.Schemata89.ReplaceBinExprOp_5(797L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_5(791L, () => allowLemma, () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(786L, la.kind, _semicolon)), () => e is ApplySuffix);
        }

        bool IsNotEndOfCase()
        {
            return MutateCSharp.Schemata89.ReplaceBinExprOp_5(824L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_5(813L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_8(803L, la.kind, _EOF), () => MutateCSharp.Schemata89.ReplaceBinExprOp_8(808L, la.kind, _rbrace)), () => MutateCSharp.Schemata89.ReplaceBinExprOp_8(819L, la.kind, _case));
        }

        /* The following is the largest lookahead there is. It needs to check if what follows
         * can be nothing but "<" Type { "," Type } ">".
         * If inExpressionContext == true, it also checks the token immediately after
         * the ">" to help disambiguate some cases (see implementation comment).   
         */
        bool IsGenericInstantiation(bool inExpressionContext)
        {
            scanner.ResetPeek();
            IToken pt = la;
            if (!IsTypeList(ref pt))
            {
                return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(830L, false);
            }
            if (!inExpressionContext)
            {
                return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(831L, true);
            }
            /* There are ambiguities in the parsing.  For example:
             *     F( a < b , c > (d) )
             * can either be a unary function F whose argument is a function "a" with type arguments "<b,c>" and
             * parameter "d", or can be a binary function F with the two boolean arguments "a < b" and "c > (d)".
             * To make the situation a little better, we (somewhat heuristically) look at the character that
             * follows the ">".  Note that if we, contrary to a user's intentions, pick "a<b,c>" out as a function
             * with a type instantiation, the user can disambiguate it by making sure the ">" sits inside some
             * parentheses, like:
             *     F( a < b , (c > (d)) )
             */
            // In the following cases, we're sure we must have read a type instantiation that just ended an expression
            if (MutateCSharp.Schemata89.ReplaceBinExprOp_2(850L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_2(844L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_2(838L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_2(832L, () => IsEquivOp(pt), () => IsImpliesOp(pt)), () => IsExpliesOp(pt)), () => IsAndOp(pt)), () => IsOrOp(pt)))
            {
                return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(856L, true);
            }
            switch (pt.kind)
            {
                case _dot:  // here, we're sure it must have been a type instantiation we saw, because an expression cannot begin with dot
                case _openparen:  // it was probably a type instantiation of a function/method
                case _lbracket:  // it is possible that it was a type instantiation
                case _lbrace:  // it was probably a type instantiation of a function/method
                case _at:
                // In the following cases, we're sure we must have read a type instantiation that just ended an expression
                case _closeparen:
                case _rbracket:
                case _rbrace:
                case _comma:
                case _semicolon:
                case _then:
                case _else:
                case _case:
                case _eq:
                case _neq:
                case _as:
                case _is:
                case _darrow:
                case _by:
                case _in:
                case _openAngleBracket:
                case _closeAngleBracket:
                case _EOF:
                // (specification clauses that can follow an expression)
                case _decreases:
                case _modifies:
                case _reads:
                case _requires:
                case _ensures:
                case _invariant:
                case _witness:
                // (top-level declarations that can follow an expression)
                case _function:
                case _predicate:
                case _least:
                case _greatest:
                case _inductive:
                case _twostate:
                case _lemma:
                case _copredicate:
                case _ghost:
                case _static:
                case _import:
                case _export:
                case _class:
                case _trait:
                case _datatype:
                case _codatatype:
                case _var:
                case _const:
                case _newtype:
                case _type:
                case _iterator:
                case _method:
                case _colemma:
                case _constructor:
                    return true;
                    break;
                default:
                    return false;
                    break;
            }

            return default;
        }
        /* Returns true if the next thing is of the form:
         *     "<" Type { "," Type } ">"
         */
        bool IsTypeList(ref IToken pt)
        {
            if (MutateCSharp.Schemata89.ReplaceBinExprOp_8(857L, pt.kind, _openAngleBracket))
            {
                return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(862L, false);
            }
            pt = scanner.Peek();
            return IsTypeSequence(ref pt, _closeAngleBracket);
        }
        /* Returns true if the next thing is of the form:
         *     [ "ghost" ] Type { "," [ "ghost" ] Type }
         * followed by an endBracketKind.
         */
        bool IsTypeSequence(ref IToken pt, int endBracketKind)
        {
            while (MutateCSharp.Schemata89.ReplaceBooleanConstant_0(863L, true))
            {
                if (MutateCSharp.Schemata89.ReplaceBinExprOp_1(864L, pt.kind, _ghost))
                {
                    pt = scanner.Peek();
                }
                if (!IsType(ref pt))
                {
                    return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(869L, false);
                }
                if (MutateCSharp.Schemata89.ReplaceBinExprOp_1(870L, pt.kind, endBracketKind))
                {
                    // end of type list
                    pt = scanner.Peek();
                    return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(875L, true);
                }
                else if (MutateCSharp.Schemata89.ReplaceBinExprOp_1(876L, pt.kind, _comma))
                {
                    // type list continues
                    pt = scanner.Peek();
                }
                else
                {
                    // not a type list
                    return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(881L, false);
                }
            }

            return default;
        }

        bool IsType(ref IToken pt)
        {
            if (!IsNonArrowType(ref pt))
            {
                return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(882L, false);
            }

            while (MutateCSharp.Schemata89.ReplaceBinExprOp_1(883L, pt.kind, _sarrow) || MutateCSharp.Schemata89.ReplaceBinExprOp_1(888L, pt.kind, _qarrow) || MutateCSharp.Schemata89.ReplaceBinExprOp_1(893L, pt.kind, _larrow))
            {
                pt = scanner.Peek();
                if (!IsNonArrowType(ref pt))
                {
                    return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(898L, false);
                }
            }
            return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(899L, true);
        }

        bool IsNonArrowType(ref IToken pt)
        {
            switch (pt.kind)
            {
                case _bool:
                case _char:
                case _nat:
                case _int:
                case _real:
                case _ORDINAL:
                case _string:
                case _object_q:
                case _object:
                    pt = scanner.Peek();
                    return true;
                    break;
                case _arrayToken:
                case _bvToken:
                case _set:
                case _iset:
                case _multiset:
                case _seq:
                case _map:
                case _imap:
                    pt = scanner.Peek();
                    return pt.kind != _openAngleBracket || IsTypeList(ref pt);
                    break;
                case _ident:
                case _least:
                case _greatest:
                    while (true)
                    {
                        // invariant: next token is an identifier (_ident, _least, or _greatest)
                        pt = scanner.Peek();
                        if (pt.kind == _openAngleBracket && !IsTypeList(ref pt))
                        {
                            return false;
                        }
                        if (pt.kind != _dot)
                        {
                            // end of the type
                            return true;
                        }
                        pt = scanner.Peek();  // get the _dot
                        if (!IsIdentifier(pt.kind))
                        {
                            return false;
                        }
                    }

                    break;
                case _openparen:
                    pt = scanner.Peek();
                    if (pt.kind == _closeparen)
                    {
                        // end of type list
                        pt = scanner.Peek();
                        return true;
                    }
                    return IsTypeSequence(ref pt, _closeparen);
                    break;
                default:
                    return false;
                    break;
            }

            return default;
        }


        void ConvertKeywordTokenToIdent()
        {
            var oldKind = la.kind;
            la.kind = _ident;

            // call CheckLiteral with la
            var origT = t;
            t = la;
            scanner.CheckLiteral();
            t = origT;

            if (MutateCSharp.Schemata89.ReplaceBinExprOp_8(900L, la.kind, _ident))
            {
                // it has been changed by CheckLiteral, which means it was a keyword
                la.kind = _ident;  // convert it to an ident
            }
            else
            {
                // la was something other than a keyword
                la.kind = oldKind;
            }
        }

        int StringToInt(string s, int defaultValue, string errString, IToken tok)
        {
            Contract.Requires(s != null);
            Contract.Requires(errString != null);
            try
            {
                if (MutateCSharp.Schemata89.ReplaceBinExprOp_13(905L, s, ""))
                {
                    defaultValue = int.Parse(s);
                }
            }
            catch (System.OverflowException)
            {
                SemErr(errString.Contains(MutateCSharp.Schemata89.ReplaceStringConstant_9(906L, "array")) ? ErrorId.p_array_dimension_too_large
                                                   : ErrorId.p_bitvector_too_large,
                  tok, string.Format(MutateCSharp.Schemata89.ReplaceStringConstant_9(907L, "sorry, {0} ({1}) are not supported"), errString, s));
            }
            return defaultValue;
        }

        readonly Expression/*!*/ dummyExpr;
        readonly AssignmentRhs/*!*/ dummyRhs;
        readonly FrameExpression/*!*/ dummyFrameExpr;
        readonly Statement/*!*/ dummyStmt;
        readonly Statement/*!*/ dummyIfStmt;
        public readonly FileModuleDefinition theModule;
        public readonly List<Action<SystemModuleManager>> SystemModuleModifiers = new();
        DafnyOptions theOptions;
        int anonymousIds = MutateCSharp.Schemata89.ReplaceNumericConstant_6(908L, 0);

        public
          /// <summary>
          /// Holds the modifiers given for a declaration
          ///
          /// Not all modifiers are applicable to all kinds of declarations.
          /// Errors are given when a modify does not apply.
          /// We also record the tokens for the specified modifiers so that
          /// they can be used in error messages.
          /// </summary>
          class DeclModifierData
        {
            public bool IsReplaceable;
            public IToken ReplaceableToken;
            public bool IsAbstract;
            public IToken AbstractToken;
            public bool IsGhost;
            public IToken GhostToken;
            public bool IsStatic;
            public IToken StaticToken;
            public bool IsOpaque;
            public IToken OpaqueToken;
            public IToken FirstToken;

        }

        private ModuleKindEnum GetModuleKind(DeclModifierData mods)
        {
            if (MutateCSharp.Schemata89.ReplaceBinExprOp_5(912L, () => mods.IsReplaceable, () => mods.IsAbstract))
            {
                SemErr(null, mods.ReplaceableToken, MutateCSharp.Schemata89.ReplaceStringConstant_9(918L, "Can't be both replaceable and abstract"));
            }

            if (mods.IsReplaceable)
            {
                return ModuleKindEnum.Replaceable;
            }
            if (mods.IsAbstract)
            {
                return ModuleKindEnum.Abstract;
            }

            return ModuleKindEnum.Concrete;
        }

        // Check that token has not been set, then set it.
        public void CheckAndSetToken(ref IToken token)
        {
            if (MutateCSharp.Schemata89.ReplaceBinExprOp_14(919L, token, null))
            {
                SemErr(ErrorId.p_duplicate_modifier, t, MutateCSharp.Schemata89.ReplaceStringConstant_9(920L, "Duplicate declaration modifier: ") + t.val);
            }
            token = t;
        }

        // Check that token has not been set, then set it, but just ignores if it was set already
        public void CheckAndSetTokenOnce(ref IToken token)
        {
            if (MutateCSharp.Schemata89.ReplaceBinExprOp_15(921L, token, null))
            {
                token = t;
            }
        }

        /// <summary>
        // A flags type used to tell what declaration modifiers are allowed for a declaration.
        /// </summary>
        [Flags]
        public enum AllowedDeclModifiers
        {
            None = 0,
            Abstract = 1,
            Ghost = 2,

            // Means ghost not allowed because already implicitly ghost.
            AlreadyGhost = 4,
            Static = 8,
            Opaque = 16,
            Replaceable = 32
        };

        bool CheckAttribute(Errors errors, IToken attr, RangeToken range)
        {
            // attr is the identifier of the Attribute
            // range is from opening brace to closing brace
            if (MutateCSharp.Schemata89.ReplaceBinExprOp_10(923L, attr.val, MutateCSharp.Schemata89.ReplaceStringConstant_9(922L, "ignore")))
            {
                errors.Warning(ErrorId.p_deprecated_attribute,
                  range,
                  $"attribute :{attr.val} is deprecated");
                return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(924L, false);
            }
            return MutateCSharp.Schemata89.ReplaceBooleanConstant_0(925L, true);
        }

        bool IsAssumeTypeKeyword(IToken la)
        {
            return MutateCSharp.Schemata89.ReplaceBinExprOp_2(947L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_2(936L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(926L, la.kind, _assume), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(931L, la.kind, _assert)), () => MutateCSharp.Schemata89.ReplaceBinExprOp_1(942L, la.kind, _expect));
        }

        public void ApplyOptionsFromAttributes(Attributes attrs)
        {
            var overrides = attrs.AsEnumerable().Where(a => MutateCSharp.Schemata89.ReplaceBinExprOp_10(954L, a.Name, MutateCSharp.Schemata89.ReplaceStringConstant_9(953L, "options")))
              .Reverse().Select(a =>
                (token: (a as UserSuppliedAttributes)?.tok,
                 options: a.Args.Select(arg =>
                 {
                     if (arg is not LiteralExpr { Value: string optStr })
                     {
                         SemErr(ErrorId.p_literal_string_required, arg.tok, MutateCSharp.Schemata89.ReplaceStringConstant_9(955L, "argument to :options attribute must be a literal string"));
                         return null;
                     }
                     return optStr;
                 }).Where(opt => opt != null).ToArray()))
              .Where(opts => opts.options.Any());

            if (overrides.Any())
            {
                var options = new DafnyAttributeOptions(theOptions, errors);
                foreach (var (token, opts) in overrides)
                {

                    var newOptionsCommand = new RootCommand();
                    newOptionsCommand.AddOption(CommonOptionBag.QuantifierSyntax);
                    newOptionsCommand.AddOption(Function.FunctionSyntaxOption);
                    var result = newOptionsCommand.Parse(string.Join(' ', opts));

                    if (!result.Errors.Any())
                    {
                        foreach (var option in newOptionsCommand.Options)
                        {
                            var value = result.GetValueForOption(option);
                            options.Options.OptionArguments[option] = value;
                            options.ApplyBinding(option);
                        }
                        continue;
                    }

                    options.Token = token;
                    options.Parse(opts);
                }
                theOptions = options;
            }
        }

        /// <summary>
        /// Check the declaration modifiers against those that are allowed.
        ///
        /// The 'allowed' parameter specifies which declaration modifiers are allowed.
        /// The 'declCaption' parameter should be a string describing the kind of declaration.
        /// It is used in error messages.
        /// Any declaration modifiers that are present but not allowed are cleared.
        ///</summary>
        void CheckDeclModifiers(ref DeclModifierData dmod, string declCaption, AllowedDeclModifiers allowed)
        {
            declCaption = (MutateCSharp.Schemata89.ReplaceBinExprOp_2(958L, () => declCaption.StartsWith(MutateCSharp.Schemata89.ReplaceStringConstant_9(956L, "i")), () => declCaption.StartsWith(MutateCSharp.Schemata89.ReplaceStringConstant_9(957L, "o"))) ? MutateCSharp.Schemata89.ReplaceStringConstant_9(964L, "an ") : MutateCSharp.Schemata89.ReplaceStringConstant_9(965L, "a ")) + declCaption;
            if (dmod.IsAbstract && ((allowed & AllowedDeclModifiers.Abstract) == 0))
            {
                SemErr(ErrorId.p_abstract_not_allowed, dmod.AbstractToken, $"{declCaption} cannot be declared 'abstract'");
                dmod.IsAbstract = MutateCSharp.Schemata89.ReplaceBooleanConstant_0(966L, false);
            }
            if (dmod.IsReplaceable && ((allowed & AllowedDeclModifiers.Replaceable) == 0))
            {
                SemErr(ErrorId.p_abstract_not_allowed, dmod.ReplaceableToken, $"{declCaption} cannot be declared 'replaceable'");
                dmod.IsReplaceable = MutateCSharp.Schemata89.ReplaceBooleanConstant_0(967L, false);
            }
            if (dmod.IsGhost)
            {
                if ((allowed & AllowedDeclModifiers.AlreadyGhost) != 0)
                {
                    if (declCaption.Contains(MutateCSharp.Schemata89.ReplaceStringConstant_9(968L, "-by-method")))
                    {
                        SemErr(ErrorId.p_no_ghost_for_by_method, dmod.GhostToken,
                          $"{declCaption} has a ghost function body and a non-ghost method body; {declCaption} declaration does not use the 'ghost' keyword.");
                    }
                    else if (MutateCSharp.Schemata89.ReplaceBinExprOp_2(973L, () => MutateCSharp.Schemata89.ReplaceBinExprOp_10(970L, declCaption, MutateCSharp.Schemata89.ReplaceStringConstant_9(969L, "a function")), () => MutateCSharp.Schemata89.ReplaceBinExprOp_10(972L, declCaption, MutateCSharp.Schemata89.ReplaceStringConstant_9(971L, "a predicate"))))
                    {
                        SemErr(ErrorId.p_ghost_forbidden_default_3, dmod.GhostToken, $"{declCaption} cannot be declared 'ghost' (it is 'ghost' by default when using --function-syntax:3)");
                    }
                    else
                    {
                        SemErr(ErrorId.p_ghost_forbidden_default, dmod.GhostToken, $"{declCaption} cannot be declared 'ghost' (it is 'ghost' by default)");
                    }
                    dmod.IsGhost = MutateCSharp.Schemata89.ReplaceBooleanConstant_0(979L, false);
                }
                else if ((allowed & AllowedDeclModifiers.Ghost) == 0)
                {
                    SemErr(ErrorId.p_ghost_forbidden, dmod.GhostToken, $"{declCaption} cannot be declared 'ghost'");
                    dmod.IsGhost = MutateCSharp.Schemata89.ReplaceBooleanConstant_0(980L, false);
                }
            }
            if (dmod.IsStatic && ((allowed & AllowedDeclModifiers.Static) == 0))
            {
                SemErr(ErrorId.p_no_static, dmod.StaticToken, $"{declCaption} cannot be declared 'static'");
                dmod.IsStatic = MutateCSharp.Schemata89.ReplaceBooleanConstant_0(981L, false);
            }
            if (dmod.IsOpaque && ((allowed & AllowedDeclModifiers.Opaque) == 0))
            {
                SemErr(ErrorId.p_no_opaque, dmod.OpaqueToken, $"{declCaption} cannot be declared 'opaque'");
                dmod.IsOpaque = MutateCSharp.Schemata89.ReplaceBooleanConstant_0(982L, false);
            }
        }

    }
}