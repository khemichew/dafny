using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using Microsoft.Boogie;
using Bpl = Microsoft.Boogie;
using static Microsoft.Dafny.Util;
using PODesc = Microsoft.Dafny.ProofObligationDescription;
namespace MutateCSharp
{
    internal class Schemata498
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT498");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_36(long mutantId, Microsoft.Dafny.MemberSelectExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_11(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_32(long mutantId, Microsoft.Dafny.BoogieGenerator.MethodTranslationKind argument1, Microsoft.Dafny.BoogieGenerator.MethodTranslationKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, Microsoft.Dafny.Formal argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_34(long mutantId, System.Func<Microsoft.Dafny.IToken, bool> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_28(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.FrameExpression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_35(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_33(long mutantId, Microsoft.Dafny.AssertLabel argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, Microsoft.Boogie.Variable argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, Microsoft.Dafny.DatatypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_30(long mutantId, Microsoft.Dafny.AssertStmt.AssertOnlyKind argument1, Microsoft.Dafny.AssertStmt.AssertOnlyKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_29(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 >= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 > argument2; }
            return argument1 >= argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Boogie.Expr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.Method argument1, Microsoft.Dafny.Method argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Boogie.Type argument1, Microsoft.Boogie.Type argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceNumericConstant_9(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.ClassLikeDecl argument1, Microsoft.Dafny.TraitDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_31(long mutantId, Microsoft.Dafny.BoogieGenerator.MethodTranslationKind argument1, Microsoft.Dafny.BoogieGenerator.MethodTranslationKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.Function argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, Microsoft.Dafny.UserDefinedType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, Microsoft.Dafny.Specification<Microsoft.Dafny.FrameExpression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, Microsoft.Boogie.Expr argument1, Microsoft.Boogie.LiteralExpr argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, Microsoft.Dafny.Formal argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Boogie.Declaration argument1, Microsoft.Boogie.Function argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

    }
}

namespace Microsoft.Dafny
{
    public partial class BoogieGenerator
    {
        void AddClassMembers(TopLevelDeclWithMembers c, bool includeAllMethods, bool includeInformationAboutType)
        {
            Contract.Requires(sink != null && predef != null);
            Contract.Requires(c != null);
            Contract.Ensures(fuelContext == Contract.OldValue(fuelContext));
            Contract.Assert(VisibleInScope(c));

            if (includeInformationAboutType)
            {
                sink.AddTopLevelDeclaration(GetClass(c));
                if (c is ArrayClassDecl)
                {
                    // classes.Add(c, predef.ClassDotArray);
                    AddAllocationAxiom(null, null, (ArrayClassDecl)c, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(1L, true));
                }

                if (c is ClassLikeDecl { IsReferenceTypeDecl: true } referenceTypeDecl)
                {
                    AddIsAndIsAllocForReferenceType(referenceTypeDecl);
                }

                if (c is TraitDecl)
                {
                    //this adds: function implements$J(Ty, typeArgs): bool;
                    var arg_ref = new Bpl.Formal(c.tok, new Bpl.TypedIdent(c.tok, MutateCSharp.Schemata498.ReplaceStringConstant_1(2L, "ty"), predef.Ty), MutateCSharp.Schemata498.ReplaceBooleanConstant_0(3L, true));
                    var vars = new List<Bpl.Variable> { arg_ref };
                    vars.AddRange(MkTyParamFormals(GetTypeParams(c), MutateCSharp.Schemata498.ReplaceBooleanConstant_0(4L, false)));
                    var res = new Bpl.Formal(c.tok, new Bpl.TypedIdent(c.tok, Bpl.TypedIdent.NoName, Bpl.Type.Bool), MutateCSharp.Schemata498.ReplaceBooleanConstant_0(5L, false));
                    var implement_intr = new Bpl.Function(c.tok, MutateCSharp.Schemata498.ReplaceStringConstant_1(6L, "implements$") + c.FullSanitizedName, vars, res);
                    sink.AddTopLevelDeclaration(implement_intr);
                }
                else if (c is ClassDecl classDecl)
                {
                    AddImplementsAxioms(classDecl);
                }
            }

            foreach (MemberDecl member in c.Members.FindAll(VisibleInScope))
            {
                Contract.Assert(isAllocContext == null);
                currentDeclaration = member;
                if (!filterOnlyMembers || member.HasUserAttribute("only", out _))
                {
                    SetAssertionOnlyFilter(member);
                }
                else
                {
                    assertionOnlyFilter = _ => MutateCSharp.Schemata498.ReplaceBooleanConstant_0(7L, false);
                }

                if (member is Field)
                {
                    Field f = (Field)member;
                    Boogie.Declaration fieldDeclaration;
                    if (f is ConstantField)
                    {
                        // The following call has the side effect of idempotently creating and adding the function to the sink's top-level declarations
                        Contract.Assert(currentModule == null);
                        currentModule = f.EnclosingClass.EnclosingModuleDefinition;
                        var oldFuelContext = fuelContext;
                        fuelContext = FuelSetting.NewFuelContext(f);
                        fieldDeclaration = GetReadonlyField(f);
                        fuelContext = oldFuelContext;
                        currentModule = null;
                    }
                    else
                    {
                        if (f.IsMutable)
                        {
                            fieldDeclaration = GetField(f);
                            sink.AddTopLevelDeclaration(fieldDeclaration);
                        }
                        else
                        {
                            fieldDeclaration = GetReadonlyField(f);
                            if (MutateCSharp.Schemata498.ReplaceBinExprOp_2(8L, fieldDeclaration, predef.ArrayLength))
                            {
                                sink.AddTopLevelDeclaration(fieldDeclaration);
                            }
                        }
                    }
                    AddAllocationAxiom(fieldDeclaration, f, c);
                }
                else if (member is Function function)
                {
                    AddFunction_Top(function, includeAllMethods);
                }
                else if (member is Method method)
                {
                    AddMethod_Top(method, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(9L, false), includeAllMethods);
                }
                else
                {
                    Contract.Assert(false); throw new cce.UnreachableException();  // unexpected member
                }
                ResetAssertionOnlyFilter();
            }
        }

        /**
          Add $Is and $IsAlloc for this class :
             axiom (forall p: ref, G: Ty ::
                { $Is(p, TClassA(G), h) }
                $Is(p, TClassA(G), h) <=> (p == null || dtype(p) == TClassA(G));
             axiom (forall p: ref, h: Heap, G: Ty ::
                { $IsAlloc(p, TClassA(G), h) }
                $IsAlloc(p, TClassA(G), h) => (p == null || h[p, alloc]);
         */
        private void AddIsAndIsAllocForReferenceType(ClassLikeDecl c)
        {
            Contract.Requires(c.IsReferenceTypeDecl);

            MapM(Bools, is_alloc =>
            {
                var vars = MkTyParamBinders(GetTypeParams(c), out var tyexprs);

                var o = BplBoundVar(MutateCSharp.Schemata498.ReplaceStringConstant_1(10L, "$o"), predef.RefType, vars);

                Bpl.Expr body, is_o;
                Bpl.Expr o_null = Bpl.Expr.Eq(o, predef.Null);
                Bpl.Expr o_ty = ClassTyCon(c, tyexprs);
                string name;

                if (is_alloc)
                {
                    name = $"$IsAlloc axiom for {c.WhatKind} {c}";
                    var h = BplBoundVar(MutateCSharp.Schemata498.ReplaceStringConstant_1(11L, "$h"), predef.HeapType, vars);
                    // $IsAlloc(o, ..)
                    is_o = MkIsAlloc(o, o_ty, h);
                    body = BplIff(is_o, BplOr(o_null, IsAlloced(c.tok, h, o)));
                }
                else
                {
                    name = $"$Is axiom for {c.WhatKind} {c}";
                    // $Is(o, ..)
                    is_o = MkIs(o, o_ty);
                    Bpl.Expr rhs;
                    if (MutateCSharp.Schemata498.ReplaceBinExprOp_3(12L, c, program.SystemModuleManager.ObjectDecl))
                    {
                        rhs = Bpl.Expr.True;
                    }
                    else if (c is TraitDecl)
                    {
                        //generating $o == null || implements$J(dtype(x), typeArgs)
                        var t = (TraitDecl)c;
                        var dtypeFunc = FunctionCall(o.tok, BuiltinFunction.DynamicType, null, o);
                        var implementsJ_Arguments = new List<Expr> { dtypeFunc }; // TODO: also needs type parameters
                        implementsJ_Arguments.AddRange(tyexprs);
                        Bpl.Expr implementsFunc =
                          FunctionCall(t.tok, MutateCSharp.Schemata498.ReplaceStringConstant_1(13L, "implements$") + t.FullSanitizedName, Bpl.Type.Bool, implementsJ_Arguments);
                        rhs = BplOr(o_null, implementsFunc);
                    }
                    else
                    {
                        rhs = BplOr(o_null, DType(o, o_ty));
                    }

                    body = BplIff(is_o, rhs);
                }

                var axiom = new Boogie.Axiom(c.tok, BplForall(vars, BplTrigger(is_o), body), name);
                AddOtherDefinition(GetOrCreateTypeConstructor(c), axiom);
            });
        }

        void AddFunction_Top(Function f, bool includeAllMethods)
        {
            FuelContext oldFuelContext = this.fuelContext;
            this.fuelContext = FuelSetting.NewFuelContext(f);
            isAllocContext = new IsAllocContext(options, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(14L, true));

            AddClassMember_Function(f);

            if (InVerificationScope(f))
            {
                AddWellformednessCheck(f);
                if (MutateCSharp.Schemata498.ReplaceBinExprOp_4(15L, f.OverriddenFunction, null))
                { //it means that f is overriding its associated parent function
                    AddFunctionOverrideCheckImpl(f);
                }
            }
            if (f is ExtremePredicate cop)
            {
                AddClassMember_Function(cop.PrefixPredicate);
                // skip the well-formedness check, because it has already been done for the extreme predicate
            }
            else if (MutateCSharp.Schemata498.ReplaceBinExprOp_5(16L, f.ByMethodDecl, null))
            {
                AddMethod_Top(f.ByMethodDecl, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(17L, true), includeAllMethods);
            }

            this.fuelContext = oldFuelContext;
            isAllocContext = null;
        }

        void AddMethod_Top(Method m, bool isByMethod, bool includeAllMethods)
        {
            if (MutateCSharp.Schemata498.ReplaceBinExprOp_6(24L, () => MutateCSharp.Schemata498.ReplaceBinExprOp_6(18L, () => !includeAllMethods, () => !InVerificationScope(m)), () => !referencedMembers.Contains(m)))
            {
                // do nothing
                return;
            }

            FuelContext oldFuelContext = this.fuelContext;
            this.fuelContext = FuelSetting.NewFuelContext(m);

            // wellformedness check for method specification
            if (MutateCSharp.Schemata498.ReplaceBinExprOp_6(31L, () => m.EnclosingClass is IteratorDecl, () => MutateCSharp.Schemata498.ReplaceBinExprOp_7(30L, m, ((IteratorDecl)m.EnclosingClass).Member_MoveNext)))
            {
                // skip the well-formedness check, because it has already been done for the iterator
            }
            else
            {
                if (!isByMethod)
                {
                    var proc = AddMethod(m, MethodTranslationKind.SpecWellformedness);
                    sink.AddTopLevelDeclaration(proc);
                    if (InVerificationScope(m))
                    {
                        AddMethodImpl(m, proc, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(37L, true));
                    }
                }
                if (MutateCSharp.Schemata498.ReplaceBinExprOp_6(39L, () => MutateCSharp.Schemata498.ReplaceBinExprOp_5(38L, m.OverriddenMethod, null), () => InVerificationScope(m))) //method has overridden a parent method
                {
                    var procOverrideChk = AddMethod(m, MethodTranslationKind.OverrideCheck);
                    sink.AddTopLevelDeclaration(procOverrideChk);
                    AddMethodOverrideCheckImpl(m, procOverrideChk);
                }
            }
            // the method spec itself
            if (!isByMethod)
            {
                sink.AddTopLevelDeclaration(AddMethod(m, MethodTranslationKind.Call));
            }
            if (m is ExtremeLemma)
            {
                // Let the CoCall and Impl forms to use m.PrefixLemma signature and specification (and
                // note that m.PrefixLemma.Body == m.Body.
                m = ((ExtremeLemma)m).PrefixLemma;
                sink.AddTopLevelDeclaration(AddMethod(m, MethodTranslationKind.CoCall));
            }
            if (MutateCSharp.Schemata498.ReplaceBinExprOp_6(52L, () => MutateCSharp.Schemata498.ReplaceBinExprOp_6(46L, () => !m.HasVerifyFalseAttribute, () => MutateCSharp.Schemata498.ReplaceBinExprOp_8(45L, m.Body, null)), () => InVerificationScope(m)))
            {
                // ...and its implementation
                assertionCount = MutateCSharp.Schemata498.ReplaceNumericConstant_9(58L, 0);
                var proc = AddMethod(m, MethodTranslationKind.Implementation);
                sink.AddTopLevelDeclaration(proc);
                AddMethodImpl(m, proc, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(62L, false));
            }
            Reset();
            this.fuelContext = oldFuelContext;
        }

        private void AddAllocationAxiom(Boogie.Declaration fieldDeclaration, Field f, TopLevelDeclWithMembers c, bool is_array = false)
        {
            Contract.Requires(c != null);
            // IFF you're adding the array axioms, then the field should be null
            Contract.Requires(is_array == (f == null));
            Contract.Requires(sink != null && predef != null);

            Bpl.Expr heightAntecedent = Bpl.Expr.True;
            if (f is ConstantField)
            {
                var cf = (ConstantField)f;
                AddWellformednessCheck(cf);
                if (InVerificationScope(cf))
                {
                    var etran = new ExpressionTranslator(this, predef, f.tok, null);
                    heightAntecedent = Bpl.Expr.Lt(Bpl.Expr.Literal(cf.EnclosingModule.CallGraph.GetSCCRepresentativePredecessorCount(cf)), etran.FunctionContextHeight());
                }
            }

            if (MutateCSharp.Schemata498.ReplaceBinExprOp_6(63L, () => f is ConstantField, () => f.IsStatic))
            {
                AddStaticConstFieldAllocationAxiom(fieldDeclaration, f, c, heightAntecedent);
            }
            else
            {
                AddInstanceFieldAllocationAxioms(fieldDeclaration, f, c, is_array, heightAntecedent);
            }
        }

