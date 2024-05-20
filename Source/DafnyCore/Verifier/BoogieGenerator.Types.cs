using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using Bpl = Microsoft.Boogie;
using BplParser = Microsoft.Boogie.Parser;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.Boogie;
using static Microsoft.Dafny.Util;
using Core;
using DafnyCore.Verifier;
using Microsoft.BaseTypes;
using Microsoft.Dafny.Compilers;
using Microsoft.Dafny.Triggers;
using Action = System.Action;
using PODesc = Microsoft.Dafny.ProofObligationDescription;
using static Microsoft.Dafny.GenericErrors;
namespace MutateCSharp
{
    internal class Schemata501
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT501");
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

        internal static bool ReplaceBinExprOp_20(long mutantId, Microsoft.Boogie.IdentifierExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.Function argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, Microsoft.Dafny.BoundVar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.NonNullTypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBinExprOp_14(long mutantId, Microsoft.Dafny.DisplayExpression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, Microsoft.Dafny.NewtypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_6(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, Microsoft.Dafny.BoundVar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, Microsoft.Dafny.RedirectingTypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_11(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_21(long mutantId, Microsoft.Boogie.Expr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, Microsoft.BaseTypes.BigNum argument1, Microsoft.BaseTypes.BigNum argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 <= argument2;
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

        internal static int ReplaceNumericConstant_0(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static string ReplaceStringConstant_5(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, Microsoft.Dafny.SubsetTypeDecl.WKind argument1, Microsoft.Dafny.SubsetTypeDecl.WKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public partial class BoogieGenerator
    {


        private void AddArrowTypeAxioms(ArrowTypeDecl ad)
        {
            Contract.Requires(ad != null);
            var arity = ad.Arity;
            var tok = ad.tok;

            // [Heap, Box, ..., Box]
            var map_args = Cons(predef.HeapType, Map(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(1L, 0), arity), i => predef.BoxType));
            // [Heap, Box, ..., Box] Box
            var apply_ty = new Bpl.MapType(tok, new List<Bpl.TypeVariable>(), map_args, predef.BoxType);
            // [Heap, Box, ..., Box] Bool
            var requires_ty = new Bpl.MapType(tok, new List<Bpl.TypeVariable>(), map_args, Bpl.Type.Bool);
            // Set Box
            var objset_ty = TrType(program.SystemModuleManager.ObjectSetType());
            // [Heap, Box, ..., Box] (Set Box)
            var reads_ty = new Bpl.MapType(tok, new List<Bpl.TypeVariable>(), map_args, objset_ty);

            {
                // function HandleN([Heap, Box, ..., Box] Box, [Heap, Box, ..., Box] Bool) : HandleType
                var res = BplFormalVar(null, predef.HandleType, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(5L, true));
                var arg = new List<Bpl.Variable> {
          BplFormalVar(null, apply_ty, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(6L, true)),
          BplFormalVar(null, requires_ty, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(7L, true)),
          BplFormalVar(null, reads_ty, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(8L, true))
        };
                sink.AddTopLevelDeclaration(new Bpl.Function(Token.NoToken, Handle(arity), arg, res));
            }

            Action<Function, string, Bpl.Type> SelectorFunction = (dafnyFunction, name, t) =>
            {
                var args = new List<Bpl.Variable>();
                MapM(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(9L, 0), MutateCSharp.Schemata501.ReplaceBinExprOp_2(17L, arity, MutateCSharp.Schemata501.ReplaceNumericConstant_0(13L, 1))), i => args.Add(BplFormalVar(null, predef.Ty, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(26L, true))));
                args.Add(BplFormalVar(null, predef.HeapType, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(27L, true)));
                args.Add(BplFormalVar(null, predef.HandleType, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(28L, true)));
                MapM(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(29L, 0), arity), i => args.Add(BplFormalVar(null, predef.BoxType, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(33L, true))));
                var boogieFunction = new Bpl.Function(Token.NoToken, name, args, BplFormalVar(null, t, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(34L, false)));
                if (MutateCSharp.Schemata501.ReplaceBinExprOp_3(35L, dafnyFunction, null))
                {
                    declarationMapping[dafnyFunction] = boogieFunction;
                }
                sink.AddTopLevelDeclaration(boogieFunction);
            };

            // function ApplyN(Ty, ... Ty, HandleType, Heap, Box, ..., Box) : Box
            if (MutateCSharp.Schemata501.ReplaceBinExprOp_4(40L, arity, MutateCSharp.Schemata501.ReplaceNumericConstant_0(36L, 1)))
            {  // Apply1 is already declared in DafnyPrelude.bpl
                SelectorFunction(null, Apply(arity), predef.BoxType);
            }
            // function RequiresN(Ty, ... Ty, HandleType, Heap, Box, ..., Box) : Bool
            SelectorFunction(ad.Requires, Requires(arity), Bpl.Type.Bool);
            // function ReadsN(Ty, ... Ty, HandleType, Heap, Box, ..., Box) : Set Box
            SelectorFunction(ad.Reads, Reads(arity), objset_ty);

            {
                // forall t1, .., tN+1 : Ty, p: [Heap, Box, ..., Box] Box, heap : Heap, b1, ..., bN : Box
                //      :: ApplyN(t1, .. tN+1, heap, HandleN(h, r, rd), b1, ..., bN) == h[heap, b1, ..., bN]
                //      :: RequiresN(t1, .. tN+1, heap, HandleN(h, r, rd), b1, ..., bN) <== r[heap, b1, ..., bN]
                //      :: ReadsN(t1, .. tN+1, heap, HandleN(h, r, rd), b1, ..., bN) == rd[heap, b1, ..., bN]
                Action<string, Bpl.Type, string, Bpl.Type, string, Bpl.Type> SelectorSemantics = (selector, selectorTy, selectorVar, selectorVarTy, precond, precondTy) =>
                {
                    Contract.Assert((precond == null) == (precondTy == null));
                    var bvars = new List<Bpl.Variable>();

                    var types = Map(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(45L, 0), MutateCSharp.Schemata501.ReplaceBinExprOp_2(53L, arity, MutateCSharp.Schemata501.ReplaceNumericConstant_0(49L, 1))), i => BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(62L, "t") + i, predef.Ty, bvars));

                    var heap = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(63L, "heap"), predef.HeapType, bvars);

                    var handleargs = new List<Bpl.Expr> {
            BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(64L, "h"), apply_ty, bvars),
            BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(65L, "r"), requires_ty, bvars),
            BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(66L, "rd"), reads_ty, bvars)
          };

                    var boxes = Map(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(67L, 0), arity), i => BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(71L, "bx") + i, predef.BoxType, bvars));

                    var lhsargs = Concat(types, Cons(heap, Cons(FunctionCall(tok, Handle(arity), predef.HandleType, handleargs), boxes)));
                    Bpl.Expr lhs = FunctionCall(tok, selector, selectorTy, lhsargs);
                    Func<Bpl.Expr, Bpl.Expr> pre = x => x;
                    if (precond != null)
                    {
                        pre = x => FunctionCall(tok, precond, precondTy, lhsargs);
                    }

