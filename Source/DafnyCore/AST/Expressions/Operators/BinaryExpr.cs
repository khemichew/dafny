using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata58
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT58");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument1, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_6(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBooleanConstant_10(long mutantId, bool argument1)
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

        internal static bool ReplaceBinExprOp_9(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_5(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
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

        internal static bool ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class BinaryExpr : Expression, ICloneable<BinaryExpr>, ICanFormat
    {
        public enum Opcode
        {
            Iff,
            Imp,
            Exp, // turned into Imp during resolution
            And,
            Or,
            Eq,
            Neq,
            Lt,
            Le,
            Ge,
            Gt,
            Disjoint,
            In,
            NotIn,
            LeftShift,
            RightShift,
            Add,
            Sub,
            Mul,
            Div,
            Mod,
            BitwiseAnd,
            BitwiseOr,
            BitwiseXor
        }
        public readonly Opcode Op;
        public enum ResolvedOpcode
        {
            YetUndetermined,  // the value before resolution has determined the value; .ResolvedOp should never be read in this state

            // logical operators
            Iff,
            Imp,
            And,
            Or,
            // non-collection types
            EqCommon,
            NeqCommon,
            // integers, reals, bitvectors
            Lt,
            LessThanLimit,  // a synonym for Lt for ORDINAL, used only during translation
            Le,
            Ge,
            Gt,
            Add, // also used for char
            Sub, // also used for char
            Mul,
            Div,
            Mod,
            // bitvectors
            LeftShift,
            RightShift,
            BitwiseAnd,
            BitwiseOr,
            BitwiseXor,
            // char
            LtChar,
            LeChar,
            GeChar,
            GtChar,
            // sets
            SetEq,
            SetNeq,
            ProperSubset,
            Subset,
            Superset,
            ProperSuperset,
            Disjoint,
            InSet,
            NotInSet,
            Union,
            Intersection,
            SetDifference,
            // multi-sets
            MultiSetEq,
            MultiSetNeq,
            MultiSubset,
            MultiSuperset,
            ProperMultiSubset,
            ProperMultiSuperset,
            MultiSetDisjoint,
            InMultiSet,
            NotInMultiSet,
            MultiSetUnion,
            MultiSetIntersection,
            MultiSetDifference,
            // Sequences
            SeqEq,
            SeqNeq,
            ProperPrefix,
            Prefix,
            Concat,
            InSeq,
            NotInSeq,
            // Maps
            MapEq,
            MapNeq,
            InMap,
            NotInMap,
            MapMerge,
            MapSubtraction,
            // datatypes
            RankLt,
            RankGt
        }
        private ResolvedOpcode _theResolvedOp = ResolvedOpcode.YetUndetermined;
        public ResolvedOpcode ResolvedOp
        {
            set
            {
                Contract.Assume(_theResolvedOp == ResolvedOpcode.YetUndetermined || _theResolvedOp == value);  // there's never a reason for resolution to change its mind, is there?
                _theResolvedOp = value;
            }
            get
            {
                Debug.Assert(MutateCSharp.Schemata58.ReplaceBinExprOp_0(1L, _theResolvedOp, ResolvedOpcode.YetUndetermined));  // shouldn't read it until it has been properly initialized
                return _theResolvedOp;
            }
        }

        public ResolvedOpcode ResolvedOp_PossiblyStillUndetermined
        {
            get { return _theResolvedOp; }
        }

        public static bool IsEqualityOp(ResolvedOpcode op)
        {
            switch (op)
            {
                case ResolvedOpcode.EqCommon:
                case ResolvedOpcode.SetEq:
                case ResolvedOpcode.SeqEq:
                case ResolvedOpcode.MultiSetEq:
                case ResolvedOpcode.MapEq:
                    return true;
                    break;
                default:
                    return false;
                    break;
            }

            return default;
        }

        public static Opcode ResolvedOp2SyntacticOp(ResolvedOpcode rop)
        {
            switch (rop)
            {
                case ResolvedOpcode.Iff:
                    return Opcode.Iff;
                    break;
                case ResolvedOpcode.Imp:
                    return Opcode.Imp;
                    break;
                case ResolvedOpcode.And:
                    return Opcode.And;
                    break;
                case ResolvedOpcode.Or:
                    return Opcode.Or;
                    break;
                case ResolvedOpcode.EqCommon:
                case ResolvedOpcode.SetEq:
                case ResolvedOpcode.MultiSetEq:
                case ResolvedOpcode.SeqEq:
                case ResolvedOpcode.MapEq:
                    return Opcode.Eq;
                    break;
                case ResolvedOpcode.NeqCommon:
                case ResolvedOpcode.SetNeq:
                case ResolvedOpcode.MultiSetNeq:
                case ResolvedOpcode.SeqNeq:
                case ResolvedOpcode.MapNeq:
                    return Opcode.Neq;
                    break;
                case ResolvedOpcode.Lt:
                case ResolvedOpcode.LtChar:
                case ResolvedOpcode.ProperSubset:
                case ResolvedOpcode.ProperMultiSuperset:
                case ResolvedOpcode.ProperPrefix:
                case ResolvedOpcode.RankLt:
                    return Opcode.Lt;
                    break;
                case ResolvedOpcode.Le:
                case ResolvedOpcode.LeChar:
                case ResolvedOpcode.Subset:
                case ResolvedOpcode.MultiSubset:
                case ResolvedOpcode.Prefix:
                    return Opcode.Le;
                    break;
                case ResolvedOpcode.Ge:
                case ResolvedOpcode.GeChar:
                case ResolvedOpcode.Superset:
                case ResolvedOpcode.MultiSuperset:
                    return Opcode.Ge;
                    break;
                case ResolvedOpcode.Gt:
                case ResolvedOpcode.GtChar:
                case ResolvedOpcode.ProperSuperset:
                case ResolvedOpcode.ProperMultiSubset:
                case ResolvedOpcode.RankGt:
                    return Opcode.Gt;
                    break;
                case ResolvedOpcode.LeftShift:
                    return Opcode.LeftShift;
                    break;
                case ResolvedOpcode.RightShift:
                    return Opcode.RightShift;
                    break;
                case ResolvedOpcode.Add:
                case ResolvedOpcode.Union:
                case ResolvedOpcode.MultiSetUnion:
                case ResolvedOpcode.MapMerge:
                case ResolvedOpcode.Concat:
                    return Opcode.Add;
                    break;
                case ResolvedOpcode.Sub:
                case ResolvedOpcode.SetDifference:
                case ResolvedOpcode.MultiSetDifference:
                case ResolvedOpcode.MapSubtraction:
                    return Opcode.Sub;
                    break;
                case ResolvedOpcode.Mul:
                case ResolvedOpcode.Intersection:
                case ResolvedOpcode.MultiSetIntersection:
                    return Opcode.Mul;
                    break;
                case ResolvedOpcode.Div:
                    return Opcode.Div;
                    break;
                case ResolvedOpcode.Mod:
                    return Opcode.Mod;
                    break;
                case ResolvedOpcode.BitwiseAnd:
                    return Opcode.BitwiseAnd;
                    break;
                case ResolvedOpcode.BitwiseOr:
                    return Opcode.BitwiseOr;
                    break;
                case ResolvedOpcode.BitwiseXor:
                    return Opcode.BitwiseXor;
                    break;
                case ResolvedOpcode.Disjoint:
                case ResolvedOpcode.MultiSetDisjoint:
                    return Opcode.Disjoint;
                    break;
                case ResolvedOpcode.InSet:
                case ResolvedOpcode.InMultiSet:
                case ResolvedOpcode.InSeq:
                case ResolvedOpcode.InMap:
                    return Opcode.In;
                    break;
                case ResolvedOpcode.NotInSet:
                case ResolvedOpcode.NotInMultiSet:
                case ResolvedOpcode.NotInSeq:
                case ResolvedOpcode.NotInMap:
                    return Opcode.NotIn;
                    break;
                case ResolvedOpcode.LessThanLimit:  // not expected here (but if it were, the same case as Lt could perhaps be used)
                default:
                    Contract.Assert(false);  // unexpected ResolvedOpcode
                    return Opcode.Add;  // please compiler
                    break;
            }

            return default;
        }

        public static string OpcodeString(Opcode op)
        {
            Contract.Ensures(Contract.Result<string>() != null);

            switch (op)
            {
                case Opcode.Iff:
                    return "<==>";
                    break;
                case Opcode.Imp:
                    return "==>";
                    break;
                case Opcode.Exp:
                    return "<==";
                    break;
                case Opcode.And:
                    return "&&";
                    break;
                case Opcode.Or:
                    return "||";
                    break;
                case Opcode.Eq:
                    return "==";
                    break;
                case Opcode.Lt:
                    return "<";
                    break;
                case Opcode.Gt:
                    return ">";
                    break;
                case Opcode.Le:
                    return "<=";
                    break;
                case Opcode.Ge:
                    return ">=";
                    break;
                case Opcode.Neq:
                    return "!=";
                    break;
                case Opcode.Disjoint:
                    return "!!";
                    break;
                case Opcode.In:
                    return "in";
                    break;
                case Opcode.NotIn:
                    return "!in";
                    break;
                case Opcode.LeftShift:
                    return "<<";
                    break;
                case Opcode.RightShift:
                    return ">>";
                    break;
                case Opcode.Add:
                    return "+";
                    break;
                case Opcode.Sub:
                    return "-";
                    break;
                case Opcode.Mul:
                    return "*";
                    break;
                case Opcode.Div:
                    return "/";
                    break;
                case Opcode.Mod:
                    return "%";
                    break;
                case Opcode.BitwiseAnd:
                    return "&";
                    break;
                case Opcode.BitwiseOr:
                    return "|";
                    break;
                case Opcode.BitwiseXor:
                    return "^";
                    break;
                default:
                    Contract.Assert(false);
                    throw new cce.UnreachableException();  // unexpected operator
                    break;
            }

            return default;
        }
        public Expression E0;
        public Expression E1;
        public enum AccumulationOperand { None, Left, Right }
        public AccumulationOperand AccumulatesForTailRecursion = AccumulationOperand.None; // set by Resolver
        [FilledInDuringResolution] public bool InCompiledContext;

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(E0 != null);
            Contract.Invariant(E1 != null);
        }

        public BinaryExpr Clone(Cloner cloner)
        {
            return new BinaryExpr(cloner, this);
        }

        public BinaryExpr(Cloner cloner, BinaryExpr original) : base(cloner, original)
        {
            this.Op = original.Op;
            this.E0 = cloner.CloneExpr(original.E0);
            this.E1 = cloner.CloneExpr(original.E1);

            if (cloner.CloneResolvedFields)
            {
                ResolvedOp = original.ResolvedOp;
            }
        }

        public BinaryExpr(IToken tok, Opcode op, Expression e0, Expression e1)
          :
          base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(e0 != null);
            Contract.Requires(e1 != null);
            this.Op = op;
            this.E0 = e0;
            this.E1 = e1;
        }

        /// <summary>
        /// Returns a resolved binary expression
        /// </summary>
        public BinaryExpr(IToken tok, BinaryExpr.ResolvedOpcode rop, Expression e0, Expression e1)
          : this(tok, BinaryExpr.ResolvedOp2SyntacticOp(rop), e0, e1)
        {
            ResolvedOp = rop;
            switch (rop)
            {
                case ResolvedOpcode.EqCommon:
                case ResolvedOpcode.NeqCommon:
                case ResolvedOpcode.Lt:
                case ResolvedOpcode.LessThanLimit:
                case ResolvedOpcode.Le:
                case ResolvedOpcode.Ge:
                case ResolvedOpcode.Gt:
                case ResolvedOpcode.LtChar:
                case ResolvedOpcode.LeChar:
                case ResolvedOpcode.GeChar:
                case ResolvedOpcode.GtChar:
                case ResolvedOpcode.SetEq:
                case ResolvedOpcode.SetNeq:
                case ResolvedOpcode.ProperSubset:
                case ResolvedOpcode.Subset:
                case ResolvedOpcode.Superset:
                case ResolvedOpcode.ProperSuperset:
                case ResolvedOpcode.Disjoint:
                case ResolvedOpcode.InSet:
                case ResolvedOpcode.NotInSet:
                case ResolvedOpcode.MultiSetEq:
                case ResolvedOpcode.MultiSetNeq:
                case ResolvedOpcode.MultiSubset:
                case ResolvedOpcode.MultiSuperset:
                case ResolvedOpcode.ProperMultiSubset:
                case ResolvedOpcode.ProperMultiSuperset:
                case ResolvedOpcode.MultiSetDisjoint:
                case ResolvedOpcode.InMultiSet:
                case ResolvedOpcode.NotInMultiSet:
                case ResolvedOpcode.SeqEq:
                case ResolvedOpcode.SeqNeq:
                case ResolvedOpcode.ProperPrefix:
                case ResolvedOpcode.Prefix:
                case ResolvedOpcode.InSeq:
                case ResolvedOpcode.NotInSeq:
                case ResolvedOpcode.MapEq:
                case ResolvedOpcode.MapNeq:
                case ResolvedOpcode.InMap:
                case ResolvedOpcode.NotInMap:
                case ResolvedOpcode.RankLt:
                case ResolvedOpcode.RankGt:
                    Type = Type.Bool;
                    break;
                    break;
                default:
                    Type = e0.Type;
                    break;
                    break;
            }
        }

        public override IEnumerable<Expression> SubExpressions
        {
            get
            {
                yield return E0;
                yield return E1;
            }
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            var indent = indentBefore;
            if (Op is Opcode.And or Opcode.Or)
            {
                var ownedTokens = OwnedTokens.ToList();
                // Alignment required.
                if (MutateCSharp.Schemata58.ReplaceBinExprOp_2(6L, ownedTokens.Count, MutateCSharp.Schemata58.ReplaceNumericConstant_1(2L, 2)))
                {
                    var firstToken = ownedTokens[MutateCSharp.Schemata58.ReplaceNumericConstant_1(11L, 0)];
                    var secondToken = ownedTokens[MutateCSharp.Schemata58.ReplaceNumericConstant_1(15L, 1)];
                    indent = formatter.GetNewTokenVisualIndent(firstToken, formatter.GetIndentInlineOrAbove(firstToken));
                    var c = MutateCSharp.Schemata58.ReplaceNumericConstant_1(19L, 0);
                    while (MutateCSharp.Schemata58.ReplaceBinExprOp_4(33L, () => MutateCSharp.Schemata58.ReplaceBinExprOp_3(23L, c, firstToken.TrailingTrivia.Length), () => MutateCSharp.Schemata58.ReplaceBinExprOp_2(28L, firstToken.TrailingTrivia[c], ' ')))
                    {
                        MutateCSharp.Schemata58.ReplacePostfixUnaryExprOp_5(39L, ref c);
                    }

                    var conjunctExtraIndent = MutateCSharp.Schemata58.ReplaceBinExprOp_6(40L, c, formatter.SpaceTab);
                    formatter.binOpIndent = indent;
                    formatter.binOpArgIndent = MutateCSharp.Schemata58.ReplaceBinExprOp_6(49L, indent, conjunctExtraIndent);
                    formatter.SetIndentations(firstToken, formatter.binOpIndent, formatter.binOpIndent, formatter.binOpArgIndent);
                    formatter.SetIndentations(secondToken, formatter.binOpIndent, formatter.binOpIndent, formatter.binOpArgIndent);
                }
                else if (MutateCSharp.Schemata58.ReplaceBinExprOp_7(62L, ownedTokens.Count, MutateCSharp.Schemata58.ReplaceNumericConstant_1(58L, 0)))
                {
                    if (MutateCSharp.Schemata58.ReplaceBinExprOp_9(72L, ownedTokens[MutateCSharp.Schemata58.ReplaceNumericConstant_1(67L, 0)].val, MutateCSharp.Schemata58.ReplaceStringConstant_8(71L, "requires")))
                    { // Requirement conjunctions inside lambdas are separated by the keyword "requires"
                        if (MutateCSharp.Schemata58.ReplaceBinExprOp_9(74L, this.StartToken.Prev.val, MutateCSharp.Schemata58.ReplaceStringConstant_8(73L, "requires")))
                        {
                            formatter.binOpIndent = formatter.GetIndentInlineOrAbove(this.StartToken.Prev);
                        }
                    }
                    if (MutateCSharp.Schemata58.ReplaceBinExprOp_7(79L, formatter.binOpIndent, MutateCSharp.Schemata58.ReplaceNumericConstant_1(75L, 0)))
                    {
                        formatter.SetIndentations(ownedTokens[MutateCSharp.Schemata58.ReplaceNumericConstant_1(84L, 0)], formatter.binOpIndent, formatter.binOpIndent, formatter.binOpArgIndent);
                    }
                    else
                    {
                        var startToken = this.StartToken;
                        //"," in a comprehension is an "&&", except that it should not try to keep a visual indentation between components.
                        var newIndent = MutateCSharp.Schemata58.ReplaceBinExprOp_9(93L, ownedTokens[MutateCSharp.Schemata58.ReplaceNumericConstant_1(88L, 0)].val, MutateCSharp.Schemata58.ReplaceStringConstant_8(92L, ",")) ?
                            formatter.GetIndentInlineOrAbove(startToken)
                            : formatter.GetNewTokenVisualIndent(startToken, formatter.GetIndentInlineOrAbove(startToken));
                        formatter.SetIndentations(ownedTokens[MutateCSharp.Schemata58.ReplaceNumericConstant_1(94L, 0)], newIndent, newIndent, newIndent);
                    }
                }

                if (MutateCSharp.Schemata58.ReplaceBinExprOp_7(102L, formatter.binOpIndent, MutateCSharp.Schemata58.ReplaceNumericConstant_1(98L, 0)) && (this.E0 is not BinaryExpr { Op: var op } || op != this.Op))
                {
                    formatter.binOpIndent = MutateCSharp.Schemata58.ReplaceNumericConstant_1(107L, -1);
                    formatter.binOpArgIndent = MutateCSharp.Schemata58.ReplaceNumericConstant_1(111L, -1);
                }

                return MutateCSharp.Schemata58.ReplaceBooleanConstant_10(115L, true); // Default indentation
            }
            else if (Op is Opcode.Imp or Opcode.Exp)
            {
                foreach (var token in this.OwnedTokens)
                {
                    switch (token.val)
                    {
                        case "==>":
                            {
                                formatter.SetOpeningIndentedRegion(token, indent);
                                break;
                            }

                            break;
                        case "<==":
                            {
                                formatter.SetIndentations(token, indent, indent, indent);
                                break;
                            }

                            break;
                    }
                }
                formatter.Visit(this.E0, indent);
                formatter.Visit(this.E1, this.Op is BinaryExpr.Opcode.Exp ? indent : MutateCSharp.Schemata58.ReplaceBinExprOp_6(116L, indent, formatter.SpaceTab));
                formatter.SetIndentations(this.EndToken, below: indent);
                return MutateCSharp.Schemata58.ReplaceBooleanConstant_10(125L, false);
            }
            else if (Op is Opcode.Eq or Opcode.Le or Opcode.Lt or Opcode.Ge or Opcode.Gt or Opcode.Iff or Opcode.Neq)
            {
                var itemIndent = formatter.GetNewTokenVisualIndent(
                  E0.StartToken, indent);
                var item2Indent = itemIndent;
                var startToken = this.E0.StartToken;
                if (MutateCSharp.Schemata58.ReplaceBinExprOp_2(126L, startToken.Prev.line, startToken.line))
                {
                    // like assert E0
                    //          == E1
                    // Careful: The binaryExpr.op's first column should be greater than the
                    // token's first column before E0.StartToken. 
                    foreach (var token in this.OwnedTokens)
                    {
                        switch (token.val)
                        {
                            case "==":
                            case "<=":
                            case "<":
                            case ">=":
                            case ">":
                            case "<==>":
                            case "!=":
                                {
                                    var followedByNewline = TokenNewIndentCollector.IsFollowedByNewline(token);
                                    var selfIndent = followedByNewline ? itemIndent : Math.Max(itemIndent - token.val.Length - 1, 0);
                                    if (selfIndent <= formatter.GetNewTokenVisualIndent(startToken.Prev, itemIndent))
                                    {
                                        // There could be a visual ambiguity if this token is aligned with the enclosing token.
                                        selfIndent = itemIndent;
                                    }
                                    formatter.SetIndentations(token, itemIndent, selfIndent);
                                    item2Indent = followedByNewline ? itemIndent : formatter.GetNewTokenVisualIndent(this.E1.StartToken, itemIndent);
                                    formatter.SetIndentations(token, below: item2Indent);
                                    break;
                                }

                                break;
                        }
                    }
                }
                formatter.Visit(E0, itemIndent);
                formatter.Visit(E1, item2Indent);
                formatter.SetIndentations(EndToken, below: indent);
                return MutateCSharp.Schemata58.ReplaceBooleanConstant_10(131L, false);
            }
            else if (Op is Opcode.In or Opcode.NotIn)
            {
                var itemIndent = formatter.GetNewTokenVisualIndent(
                  E0.StartToken, indent);
                var item2Indent = MutateCSharp.Schemata58.ReplaceBinExprOp_6(132L, itemIndent, formatter.SpaceTab);
                formatter.Visit(E0, itemIndent);
                foreach (var token in this.OwnedTokens)
                {
                    switch (token.val)
                    {
                        case "<":
                            {
                                if (token.Prev.line != token.line)
                                {
                                    itemIndent = formatter.GetNewTokenVisualIndent(token, indent);
                                }

                                break;
                            }

                            break;
                        case "in":
                        case "-":
                            {
                                if (TokenNewIndentCollector.IsFollowedByNewline(token))
                                {
                                    formatter.SetOpeningIndentedRegion(token, itemIndent);
                                }
                                else
                                {
                                    formatter.SetAlign(itemIndent, token, out item2Indent, out _);
                                }
                                break;
                            }

                            break;
                    }
                }
                formatter.Visit(E1, item2Indent);
                return MutateCSharp.Schemata58.ReplaceBooleanConstant_10(141L, false);
            }
            else
            {
                foreach (var token in OwnedTokens)
                {
                    formatter.SetIndentations(token, indent, indent, indent);
                }
                formatter.Visit(E0, indent);
                formatter.Visit(E1, indent);
                formatter.SetIndentations(EndToken, below: indent);
                return MutateCSharp.Schemata58.ReplaceBooleanConstant_10(142L, false);
            }

            return default;
        }
    }
}