        /// <summary>
        /// For a non-static field "f" in a class "c(G)", generate:
        ///     // type axiom:
        ///     // If "G" is empty, then TClassA(G) is omitted from trigger.
        ///     // If "c" is an array declaration, then the bound variables also include the index variables "ii" and "h[o, f]" has the form "h[o, Index(ii)]".
        ///     // If "f" is readonly, then "h[o, f]" has the form "f(o)" (for special fields) or "f(G,o)" (for programmer-declared const fields),
        ///     // so "h" and $IsHeap(h) are omitted.
        ///     axiom fh < FunctionContextHeight ==>
        ///       (forall o: ref, h: Heap, G : Ty ::
        ///         { h[o, f], TClassA(G) }
        ///         $IsHeap(h) &&
        ///         o != null && $Is(o, TClassA(G))  // or dtype(o) = TClassA(G)
        ///         ==>
        ///         $Is(h[o, f], TT(PP)));
        ///
        ///     // allocation axiom:
        ///     // As above for "G" and "ii", but "h" is included no matter what.
        ///     axiom fh < FunctionContextHeight ==>
        ///       (forall o: ref, h: Heap, G : Ty ::
        ///         { h[o, f], TClassA(G) }
        ///         $IsHeap(h) &&
        ///         o != null && $Is(o, TClassA(G)) &&  // or dtype(o) = TClassA(G)
        ///         h[o, alloc]
        ///         ==>
        ///         $IsAlloc(h[o, f], TT(PP), h));
        /// </summary>
        private void AddInstanceFieldAllocationAxioms(Bpl.Declaration fieldDeclaration, Field f, TopLevelDeclWithMembers c,
          bool is_array, Expr heightAntecedent)
        {
            var bvsTypeAxiom = new List<Bpl.Variable>();
            var bvsAllocationAxiom = new List<Bpl.Variable>();

            var tyvars = MkTyParamBinders(GetTypeParams(c), out var tyexprs);
            bvsTypeAxiom.AddRange(tyvars);
            bvsAllocationAxiom.AddRange(tyvars);

            // This is the typical case (that is, f is not a static const field)

            var hVar = BplBoundVar(MutateCSharp.Schemata498.ReplaceStringConstant_1(69L, "$h"), predef.HeapType, out var h);
            var oVar = BplBoundVar(MutateCSharp.Schemata498.ReplaceStringConstant_1(70L, "$o"), TrType(ModuleResolver.GetThisType(c.tok, c)), out var o);

            Bpl.Expr o_ty; // to hold TClassA(G)
            var isGoodHeap = FunctionCall(c.tok, BuiltinFunction.IsGoodHeap, null, h);
            Bpl.Expr isalloc_o;
            if (c is not ClassLikeDecl { IsReferenceTypeDecl: true })
            {
                var udt = UserDefinedType.FromTopLevelDecl(c.tok, c);
                o_ty = ClassTyCon(c, tyexprs);
                isalloc_o = MkIsAlloc(o, udt, h);
            }
            else if (RevealedInScope(c))
            {
                o_ty = ClassTyCon(c, tyexprs);
                isalloc_o = IsAlloced(c.tok, h, o);
            }
            else
            {
                // c is only provided, not revealed, in the scope. Use the non-null type decl's internal synonym
                var cl = (ClassLikeDecl)c;
                Contract.Assert(cl.NonNullTypeDecl != null);
                o_ty = ClassTyCon(cl.NonNullTypeDecl, tyexprs);
                var udt = UserDefinedType.FromTopLevelDecl(c.tok, cl.NonNullTypeDecl);
                isalloc_o = MkIsAlloc(o, udt, h);
            }

            Bpl.Expr indexBounds = Bpl.Expr.True;
            Bpl.Expr oDotF;
            if (is_array)
            {
                // generate h[o,Index(ii)]
                bvsTypeAxiom.Add(hVar);
                bvsTypeAxiom.Add(oVar);
                bvsAllocationAxiom.Add(hVar);
                bvsAllocationAxiom.Add(oVar);

                var ac = (ArrayClassDecl)c;
                var ixs = new List<Bpl.Expr>();
                for (int i = MutateCSharp.Schemata498.ReplaceNumericConstant_9(71L, 0); MutateCSharp.Schemata498.ReplaceBinExprOp_10(75L, i, ac.Dims); MutateCSharp.Schemata498.ReplacePostfixUnaryExprOp_11(80L, ref i))
                {
                    Bpl.Variable v = BplBoundVar(MutateCSharp.Schemata498.ReplaceStringConstant_1(81L, "$i") + i, Bpl.Type.Int, out var e);
                    ixs.Add(e);
                    bvsTypeAxiom.Add(v);
                    bvsAllocationAxiom.Add(v);
                }

                oDotF = ReadHeap(c.tok, h, o, GetArrayIndexFieldName(c.tok, ixs));

                for (int i = MutateCSharp.Schemata498.ReplaceNumericConstant_9(82L, 0); MutateCSharp.Schemata498.ReplaceBinExprOp_10(86L, i, ac.Dims); MutateCSharp.Schemata498.ReplacePostfixUnaryExprOp_11(91L, ref i))
                {
                    // 0 <= i && i < _System.array.Length(o)
                    var e1 = Bpl.Expr.Le(Bpl.Expr.Literal(MutateCSharp.Schemata498.ReplaceNumericConstant_9(92L, 0)), ixs[i]);
                    var ff = GetReadonlyField((Field)(ac.Members[i]));
                    var e2 = Bpl.Expr.Lt(ixs[i], new Bpl.NAryExpr(c.tok, new Bpl.FunctionCall(ff), new List<Bpl.Expr> { o }));
                    indexBounds = BplAnd(indexBounds, BplAnd(e1, e2));
                }
            }
            else if (f.IsMutable)
            {
                // generate h[o,f]
                var ty = TrType(f.Type);
                oDotF = ReadHeap(c.tok, h, o, new Bpl.IdentifierExpr(c.tok, GetField(f)));
                oDotF = MutateCSharp.Schemata498.ReplaceBinExprOp_12(96L, ty, predef.BoxType) ? oDotF : ApplyUnbox(c.tok, oDotF, ty);
                bvsTypeAxiom.Add(hVar);
                bvsTypeAxiom.Add(oVar);
                bvsAllocationAxiom.Add(hVar);
                bvsAllocationAxiom.Add(oVar);
            }
            else
            {
                // generate f(G,o)
                var args = new List<Bpl.Expr> { o };
                if (f is ConstantField)
                {
                    args = Concat(tyexprs, args);
                }

                oDotF = new Bpl.NAryExpr(c.tok, new Bpl.FunctionCall(GetReadonlyField(f)), args);
                bvsTypeAxiom.Add(oVar);
                bvsAllocationAxiom.Add(hVar);
                bvsAllocationAxiom.Add(oVar);
            }

            // antecedent: some subset of: $IsHeap(h) && o != null && $Is(o, TClassA(G)) && indexBounds
            Bpl.Expr ante = Bpl.Expr.True;
            if (MutateCSharp.Schemata498.ReplaceBinExprOp_13(97L, () => is_array, () => f.IsMutable))
            {
                ante = BplAnd(ante, isGoodHeap);
                // Note: for the allocation axiom, isGoodHeap is added back in for !f.IsMutable below
            }

            Bpl.Expr is_o = BplAnd(
              ReceiverNotNull(o),
      MutateCSharp.Schemata498.ReplaceBinExprOp_13(103L, () => !o.Type.Equals(predef.RefType), () => c is TraitDecl
      ) ? MkIs(o, o_ty, ModeledAsBoxType(ModuleResolver.GetThisType(c.tok, c))) // $Is(o, ..)
                : DType(o, o_ty)); // dtype(o) == o_ty
            ante = BplAnd(ante, is_o);

            ante = BplAnd(ante, indexBounds);

            // trigger
            var t_es = new List<Bpl.Expr>();
            t_es.Add(oDotF);
            if (MutateCSharp.Schemata498.ReplaceBinExprOp_6(124L, () => MutateCSharp.Schemata498.ReplaceBinExprOp_14(113L, tyvars.Count, MutateCSharp.Schemata498.ReplaceNumericConstant_9(109L, 0)), () => (MutateCSharp.Schemata498.ReplaceBinExprOp_13(118L, () => is_array, () => !(f is ConstantField)))))
            {
                t_es.Add(o_ty);
            }

            var tr = new Bpl.Trigger(c.tok, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(130L, true), t_es);

            // Now for the conclusion of the axioms
            Bpl.Expr is_hf, isalloc_hf = null;
            if (is_array)
            {
                is_hf = MkIs(oDotF, tyexprs[MutateCSharp.Schemata498.ReplaceNumericConstant_9(131L, 0)], MutateCSharp.Schemata498.ReplaceBooleanConstant_0(135L, true));
                isalloc_hf = MkIsAlloc(oDotF, tyexprs[MutateCSharp.Schemata498.ReplaceNumericConstant_9(136L, 0)], h, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(140L, true));
            }
            else
            {
                is_hf = MkIs(oDotF, f.Type); // $Is(h[o, f], ..)
                isalloc_hf = MkIsAlloc(oDotF, f.Type, h); // $IsAlloc(h[o, f], ..)
            }

            Bpl.Expr ax = BplForall(bvsTypeAxiom, tr, BplImp(ante, is_hf));
            AddOtherDefinition(fieldDeclaration, new Bpl.Axiom(c.tok, BplImp(heightAntecedent, ax), string.Format(MutateCSharp.Schemata498.ReplaceStringConstant_1(141L, "{0}.{1}: Type axiom"), c, f)));

            if (MutateCSharp.Schemata498.ReplaceBinExprOp_15(142L, isalloc_hf, null))
            {
                if (MutateCSharp.Schemata498.ReplaceBinExprOp_6(143L, () => !is_array, () => !f.IsMutable))
                {
                    // isGoodHeap wasn't added above, so add it now
                    ante = BplAnd(isGoodHeap, ante);
                }

                ante = BplAnd(ante, isalloc_o);

                // compute a different trigger
                t_es = new List<Bpl.Expr>();
                t_es.Add(oDotF);
                if (MutateCSharp.Schemata498.ReplaceBinExprOp_6(149L, () => !is_array, () => !f.IsMutable))
                {
                    // since "h" is not part of oDotF, we add a separate term that mentions "h"
                    t_es.Add(isalloc_o);
                }

                if (MutateCSharp.Schemata498.ReplaceBinExprOp_6(164L, () => !(f is ConstantField), () => MutateCSharp.Schemata498.ReplaceBinExprOp_14(159L, tyvars.Count, MutateCSharp.Schemata498.ReplaceNumericConstant_9(155L, 0))))
                {
                    t_es.Add(o_ty);
                }

                tr = new Bpl.Trigger(c.tok, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(170L, true), t_es);

                ax = BplForall(bvsAllocationAxiom, tr, BplImp(ante, isalloc_hf));
                AddOtherDefinition(fieldDeclaration, new Boogie.Axiom(c.tok, BplImp(heightAntecedent, ax), $"{c}.{f}: Allocation axiom"));
            }
        }

        /// <summary>
        /// For a static (necessarily "const") field "f" in a class "c(G)", the expression corresponding to "h[o, f]" or "f(G,o)" above is "f(G)",
        /// so generate:
        ///     // type axiom:
        ///     axiom fh < FunctionContextHeight ==>
        ///       (forall G : Ty ::
        ///         { f(G) }
        ///         $Is(f(G), TT(PP)));
        ///     // Or in the case where G is empty:
        ///     axiom $Is(f(G), TT);
        ///
        ///     // allocation axiom:
        ///     axiom fh < FunctionContextHeight ==>
        ///       (forall h: Heap, G : Ty ::
        ///         { $IsAlloc(f(G), TT(PP), h) }
        ///         $IsHeap(h)
        ///       ==>
        ///         $IsAlloc(f(G), TT(PP), h));
        ///
        ///
        /// The axioms above could be optimised to something along the lines of:
        ///     axiom fh < FunctionContextHeight ==>
        ///       (forall o: ref, h: Heap ::
        ///         { h[o, f] }
        ///         $IsHeap(h) && o != null && Tag(dtype(o)) = TagClass
        ///         ==>
        ///         (h[o, alloc] ==> $IsAlloc(h[o, f], TT(TClassA_Inv_i(dtype(o)),..), h)) &&
        ///         $Is(h[o, f], TT(TClassA_Inv_i(dtype(o)),..), h);
        /// <summary>
        private void AddStaticConstFieldAllocationAxiom(Boogie.Declaration fieldDeclaration, Field f, TopLevelDeclWithMembers c, Expr heightAntecedent)
        {

            var bvsTypeAxiom = new List<Bpl.Variable>();
            var bvsAllocationAxiom = new List<Bpl.Variable>();

            var tyvars = MkTyParamBinders(GetTypeParams(c), out var tyexprs);
            bvsTypeAxiom.AddRange(tyvars);
            bvsAllocationAxiom.AddRange(tyvars);

            var oDotF = new Boogie.NAryExpr(c.tok, new Boogie.FunctionCall(GetReadonlyField(f)), tyexprs);
            var is_hf = MkIs(oDotF, f.Type); // $Is(h[o, f], ..)
            Boogie.Expr ax = MutateCSharp.Schemata498.ReplaceBinExprOp_16(175L, bvsTypeAxiom.Count, MutateCSharp.Schemata498.ReplaceNumericConstant_9(171L, 0)) ? is_hf : BplForall(bvsTypeAxiom, BplTrigger(oDotF), is_hf);
            var isAxiom = new Boogie.Axiom(c.tok, BplImp(heightAntecedent, ax), $"{c}.{f}: Type axiom");
            AddOtherDefinition(fieldDeclaration, isAxiom);

            {
                var hVar = BplBoundVar(MutateCSharp.Schemata498.ReplaceStringConstant_1(180L, "$h"), predef.HeapType, out var h);
                bvsAllocationAxiom.Add(hVar);
                var isGoodHeap = FunctionCall(c.tok, BuiltinFunction.IsGoodHeap, null, h);
                var isalloc_hf = MkIsAlloc(oDotF, f.Type, h); // $IsAlloc(h[o, f], ..)
                ax = BplForall(bvsAllocationAxiom, BplTrigger(isalloc_hf), BplImp(isGoodHeap, isalloc_hf));
                var isAllocAxiom = new Boogie.Axiom(c.tok, BplImp(heightAntecedent, ax), $"{c}.{f}: Allocation axiom");
                sink.AddTopLevelDeclaration(isAllocAxiom);
            }
        }

