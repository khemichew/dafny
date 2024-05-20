using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata193
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT193");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplacePostfixUnaryExprOp_8(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
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

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static int ReplaceNumericConstant_4(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class IteratorDecl : ClassDecl, IMethodCodeContext, ICanVerify
    {
        public override string WhatKind
        {
            get { return MutateCSharp.Schemata193.ReplaceStringConstant_0(1L, "iterator"); }
        }

        public readonly List<Formal> Ins;
        public readonly List<Formal> Outs;
        public readonly Specification<FrameExpression> Reads;
        public readonly Specification<FrameExpression> Modifies;
        public readonly Specification<Expression> Decreases;
        public readonly List<AttributedExpression> Requires;
        public readonly List<AttributedExpression> Ensures;
        public readonly List<AttributedExpression> YieldRequires;
        public readonly List<AttributedExpression> YieldEnsures;
        public readonly BlockStmt Body;
        public bool SignatureIsOmitted
        {
            get { return MutateCSharp.Schemata193.ReplaceBinExprOp_1(2L, SignatureEllipsis, null); }
        }

        public readonly IToken SignatureEllipsis;
        public readonly List<Field> OutsFields;
        public readonly List<Field> OutsHistoryFields;  // these are the 'xs' variables
        [FilledInDuringResolution] public readonly List<Field> DecreasesFields;
        [FilledInDuringResolution] public SpecialField Member_Modifies;
        [FilledInDuringResolution] public SpecialField Member_Reads;
        [FilledInDuringResolution] public SpecialField Member_New;
        [FilledInDuringResolution] public Constructor Member_Init;  // created during registration phase of resolution;
        [FilledInDuringResolution] public Predicate Member_Valid;  // created during registration phase of resolution;
        [FilledInDuringResolution] public Method Member_MoveNext;  // created during registration phase of resolution;
        public readonly LocalVariable YieldCountVariable;

        public IteratorDecl(RangeToken rangeToken, Name name, ModuleDefinition module, List<TypeParameter> typeArgs,
          List<Formal> ins, List<Formal> outs,
          Specification<FrameExpression> reads, Specification<FrameExpression> mod, Specification<Expression> decreases,
          List<AttributedExpression> requires,
          List<AttributedExpression> ensures,
          List<AttributedExpression> yieldRequires,
          List<AttributedExpression> yieldEnsures,
          BlockStmt body, Attributes attributes, IToken signatureEllipsis)
          : base(rangeToken, name, module, typeArgs, new List<MemberDecl>(), attributes, MutateCSharp.Schemata193.ReplaceBinExprOp_1(3L, signatureEllipsis, null), null)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(module != null);
            Contract.Requires(typeArgs != null);
            Contract.Requires(ins != null);
            Contract.Requires(outs != null);
            Contract.Requires(reads != null);
            Contract.Requires(mod != null);
            Contract.Requires(decreases != null);
            Contract.Requires(requires != null);
            Contract.Requires(ensures != null);
            Contract.Requires(yieldRequires != null);
            Contract.Requires(yieldEnsures != null);
            Ins = ins;
            Outs = outs;
            Reads = reads;
            Modifies = mod;
            Decreases = decreases;
            Requires = requires;
            Ensures = ensures;
            YieldRequires = yieldRequires;
            YieldEnsures = yieldEnsures;
            Body = body;
            SignatureEllipsis = signatureEllipsis;

            OutsFields = new List<Field>();
            OutsHistoryFields = new List<Field>();
            DecreasesFields = new List<Field>();

            YieldCountVariable = new LocalVariable(rangeToken, MutateCSharp.Schemata193.ReplaceStringConstant_0(4L, "_yieldCount"), new EverIncreasingType(), MutateCSharp.Schemata193.ReplaceBooleanConstant_2(5L, true));
            YieldCountVariable.type = YieldCountVariable.OptionalType;  // resolve YieldCountVariable here
        }

        /// <summary>
        /// Returns the non-null expressions of this declaration proper (that is, do not include the expressions of substatements).
        /// Does not include the generated class members.
        /// </summary>
        public virtual IEnumerable<Expression> SubExpressions
        {
            get
            {
                foreach (var e in Attributes.SubExpressions(Attributes))
                {
                    yield return e;
                }
                foreach (var e in Attributes.SubExpressions(Reads.Attributes))
                {
                    yield return e;
                }
                foreach (var e in Reads.Expressions)
                {
                    yield return e.E;
                }
                foreach (var e in Attributes.SubExpressions(Modifies.Attributes))
                {
                    yield return e;
                }
                foreach (var e in Modifies.Expressions)
                {
                    yield return e.E;
                }
                foreach (var e in Attributes.SubExpressions(Decreases.Attributes))
                {
                    yield return e;
                }
                foreach (var e in Decreases.Expressions)
                {
                    yield return e;
                }
                foreach (var e in Requires)
                {
                    yield return e.E;
                }
                foreach (var e in Ensures)
                {
                    yield return e.E;
                }
                foreach (var e in YieldRequires)
                {
                    yield return e.E;
                }
                foreach (var e in YieldEnsures)
                {
                    yield return e.E;
                }

                yield break;
            }
        }

        /// <summary>
        /// This Dafny type exists only for the purpose of giving the yield-count variable a type, so
        /// that the type can be recognized during translation of Dafny into Boogie.  It represents
        /// an integer component in a "decreases" clause whose order is (\lambda x,y :: x GREATER y),
        /// not the usual (\lambda x,y :: x LESS y AND 0 ATMOST y).
        /// </summary>
        public class EverIncreasingType : BasicType
        {
            [Pure]
            public override string TypeName(DafnyOptions options, ModuleDefinition context, bool parseAble)
            {
                Contract.Assert(parseAble == false);

                return MutateCSharp.Schemata193.ReplaceStringConstant_0(6L, "_increasingInt");
            }
            public override bool Equals(Type that, bool keepConstraints = false)
            {
                return that.NormalizeExpand(keepConstraints) is EverIncreasingType;
            }
        }

        bool ICodeContext.IsGhost
        {
            get { return MutateCSharp.Schemata193.ReplaceBooleanConstant_2(7L, false); }
        }

        List<TypeParameter> ICodeContext.TypeArgs
        {
            get { return this.TypeArgs; }
        }

        List<Formal> ICodeContext.Ins
        {
            get { return this.Ins; }
        }

        List<Formal> IMethodCodeContext.Outs
        {
            get { return this.Outs; }
        }

        Specification<FrameExpression> IMethodCodeContext.Modifies
        {
            get { return this.Modifies; }
        }

        string ICallable.NameRelativeToModule
        {
            get { return this.Name; }
        }

        Specification<Expression> ICallable.Decreases
        {
            get { return this.Decreases; }
        }

        bool _inferredDecr;
        bool ICallable.InferredDecreases
        {
            set { _inferredDecr = value; }
            get { return _inferredDecr; }
        }

        ModuleDefinition IASTVisitorContext.EnclosingModule
        {
            get { return this.EnclosingModuleDefinition; }
        }

        bool ICodeContext.MustReverify
        {
            get { return MutateCSharp.Schemata193.ReplaceBooleanConstant_2(8L, false); }
        }

        public bool AllowsNontermination
        {
            get
            {
                return Contract.Exists(Decreases.Expressions, e => e is WildcardExpr);
            }
        }

        public override bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            formatter.SetMethodLikeIndent(StartToken, OwnedTokens, indentBefore);
            foreach (var req in Requires)
            {
                formatter.SetAttributedExpressionIndentation(req, MutateCSharp.Schemata193.ReplaceBinExprOp_3(9L, indentBefore, formatter.SpaceTab));
            }

            foreach (var req in Ensures)
            {
                formatter.SetAttributedExpressionIndentation(req, MutateCSharp.Schemata193.ReplaceBinExprOp_3(18L, indentBefore, formatter.SpaceTab));
            }

            foreach (var req in YieldRequires)
            {
                formatter.SetAttributedExpressionIndentation(req, MutateCSharp.Schemata193.ReplaceBinExprOp_3(27L, indentBefore, formatter.SpaceTab));
            }

            foreach (var req in YieldEnsures)
            {
                formatter.SetAttributedExpressionIndentation(req, MutateCSharp.Schemata193.ReplaceBinExprOp_3(36L, indentBefore, formatter.SpaceTab));
            }

            formatter.SetFormalsIndentation(Ins);
            formatter.SetFormalsIndentation(Outs);
            if (MutateCSharp.Schemata193.ReplaceBinExprOp_5(49L, this.BodyStartTok.line, MutateCSharp.Schemata193.ReplaceNumericConstant_4(45L, 0)))
            {
                formatter.SetDelimiterIndentedRegions(this.BodyStartTok, indentBefore);
                formatter.SetClosingIndentedRegion(Token.NoToken, indentBefore);
            }

            if (MutateCSharp.Schemata193.ReplaceBinExprOp_6(54L, Body, null))
            {
                formatter.SetStatementIndentation(Body);
            }

            return MutateCSharp.Schemata193.ReplaceBooleanConstant_2(55L, true);
        }

        /// <summary>
        /// Assumes the specification of the iterator itself has been successfully resolved.
        /// </summary>
        public void CreateIteratorMethodSpecs(ModuleResolver resolver)
        {
            Contract.Requires(this != null);

            var tok = new AutoGeneratedToken(Tok);

            // ---------- here comes the constructor ----------
            // same requires clause as the iterator itself
            Member_Init.Req.AddRange(Requires);
            var ens = Member_Init.Ens;
            foreach (var p in Ins)
            {
                // ensures this.x == x;
                ens.Add(new AttributedExpression(new BinaryExpr(p.tok, BinaryExpr.Opcode.Eq,
                  new ExprDotName(p.tok, new ThisExpr(p.tok), p.Name, null), new IdentifierExpr(p.tok, p.Name))));
            }
            foreach (var p in OutsHistoryFields)
            {
                // ensures this.ys == [];
                ens.Add(new AttributedExpression(new BinaryExpr(p.tok, BinaryExpr.Opcode.Eq,
                  new ExprDotName(p.tok, new ThisExpr(p.tok), p.Name, null), new SeqDisplayExpr(p.tok, new List<Expression>()))));
            }
            // ensures this.Valid();
            var valid_call = AutoContractsRewriter.CreateUnresolvedValidCall(tok);
            ens.Add(new AttributedExpression(valid_call));
            AddConstructorFramePostconditions(tok, ens, resolver);
            // ensures this._new == {};
            ens.Add(new AttributedExpression(new BinaryExpr(tok, BinaryExpr.Opcode.Eq,
              new ExprDotName(tok, new ThisExpr(tok), MutateCSharp.Schemata193.ReplaceStringConstant_0(56L, "_new"), null),
              new SetDisplayExpr(tok, MutateCSharp.Schemata193.ReplaceBooleanConstant_2(57L, true), new List<Expression>()))));
            // ensures this._decreases0 == old(DecreasesClause[0]) && ...;
            Contract.Assert(Decreases.Expressions.Count == DecreasesFields.Count);
            for (int i = MutateCSharp.Schemata193.ReplaceNumericConstant_4(58L, 0); MutateCSharp.Schemata193.ReplaceBinExprOp_7(62L, i, Decreases.Expressions.Count); MutateCSharp.Schemata193.ReplacePostfixUnaryExprOp_8(67L, ref i))
            {
                var p = Decreases.Expressions[i];
                ens.Add(new AttributedExpression(new BinaryExpr(tok, BinaryExpr.Opcode.Eq,
                  new ExprDotName(tok, new ThisExpr(tok), DecreasesFields[i].Name, null),
                  new OldExpr(tok, p))));
            }

            // ---------- here comes predicate Valid() ----------
            var reads = Member_Valid.Reads;
            reads.Expressions.Add(new FrameExpression(tok, new ThisExpr(tok), null));  // reads this;
            reads.Expressions.Add(new FrameExpression(tok, new ExprDotName(tok, new ThisExpr(tok), MutateCSharp.Schemata193.ReplaceStringConstant_0(68L, "_reads"), null), null));  // reads this._reads;
            reads.Expressions.Add(new FrameExpression(tok, new ExprDotName(tok, new ThisExpr(tok), MutateCSharp.Schemata193.ReplaceStringConstant_0(69L, "_new"), null), null));  // reads this._new;

            // ---------- here comes method MoveNext() ----------
            // requires this.Valid();
            var req = Member_MoveNext.Req;
            valid_call = AutoContractsRewriter.CreateUnresolvedValidCall(tok);
            req.Add(new AttributedExpression(valid_call));
            // requires YieldRequires;
            req.AddRange(YieldRequires);
            // modifies this, this._modifies, this._new;
            var mod = Member_MoveNext.Mod.Expressions;
            mod.Add(new FrameExpression(tok, new ThisExpr(tok), null));
            mod.Add(new FrameExpression(tok, new ExprDotName(tok, new ThisExpr(tok), MutateCSharp.Schemata193.ReplaceStringConstant_0(70L, "_modifies"), null), null));
            mod.Add(new FrameExpression(tok, new ExprDotName(tok, new ThisExpr(tok), MutateCSharp.Schemata193.ReplaceStringConstant_0(71L, "_new"), null), null));
            // ensures fresh(_new - old(_new));
            ens = Member_MoveNext.Ens;
            ens.Add(new AttributedExpression(new FreshExpr(tok,
              new BinaryExpr(tok, BinaryExpr.Opcode.Sub,
                new ExprDotName(tok, new ThisExpr(tok), MutateCSharp.Schemata193.ReplaceStringConstant_0(72L, "_new"), null),
                new OldExpr(tok, new ExprDotName(tok, new ThisExpr(tok), MutateCSharp.Schemata193.ReplaceStringConstant_0(73L, "_new"), null))))));
            // ensures null !in _new
            ens.Add(new AttributedExpression(new BinaryExpr(tok, BinaryExpr.Opcode.NotIn,
              new LiteralExpr(tok),
              new ExprDotName(tok, new ThisExpr(tok), MutateCSharp.Schemata193.ReplaceStringConstant_0(74L, "_new"), null))));
            // ensures more ==> this.Valid();
            valid_call = AutoContractsRewriter.CreateUnresolvedValidCall(tok);
            ens.Add(new AttributedExpression(new BinaryExpr(tok, BinaryExpr.Opcode.Imp,
              new IdentifierExpr(tok, MutateCSharp.Schemata193.ReplaceStringConstant_0(75L, "more")),
              valid_call)));
            // ensures this.ys == if more then old(this.ys) + [this.y] else old(this.ys);
            Contract.Assert(OutsFields.Count == OutsHistoryFields.Count);
            for (int i = MutateCSharp.Schemata193.ReplaceNumericConstant_4(76L, 0); MutateCSharp.Schemata193.ReplaceBinExprOp_7(80L, i, OutsFields.Count); MutateCSharp.Schemata193.ReplacePostfixUnaryExprOp_8(85L, ref i))
            {
                var y = OutsFields[i];
                var ys = OutsHistoryFields[i];
                var ite = new ITEExpr(tok, MutateCSharp.Schemata193.ReplaceBooleanConstant_2(86L, false), new IdentifierExpr(tok, MutateCSharp.Schemata193.ReplaceStringConstant_0(87L, "more")),
                  new BinaryExpr(tok, BinaryExpr.Opcode.Add,
                    new OldExpr(tok, new ExprDotName(tok, new ThisExpr(tok), ys.Name, null)),
                    new SeqDisplayExpr(tok, new List<Expression>() { new ExprDotName(tok, new ThisExpr(tok), y.Name, null) })),
                  new OldExpr(tok, new ExprDotName(tok, new ThisExpr(tok), ys.Name, null)));
                var eq = new BinaryExpr(tok, BinaryExpr.Opcode.Eq, new ExprDotName(tok, new ThisExpr(tok), ys.Name, null), ite);
                ens.Add(new AttributedExpression(eq));
            }
            // ensures more ==> YieldEnsures;
            foreach (var ye in YieldEnsures)
            {
                ens.Add(new AttributedExpression(
                  new BinaryExpr(tok, BinaryExpr.Opcode.Imp, new IdentifierExpr(tok, MutateCSharp.Schemata193.ReplaceStringConstant_0(88L, "more")), ye.E)
                ));
            }
            // ensures !more ==> Ensures;
            foreach (var e in Ensures)
            {
                ens.Add(new AttributedExpression(new BinaryExpr(tok, BinaryExpr.Opcode.Imp,
                  new UnaryOpExpr(tok, UnaryOpExpr.Opcode.Not, new IdentifierExpr(tok, MutateCSharp.Schemata193.ReplaceStringConstant_0(89L, "more"))),
                  e.E)
                ));
            }
            // decreases this._decreases0, this._decreases1, ...;
            Contract.Assert(Decreases.Expressions.Count == DecreasesFields.Count);
            for (int i = MutateCSharp.Schemata193.ReplaceNumericConstant_4(90L, 0); MutateCSharp.Schemata193.ReplaceBinExprOp_7(94L, i, Decreases.Expressions.Count); MutateCSharp.Schemata193.ReplacePostfixUnaryExprOp_8(99L, ref i))
            {
                var p = Decreases.Expressions[i];
                Member_MoveNext.Decreases.Expressions.Add(new ExprDotName(p.tok, new ThisExpr(p.tok), DecreasesFields[i].Name, null));
            }
            Member_MoveNext.Decreases.Attributes = Decreases.Attributes;
        }

        /// <summary>
        /// Append to "iteratorCtorEnsures" the following postconditions about the _reads and _modifies fields:
        ///     ensures this._reads == old(ReadsClause)
        ///     ensures this._modifies == old(ModifiesClause)
        /// In order to produce the RHSs of these equalities, type information about the ReadsClause and ModifiesClause are needed.
        /// </summary>
        private void AddConstructorFramePostconditions(AutoGeneratedToken tok, List<AttributedExpression> iteratorCtorEnsures, ModuleResolver resolver)
        {
            // ensures this._reads == old(ReadsClause)
            var modSetSingletons = new List<Expression>();
            Expression frameSet = new SetDisplayExpr(tok, MutateCSharp.Schemata193.ReplaceBooleanConstant_2(100L, true), modSetSingletons);
            foreach (var fr in Reads.Expressions)
            {
                if (fr.FieldName != null)
                {
                    resolver.reporter.Error(MessageSource.Resolver, fr.tok,
            MutateCSharp.Schemata193.ReplaceStringConstant_0(101L, "sorry, a reads clause for an iterator is not allowed to designate specific fields"));
                }
                else if (MutateCSharp.Schemata193.ReplaceBinExprOp_9(102L, fr.E.Type, null) ? fr.E.Type.IsRefType : fr.E.PreType.IsRefType)
                {
                    modSetSingletons.Add(fr.E);
                }
                else
                {
                    frameSet = new BinaryExpr(fr.tok, BinaryExpr.Opcode.Add, frameSet, fr.E);
                }
            }
            iteratorCtorEnsures.Add(new AttributedExpression(new BinaryExpr(tok, BinaryExpr.Opcode.Eq,
              new ExprDotName(tok, new ThisExpr(tok), MutateCSharp.Schemata193.ReplaceStringConstant_0(103L, "_reads"), null),
              new OldExpr(tok, frameSet))));

            // ensures this._modifies == old(ModifiesClause)
            modSetSingletons = new List<Expression>();
            frameSet = new SetDisplayExpr(tok, MutateCSharp.Schemata193.ReplaceBooleanConstant_2(104L, true), modSetSingletons);
            foreach (var fr in Modifies.Expressions)
            {
                if (fr.FieldName != null)
                {
                    resolver.reporter.Error(MessageSource.Resolver, fr.tok,
            MutateCSharp.Schemata193.ReplaceStringConstant_0(105L, "sorry, a modifies clause for an iterator is not allowed to designate specific fields"));
                }
                else if (MutateCSharp.Schemata193.ReplaceBinExprOp_9(106L, fr.E.Type, null) ? fr.E.Type.IsRefType : fr.E.PreType.IsRefType)
                {
                    modSetSingletons.Add(fr.E);
                }
                else
                {
                    frameSet = new BinaryExpr(fr.tok, BinaryExpr.Opcode.Add, frameSet, fr.E);
                }
            }
            iteratorCtorEnsures.Add(new AttributedExpression(new BinaryExpr(tok, BinaryExpr.Opcode.Eq,
              new ExprDotName(tok, new ThisExpr(tok), MutateCSharp.Schemata193.ReplaceStringConstant_0(107L, "_modifies"), null),
              new OldExpr(tok, frameSet))));
        }

        public void Resolve(ModuleResolver resolver)
        {
            var rangeToken = RangeToken.MakeAutoGenerated();

            // register the names of the implicit members
            var members = new Dictionary<string, MemberDecl>();
            resolver.AddClassMembers(this, members);

            // First, register the iterator's in- and out-parameters as readonly fields
            foreach (var p in Ins)
            {
                if (members.ContainsKey(p.Name))
                {
                    resolver.reporter.Error(MessageSource.Resolver, p,
            MutateCSharp.Schemata193.ReplaceStringConstant_0(108L, "Name of in-parameter is used by another member of the iterator: {0}"), p.Name);
                }
                else
                {
                    var field = new SpecialField(p.RangeToken, p.Name, SpecialField.ID.UseIdParam, p.CompileName, p.IsGhost, MutateCSharp.Schemata193.ReplaceBooleanConstant_2(109L, false),
            MutateCSharp.Schemata193.ReplaceBooleanConstant_2(110L, false), p.Type, null);
                    field.EnclosingClass = this; // resolve here
                    field.InheritVisibility(this);
                    members.Add(p.Name, field);
                    Members.Add(field);
                }
            }

            var nonDuplicateOuts = new List<Formal>();
            foreach (var p in Outs)
            {
                if (members.ContainsKey(p.Name))
                {
                    resolver.reporter.Error(MessageSource.Resolver, p,
            MutateCSharp.Schemata193.ReplaceStringConstant_0(111L, "Name of yield-parameter is used by another member of the iterator: {0}"), p.Name);
                }
                else
                {
                    nonDuplicateOuts.Add(p);
                    var field = new SpecialField(p.RangeToken, p.Name, SpecialField.ID.UseIdParam, p.CompileName, p.IsGhost, MutateCSharp.Schemata193.ReplaceBooleanConstant_2(112L, true),
            MutateCSharp.Schemata193.ReplaceBooleanConstant_2(113L, true), p.Type, null);
                    field.EnclosingClass = this; // resolve here
                    field.InheritVisibility(this);
                    OutsFields.Add(field);
                    members.Add(p.Name, field);
                    Members.Add(field);
                }
            }

            foreach (var p in nonDuplicateOuts)
            {
                var nm = p.Name + MutateCSharp.Schemata193.ReplaceStringConstant_0(114L, "s");
                if (members.ContainsKey(nm))
                {
                    resolver.reporter.Error(MessageSource.Resolver, p.tok,
            MutateCSharp.Schemata193.ReplaceStringConstant_0(115L, "Name of implicit yield-history variable '{0}' is already used by another member of the iterator"),
                      p.Name);
                    nm = p.Name + MutateCSharp.Schemata193.ReplaceStringConstant_0(116L, "*"); // bogus name, but at least it'll be unique
                }

                // we add some field to OutsHistoryFields, even if there was an error; the name of the field, in case of error, is not so important
                var tp = new SeqType(p.Type.NormalizeExpand());
                var field = new SpecialField(p.RangeToken, nm, SpecialField.ID.UseIdParam, nm, MutateCSharp.Schemata193.ReplaceBooleanConstant_2(117L, true), MutateCSharp.Schemata193.ReplaceBooleanConstant_2(118L, true), MutateCSharp.Schemata193.ReplaceBooleanConstant_2(119L, false), tp, null);
                field.EnclosingClass = this; // resolve here
                field.InheritVisibility(this);
                OutsHistoryFields
                  .Add(field); // for now, just record this field (until all parameters have been added as members)
            }

            Contract.Assert(OutsFields.Count ==
                            OutsHistoryFields
                              .Count); // the code above makes sure this holds, even in the face of errors
                                       // now that already-used 'ys' names have been checked for, add these yield-history variables
            OutsHistoryFields.ForEach(f =>
            {
                members.Add(f.Name, f);
                Members.Add(f);
            });
            // add the additional special variables as fields
            Member_Reads = new SpecialField(RangeToken, MutateCSharp.Schemata193.ReplaceStringConstant_0(120L, "_reads"), SpecialField.ID.Reads, null, MutateCSharp.Schemata193.ReplaceBooleanConstant_2(121L, true), MutateCSharp.Schemata193.ReplaceBooleanConstant_2(122L, false), MutateCSharp.Schemata193.ReplaceBooleanConstant_2(123L, false),
              resolver.SystemModuleManager.ObjectSetType(), null);
            Member_Modifies = new SpecialField(RangeToken, MutateCSharp.Schemata193.ReplaceStringConstant_0(124L, "_modifies"), SpecialField.ID.Modifies, null, MutateCSharp.Schemata193.ReplaceBooleanConstant_2(125L, true), MutateCSharp.Schemata193.ReplaceBooleanConstant_2(126L, false),
        MutateCSharp.Schemata193.ReplaceBooleanConstant_2(127L, false), resolver.SystemModuleManager.ObjectSetType(), null);
            Member_New = new SpecialField(RangeToken, MutateCSharp.Schemata193.ReplaceStringConstant_0(128L, "_new"), SpecialField.ID.New, null, MutateCSharp.Schemata193.ReplaceBooleanConstant_2(129L, true), MutateCSharp.Schemata193.ReplaceBooleanConstant_2(130L, true), MutateCSharp.Schemata193.ReplaceBooleanConstant_2(131L, true),
              resolver.SystemModuleManager.ObjectSetType(), null);
            foreach (var field in new List<Field>() { Member_Reads, Member_Modifies, Member_New })
            {
                field.EnclosingClass = this; // resolve here
                field.InheritVisibility(this);
                members.Add(field.Name, field);
                Members.Add(field);
            }

            // finally, add special variables to hold the components of the (explicit or implicit) decreases clause
            new InferDecreasesClause(resolver).FillInDefaultDecreases(this, MutateCSharp.Schemata193.ReplaceBooleanConstant_2(132L, false));
            // create the fields; unfortunately, we don't know their types yet, so we'll just insert type proxies for now
            var i = MutateCSharp.Schemata193.ReplaceNumericConstant_4(133L, 0);
            foreach (var p in Decreases.Expressions)
            {
                var nm = MutateCSharp.Schemata193.ReplaceStringConstant_0(137L, "_decreases") + i;
                var field = new SpecialField(p.RangeToken, nm, SpecialField.ID.UseIdParam, nm, MutateCSharp.Schemata193.ReplaceBooleanConstant_2(138L, true), MutateCSharp.Schemata193.ReplaceBooleanConstant_2(139L, false), MutateCSharp.Schemata193.ReplaceBooleanConstant_2(140L, false),
                  new InferredTypeProxy(), null);
                field.EnclosingClass = this; // resolve here
                field.InheritVisibility(this);
                DecreasesFields.Add(field);
                members.Add(field.Name, field);
                Members.Add(field);
                MutateCSharp.Schemata193.ReplacePostfixUnaryExprOp_8(141L, ref i);
            }

            // Note, the typeArgs parameter to the following Method/Predicate constructors is passed in as the empty list.  What that is
            // saying is that the Method/Predicate does not take any type parameters over and beyond what the enclosing type (namely, the
            // iterator type) does.
            // --- here comes the constructor
            var init = new Constructor(rangeToken, new Name(NameNode.RangeToken, MutateCSharp.Schemata193.ReplaceStringConstant_0(142L, "_ctor")), MutateCSharp.Schemata193.ReplaceBooleanConstant_2(143L, false),
              new List<TypeParameter>(), Ins,
              new List<AttributedExpression>(),
              new Specification<FrameExpression>(),
              new Specification<FrameExpression>(new List<FrameExpression>(), null),
              new List<AttributedExpression>(),
              new Specification<Expression>(new List<Expression>(), null),
              null, SystemModuleManager.AxiomAttribute(), null);
            // --- here comes predicate Valid()
            var valid = new Predicate(rangeToken, new Name(NameNode.RangeToken, MutateCSharp.Schemata193.ReplaceStringConstant_0(144L, "Valid")), MutateCSharp.Schemata193.ReplaceBooleanConstant_2(145L, false), MutateCSharp.Schemata193.ReplaceBooleanConstant_2(146L, true), MutateCSharp.Schemata193.ReplaceBooleanConstant_2(147L, false),
              new List<TypeParameter>(),
              new List<Formal>(),
              null,
              new List<AttributedExpression>(),
              new Specification<FrameExpression>(),
              new List<AttributedExpression>(),
              new Specification<Expression>(new List<Expression>(), null),
              null, Predicate.BodyOriginKind.OriginalOrInherited, null, null, SystemModuleManager.AxiomAttribute(), null);
            // --- here comes method MoveNext
            var moveNext = new Method(rangeToken, new Name(NameNode.RangeToken, MutateCSharp.Schemata193.ReplaceStringConstant_0(148L, "MoveNext")), MutateCSharp.Schemata193.ReplaceBooleanConstant_2(149L, false), MutateCSharp.Schemata193.ReplaceBooleanConstant_2(150L, false),
              new List<TypeParameter>(),
              new List<Formal>(), new List<Formal>() { new Formal(tok, MutateCSharp.Schemata193.ReplaceStringConstant_0(151L, "more"), Type.Bool, MutateCSharp.Schemata193.ReplaceBooleanConstant_2(152L, false), MutateCSharp.Schemata193.ReplaceBooleanConstant_2(153L, false), null) },
              new List<AttributedExpression>(),
              new Specification<FrameExpression>(),
              new Specification<FrameExpression>(new List<FrameExpression>(), null),
              new List<AttributedExpression>(),
              new Specification<Expression>(new List<Expression>(), null),
              null, SystemModuleManager.AxiomAttribute(Attributes.Find(Attributes, MutateCSharp.Schemata193.ReplaceStringConstant_0(154L, "print"))), null);
            // add these implicit members to the class
            init.EnclosingClass = this;
            init.InheritVisibility(this);
            valid.EnclosingClass = this;
            valid.InheritVisibility(this);
            moveNext.EnclosingClass = this;
            moveNext.InheritVisibility(this);
            HasConstructor = MutateCSharp.Schemata193.ReplaceBooleanConstant_2(155L, true);
            Member_Init = init;
            Member_Valid = valid;
            Member_MoveNext = moveNext;
            if (members.TryGetValue(init.Name, out var member))
            {
                resolver.reporter.Error(MessageSource.Resolver, member.tok,
          MutateCSharp.Schemata193.ReplaceStringConstant_0(156L, "member name '{0}' is already predefined for this iterator"), init.Name);
            }
            else
            {
                members.Add(init.Name, init);
                Members.Add(init);
            }

            // If the name of the iterator is "Valid" or "MoveNext", one of the following will produce an error message.  That
            // error message may not be as clear as it could be, but the situation also seems unlikely to ever occur in practice.
            if (members.TryGetValue(MutateCSharp.Schemata193.ReplaceStringConstant_0(157L, "Valid"), out member))
            {
                resolver.reporter.Error(MessageSource.Resolver, member.tok,
          MutateCSharp.Schemata193.ReplaceStringConstant_0(158L, "member name 'Valid' is already predefined for iterators"));
            }
            else
            {
                members.Add(valid.Name, valid);
                Members.Add(valid);
            }

            if (members.TryGetValue(MutateCSharp.Schemata193.ReplaceStringConstant_0(159L, "MoveNext"), out member))
            {
                resolver.reporter.Error(MessageSource.Resolver, member.tok,
          MutateCSharp.Schemata193.ReplaceStringConstant_0(160L, "member name 'MoveNext' is already predefined for iterators"));
            }
            else
            {
                members.Add(moveNext.Name, moveNext);
                Members.Add(moveNext);
            }
        }

        public override string GetTriviaContainingDocstring()
        {
            IToken lastClosingParenthesis = null;
            foreach (var token in OwnedTokens)
            {
                if (MutateCSharp.Schemata193.ReplaceBinExprOp_10(162L, token.val, MutateCSharp.Schemata193.ReplaceStringConstant_0(161L, ")")))
                {
                    lastClosingParenthesis = token;
                }
            }

            if (MutateCSharp.Schemata193.ReplaceBinExprOp_12(165L, () => MutateCSharp.Schemata193.ReplaceBinExprOp_1(163L, lastClosingParenthesis, null), () => MutateCSharp.Schemata193.ReplaceBinExprOp_11(164L, lastClosingParenthesis.TrailingTrivia.Trim(), "")))
            {
                return lastClosingParenthesis.TrailingTrivia;
            }

            return GetTriviaContainingDocstringFromStartTokenOrNull();
        }
        public bool ShouldVerify => MutateCSharp.Schemata193.ReplaceBooleanConstant_2(171L, true); // This could be made more accurate
        public ModuleDefinition ContainingModule => EnclosingModuleDefinition;
        public string Designator => WhatKind;
    }
}