                    Bpl.Expr rhs = new Bpl.NAryExpr(tok, new Bpl.MapSelect(tok, MutateCSharp.Schemata501.ReplaceBinExprOp_2(76L, arity, MutateCSharp.Schemata501.ReplaceNumericConstant_0(72L, 1))),
                      Cons(new Bpl.IdentifierExpr(tok, selectorVar, selectorVarTy), Cons(heap, boxes)));
                    Func<Bpl.Expr, Bpl.Expr, Bpl.Expr> op = Bpl.Expr.Eq;
                    if (MutateCSharp.Schemata501.ReplaceBinExprOp_6(86L, selectorVar, MutateCSharp.Schemata501.ReplaceStringConstant_5(85L, "rd")))
                    {
                        var bx = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(87L, "bx"), predef.BoxType, bvars);
                        lhs = Bpl.Expr.SelectTok(tok, lhs, bx);
                        rhs = Bpl.Expr.SelectTok(tok, rhs, bx);
                        // op = BplImp;
                    }
                    if (MutateCSharp.Schemata501.ReplaceBinExprOp_6(89L, selectorVar, MutateCSharp.Schemata501.ReplaceStringConstant_5(88L, "r")))
                    {
                        op = (u, v) => BplImp(v, u);
                    }
                    AddOtherDefinition(GetOrCreateTypeConstructor(ad), new Axiom(tok,
                      BplForall(bvars, BplTrigger(lhs), op(lhs, rhs))));
                };
                SelectorSemantics(Apply(arity), predef.BoxType, MutateCSharp.Schemata501.ReplaceStringConstant_5(90L, "h"), apply_ty, Requires(arity), requires_ty);
                SelectorSemantics(Requires(arity), Bpl.Type.Bool, MutateCSharp.Schemata501.ReplaceStringConstant_5(91L, "r"), requires_ty, null, null);
                SelectorSemantics(Reads(arity), objset_ty, MutateCSharp.Schemata501.ReplaceStringConstant_5(92L, "rd"), reads_ty, null, null);

                // function {:inline true}
                //   FuncN._requires#canCall(G...G G: Ty, H:Heap, f:Handle, x ... x :Box): bool
                //   { true }
                // + similar for Reads
                Action<string, Function> UserSelectorFunction = (fname, f) =>
                {
                    var formals = new List<Bpl.Variable>();
                    var rhsargs = new List<Bpl.Expr>();

                    MapM(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(93L, 0), MutateCSharp.Schemata501.ReplaceBinExprOp_2(101L, arity, MutateCSharp.Schemata501.ReplaceNumericConstant_0(97L, 1))), i => rhsargs.Add(BplFormalVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(110L, "t") + i, predef.Ty, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(111L, true), formals)));

                    var heap = BplFormalVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(112L, "heap"), predef.HeapType, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(113L, true), formals);
                    rhsargs.Add(heap);
                    rhsargs.Add(BplFormalVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(114L, "f"), predef.HandleType, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(115L, true), formals));

                    MapM(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(116L, 0), arity), i => rhsargs.Add(BplFormalVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(120L, "bx") + i, predef.BoxType, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(121L, true), formals)));

                    sink.AddTopLevelDeclaration(
                      new Bpl.Function(f.tok, f.FullSanitizedName + MutateCSharp.Schemata501.ReplaceStringConstant_5(122L, "#canCall"), new List<TypeVariable>(), formals,
                        BplFormalVar(null, Bpl.Type.Bool, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(123L, false)), null,
                        InlineAttribute(f.tok))
                      {
                          Body = Bpl.Expr.True
                      });
                };

                UserSelectorFunction(Requires(ad.Arity), ad.Requires);
                UserSelectorFunction(Reads(ad.Arity), ad.Reads);

                // frame axiom
                /*

                  forall t0..tN+1 : Ty, h0, h1 : Heap, f : Handle, bx1 .. bxN : Box,
                    HeapSucc(h0, h1) && GoodHeap(h0) && GoodHeap(h1)
                    && Is[&IsAllocBox](bxI, tI, h0)              // in h0, not hN
                    && Is[&IsAlloc](f, Func(t1,..,tN, tN+1), h0) // in h0, not hN
                    &&
                    (forall o : ref::
                         o != null [&& h0[o, alloc] && h1[o, alloc] &&]
                         Reads(h,hN,bxs)[Box(o)]             // for hN in h0 and h1
                      ==> h0[o,field] == h1[o,field])
                  ==>  Reads(..h0..) == Reads(..h1..)
                   AND Requires(f,h0,bxs) == Requires(f,h1,bxs) // which is needed for the next
                   AND  Apply(f,h0,bxs) == Apply(f,h0,bxs)

                   The [...] expressions are omitted for /allocated:0 and /allocated:1:
                     - in these modes, functions are pure values and IsAlloc of a function is trivially true
                     - o may be unallocated even if f reads it, so we require a stronger condition that
                       even fields of *unallocated* objects o are unchanged from h0 to h1
                     - given this stronger condition, we can say that f(bx1...bxN) does not change from h0 to h1
                       even if some of bx1...bxN are unallocated
                     - it's harder to satisfy the stronger condition, but two cases are nevertheless useful:
                       1) f has an empty reads clause
                       2) f explictly states that everything is its reads clause is allocated
                 */
                {
                    var bvars = new List<Bpl.Variable>();

                    var types = Map(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(124L, 0), MutateCSharp.Schemata501.ReplaceBinExprOp_2(132L, arity, MutateCSharp.Schemata501.ReplaceNumericConstant_0(128L, 1))), i => BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(141L, "t") + i, predef.Ty, bvars));

                    var h0 = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(142L, "h0"), predef.HeapType, bvars);
                    var h1 = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(143L, "h1"), predef.HeapType, bvars);
                    var heapSucc = HeapSucc(h0, h1);
                    var goodHeaps = BplAnd(
                      FunctionCall(tok, BuiltinFunction.IsGoodHeap, null, h0),
                      FunctionCall(tok, BuiltinFunction.IsGoodHeap, null, h1));

                    var f = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(144L, "f"), predef.HandleType, bvars);
                    var boxes = Map(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(145L, 0), arity), i => BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(149L, "bx") + i, predef.BoxType, bvars));

                    var isness = BplAnd(
                      Snoc(Map(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(150L, 0), arity), i =>
                        BplAnd(MkIs(boxes[i], types[i], MutateCSharp.Schemata501.ReplaceBooleanConstant_1(154L, true)), Bpl.Expr.True)),
                      BplAnd(MkIs(f, ClassTyCon(ad, types)), Bpl.Expr.True)));

                    Action<Bpl.Expr, string> AddFrameForFunction = (hN, fname) =>
                    {

                        // inner forall vars
                        var ivars = new List<Bpl.Variable>();
                        var o = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(155L, "o"), predef.RefType, ivars);
                        var fld = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(156L, "fld"), predef.FieldName(tok), ivars);

                        var inner_forall = new Bpl.ForallExpr(tok, new List<TypeVariable>(), ivars, BplImp(
                          BplAnd(
                            Bpl.Expr.Neq(o, predef.Null),
                            // Note, the MkIsAlloc conjunct of "isness" implies that everything in the reads frame is allocated in "h0", which by HeapSucc(h0,h1) also implies the frame is allocated in "h1"
                            new Bpl.NAryExpr(tok, new Bpl.MapSelect(tok, MutateCSharp.Schemata501.ReplaceNumericConstant_0(157L, 1)), new List<Bpl.Expr> {
                  FunctionCall(tok, Reads(ad.Arity), objset_ty, Concat(types, Cons(hN, Cons(f, boxes)))),
                  FunctionCall(tok, BuiltinFunction.Box, null, o)
                            })
                          ),
                          Bpl.Expr.Eq(ReadHeap(tok, h0, o, fld), ReadHeap(tok, h1, o, fld))));

                        Func<Bpl.Expr, Bpl.Expr> fn = h => FunctionCall(tok, fname, Bpl.Type.Bool, Concat(types, Cons(h, Cons<Bpl.Expr>(f, boxes))));

                        sink.AddTopLevelDeclaration(new Axiom(tok,
                          BplForall(bvars,
                            new Bpl.Trigger(tok, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(161L, true), new List<Bpl.Expr> { heapSucc, fn(h1) }),
                            BplImp(
                              BplAnd(BplAnd(BplAnd(heapSucc, goodHeaps), isness), inner_forall),
                              Bpl.Expr.Eq(fn(h0), fn(h1)))), MutateCSharp.Schemata501.ReplaceStringConstant_5(162L, "frame axiom for ") + fname));
                    };

                    AddFrameForFunction(h0, Reads(ad.Arity));
                    AddFrameForFunction(h1, Reads(ad.Arity));
                    AddFrameForFunction(h0, Requires(ad.Arity));
                    AddFrameForFunction(h1, Requires(ad.Arity));
                    AddFrameForFunction(h0, Apply(ad.Arity));
                    AddFrameForFunction(h1, Apply(ad.Arity));
                }

                /* axiom (forall T..: Ty, heap: Heap, f: HandleType, bx..: Box ::
                 *   { ReadsN(T.., $OneHeap, f, bx..), $IsGoodHeap(heap) }
                 *   { ReadsN(T.., heap, f, bx..) }
                 *   $IsGoodHeap(heap) && Is...(f...bx...) ==>
                 *   Set#Equal(ReadsN(T.., OneHeap, f, bx..), EmptySet) == Set#Equal(ReadsN(T.., heap, f, bx..), EmptySet));
                 */
                {
                    var bvars = new List<Bpl.Variable>();
                    var types = Map(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(163L, 0), MutateCSharp.Schemata501.ReplaceBinExprOp_2(171L, arity, MutateCSharp.Schemata501.ReplaceNumericConstant_0(167L, 1))), i => BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(180L, "t") + i, predef.Ty, bvars));
                    var oneheap = NewOneHeapExpr(tok);
                    var h = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(181L, "heap"), predef.HeapType, bvars);
                    var f = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(182L, "f"), predef.HandleType, bvars);
                    var boxes = Map(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(183L, 0), arity), i => BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(187L, "bx") + i, predef.BoxType, bvars));

                    var goodHeap = FunctionCall(tok, BuiltinFunction.IsGoodHeap, null, h);

                    var isness = BplAnd(
                      Snoc(Map(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(188L, 0), arity), i =>
                        BplAnd(MkIs(boxes[i], types[i], MutateCSharp.Schemata501.ReplaceBooleanConstant_1(192L, true)), Bpl.Expr.True)),
                      BplAnd(MkIs(f, ClassTyCon(ad, types)), Bpl.Expr.True)));

                    var readsOne = FunctionCall(tok, Reads(arity), objset_ty, Concat(types, Cons(oneheap, Cons(f, boxes))));
                    var readsH = FunctionCall(tok, Reads(arity), objset_ty, Concat(types, Cons(h, Cons(f, boxes))));
                    var empty = FunctionCall(tok, BuiltinFunction.SetEmpty, predef.BoxType);
                    var readsNothingOne = FunctionCall(tok, BuiltinFunction.SetEqual, null, readsOne, empty);
                    var readsNothingH = FunctionCall(tok, BuiltinFunction.SetEqual, null, readsH, empty);

                    sink.AddTopLevelDeclaration(new Axiom(tok, BplForall(bvars,
                      new Bpl.Trigger(tok, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(193L, true), new List<Bpl.Expr> { readsOne, goodHeap },
                      new Bpl.Trigger(tok, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(194L, true), new List<Bpl.Expr> { readsH })),
                      BplImp(
                        BplAnd(goodHeap, isness),
                        BplIff(readsNothingOne, readsNothingH))),
                      string.Format(MutateCSharp.Schemata501.ReplaceStringConstant_5(195L, "empty-reads property for {0} "), Reads(arity))));
                }

                /* axiom (forall T..: Ty, heap: Heap, f: HandleType, bx..: Box ::
                 *   { RequiresN(T.., OneHeap, f, bx..), $IsGoodHeap(heap) }
                 *   { RequiresN(T.., heap, f, bx..) }
                 *   $IsGoodHeap(heap) && Is...(f...bx...) &&
                 *   Set#Equal(ReadsN(T.., OneHeap, f, bx..), EmptySet)
                 *   ==>
                 *   RequiresN(T.., OneHeap, f, bx..) == RequiresN(T.., heap, f, bx..));
                 */
                {
                    var bvars = new List<Bpl.Variable>();
                    var types = Map(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(196L, 0), MutateCSharp.Schemata501.ReplaceBinExprOp_2(204L, arity, MutateCSharp.Schemata501.ReplaceNumericConstant_0(200L, 1))), i => BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(213L, "t") + i, predef.Ty, bvars));
                    var oneheap = NewOneHeapExpr(tok);
                    var h = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(214L, "heap"), predef.HeapType, bvars);
                    var f = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(215L, "f"), predef.HandleType, bvars);
                    var boxes = Map(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(216L, 0), arity), i => BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(220L, "bx") + i, predef.BoxType, bvars));

                    var goodHeap = FunctionCall(tok, BuiltinFunction.IsGoodHeap, null, h);

                    var isness = BplAnd(
                      Snoc(Map(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(221L, 0), arity), i =>
                        BplAnd(MkIs(boxes[i], types[i], MutateCSharp.Schemata501.ReplaceBooleanConstant_1(225L, true)), Bpl.Expr.True)),
                      BplAnd(MkIs(f, ClassTyCon(ad, types)), Bpl.Expr.True)));

                    var readsOne = FunctionCall(tok, Reads(arity), objset_ty, Concat(types, Cons(oneheap, Cons(f, boxes))));
                    var empty = FunctionCall(tok, BuiltinFunction.SetEmpty, predef.BoxType);
                    var readsNothingOne = FunctionCall(tok, BuiltinFunction.SetEqual, null, readsOne, empty);

                    var requiresOne = FunctionCall(tok, Requires(arity), Bpl.Type.Bool, Concat(types, Cons(oneheap, Cons(f, boxes))));
                    var requiresH = FunctionCall(tok, Requires(arity), Bpl.Type.Bool, Concat(types, Cons(h, Cons(f, boxes))));

                    sink.AddTopLevelDeclaration(new Axiom(tok, BplForall(bvars,
                      new Bpl.Trigger(tok, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(226L, true), new List<Bpl.Expr> { requiresOne, goodHeap },
                      new Bpl.Trigger(tok, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(227L, true), new List<Bpl.Expr> { requiresH })),
                      BplImp(
                        BplAnd(BplAnd(goodHeap, isness), readsNothingOne),
                        Bpl.Expr.Eq(requiresOne, requiresH))),
                      string.Format(MutateCSharp.Schemata501.ReplaceStringConstant_5(228L, "empty-reads property for {0}"), Requires(arity))));
                }

                // $Is and $IsAlloc axioms
                /*
                  axiom (forall f: HandleType, t0: Ty, t1: Ty ::
                    { $Is(f, Tclass._System.___hFunc1(t0, t1)) }
                    $Is(f, Tclass._System.___hFunc1(t0, t1))
                       <==> (forall h: Heap, bx0: Box ::
                         { Apply1(t0, t1, f, h, bx0) }
                         $IsGoodHeap(h) && $IsBox(bx0, t0)
                         && precondition of f(bx0) holds in h
                         ==> $IsBox(Apply1(t0, t1, f, h, bx0), t1)));
                */
                {
                    var bvarsOuter = new List<Bpl.Variable>();
                    var f = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(229L, "f"), predef.HandleType, bvarsOuter);
                    var types = Map(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(230L, 0), MutateCSharp.Schemata501.ReplaceBinExprOp_2(238L, arity, MutateCSharp.Schemata501.ReplaceNumericConstant_0(234L, 1))), i => BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(247L, "t") + i, predef.Ty, bvarsOuter));
                    var Is = MkIs(f, ClassTyCon(ad, types));

                    var bvarsInner = new List<Bpl.Variable>();
                    var h = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(248L, "h"), predef.HeapType, bvarsInner);
                    var boxes = Map(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(249L, 0), arity), i => BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(253L, "bx") + i, predef.BoxType, bvarsInner));
                    var goodHeap = FunctionCall(tok, BuiltinFunction.IsGoodHeap, null, h);
                    var isBoxes = BplAnd(Map(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(254L, 0), arity), i => MkIs(boxes[i], types[i], MutateCSharp.Schemata501.ReplaceBooleanConstant_1(258L, true))));
                    var pre = FunctionCall(tok, Requires(ad.Arity), predef.BoxType, Concat(types, Cons(h, Cons<Bpl.Expr>(f, boxes))));
                    var applied = FunctionCall(tok, Apply(ad.Arity), predef.BoxType, Concat(types, Cons(h, Cons<Bpl.Expr>(f, boxes))));
                    var applied_is = MkIs(applied, types[ad.Arity], MutateCSharp.Schemata501.ReplaceBooleanConstant_1(259L, true));

                    sink.AddTopLevelDeclaration(new Axiom(tok,
                      BplForall(bvarsOuter, BplTrigger(Is),
                        BplIff(Is,
                          BplForall(bvarsInner, BplTrigger(applied),
                            BplImp(BplAnd(BplAnd(goodHeap, isBoxes), pre), applied_is))))));
                }
                /*
                   axiom (forall f: HandleType, t0: Ty, t1: Ty, u0: Ty, u1: Ty ::
                     { $Is(f, Tclass._System.___hFunc1(t0, t1)), $Is(f, Tclass._System.___hFunc1(u0, u1)) }
                     $Is(f, Tclass._System.___hFunc1(t0, t1)) &&
                     (forall bx: Box :: { $IsBox(bx, u0), $IsBox(bx, t0) }
                         $IsBox(bx, u0) ==> $IsBox(bx, t0)) &&  // contravariant arguments
                     (forall bx: Box :: { $IsBox(bx, t1), $IsBox(bx, u1) }
                         $IsBox(bx, t1) ==> $IsBox(bx, u1))     // covariant result
                     ==>
                     $Is(f, Tclass._System.___hFunc1(u0, u1)));
                */
                {
                    var bvarsOuter = new List<Bpl.Variable>();
                    var f = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(260L, "f"), predef.HandleType, bvarsOuter);
                    var typesT = Map(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(261L, 0), MutateCSharp.Schemata501.ReplaceBinExprOp_2(269L, arity, MutateCSharp.Schemata501.ReplaceNumericConstant_0(265L, 1))), i => BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(278L, "t") + i, predef.Ty, bvarsOuter));
                    var IsT = MkIs(f, ClassTyCon(ad, typesT));
                    var typesU = Map(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(279L, 0), MutateCSharp.Schemata501.ReplaceBinExprOp_2(287L, arity, MutateCSharp.Schemata501.ReplaceNumericConstant_0(283L, 1))), i => BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(296L, "u") + i, predef.Ty, bvarsOuter));
                    var IsU = MkIs(f, ClassTyCon(ad, typesU));

                    Func<Expr, Expr, Expr> Inner = (a, b) =>
                    {
                        var bvarsInner = new List<Bpl.Variable>();
                        var bx = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(297L, "bx"), predef.BoxType, bvarsInner);
                        var isBoxA = MkIs(bx, a, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(298L, true));
                        var isBoxB = MkIs(bx, b, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(299L, true));
                        var tr = new Bpl.Trigger(tok, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(300L, true), new[] { isBoxA }, new Bpl.Trigger(tok, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(301L, true), new[] { isBoxB }));
                        var imp = BplImp(isBoxA, isBoxB);
                        return BplForall(bvarsInner, tr, imp);
                    };

                    var body = IsT;
                    for (int i = MutateCSharp.Schemata501.ReplaceNumericConstant_0(302L, 0); MutateCSharp.Schemata501.ReplaceBinExprOp_7(306L, i, arity); MutateCSharp.Schemata501.ReplacePostfixUnaryExprOp_8(311L, ref i))
                    {
                        body = BplAnd(body, Inner(typesU[i], typesT[i]));
                    }
                    body = BplAnd(body, Inner(typesT[arity], typesU[arity]));
                    body = BplImp(body, IsU);
                    sink.AddTopLevelDeclaration(new Axiom(tok,
                      BplForall(bvarsOuter, new Bpl.Trigger(tok, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(312L, true), new[] { IsT, IsU }), body)));
                }
                /*  This is the definition of $IsAlloc function the arrow type:
                  axiom (forall f: HandleType, t0: Ty, t1: Ty, h: Heap ::
                    { $IsAlloc(f, Tclass._System.___hFunc1(t0, t1), h) }
                    $IsGoodHeap(h)
                    ==>
                    (
                      $IsAlloc(f, Tclass._System.___hFunc1(t0, t1), h)
                        <==>
                        (forall bx0: Box ::
                          { Apply1(t0, t1, f, h, bx0) } { Reads1(t0, t1, f, h, bx0) }
                          $IsBox(bx0, t0) && $IsAllocBox(bx0, t0, h)
                          && precondition of f(bx0) holds in h
                          ==>
                            (everything in reads set of f(bx0) is allocated in h)
                    ));
                  However, for /allocated:0 and /allocated:1, IsAlloc for arrow types is trivially true
                  and implies nothing about the reads set.
                */
                {
                    var bvarsOuter = new List<Bpl.Variable>();
                    var f = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(313L, "f"), predef.HandleType, bvarsOuter);
                    var types = Map(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(314L, 0), MutateCSharp.Schemata501.ReplaceBinExprOp_2(322L, arity, MutateCSharp.Schemata501.ReplaceNumericConstant_0(318L, 1))), i => BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(331L, "t") + i, predef.Ty, bvarsOuter));
                    var h = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(332L, "h"), predef.HeapType, bvarsOuter);
                    var goodHeap = FunctionCall(tok, BuiltinFunction.IsGoodHeap, null, h);
                    var isAlloc = MkIsAlloc(f, ClassTyCon(ad, types), h);

                    var bvarsInner = new List<Bpl.Variable>();
                    var boxes = Map(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(333L, 0), arity), i => BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(337L, "bx") + i, predef.BoxType, bvarsInner));
                    var isAllocBoxes = BplAnd(Map(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(338L, 0), arity), i =>
                      BplAnd(MkIs(boxes[i], types[i], MutateCSharp.Schemata501.ReplaceBooleanConstant_1(342L, true)), MkIsAlloc(boxes[i], types[i], h, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(343L, true)))));
                    var pre = FunctionCall(tok, Requires(ad.Arity), predef.BoxType, Concat(types, Cons(h, Cons<Bpl.Expr>(f, boxes))));
                    var applied = FunctionCall(tok, Apply(ad.Arity), predef.BoxType, Concat(types, Cons(h, Cons<Bpl.Expr>(f, boxes))));

                    // (forall r: ref :: {Reads1(t0, t1, f, h, bx0)[$Box(r)]}  r != null && Reads1(t0, t1, f, h, bx0)[$Box(r)] ==> h[r, alloc])
                    var bvarsR = new List<Bpl.Variable>();
                    var r = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(344L, "r"), predef.RefType, bvarsR);
                    var rNonNull = Bpl.Expr.Neq(r, predef.Null);
                    var reads = FunctionCall(tok, Reads(ad.Arity), predef.BoxType, Concat(types, Cons(h, Cons<Bpl.Expr>(f, boxes))));
                    var rInReads = Bpl.Expr.Select(reads, FunctionCall(tok, BuiltinFunction.Box, null, r));
                    var rAlloc = IsAlloced(tok, h, r);
                    var isAllocReads = BplForall(bvarsR, BplTrigger(rInReads), BplImp(BplAnd(rNonNull, rInReads), rAlloc));

                    sink.AddTopLevelDeclaration(new Axiom(tok,
                      BplForall(bvarsOuter, BplTrigger(isAlloc),
                        BplImp(goodHeap,
                          BplIff(isAlloc,
                            BplForall(bvarsInner,
                              new Bpl.Trigger(tok, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(345L, true), new List<Bpl.Expr> { applied }, BplTrigger(reads)),
                              BplImp(BplAnd(isAllocBoxes, pre), isAllocReads)))))));
                }
                /*  This is the allocatedness consequence axiom of arrow types:
                  axiom (forall f: HandleType, t0: Ty, t1: Ty, h: Heap ::
                    { $IsAlloc(f, Tclass._System.___hFunc1(t0, t1), h) }
                    $IsGoodHeap(h) &&
                    $IsAlloc(f, Tclass._System.___hFunc1(t0, t1), h)
                    ==>
                        (forall bx0: Box ::
                          { Apply1(t0, t1, f, h, bx0) }
                          $IsAllocBox(bx0, t0, h)
                          && precondition of f(bx0) holds in h
                          ==>
                            $IsAllocBox(Apply1(t0, t1, f, h, bx0), t1, h))
                    ));
                */
                {
                    var bvarsOuter = new List<Bpl.Variable>();
                    var f = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(346L, "f"), predef.HandleType, bvarsOuter);
                    var types = Map(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(347L, 0), MutateCSharp.Schemata501.ReplaceBinExprOp_2(355L, arity, MutateCSharp.Schemata501.ReplaceNumericConstant_0(351L, 1))), i => BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(364L, "t") + i, predef.Ty, bvarsOuter));
                    var h = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(365L, "h"), predef.HeapType, bvarsOuter);
                    var goodHeap = FunctionCall(tok, BuiltinFunction.IsGoodHeap, null, h);
                    var isAlloc = MkIsAlloc(f, ClassTyCon(ad, types), h);

                    var bvarsInner = new List<Bpl.Variable>();
                    var boxes = Map(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(366L, 0), arity), i => BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(370L, "bx") + i, predef.BoxType, bvarsInner));
                    var isAllocBoxes = BplAnd(Map(Enumerable.Range(MutateCSharp.Schemata501.ReplaceNumericConstant_0(371L, 0), arity), i => MkIsAlloc(boxes[i], types[i], h, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(375L, true))));
                    var pre = FunctionCall(tok, Requires(ad.Arity), predef.BoxType, Concat(types, Cons(h, Cons<Bpl.Expr>(f, boxes))));
                    var applied = FunctionCall(tok, Apply(ad.Arity), predef.BoxType, Concat(types, Cons(h, Cons<Bpl.Expr>(f, boxes))));
                    var applied_isAlloc = MkIsAlloc(applied, types[ad.Arity], h, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(376L, true));

                    sink.AddTopLevelDeclaration(new Axiom(tok,
                      BplForall(bvarsOuter, BplTrigger(isAlloc),
                        BplImp(BplAnd(goodHeap, isAlloc),
                          BplForall(bvarsInner, BplTrigger(applied),
                            BplImp(BplAnd(isAllocBoxes, pre), applied_isAlloc))))));
                }
            }
        }

        private string AddTyAxioms(TopLevelDecl td)
        {
            Contract.Requires(td != null);
            IToken tok = td.tok;

            // use the internal type synonym, if any
            if (!RevealedInScope(td) && td is RevealableTypeDecl revealableTypeDecl)
            {
                td = revealableTypeDecl.SelfSynonymDecl();
            }
            Contract.Assume(td is SubsetTypeDecl or not TypeSynonymDecl); // this is expected of the caller

            var func = GetOrCreateTypeConstructor(td);
            var name = func.Name;

            // Produce uniqueness or injectivity axioms, unless the type is one that may (non-uniquely) stand for another type.
            if (td is not AbstractTypeDecl and not InternalTypeSynonymDecl)
            {
                var tagAxiom = CreateTagAndCallingForTypeConstructor(td);
                AddOtherDefinition(func, tagAxiom);

                // Create the injectivity axiom and its function
                /*
                   function List_0(Ty) : Ty;
                   axiom (forall t0: Ty :: { List(t0) } List_0(List(t0)) == t0);
                */
                for (int i = MutateCSharp.Schemata501.ReplaceNumericConstant_0(377L, 0); MutateCSharp.Schemata501.ReplaceBinExprOp_7(381L, i, func.InParams.Count); MutateCSharp.Schemata501.ReplacePostfixUnaryExprOp_8(386L, ref i))
                {
                    var args = MkTyParamBinders(td.TypeArgs, out var argExprs);
                    var inner = FunctionCall(tok, name, predef.Ty, argExprs);
                    Bpl.Variable tyVarIn = BplFormalVar(null, predef.Ty, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(387L, true));
                    Bpl.Variable tyVarOut = BplFormalVar(null, predef.Ty, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(388L, false));
                    var injname = name + MutateCSharp.Schemata501.ReplaceStringConstant_5(389L, "_") + i;
                    var injfunc = new Bpl.Function(tok, injname, Singleton(tyVarIn), tyVarOut);
                    sink.AddTopLevelDeclaration(injfunc);
                    var outer = FunctionCall(tok, injname, args[i].TypedIdent.Type, inner);
                    Bpl.Expr qq = BplForall(args, BplTrigger(inner), Bpl.Expr.Eq(outer, argExprs[i]));
                    var injectivityAxiom = new Axiom(tok, qq, name + MutateCSharp.Schemata501.ReplaceStringConstant_5(390L, " injectivity ") + i);
                    AddOtherDefinition(injfunc, injectivityAxiom);
                }
            }

            // Boxing axiom (important for the properties of unbox)
            /*
               axiom (forall T: Ty, bx: Box ::
                 { $IsBox(bx, List(T)) }
                 $IsBox(bx, List(T))
                    ==> $Box($Unbox(bx): DatatypeType) == bx
                     && $Is($Unbox(bx): DatatypeType, List(T)));
            */
            if (!ModeledAsBoxType(UserDefinedType.FromTopLevelDecl(td.tok, td)))
            {
                var args = MkTyParamBinders(td.TypeArgs, out var argExprs);
                var ty_repr = TrType(UserDefinedType.FromTopLevelDecl(td.tok, td));
                var typeTerm = FunctionCall(tok, name, predef.Ty, argExprs);
                AddBoxUnboxAxiom(tok, name, typeTerm, ty_repr, args);
            }

            return name;
        }

        /* Create the Tag and calling Tag on this type constructor
         *
         * The common case:
         *     const unique TagList: TyTag;
         *     const unique tytagFamily$List: TyTagFamily;  // defined once for each type named "List"
         *     axiom (forall t0: Ty :: { List(t0) } Tag(List(t0)) == TagList && TagFamily(List(t0)) == tytagFamily$List);
         * For types obtained via an abstract import, just do:
         *     const unique tytagFamily$List: TyTagFamily;  // defined once for each type named "List"
         *     axiom (forall t0: Ty :: { List(t0) } TagFamily(List(t0)) == tytagFamily$List);
         */
        private Axiom CreateTagAndCallingForTypeConstructor(TopLevelDecl td)
        {
            IToken tok = td.tok;
            var inner_name = GetClass(td).TypedIdent.Name;
            string name = MutateCSharp.Schemata501.ReplaceStringConstant_5(391L, "T") + inner_name;

            var args = MkTyParamBinders(td.TypeArgs, out var argExprs);
            var inner = FunctionCall(tok, name, predef.Ty, argExprs);
            Bpl.Expr body = Bpl.Expr.True;

            if (!td.EnclosingModuleDefinition.IsFacade)
            {
                var tagName = MutateCSharp.Schemata501.ReplaceStringConstant_5(392L, "Tag") + inner_name;
                var tag = new Bpl.Constant(tok, new Bpl.TypedIdent(tok, tagName, predef.TyTag), MutateCSharp.Schemata501.ReplaceBooleanConstant_1(393L, true));
                sink.AddTopLevelDeclaration(tag);
                body = Bpl.Expr.Eq(FunctionCall(tok, MutateCSharp.Schemata501.ReplaceStringConstant_5(394L, "Tag"), predef.TyTag, inner), new Bpl.IdentifierExpr(tok, tag));
            }

            if (!tytagConstants.TryGetValue(td.Name, out var tagFamily))
            {
                tagFamily = new Bpl.Constant(Token.NoToken,
                  new Bpl.TypedIdent(Token.NoToken, MutateCSharp.Schemata501.ReplaceStringConstant_5(395L, "tytagFamily$") + td.Name, predef.TyTagFamily), MutateCSharp.Schemata501.ReplaceBooleanConstant_1(396L, true));
                tytagConstants.Add(td.Name, tagFamily);
            }

            body = BplAnd(body,
              Bpl.Expr.Eq(FunctionCall(tok, MutateCSharp.Schemata501.ReplaceStringConstant_5(397L, "TagFamily"), predef.TyTagFamily, inner), new Bpl.IdentifierExpr(tok, tagFamily)));

            var qq = BplForall(args, BplTrigger(inner), body);
            var tagAxiom = new Axiom(tok, qq, name + MutateCSharp.Schemata501.ReplaceStringConstant_5(398L, " Tag"));
            return tagAxiom;
        }

        private void AddBitvectorTypeAxioms(int w)
        {
            Contract.Requires(0 <= w);

            if (MutateCSharp.Schemata501.ReplaceBinExprOp_9(403L, w, MutateCSharp.Schemata501.ReplaceNumericConstant_0(399L, 0)))
            {
                // the axioms for bv0 are already in DafnyPrelude.bpl
                return;
            }

            // box/unbox axiom
            var tok = Token.NoToken;
            var printableName = MutateCSharp.Schemata501.ReplaceStringConstant_5(408L, "bv") + w;
            var dafnyType = new BitvectorType(options, w);
            var boogieType = BplBvType(w);
            var typeTerm = TypeToTy(dafnyType);
            AddBoxUnboxAxiom(tok, printableName, typeTerm, boogieType, new List<Variable>());

            // axiom (forall v: bv3 :: { $Is(v, TBitvector(3)) } $Is(v, TBitvector(3)));
            var vVar = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(409L, "v"), boogieType, out var v);
            var bvs = new List<Variable>() { vVar };
            var isBv = MkIs(v, typeTerm);
            var tr = BplTrigger(isBv);
            sink.AddTopLevelDeclaration(new Bpl.Axiom(tok, new Bpl.ForallExpr(tok, bvs, tr, isBv)));

            // axiom (forall v: bv3, heap: Heap :: { $IsAlloc(v, TBitvector(3), h) } $IsAlloc(v, TBitvector(3), heap));
            vVar = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(410L, "v"), boogieType, out v);
            var heapVar = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(411L, "heap"), predef.HeapType, out var heap);
            bvs = new List<Variable>() { vVar, heapVar };
            var isAllocBv = MkIsAlloc(v, typeTerm, heap);
            tr = BplTrigger(isAllocBv);
            sink.AddTopLevelDeclaration(new Bpl.Axiom(tok, new Bpl.ForallExpr(tok, bvs, tr, isAllocBv)));
        }

        /// <summary>
        /// Generate:
        ///     axiom (forall args: Ty, bx: Box ::
        ///       { $IsBox(bx, name(argExprs)) }
        ///       $IsBox(bx, name(argExprs)) ==>
        ///         $Box($Unbox(bx): tyRepr) == bx &&
        ///         $Is($Unbox(bx): tyRepr, name(argExprs)));
        /// </summary>
        private void AddBoxUnboxAxiom(IToken tok, string printableName, Bpl.Expr typeTerm, Bpl.Type tyRepr, List<Variable> args)
        {
            Contract.Requires(tok != null);
            Contract.Requires(printableName != null);
            Contract.Requires(typeTerm != null);
            Contract.Requires(tyRepr != null);
            Contract.Requires(args != null);

            var bxVar = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(412L, "bx"), predef.BoxType, out var bx);
            var unbox = FunctionCall(tok, BuiltinFunction.Unbox, tyRepr, bx);
            var box_is = MkIs(bx, typeTerm, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(413L, true));
            var unbox_is = MkIs(unbox, typeTerm, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(414L, false));
            var box_unbox = FunctionCall(tok, BuiltinFunction.Box, null, unbox);
            sink.AddTopLevelDeclaration(
              new Axiom(tok,
                BplForall(Snoc(args, bxVar), BplTrigger(box_is),
                  BplImp(box_is, BplAnd(Bpl.Expr.Eq(box_unbox, bx), unbox_is))),
        MutateCSharp.Schemata501.ReplaceStringConstant_5(415L, "Box/unbox axiom for ") + printableName));
        }


        private void GenerateAndCheckGuesses(IToken tok, List<BoundVar> bvars, List<BoundedPool> bounds, Expression expr, Trigger triggers, BoogieStmtListBuilder builder, ExpressionTranslator etran)
        {
            Contract.Requires(tok != null);
            Contract.Requires(bvars != null);
            Contract.Requires(bounds != null);
            Contract.Requires(expr != null);
            Contract.Requires(builder != null);
            Contract.Requires(etran != null);

            List<Tuple<List<Tuple<BoundVar, Expression>>, Expression>> partialGuesses = GeneratePartialGuesses(bvars, expr);
            Bpl.Expr w = Bpl.Expr.False;
            foreach (var tup in partialGuesses)
            {
                var body = etran.TrExpr(tup.Item2);
                Bpl.Expr typeConstraints = Bpl.Expr.True;
                var undetermined = new List<BoundVar>();
                foreach (var be in tup.Item1)
                {
                    if (MutateCSharp.Schemata501.ReplaceBinExprOp_10(416L, be.Item2, null))
                    {
                        undetermined.Add(be.Item1);
                    }
                    else
                    {
                        typeConstraints = BplAnd(typeConstraints, MkIs(etran.TrExpr(be.Item2), be.Item1.Type));
                    }
                }
                body = BplAnd(typeConstraints, body);
                if (MutateCSharp.Schemata501.ReplaceBinExprOp_4(421L, undetermined.Count, MutateCSharp.Schemata501.ReplaceNumericConstant_0(417L, 0)))
                {
                    List<bool> freeOfAlloc = BoundedPool.HasBounds(bounds, BoundedPool.PoolVirtues.IndependentOfAlloc_or_ExplicitAlloc);
                    var bvs = new List<Variable>();
                    var typeAntecedent = etran.TrBoundVariables(undetermined, bvs, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(426L, false), freeOfAlloc);
                    body = new Bpl.ExistsExpr(tok, bvs, triggers, BplAnd(typeAntecedent, body));
                }
                w = BplOr(body, w);
            }
            builder.Add(Assert(tok, w, new PODesc.LetSuchThatExists(bvars, expr)));
        }

        List<Tuple<List<Tuple<BoundVar, Expression>>, Expression>> GeneratePartialGuesses(List<BoundVar> bvars, Expression expression)
        {
            if (MutateCSharp.Schemata501.ReplaceBinExprOp_9(431L, bvars.Count, MutateCSharp.Schemata501.ReplaceNumericConstant_0(427L, 0)))
            {
                var tup = new Tuple<List<Tuple<BoundVar, Expression>>, Expression>(new List<Tuple<BoundVar, Expression>>(), expression);
                return new List<Tuple<List<Tuple<BoundVar, Expression>>, Expression>>() { tup };
            }
            var result = new List<Tuple<List<Tuple<BoundVar, Expression>>, Expression>>();
            var x = bvars[MutateCSharp.Schemata501.ReplaceNumericConstant_0(436L, 0)];
            var otherBvars = bvars.GetRange(MutateCSharp.Schemata501.ReplaceNumericConstant_0(440L, 1), MutateCSharp.Schemata501.ReplaceBinExprOp_11(448L, bvars.Count, MutateCSharp.Schemata501.ReplaceNumericConstant_0(444L, 1)));
            foreach (var tup in GeneratePartialGuesses(otherBvars, expression))
            {
                // in the special case that x does not even occur in expression (and we know the type has a value for x), we can just ignore x
                if (MutateCSharp.Schemata501.ReplaceBinExprOp_12(458L, () => !FreeVariablesUtil.ContainsFreeVariable(tup.Item2, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(457L, false), x), () => x.Type.KnownToHaveToAValue(x.IsGhost)))
                {
                    result.Add(tup);
                    continue;
                }
                // one possible result is to quantify over all the variables
                var vs = new List<Tuple<BoundVar, Expression>>() { new Tuple<BoundVar, Expression>(x, null) };
                vs.AddRange(tup.Item1);
                result.Add(new Tuple<List<Tuple<BoundVar, Expression>>, Expression>(vs, tup.Item2));
                // other possibilities involve guessing a value for x
                foreach (var guess in GuessWitnesses(x, tup.Item2))
                {
                    var g = Substitute(tup.Item2, x, guess);
                    vs = new List<Tuple<BoundVar, Expression>>() { new Tuple<BoundVar, Expression>(x, guess) };
                    AddRangeSubst(vs, tup.Item1, x, guess);
                    result.Add(new Tuple<List<Tuple<BoundVar, Expression>>, Expression>(vs, g));
                }
            }
            return result;
        }

        private void AddRangeSubst(List<Tuple<BoundVar, Expression>> vs, List<Tuple<BoundVar, Expression>> aa, IVariable v, Expression e)
        {
            Contract.Requires(vs != null);
            Contract.Requires(aa != null);
            Contract.Requires(v != null);
            Contract.Requires(e != null);
            foreach (var be in aa)
            {
                if (MutateCSharp.Schemata501.ReplaceBinExprOp_10(464L, be.Item2, null))
                {
                    vs.Add(be);
                }
                else
                {
                    vs.Add(new Tuple<BoundVar, Expression>(be.Item1, Substitute(be.Item2, v, e)));
                }
            }
        }

        IEnumerable<Expression> GuessWitnesses(BoundVar x, Expression expr)
        {
            Contract.Requires(x != null);
            Contract.Requires(expr != null);
            var xType = x.Type.NormalizeExpand();
            if (xType is BoolType)
            {
                var lit = Expression.CreateBoolLiteral(x.tok, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(465L, false));
                yield return lit;
                lit = Expression.CreateBoolLiteral(x.tok, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(466L, true));
                yield return lit;
                yield break;  // there are no more possible witnesses for booleans
            }
            else if (xType is CharType)
            {
                // TODO: something could be done for character literals
            }
            else if (xType.IsBitVectorType)
            {
                // TODO: something could be done for bitvectors
            }
            else if (xType.IsRefType)
            {
                var lit = new LiteralExpr(x.tok) { Type = xType };  // null
                yield return lit;
            }
            else if (xType.IsDatatype)
            {
                var dt = xType.AsDatatype;
                Expression zero = Zero(x.tok, xType);
                if (MutateCSharp.Schemata501.ReplaceBinExprOp_13(467L, zero, null))
                {
                    yield return zero;
                }
                foreach (var ctor in dt.Ctors)
                {
                    if (MutateCSharp.Schemata501.ReplaceBinExprOp_9(472L, ctor.Formals.Count, MutateCSharp.Schemata501.ReplaceNumericConstant_0(468L, 0)))
                    {
                        var v = new DatatypeValue(x.tok, dt.Name, ctor.Name, new List<Expression>());
                        v.Ctor = ctor;  // resolve here
                        v.InferredTypeArgs = xType.TypeArgs; // resolved here.
                        v.Type = xType;  // resolve here
                        yield return v;
                    }
                }
            }
            else if (xType is SetType)
            {
                var empty = new SetDisplayExpr(x.tok, ((SetType)xType).Finite, new List<Expression>());
                empty.Type = xType;
                yield return empty;
            }
            else if (xType is MultiSetType)
            {
                var empty = new MultiSetDisplayExpr(x.tok, new List<Expression>());
                empty.Type = xType;
                yield return empty;
            }
            else if (xType is SeqType)
            {
                var empty = new SeqDisplayExpr(x.tok, new List<Expression>());
                empty.Type = xType;
                yield return empty;
            }
            else if (xType.IsNumericBased(Type.NumericPersuasion.Int))
            {
                var lit = new LiteralExpr(x.tok, MutateCSharp.Schemata501.ReplaceNumericConstant_0(477L, 0));
                lit.Type = xType;  // resolve here
                yield return lit;
            }
            else if (xType.IsNumericBased(Type.NumericPersuasion.Real))
            {
                var lit = new LiteralExpr(x.tok, BaseTypes.BigDec.ZERO);
                lit.Type = xType;  // resolve here
                yield return lit;
            }

            var bounds = ModuleResolver.DiscoverAllBounds_SingleVar(x, expr, out _);
            foreach (var bound in bounds)
            {
                if (bound is IntBoundedPool)
                {
                    var bnd = (IntBoundedPool)bound;
                    if (MutateCSharp.Schemata501.ReplaceBinExprOp_13(481L, bnd.LowerBound, null))
                    {
                        yield return bnd.LowerBound;
                    }

                    if (MutateCSharp.Schemata501.ReplaceBinExprOp_13(482L, bnd.UpperBound, null))
                    {
                        yield return Expression.CreateDecrement(bnd.UpperBound, MutateCSharp.Schemata501.ReplaceNumericConstant_0(483L, 1));
                    }
                }
                else if (bound is SubSetBoundedPool)
                {
                    var bnd = (SubSetBoundedPool)bound;
                    yield return bnd.UpperBound;
                }
                else if (bound is SuperSetBoundedPool)
                {
                    var bnd = (SuperSetBoundedPool)bound;
                    yield return bnd.LowerBound;
                }
                else if (bound is SetBoundedPool)
                {
                    var st = ((SetBoundedPool)bound).Set.Resolved;
                    if (st is DisplayExpression)
                    {
                        var display = (DisplayExpression)st;
                        foreach (var el in display.Elements)
                        {
                            yield return el;
                        }
                    }
                    else if (st is MapDisplayExpr)
                    {
                        var display = (MapDisplayExpr)st;
                        foreach (var maplet in display.Elements)
                        {
                            yield return maplet.A;
                        }
                    }
                }
                else if (bound is MultiSetBoundedPool)
                {
                    var st = ((MultiSetBoundedPool)bound).MultiSet.Resolved;
                    if (st is DisplayExpression)
                    {
                        var display = (DisplayExpression)st;
                        foreach (var el in display.Elements)
                        {
                            yield return el;
                        }
                    }
                    else if (st is MapDisplayExpr)
                    {
                        var display = (MapDisplayExpr)st;
                        foreach (var maplet in display.Elements)
                        {
                            yield return maplet.A;
                        }
                    }
                }
                else if (bound is SeqBoundedPool)
                {
                    var sq = ((SeqBoundedPool)bound).Seq.Resolved;
                    var display = sq as DisplayExpression;
                    if (MutateCSharp.Schemata501.ReplaceBinExprOp_14(487L, display, null))
                    {
                        foreach (var el in display.Elements)
                        {
                            yield return el;
                        }
                    }
                }
                else if (bound is ExactBoundedPool)
                {
                    yield return ((ExactBoundedPool)bound).E;
                }
            }

            yield break;
        }

        /// <summary>
        /// Return a zero-equivalent value for "typ", or return null (for any reason whatsoever).
        /// </summary>
        Expression Zero(IToken tok, Type typ)
        {
            Contract.Requires(tok != null);
            Contract.Requires(typ != null);
            typ = typ.NormalizeToAncestorType();
            if (typ is BoolType)
            {
                return Expression.CreateBoolLiteral(tok, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(488L, false));
            }
            else if (typ is CharType)
            {
                var z = new CharLiteralExpr(tok, CharType.DefaultValue.ToString());
                z.Type = Type.Char;  // resolve here
                return z;
            }
            else if (typ.IsNumericBased(Type.NumericPersuasion.Int))
            {
                return Expression.CreateIntLiteral(tok, MutateCSharp.Schemata501.ReplaceNumericConstant_0(489L, 0));
            }
            else if (typ.IsNumericBased(Type.NumericPersuasion.Real))
            {
                return Expression.CreateRealLiteral(tok, BaseTypes.BigDec.ZERO);
            }
            else if (typ.IsBigOrdinalType)
            {
                return Expression.CreateNatLiteral(tok, MutateCSharp.Schemata501.ReplaceNumericConstant_0(493L, 0), Type.BigOrdinal);
            }
            else if (typ.IsBitVectorType)
            {
                var z = new LiteralExpr(tok, MutateCSharp.Schemata501.ReplaceNumericConstant_0(497L, 0));
                z.Type = typ;
                return z;
            }
            else if (typ.IsRefType)
            {
                var z = new LiteralExpr(tok);  // null
                z.Type = typ;
                return z;
            }
            else if (typ.IsDatatype)
            {
                return null;  // this can be improved
            }
            else if (typ is SetType)
            {
                var empty = new SetDisplayExpr(tok, ((SetType)typ).Finite, new List<Expression>());
                empty.Type = typ;
                return empty;
            }
            else if (typ is MultiSetType)
            {
                var empty = new MultiSetDisplayExpr(tok, new List<Expression>());
                empty.Type = typ;
                return empty;
            }
            else if (typ is SeqType)
            {
                var empty = new SeqDisplayExpr(tok, new List<Expression>());
                empty.Type = typ;
                return empty;
            }
            else if (typ is MapType)
            {
                var empty = new MapDisplayExpr(tok, ((MapType)typ).Finite, new List<ExpressionPair>());
                empty.Type = typ;
                return empty;
            }
            else if (typ is ArrowType)
            {
                // TODO: do better than just returning null
                return null;
            }
            else if (MutateCSharp.Schemata501.ReplaceBinExprOp_15(501L, () => typ.IsAbstractType, () => typ.IsInternalTypeSynonym))
            {
                return null;
            }
            else if (typ.IsTraitType)
            {
                Contract.Assert(options.Get(CommonOptionBag.GeneralTraits) != CommonOptionBag.GeneralTraitsOptions.Legacy);
                return null;
            }
            else
            {
                Contract.Assume(false);  // unexpected type
                return null;
            }

            return default;
        }

        void AddRevealableTypeDecl(RevealableTypeDecl d)
        {
            Contract.Requires(d != null);
            if (RevealedInScope(d))
            {
                if (d is NewtypeDecl)
                {
                    var dd = (NewtypeDecl)d;
                    AddTypeDecl(dd);
                    AddClassMembers(dd, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(507L, true), MutateCSharp.Schemata501.ReplaceBooleanConstant_1(508L, true));
                }
                else if (d is DefaultClassDecl defaultClassDecl)
                {
                    AddClassMembers(defaultClassDecl, MutateCSharp.Schemata501.ReplaceBinExprOp_7(513L, options.OptimizeResolution, MutateCSharp.Schemata501.ReplaceNumericConstant_0(509L, 1)), MutateCSharp.Schemata501.ReplaceBooleanConstant_1(518L, true));
                }
                else if (d is ClassLikeDecl)
                {
                    var cl = (ClassLikeDecl)d;
                    AddClassMembers(cl, MutateCSharp.Schemata501.ReplaceBinExprOp_7(523L, options.OptimizeResolution, MutateCSharp.Schemata501.ReplaceNumericConstant_0(519L, 1)), MutateCSharp.Schemata501.ReplaceBooleanConstant_1(528L, true));
                    if (MutateCSharp.Schemata501.ReplaceBinExprOp_16(529L, cl.NonNullTypeDecl, null))
                    {
                        AddTypeDecl(cl.NonNullTypeDecl);
                    }
                    if (d is IteratorDecl)
                    {
                        AddIteratorSpecAndBody((IteratorDecl)d);
                    }
                }
                else if (d is DatatypeDecl)
                {
                    var dd = (DatatypeDecl)d;
                    AddDatatype(dd);
                    AddClassMembers(dd, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(530L, true), MutateCSharp.Schemata501.ReplaceBooleanConstant_1(531L, true));
                }
                else if (d is SubsetTypeDecl)
                {
                    AddTypeDecl((SubsetTypeDecl)d);
                }
                else if (d is TypeSynonymDecl)
                {
                    //do nothing, this type will be transparent to translation
                }
                else
                {
                    Contract.Assert(false);
                }
            }
            else
            {
                // Create a type constructor for the export-provided type. But note:
                //   -- A DefaultClassDecl does not need a type constructor.
                //   -- Reference types give rise to two type declarations, the nullable version and the non-null version.
                //      For a type that is only export-provided, the type that is exported is an abstract-type version
                //      of the non-null type. Thus, for a class declaration and reference-type trait declaration, we
                //      do not create a type constructor.
                if (MutateCSharp.Schemata501.ReplaceBinExprOp_12(532L, () => d is not DefaultClassDecl, () => d is not ClassLikeDecl { IsReferenceTypeDecl: true }))
                {
                    GetOrCreateTypeConstructor(d.SelfSynonymDecl());
                }

                if (d is TopLevelDeclWithMembers topLevelDeclWithMembers)
                {
                    AddClassMembers(topLevelDeclWithMembers, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(538L, true), MutateCSharp.Schemata501.ReplaceBooleanConstant_1(539L, false));
                }
            }
        }

        void AddTypeDecl(NewtypeDecl dd)
        {
            Contract.Requires(dd != null);
            Contract.Ensures(fuelContext == Contract.OldValue(fuelContext));

            FuelContext oldFuelContext = this.fuelContext;
            this.fuelContext = FuelSetting.NewFuelContext(dd);

            if (MutateCSharp.Schemata501.ReplaceBinExprOp_17(540L, dd.Var, null))
            {
                AddWellformednessCheck(dd);
            }

            // Add $Is and $IsAlloc axioms for the newtype
            currentModule = dd.EnclosingModuleDefinition;
            AddRedirectingTypeDeclAxioms(MutateCSharp.Schemata501.ReplaceBooleanConstant_1(541L, false), dd, dd.FullName);
            AddRedirectingTypeDeclAxioms(MutateCSharp.Schemata501.ReplaceBooleanConstant_1(542L, true), dd, dd.FullName);
            currentModule = null;

            this.fuelContext = oldFuelContext;
        }

        void AddTypeDecl(SubsetTypeDecl dd)
        {
            Contract.Requires(dd != null);
            Contract.Ensures(fuelContext == Contract.OldValue(fuelContext));

            FuelContext oldFuelContext = this.fuelContext;
            this.fuelContext = FuelSetting.NewFuelContext(dd);

            if (!Attributes.Contains(dd.Attributes, MutateCSharp.Schemata501.ReplaceStringConstant_5(543L, "axiom")))
            {
                AddWellformednessCheck(dd);
            }
            currentModule = dd.EnclosingModuleDefinition;
            // Add $Is and $IsAlloc axioms for the subset type
            AddRedirectingTypeDeclAxioms(MutateCSharp.Schemata501.ReplaceBooleanConstant_1(544L, false), dd, dd.FullName);
            AddRedirectingTypeDeclAxioms(MutateCSharp.Schemata501.ReplaceBooleanConstant_1(545L, true), dd, dd.FullName);
            currentModule = null;
            this.fuelContext = oldFuelContext;
        }

        /**
         * Example:
          // _System.object: subset type $Is
          axiom (forall c#0: ref :: 
            { $Is(c#0, Tclass._System.object()) } 
            $Is(c#0, Tclass._System.object())
               <==> $Is(c#0, Tclass._System.object?()) && c#0 != null);

          // _System.object: subset type $IsAlloc
          axiom (forall c#0: ref, $h: Heap :: 
            { $IsAlloc(c#0, Tclass._System.object(), $h) } 
            $IsAlloc(c#0, Tclass._System.object(), $h)
               <==> $IsAlloc(c#0, Tclass._System.object?(), $h));
         */
        void AddRedirectingTypeDeclAxioms<T>(bool is_alloc, T dd, string fullName)
          where T : TopLevelDecl, RedirectingTypeDecl
        {
            Contract.Requires(dd != null);
            Contract.Requires((dd.Var != null && dd.Constraint != null) || dd is NewtypeDecl);
            Contract.Requires(fullName != null);

            List<Bpl.Expr> typeArgs;
            var vars = MkTyParamBinders(dd.TypeArgs, out typeArgs);
            var o_ty = ClassTyCon(dd, typeArgs);

            var baseType = MutateCSharp.Schemata501.ReplaceBinExprOp_17(546L, dd.Var, null) ? dd.Var.Type : ((NewtypeDecl)(object)dd).BaseType;
            var oBplType = TrType(baseType);
            var c = new BoundVar(dd.tok, CurrentIdGenerator.FreshId(MutateCSharp.Schemata501.ReplaceStringConstant_5(547L, "c")), baseType);
            var o = BplBoundVar((dd.Var ?? c).AssignUniqueName((dd.IdGenerator)), oBplType, vars);

            Bpl.Expr body, is_o;
            string comment;

            if (is_alloc)
            {
                comment = $"$IsAlloc axiom for {dd.WhatKind} {fullName}";
                var h = BplBoundVar(MutateCSharp.Schemata501.ReplaceStringConstant_5(548L, "$h"), predef.HeapType, vars);
                // $IsAlloc(o, ..)
                is_o = MkIsAlloc(o, o_ty, h, ModeledAsBoxType(baseType));
                if (MutateCSharp.Schemata501.ReplaceBinExprOp_15(561L, () => MutateCSharp.Schemata501.ReplaceBinExprOp_15(555L, () => MutateCSharp.Schemata501.ReplaceBinExprOp_15(549L, () => baseType.IsNumericBased(), () => baseType.IsBitVectorType), () => baseType.IsBoolType), () => baseType.IsCharType))
                {
                    body = is_o;
                }
                else
                {
                    Bpl.Expr rhs = MkIsAlloc(o, baseType, h);
                    body = BplIff(is_o, rhs);
                }
            }
            else
            {
                comment = $"$Is axiom for {dd.WhatKind} {fullName}";
                // $Is(o, ..)
                is_o = MkIs(o, o_ty, ModeledAsBoxType(baseType));
                var etran = new ExpressionTranslator(this, predef, NewOneHeapExpr(dd.tok), null);
                Bpl.Expr parentConstraint, constraint;
                if (MutateCSharp.Schemata501.ReplaceBinExprOp_15(579L, () => MutateCSharp.Schemata501.ReplaceBinExprOp_15(573L, () => MutateCSharp.Schemata501.ReplaceBinExprOp_15(567L, () => baseType.IsNumericBased(), () => baseType.IsBitVectorType), () => baseType.IsBoolType), () => baseType.IsCharType))
                {
                    // optimize this to only use the numeric/bitvector constraint, not the whole $Is thing on the base type
                    parentConstraint = Bpl.Expr.True;
                    var udt = UserDefinedType.FromTopLevelDecl(dd.tok, dd);
                    var substitutee = Expression.CreateIdentExpr(dd.Var ?? c);
                    constraint = etran.TrExpr(ModuleResolver.GetImpliedTypeConstraint(substitutee, udt));
                }
                else
                {
                    parentConstraint = MkIs(o, baseType);
                    // conjoin the constraint
                    constraint = etran.TrExpr(dd.Constraint ?? Expression.CreateBoolLiteral(dd.tok, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(585L, true)));
                }
                body = BplIff(is_o, BplAnd(parentConstraint, constraint));
            }

            var axiom = new Bpl.Axiom(dd.tok, BplForall(vars, BplTrigger(is_o), body), comment);
            AddOtherDefinition(GetOrCreateTypeConstructor(dd), axiom);
        }


        /// <summary>
        /// Returns the translation of converting "r", whose Dafny type was "fromType", to a value of type "toType".
        /// The translation assumes that "r" is known to be a value of type "toType".
        /// </summary>
        Bpl.Expr ConvertExpression(IToken tok, Bpl.Expr r, Type fromType, Type toType)
        {
            Contract.Requires(tok != null);
            Contract.Requires(r != null);
            Contract.Requires(fromType != null);
            Contract.Requires(toType != null);
            toType = toType.NormalizeToAncestorType();
            fromType = fromType.NormalizeToAncestorType();
            if (fromType.IsNumericBased(Type.NumericPersuasion.Int))
            {
                if (toType.IsNumericBased(Type.NumericPersuasion.Int))
                {
                    // do nothing
                }
                else if (toType.IsNumericBased(Type.NumericPersuasion.Real))
                {
                    r = FunctionCall(tok, BuiltinFunction.IntToReal, null, r);
                }
                else if (toType.IsCharType)
                {
                    r = FunctionCall(tok, BuiltinFunction.CharFromInt, null, r);
                }
                else if (toType.IsBitVectorType)
                {
                    r = IntToBV(tok, r, toType);
                }
                else if (toType.IsBigOrdinalType)
                {
                    r = FunctionCall(tok, MutateCSharp.Schemata501.ReplaceStringConstant_5(586L, "ORD#FromNat"), predef.BigOrdinalType, r);
                }
                else
                {
                    Contract.Assert(false, $"No translation implemented from {fromType} to {toType}");
                }
                return r;
            }
            else if (fromType.IsBitVectorType)
            {
                var fromWidth = fromType.AsBitVectorType.Width;
                if (toType.IsBitVectorType)
                {
                    // conversion from one bitvector type to another
                    var toWidth = toType.AsBitVectorType.Width;
                    if (MutateCSharp.Schemata501.ReplaceBinExprOp_9(587L, fromWidth, toWidth))
                    {
                        // no conversion
                    }
                    else if (MutateCSharp.Schemata501.ReplaceBinExprOp_7(592L, fromWidth, toWidth))
                    {
                        var zeros = BplBvLiteralExpr(tok, BaseTypes.BigNum.ZERO, MutateCSharp.Schemata501.ReplaceBinExprOp_11(597L, toWidth, fromWidth));
                        if (MutateCSharp.Schemata501.ReplaceBinExprOp_9(610L, fromWidth, MutateCSharp.Schemata501.ReplaceNumericConstant_0(606L, 0)))
                        {
                            r = zeros;
                        }
                        else
                        {
                            var concat = new Bpl.BvConcatExpr(tok, zeros, r);
                            // There's a bug in Boogie that causes a warning to be emitted if a BvConcatExpr is passed as the argument
                            // to $Box, which takes a type argument.  The bug can apparently be worked around by giving an explicit
                            // (and other redudant) type conversion.
                            r = Bpl.Expr.CoerceType(tok, concat, BplBvType(toWidth));
                        }
                    }
                    else if (MutateCSharp.Schemata501.ReplaceBinExprOp_9(619L, toWidth, MutateCSharp.Schemata501.ReplaceNumericConstant_0(615L, 0)))
                    {
                        r = BplBvLiteralExpr(tok, BaseTypes.BigNum.ZERO, toWidth);
                    }
                    else
                    {
                        r = new Bpl.BvExtractExpr(tok, r, toWidth, MutateCSharp.Schemata501.ReplaceNumericConstant_0(624L, 0));
                    }
                }
                else if (toType.IsNumericBased(Type.NumericPersuasion.Int))
                {
                    r = FunctionCall(tok, MutateCSharp.Schemata501.ReplaceStringConstant_5(628L, "nat_from_bv") + fromWidth, Bpl.Type.Int, r);
                }
                else if (toType.IsNumericBased(Type.NumericPersuasion.Real))
                {
                    r = FunctionCall(tok, MutateCSharp.Schemata501.ReplaceStringConstant_5(629L, "nat_from_bv") + fromWidth, Bpl.Type.Int, r);
                    r = FunctionCall(tok, BuiltinFunction.IntToReal, null, r);
                }
                else if (toType.IsCharType)
                {
                    r = FunctionCall(tok, MutateCSharp.Schemata501.ReplaceStringConstant_5(630L, "nat_from_bv") + fromWidth, Bpl.Type.Int, r);
                    r = FunctionCall(tok, BuiltinFunction.CharFromInt, null, r);
                }
                else if (toType.IsBigOrdinalType)
                {
                    r = FunctionCall(tok, MutateCSharp.Schemata501.ReplaceStringConstant_5(631L, "nat_from_bv") + fromWidth, Bpl.Type.Int, r);
                    r = FunctionCall(tok, MutateCSharp.Schemata501.ReplaceStringConstant_5(632L, "ORD#FromNat"), predef.BigOrdinalType, r);
                }
                else
                {
                    Contract.Assert(false, $"No translation implemented from {fromType} to {toType}");
                }
                return r;
            }
            else if (fromType.IsCharType)
            {
                if (toType.IsNumericBased(Type.NumericPersuasion.Int))
                {
                    r = FunctionCall(tok, BuiltinFunction.CharToInt, null, r);
                }
                else if (toType.IsCharType)
                {
                    // do nothing
                }
                else if (toType.IsNumericBased(Type.NumericPersuasion.Real))
                {
                    r = FunctionCall(tok, BuiltinFunction.CharToInt, null, r);
                    r = FunctionCall(tok, BuiltinFunction.IntToReal, null, r);
                }
                else if (toType.IsBitVectorType)
                {
                    r = FunctionCall(tok, BuiltinFunction.CharToInt, null, r);
                    r = IntToBV(tok, r, toType);
                }
                else if (toType.IsBigOrdinalType)
                {
                    r = FunctionCall(tok, BuiltinFunction.CharToInt, null, r);
                    r = FunctionCall(tok, MutateCSharp.Schemata501.ReplaceStringConstant_5(633L, "ORD#FromNat"), Bpl.Type.Int, r);
                }
                else
                {
                    Contract.Assert(false, $"No translation implemented from {fromType} to {toType}");
                }
                return r;
            }
            else if (fromType.IsNumericBased(Type.NumericPersuasion.Real))
            {
                if (toType.IsNumericBased(Type.NumericPersuasion.Real))
                {
                    // do nothing
                }
                else if (toType.IsNumericBased(Type.NumericPersuasion.Int))
                {
                    r = FunctionCall(tok, BuiltinFunction.RealToInt, null, r);
                }
                else if (toType.IsBitVectorType)
                {
                    r = FunctionCall(tok, BuiltinFunction.RealToInt, null, r);
                    r = IntToBV(tok, r, toType);
                }
                else if (toType.IsCharType)
                {
                    r = FunctionCall(tok, BuiltinFunction.RealToInt, null, r);
                    r = FunctionCall(tok, BuiltinFunction.CharFromInt, null, r);
                }
                else if (toType.IsBigOrdinalType)
                {
                    r = FunctionCall(tok, BuiltinFunction.RealToInt, null, r);
                    r = FunctionCall(tok, MutateCSharp.Schemata501.ReplaceStringConstant_5(634L, "ORD#FromNat"), Bpl.Type.Int, r);
                }
                else
                {
                    Contract.Assert(false, $"No translation implemented from {fromType} to {toType}");
                }
                return r;
                // "r" now denotes an integer
            }
            else if (fromType.IsBigOrdinalType)
            {
                if (toType.IsNumericBased(Type.NumericPersuasion.Int))
                {
                    r = FunctionCall(tok, MutateCSharp.Schemata501.ReplaceStringConstant_5(635L, "ORD#Offset"), Bpl.Type.Int, r);
                }
                else if (toType.IsNumericBased(Type.NumericPersuasion.Real))
                {
                    r = FunctionCall(tok, MutateCSharp.Schemata501.ReplaceStringConstant_5(636L, "ORD#Offset"), Bpl.Type.Int, r);
                    r = FunctionCall(tok, BuiltinFunction.IntToReal, null, r);
                }
                else if (toType.IsCharType)
                {
                    r = FunctionCall(tok, MutateCSharp.Schemata501.ReplaceStringConstant_5(637L, "ORD#Offset"), Bpl.Type.Int, r);
                    r = FunctionCall(tok, BuiltinFunction.CharFromInt, null, r);
                }
                else if (toType.IsBitVectorType)
                {
                    r = FunctionCall(tok, MutateCSharp.Schemata501.ReplaceStringConstant_5(638L, "ORD#Offset"), Bpl.Type.Int, r);
                    r = IntToBV(tok, r, toType);
                }
                else if (toType.IsBigOrdinalType)
                {
                    // do nothing
                }
                else
                {
                    Contract.Assert(false, $"No translation implemented from {fromType} to {toType}");
                }
                return r;
            }
            else if (MutateCSharp.Schemata501.ReplaceBinExprOp_12(639L, () => fromType.IsRefType, () => toType.IsRefType))
            {
                return r;
            }
            else if (fromType.IsRefType)
            {
                Contract.Assert(toType.IsTraitType);
                return BoxIfNecessary(r.tok, r, fromType);
            }
            else if (toType.IsRefType)
            {
                Contract.Assert(fromType.IsTraitType);
                return UnboxUnlessInherentlyBoxed(r, toType);
            }
            else if (toType.IsTraitType)
            {
                // cast to a non-reference trait
                return BoxIfNecessary(r.tok, r, fromType);
            }
            else if (fromType.IsTraitType)
            {
                // cast from a non-reference trait
                return UnboxUnlessInherentlyBoxed(r, toType);
            }
            else if (MutateCSharp.Schemata501.ReplaceBinExprOp_15(653L, () => MutateCSharp.Schemata501.ReplaceBinExprOp_15(646L, () => fromType.Equals(toType), () => MutateCSharp.Schemata501.ReplaceBinExprOp_18(645L, fromType.AsNewtype, null)), () => MutateCSharp.Schemata501.ReplaceBinExprOp_18(652L, toType.AsNewtype, null)))
            {
                return r;
            }
            else
            {
                Contract.Assert(false, $"No translation implemented from {fromType} to {toType}");
            }
            return r;
        }

        private Bpl.Expr IntToBV(IToken tok, Bpl.Expr r, Type toType)
        {
            var toWidth = toType.AsBitVectorType.Width;
            if (RemoveLit(r) is Bpl.LiteralExpr)
            {
                Bpl.LiteralExpr e = (Bpl.LiteralExpr)RemoveLit(r);
                if (e.isBigNum)
                {
                    var toBound = BaseTypes.BigNum.FromBigInt(BigInteger.One << toWidth);  // 1 << toWidth
                    if (MutateCSharp.Schemata501.ReplaceBinExprOp_19(659L, e.asBigNum, toBound))
                    {
                        return BplBvLiteralExpr(r.tok, e.asBigNum, toType.AsBitVectorType);
                    }
                }
            }
            return FunctionCall(tok, MutateCSharp.Schemata501.ReplaceStringConstant_5(661L, "nat_to_bv") + toWidth, BplBvType(toWidth), r);
        }

        /// <summary>
        /// Emit checks that "expr" (which may or may not be a value of type "expr.Type"!) is a value of type "toType".
        /// </summary>
        void CheckResultToBeInType(IToken tok, Expression expr, Type toType, List<Bpl.Variable> locals, BoogieStmtListBuilder builder, ExpressionTranslator etran, string errorMsgPrefix = "")
        {
            Contract.Requires(tok != null);
            Contract.Requires(expr != null);
            Contract.Requires(toType != null);
            Contract.Requires(builder != null);
            Contract.Requires(etran != null);
            Contract.Requires(errorMsgPrefix != null);

            var toTypeFamily = toType.NormalizeToAncestorType();
            var fromType = expr.Type;
            var fromTypeFamily = expr.Type.NormalizeToAncestorType();

            // Lazily create a local variable "o" to hold the value of the from-expression
            Bpl.IdentifierExpr o = null;
            void PutSourceIntoLocal()
            {
                if (MutateCSharp.Schemata501.ReplaceBinExprOp_20(662L, o, null))
                {
                    var oType = fromType.IsCharType ? Type.Int : fromType;
                    var oVar = new Bpl.LocalVariable(tok, new Bpl.TypedIdent(tok, CurrentIdGenerator.FreshId(MutateCSharp.Schemata501.ReplaceStringConstant_5(663L, "newtype$check#")), TrType(oType)));
                    locals.Add(oVar);
                    o = new Bpl.IdentifierExpr(tok, oVar);
                    var rhs = etran.TrExpr(expr);
                    if (fromType.IsCharType)
                    {
                        rhs = FunctionCall(expr.tok, MutateCSharp.Schemata501.ReplaceStringConstant_5(664L, "char#ToInt"), Bpl.Type.Int, rhs);
                    }
                    builder.Add(Bpl.Cmd.SimpleAssign(tok, o, rhs));
                }
            }

            Contract.Assert(options.Get(CommonOptionBag.GeneralTraits) != CommonOptionBag.GeneralTraitsOptions.Legacy || fromType.IsRefType == toType.IsRefType);
            if (toType.IsRefType)
            {
                PutSourceIntoLocal();
                CheckSubrange(tok, o, fromType, toType, builder, errorMsgPrefix);
                return;
            }
            else if (fromType.IsTraitType)
            {
                PutSourceIntoLocal();
                CheckSubrange(tok, o, fromType, toType, builder, errorMsgPrefix);
                return;
            }

            if (MutateCSharp.Schemata501.ReplaceBinExprOp_12(665L, () => fromType.IsNumericBased(Type.NumericPersuasion.Real), () => !toType.IsNumericBased(Type.NumericPersuasion.Real)))
            {
                // this operation is well-formed only if the real-based number represents an integer
                //   assert Real(Int(o)) == o;
                PutSourceIntoLocal();
                Bpl.Expr from = FunctionCall(tok, BuiltinFunction.RealToInt, null, o);
                Bpl.Expr e = FunctionCall(tok, BuiltinFunction.IntToReal, null, from);
                e = Bpl.Expr.Binary(tok, Bpl.BinaryOperator.Opcode.Eq, e, o);
                builder.Add(Assert(tok, e, new PODesc.IsInteger(expr, errorMsgPrefix)));
            }

            if (MutateCSharp.Schemata501.ReplaceBinExprOp_12(671L, () => fromType.IsBigOrdinalType, () => !toType.IsBigOrdinalType))
            {
                PutSourceIntoLocal();
                Bpl.Expr boundsCheck = FunctionCall(tok, MutateCSharp.Schemata501.ReplaceStringConstant_5(677L, "ORD#IsNat"), Bpl.Type.Bool, o);
                builder.Add(Assert(tok, boundsCheck, new PODesc.ConversionIsNatural(errorMsgPrefix, expr)));
            }

            if (toTypeFamily.IsBitVectorType)
            {
                var toWidth = toTypeFamily.AsBitVectorType.Width;
                var toBound = BaseTypes.BigNum.FromBigInt(BigInteger.One << toWidth);  // 1 << toWidth
                Bpl.Expr boundsCheck = null;
                var dafnyBound = new BinaryExpr(expr.tok, BinaryExpr.Opcode.LeftShift, Expression.CreateIntLiteral(expr.tok, MutateCSharp.Schemata501.ReplaceNumericConstant_0(678L, 1)), Expression.CreateIntLiteral(expr.tok, toWidth));
                Expression dafnyBoundsCheck = null;
                if (fromTypeFamily.IsBitVectorType)
                {
                    var fromWidth = fromTypeFamily.AsBitVectorType.Width;
                    if (MutateCSharp.Schemata501.ReplaceBinExprOp_7(682L, toWidth, fromWidth))
                    {
                        // Check "expr < (1 << toWidth)" in type "fromType" (note that "1 << toWidth" is indeed a value in "fromType")
                        PutSourceIntoLocal();
                        var bound = BplBvLiteralExpr(tok, toBound, fromTypeFamily.AsBitVectorType);
                        boundsCheck = FunctionCall(expr.tok, MutateCSharp.Schemata501.ReplaceStringConstant_5(687L, "lt_bv") + fromWidth, Bpl.Type.Bool, o, bound);
                        dafnyBoundsCheck = new BinaryExpr(expr.tok, BinaryExpr.Opcode.And,
                          new BinaryExpr(expr.tok, BinaryExpr.Opcode.Le, new LiteralExpr(expr.tok, MutateCSharp.Schemata501.ReplaceNumericConstant_0(688L, 0)), expr),
                          new BinaryExpr(expr.tok, BinaryExpr.Opcode.Lt, expr, dafnyBound)
                      );
                    }
                }
                else if (MutateCSharp.Schemata501.ReplaceBinExprOp_15(692L, () => fromType.IsNumericBased(Type.NumericPersuasion.Int), () => fromTypeFamily.IsCharType))
                {
                    // Check "expr < (1 << toWidth)" in type "int"
                    PutSourceIntoLocal();
                    var bound = Bpl.Expr.Literal(toBound);
                    boundsCheck = BplAnd(Bpl.Expr.Le(Bpl.Expr.Literal(MutateCSharp.Schemata501.ReplaceNumericConstant_0(698L, 0)), o), Bpl.Expr.Lt(o, bound));
                    dafnyBoundsCheck = Expression.CreateAnd(
                      Expression.CreateLess(Expression.CreateIntLiteral(expr.tok, MutateCSharp.Schemata501.ReplaceNumericConstant_0(702L, 0)), expr),
                      Expression.CreateAtMost(expr, dafnyBound));
                }
                else if (fromType.IsNumericBased(Type.NumericPersuasion.Real))
                {
                    // Check "Int(expr) < (1 << toWidth)" in type "int"
                    PutSourceIntoLocal();
                    var bound = Bpl.Expr.Literal(toBound);
                    var oi = FunctionCall(tok, BuiltinFunction.RealToInt, null, o);
                    boundsCheck = BplAnd(Bpl.Expr.Le(Bpl.Expr.Literal(MutateCSharp.Schemata501.ReplaceNumericConstant_0(706L, 0)), oi), Bpl.Expr.Lt(oi, bound));
                    var intExpr = new ExprDotName(expr.tok, expr, MutateCSharp.Schemata501.ReplaceStringConstant_5(710L, "Floor"), null);
                    dafnyBoundsCheck = new BinaryExpr(expr.tok, BinaryExpr.Opcode.And,
                      new BinaryExpr(expr.tok, BinaryExpr.Opcode.Le, new LiteralExpr(expr.tok, MutateCSharp.Schemata501.ReplaceNumericConstant_0(711L, 0)), intExpr),
                      new BinaryExpr(expr.tok, BinaryExpr.Opcode.Lt, intExpr, dafnyBound)
                    );
                }
                else if (fromType.IsBigOrdinalType)
                {
                    var bound = Bpl.Expr.Literal(toBound);
                    var oi = FunctionCall(tok, MutateCSharp.Schemata501.ReplaceStringConstant_5(715L, "ORD#Offset"), Bpl.Type.Int, o);
                    boundsCheck = Bpl.Expr.Lt(oi, bound);
                    var intExpr = new ExprDotName(expr.tok, expr, MutateCSharp.Schemata501.ReplaceStringConstant_5(716L, "Offset"), null);
                    dafnyBoundsCheck = new BinaryExpr(expr.tok, BinaryExpr.Opcode.And,
                      new BinaryExpr(expr.tok, BinaryExpr.Opcode.Le, new LiteralExpr(expr.tok, MutateCSharp.Schemata501.ReplaceNumericConstant_0(717L, 0)), intExpr),
                      new BinaryExpr(expr.tok, BinaryExpr.Opcode.Lt, intExpr, dafnyBound)
                    );
                }

                if (MutateCSharp.Schemata501.ReplaceBinExprOp_21(721L, boundsCheck, null))
                {
                    builder.Add(Assert(tok, boundsCheck, new PODesc.ConversionFit(MutateCSharp.Schemata501.ReplaceStringConstant_5(722L, "value"), toType, dafnyBoundsCheck, errorMsgPrefix)));
                }

            }
            else if (toType.IsCharType)
            {
                if (fromType.IsNumericBased(Type.NumericPersuasion.Int))
                {
                    PutSourceIntoLocal();
                    var boundsCheck = FunctionCall(Token.NoToken, BuiltinFunction.IsChar, null, o);
                    var dafnyBoundsCheck = PODesc.Utils.MakeCharBoundsCheck(options, expr);
                    builder.Add(Assert(tok, boundsCheck, new PODesc.ConversionFit(MutateCSharp.Schemata501.ReplaceStringConstant_5(723L, "value"), toType, dafnyBoundsCheck, errorMsgPrefix)));
                }
                else if (fromType.IsNumericBased(Type.NumericPersuasion.Real))
                {
                    PutSourceIntoLocal();
                    var oi = FunctionCall(tok, BuiltinFunction.RealToInt, null, o);
                    var boundsCheck = FunctionCall(Token.NoToken, BuiltinFunction.IsChar, null, oi);
                    Expression intExpr = new ExprDotName(expr.tok, expr, MutateCSharp.Schemata501.ReplaceStringConstant_5(724L, "Floor"), null);
                    var dafnyBoundsCheck = PODesc.Utils.MakeCharBoundsCheck(options, intExpr);
                    builder.Add(Assert(tok, boundsCheck, new PODesc.ConversionFit(MutateCSharp.Schemata501.ReplaceStringConstant_5(725L, "real value"), toType, dafnyBoundsCheck, errorMsgPrefix)));
                }
                else if (fromType.IsBitVectorType)
                {
                    PutSourceIntoLocal();
                    var fromWidth = fromType.AsBitVectorType.Width;
                    var toWidth = MutateCSharp.Schemata501.ReplaceNumericConstant_0(726L, 16);
                    if (MutateCSharp.Schemata501.ReplaceBinExprOp_7(730L, toWidth, fromWidth))
                    {
                        // Check "expr < (1 << toWidth)" in type "fromType" (note that "1 << toWidth" is indeed a value in "fromType")
                        PutSourceIntoLocal();
                        var toBound = BaseTypes.BigNum.FromBigInt(BigInteger.One << toWidth); // 1 << toWidth
                        var bound = BplBvLiteralExpr(tok, toBound, fromType.AsBitVectorType);
                        var boundsCheck = FunctionCall(expr.tok, MutateCSharp.Schemata501.ReplaceStringConstant_5(735L, "lt_bv") + fromWidth, Bpl.Type.Bool, o, bound);
                        var dafnyBound = new BinaryExpr(expr.tok, BinaryExpr.Opcode.LeftShift, Expression.CreateIntLiteral(expr.tok, MutateCSharp.Schemata501.ReplaceNumericConstant_0(736L, 1)), Expression.CreateIntLiteral(expr.tok, toWidth));
                        var dafnyBoundsCheck = new BinaryExpr(expr.tok, BinaryExpr.Opcode.Lt, expr, dafnyBound);
                        builder.Add(Assert(tok, boundsCheck, new PODesc.ConversionFit(MutateCSharp.Schemata501.ReplaceStringConstant_5(740L, "bit-vector value"), toType, dafnyBoundsCheck, errorMsgPrefix)));
                    }
                }
                else if (fromType.IsBigOrdinalType)
                {
                    PutSourceIntoLocal();
                    var oi = FunctionCall(tok, MutateCSharp.Schemata501.ReplaceStringConstant_5(741L, "ORD#Offset"), Bpl.Type.Int, o);
                    int toWidth = MutateCSharp.Schemata501.ReplaceNumericConstant_0(742L, 16);
                    var toBound = BaseTypes.BigNum.FromBigInt(BigInteger.One << toWidth); // 1 << toWidth
                    var bound = Bpl.Expr.Literal(toBound);
                    var boundsCheck = Bpl.Expr.Lt(oi, bound);
                    var dafnyBound = new BinaryExpr(expr.tok, BinaryExpr.Opcode.LeftShift, Expression.CreateIntLiteral(expr.tok, MutateCSharp.Schemata501.ReplaceNumericConstant_0(746L, 1)), Expression.CreateIntLiteral(expr.tok, toWidth));
                    var offset = new ExprDotName(expr.tok, expr, MutateCSharp.Schemata501.ReplaceStringConstant_5(750L, "Offset"), null);
                    var dafnyBoundsCheck = new BinaryExpr(expr.tok, BinaryExpr.Opcode.Lt, offset, dafnyBound);
                    builder.Add(Assert(tok, boundsCheck, new PODesc.ConversionFit(MutateCSharp.Schemata501.ReplaceStringConstant_5(751L, "ORDINAL value"), toType, dafnyBoundsCheck, errorMsgPrefix)));
                }

            }
            else if (toType.IsBigOrdinalType)
            {
                if (fromType.IsNumericBased(Type.NumericPersuasion.Int))
                {
                    PutSourceIntoLocal();
                    Bpl.Expr boundsCheck = Bpl.Expr.Le(Bpl.Expr.Literal(MutateCSharp.Schemata501.ReplaceNumericConstant_0(752L, 0)), o);
                    var desc = new PODesc.ConversionPositive(MutateCSharp.Schemata501.ReplaceStringConstant_5(756L, "integer"), toType, expr, errorMsgPrefix);
                    builder.Add(Assert(tok, boundsCheck, desc));
                }
                if (fromType.IsNumericBased(Type.NumericPersuasion.Real))
                {
                    PutSourceIntoLocal();
                    var oi = FunctionCall(tok, BuiltinFunction.RealToInt, null, o);
                    Bpl.Expr boundsCheck = Bpl.Expr.Le(Bpl.Expr.Literal(MutateCSharp.Schemata501.ReplaceNumericConstant_0(757L, 0)), oi);
                    var intExpr = new ExprDotName(expr.tok, expr, MutateCSharp.Schemata501.ReplaceStringConstant_5(761L, "Floor"), null);
                    var desc = new PODesc.ConversionPositive(MutateCSharp.Schemata501.ReplaceStringConstant_5(762L, "real"), toType, intExpr, errorMsgPrefix);
                    builder.Add(Assert(tok, boundsCheck, desc));
                }

            }
            else if (toType.IsNumericBased(Type.NumericPersuasion.Int))
            {
                // already checked that BigOrdinal or real inputs are integral
            }
            else if (toType.IsNumericBased(Type.NumericPersuasion.Real))
            {
                // already checked that BigOrdinal is integral
            }

            if (MutateCSharp.Schemata501.ReplaceBinExprOp_22(763L, toType.NormalizeExpandKeepConstraints().AsRedirectingType, null))
            {
                PutSourceIntoLocal();
                Bpl.Expr be;
                if (MutateCSharp.Schemata501.ReplaceBinExprOp_15(764L, () => fromType.IsNumericBased(), () => fromTypeFamily.IsBitVectorType))
                {
                    be = ConvertExpression(expr.tok, o, fromType, toType);
                }
                else if (fromType.IsCharType)
                {
                    be = ConvertExpression(expr.tok, o, Dafny.Type.Int, toType);
                }
                else if (fromType.IsBigOrdinalType)
                {
                    be = FunctionCall(expr.tok, MutateCSharp.Schemata501.ReplaceStringConstant_5(770L, "ORD#Offset"), Bpl.Type.Int, o);
                    be = ConvertExpression(expr.tok, be, Dafny.Type.Int, toType);
                }
                else
                {
                    be = o;
                }
                CheckResultToBeInType_Aux(tok, new BoogieWrapper(be, toTypeFamily), expr, toType.NormalizeExpandKeepConstraints(), builder, etran, errorMsgPrefix);
            }
        }

        void CheckResultToBeInType_Aux(IToken tok, Expression boogieExpr, Expression origExpr, Type toType, BoogieStmtListBuilder builder, ExpressionTranslator etran, string errorMsgPrefix)
        {
            Contract.Requires(tok != null);
            Contract.Requires(boogieExpr != null);
            Contract.Requires(origExpr != null);
            Contract.Requires(toType != null && toType.AsRedirectingType != null);
            Contract.Requires(builder != null);
            Contract.Requires(etran != null);
            Contract.Requires(errorMsgPrefix != null);
            // First, check constraints of base types
            var udt = (UserDefinedType)toType;
            var rdt = (RedirectingTypeDecl)udt.ResolvedClass;
            Type baseType;
            string kind;
            if (rdt is SubsetTypeDecl)
            {
                baseType = ((SubsetTypeDecl)rdt).RhsWithArgument(udt.TypeArgs);
                kind = MutateCSharp.Schemata501.ReplaceStringConstant_5(771L, "subset type");
            }
            else if (rdt is NewtypeDecl)
            {
                baseType = ((NewtypeDecl)rdt).BaseType;
                kind = MutateCSharp.Schemata501.ReplaceStringConstant_5(772L, "newtype");
            }
            else
            {
                baseType = ((TypeSynonymDecl)rdt).RhsWithArgument(udt.TypeArgs);
                kind = MutateCSharp.Schemata501.ReplaceStringConstant_5(773L, "type synonym");
            }

            if (MutateCSharp.Schemata501.ReplaceBinExprOp_22(774L, baseType.AsRedirectingType, null))
            {
                CheckResultToBeInType_Aux(tok, boogieExpr, origExpr, baseType, builder, etran, errorMsgPrefix);
            }
            // Check any constraint defined in 'dd'
            if (MutateCSharp.Schemata501.ReplaceBinExprOp_17(775L, rdt.Var, null))
            {
                // TODO: use TrSplitExpr
                var typeMap = TypeParameter.SubstitutionMap(rdt.TypeArgs, udt.TypeArgs);
                var dafnyConstraint = Substitute(rdt.Constraint, null, new() { { rdt.Var, origExpr } }, typeMap);
                var boogieConstraint = etran.TrExpr(Substitute(rdt.Constraint, null, new() { { rdt.Var, boogieExpr } }, typeMap));
                builder.Add(Assert(tok, boogieConstraint, new PODesc.ConversionSatisfiesConstraints(errorMsgPrefix, kind, rdt.Name, dafnyConstraint)));
            }
        }


        void AddWellformednessCheck(RedirectingTypeDecl decl)
        {
            Contract.Requires(decl != null);
            Contract.Requires(sink != null && predef != null);
            Contract.Requires(currentModule == null && codeContext == null && isAllocContext == null);
            Contract.Ensures(currentModule == null && codeContext == null && isAllocContext == null);

            proofDependencies.SetCurrentDefinition(MethodVerboseName(decl.FullDafnyName, MethodTranslationKind.SpecWellformedness));

            if (!InVerificationScope(decl))
            {
                // Checked in other file
                return;
            }

            // If there's no constraint, there's nothing to do
            if (MutateCSharp.Schemata501.ReplaceBinExprOp_23(776L, decl.Var, null))
            {
                Contract.Assert(decl.Constraint == null);  // there's a constraint only if there's a variable to be constrained
                Contract.Assert(decl.WitnessKind == SubsetTypeDecl.WKind.CompiledZero);  // a witness makes sense only if there is a constraint
                Contract.Assert(decl.Witness == null);  // a witness makes sense only if there is a constraint
                return;
            }
            Contract.Assert(decl.Constraint != null);  // follows from the test above and the RedirectingTypeDecl class invariant

            currentModule = decl.Module;
            codeContext = new CallableWrapper(decl, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(777L, true));
            var etran = new ExpressionTranslator(this, predef, decl.tok, null);

            // parameters of the procedure
            var inParams = MkTyParamFormals(decl.TypeArgs, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(778L, true));
            Bpl.Type varType = TrType(decl.Var.Type);
            Bpl.Expr wh = GetWhereClause(decl.Var.tok, new Bpl.IdentifierExpr(decl.Var.tok, decl.Var.AssignUniqueName(decl.IdGenerator), varType), decl.Var.Type, etran, NOALLOC);
            inParams.Add(new Bpl.Formal(decl.Var.tok, new Bpl.TypedIdent(decl.Var.tok, decl.Var.AssignUniqueName(decl.IdGenerator), varType, wh), MutateCSharp.Schemata501.ReplaceBooleanConstant_1(779L, true)));

            // the procedure itself
            var req = new List<Bpl.Requires>();
            // free requires mh == ModuleContextHeight && fh == TypeContextHeight;
            req.Add(Requires(decl.tok, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(780L, true), etran.HeightContext(decl), null, null, null));
            // modifies $Heap
            var mod = new List<Bpl.IdentifierExpr> {
        etran.HeapCastToIdentifierExpr,
      };
            var name = MethodName(decl, MethodTranslationKind.SpecWellformedness);
            var proc = new Bpl.Procedure(decl.tok, name, new List<Bpl.TypeVariable>(),
              inParams, new List<Variable>(),
        MutateCSharp.Schemata501.ReplaceBooleanConstant_1(781L, false), req, mod, new List<Bpl.Ensures>(), etran.TrAttributes(decl.Attributes, null));
            AddVerboseNameAttribute(proc, decl.FullDafnyName, MethodTranslationKind.SpecWellformedness);
            sink.AddTopLevelDeclaration(proc);

            // TODO: Can a checksum be inserted here?

            Contract.Assert(proc.InParams.Count == inParams.Count);
            // Changed the next line to strip from inParams instead of proc.InParams
            // They should be the same, but hence the added contract
            var implInParams = Bpl.Formal.StripWhereClauses(inParams);
            var locals = new List<Variable>();
            var builder = new BoogieStmtListBuilder(this, options);
            builder.Add(new CommentCmd(string.Format(MutateCSharp.Schemata501.ReplaceStringConstant_5(782L, "AddWellformednessCheck for {0} {1}"), decl.WhatKind, decl)));
            builder.AddCaptureState(decl.tok, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(783L, false), MutateCSharp.Schemata501.ReplaceStringConstant_5(784L, "initial state"));
            isAllocContext = new IsAllocContext(options, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(785L, true));

            DefineFrame(decl.tok, etran.ReadsFrame(decl.tok), new List<FrameExpression>(), builder, locals, null);

            // some initialization stuff;  // This is collected in builderInitializationArea
            // define frame;
            // if (*) {
            //   // The following is collected in constraintCheckBuilder:
            //   check constraint is well-formed;
            //   assume constraint;
            //   do reads checks;
            // } else {
            //   // The following is collected in witnessCheckBuilder:
            //   check witness;
            // }

            // check well-formedness of the constraint (including termination, and delayed reads checks)
            var constraintCheckBuilder = new BoogieStmtListBuilder(this, options);
            var builderInitializationArea = new BoogieStmtListBuilder(this, options);
            var delayer = new ReadsCheckDelayer(etran, null, locals, builderInitializationArea, constraintCheckBuilder);
            delayer.DoWithDelayedReadsChecks(MutateCSharp.Schemata501.ReplaceBooleanConstant_1(786L, false), wfo =>
            {
                CheckWellformedAndAssume(decl.Constraint, wfo, locals, constraintCheckBuilder, etran, MutateCSharp.Schemata501.ReplaceStringConstant_5(787L, "predicate subtype constraint"));
            });

            // Check that the type is inhabited.
            // Note, the possible witness in this check should be coordinated with the compiler, so the compiler knows how to do the initialization
            Expression witnessExpr = null;
            var witnessCheckBuilder = new BoogieStmtListBuilder(this, options);
            string witnessString = null;
            if (MutateCSharp.Schemata501.ReplaceBinExprOp_13(788L, decl.Witness, null))
            {
                // check well-formedness of the witness expression (including termination, and reads checks)
                var ghostCodeContext = codeContext;
                codeContext = MutateCSharp.Schemata501.ReplaceBinExprOp_24(789L, decl.WitnessKind, SubsetTypeDecl.WKind.Compiled) ? new CallableWrapper(decl, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(790L, false)) : ghostCodeContext;
                CheckWellformed(decl.Witness, new WFOptions(null, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(791L, true)), locals, witnessCheckBuilder, etran);
                codeContext = ghostCodeContext;
                // check that the witness is assignable to the type of the given bound variable
                if (decl is SubsetTypeDecl)
                {
                    // Note, for new-types, this has already been checked by CheckWellformed.
                    CheckResultToBeInType(decl.Witness.tok, decl.Witness, decl.Var.Type, locals, witnessCheckBuilder, etran);
                }
                // check that the witness expression checks out
                witnessExpr = Substitute(decl.Constraint, decl.Var, decl.Witness);
            }
            else if (MutateCSharp.Schemata501.ReplaceBinExprOp_24(792L, decl.WitnessKind, SubsetTypeDecl.WKind.CompiledZero))
            {
                var witness = Zero(decl.tok, decl.Var.Type);
                if (MutateCSharp.Schemata501.ReplaceBinExprOp_10(793L, witness, null))
                {
                    witnessString = "";
                    witnessCheckBuilder.Add(Assert(decl.tok, Bpl.Expr.False, new PODesc.WitnessCheck(witnessString)));
                }
                else
                {
                    // before trying 0 as a witness, check that 0 can be assigned to decl.Var
                    witnessString = Printer.ExprToString(options, witness);
                    CheckResultToBeInType(decl.tok, witness, decl.Var.Type, locals, witnessCheckBuilder, etran, $"trying witness {witnessString}: ");
                    witnessExpr = Substitute(decl.Constraint, decl.Var, witness);
                }
            }
            if (MutateCSharp.Schemata501.ReplaceBinExprOp_13(794L, witnessExpr, null))
            {
                var witnessCheckTok = MutateCSharp.Schemata501.ReplaceBinExprOp_13(795L, decl.Witness, null) ? GetToken(decl.Witness) : decl.tok;
                witnessCheckBuilder.Add(new Bpl.AssumeCmd(witnessCheckTok, etran.CanCallAssumption(witnessExpr)));
                var witnessCheck = etran.TrExpr(witnessExpr);

                bool splitHappened;
                var ss = TrSplitExpr(witnessExpr, etran, MutateCSharp.Schemata501.ReplaceBooleanConstant_1(796L, true), out splitHappened);
                var desc = new PODesc.WitnessCheck(witnessString, witnessExpr);
                if (!splitHappened)
                {
                    witnessCheckBuilder.Add(Assert(witnessCheckTok, etran.TrExpr(witnessExpr), desc));
                }
                else
                {
                    foreach (var split in ss)
                    {
                        if (split.IsChecked)
                        {
                            var tok = witnessCheckTok is IToken t ? new NestedToken(t, split.Tok) : witnessCheckTok;
                            witnessCheckBuilder.Add(AssertNS(tok, split.E, desc));
                        }
                    }
                }
            }

            builder.Add(new Bpl.IfCmd(decl.tok, null, constraintCheckBuilder.Collect(decl.tok), null, witnessCheckBuilder.Collect(decl.tok)));

            var s0 = builderInitializationArea.Collect(decl.tok);
            var s1 = builder.Collect(decl.tok);
            var implBody = new StmtList(new List<BigBlock>(s0.BigBlocks.Concat(s1.BigBlocks)), decl.tok);

            if (EmitImplementation(decl.Attributes))
            {
                // emit the impl only when there are proof obligations.
                QKeyValue kv = etran.TrAttributes(decl.Attributes, null);

                AddImplementationWithAttributes(GetToken(decl), proc, implInParams, new List<Variable>(), locals, implBody, kv);
            }

            // TODO: Should a checksum be inserted here?

            Contract.Assert(currentModule == decl.Module);
            Contract.Assert(CodeContextWrapper.Unwrap(codeContext) == decl);
            isAllocContext = null;
            Reset();
        }
    }
}