        private void AddImplementsAxioms(ClassDecl c)
        {
            //this adds: axiom implements$J(class.C, typeInstantiations);
            var vars = MkTyParamBinders(GetTypeParams(c), out var tyexprs);

            foreach (var parent in c.ParentTraits)
            {
                var trait = ((UserDefinedType)parent).AsParentTraitDecl();
                Contract.Assert(trait != null);
                var arg = ClassTyCon(c, tyexprs);
                var args = new List<Bpl.Expr> { arg };
                foreach (var targ in parent.TypeArgs)
                {
                    args.Add(TypeToTy(targ));
                }
                var expr = FunctionCall(c.tok, MutateCSharp.Schemata498.ReplaceStringConstant_1(181L, "implements$") + trait.FullSanitizedName, Bpl.Type.Bool, args);
                var implements_axiom = new Bpl.Axiom(c.tok, BplForall(vars, null, expr));
                AddOtherDefinition(GetOrCreateTypeConstructor(c), implements_axiom);
            }
        }

        private void AddClassMember_Function(Function f)
        {
            Contract.Ensures(currentModule == null && codeContext == null);
            Contract.Ensures(currentModule == null && codeContext == null);

            currentModule = f.EnclosingClass.EnclosingModuleDefinition;
            codeContext = f;

            // declare function
            var boogieFunction = GetOrCreateFunction(f);
            // add synonym axiom
            if (f.IsFuelAware())
            {
                AddFuelSuccSynonymAxiom(f);
                AddFuelZeroSynonymAxiom(f);
            }
            // add frame axiom
            if (f.ReadsHeap)
            {
                AddFrameAxiom(f);
            }
            // add consequence axiom
            AddFunctionConsequenceAxiom(boogieFunction, f, f.Ens);
            // add definition axioms, suitably specialized for literals
            if (MutateCSharp.Schemata498.ReplaceBinExprOp_6(183L, () => MutateCSharp.Schemata498.ReplaceBinExprOp_17(182L, f.Body, null), () => RevealedInScope(f)))
            {
                AddFunctionAxiom(boogieFunction, f, f.Body.Resolved);
            }
            else
            {
                // for body-less functions, at least generate its #requires function
                var b = GetFunctionAxiom(f, null, null);
                Contract.Assert(b == null);
            }
            // for a function in a class C that overrides a function in a trait J, add an axiom that connects J.F and C.F
            if (MutateCSharp.Schemata498.ReplaceBinExprOp_4(189L, f.OverriddenFunction, null))
            {
                sink.AddTopLevelDeclaration(FunctionOverrideAxiom(f.OverriddenFunction, f));
            }

            // supply the connection between least/greatest predicates and prefix predicates
            if (f is ExtremePredicate)
            {
                AddPrefixPredicateAxioms(((ExtremePredicate)f).PrefixPredicate);
            }

            Reset();
        }

        private void AddMethodImpl(Method m, Boogie.Procedure proc, bool wellformednessProc)
        {
            Contract.Requires(m != null);
            Contract.Requires(proc != null);
            Contract.Requires(sink != null && predef != null);
            Contract.Requires(wellformednessProc || m.Body != null);
            Contract.Requires(currentModule == null && codeContext == null && _tmpIEs.Count == 0 && isAllocContext == null);
            Contract.Ensures(currentModule == null && codeContext == null && _tmpIEs.Count == 0 && isAllocContext == null);

            proofDependencies.SetCurrentDefinition(proc.VerboseName);
            currentModule = m.EnclosingClass.EnclosingModuleDefinition;
            codeContext = m;
            isAllocContext = new IsAllocContext(options, m.IsGhost);

            List<Variable> inParams = Boogie.Formal.StripWhereClauses(proc.InParams);
            List<Variable> outParams = Boogie.Formal.StripWhereClauses(proc.OutParams);

            var builder = new BoogieStmtListBuilder(this, options);
            var builderInitializationArea = new BoogieStmtListBuilder(this, options);
            builder.Add(new CommentCmd(MutateCSharp.Schemata498.ReplaceStringConstant_1(190L, "AddMethodImpl: ") + m + MutateCSharp.Schemata498.ReplaceStringConstant_1(191L, ", ") + proc));
            var etran = new ExpressionTranslator(this, predef, m.tok,
              m.IsByMethod ? m.FunctionFromWhichThisIsByMethodDecl : m);
            // Only do reads checks for methods, not lemmas
            // (which aren't allowed to declare frames and don't check reads and writes against them).
            // Also don't do any reads checks if the reads clause is *,
            // since all the checks will be trivially true
            // and we don't need to cause additional verification cost for existing code.
            if (MutateCSharp.Schemata498.ReplaceBinExprOp_13(198L, () => MutateCSharp.Schemata498.ReplaceBinExprOp_13(192L, () => !options.Get(Method.ReadsClausesOnMethods), () => m.IsLemmaLike), () => m.Reads.Expressions.Exists(e => e.E is WildcardExpr)))
            {
                etran = etran.WithReadsFrame(null);
            }
            InitializeFuelConstant(m.tok, builder, etran);
            var localVariables = new List<Variable>();
            GenerateImplPrelude(m, wellformednessProc, inParams, outParams, builder, localVariables, etran);

            if (UseOptimizationInZ3)
            {
                // We ask Z3 to minimize all parameters of type 'nat'.
                foreach (var f in m.Ins)
                {
                    var udt = f.Type.NormalizeExpandKeepConstraints() as UserDefinedType;
                    if (MutateCSharp.Schemata498.ReplaceBinExprOp_6(207L, () => MutateCSharp.Schemata498.ReplaceBinExprOp_18(204L, udt, null), () => MutateCSharp.Schemata498.ReplaceBinExprOp_19(206L, udt.Name, MutateCSharp.Schemata498.ReplaceStringConstant_1(205L, "nat"))))
                    {
                        builder.Add(optimizeExpr(MutateCSharp.Schemata498.ReplaceBooleanConstant_0(213L, true), new IdentifierExpr(f.tok, f), f.Tok, etran));
                    }
                }
            }

            Boogie.StmtList stmts;
            if (!wellformednessProc)
            {
                var inductionVars = ApplyInduction(m.Ins, m.Attributes);
                if (MutateCSharp.Schemata498.ReplaceBinExprOp_20(218L, inductionVars.Count, MutateCSharp.Schemata498.ReplaceNumericConstant_9(214L, 0)))
                {
                    // Let the parameters be this,x,y of the method M and suppose ApplyInduction returns this,y.
                    // Also, let Pre be the precondition and VF be the decreases clause.
                    // Then, insert into the method body what amounts to:
                    //     assume case-analysis-on-parameter[[ y' ]];
                    //     forall this',y' | Pre(this', x, y') && (VF(this', x, y') << VF(this', x, y)) {
                    //       this'.M(x, y');
                    //     }
                    // Generate bound variables for the forall statement, and a substitution for the Pre and VF

                    // assume case-analysis-on-parameter[[ y' ]];
                    foreach (var inFormal in m.Ins)
                    {
                        var dt = inFormal.Type.AsDatatype;
                        if (MutateCSharp.Schemata498.ReplaceBinExprOp_21(223L, dt, null))
                        {
                            var funcID = new Boogie.FunctionCall(new Boogie.IdentifierExpr(inFormal.tok, MutateCSharp.Schemata498.ReplaceStringConstant_1(224L, "$IsA#") + dt.FullSanitizedName, Boogie.Type.Bool));
                            var f = new Boogie.IdentifierExpr(inFormal.tok, inFormal.AssignUniqueName(m.IdGenerator), TrType(inFormal.Type));
                            builder.Add(TrAssumeCmd(inFormal.tok, new Boogie.NAryExpr(inFormal.tok, funcID, new List<Boogie.Expr> { f })));
                        }
                    }

                    var parBoundVars = new List<BoundVar>();
                    var parBounds = new List<BoundedPool>();
                    var substMap = new Dictionary<IVariable, Expression>();
                    Expression receiverSubst = null;
                    foreach (var iv in inductionVars)
                    {
                        BoundVar bv;
                        if (MutateCSharp.Schemata498.ReplaceBinExprOp_22(225L, iv, null))
                        {
                            // this corresponds to "this"
                            Contract.Assert(!m.IsStatic);  // if "m" is static, "this" should never have gone into the _induction attribute
                            Contract.Assert(receiverSubst == null);  // we expect at most one
                            var receiverType = ModuleResolver.GetThisType(m.tok, (TopLevelDeclWithMembers)m.EnclosingClass);
                            bv = new BoundVar(m.tok, CurrentIdGenerator.FreshId(MutateCSharp.Schemata498.ReplaceStringConstant_1(226L, "$ih#this")), receiverType); // use this temporary variable counter, but for a Dafny name (the idea being that the number and the initial "_" in the name might avoid name conflicts)
                            var ie = new IdentifierExpr(m.tok, bv.Name)
                            {
                                Var = bv,
                                Type = bv.Type
                            };
                            receiverSubst = ie;
                        }
                        else
                        {
                            CloneVariableAsBoundVar(iv.tok, iv, MutateCSharp.Schemata498.ReplaceStringConstant_1(227L, "$ih#") + iv.Name, out bv, out var ie);
                            substMap.Add(iv, ie);
                        }
                        parBoundVars.Add(bv);
                        parBounds.Add(new SpecialAllocIndependenceAllocatedBoundedPool());  // record that we don't want alloc antecedents for these variables
                    }

                    // Generate a CallStmt to be used as the body of the 'forall' statement.
                    m.RecursiveCallParameters(m.tok, m.TypeArgs, m.Ins, receiverSubst, substMap, out var recursiveCallReceiver, out var recursiveCallArgs);
                    var methodSel = new MemberSelectExpr(m.tok, recursiveCallReceiver, m.Name)
                    {
                        Member = m,
                        TypeApplication_AtEnclosingClass = m.EnclosingClass.TypeArgs.ConvertAll(tp => (Type)new UserDefinedType(tp.tok, tp)),
                        TypeApplication_JustMember = m.TypeArgs.ConvertAll(tp => (Type)new UserDefinedType(tp.tok, tp)),
                        Type = new InferredTypeProxy()
                    };
                    var recursiveCall = new CallStmt(m.tok.ToRange(), new List<Expression>(), methodSel, recursiveCallArgs)
                    {
                        IsGhost = m.IsGhost
                    };

                    Expression parRange = Expression.CreateBoolLiteral(m.tok, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(228L, true));
                    foreach (var pre in m.Req)
                    {
                        parRange = Expression.CreateAnd(parRange, Substitute(pre.E, receiverSubst, substMap));
                    }
                    // construct an expression (generator) for:  VF' << VF
                    ExpressionConverter decrCheck = delegate (Dictionary<IVariable, Expression> decrSubstMap, ExpressionTranslator exprTran)
                    {
                        var decrToks = new List<IToken>();
                        var decrTypes = new List<Type>();
                        var decrCallee = new List<Expr>();
                        var decrCaller = new List<Expr>();
                        foreach (var ee in m.Decreases.Expressions)
                        {
                            decrToks.Add(ee.tok);
                            decrTypes.Add(ee.Type.NormalizeExpand());
                            decrCaller.Add(exprTran.TrExpr(ee));
                            Expression es = Substitute(ee, receiverSubst, substMap);
                            es = Substitute(es, null, decrSubstMap);
                            decrCallee.Add(exprTran.TrExpr(es));
                        }
                        return DecreasesCheck(decrToks, decrTypes, decrTypes, decrCallee, decrCaller, null, null, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(229L, false), MutateCSharp.Schemata498.ReplaceBooleanConstant_0(230L, true));
                    };

#if VERIFY_CORRECTNESS_OF_TRANSLATION_FORALL_STATEMENT_RANGE
          var definedness = new BoogieStmtListBuilder(this, options);
          var exporter = new BoogieStmtListBuilder(this, options);
          TrForallStmtCall(m.tok, parBoundVars, parRange, decrCheck, null, recursiveCall, definedness, exporter, localVariables, etran);
          // All done, so put the two pieces together
          builder.Add(new Bpl.IfCmd(m.tok, null, definedness.Collect(m.tok), null, exporter.Collect(m.tok)));
#else
                    TrForallStmtCall(m.tok, parBoundVars, parBounds, parRange, decrCheck, null, recursiveCall, null, builder, localVariables, etran);
#endif
                }
                // translate the body of the method
                Contract.Assert(m.Body != null);  // follows from method precondition and the if guard

                // $_reverifyPost := false;
                builder.Add(Boogie.Cmd.SimpleAssign(m.tok, new Boogie.IdentifierExpr(m.tok, MutateCSharp.Schemata498.ReplaceStringConstant_1(231L, "$_reverifyPost"), Boogie.Type.Bool), Boogie.Expr.False));
                // register output parameters with definite-assignment trackers
                Contract.Assert(definiteAssignmentTrackers.Count == 0);
                m.Outs.ForEach(p => AddExistingDefiniteAssignmentTracker(p, m.IsGhost));
                // translate the body
                TrStmt(m.Body, builder, localVariables, etran);
                m.Outs.ForEach(p => CheckDefiniteAssignmentReturn(m.Body.RangeToken.EndToken, p, builder));
                if (m is { FunctionFromWhichThisIsByMethodDecl: { ByMethodTok: { } } fun })
                {
                    AssumeCanCallForByMethodDecl(m, builder);
                }
                stmts = builder.Collect(m.Body.RangeToken.StartToken); // TODO should this be EndToken?  the parameter name suggests it should be the closing curly
                                                                       // tear down definite-assignment trackers
                m.Outs.ForEach(RemoveDefiniteAssignmentTracker);

                Contract.Assert(definiteAssignmentTrackers.Count == 0);
            }
            else
            {
                var readsCheckDelayer = new ReadsCheckDelayer(etran, null, localVariables, builderInitializationArea, builder);

                // check well-formedness of any default-value expressions (before assuming preconditions)
                readsCheckDelayer.DoWithDelayedReadsChecks(MutateCSharp.Schemata498.ReplaceBooleanConstant_0(232L, true), wfo =>
                {
                    foreach (var formal in m.Ins.Where(formal => MutateCSharp.Schemata498.ReplaceBinExprOp_17(233L, formal.DefaultValue, null)))
                    {
                        var e = formal.DefaultValue;
                        CheckWellformed(e, wfo, localVariables, builder, etran.WithReadsFrame(etran.readsFrame, null)); // No scope for default parameters
                        builder.Add(new Boogie.AssumeCmd(e.tok, etran.CanCallAssumption(e)));
                        CheckSubrange(e.tok, etran.TrExpr(e), e.Type, formal.Type, builder);

                        if (formal.IsOld)
                        {
                            Boogie.Expr wh = GetWhereClause(e.tok, etran.TrExpr(e), e.Type, etran.Old, ISALLOC, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(234L, true));
                            if (MutateCSharp.Schemata498.ReplaceBinExprOp_15(235L, wh, null))
                            {
                                var desc = new PODesc.IsAllocated(MutateCSharp.Schemata498.ReplaceStringConstant_1(236L, "default value"), MutateCSharp.Schemata498.ReplaceStringConstant_1(237L, "in the two-state lemma's previous state"), e);
                                builder.Add(Assert(e.RangeToken, wh, desc));
                            }
                        }
                    }
                });

                // check well-formedness of the preconditions, and then assume each one of them
                readsCheckDelayer.DoWithDelayedReadsChecks(MutateCSharp.Schemata498.ReplaceBooleanConstant_0(238L, false), wfo =>
                {
                    foreach (AttributedExpression p in m.Req)
                    {
                        CheckWellformedAndAssume(p.E, wfo, localVariables, builder, etran, MutateCSharp.Schemata498.ReplaceStringConstant_1(239L, "method requires clause"));
                    }
                });

                // check well-formedness of the reads clauses
                readsCheckDelayer.DoWithDelayedReadsChecks(MutateCSharp.Schemata498.ReplaceBooleanConstant_0(240L, false), wfo =>
                {
                    CheckFrameWellFormed(wfo, m.Reads.Expressions, localVariables, builder, etran);
                });
                // Also check that the reads clause == {} if the {:concurrent} attribute is present
                // on the method, and {:assume_concurrent} is NOT present on the reads clause.
                if (MutateCSharp.Schemata498.ReplaceBinExprOp_6(241L, () => Attributes.Contains(m.Attributes, Attributes.ConcurrentAttributeName), () => !Attributes.Contains(m.Reads.Attributes, Attributes.AssumeConcurrentAttributeName)))
                {
                    var desc = new PODesc.ConcurrentFrameEmpty(MutateCSharp.Schemata498.ReplaceStringConstant_1(247L, "reads clause"));
                    if (etran.readsFrame != null)
                    {
                        CheckFrameEmpty(m.tok, etran, etran.ReadsFrame(m.tok), builder, desc, null);
                    }
                    else
                    {
                        // etran.readsFrame being null indicates the default of reads *,
                        // so this is an automatic failure.
                        builder.Add(Assert(m.tok, Expr.False, desc));
                    }
                }

                // check well-formedness of the modifies clauses
                readsCheckDelayer.DoWithDelayedReadsChecks(MutateCSharp.Schemata498.ReplaceBooleanConstant_0(248L, false), wfo =>
                {
                    CheckFrameWellFormed(wfo, m.Mod.Expressions, localVariables, builder, etran);
                });
                // Also check that the modifies clause == {} if the {:concurrent} attribute is present,
                // and {:assume_concurrent} is NOT present on the modifies clause.
                if (MutateCSharp.Schemata498.ReplaceBinExprOp_6(249L, () => Attributes.Contains(m.Attributes, Attributes.ConcurrentAttributeName), () => !Attributes.Contains(m.Mod.Attributes, Attributes.AssumeConcurrentAttributeName)))
                {
                    var desc = new PODesc.ConcurrentFrameEmpty(MutateCSharp.Schemata498.ReplaceStringConstant_1(255L, "modifies clause"));
                    CheckFrameEmpty(m.tok, etran, etran.ModifiesFrame(m.tok), builder, desc, null);
                }

                // check well-formedness of the decreases clauses
                foreach (Expression p in m.Decreases.Expressions)
                {
                    CheckWellformed(p, new WFOptions(), localVariables, builder, etran);
                }

                if (!(m is TwoStateLemma))
                {
                    // play havoc with the heap according to the modifies clause
                    builder.Add(new Boogie.HavocCmd(m.tok, new List<Boogie.IdentifierExpr> { etran.HeapCastToIdentifierExpr }));
                    // assume the usual two-state boilerplate information
                    foreach (BoilerplateTriple tri in GetTwoStateBoilerplate(m.tok, m.Mod.Expressions, m.IsGhost, m.AllowsAllocation, etran.Old, etran, etran.Old))
                    {
                        if (tri.IsFree)
                        {
                            builder.Add(TrAssumeCmd(m.tok, tri.Expr));
                        }
                    }
                }

                // also play havoc with the out parameters
                if (MutateCSharp.Schemata498.ReplaceBinExprOp_20(260L, outParams.Count, MutateCSharp.Schemata498.ReplaceNumericConstant_9(256L, 0)))
                {  // don't create an empty havoc statement
                    List<Boogie.IdentifierExpr> outH = new List<Boogie.IdentifierExpr>();
                    foreach (Boogie.Variable b in outParams)
                    {
                        Contract.Assert(b != null);
                        outH.Add(new Boogie.IdentifierExpr(b.tok, b));
                    }
                    builder.Add(new Boogie.HavocCmd(m.tok, outH));
                }
                // mark the end of the modifles/out-parameter havocking with a CaptureState; make its location be the first ensures clause, if any (and just
                // omit the CaptureState if there's no ensures clause)
                if (MutateCSharp.Schemata498.ReplaceBinExprOp_20(269L, m.Ens.Count, MutateCSharp.Schemata498.ReplaceNumericConstant_9(265L, 0)))
                {
                    builder.AddCaptureState(m.Ens[MutateCSharp.Schemata498.ReplaceNumericConstant_9(274L, 0)].E.tok, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(278L, false), MutateCSharp.Schemata498.ReplaceStringConstant_1(279L, "post-state"));
                }

                // check wellformedness of postconditions
                foreach (AttributedExpression p in m.Ens)
                {
                    CheckWellformedAndAssume(p.E, new WFOptions(), localVariables, builder, etran, MutateCSharp.Schemata498.ReplaceStringConstant_1(280L, "method ensures clause"));
                }

                var s0 = builderInitializationArea.Collect(m.tok);
                var s1 = builder.Collect(m.tok);
                stmts = new StmtList(new List<BigBlock>(s0.BigBlocks.Concat(s1.BigBlocks)), m.tok);
            }

            if (EmitImplementation(m.Attributes))
            {
                // emit impl only when there are proof obligations.
                QKeyValue kv = etran.TrAttributes(m.Attributes, null);
                Boogie.Implementation impl = AddImplementationWithAttributes(GetToken(m), proc,
                   inParams, outParams, localVariables, stmts, kv);

                if (InsertChecksums)
                {
                    InsertChecksum(m, impl);
                }
            }

            isAllocContext = null;
            Reset();
        }

