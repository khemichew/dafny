// Dafny program the_program compiled into C#
// To recompile, you will need the libraries
//     System.Runtime.Numerics.dll System.Collections.Immutable.dll
// but the 'dotnet' tool in net6.0 should pick those up automatically.
// Optionally, you may want to include compiler switches like
//     /debug /nowarn:162,164,168,183,219,436,1717,1718

using System;
using System.Numerics;
using System.Collections;
namespace MutateCSharp
{
    internal class Schemata278
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT278");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_3(long mutantId, System.Numerics.BigInteger argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_63(long mutantId, RAST.Associativity_RequiresParentheses argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_83(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() == argument2();
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, RAST.NamelessFormal argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_75(long mutantId, RAST.Expr_Block argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_57(long mutantId, Dafny.Rune argument1, Dafny.Rune argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_67(long mutantId, RAST.PrintingInfo_Precedence argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_34(long mutantId, RAST.Type_I32 argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_58(long mutantId, RAST.AssignIdentifier argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_90(long mutantId, RAST.Expr_Labelled argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, RAST.Mod_Mod argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBinExprOp_36(long mutantId, RAST.Type_I128 argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_45(long mutantId, RAST.Type_FnType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_79(long mutantId, RAST.Expr_BinaryOp argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_64(long mutantId, System.Numerics.BigInteger argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_33(long mutantId, RAST.Type_I16 argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_73(long mutantId, RAST.Expr_Match argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_59(long mutantId, RAST.DeclareType_MUT argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_94(long mutantId, RAST.Expr_Call argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, RAST.TypeParam argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_56(long mutantId, RAST.MatchCase argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Dafny.Rune argument1, Dafny.Rune argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_39(long mutantId, RAST.Type_TypeApp argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_69(long mutantId, RAST.PrintingInfo_SuffixPrecedence argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, RAST.Type_U8 argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, RAST.Formals_NamelessFormals argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_31(long mutantId, RAST.Type_U128 argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_40(long mutantId, RAST.Type_Borrowed argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBinExprOp_21(long mutantId, RAST.Formals_NamedFormals argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_87(long mutantId, RAST.Expr_IfExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, RAST.ModDecl_StructDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static ulong ReplaceNumericConstant_8(long mutantId, ulong argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 2)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, RAST.ModDecl_ImplDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, RAST.Struct argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_96(long mutantId, RAST.Expr_MemberSelect argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_88(long mutantId, RAST.Expr_Loop argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_85(long mutantId, RAST.Expr_DeclareVar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_66(long mutantId, RAST.PrintingInfo_UnknownPrecedence argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_78(long mutantId, RAST.Expr_UnaryOp argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, RAST.ModDecl_RawDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_50(long mutantId, RAST.ImplMember_RawImplMember argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_54(long mutantId, RAST.Formal argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_89(long mutantId, RAST.Expr_For argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_60(long mutantId, RAST.DeclareType_CONST argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_76(long mutantId, RAST.Expr_StructBuild argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_82(long mutantId, RAST.Expr_LiteralString argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_28(long mutantId, RAST.Type_U16 argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_37(long mutantId, RAST.Type_TIdentifier argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_77(long mutantId, RAST.Expr_Tuple argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_92(long mutantId, RAST.Expr_Continue argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_55(long mutantId, RAST.Pattern argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_38(long mutantId, RAST.Type_TMemberSelect argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_10(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_35(long mutantId, RAST.Type_I64 argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_97(long mutantId, RAST.Fn argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, RAST.Mod_ExternMod argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, RAST.Attribute argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_65(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_15(long mutantId, RAST.ModDecl_EnumDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_47(long mutantId, RAST.Trait argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_74(long mutantId, RAST.Expr_StmtExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_43(long mutantId, RAST.Type_DynType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, RAST.ModDecl_ModDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_30(long mutantId, RAST.Type_U64 argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_42(long mutantId, RAST.Type_ImplType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_91(long mutantId, RAST.Expr_Break argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, RAST.ModDecl_TraitDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_46(long mutantId, RAST.Type_IntersectionType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, RAST.EnumCase argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_29(long mutantId, RAST.Type_U32 argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Numerics.BigInteger argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, RAST.Type_SelfOwned argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_52(long mutantId, RAST.Visibility_PUB argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_41(long mutantId, RAST.Type_BorrowedMut argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_32(long mutantId, RAST.Type_I8 argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_81(long mutantId, RAST.Expr_LiteralInt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_44(long mutantId, RAST.Type_TupleType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, RAST.Enum argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_61(long mutantId, RAST.Associativity_LeftToRight argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static ulong ReplaceBinExprOp_9(long mutantId, ulong argument1, ulong argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 6)) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 ^ argument2; }
            return argument1 + argument2;
        }

        internal static bool ReplaceBinExprOp_70(long mutantId, RAST.PrintingInfo_PrecedenceAssociativity argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_71(long mutantId, RAST.Expr_RawExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_80(long mutantId, RAST.Expr_TypeAscription argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_93(long mutantId, RAST.Expr_Return argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_4(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
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

        internal static bool ReplaceBinExprOp_72(long mutantId, RAST.Expr_Identifier argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_62(long mutantId, RAST.Associativity_RightToLeft argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_68(long mutantId, System.Numerics.BigInteger argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_53(long mutantId, RAST.Visibility_PRIV argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_51(long mutantId, RAST.ImplMember_FnDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_95(long mutantId, RAST.Expr_Select argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_86(long mutantId, RAST.Expr_AssignVar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_48(long mutantId, RAST.Impl_ImplFor argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_84(long mutantId, RAST.Expr_ConversionNum argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_49(long mutantId, RAST.Impl_Impl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace RAST
{

    public partial class __default
    {
        public static Dafny.ISequence<Dafny.Rune> SeqToString<__T>(Dafny.ISequence<__T> s, Func<__T, Dafny.ISequence<Dafny.Rune>> f, Dafny.ISequence<Dafny.Rune> separator)
        {
            if (MutateCSharp.Schemata278.ReplaceBinExprOp_1(5L, (new BigInteger((s).Count)).Sign, MutateCSharp.Schemata278.ReplaceNumericConstant_0(1L, 0)))
            {
                return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            }
            else
            {
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Helpers.Id<Func<__T, Dafny.ISequence<Dafny.Rune>>>(f)((s).Select(BigInteger.Zero)), ((MutateCSharp.Schemata278.ReplaceBinExprOp_2(10L, (new BigInteger((s).Count)), (BigInteger.One))) ? (Dafny.Sequence<Dafny.Rune>.Concat(separator, RAST.__default.SeqToString<__T>((s).Drop(BigInteger.One), f, separator))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))));
            }

            return default;
        }
        public static BigInteger SeqToHeight<__T>(Dafny.ISequence<__T> s, Func<__T, BigInteger> f)
        {
            if (MutateCSharp.Schemata278.ReplaceBinExprOp_1(16L, (new BigInteger((s).Count)).Sign, MutateCSharp.Schemata278.ReplaceNumericConstant_0(12L, 0)))
            {
                return BigInteger.Zero;
            }
            else
            {
                BigInteger _828_i = Dafny.Helpers.Id<Func<__T, BigInteger>>(f)((s).Select(BigInteger.Zero));
                BigInteger _829_j = RAST.__default.SeqToHeight<__T>((s).Drop(BigInteger.One), f);
                if (MutateCSharp.Schemata278.ReplaceBinExprOp_3(21L, (_828_i), (_829_j)))
                {
                    return _829_j;
                }
                else
                {
                    return _828_i;
                }
            }

            return default;
        }
        public static RAST._IType Rc(RAST._IType underlying)
        {
            return RAST.Type.create_TypeApp(((RAST.__default.std__type).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(23L, "rc")))).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(24L, "Rc"))), Dafny.Sequence<RAST._IType>.FromElements(underlying));
        }
        public static RAST._IType RefCell(RAST._IType underlying)
        {
            return RAST.Type.create_TypeApp(((RAST.__default.std__type).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(25L, "cell")))).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(26L, "RefCell"))), Dafny.Sequence<RAST._IType>.FromElements(underlying));
        }
        public static RAST._IType Vec(RAST._IType underlying)
        {
            return RAST.Type.create_TypeApp(((RAST.__default.std__type).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(27L, "vec")))).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(28L, "Vec"))), Dafny.Sequence<RAST._IType>.FromElements(underlying));
        }
        public static RAST._IExpr NewVec(Dafny.ISequence<RAST._IExpr> elements)
        {
            return RAST.Expr.create_Call(RAST.Expr.create_Identifier(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(29L, "vec!"))), Dafny.Sequence<RAST._IType>.FromElements(), elements);
        }
        public static RAST._IExpr Clone(RAST._IExpr underlying)
        {
            return RAST.Expr.create_Call(RAST.Expr.create_Select(underlying, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(30L, "clone"))), Dafny.Sequence<RAST._IType>.FromElements(), Dafny.Sequence<RAST._IExpr>.FromElements());
        }
        public static RAST._IExpr Borrow(RAST._IExpr underlying)
        {
            return RAST.Expr.create_UnaryOp(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(31L, "&")), underlying, DAST.Format.UnaryOpFormat.create_NoFormat());
        }
        public static RAST._IExpr BorrowMut(RAST._IExpr underlying)
        {
            return RAST.Expr.create_UnaryOp(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(32L, "&mut")), underlying, DAST.Format.UnaryOpFormat.create_NoFormat());
        }
        public static RAST._IType RawType(Dafny.ISequence<Dafny.Rune> content)
        {
            return RAST.Type.create_TIdentifier(content);
        }
        public static Dafny.ISequence<Dafny.Rune> AddIndent(Dafny.ISequence<Dafny.Rune> raw, Dafny.ISequence<Dafny.Rune> ind)
        {
            Dafny.ISequence<Dafny.Rune> _830___accumulator = Dafny.Sequence<Dafny.Rune>.FromElements();
        TAIL_CALL_START:;
            if (MutateCSharp.Schemata278.ReplaceBinExprOp_1(37L, (new BigInteger((raw).Count)).Sign, MutateCSharp.Schemata278.ReplaceNumericConstant_0(33L, 0)))
            {
                return Dafny.Sequence<Dafny.Rune>.Concat(_830___accumulator, raw);
            }
            else if ((Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(42L, "[({"))).Contains((raw).Select(BigInteger.Zero)))
            {
                _830___accumulator = Dafny.Sequence<Dafny.Rune>.Concat(_830___accumulator, Dafny.Sequence<Dafny.Rune>.FromElements((raw).Select(BigInteger.Zero)));
                Dafny.ISequence<Dafny.Rune> _in103 = (raw).Drop(BigInteger.One);
                Dafny.ISequence<Dafny.Rune> _in104 = Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND);
                raw = _in103;
                ind = _in104;
                goto TAIL_CALL_START;
            }
            else if (MutateCSharp.Schemata278.ReplaceBinExprOp_5(50L, () => ((Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(43L, "})]"))).Contains((raw).Select(BigInteger.Zero))), () => (MutateCSharp.Schemata278.ReplaceBinExprOp_2(48L, (new BigInteger((ind).Count)), (new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(44L, 2)))))))
            {
                _830___accumulator = Dafny.Sequence<Dafny.Rune>.Concat(_830___accumulator, Dafny.Sequence<Dafny.Rune>.FromElements((raw).Select(BigInteger.Zero)));
                Dafny.ISequence<Dafny.Rune> _in105 = (raw).Drop(BigInteger.One);
                Dafny.ISequence<Dafny.Rune> _in106 = (ind).Take((new BigInteger((ind).Count)) - (new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(56L, 2))));
                raw = _in105;
                ind = _in106;
                goto TAIL_CALL_START;
            }
            else if (MutateCSharp.Schemata278.ReplaceBinExprOp_6(60L, ((raw).Select(BigInteger.Zero)), (new Dafny.Rune('\n'))))
            {
                _830___accumulator = Dafny.Sequence<Dafny.Rune>.Concat(_830___accumulator, Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.FromElements((raw).Select(BigInteger.Zero)), ind));
                Dafny.ISequence<Dafny.Rune> _in107 = (raw).Drop(BigInteger.One);
                Dafny.ISequence<Dafny.Rune> _in108 = ind;
                raw = _in107;
                ind = _in108;
                goto TAIL_CALL_START;
            }
            else
            {
                _830___accumulator = Dafny.Sequence<Dafny.Rune>.Concat(_830___accumulator, Dafny.Sequence<Dafny.Rune>.FromElements((raw).Select(BigInteger.Zero)));
                Dafny.ISequence<Dafny.Rune> _in109 = (raw).Drop(BigInteger.One);
                Dafny.ISequence<Dafny.Rune> _in110 = ind;
                raw = _in109;
                ind = _in110;
                goto TAIL_CALL_START;
            }

            return default;
        }
        public static BigInteger max(BigInteger i, BigInteger j)
        {
            if (MutateCSharp.Schemata278.ReplaceBinExprOp_3(61L, (i), (j)))
            {
                return j;
            }
            else
            {
                return i;
            }

            return default;
        }
        public static RAST._IExpr RcNew(RAST._IExpr underlying)
        {
            return RAST.Expr.create_Call(RAST.__default.std__rc__Rc__new, Dafny.Sequence<RAST._IType>.FromElements(), Dafny.Sequence<RAST._IExpr>.FromElements(underlying));
        }
        public static RAST._IType Self
        {
            get
            {
                return RAST.Type.create_Borrowed(RAST.Type.create_SelfOwned());
            }
        }

        public static RAST._IType SelfMut
        {
            get
            {
                return RAST.Type.create_BorrowedMut(RAST.Type.create_SelfOwned());
            }
        }

        public static RAST._IType global__type
        {
            get
            {
                return RAST.Type.create_TIdentifier(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""));
            }
        }

        public static RAST._IType std__type
        {
            get
            {
                return (RAST.__default.global__type).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(63L, "std")));
            }
        }

        public static RAST._IType CloneTrait
        {
            get
            {
                return RAST.__default.RawType(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(64L, "Clone")));
            }
        }

        public static RAST._IType DafnyPrintTrait
        {
            get
            {
                return RAST.__default.RawType(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(65L, "::dafny_runtime::DafnyPrint")));
            }
        }

        public static RAST._IType DefaultTrait
        {
            get
            {
                return RAST.__default.RawType(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(66L, "::std::default::Default")));
            }
        }

        public static RAST._IType StaticTrait
        {
            get
            {
                return RAST.__default.RawType(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(67L, "'static")));
            }
        }

        public static RAST._IType cell__type
        {
            get
            {
                return (RAST.__default.std__type).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(68L, "cell")));
            }
        }

        public static RAST._IType refcell__type
        {
            get
            {
                return (RAST.__default.cell__type).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(69L, "RefCell")));
            }
        }

        public static RAST._IType dafny__runtime__type
        {
            get
            {
                return (RAST.__default.global__type).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(70L, "dafny_runtime")));
            }
        }

        public static Dafny.ISequence<Dafny.Rune> IND
        {
            get
            {
                return Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(71L, "  "));
            }
        }

        public static RAST._IExpr @global
        {
            get
            {
                return RAST.Expr.create_Identifier(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""));
            }
        }

        public static RAST._IExpr dafny__runtime
        {
            get
            {
                return (RAST.__default.@global).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(72L, "dafny_runtime")));
            }
        }

        public static RAST._IExpr dafny__runtime__Set
        {
            get
            {
                return (RAST.__default.dafny__runtime).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(73L, "Set")));
            }
        }

        public static RAST._IExpr dafny__runtime__Set__from__array
        {
            get
            {
                return (RAST.__default.dafny__runtime__Set).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(74L, "from_array")));
            }
        }

        public static RAST._IExpr dafny__runtime__Sequence
        {
            get
            {
                return (RAST.__default.dafny__runtime).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(75L, "Sequence")));
            }
        }

        public static RAST._IExpr Sequence__from__array__owned
        {
            get
            {
                return (RAST.__default.dafny__runtime__Sequence).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(76L, "from_array_owned")));
            }
        }

        public static RAST._IExpr Sequence__from__array
        {
            get
            {
                return (RAST.__default.dafny__runtime__Sequence).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(77L, "from_array")));
            }
        }

        public static RAST._IExpr dafny__runtime__Multiset
        {
            get
            {
                return (RAST.__default.dafny__runtime).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(78L, "Multiset")));
            }
        }

        public static RAST._IExpr dafny__runtime__Multiset__from__array
        {
            get
            {
                return (RAST.__default.dafny__runtime__Multiset).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(79L, "from_array")));
            }
        }

        public static RAST._IExpr std
        {
            get
            {
                return (RAST.__default.@global).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(80L, "std")));
            }
        }

        public static RAST._IExpr std__rc
        {
            get
            {
                return (RAST.__default.std).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(81L, "rc")));
            }
        }

        public static RAST._IExpr std__rc__Rc
        {
            get
            {
                return (RAST.__default.std__rc).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(82L, "Rc")));
            }
        }

        public static RAST._IExpr std__rc__Rc__new
        {
            get
            {
                return (RAST.__default.std__rc__Rc).MSel(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(83L, "new")));
            }
        }
    }

    public interface _IMod
    {
        bool is_Mod { get; }
        bool is_ExternMod { get; }
        Dafny.ISequence<Dafny.Rune> dtor_name { get; }
        Dafny.ISequence<RAST._IModDecl> dtor_body { get; }

        _IMod DowncastClone();
        Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
    }
    public abstract class Mod : _IMod
    {
        public Mod()
        {
        }
        private static readonly RAST._IMod theDefault = create_Mod(Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<RAST._IModDecl>.Empty);
        public static RAST._IMod Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<RAST._IMod> _TYPE = new Dafny.TypeDescriptor<RAST._IMod>(RAST.Mod.Default());
        public static Dafny.TypeDescriptor<RAST._IMod> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IMod create_Mod(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._IModDecl> body)
        {
            return new Mod_Mod(name, body);
        }
        public static _IMod create_ExternMod(Dafny.ISequence<Dafny.Rune> name)
        {
            return new Mod_ExternMod(name);
        }
        public bool is_Mod
        {
            get { return this is Mod_Mod; }
        }

        public bool is_ExternMod
        {
            get { return this is Mod_ExternMod; }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_name
        {
            get
            {
                var d = this;
                if (d is Mod_Mod) { return ((Mod_Mod)d)._name; }
                return ((Mod_ExternMod)d)._name;
            }
        }

        public Dafny.ISequence<RAST._IModDecl> dtor_body
        {
            get
            {
                var d = this;
                return ((Mod_Mod)d)._body;
            }
        }

        public abstract _IMod DowncastClone();
        public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind)
        {
            RAST._IMod _source25 = this;
            if (_source25.is_Mod)
            {
                Dafny.ISequence<Dafny.Rune> _831___mcc_h0 = _source25.dtor_name;
                Dafny.ISequence<RAST._IModDecl> _832___mcc_h1 = _source25.dtor_body;
                Dafny.ISequence<RAST._IModDecl> _833_body = _832___mcc_h1;
                Dafny.ISequence<Dafny.Rune> _834_name = _831___mcc_h0;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(84L, "mod ")), _834_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(85L, " {"))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(86L, "\n"))), ind), RAST.__default.IND), RAST.__default.SeqToString<RAST._IModDecl>(_833_body, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IModDecl, Dafny.ISequence<Dafny.Rune>>>>((_835_ind) => ((System.Func<RAST._IModDecl, Dafny.ISequence<Dafny.Rune>>)((_836_modDecl) =>
                {
                    return (_836_modDecl)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_835_ind, RAST.__default.IND));
                })))(ind), Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(87L, "\n")), ind), RAST.__default.IND))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(88L, "\n"))), ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(89L, "}")));
            }
            else
            {
                Dafny.ISequence<Dafny.Rune> _837___mcc_h2 = _source25.dtor_name;
                Dafny.ISequence<Dafny.Rune> _838_name = _837___mcc_h2;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(90L, "mod ")), _838_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(91L, ";")));
            }

            return default;
        }
    }
    public class Mod_Mod : Mod
    {
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public readonly Dafny.ISequence<RAST._IModDecl> _body;
        public Mod_Mod(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._IModDecl> body) : base()
        {
            this._name = name;
            this._body = body;
        }
        public override _IMod DowncastClone()
        {
            if (this is _IMod dt) { return dt; }
            return new Mod_Mod(_name, _body);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Mod_Mod;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(99L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(93L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_7(92L, oth, null), () => object.Equals(this._name, oth._name)), () => object.Equals(this._body, oth._body));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(105L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(122L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(112L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(108L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(119L, 0));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(140L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(133L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(129L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(158L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(151L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(147L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._body)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(165L, "RAST.Mod.Mod");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(166L, "(");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(167L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(168L, ", ");
            s += Dafny.Helpers.ToString(this._body);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(169L, ")");
            return s;
        }
    }
    public class Mod_ExternMod : Mod
    {
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public Mod_ExternMod(Dafny.ISequence<Dafny.Rune> name) : base()
        {
            this._name = name;
        }
        public override _IMod DowncastClone()
        {
            if (this is _IMod dt) { return dt; }
            return new Mod_ExternMod(_name);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Mod_ExternMod;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(171L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_11(170L, oth, null), () => object.Equals(this._name, oth._name));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(177L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(194L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(184L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(180L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(191L, 1));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(212L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(205L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(201L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(219L, "RAST.Mod.ExternMod");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(220L, "(");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(221L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(222L, ")");
            return s;
        }
    }

    public interface _IModDecl
    {
        bool is_RawDecl { get; }
        bool is_ModDecl { get; }
        bool is_StructDecl { get; }
        bool is_EnumDecl { get; }
        bool is_ImplDecl { get; }
        bool is_TraitDecl { get; }
        Dafny.ISequence<Dafny.Rune> dtor_body { get; }
        RAST._IMod dtor_mod { get; }
        RAST._IStruct dtor_struct { get; }
        RAST._IEnum dtor_enum { get; }
        RAST._IImpl dtor_impl { get; }
        RAST._ITrait dtor_tr { get; }

        _IModDecl DowncastClone();
        Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
    }
    public abstract class ModDecl : _IModDecl
    {
        public ModDecl()
        {
        }
        private static readonly RAST._IModDecl theDefault = create_RawDecl(Dafny.Sequence<Dafny.Rune>.Empty);
        public static RAST._IModDecl Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<RAST._IModDecl> _TYPE = new Dafny.TypeDescriptor<RAST._IModDecl>(RAST.ModDecl.Default());
        public static Dafny.TypeDescriptor<RAST._IModDecl> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IModDecl create_RawDecl(Dafny.ISequence<Dafny.Rune> body)
        {
            return new ModDecl_RawDecl(body);
        }
        public static _IModDecl create_ModDecl(RAST._IMod mod)
        {
            return new ModDecl_ModDecl(mod);
        }
        public static _IModDecl create_StructDecl(RAST._IStruct @struct)
        {
            return new ModDecl_StructDecl(@struct);
        }
        public static _IModDecl create_EnumDecl(RAST._IEnum @enum)
        {
            return new ModDecl_EnumDecl(@enum);
        }
        public static _IModDecl create_ImplDecl(RAST._IImpl impl)
        {
            return new ModDecl_ImplDecl(impl);
        }
        public static _IModDecl create_TraitDecl(RAST._ITrait tr)
        {
            return new ModDecl_TraitDecl(tr);
        }
        public bool is_RawDecl
        {
            get { return this is ModDecl_RawDecl; }
        }

        public bool is_ModDecl
        {
            get { return this is ModDecl_ModDecl; }
        }

        public bool is_StructDecl
        {
            get { return this is ModDecl_StructDecl; }
        }

        public bool is_EnumDecl
        {
            get { return this is ModDecl_EnumDecl; }
        }

        public bool is_ImplDecl
        {
            get { return this is ModDecl_ImplDecl; }
        }

        public bool is_TraitDecl
        {
            get { return this is ModDecl_TraitDecl; }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_body
        {
            get
            {
                var d = this;
                return ((ModDecl_RawDecl)d)._body;
            }
        }

        public RAST._IMod dtor_mod
        {
            get
            {
                var d = this;
                return ((ModDecl_ModDecl)d)._mod;
            }
        }

        public RAST._IStruct dtor_struct
        {
            get
            {
                var d = this;
                return ((ModDecl_StructDecl)d)._struct;
            }
        }

        public RAST._IEnum dtor_enum
        {
            get
            {
                var d = this;
                return ((ModDecl_EnumDecl)d)._enum;
            }
        }

        public RAST._IImpl dtor_impl
        {
            get
            {
                var d = this;
                return ((ModDecl_ImplDecl)d)._impl;
            }
        }

        public RAST._ITrait dtor_tr
        {
            get
            {
                var d = this;
                return ((ModDecl_TraitDecl)d)._tr;
            }
        }

        public abstract _IModDecl DowncastClone();
        public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind)
        {
            if ((this).is_ModDecl)
            {
                return ((this).dtor_mod)._ToString(ind);
            }
            else if ((this).is_StructDecl)
            {
                return ((this).dtor_struct)._ToString(ind);
            }
            else if ((this).is_ImplDecl)
            {
                return ((this).dtor_impl)._ToString(ind);
            }
            else if ((this).is_EnumDecl)
            {
                return ((this).dtor_enum)._ToString(ind);
            }
            else if ((this).is_TraitDecl)
            {
                return ((this).dtor_tr)._ToString(ind);
            }
            else
            {
                return (this).dtor_body;
            }

            return default;
        }
    }
    public class ModDecl_RawDecl : ModDecl
    {
        public readonly Dafny.ISequence<Dafny.Rune> _body;
        public ModDecl_RawDecl(Dafny.ISequence<Dafny.Rune> body) : base()
        {
            this._body = body;
        }
        public override _IModDecl DowncastClone()
        {
            if (this is _IModDecl dt) { return dt; }
            return new ModDecl_RawDecl(_body);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.ModDecl_RawDecl;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(224L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_12(223L, oth, null), () => object.Equals(this._body, oth._body));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(230L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(247L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(237L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(233L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(244L, 0));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(265L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(258L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(254L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._body)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(272L, "RAST.ModDecl.RawDecl");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(273L, "(");
            s += this._body.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(274L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(275L, ")");
            return s;
        }
    }
    public class ModDecl_ModDecl : ModDecl
    {
        public readonly RAST._IMod _mod;
        public ModDecl_ModDecl(RAST._IMod mod) : base()
        {
            this._mod = mod;
        }
        public override _IModDecl DowncastClone()
        {
            if (this is _IModDecl dt) { return dt; }
            return new ModDecl_ModDecl(_mod);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.ModDecl_ModDecl;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(277L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_13(276L, oth, null), () => object.Equals(this._mod, oth._mod));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(283L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(300L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(290L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(286L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(297L, 1));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(318L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(311L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(307L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._mod)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(325L, "RAST.ModDecl.ModDecl");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(326L, "(");
            s += Dafny.Helpers.ToString(this._mod);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(327L, ")");
            return s;
        }
    }
    public class ModDecl_StructDecl : ModDecl
    {
        public readonly RAST._IStruct _struct;
        public ModDecl_StructDecl(RAST._IStruct @struct) : base()
        {
            this._struct = @struct;
        }
        public override _IModDecl DowncastClone()
        {
            if (this is _IModDecl dt) { return dt; }
            return new ModDecl_StructDecl(_struct);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.ModDecl_StructDecl;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(329L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_14(328L, oth, null), () => object.Equals(this._struct, oth._struct));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(335L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(352L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(342L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(338L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(349L, 2));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(370L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(363L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(359L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._struct)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(377L, "RAST.ModDecl.StructDecl");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(378L, "(");
            s += Dafny.Helpers.ToString(this._struct);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(379L, ")");
            return s;
        }
    }
    public class ModDecl_EnumDecl : ModDecl
    {
        public readonly RAST._IEnum _enum;
        public ModDecl_EnumDecl(RAST._IEnum @enum) : base()
        {
            this._enum = @enum;
        }
        public override _IModDecl DowncastClone()
        {
            if (this is _IModDecl dt) { return dt; }
            return new ModDecl_EnumDecl(_enum);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.ModDecl_EnumDecl;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(381L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_15(380L, oth, null), () => object.Equals(this._enum, oth._enum));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(387L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(404L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(394L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(390L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(401L, 3));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(422L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(415L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(411L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._enum)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(429L, "RAST.ModDecl.EnumDecl");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(430L, "(");
            s += Dafny.Helpers.ToString(this._enum);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(431L, ")");
            return s;
        }
    }
    public class ModDecl_ImplDecl : ModDecl
    {
        public readonly RAST._IImpl _impl;
        public ModDecl_ImplDecl(RAST._IImpl impl) : base()
        {
            this._impl = impl;
        }
        public override _IModDecl DowncastClone()
        {
            if (this is _IModDecl dt) { return dt; }
            return new ModDecl_ImplDecl(_impl);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.ModDecl_ImplDecl;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(433L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_16(432L, oth, null), () => object.Equals(this._impl, oth._impl));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(439L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(456L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(446L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(442L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(453L, 4));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(474L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(467L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(463L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._impl)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(481L, "RAST.ModDecl.ImplDecl");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(482L, "(");
            s += Dafny.Helpers.ToString(this._impl);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(483L, ")");
            return s;
        }
    }
    public class ModDecl_TraitDecl : ModDecl
    {
        public readonly RAST._ITrait _tr;
        public ModDecl_TraitDecl(RAST._ITrait tr) : base()
        {
            this._tr = tr;
        }
        public override _IModDecl DowncastClone()
        {
            if (this is _IModDecl dt) { return dt; }
            return new ModDecl_TraitDecl(_tr);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.ModDecl_TraitDecl;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(485L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_17(484L, oth, null), () => object.Equals(this._tr, oth._tr));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(491L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(508L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(498L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(494L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(505L, 5));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(526L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(519L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(515L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._tr)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(533L, "RAST.ModDecl.TraitDecl");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(534L, "(");
            s += Dafny.Helpers.ToString(this._tr);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(535L, ")");
            return s;
        }
    }

    public interface _IAttribute
    {
        bool is_RawAttribute { get; }
        Dafny.ISequence<Dafny.Rune> dtor_content { get; }
    }
    public class Attribute : _IAttribute
    {
        public readonly Dafny.ISequence<Dafny.Rune> _content;
        public Attribute(Dafny.ISequence<Dafny.Rune> content)
        {
            this._content = content;
        }
        public static Dafny.ISequence<Dafny.Rune> DowncastClone(Dafny.ISequence<Dafny.Rune> _this)
        {
            return _this;
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Attribute;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(537L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_18(536L, oth, null), () => object.Equals(this._content, oth._content));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(543L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(560L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(550L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(546L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(557L, 0));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(578L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(571L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(567L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._content)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(585L, "RAST.Attribute.RawAttribute");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(586L, "(");
            s += this._content.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(587L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(588L, ")");
            return s;
        }
        private static readonly Dafny.ISequence<Dafny.Rune> theDefault = Dafny.Sequence<Dafny.Rune>.Empty;
        public static Dafny.ISequence<Dafny.Rune> Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<Dafny.ISequence<Dafny.Rune>> _TYPE = new Dafny.TypeDescriptor<Dafny.ISequence<Dafny.Rune>>(Dafny.Sequence<Dafny.Rune>.Empty);
        public static Dafny.TypeDescriptor<Dafny.ISequence<Dafny.Rune>> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IAttribute create(Dafny.ISequence<Dafny.Rune> content)
        {
            return new Attribute(content);
        }
        public static _IAttribute create_RawAttribute(Dafny.ISequence<Dafny.Rune> content)
        {
            return create(content);
        }
        public bool is_RawAttribute
        {
            get { return MutateCSharp.Schemata278.ReplaceBooleanConstant_10(589L, true); }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_content
        {
            get
            {
                return this._content;
            }
        }

        public static Dafny.ISequence<Dafny.Rune> ToStringMultiple(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> attributes, Dafny.ISequence<Dafny.Rune> ind)
        {
            return RAST.__default.SeqToString<Dafny.ISequence<Dafny.Rune>>(attributes, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>>>((_839_ind) => ((System.Func<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>)((_840_attribute) =>
            {
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat((_840_attribute), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(590L, "\n"))), _839_ind);
            })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""));
        }
    }

    public interface _IStruct
    {
        bool is_Struct { get; }
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_attributes { get; }
        Dafny.ISequence<Dafny.Rune> dtor_name { get; }
        Dafny.ISequence<RAST._ITypeParam> dtor_typeParams { get; }
        RAST._IFormals dtor_fields { get; }

        _IStruct DowncastClone();
        Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
    }
    public class Struct : _IStruct
    {
        public readonly Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _attributes;
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public readonly Dafny.ISequence<RAST._ITypeParam> _typeParams;
        public readonly RAST._IFormals _fields;
        public Struct(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> attributes, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._ITypeParam> typeParams, RAST._IFormals fields)
        {
            this._attributes = attributes;
            this._name = name;
            this._typeParams = typeParams;
            this._fields = fields;
        }
        public _IStruct DowncastClone()
        {
            if (this is _IStruct dt) { return dt; }
            return new Struct(_attributes, _name, _typeParams, _fields);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Struct;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(610L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(604L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(598L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(592L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_19(591L, oth, null), () => object.Equals(this._attributes, oth._attributes)), () => object.Equals(this._name, oth._name)), () => object.Equals(this._typeParams, oth._typeParams)), () => object.Equals(this._fields, oth._fields));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(616L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(633L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(623L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(619L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(630L, 0));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(651L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(644L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(640L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._attributes)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(669L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(662L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(658L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(687L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(680L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(676L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typeParams)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(705L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(698L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(694L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._fields)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(712L, "RAST.Struct.Struct");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(713L, "(");
            s += Dafny.Helpers.ToString(this._attributes);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(714L, ", ");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(715L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(716L, ", ");
            s += Dafny.Helpers.ToString(this._typeParams);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(717L, ", ");
            s += Dafny.Helpers.ToString(this._fields);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(718L, ")");
            return s;
        }
        private static readonly RAST._IStruct theDefault = create(Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Empty, Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<RAST._ITypeParam>.Empty, RAST.Formals.Default());
        public static RAST._IStruct Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<RAST._IStruct> _TYPE = new Dafny.TypeDescriptor<RAST._IStruct>(RAST.Struct.Default());
        public static Dafny.TypeDescriptor<RAST._IStruct> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IStruct create(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> attributes, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._ITypeParam> typeParams, RAST._IFormals fields)
        {
            return new Struct(attributes, name, typeParams, fields);
        }
        public static _IStruct create_Struct(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> attributes, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._ITypeParam> typeParams, RAST._IFormals fields)
        {
            return create(attributes, name, typeParams, fields);
        }
        public bool is_Struct
        {
            get { return MutateCSharp.Schemata278.ReplaceBooleanConstant_10(719L, true); }
        }

        public Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_attributes
        {
            get
            {
                return this._attributes;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_name
        {
            get
            {
                return this._name;
            }
        }

        public Dafny.ISequence<RAST._ITypeParam> dtor_typeParams
        {
            get
            {
                return this._typeParams;
            }
        }

        public RAST._IFormals dtor_fields
        {
            get
            {
                return this._fields;
            }
        }

        public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind)
        {
            return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(RAST.Attribute.ToStringMultiple((this).dtor_attributes, ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(720L, "pub struct "))), (this).dtor_name), RAST.TypeParam.ToStringMultiple((this).dtor_typeParams, ind)), ((this).dtor_fields)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND), ((this).dtor_fields).is_NamedFormals)), ((((this).dtor_fields).is_NamelessFormals) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(721L, ";"))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))));
        }
    }

    public interface _INamelessFormal
    {
        bool is_NamelessFormal { get; }
        RAST._IVisibility dtor_visibility { get; }
        RAST._IType dtor_tpe { get; }

        _INamelessFormal DowncastClone();
        Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
    }
    public class NamelessFormal : _INamelessFormal
    {
        public readonly RAST._IVisibility _visibility;
        public readonly RAST._IType _tpe;
        public NamelessFormal(RAST._IVisibility visibility, RAST._IType tpe)
        {
            this._visibility = visibility;
            this._tpe = tpe;
        }
        public _INamelessFormal DowncastClone()
        {
            if (this is _INamelessFormal dt) { return dt; }
            return new NamelessFormal(_visibility, _tpe);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.NamelessFormal;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(729L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(723L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_20(722L, oth, null), () => object.Equals(this._visibility, oth._visibility)), () => object.Equals(this._tpe, oth._tpe));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(735L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(752L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(742L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(738L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(749L, 0));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(770L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(763L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(759L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._visibility)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(788L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(781L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(777L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._tpe)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(795L, "RAST.NamelessFormal.NamelessFormal");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(796L, "(");
            s += Dafny.Helpers.ToString(this._visibility);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(797L, ", ");
            s += Dafny.Helpers.ToString(this._tpe);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(798L, ")");
            return s;
        }
        private static readonly RAST._INamelessFormal theDefault = create(RAST.Visibility.Default(), RAST.Type.Default());
        public static RAST._INamelessFormal Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<RAST._INamelessFormal> _TYPE = new Dafny.TypeDescriptor<RAST._INamelessFormal>(RAST.NamelessFormal.Default());
        public static Dafny.TypeDescriptor<RAST._INamelessFormal> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _INamelessFormal create(RAST._IVisibility visibility, RAST._IType tpe)
        {
            return new NamelessFormal(visibility, tpe);
        }
        public static _INamelessFormal create_NamelessFormal(RAST._IVisibility visibility, RAST._IType tpe)
        {
            return create(visibility, tpe);
        }
        public bool is_NamelessFormal
        {
            get { return MutateCSharp.Schemata278.ReplaceBooleanConstant_10(799L, true); }
        }

        public RAST._IVisibility dtor_visibility
        {
            get
            {
                return this._visibility;
            }
        }

        public RAST._IType dtor_tpe
        {
            get
            {
                return this._tpe;
            }
        }

        public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind)
        {
            return Dafny.Sequence<Dafny.Rune>.Concat(((object.Equals((this).dtor_visibility, RAST.Visibility.create_PUB())) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(800L, "pub "))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), ((this).dtor_tpe)._ToString(ind));
        }
    }

    public interface _IFormals
    {
        bool is_NamedFormals { get; }
        bool is_NamelessFormals { get; }
        Dafny.ISequence<RAST._IFormal> dtor_fields { get; }
        Dafny.ISequence<RAST._INamelessFormal> dtor_types { get; }

        _IFormals DowncastClone();
        Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind, bool newLine);
    }
    public abstract class Formals : _IFormals
    {
        public Formals()
        {
        }
        private static readonly RAST._IFormals theDefault = create_NamedFormals(Dafny.Sequence<RAST._IFormal>.Empty);
        public static RAST._IFormals Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<RAST._IFormals> _TYPE = new Dafny.TypeDescriptor<RAST._IFormals>(RAST.Formals.Default());
        public static Dafny.TypeDescriptor<RAST._IFormals> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IFormals create_NamedFormals(Dafny.ISequence<RAST._IFormal> fields)
        {
            return new Formals_NamedFormals(fields);
        }
        public static _IFormals create_NamelessFormals(Dafny.ISequence<RAST._INamelessFormal> types)
        {
            return new Formals_NamelessFormals(types);
        }
        public bool is_NamedFormals
        {
            get { return this is Formals_NamedFormals; }
        }

        public bool is_NamelessFormals
        {
            get { return this is Formals_NamelessFormals; }
        }

        public Dafny.ISequence<RAST._IFormal> dtor_fields
        {
            get
            {
                var d = this;
                return ((Formals_NamedFormals)d)._fields;
            }
        }

        public Dafny.ISequence<RAST._INamelessFormal> dtor_types
        {
            get
            {
                var d = this;
                return ((Formals_NamelessFormals)d)._types;
            }
        }

        public abstract _IFormals DowncastClone();
        public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind, bool newLine)
        {
            if ((this).is_NamedFormals)
            {
                Dafny.ISequence<Dafny.Rune> _841_separator = ((newLine) ? (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(801L, ",\n")), ind), RAST.__default.IND)) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(802L, ", "))));
                _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> _let_tmp_rhs40 = ((MutateCSharp.Schemata278.ReplaceBinExprOp_5(812L, () => (newLine), () => (MutateCSharp.Schemata278.ReplaceBinExprOp_1(807L, (new BigInteger(((this).dtor_fields).Count)).Sign, MutateCSharp.Schemata278.ReplaceNumericConstant_0(803L, 1))))) ? (_System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(818L, "\n")), ind), RAST.__default.IND), Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(819L, "\n")), ind))) : (((MutateCSharp.Schemata278.ReplaceBinExprOp_1(824L, (new BigInteger(((this).dtor_fields).Count)).Sign, MutateCSharp.Schemata278.ReplaceNumericConstant_0(820L, 1))) ? (_System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(829L, " ")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(830L, " ")))) : (_System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))))));
                Dafny.ISequence<Dafny.Rune> _842_beginSpace = _let_tmp_rhs40.dtor__0;
                Dafny.ISequence<Dafny.Rune> _843_endSpace = _let_tmp_rhs40.dtor__1;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(831L, " {")), _842_beginSpace), RAST.__default.SeqToString<RAST._IFormal>((this).dtor_fields, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IFormal, Dafny.ISequence<Dafny.Rune>>>>((_844_ind) => ((System.Func<RAST._IFormal, Dafny.ISequence<Dafny.Rune>>)((_845_field) =>
                {
                    return (_845_field)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_844_ind, RAST.__default.IND));
                })))(ind), _841_separator)), _843_endSpace), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(832L, "}")));
            }
            else
            {
                Dafny.ISequence<Dafny.Rune> _846_separator = ((newLine) ? (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(833L, ",\n")), ind), RAST.__default.IND)) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(834L, ", "))));
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(835L, "(")), RAST.__default.SeqToString<RAST._INamelessFormal>((this).dtor_types, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._INamelessFormal, Dafny.ISequence<Dafny.Rune>>>>((_847_ind) => ((System.Func<RAST._INamelessFormal, Dafny.ISequence<Dafny.Rune>>)((_848_t) =>
                {
                    return (_848_t)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_847_ind, RAST.__default.IND));
                })))(ind), _846_separator)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(836L, ")")));
            }

            return default;
        }
    }
    public class Formals_NamedFormals : Formals
    {
        public readonly Dafny.ISequence<RAST._IFormal> _fields;
        public Formals_NamedFormals(Dafny.ISequence<RAST._IFormal> fields) : base()
        {
            this._fields = fields;
        }
        public override _IFormals DowncastClone()
        {
            if (this is _IFormals dt) { return dt; }
            return new Formals_NamedFormals(_fields);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Formals_NamedFormals;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(838L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_21(837L, oth, null), () => object.Equals(this._fields, oth._fields));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(844L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(861L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(851L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(847L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(858L, 0));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(879L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(872L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(868L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._fields)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(886L, "RAST.Formals.NamedFormals");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(887L, "(");
            s += Dafny.Helpers.ToString(this._fields);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(888L, ")");
            return s;
        }
    }
    public class Formals_NamelessFormals : Formals
    {
        public readonly Dafny.ISequence<RAST._INamelessFormal> _types;
        public Formals_NamelessFormals(Dafny.ISequence<RAST._INamelessFormal> types) : base()
        {
            this._types = types;
        }
        public override _IFormals DowncastClone()
        {
            if (this is _IFormals dt) { return dt; }
            return new Formals_NamelessFormals(_types);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Formals_NamelessFormals;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(890L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_22(889L, oth, null), () => object.Equals(this._types, oth._types));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(896L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(913L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(903L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(899L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(910L, 1));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(931L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(924L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(920L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._types)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(938L, "RAST.Formals.NamelessFormals");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(939L, "(");
            s += Dafny.Helpers.ToString(this._types);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(940L, ")");
            return s;
        }
    }

    public interface _IEnumCase
    {
        bool is_EnumCase { get; }
        Dafny.ISequence<Dafny.Rune> dtor_name { get; }
        RAST._IFormals dtor_fields { get; }

        _IEnumCase DowncastClone();
        Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind, bool newLine);
    }
    public class EnumCase : _IEnumCase
    {
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public readonly RAST._IFormals _fields;
        public EnumCase(Dafny.ISequence<Dafny.Rune> name, RAST._IFormals fields)
        {
            this._name = name;
            this._fields = fields;
        }
        public _IEnumCase DowncastClone()
        {
            if (this is _IEnumCase dt) { return dt; }
            return new EnumCase(_name, _fields);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.EnumCase;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(948L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(942L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_23(941L, oth, null), () => object.Equals(this._name, oth._name)), () => object.Equals(this._fields, oth._fields));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(954L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(971L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(961L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(957L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(968L, 0));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(989L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(982L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(978L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1007L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1000L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(996L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._fields)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(1014L, "RAST.EnumCase.EnumCase");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1015L, "(");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(1016L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1017L, ", ");
            s += Dafny.Helpers.ToString(this._fields);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1018L, ")");
            return s;
        }
        private static readonly RAST._IEnumCase theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, RAST.Formals.Default());
        public static RAST._IEnumCase Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<RAST._IEnumCase> _TYPE = new Dafny.TypeDescriptor<RAST._IEnumCase>(RAST.EnumCase.Default());
        public static Dafny.TypeDescriptor<RAST._IEnumCase> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IEnumCase create(Dafny.ISequence<Dafny.Rune> name, RAST._IFormals fields)
        {
            return new EnumCase(name, fields);
        }
        public static _IEnumCase create_EnumCase(Dafny.ISequence<Dafny.Rune> name, RAST._IFormals fields)
        {
            return create(name, fields);
        }
        public bool is_EnumCase
        {
            get { return MutateCSharp.Schemata278.ReplaceBooleanConstant_10(1019L, true); }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_name
        {
            get
            {
                return this._name;
            }
        }

        public RAST._IFormals dtor_fields
        {
            get
            {
                return this._fields;
            }
        }

        public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind, bool newLine)
        {
            return Dafny.Sequence<Dafny.Rune>.Concat((this).dtor_name, ((this).dtor_fields)._ToString(ind, newLine));
        }
    }

    public interface _IEnum
    {
        bool is_Enum { get; }
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_attributes { get; }
        Dafny.ISequence<Dafny.Rune> dtor_name { get; }
        Dafny.ISequence<RAST._ITypeParam> dtor_typeParams { get; }
        Dafny.ISequence<RAST._IEnumCase> dtor_variants { get; }

        _IEnum DowncastClone();
        Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
    }
    public class Enum : _IEnum
    {
        public readonly Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _attributes;
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public readonly Dafny.ISequence<RAST._ITypeParam> _typeParams;
        public readonly Dafny.ISequence<RAST._IEnumCase> _variants;
        public Enum(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> attributes, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._ITypeParam> typeParams, Dafny.ISequence<RAST._IEnumCase> variants)
        {
            this._attributes = attributes;
            this._name = name;
            this._typeParams = typeParams;
            this._variants = variants;
        }
        public _IEnum DowncastClone()
        {
            if (this is _IEnum dt) { return dt; }
            return new Enum(_attributes, _name, _typeParams, _variants);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Enum;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(1039L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(1033L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(1027L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(1021L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_24(1020L, oth, null), () => object.Equals(this._attributes, oth._attributes)), () => object.Equals(this._name, oth._name)), () => object.Equals(this._typeParams, oth._typeParams)), () => object.Equals(this._variants, oth._variants));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(1045L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1062L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1052L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1048L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(1059L, 0));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1080L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1073L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1069L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._attributes)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1098L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1091L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1087L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1116L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1109L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1105L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typeParams)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1134L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1127L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1123L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._variants)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(1141L, "RAST.Enum.Enum");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1142L, "(");
            s += Dafny.Helpers.ToString(this._attributes);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1143L, ", ");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(1144L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1145L, ", ");
            s += Dafny.Helpers.ToString(this._typeParams);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1146L, ", ");
            s += Dafny.Helpers.ToString(this._variants);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1147L, ")");
            return s;
        }
        private static readonly RAST._IEnum theDefault = create(Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Empty, Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<RAST._ITypeParam>.Empty, Dafny.Sequence<RAST._IEnumCase>.Empty);
        public static RAST._IEnum Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<RAST._IEnum> _TYPE = new Dafny.TypeDescriptor<RAST._IEnum>(RAST.Enum.Default());
        public static Dafny.TypeDescriptor<RAST._IEnum> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IEnum create(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> attributes, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._ITypeParam> typeParams, Dafny.ISequence<RAST._IEnumCase> variants)
        {
            return new Enum(attributes, name, typeParams, variants);
        }
        public static _IEnum create_Enum(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> attributes, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._ITypeParam> typeParams, Dafny.ISequence<RAST._IEnumCase> variants)
        {
            return create(attributes, name, typeParams, variants);
        }
        public bool is_Enum
        {
            get { return MutateCSharp.Schemata278.ReplaceBooleanConstant_10(1148L, true); }
        }

        public Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_attributes
        {
            get
            {
                return this._attributes;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_name
        {
            get
            {
                return this._name;
            }
        }

        public Dafny.ISequence<RAST._ITypeParam> dtor_typeParams
        {
            get
            {
                return this._typeParams;
            }
        }

        public Dafny.ISequence<RAST._IEnumCase> dtor_variants
        {
            get
            {
                return this._variants;
            }
        }

        public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind)
        {
            return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(RAST.Attribute.ToStringMultiple((this).dtor_attributes, ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1149L, "pub enum "))), (this).dtor_name), RAST.TypeParam.ToStringMultiple((this).dtor_typeParams, ind)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1150L, " {"))), RAST.__default.SeqToString<RAST._IEnumCase>((this).dtor_variants, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IEnumCase, Dafny.ISequence<Dafny.Rune>>>>((_849_ind) => ((System.Func<RAST._IEnumCase, Dafny.ISequence<Dafny.Rune>>)((_850_variant) =>
            {
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1151L, "\n")), _849_ind), RAST.__default.IND), (_850_variant)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_849_ind, RAST.__default.IND), MutateCSharp.Schemata278.ReplaceBooleanConstant_10(1152L, false)));
            })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1153L, ",")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1154L, "\n"))), ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1155L, "}")));
        }
    }

    public interface _ITypeParam
    {
        bool is_RawTypeParam { get; }
        Dafny.ISequence<Dafny.Rune> dtor_content { get; }
        Dafny.ISequence<RAST._IType> dtor_constraints { get; }

        _ITypeParam DowncastClone();
        RAST._ITypeParam AddConstraints(Dafny.ISequence<RAST._IType> constraints);
        Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
    }
    public class TypeParam : _ITypeParam
    {
        public readonly Dafny.ISequence<Dafny.Rune> _content;
        public readonly Dafny.ISequence<RAST._IType> _constraints;
        public TypeParam(Dafny.ISequence<Dafny.Rune> content, Dafny.ISequence<RAST._IType> constraints)
        {
            this._content = content;
            this._constraints = constraints;
        }
        public _ITypeParam DowncastClone()
        {
            if (this is _ITypeParam dt) { return dt; }
            return new TypeParam(_content, _constraints);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.TypeParam;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(1163L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(1157L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_25(1156L, oth, null), () => object.Equals(this._content, oth._content)), () => object.Equals(this._constraints, oth._constraints));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(1169L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1186L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1176L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1172L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(1183L, 0));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1204L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1197L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1193L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._content)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1222L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1215L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1211L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._constraints)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(1229L, "RAST.TypeParam.RawTypeParam");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1230L, "(");
            s += this._content.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(1231L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1232L, ", ");
            s += Dafny.Helpers.ToString(this._constraints);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1233L, ")");
            return s;
        }
        private static readonly RAST._ITypeParam theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<RAST._IType>.Empty);
        public static RAST._ITypeParam Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<RAST._ITypeParam> _TYPE = new Dafny.TypeDescriptor<RAST._ITypeParam>(RAST.TypeParam.Default());
        public static Dafny.TypeDescriptor<RAST._ITypeParam> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _ITypeParam create(Dafny.ISequence<Dafny.Rune> content, Dafny.ISequence<RAST._IType> constraints)
        {
            return new TypeParam(content, constraints);
        }
        public static _ITypeParam create_RawTypeParam(Dafny.ISequence<Dafny.Rune> content, Dafny.ISequence<RAST._IType> constraints)
        {
            return create(content, constraints);
        }
        public bool is_RawTypeParam
        {
            get { return MutateCSharp.Schemata278.ReplaceBooleanConstant_10(1234L, true); }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_content
        {
            get
            {
                return this._content;
            }
        }

        public Dafny.ISequence<RAST._IType> dtor_constraints
        {
            get
            {
                return this._constraints;
            }
        }

        public static Dafny.ISequence<Dafny.Rune> ToStringMultiple(Dafny.ISequence<RAST._ITypeParam> typeParams, Dafny.ISequence<Dafny.Rune> ind)
        {
            if (MutateCSharp.Schemata278.ReplaceBinExprOp_1(1239L, (new BigInteger((typeParams).Count)).Sign, MutateCSharp.Schemata278.ReplaceNumericConstant_0(1235L, 0)))
            {
                return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            }
            else
            {
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1244L, "<")), RAST.__default.SeqToString<RAST._ITypeParam>(typeParams, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._ITypeParam, Dafny.ISequence<Dafny.Rune>>>>((_851_ind) => ((System.Func<RAST._ITypeParam, Dafny.ISequence<Dafny.Rune>>)((_852_t) =>
                {
                    return (_852_t)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_851_ind, RAST.__default.IND));
                })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1245L, ", ")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1246L, ">")));
            }

            return default;
        }
        public static Dafny.ISequence<RAST._ITypeParam> AddConstraintsMultiple(Dafny.ISequence<RAST._ITypeParam> typeParams, Dafny.ISequence<RAST._IType> constraints)
        {
            Dafny.ISequence<RAST._ITypeParam> _853___accumulator = Dafny.Sequence<RAST._ITypeParam>.FromElements();
        TAIL_CALL_START:;
            if (MutateCSharp.Schemata278.ReplaceBinExprOp_1(1251L, (new BigInteger((typeParams).Count)).Sign, MutateCSharp.Schemata278.ReplaceNumericConstant_0(1247L, 0)))
            {
                return Dafny.Sequence<RAST._ITypeParam>.Concat(_853___accumulator, Dafny.Sequence<RAST._ITypeParam>.FromElements());
            }
            else
            {
                _853___accumulator = Dafny.Sequence<RAST._ITypeParam>.Concat(_853___accumulator, Dafny.Sequence<RAST._ITypeParam>.FromElements(((typeParams).Select(BigInteger.Zero)).AddConstraints(constraints)));
                Dafny.ISequence<RAST._ITypeParam> _in111 = (typeParams).Drop(BigInteger.One);
                Dafny.ISequence<RAST._IType> _in112 = constraints;
                typeParams = _in111;
                constraints = _in112;
                goto TAIL_CALL_START;
            }

            return default;
        }
        public RAST._ITypeParam AddConstraints(Dafny.ISequence<RAST._IType> constraints)
        {
            RAST._ITypeParam _854_dt__update__tmp_h0 = this;
            Dafny.ISequence<RAST._IType> _855_dt__update_hconstraints_h0 = Dafny.Sequence<RAST._IType>.Concat((this).dtor_constraints, constraints);
            return RAST.TypeParam.create((_854_dt__update__tmp_h0).dtor_content, _855_dt__update_hconstraints_h0);
        }
        public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind)
        {
            return Dafny.Sequence<Dafny.Rune>.Concat((this).dtor_content, ((MutateCSharp.Schemata278.ReplaceBinExprOp_1(1260L, (new BigInteger(((this).dtor_constraints).Count)).Sign, MutateCSharp.Schemata278.ReplaceNumericConstant_0(1256L, 0))) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1265L, ": ")), RAST.__default.SeqToString<RAST._IType>((this).dtor_constraints, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IType, Dafny.ISequence<Dafny.Rune>>>>((_856_ind) => ((System.Func<RAST._IType, Dafny.ISequence<Dafny.Rune>>)((_857_t) =>
            {
                return (_857_t)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_856_ind, RAST.__default.IND));
            })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1266L, " + ")))))));
        }
    }

    public interface _IType
    {
        bool is_SelfOwned { get; }
        bool is_U8 { get; }
        bool is_U16 { get; }
        bool is_U32 { get; }
        bool is_U64 { get; }
        bool is_U128 { get; }
        bool is_I8 { get; }
        bool is_I16 { get; }
        bool is_I32 { get; }
        bool is_I64 { get; }
        bool is_I128 { get; }
        bool is_TIdentifier { get; }
        bool is_TMemberSelect { get; }
        bool is_TypeApp { get; }
        bool is_Borrowed { get; }
        bool is_BorrowedMut { get; }
        bool is_ImplType { get; }
        bool is_DynType { get; }
        bool is_TupleType { get; }
        bool is_FnType { get; }
        bool is_IntersectionType { get; }
        Dafny.ISequence<Dafny.Rune> dtor_name { get; }
        RAST._IType dtor_base { get; }
        RAST._IType dtor_baseName { get; }
        Dafny.ISequence<RAST._IType> dtor_arguments { get; }
        RAST._IType dtor_underlying { get; }
        RAST._IType dtor_returnType { get; }
        RAST._IType dtor_left { get; }
        RAST._IType dtor_right { get; }

        _IType DowncastClone();
        Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
        RAST._IType MSel(Dafny.ISequence<Dafny.Rune> name);
        RAST._IType Apply1(RAST._IType arg);
    }
    public abstract class Type : _IType
    {
        public Type()
        {
        }
        private static readonly RAST._IType theDefault = create_SelfOwned();
        public static RAST._IType Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<RAST._IType> _TYPE = new Dafny.TypeDescriptor<RAST._IType>(RAST.Type.Default());
        public static Dafny.TypeDescriptor<RAST._IType> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IType create_SelfOwned()
        {
            return new Type_SelfOwned();
        }
        public static _IType create_U8()
        {
            return new Type_U8();
        }
        public static _IType create_U16()
        {
            return new Type_U16();
        }
        public static _IType create_U32()
        {
            return new Type_U32();
        }
        public static _IType create_U64()
        {
            return new Type_U64();
        }
        public static _IType create_U128()
        {
            return new Type_U128();
        }
        public static _IType create_I8()
        {
            return new Type_I8();
        }
        public static _IType create_I16()
        {
            return new Type_I16();
        }
        public static _IType create_I32()
        {
            return new Type_I32();
        }
        public static _IType create_I64()
        {
            return new Type_I64();
        }
        public static _IType create_I128()
        {
            return new Type_I128();
        }
        public static _IType create_TIdentifier(Dafny.ISequence<Dafny.Rune> name)
        {
            return new Type_TIdentifier(name);
        }
        public static _IType create_TMemberSelect(RAST._IType @base, Dafny.ISequence<Dafny.Rune> name)
        {
            return new Type_TMemberSelect(@base, name);
        }
        public static _IType create_TypeApp(RAST._IType baseName, Dafny.ISequence<RAST._IType> arguments)
        {
            return new Type_TypeApp(baseName, arguments);
        }
        public static _IType create_Borrowed(RAST._IType underlying)
        {
            return new Type_Borrowed(underlying);
        }
        public static _IType create_BorrowedMut(RAST._IType underlying)
        {
            return new Type_BorrowedMut(underlying);
        }
        public static _IType create_ImplType(RAST._IType underlying)
        {
            return new Type_ImplType(underlying);
        }
        public static _IType create_DynType(RAST._IType underlying)
        {
            return new Type_DynType(underlying);
        }
        public static _IType create_TupleType(Dafny.ISequence<RAST._IType> arguments)
        {
            return new Type_TupleType(arguments);
        }
        public static _IType create_FnType(Dafny.ISequence<RAST._IType> arguments, RAST._IType returnType)
        {
            return new Type_FnType(arguments, returnType);
        }
        public static _IType create_IntersectionType(RAST._IType left, RAST._IType right)
        {
            return new Type_IntersectionType(left, right);
        }
        public bool is_SelfOwned
        {
            get { return this is Type_SelfOwned; }
        }

        public bool is_U8
        {
            get { return this is Type_U8; }
        }

        public bool is_U16
        {
            get { return this is Type_U16; }
        }

        public bool is_U32
        {
            get { return this is Type_U32; }
        }

        public bool is_U64
        {
            get { return this is Type_U64; }
        }

        public bool is_U128
        {
            get { return this is Type_U128; }
        }

        public bool is_I8
        {
            get { return this is Type_I8; }
        }

        public bool is_I16
        {
            get { return this is Type_I16; }
        }

        public bool is_I32
        {
            get { return this is Type_I32; }
        }

        public bool is_I64
        {
            get { return this is Type_I64; }
        }

        public bool is_I128
        {
            get { return this is Type_I128; }
        }

        public bool is_TIdentifier
        {
            get { return this is Type_TIdentifier; }
        }

        public bool is_TMemberSelect
        {
            get { return this is Type_TMemberSelect; }
        }

        public bool is_TypeApp
        {
            get { return this is Type_TypeApp; }
        }

        public bool is_Borrowed
        {
            get { return this is Type_Borrowed; }
        }

        public bool is_BorrowedMut
        {
            get { return this is Type_BorrowedMut; }
        }

        public bool is_ImplType
        {
            get { return this is Type_ImplType; }
        }

        public bool is_DynType
        {
            get { return this is Type_DynType; }
        }

        public bool is_TupleType
        {
            get { return this is Type_TupleType; }
        }

        public bool is_FnType
        {
            get { return this is Type_FnType; }
        }

        public bool is_IntersectionType
        {
            get { return this is Type_IntersectionType; }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_name
        {
            get
            {
                var d = this;
                if (d is Type_TIdentifier) { return ((Type_TIdentifier)d)._name; }
                return ((Type_TMemberSelect)d)._name;
            }
        }

        public RAST._IType dtor_base
        {
            get
            {
                var d = this;
                return ((Type_TMemberSelect)d)._base;
            }
        }

        public RAST._IType dtor_baseName
        {
            get
            {
                var d = this;
                return ((Type_TypeApp)d)._baseName;
            }
        }

        public Dafny.ISequence<RAST._IType> dtor_arguments
        {
            get
            {
                var d = this;
                if (d is Type_TypeApp) { return ((Type_TypeApp)d)._arguments; }
                if (d is Type_TupleType) { return ((Type_TupleType)d)._arguments; }
                return ((Type_FnType)d)._arguments;
            }
        }

        public RAST._IType dtor_underlying
        {
            get
            {
                var d = this;
                if (d is Type_Borrowed) { return ((Type_Borrowed)d)._underlying; }
                if (d is Type_BorrowedMut) { return ((Type_BorrowedMut)d)._underlying; }
                if (d is Type_ImplType) { return ((Type_ImplType)d)._underlying; }
                return ((Type_DynType)d)._underlying;
            }
        }

        public RAST._IType dtor_returnType
        {
            get
            {
                var d = this;
                return ((Type_FnType)d)._returnType;
            }
        }

        public RAST._IType dtor_left
        {
            get
            {
                var d = this;
                return ((Type_IntersectionType)d)._left;
            }
        }

        public RAST._IType dtor_right
        {
            get
            {
                var d = this;
                return ((Type_IntersectionType)d)._right;
            }
        }

        public abstract _IType DowncastClone();
        public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind)
        {
            RAST._IType _source26 = this;
            if (_source26.is_SelfOwned)
            {
                return Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1267L, "Self"));
            }
            else if (_source26.is_U8)
            {
                return Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1268L, "u8"));
            }
            else if (_source26.is_U16)
            {
                return Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1269L, "u16"));
            }
            else if (_source26.is_U32)
            {
                return Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1270L, "u32"));
            }
            else if (_source26.is_U64)
            {
                return Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1271L, "u64"));
            }
            else if (_source26.is_U128)
            {
                return Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1272L, "u128"));
            }
            else if (_source26.is_I8)
            {
                return Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1273L, "i8"));
            }
            else if (_source26.is_I16)
            {
                return Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1274L, "i16"));
            }
            else if (_source26.is_I32)
            {
                return Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1275L, "i32"));
            }
            else if (_source26.is_I64)
            {
                return Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1276L, "i64"));
            }
            else if (_source26.is_I128)
            {
                return Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1277L, "i128"));
            }
            else if (_source26.is_TIdentifier)
            {
                Dafny.ISequence<Dafny.Rune> _858___mcc_h0 = _source26.dtor_name;
                Dafny.ISequence<Dafny.Rune> _859_underlying = _858___mcc_h0;
                return _859_underlying;
            }
            else if (_source26.is_TMemberSelect)
            {
                RAST._IType _860___mcc_h1 = _source26.dtor_base;
                Dafny.ISequence<Dafny.Rune> _861___mcc_h2 = _source26.dtor_name;
                Dafny.ISequence<Dafny.Rune> _862_name = _861___mcc_h2;
                RAST._IType _863_underlying = _860___mcc_h1;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat((_863_underlying)._ToString(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1278L, "::"))), _862_name);
            }
            else if (_source26.is_TypeApp)
            {
                RAST._IType _864___mcc_h3 = _source26.dtor_baseName;
                Dafny.ISequence<RAST._IType> _865___mcc_h4 = _source26.dtor_arguments;
                Dafny.ISequence<RAST._IType> _866_args = _865___mcc_h4;
                RAST._IType _867_base = _864___mcc_h3;
                return Dafny.Sequence<Dafny.Rune>.Concat((_867_base)._ToString(ind), (((_866_args).Equals(Dafny.Sequence<RAST._IType>.FromElements())) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1279L, "<")), RAST.__default.SeqToString<RAST._IType>(_866_args, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IType, Dafny.ISequence<Dafny.Rune>>>>((_868_ind) => ((System.Func<RAST._IType, Dafny.ISequence<Dafny.Rune>>)((_869_arg) =>
                {
                    return (_869_arg)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_868_ind, RAST.__default.IND));
                })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1280L, ", ")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1281L, ">"))))));
            }
            else if (_source26.is_Borrowed)
            {
                RAST._IType _870___mcc_h5 = _source26.dtor_underlying;
                RAST._IType _871_underlying = _870___mcc_h5;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1282L, "&")), (_871_underlying)._ToString(ind));
            }
            else if (_source26.is_BorrowedMut)
            {
                RAST._IType _872___mcc_h6 = _source26.dtor_underlying;
                RAST._IType _873_underlying = _872___mcc_h6;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1283L, "&mut ")), (_873_underlying)._ToString(ind));
            }
            else if (_source26.is_ImplType)
            {
                RAST._IType _874___mcc_h7 = _source26.dtor_underlying;
                RAST._IType _875_underlying = _874___mcc_h7;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1284L, "impl ")), (_875_underlying)._ToString(ind));
            }
            else if (_source26.is_DynType)
            {
                RAST._IType _876___mcc_h8 = _source26.dtor_underlying;
                RAST._IType _877_underlying = _876___mcc_h8;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1285L, "dyn ")), (_877_underlying)._ToString(ind));
            }
            else if (_source26.is_TupleType)
            {
                Dafny.ISequence<RAST._IType> _878___mcc_h9 = _source26.dtor_arguments;
                Dafny.ISequence<RAST._IType> _879_args = _878___mcc_h9;
                if ((_879_args).Equals(Dafny.Sequence<RAST._IType>.FromElements()))
                {
                    return Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1286L, "()"));
                }
                else
                {
                    return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1287L, "(")), RAST.__default.SeqToString<RAST._IType>(_879_args, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IType, Dafny.ISequence<Dafny.Rune>>>>((_880_ind) => ((System.Func<RAST._IType, Dafny.ISequence<Dafny.Rune>>)((_881_arg) =>
                    {
                        return (_881_arg)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_880_ind, RAST.__default.IND));
                    })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1288L, ", ")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1289L, ")")));
                }
            }
            else if (_source26.is_FnType)
            {
                Dafny.ISequence<RAST._IType> _882___mcc_h10 = _source26.dtor_arguments;
                RAST._IType _883___mcc_h11 = _source26.dtor_returnType;
                RAST._IType _884_returnType = _883___mcc_h11;
                Dafny.ISequence<RAST._IType> _885_arguments = _882___mcc_h10;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1290L, "::std::ops::Fn(")), RAST.__default.SeqToString<RAST._IType>(_885_arguments, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IType, Dafny.ISequence<Dafny.Rune>>>>((_886_ind) => ((System.Func<RAST._IType, Dafny.ISequence<Dafny.Rune>>)((_887_arg) =>
                {
                    return (_887_arg)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_886_ind, RAST.__default.IND));
                })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1291L, ", ")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1292L, ") -> "))), (_884_returnType)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND)));
            }
            else
            {
                RAST._IType _888___mcc_h12 = _source26.dtor_left;
                RAST._IType _889___mcc_h13 = _source26.dtor_right;
                RAST._IType _890_right = _889___mcc_h13;
                RAST._IType _891_left = _888___mcc_h12;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat((_891_left)._ToString(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(1293L, " + "))), (_890_right)._ToString(ind));
            }

            return default;
        }
        public RAST._IType MSel(Dafny.ISequence<Dafny.Rune> name)
        {
            return RAST.Type.create_TMemberSelect(this, name);
        }
        public RAST._IType Apply1(RAST._IType arg)
        {
            return RAST.Type.create_TypeApp(this, Dafny.Sequence<RAST._IType>.FromElements(arg));
        }
    }
    public class Type_SelfOwned : Type
    {
        public Type_SelfOwned() : base()
        {
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_SelfOwned();
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Type_SelfOwned;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_26(1294L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(1295L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1312L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1302L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1298L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(1309L, 0));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(1319L, "RAST.Type.SelfOwned");
            return s;
        }
    }
    public class Type_U8 : Type
    {
        public Type_U8() : base()
        {
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_U8();
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Type_U8;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_27(1320L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(1321L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1338L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1328L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1324L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(1335L, 1));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(1345L, "RAST.Type.U8");
            return s;
        }
    }
    public class Type_U16 : Type
    {
        public Type_U16() : base()
        {
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_U16();
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Type_U16;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_28(1346L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(1347L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1364L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1354L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1350L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(1361L, 2));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(1371L, "RAST.Type.U16");
            return s;
        }
    }
    public class Type_U32 : Type
    {
        public Type_U32() : base()
        {
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_U32();
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Type_U32;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_29(1372L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(1373L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1390L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1380L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1376L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(1387L, 3));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(1397L, "RAST.Type.U32");
            return s;
        }
    }
    public class Type_U64 : Type
    {
        public Type_U64() : base()
        {
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_U64();
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Type_U64;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_30(1398L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(1399L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1416L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1406L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1402L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(1413L, 4));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(1423L, "RAST.Type.U64");
            return s;
        }
    }
    public class Type_U128 : Type
    {
        public Type_U128() : base()
        {
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_U128();
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Type_U128;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_31(1424L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(1425L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1442L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1432L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1428L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(1439L, 5));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(1449L, "RAST.Type.U128");
            return s;
        }
    }
    public class Type_I8 : Type
    {
        public Type_I8() : base()
        {
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_I8();
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Type_I8;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_32(1450L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(1451L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1468L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1458L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1454L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(1465L, 6));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(1475L, "RAST.Type.I8");
            return s;
        }
    }
    public class Type_I16 : Type
    {
        public Type_I16() : base()
        {
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_I16();
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Type_I16;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_33(1476L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(1477L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1494L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1484L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1480L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(1491L, 7));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(1501L, "RAST.Type.I16");
            return s;
        }
    }
    public class Type_I32 : Type
    {
        public Type_I32() : base()
        {
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_I32();
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Type_I32;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_34(1502L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(1503L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1520L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1510L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1506L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(1517L, 8));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(1527L, "RAST.Type.I32");
            return s;
        }
    }
    public class Type_I64 : Type
    {
        public Type_I64() : base()
        {
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_I64();
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Type_I64;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_35(1528L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(1529L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1546L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1536L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1532L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(1543L, 9));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(1553L, "RAST.Type.I64");
            return s;
        }
    }
    public class Type_I128 : Type
    {
        public Type_I128() : base()
        {
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_I128();
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Type_I128;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_36(1554L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(1555L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1572L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1562L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1558L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(1569L, 10));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(1579L, "RAST.Type.I128");
            return s;
        }
    }
    public class Type_TIdentifier : Type
    {
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public Type_TIdentifier(Dafny.ISequence<Dafny.Rune> name) : base()
        {
            this._name = name;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_TIdentifier(_name);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Type_TIdentifier;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(1581L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_37(1580L, oth, null), () => object.Equals(this._name, oth._name));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(1587L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1604L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1594L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1590L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(1601L, 11));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1622L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1615L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1611L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(1629L, "RAST.Type.TIdentifier");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1630L, "(");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(1631L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1632L, ")");
            return s;
        }
    }
    public class Type_TMemberSelect : Type
    {
        public readonly RAST._IType _base;
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public Type_TMemberSelect(RAST._IType @base, Dafny.ISequence<Dafny.Rune> name) : base()
        {
            this._base = @base;
            this._name = name;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_TMemberSelect(_base, _name);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Type_TMemberSelect;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(1640L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(1634L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_38(1633L, oth, null), () => object.Equals(this._base, oth._base)), () => object.Equals(this._name, oth._name));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(1646L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1663L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1653L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1649L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(1660L, 12));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1681L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1674L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1670L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._base)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1699L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1692L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1688L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(1706L, "RAST.Type.TMemberSelect");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1707L, "(");
            s += Dafny.Helpers.ToString(this._base);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1708L, ", ");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(1709L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1710L, ")");
            return s;
        }
    }
    public class Type_TypeApp : Type
    {
        public readonly RAST._IType _baseName;
        public readonly Dafny.ISequence<RAST._IType> _arguments;
        public Type_TypeApp(RAST._IType baseName, Dafny.ISequence<RAST._IType> arguments) : base()
        {
            this._baseName = baseName;
            this._arguments = arguments;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_TypeApp(_baseName, _arguments);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Type_TypeApp;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(1718L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(1712L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_39(1711L, oth, null), () => object.Equals(this._baseName, oth._baseName)), () => object.Equals(this._arguments, oth._arguments));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(1724L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1741L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1731L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1727L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(1738L, 13));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1759L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1752L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1748L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._baseName)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1777L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1770L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1766L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._arguments)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(1784L, "RAST.Type.TypeApp");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1785L, "(");
            s += Dafny.Helpers.ToString(this._baseName);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1786L, ", ");
            s += Dafny.Helpers.ToString(this._arguments);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1787L, ")");
            return s;
        }
    }
    public class Type_Borrowed : Type
    {
        public readonly RAST._IType _underlying;
        public Type_Borrowed(RAST._IType underlying) : base()
        {
            this._underlying = underlying;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_Borrowed(_underlying);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Type_Borrowed;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(1789L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_40(1788L, oth, null), () => object.Equals(this._underlying, oth._underlying));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(1795L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1812L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1802L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1798L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(1809L, 14));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1830L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1823L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1819L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._underlying)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(1837L, "RAST.Type.Borrowed");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1838L, "(");
            s += Dafny.Helpers.ToString(this._underlying);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1839L, ")");
            return s;
        }
    }
    public class Type_BorrowedMut : Type
    {
        public readonly RAST._IType _underlying;
        public Type_BorrowedMut(RAST._IType underlying) : base()
        {
            this._underlying = underlying;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_BorrowedMut(_underlying);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Type_BorrowedMut;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(1841L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_41(1840L, oth, null), () => object.Equals(this._underlying, oth._underlying));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(1847L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1864L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1854L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1850L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(1861L, 15));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1882L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1875L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1871L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._underlying)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(1889L, "RAST.Type.BorrowedMut");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1890L, "(");
            s += Dafny.Helpers.ToString(this._underlying);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1891L, ")");
            return s;
        }
    }
    public class Type_ImplType : Type
    {
        public readonly RAST._IType _underlying;
        public Type_ImplType(RAST._IType underlying) : base()
        {
            this._underlying = underlying;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_ImplType(_underlying);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Type_ImplType;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(1893L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_42(1892L, oth, null), () => object.Equals(this._underlying, oth._underlying));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(1899L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1916L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1906L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1902L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(1913L, 16));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1934L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1927L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1923L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._underlying)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(1941L, "RAST.Type.ImplType");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1942L, "(");
            s += Dafny.Helpers.ToString(this._underlying);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1943L, ")");
            return s;
        }
    }
    public class Type_DynType : Type
    {
        public readonly RAST._IType _underlying;
        public Type_DynType(RAST._IType underlying) : base()
        {
            this._underlying = underlying;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_DynType(_underlying);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Type_DynType;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(1945L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_43(1944L, oth, null), () => object.Equals(this._underlying, oth._underlying));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(1951L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1968L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1958L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1954L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(1965L, 17));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(1986L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(1979L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(1975L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._underlying)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(1993L, "RAST.Type.DynType");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1994L, "(");
            s += Dafny.Helpers.ToString(this._underlying);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(1995L, ")");
            return s;
        }
    }
    public class Type_TupleType : Type
    {
        public readonly Dafny.ISequence<RAST._IType> _arguments;
        public Type_TupleType(Dafny.ISequence<RAST._IType> arguments) : base()
        {
            this._arguments = arguments;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_TupleType(_arguments);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Type_TupleType;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(1997L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_44(1996L, oth, null), () => object.Equals(this._arguments, oth._arguments));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(2003L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2020L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2010L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2006L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(2017L, 18));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2038L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2031L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2027L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._arguments)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(2045L, "RAST.Type.TupleType");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2046L, "(");
            s += Dafny.Helpers.ToString(this._arguments);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2047L, ")");
            return s;
        }
    }
    public class Type_FnType : Type
    {
        public readonly Dafny.ISequence<RAST._IType> _arguments;
        public readonly RAST._IType _returnType;
        public Type_FnType(Dafny.ISequence<RAST._IType> arguments, RAST._IType returnType) : base()
        {
            this._arguments = arguments;
            this._returnType = returnType;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_FnType(_arguments, _returnType);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Type_FnType;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(2055L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(2049L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_45(2048L, oth, null), () => object.Equals(this._arguments, oth._arguments)), () => object.Equals(this._returnType, oth._returnType));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(2061L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2078L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2068L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2064L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(2075L, 19));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2096L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2089L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2085L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._arguments)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2114L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2107L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2103L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._returnType)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(2121L, "RAST.Type.FnType");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2122L, "(");
            s += Dafny.Helpers.ToString(this._arguments);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2123L, ", ");
            s += Dafny.Helpers.ToString(this._returnType);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2124L, ")");
            return s;
        }
    }
    public class Type_IntersectionType : Type
    {
        public readonly RAST._IType _left;
        public readonly RAST._IType _right;
        public Type_IntersectionType(RAST._IType left, RAST._IType right) : base()
        {
            this._left = left;
            this._right = right;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_IntersectionType(_left, _right);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Type_IntersectionType;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(2132L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(2126L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_46(2125L, oth, null), () => object.Equals(this._left, oth._left)), () => object.Equals(this._right, oth._right));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(2138L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2155L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2145L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2141L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(2152L, 20));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2173L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2166L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2162L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._left)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2191L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2184L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2180L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._right)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(2198L, "RAST.Type.IntersectionType");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2199L, "(");
            s += Dafny.Helpers.ToString(this._left);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2200L, ", ");
            s += Dafny.Helpers.ToString(this._right);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2201L, ")");
            return s;
        }
    }

    public interface _ITrait
    {
        bool is_Trait { get; }
        Dafny.ISequence<RAST._ITypeParam> dtor_typeParams { get; }
        RAST._IType dtor_tpe { get; }
        Dafny.ISequence<Dafny.Rune> dtor_where { get; }
        Dafny.ISequence<RAST._IImplMember> dtor_body { get; }

        _ITrait DowncastClone();
        Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
    }
    public class Trait : _ITrait
    {
        public readonly Dafny.ISequence<RAST._ITypeParam> _typeParams;
        public readonly RAST._IType _tpe;
        public readonly Dafny.ISequence<Dafny.Rune> _where;
        public readonly Dafny.ISequence<RAST._IImplMember> _body;
        public Trait(Dafny.ISequence<RAST._ITypeParam> typeParams, RAST._IType tpe, Dafny.ISequence<Dafny.Rune> @where, Dafny.ISequence<RAST._IImplMember> body)
        {
            this._typeParams = typeParams;
            this._tpe = tpe;
            this._where = @where;
            this._body = body;
        }
        public _ITrait DowncastClone()
        {
            if (this is _ITrait dt) { return dt; }
            return new Trait(_typeParams, _tpe, _where, _body);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Trait;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(2221L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(2215L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(2209L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(2203L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_47(2202L, oth, null), () => object.Equals(this._typeParams, oth._typeParams)), () => object.Equals(this._tpe, oth._tpe)), () => object.Equals(this._where, oth._where)), () => object.Equals(this._body, oth._body));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(2227L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2244L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2234L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2230L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(2241L, 0));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2262L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2255L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2251L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typeParams)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2280L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2273L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2269L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._tpe)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2298L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2291L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2287L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._where)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2316L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2309L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2305L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._body)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(2323L, "RAST.Trait.Trait");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2324L, "(");
            s += Dafny.Helpers.ToString(this._typeParams);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2325L, ", ");
            s += Dafny.Helpers.ToString(this._tpe);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2326L, ", ");
            s += this._where.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(2327L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2328L, ", ");
            s += Dafny.Helpers.ToString(this._body);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2329L, ")");
            return s;
        }
        private static readonly RAST._ITrait theDefault = create(Dafny.Sequence<RAST._ITypeParam>.Empty, RAST.Type.Default(), Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<RAST._IImplMember>.Empty);
        public static RAST._ITrait Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<RAST._ITrait> _TYPE = new Dafny.TypeDescriptor<RAST._ITrait>(RAST.Trait.Default());
        public static Dafny.TypeDescriptor<RAST._ITrait> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _ITrait create(Dafny.ISequence<RAST._ITypeParam> typeParams, RAST._IType tpe, Dafny.ISequence<Dafny.Rune> @where, Dafny.ISequence<RAST._IImplMember> body)
        {
            return new Trait(typeParams, tpe, @where, body);
        }
        public static _ITrait create_Trait(Dafny.ISequence<RAST._ITypeParam> typeParams, RAST._IType tpe, Dafny.ISequence<Dafny.Rune> @where, Dafny.ISequence<RAST._IImplMember> body)
        {
            return create(typeParams, tpe, @where, body);
        }
        public bool is_Trait
        {
            get { return MutateCSharp.Schemata278.ReplaceBooleanConstant_10(2330L, true); }
        }

        public Dafny.ISequence<RAST._ITypeParam> dtor_typeParams
        {
            get
            {
                return this._typeParams;
            }
        }

        public RAST._IType dtor_tpe
        {
            get
            {
                return this._tpe;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_where
        {
            get
            {
                return this._where;
            }
        }

        public Dafny.ISequence<RAST._IImplMember> dtor_body
        {
            get
            {
                return this._body;
            }
        }

        public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind)
        {
            return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(2331L, "trait ")), RAST.TypeParam.ToStringMultiple((this).dtor_typeParams, ind)), ((this).dtor_tpe)._ToString(ind)), ((!((this).dtor_where).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(2332L, "\n")), ind), RAST.__default.IND), (this).dtor_where)) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(2333L, " {"))), RAST.__default.SeqToString<RAST._IImplMember>((this).dtor_body, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IImplMember, Dafny.ISequence<Dafny.Rune>>>>((_892_ind) => ((System.Func<RAST._IImplMember, Dafny.ISequence<Dafny.Rune>>)((_893_member) =>
            {
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(2334L, "\n")), _892_ind), RAST.__default.IND), (_893_member)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_892_ind, RAST.__default.IND)));
            })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), ((MutateCSharp.Schemata278.ReplaceBinExprOp_1(2339L, (new BigInteger(((this).dtor_body).Count)).Sign, MutateCSharp.Schemata278.ReplaceNumericConstant_0(2335L, 0))) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(2344L, "\n")), ind)))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(2345L, "}")));
        }
    }

    public interface _IImpl
    {
        bool is_ImplFor { get; }
        bool is_Impl { get; }
        Dafny.ISequence<RAST._ITypeParam> dtor_typeParams { get; }
        RAST._IType dtor_tpe { get; }
        RAST._IType dtor_forType { get; }
        Dafny.ISequence<Dafny.Rune> dtor_where { get; }
        Dafny.ISequence<RAST._IImplMember> dtor_body { get; }

        _IImpl DowncastClone();
        Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
    }
    public abstract class Impl : _IImpl
    {
        public Impl()
        {
        }
        private static readonly RAST._IImpl theDefault = create_ImplFor(Dafny.Sequence<RAST._ITypeParam>.Empty, RAST.Type.Default(), RAST.Type.Default(), Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<RAST._IImplMember>.Empty);
        public static RAST._IImpl Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<RAST._IImpl> _TYPE = new Dafny.TypeDescriptor<RAST._IImpl>(RAST.Impl.Default());
        public static Dafny.TypeDescriptor<RAST._IImpl> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IImpl create_ImplFor(Dafny.ISequence<RAST._ITypeParam> typeParams, RAST._IType tpe, RAST._IType forType, Dafny.ISequence<Dafny.Rune> @where, Dafny.ISequence<RAST._IImplMember> body)
        {
            return new Impl_ImplFor(typeParams, tpe, forType, @where, body);
        }
        public static _IImpl create_Impl(Dafny.ISequence<RAST._ITypeParam> typeParams, RAST._IType tpe, Dafny.ISequence<Dafny.Rune> @where, Dafny.ISequence<RAST._IImplMember> body)
        {
            return new Impl_Impl(typeParams, tpe, @where, body);
        }
        public bool is_ImplFor
        {
            get { return this is Impl_ImplFor; }
        }

        public bool is_Impl
        {
            get { return this is Impl_Impl; }
        }

        public Dafny.ISequence<RAST._ITypeParam> dtor_typeParams
        {
            get
            {
                var d = this;
                if (d is Impl_ImplFor) { return ((Impl_ImplFor)d)._typeParams; }
                return ((Impl_Impl)d)._typeParams;
            }
        }

        public RAST._IType dtor_tpe
        {
            get
            {
                var d = this;
                if (d is Impl_ImplFor) { return ((Impl_ImplFor)d)._tpe; }
                return ((Impl_Impl)d)._tpe;
            }
        }

        public RAST._IType dtor_forType
        {
            get
            {
                var d = this;
                return ((Impl_ImplFor)d)._forType;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_where
        {
            get
            {
                var d = this;
                if (d is Impl_ImplFor) { return ((Impl_ImplFor)d)._where; }
                return ((Impl_Impl)d)._where;
            }
        }

        public Dafny.ISequence<RAST._IImplMember> dtor_body
        {
            get
            {
                var d = this;
                if (d is Impl_ImplFor) { return ((Impl_ImplFor)d)._body; }
                return ((Impl_Impl)d)._body;
            }
        }

        public abstract _IImpl DowncastClone();
        public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind)
        {
            return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(2346L, "impl ")), RAST.TypeParam.ToStringMultiple((this).dtor_typeParams, ind)), ((this).dtor_tpe)._ToString(ind)), (((this).is_ImplFor) ? (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(2347L, " for ")), ((this).dtor_forType)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND)))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), ((!((this).dtor_where).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(2348L, "\n")), ind), RAST.__default.IND), (this).dtor_where)) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(2349L, " {"))), RAST.__default.SeqToString<RAST._IImplMember>((this).dtor_body, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IImplMember, Dafny.ISequence<Dafny.Rune>>>>((_894_ind) => ((System.Func<RAST._IImplMember, Dafny.ISequence<Dafny.Rune>>)((_895_member) =>
            {
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(2350L, "\n")), _894_ind), RAST.__default.IND), (_895_member)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_894_ind, RAST.__default.IND)));
            })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), ((MutateCSharp.Schemata278.ReplaceBinExprOp_1(2355L, (new BigInteger(((this).dtor_body).Count)).Sign, MutateCSharp.Schemata278.ReplaceNumericConstant_0(2351L, 0))) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(2360L, "\n")), ind)))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(2361L, "}")));
        }
    }
    public class Impl_ImplFor : Impl
    {
        public readonly Dafny.ISequence<RAST._ITypeParam> _typeParams;
        public readonly RAST._IType _tpe;
        public readonly RAST._IType _forType;
        public readonly Dafny.ISequence<Dafny.Rune> _where;
        public readonly Dafny.ISequence<RAST._IImplMember> _body;
        public Impl_ImplFor(Dafny.ISequence<RAST._ITypeParam> typeParams, RAST._IType tpe, RAST._IType forType, Dafny.ISequence<Dafny.Rune> @where, Dafny.ISequence<RAST._IImplMember> body) : base()
        {
            this._typeParams = typeParams;
            this._tpe = tpe;
            this._forType = forType;
            this._where = @where;
            this._body = body;
        }
        public override _IImpl DowncastClone()
        {
            if (this is _IImpl dt) { return dt; }
            return new Impl_ImplFor(_typeParams, _tpe, _forType, _where, _body);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Impl_ImplFor;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(2387L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(2381L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(2375L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(2369L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(2363L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_48(2362L, oth, null), () => object.Equals(this._typeParams, oth._typeParams)), () => object.Equals(this._tpe, oth._tpe)), () => object.Equals(this._forType, oth._forType)), () => object.Equals(this._where, oth._where)), () => object.Equals(this._body, oth._body));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(2393L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2410L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2400L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2396L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(2407L, 0));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2428L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2421L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2417L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typeParams)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2446L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2439L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2435L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._tpe)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2464L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2457L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2453L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._forType)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2482L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2475L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2471L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._where)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2500L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2493L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2489L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._body)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(2507L, "RAST.Impl.ImplFor");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2508L, "(");
            s += Dafny.Helpers.ToString(this._typeParams);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2509L, ", ");
            s += Dafny.Helpers.ToString(this._tpe);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2510L, ", ");
            s += Dafny.Helpers.ToString(this._forType);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2511L, ", ");
            s += this._where.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(2512L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2513L, ", ");
            s += Dafny.Helpers.ToString(this._body);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2514L, ")");
            return s;
        }
    }
    public class Impl_Impl : Impl
    {
        public readonly Dafny.ISequence<RAST._ITypeParam> _typeParams;
        public readonly RAST._IType _tpe;
        public readonly Dafny.ISequence<Dafny.Rune> _where;
        public readonly Dafny.ISequence<RAST._IImplMember> _body;
        public Impl_Impl(Dafny.ISequence<RAST._ITypeParam> typeParams, RAST._IType tpe, Dafny.ISequence<Dafny.Rune> @where, Dafny.ISequence<RAST._IImplMember> body) : base()
        {
            this._typeParams = typeParams;
            this._tpe = tpe;
            this._where = @where;
            this._body = body;
        }
        public override _IImpl DowncastClone()
        {
            if (this is _IImpl dt) { return dt; }
            return new Impl_Impl(_typeParams, _tpe, _where, _body);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Impl_Impl;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(2534L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(2528L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(2522L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(2516L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_49(2515L, oth, null), () => object.Equals(this._typeParams, oth._typeParams)), () => object.Equals(this._tpe, oth._tpe)), () => object.Equals(this._where, oth._where)), () => object.Equals(this._body, oth._body));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(2540L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2557L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2547L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2543L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(2554L, 1));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2575L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2568L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2564L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typeParams)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2593L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2586L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2582L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._tpe)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2611L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2604L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2600L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._where)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2629L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2622L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2618L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._body)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(2636L, "RAST.Impl.Impl");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2637L, "(");
            s += Dafny.Helpers.ToString(this._typeParams);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2638L, ", ");
            s += Dafny.Helpers.ToString(this._tpe);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2639L, ", ");
            s += this._where.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(2640L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2641L, ", ");
            s += Dafny.Helpers.ToString(this._body);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2642L, ")");
            return s;
        }
    }

    public interface _IImplMember
    {
        bool is_RawImplMember { get; }
        bool is_FnDecl { get; }
        Dafny.ISequence<Dafny.Rune> dtor_content { get; }
        RAST._IVisibility dtor_pub { get; }
        RAST._IFn dtor_fun { get; }

        _IImplMember DowncastClone();
        Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
    }
    public abstract class ImplMember : _IImplMember
    {
        public ImplMember()
        {
        }
        private static readonly RAST._IImplMember theDefault = create_RawImplMember(Dafny.Sequence<Dafny.Rune>.Empty);
        public static RAST._IImplMember Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<RAST._IImplMember> _TYPE = new Dafny.TypeDescriptor<RAST._IImplMember>(RAST.ImplMember.Default());
        public static Dafny.TypeDescriptor<RAST._IImplMember> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IImplMember create_RawImplMember(Dafny.ISequence<Dafny.Rune> content)
        {
            return new ImplMember_RawImplMember(content);
        }
        public static _IImplMember create_FnDecl(RAST._IVisibility pub, RAST._IFn fun)
        {
            return new ImplMember_FnDecl(pub, fun);
        }
        public bool is_RawImplMember
        {
            get { return this is ImplMember_RawImplMember; }
        }

        public bool is_FnDecl
        {
            get { return this is ImplMember_FnDecl; }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_content
        {
            get
            {
                var d = this;
                return ((ImplMember_RawImplMember)d)._content;
            }
        }

        public RAST._IVisibility dtor_pub
        {
            get
            {
                var d = this;
                return ((ImplMember_FnDecl)d)._pub;
            }
        }

        public RAST._IFn dtor_fun
        {
            get
            {
                var d = this;
                return ((ImplMember_FnDecl)d)._fun;
            }
        }

        public abstract _IImplMember DowncastClone();
        public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind)
        {
            if ((this).is_FnDecl)
            {
                return Dafny.Sequence<Dafny.Rune>.Concat(((object.Equals((this).dtor_pub, RAST.Visibility.create_PUB())) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(2643L, "pub "))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), ((this).dtor_fun)._ToString(ind));
            }
            else
            {
                return (this).dtor_content;
            }

            return default;
        }
    }
    public class ImplMember_RawImplMember : ImplMember
    {
        public readonly Dafny.ISequence<Dafny.Rune> _content;
        public ImplMember_RawImplMember(Dafny.ISequence<Dafny.Rune> content) : base()
        {
            this._content = content;
        }
        public override _IImplMember DowncastClone()
        {
            if (this is _IImplMember dt) { return dt; }
            return new ImplMember_RawImplMember(_content);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.ImplMember_RawImplMember;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(2645L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_50(2644L, oth, null), () => object.Equals(this._content, oth._content));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(2651L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2668L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2658L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2654L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(2665L, 0));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2686L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2679L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2675L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._content)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(2693L, "RAST.ImplMember.RawImplMember");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2694L, "(");
            s += this._content.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(2695L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2696L, ")");
            return s;
        }
    }
    public class ImplMember_FnDecl : ImplMember
    {
        public readonly RAST._IVisibility _pub;
        public readonly RAST._IFn _fun;
        public ImplMember_FnDecl(RAST._IVisibility pub, RAST._IFn fun) : base()
        {
            this._pub = pub;
            this._fun = fun;
        }
        public override _IImplMember DowncastClone()
        {
            if (this is _IImplMember dt) { return dt; }
            return new ImplMember_FnDecl(_pub, _fun);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.ImplMember_FnDecl;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(2704L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(2698L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_51(2697L, oth, null), () => object.Equals(this._pub, oth._pub)), () => object.Equals(this._fun, oth._fun));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(2710L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2727L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2717L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2713L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(2724L, 1));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2745L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2738L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2734L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._pub)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2763L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2756L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2752L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._fun)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(2770L, "RAST.ImplMember.FnDecl");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2771L, "(");
            s += Dafny.Helpers.ToString(this._pub);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2772L, ", ");
            s += Dafny.Helpers.ToString(this._fun);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2773L, ")");
            return s;
        }
    }

    public interface _IVisibility
    {
        bool is_PUB { get; }
        bool is_PRIV { get; }

        _IVisibility DowncastClone();
    }
    public abstract class Visibility : _IVisibility
    {
        public Visibility()
        {
        }
        private static readonly RAST._IVisibility theDefault = create_PUB();
        public static RAST._IVisibility Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<RAST._IVisibility> _TYPE = new Dafny.TypeDescriptor<RAST._IVisibility>(RAST.Visibility.Default());
        public static Dafny.TypeDescriptor<RAST._IVisibility> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IVisibility create_PUB()
        {
            return new Visibility_PUB();
        }
        public static _IVisibility create_PRIV()
        {
            return new Visibility_PRIV();
        }
        public bool is_PUB
        {
            get { return this is Visibility_PUB; }
        }

        public bool is_PRIV
        {
            get { return this is Visibility_PRIV; }
        }

        public static System.Collections.Generic.IEnumerable<_IVisibility> AllSingletonConstructors
        {
            get
            {
                yield return Visibility.create_PUB();
                yield return Visibility.create_PRIV();
            }
        }

        public abstract _IVisibility DowncastClone();
    }
    public class Visibility_PUB : Visibility
    {
        public Visibility_PUB() : base()
        {
        }
        public override _IVisibility DowncastClone()
        {
            if (this is _IVisibility dt) { return dt; }
            return new Visibility_PUB();
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Visibility_PUB;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_52(2774L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(2775L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2792L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2782L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2778L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(2789L, 0));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(2799L, "RAST.Visibility.PUB");
            return s;
        }
    }
    public class Visibility_PRIV : Visibility
    {
        public Visibility_PRIV() : base()
        {
        }
        public override _IVisibility DowncastClone()
        {
            if (this is _IVisibility dt) { return dt; }
            return new Visibility_PRIV();
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Visibility_PRIV;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_53(2800L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(2801L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2818L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2808L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2804L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(2815L, 1));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(2825L, "RAST.Visibility.PRIV");
            return s;
        }
    }

    public interface _IFormal
    {
        bool is_Formal { get; }
        Dafny.ISequence<Dafny.Rune> dtor_name { get; }
        RAST._IType dtor_tpe { get; }

        _IFormal DowncastClone();
        Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
    }
    public class Formal : _IFormal
    {
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public readonly RAST._IType _tpe;
        public Formal(Dafny.ISequence<Dafny.Rune> name, RAST._IType tpe)
        {
            this._name = name;
            this._tpe = tpe;
        }
        public _IFormal DowncastClone()
        {
            if (this is _IFormal dt) { return dt; }
            return new Formal(_name, _tpe);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Formal;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(2833L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(2827L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_54(2826L, oth, null), () => object.Equals(this._name, oth._name)), () => object.Equals(this._tpe, oth._tpe));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(2839L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2856L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2846L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2842L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(2853L, 0));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2874L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2867L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2863L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2892L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2885L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2881L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._tpe)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(2899L, "RAST.Formal.Formal");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2900L, "(");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(2901L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2902L, ", ");
            s += Dafny.Helpers.ToString(this._tpe);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2903L, ")");
            return s;
        }
        private static readonly RAST._IFormal theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, RAST.Type.Default());
        public static RAST._IFormal Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<RAST._IFormal> _TYPE = new Dafny.TypeDescriptor<RAST._IFormal>(RAST.Formal.Default());
        public static Dafny.TypeDescriptor<RAST._IFormal> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IFormal create(Dafny.ISequence<Dafny.Rune> name, RAST._IType tpe)
        {
            return new Formal(name, tpe);
        }
        public static _IFormal create_Formal(Dafny.ISequence<Dafny.Rune> name, RAST._IType tpe)
        {
            return create(name, tpe);
        }
        public bool is_Formal
        {
            get { return MutateCSharp.Schemata278.ReplaceBooleanConstant_10(2904L, true); }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_name
        {
            get
            {
                return this._name;
            }
        }

        public RAST._IType dtor_tpe
        {
            get
            {
                return this._tpe;
            }
        }

        public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind)
        {
            if (MutateCSharp.Schemata278.ReplaceBinExprOp_5(2906L, () => (((this).dtor_name).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(2905L, "self")))), () => (((this).dtor_tpe).is_SelfOwned)))
            {
                return (this).dtor_name;
            }
            else if (MutateCSharp.Schemata278.ReplaceBinExprOp_5(2913L, () => (((this).dtor_name).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(2912L, "&self")))), () => (object.Equals((this).dtor_tpe, RAST.Type.create_Borrowed(RAST.Type.create_SelfOwned())))))
            {
                return (this).dtor_name;
            }
            else if (MutateCSharp.Schemata278.ReplaceBinExprOp_5(2920L, () => (((this).dtor_name).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(2919L, "&mut self")))), () => (object.Equals((this).dtor_tpe, RAST.Type.create_Borrowed(RAST.__default.SelfMut)))))
            {
                return (this).dtor_name;
            }
            else
            {
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat((this).dtor_name, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(2926L, ": "))), ((this).dtor_tpe)._ToString(ind));
            }

            return default;
        }
        public static RAST._IFormal self
        {
            get
            {
                return RAST.Formal.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(2927L, "&self")), RAST.__default.Self);
            }
        }

        public static RAST._IFormal selfOwned
        {
            get
            {
                return RAST.Formal.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(2928L, "self")), RAST.Type.create_SelfOwned());
            }
        }

        public static RAST._IFormal selfMut
        {
            get
            {
                return RAST.Formal.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(2929L, "&mut self")), RAST.__default.SelfMut);
            }
        }
    }

    public interface _IPattern
    {
        bool is_RawPattern { get; }
        Dafny.ISequence<Dafny.Rune> dtor_content { get; }
    }
    public class Pattern : _IPattern
    {
        public readonly Dafny.ISequence<Dafny.Rune> _content;
        public Pattern(Dafny.ISequence<Dafny.Rune> content)
        {
            this._content = content;
        }
        public static Dafny.ISequence<Dafny.Rune> DowncastClone(Dafny.ISequence<Dafny.Rune> _this)
        {
            return _this;
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Pattern;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(2931L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_55(2930L, oth, null), () => object.Equals(this._content, oth._content));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(2937L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2954L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2944L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2940L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(2951L, 0));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(2972L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(2965L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(2961L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._content)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(2979L, "RAST.Pattern.RawPattern");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2980L, "(");
            s += this._content.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(2981L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(2982L, ")");
            return s;
        }
        private static readonly Dafny.ISequence<Dafny.Rune> theDefault = Dafny.Sequence<Dafny.Rune>.Empty;
        public static Dafny.ISequence<Dafny.Rune> Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<Dafny.ISequence<Dafny.Rune>> _TYPE = new Dafny.TypeDescriptor<Dafny.ISequence<Dafny.Rune>>(Dafny.Sequence<Dafny.Rune>.Empty);
        public static Dafny.TypeDescriptor<Dafny.ISequence<Dafny.Rune>> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IPattern create(Dafny.ISequence<Dafny.Rune> content)
        {
            return new Pattern(content);
        }
        public static _IPattern create_RawPattern(Dafny.ISequence<Dafny.Rune> content)
        {
            return create(content);
        }
        public bool is_RawPattern
        {
            get { return MutateCSharp.Schemata278.ReplaceBooleanConstant_10(2983L, true); }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_content
        {
            get
            {
                return this._content;
            }
        }

        public static Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> _this, Dafny.ISequence<Dafny.Rune> ind)
        {
            return (_this);
        }
    }

    public interface _IMatchCase
    {
        bool is_MatchCase { get; }
        Dafny.ISequence<Dafny.Rune> dtor_pattern { get; }
        RAST._IExpr dtor_rhs { get; }

        _IMatchCase DowncastClone();
        Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
    }
    public class MatchCase : _IMatchCase
    {
        public readonly Dafny.ISequence<Dafny.Rune> _pattern;
        public readonly RAST._IExpr _rhs;
        public MatchCase(Dafny.ISequence<Dafny.Rune> pattern, RAST._IExpr rhs)
        {
            this._pattern = pattern;
            this._rhs = rhs;
        }
        public _IMatchCase DowncastClone()
        {
            if (this is _IMatchCase dt) { return dt; }
            return new MatchCase(_pattern, _rhs);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.MatchCase;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(2991L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(2985L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_56(2984L, oth, null), () => object.Equals(this._pattern, oth._pattern)), () => object.Equals(this._rhs, oth._rhs));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(2997L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(3014L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(3004L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(3000L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(3011L, 0));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(3032L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(3025L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(3021L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._pattern)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(3050L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(3043L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(3039L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._rhs)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(3057L, "RAST.MatchCase.MatchCase");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(3058L, "(");
            s += Dafny.Helpers.ToString(this._pattern);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(3059L, ", ");
            s += Dafny.Helpers.ToString(this._rhs);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(3060L, ")");
            return s;
        }
        private static readonly RAST._IMatchCase theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, RAST.Expr.Default());
        public static RAST._IMatchCase Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<RAST._IMatchCase> _TYPE = new Dafny.TypeDescriptor<RAST._IMatchCase>(RAST.MatchCase.Default());
        public static Dafny.TypeDescriptor<RAST._IMatchCase> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IMatchCase create(Dafny.ISequence<Dafny.Rune> pattern, RAST._IExpr rhs)
        {
            return new MatchCase(pattern, rhs);
        }
        public static _IMatchCase create_MatchCase(Dafny.ISequence<Dafny.Rune> pattern, RAST._IExpr rhs)
        {
            return create(pattern, rhs);
        }
        public bool is_MatchCase
        {
            get { return MutateCSharp.Schemata278.ReplaceBooleanConstant_10(3061L, true); }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_pattern
        {
            get
            {
                return this._pattern;
            }
        }

        public RAST._IExpr dtor_rhs
        {
            get
            {
                return this._rhs;
            }
        }

        public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind)
        {
            Dafny.ISequence<Dafny.Rune> _896_newIndent = ((((this).dtor_rhs).is_Block) ? (ind) : (Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND)));
            Dafny.ISequence<Dafny.Rune> _897_rhsString = ((this).dtor_rhs)._ToString(_896_newIndent);
            return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(RAST.Pattern._ToString((this).dtor_pattern, ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3062L, " =>"))), ((MutateCSharp.Schemata278.ReplaceBinExprOp_5(3064L, () => ((_897_rhsString).Contains(new Dafny.Rune('\n'))), () => (MutateCSharp.Schemata278.ReplaceBinExprOp_57(3063L, ((_897_rhsString).Select(BigInteger.Zero)), (new Dafny.Rune('{')))))) ? (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3070L, "\n")), ind), RAST.__default.IND), _897_rhsString)) : (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3071L, " ")), _897_rhsString))));
        }
    }

    public interface _IAssignIdentifier
    {
        bool is_AssignIdentifier { get; }
        Dafny.ISequence<Dafny.Rune> dtor_identifier { get; }
        RAST._IExpr dtor_rhs { get; }

        _IAssignIdentifier DowncastClone();
        Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
    }
    public class AssignIdentifier : _IAssignIdentifier
    {
        public readonly Dafny.ISequence<Dafny.Rune> _identifier;
        public readonly RAST._IExpr _rhs;
        public AssignIdentifier(Dafny.ISequence<Dafny.Rune> identifier, RAST._IExpr rhs)
        {
            this._identifier = identifier;
            this._rhs = rhs;
        }
        public _IAssignIdentifier DowncastClone()
        {
            if (this is _IAssignIdentifier dt) { return dt; }
            return new AssignIdentifier(_identifier, _rhs);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.AssignIdentifier;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(3079L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(3073L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_58(3072L, oth, null), () => object.Equals(this._identifier, oth._identifier)), () => object.Equals(this._rhs, oth._rhs));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(3085L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(3102L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(3092L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(3088L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(3099L, 0));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(3120L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(3113L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(3109L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._identifier)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(3138L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(3131L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(3127L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._rhs)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(3145L, "RAST.AssignIdentifier.AssignIdentifier");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(3146L, "(");
            s += this._identifier.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(3147L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(3148L, ", ");
            s += Dafny.Helpers.ToString(this._rhs);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(3149L, ")");
            return s;
        }
        private static readonly RAST._IAssignIdentifier theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, RAST.Expr.Default());
        public static RAST._IAssignIdentifier Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<RAST._IAssignIdentifier> _TYPE = new Dafny.TypeDescriptor<RAST._IAssignIdentifier>(RAST.AssignIdentifier.Default());
        public static Dafny.TypeDescriptor<RAST._IAssignIdentifier> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IAssignIdentifier create(Dafny.ISequence<Dafny.Rune> identifier, RAST._IExpr rhs)
        {
            return new AssignIdentifier(identifier, rhs);
        }
        public static _IAssignIdentifier create_AssignIdentifier(Dafny.ISequence<Dafny.Rune> identifier, RAST._IExpr rhs)
        {
            return create(identifier, rhs);
        }
        public bool is_AssignIdentifier
        {
            get { return MutateCSharp.Schemata278.ReplaceBooleanConstant_10(3150L, true); }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_identifier
        {
            get
            {
                return this._identifier;
            }
        }

        public RAST._IExpr dtor_rhs
        {
            get
            {
                return this._rhs;
            }
        }

        public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind)
        {
            return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat((this).dtor_identifier, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3151L, ": "))), ((this).dtor_rhs)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND)));
        }
    }

    public interface _IDeclareType
    {
        bool is_MUT { get; }
        bool is_CONST { get; }

        _IDeclareType DowncastClone();
    }
    public abstract class DeclareType : _IDeclareType
    {
        public DeclareType()
        {
        }
        private static readonly RAST._IDeclareType theDefault = create_MUT();
        public static RAST._IDeclareType Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<RAST._IDeclareType> _TYPE = new Dafny.TypeDescriptor<RAST._IDeclareType>(RAST.DeclareType.Default());
        public static Dafny.TypeDescriptor<RAST._IDeclareType> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IDeclareType create_MUT()
        {
            return new DeclareType_MUT();
        }
        public static _IDeclareType create_CONST()
        {
            return new DeclareType_CONST();
        }
        public bool is_MUT
        {
            get { return this is DeclareType_MUT; }
        }

        public bool is_CONST
        {
            get { return this is DeclareType_CONST; }
        }

        public static System.Collections.Generic.IEnumerable<_IDeclareType> AllSingletonConstructors
        {
            get
            {
                yield return DeclareType.create_MUT();
                yield return DeclareType.create_CONST();
            }
        }

        public abstract _IDeclareType DowncastClone();
    }
    public class DeclareType_MUT : DeclareType
    {
        public DeclareType_MUT() : base()
        {
        }
        public override _IDeclareType DowncastClone()
        {
            if (this is _IDeclareType dt) { return dt; }
            return new DeclareType_MUT();
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.DeclareType_MUT;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_59(3152L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(3153L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(3170L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(3160L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(3156L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(3167L, 0));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(3177L, "RAST.DeclareType.MUT");
            return s;
        }
    }
    public class DeclareType_CONST : DeclareType
    {
        public DeclareType_CONST() : base()
        {
        }
        public override _IDeclareType DowncastClone()
        {
            if (this is _IDeclareType dt) { return dt; }
            return new DeclareType_CONST();
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.DeclareType_CONST;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_60(3178L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(3179L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(3196L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(3186L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(3182L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(3193L, 1));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(3203L, "RAST.DeclareType.CONST");
            return s;
        }
    }

    public interface _IAssociativity
    {
        bool is_LeftToRight { get; }
        bool is_RightToLeft { get; }
        bool is_RequiresParentheses { get; }

        _IAssociativity DowncastClone();
    }
    public abstract class Associativity : _IAssociativity
    {
        public Associativity()
        {
        }
        private static readonly RAST._IAssociativity theDefault = create_LeftToRight();
        public static RAST._IAssociativity Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<RAST._IAssociativity> _TYPE = new Dafny.TypeDescriptor<RAST._IAssociativity>(RAST.Associativity.Default());
        public static Dafny.TypeDescriptor<RAST._IAssociativity> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IAssociativity create_LeftToRight()
        {
            return new Associativity_LeftToRight();
        }
        public static _IAssociativity create_RightToLeft()
        {
            return new Associativity_RightToLeft();
        }
        public static _IAssociativity create_RequiresParentheses()
        {
            return new Associativity_RequiresParentheses();
        }
        public bool is_LeftToRight
        {
            get { return this is Associativity_LeftToRight; }
        }

        public bool is_RightToLeft
        {
            get { return this is Associativity_RightToLeft; }
        }

        public bool is_RequiresParentheses
        {
            get { return this is Associativity_RequiresParentheses; }
        }

        public static System.Collections.Generic.IEnumerable<_IAssociativity> AllSingletonConstructors
        {
            get
            {
                yield return Associativity.create_LeftToRight();
                yield return Associativity.create_RightToLeft();
                yield return Associativity.create_RequiresParentheses();
            }
        }

        public abstract _IAssociativity DowncastClone();
    }
    public class Associativity_LeftToRight : Associativity
    {
        public Associativity_LeftToRight() : base()
        {
        }
        public override _IAssociativity DowncastClone()
        {
            if (this is _IAssociativity dt) { return dt; }
            return new Associativity_LeftToRight();
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Associativity_LeftToRight;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_61(3204L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(3205L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(3222L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(3212L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(3208L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(3219L, 0));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(3229L, "RAST.Associativity.LeftToRight");
            return s;
        }
    }
    public class Associativity_RightToLeft : Associativity
    {
        public Associativity_RightToLeft() : base()
        {
        }
        public override _IAssociativity DowncastClone()
        {
            if (this is _IAssociativity dt) { return dt; }
            return new Associativity_RightToLeft();
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Associativity_RightToLeft;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_62(3230L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(3231L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(3248L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(3238L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(3234L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(3245L, 1));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(3255L, "RAST.Associativity.RightToLeft");
            return s;
        }
    }
    public class Associativity_RequiresParentheses : Associativity
    {
        public Associativity_RequiresParentheses() : base()
        {
        }
        public override _IAssociativity DowncastClone()
        {
            if (this is _IAssociativity dt) { return dt; }
            return new Associativity_RequiresParentheses();
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Associativity_RequiresParentheses;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_63(3256L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(3257L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(3274L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(3264L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(3260L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(3271L, 2));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(3281L, "RAST.Associativity.RequiresParentheses");
            return s;
        }
    }

    public interface _IPrintingInfo
    {
        bool is_UnknownPrecedence { get; }
        bool is_Precedence { get; }
        bool is_SuffixPrecedence { get; }
        bool is_PrecedenceAssociativity { get; }
        BigInteger dtor_precedence { get; }
        RAST._IAssociativity dtor_associativity { get; }

        _IPrintingInfo DowncastClone();
        bool NeedParenthesesFor(RAST._IPrintingInfo underlying);
        bool NeedParenthesesForLeft(RAST._IPrintingInfo underlying);
        bool NeedParenthesesForRight(RAST._IPrintingInfo underlying);
    }
    public abstract class PrintingInfo : _IPrintingInfo
    {
        public PrintingInfo()
        {
        }
        private static readonly RAST._IPrintingInfo theDefault = create_UnknownPrecedence();
        public static RAST._IPrintingInfo Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<RAST._IPrintingInfo> _TYPE = new Dafny.TypeDescriptor<RAST._IPrintingInfo>(RAST.PrintingInfo.Default());
        public static Dafny.TypeDescriptor<RAST._IPrintingInfo> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IPrintingInfo create_UnknownPrecedence()
        {
            return new PrintingInfo_UnknownPrecedence();
        }
        public static _IPrintingInfo create_Precedence(BigInteger precedence)
        {
            return new PrintingInfo_Precedence(precedence);
        }
        public static _IPrintingInfo create_SuffixPrecedence(BigInteger precedence)
        {
            return new PrintingInfo_SuffixPrecedence(precedence);
        }
        public static _IPrintingInfo create_PrecedenceAssociativity(BigInteger precedence, RAST._IAssociativity associativity)
        {
            return new PrintingInfo_PrecedenceAssociativity(precedence, associativity);
        }
        public bool is_UnknownPrecedence
        {
            get { return this is PrintingInfo_UnknownPrecedence; }
        }

        public bool is_Precedence
        {
            get { return this is PrintingInfo_Precedence; }
        }

        public bool is_SuffixPrecedence
        {
            get { return this is PrintingInfo_SuffixPrecedence; }
        }

        public bool is_PrecedenceAssociativity
        {
            get { return this is PrintingInfo_PrecedenceAssociativity; }
        }

        public BigInteger dtor_precedence
        {
            get
            {
                var d = this;
                if (d is PrintingInfo_Precedence) { return ((PrintingInfo_Precedence)d)._precedence; }
                if (d is PrintingInfo_SuffixPrecedence) { return ((PrintingInfo_SuffixPrecedence)d)._precedence; }
                return ((PrintingInfo_PrecedenceAssociativity)d)._precedence;
            }
        }

        public RAST._IAssociativity dtor_associativity
        {
            get
            {
                var d = this;
                return ((PrintingInfo_PrecedenceAssociativity)d)._associativity;
            }
        }

        public abstract _IPrintingInfo DowncastClone();
        public bool NeedParenthesesFor(RAST._IPrintingInfo underlying)
        {
            if ((this).is_UnknownPrecedence)
            {
                return MutateCSharp.Schemata278.ReplaceBooleanConstant_10(3282L, true);
            }
            else if ((underlying).is_UnknownPrecedence)
            {
                return MutateCSharp.Schemata278.ReplaceBooleanConstant_10(3283L, true);
            }
            else if (MutateCSharp.Schemata278.ReplaceBinExprOp_64(3284L, ((this).dtor_precedence), ((underlying).dtor_precedence)))
            {
                return MutateCSharp.Schemata278.ReplaceBooleanConstant_10(3286L, true);
            }
            else
            {
                return MutateCSharp.Schemata278.ReplaceBooleanConstant_10(3287L, false);
            }

            return default;
        }
        public bool NeedParenthesesForLeft(RAST._IPrintingInfo underlying)
        {
            if ((this).is_UnknownPrecedence)
            {
                return MutateCSharp.Schemata278.ReplaceBooleanConstant_10(3288L, true);
            }
            else if ((underlying).is_UnknownPrecedence)
            {
                return MutateCSharp.Schemata278.ReplaceBooleanConstant_10(3289L, true);
            }
            else if (MutateCSharp.Schemata278.ReplaceBinExprOp_64(3290L, ((this).dtor_precedence), ((underlying).dtor_precedence)))
            {
                return MutateCSharp.Schemata278.ReplaceBinExprOp_65(3300L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3294L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_3(3292L, ((this).dtor_precedence), ((underlying).dtor_precedence))), () => (!((this).is_PrecedenceAssociativity)))), () => (!(((this).dtor_associativity).is_LeftToRight)));
            }
            else
            {
                return MutateCSharp.Schemata278.ReplaceBooleanConstant_10(3306L, false);
            }

            return default;
        }
        public bool NeedParenthesesForRight(RAST._IPrintingInfo underlying)
        {
            if ((this).is_UnknownPrecedence)
            {
                return MutateCSharp.Schemata278.ReplaceBooleanConstant_10(3307L, true);
            }
            else if ((underlying).is_UnknownPrecedence)
            {
                return MutateCSharp.Schemata278.ReplaceBooleanConstant_10(3308L, true);
            }
            else if (MutateCSharp.Schemata278.ReplaceBinExprOp_64(3309L, ((this).dtor_precedence), ((underlying).dtor_precedence)))
            {
                return MutateCSharp.Schemata278.ReplaceBinExprOp_65(3319L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3313L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_3(3311L, ((this).dtor_precedence), ((underlying).dtor_precedence))), () => (!((this).is_PrecedenceAssociativity)))), () => (!(((this).dtor_associativity).is_RightToLeft)));
            }
            else
            {
                return MutateCSharp.Schemata278.ReplaceBooleanConstant_10(3325L, false);
            }

            return default;
        }
    }
    public class PrintingInfo_UnknownPrecedence : PrintingInfo
    {
        public PrintingInfo_UnknownPrecedence() : base()
        {
        }
        public override _IPrintingInfo DowncastClone()
        {
            if (this is _IPrintingInfo dt) { return dt; }
            return new PrintingInfo_UnknownPrecedence();
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.PrintingInfo_UnknownPrecedence;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_66(3326L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(3327L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(3344L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(3334L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(3330L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(3341L, 0));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(3351L, "RAST.PrintingInfo.UnknownPrecedence");
            return s;
        }
    }
    public class PrintingInfo_Precedence : PrintingInfo
    {
        public readonly BigInteger _precedence;
        public PrintingInfo_Precedence(BigInteger precedence) : base()
        {
            this._precedence = precedence;
        }
        public override _IPrintingInfo DowncastClone()
        {
            if (this is _IPrintingInfo dt) { return dt; }
            return new PrintingInfo_Precedence(_precedence);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.PrintingInfo_Precedence;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(3354L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_67(3352L, oth, null), () => MutateCSharp.Schemata278.ReplaceBinExprOp_68(3353L, this._precedence, oth._precedence));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(3360L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(3377L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(3367L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(3363L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(3374L, 1));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(3395L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(3388L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(3384L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._precedence)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(3402L, "RAST.PrintingInfo.Precedence");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(3403L, "(");
            s += Dafny.Helpers.ToString(this._precedence);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(3404L, ")");
            return s;
        }
    }
    public class PrintingInfo_SuffixPrecedence : PrintingInfo
    {
        public readonly BigInteger _precedence;
        public PrintingInfo_SuffixPrecedence(BigInteger precedence) : base()
        {
            this._precedence = precedence;
        }
        public override _IPrintingInfo DowncastClone()
        {
            if (this is _IPrintingInfo dt) { return dt; }
            return new PrintingInfo_SuffixPrecedence(_precedence);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.PrintingInfo_SuffixPrecedence;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(3407L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_69(3405L, oth, null), () => MutateCSharp.Schemata278.ReplaceBinExprOp_68(3406L, this._precedence, oth._precedence));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(3413L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(3430L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(3420L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(3416L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(3427L, 2));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(3448L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(3441L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(3437L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._precedence)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(3455L, "RAST.PrintingInfo.SuffixPrecedence");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(3456L, "(");
            s += Dafny.Helpers.ToString(this._precedence);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(3457L, ")");
            return s;
        }
    }
    public class PrintingInfo_PrecedenceAssociativity : PrintingInfo
    {
        public readonly BigInteger _precedence;
        public readonly RAST._IAssociativity _associativity;
        public PrintingInfo_PrecedenceAssociativity(BigInteger precedence, RAST._IAssociativity associativity) : base()
        {
            this._precedence = precedence;
            this._associativity = associativity;
        }
        public override _IPrintingInfo DowncastClone()
        {
            if (this is _IPrintingInfo dt) { return dt; }
            return new PrintingInfo_PrecedenceAssociativity(_precedence, _associativity);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.PrintingInfo_PrecedenceAssociativity;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(3466L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(3460L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_70(3458L, oth, null), () => MutateCSharp.Schemata278.ReplaceBinExprOp_68(3459L, this._precedence, oth._precedence)), () => object.Equals(this._associativity, oth._associativity));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(3472L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(3489L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(3479L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(3475L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(3486L, 3));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(3507L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(3500L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(3496L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._precedence)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(3525L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(3518L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(3514L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._associativity)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(3532L, "RAST.PrintingInfo.PrecedenceAssociativity");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(3533L, "(");
            s += Dafny.Helpers.ToString(this._precedence);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(3534L, ", ");
            s += Dafny.Helpers.ToString(this._associativity);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(3535L, ")");
            return s;
        }
    }

    public interface _IExpr
    {
        bool is_RawExpr { get; }
        bool is_Identifier { get; }
        bool is_Match { get; }
        bool is_StmtExpr { get; }
        bool is_Block { get; }
        bool is_StructBuild { get; }
        bool is_Tuple { get; }
        bool is_UnaryOp { get; }
        bool is_BinaryOp { get; }
        bool is_TypeAscription { get; }
        bool is_LiteralInt { get; }
        bool is_LiteralString { get; }
        bool is_ConversionNum { get; }
        bool is_DeclareVar { get; }
        bool is_AssignVar { get; }
        bool is_IfExpr { get; }
        bool is_Loop { get; }
        bool is_For { get; }
        bool is_Labelled { get; }
        bool is_Break { get; }
        bool is_Continue { get; }
        bool is_Return { get; }
        bool is_Call { get; }
        bool is_Select { get; }
        bool is_MemberSelect { get; }
        Dafny.ISequence<Dafny.Rune> dtor_content { get; }
        Dafny.ISequence<Dafny.Rune> dtor_name { get; }
        RAST._IExpr dtor_matchee { get; }
        Dafny.ISequence<RAST._IMatchCase> dtor_cases { get; }
        RAST._IExpr dtor_stmt { get; }
        RAST._IExpr dtor_rhs { get; }
        RAST._IExpr dtor_underlying { get; }
        Dafny.ISequence<RAST._IAssignIdentifier> dtor_assignments { get; }
        Dafny.ISequence<RAST._IExpr> dtor_arguments { get; }
        Dafny.ISequence<Dafny.Rune> dtor_op1 { get; }
        DAST.Format._IUnaryOpFormat dtor_format { get; }
        Dafny.ISequence<Dafny.Rune> dtor_op2 { get; }
        RAST._IExpr dtor_left { get; }
        RAST._IExpr dtor_right { get; }
        DAST.Format._IBinaryOpFormat dtor_format2 { get; }
        RAST._IType dtor_tpe { get; }
        Dafny.ISequence<Dafny.Rune> dtor_value { get; }
        bool dtor_binary { get; }
        RAST._IDeclareType dtor_declareType { get; }
        Std.Wrappers._IOption<RAST._IType> dtor_optType { get; }
        Std.Wrappers._IOption<RAST._IExpr> dtor_optRhs { get; }
        RAST._IExpr dtor_cond { get; }
        RAST._IExpr dtor_thn { get; }
        RAST._IExpr dtor_els { get; }
        Std.Wrappers._IOption<RAST._IExpr> dtor_optCond { get; }
        RAST._IExpr dtor_range { get; }
        RAST._IExpr dtor_body { get; }
        Dafny.ISequence<Dafny.Rune> dtor_lbl { get; }
        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> dtor_optLbl { get; }
        Std.Wrappers._IOption<RAST._IExpr> dtor_optExpr { get; }
        RAST._IExpr dtor_obj { get; }
        Dafny.ISequence<RAST._IType> dtor_typeParameters { get; }

        _IExpr DowncastClone();
        bool NoExtraSemicolonAfter();
        RAST._IPrintingInfo printingInfo { get; }

        RAST._IExpr Optimize();
        bool LeftRequiresParentheses(RAST._IExpr left);
        _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> LeftParentheses(RAST._IExpr left);
        bool RightRequiresParentheses(RAST._IExpr right);
        _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> RightParentheses(RAST._IExpr right);
        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> RightMostIdentifier();
        Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
        RAST._IExpr Then(RAST._IExpr rhs2);
        RAST._IExpr Sel(Dafny.ISequence<Dafny.Rune> name);
        RAST._IExpr MSel(Dafny.ISequence<Dafny.Rune> name);
        RAST._IExpr Apply(Dafny.ISequence<RAST._IType> typeParameters, Dafny.ISequence<RAST._IExpr> arguments);
        RAST._IExpr Apply1(RAST._IExpr argument);
    }
    public abstract class Expr : _IExpr
    {
        public Expr()
        {
        }
        private static readonly RAST._IExpr theDefault = create_RawExpr(Dafny.Sequence<Dafny.Rune>.Empty);
        public static RAST._IExpr Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<RAST._IExpr> _TYPE = new Dafny.TypeDescriptor<RAST._IExpr>(RAST.Expr.Default());
        public static Dafny.TypeDescriptor<RAST._IExpr> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IExpr create_RawExpr(Dafny.ISequence<Dafny.Rune> content)
        {
            return new Expr_RawExpr(content);
        }
        public static _IExpr create_Identifier(Dafny.ISequence<Dafny.Rune> name)
        {
            return new Expr_Identifier(name);
        }
        public static _IExpr create_Match(RAST._IExpr matchee, Dafny.ISequence<RAST._IMatchCase> cases)
        {
            return new Expr_Match(matchee, cases);
        }
        public static _IExpr create_StmtExpr(RAST._IExpr stmt, RAST._IExpr rhs)
        {
            return new Expr_StmtExpr(stmt, rhs);
        }
        public static _IExpr create_Block(RAST._IExpr underlying)
        {
            return new Expr_Block(underlying);
        }
        public static _IExpr create_StructBuild(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._IAssignIdentifier> assignments)
        {
            return new Expr_StructBuild(name, assignments);
        }
        public static _IExpr create_Tuple(Dafny.ISequence<RAST._IExpr> arguments)
        {
            return new Expr_Tuple(arguments);
        }
        public static _IExpr create_UnaryOp(Dafny.ISequence<Dafny.Rune> op1, RAST._IExpr underlying, DAST.Format._IUnaryOpFormat format)
        {
            return new Expr_UnaryOp(op1, underlying, format);
        }
        public static _IExpr create_BinaryOp(Dafny.ISequence<Dafny.Rune> op2, RAST._IExpr left, RAST._IExpr right, DAST.Format._IBinaryOpFormat format2)
        {
            return new Expr_BinaryOp(op2, left, right, format2);
        }
        public static _IExpr create_TypeAscription(RAST._IExpr left, RAST._IType tpe)
        {
            return new Expr_TypeAscription(left, tpe);
        }
        public static _IExpr create_LiteralInt(Dafny.ISequence<Dafny.Rune> @value)
        {
            return new Expr_LiteralInt(@value);
        }
        public static _IExpr create_LiteralString(Dafny.ISequence<Dafny.Rune> @value, bool binary)
        {
            return new Expr_LiteralString(@value, binary);
        }
        public static _IExpr create_ConversionNum(RAST._IType tpe, RAST._IExpr underlying)
        {
            return new Expr_ConversionNum(tpe, underlying);
        }
        public static _IExpr create_DeclareVar(RAST._IDeclareType declareType, Dafny.ISequence<Dafny.Rune> name, Std.Wrappers._IOption<RAST._IType> optType, Std.Wrappers._IOption<RAST._IExpr> optRhs)
        {
            return new Expr_DeclareVar(declareType, name, optType, optRhs);
        }
        public static _IExpr create_AssignVar(Dafny.ISequence<Dafny.Rune> name, RAST._IExpr rhs)
        {
            return new Expr_AssignVar(name, rhs);
        }
        public static _IExpr create_IfExpr(RAST._IExpr cond, RAST._IExpr thn, RAST._IExpr els)
        {
            return new Expr_IfExpr(cond, thn, els);
        }
        public static _IExpr create_Loop(Std.Wrappers._IOption<RAST._IExpr> optCond, RAST._IExpr underlying)
        {
            return new Expr_Loop(optCond, underlying);
        }
        public static _IExpr create_For(Dafny.ISequence<Dafny.Rune> name, RAST._IExpr range, RAST._IExpr body)
        {
            return new Expr_For(name, range, body);
        }
        public static _IExpr create_Labelled(Dafny.ISequence<Dafny.Rune> lbl, RAST._IExpr underlying)
        {
            return new Expr_Labelled(lbl, underlying);
        }
        public static _IExpr create_Break(Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> optLbl)
        {
            return new Expr_Break(optLbl);
        }
        public static _IExpr create_Continue(Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> optLbl)
        {
            return new Expr_Continue(optLbl);
        }
        public static _IExpr create_Return(Std.Wrappers._IOption<RAST._IExpr> optExpr)
        {
            return new Expr_Return(optExpr);
        }
        public static _IExpr create_Call(RAST._IExpr obj, Dafny.ISequence<RAST._IType> typeParameters, Dafny.ISequence<RAST._IExpr> arguments)
        {
            return new Expr_Call(obj, typeParameters, arguments);
        }
        public static _IExpr create_Select(RAST._IExpr obj, Dafny.ISequence<Dafny.Rune> name)
        {
            return new Expr_Select(obj, name);
        }
        public static _IExpr create_MemberSelect(RAST._IExpr obj, Dafny.ISequence<Dafny.Rune> name)
        {
            return new Expr_MemberSelect(obj, name);
        }
        public bool is_RawExpr
        {
            get { return this is Expr_RawExpr; }
        }

        public bool is_Identifier
        {
            get { return this is Expr_Identifier; }
        }

        public bool is_Match
        {
            get { return this is Expr_Match; }
        }

        public bool is_StmtExpr
        {
            get { return this is Expr_StmtExpr; }
        }

        public bool is_Block
        {
            get { return this is Expr_Block; }
        }

        public bool is_StructBuild
        {
            get { return this is Expr_StructBuild; }
        }

        public bool is_Tuple
        {
            get { return this is Expr_Tuple; }
        }

        public bool is_UnaryOp
        {
            get { return this is Expr_UnaryOp; }
        }

        public bool is_BinaryOp
        {
            get { return this is Expr_BinaryOp; }
        }

        public bool is_TypeAscription
        {
            get { return this is Expr_TypeAscription; }
        }

        public bool is_LiteralInt
        {
            get { return this is Expr_LiteralInt; }
        }

        public bool is_LiteralString
        {
            get { return this is Expr_LiteralString; }
        }

        public bool is_ConversionNum
        {
            get { return this is Expr_ConversionNum; }
        }

        public bool is_DeclareVar
        {
            get { return this is Expr_DeclareVar; }
        }

        public bool is_AssignVar
        {
            get { return this is Expr_AssignVar; }
        }

        public bool is_IfExpr
        {
            get { return this is Expr_IfExpr; }
        }

        public bool is_Loop
        {
            get { return this is Expr_Loop; }
        }

        public bool is_For
        {
            get { return this is Expr_For; }
        }

        public bool is_Labelled
        {
            get { return this is Expr_Labelled; }
        }

        public bool is_Break
        {
            get { return this is Expr_Break; }
        }

        public bool is_Continue
        {
            get { return this is Expr_Continue; }
        }

        public bool is_Return
        {
            get { return this is Expr_Return; }
        }

        public bool is_Call
        {
            get { return this is Expr_Call; }
        }

        public bool is_Select
        {
            get { return this is Expr_Select; }
        }

        public bool is_MemberSelect
        {
            get { return this is Expr_MemberSelect; }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_content
        {
            get
            {
                var d = this;
                return ((Expr_RawExpr)d)._content;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_name
        {
            get
            {
                var d = this;
                if (d is Expr_Identifier) { return ((Expr_Identifier)d)._name; }
                if (d is Expr_StructBuild) { return ((Expr_StructBuild)d)._name; }
                if (d is Expr_DeclareVar) { return ((Expr_DeclareVar)d)._name; }
                if (d is Expr_AssignVar) { return ((Expr_AssignVar)d)._name; }
                if (d is Expr_For) { return ((Expr_For)d)._name; }
                if (d is Expr_Select) { return ((Expr_Select)d)._name; }
                return ((Expr_MemberSelect)d)._name;
            }
        }

        public RAST._IExpr dtor_matchee
        {
            get
            {
                var d = this;
                return ((Expr_Match)d)._matchee;
            }
        }

        public Dafny.ISequence<RAST._IMatchCase> dtor_cases
        {
            get
            {
                var d = this;
                return ((Expr_Match)d)._cases;
            }
        }

        public RAST._IExpr dtor_stmt
        {
            get
            {
                var d = this;
                return ((Expr_StmtExpr)d)._stmt;
            }
        }

        public RAST._IExpr dtor_rhs
        {
            get
            {
                var d = this;
                if (d is Expr_StmtExpr) { return ((Expr_StmtExpr)d)._rhs; }
                return ((Expr_AssignVar)d)._rhs;
            }
        }

        public RAST._IExpr dtor_underlying
        {
            get
            {
                var d = this;
                if (d is Expr_Block) { return ((Expr_Block)d)._underlying; }
                if (d is Expr_UnaryOp) { return ((Expr_UnaryOp)d)._underlying; }
                if (d is Expr_ConversionNum) { return ((Expr_ConversionNum)d)._underlying; }
                if (d is Expr_Loop) { return ((Expr_Loop)d)._underlying; }
                return ((Expr_Labelled)d)._underlying;
            }
        }

        public Dafny.ISequence<RAST._IAssignIdentifier> dtor_assignments
        {
            get
            {
                var d = this;
                return ((Expr_StructBuild)d)._assignments;
            }
        }

        public Dafny.ISequence<RAST._IExpr> dtor_arguments
        {
            get
            {
                var d = this;
                if (d is Expr_Tuple) { return ((Expr_Tuple)d)._arguments; }
                return ((Expr_Call)d)._arguments;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_op1
        {
            get
            {
                var d = this;
                return ((Expr_UnaryOp)d)._op1;
            }
        }

        public DAST.Format._IUnaryOpFormat dtor_format
        {
            get
            {
                var d = this;
                return ((Expr_UnaryOp)d)._format;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_op2
        {
            get
            {
                var d = this;
                return ((Expr_BinaryOp)d)._op2;
            }
        }

        public RAST._IExpr dtor_left
        {
            get
            {
                var d = this;
                if (d is Expr_BinaryOp) { return ((Expr_BinaryOp)d)._left; }
                return ((Expr_TypeAscription)d)._left;
            }
        }

        public RAST._IExpr dtor_right
        {
            get
            {
                var d = this;
                return ((Expr_BinaryOp)d)._right;
            }
        }

        public DAST.Format._IBinaryOpFormat dtor_format2
        {
            get
            {
                var d = this;
                return ((Expr_BinaryOp)d)._format2;
            }
        }

        public RAST._IType dtor_tpe
        {
            get
            {
                var d = this;
                if (d is Expr_TypeAscription) { return ((Expr_TypeAscription)d)._tpe; }
                return ((Expr_ConversionNum)d)._tpe;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_value
        {
            get
            {
                var d = this;
                if (d is Expr_LiteralInt) { return ((Expr_LiteralInt)d)._value; }
                return ((Expr_LiteralString)d)._value;
            }
        }

        public bool dtor_binary
        {
            get
            {
                var d = this;
                return ((Expr_LiteralString)d)._binary;
            }
        }

        public RAST._IDeclareType dtor_declareType
        {
            get
            {
                var d = this;
                return ((Expr_DeclareVar)d)._declareType;
            }
        }

        public Std.Wrappers._IOption<RAST._IType> dtor_optType
        {
            get
            {
                var d = this;
                return ((Expr_DeclareVar)d)._optType;
            }
        }

        public Std.Wrappers._IOption<RAST._IExpr> dtor_optRhs
        {
            get
            {
                var d = this;
                return ((Expr_DeclareVar)d)._optRhs;
            }
        }

        public RAST._IExpr dtor_cond
        {
            get
            {
                var d = this;
                return ((Expr_IfExpr)d)._cond;
            }
        }

        public RAST._IExpr dtor_thn
        {
            get
            {
                var d = this;
                return ((Expr_IfExpr)d)._thn;
            }
        }

        public RAST._IExpr dtor_els
        {
            get
            {
                var d = this;
                return ((Expr_IfExpr)d)._els;
            }
        }

        public Std.Wrappers._IOption<RAST._IExpr> dtor_optCond
        {
            get
            {
                var d = this;
                return ((Expr_Loop)d)._optCond;
            }
        }

        public RAST._IExpr dtor_range
        {
            get
            {
                var d = this;
                return ((Expr_For)d)._range;
            }
        }

        public RAST._IExpr dtor_body
        {
            get
            {
                var d = this;
                return ((Expr_For)d)._body;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_lbl
        {
            get
            {
                var d = this;
                return ((Expr_Labelled)d)._lbl;
            }
        }

        public Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> dtor_optLbl
        {
            get
            {
                var d = this;
                if (d is Expr_Break) { return ((Expr_Break)d)._optLbl; }
                return ((Expr_Continue)d)._optLbl;
            }
        }

        public Std.Wrappers._IOption<RAST._IExpr> dtor_optExpr
        {
            get
            {
                var d = this;
                return ((Expr_Return)d)._optExpr;
            }
        }

        public RAST._IExpr dtor_obj
        {
            get
            {
                var d = this;
                if (d is Expr_Call) { return ((Expr_Call)d)._obj; }
                if (d is Expr_Select) { return ((Expr_Select)d)._obj; }
                return ((Expr_MemberSelect)d)._obj;
            }
        }

        public Dafny.ISequence<RAST._IType> dtor_typeParameters
        {
            get
            {
                var d = this;
                return ((Expr_Call)d)._typeParameters;
            }
        }

        public abstract _IExpr DowncastClone();
        public bool NoExtraSemicolonAfter()
        {
            return MutateCSharp.Schemata278.ReplaceBinExprOp_65(3582L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3554L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3548L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3542L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3536L, () => ((this).is_DeclareVar), () => ((this).is_AssignVar))), () => ((this).is_Break))), () => ((this).is_Continue))), () => ((this).is_Return))), () => (MutateCSharp.Schemata278.ReplaceBinExprOp_5(3576L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_5(3569L, () => ((this).is_RawExpr), () => (MutateCSharp.Schemata278.ReplaceBinExprOp_1(3564L, (new BigInteger(((this).dtor_content).Count)).Sign, MutateCSharp.Schemata278.ReplaceNumericConstant_0(3560L, 1))))), () => (MutateCSharp.Schemata278.ReplaceBinExprOp_6(3575L, (((this).dtor_content).Select((new BigInteger(((this).dtor_content).Count)) - (BigInteger.One))), (new Dafny.Rune(';')))))));
        }
        public RAST._IExpr Optimize()
        {
            RAST._IExpr _source27 = this;
            if (_source27.is_RawExpr)
            {
                Dafny.ISequence<Dafny.Rune> _898___mcc_h0 = _source27.dtor_content;
                return this;
            }
            else if (_source27.is_Identifier)
            {
                Dafny.ISequence<Dafny.Rune> _899___mcc_h2 = _source27.dtor_name;
                return this;
            }
            else if (_source27.is_Match)
            {
                RAST._IExpr _900___mcc_h4 = _source27.dtor_matchee;
                Dafny.ISequence<RAST._IMatchCase> _901___mcc_h5 = _source27.dtor_cases;
                return this;
            }
            else if (_source27.is_StmtExpr)
            {
                RAST._IExpr _902___mcc_h8 = _source27.dtor_stmt;
                RAST._IExpr _903___mcc_h9 = _source27.dtor_rhs;
                RAST._IExpr _source28 = _902___mcc_h8;
                if (_source28.is_RawExpr)
                {
                    Dafny.ISequence<Dafny.Rune> _904___mcc_h12 = _source28.dtor_content;
                    return this;
                }
                else if (_source28.is_Identifier)
                {
                    Dafny.ISequence<Dafny.Rune> _905___mcc_h14 = _source28.dtor_name;
                    return this;
                }
                else if (_source28.is_Match)
                {
                    RAST._IExpr _906___mcc_h16 = _source28.dtor_matchee;
                    Dafny.ISequence<RAST._IMatchCase> _907___mcc_h17 = _source28.dtor_cases;
                    return this;
                }
                else if (_source28.is_StmtExpr)
                {
                    RAST._IExpr _908___mcc_h20 = _source28.dtor_stmt;
                    RAST._IExpr _909___mcc_h21 = _source28.dtor_rhs;
                    return this;
                }
                else if (_source28.is_Block)
                {
                    RAST._IExpr _910___mcc_h24 = _source28.dtor_underlying;
                    return this;
                }
                else if (_source28.is_StructBuild)
                {
                    Dafny.ISequence<Dafny.Rune> _911___mcc_h26 = _source28.dtor_name;
                    Dafny.ISequence<RAST._IAssignIdentifier> _912___mcc_h27 = _source28.dtor_assignments;
                    return this;
                }
                else if (_source28.is_Tuple)
                {
                    Dafny.ISequence<RAST._IExpr> _913___mcc_h30 = _source28.dtor_arguments;
                    return this;
                }
                else if (_source28.is_UnaryOp)
                {
                    Dafny.ISequence<Dafny.Rune> _914___mcc_h32 = _source28.dtor_op1;
                    RAST._IExpr _915___mcc_h33 = _source28.dtor_underlying;
                    DAST.Format._IUnaryOpFormat _916___mcc_h34 = _source28.dtor_format;
                    return this;
                }
                else if (_source28.is_BinaryOp)
                {
                    Dafny.ISequence<Dafny.Rune> _917___mcc_h38 = _source28.dtor_op2;
                    RAST._IExpr _918___mcc_h39 = _source28.dtor_left;
                    RAST._IExpr _919___mcc_h40 = _source28.dtor_right;
                    DAST.Format._IBinaryOpFormat _920___mcc_h41 = _source28.dtor_format2;
                    return this;
                }
                else if (_source28.is_TypeAscription)
                {
                    RAST._IExpr _921___mcc_h46 = _source28.dtor_left;
                    RAST._IType _922___mcc_h47 = _source28.dtor_tpe;
                    return this;
                }
                else if (_source28.is_LiteralInt)
                {
                    Dafny.ISequence<Dafny.Rune> _923___mcc_h50 = _source28.dtor_value;
                    return this;
                }
                else if (_source28.is_LiteralString)
                {
                    Dafny.ISequence<Dafny.Rune> _924___mcc_h52 = _source28.dtor_value;
                    bool _925___mcc_h53 = _source28.dtor_binary;
                    return this;
                }
                else if (_source28.is_ConversionNum)
                {
                    RAST._IType _926___mcc_h56 = _source28.dtor_tpe;
                    RAST._IExpr _927___mcc_h57 = _source28.dtor_underlying;
                    return this;
                }
                else if (_source28.is_DeclareVar)
                {
                    RAST._IDeclareType _928___mcc_h60 = _source28.dtor_declareType;
                    Dafny.ISequence<Dafny.Rune> _929___mcc_h61 = _source28.dtor_name;
                    Std.Wrappers._IOption<RAST._IType> _930___mcc_h62 = _source28.dtor_optType;
                    Std.Wrappers._IOption<RAST._IExpr> _931___mcc_h63 = _source28.dtor_optRhs;
                    Std.Wrappers._IOption<RAST._IType> _source29 = _930___mcc_h62;
                    if (_source29.is_None)
                    {
                        return this;
                    }
                    else
                    {
                        RAST._IType _932___mcc_h68 = _source29.dtor_value;
                        Std.Wrappers._IOption<RAST._IExpr> _source30 = _931___mcc_h63;
                        if (_source30.is_None)
                        {
                            RAST._IExpr _source31 = _903___mcc_h9;
                            if (_source31.is_RawExpr)
                            {
                                Dafny.ISequence<Dafny.Rune> _933___mcc_h70 = _source31.dtor_content;
                                return this;
                            }
                            else if (_source31.is_Identifier)
                            {
                                Dafny.ISequence<Dafny.Rune> _934___mcc_h72 = _source31.dtor_name;
                                return this;
                            }
                            else if (_source31.is_Match)
                            {
                                RAST._IExpr _935___mcc_h74 = _source31.dtor_matchee;
                                Dafny.ISequence<RAST._IMatchCase> _936___mcc_h75 = _source31.dtor_cases;
                                return this;
                            }
                            else if (_source31.is_StmtExpr)
                            {
                                RAST._IExpr _937___mcc_h78 = _source31.dtor_stmt;
                                RAST._IExpr _938___mcc_h79 = _source31.dtor_rhs;
                                RAST._IExpr _source32 = _937___mcc_h78;
                                if (_source32.is_RawExpr)
                                {
                                    Dafny.ISequence<Dafny.Rune> _939___mcc_h82 = _source32.dtor_content;
                                    return this;
                                }
                                else if (_source32.is_Identifier)
                                {
                                    Dafny.ISequence<Dafny.Rune> _940___mcc_h84 = _source32.dtor_name;
                                    return this;
                                }
                                else if (_source32.is_Match)
                                {
                                    RAST._IExpr _941___mcc_h86 = _source32.dtor_matchee;
                                    Dafny.ISequence<RAST._IMatchCase> _942___mcc_h87 = _source32.dtor_cases;
                                    return this;
                                }
                                else if (_source32.is_StmtExpr)
                                {
                                    RAST._IExpr _943___mcc_h90 = _source32.dtor_stmt;
                                    RAST._IExpr _944___mcc_h91 = _source32.dtor_rhs;
                                    return this;
                                }
                                else if (_source32.is_Block)
                                {
                                    RAST._IExpr _945___mcc_h94 = _source32.dtor_underlying;
                                    return this;
                                }
                                else if (_source32.is_StructBuild)
                                {
                                    Dafny.ISequence<Dafny.Rune> _946___mcc_h96 = _source32.dtor_name;
                                    Dafny.ISequence<RAST._IAssignIdentifier> _947___mcc_h97 = _source32.dtor_assignments;
                                    return this;
                                }
                                else if (_source32.is_Tuple)
                                {
                                    Dafny.ISequence<RAST._IExpr> _948___mcc_h100 = _source32.dtor_arguments;
                                    return this;
                                }
                                else if (_source32.is_UnaryOp)
                                {
                                    Dafny.ISequence<Dafny.Rune> _949___mcc_h102 = _source32.dtor_op1;
                                    RAST._IExpr _950___mcc_h103 = _source32.dtor_underlying;
                                    DAST.Format._IUnaryOpFormat _951___mcc_h104 = _source32.dtor_format;
                                    return this;
                                }
                                else if (_source32.is_BinaryOp)
                                {
                                    Dafny.ISequence<Dafny.Rune> _952___mcc_h108 = _source32.dtor_op2;
                                    RAST._IExpr _953___mcc_h109 = _source32.dtor_left;
                                    RAST._IExpr _954___mcc_h110 = _source32.dtor_right;
                                    DAST.Format._IBinaryOpFormat _955___mcc_h111 = _source32.dtor_format2;
                                    return this;
                                }
                                else if (_source32.is_TypeAscription)
                                {
                                    RAST._IExpr _956___mcc_h116 = _source32.dtor_left;
                                    RAST._IType _957___mcc_h117 = _source32.dtor_tpe;
                                    return this;
                                }
                                else if (_source32.is_LiteralInt)
                                {
                                    Dafny.ISequence<Dafny.Rune> _958___mcc_h120 = _source32.dtor_value;
                                    return this;
                                }
                                else if (_source32.is_LiteralString)
                                {
                                    Dafny.ISequence<Dafny.Rune> _959___mcc_h122 = _source32.dtor_value;
                                    bool _960___mcc_h123 = _source32.dtor_binary;
                                    return this;
                                }
                                else if (_source32.is_ConversionNum)
                                {
                                    RAST._IType _961___mcc_h126 = _source32.dtor_tpe;
                                    RAST._IExpr _962___mcc_h127 = _source32.dtor_underlying;
                                    return this;
                                }
                                else if (_source32.is_DeclareVar)
                                {
                                    RAST._IDeclareType _963___mcc_h130 = _source32.dtor_declareType;
                                    Dafny.ISequence<Dafny.Rune> _964___mcc_h131 = _source32.dtor_name;
                                    Std.Wrappers._IOption<RAST._IType> _965___mcc_h132 = _source32.dtor_optType;
                                    Std.Wrappers._IOption<RAST._IExpr> _966___mcc_h133 = _source32.dtor_optRhs;
                                    return this;
                                }
                                else if (_source32.is_AssignVar)
                                {
                                    Dafny.ISequence<Dafny.Rune> _967___mcc_h138 = _source32.dtor_name;
                                    RAST._IExpr _968___mcc_h139 = _source32.dtor_rhs;
                                    RAST._IExpr _969_last = _938___mcc_h79;
                                    RAST._IExpr _970_rhs = _968___mcc_h139;
                                    Dafny.ISequence<Dafny.Rune> _971_name2 = _967___mcc_h138;
                                    RAST._IType _972_tpe = _932___mcc_h68;
                                    Dafny.ISequence<Dafny.Rune> _973_name = _929___mcc_h61;
                                    RAST._IDeclareType _974_mod = _928___mcc_h60;
                                    if ((_973_name).Equals(_971_name2))
                                    {
                                        RAST._IExpr _975_rewriting = RAST.Expr.create_StmtExpr(RAST.Expr.create_DeclareVar(_974_mod, _973_name, Std.Wrappers.Option<RAST._IType>.create_Some(_972_tpe), Std.Wrappers.Option<RAST._IExpr>.create_Some(_970_rhs)), _969_last);
                                        return _975_rewriting;
                                    }
                                    else
                                    {
                                        return this;
                                    }
                                }
                                else if (_source32.is_IfExpr)
                                {
                                    RAST._IExpr _976___mcc_h142 = _source32.dtor_cond;
                                    RAST._IExpr _977___mcc_h143 = _source32.dtor_thn;
                                    RAST._IExpr _978___mcc_h144 = _source32.dtor_els;
                                    return this;
                                }
                                else if (_source32.is_Loop)
                                {
                                    Std.Wrappers._IOption<RAST._IExpr> _979___mcc_h148 = _source32.dtor_optCond;
                                    RAST._IExpr _980___mcc_h149 = _source32.dtor_underlying;
                                    return this;
                                }
                                else if (_source32.is_For)
                                {
                                    Dafny.ISequence<Dafny.Rune> _981___mcc_h152 = _source32.dtor_name;
                                    RAST._IExpr _982___mcc_h153 = _source32.dtor_range;
                                    RAST._IExpr _983___mcc_h154 = _source32.dtor_body;
                                    return this;
                                }
                                else if (_source32.is_Labelled)
                                {
                                    Dafny.ISequence<Dafny.Rune> _984___mcc_h158 = _source32.dtor_lbl;
                                    RAST._IExpr _985___mcc_h159 = _source32.dtor_underlying;
                                    return this;
                                }
                                else if (_source32.is_Break)
                                {
                                    Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _986___mcc_h162 = _source32.dtor_optLbl;
                                    return this;
                                }
                                else if (_source32.is_Continue)
                                {
                                    Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _987___mcc_h164 = _source32.dtor_optLbl;
                                    return this;
                                }
                                else if (_source32.is_Return)
                                {
                                    Std.Wrappers._IOption<RAST._IExpr> _988___mcc_h166 = _source32.dtor_optExpr;
                                    return this;
                                }
                                else if (_source32.is_Call)
                                {
                                    RAST._IExpr _989___mcc_h168 = _source32.dtor_obj;
                                    Dafny.ISequence<RAST._IType> _990___mcc_h169 = _source32.dtor_typeParameters;
                                    Dafny.ISequence<RAST._IExpr> _991___mcc_h170 = _source32.dtor_arguments;
                                    return this;
                                }
                                else if (_source32.is_Select)
                                {
                                    RAST._IExpr _992___mcc_h174 = _source32.dtor_obj;
                                    Dafny.ISequence<Dafny.Rune> _993___mcc_h175 = _source32.dtor_name;
                                    return this;
                                }
                                else
                                {
                                    RAST._IExpr _994___mcc_h178 = _source32.dtor_obj;
                                    Dafny.ISequence<Dafny.Rune> _995___mcc_h179 = _source32.dtor_name;
                                    return this;
                                }
                            }
                            else if (_source31.is_Block)
                            {
                                RAST._IExpr _996___mcc_h182 = _source31.dtor_underlying;
                                return this;
                            }
                            else if (_source31.is_StructBuild)
                            {
                                Dafny.ISequence<Dafny.Rune> _997___mcc_h184 = _source31.dtor_name;
                                Dafny.ISequence<RAST._IAssignIdentifier> _998___mcc_h185 = _source31.dtor_assignments;
                                return this;
                            }
                            else if (_source31.is_Tuple)
                            {
                                Dafny.ISequence<RAST._IExpr> _999___mcc_h188 = _source31.dtor_arguments;
                                return this;
                            }
                            else if (_source31.is_UnaryOp)
                            {
                                Dafny.ISequence<Dafny.Rune> _1000___mcc_h190 = _source31.dtor_op1;
                                RAST._IExpr _1001___mcc_h191 = _source31.dtor_underlying;
                                DAST.Format._IUnaryOpFormat _1002___mcc_h192 = _source31.dtor_format;
                                return this;
                            }
                            else if (_source31.is_BinaryOp)
                            {
                                Dafny.ISequence<Dafny.Rune> _1003___mcc_h196 = _source31.dtor_op2;
                                RAST._IExpr _1004___mcc_h197 = _source31.dtor_left;
                                RAST._IExpr _1005___mcc_h198 = _source31.dtor_right;
                                DAST.Format._IBinaryOpFormat _1006___mcc_h199 = _source31.dtor_format2;
                                return this;
                            }
                            else if (_source31.is_TypeAscription)
                            {
                                RAST._IExpr _1007___mcc_h204 = _source31.dtor_left;
                                RAST._IType _1008___mcc_h205 = _source31.dtor_tpe;
                                return this;
                            }
                            else if (_source31.is_LiteralInt)
                            {
                                Dafny.ISequence<Dafny.Rune> _1009___mcc_h208 = _source31.dtor_value;
                                return this;
                            }
                            else if (_source31.is_LiteralString)
                            {
                                Dafny.ISequence<Dafny.Rune> _1010___mcc_h210 = _source31.dtor_value;
                                bool _1011___mcc_h211 = _source31.dtor_binary;
                                return this;
                            }
                            else if (_source31.is_ConversionNum)
                            {
                                RAST._IType _1012___mcc_h214 = _source31.dtor_tpe;
                                RAST._IExpr _1013___mcc_h215 = _source31.dtor_underlying;
                                return this;
                            }
                            else if (_source31.is_DeclareVar)
                            {
                                RAST._IDeclareType _1014___mcc_h218 = _source31.dtor_declareType;
                                Dafny.ISequence<Dafny.Rune> _1015___mcc_h219 = _source31.dtor_name;
                                Std.Wrappers._IOption<RAST._IType> _1016___mcc_h220 = _source31.dtor_optType;
                                Std.Wrappers._IOption<RAST._IExpr> _1017___mcc_h221 = _source31.dtor_optRhs;
                                return this;
                            }
                            else if (_source31.is_AssignVar)
                            {
                                Dafny.ISequence<Dafny.Rune> _1018___mcc_h226 = _source31.dtor_name;
                                RAST._IExpr _1019___mcc_h227 = _source31.dtor_rhs;
                                return this;
                            }
                            else if (_source31.is_IfExpr)
                            {
                                RAST._IExpr _1020___mcc_h230 = _source31.dtor_cond;
                                RAST._IExpr _1021___mcc_h231 = _source31.dtor_thn;
                                RAST._IExpr _1022___mcc_h232 = _source31.dtor_els;
                                return this;
                            }
                            else if (_source31.is_Loop)
                            {
                                Std.Wrappers._IOption<RAST._IExpr> _1023___mcc_h236 = _source31.dtor_optCond;
                                RAST._IExpr _1024___mcc_h237 = _source31.dtor_underlying;
                                return this;
                            }
                            else if (_source31.is_For)
                            {
                                Dafny.ISequence<Dafny.Rune> _1025___mcc_h240 = _source31.dtor_name;
                                RAST._IExpr _1026___mcc_h241 = _source31.dtor_range;
                                RAST._IExpr _1027___mcc_h242 = _source31.dtor_body;
                                return this;
                            }
                            else if (_source31.is_Labelled)
                            {
                                Dafny.ISequence<Dafny.Rune> _1028___mcc_h246 = _source31.dtor_lbl;
                                RAST._IExpr _1029___mcc_h247 = _source31.dtor_underlying;
                                return this;
                            }
                            else if (_source31.is_Break)
                            {
                                Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1030___mcc_h250 = _source31.dtor_optLbl;
                                return this;
                            }
                            else if (_source31.is_Continue)
                            {
                                Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1031___mcc_h252 = _source31.dtor_optLbl;
                                return this;
                            }
                            else if (_source31.is_Return)
                            {
                                Std.Wrappers._IOption<RAST._IExpr> _1032___mcc_h254 = _source31.dtor_optExpr;
                                return this;
                            }
                            else if (_source31.is_Call)
                            {
                                RAST._IExpr _1033___mcc_h256 = _source31.dtor_obj;
                                Dafny.ISequence<RAST._IType> _1034___mcc_h257 = _source31.dtor_typeParameters;
                                Dafny.ISequence<RAST._IExpr> _1035___mcc_h258 = _source31.dtor_arguments;
                                return this;
                            }
                            else if (_source31.is_Select)
                            {
                                RAST._IExpr _1036___mcc_h262 = _source31.dtor_obj;
                                Dafny.ISequence<Dafny.Rune> _1037___mcc_h263 = _source31.dtor_name;
                                return this;
                            }
                            else
                            {
                                RAST._IExpr _1038___mcc_h266 = _source31.dtor_obj;
                                Dafny.ISequence<Dafny.Rune> _1039___mcc_h267 = _source31.dtor_name;
                                return this;
                            }
                        }
                        else
                        {
                            RAST._IExpr _1040___mcc_h270 = _source30.dtor_value;
                            return this;
                        }
                    }
                }
                else if (_source28.is_AssignVar)
                {
                    Dafny.ISequence<Dafny.Rune> _1041___mcc_h272 = _source28.dtor_name;
                    RAST._IExpr _1042___mcc_h273 = _source28.dtor_rhs;
                    return this;
                }
                else if (_source28.is_IfExpr)
                {
                    RAST._IExpr _1043___mcc_h276 = _source28.dtor_cond;
                    RAST._IExpr _1044___mcc_h277 = _source28.dtor_thn;
                    RAST._IExpr _1045___mcc_h278 = _source28.dtor_els;
                    return this;
                }
                else if (_source28.is_Loop)
                {
                    Std.Wrappers._IOption<RAST._IExpr> _1046___mcc_h282 = _source28.dtor_optCond;
                    RAST._IExpr _1047___mcc_h283 = _source28.dtor_underlying;
                    return this;
                }
                else if (_source28.is_For)
                {
                    Dafny.ISequence<Dafny.Rune> _1048___mcc_h286 = _source28.dtor_name;
                    RAST._IExpr _1049___mcc_h287 = _source28.dtor_range;
                    RAST._IExpr _1050___mcc_h288 = _source28.dtor_body;
                    return this;
                }
                else if (_source28.is_Labelled)
                {
                    Dafny.ISequence<Dafny.Rune> _1051___mcc_h292 = _source28.dtor_lbl;
                    RAST._IExpr _1052___mcc_h293 = _source28.dtor_underlying;
                    return this;
                }
                else if (_source28.is_Break)
                {
                    Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1053___mcc_h296 = _source28.dtor_optLbl;
                    return this;
                }
                else if (_source28.is_Continue)
                {
                    Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1054___mcc_h298 = _source28.dtor_optLbl;
                    return this;
                }
                else if (_source28.is_Return)
                {
                    Std.Wrappers._IOption<RAST._IExpr> _1055___mcc_h300 = _source28.dtor_optExpr;
                    return this;
                }
                else if (_source28.is_Call)
                {
                    RAST._IExpr _1056___mcc_h302 = _source28.dtor_obj;
                    Dafny.ISequence<RAST._IType> _1057___mcc_h303 = _source28.dtor_typeParameters;
                    Dafny.ISequence<RAST._IExpr> _1058___mcc_h304 = _source28.dtor_arguments;
                    return this;
                }
                else if (_source28.is_Select)
                {
                    RAST._IExpr _1059___mcc_h308 = _source28.dtor_obj;
                    Dafny.ISequence<Dafny.Rune> _1060___mcc_h309 = _source28.dtor_name;
                    return this;
                }
                else
                {
                    RAST._IExpr _1061___mcc_h312 = _source28.dtor_obj;
                    Dafny.ISequence<Dafny.Rune> _1062___mcc_h313 = _source28.dtor_name;
                    return this;
                }
            }
            else if (_source27.is_Block)
            {
                RAST._IExpr _1063___mcc_h316 = _source27.dtor_underlying;
                return this;
            }
            else if (_source27.is_StructBuild)
            {
                Dafny.ISequence<Dafny.Rune> _1064___mcc_h318 = _source27.dtor_name;
                Dafny.ISequence<RAST._IAssignIdentifier> _1065___mcc_h319 = _source27.dtor_assignments;
                return this;
            }
            else if (_source27.is_Tuple)
            {
                Dafny.ISequence<RAST._IExpr> _1066___mcc_h322 = _source27.dtor_arguments;
                return this;
            }
            else if (_source27.is_UnaryOp)
            {
                Dafny.ISequence<Dafny.Rune> _1067___mcc_h324 = _source27.dtor_op1;
                RAST._IExpr _1068___mcc_h325 = _source27.dtor_underlying;
                DAST.Format._IUnaryOpFormat _1069___mcc_h326 = _source27.dtor_format;
                if (object.Equals(_1067___mcc_h324, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3588L, "&"))))
                {
                    RAST._IExpr _source33 = _1068___mcc_h325;
                    if (_source33.is_RawExpr)
                    {
                        Dafny.ISequence<Dafny.Rune> _1070___mcc_h330 = _source33.dtor_content;
                        return this;
                    }
                    else if (_source33.is_Identifier)
                    {
                        Dafny.ISequence<Dafny.Rune> _1071___mcc_h332 = _source33.dtor_name;
                        return this;
                    }
                    else if (_source33.is_Match)
                    {
                        RAST._IExpr _1072___mcc_h334 = _source33.dtor_matchee;
                        Dafny.ISequence<RAST._IMatchCase> _1073___mcc_h335 = _source33.dtor_cases;
                        return this;
                    }
                    else if (_source33.is_StmtExpr)
                    {
                        RAST._IExpr _1074___mcc_h338 = _source33.dtor_stmt;
                        RAST._IExpr _1075___mcc_h339 = _source33.dtor_rhs;
                        return this;
                    }
                    else if (_source33.is_Block)
                    {
                        RAST._IExpr _1076___mcc_h342 = _source33.dtor_underlying;
                        return this;
                    }
                    else if (_source33.is_StructBuild)
                    {
                        Dafny.ISequence<Dafny.Rune> _1077___mcc_h344 = _source33.dtor_name;
                        Dafny.ISequence<RAST._IAssignIdentifier> _1078___mcc_h345 = _source33.dtor_assignments;
                        return this;
                    }
                    else if (_source33.is_Tuple)
                    {
                        Dafny.ISequence<RAST._IExpr> _1079___mcc_h348 = _source33.dtor_arguments;
                        return this;
                    }
                    else if (_source33.is_UnaryOp)
                    {
                        Dafny.ISequence<Dafny.Rune> _1080___mcc_h350 = _source33.dtor_op1;
                        RAST._IExpr _1081___mcc_h351 = _source33.dtor_underlying;
                        DAST.Format._IUnaryOpFormat _1082___mcc_h352 = _source33.dtor_format;
                        return this;
                    }
                    else if (_source33.is_BinaryOp)
                    {
                        Dafny.ISequence<Dafny.Rune> _1083___mcc_h356 = _source33.dtor_op2;
                        RAST._IExpr _1084___mcc_h357 = _source33.dtor_left;
                        RAST._IExpr _1085___mcc_h358 = _source33.dtor_right;
                        DAST.Format._IBinaryOpFormat _1086___mcc_h359 = _source33.dtor_format2;
                        return this;
                    }
                    else if (_source33.is_TypeAscription)
                    {
                        RAST._IExpr _1087___mcc_h364 = _source33.dtor_left;
                        RAST._IType _1088___mcc_h365 = _source33.dtor_tpe;
                        return this;
                    }
                    else if (_source33.is_LiteralInt)
                    {
                        Dafny.ISequence<Dafny.Rune> _1089___mcc_h368 = _source33.dtor_value;
                        return this;
                    }
                    else if (_source33.is_LiteralString)
                    {
                        Dafny.ISequence<Dafny.Rune> _1090___mcc_h370 = _source33.dtor_value;
                        bool _1091___mcc_h371 = _source33.dtor_binary;
                        return this;
                    }
                    else if (_source33.is_ConversionNum)
                    {
                        RAST._IType _1092___mcc_h374 = _source33.dtor_tpe;
                        RAST._IExpr _1093___mcc_h375 = _source33.dtor_underlying;
                        return this;
                    }
                    else if (_source33.is_DeclareVar)
                    {
                        RAST._IDeclareType _1094___mcc_h378 = _source33.dtor_declareType;
                        Dafny.ISequence<Dafny.Rune> _1095___mcc_h379 = _source33.dtor_name;
                        Std.Wrappers._IOption<RAST._IType> _1096___mcc_h380 = _source33.dtor_optType;
                        Std.Wrappers._IOption<RAST._IExpr> _1097___mcc_h381 = _source33.dtor_optRhs;
                        return this;
                    }
                    else if (_source33.is_AssignVar)
                    {
                        Dafny.ISequence<Dafny.Rune> _1098___mcc_h386 = _source33.dtor_name;
                        RAST._IExpr _1099___mcc_h387 = _source33.dtor_rhs;
                        return this;
                    }
                    else if (_source33.is_IfExpr)
                    {
                        RAST._IExpr _1100___mcc_h390 = _source33.dtor_cond;
                        RAST._IExpr _1101___mcc_h391 = _source33.dtor_thn;
                        RAST._IExpr _1102___mcc_h392 = _source33.dtor_els;
                        return this;
                    }
                    else if (_source33.is_Loop)
                    {
                        Std.Wrappers._IOption<RAST._IExpr> _1103___mcc_h396 = _source33.dtor_optCond;
                        RAST._IExpr _1104___mcc_h397 = _source33.dtor_underlying;
                        return this;
                    }
                    else if (_source33.is_For)
                    {
                        Dafny.ISequence<Dafny.Rune> _1105___mcc_h400 = _source33.dtor_name;
                        RAST._IExpr _1106___mcc_h401 = _source33.dtor_range;
                        RAST._IExpr _1107___mcc_h402 = _source33.dtor_body;
                        return this;
                    }
                    else if (_source33.is_Labelled)
                    {
                        Dafny.ISequence<Dafny.Rune> _1108___mcc_h406 = _source33.dtor_lbl;
                        RAST._IExpr _1109___mcc_h407 = _source33.dtor_underlying;
                        return this;
                    }
                    else if (_source33.is_Break)
                    {
                        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1110___mcc_h410 = _source33.dtor_optLbl;
                        return this;
                    }
                    else if (_source33.is_Continue)
                    {
                        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1111___mcc_h412 = _source33.dtor_optLbl;
                        return this;
                    }
                    else if (_source33.is_Return)
                    {
                        Std.Wrappers._IOption<RAST._IExpr> _1112___mcc_h414 = _source33.dtor_optExpr;
                        return this;
                    }
                    else if (_source33.is_Call)
                    {
                        RAST._IExpr _1113___mcc_h416 = _source33.dtor_obj;
                        Dafny.ISequence<RAST._IType> _1114___mcc_h417 = _source33.dtor_typeParameters;
                        Dafny.ISequence<RAST._IExpr> _1115___mcc_h418 = _source33.dtor_arguments;
                        RAST._IExpr _source34 = _1113___mcc_h416;
                        if (_source34.is_RawExpr)
                        {
                            Dafny.ISequence<Dafny.Rune> _1116___mcc_h422 = _source34.dtor_content;
                            return this;
                        }
                        else if (_source34.is_Identifier)
                        {
                            Dafny.ISequence<Dafny.Rune> _1117___mcc_h424 = _source34.dtor_name;
                            return this;
                        }
                        else if (_source34.is_Match)
                        {
                            RAST._IExpr _1118___mcc_h426 = _source34.dtor_matchee;
                            Dafny.ISequence<RAST._IMatchCase> _1119___mcc_h427 = _source34.dtor_cases;
                            return this;
                        }
                        else if (_source34.is_StmtExpr)
                        {
                            RAST._IExpr _1120___mcc_h430 = _source34.dtor_stmt;
                            RAST._IExpr _1121___mcc_h431 = _source34.dtor_rhs;
                            return this;
                        }
                        else if (_source34.is_Block)
                        {
                            RAST._IExpr _1122___mcc_h434 = _source34.dtor_underlying;
                            return this;
                        }
                        else if (_source34.is_StructBuild)
                        {
                            Dafny.ISequence<Dafny.Rune> _1123___mcc_h436 = _source34.dtor_name;
                            Dafny.ISequence<RAST._IAssignIdentifier> _1124___mcc_h437 = _source34.dtor_assignments;
                            return this;
                        }
                        else if (_source34.is_Tuple)
                        {
                            Dafny.ISequence<RAST._IExpr> _1125___mcc_h440 = _source34.dtor_arguments;
                            return this;
                        }
                        else if (_source34.is_UnaryOp)
                        {
                            Dafny.ISequence<Dafny.Rune> _1126___mcc_h442 = _source34.dtor_op1;
                            RAST._IExpr _1127___mcc_h443 = _source34.dtor_underlying;
                            DAST.Format._IUnaryOpFormat _1128___mcc_h444 = _source34.dtor_format;
                            return this;
                        }
                        else if (_source34.is_BinaryOp)
                        {
                            Dafny.ISequence<Dafny.Rune> _1129___mcc_h448 = _source34.dtor_op2;
                            RAST._IExpr _1130___mcc_h449 = _source34.dtor_left;
                            RAST._IExpr _1131___mcc_h450 = _source34.dtor_right;
                            DAST.Format._IBinaryOpFormat _1132___mcc_h451 = _source34.dtor_format2;
                            return this;
                        }
                        else if (_source34.is_TypeAscription)
                        {
                            RAST._IExpr _1133___mcc_h456 = _source34.dtor_left;
                            RAST._IType _1134___mcc_h457 = _source34.dtor_tpe;
                            return this;
                        }
                        else if (_source34.is_LiteralInt)
                        {
                            Dafny.ISequence<Dafny.Rune> _1135___mcc_h460 = _source34.dtor_value;
                            return this;
                        }
                        else if (_source34.is_LiteralString)
                        {
                            Dafny.ISequence<Dafny.Rune> _1136___mcc_h462 = _source34.dtor_value;
                            bool _1137___mcc_h463 = _source34.dtor_binary;
                            return this;
                        }
                        else if (_source34.is_ConversionNum)
                        {
                            RAST._IType _1138___mcc_h466 = _source34.dtor_tpe;
                            RAST._IExpr _1139___mcc_h467 = _source34.dtor_underlying;
                            return this;
                        }
                        else if (_source34.is_DeclareVar)
                        {
                            RAST._IDeclareType _1140___mcc_h470 = _source34.dtor_declareType;
                            Dafny.ISequence<Dafny.Rune> _1141___mcc_h471 = _source34.dtor_name;
                            Std.Wrappers._IOption<RAST._IType> _1142___mcc_h472 = _source34.dtor_optType;
                            Std.Wrappers._IOption<RAST._IExpr> _1143___mcc_h473 = _source34.dtor_optRhs;
                            return this;
                        }
                        else if (_source34.is_AssignVar)
                        {
                            Dafny.ISequence<Dafny.Rune> _1144___mcc_h478 = _source34.dtor_name;
                            RAST._IExpr _1145___mcc_h479 = _source34.dtor_rhs;
                            return this;
                        }
                        else if (_source34.is_IfExpr)
                        {
                            RAST._IExpr _1146___mcc_h482 = _source34.dtor_cond;
                            RAST._IExpr _1147___mcc_h483 = _source34.dtor_thn;
                            RAST._IExpr _1148___mcc_h484 = _source34.dtor_els;
                            return this;
                        }
                        else if (_source34.is_Loop)
                        {
                            Std.Wrappers._IOption<RAST._IExpr> _1149___mcc_h488 = _source34.dtor_optCond;
                            RAST._IExpr _1150___mcc_h489 = _source34.dtor_underlying;
                            return this;
                        }
                        else if (_source34.is_For)
                        {
                            Dafny.ISequence<Dafny.Rune> _1151___mcc_h492 = _source34.dtor_name;
                            RAST._IExpr _1152___mcc_h493 = _source34.dtor_range;
                            RAST._IExpr _1153___mcc_h494 = _source34.dtor_body;
                            return this;
                        }
                        else if (_source34.is_Labelled)
                        {
                            Dafny.ISequence<Dafny.Rune> _1154___mcc_h498 = _source34.dtor_lbl;
                            RAST._IExpr _1155___mcc_h499 = _source34.dtor_underlying;
                            return this;
                        }
                        else if (_source34.is_Break)
                        {
                            Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1156___mcc_h502 = _source34.dtor_optLbl;
                            return this;
                        }
                        else if (_source34.is_Continue)
                        {
                            Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1157___mcc_h504 = _source34.dtor_optLbl;
                            return this;
                        }
                        else if (_source34.is_Return)
                        {
                            Std.Wrappers._IOption<RAST._IExpr> _1158___mcc_h506 = _source34.dtor_optExpr;
                            return this;
                        }
                        else if (_source34.is_Call)
                        {
                            RAST._IExpr _1159___mcc_h508 = _source34.dtor_obj;
                            Dafny.ISequence<RAST._IType> _1160___mcc_h509 = _source34.dtor_typeParameters;
                            Dafny.ISequence<RAST._IExpr> _1161___mcc_h510 = _source34.dtor_arguments;
                            return this;
                        }
                        else if (_source34.is_Select)
                        {
                            RAST._IExpr _1162___mcc_h514 = _source34.dtor_obj;
                            Dafny.ISequence<Dafny.Rune> _1163___mcc_h515 = _source34.dtor_name;
                            if (object.Equals(_1163___mcc_h515, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3589L, "clone"))))
                            {
                                DAST.Format._IUnaryOpFormat _1164_format = _1069___mcc_h326;
                                Dafny.ISequence<RAST._IExpr> _1165_args = _1115___mcc_h418;
                                Dafny.ISequence<RAST._IType> _1166_typeArgs = _1114___mcc_h417;
                                RAST._IExpr _1167_underlying = _1162___mcc_h514;
                                if (MutateCSharp.Schemata278.ReplaceBinExprOp_5(3590L, () => ((_1166_typeArgs).Equals(Dafny.Sequence<RAST._IType>.FromElements())), () => ((_1165_args).Equals(Dafny.Sequence<RAST._IExpr>.FromElements()))))
                                {
                                    return RAST.Expr.create_UnaryOp(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3596L, "&")), _1167_underlying, _1164_format);
                                }
                                else
                                {
                                    return this;
                                }
                            }
                            else
                            {
                                return this;
                            }
                        }
                        else
                        {
                            RAST._IExpr _1168___mcc_h518 = _source34.dtor_obj;
                            Dafny.ISequence<Dafny.Rune> _1169___mcc_h519 = _source34.dtor_name;
                            return this;
                        }
                    }
                    else if (_source33.is_Select)
                    {
                        RAST._IExpr _1170___mcc_h522 = _source33.dtor_obj;
                        Dafny.ISequence<Dafny.Rune> _1171___mcc_h523 = _source33.dtor_name;
                        return this;
                    }
                    else
                    {
                        RAST._IExpr _1172___mcc_h526 = _source33.dtor_obj;
                        Dafny.ISequence<Dafny.Rune> _1173___mcc_h527 = _source33.dtor_name;
                        return this;
                    }
                }
                else if (object.Equals(_1067___mcc_h324, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3597L, "!"))))
                {
                    RAST._IExpr _source35 = _1068___mcc_h325;
                    if (_source35.is_RawExpr)
                    {
                        Dafny.ISequence<Dafny.Rune> _1174___mcc_h530 = _source35.dtor_content;
                        return this;
                    }
                    else if (_source35.is_Identifier)
                    {
                        Dafny.ISequence<Dafny.Rune> _1175___mcc_h532 = _source35.dtor_name;
                        return this;
                    }
                    else if (_source35.is_Match)
                    {
                        RAST._IExpr _1176___mcc_h534 = _source35.dtor_matchee;
                        Dafny.ISequence<RAST._IMatchCase> _1177___mcc_h535 = _source35.dtor_cases;
                        return this;
                    }
                    else if (_source35.is_StmtExpr)
                    {
                        RAST._IExpr _1178___mcc_h538 = _source35.dtor_stmt;
                        RAST._IExpr _1179___mcc_h539 = _source35.dtor_rhs;
                        return this;
                    }
                    else if (_source35.is_Block)
                    {
                        RAST._IExpr _1180___mcc_h542 = _source35.dtor_underlying;
                        return this;
                    }
                    else if (_source35.is_StructBuild)
                    {
                        Dafny.ISequence<Dafny.Rune> _1181___mcc_h544 = _source35.dtor_name;
                        Dafny.ISequence<RAST._IAssignIdentifier> _1182___mcc_h545 = _source35.dtor_assignments;
                        return this;
                    }
                    else if (_source35.is_Tuple)
                    {
                        Dafny.ISequence<RAST._IExpr> _1183___mcc_h548 = _source35.dtor_arguments;
                        return this;
                    }
                    else if (_source35.is_UnaryOp)
                    {
                        Dafny.ISequence<Dafny.Rune> _1184___mcc_h550 = _source35.dtor_op1;
                        RAST._IExpr _1185___mcc_h551 = _source35.dtor_underlying;
                        DAST.Format._IUnaryOpFormat _1186___mcc_h552 = _source35.dtor_format;
                        return this;
                    }
                    else if (_source35.is_BinaryOp)
                    {
                        Dafny.ISequence<Dafny.Rune> _1187___mcc_h556 = _source35.dtor_op2;
                        RAST._IExpr _1188___mcc_h557 = _source35.dtor_left;
                        RAST._IExpr _1189___mcc_h558 = _source35.dtor_right;
                        DAST.Format._IBinaryOpFormat _1190___mcc_h559 = _source35.dtor_format2;
                        if (object.Equals(_1187___mcc_h556, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3598L, "=="))))
                        {
                            DAST.Format._IUnaryOpFormat _source36 = _1069___mcc_h326;
                            if (_source36.is_NoFormat)
                            {
                                return this;
                            }
                            else
                            {
                                DAST.Format._IBinaryOpFormat _1191_format = _1190___mcc_h559;
                                RAST._IExpr _1192_right = _1189___mcc_h558;
                                RAST._IExpr _1193_left = _1188___mcc_h557;
                                return RAST.Expr.create_BinaryOp(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3599L, "!=")), _1193_left, _1192_right, DAST.Format.BinaryOpFormat.create_NoFormat());
                            }
                        }
                        else if (object.Equals(_1187___mcc_h556, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3600L, "<"))))
                        {
                            DAST.Format._IBinaryOpFormat _source37 = _1190___mcc_h559;
                            if (_source37.is_NoFormat)
                            {
                                DAST.Format._IUnaryOpFormat _source38 = _1069___mcc_h326;
                                if (_source38.is_NoFormat)
                                {
                                    return this;
                                }
                                else
                                {
                                    RAST._IExpr _1194_right = _1189___mcc_h558;
                                    RAST._IExpr _1195_left = _1188___mcc_h557;
                                    return RAST.Expr.create_BinaryOp(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3601L, ">=")), _1195_left, _1194_right, DAST.Format.BinaryOpFormat.create_NoFormat());
                                }
                            }
                            else if (_source37.is_ImpliesFormat)
                            {
                                return this;
                            }
                            else if (_source37.is_EquivalenceFormat)
                            {
                                return this;
                            }
                            else
                            {
                                DAST.Format._IUnaryOpFormat _source39 = _1069___mcc_h326;
                                if (_source39.is_NoFormat)
                                {
                                    return this;
                                }
                                else
                                {
                                    RAST._IExpr _1196_right = _1189___mcc_h558;
                                    RAST._IExpr _1197_left = _1188___mcc_h557;
                                    return RAST.Expr.create_BinaryOp(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3602L, "<=")), _1196_right, _1197_left, DAST.Format.BinaryOpFormat.create_NoFormat());
                                }
                            }
                        }
                        else
                        {
                            return this;
                        }
                    }
                    else if (_source35.is_TypeAscription)
                    {
                        RAST._IExpr _1198___mcc_h564 = _source35.dtor_left;
                        RAST._IType _1199___mcc_h565 = _source35.dtor_tpe;
                        return this;
                    }
                    else if (_source35.is_LiteralInt)
                    {
                        Dafny.ISequence<Dafny.Rune> _1200___mcc_h568 = _source35.dtor_value;
                        return this;
                    }
                    else if (_source35.is_LiteralString)
                    {
                        Dafny.ISequence<Dafny.Rune> _1201___mcc_h570 = _source35.dtor_value;
                        bool _1202___mcc_h571 = _source35.dtor_binary;
                        return this;
                    }
                    else if (_source35.is_ConversionNum)
                    {
                        RAST._IType _1203___mcc_h574 = _source35.dtor_tpe;
                        RAST._IExpr _1204___mcc_h575 = _source35.dtor_underlying;
                        return this;
                    }
                    else if (_source35.is_DeclareVar)
                    {
                        RAST._IDeclareType _1205___mcc_h578 = _source35.dtor_declareType;
                        Dafny.ISequence<Dafny.Rune> _1206___mcc_h579 = _source35.dtor_name;
                        Std.Wrappers._IOption<RAST._IType> _1207___mcc_h580 = _source35.dtor_optType;
                        Std.Wrappers._IOption<RAST._IExpr> _1208___mcc_h581 = _source35.dtor_optRhs;
                        return this;
                    }
                    else if (_source35.is_AssignVar)
                    {
                        Dafny.ISequence<Dafny.Rune> _1209___mcc_h586 = _source35.dtor_name;
                        RAST._IExpr _1210___mcc_h587 = _source35.dtor_rhs;
                        return this;
                    }
                    else if (_source35.is_IfExpr)
                    {
                        RAST._IExpr _1211___mcc_h590 = _source35.dtor_cond;
                        RAST._IExpr _1212___mcc_h591 = _source35.dtor_thn;
                        RAST._IExpr _1213___mcc_h592 = _source35.dtor_els;
                        return this;
                    }
                    else if (_source35.is_Loop)
                    {
                        Std.Wrappers._IOption<RAST._IExpr> _1214___mcc_h596 = _source35.dtor_optCond;
                        RAST._IExpr _1215___mcc_h597 = _source35.dtor_underlying;
                        return this;
                    }
                    else if (_source35.is_For)
                    {
                        Dafny.ISequence<Dafny.Rune> _1216___mcc_h600 = _source35.dtor_name;
                        RAST._IExpr _1217___mcc_h601 = _source35.dtor_range;
                        RAST._IExpr _1218___mcc_h602 = _source35.dtor_body;
                        return this;
                    }
                    else if (_source35.is_Labelled)
                    {
                        Dafny.ISequence<Dafny.Rune> _1219___mcc_h606 = _source35.dtor_lbl;
                        RAST._IExpr _1220___mcc_h607 = _source35.dtor_underlying;
                        return this;
                    }
                    else if (_source35.is_Break)
                    {
                        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1221___mcc_h610 = _source35.dtor_optLbl;
                        return this;
                    }
                    else if (_source35.is_Continue)
                    {
                        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1222___mcc_h612 = _source35.dtor_optLbl;
                        return this;
                    }
                    else if (_source35.is_Return)
                    {
                        Std.Wrappers._IOption<RAST._IExpr> _1223___mcc_h614 = _source35.dtor_optExpr;
                        return this;
                    }
                    else if (_source35.is_Call)
                    {
                        RAST._IExpr _1224___mcc_h616 = _source35.dtor_obj;
                        Dafny.ISequence<RAST._IType> _1225___mcc_h617 = _source35.dtor_typeParameters;
                        Dafny.ISequence<RAST._IExpr> _1226___mcc_h618 = _source35.dtor_arguments;
                        return this;
                    }
                    else if (_source35.is_Select)
                    {
                        RAST._IExpr _1227___mcc_h622 = _source35.dtor_obj;
                        Dafny.ISequence<Dafny.Rune> _1228___mcc_h623 = _source35.dtor_name;
                        return this;
                    }
                    else
                    {
                        RAST._IExpr _1229___mcc_h626 = _source35.dtor_obj;
                        Dafny.ISequence<Dafny.Rune> _1230___mcc_h627 = _source35.dtor_name;
                        return this;
                    }
                }
                else
                {
                    return this;
                }
            }
            else if (_source27.is_BinaryOp)
            {
                Dafny.ISequence<Dafny.Rune> _1231___mcc_h630 = _source27.dtor_op2;
                RAST._IExpr _1232___mcc_h631 = _source27.dtor_left;
                RAST._IExpr _1233___mcc_h632 = _source27.dtor_right;
                DAST.Format._IBinaryOpFormat _1234___mcc_h633 = _source27.dtor_format2;
                return this;
            }
            else if (_source27.is_TypeAscription)
            {
                RAST._IExpr _1235___mcc_h638 = _source27.dtor_left;
                RAST._IType _1236___mcc_h639 = _source27.dtor_tpe;
                return this;
            }
            else if (_source27.is_LiteralInt)
            {
                Dafny.ISequence<Dafny.Rune> _1237___mcc_h642 = _source27.dtor_value;
                return this;
            }
            else if (_source27.is_LiteralString)
            {
                Dafny.ISequence<Dafny.Rune> _1238___mcc_h644 = _source27.dtor_value;
                bool _1239___mcc_h645 = _source27.dtor_binary;
                return this;
            }
            else if (_source27.is_ConversionNum)
            {
                RAST._IType _1240___mcc_h648 = _source27.dtor_tpe;
                RAST._IExpr _1241___mcc_h649 = _source27.dtor_underlying;
                RAST._IExpr _1242_expr = _1241___mcc_h649;
                RAST._IType _1243_tpe = _1240___mcc_h648;
                if (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3651L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3645L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3639L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3633L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3627L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3621L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3615L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3609L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3603L, () => ((_1243_tpe).is_U8), () => ((_1243_tpe).is_U16))), () => ((_1243_tpe).is_U32))), () => ((_1243_tpe).is_U64))), () => ((_1243_tpe).is_U128))), () => ((_1243_tpe).is_I8))), () => ((_1243_tpe).is_I16))), () => ((_1243_tpe).is_I32))), () => ((_1243_tpe).is_I64))), () => ((_1243_tpe).is_I128)))
                {
                    RAST._IExpr _source40 = _1242_expr;
                    if (_source40.is_RawExpr)
                    {
                        Dafny.ISequence<Dafny.Rune> _1244___mcc_h704 = _source40.dtor_content;
                        return this;
                    }
                    else if (_source40.is_Identifier)
                    {
                        Dafny.ISequence<Dafny.Rune> _1245___mcc_h706 = _source40.dtor_name;
                        return this;
                    }
                    else if (_source40.is_Match)
                    {
                        RAST._IExpr _1246___mcc_h708 = _source40.dtor_matchee;
                        Dafny.ISequence<RAST._IMatchCase> _1247___mcc_h709 = _source40.dtor_cases;
                        return this;
                    }
                    else if (_source40.is_StmtExpr)
                    {
                        RAST._IExpr _1248___mcc_h712 = _source40.dtor_stmt;
                        RAST._IExpr _1249___mcc_h713 = _source40.dtor_rhs;
                        return this;
                    }
                    else if (_source40.is_Block)
                    {
                        RAST._IExpr _1250___mcc_h716 = _source40.dtor_underlying;
                        return this;
                    }
                    else if (_source40.is_StructBuild)
                    {
                        Dafny.ISequence<Dafny.Rune> _1251___mcc_h718 = _source40.dtor_name;
                        Dafny.ISequence<RAST._IAssignIdentifier> _1252___mcc_h719 = _source40.dtor_assignments;
                        return this;
                    }
                    else if (_source40.is_Tuple)
                    {
                        Dafny.ISequence<RAST._IExpr> _1253___mcc_h722 = _source40.dtor_arguments;
                        return this;
                    }
                    else if (_source40.is_UnaryOp)
                    {
                        Dafny.ISequence<Dafny.Rune> _1254___mcc_h724 = _source40.dtor_op1;
                        RAST._IExpr _1255___mcc_h725 = _source40.dtor_underlying;
                        DAST.Format._IUnaryOpFormat _1256___mcc_h726 = _source40.dtor_format;
                        return this;
                    }
                    else if (_source40.is_BinaryOp)
                    {
                        Dafny.ISequence<Dafny.Rune> _1257___mcc_h730 = _source40.dtor_op2;
                        RAST._IExpr _1258___mcc_h731 = _source40.dtor_left;
                        RAST._IExpr _1259___mcc_h732 = _source40.dtor_right;
                        DAST.Format._IBinaryOpFormat _1260___mcc_h733 = _source40.dtor_format2;
                        return this;
                    }
                    else if (_source40.is_TypeAscription)
                    {
                        RAST._IExpr _1261___mcc_h738 = _source40.dtor_left;
                        RAST._IType _1262___mcc_h739 = _source40.dtor_tpe;
                        return this;
                    }
                    else if (_source40.is_LiteralInt)
                    {
                        Dafny.ISequence<Dafny.Rune> _1263___mcc_h742 = _source40.dtor_value;
                        return this;
                    }
                    else if (_source40.is_LiteralString)
                    {
                        Dafny.ISequence<Dafny.Rune> _1264___mcc_h744 = _source40.dtor_value;
                        bool _1265___mcc_h745 = _source40.dtor_binary;
                        return this;
                    }
                    else if (_source40.is_ConversionNum)
                    {
                        RAST._IType _1266___mcc_h748 = _source40.dtor_tpe;
                        RAST._IExpr _1267___mcc_h749 = _source40.dtor_underlying;
                        return this;
                    }
                    else if (_source40.is_DeclareVar)
                    {
                        RAST._IDeclareType _1268___mcc_h752 = _source40.dtor_declareType;
                        Dafny.ISequence<Dafny.Rune> _1269___mcc_h753 = _source40.dtor_name;
                        Std.Wrappers._IOption<RAST._IType> _1270___mcc_h754 = _source40.dtor_optType;
                        Std.Wrappers._IOption<RAST._IExpr> _1271___mcc_h755 = _source40.dtor_optRhs;
                        return this;
                    }
                    else if (_source40.is_AssignVar)
                    {
                        Dafny.ISequence<Dafny.Rune> _1272___mcc_h760 = _source40.dtor_name;
                        RAST._IExpr _1273___mcc_h761 = _source40.dtor_rhs;
                        return this;
                    }
                    else if (_source40.is_IfExpr)
                    {
                        RAST._IExpr _1274___mcc_h764 = _source40.dtor_cond;
                        RAST._IExpr _1275___mcc_h765 = _source40.dtor_thn;
                        RAST._IExpr _1276___mcc_h766 = _source40.dtor_els;
                        return this;
                    }
                    else if (_source40.is_Loop)
                    {
                        Std.Wrappers._IOption<RAST._IExpr> _1277___mcc_h770 = _source40.dtor_optCond;
                        RAST._IExpr _1278___mcc_h771 = _source40.dtor_underlying;
                        return this;
                    }
                    else if (_source40.is_For)
                    {
                        Dafny.ISequence<Dafny.Rune> _1279___mcc_h774 = _source40.dtor_name;
                        RAST._IExpr _1280___mcc_h775 = _source40.dtor_range;
                        RAST._IExpr _1281___mcc_h776 = _source40.dtor_body;
                        return this;
                    }
                    else if (_source40.is_Labelled)
                    {
                        Dafny.ISequence<Dafny.Rune> _1282___mcc_h780 = _source40.dtor_lbl;
                        RAST._IExpr _1283___mcc_h781 = _source40.dtor_underlying;
                        return this;
                    }
                    else if (_source40.is_Break)
                    {
                        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1284___mcc_h784 = _source40.dtor_optLbl;
                        return this;
                    }
                    else if (_source40.is_Continue)
                    {
                        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1285___mcc_h786 = _source40.dtor_optLbl;
                        return this;
                    }
                    else if (_source40.is_Return)
                    {
                        Std.Wrappers._IOption<RAST._IExpr> _1286___mcc_h788 = _source40.dtor_optExpr;
                        return this;
                    }
                    else if (_source40.is_Call)
                    {
                        RAST._IExpr _1287___mcc_h790 = _source40.dtor_obj;
                        Dafny.ISequence<RAST._IType> _1288___mcc_h791 = _source40.dtor_typeParameters;
                        Dafny.ISequence<RAST._IExpr> _1289___mcc_h792 = _source40.dtor_arguments;
                        RAST._IExpr _source41 = _1287___mcc_h790;
                        if (_source41.is_RawExpr)
                        {
                            Dafny.ISequence<Dafny.Rune> _1290___mcc_h796 = _source41.dtor_content;
                            return this;
                        }
                        else if (_source41.is_Identifier)
                        {
                            Dafny.ISequence<Dafny.Rune> _1291___mcc_h798 = _source41.dtor_name;
                            return this;
                        }
                        else if (_source41.is_Match)
                        {
                            RAST._IExpr _1292___mcc_h800 = _source41.dtor_matchee;
                            Dafny.ISequence<RAST._IMatchCase> _1293___mcc_h801 = _source41.dtor_cases;
                            return this;
                        }
                        else if (_source41.is_StmtExpr)
                        {
                            RAST._IExpr _1294___mcc_h804 = _source41.dtor_stmt;
                            RAST._IExpr _1295___mcc_h805 = _source41.dtor_rhs;
                            return this;
                        }
                        else if (_source41.is_Block)
                        {
                            RAST._IExpr _1296___mcc_h808 = _source41.dtor_underlying;
                            return this;
                        }
                        else if (_source41.is_StructBuild)
                        {
                            Dafny.ISequence<Dafny.Rune> _1297___mcc_h810 = _source41.dtor_name;
                            Dafny.ISequence<RAST._IAssignIdentifier> _1298___mcc_h811 = _source41.dtor_assignments;
                            return this;
                        }
                        else if (_source41.is_Tuple)
                        {
                            Dafny.ISequence<RAST._IExpr> _1299___mcc_h814 = _source41.dtor_arguments;
                            return this;
                        }
                        else if (_source41.is_UnaryOp)
                        {
                            Dafny.ISequence<Dafny.Rune> _1300___mcc_h816 = _source41.dtor_op1;
                            RAST._IExpr _1301___mcc_h817 = _source41.dtor_underlying;
                            DAST.Format._IUnaryOpFormat _1302___mcc_h818 = _source41.dtor_format;
                            return this;
                        }
                        else if (_source41.is_BinaryOp)
                        {
                            Dafny.ISequence<Dafny.Rune> _1303___mcc_h822 = _source41.dtor_op2;
                            RAST._IExpr _1304___mcc_h823 = _source41.dtor_left;
                            RAST._IExpr _1305___mcc_h824 = _source41.dtor_right;
                            DAST.Format._IBinaryOpFormat _1306___mcc_h825 = _source41.dtor_format2;
                            return this;
                        }
                        else if (_source41.is_TypeAscription)
                        {
                            RAST._IExpr _1307___mcc_h830 = _source41.dtor_left;
                            RAST._IType _1308___mcc_h831 = _source41.dtor_tpe;
                            return this;
                        }
                        else if (_source41.is_LiteralInt)
                        {
                            Dafny.ISequence<Dafny.Rune> _1309___mcc_h834 = _source41.dtor_value;
                            return this;
                        }
                        else if (_source41.is_LiteralString)
                        {
                            Dafny.ISequence<Dafny.Rune> _1310___mcc_h836 = _source41.dtor_value;
                            bool _1311___mcc_h837 = _source41.dtor_binary;
                            return this;
                        }
                        else if (_source41.is_ConversionNum)
                        {
                            RAST._IType _1312___mcc_h840 = _source41.dtor_tpe;
                            RAST._IExpr _1313___mcc_h841 = _source41.dtor_underlying;
                            return this;
                        }
                        else if (_source41.is_DeclareVar)
                        {
                            RAST._IDeclareType _1314___mcc_h844 = _source41.dtor_declareType;
                            Dafny.ISequence<Dafny.Rune> _1315___mcc_h845 = _source41.dtor_name;
                            Std.Wrappers._IOption<RAST._IType> _1316___mcc_h846 = _source41.dtor_optType;
                            Std.Wrappers._IOption<RAST._IExpr> _1317___mcc_h847 = _source41.dtor_optRhs;
                            return this;
                        }
                        else if (_source41.is_AssignVar)
                        {
                            Dafny.ISequence<Dafny.Rune> _1318___mcc_h852 = _source41.dtor_name;
                            RAST._IExpr _1319___mcc_h853 = _source41.dtor_rhs;
                            return this;
                        }
                        else if (_source41.is_IfExpr)
                        {
                            RAST._IExpr _1320___mcc_h856 = _source41.dtor_cond;
                            RAST._IExpr _1321___mcc_h857 = _source41.dtor_thn;
                            RAST._IExpr _1322___mcc_h858 = _source41.dtor_els;
                            return this;
                        }
                        else if (_source41.is_Loop)
                        {
                            Std.Wrappers._IOption<RAST._IExpr> _1323___mcc_h862 = _source41.dtor_optCond;
                            RAST._IExpr _1324___mcc_h863 = _source41.dtor_underlying;
                            return this;
                        }
                        else if (_source41.is_For)
                        {
                            Dafny.ISequence<Dafny.Rune> _1325___mcc_h866 = _source41.dtor_name;
                            RAST._IExpr _1326___mcc_h867 = _source41.dtor_range;
                            RAST._IExpr _1327___mcc_h868 = _source41.dtor_body;
                            return this;
                        }
                        else if (_source41.is_Labelled)
                        {
                            Dafny.ISequence<Dafny.Rune> _1328___mcc_h872 = _source41.dtor_lbl;
                            RAST._IExpr _1329___mcc_h873 = _source41.dtor_underlying;
                            return this;
                        }
                        else if (_source41.is_Break)
                        {
                            Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1330___mcc_h876 = _source41.dtor_optLbl;
                            return this;
                        }
                        else if (_source41.is_Continue)
                        {
                            Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1331___mcc_h878 = _source41.dtor_optLbl;
                            return this;
                        }
                        else if (_source41.is_Return)
                        {
                            Std.Wrappers._IOption<RAST._IExpr> _1332___mcc_h880 = _source41.dtor_optExpr;
                            return this;
                        }
                        else if (_source41.is_Call)
                        {
                            RAST._IExpr _1333___mcc_h882 = _source41.dtor_obj;
                            Dafny.ISequence<RAST._IType> _1334___mcc_h883 = _source41.dtor_typeParameters;
                            Dafny.ISequence<RAST._IExpr> _1335___mcc_h884 = _source41.dtor_arguments;
                            return this;
                        }
                        else if (_source41.is_Select)
                        {
                            RAST._IExpr _1336___mcc_h888 = _source41.dtor_obj;
                            Dafny.ISequence<Dafny.Rune> _1337___mcc_h889 = _source41.dtor_name;
                            return this;
                        }
                        else
                        {
                            RAST._IExpr _1338___mcc_h892 = _source41.dtor_obj;
                            Dafny.ISequence<Dafny.Rune> _1339___mcc_h893 = _source41.dtor_name;
                            RAST._IExpr _source42 = _1338___mcc_h892;
                            if (_source42.is_RawExpr)
                            {
                                Dafny.ISequence<Dafny.Rune> _1340___mcc_h896 = _source42.dtor_content;
                                return this;
                            }
                            else if (_source42.is_Identifier)
                            {
                                Dafny.ISequence<Dafny.Rune> _1341___mcc_h898 = _source42.dtor_name;
                                return this;
                            }
                            else if (_source42.is_Match)
                            {
                                RAST._IExpr _1342___mcc_h900 = _source42.dtor_matchee;
                                Dafny.ISequence<RAST._IMatchCase> _1343___mcc_h901 = _source42.dtor_cases;
                                return this;
                            }
                            else if (_source42.is_StmtExpr)
                            {
                                RAST._IExpr _1344___mcc_h904 = _source42.dtor_stmt;
                                RAST._IExpr _1345___mcc_h905 = _source42.dtor_rhs;
                                return this;
                            }
                            else if (_source42.is_Block)
                            {
                                RAST._IExpr _1346___mcc_h908 = _source42.dtor_underlying;
                                return this;
                            }
                            else if (_source42.is_StructBuild)
                            {
                                Dafny.ISequence<Dafny.Rune> _1347___mcc_h910 = _source42.dtor_name;
                                Dafny.ISequence<RAST._IAssignIdentifier> _1348___mcc_h911 = _source42.dtor_assignments;
                                return this;
                            }
                            else if (_source42.is_Tuple)
                            {
                                Dafny.ISequence<RAST._IExpr> _1349___mcc_h914 = _source42.dtor_arguments;
                                return this;
                            }
                            else if (_source42.is_UnaryOp)
                            {
                                Dafny.ISequence<Dafny.Rune> _1350___mcc_h916 = _source42.dtor_op1;
                                RAST._IExpr _1351___mcc_h917 = _source42.dtor_underlying;
                                DAST.Format._IUnaryOpFormat _1352___mcc_h918 = _source42.dtor_format;
                                return this;
                            }
                            else if (_source42.is_BinaryOp)
                            {
                                Dafny.ISequence<Dafny.Rune> _1353___mcc_h922 = _source42.dtor_op2;
                                RAST._IExpr _1354___mcc_h923 = _source42.dtor_left;
                                RAST._IExpr _1355___mcc_h924 = _source42.dtor_right;
                                DAST.Format._IBinaryOpFormat _1356___mcc_h925 = _source42.dtor_format2;
                                return this;
                            }
                            else if (_source42.is_TypeAscription)
                            {
                                RAST._IExpr _1357___mcc_h930 = _source42.dtor_left;
                                RAST._IType _1358___mcc_h931 = _source42.dtor_tpe;
                                return this;
                            }
                            else if (_source42.is_LiteralInt)
                            {
                                Dafny.ISequence<Dafny.Rune> _1359___mcc_h934 = _source42.dtor_value;
                                return this;
                            }
                            else if (_source42.is_LiteralString)
                            {
                                Dafny.ISequence<Dafny.Rune> _1360___mcc_h936 = _source42.dtor_value;
                                bool _1361___mcc_h937 = _source42.dtor_binary;
                                return this;
                            }
                            else if (_source42.is_ConversionNum)
                            {
                                RAST._IType _1362___mcc_h940 = _source42.dtor_tpe;
                                RAST._IExpr _1363___mcc_h941 = _source42.dtor_underlying;
                                return this;
                            }
                            else if (_source42.is_DeclareVar)
                            {
                                RAST._IDeclareType _1364___mcc_h944 = _source42.dtor_declareType;
                                Dafny.ISequence<Dafny.Rune> _1365___mcc_h945 = _source42.dtor_name;
                                Std.Wrappers._IOption<RAST._IType> _1366___mcc_h946 = _source42.dtor_optType;
                                Std.Wrappers._IOption<RAST._IExpr> _1367___mcc_h947 = _source42.dtor_optRhs;
                                return this;
                            }
                            else if (_source42.is_AssignVar)
                            {
                                Dafny.ISequence<Dafny.Rune> _1368___mcc_h952 = _source42.dtor_name;
                                RAST._IExpr _1369___mcc_h953 = _source42.dtor_rhs;
                                return this;
                            }
                            else if (_source42.is_IfExpr)
                            {
                                RAST._IExpr _1370___mcc_h956 = _source42.dtor_cond;
                                RAST._IExpr _1371___mcc_h957 = _source42.dtor_thn;
                                RAST._IExpr _1372___mcc_h958 = _source42.dtor_els;
                                return this;
                            }
                            else if (_source42.is_Loop)
                            {
                                Std.Wrappers._IOption<RAST._IExpr> _1373___mcc_h962 = _source42.dtor_optCond;
                                RAST._IExpr _1374___mcc_h963 = _source42.dtor_underlying;
                                return this;
                            }
                            else if (_source42.is_For)
                            {
                                Dafny.ISequence<Dafny.Rune> _1375___mcc_h966 = _source42.dtor_name;
                                RAST._IExpr _1376___mcc_h967 = _source42.dtor_range;
                                RAST._IExpr _1377___mcc_h968 = _source42.dtor_body;
                                return this;
                            }
                            else if (_source42.is_Labelled)
                            {
                                Dafny.ISequence<Dafny.Rune> _1378___mcc_h972 = _source42.dtor_lbl;
                                RAST._IExpr _1379___mcc_h973 = _source42.dtor_underlying;
                                return this;
                            }
                            else if (_source42.is_Break)
                            {
                                Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1380___mcc_h976 = _source42.dtor_optLbl;
                                return this;
                            }
                            else if (_source42.is_Continue)
                            {
                                Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1381___mcc_h978 = _source42.dtor_optLbl;
                                return this;
                            }
                            else if (_source42.is_Return)
                            {
                                Std.Wrappers._IOption<RAST._IExpr> _1382___mcc_h980 = _source42.dtor_optExpr;
                                return this;
                            }
                            else if (_source42.is_Call)
                            {
                                RAST._IExpr _1383___mcc_h982 = _source42.dtor_obj;
                                Dafny.ISequence<RAST._IType> _1384___mcc_h983 = _source42.dtor_typeParameters;
                                Dafny.ISequence<RAST._IExpr> _1385___mcc_h984 = _source42.dtor_arguments;
                                return this;
                            }
                            else if (_source42.is_Select)
                            {
                                RAST._IExpr _1386___mcc_h988 = _source42.dtor_obj;
                                Dafny.ISequence<Dafny.Rune> _1387___mcc_h989 = _source42.dtor_name;
                                return this;
                            }
                            else
                            {
                                RAST._IExpr _1388___mcc_h992 = _source42.dtor_obj;
                                Dafny.ISequence<Dafny.Rune> _1389___mcc_h993 = _source42.dtor_name;
                                RAST._IExpr _source43 = _1388___mcc_h992;
                                if (_source43.is_RawExpr)
                                {
                                    Dafny.ISequence<Dafny.Rune> _1390___mcc_h996 = _source43.dtor_content;
                                    return this;
                                }
                                else if (_source43.is_Identifier)
                                {
                                    Dafny.ISequence<Dafny.Rune> _1391___mcc_h998 = _source43.dtor_name;
                                    return this;
                                }
                                else if (_source43.is_Match)
                                {
                                    RAST._IExpr _1392___mcc_h1000 = _source43.dtor_matchee;
                                    Dafny.ISequence<RAST._IMatchCase> _1393___mcc_h1001 = _source43.dtor_cases;
                                    return this;
                                }
                                else if (_source43.is_StmtExpr)
                                {
                                    RAST._IExpr _1394___mcc_h1004 = _source43.dtor_stmt;
                                    RAST._IExpr _1395___mcc_h1005 = _source43.dtor_rhs;
                                    return this;
                                }
                                else if (_source43.is_Block)
                                {
                                    RAST._IExpr _1396___mcc_h1008 = _source43.dtor_underlying;
                                    return this;
                                }
                                else if (_source43.is_StructBuild)
                                {
                                    Dafny.ISequence<Dafny.Rune> _1397___mcc_h1010 = _source43.dtor_name;
                                    Dafny.ISequence<RAST._IAssignIdentifier> _1398___mcc_h1011 = _source43.dtor_assignments;
                                    return this;
                                }
                                else if (_source43.is_Tuple)
                                {
                                    Dafny.ISequence<RAST._IExpr> _1399___mcc_h1014 = _source43.dtor_arguments;
                                    return this;
                                }
                                else if (_source43.is_UnaryOp)
                                {
                                    Dafny.ISequence<Dafny.Rune> _1400___mcc_h1016 = _source43.dtor_op1;
                                    RAST._IExpr _1401___mcc_h1017 = _source43.dtor_underlying;
                                    DAST.Format._IUnaryOpFormat _1402___mcc_h1018 = _source43.dtor_format;
                                    return this;
                                }
                                else if (_source43.is_BinaryOp)
                                {
                                    Dafny.ISequence<Dafny.Rune> _1403___mcc_h1022 = _source43.dtor_op2;
                                    RAST._IExpr _1404___mcc_h1023 = _source43.dtor_left;
                                    RAST._IExpr _1405___mcc_h1024 = _source43.dtor_right;
                                    DAST.Format._IBinaryOpFormat _1406___mcc_h1025 = _source43.dtor_format2;
                                    return this;
                                }
                                else if (_source43.is_TypeAscription)
                                {
                                    RAST._IExpr _1407___mcc_h1030 = _source43.dtor_left;
                                    RAST._IType _1408___mcc_h1031 = _source43.dtor_tpe;
                                    return this;
                                }
                                else if (_source43.is_LiteralInt)
                                {
                                    Dafny.ISequence<Dafny.Rune> _1409___mcc_h1034 = _source43.dtor_value;
                                    return this;
                                }
                                else if (_source43.is_LiteralString)
                                {
                                    Dafny.ISequence<Dafny.Rune> _1410___mcc_h1036 = _source43.dtor_value;
                                    bool _1411___mcc_h1037 = _source43.dtor_binary;
                                    return this;
                                }
                                else if (_source43.is_ConversionNum)
                                {
                                    RAST._IType _1412___mcc_h1040 = _source43.dtor_tpe;
                                    RAST._IExpr _1413___mcc_h1041 = _source43.dtor_underlying;
                                    return this;
                                }
                                else if (_source43.is_DeclareVar)
                                {
                                    RAST._IDeclareType _1414___mcc_h1044 = _source43.dtor_declareType;
                                    Dafny.ISequence<Dafny.Rune> _1415___mcc_h1045 = _source43.dtor_name;
                                    Std.Wrappers._IOption<RAST._IType> _1416___mcc_h1046 = _source43.dtor_optType;
                                    Std.Wrappers._IOption<RAST._IExpr> _1417___mcc_h1047 = _source43.dtor_optRhs;
                                    return this;
                                }
                                else if (_source43.is_AssignVar)
                                {
                                    Dafny.ISequence<Dafny.Rune> _1418___mcc_h1052 = _source43.dtor_name;
                                    RAST._IExpr _1419___mcc_h1053 = _source43.dtor_rhs;
                                    return this;
                                }
                                else if (_source43.is_IfExpr)
                                {
                                    RAST._IExpr _1420___mcc_h1056 = _source43.dtor_cond;
                                    RAST._IExpr _1421___mcc_h1057 = _source43.dtor_thn;
                                    RAST._IExpr _1422___mcc_h1058 = _source43.dtor_els;
                                    return this;
                                }
                                else if (_source43.is_Loop)
                                {
                                    Std.Wrappers._IOption<RAST._IExpr> _1423___mcc_h1062 = _source43.dtor_optCond;
                                    RAST._IExpr _1424___mcc_h1063 = _source43.dtor_underlying;
                                    return this;
                                }
                                else if (_source43.is_For)
                                {
                                    Dafny.ISequence<Dafny.Rune> _1425___mcc_h1066 = _source43.dtor_name;
                                    RAST._IExpr _1426___mcc_h1067 = _source43.dtor_range;
                                    RAST._IExpr _1427___mcc_h1068 = _source43.dtor_body;
                                    return this;
                                }
                                else if (_source43.is_Labelled)
                                {
                                    Dafny.ISequence<Dafny.Rune> _1428___mcc_h1072 = _source43.dtor_lbl;
                                    RAST._IExpr _1429___mcc_h1073 = _source43.dtor_underlying;
                                    return this;
                                }
                                else if (_source43.is_Break)
                                {
                                    Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1430___mcc_h1076 = _source43.dtor_optLbl;
                                    return this;
                                }
                                else if (_source43.is_Continue)
                                {
                                    Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1431___mcc_h1078 = _source43.dtor_optLbl;
                                    return this;
                                }
                                else if (_source43.is_Return)
                                {
                                    Std.Wrappers._IOption<RAST._IExpr> _1432___mcc_h1080 = _source43.dtor_optExpr;
                                    return this;
                                }
                                else if (_source43.is_Call)
                                {
                                    RAST._IExpr _1433___mcc_h1082 = _source43.dtor_obj;
                                    Dafny.ISequence<RAST._IType> _1434___mcc_h1083 = _source43.dtor_typeParameters;
                                    Dafny.ISequence<RAST._IExpr> _1435___mcc_h1084 = _source43.dtor_arguments;
                                    return this;
                                }
                                else if (_source43.is_Select)
                                {
                                    RAST._IExpr _1436___mcc_h1088 = _source43.dtor_obj;
                                    Dafny.ISequence<Dafny.Rune> _1437___mcc_h1089 = _source43.dtor_name;
                                    return this;
                                }
                                else
                                {
                                    RAST._IExpr _1438___mcc_h1092 = _source43.dtor_obj;
                                    Dafny.ISequence<Dafny.Rune> _1439___mcc_h1093 = _source43.dtor_name;
                                    RAST._IExpr _source44 = _1438___mcc_h1092;
                                    if (_source44.is_RawExpr)
                                    {
                                        Dafny.ISequence<Dafny.Rune> _1440___mcc_h1096 = _source44.dtor_content;
                                        return this;
                                    }
                                    else if (_source44.is_Identifier)
                                    {
                                        Dafny.ISequence<Dafny.Rune> _1441___mcc_h1098 = _source44.dtor_name;
                                        if (object.Equals(_1441___mcc_h1098, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))
                                        {
                                            if (object.Equals(_1439___mcc_h1093, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3657L, "dafny_runtime"))))
                                            {
                                                if (object.Equals(_1389___mcc_h993, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3658L, "DafnyInt"))))
                                                {
                                                    if (object.Equals(_1339___mcc_h893, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3659L, "from"))))
                                                    {
                                                        Dafny.ISequence<RAST._IExpr> _1442_args = _1289___mcc_h792;
                                                        Dafny.ISequence<RAST._IType> _1443_tpe = _1288___mcc_h791;
                                                        if (MutateCSharp.Schemata278.ReplaceBinExprOp_5(3670L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_1(3664L, (new BigInteger((_1443_tpe).Count)).Sign, MutateCSharp.Schemata278.ReplaceNumericConstant_0(3660L, 0))), () => (MutateCSharp.Schemata278.ReplaceBinExprOp_68(3669L, (new BigInteger((_1442_args).Count)), (BigInteger.One)))))
                                                        {
                                                            RAST._IExpr _source45 = (_1442_args).Select(BigInteger.Zero);
                                                            if (_source45.is_RawExpr)
                                                            {
                                                                Dafny.ISequence<Dafny.Rune> _1444___mcc_h1204 = _source45.dtor_content;
                                                                return this;
                                                            }
                                                            else if (_source45.is_Identifier)
                                                            {
                                                                Dafny.ISequence<Dafny.Rune> _1445___mcc_h1206 = _source45.dtor_name;
                                                                return this;
                                                            }
                                                            else if (_source45.is_Match)
                                                            {
                                                                RAST._IExpr _1446___mcc_h1208 = _source45.dtor_matchee;
                                                                Dafny.ISequence<RAST._IMatchCase> _1447___mcc_h1209 = _source45.dtor_cases;
                                                                return this;
                                                            }
                                                            else if (_source45.is_StmtExpr)
                                                            {
                                                                RAST._IExpr _1448___mcc_h1212 = _source45.dtor_stmt;
                                                                RAST._IExpr _1449___mcc_h1213 = _source45.dtor_rhs;
                                                                return this;
                                                            }
                                                            else if (_source45.is_Block)
                                                            {
                                                                RAST._IExpr _1450___mcc_h1216 = _source45.dtor_underlying;
                                                                return this;
                                                            }
                                                            else if (_source45.is_StructBuild)
                                                            {
                                                                Dafny.ISequence<Dafny.Rune> _1451___mcc_h1218 = _source45.dtor_name;
                                                                Dafny.ISequence<RAST._IAssignIdentifier> _1452___mcc_h1219 = _source45.dtor_assignments;
                                                                return this;
                                                            }
                                                            else if (_source45.is_Tuple)
                                                            {
                                                                Dafny.ISequence<RAST._IExpr> _1453___mcc_h1222 = _source45.dtor_arguments;
                                                                return this;
                                                            }
                                                            else if (_source45.is_UnaryOp)
                                                            {
                                                                Dafny.ISequence<Dafny.Rune> _1454___mcc_h1224 = _source45.dtor_op1;
                                                                RAST._IExpr _1455___mcc_h1225 = _source45.dtor_underlying;
                                                                DAST.Format._IUnaryOpFormat _1456___mcc_h1226 = _source45.dtor_format;
                                                                return this;
                                                            }
                                                            else if (_source45.is_BinaryOp)
                                                            {
                                                                Dafny.ISequence<Dafny.Rune> _1457___mcc_h1230 = _source45.dtor_op2;
                                                                RAST._IExpr _1458___mcc_h1231 = _source45.dtor_left;
                                                                RAST._IExpr _1459___mcc_h1232 = _source45.dtor_right;
                                                                DAST.Format._IBinaryOpFormat _1460___mcc_h1233 = _source45.dtor_format2;
                                                                return this;
                                                            }
                                                            else if (_source45.is_TypeAscription)
                                                            {
                                                                RAST._IExpr _1461___mcc_h1238 = _source45.dtor_left;
                                                                RAST._IType _1462___mcc_h1239 = _source45.dtor_tpe;
                                                                return this;
                                                            }
                                                            else if (_source45.is_LiteralInt)
                                                            {
                                                                Dafny.ISequence<Dafny.Rune> _1463___mcc_h1242 = _source45.dtor_value;
                                                                Dafny.ISequence<Dafny.Rune> _1464_number = _1463___mcc_h1242;
                                                                return RAST.Expr.create_LiteralInt(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3676L, "/*optimized*/")), _1464_number));
                                                            }
                                                            else if (_source45.is_LiteralString)
                                                            {
                                                                Dafny.ISequence<Dafny.Rune> _1465___mcc_h1244 = _source45.dtor_value;
                                                                bool _1466___mcc_h1245 = _source45.dtor_binary;
                                                                Dafny.ISequence<Dafny.Rune> _1467_number = _1465___mcc_h1244;
                                                                return RAST.Expr.create_LiteralInt(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3677L, "/*optimized*/")), _1467_number));
                                                            }
                                                            else if (_source45.is_ConversionNum)
                                                            {
                                                                RAST._IType _1468___mcc_h1248 = _source45.dtor_tpe;
                                                                RAST._IExpr _1469___mcc_h1249 = _source45.dtor_underlying;
                                                                return this;
                                                            }
                                                            else if (_source45.is_DeclareVar)
                                                            {
                                                                RAST._IDeclareType _1470___mcc_h1252 = _source45.dtor_declareType;
                                                                Dafny.ISequence<Dafny.Rune> _1471___mcc_h1253 = _source45.dtor_name;
                                                                Std.Wrappers._IOption<RAST._IType> _1472___mcc_h1254 = _source45.dtor_optType;
                                                                Std.Wrappers._IOption<RAST._IExpr> _1473___mcc_h1255 = _source45.dtor_optRhs;
                                                                return this;
                                                            }
                                                            else if (_source45.is_AssignVar)
                                                            {
                                                                Dafny.ISequence<Dafny.Rune> _1474___mcc_h1260 = _source45.dtor_name;
                                                                RAST._IExpr _1475___mcc_h1261 = _source45.dtor_rhs;
                                                                return this;
                                                            }
                                                            else if (_source45.is_IfExpr)
                                                            {
                                                                RAST._IExpr _1476___mcc_h1264 = _source45.dtor_cond;
                                                                RAST._IExpr _1477___mcc_h1265 = _source45.dtor_thn;
                                                                RAST._IExpr _1478___mcc_h1266 = _source45.dtor_els;
                                                                return this;
                                                            }
                                                            else if (_source45.is_Loop)
                                                            {
                                                                Std.Wrappers._IOption<RAST._IExpr> _1479___mcc_h1270 = _source45.dtor_optCond;
                                                                RAST._IExpr _1480___mcc_h1271 = _source45.dtor_underlying;
                                                                return this;
                                                            }
                                                            else if (_source45.is_For)
                                                            {
                                                                Dafny.ISequence<Dafny.Rune> _1481___mcc_h1274 = _source45.dtor_name;
                                                                RAST._IExpr _1482___mcc_h1275 = _source45.dtor_range;
                                                                RAST._IExpr _1483___mcc_h1276 = _source45.dtor_body;
                                                                return this;
                                                            }
                                                            else if (_source45.is_Labelled)
                                                            {
                                                                Dafny.ISequence<Dafny.Rune> _1484___mcc_h1280 = _source45.dtor_lbl;
                                                                RAST._IExpr _1485___mcc_h1281 = _source45.dtor_underlying;
                                                                return this;
                                                            }
                                                            else if (_source45.is_Break)
                                                            {
                                                                Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1486___mcc_h1284 = _source45.dtor_optLbl;
                                                                return this;
                                                            }
                                                            else if (_source45.is_Continue)
                                                            {
                                                                Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1487___mcc_h1286 = _source45.dtor_optLbl;
                                                                return this;
                                                            }
                                                            else if (_source45.is_Return)
                                                            {
                                                                Std.Wrappers._IOption<RAST._IExpr> _1488___mcc_h1288 = _source45.dtor_optExpr;
                                                                return this;
                                                            }
                                                            else if (_source45.is_Call)
                                                            {
                                                                RAST._IExpr _1489___mcc_h1290 = _source45.dtor_obj;
                                                                Dafny.ISequence<RAST._IType> _1490___mcc_h1291 = _source45.dtor_typeParameters;
                                                                Dafny.ISequence<RAST._IExpr> _1491___mcc_h1292 = _source45.dtor_arguments;
                                                                return this;
                                                            }
                                                            else if (_source45.is_Select)
                                                            {
                                                                RAST._IExpr _1492___mcc_h1296 = _source45.dtor_obj;
                                                                Dafny.ISequence<Dafny.Rune> _1493___mcc_h1297 = _source45.dtor_name;
                                                                return this;
                                                            }
                                                            else
                                                            {
                                                                RAST._IExpr _1494___mcc_h1300 = _source45.dtor_obj;
                                                                Dafny.ISequence<Dafny.Rune> _1495___mcc_h1301 = _source45.dtor_name;
                                                                return this;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            return this;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        return this;
                                                    }
                                                }
                                                else
                                                {
                                                    return this;
                                                }
                                            }
                                            else
                                            {
                                                return this;
                                            }
                                        }
                                        else
                                        {
                                            return this;
                                        }
                                    }
                                    else if (_source44.is_Match)
                                    {
                                        RAST._IExpr _1496___mcc_h1100 = _source44.dtor_matchee;
                                        Dafny.ISequence<RAST._IMatchCase> _1497___mcc_h1101 = _source44.dtor_cases;
                                        return this;
                                    }
                                    else if (_source44.is_StmtExpr)
                                    {
                                        RAST._IExpr _1498___mcc_h1104 = _source44.dtor_stmt;
                                        RAST._IExpr _1499___mcc_h1105 = _source44.dtor_rhs;
                                        return this;
                                    }
                                    else if (_source44.is_Block)
                                    {
                                        RAST._IExpr _1500___mcc_h1108 = _source44.dtor_underlying;
                                        return this;
                                    }
                                    else if (_source44.is_StructBuild)
                                    {
                                        Dafny.ISequence<Dafny.Rune> _1501___mcc_h1110 = _source44.dtor_name;
                                        Dafny.ISequence<RAST._IAssignIdentifier> _1502___mcc_h1111 = _source44.dtor_assignments;
                                        return this;
                                    }
                                    else if (_source44.is_Tuple)
                                    {
                                        Dafny.ISequence<RAST._IExpr> _1503___mcc_h1114 = _source44.dtor_arguments;
                                        return this;
                                    }
                                    else if (_source44.is_UnaryOp)
                                    {
                                        Dafny.ISequence<Dafny.Rune> _1504___mcc_h1116 = _source44.dtor_op1;
                                        RAST._IExpr _1505___mcc_h1117 = _source44.dtor_underlying;
                                        DAST.Format._IUnaryOpFormat _1506___mcc_h1118 = _source44.dtor_format;
                                        return this;
                                    }
                                    else if (_source44.is_BinaryOp)
                                    {
                                        Dafny.ISequence<Dafny.Rune> _1507___mcc_h1122 = _source44.dtor_op2;
                                        RAST._IExpr _1508___mcc_h1123 = _source44.dtor_left;
                                        RAST._IExpr _1509___mcc_h1124 = _source44.dtor_right;
                                        DAST.Format._IBinaryOpFormat _1510___mcc_h1125 = _source44.dtor_format2;
                                        return this;
                                    }
                                    else if (_source44.is_TypeAscription)
                                    {
                                        RAST._IExpr _1511___mcc_h1130 = _source44.dtor_left;
                                        RAST._IType _1512___mcc_h1131 = _source44.dtor_tpe;
                                        return this;
                                    }
                                    else if (_source44.is_LiteralInt)
                                    {
                                        Dafny.ISequence<Dafny.Rune> _1513___mcc_h1134 = _source44.dtor_value;
                                        return this;
                                    }
                                    else if (_source44.is_LiteralString)
                                    {
                                        Dafny.ISequence<Dafny.Rune> _1514___mcc_h1136 = _source44.dtor_value;
                                        bool _1515___mcc_h1137 = _source44.dtor_binary;
                                        return this;
                                    }
                                    else if (_source44.is_ConversionNum)
                                    {
                                        RAST._IType _1516___mcc_h1140 = _source44.dtor_tpe;
                                        RAST._IExpr _1517___mcc_h1141 = _source44.dtor_underlying;
                                        return this;
                                    }
                                    else if (_source44.is_DeclareVar)
                                    {
                                        RAST._IDeclareType _1518___mcc_h1144 = _source44.dtor_declareType;
                                        Dafny.ISequence<Dafny.Rune> _1519___mcc_h1145 = _source44.dtor_name;
                                        Std.Wrappers._IOption<RAST._IType> _1520___mcc_h1146 = _source44.dtor_optType;
                                        Std.Wrappers._IOption<RAST._IExpr> _1521___mcc_h1147 = _source44.dtor_optRhs;
                                        return this;
                                    }
                                    else if (_source44.is_AssignVar)
                                    {
                                        Dafny.ISequence<Dafny.Rune> _1522___mcc_h1152 = _source44.dtor_name;
                                        RAST._IExpr _1523___mcc_h1153 = _source44.dtor_rhs;
                                        return this;
                                    }
                                    else if (_source44.is_IfExpr)
                                    {
                                        RAST._IExpr _1524___mcc_h1156 = _source44.dtor_cond;
                                        RAST._IExpr _1525___mcc_h1157 = _source44.dtor_thn;
                                        RAST._IExpr _1526___mcc_h1158 = _source44.dtor_els;
                                        return this;
                                    }
                                    else if (_source44.is_Loop)
                                    {
                                        Std.Wrappers._IOption<RAST._IExpr> _1527___mcc_h1162 = _source44.dtor_optCond;
                                        RAST._IExpr _1528___mcc_h1163 = _source44.dtor_underlying;
                                        return this;
                                    }
                                    else if (_source44.is_For)
                                    {
                                        Dafny.ISequence<Dafny.Rune> _1529___mcc_h1166 = _source44.dtor_name;
                                        RAST._IExpr _1530___mcc_h1167 = _source44.dtor_range;
                                        RAST._IExpr _1531___mcc_h1168 = _source44.dtor_body;
                                        return this;
                                    }
                                    else if (_source44.is_Labelled)
                                    {
                                        Dafny.ISequence<Dafny.Rune> _1532___mcc_h1172 = _source44.dtor_lbl;
                                        RAST._IExpr _1533___mcc_h1173 = _source44.dtor_underlying;
                                        return this;
                                    }
                                    else if (_source44.is_Break)
                                    {
                                        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1534___mcc_h1176 = _source44.dtor_optLbl;
                                        return this;
                                    }
                                    else if (_source44.is_Continue)
                                    {
                                        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1535___mcc_h1178 = _source44.dtor_optLbl;
                                        return this;
                                    }
                                    else if (_source44.is_Return)
                                    {
                                        Std.Wrappers._IOption<RAST._IExpr> _1536___mcc_h1180 = _source44.dtor_optExpr;
                                        return this;
                                    }
                                    else if (_source44.is_Call)
                                    {
                                        RAST._IExpr _1537___mcc_h1182 = _source44.dtor_obj;
                                        Dafny.ISequence<RAST._IType> _1538___mcc_h1183 = _source44.dtor_typeParameters;
                                        Dafny.ISequence<RAST._IExpr> _1539___mcc_h1184 = _source44.dtor_arguments;
                                        return this;
                                    }
                                    else if (_source44.is_Select)
                                    {
                                        RAST._IExpr _1540___mcc_h1188 = _source44.dtor_obj;
                                        Dafny.ISequence<Dafny.Rune> _1541___mcc_h1189 = _source44.dtor_name;
                                        return this;
                                    }
                                    else
                                    {
                                        RAST._IExpr _1542___mcc_h1192 = _source44.dtor_obj;
                                        Dafny.ISequence<Dafny.Rune> _1543___mcc_h1193 = _source44.dtor_name;
                                        return this;
                                    }
                                }
                            }
                        }
                    }
                    else if (_source40.is_Select)
                    {
                        RAST._IExpr _1544___mcc_h1196 = _source40.dtor_obj;
                        Dafny.ISequence<Dafny.Rune> _1545___mcc_h1197 = _source40.dtor_name;
                        return this;
                    }
                    else
                    {
                        RAST._IExpr _1546___mcc_h1200 = _source40.dtor_obj;
                        Dafny.ISequence<Dafny.Rune> _1547___mcc_h1201 = _source40.dtor_name;
                        return this;
                    }
                }
                else
                {
                    return this;
                }
            }
            else if (_source27.is_DeclareVar)
            {
                RAST._IDeclareType _1548___mcc_h652 = _source27.dtor_declareType;
                Dafny.ISequence<Dafny.Rune> _1549___mcc_h653 = _source27.dtor_name;
                Std.Wrappers._IOption<RAST._IType> _1550___mcc_h654 = _source27.dtor_optType;
                Std.Wrappers._IOption<RAST._IExpr> _1551___mcc_h655 = _source27.dtor_optRhs;
                return this;
            }
            else if (_source27.is_AssignVar)
            {
                Dafny.ISequence<Dafny.Rune> _1552___mcc_h660 = _source27.dtor_name;
                RAST._IExpr _1553___mcc_h661 = _source27.dtor_rhs;
                return this;
            }
            else if (_source27.is_IfExpr)
            {
                RAST._IExpr _1554___mcc_h664 = _source27.dtor_cond;
                RAST._IExpr _1555___mcc_h665 = _source27.dtor_thn;
                RAST._IExpr _1556___mcc_h666 = _source27.dtor_els;
                return this;
            }
            else if (_source27.is_Loop)
            {
                Std.Wrappers._IOption<RAST._IExpr> _1557___mcc_h670 = _source27.dtor_optCond;
                RAST._IExpr _1558___mcc_h671 = _source27.dtor_underlying;
                return this;
            }
            else if (_source27.is_For)
            {
                Dafny.ISequence<Dafny.Rune> _1559___mcc_h674 = _source27.dtor_name;
                RAST._IExpr _1560___mcc_h675 = _source27.dtor_range;
                RAST._IExpr _1561___mcc_h676 = _source27.dtor_body;
                return this;
            }
            else if (_source27.is_Labelled)
            {
                Dafny.ISequence<Dafny.Rune> _1562___mcc_h680 = _source27.dtor_lbl;
                RAST._IExpr _1563___mcc_h681 = _source27.dtor_underlying;
                return this;
            }
            else if (_source27.is_Break)
            {
                Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1564___mcc_h684 = _source27.dtor_optLbl;
                return this;
            }
            else if (_source27.is_Continue)
            {
                Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1565___mcc_h686 = _source27.dtor_optLbl;
                return this;
            }
            else if (_source27.is_Return)
            {
                Std.Wrappers._IOption<RAST._IExpr> _1566___mcc_h688 = _source27.dtor_optExpr;
                return this;
            }
            else if (_source27.is_Call)
            {
                RAST._IExpr _1567___mcc_h690 = _source27.dtor_obj;
                Dafny.ISequence<RAST._IType> _1568___mcc_h691 = _source27.dtor_typeParameters;
                Dafny.ISequence<RAST._IExpr> _1569___mcc_h692 = _source27.dtor_arguments;
                return this;
            }
            else if (_source27.is_Select)
            {
                RAST._IExpr _1570___mcc_h696 = _source27.dtor_obj;
                Dafny.ISequence<Dafny.Rune> _1571___mcc_h697 = _source27.dtor_name;
                return this;
            }
            else
            {
                RAST._IExpr _1572___mcc_h700 = _source27.dtor_obj;
                Dafny.ISequence<Dafny.Rune> _1573___mcc_h701 = _source27.dtor_name;
                return this;
            }

            return default;
        }
        public bool LeftRequiresParentheses(RAST._IExpr left)
        {
            return ((this).printingInfo).NeedParenthesesForLeft((left).printingInfo);
        }
        public _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> LeftParentheses(RAST._IExpr left)
        {
            if ((this).LeftRequiresParentheses(left))
            {
                return _System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3678L, "(")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3679L, ")")));
            }
            else
            {
                return _System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""));
            }

            return default;
        }
        public bool RightRequiresParentheses(RAST._IExpr right)
        {
            return ((this).printingInfo).NeedParenthesesForRight((right).printingInfo);
        }
        public _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> RightParentheses(RAST._IExpr right)
        {
            if ((this).RightRequiresParentheses(right))
            {
                return _System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3680L, "(")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3681L, ")")));
            }
            else
            {
                return _System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""));
            }

            return default;
        }
        public Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> RightMostIdentifier()
        {
            RAST._IExpr _source46 = this;
            if (_source46.is_RawExpr)
            {
                Dafny.ISequence<Dafny.Rune> _1574___mcc_h0 = _source46.dtor_content;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else if (_source46.is_Identifier)
            {
                Dafny.ISequence<Dafny.Rune> _1575___mcc_h2 = _source46.dtor_name;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else if (_source46.is_Match)
            {
                RAST._IExpr _1576___mcc_h4 = _source46.dtor_matchee;
                Dafny.ISequence<RAST._IMatchCase> _1577___mcc_h5 = _source46.dtor_cases;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else if (_source46.is_StmtExpr)
            {
                RAST._IExpr _1578___mcc_h8 = _source46.dtor_stmt;
                RAST._IExpr _1579___mcc_h9 = _source46.dtor_rhs;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else if (_source46.is_Block)
            {
                RAST._IExpr _1580___mcc_h12 = _source46.dtor_underlying;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else if (_source46.is_StructBuild)
            {
                Dafny.ISequence<Dafny.Rune> _1581___mcc_h14 = _source46.dtor_name;
                Dafny.ISequence<RAST._IAssignIdentifier> _1582___mcc_h15 = _source46.dtor_assignments;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else if (_source46.is_Tuple)
            {
                Dafny.ISequence<RAST._IExpr> _1583___mcc_h18 = _source46.dtor_arguments;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else if (_source46.is_UnaryOp)
            {
                Dafny.ISequence<Dafny.Rune> _1584___mcc_h20 = _source46.dtor_op1;
                RAST._IExpr _1585___mcc_h21 = _source46.dtor_underlying;
                DAST.Format._IUnaryOpFormat _1586___mcc_h22 = _source46.dtor_format;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else if (_source46.is_BinaryOp)
            {
                Dafny.ISequence<Dafny.Rune> _1587___mcc_h26 = _source46.dtor_op2;
                RAST._IExpr _1588___mcc_h27 = _source46.dtor_left;
                RAST._IExpr _1589___mcc_h28 = _source46.dtor_right;
                DAST.Format._IBinaryOpFormat _1590___mcc_h29 = _source46.dtor_format2;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else if (_source46.is_TypeAscription)
            {
                RAST._IExpr _1591___mcc_h34 = _source46.dtor_left;
                RAST._IType _1592___mcc_h35 = _source46.dtor_tpe;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else if (_source46.is_LiteralInt)
            {
                Dafny.ISequence<Dafny.Rune> _1593___mcc_h38 = _source46.dtor_value;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else if (_source46.is_LiteralString)
            {
                Dafny.ISequence<Dafny.Rune> _1594___mcc_h40 = _source46.dtor_value;
                bool _1595___mcc_h41 = _source46.dtor_binary;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else if (_source46.is_ConversionNum)
            {
                RAST._IType _1596___mcc_h44 = _source46.dtor_tpe;
                RAST._IExpr _1597___mcc_h45 = _source46.dtor_underlying;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else if (_source46.is_DeclareVar)
            {
                RAST._IDeclareType _1598___mcc_h48 = _source46.dtor_declareType;
                Dafny.ISequence<Dafny.Rune> _1599___mcc_h49 = _source46.dtor_name;
                Std.Wrappers._IOption<RAST._IType> _1600___mcc_h50 = _source46.dtor_optType;
                Std.Wrappers._IOption<RAST._IExpr> _1601___mcc_h51 = _source46.dtor_optRhs;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else if (_source46.is_AssignVar)
            {
                Dafny.ISequence<Dafny.Rune> _1602___mcc_h56 = _source46.dtor_name;
                RAST._IExpr _1603___mcc_h57 = _source46.dtor_rhs;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else if (_source46.is_IfExpr)
            {
                RAST._IExpr _1604___mcc_h60 = _source46.dtor_cond;
                RAST._IExpr _1605___mcc_h61 = _source46.dtor_thn;
                RAST._IExpr _1606___mcc_h62 = _source46.dtor_els;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else if (_source46.is_Loop)
            {
                Std.Wrappers._IOption<RAST._IExpr> _1607___mcc_h66 = _source46.dtor_optCond;
                RAST._IExpr _1608___mcc_h67 = _source46.dtor_underlying;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else if (_source46.is_For)
            {
                Dafny.ISequence<Dafny.Rune> _1609___mcc_h70 = _source46.dtor_name;
                RAST._IExpr _1610___mcc_h71 = _source46.dtor_range;
                RAST._IExpr _1611___mcc_h72 = _source46.dtor_body;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else if (_source46.is_Labelled)
            {
                Dafny.ISequence<Dafny.Rune> _1612___mcc_h76 = _source46.dtor_lbl;
                RAST._IExpr _1613___mcc_h77 = _source46.dtor_underlying;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else if (_source46.is_Break)
            {
                Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1614___mcc_h80 = _source46.dtor_optLbl;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else if (_source46.is_Continue)
            {
                Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1615___mcc_h82 = _source46.dtor_optLbl;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else if (_source46.is_Return)
            {
                Std.Wrappers._IOption<RAST._IExpr> _1616___mcc_h84 = _source46.dtor_optExpr;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else if (_source46.is_Call)
            {
                RAST._IExpr _1617___mcc_h86 = _source46.dtor_obj;
                Dafny.ISequence<RAST._IType> _1618___mcc_h87 = _source46.dtor_typeParameters;
                Dafny.ISequence<RAST._IExpr> _1619___mcc_h88 = _source46.dtor_arguments;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else if (_source46.is_Select)
            {
                RAST._IExpr _1620___mcc_h92 = _source46.dtor_obj;
                Dafny.ISequence<Dafny.Rune> _1621___mcc_h93 = _source46.dtor_name;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
            }
            else
            {
                RAST._IExpr _1622___mcc_h96 = _source46.dtor_obj;
                Dafny.ISequence<Dafny.Rune> _1623___mcc_h97 = _source46.dtor_name;
                Dafny.ISequence<Dafny.Rune> _1624_id = _1623___mcc_h97;
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_Some(_1624_id);
            }

            return default;
        }
        public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind)
        {
            var _pat_let_tv4 = ind;
            RAST._IExpr _source47 = (this).Optimize();
            if (_source47.is_RawExpr)
            {
                Dafny.ISequence<Dafny.Rune> _1625___mcc_h0 = _source47.dtor_content;
                RAST._IExpr _1626_r = (this).Optimize();
                return RAST.__default.AddIndent((_1626_r).dtor_content, ind);
            }
            else if (_source47.is_Identifier)
            {
                Dafny.ISequence<Dafny.Rune> _1627___mcc_h2 = _source47.dtor_name;
                Dafny.ISequence<Dafny.Rune> _1628_name = _1627___mcc_h2;
                return _1628_name;
            }
            else if (_source47.is_Match)
            {
                RAST._IExpr _1629___mcc_h4 = _source47.dtor_matchee;
                Dafny.ISequence<RAST._IMatchCase> _1630___mcc_h5 = _source47.dtor_cases;
                Dafny.ISequence<RAST._IMatchCase> _1631_cases = _1630___mcc_h5;
                RAST._IExpr _1632_matchee = _1629___mcc_h4;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3682L, "match ")), (_1632_matchee)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3683L, " {"))), RAST.__default.SeqToString<RAST._IMatchCase>(_1631_cases, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IMatchCase, Dafny.ISequence<Dafny.Rune>>>>((_1633_ind) => ((System.Func<RAST._IMatchCase, Dafny.ISequence<Dafny.Rune>>)((_1634_c) =>
                {
                    return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3684L, "\n")), _1633_ind), RAST.__default.IND), (_1634_c)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_1633_ind, RAST.__default.IND)));
                })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3685L, ",")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3686L, "\n"))), ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3687L, "}")));
            }
            else if (_source47.is_StmtExpr)
            {
                RAST._IExpr _1635___mcc_h8 = _source47.dtor_stmt;
                RAST._IExpr _1636___mcc_h9 = _source47.dtor_rhs;
                RAST._IExpr _1637_rhs = _1636___mcc_h9;
                RAST._IExpr _1638_stmt = _1635___mcc_h8;
                if (MutateCSharp.Schemata278.ReplaceBinExprOp_5(3688L, () => ((_1638_stmt).is_RawExpr), () => (((_1638_stmt).dtor_content).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))))
                {
                    return (_1637_rhs)._ToString(ind);
                }
                else
                {
                    return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat((_1638_stmt)._ToString(ind), (((_1638_stmt).NoExtraSemicolonAfter()) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3694L, ";"))))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3695L, "\n"))), ind), (_1637_rhs)._ToString(ind));
                }
            }
            else if (_source47.is_Block)
            {
                RAST._IExpr _1639___mcc_h12 = _source47.dtor_underlying;
                RAST._IExpr _1640_underlying = _1639___mcc_h12;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3696L, "{\n")), ind), RAST.__default.IND), (_1640_underlying)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3697L, "\n"))), ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3698L, "}")));
            }
            else if (_source47.is_StructBuild)
            {
                Dafny.ISequence<Dafny.Rune> _1641___mcc_h14 = _source47.dtor_name;
                Dafny.ISequence<RAST._IAssignIdentifier> _1642___mcc_h15 = _source47.dtor_assignments;
                Dafny.ISequence<RAST._IAssignIdentifier> _1643_assignments = _1642___mcc_h15;
                Dafny.ISequence<Dafny.Rune> _1644_name = _1641___mcc_h14;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1644_name, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3699L, " {"))), RAST.__default.SeqToString<RAST._IAssignIdentifier>(_1643_assignments, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IAssignIdentifier, Dafny.ISequence<Dafny.Rune>>>>((_1645_ind) => ((System.Func<RAST._IAssignIdentifier, Dafny.ISequence<Dafny.Rune>>)((_1646_assignment) =>
                {
                    return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3700L, "\n")), _1645_ind), RAST.__default.IND), (_1646_assignment)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_1645_ind, RAST.__default.IND)));
                })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3701L, ",")))), ((MutateCSharp.Schemata278.ReplaceBinExprOp_1(3706L, (new BigInteger((_1643_assignments).Count)).Sign, MutateCSharp.Schemata278.ReplaceNumericConstant_0(3702L, 1))) ? (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3711L, "\n")), ind)) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3712L, "}")));
            }
            else if (_source47.is_Tuple)
            {
                Dafny.ISequence<RAST._IExpr> _1647___mcc_h18 = _source47.dtor_arguments;
                Dafny.ISequence<RAST._IExpr> _1648_arguments = _1647___mcc_h18;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3713L, "(")), RAST.__default.SeqToString<RAST._IExpr>(_1648_arguments, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IExpr, Dafny.ISequence<Dafny.Rune>>>>((_1649_ind) => ((System.Func<RAST._IExpr, Dafny.ISequence<Dafny.Rune>>)((_1650_arg) =>
                {
                    return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3714L, "\n")), _1649_ind), RAST.__default.IND), (_1650_arg)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_1649_ind, RAST.__default.IND)));
                })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3715L, ",")))), ((MutateCSharp.Schemata278.ReplaceBinExprOp_1(3720L, (new BigInteger((_1648_arguments).Count)).Sign, MutateCSharp.Schemata278.ReplaceNumericConstant_0(3716L, 1))) ? (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3725L, "\n")), ind)) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3726L, ")")));
            }
            else if (_source47.is_UnaryOp)
            {
                Dafny.ISequence<Dafny.Rune> _1651___mcc_h20 = _source47.dtor_op1;
                RAST._IExpr _1652___mcc_h21 = _source47.dtor_underlying;
                DAST.Format._IUnaryOpFormat _1653___mcc_h22 = _source47.dtor_format;
                DAST.Format._IUnaryOpFormat _1654_format = _1653___mcc_h22;
                RAST._IExpr _1655_underlying = _1652___mcc_h21;
                Dafny.ISequence<Dafny.Rune> _1656_op = _1651___mcc_h20;
                _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> _let_tmp_rhs41 = ((((this).printingInfo).NeedParenthesesFor((_1655_underlying).printingInfo)) ? (_System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3727L, "(")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3728L, ")")))) : (_System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))));
                Dafny.ISequence<Dafny.Rune> _1657_leftP = _let_tmp_rhs41.dtor__0;
                Dafny.ISequence<Dafny.Rune> _1658_rightP = _let_tmp_rhs41.dtor__1;
                Dafny.ISequence<Dafny.Rune> _1659_leftOp = ((MutateCSharp.Schemata278.ReplaceBinExprOp_5(3731L, () => ((_1656_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3729L, "&mut")))), () => (!(_1657_leftP).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3730L, "(")))))) ? (Dafny.Sequence<Dafny.Rune>.Concat(_1656_op, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3737L, " ")))) : ((((_1656_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3738L, "?")))) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (_1656_op))));
                Dafny.ISequence<Dafny.Rune> _1660_rightOp = (((_1656_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3739L, "?")))) ? (_1656_op) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")));
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1659_leftOp, _1657_leftP), (_1655_underlying)._ToString(ind)), _1658_rightP), _1660_rightOp);
            }
            else if (_source47.is_BinaryOp)
            {
                Dafny.ISequence<Dafny.Rune> _1661___mcc_h26 = _source47.dtor_op2;
                RAST._IExpr _1662___mcc_h27 = _source47.dtor_left;
                RAST._IExpr _1663___mcc_h28 = _source47.dtor_right;
                DAST.Format._IBinaryOpFormat _1664___mcc_h29 = _source47.dtor_format2;
                DAST.Format._IBinaryOpFormat _1665_format = _1664___mcc_h29;
                RAST._IExpr _1666_right = _1663___mcc_h28;
                RAST._IExpr _1667_left = _1662___mcc_h27;
                Dafny.ISequence<Dafny.Rune> _1668_op2 = _1661___mcc_h26;
                _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> _let_tmp_rhs42 = (this).LeftParentheses(_1667_left);
                Dafny.ISequence<Dafny.Rune> _1669_leftLeftP = _let_tmp_rhs42.dtor__0;
                Dafny.ISequence<Dafny.Rune> _1670_leftRighP = _let_tmp_rhs42.dtor__1;
                _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> _let_tmp_rhs43 = (this).RightParentheses(_1666_right);
                Dafny.ISequence<Dafny.Rune> _1671_rightLeftP = _let_tmp_rhs43.dtor__0;
                Dafny.ISequence<Dafny.Rune> _1672_rightRightP = _let_tmp_rhs43.dtor__1;
                Dafny.ISequence<Dafny.Rune> _1673_opRendered = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3740L, " ")), _1668_op2), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3741L, " ")));
                Dafny.ISequence<Dafny.Rune> _1674_indLeft = (((_1669_leftLeftP).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3742L, "(")))) ? (Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND)) : (ind));
                Dafny.ISequence<Dafny.Rune> _1675_indRight = (((_1671_rightLeftP).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3743L, "(")))) ? (Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND)) : (ind));
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1669_leftLeftP, (_1667_left)._ToString(_1674_indLeft)), _1670_leftRighP), _1673_opRendered), _1671_rightLeftP), (_1666_right)._ToString(_1675_indRight)), _1672_rightRightP);
            }
            else if (_source47.is_TypeAscription)
            {
                RAST._IExpr _1676___mcc_h34 = _source47.dtor_left;
                RAST._IType _1677___mcc_h35 = _source47.dtor_tpe;
                RAST._IType _1678_tpe = _1677___mcc_h35;
                RAST._IExpr _1679_left = _1676___mcc_h34;
                _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> _let_tmp_rhs44 = (this).LeftParentheses(_1679_left);
                Dafny.ISequence<Dafny.Rune> _1680_leftLeftP = _let_tmp_rhs44.dtor__0;
                Dafny.ISequence<Dafny.Rune> _1681_leftRightP = _let_tmp_rhs44.dtor__1;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1680_leftLeftP, (_1679_left)._ToString(RAST.__default.IND)), _1681_leftRightP), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3744L, " as "))), (_1678_tpe)._ToString(RAST.__default.IND));
            }
            else if (_source47.is_LiteralInt)
            {
                Dafny.ISequence<Dafny.Rune> _1682___mcc_h38 = _source47.dtor_value;
                Dafny.ISequence<Dafny.Rune> _1683_number = _1682___mcc_h38;
                return _1683_number;
            }
            else if (_source47.is_LiteralString)
            {
                Dafny.ISequence<Dafny.Rune> _1684___mcc_h40 = _source47.dtor_value;
                bool _1685___mcc_h41 = _source47.dtor_binary;
                bool _1686_binary = _1685___mcc_h41;
                Dafny.ISequence<Dafny.Rune> _1687_characters = _1684___mcc_h40;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(((_1686_binary) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3745L, "b"))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3746L, "\""))), _1687_characters), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3747L, "\"")));
            }
            else if (_source47.is_ConversionNum)
            {
                RAST._IType _1688___mcc_h44 = _source47.dtor_tpe;
                RAST._IExpr _1689___mcc_h45 = _source47.dtor_underlying;
                RAST._IExpr _1690_expr = _1689___mcc_h45;
                RAST._IType _1691_tpe = _1688___mcc_h44;
                if (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3796L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3790L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3784L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3778L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3772L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3766L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3760L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3754L, () => (MutateCSharp.Schemata278.ReplaceBinExprOp_65(3748L, () => ((_1691_tpe).is_U8), () => ((_1691_tpe).is_U16))), () => ((_1691_tpe).is_U32))), () => ((_1691_tpe).is_U64))), () => ((_1691_tpe).is_U128))), () => ((_1691_tpe).is_I8))), () => ((_1691_tpe).is_I16))), () => ((_1691_tpe).is_I32))), () => ((_1691_tpe).is_I64))), () => ((_1691_tpe).is_I128)))
                {
                    return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3802L, "num::ToPrimitive::to_")), (_1691_tpe)._ToString(ind)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3803L, "("))), (_1690_expr)._ToString(ind)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3804L, ").unwrap()")));
                }
                else
                {
                    return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3805L, "<b>Unsupported: Numeric conversion to ")), (_1691_tpe)._ToString(ind)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3806L, "</b>")));
                }
            }
            else if (_source47.is_DeclareVar)
            {
                RAST._IDeclareType _1692___mcc_h48 = _source47.dtor_declareType;
                Dafny.ISequence<Dafny.Rune> _1693___mcc_h49 = _source47.dtor_name;
                Std.Wrappers._IOption<RAST._IType> _1694___mcc_h50 = _source47.dtor_optType;
                Std.Wrappers._IOption<RAST._IExpr> _1695___mcc_h51 = _source47.dtor_optRhs;
                Std.Wrappers._IOption<RAST._IExpr> _1696_optExpr = _1695___mcc_h51;
                Std.Wrappers._IOption<RAST._IType> _1697_optType = _1694___mcc_h50;
                Dafny.ISequence<Dafny.Rune> _1698_name = _1693___mcc_h49;
                RAST._IDeclareType _1699_declareType = _1692___mcc_h48;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3807L, "let ")), ((object.Equals(_1699_declareType, RAST.DeclareType.create_MUT())) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3808L, "mut "))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _1698_name), (((_1697_optType).is_Some) ? (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3809L, ": ")), ((_1697_optType).dtor_value)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND)))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), (((_1696_optExpr).is_Some) ? (Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(((_1696_optExpr).dtor_value)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND)), _pat_let6_0 => Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_pat_let6_0, _1700_optExprString => (((_1700_optExprString).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3810L, "= /*issue with empty RHS*/")), ((((_1696_optExpr).dtor_value).is_RawExpr) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3811L, "Empty Raw expr"))) : (((((_1696_optExpr).dtor_value).is_LiteralString) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3812L, "Empty string literal"))) : (((((_1696_optExpr).dtor_value).is_LiteralInt) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3813L, "Empty int literal"))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3814L, "Another case")))))))))) : (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3815L, " = ")), _1700_optExprString)))))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3816L, ";")));
            }
            else if (_source47.is_AssignVar)
            {
                Dafny.ISequence<Dafny.Rune> _1701___mcc_h56 = _source47.dtor_name;
                RAST._IExpr _1702___mcc_h57 = _source47.dtor_rhs;
                RAST._IExpr _1703_expr = _1702___mcc_h57;
                Dafny.ISequence<Dafny.Rune> _1704_name = _1701___mcc_h56;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1704_name, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3817L, " = "))), (_1703_expr)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3818L, ";")));
            }
            else if (_source47.is_IfExpr)
            {
                RAST._IExpr _1705___mcc_h60 = _source47.dtor_cond;
                RAST._IExpr _1706___mcc_h61 = _source47.dtor_thn;
                RAST._IExpr _1707___mcc_h62 = _source47.dtor_els;
                RAST._IExpr _1708_els = _1707___mcc_h62;
                RAST._IExpr _1709_thn = _1706___mcc_h61;
                RAST._IExpr _1710_cond = _1705___mcc_h60;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3819L, "if ")), (_1710_cond)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3820L, " {\n"))), ind), RAST.__default.IND), (_1709_thn)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3821L, "\n"))), ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3822L, "} else {\n"))), ind), RAST.__default.IND), (_1708_els)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3823L, "\n"))), ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3824L, "}")));
            }
            else if (_source47.is_Loop)
            {
                Std.Wrappers._IOption<RAST._IExpr> _1711___mcc_h66 = _source47.dtor_optCond;
                RAST._IExpr _1712___mcc_h67 = _source47.dtor_underlying;
                RAST._IExpr _1713_underlying = _1712___mcc_h67;
                Std.Wrappers._IOption<RAST._IExpr> _1714_optCond = _1711___mcc_h66;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(((System.Func<Std.Wrappers._IOption<RAST._IExpr>, Dafny.ISequence<Dafny.Rune>>)((_source48) =>
                {
                    if (_source48.is_None)
                    {
                        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3825L, "loop"));
                    }
                    else
                    {
                        RAST._IExpr _1715___mcc_h100 = _source48.dtor_value;
                        RAST._IExpr _1716_c = _1715___mcc_h100;
                        return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3826L, "while ")), (_1716_c)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_pat_let_tv4, RAST.__default.IND)));
                    }

                    return default;
                }))(_1714_optCond), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3827L, " {\n"))), ind), RAST.__default.IND), (_1713_underlying)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3828L, "\n"))), ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3829L, "}")));
            }
            else if (_source47.is_For)
            {
                Dafny.ISequence<Dafny.Rune> _1717___mcc_h70 = _source47.dtor_name;
                RAST._IExpr _1718___mcc_h71 = _source47.dtor_range;
                RAST._IExpr _1719___mcc_h72 = _source47.dtor_body;
                RAST._IExpr _1720_body = _1719___mcc_h72;
                RAST._IExpr _1721_range = _1718___mcc_h71;
                Dafny.ISequence<Dafny.Rune> _1722_name = _1717___mcc_h70;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3830L, "for ")), _1722_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3831L, " in "))), (_1721_range)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3832L, " {\n"))), ind), RAST.__default.IND), (_1720_body)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3833L, "\n"))), ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3834L, "}")));
            }
            else if (_source47.is_Labelled)
            {
                Dafny.ISequence<Dafny.Rune> _1723___mcc_h76 = _source47.dtor_lbl;
                RAST._IExpr _1724___mcc_h77 = _source47.dtor_underlying;
                RAST._IExpr _1725_underlying = _1724___mcc_h77;
                Dafny.ISequence<Dafny.Rune> _1726_name = _1723___mcc_h76;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3835L, "'")), _1726_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3836L, ": "))), (_1725_underlying)._ToString(ind));
            }
            else if (_source47.is_Break)
            {
                Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1727___mcc_h80 = _source47.dtor_optLbl;
                Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1728_optLbl = _1727___mcc_h80;
                Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _source49 = _1728_optLbl;
                if (_source49.is_None)
                {
                    return Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3837L, "break;"));
                }
                else
                {
                    Dafny.ISequence<Dafny.Rune> _1729___mcc_h101 = _source49.dtor_value;
                    Dafny.ISequence<Dafny.Rune> _1730_lbl = _1729___mcc_h101;
                    return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3838L, "break '")), _1730_lbl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3839L, ";")));
                }
            }
            else if (_source47.is_Continue)
            {
                Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1731___mcc_h82 = _source47.dtor_optLbl;
                Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1732_optLbl = _1731___mcc_h82;
                Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _source50 = _1732_optLbl;
                if (_source50.is_None)
                {
                    return Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3840L, "continue;"));
                }
                else
                {
                    Dafny.ISequence<Dafny.Rune> _1733___mcc_h102 = _source50.dtor_value;
                    Dafny.ISequence<Dafny.Rune> _1734_lbl = _1733___mcc_h102;
                    return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3841L, "continue '")), _1734_lbl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3842L, ";")));
                }
            }
            else if (_source47.is_Return)
            {
                Std.Wrappers._IOption<RAST._IExpr> _1735___mcc_h84 = _source47.dtor_optExpr;
                Std.Wrappers._IOption<RAST._IExpr> _1736_optExpr = _1735___mcc_h84;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3843L, "return")), (((_1736_optExpr).is_Some) ? (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3844L, " ")), ((_1736_optExpr).dtor_value)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(ind, RAST.__default.IND)))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3845L, ";")));
            }
            else if (_source47.is_Call)
            {
                RAST._IExpr _1737___mcc_h86 = _source47.dtor_obj;
                Dafny.ISequence<RAST._IType> _1738___mcc_h87 = _source47.dtor_typeParameters;
                Dafny.ISequence<RAST._IExpr> _1739___mcc_h88 = _source47.dtor_arguments;
                Dafny.ISequence<RAST._IExpr> _1740_args = _1739___mcc_h88;
                Dafny.ISequence<RAST._IType> _1741_tpes = _1738___mcc_h87;
                RAST._IExpr _1742_expr = _1737___mcc_h86;
                _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> _let_tmp_rhs45 = (this).LeftParentheses(_1742_expr);
                Dafny.ISequence<Dafny.Rune> _1743_leftP = _let_tmp_rhs45.dtor__0;
                Dafny.ISequence<Dafny.Rune> _1744_rightP = _let_tmp_rhs45.dtor__1;
                _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> _let_tmp_rhs46 = ((System.Func<Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>>, _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>>)((_source51) =>
                {
                    if (_source51.is_None)
                    {
                        return _System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3846L, "(")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3847L, ")")));
                    }
                    else
                    {
                        Dafny.ISequence<Dafny.Rune> _1745___mcc_h103 = _source51.dtor_value;
                        if (object.Equals(_1745___mcc_h103, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3848L, "seq!"))))
                        {
                            return _System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3849L, "[")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3850L, "]")));
                        }
                        else if (object.Equals(_1745___mcc_h103, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3851L, "map!"))))
                        {
                            return _System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3852L, "[")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3853L, "]")));
                        }
                        else if (object.Equals(_1745___mcc_h103, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3854L, "set!"))))
                        {
                            return _System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3855L, "{")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3856L, "}")));
                        }
                        else if (object.Equals(_1745___mcc_h103, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3857L, "multiset!"))))
                        {
                            return _System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3858L, "{")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3859L, "}")));
                        }
                        else
                        {
                            return _System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3860L, "(")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3861L, ")")));
                        }
                    }

                    return default;
                }))((_1742_expr).RightMostIdentifier());
                Dafny.ISequence<Dafny.Rune> _1746_leftCallP = _let_tmp_rhs46.dtor__0;
                Dafny.ISequence<Dafny.Rune> _1747_rightCallP = _let_tmp_rhs46.dtor__1;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1743_leftP, (_1742_expr)._ToString(ind)), _1744_rightP), ((MutateCSharp.Schemata278.ReplaceBinExprOp_1(3866L, (new BigInteger((_1741_tpes).Count)).Sign, MutateCSharp.Schemata278.ReplaceNumericConstant_0(3862L, 0))) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3871L, "::<")), RAST.__default.SeqToString<RAST._IType>(_1741_tpes, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IType, Dafny.ISequence<Dafny.Rune>>>>((_1748_ind) => ((System.Func<RAST._IType, Dafny.ISequence<Dafny.Rune>>)((_1749_tpe) =>
                {
                    return (_1749_tpe)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_1748_ind, RAST.__default.IND));
                })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3872L, ", ")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3873L, ">")))))), _1746_leftCallP), RAST.__default.SeqToString<RAST._IExpr>(_1740_args, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IExpr, Dafny.ISequence<Dafny.Rune>>>>((_1750_ind) => ((System.Func<RAST._IExpr, Dafny.ISequence<Dafny.Rune>>)((_1751_arg) =>
                {
                    return (_1751_arg)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_1750_ind, RAST.__default.IND));
                })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3874L, ", ")))), _1747_rightCallP);
            }
            else if (_source47.is_Select)
            {
                RAST._IExpr _1752___mcc_h92 = _source47.dtor_obj;
                Dafny.ISequence<Dafny.Rune> _1753___mcc_h93 = _source47.dtor_name;
                Dafny.ISequence<Dafny.Rune> _1754_name = _1753___mcc_h93;
                RAST._IExpr _1755_expression = _1752___mcc_h92;
                _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> _let_tmp_rhs47 = (this).LeftParentheses(_1755_expression);
                Dafny.ISequence<Dafny.Rune> _1756_leftP = _let_tmp_rhs47.dtor__0;
                Dafny.ISequence<Dafny.Rune> _1757_rightP = _let_tmp_rhs47.dtor__1;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1756_leftP, (_1755_expression)._ToString(ind)), _1757_rightP), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3875L, "."))), _1754_name);
            }
            else
            {
                RAST._IExpr _1758___mcc_h96 = _source47.dtor_obj;
                Dafny.ISequence<Dafny.Rune> _1759___mcc_h97 = _source47.dtor_name;
                Dafny.ISequence<Dafny.Rune> _1760_name = _1759___mcc_h97;
                RAST._IExpr _1761_expression = _1758___mcc_h96;
                _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> _let_tmp_rhs48 = (this).LeftParentheses(_1761_expression);
                Dafny.ISequence<Dafny.Rune> _1762_leftP = _let_tmp_rhs48.dtor__0;
                Dafny.ISequence<Dafny.Rune> _1763_rightP = _let_tmp_rhs48.dtor__1;
                return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1762_leftP, (_1761_expression)._ToString(ind)), _1763_rightP), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3876L, "::"))), _1760_name);
            }

            return default;
        }
        public RAST._IExpr Then(RAST._IExpr rhs2)
        {
            if ((this).is_StmtExpr)
            {
                return RAST.Expr.create_StmtExpr((this).dtor_stmt, ((this).dtor_rhs).Then(rhs2));
            }
            else
            {
                return RAST.Expr.create_StmtExpr(this, rhs2);
            }

            return default;
        }
        public RAST._IExpr Sel(Dafny.ISequence<Dafny.Rune> name)
        {
            return RAST.Expr.create_Select(this, name);
        }
        public RAST._IExpr MSel(Dafny.ISequence<Dafny.Rune> name)
        {
            return RAST.Expr.create_MemberSelect(this, name);
        }
        public RAST._IExpr Apply(Dafny.ISequence<RAST._IType> typeParameters, Dafny.ISequence<RAST._IExpr> arguments)
        {
            return RAST.Expr.create_Call(this, typeParameters, arguments);
        }
        public RAST._IExpr Apply1(RAST._IExpr argument)
        {
            return RAST.Expr.create_Call(this, Dafny.Sequence<RAST._IType>.FromElements(), Dafny.Sequence<RAST._IExpr>.FromElements(argument));
        }
        public RAST._IPrintingInfo printingInfo
        {
            get
            {
                RAST._IExpr _source52 = this;
                if (_source52.is_RawExpr)
                {
                    Dafny.ISequence<Dafny.Rune> _1764___mcc_h0 = _source52.dtor_content;
                    return RAST.PrintingInfo.create_UnknownPrecedence();
                }
                else if (_source52.is_Identifier)
                {
                    Dafny.ISequence<Dafny.Rune> _1765___mcc_h2 = _source52.dtor_name;
                    return RAST.PrintingInfo.create_Precedence(BigInteger.One);
                }
                else if (_source52.is_Match)
                {
                    RAST._IExpr _1766___mcc_h4 = _source52.dtor_matchee;
                    Dafny.ISequence<RAST._IMatchCase> _1767___mcc_h5 = _source52.dtor_cases;
                    return RAST.PrintingInfo.create_UnknownPrecedence();
                }
                else if (_source52.is_StmtExpr)
                {
                    RAST._IExpr _1768___mcc_h8 = _source52.dtor_stmt;
                    RAST._IExpr _1769___mcc_h9 = _source52.dtor_rhs;
                    return RAST.PrintingInfo.create_UnknownPrecedence();
                }
                else if (_source52.is_Block)
                {
                    RAST._IExpr _1770___mcc_h12 = _source52.dtor_underlying;
                    return RAST.PrintingInfo.create_UnknownPrecedence();
                }
                else if (_source52.is_StructBuild)
                {
                    Dafny.ISequence<Dafny.Rune> _1771___mcc_h14 = _source52.dtor_name;
                    Dafny.ISequence<RAST._IAssignIdentifier> _1772___mcc_h15 = _source52.dtor_assignments;
                    return RAST.PrintingInfo.create_UnknownPrecedence();
                }
                else if (_source52.is_Tuple)
                {
                    Dafny.ISequence<RAST._IExpr> _1773___mcc_h18 = _source52.dtor_arguments;
                    return RAST.PrintingInfo.create_UnknownPrecedence();
                }
                else if (_source52.is_UnaryOp)
                {
                    Dafny.ISequence<Dafny.Rune> _1774___mcc_h20 = _source52.dtor_op1;
                    RAST._IExpr _1775___mcc_h21 = _source52.dtor_underlying;
                    DAST.Format._IUnaryOpFormat _1776___mcc_h22 = _source52.dtor_format;
                    DAST.Format._IUnaryOpFormat _1777_format = _1776___mcc_h22;
                    RAST._IExpr _1778_underlying = _1775___mcc_h21;
                    Dafny.ISequence<Dafny.Rune> _1779_op = _1774___mcc_h20;
                    if (object.Equals(_1779_op, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3877L, "?"))))
                    {
                        return RAST.PrintingInfo.create_SuffixPrecedence(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3878L, 5)));
                    }
                    else if (object.Equals(_1779_op, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3882L, "-"))))
                    {
                        return RAST.PrintingInfo.create_Precedence(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3883L, 6)));
                    }
                    else if (object.Equals(_1779_op, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3887L, "*"))))
                    {
                        return RAST.PrintingInfo.create_Precedence(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3888L, 6)));
                    }
                    else if (object.Equals(_1779_op, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3892L, "!"))))
                    {
                        return RAST.PrintingInfo.create_Precedence(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3893L, 6)));
                    }
                    else if (object.Equals(_1779_op, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3897L, "&"))))
                    {
                        return RAST.PrintingInfo.create_Precedence(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3898L, 6)));
                    }
                    else if (object.Equals(_1779_op, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3902L, "&mut"))))
                    {
                        return RAST.PrintingInfo.create_Precedence(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3903L, 6)));
                    }
                    else
                    {
                        return RAST.PrintingInfo.create_UnknownPrecedence();
                    }
                }
                else if (_source52.is_BinaryOp)
                {
                    Dafny.ISequence<Dafny.Rune> _1780___mcc_h26 = _source52.dtor_op2;
                    RAST._IExpr _1781___mcc_h27 = _source52.dtor_left;
                    RAST._IExpr _1782___mcc_h28 = _source52.dtor_right;
                    DAST.Format._IBinaryOpFormat _1783___mcc_h29 = _source52.dtor_format2;
                    DAST.Format._IBinaryOpFormat _1784_format = _1783___mcc_h29;
                    RAST._IExpr _1785_right = _1782___mcc_h28;
                    RAST._IExpr _1786_left = _1781___mcc_h27;
                    Dafny.ISequence<Dafny.Rune> _1787_op2 = _1780___mcc_h26;
                    if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3907L, "*"))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3908L, 20)), RAST.Associativity.create_LeftToRight());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3912L, "/"))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3913L, 20)), RAST.Associativity.create_LeftToRight());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3917L, "%"))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3918L, 20)), RAST.Associativity.create_LeftToRight());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3922L, "+"))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3923L, 30)), RAST.Associativity.create_LeftToRight());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3927L, "-"))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3928L, 30)), RAST.Associativity.create_LeftToRight());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3932L, "<<"))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3933L, 40)), RAST.Associativity.create_LeftToRight());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3937L, ">>"))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3938L, 40)), RAST.Associativity.create_LeftToRight());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3942L, "&"))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3943L, 50)), RAST.Associativity.create_LeftToRight());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3947L, "^"))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3948L, 60)), RAST.Associativity.create_LeftToRight());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3952L, "|"))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3953L, 70)), RAST.Associativity.create_LeftToRight());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3957L, "=="))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3958L, 80)), RAST.Associativity.create_RequiresParentheses());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3962L, "!="))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3963L, 80)), RAST.Associativity.create_RequiresParentheses());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3967L, "<"))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3968L, 80)), RAST.Associativity.create_RequiresParentheses());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3972L, ">"))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3973L, 80)), RAST.Associativity.create_RequiresParentheses());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3977L, "<="))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3978L, 80)), RAST.Associativity.create_RequiresParentheses());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3982L, ">="))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3983L, 80)), RAST.Associativity.create_RequiresParentheses());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3987L, "&&"))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3988L, 90)), RAST.Associativity.create_LeftToRight());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3992L, "||"))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3993L, 100)), RAST.Associativity.create_LeftToRight());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(3997L, ".."))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(3998L, 110)), RAST.Associativity.create_RequiresParentheses());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(4002L, "..="))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(4003L, 110)), RAST.Associativity.create_RequiresParentheses());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(4007L, "="))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(4008L, 110)), RAST.Associativity.create_RightToLeft());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(4012L, "+="))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(4013L, 110)), RAST.Associativity.create_RightToLeft());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(4017L, "-="))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(4018L, 110)), RAST.Associativity.create_RightToLeft());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(4022L, "*="))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(4023L, 110)), RAST.Associativity.create_RightToLeft());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(4027L, "/="))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(4028L, 110)), RAST.Associativity.create_RightToLeft());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(4032L, "%="))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(4033L, 110)), RAST.Associativity.create_RightToLeft());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(4037L, "&="))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(4038L, 110)), RAST.Associativity.create_RightToLeft());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(4042L, "|="))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(4043L, 110)), RAST.Associativity.create_RightToLeft());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(4047L, "^="))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(4048L, 110)), RAST.Associativity.create_RightToLeft());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(4052L, "<<="))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(4053L, 110)), RAST.Associativity.create_RightToLeft());
                    }
                    else if (object.Equals(_1787_op2, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(4057L, ">>="))))
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(4058L, 110)), RAST.Associativity.create_RightToLeft());
                    }
                    else
                    {
                        return RAST.PrintingInfo.create_PrecedenceAssociativity(BigInteger.Zero, RAST.Associativity.create_RequiresParentheses());
                    }
                }
                else if (_source52.is_TypeAscription)
                {
                    RAST._IExpr _1788___mcc_h34 = _source52.dtor_left;
                    RAST._IType _1789___mcc_h35 = _source52.dtor_tpe;
                    RAST._IType _1790_tpe = _1789___mcc_h35;
                    RAST._IExpr _1791_left = _1788___mcc_h34;
                    return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(4062L, 10)), RAST.Associativity.create_LeftToRight());
                }
                else if (_source52.is_LiteralInt)
                {
                    Dafny.ISequence<Dafny.Rune> _1792___mcc_h38 = _source52.dtor_value;
                    return RAST.PrintingInfo.create_Precedence(BigInteger.One);
                }
                else if (_source52.is_LiteralString)
                {
                    Dafny.ISequence<Dafny.Rune> _1793___mcc_h40 = _source52.dtor_value;
                    bool _1794___mcc_h41 = _source52.dtor_binary;
                    return RAST.PrintingInfo.create_Precedence(BigInteger.One);
                }
                else if (_source52.is_ConversionNum)
                {
                    RAST._IType _1795___mcc_h44 = _source52.dtor_tpe;
                    RAST._IExpr _1796___mcc_h45 = _source52.dtor_underlying;
                    return RAST.PrintingInfo.create_UnknownPrecedence();
                }
                else if (_source52.is_DeclareVar)
                {
                    RAST._IDeclareType _1797___mcc_h48 = _source52.dtor_declareType;
                    Dafny.ISequence<Dafny.Rune> _1798___mcc_h49 = _source52.dtor_name;
                    Std.Wrappers._IOption<RAST._IType> _1799___mcc_h50 = _source52.dtor_optType;
                    Std.Wrappers._IOption<RAST._IExpr> _1800___mcc_h51 = _source52.dtor_optRhs;
                    return RAST.PrintingInfo.create_UnknownPrecedence();
                }
                else if (_source52.is_AssignVar)
                {
                    Dafny.ISequence<Dafny.Rune> _1801___mcc_h56 = _source52.dtor_name;
                    RAST._IExpr _1802___mcc_h57 = _source52.dtor_rhs;
                    return RAST.PrintingInfo.create_UnknownPrecedence();
                }
                else if (_source52.is_IfExpr)
                {
                    RAST._IExpr _1803___mcc_h60 = _source52.dtor_cond;
                    RAST._IExpr _1804___mcc_h61 = _source52.dtor_thn;
                    RAST._IExpr _1805___mcc_h62 = _source52.dtor_els;
                    return RAST.PrintingInfo.create_UnknownPrecedence();
                }
                else if (_source52.is_Loop)
                {
                    Std.Wrappers._IOption<RAST._IExpr> _1806___mcc_h66 = _source52.dtor_optCond;
                    RAST._IExpr _1807___mcc_h67 = _source52.dtor_underlying;
                    return RAST.PrintingInfo.create_UnknownPrecedence();
                }
                else if (_source52.is_For)
                {
                    Dafny.ISequence<Dafny.Rune> _1808___mcc_h70 = _source52.dtor_name;
                    RAST._IExpr _1809___mcc_h71 = _source52.dtor_range;
                    RAST._IExpr _1810___mcc_h72 = _source52.dtor_body;
                    return RAST.PrintingInfo.create_UnknownPrecedence();
                }
                else if (_source52.is_Labelled)
                {
                    Dafny.ISequence<Dafny.Rune> _1811___mcc_h76 = _source52.dtor_lbl;
                    RAST._IExpr _1812___mcc_h77 = _source52.dtor_underlying;
                    return RAST.PrintingInfo.create_UnknownPrecedence();
                }
                else if (_source52.is_Break)
                {
                    Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1813___mcc_h80 = _source52.dtor_optLbl;
                    return RAST.PrintingInfo.create_UnknownPrecedence();
                }
                else if (_source52.is_Continue)
                {
                    Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _1814___mcc_h82 = _source52.dtor_optLbl;
                    return RAST.PrintingInfo.create_UnknownPrecedence();
                }
                else if (_source52.is_Return)
                {
                    Std.Wrappers._IOption<RAST._IExpr> _1815___mcc_h84 = _source52.dtor_optExpr;
                    return RAST.PrintingInfo.create_UnknownPrecedence();
                }
                else if (_source52.is_Call)
                {
                    RAST._IExpr _1816___mcc_h86 = _source52.dtor_obj;
                    Dafny.ISequence<RAST._IType> _1817___mcc_h87 = _source52.dtor_typeParameters;
                    Dafny.ISequence<RAST._IExpr> _1818___mcc_h88 = _source52.dtor_arguments;
                    return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(4066L, 2)), RAST.Associativity.create_LeftToRight());
                }
                else if (_source52.is_Select)
                {
                    RAST._IExpr _1819___mcc_h92 = _source52.dtor_obj;
                    Dafny.ISequence<Dafny.Rune> _1820___mcc_h93 = _source52.dtor_name;
                    Dafny.ISequence<Dafny.Rune> _1821_name = _1820___mcc_h93;
                    RAST._IExpr _1822_underlying = _1819___mcc_h92;
                    return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(4070L, 2)), RAST.Associativity.create_LeftToRight());
                }
                else
                {
                    RAST._IExpr _1823___mcc_h96 = _source52.dtor_obj;
                    Dafny.ISequence<Dafny.Rune> _1824___mcc_h97 = _source52.dtor_name;
                    Dafny.ISequence<Dafny.Rune> _1825_name = _1824___mcc_h97;
                    RAST._IExpr _1826_underlying = _1823___mcc_h96;
                    return RAST.PrintingInfo.create_PrecedenceAssociativity(new BigInteger(MutateCSharp.Schemata278.ReplaceNumericConstant_0(4074L, 2)), RAST.Associativity.create_LeftToRight());
                }

                return default;
            }
        }
    }
    public class Expr_RawExpr : Expr
    {
        public readonly Dafny.ISequence<Dafny.Rune> _content;
        public Expr_RawExpr(Dafny.ISequence<Dafny.Rune> content) : base()
        {
            this._content = content;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_RawExpr(_content);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_RawExpr;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(4079L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_71(4078L, oth, null), () => object.Equals(this._content, oth._content));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(4085L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4102L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4092L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4088L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(4099L, 0));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4120L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4113L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4109L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._content)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(4127L, "RAST.Expr.RawExpr");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4128L, "(");
            s += this._content.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(4129L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4130L, ")");
            return s;
        }
    }
    public class Expr_Identifier : Expr
    {
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public Expr_Identifier(Dafny.ISequence<Dafny.Rune> name) : base()
        {
            this._name = name;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_Identifier(_name);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_Identifier;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(4132L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_72(4131L, oth, null), () => object.Equals(this._name, oth._name));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(4138L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4155L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4145L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4141L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(4152L, 1));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4173L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4166L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4162L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(4180L, "RAST.Expr.Identifier");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4181L, "(");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(4182L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4183L, ")");
            return s;
        }
    }
    public class Expr_Match : Expr
    {
        public readonly RAST._IExpr _matchee;
        public readonly Dafny.ISequence<RAST._IMatchCase> _cases;
        public Expr_Match(RAST._IExpr matchee, Dafny.ISequence<RAST._IMatchCase> cases) : base()
        {
            this._matchee = matchee;
            this._cases = cases;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_Match(_matchee, _cases);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_Match;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(4191L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(4185L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_73(4184L, oth, null), () => object.Equals(this._matchee, oth._matchee)), () => object.Equals(this._cases, oth._cases));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(4197L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4214L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4204L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4200L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(4211L, 2));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4232L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4225L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4221L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._matchee)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4250L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4243L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4239L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._cases)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(4257L, "RAST.Expr.Match");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4258L, "(");
            s += Dafny.Helpers.ToString(this._matchee);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4259L, ", ");
            s += Dafny.Helpers.ToString(this._cases);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4260L, ")");
            return s;
        }
    }
    public class Expr_StmtExpr : Expr
    {
        public readonly RAST._IExpr _stmt;
        public readonly RAST._IExpr _rhs;
        public Expr_StmtExpr(RAST._IExpr stmt, RAST._IExpr rhs) : base()
        {
            this._stmt = stmt;
            this._rhs = rhs;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_StmtExpr(_stmt, _rhs);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_StmtExpr;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(4268L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(4262L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_74(4261L, oth, null), () => object.Equals(this._stmt, oth._stmt)), () => object.Equals(this._rhs, oth._rhs));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(4274L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4291L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4281L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4277L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(4288L, 3));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4309L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4302L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4298L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._stmt)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4327L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4320L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4316L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._rhs)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(4334L, "RAST.Expr.StmtExpr");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4335L, "(");
            s += Dafny.Helpers.ToString(this._stmt);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4336L, ", ");
            s += Dafny.Helpers.ToString(this._rhs);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4337L, ")");
            return s;
        }
    }
    public class Expr_Block : Expr
    {
        public readonly RAST._IExpr _underlying;
        public Expr_Block(RAST._IExpr underlying) : base()
        {
            this._underlying = underlying;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_Block(_underlying);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_Block;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(4339L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_75(4338L, oth, null), () => object.Equals(this._underlying, oth._underlying));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(4345L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4362L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4352L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4348L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(4359L, 4));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4380L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4373L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4369L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._underlying)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(4387L, "RAST.Expr.Block");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4388L, "(");
            s += Dafny.Helpers.ToString(this._underlying);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4389L, ")");
            return s;
        }
    }
    public class Expr_StructBuild : Expr
    {
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public readonly Dafny.ISequence<RAST._IAssignIdentifier> _assignments;
        public Expr_StructBuild(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._IAssignIdentifier> assignments) : base()
        {
            this._name = name;
            this._assignments = assignments;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_StructBuild(_name, _assignments);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_StructBuild;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(4397L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(4391L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_76(4390L, oth, null), () => object.Equals(this._name, oth._name)), () => object.Equals(this._assignments, oth._assignments));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(4403L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4420L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4410L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4406L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(4417L, 5));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4438L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4431L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4427L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4456L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4449L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4445L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._assignments)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(4463L, "RAST.Expr.StructBuild");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4464L, "(");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(4465L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4466L, ", ");
            s += Dafny.Helpers.ToString(this._assignments);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4467L, ")");
            return s;
        }
    }
    public class Expr_Tuple : Expr
    {
        public readonly Dafny.ISequence<RAST._IExpr> _arguments;
        public Expr_Tuple(Dafny.ISequence<RAST._IExpr> arguments) : base()
        {
            this._arguments = arguments;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_Tuple(_arguments);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_Tuple;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(4469L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_77(4468L, oth, null), () => object.Equals(this._arguments, oth._arguments));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(4475L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4492L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4482L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4478L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(4489L, 6));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4510L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4503L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4499L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._arguments)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(4517L, "RAST.Expr.Tuple");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4518L, "(");
            s += Dafny.Helpers.ToString(this._arguments);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4519L, ")");
            return s;
        }
    }
    public class Expr_UnaryOp : Expr
    {
        public readonly Dafny.ISequence<Dafny.Rune> _op1;
        public readonly RAST._IExpr _underlying;
        public readonly DAST.Format._IUnaryOpFormat _format;
        public Expr_UnaryOp(Dafny.ISequence<Dafny.Rune> op1, RAST._IExpr underlying, DAST.Format._IUnaryOpFormat format) : base()
        {
            this._op1 = op1;
            this._underlying = underlying;
            this._format = format;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_UnaryOp(_op1, _underlying, _format);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_UnaryOp;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(4533L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(4527L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(4521L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_78(4520L, oth, null), () => object.Equals(this._op1, oth._op1)), () => object.Equals(this._underlying, oth._underlying)), () => object.Equals(this._format, oth._format));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(4539L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4556L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4546L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4542L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(4553L, 7));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4574L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4567L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4563L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._op1)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4592L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4585L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4581L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._underlying)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4610L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4603L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4599L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._format)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(4617L, "RAST.Expr.UnaryOp");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4618L, "(");
            s += this._op1.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(4619L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4620L, ", ");
            s += Dafny.Helpers.ToString(this._underlying);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4621L, ", ");
            s += Dafny.Helpers.ToString(this._format);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4622L, ")");
            return s;
        }
    }
    public class Expr_BinaryOp : Expr
    {
        public readonly Dafny.ISequence<Dafny.Rune> _op2;
        public readonly RAST._IExpr _left;
        public readonly RAST._IExpr _right;
        public readonly DAST.Format._IBinaryOpFormat _format2;
        public Expr_BinaryOp(Dafny.ISequence<Dafny.Rune> op2, RAST._IExpr left, RAST._IExpr right, DAST.Format._IBinaryOpFormat format2) : base()
        {
            this._op2 = op2;
            this._left = left;
            this._right = right;
            this._format2 = format2;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_BinaryOp(_op2, _left, _right, _format2);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_BinaryOp;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(4642L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(4636L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(4630L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(4624L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_79(4623L, oth, null), () => object.Equals(this._op2, oth._op2)), () => object.Equals(this._left, oth._left)), () => object.Equals(this._right, oth._right)), () => object.Equals(this._format2, oth._format2));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(4648L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4665L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4655L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4651L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(4662L, 8));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4683L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4676L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4672L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._op2)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4701L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4694L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4690L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._left)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4719L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4712L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4708L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._right)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4737L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4730L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4726L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._format2)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(4744L, "RAST.Expr.BinaryOp");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4745L, "(");
            s += this._op2.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(4746L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4747L, ", ");
            s += Dafny.Helpers.ToString(this._left);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4748L, ", ");
            s += Dafny.Helpers.ToString(this._right);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4749L, ", ");
            s += Dafny.Helpers.ToString(this._format2);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4750L, ")");
            return s;
        }
    }
    public class Expr_TypeAscription : Expr
    {
        public readonly RAST._IExpr _left;
        public readonly RAST._IType _tpe;
        public Expr_TypeAscription(RAST._IExpr left, RAST._IType tpe) : base()
        {
            this._left = left;
            this._tpe = tpe;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_TypeAscription(_left, _tpe);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_TypeAscription;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(4758L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(4752L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_80(4751L, oth, null), () => object.Equals(this._left, oth._left)), () => object.Equals(this._tpe, oth._tpe));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(4764L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4781L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4771L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4767L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(4778L, 9));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4799L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4792L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4788L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._left)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4817L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4810L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4806L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._tpe)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(4824L, "RAST.Expr.TypeAscription");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4825L, "(");
            s += Dafny.Helpers.ToString(this._left);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4826L, ", ");
            s += Dafny.Helpers.ToString(this._tpe);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4827L, ")");
            return s;
        }
    }
    public class Expr_LiteralInt : Expr
    {
        public readonly Dafny.ISequence<Dafny.Rune> _value;
        public Expr_LiteralInt(Dafny.ISequence<Dafny.Rune> @value) : base()
        {
            this._value = @value;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_LiteralInt(_value);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_LiteralInt;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(4829L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_81(4828L, oth, null), () => object.Equals(this._value, oth._value));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(4835L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4852L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4842L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4838L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(4849L, 10));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4870L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4863L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4859L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._value)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(4877L, "RAST.Expr.LiteralInt");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4878L, "(");
            s += this._value.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(4879L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4880L, ")");
            return s;
        }
    }
    public class Expr_LiteralString : Expr
    {
        public readonly Dafny.ISequence<Dafny.Rune> _value;
        public readonly bool _binary;
        public Expr_LiteralString(Dafny.ISequence<Dafny.Rune> @value, bool binary) : base()
        {
            this._value = @value;
            this._binary = binary;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_LiteralString(_value, _binary);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_LiteralString;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(4894L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(4882L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_82(4881L, oth, null), () => object.Equals(this._value, oth._value)), () => MutateCSharp.Schemata278.ReplaceBinExprOp_83(4888L, () => this._binary, () => oth._binary));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(4900L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4917L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4907L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4903L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(4914L, 11));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4935L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4928L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4924L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._value)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4953L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4946L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4942L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._binary)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(4960L, "RAST.Expr.LiteralString");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4961L, "(");
            s += this._value.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(4962L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4963L, ", ");
            s += Dafny.Helpers.ToString(this._binary);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(4964L, ")");
            return s;
        }
    }
    public class Expr_ConversionNum : Expr
    {
        public readonly RAST._IType _tpe;
        public readonly RAST._IExpr _underlying;
        public Expr_ConversionNum(RAST._IType tpe, RAST._IExpr underlying) : base()
        {
            this._tpe = tpe;
            this._underlying = underlying;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_ConversionNum(_tpe, _underlying);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_ConversionNum;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(4972L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(4966L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_84(4965L, oth, null), () => object.Equals(this._tpe, oth._tpe)), () => object.Equals(this._underlying, oth._underlying));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(4978L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(4995L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(4985L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(4981L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(4992L, 12));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5013L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5006L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5002L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._tpe)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5031L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5024L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5020L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._underlying)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(5038L, "RAST.Expr.ConversionNum");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5039L, "(");
            s += Dafny.Helpers.ToString(this._tpe);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5040L, ", ");
            s += Dafny.Helpers.ToString(this._underlying);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5041L, ")");
            return s;
        }
    }
    public class Expr_DeclareVar : Expr
    {
        public readonly RAST._IDeclareType _declareType;
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public readonly Std.Wrappers._IOption<RAST._IType> _optType;
        public readonly Std.Wrappers._IOption<RAST._IExpr> _optRhs;
        public Expr_DeclareVar(RAST._IDeclareType declareType, Dafny.ISequence<Dafny.Rune> name, Std.Wrappers._IOption<RAST._IType> optType, Std.Wrappers._IOption<RAST._IExpr> optRhs) : base()
        {
            this._declareType = declareType;
            this._name = name;
            this._optType = optType;
            this._optRhs = optRhs;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_DeclareVar(_declareType, _name, _optType, _optRhs);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_DeclareVar;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(5061L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(5055L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(5049L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(5043L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_85(5042L, oth, null), () => object.Equals(this._declareType, oth._declareType)), () => object.Equals(this._name, oth._name)), () => object.Equals(this._optType, oth._optType)), () => object.Equals(this._optRhs, oth._optRhs));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(5067L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5084L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5074L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5070L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(5081L, 13));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5102L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5095L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5091L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._declareType)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5120L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5113L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5109L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5138L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5131L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5127L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._optType)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5156L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5149L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5145L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._optRhs)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(5163L, "RAST.Expr.DeclareVar");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5164L, "(");
            s += Dafny.Helpers.ToString(this._declareType);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5165L, ", ");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(5166L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5167L, ", ");
            s += Dafny.Helpers.ToString(this._optType);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5168L, ", ");
            s += Dafny.Helpers.ToString(this._optRhs);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5169L, ")");
            return s;
        }
    }
    public class Expr_AssignVar : Expr
    {
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public readonly RAST._IExpr _rhs;
        public Expr_AssignVar(Dafny.ISequence<Dafny.Rune> name, RAST._IExpr rhs) : base()
        {
            this._name = name;
            this._rhs = rhs;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_AssignVar(_name, _rhs);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_AssignVar;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(5177L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(5171L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_86(5170L, oth, null), () => object.Equals(this._name, oth._name)), () => object.Equals(this._rhs, oth._rhs));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(5183L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5200L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5190L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5186L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(5197L, 14));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5218L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5211L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5207L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5236L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5229L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5225L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._rhs)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(5243L, "RAST.Expr.AssignVar");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5244L, "(");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(5245L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5246L, ", ");
            s += Dafny.Helpers.ToString(this._rhs);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5247L, ")");
            return s;
        }
    }
    public class Expr_IfExpr : Expr
    {
        public readonly RAST._IExpr _cond;
        public readonly RAST._IExpr _thn;
        public readonly RAST._IExpr _els;
        public Expr_IfExpr(RAST._IExpr cond, RAST._IExpr thn, RAST._IExpr els) : base()
        {
            this._cond = cond;
            this._thn = thn;
            this._els = els;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_IfExpr(_cond, _thn, _els);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_IfExpr;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(5261L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(5255L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(5249L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_87(5248L, oth, null), () => object.Equals(this._cond, oth._cond)), () => object.Equals(this._thn, oth._thn)), () => object.Equals(this._els, oth._els));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(5267L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5284L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5274L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5270L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(5281L, 15));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5302L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5295L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5291L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._cond)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5320L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5313L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5309L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._thn)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5338L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5331L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5327L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._els)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(5345L, "RAST.Expr.IfExpr");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5346L, "(");
            s += Dafny.Helpers.ToString(this._cond);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5347L, ", ");
            s += Dafny.Helpers.ToString(this._thn);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5348L, ", ");
            s += Dafny.Helpers.ToString(this._els);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5349L, ")");
            return s;
        }
    }
    public class Expr_Loop : Expr
    {
        public readonly Std.Wrappers._IOption<RAST._IExpr> _optCond;
        public readonly RAST._IExpr _underlying;
        public Expr_Loop(Std.Wrappers._IOption<RAST._IExpr> optCond, RAST._IExpr underlying) : base()
        {
            this._optCond = optCond;
            this._underlying = underlying;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_Loop(_optCond, _underlying);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_Loop;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(5357L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(5351L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_88(5350L, oth, null), () => object.Equals(this._optCond, oth._optCond)), () => object.Equals(this._underlying, oth._underlying));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(5363L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5380L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5370L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5366L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(5377L, 16));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5398L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5391L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5387L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._optCond)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5416L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5409L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5405L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._underlying)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(5423L, "RAST.Expr.Loop");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5424L, "(");
            s += Dafny.Helpers.ToString(this._optCond);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5425L, ", ");
            s += Dafny.Helpers.ToString(this._underlying);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5426L, ")");
            return s;
        }
    }
    public class Expr_For : Expr
    {
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public readonly RAST._IExpr _range;
        public readonly RAST._IExpr _body;
        public Expr_For(Dafny.ISequence<Dafny.Rune> name, RAST._IExpr range, RAST._IExpr body) : base()
        {
            this._name = name;
            this._range = range;
            this._body = body;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_For(_name, _range, _body);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_For;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(5440L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(5434L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(5428L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_89(5427L, oth, null), () => object.Equals(this._name, oth._name)), () => object.Equals(this._range, oth._range)), () => object.Equals(this._body, oth._body));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(5446L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5463L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5453L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5449L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(5460L, 17));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5481L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5474L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5470L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5499L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5492L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5488L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._range)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5517L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5510L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5506L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._body)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(5524L, "RAST.Expr.For");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5525L, "(");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(5526L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5527L, ", ");
            s += Dafny.Helpers.ToString(this._range);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5528L, ", ");
            s += Dafny.Helpers.ToString(this._body);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5529L, ")");
            return s;
        }
    }
    public class Expr_Labelled : Expr
    {
        public readonly Dafny.ISequence<Dafny.Rune> _lbl;
        public readonly RAST._IExpr _underlying;
        public Expr_Labelled(Dafny.ISequence<Dafny.Rune> lbl, RAST._IExpr underlying) : base()
        {
            this._lbl = lbl;
            this._underlying = underlying;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_Labelled(_lbl, _underlying);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_Labelled;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(5537L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(5531L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_90(5530L, oth, null), () => object.Equals(this._lbl, oth._lbl)), () => object.Equals(this._underlying, oth._underlying));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(5543L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5560L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5550L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5546L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(5557L, 18));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5578L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5571L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5567L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._lbl)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5596L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5589L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5585L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._underlying)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(5603L, "RAST.Expr.Labelled");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5604L, "(");
            s += this._lbl.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(5605L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5606L, ", ");
            s += Dafny.Helpers.ToString(this._underlying);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5607L, ")");
            return s;
        }
    }
    public class Expr_Break : Expr
    {
        public readonly Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _optLbl;
        public Expr_Break(Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> optLbl) : base()
        {
            this._optLbl = optLbl;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_Break(_optLbl);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_Break;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(5609L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_91(5608L, oth, null), () => object.Equals(this._optLbl, oth._optLbl));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(5615L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5632L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5622L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5618L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(5629L, 19));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5650L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5643L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5639L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._optLbl)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(5657L, "RAST.Expr.Break");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5658L, "(");
            s += Dafny.Helpers.ToString(this._optLbl);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5659L, ")");
            return s;
        }
    }
    public class Expr_Continue : Expr
    {
        public readonly Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _optLbl;
        public Expr_Continue(Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> optLbl) : base()
        {
            this._optLbl = optLbl;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_Continue(_optLbl);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_Continue;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(5661L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_92(5660L, oth, null), () => object.Equals(this._optLbl, oth._optLbl));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(5667L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5684L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5674L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5670L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(5681L, 20));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5702L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5695L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5691L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._optLbl)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(5709L, "RAST.Expr.Continue");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5710L, "(");
            s += Dafny.Helpers.ToString(this._optLbl);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5711L, ")");
            return s;
        }
    }
    public class Expr_Return : Expr
    {
        public readonly Std.Wrappers._IOption<RAST._IExpr> _optExpr;
        public Expr_Return(Std.Wrappers._IOption<RAST._IExpr> optExpr) : base()
        {
            this._optExpr = optExpr;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_Return(_optExpr);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_Return;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(5713L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_93(5712L, oth, null), () => object.Equals(this._optExpr, oth._optExpr));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(5719L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5736L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5726L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5722L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(5733L, 21));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5754L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5747L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5743L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._optExpr)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(5761L, "RAST.Expr.Return");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5762L, "(");
            s += Dafny.Helpers.ToString(this._optExpr);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5763L, ")");
            return s;
        }
    }
    public class Expr_Call : Expr
    {
        public readonly RAST._IExpr _obj;
        public readonly Dafny.ISequence<RAST._IType> _typeParameters;
        public readonly Dafny.ISequence<RAST._IExpr> _arguments;
        public Expr_Call(RAST._IExpr obj, Dafny.ISequence<RAST._IType> typeParameters, Dafny.ISequence<RAST._IExpr> arguments) : base()
        {
            this._obj = obj;
            this._typeParameters = typeParameters;
            this._arguments = arguments;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_Call(_obj, _typeParameters, _arguments);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_Call;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(5777L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(5771L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(5765L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_94(5764L, oth, null), () => object.Equals(this._obj, oth._obj)), () => object.Equals(this._typeParameters, oth._typeParameters)), () => object.Equals(this._arguments, oth._arguments));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(5783L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5800L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5790L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5786L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(5797L, 22));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5818L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5811L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5807L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._obj)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5836L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5829L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5825L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typeParameters)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5854L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5847L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5843L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._arguments)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(5861L, "RAST.Expr.Call");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5862L, "(");
            s += Dafny.Helpers.ToString(this._obj);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5863L, ", ");
            s += Dafny.Helpers.ToString(this._typeParameters);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5864L, ", ");
            s += Dafny.Helpers.ToString(this._arguments);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5865L, ")");
            return s;
        }
    }
    public class Expr_Select : Expr
    {
        public readonly RAST._IExpr _obj;
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public Expr_Select(RAST._IExpr obj, Dafny.ISequence<Dafny.Rune> name) : base()
        {
            this._obj = obj;
            this._name = name;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_Select(_obj, _name);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_Select;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(5873L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(5867L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_95(5866L, oth, null), () => object.Equals(this._obj, oth._obj)), () => object.Equals(this._name, oth._name));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(5879L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5896L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5886L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5882L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(5893L, 23));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5914L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5907L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5903L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._obj)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5932L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5925L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5921L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(5939L, "RAST.Expr.Select");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5940L, "(");
            s += Dafny.Helpers.ToString(this._obj);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5941L, ", ");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(5942L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(5943L, ")");
            return s;
        }
    }
    public class Expr_MemberSelect : Expr
    {
        public readonly RAST._IExpr _obj;
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public Expr_MemberSelect(RAST._IExpr obj, Dafny.ISequence<Dafny.Rune> name) : base()
        {
            this._obj = obj;
            this._name = name;
        }
        public override _IExpr DowncastClone()
        {
            if (this is _IExpr dt) { return dt; }
            return new Expr_MemberSelect(_obj, _name);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Expr_MemberSelect;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(5951L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(5945L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_96(5944L, oth, null), () => object.Equals(this._obj, oth._obj)), () => object.Equals(this._name, oth._name));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(5957L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5974L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5964L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5960L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(5971L, 24));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(5992L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(5985L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5981L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._obj)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(6010L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(6003L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(5999L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(6017L, "RAST.Expr.MemberSelect");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(6018L, "(");
            s += Dafny.Helpers.ToString(this._obj);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(6019L, ", ");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(6020L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(6021L, ")");
            return s;
        }
    }

    public interface _IFn
    {
        bool is_Fn { get; }
        Dafny.ISequence<Dafny.Rune> dtor_name { get; }
        Dafny.ISequence<RAST._ITypeParam> dtor_typeParams { get; }
        Dafny.ISequence<RAST._IFormal> dtor_formals { get; }
        Std.Wrappers._IOption<RAST._IType> dtor_returnType { get; }
        Dafny.ISequence<Dafny.Rune> dtor_where { get; }
        Std.Wrappers._IOption<RAST._IExpr> dtor_body { get; }

        _IFn DowncastClone();
        Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind);
    }
    public class Fn : _IFn
    {
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public readonly Dafny.ISequence<RAST._ITypeParam> _typeParams;
        public readonly Dafny.ISequence<RAST._IFormal> _formals;
        public readonly Std.Wrappers._IOption<RAST._IType> _returnType;
        public readonly Dafny.ISequence<Dafny.Rune> _where;
        public readonly Std.Wrappers._IOption<RAST._IExpr> _body;
        public Fn(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._ITypeParam> typeParams, Dafny.ISequence<RAST._IFormal> formals, Std.Wrappers._IOption<RAST._IType> returnType, Dafny.ISequence<Dafny.Rune> @where, Std.Wrappers._IOption<RAST._IExpr> body)
        {
            this._name = name;
            this._typeParams = typeParams;
            this._formals = formals;
            this._returnType = returnType;
            this._where = @where;
            this._body = body;
        }
        public _IFn DowncastClone()
        {
            if (this is _IFn dt) { return dt; }
            return new Fn(_name, _typeParams, _formals, _returnType, _where, _body);
        }
        public override bool Equals(object other)
        {
            var oth = other as RAST.Fn;
            return MutateCSharp.Schemata278.ReplaceBinExprOp_5(6053L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(6047L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(6041L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(6035L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(6029L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_5(6023L, () => MutateCSharp.Schemata278.ReplaceBinExprOp_97(6022L, oth, null), () => object.Equals(this._name, oth._name)), () => object.Equals(this._typeParams, oth._typeParams)), () => object.Equals(this._formals, oth._formals)), () => object.Equals(this._returnType, oth._returnType)), () => object.Equals(this._where, oth._where)), () => object.Equals(this._body, oth._body));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata278.ReplaceNumericConstant_8(6059L, 5381);
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(6076L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(6066L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(6062L, 5)), hash)), MutateCSharp.Schemata278.ReplaceNumericConstant_8(6073L, 0));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(6094L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(6087L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(6083L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(6112L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(6105L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(6101L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typeParams)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(6130L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(6123L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(6119L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._formals)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(6148L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(6141L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(6137L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._returnType)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(6166L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(6159L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(6155L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._where)));
            hash = MutateCSharp.Schemata278.ReplaceBinExprOp_9(6184L, (MutateCSharp.Schemata278.ReplaceBinExprOp_9(6177L, (hash << MutateCSharp.Schemata278.ReplaceNumericConstant_0(6173L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._body)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata278.ReplaceStringConstant_4(6191L, "RAST.Fn.Fn");
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(6192L, "(");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(6193L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(6194L, ", ");
            s += Dafny.Helpers.ToString(this._typeParams);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(6195L, ", ");
            s += Dafny.Helpers.ToString(this._formals);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(6196L, ", ");
            s += Dafny.Helpers.ToString(this._returnType);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(6197L, ", ");
            s += this._where.ToVerbatimString(MutateCSharp.Schemata278.ReplaceBooleanConstant_10(6198L, true));
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(6199L, ", ");
            s += Dafny.Helpers.ToString(this._body);
            s += MutateCSharp.Schemata278.ReplaceStringConstant_4(6200L, ")");
            return s;
        }
        private static readonly RAST._IFn theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<RAST._ITypeParam>.Empty, Dafny.Sequence<RAST._IFormal>.Empty, Std.Wrappers.Option<RAST._IType>.Default(), Dafny.Sequence<Dafny.Rune>.Empty, Std.Wrappers.Option<RAST._IExpr>.Default());
        public static RAST._IFn Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<RAST._IFn> _TYPE = new Dafny.TypeDescriptor<RAST._IFn>(RAST.Fn.Default());
        public static Dafny.TypeDescriptor<RAST._IFn> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IFn create(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._ITypeParam> typeParams, Dafny.ISequence<RAST._IFormal> formals, Std.Wrappers._IOption<RAST._IType> returnType, Dafny.ISequence<Dafny.Rune> @where, Std.Wrappers._IOption<RAST._IExpr> body)
        {
            return new Fn(name, typeParams, formals, returnType, @where, body);
        }
        public static _IFn create_Fn(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<RAST._ITypeParam> typeParams, Dafny.ISequence<RAST._IFormal> formals, Std.Wrappers._IOption<RAST._IType> returnType, Dafny.ISequence<Dafny.Rune> @where, Std.Wrappers._IOption<RAST._IExpr> body)
        {
            return create(name, typeParams, formals, returnType, @where, body);
        }
        public bool is_Fn
        {
            get { return MutateCSharp.Schemata278.ReplaceBooleanConstant_10(6201L, true); }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_name
        {
            get
            {
                return this._name;
            }
        }

        public Dafny.ISequence<RAST._ITypeParam> dtor_typeParams
        {
            get
            {
                return this._typeParams;
            }
        }

        public Dafny.ISequence<RAST._IFormal> dtor_formals
        {
            get
            {
                return this._formals;
            }
        }

        public Std.Wrappers._IOption<RAST._IType> dtor_returnType
        {
            get
            {
                return this._returnType;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_where
        {
            get
            {
                return this._where;
            }
        }

        public Std.Wrappers._IOption<RAST._IExpr> dtor_body
        {
            get
            {
                return this._body;
            }
        }

        public Dafny.ISequence<Dafny.Rune> _ToString(Dafny.ISequence<Dafny.Rune> ind)
        {
            var _pat_let_tv5 = ind;
            var _pat_let_tv6 = ind;
            var _pat_let_tv7 = ind;
            var _pat_let_tv8 = ind;
            return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(6202L, "fn ")), (this).dtor_name), RAST.TypeParam.ToStringMultiple((this).dtor_typeParams, ind)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(6203L, "("))), RAST.__default.SeqToString<RAST._IFormal>((this).dtor_formals, Dafny.Helpers.Id<Func<Dafny.ISequence<Dafny.Rune>, Func<RAST._IFormal, Dafny.ISequence<Dafny.Rune>>>>((_1827_ind) => ((System.Func<RAST._IFormal, Dafny.ISequence<Dafny.Rune>>)((_1828_formal) =>
            {
                return (_1828_formal)._ToString(_1827_ind);
            })))(ind), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(6204L, ", ")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(6205L, ")"))), ((System.Func<Std.Wrappers._IOption<RAST._IType>, Dafny.ISequence<Dafny.Rune>>)((_source53) =>
            {
                if (_source53.is_None)
                {
                    return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
                }
                else
                {
                    RAST._IType _1829___mcc_h0 = _source53.dtor_value;
                    RAST._IType _1830_t = _1829___mcc_h0;
                    return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(6206L, " -> ")), (_1830_t)._ToString(_pat_let_tv5));
                }

                return default;
            }))((this).dtor_returnType)), ((((this).dtor_where).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(6207L, "\n")), ind), RAST.__default.IND), (this).dtor_where)))), ((System.Func<Std.Wrappers._IOption<RAST._IExpr>, Dafny.ISequence<Dafny.Rune>>)((_source54) =>
            {
                if (_source54.is_None)
                {
                    return Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(6208L, ";"));
                }
                else
                {
                    RAST._IExpr _1831___mcc_h2 = _source54.dtor_value;
                    RAST._IExpr _1832_body = _1831___mcc_h2;
                    return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(6209L, " {\n")), _pat_let_tv6), RAST.__default.IND), (_1832_body)._ToString(Dafny.Sequence<Dafny.Rune>.Concat(_pat_let_tv7, RAST.__default.IND))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(6210L, "\n"))), _pat_let_tv8), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata278.ReplaceStringConstant_4(6211L, "}")));
                }

                return default;
            }))((this).dtor_body));
        }
    }
} // end of namespace RAST