        private void AddMethodOverrideCheckImpl(Method m, Boogie.Procedure proc)
        {
            Contract.Requires(m != null);
            Contract.Requires(proc != null);
            Contract.Requires(sink != null && predef != null);
            Contract.Requires(m.OverriddenMethod != null);
            Contract.Requires(m.Ins.Count == m.OverriddenMethod.Ins.Count);
            Contract.Requires(m.Outs.Count == m.OverriddenMethod.Outs.Count);
            //Contract.Requires(wellformednessProc || m.Body != null);
            Contract.Requires(currentModule == null && codeContext == null && _tmpIEs.Count == 0 && isAllocContext == null);
            Contract.Ensures(currentModule == null && codeContext == null && _tmpIEs.Count == 0 && isAllocContext == null);

            proofDependencies.SetCurrentDefinition(proc.VerboseName);
            currentModule = m.EnclosingClass.EnclosingModuleDefinition;
            codeContext = m;
            isAllocContext = new IsAllocContext(options, m.IsGhost);

            List<Variable> inParams = Boogie.Formal.StripWhereClauses(proc.InParams);
            List<Variable> outParams = Boogie.Formal.StripWhereClauses(proc.OutParams);

            var builder = new BoogieStmtListBuilder(this, options);
            var etran = new ExpressionTranslator(this, predef, m.tok, m);
            var localVariables = new List<Variable>();
            InitializeFuelConstant(m.tok, builder, etran);

            // assume traitTypeParameter == G(overrideTypeParameters);
            AddOverrideCheckTypeArgumentInstantiations(m, builder, localVariables);

            if (m is TwoStateLemma)
            {
                // $Heap := current$Heap;
                var heap = ExpressionTranslator.HeapIdentifierExpr(predef, m.tok);
                builder.Add(Boogie.Cmd.SimpleAssign(m.tok, heap, new Boogie.IdentifierExpr(m.tok, MutateCSharp.Schemata498.ReplaceStringConstant_1(281L, "current$Heap"), predef.HeapType)));
            }


            var substMap = new Dictionary<IVariable, Expression>();
            for (int i = MutateCSharp.Schemata498.ReplaceNumericConstant_9(282L, 0); MutateCSharp.Schemata498.ReplaceBinExprOp_10(286L, i, m.Ins.Count); MutateCSharp.Schemata498.ReplacePostfixUnaryExprOp_11(291L, ref i))
            {
                // get corresponding formal in the class
                var ie = new IdentifierExpr(m.Ins[i].tok, m.Ins[i].AssignUniqueName(m.IdGenerator));
                ie.Var = m.Ins[i]; ie.Type = ie.Var.Type;
                substMap.Add(m.OverriddenMethod.Ins[i], ie);
            }
            for (int i = MutateCSharp.Schemata498.ReplaceNumericConstant_9(292L, 0); MutateCSharp.Schemata498.ReplaceBinExprOp_10(296L, i, m.Outs.Count); MutateCSharp.Schemata498.ReplacePostfixUnaryExprOp_11(301L, ref i))
            {
                // get corresponding formal in the class
                var ie = new IdentifierExpr(m.Outs[i].tok, m.Outs[i].AssignUniqueName(m.IdGenerator));
                ie.Var = m.Outs[i]; ie.Type = ie.Var.Type;
                substMap.Add(m.OverriddenMethod.Outs[i], ie);
            }

            var typeMap = GetTypeArgumentSubstitutionMap(m.OverriddenMethod, m);

            Boogie.StmtList stmts;
            //adding assume Pre’; assert P; // this checks that Pre’ implies P
            AddMethodOverrideReqsChk(m, builder, etran, substMap, typeMap);

            //adding assert R <= Rank’;
            AddOverrideTerminationChk(m, m.OverriddenMethod, builder, etran, substMap, typeMap);

            //adding assert F <= Frame’ (for both reads and modifies clauses)
            AddMethodOverrideFrameSubsetChk(m, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(302L, false), builder, etran, localVariables, substMap, typeMap);
            AddMethodOverrideFrameSubsetChk(m, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(303L, true), builder, etran, localVariables, substMap, typeMap);

            if (!(m is TwoStateLemma))
            {
                //change the heap at locations W
                HavocMethodFrameLocations(m, builder, etran, localVariables);
            }

            //adding assume Q; assert Post’;
            AddMethodOverrideEnsChk(m, builder, etran, substMap, typeMap);

            stmts = builder.Collect(m.tok);

            if (EmitImplementation(m.Attributes))
            {
                // emit the impl only when there are proof obligations.
                QKeyValue kv = etran.TrAttributes(m.Attributes, null);

                Boogie.Implementation impl = AddImplementationWithAttributes(GetToken(m), proc, inParams, outParams, localVariables, stmts, kv);

                if (InsertChecksums)
                {
                    InsertChecksum(m, impl);
                }
            }

            isAllocContext = null;
            Reset();
        }

        private void HavocMethodFrameLocations(Method m, BoogieStmtListBuilder builder, ExpressionTranslator etran, List<Variable> localVariables)
        {
            Contract.Requires(m != null);
            Contract.Requires(m.EnclosingClass != null && m.EnclosingClass is ClassLikeDecl);

            // play havoc with the heap according to the modifies clause
            builder.Add(new Bpl.HavocCmd(m.tok, new List<Bpl.IdentifierExpr> { etran.HeapCastToIdentifierExpr }));
            // assume the usual two-state boilerplate information
            foreach (BoilerplateTriple tri in GetTwoStateBoilerplate(m.tok, m.Mod.Expressions, m.IsGhost, m.AllowsAllocation, etran.Old, etran, etran.Old))
            {
                if (tri.IsFree)
                {
                    builder.Add(TrAssumeCmd(m.tok, tri.Expr));
                }
            }
        }

        private void AddFunctionOverrideCheckImpl(Function f)
        {
            Contract.Requires(f != null);
            Contract.Requires(f.EnclosingClass is TopLevelDeclWithMembers);
            Contract.Requires(sink != null && predef != null);
            Contract.Requires(f.OverriddenFunction != null);
            Contract.Requires(f.Ins.Count == f.OverriddenFunction.Ins.Count);
            Contract.Requires(currentModule == null && codeContext == null && _tmpIEs.Count == 0 && isAllocContext != null);
            Contract.Ensures(currentModule == null && codeContext == null && _tmpIEs.Count == 0 && isAllocContext != null);

            proofDependencies.SetCurrentDefinition(MethodVerboseName(f.FullDafnyName, MethodTranslationKind.OverrideCheck));
            #region first procedure, no impl yet
            //Function nf = new Function(f.tok, "OverrideCheck_" + f.Name, f.IsStatic, f.IsGhost, f.TypeArgs, f.OpenParen, f.Formals, f.ResultType, f.Req, f.Reads, f.Ens, f.Decreases, f.Body, f.Attributes, f.SignatureEllipsis);
            //AddFunction(f);
            currentModule = f.EnclosingClass.EnclosingModuleDefinition;
            codeContext = f;

            Boogie.Expr prevHeap = null;
            Boogie.Expr currHeap = null;
            var ordinaryEtran = new ExpressionTranslator(this, predef, f.tok, f);
            ExpressionTranslator etran;
            var inParams_Heap = new List<Boogie.Variable>();
            if (f is TwoStateFunction)
            {
                var prevHeapVar = new Boogie.Formal(f.tok, new Boogie.TypedIdent(f.tok, MutateCSharp.Schemata498.ReplaceStringConstant_1(304L, "previous$Heap"), predef.HeapType), MutateCSharp.Schemata498.ReplaceBooleanConstant_0(305L, true));
                inParams_Heap.Add(prevHeapVar);
                prevHeap = new Boogie.IdentifierExpr(f.tok, prevHeapVar);
                if (f.ReadsHeap)
                {
                    var currHeapVar = new Boogie.Formal(f.tok, new Boogie.TypedIdent(f.tok, MutateCSharp.Schemata498.ReplaceStringConstant_1(306L, "current$Heap"), predef.HeapType), MutateCSharp.Schemata498.ReplaceBooleanConstant_0(307L, true));
                    inParams_Heap.Add(currHeapVar);
                    currHeap = new Boogie.IdentifierExpr(f.tok, currHeapVar);
                }
                etran = new ExpressionTranslator(this, predef, currHeap, prevHeap, f);
            }
            else
            {
                etran = ordinaryEtran;
            }

            // parameters of the procedure
            var typeInParams = MkTyParamFormals(GetTypeParams(f), MutateCSharp.Schemata498.ReplaceBooleanConstant_0(308L, true));
            var inParams = new List<Variable>();
            var outParams = new List<Boogie.Variable>();
            if (!f.IsStatic)
            {
                var th = new Boogie.IdentifierExpr(f.tok, MutateCSharp.Schemata498.ReplaceStringConstant_1(309L, "this"), TrReceiverType(f));
                Boogie.Expr wh = BplAnd(
                  ReceiverNotNull(th),
                  etran.GoodRef(f.tok, th, ModuleResolver.GetReceiverType(f.tok, f)));
                Boogie.Formal thVar = new Boogie.Formal(f.tok, new Boogie.TypedIdent(f.tok, MutateCSharp.Schemata498.ReplaceStringConstant_1(310L, "this"), TrReceiverType(f), wh), MutateCSharp.Schemata498.ReplaceBooleanConstant_0(311L, true));
                inParams.Add(thVar);
            }
            foreach (Formal p in f.Ins)
            {
                Boogie.Type varType = TrType(p.Type);
                Boogie.Expr wh = GetWhereClause(p.tok, new Boogie.IdentifierExpr(p.tok, p.AssignUniqueName(f.IdGenerator), varType), p.Type, etran, NOALLOC);
                inParams.Add(new Boogie.Formal(p.tok, new Boogie.TypedIdent(p.tok, p.AssignUniqueName(f.IdGenerator), varType, wh), MutateCSharp.Schemata498.ReplaceBooleanConstant_0(312L, true)));
            }

            Formal pOut = null;
            if (MutateCSharp.Schemata498.ReplaceBinExprOp_13(315L, () => MutateCSharp.Schemata498.ReplaceBinExprOp_23(313L, f.Result, null), () => MutateCSharp.Schemata498.ReplaceBinExprOp_23(314L, f.OverriddenFunction.Result, null)))
            {
                if (MutateCSharp.Schemata498.ReplaceBinExprOp_23(321L, f.Result, null))
                {
                    pOut = f.Result;
                    Contract.Assert(!pOut.IsOld);
                }
                else
                {
                    var pp = f.OverriddenFunction.Result;
                    Contract.Assert(!pp.IsOld);
                    pOut = new Formal(pp.tok, pp.Name, f.ResultType, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(322L, false), pp.IsGhost, null);
                }
                var varType = TrType(pOut.Type);
                var wh = GetWhereClause(pOut.tok, new Boogie.IdentifierExpr(pOut.tok, pOut.AssignUniqueName(f.IdGenerator), varType), pOut.Type, etran, NOALLOC);
                outParams.Add(new Boogie.Formal(pOut.tok, new Boogie.TypedIdent(pOut.tok, pOut.AssignUniqueName(f.IdGenerator), varType, wh), MutateCSharp.Schemata498.ReplaceBooleanConstant_0(323L, true)));
            }
            // the procedure itself
            var req = new List<Boogie.Requires>();
            // free requires fh == FunctionContextHeight;
            req.Add(Requires(f.tok, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(324L, true), etran.HeightContext(f), null, null, null));
            if (f is TwoStateFunction)
            {
                // free requires prevHeap == Heap && HeapSucc(prevHeap, currHeap) && IsHeap(currHeap)
                var a0 = Boogie.Expr.Eq(prevHeap, ordinaryEtran.HeapExpr);
                var a1 = HeapSucc(prevHeap, currHeap);
                var a2 = FunctionCall(f.tok, BuiltinFunction.IsGoodHeap, null, currHeap);
                req.Add(Requires(f.tok, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(325L, true), BplAnd(a0, BplAnd(a1, a2)), null, null, null));
            }
            // modifies $Heap
            var mod = new List<Boogie.IdentifierExpr> {
        ordinaryEtran.HeapCastToIdentifierExpr,
      };
            var ens = new List<Boogie.Ensures>();

            var name = MethodName(f, MethodTranslationKind.OverrideCheck);
            var proc = new Boogie.Procedure(f.tok, name, new List<Boogie.TypeVariable>(),
              Util.Concat(Util.Concat(typeInParams, inParams_Heap), inParams), outParams,
      MutateCSharp.Schemata498.ReplaceBooleanConstant_0(326L, false), req, mod, ens, etran.TrAttributes(f.Attributes, null));
            AddVerboseNameAttribute(proc, f.FullDafnyName, MethodTranslationKind.OverrideCheck);
            sink.AddTopLevelDeclaration(proc);
            var implInParams = Boogie.Formal.StripWhereClauses(inParams);
            var implOutParams = Boogie.Formal.StripWhereClauses(outParams);

            #endregion

            //List<Variable> outParams = Bpl.Formal.StripWhereClauses(proc.OutParams);

            BoogieStmtListBuilder builder = new BoogieStmtListBuilder(this, options);
            List<Variable> localVariables = new List<Variable>();

            InitializeFuelConstant(f.tok, builder, etran);

            // assume traitTypeParameter == G(overrideTypeParameters);
            AddOverrideCheckTypeArgumentInstantiations(f, builder, localVariables);

            if (f is TwoStateFunction)
            {
                // $Heap := current$Heap;
                var heap = ordinaryEtran.HeapCastToIdentifierExpr;
                builder.Add(Boogie.Cmd.SimpleAssign(f.tok, heap, etran.HeapExpr));
                etran = ordinaryEtran;  // we no longer need the special heap names
            }

            var substMap = new Dictionary<IVariable, Expression>();
            foreach (var (formal, overriddenFormal) in f.Ins.Zip(f.OverriddenFunction.Ins, Tuple.Create))
            {
                // get corresponding formal in the class
                var ie = new IdentifierExpr(formal.tok, formal.AssignUniqueName(f.IdGenerator)) { Var = formal, Type = formal.Type };
                substMap.Add(overriddenFormal, ie);
            }

            if (MutateCSharp.Schemata498.ReplaceBinExprOp_23(327L, f.OverriddenFunction.Result, null))
            {
                Contract.Assert(pOut != null);
                //get corresponding formal in the class
                var ie = new IdentifierExpr(pOut.tok, pOut.AssignUniqueName(f.IdGenerator)) { Var = pOut, Type = pOut.Type };
                substMap.Add(f.OverriddenFunction.Result, ie);
            }

            var typeMap = GetTypeArgumentSubstitutionMap(f.OverriddenFunction, f);

            //adding assume Pre’; assert P; // this checks that Pre’ implies P
            AddFunctionOverrideReqsChk(f, builder, etran, substMap, typeMap);

            //adding assert R <= Rank’;
            AddOverrideTerminationChk(f, f.OverriddenFunction, builder, etran, substMap, typeMap);

            //adding assert W <= Frame’
            AddFunctionOverrideSubsetChk(f, builder, etran, localVariables, substMap, typeMap);

            //adding assume Q; assert Post’;
            AddFunctionOverrideEnsChk(f, builder, etran, substMap, typeMap, implInParams, MutateCSharp.Schemata498.ReplaceBinExprOp_16(332L, implOutParams.Count, MutateCSharp.Schemata498.ReplaceNumericConstant_9(328L, 0)) ? null : implOutParams[MutateCSharp.Schemata498.ReplaceNumericConstant_9(337L, 0)]);

            var stmts = builder.Collect(f.tok);

            if (EmitImplementation(f.Attributes))
            {
                // emit the impl only when there are proof obligations.
                QKeyValue kv = etran.TrAttributes(f.Attributes, null);

                AddImplementationWithAttributes(GetToken(f), proc,
                    Util.Concat(Util.Concat(typeInParams, inParams_Heap), implInParams),
                    implOutParams, localVariables, stmts, kv);
            }

            if (InsertChecksums)
            {
                InsertChecksum(f, proc, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(341L, true));
            }

            Reset();
        }


        private void AddFunctionOverrideEnsChk(Function f, BoogieStmtListBuilder builder, ExpressionTranslator etran,
          Dictionary<IVariable, Expression> substMap,
          Dictionary<TypeParameter, Type> typeMap,
          List<Bpl.Variable> implInParams,
          Bpl.Variable/*?*/ resultVariable)
        {
            Contract.Requires(f.Ins.Count <= implInParams.Count);

            //generating class post-conditions
            foreach (var en in f.Ens)
            {
                builder.Add(TrAssumeCmdWithDependencies(etran, f.tok, en.E, MutateCSharp.Schemata498.ReplaceStringConstant_1(342L, "overridden function ensures clause")));
            }

            //generating assume C.F(ins) == out, if a result variable was given
            if (MutateCSharp.Schemata498.ReplaceBinExprOp_24(343L, resultVariable, null))
            {
                var funcIdC = new FunctionCall(new Bpl.IdentifierExpr(f.tok, f.FullSanitizedName, TrType(f.ResultType)));
                var argsC = new List<Bpl.Expr>();

                // add type arguments
                argsC.AddRange(GetTypeArguments(f, null).ConvertAll(TypeToTy));

                // add fuel arguments
                if (f.IsFuelAware())
                {
                    argsC.Add(etran.layerInterCluster.GetFunctionFuel(f));
                }

                if (MutateCSharp.Schemata498.ReplaceBinExprOp_13(344L, () => f.IsOpaque, () => f.IsMadeImplicitlyOpaque(options)))
                {
                    argsC.Add(GetRevealConstant(f));
                }

                // add heap arguments
                if (f is TwoStateFunction)
                {
                    argsC.Add(etran.Old.HeapExpr);
                }
                if (f.ReadsHeap)
                {
                    argsC.Add(etran.HeapExpr);
                }

                argsC.AddRange(implInParams.Select(var => new Bpl.IdentifierExpr(f.tok, var)));

                var funcExpC = new Bpl.NAryExpr(f.tok, funcIdC, argsC);
                var resultVar = new Bpl.IdentifierExpr(resultVariable.tok, resultVariable);
                builder.Add(TrAssumeCmd(f.tok, Bpl.Expr.Eq(funcExpC, resultVar)));
            }

            //generating trait post-conditions with class variables
            FunctionCallSubstituter sub = null;
            foreach (var en in f.OverriddenFunction.Ens)
            {
                sub ??= new FunctionCallSubstituter(substMap, typeMap, (TraitDecl)f.OverriddenFunction.EnclosingClass, (TopLevelDeclWithMembers)f.EnclosingClass);
                foreach (var s in TrSplitExpr(sub.Substitute(en.E), etran, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(350L, false), out _).Where(s => s.IsChecked))
                {
                    builder.Add(Assert(f.tok, s.E, new PODesc.FunctionContractOverride(MutateCSharp.Schemata498.ReplaceBooleanConstant_0(351L, true))));
                }
            }
        }

        private void AddOverrideCheckTypeArgumentInstantiations(MemberDecl member, BoogieStmtListBuilder builder, List<Variable> localVariables)
        {
            Contract.Requires(member is Function || member is Method);
            Contract.Requires(member.EnclosingClass is TopLevelDeclWithMembers);
            Contract.Requires(builder != null);
            Contract.Requires(localVariables != null);

            MemberDecl overriddenMember;
            List<TypeParameter> overriddenTypeParameters;
            if (member is Function)
            {
                var o = ((Function)member).OverriddenFunction;
                overriddenMember = o;
                overriddenTypeParameters = o.TypeArgs;
            }
            else
            {
                var o = ((Method)member).OverriddenMethod;
                overriddenMember = o;
                overriddenTypeParameters = o.TypeArgs;
            }
            var typeMap = GetTypeArgumentSubstitutionMap(overriddenMember, member);
            foreach (var tp in Util.Concat(overriddenMember.EnclosingClass.TypeArgs, overriddenTypeParameters))
            {
                var local = BplLocalVar(NameTypeParam(tp), predef.Ty, out var lhs);
                localVariables.Add(local);
                var rhs = TypeToTy(typeMap[tp]);
                builder.Add(new Boogie.AssumeCmd(tp.tok, Boogie.Expr.Eq(lhs, rhs)));
            }
        }


        private void AddFunctionOverrideSubsetChk(Function func, BoogieStmtListBuilder builder, ExpressionTranslator etran, List<Variable> localVariables,
          Dictionary<IVariable, Expression> substMap,
          Dictionary<TypeParameter, Type> typeMap)
        {
            //getting framePrime
            List<FrameExpression> traitFrameExps = new List<FrameExpression>();
            FunctionCallSubstituter sub = null;
            foreach (var e in func.OverriddenFunction.Reads.Expressions)
            {
                sub ??= new FunctionCallSubstituter(substMap, typeMap, (TraitDecl)func.OverriddenFunction.EnclosingClass, (TopLevelDeclWithMembers)func.EnclosingClass);
                var newE = sub.Substitute(e.E);
                FrameExpression fe = new FrameExpression(e.tok, newE, e.FieldName);
                traitFrameExps.Add(fe);
            }

            QKeyValue kv = etran.TrAttributes(func.Attributes, null);

            IToken tok = func.tok;
            // Declare a local variable $_ReadsFrame: [ref, Field]bool
            Bpl.IdentifierExpr traitFrame = etran.ReadsFrame(func.OverriddenFunction.tok);  // this is a throw-away expression, used only to extract the type and name of the $_ReadsFrame variable
            traitFrame.Name = func.EnclosingClass.Name + MutateCSharp.Schemata498.ReplaceStringConstant_1(352L, "_") + traitFrame.Name;
            Contract.Assert(traitFrame.Type != null);  // follows from the postcondition of ReadsFrame
            Bpl.LocalVariable frame = new Bpl.LocalVariable(tok, new Bpl.TypedIdent(tok, null ?? traitFrame.Name, traitFrame.Type));
            localVariables.Add(frame);
            // $_ReadsFrame := (lambda $o: ref, $f: Field :: $o != null && $Heap[$o,alloc] ==> ($o,$f) in Modifies/Reads-Clause);
            Bpl.BoundVariable oVar = new Bpl.BoundVariable(tok, new Bpl.TypedIdent(tok, MutateCSharp.Schemata498.ReplaceStringConstant_1(353L, "$o"), predef.RefType));
            Bpl.IdentifierExpr o = new Bpl.IdentifierExpr(tok, oVar);
            Bpl.BoundVariable fVar = new Bpl.BoundVariable(tok, new Bpl.TypedIdent(tok, MutateCSharp.Schemata498.ReplaceStringConstant_1(354L, "$f"), predef.FieldName(tok)));
            Bpl.IdentifierExpr f = new Bpl.IdentifierExpr(tok, fVar);
            Bpl.Expr ante = BplAnd(Bpl.Expr.Neq(o, predef.Null), etran.IsAlloced(tok, o));
            Bpl.Expr consequent = InRWClause(tok, o, f, traitFrameExps, etran, null, null);
            Bpl.Expr lambda = new Bpl.LambdaExpr(tok, new List<TypeVariable>(), new List<Variable> { oVar, fVar }, null,
                                                 BplImp(ante, consequent));

            //to initialize $_ReadsFrame variable to Frame'
            builder.Add(Bpl.Cmd.SimpleAssign(tok, new Bpl.IdentifierExpr(tok, frame), lambda));

            // emit: assert (forall o: ref, f: Field :: o != null && $Heap[o,alloc] && (o,f) in subFrame ==> $_ReadsFrame[o,f]);
            Bpl.Expr oInCallee = InRWClause(tok, o, f, func.Reads.Expressions, etran, null, null);
            Bpl.Expr consequent2 = InRWClause(tok, o, f, traitFrameExps, etran, null, null);
            Bpl.Expr q = new Bpl.ForallExpr(tok, new List<TypeVariable>(), new List<Variable> { oVar, fVar },
                                            BplImp(BplAnd(ante, oInCallee), consequent2));
            builder.Add(Assert(tok, q, new PODesc.TraitFrame(func.WhatKind, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(355L, false)), kv));
        }

        private void AddFunctionOverrideReqsChk(Function f, BoogieStmtListBuilder builder, ExpressionTranslator etran,
          Dictionary<IVariable, Expression> substMap,
          Dictionary<TypeParameter, Type> typeMap)
        {
            Contract.Requires(f != null);
            Contract.Requires(builder != null);
            Contract.Requires(etran != null);
            Contract.Requires(substMap != null);
            //generating trait pre-conditions with class variables
            FunctionCallSubstituter sub = null;
            foreach (var req in f.OverriddenFunction.Req)
            {
                sub ??= new FunctionCallSubstituter(substMap, typeMap, (TraitDecl)f.OverriddenFunction.EnclosingClass, (TopLevelDeclWithMembers)f.EnclosingClass);
                builder.Add(TrAssumeCmdWithDependencies(etran, f.tok, sub.Substitute(req.E), MutateCSharp.Schemata498.ReplaceStringConstant_1(356L, "overridden function requires clause")));
            }
            //generating class pre-conditions
            foreach (var s in f.Req.SelectMany(req => TrSplitExpr(req.E, etran, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(357L, false), out _).Where(s => s.IsChecked)))
            {
                builder.Add(Assert(f.tok, s.E, new PODesc.FunctionContractOverride(MutateCSharp.Schemata498.ReplaceBooleanConstant_0(358L, false))));
            }
        }

        /// <summary>
        /// Essentially, the function override axiom looks like:
        ///   axiom (forall $heap: HeapType, typeArgs: Ty, this: ref, x#0: int, fuel: LayerType ::
        ///     { J.F(fuel, $heap, G(typeArgs), this, x#0), C.F(fuel, $heap, typeArgs, this, x#0) }
        ///     { J.F(fuel, $heap, G(typeArgs), this, x#0), $Is(this, C) }
        ///     C.F#canCall(args) || (fh < FunctionContextHeight && this != null && $Is(this, C))
        ///     ==>
        ///     J.F(fuel, $heap, G(typeArgs), this, x#0) == C.F(fuel, $heap, typeArgs, this, x#0));
        /// (without the other usual antecedents).  Essentially, the override gives a part of the body of the
        /// trait's function, so we call FunctionAxiom to generate a conditional axiom (that is, we pass in the "overridingFunction"
        /// parameter to FunctionAxiom, which will add 'dtype(this) == class.C' as an additional antecedent) for a
        /// body of 'C.F(this, x#0)'.
        /// </summary>
        private Boogie.Axiom FunctionOverrideAxiom(Function f, Function overridingFunction)
        {
            Contract.Requires(f != null);
            Contract.Requires(overridingFunction != null);
            Contract.Requires(predef != null);
            Contract.Requires(f.EnclosingClass != null);
            Contract.Requires(!f.IsStatic);
            Contract.Requires(overridingFunction.EnclosingClass is TopLevelDeclWithMembers);
            Contract.Ensures(Contract.Result<Boogie.Axiom>() != null);

            bool readsHeap = MutateCSharp.Schemata498.ReplaceBinExprOp_13(359L, () => f.ReadsHeap, () => overridingFunction.ReadsHeap);

            ExpressionTranslator etran;
            Boogie.BoundVariable bvPrevHeap = null;
            if (f is TwoStateFunction)
            {
                bvPrevHeap = new Boogie.BoundVariable(f.tok, new Boogie.TypedIdent(f.tok, MutateCSharp.Schemata498.ReplaceStringConstant_1(365L, "$prevHeap"), predef.HeapType));
                etran = new ExpressionTranslator(this, predef,
                  f.ReadsHeap ? new Boogie.IdentifierExpr(f.tok, predef.HeapVarName, predef.HeapType) : null,
                  new Boogie.IdentifierExpr(f.tok, bvPrevHeap),
                  f);
            }
            else if (readsHeap)
            {
                etran = new ExpressionTranslator(this, predef, f.tok, f);
            }
            else
            {
                etran = new ExpressionTranslator(this, predef, (Boogie.Expr)null, f);
            }

            // "forallFormals" is built to hold the bound variables of the quantification
            // argsJF are the arguments to J.F (the function in the trait)
            // argsCF are the arguments to C.F (the overriding function)
            var forallFormals = new List<Boogie.Variable>();
            var argsJF = new List<Boogie.Expr>();
            var argsCF = new List<Boogie.Expr>();

            // Add type arguments
            forallFormals.AddRange(MkTyParamBinders(GetTypeParams(overridingFunction), out _));
            argsJF.AddRange(GetTypeArguments(f, overridingFunction).ConvertAll(TypeToTy));
            argsCF.AddRange(GetTypeArguments(overridingFunction, null).ConvertAll(TypeToTy));

            var moreArgsCF = new List<Boogie.Expr>();
            Expr layer = null;
            Expr reveal = null;

            // Add the fuel argument
            if (f.IsFuelAware())
            {
                Contract.Assert(overridingFunction.IsFuelAware());  // f.IsFuelAware() ==> overridingFunction.IsFuelAware()
                var fuel = new Boogie.BoundVariable(f.tok, new Boogie.TypedIdent(f.tok, MutateCSharp.Schemata498.ReplaceStringConstant_1(366L, "$fuel"), predef.LayerType));
                forallFormals.Add(fuel);
                layer = new Boogie.IdentifierExpr(f.tok, fuel);
                argsJF.Add(layer);
            }
            else if (overridingFunction.IsFuelAware())
            {
                // We can't use a bound variable $fuel, because then one of the triggers won't be mentioning this $fuel.
                // Instead, we do the next best thing: use the literal $LZ.
                layer = new Boogie.IdentifierExpr(f.tok, MutateCSharp.Schemata498.ReplaceStringConstant_1(367L, "$LZ"), predef.LayerType); // $LZ
            }

            if (MutateCSharp.Schemata498.ReplaceBinExprOp_13(368L, () => f.IsOpaque, () => f.IsMadeImplicitlyOpaque(options)))
            {
                Contract.Assert(overridingFunction.IsOpaque || options.Get(CommonOptionBag.DefaultFunctionOpacity) == CommonOptionBag.DefaultFunctionOpacityOptions.Opaque || options.Get(CommonOptionBag.DefaultFunctionOpacity) == CommonOptionBag.DefaultFunctionOpacityOptions.AutoRevealDependencies);
                var revealVar = new Boogie.BoundVariable(f.tok, new Boogie.TypedIdent(f.tok, MutateCSharp.Schemata498.ReplaceStringConstant_1(374L, "reveal"), Boogie.Type.Bool));
                forallFormals.Add(revealVar);
                reveal = new Boogie.IdentifierExpr(f.tok, revealVar);
                argsJF.Add(reveal);
            }
            else if (MutateCSharp.Schemata498.ReplaceBinExprOp_13(375L, () => overridingFunction.IsOpaque, () => overridingFunction.IsMadeImplicitlyOpaque(options)))
            {
                reveal = GetRevealConstant(overridingFunction);
            }

            // Add heap arguments
            if (f is TwoStateFunction)
            {
                Contract.Assert(bvPrevHeap != null);
                forallFormals.Add(bvPrevHeap);
                argsJF.Add(etran.Old.HeapExpr);
                moreArgsCF.Add(etran.Old.HeapExpr);
            }
            if (MutateCSharp.Schemata498.ReplaceBinExprOp_13(381L, () => f.ReadsHeap, () => overridingFunction.ReadsHeap))
            {
                var heap = new Boogie.BoundVariable(f.tok, new Boogie.TypedIdent(f.tok, predef.HeapVarName, predef.HeapType));
                forallFormals.Add(heap);
                if (f.ReadsHeap)
                {
                    argsJF.Add(new Boogie.IdentifierExpr(f.tok, heap));
                }
                if (overridingFunction.ReadsHeap)
                {
                    moreArgsCF.Add(new Boogie.IdentifierExpr(overridingFunction.tok, heap));
                }
            }

            // Add receiver parameter
            Type thisType = ModuleResolver.GetReceiverType(f.tok, overridingFunction);
            var bvThis = new Boogie.BoundVariable(f.tok, new Boogie.TypedIdent(f.tok, etran.This, TrType(thisType)));
            forallFormals.Add(bvThis);
            var bvThisExpr = new Boogie.IdentifierExpr(f.tok, bvThis);
            argsJF.Add(BoxifyForTraitParent(f.tok, bvThisExpr, f, thisType));
            moreArgsCF.Add(bvThisExpr);
            // $Is(this, C)
            var isOfSubtype = GetWhereClause(overridingFunction.tok, bvThisExpr, thisType, f is TwoStateFunction ? etran.Old : etran,
              IsAllocType.NEVERALLOC, alwaysUseSymbolicName: MutateCSharp.Schemata498.ReplaceBooleanConstant_0(387L, true));

            Bpl.Expr ante = BplAnd(ReceiverNotNull(bvThisExpr), isOfSubtype);

            // Add other arguments
            var typeMap = GetTypeArgumentSubstitutionMap(f, overridingFunction);
            foreach (Formal p in f.Ins)
            {
                var pType = p.Type.Subst(typeMap);
                var bv = new Boogie.BoundVariable(p.tok, new Boogie.TypedIdent(p.tok, p.AssignUniqueName(currentDeclaration.IdGenerator), TrType(pType)));
                forallFormals.Add(bv);
                var jfArg = new Boogie.IdentifierExpr(p.tok, bv);
                argsJF.Add(ModeledAsBoxType(p.Type) ? BoxIfNotNormallyBoxed(p.tok, jfArg, pType) : jfArg);
                moreArgsCF.Add(new Boogie.IdentifierExpr(p.tok, bv));
            }

            // useViaContext: fh < FunctionContextHeight
            Boogie.Expr useViaContext = !InVerificationScope(overridingFunction)
              ? Boogie.Expr.True
              : Boogie.Expr.Lt(Boogie.Expr.Literal(forModule.CallGraph.GetSCCRepresentativePredecessorCount(overridingFunction)), etran.FunctionContextHeight());

            // useViaCanCall: C.F#canCall(args)
            Bpl.IdentifierExpr canCallFuncID = new Bpl.IdentifierExpr(overridingFunction.tok, overridingFunction.FullSanitizedName + MutateCSharp.Schemata498.ReplaceStringConstant_1(388L, "#canCall"), Bpl.Type.Bool);
            Bpl.Expr useViaCanCall = new Bpl.NAryExpr(f.tok, new Bpl.FunctionCall(canCallFuncID), Concat(argsCF, moreArgsCF));

            if (MutateCSharp.Schemata498.ReplaceBinExprOp_15(389L, layer, null))
            {
                argsCF.Add(layer);
            }

            if (MutateCSharp.Schemata498.ReplaceBinExprOp_15(390L, reveal, null))
            {
                argsCF.Add(reveal);
            }

            argsCF = Concat(argsCF, moreArgsCF);

            // ante := useViaCanCall || (useViaContext && this != null && $Is(this, C))
            ante = BplOr(useViaCanCall, BplAnd(useViaContext, ante));

            Boogie.Expr funcAppl;
            {
                var funcID = new Boogie.IdentifierExpr(f.tok, f.FullSanitizedName, TrType(f.ResultType));
                funcAppl = new Boogie.NAryExpr(f.tok, new Boogie.FunctionCall(funcID), argsJF);
            }
            Boogie.Expr overridingFuncAppl;
            {
                var funcID = new Boogie.IdentifierExpr(overridingFunction.tok, overridingFunction.FullSanitizedName, TrType(overridingFunction.ResultType));
                overridingFuncAppl = new Boogie.NAryExpr(overridingFunction.tok, new Boogie.FunctionCall(funcID), argsCF);
            }

            // Build the triggers
            // { f(Succ(s), args), f'(Succ(s), args') }
            Boogie.Trigger tr = BplTriggerHeap(this, overridingFunction.tok,
              funcAppl,
              readsHeap ? etran.HeapExpr : null,
              overridingFuncAppl);
            // { f(Succ(s), args), $Is(this, T') }
            var exprs = new List<Boogie.Expr>() { funcAppl, isOfSubtype };
            if (readsHeap)
            {
                exprs.Add(FunctionCall(overridingFunction.tok, BuiltinFunction.IsGoodHeap, null, etran.HeapExpr));
            }
            tr = new Boogie.Trigger(overridingFunction.tok, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(391L, true), exprs, tr);

            // The equality that is what it's all about
            var synonyms = Boogie.Expr.Eq(
              funcAppl,
              ModeledAsBoxType(f.ResultType) ? BoxIfNotNormallyBoxed(overridingFunction.tok, overridingFuncAppl, overridingFunction.ResultType) : overridingFuncAppl);

            // The axiom
            Boogie.Expr ax = BplForall(f.tok, new List<Boogie.TypeVariable>(), forallFormals, null, tr,
              BplImp(ante, synonyms));
            var activate = AxiomActivation(overridingFunction, etran);
            string comment = MutateCSharp.Schemata498.ReplaceStringConstant_1(392L, "override axiom for ") + f.FullSanitizedName + MutateCSharp.Schemata498.ReplaceStringConstant_1(393L, " in class ") + overridingFunction.EnclosingClass.FullSanitizedName;
            return new Boogie.Axiom(f.tok, BplImp(activate, ax), comment);
        }

        /// <summary>
        /// Return a type-parameter substitution map for function "f", as instantiated by the context of "overridingFunction".
        ///
        /// In more symbols, suppose "f" is declared as follows:
        ///     class/trait Tr[A,B] {
        ///       function f[C,D](...): ...
        ///     }
        /// and "overridingFunction" is declared as follows:
        ///     class/trait Cl[G] extends Tr[X(G),Y(G)] {
        ///       function f[R,S](...): ...
        ///     }
        /// Then, return the following map:
        ///     A -> X(G)
        ///     B -> Y(G)
        ///     C -> R
        ///     D -> S
        ///
        /// See also GetTypeArguments.
        /// </summary>
        private static Dictionary<TypeParameter, Type> GetTypeArgumentSubstitutionMap(MemberDecl member, MemberDecl overridingMember)
        {
            Contract.Requires(member is Function || member is Method);
            Contract.Requires(overridingMember is Function || overridingMember is Method);
            Contract.Requires(overridingMember.EnclosingClass is TopLevelDeclWithMembers);
            Contract.Requires(((ICallable)member).TypeArgs.Count == ((ICallable)overridingMember).TypeArgs.Count);

            var typeMap = new Dictionary<TypeParameter, Type>();

            var cl = (TopLevelDeclWithMembers)overridingMember.EnclosingClass;
            var classTypeMap = cl.ParentFormalTypeParametersToActuals;
            member.EnclosingClass.TypeArgs.ForEach(tp => typeMap.Add(tp, classTypeMap[tp]));

            var origTypeArgs = ((ICallable)member).TypeArgs;
            var overridingTypeArgs = ((ICallable)overridingMember).TypeArgs;
            for (var i = MutateCSharp.Schemata498.ReplaceNumericConstant_9(394L, 0); MutateCSharp.Schemata498.ReplaceBinExprOp_10(398L, i, origTypeArgs.Count); MutateCSharp.Schemata498.ReplacePostfixUnaryExprOp_11(403L, ref i))
            {
                var otp = overridingTypeArgs[i];
                typeMap.Add(origTypeArgs[i], new UserDefinedType(otp.tok, otp));
            }

            return typeMap;
        }

        private void AddMethodOverrideEnsChk(Method m, BoogieStmtListBuilder builder, ExpressionTranslator etran,
          Dictionary<IVariable, Expression> substMap,
          Dictionary<TypeParameter, Type> typeMap)
        {
            Contract.Requires(m != null);
            Contract.Requires(builder != null);
            Contract.Requires(etran != null);
            Contract.Requires(substMap != null);
            //generating class post-conditions
            foreach (var en in m.Ens)
            {
                builder.Add(TrAssumeCmdWithDependencies(etran, m.tok, en.E, MutateCSharp.Schemata498.ReplaceStringConstant_1(404L, "overridden ensures clause")));
            }
            //generating trait post-conditions with class variables
            FunctionCallSubstituter sub = null;
            foreach (var en in m.OverriddenMethod.Ens)
            {
                sub ??= new FunctionCallSubstituter(substMap, typeMap, (TraitDecl)m.OverriddenMethod.EnclosingClass, (TopLevelDeclWithMembers)m.EnclosingClass);
                foreach (var s in TrSplitExpr(sub.Substitute(en.E), etran, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(405L, false), out _).Where(s => s.IsChecked))
                {
                    builder.Add(Assert(m.RangeToken, s.E, new PODesc.EnsuresStronger()));
                }
            }
        }

        private void AddMethodOverrideReqsChk(Method m, BoogieStmtListBuilder builder, ExpressionTranslator etran,
          Dictionary<IVariable, Expression> substMap,
          Dictionary<TypeParameter, Type> typeMap)
        {
            Contract.Requires(m != null);
            Contract.Requires(builder != null);
            Contract.Requires(etran != null);
            Contract.Requires(substMap != null);
            //generating trait pre-conditions with class variables
            FunctionCallSubstituter sub = null;
            foreach (var req in m.OverriddenMethod.Req)
            {
                sub ??= new FunctionCallSubstituter(substMap, typeMap, (TraitDecl)m.OverriddenMethod.EnclosingClass, (TopLevelDeclWithMembers)m.EnclosingClass);
                builder.Add(TrAssumeCmdWithDependencies(etran, m.tok, sub.Substitute(req.E), MutateCSharp.Schemata498.ReplaceStringConstant_1(406L, "overridden requires clause")));
            }
            //generating class pre-conditions
            foreach (var s in m.Req.SelectMany(req => TrSplitExpr(req.E, etran, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(407L, false), out _).Where(s => s.IsChecked)))
            {
                builder.Add(Assert(m.RangeToken, s.E, new PODesc.RequiresWeaker()));
            }
        }

        private void AddOverrideTerminationChk(ICallable original, ICallable overryd, BoogieStmtListBuilder builder, ExpressionTranslator etran,
          Dictionary<IVariable, Expression> substMap,
          Dictionary<TypeParameter, Type> typeMap)
        {
            Contract.Requires(original != null);
            Contract.Requires(overryd != null);
            Contract.Requires(builder != null);
            Contract.Requires(etran != null);
            Contract.Requires(substMap != null);
            // Note, it is as if the trait's method is calling the class's method.
            var contextDecreases = overryd.Decreases.Expressions;
            var calleeDecreases = original.Decreases.Expressions;
            var T = (TraitDecl)((MemberDecl)overryd).EnclosingClass;
            var I = (TopLevelDeclWithMembers)((MemberDecl)original).EnclosingClass;

            // We want to check:  calleeDecreases <= contextDecreases (note, we can allow equality, since there is a bounded, namely 1, number of dynamic dispatches)
            if (Contract.Exists(contextDecreases, e => e is WildcardExpr))
            {
                // no check needed
                return;
            }

            int N = Math.Min(contextDecreases.Count, calleeDecreases.Count);
            var toks = new List<IToken>();
            var types0 = new List<Type>();
            var types1 = new List<Type>();
            var callee = new List<Expr>();
            var caller = new List<Expr>();
            FunctionCallSubstituter sub = null;

            for (int i = MutateCSharp.Schemata498.ReplaceNumericConstant_9(408L, 0); MutateCSharp.Schemata498.ReplaceBinExprOp_10(412L, i, N); MutateCSharp.Schemata498.ReplacePostfixUnaryExprOp_11(417L, ref i))
            {
                Expression e0 = calleeDecreases[i];
                sub ??= new FunctionCallSubstituter(substMap, typeMap, T, I);
                Expression e1 = sub.Substitute(contextDecreases[i]);
                if (!CompatibleDecreasesTypes(e0.Type, e1.Type))
                {
                    N = i;
                    break;
                }
                toks.Add(new NestedToken(original.RangeToken.StartToken, e1.tok));
                types0.Add(e0.Type.NormalizeExpand());
                types1.Add(e1.Type.NormalizeExpand());
                callee.Add(etran.TrExpr(e0));
                caller.Add(etran.TrExpr(e1));
                var canCall = etran.CanCallAssumption(e1);
                if (MutateCSharp.Schemata498.ReplaceBinExprOp_25(418L, canCall, Bpl.Expr.True))
                {
                    builder.Add(new Bpl.AssumeCmd(e1.tok, canCall));
                }
            }

            var decrCountT = contextDecreases.Count;
            var decrCountC = calleeDecreases.Count;
            // Generally, we want to produce a check "decrClass <= decrTrait", allowing (the common case where) they are equal.
            // * If N < decrCountC && N < decrCountT, then "decrClass <= decrTrait" if the comparison ever gets beyond the
            //   parts that survived truncation.  Thus, we compare with "allowNoChange" set to "false".
            // Otherwise:
            // * If decrCountC == decrCountT, then the truncation we did above had no effect and we pass in "allowNoChange" as "true".
            // * If decrCountC > decrCountT, then we will have truncated decrClass above.  Let x,y and x' denote decrClass and
            //   decrTrait, respectively, where x and x' have the same length.  Considering how Dafny in effect pads the end of
            //   decreases tuples with a \top, we were supposed to evaluate (x,(y,\top)) <= (x',\top), which by lexicographic pairs
            //   we can expand to:
            //       x <= x' && (x == x' ==> (y,\top) <= \top)
            //   which is equivalent to just x <= x'.  Thus, we called DecreasesCheck to compare x and x' and we pass in "allowNoChange"
            //   as "true".
            // * If decrCountC < decrCountT, then we will have truncated decrTrait above.  Let x and x',y' denote decrClass and
            //   decrTrait, respectively, where x and x' have the same length.  We then want to check (x,\top) <= (x',(y',\top)), which
            //   expands to:
            //       x <= x' && (x == x' ==> \top <= (y',\top))
            //    =      { \top is strictly larger than a pair }
            //       x <= x' && (x == x' ==> false)
            //    =
            //       x < x'
            //   So we perform our desired check by calling DecreasesCheck to strictly compare x and x', so we pass in "allowNoChange"
            //   as "false".
            bool allowNoChange = MutateCSharp.Schemata498.ReplaceBinExprOp_6(429L, () => MutateCSharp.Schemata498.ReplaceBinExprOp_16(419L, N, decrCountT), () => MutateCSharp.Schemata498.ReplaceBinExprOp_26(424L, decrCountT, decrCountC));
            var decrChk = DecreasesCheck(toks, types0, types1, callee, caller, null, null, allowNoChange, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(435L, false));
            builder.Add(Assert(original.RangeToken, decrChk, new PODesc.TraitDecreases(original.WhatKind)));
        }

        private void AddMethodOverrideFrameSubsetChk(Method m, bool isModifies, BoogieStmtListBuilder builder, ExpressionTranslator etran, List<Variable> localVariables,
          Dictionary<IVariable, Expression> substMap,
          Dictionary<TypeParameter, Type> typeMap)
        {

            List<FrameExpression> classFrameExps;
            List<FrameExpression> originalTraitFrameExps;
            if (isModifies)
            {
                classFrameExps = MutateCSharp.Schemata498.ReplaceBinExprOp_27(436L, m.Mod, null) ? m.Mod.Expressions : new List<FrameExpression>();
                originalTraitFrameExps = m.OverriddenMethod.Mod?.Expressions;
            }
            else
            {
                classFrameExps = MutateCSharp.Schemata498.ReplaceBinExprOp_27(437L, m.Reads, null) ? m.Reads.Expressions : new List<FrameExpression>();
                originalTraitFrameExps = m.OverriddenMethod.Reads?.Expressions;
            }

            var traitFrameExps = new List<FrameExpression>();
            if (MutateCSharp.Schemata498.ReplaceBinExprOp_28(438L, originalTraitFrameExps, null))
            {
                // Not currently possible for modifies, but is supported for reads
                if (originalTraitFrameExps.Any(e => e.E is WildcardExpr))
                {
                    // Trivially true
                    return;
                }
                foreach (var e in originalTraitFrameExps)
                {
                    var newE = Substitute(e.E, null, substMap, typeMap);
                    var fe = new FrameExpression(e.tok, newE, e.FieldName);
                    traitFrameExps.Add(fe);
                }
            }

            var kv = etran.TrAttributes(m.Attributes, null);

            var tok = m.tok;
            var oVar = new Boogie.BoundVariable(tok, new Boogie.TypedIdent(tok, MutateCSharp.Schemata498.ReplaceStringConstant_1(439L, "$o"), predef.RefType));
            var o = new Boogie.IdentifierExpr(tok, oVar);
            var fVar = new Boogie.BoundVariable(tok, new Boogie.TypedIdent(tok, MutateCSharp.Schemata498.ReplaceStringConstant_1(440L, "$f"), predef.FieldName(tok)));
            var f = new Boogie.IdentifierExpr(tok, fVar);
            var ante = BplAnd(Boogie.Expr.Neq(o, predef.Null), etran.IsAlloced(tok, o));

            // emit: assert (forall o: ref, f: Field :: o != null && $Heap[o,alloc] && (o,f) in subFrame ==> $_Frame[o,f]);
            var oInCallee = InRWClause(tok, o, f, classFrameExps, etran, null, null);
            var consequent2 = InRWClause(tok, o, f, traitFrameExps, etran, null, null);
            var q = new Boogie.ForallExpr(tok, new List<TypeVariable>(), new List<Variable> { oVar, fVar },
              BplImp(BplAnd(ante, oInCallee), consequent2));
            builder.Add(Assert(m.RangeToken, q, new PODesc.TraitFrame(m.WhatKind, isModifies), kv));
        }

        // Return a way to know if an assertion should be converted to an assumption
        private void SetAssertionOnlyFilter(Node m)
        {
            List<RangeToken> rangesOnly = new List<RangeToken>();
            m.Visit(node =>
            {
                if (node is AssertStmt assertStmt &&
                    assertStmt.HasAssertOnlyAttribute(out var assertOnlyKind))
                {
                    var ifAfterLastToken = m.EndToken;
                    if (rangesOnly.FindIndex(r => r.Contains(node.StartToken.pos)) is var x && MutateCSharp.Schemata498.ReplaceBinExprOp_29(445L, x, MutateCSharp.Schemata498.ReplaceNumericConstant_9(441L, 0)))
                    {
                        if (MutateCSharp.Schemata498.ReplaceBinExprOp_30(450L, assertOnlyKind, AssertStmt.AssertOnlyKind.Before))
                        {// Just shorten the previous range
                            rangesOnly[x] = new RangeToken(rangesOnly[x].StartToken, node.EndToken);
                            return MutateCSharp.Schemata498.ReplaceBooleanConstant_0(451L, true);
                        }

                        ifAfterLastToken = rangesOnly[x].EndToken;
                        rangesOnly.RemoveAt(x);
                    }

                    var rangeToAdd = MutateCSharp.Schemata498.ReplaceBinExprOp_30(452L, assertOnlyKind, AssertStmt.AssertOnlyKind.Before) ?
                        new RangeToken(m.StartToken, assertStmt.EndToken) : MutateCSharp.Schemata498.ReplaceBinExprOp_30(453L, assertOnlyKind, AssertStmt.AssertOnlyKind.After) ?
                        new RangeToken(assertStmt.StartToken, ifAfterLastToken)
                        : assertStmt.RangeToken;
                    if (MutateCSharp.Schemata498.ReplaceBinExprOp_6(455L, () => MutateCSharp.Schemata498.ReplaceBinExprOp_30(454L, assertOnlyKind, AssertStmt.AssertOnlyKind.Before), () => rangesOnly.Any(other => rangeToAdd.Intersects(other))))
                    {
                        // There are more precise ranges so we don't add this one
                        return MutateCSharp.Schemata498.ReplaceBooleanConstant_0(461L, true);
                    }
                    rangesOnly.Add(rangeToAdd);
                }
                return MutateCSharp.Schemata498.ReplaceBooleanConstant_0(462L, true);
            });
            if (rangesOnly.Any())
            {
                // TODO: What to do with refined postconditions?
                assertionOnlyFilter = token => rangesOnly.Any(range => range.Contains((token.pos)));
            }
        }

        private void ResetAssertionOnlyFilter()
        {
            assertionOnlyFilter = null;
        }

        /// <summary>
        /// This method is expected to be called at most once for each parameter combination, and in particular
        /// at most once for each value of "kind".
        /// </summary>
        private Boogie.Procedure AddMethod(Method m, MethodTranslationKind kind)
        {
            Contract.Requires(m != null);
            Contract.Requires(m.EnclosingClass != null);
            Contract.Requires(predef != null);
            Contract.Requires(currentModule == null && codeContext == null && isAllocContext == null);
            Contract.Ensures(currentModule == null && codeContext == null && isAllocContext == null);
            Contract.Ensures(Contract.Result<Boogie.Procedure>() != null);
            Contract.Assert(VisibleInScope(m));

            proofDependencies.SetCurrentDefinition(MethodVerboseName(m.FullDafnyName, kind));
            currentModule = m.EnclosingClass.EnclosingModuleDefinition;
            codeContext = m;
            isAllocContext = new IsAllocContext(options, m.IsGhost);
            Boogie.Expr prevHeap = null;
            Boogie.Expr currHeap = null;
            var ordinaryEtran = new ExpressionTranslator(this, predef, m.tok, m);
            ExpressionTranslator etran;
            var inParams = new List<Boogie.Variable>();
            if (m is TwoStateLemma)
            {
                var prevHeapVar = new Boogie.Formal(m.tok, new Boogie.TypedIdent(m.tok, MutateCSharp.Schemata498.ReplaceStringConstant_1(463L, "previous$Heap"), predef.HeapType), MutateCSharp.Schemata498.ReplaceBooleanConstant_0(464L, true));
                var currHeapVar = new Boogie.Formal(m.tok, new Boogie.TypedIdent(m.tok, MutateCSharp.Schemata498.ReplaceStringConstant_1(465L, "current$Heap"), predef.HeapType), MutateCSharp.Schemata498.ReplaceBooleanConstant_0(466L, true));
                inParams.Add(prevHeapVar);
                inParams.Add(currHeapVar);
                prevHeap = new Boogie.IdentifierExpr(m.tok, prevHeapVar);
                currHeap = new Boogie.IdentifierExpr(m.tok, currHeapVar);
                etran = new ExpressionTranslator(this, predef, currHeap, prevHeap, m);
            }
            else
            {
                etran = ordinaryEtran;
            }

            GenerateMethodParameters(m.tok, m, kind, etran, inParams, out var outParams);

            var req = new List<Boogie.Requires>();
            var mod = new List<Boogie.IdentifierExpr>();
            var ens = new List<Boogie.Ensures>();
            // FREE PRECONDITIONS
            if (MutateCSharp.Schemata498.ReplaceBinExprOp_13(476L, () => MutateCSharp.Schemata498.ReplaceBinExprOp_13(469L, () => MutateCSharp.Schemata498.ReplaceBinExprOp_31(467L, kind, MethodTranslationKind.SpecWellformedness), () => MutateCSharp.Schemata498.ReplaceBinExprOp_31(468L, kind, MethodTranslationKind.Implementation)), () => MutateCSharp.Schemata498.ReplaceBinExprOp_31(475L, kind, MethodTranslationKind.OverrideCheck)))
            {  // the other cases have no need for a free precondition
               // free requires mh == ModuleContextHeight && fh == FunctionContextHeight;
                req.Add(Requires(m.tok, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(482L, true), etran.HeightContext(m), null, null, null));
                if (m is TwoStateLemma)
                {
                    // free requires prevHeap == Heap && HeapSucc(prevHeap, currHeap) && IsHeap(currHeap)
                    var a0 = Boogie.Expr.Eq(prevHeap, ordinaryEtran.HeapExpr);
                    var a1 = HeapSucc(prevHeap, currHeap);
                    var a2 = FunctionCall(m.tok, BuiltinFunction.IsGoodHeap, null, currHeap);
                    req.Add(Requires(m.tok, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(483L, true), BplAnd(a0, BplAnd(a1, a2)), null, null, null));
                }
            }
            if (m is TwoStateLemma)
            {
                // Checked preconditions that old parameters really existed in previous state
                var index = MutateCSharp.Schemata498.ReplaceNumericConstant_9(484L, 0);
                foreach (var formal in m.Ins)
                {
                    if (formal.IsOld)
                    {
                        var dafnyFormalIdExpr = new IdentifierExpr(formal.tok, formal);
                        var pIdx = MutateCSharp.Schemata498.ReplaceBinExprOp_16(492L, m.Ins.Count, MutateCSharp.Schemata498.ReplaceNumericConstant_9(488L, 1)) ? "" : MutateCSharp.Schemata498.ReplaceStringConstant_1(497L, " at index ") + index;
                        var desc = new PODesc.IsAllocated($"argument{pIdx} for parameter '{formal.Name}'",
            MutateCSharp.Schemata498.ReplaceStringConstant_1(498L, "in the two-state lemma's previous state") + PODesc.IsAllocated.HelperFormal(formal),
                          dafnyFormalIdExpr
                        );
                        var require = Requires(formal.tok, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(499L, false), MkIsAlloc(etran.TrExpr(dafnyFormalIdExpr), formal.Type, prevHeap),
                          desc.FailureDescription, desc.SuccessDescription, null);
                        require.Description = desc;
                        req.Add(require);
                    }

                    MutateCSharp.Schemata498.ReplacePostfixUnaryExprOp_11(500L, ref index);
                }
            }
            mod.Add(ordinaryEtran.HeapCastToIdentifierExpr);

            var bodyKind = MutateCSharp.Schemata498.ReplaceBinExprOp_13(503L, () => MutateCSharp.Schemata498.ReplaceBinExprOp_31(501L, kind, MethodTranslationKind.SpecWellformedness), () => MutateCSharp.Schemata498.ReplaceBinExprOp_31(502L, kind, MethodTranslationKind.Implementation));

            if (MutateCSharp.Schemata498.ReplaceBinExprOp_6(511L, () => MutateCSharp.Schemata498.ReplaceBinExprOp_32(509L, kind, MethodTranslationKind.SpecWellformedness), () => MutateCSharp.Schemata498.ReplaceBinExprOp_32(510L, kind, MethodTranslationKind.OverrideCheck)))
            {
                // USER-DEFINED SPECIFICATIONS
                var comment = MutateCSharp.Schemata498.ReplaceStringConstant_1(517L, "user-defined preconditions");
                foreach (var p in m.Req)
                {
                    var (errorMessage, successMessage) = CustomErrorMessage(p.Attributes);
                    if (MutateCSharp.Schemata498.ReplaceBinExprOp_6(520L, () => MutateCSharp.Schemata498.ReplaceBinExprOp_33(518L, p.Label, null), () => MutateCSharp.Schemata498.ReplaceBinExprOp_31(519L, kind, MethodTranslationKind.Implementation)))
                    {
                        // don't include this precondition here, but record it for later use
                        p.Label.E = (m is TwoStateLemma ? ordinaryEtran : etran.Old).TrExpr(p.E);
                    }
                    else
                    {
                        foreach (var s in TrSplitExprForMethodSpec(p.E, etran, kind))
                        {
                            if (MutateCSharp.Schemata498.ReplaceBinExprOp_6(526L, () => s.IsOnlyChecked, () => bodyKind))
                            {
                                // don't include in split
                            }
                            else if (MutateCSharp.Schemata498.ReplaceBinExprOp_6(532L, () => s.IsOnlyFree, () => !bodyKind))
                            {
                                // don't include in split -- it would be ignored, anyhow
                            }
                            else
                            {
                                req.Add(RequiresWithDependencies(s.Tok, s.IsOnlyFree, p.E, s.E, errorMessage, successMessage, comment));
                                comment = null;
                                // the free here is not linked to the free on the original expression (this is free things generated in the splitting.)
                            }
                        }
                    }
                }
                comment = MutateCSharp.Schemata498.ReplaceStringConstant_1(538L, "user-defined postconditions");
                foreach (var p in m.Ens)
                {
                    var (errorMessage, successMessage) = CustomErrorMessage(p.Attributes);
                    AddEnsures(ens, Ensures(p.E.tok, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(539L, true), etran.CanCallAssumption(p.E), errorMessage, successMessage, comment));
                    comment = null;
                    foreach (var s in TrSplitExprForMethodSpec(p.E, etran, kind))
                    {
                        var post = s.E;
                        if (MutateCSharp.Schemata498.ReplaceBinExprOp_6(541L, () => MutateCSharp.Schemata498.ReplaceBinExprOp_31(540L, kind, MethodTranslationKind.Implementation), () => RefinementToken.IsInherited(s.Tok, currentModule)))
                        {
                            // this postcondition was inherited into this module, so make it into the form "$_reverifyPost ==> s.E"
                            post = BplImp(new Boogie.IdentifierExpr(s.E.tok, MutateCSharp.Schemata498.ReplaceStringConstant_1(547L, "$_reverifyPost"), Boogie.Type.Bool), post);
                        }
                        if (MutateCSharp.Schemata498.ReplaceBinExprOp_6(548L, () => s.IsOnlyFree, () => bodyKind))
                        {
                            // don't include in split -- it would be ignored, anyhow
                        }
                        else if (MutateCSharp.Schemata498.ReplaceBinExprOp_6(554L, () => s.IsOnlyChecked, () => !bodyKind))
                        {
                            // don't include in split
                        }
                        else
                        {
                            AddEnsures(ens, EnsuresWithDependencies(s.Tok, MutateCSharp.Schemata498.ReplaceBinExprOp_13(561L, () => s.IsOnlyFree, () => MutateCSharp.Schemata498.ReplaceBinExprOp_34(560L, this.assertionOnlyFilter, null)), p.E, post, errorMessage, successMessage, null));
                        }
                    }
                }
                if (MutateCSharp.Schemata498.ReplaceBinExprOp_6(568L, () => m is Constructor, () => MutateCSharp.Schemata498.ReplaceBinExprOp_31(567L, kind, MethodTranslationKind.Call)))
                {
                    var fresh = Boogie.Expr.Not(etran.Old.IsAlloced(m.tok, new Boogie.IdentifierExpr(m.tok, MutateCSharp.Schemata498.ReplaceStringConstant_1(574L, "this"), TrReceiverType(m))));
                    AddEnsures(ens, Ensures(m.tok, MutateCSharp.Schemata498.ReplaceBinExprOp_13(577L, () => MutateCSharp.Schemata498.ReplaceBooleanConstant_0(575L, false), () => MutateCSharp.Schemata498.ReplaceBinExprOp_34(576L, this.assertionOnlyFilter, null)), fresh, null, null, MutateCSharp.Schemata498.ReplaceStringConstant_1(583L, "constructor allocates the object")));
                }
                foreach (BoilerplateTriple tri in GetTwoStateBoilerplate(m.tok, m.Mod.Expressions, m.IsGhost, m.AllowsAllocation, ordinaryEtran.Old, ordinaryEtran, ordinaryEtran.Old))
                {
                    AddEnsures(ens, Ensures(tri.tok, MutateCSharp.Schemata498.ReplaceBinExprOp_13(585L, () => tri.IsFree, () => MutateCSharp.Schemata498.ReplaceBinExprOp_34(584L, this.assertionOnlyFilter, null)), tri.Expr, tri.ErrorMessage, tri.SuccessMessage, tri.Comment));
                }

                // add the fuel assumption for the reveal method of a opaque method
                if (IsOpaqueRevealLemma(m))
                {
                    List<Expression> args = Attributes.FindExpressions(m.Attributes, MutateCSharp.Schemata498.ReplaceStringConstant_1(591L, "revealedFunction"));
                    if (MutateCSharp.Schemata498.ReplaceBinExprOp_35(592L, args, null))
                    {
                        MemberSelectExpr selectExpr = args[MutateCSharp.Schemata498.ReplaceNumericConstant_9(593L, 0)].Resolved as MemberSelectExpr;
                        if (MutateCSharp.Schemata498.ReplaceBinExprOp_36(597L, selectExpr, null))
                        {
                            Function f = selectExpr.Member as Function;
                            AddEnsures(ens, Ensures(m.tok, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(598L, true), GetRevealConstant(f), null, null, null));
                        }
                    }
                }
            }

            var name = MethodName(m, kind);
            var proc = new Boogie.Procedure(m.tok, name, new List<Boogie.TypeVariable>(), inParams, outParams, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(599L, false), req, mod, ens, etran.TrAttributes(m.Attributes, null));
            AddVerboseNameAttribute(proc, m.FullDafnyName, kind);

            if (InsertChecksums)
            {
                InsertChecksum(m, proc, MutateCSharp.Schemata498.ReplaceBooleanConstant_0(600L, true));
            }

            currentModule = null;
            codeContext = null;
            isAllocContext = null;

            return proc;
        }

        private void InsertChecksum(Method m, Boogie.Declaration decl, bool specificationOnly = false)
        {
            Contract.Requires(VisibleInScope(m));
            byte[] data;
            using (var writer = new System.IO.StringWriter())
            {
                var printer = new Printer(writer, options);
                printer.PrintAttributes(m.Attributes);
                printer.PrintFormals(m.Ins, m);
                if (m.Outs.Any())
                {
                    writer.Write(MutateCSharp.Schemata498.ReplaceStringConstant_1(601L, "returns "));
                    printer.PrintFormals(m.Outs, m);
                }
                printer.PrintSpec("", m.Req, MutateCSharp.Schemata498.ReplaceNumericConstant_9(602L, 0));
                printer.PrintFrameSpecLine("", m.Mod, MutateCSharp.Schemata498.ReplaceNumericConstant_9(606L, 0));
                printer.PrintSpec("", m.Ens, MutateCSharp.Schemata498.ReplaceNumericConstant_9(610L, 0));
                printer.PrintDecreasesSpec(m.Decreases, MutateCSharp.Schemata498.ReplaceNumericConstant_9(614L, 0));
                writer.WriteLine();
                if (MutateCSharp.Schemata498.ReplaceBinExprOp_6(625L, () => MutateCSharp.Schemata498.ReplaceBinExprOp_6(619L, () => !specificationOnly, () => MutateCSharp.Schemata498.ReplaceBinExprOp_8(618L, m.Body, null)), () => RevealedInScope(m)))
                {
                    printer.PrintStatement(m.Body, MutateCSharp.Schemata498.ReplaceNumericConstant_9(631L, 0));
                }
                data = Encoding.UTF8.GetBytes(writer.ToString());
            }

            InsertChecksum(decl, data);
        }
    }
}
