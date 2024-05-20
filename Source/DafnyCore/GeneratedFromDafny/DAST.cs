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
    internal class Schemata274
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT274");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
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

        internal static bool ReplaceBinExprOp_14(long mutantId, DAST.Type_Nullable argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_153(long mutantId, DAST.Expression_Apply argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_77(long mutantId, DAST.AssignLhs_Ident argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_127(long mutantId, DAST.Expression_SeqConstruct argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_86(long mutantId, DAST.BinOp_Mod argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_46(long mutantId, DAST.ResolvedType_Trait argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, DAST.Type_Set argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_149(long mutantId, DAST.Expression_Call argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_117(long mutantId, DAST.BinOp_Concat argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_72(long mutantId, DAST.Statement_Break argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_132(long mutantId, DAST.Expression_MapBuilder argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_44(long mutantId, DAST.NewtypeRange_NoRange argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_155(long mutantId, DAST.Expression_InitializationValue argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_80(long mutantId, DAST.CollKind_Seq argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_101(long mutantId, DAST.BinOp_SeqProperPrefix argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_36(long mutantId, DAST.NewtypeRange_I16 argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_31(long mutantId, DAST.Primitive_Bool argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_142(long mutantId, DAST.Expression_MapKeys argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_67(long mutantId, DAST.Statement_While argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_71(long mutantId, DAST.Statement_EarlyReturn argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_112(long mutantId, DAST.BinOp_MultisetSubtraction argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_66(long mutantId, DAST.Statement_Labeled argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_68(long mutantId, DAST.Statement_Foreach argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_145(long mutantId, DAST.Expression_SelectFn argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static ulong ReplaceBinExprOp_5(long mutantId, ulong argument1, ulong argument2)
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

        internal static bool ReplaceBinExprOp_144(long mutantId, DAST.Expression_Select argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_97(long mutantId, DAST.BinOp_BitwiseShiftLeft argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_136(long mutantId, DAST.Expression_ToMultiset argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_76(long mutantId, DAST.Statement_Print argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_91(long mutantId, DAST.BinOp_Minus argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_84(long mutantId, DAST.BinOp_Div argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, DAST.Type_Array argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_30(long mutantId, DAST.Primitive_String argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_126(long mutantId, DAST.Expression_Convert argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_93(long mutantId, DAST.BinOp_BitwiseAnd argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_165(long mutantId, DAST.Literal_DecLiteral argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_140(long mutantId, DAST.Expression_BinOp argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, DAST.ModuleItem_Newtype argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_64(long mutantId, DAST.Statement_Assign argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_162(long mutantId, DAST.UnaryOp_Cardinality argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_164(long mutantId, DAST.Literal_IntLiteral argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_138(long mutantId, DAST.Expression_Ite argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_111(long mutantId, DAST.BinOp_MultisetMerge argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_50(long mutantId, DAST.Trait argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_73(long mutantId, DAST.Statement_TailRecursive argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_35(long mutantId, DAST.NewtypeRange_U16 argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_119(long mutantId, DAST.Expression_Literal argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_134(long mutantId, DAST.Expression_MapUpdate argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_99(long mutantId, DAST.BinOp_Or argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_141(long mutantId, DAST.Expression_ArrayLen argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_74(long mutantId, DAST.Statement_JumpTailCallStart argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_53(long mutantId, DAST.Newtype argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_120(long mutantId, DAST.Expression_Ident argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, DAST.Type_Seq argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_125(long mutantId, DAST.Expression_DatatypeValue argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_70(long mutantId, DAST.Statement_Return argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_158(long mutantId, DAST.Expression_SeqBoundedPool argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_45(long mutantId, DAST.ResolvedType_Datatype argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_168(long mutantId, Dafny.Rune argument1, Dafny.Rune argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_60(long mutantId, DAST.CallName_MapBuilderBuild argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_115(long mutantId, DAST.BinOp_ProperSubmultiset argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_169(long mutantId, DAST.Literal_Null argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, DAST.Type_Arrow argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_157(long mutantId, DAST.Expression_SetBoundedPool argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_135(long mutantId, DAST.Expression_SetBuilder argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, DAST.Type_Passthrough argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_34(long mutantId, DAST.NewtypeRange_I8 argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_166(long mutantId, DAST.Literal_StringLiteral argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_89(long mutantId, DAST.BinOp_LtChar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_98(long mutantId, DAST.BinOp_And argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_78(long mutantId, DAST.AssignLhs_Select argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_41(long mutantId, DAST.NewtypeRange_U128 argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_124(long mutantId, DAST.Expression_NewArray argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_38(long mutantId, DAST.NewtypeRange_I32 argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_83(long mutantId, DAST.BinOp_Eq argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_148(long mutantId, DAST.Expression_TupleSelect argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_28(long mutantId, DAST.Primitive_Int argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_82(long mutantId, DAST.CollKind_Map argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static ulong ReplaceNumericConstant_3(long mutantId, ulong argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 2)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_57(long mutantId, DAST.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_40(long mutantId, DAST.NewtypeRange_I64 argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_96(long mutantId, DAST.BinOp_BitwiseShiftRight argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_100(long mutantId, DAST.BinOp_In argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_116(long mutantId, DAST.BinOp_MultisetDisjoint argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_88(long mutantId, DAST.BinOp_Lt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_110(long mutantId, DAST.BinOp_MapSubtraction argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_122(long mutantId, DAST.Expression_Tuple argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_65(long mutantId, DAST.Statement_If argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, DAST.ModuleItem_Class argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_121(long mutantId, DAST.Expression_Companion argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_147(long mutantId, DAST.Expression_IndexRange argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_55(long mutantId, DAST.Field argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_104(long mutantId, DAST.BinOp_SetSubtraction argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_103(long mutantId, DAST.BinOp_SetMerge argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_6(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_159(long mutantId, DAST.Expression_IntRange argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_92(long mutantId, DAST.BinOp_Times argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_139(long mutantId, DAST.Expression_UnOp argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_47(long mutantId, DAST.ResolvedType_Newtype argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_62(long mutantId, DAST.CallName_SetBuilderBuild argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_94(long mutantId, DAST.BinOp_BitwiseOr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, DAST.Type_SetBuilder argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_29(long mutantId, DAST.Primitive_Real argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, DAST.Type_TypeArg argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, DAST.Type_MapBuilder argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, DAST.Type_Primitive argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_63(long mutantId, DAST.Statement_DeclareVar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_51(long mutantId, DAST.Datatype argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_113(long mutantId, DAST.BinOp_MultisetIntersection argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_79(long mutantId, DAST.AssignLhs_Index argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_48(long mutantId, DAST.Ident argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_106(long mutantId, DAST.BinOp_Subset argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_43(long mutantId, DAST.NewtypeRange_BigInt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_85(long mutantId, DAST.BinOp_EuclidianDiv argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_150(long mutantId, DAST.Expression_Lambda argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_131(long mutantId, DAST.Expression_MapValue argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_32(long mutantId, DAST.Primitive_Char argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_146(long mutantId, DAST.Expression_Index argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_105(long mutantId, DAST.BinOp_SetIntersection argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_52(long mutantId, DAST.DatatypeCtor argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, DAST.Type_Map argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_109(long mutantId, DAST.BinOp_MapMerge argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, DAST.Type_Multiset argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_49(long mutantId, DAST.Class argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_118(long mutantId, DAST.BinOp_Passthrough argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_151(long mutantId, DAST.Expression_BetaRedex argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_42(long mutantId, DAST.NewtypeRange_I128 argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, DAST.ModuleItem_Trait argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_130(long mutantId, DAST.Expression_MultisetValue argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_123(long mutantId, DAST.Expression_New argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_156(long mutantId, DAST.Expression_BoolBoundedPool argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_143(long mutantId, DAST.Expression_MapValues argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_54(long mutantId, DAST.ClassItem argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_161(long mutantId, DAST.UnaryOp_BitwiseNot argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_39(long mutantId, DAST.NewtypeRange_U64 argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_108(long mutantId, DAST.BinOp_SetDisjoint argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_75(long mutantId, DAST.Statement_Halt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, DAST.ModuleItem_Datatype argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_167(long mutantId, DAST.Literal_CharLiteral argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_129(long mutantId, DAST.Expression_SetValue argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_133(long mutantId, DAST.Expression_SeqUpdate argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_102(long mutantId, DAST.BinOp_SeqPrefix argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, DAST.Type_Tuple argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_154(long mutantId, DAST.Expression_TypeTest argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_81(long mutantId, DAST.CollKind_Array argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_128(long mutantId, DAST.Expression_SeqValue argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_87(long mutantId, DAST.BinOp_EuclidianMod argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_163(long mutantId, DAST.Literal_BoolLiteral argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_33(long mutantId, DAST.NewtypeRange_U8 argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_160(long mutantId, DAST.UnaryOp_Not argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_59(long mutantId, DAST.CallName_MapBuilderAdd argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_7(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_37(long mutantId, DAST.NewtypeRange_U32 argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_56(long mutantId, DAST.Formal argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_152(long mutantId, DAST.Expression_IIFE argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, System.Numerics.BigInteger argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_58(long mutantId, DAST.CallName_Name argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_90(long mutantId, DAST.BinOp_Plus argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_137(long mutantId, DAST.Expression_This argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, DAST.Module argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_61(long mutantId, DAST.CallName_SetBuilderAdd argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_95(long mutantId, DAST.BinOp_BitwiseXor argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_114(long mutantId, DAST.BinOp_Submultiset argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, DAST.Type_Path argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_69(long mutantId, DAST.Statement_Call argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, DAST.ModuleItem_Module argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_107(long mutantId, DAST.BinOp_ProperSubset argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace DAST
{


    public interface _IModule
    {
        bool is_Module { get; }
        Dafny.ISequence<Dafny.Rune> dtor_name { get; }
        bool dtor_isExtern { get; }
        Dafny.ISequence<DAST._IModuleItem> dtor_body { get; }

        _IModule DowncastClone();
    }
    public class Module : _IModule
    {
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public readonly bool _isExtern;
        public readonly Dafny.ISequence<DAST._IModuleItem> _body;
        public Module(Dafny.ISequence<Dafny.Rune> name, bool isExtern, Dafny.ISequence<DAST._IModuleItem> body)
        {
            this._name = name;
            this._isExtern = isExtern;
            this._body = body;
        }
        public _IModule DowncastClone()
        {
            if (this is _IModule dt) { return dt; }
            return new Module(_name, _isExtern, _body);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Module;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(20L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(14L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_0(1L, oth, null), () => object.Equals(this._name, oth._name)), () => MutateCSharp.Schemata274.ReplaceBinExprOp_2(8L, () => this._isExtern, () => oth._isExtern)), () => object.Equals(this._body, oth._body));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(26L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(43L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(33L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(29L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(40L, 0));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(61L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(54L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(50L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(79L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(72L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(68L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._isExtern)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(97L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(90L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(86L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._body)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(104L, "DAST.Module.Module");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(105L, "(");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(106L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(107L, ", ");
            s += Dafny.Helpers.ToString(this._isExtern);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(108L, ", ");
            s += Dafny.Helpers.ToString(this._body);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(109L, ")");
            return s;
        }
        private static readonly DAST._IModule theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, MutateCSharp.Schemata274.ReplaceBooleanConstant_7(110L, false), Dafny.Sequence<DAST._IModuleItem>.Empty);
        public static DAST._IModule Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST._IModule> _TYPE = new Dafny.TypeDescriptor<DAST._IModule>(DAST.Module.Default());
        public static Dafny.TypeDescriptor<DAST._IModule> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IModule create(Dafny.ISequence<Dafny.Rune> name, bool isExtern, Dafny.ISequence<DAST._IModuleItem> body)
        {
            return new Module(name, isExtern, body);
        }
        public static _IModule create_Module(Dafny.ISequence<Dafny.Rune> name, bool isExtern, Dafny.ISequence<DAST._IModuleItem> body)
        {
            return create(name, isExtern, body);
        }
        public bool is_Module
        {
            get { return MutateCSharp.Schemata274.ReplaceBooleanConstant_7(111L, true); }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_name
        {
            get
            {
                return this._name;
            }
        }

        public bool dtor_isExtern
        {
            get
            {
                return this._isExtern;
            }
        }

        public Dafny.ISequence<DAST._IModuleItem> dtor_body
        {
            get
            {
                return this._body;
            }
        }
    }

    public interface _IModuleItem
    {
        bool is_Module { get; }
        bool is_Class { get; }
        bool is_Trait { get; }
        bool is_Newtype { get; }
        bool is_Datatype { get; }
        DAST._IModule dtor_Module_a0 { get; }
        DAST._IClass dtor_Class_a0 { get; }
        DAST._ITrait dtor_Trait_a0 { get; }
        DAST._INewtype dtor_Newtype_a0 { get; }
        DAST._IDatatype dtor_Datatype_a0 { get; }

        _IModuleItem DowncastClone();
    }
    public abstract class ModuleItem : _IModuleItem
    {
        public ModuleItem()
        {
        }
        private static readonly DAST._IModuleItem theDefault = create_Module(DAST.Module.Default());
        public static DAST._IModuleItem Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST._IModuleItem> _TYPE = new Dafny.TypeDescriptor<DAST._IModuleItem>(DAST.ModuleItem.Default());
        public static Dafny.TypeDescriptor<DAST._IModuleItem> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IModuleItem create_Module(DAST._IModule _a0)
        {
            return new ModuleItem_Module(_a0);
        }
        public static _IModuleItem create_Class(DAST._IClass _a0)
        {
            return new ModuleItem_Class(_a0);
        }
        public static _IModuleItem create_Trait(DAST._ITrait _a0)
        {
            return new ModuleItem_Trait(_a0);
        }
        public static _IModuleItem create_Newtype(DAST._INewtype _a0)
        {
            return new ModuleItem_Newtype(_a0);
        }
        public static _IModuleItem create_Datatype(DAST._IDatatype _a0)
        {
            return new ModuleItem_Datatype(_a0);
        }
        public bool is_Module
        {
            get { return this is ModuleItem_Module; }
        }

        public bool is_Class
        {
            get { return this is ModuleItem_Class; }
        }

        public bool is_Trait
        {
            get { return this is ModuleItem_Trait; }
        }

        public bool is_Newtype
        {
            get { return this is ModuleItem_Newtype; }
        }

        public bool is_Datatype
        {
            get { return this is ModuleItem_Datatype; }
        }

        public DAST._IModule dtor_Module_a0
        {
            get
            {
                var d = this;
                return ((ModuleItem_Module)d)._a0;
            }
        }

        public DAST._IClass dtor_Class_a0
        {
            get
            {
                var d = this;
                return ((ModuleItem_Class)d)._a0;
            }
        }

        public DAST._ITrait dtor_Trait_a0
        {
            get
            {
                var d = this;
                return ((ModuleItem_Trait)d)._a0;
            }
        }

        public DAST._INewtype dtor_Newtype_a0
        {
            get
            {
                var d = this;
                return ((ModuleItem_Newtype)d)._a0;
            }
        }

        public DAST._IDatatype dtor_Datatype_a0
        {
            get
            {
                var d = this;
                return ((ModuleItem_Datatype)d)._a0;
            }
        }

        public abstract _IModuleItem DowncastClone();
    }
    public class ModuleItem_Module : ModuleItem
    {
        public readonly DAST._IModule _a0;
        public ModuleItem_Module(DAST._IModule _a0) : base()
        {
            this._a0 = _a0;
        }
        public override _IModuleItem DowncastClone()
        {
            if (this is _IModuleItem dt) { return dt; }
            return new ModuleItem_Module(_a0);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.ModuleItem_Module;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(113L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_8(112L, oth, null), () => object.Equals(this._a0, oth._a0));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(119L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(136L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(126L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(122L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(133L, 0));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(154L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(147L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(143L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(161L, "DAST.ModuleItem.Module");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(162L, "(");
            s += Dafny.Helpers.ToString(this._a0);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(163L, ")");
            return s;
        }
    }
    public class ModuleItem_Class : ModuleItem
    {
        public readonly DAST._IClass _a0;
        public ModuleItem_Class(DAST._IClass _a0) : base()
        {
            this._a0 = _a0;
        }
        public override _IModuleItem DowncastClone()
        {
            if (this is _IModuleItem dt) { return dt; }
            return new ModuleItem_Class(_a0);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.ModuleItem_Class;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(165L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_9(164L, oth, null), () => object.Equals(this._a0, oth._a0));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(171L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(188L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(178L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(174L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(185L, 1));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(206L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(199L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(195L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(213L, "DAST.ModuleItem.Class");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(214L, "(");
            s += Dafny.Helpers.ToString(this._a0);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(215L, ")");
            return s;
        }
    }
    public class ModuleItem_Trait : ModuleItem
    {
        public readonly DAST._ITrait _a0;
        public ModuleItem_Trait(DAST._ITrait _a0) : base()
        {
            this._a0 = _a0;
        }
        public override _IModuleItem DowncastClone()
        {
            if (this is _IModuleItem dt) { return dt; }
            return new ModuleItem_Trait(_a0);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.ModuleItem_Trait;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(217L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_10(216L, oth, null), () => object.Equals(this._a0, oth._a0));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(223L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(240L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(230L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(226L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(237L, 2));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(258L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(251L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(247L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(265L, "DAST.ModuleItem.Trait");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(266L, "(");
            s += Dafny.Helpers.ToString(this._a0);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(267L, ")");
            return s;
        }
    }
    public class ModuleItem_Newtype : ModuleItem
    {
        public readonly DAST._INewtype _a0;
        public ModuleItem_Newtype(DAST._INewtype _a0) : base()
        {
            this._a0 = _a0;
        }
        public override _IModuleItem DowncastClone()
        {
            if (this is _IModuleItem dt) { return dt; }
            return new ModuleItem_Newtype(_a0);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.ModuleItem_Newtype;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(269L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_11(268L, oth, null), () => object.Equals(this._a0, oth._a0));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(275L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(292L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(282L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(278L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(289L, 3));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(310L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(303L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(299L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(317L, "DAST.ModuleItem.Newtype");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(318L, "(");
            s += Dafny.Helpers.ToString(this._a0);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(319L, ")");
            return s;
        }
    }
    public class ModuleItem_Datatype : ModuleItem
    {
        public readonly DAST._IDatatype _a0;
        public ModuleItem_Datatype(DAST._IDatatype _a0) : base()
        {
            this._a0 = _a0;
        }
        public override _IModuleItem DowncastClone()
        {
            if (this is _IModuleItem dt) { return dt; }
            return new ModuleItem_Datatype(_a0);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.ModuleItem_Datatype;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(321L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_12(320L, oth, null), () => object.Equals(this._a0, oth._a0));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(327L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(344L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(334L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(330L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(341L, 4));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(362L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(355L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(351L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(369L, "DAST.ModuleItem.Datatype");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(370L, "(");
            s += Dafny.Helpers.ToString(this._a0);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(371L, ")");
            return s;
        }
    }

    public interface _IType
    {
        bool is_Path { get; }
        bool is_Nullable { get; }
        bool is_Tuple { get; }
        bool is_Array { get; }
        bool is_Seq { get; }
        bool is_Set { get; }
        bool is_Multiset { get; }
        bool is_Map { get; }
        bool is_SetBuilder { get; }
        bool is_MapBuilder { get; }
        bool is_Arrow { get; }
        bool is_Primitive { get; }
        bool is_Passthrough { get; }
        bool is_TypeArg { get; }
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_Path_a0 { get; }
        Dafny.ISequence<DAST._IType> dtor_typeArgs { get; }
        DAST._IResolvedType dtor_resolved { get; }
        DAST._IType dtor_Nullable_a0 { get; }
        Dafny.ISequence<DAST._IType> dtor_Tuple_a0 { get; }
        DAST._IType dtor_element { get; }
        BigInteger dtor_dims { get; }
        DAST._IType dtor_key { get; }
        DAST._IType dtor_value { get; }
        Dafny.ISequence<DAST._IType> dtor_args { get; }
        DAST._IType dtor_result { get; }
        DAST._IPrimitive dtor_Primitive_a0 { get; }
        Dafny.ISequence<Dafny.Rune> dtor_Passthrough_a0 { get; }
        Dafny.ISequence<Dafny.Rune> dtor_TypeArg_a0 { get; }

        _IType DowncastClone();
    }
    public abstract class Type : _IType
    {
        public Type()
        {
        }
        private static readonly DAST._IType theDefault = create_Path(Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Empty, Dafny.Sequence<DAST._IType>.Empty, DAST.ResolvedType.Default());
        public static DAST._IType Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST._IType> _TYPE = new Dafny.TypeDescriptor<DAST._IType>(DAST.Type.Default());
        public static Dafny.TypeDescriptor<DAST._IType> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IType create_Path(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _a0, Dafny.ISequence<DAST._IType> typeArgs, DAST._IResolvedType resolved)
        {
            return new Type_Path(_a0, typeArgs, resolved);
        }
        public static _IType create_Nullable(DAST._IType _a0)
        {
            return new Type_Nullable(_a0);
        }
        public static _IType create_Tuple(Dafny.ISequence<DAST._IType> _a0)
        {
            return new Type_Tuple(_a0);
        }
        public static _IType create_Array(DAST._IType element, BigInteger dims)
        {
            return new Type_Array(element, dims);
        }
        public static _IType create_Seq(DAST._IType element)
        {
            return new Type_Seq(element);
        }
        public static _IType create_Set(DAST._IType element)
        {
            return new Type_Set(element);
        }
        public static _IType create_Multiset(DAST._IType element)
        {
            return new Type_Multiset(element);
        }
        public static _IType create_Map(DAST._IType key, DAST._IType @value)
        {
            return new Type_Map(key, @value);
        }
        public static _IType create_SetBuilder(DAST._IType element)
        {
            return new Type_SetBuilder(element);
        }
        public static _IType create_MapBuilder(DAST._IType key, DAST._IType @value)
        {
            return new Type_MapBuilder(key, @value);
        }
        public static _IType create_Arrow(Dafny.ISequence<DAST._IType> args, DAST._IType result)
        {
            return new Type_Arrow(args, result);
        }
        public static _IType create_Primitive(DAST._IPrimitive _a0)
        {
            return new Type_Primitive(_a0);
        }
        public static _IType create_Passthrough(Dafny.ISequence<Dafny.Rune> _a0)
        {
            return new Type_Passthrough(_a0);
        }
        public static _IType create_TypeArg(Dafny.ISequence<Dafny.Rune> _a0)
        {
            return new Type_TypeArg(_a0);
        }
        public bool is_Path
        {
            get { return this is Type_Path; }
        }

        public bool is_Nullable
        {
            get { return this is Type_Nullable; }
        }

        public bool is_Tuple
        {
            get { return this is Type_Tuple; }
        }

        public bool is_Array
        {
            get { return this is Type_Array; }
        }

        public bool is_Seq
        {
            get { return this is Type_Seq; }
        }

        public bool is_Set
        {
            get { return this is Type_Set; }
        }

        public bool is_Multiset
        {
            get { return this is Type_Multiset; }
        }

        public bool is_Map
        {
            get { return this is Type_Map; }
        }

        public bool is_SetBuilder
        {
            get { return this is Type_SetBuilder; }
        }

        public bool is_MapBuilder
        {
            get { return this is Type_MapBuilder; }
        }

        public bool is_Arrow
        {
            get { return this is Type_Arrow; }
        }

        public bool is_Primitive
        {
            get { return this is Type_Primitive; }
        }

        public bool is_Passthrough
        {
            get { return this is Type_Passthrough; }
        }

        public bool is_TypeArg
        {
            get { return this is Type_TypeArg; }
        }

        public Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_Path_a0
        {
            get
            {
                var d = this;
                return ((Type_Path)d)._a0;
            }
        }

        public Dafny.ISequence<DAST._IType> dtor_typeArgs
        {
            get
            {
                var d = this;
                return ((Type_Path)d)._typeArgs;
            }
        }

        public DAST._IResolvedType dtor_resolved
        {
            get
            {
                var d = this;
                return ((Type_Path)d)._resolved;
            }
        }

        public DAST._IType dtor_Nullable_a0
        {
            get
            {
                var d = this;
                return ((Type_Nullable)d)._a0;
            }
        }

        public Dafny.ISequence<DAST._IType> dtor_Tuple_a0
        {
            get
            {
                var d = this;
                return ((Type_Tuple)d)._a0;
            }
        }

        public DAST._IType dtor_element
        {
            get
            {
                var d = this;
                if (d is Type_Array) { return ((Type_Array)d)._element; }
                if (d is Type_Seq) { return ((Type_Seq)d)._element; }
                if (d is Type_Set) { return ((Type_Set)d)._element; }
                if (d is Type_Multiset) { return ((Type_Multiset)d)._element; }
                return ((Type_SetBuilder)d)._element;
            }
        }

        public BigInteger dtor_dims
        {
            get
            {
                var d = this;
                return ((Type_Array)d)._dims;
            }
        }

        public DAST._IType dtor_key
        {
            get
            {
                var d = this;
                if (d is Type_Map) { return ((Type_Map)d)._key; }
                return ((Type_MapBuilder)d)._key;
            }
        }

        public DAST._IType dtor_value
        {
            get
            {
                var d = this;
                if (d is Type_Map) { return ((Type_Map)d)._value; }
                return ((Type_MapBuilder)d)._value;
            }
        }

        public Dafny.ISequence<DAST._IType> dtor_args
        {
            get
            {
                var d = this;
                return ((Type_Arrow)d)._args;
            }
        }

        public DAST._IType dtor_result
        {
            get
            {
                var d = this;
                return ((Type_Arrow)d)._result;
            }
        }

        public DAST._IPrimitive dtor_Primitive_a0
        {
            get
            {
                var d = this;
                return ((Type_Primitive)d)._a0;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_Passthrough_a0
        {
            get
            {
                var d = this;
                return ((Type_Passthrough)d)._a0;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_TypeArg_a0
        {
            get
            {
                var d = this;
                return ((Type_TypeArg)d)._a0;
            }
        }

        public abstract _IType DowncastClone();
    }
    public class Type_Path : Type
    {
        public readonly Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _a0;
        public readonly Dafny.ISequence<DAST._IType> _typeArgs;
        public readonly DAST._IResolvedType _resolved;
        public Type_Path(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _a0, Dafny.ISequence<DAST._IType> typeArgs, DAST._IResolvedType resolved) : base()
        {
            this._a0 = _a0;
            this._typeArgs = typeArgs;
            this._resolved = resolved;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_Path(_a0, _typeArgs, _resolved);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Type_Path;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(385L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(379L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(373L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_13(372L, oth, null), () => object.Equals(this._a0, oth._a0)), () => object.Equals(this._typeArgs, oth._typeArgs)), () => object.Equals(this._resolved, oth._resolved));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(391L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(408L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(398L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(394L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(405L, 0));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(426L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(419L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(415L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(444L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(437L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(433L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typeArgs)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(462L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(455L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(451L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._resolved)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(469L, "DAST.Type.Path");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(470L, "(");
            s += Dafny.Helpers.ToString(this._a0);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(471L, ", ");
            s += Dafny.Helpers.ToString(this._typeArgs);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(472L, ", ");
            s += Dafny.Helpers.ToString(this._resolved);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(473L, ")");
            return s;
        }
    }
    public class Type_Nullable : Type
    {
        public readonly DAST._IType _a0;
        public Type_Nullable(DAST._IType _a0) : base()
        {
            this._a0 = _a0;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_Nullable(_a0);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Type_Nullable;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(475L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_14(474L, oth, null), () => object.Equals(this._a0, oth._a0));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(481L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(498L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(488L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(484L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(495L, 1));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(516L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(509L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(505L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(523L, "DAST.Type.Nullable");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(524L, "(");
            s += Dafny.Helpers.ToString(this._a0);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(525L, ")");
            return s;
        }
    }
    public class Type_Tuple : Type
    {
        public readonly Dafny.ISequence<DAST._IType> _a0;
        public Type_Tuple(Dafny.ISequence<DAST._IType> _a0) : base()
        {
            this._a0 = _a0;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_Tuple(_a0);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Type_Tuple;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(527L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_15(526L, oth, null), () => object.Equals(this._a0, oth._a0));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(533L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(550L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(540L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(536L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(547L, 2));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(568L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(561L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(557L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(575L, "DAST.Type.Tuple");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(576L, "(");
            s += Dafny.Helpers.ToString(this._a0);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(577L, ")");
            return s;
        }
    }
    public class Type_Array : Type
    {
        public readonly DAST._IType _element;
        public readonly BigInteger _dims;
        public Type_Array(DAST._IType element, BigInteger dims) : base()
        {
            this._element = element;
            this._dims = dims;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_Array(_element, _dims);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Type_Array;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(586L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(579L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_16(578L, oth, null), () => object.Equals(this._element, oth._element)), () => MutateCSharp.Schemata274.ReplaceBinExprOp_17(585L, this._dims, oth._dims));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(592L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(609L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(599L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(595L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(606L, 3));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(627L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(620L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(616L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._element)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(645L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(638L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(634L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._dims)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(652L, "DAST.Type.Array");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(653L, "(");
            s += Dafny.Helpers.ToString(this._element);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(654L, ", ");
            s += Dafny.Helpers.ToString(this._dims);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(655L, ")");
            return s;
        }
    }
    public class Type_Seq : Type
    {
        public readonly DAST._IType _element;
        public Type_Seq(DAST._IType element) : base()
        {
            this._element = element;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_Seq(_element);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Type_Seq;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(657L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_18(656L, oth, null), () => object.Equals(this._element, oth._element));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(663L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(680L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(670L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(666L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(677L, 4));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(698L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(691L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(687L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._element)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(705L, "DAST.Type.Seq");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(706L, "(");
            s += Dafny.Helpers.ToString(this._element);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(707L, ")");
            return s;
        }
    }
    public class Type_Set : Type
    {
        public readonly DAST._IType _element;
        public Type_Set(DAST._IType element) : base()
        {
            this._element = element;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_Set(_element);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Type_Set;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(709L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_19(708L, oth, null), () => object.Equals(this._element, oth._element));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(715L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(732L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(722L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(718L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(729L, 5));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(750L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(743L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(739L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._element)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(757L, "DAST.Type.Set");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(758L, "(");
            s += Dafny.Helpers.ToString(this._element);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(759L, ")");
            return s;
        }
    }
    public class Type_Multiset : Type
    {
        public readonly DAST._IType _element;
        public Type_Multiset(DAST._IType element) : base()
        {
            this._element = element;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_Multiset(_element);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Type_Multiset;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(761L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_20(760L, oth, null), () => object.Equals(this._element, oth._element));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(767L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(784L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(774L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(770L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(781L, 6));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(802L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(795L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(791L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._element)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(809L, "DAST.Type.Multiset");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(810L, "(");
            s += Dafny.Helpers.ToString(this._element);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(811L, ")");
            return s;
        }
    }
    public class Type_Map : Type
    {
        public readonly DAST._IType _key;
        public readonly DAST._IType _value;
        public Type_Map(DAST._IType key, DAST._IType @value) : base()
        {
            this._key = key;
            this._value = @value;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_Map(_key, _value);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Type_Map;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(819L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(813L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_21(812L, oth, null), () => object.Equals(this._key, oth._key)), () => object.Equals(this._value, oth._value));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(825L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(842L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(832L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(828L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(839L, 7));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(860L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(853L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(849L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._key)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(878L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(871L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(867L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._value)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(885L, "DAST.Type.Map");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(886L, "(");
            s += Dafny.Helpers.ToString(this._key);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(887L, ", ");
            s += Dafny.Helpers.ToString(this._value);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(888L, ")");
            return s;
        }
    }
    public class Type_SetBuilder : Type
    {
        public readonly DAST._IType _element;
        public Type_SetBuilder(DAST._IType element) : base()
        {
            this._element = element;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_SetBuilder(_element);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Type_SetBuilder;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(890L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_22(889L, oth, null), () => object.Equals(this._element, oth._element));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(896L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(913L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(903L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(899L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(910L, 8));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(931L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(924L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(920L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._element)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(938L, "DAST.Type.SetBuilder");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(939L, "(");
            s += Dafny.Helpers.ToString(this._element);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(940L, ")");
            return s;
        }
    }
    public class Type_MapBuilder : Type
    {
        public readonly DAST._IType _key;
        public readonly DAST._IType _value;
        public Type_MapBuilder(DAST._IType key, DAST._IType @value) : base()
        {
            this._key = key;
            this._value = @value;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_MapBuilder(_key, _value);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Type_MapBuilder;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(948L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(942L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_23(941L, oth, null), () => object.Equals(this._key, oth._key)), () => object.Equals(this._value, oth._value));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(954L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(971L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(961L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(957L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(968L, 9));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(989L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(982L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(978L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._key)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1007L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1000L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(996L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._value)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1014L, "DAST.Type.MapBuilder");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(1015L, "(");
            s += Dafny.Helpers.ToString(this._key);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(1016L, ", ");
            s += Dafny.Helpers.ToString(this._value);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(1017L, ")");
            return s;
        }
    }
    public class Type_Arrow : Type
    {
        public readonly Dafny.ISequence<DAST._IType> _args;
        public readonly DAST._IType _result;
        public Type_Arrow(Dafny.ISequence<DAST._IType> args, DAST._IType result) : base()
        {
            this._args = args;
            this._result = result;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_Arrow(_args, _result);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Type_Arrow;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(1025L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(1019L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_24(1018L, oth, null), () => object.Equals(this._args, oth._args)), () => object.Equals(this._result, oth._result));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1031L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1048L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1038L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1034L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1045L, 10));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1066L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1059L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1055L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._args)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1084L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1077L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1073L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._result)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1091L, "DAST.Type.Arrow");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(1092L, "(");
            s += Dafny.Helpers.ToString(this._args);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(1093L, ", ");
            s += Dafny.Helpers.ToString(this._result);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(1094L, ")");
            return s;
        }
    }
    public class Type_Primitive : Type
    {
        public readonly DAST._IPrimitive _a0;
        public Type_Primitive(DAST._IPrimitive _a0) : base()
        {
            this._a0 = _a0;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_Primitive(_a0);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Type_Primitive;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(1096L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_25(1095L, oth, null), () => object.Equals(this._a0, oth._a0));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1102L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1119L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1109L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1105L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1116L, 11));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1137L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1130L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1126L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1144L, "DAST.Type.Primitive");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(1145L, "(");
            s += Dafny.Helpers.ToString(this._a0);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(1146L, ")");
            return s;
        }
    }
    public class Type_Passthrough : Type
    {
        public readonly Dafny.ISequence<Dafny.Rune> _a0;
        public Type_Passthrough(Dafny.ISequence<Dafny.Rune> _a0) : base()
        {
            this._a0 = _a0;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_Passthrough(_a0);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Type_Passthrough;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(1148L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_26(1147L, oth, null), () => object.Equals(this._a0, oth._a0));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1154L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1171L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1161L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1157L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1168L, 12));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1189L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1182L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1178L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1196L, "DAST.Type.Passthrough");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(1197L, "(");
            s += this._a0.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(1198L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(1199L, ")");
            return s;
        }
    }
    public class Type_TypeArg : Type
    {
        public readonly Dafny.ISequence<Dafny.Rune> _a0;
        public Type_TypeArg(Dafny.ISequence<Dafny.Rune> _a0) : base()
        {
            this._a0 = _a0;
        }
        public override _IType DowncastClone()
        {
            if (this is _IType dt) { return dt; }
            return new Type_TypeArg(_a0);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Type_TypeArg;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(1201L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_27(1200L, oth, null), () => object.Equals(this._a0, oth._a0));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1207L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1224L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1214L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1210L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1221L, 13));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1242L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1235L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1231L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1249L, "DAST.Type.TypeArg");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(1250L, "(");
            s += Dafny.Helpers.ToString(this._a0);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(1251L, ")");
            return s;
        }
    }

    public interface _IPrimitive
    {
        bool is_Int { get; }
        bool is_Real { get; }
        bool is_String { get; }
        bool is_Bool { get; }
        bool is_Char { get; }

        _IPrimitive DowncastClone();
    }
    public abstract class Primitive : _IPrimitive
    {
        public Primitive()
        {
        }
        private static readonly DAST._IPrimitive theDefault = create_Int();
        public static DAST._IPrimitive Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST._IPrimitive> _TYPE = new Dafny.TypeDescriptor<DAST._IPrimitive>(DAST.Primitive.Default());
        public static Dafny.TypeDescriptor<DAST._IPrimitive> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IPrimitive create_Int()
        {
            return new Primitive_Int();
        }
        public static _IPrimitive create_Real()
        {
            return new Primitive_Real();
        }
        public static _IPrimitive create_String()
        {
            return new Primitive_String();
        }
        public static _IPrimitive create_Bool()
        {
            return new Primitive_Bool();
        }
        public static _IPrimitive create_Char()
        {
            return new Primitive_Char();
        }
        public bool is_Int
        {
            get { return this is Primitive_Int; }
        }

        public bool is_Real
        {
            get { return this is Primitive_Real; }
        }

        public bool is_String
        {
            get { return this is Primitive_String; }
        }

        public bool is_Bool
        {
            get { return this is Primitive_Bool; }
        }

        public bool is_Char
        {
            get { return this is Primitive_Char; }
        }

        public static System.Collections.Generic.IEnumerable<_IPrimitive> AllSingletonConstructors
        {
            get
            {
                yield return Primitive.create_Int();
                yield return Primitive.create_Real();
                yield return Primitive.create_String();
                yield return Primitive.create_Bool();
                yield return Primitive.create_Char();
            }
        }

        public abstract _IPrimitive DowncastClone();
    }
    public class Primitive_Int : Primitive
    {
        public Primitive_Int() : base()
        {
        }
        public override _IPrimitive DowncastClone()
        {
            if (this is _IPrimitive dt) { return dt; }
            return new Primitive_Int();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Primitive_Int;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_28(1252L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1253L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1270L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1260L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1256L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1267L, 0));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1277L, "DAST.Primitive.Int");
            return s;
        }
    }
    public class Primitive_Real : Primitive
    {
        public Primitive_Real() : base()
        {
        }
        public override _IPrimitive DowncastClone()
        {
            if (this is _IPrimitive dt) { return dt; }
            return new Primitive_Real();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Primitive_Real;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_29(1278L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1279L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1296L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1286L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1282L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1293L, 1));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1303L, "DAST.Primitive.Real");
            return s;
        }
    }
    public class Primitive_String : Primitive
    {
        public Primitive_String() : base()
        {
        }
        public override _IPrimitive DowncastClone()
        {
            if (this is _IPrimitive dt) { return dt; }
            return new Primitive_String();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Primitive_String;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_30(1304L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1305L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1322L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1312L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1308L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1319L, 2));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1329L, "DAST.Primitive.String");
            return s;
        }
    }
    public class Primitive_Bool : Primitive
    {
        public Primitive_Bool() : base()
        {
        }
        public override _IPrimitive DowncastClone()
        {
            if (this is _IPrimitive dt) { return dt; }
            return new Primitive_Bool();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Primitive_Bool;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_31(1330L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1331L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1348L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1338L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1334L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1345L, 3));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1355L, "DAST.Primitive.Bool");
            return s;
        }
    }
    public class Primitive_Char : Primitive
    {
        public Primitive_Char() : base()
        {
        }
        public override _IPrimitive DowncastClone()
        {
            if (this is _IPrimitive dt) { return dt; }
            return new Primitive_Char();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Primitive_Char;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_32(1356L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1357L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1374L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1364L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1360L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1371L, 4));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1381L, "DAST.Primitive.Char");
            return s;
        }
    }

    public interface _INewtypeRange
    {
        bool is_U8 { get; }
        bool is_I8 { get; }
        bool is_U16 { get; }
        bool is_I16 { get; }
        bool is_U32 { get; }
        bool is_I32 { get; }
        bool is_U64 { get; }
        bool is_I64 { get; }
        bool is_U128 { get; }
        bool is_I128 { get; }
        bool is_BigInt { get; }
        bool is_NoRange { get; }

        _INewtypeRange DowncastClone();
    }
    public abstract class NewtypeRange : _INewtypeRange
    {
        public NewtypeRange()
        {
        }
        private static readonly DAST._INewtypeRange theDefault = create_U8();
        public static DAST._INewtypeRange Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST._INewtypeRange> _TYPE = new Dafny.TypeDescriptor<DAST._INewtypeRange>(DAST.NewtypeRange.Default());
        public static Dafny.TypeDescriptor<DAST._INewtypeRange> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _INewtypeRange create_U8()
        {
            return new NewtypeRange_U8();
        }
        public static _INewtypeRange create_I8()
        {
            return new NewtypeRange_I8();
        }
        public static _INewtypeRange create_U16()
        {
            return new NewtypeRange_U16();
        }
        public static _INewtypeRange create_I16()
        {
            return new NewtypeRange_I16();
        }
        public static _INewtypeRange create_U32()
        {
            return new NewtypeRange_U32();
        }
        public static _INewtypeRange create_I32()
        {
            return new NewtypeRange_I32();
        }
        public static _INewtypeRange create_U64()
        {
            return new NewtypeRange_U64();
        }
        public static _INewtypeRange create_I64()
        {
            return new NewtypeRange_I64();
        }
        public static _INewtypeRange create_U128()
        {
            return new NewtypeRange_U128();
        }
        public static _INewtypeRange create_I128()
        {
            return new NewtypeRange_I128();
        }
        public static _INewtypeRange create_BigInt()
        {
            return new NewtypeRange_BigInt();
        }
        public static _INewtypeRange create_NoRange()
        {
            return new NewtypeRange_NoRange();
        }
        public bool is_U8
        {
            get { return this is NewtypeRange_U8; }
        }

        public bool is_I8
        {
            get { return this is NewtypeRange_I8; }
        }

        public bool is_U16
        {
            get { return this is NewtypeRange_U16; }
        }

        public bool is_I16
        {
            get { return this is NewtypeRange_I16; }
        }

        public bool is_U32
        {
            get { return this is NewtypeRange_U32; }
        }

        public bool is_I32
        {
            get { return this is NewtypeRange_I32; }
        }

        public bool is_U64
        {
            get { return this is NewtypeRange_U64; }
        }

        public bool is_I64
        {
            get { return this is NewtypeRange_I64; }
        }

        public bool is_U128
        {
            get { return this is NewtypeRange_U128; }
        }

        public bool is_I128
        {
            get { return this is NewtypeRange_I128; }
        }

        public bool is_BigInt
        {
            get { return this is NewtypeRange_BigInt; }
        }

        public bool is_NoRange
        {
            get { return this is NewtypeRange_NoRange; }
        }

        public static System.Collections.Generic.IEnumerable<_INewtypeRange> AllSingletonConstructors
        {
            get
            {
                yield return NewtypeRange.create_U8();
                yield return NewtypeRange.create_I8();
                yield return NewtypeRange.create_U16();
                yield return NewtypeRange.create_I16();
                yield return NewtypeRange.create_U32();
                yield return NewtypeRange.create_I32();
                yield return NewtypeRange.create_U64();
                yield return NewtypeRange.create_I64();
                yield return NewtypeRange.create_U128();
                yield return NewtypeRange.create_I128();
                yield return NewtypeRange.create_BigInt();
                yield return NewtypeRange.create_NoRange();
            }
        }

        public abstract _INewtypeRange DowncastClone();
    }
    public class NewtypeRange_U8 : NewtypeRange
    {
        public NewtypeRange_U8() : base()
        {
        }
        public override _INewtypeRange DowncastClone()
        {
            if (this is _INewtypeRange dt) { return dt; }
            return new NewtypeRange_U8();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.NewtypeRange_U8;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_33(1382L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1383L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1400L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1390L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1386L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1397L, 0));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1407L, "DAST.NewtypeRange.U8");
            return s;
        }
    }
    public class NewtypeRange_I8 : NewtypeRange
    {
        public NewtypeRange_I8() : base()
        {
        }
        public override _INewtypeRange DowncastClone()
        {
            if (this is _INewtypeRange dt) { return dt; }
            return new NewtypeRange_I8();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.NewtypeRange_I8;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_34(1408L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1409L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1426L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1416L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1412L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1423L, 1));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1433L, "DAST.NewtypeRange.I8");
            return s;
        }
    }
    public class NewtypeRange_U16 : NewtypeRange
    {
        public NewtypeRange_U16() : base()
        {
        }
        public override _INewtypeRange DowncastClone()
        {
            if (this is _INewtypeRange dt) { return dt; }
            return new NewtypeRange_U16();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.NewtypeRange_U16;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_35(1434L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1435L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1452L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1442L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1438L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1449L, 2));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1459L, "DAST.NewtypeRange.U16");
            return s;
        }
    }
    public class NewtypeRange_I16 : NewtypeRange
    {
        public NewtypeRange_I16() : base()
        {
        }
        public override _INewtypeRange DowncastClone()
        {
            if (this is _INewtypeRange dt) { return dt; }
            return new NewtypeRange_I16();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.NewtypeRange_I16;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_36(1460L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1461L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1478L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1468L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1464L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1475L, 3));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1485L, "DAST.NewtypeRange.I16");
            return s;
        }
    }
    public class NewtypeRange_U32 : NewtypeRange
    {
        public NewtypeRange_U32() : base()
        {
        }
        public override _INewtypeRange DowncastClone()
        {
            if (this is _INewtypeRange dt) { return dt; }
            return new NewtypeRange_U32();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.NewtypeRange_U32;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_37(1486L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1487L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1504L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1494L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1490L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1501L, 4));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1511L, "DAST.NewtypeRange.U32");
            return s;
        }
    }
    public class NewtypeRange_I32 : NewtypeRange
    {
        public NewtypeRange_I32() : base()
        {
        }
        public override _INewtypeRange DowncastClone()
        {
            if (this is _INewtypeRange dt) { return dt; }
            return new NewtypeRange_I32();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.NewtypeRange_I32;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_38(1512L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1513L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1530L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1520L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1516L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1527L, 5));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1537L, "DAST.NewtypeRange.I32");
            return s;
        }
    }
    public class NewtypeRange_U64 : NewtypeRange
    {
        public NewtypeRange_U64() : base()
        {
        }
        public override _INewtypeRange DowncastClone()
        {
            if (this is _INewtypeRange dt) { return dt; }
            return new NewtypeRange_U64();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.NewtypeRange_U64;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_39(1538L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1539L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1556L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1546L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1542L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1553L, 6));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1563L, "DAST.NewtypeRange.U64");
            return s;
        }
    }
    public class NewtypeRange_I64 : NewtypeRange
    {
        public NewtypeRange_I64() : base()
        {
        }
        public override _INewtypeRange DowncastClone()
        {
            if (this is _INewtypeRange dt) { return dt; }
            return new NewtypeRange_I64();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.NewtypeRange_I64;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_40(1564L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1565L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1582L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1572L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1568L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1579L, 7));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1589L, "DAST.NewtypeRange.I64");
            return s;
        }
    }
    public class NewtypeRange_U128 : NewtypeRange
    {
        public NewtypeRange_U128() : base()
        {
        }
        public override _INewtypeRange DowncastClone()
        {
            if (this is _INewtypeRange dt) { return dt; }
            return new NewtypeRange_U128();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.NewtypeRange_U128;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_41(1590L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1591L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1608L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1598L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1594L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1605L, 8));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1615L, "DAST.NewtypeRange.U128");
            return s;
        }
    }
    public class NewtypeRange_I128 : NewtypeRange
    {
        public NewtypeRange_I128() : base()
        {
        }
        public override _INewtypeRange DowncastClone()
        {
            if (this is _INewtypeRange dt) { return dt; }
            return new NewtypeRange_I128();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.NewtypeRange_I128;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_42(1616L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1617L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1634L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1624L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1620L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1631L, 9));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1641L, "DAST.NewtypeRange.I128");
            return s;
        }
    }
    public class NewtypeRange_BigInt : NewtypeRange
    {
        public NewtypeRange_BigInt() : base()
        {
        }
        public override _INewtypeRange DowncastClone()
        {
            if (this is _INewtypeRange dt) { return dt; }
            return new NewtypeRange_BigInt();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.NewtypeRange_BigInt;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_43(1642L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1643L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1660L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1650L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1646L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1657L, 10));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1667L, "DAST.NewtypeRange.BigInt");
            return s;
        }
    }
    public class NewtypeRange_NoRange : NewtypeRange
    {
        public NewtypeRange_NoRange() : base()
        {
        }
        public override _INewtypeRange DowncastClone()
        {
            if (this is _INewtypeRange dt) { return dt; }
            return new NewtypeRange_NoRange();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.NewtypeRange_NoRange;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_44(1668L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1669L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1686L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1676L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1672L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1683L, 11));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1693L, "DAST.NewtypeRange.NoRange");
            return s;
        }
    }

    public interface _IResolvedType
    {
        bool is_Datatype { get; }
        bool is_Trait { get; }
        bool is_Newtype { get; }
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_path { get; }
        DAST._IType dtor_baseType { get; }
        DAST._INewtypeRange dtor_range { get; }
        bool dtor_erase { get; }

        _IResolvedType DowncastClone();
    }
    public abstract class ResolvedType : _IResolvedType
    {
        public ResolvedType()
        {
        }
        private static readonly DAST._IResolvedType theDefault = create_Datatype(Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Empty);
        public static DAST._IResolvedType Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST._IResolvedType> _TYPE = new Dafny.TypeDescriptor<DAST._IResolvedType>(DAST.ResolvedType.Default());
        public static Dafny.TypeDescriptor<DAST._IResolvedType> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IResolvedType create_Datatype(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> path)
        {
            return new ResolvedType_Datatype(path);
        }
        public static _IResolvedType create_Trait(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> path)
        {
            return new ResolvedType_Trait(path);
        }
        public static _IResolvedType create_Newtype(DAST._IType baseType, DAST._INewtypeRange range, bool erase)
        {
            return new ResolvedType_Newtype(baseType, range, erase);
        }
        public bool is_Datatype
        {
            get { return this is ResolvedType_Datatype; }
        }

        public bool is_Trait
        {
            get { return this is ResolvedType_Trait; }
        }

        public bool is_Newtype
        {
            get { return this is ResolvedType_Newtype; }
        }

        public Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_path
        {
            get
            {
                var d = this;
                if (d is ResolvedType_Datatype) { return ((ResolvedType_Datatype)d)._path; }
                return ((ResolvedType_Trait)d)._path;
            }
        }

        public DAST._IType dtor_baseType
        {
            get
            {
                var d = this;
                return ((ResolvedType_Newtype)d)._baseType;
            }
        }

        public DAST._INewtypeRange dtor_range
        {
            get
            {
                var d = this;
                return ((ResolvedType_Newtype)d)._range;
            }
        }

        public bool dtor_erase
        {
            get
            {
                var d = this;
                return ((ResolvedType_Newtype)d)._erase;
            }
        }

        public abstract _IResolvedType DowncastClone();
    }
    public class ResolvedType_Datatype : ResolvedType
    {
        public readonly Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _path;
        public ResolvedType_Datatype(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> path) : base()
        {
            this._path = path;
        }
        public override _IResolvedType DowncastClone()
        {
            if (this is _IResolvedType dt) { return dt; }
            return new ResolvedType_Datatype(_path);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.ResolvedType_Datatype;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(1695L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_45(1694L, oth, null), () => object.Equals(this._path, oth._path));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1701L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1718L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1708L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1704L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1715L, 0));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1736L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1729L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1725L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._path)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1743L, "DAST.ResolvedType.Datatype");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(1744L, "(");
            s += Dafny.Helpers.ToString(this._path);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(1745L, ")");
            return s;
        }
    }
    public class ResolvedType_Trait : ResolvedType
    {
        public readonly Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _path;
        public ResolvedType_Trait(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> path) : base()
        {
            this._path = path;
        }
        public override _IResolvedType DowncastClone()
        {
            if (this is _IResolvedType dt) { return dt; }
            return new ResolvedType_Trait(_path);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.ResolvedType_Trait;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(1747L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_46(1746L, oth, null), () => object.Equals(this._path, oth._path));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1753L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1770L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1760L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1756L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1767L, 1));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1788L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1781L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1777L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._path)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1795L, "DAST.ResolvedType.Trait");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(1796L, "(");
            s += Dafny.Helpers.ToString(this._path);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(1797L, ")");
            return s;
        }
    }
    public class ResolvedType_Newtype : ResolvedType
    {
        public readonly DAST._IType _baseType;
        public readonly DAST._INewtypeRange _range;
        public readonly bool _erase;
        public ResolvedType_Newtype(DAST._IType baseType, DAST._INewtypeRange range, bool erase) : base()
        {
            this._baseType = baseType;
            this._range = range;
            this._erase = erase;
        }
        public override _IResolvedType DowncastClone()
        {
            if (this is _IResolvedType dt) { return dt; }
            return new ResolvedType_Newtype(_baseType, _range, _erase);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.ResolvedType_Newtype;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(1817L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(1805L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(1799L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_47(1798L, oth, null), () => object.Equals(this._baseType, oth._baseType)), () => object.Equals(this._range, oth._range)), () => MutateCSharp.Schemata274.ReplaceBinExprOp_2(1811L, () => this._erase, () => oth._erase));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1823L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1840L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1830L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1826L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1837L, 2));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1858L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1851L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1847L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._baseType)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1876L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1869L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1865L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._range)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1894L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1887L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1883L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._erase)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1901L, "DAST.ResolvedType.Newtype");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(1902L, "(");
            s += Dafny.Helpers.ToString(this._baseType);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(1903L, ", ");
            s += Dafny.Helpers.ToString(this._range);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(1904L, ", ");
            s += Dafny.Helpers.ToString(this._erase);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(1905L, ")");
            return s;
        }
    }

    public interface _IIdent
    {
        bool is_Ident { get; }
        Dafny.ISequence<Dafny.Rune> dtor_id { get; }
    }
    public class Ident : _IIdent
    {
        public readonly Dafny.ISequence<Dafny.Rune> _id;
        public Ident(Dafny.ISequence<Dafny.Rune> id)
        {
            this._id = id;
        }
        public static Dafny.ISequence<Dafny.Rune> DowncastClone(Dafny.ISequence<Dafny.Rune> _this)
        {
            return _this;
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Ident;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(1907L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_48(1906L, oth, null), () => object.Equals(this._id, oth._id));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1913L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1930L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1920L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1916L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(1927L, 0));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(1948L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(1941L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(1937L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._id)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(1955L, "DAST.Ident.Ident");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(1956L, "(");
            s += this._id.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(1957L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(1958L, ")");
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
        public static _IIdent create(Dafny.ISequence<Dafny.Rune> id)
        {
            return new Ident(id);
        }
        public static _IIdent create_Ident(Dafny.ISequence<Dafny.Rune> id)
        {
            return create(id);
        }
        public bool is_Ident
        {
            get { return MutateCSharp.Schemata274.ReplaceBooleanConstant_7(1959L, true); }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_id
        {
            get
            {
                return this._id;
            }
        }
    }

    public interface _IClass
    {
        bool is_Class { get; }
        Dafny.ISequence<Dafny.Rune> dtor_name { get; }
        Dafny.ISequence<Dafny.Rune> dtor_enclosingModule { get; }
        Dafny.ISequence<DAST._IType> dtor_typeParams { get; }
        Dafny.ISequence<DAST._IType> dtor_superClasses { get; }
        Dafny.ISequence<DAST._IField> dtor_fields { get; }
        Dafny.ISequence<DAST._IMethod> dtor_body { get; }

        _IClass DowncastClone();
    }
    public class Class : _IClass
    {
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public readonly Dafny.ISequence<Dafny.Rune> _enclosingModule;
        public readonly Dafny.ISequence<DAST._IType> _typeParams;
        public readonly Dafny.ISequence<DAST._IType> _superClasses;
        public readonly Dafny.ISequence<DAST._IField> _fields;
        public readonly Dafny.ISequence<DAST._IMethod> _body;
        public Class(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<Dafny.Rune> enclosingModule, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IType> superClasses, Dafny.ISequence<DAST._IField> fields, Dafny.ISequence<DAST._IMethod> body)
        {
            this._name = name;
            this._enclosingModule = enclosingModule;
            this._typeParams = typeParams;
            this._superClasses = superClasses;
            this._fields = fields;
            this._body = body;
        }
        public _IClass DowncastClone()
        {
            if (this is _IClass dt) { return dt; }
            return new Class(_name, _enclosingModule, _typeParams, _superClasses, _fields, _body);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Class;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(1991L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(1985L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(1979L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(1973L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(1967L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(1961L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_49(1960L, oth, null), () => object.Equals(this._name, oth._name)), () => object.Equals(this._enclosingModule, oth._enclosingModule)), () => object.Equals(this._typeParams, oth._typeParams)), () => object.Equals(this._superClasses, oth._superClasses)), () => object.Equals(this._fields, oth._fields)), () => object.Equals(this._body, oth._body));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(1997L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2014L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2004L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2000L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(2011L, 0));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2032L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2025L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2021L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2050L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2043L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2039L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._enclosingModule)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2068L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2061L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2057L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typeParams)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2086L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2079L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2075L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._superClasses)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2104L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2097L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2093L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._fields)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2122L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2115L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2111L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._body)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(2129L, "DAST.Class.Class");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2130L, "(");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(2131L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2132L, ", ");
            s += Dafny.Helpers.ToString(this._enclosingModule);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2133L, ", ");
            s += Dafny.Helpers.ToString(this._typeParams);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2134L, ", ");
            s += Dafny.Helpers.ToString(this._superClasses);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2135L, ", ");
            s += Dafny.Helpers.ToString(this._fields);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2136L, ", ");
            s += Dafny.Helpers.ToString(this._body);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2137L, ")");
            return s;
        }
        private static readonly DAST._IClass theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<DAST._IType>.Empty, Dafny.Sequence<DAST._IType>.Empty, Dafny.Sequence<DAST._IField>.Empty, Dafny.Sequence<DAST._IMethod>.Empty);
        public static DAST._IClass Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST._IClass> _TYPE = new Dafny.TypeDescriptor<DAST._IClass>(DAST.Class.Default());
        public static Dafny.TypeDescriptor<DAST._IClass> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IClass create(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<Dafny.Rune> enclosingModule, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IType> superClasses, Dafny.ISequence<DAST._IField> fields, Dafny.ISequence<DAST._IMethod> body)
        {
            return new Class(name, enclosingModule, typeParams, superClasses, fields, body);
        }
        public static _IClass create_Class(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<Dafny.Rune> enclosingModule, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IType> superClasses, Dafny.ISequence<DAST._IField> fields, Dafny.ISequence<DAST._IMethod> body)
        {
            return create(name, enclosingModule, typeParams, superClasses, fields, body);
        }
        public bool is_Class
        {
            get { return MutateCSharp.Schemata274.ReplaceBooleanConstant_7(2138L, true); }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_name
        {
            get
            {
                return this._name;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_enclosingModule
        {
            get
            {
                return this._enclosingModule;
            }
        }

        public Dafny.ISequence<DAST._IType> dtor_typeParams
        {
            get
            {
                return this._typeParams;
            }
        }

        public Dafny.ISequence<DAST._IType> dtor_superClasses
        {
            get
            {
                return this._superClasses;
            }
        }

        public Dafny.ISequence<DAST._IField> dtor_fields
        {
            get
            {
                return this._fields;
            }
        }

        public Dafny.ISequence<DAST._IMethod> dtor_body
        {
            get
            {
                return this._body;
            }
        }
    }

    public interface _ITrait
    {
        bool is_Trait { get; }
        Dafny.ISequence<Dafny.Rune> dtor_name { get; }
        Dafny.ISequence<DAST._IType> dtor_typeParams { get; }
        Dafny.ISequence<DAST._IMethod> dtor_body { get; }

        _ITrait DowncastClone();
    }
    public class Trait : _ITrait
    {
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public readonly Dafny.ISequence<DAST._IType> _typeParams;
        public readonly Dafny.ISequence<DAST._IMethod> _body;
        public Trait(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IMethod> body)
        {
            this._name = name;
            this._typeParams = typeParams;
            this._body = body;
        }
        public _ITrait DowncastClone()
        {
            if (this is _ITrait dt) { return dt; }
            return new Trait(_name, _typeParams, _body);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Trait;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(2152L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2146L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2140L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_50(2139L, oth, null), () => object.Equals(this._name, oth._name)), () => object.Equals(this._typeParams, oth._typeParams)), () => object.Equals(this._body, oth._body));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(2158L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2175L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2165L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2161L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(2172L, 0));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2193L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2186L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2182L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2211L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2204L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2200L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typeParams)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2229L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2222L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2218L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._body)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(2236L, "DAST.Trait.Trait");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2237L, "(");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(2238L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2239L, ", ");
            s += Dafny.Helpers.ToString(this._typeParams);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2240L, ", ");
            s += Dafny.Helpers.ToString(this._body);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2241L, ")");
            return s;
        }
        private static readonly DAST._ITrait theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<DAST._IType>.Empty, Dafny.Sequence<DAST._IMethod>.Empty);
        public static DAST._ITrait Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST._ITrait> _TYPE = new Dafny.TypeDescriptor<DAST._ITrait>(DAST.Trait.Default());
        public static Dafny.TypeDescriptor<DAST._ITrait> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _ITrait create(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IMethod> body)
        {
            return new Trait(name, typeParams, body);
        }
        public static _ITrait create_Trait(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IMethod> body)
        {
            return create(name, typeParams, body);
        }
        public bool is_Trait
        {
            get { return MutateCSharp.Schemata274.ReplaceBooleanConstant_7(2242L, true); }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_name
        {
            get
            {
                return this._name;
            }
        }

        public Dafny.ISequence<DAST._IType> dtor_typeParams
        {
            get
            {
                return this._typeParams;
            }
        }

        public Dafny.ISequence<DAST._IMethod> dtor_body
        {
            get
            {
                return this._body;
            }
        }
    }

    public interface _IDatatype
    {
        bool is_Datatype { get; }
        Dafny.ISequence<Dafny.Rune> dtor_name { get; }
        Dafny.ISequence<Dafny.Rune> dtor_enclosingModule { get; }
        Dafny.ISequence<DAST._IType> dtor_typeParams { get; }
        Dafny.ISequence<DAST._IDatatypeCtor> dtor_ctors { get; }
        Dafny.ISequence<DAST._IMethod> dtor_body { get; }
        bool dtor_isCo { get; }

        _IDatatype DowncastClone();
    }
    public class Datatype : _IDatatype
    {
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public readonly Dafny.ISequence<Dafny.Rune> _enclosingModule;
        public readonly Dafny.ISequence<DAST._IType> _typeParams;
        public readonly Dafny.ISequence<DAST._IDatatypeCtor> _ctors;
        public readonly Dafny.ISequence<DAST._IMethod> _body;
        public readonly bool _isCo;
        public Datatype(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<Dafny.Rune> enclosingModule, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IDatatypeCtor> ctors, Dafny.ISequence<DAST._IMethod> body, bool isCo)
        {
            this._name = name;
            this._enclosingModule = enclosingModule;
            this._typeParams = typeParams;
            this._ctors = ctors;
            this._body = body;
            this._isCo = isCo;
        }
        public _IDatatype DowncastClone()
        {
            if (this is _IDatatype dt) { return dt; }
            return new Datatype(_name, _enclosingModule, _typeParams, _ctors, _body, _isCo);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Datatype;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(2280L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2268L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2262L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2256L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2250L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2244L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_51(2243L, oth, null), () => object.Equals(this._name, oth._name)), () => object.Equals(this._enclosingModule, oth._enclosingModule)), () => object.Equals(this._typeParams, oth._typeParams)), () => object.Equals(this._ctors, oth._ctors)), () => object.Equals(this._body, oth._body)), () => MutateCSharp.Schemata274.ReplaceBinExprOp_2(2274L, () => this._isCo, () => oth._isCo));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(2286L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2303L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2293L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2289L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(2300L, 0));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2321L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2314L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2310L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2339L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2332L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2328L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._enclosingModule)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2357L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2350L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2346L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typeParams)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2375L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2368L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2364L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._ctors)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2393L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2386L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2382L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._body)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2411L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2404L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2400L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._isCo)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(2418L, "DAST.Datatype.Datatype");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2419L, "(");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(2420L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2421L, ", ");
            s += Dafny.Helpers.ToString(this._enclosingModule);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2422L, ", ");
            s += Dafny.Helpers.ToString(this._typeParams);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2423L, ", ");
            s += Dafny.Helpers.ToString(this._ctors);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2424L, ", ");
            s += Dafny.Helpers.ToString(this._body);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2425L, ", ");
            s += Dafny.Helpers.ToString(this._isCo);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2426L, ")");
            return s;
        }
        private static readonly DAST._IDatatype theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<DAST._IType>.Empty, Dafny.Sequence<DAST._IDatatypeCtor>.Empty, Dafny.Sequence<DAST._IMethod>.Empty, MutateCSharp.Schemata274.ReplaceBooleanConstant_7(2427L, false));
        public static DAST._IDatatype Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST._IDatatype> _TYPE = new Dafny.TypeDescriptor<DAST._IDatatype>(DAST.Datatype.Default());
        public static Dafny.TypeDescriptor<DAST._IDatatype> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IDatatype create(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<Dafny.Rune> enclosingModule, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IDatatypeCtor> ctors, Dafny.ISequence<DAST._IMethod> body, bool isCo)
        {
            return new Datatype(name, enclosingModule, typeParams, ctors, body, isCo);
        }
        public static _IDatatype create_Datatype(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<Dafny.Rune> enclosingModule, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IDatatypeCtor> ctors, Dafny.ISequence<DAST._IMethod> body, bool isCo)
        {
            return create(name, enclosingModule, typeParams, ctors, body, isCo);
        }
        public bool is_Datatype
        {
            get { return MutateCSharp.Schemata274.ReplaceBooleanConstant_7(2428L, true); }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_name
        {
            get
            {
                return this._name;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_enclosingModule
        {
            get
            {
                return this._enclosingModule;
            }
        }

        public Dafny.ISequence<DAST._IType> dtor_typeParams
        {
            get
            {
                return this._typeParams;
            }
        }

        public Dafny.ISequence<DAST._IDatatypeCtor> dtor_ctors
        {
            get
            {
                return this._ctors;
            }
        }

        public Dafny.ISequence<DAST._IMethod> dtor_body
        {
            get
            {
                return this._body;
            }
        }

        public bool dtor_isCo
        {
            get
            {
                return this._isCo;
            }
        }
    }

    public interface _IDatatypeCtor
    {
        bool is_DatatypeCtor { get; }
        Dafny.ISequence<Dafny.Rune> dtor_name { get; }
        Dafny.ISequence<DAST._IFormal> dtor_args { get; }
        bool dtor_hasAnyArgs { get; }

        _IDatatypeCtor DowncastClone();
    }
    public class DatatypeCtor : _IDatatypeCtor
    {
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public readonly Dafny.ISequence<DAST._IFormal> _args;
        public readonly bool _hasAnyArgs;
        public DatatypeCtor(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IFormal> args, bool hasAnyArgs)
        {
            this._name = name;
            this._args = args;
            this._hasAnyArgs = hasAnyArgs;
        }
        public _IDatatypeCtor DowncastClone()
        {
            if (this is _IDatatypeCtor dt) { return dt; }
            return new DatatypeCtor(_name, _args, _hasAnyArgs);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.DatatypeCtor;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(2448L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2436L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2430L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_52(2429L, oth, null), () => object.Equals(this._name, oth._name)), () => object.Equals(this._args, oth._args)), () => MutateCSharp.Schemata274.ReplaceBinExprOp_2(2442L, () => this._hasAnyArgs, () => oth._hasAnyArgs));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(2454L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2471L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2461L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2457L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(2468L, 0));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2489L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2482L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2478L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2507L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2500L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2496L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._args)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2525L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2518L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2514L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._hasAnyArgs)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(2532L, "DAST.DatatypeCtor.DatatypeCtor");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2533L, "(");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(2534L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2535L, ", ");
            s += Dafny.Helpers.ToString(this._args);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2536L, ", ");
            s += Dafny.Helpers.ToString(this._hasAnyArgs);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2537L, ")");
            return s;
        }
        private static readonly DAST._IDatatypeCtor theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<DAST._IFormal>.Empty, MutateCSharp.Schemata274.ReplaceBooleanConstant_7(2538L, false));
        public static DAST._IDatatypeCtor Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST._IDatatypeCtor> _TYPE = new Dafny.TypeDescriptor<DAST._IDatatypeCtor>(DAST.DatatypeCtor.Default());
        public static Dafny.TypeDescriptor<DAST._IDatatypeCtor> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IDatatypeCtor create(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IFormal> args, bool hasAnyArgs)
        {
            return new DatatypeCtor(name, args, hasAnyArgs);
        }
        public static _IDatatypeCtor create_DatatypeCtor(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IFormal> args, bool hasAnyArgs)
        {
            return create(name, args, hasAnyArgs);
        }
        public bool is_DatatypeCtor
        {
            get { return MutateCSharp.Schemata274.ReplaceBooleanConstant_7(2539L, true); }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_name
        {
            get
            {
                return this._name;
            }
        }

        public Dafny.ISequence<DAST._IFormal> dtor_args
        {
            get
            {
                return this._args;
            }
        }

        public bool dtor_hasAnyArgs
        {
            get
            {
                return this._hasAnyArgs;
            }
        }
    }

    public interface _INewtype
    {
        bool is_Newtype { get; }
        Dafny.ISequence<Dafny.Rune> dtor_name { get; }
        Dafny.ISequence<DAST._IType> dtor_typeParams { get; }
        DAST._IType dtor_base { get; }
        DAST._INewtypeRange dtor_range { get; }
        Dafny.ISequence<DAST._IStatement> dtor_witnessStmts { get; }
        Std.Wrappers._IOption<DAST._IExpression> dtor_witnessExpr { get; }

        _INewtype DowncastClone();
    }
    public class Newtype : _INewtype
    {
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public readonly Dafny.ISequence<DAST._IType> _typeParams;
        public readonly DAST._IType _base;
        public readonly DAST._INewtypeRange _range;
        public readonly Dafny.ISequence<DAST._IStatement> _witnessStmts;
        public readonly Std.Wrappers._IOption<DAST._IExpression> _witnessExpr;
        public Newtype(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, DAST._IType @base, DAST._INewtypeRange range, Dafny.ISequence<DAST._IStatement> witnessStmts, Std.Wrappers._IOption<DAST._IExpression> witnessExpr)
        {
            this._name = name;
            this._typeParams = typeParams;
            this._base = @base;
            this._range = range;
            this._witnessStmts = witnessStmts;
            this._witnessExpr = witnessExpr;
        }
        public _INewtype DowncastClone()
        {
            if (this is _INewtype dt) { return dt; }
            return new Newtype(_name, _typeParams, _base, _range, _witnessStmts, _witnessExpr);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Newtype;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(2571L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2565L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2559L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2553L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2547L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2541L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_53(2540L, oth, null), () => object.Equals(this._name, oth._name)), () => object.Equals(this._typeParams, oth._typeParams)), () => object.Equals(this._base, oth._base)), () => object.Equals(this._range, oth._range)), () => object.Equals(this._witnessStmts, oth._witnessStmts)), () => object.Equals(this._witnessExpr, oth._witnessExpr));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(2577L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2594L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2584L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2580L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(2591L, 0));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2612L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2605L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2601L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2630L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2623L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2619L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typeParams)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2648L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2641L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2637L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._base)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2666L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2659L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2655L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._range)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2684L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2677L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2673L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._witnessStmts)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2702L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2695L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2691L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._witnessExpr)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(2709L, "DAST.Newtype.Newtype");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2710L, "(");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(2711L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2712L, ", ");
            s += Dafny.Helpers.ToString(this._typeParams);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2713L, ", ");
            s += Dafny.Helpers.ToString(this._base);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2714L, ", ");
            s += Dafny.Helpers.ToString(this._range);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2715L, ", ");
            s += Dafny.Helpers.ToString(this._witnessStmts);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2716L, ", ");
            s += Dafny.Helpers.ToString(this._witnessExpr);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2717L, ")");
            return s;
        }
        private static readonly DAST._INewtype theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<DAST._IType>.Empty, DAST.Type.Default(), DAST.NewtypeRange.Default(), Dafny.Sequence<DAST._IStatement>.Empty, Std.Wrappers.Option<DAST._IExpression>.Default());
        public static DAST._INewtype Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST._INewtype> _TYPE = new Dafny.TypeDescriptor<DAST._INewtype>(DAST.Newtype.Default());
        public static Dafny.TypeDescriptor<DAST._INewtype> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _INewtype create(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, DAST._IType @base, DAST._INewtypeRange range, Dafny.ISequence<DAST._IStatement> witnessStmts, Std.Wrappers._IOption<DAST._IExpression> witnessExpr)
        {
            return new Newtype(name, typeParams, @base, range, witnessStmts, witnessExpr);
        }
        public static _INewtype create_Newtype(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, DAST._IType @base, DAST._INewtypeRange range, Dafny.ISequence<DAST._IStatement> witnessStmts, Std.Wrappers._IOption<DAST._IExpression> witnessExpr)
        {
            return create(name, typeParams, @base, range, witnessStmts, witnessExpr);
        }
        public bool is_Newtype
        {
            get { return MutateCSharp.Schemata274.ReplaceBooleanConstant_7(2718L, true); }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_name
        {
            get
            {
                return this._name;
            }
        }

        public Dafny.ISequence<DAST._IType> dtor_typeParams
        {
            get
            {
                return this._typeParams;
            }
        }

        public DAST._IType dtor_base
        {
            get
            {
                return this._base;
            }
        }

        public DAST._INewtypeRange dtor_range
        {
            get
            {
                return this._range;
            }
        }

        public Dafny.ISequence<DAST._IStatement> dtor_witnessStmts
        {
            get
            {
                return this._witnessStmts;
            }
        }

        public Std.Wrappers._IOption<DAST._IExpression> dtor_witnessExpr
        {
            get
            {
                return this._witnessExpr;
            }
        }
    }

    public interface _IClassItem
    {
        bool is_Method { get; }
        DAST._IMethod dtor_Method_a0 { get; }
    }
    public class ClassItem : _IClassItem
    {
        public readonly DAST._IMethod _a0;
        public ClassItem(DAST._IMethod _a0)
        {
            this._a0 = _a0;
        }
        public static DAST._IMethod DowncastClone(DAST._IMethod _this)
        {
            return _this;
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.ClassItem;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(2720L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_54(2719L, oth, null), () => object.Equals(this._a0, oth._a0));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(2726L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2743L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2733L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2729L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(2740L, 0));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2761L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2754L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2750L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(2768L, "DAST.ClassItem.Method");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2769L, "(");
            s += Dafny.Helpers.ToString(this._a0);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2770L, ")");
            return s;
        }
        private static readonly DAST._IMethod theDefault = DAST.Method.Default();
        public static DAST._IMethod Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST._IMethod> _TYPE = new Dafny.TypeDescriptor<DAST._IMethod>(DAST.Method.Default());
        public static Dafny.TypeDescriptor<DAST._IMethod> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IClassItem create(DAST._IMethod _a0)
        {
            return new ClassItem(_a0);
        }
        public static _IClassItem create_Method(DAST._IMethod _a0)
        {
            return create(_a0);
        }
        public bool is_Method
        {
            get { return MutateCSharp.Schemata274.ReplaceBooleanConstant_7(2771L, true); }
        }

        public DAST._IMethod dtor_Method_a0
        {
            get
            {
                return this._a0;
            }
        }
    }

    public interface _IField
    {
        bool is_Field { get; }
        DAST._IFormal dtor_formal { get; }
        Std.Wrappers._IOption<DAST._IExpression> dtor_defaultValue { get; }

        _IField DowncastClone();
    }
    public class Field : _IField
    {
        public readonly DAST._IFormal _formal;
        public readonly Std.Wrappers._IOption<DAST._IExpression> _defaultValue;
        public Field(DAST._IFormal formal, Std.Wrappers._IOption<DAST._IExpression> defaultValue)
        {
            this._formal = formal;
            this._defaultValue = defaultValue;
        }
        public _IField DowncastClone()
        {
            if (this is _IField dt) { return dt; }
            return new Field(_formal, _defaultValue);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Field;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(2779L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2773L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_55(2772L, oth, null), () => object.Equals(this._formal, oth._formal)), () => object.Equals(this._defaultValue, oth._defaultValue));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(2785L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2802L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2792L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2788L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(2799L, 0));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2820L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2813L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2809L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._formal)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2838L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2831L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2827L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._defaultValue)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(2845L, "DAST.Field.Field");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2846L, "(");
            s += Dafny.Helpers.ToString(this._formal);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2847L, ", ");
            s += Dafny.Helpers.ToString(this._defaultValue);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2848L, ")");
            return s;
        }
        private static readonly DAST._IField theDefault = create(DAST.Formal.Default(), Std.Wrappers.Option<DAST._IExpression>.Default());
        public static DAST._IField Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST._IField> _TYPE = new Dafny.TypeDescriptor<DAST._IField>(DAST.Field.Default());
        public static Dafny.TypeDescriptor<DAST._IField> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IField create(DAST._IFormal formal, Std.Wrappers._IOption<DAST._IExpression> defaultValue)
        {
            return new Field(formal, defaultValue);
        }
        public static _IField create_Field(DAST._IFormal formal, Std.Wrappers._IOption<DAST._IExpression> defaultValue)
        {
            return create(formal, defaultValue);
        }
        public bool is_Field
        {
            get { return MutateCSharp.Schemata274.ReplaceBooleanConstant_7(2849L, true); }
        }

        public DAST._IFormal dtor_formal
        {
            get
            {
                return this._formal;
            }
        }

        public Std.Wrappers._IOption<DAST._IExpression> dtor_defaultValue
        {
            get
            {
                return this._defaultValue;
            }
        }
    }

    public interface _IFormal
    {
        bool is_Formal { get; }
        Dafny.ISequence<Dafny.Rune> dtor_name { get; }
        DAST._IType dtor_typ { get; }

        _IFormal DowncastClone();
    }
    public class Formal : _IFormal
    {
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public readonly DAST._IType _typ;
        public Formal(Dafny.ISequence<Dafny.Rune> name, DAST._IType typ)
        {
            this._name = name;
            this._typ = typ;
        }
        public _IFormal DowncastClone()
        {
            if (this is _IFormal dt) { return dt; }
            return new Formal(_name, _typ);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Formal;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(2857L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2851L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_56(2850L, oth, null), () => object.Equals(this._name, oth._name)), () => object.Equals(this._typ, oth._typ));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(2863L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2880L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2870L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2866L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(2877L, 0));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2898L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2891L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2887L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(2916L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(2909L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2905L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typ)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(2923L, "DAST.Formal.Formal");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2924L, "(");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(2925L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2926L, ", ");
            s += Dafny.Helpers.ToString(this._typ);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(2927L, ")");
            return s;
        }
        private static readonly DAST._IFormal theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, DAST.Type.Default());
        public static DAST._IFormal Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST._IFormal> _TYPE = new Dafny.TypeDescriptor<DAST._IFormal>(DAST.Formal.Default());
        public static Dafny.TypeDescriptor<DAST._IFormal> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IFormal create(Dafny.ISequence<Dafny.Rune> name, DAST._IType typ)
        {
            return new Formal(name, typ);
        }
        public static _IFormal create_Formal(Dafny.ISequence<Dafny.Rune> name, DAST._IType typ)
        {
            return create(name, typ);
        }
        public bool is_Formal
        {
            get { return MutateCSharp.Schemata274.ReplaceBooleanConstant_7(2928L, true); }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_name
        {
            get
            {
                return this._name;
            }
        }

        public DAST._IType dtor_typ
        {
            get
            {
                return this._typ;
            }
        }
    }

    public interface _IMethod
    {
        bool is_Method { get; }
        bool dtor_isStatic { get; }
        bool dtor_hasBody { get; }
        Std.Wrappers._IOption<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> dtor_overridingPath { get; }
        Dafny.ISequence<Dafny.Rune> dtor_name { get; }
        Dafny.ISequence<DAST._IType> dtor_typeParams { get; }
        Dafny.ISequence<DAST._IFormal> dtor_params { get; }
        Dafny.ISequence<DAST._IStatement> dtor_body { get; }
        Dafny.ISequence<DAST._IType> dtor_outTypes { get; }
        Std.Wrappers._IOption<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> dtor_outVars { get; }

        _IMethod DowncastClone();
    }
    public class Method : _IMethod
    {
        public readonly bool _isStatic;
        public readonly bool _hasBody;
        public readonly Std.Wrappers._IOption<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _overridingPath;
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public readonly Dafny.ISequence<DAST._IType> _typeParams;
        public readonly Dafny.ISequence<DAST._IFormal> _params;
        public readonly Dafny.ISequence<DAST._IStatement> _body;
        public readonly Dafny.ISequence<DAST._IType> _outTypes;
        public readonly Std.Wrappers._IOption<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _outVars;
        public Method(bool isStatic, bool hasBody, Std.Wrappers._IOption<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> overridingPath, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IFormal> @params, Dafny.ISequence<DAST._IStatement> body, Dafny.ISequence<DAST._IType> outTypes, Std.Wrappers._IOption<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> outVars)
        {
            this._isStatic = isStatic;
            this._hasBody = hasBody;
            this._overridingPath = overridingPath;
            this._name = name;
            this._typeParams = typeParams;
            this._params = @params;
            this._body = body;
            this._outTypes = outTypes;
            this._outVars = outVars;
        }
        public _IMethod DowncastClone()
        {
            if (this is _IMethod dt) { return dt; }
            return new Method(_isStatic, _hasBody, _overridingPath, _name, _typeParams, _params, _body, _outTypes, _outVars);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Method;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(2990L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2984L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2978L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2972L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2966L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2960L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2954L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2948L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(2936L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_57(2929L, oth, null), () => MutateCSharp.Schemata274.ReplaceBinExprOp_2(2930L, () => this._isStatic, () => oth._isStatic)), () => MutateCSharp.Schemata274.ReplaceBinExprOp_2(2942L, () => this._hasBody, () => oth._hasBody)), () => object.Equals(this._overridingPath, oth._overridingPath)), () => object.Equals(this._name, oth._name)), () => object.Equals(this._typeParams, oth._typeParams)), () => object.Equals(this._params, oth._params)), () => object.Equals(this._body, oth._body)), () => object.Equals(this._outTypes, oth._outTypes)), () => object.Equals(this._outVars, oth._outVars));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(2996L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3013L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3003L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(2999L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(3010L, 0));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3031L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3024L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3020L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._isStatic)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3049L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3042L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3038L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._hasBody)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3067L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3060L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3056L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._overridingPath)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3085L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3078L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3074L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3103L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3096L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3092L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typeParams)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3121L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3114L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3110L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._params)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3139L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3132L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3128L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._body)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3157L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3150L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3146L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._outTypes)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3175L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3168L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3164L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._outVars)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(3182L, "DAST.Method.Method");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3183L, "(");
            s += Dafny.Helpers.ToString(this._isStatic);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3184L, ", ");
            s += Dafny.Helpers.ToString(this._hasBody);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3185L, ", ");
            s += Dafny.Helpers.ToString(this._overridingPath);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3186L, ", ");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(3187L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3188L, ", ");
            s += Dafny.Helpers.ToString(this._typeParams);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3189L, ", ");
            s += Dafny.Helpers.ToString(this._params);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3190L, ", ");
            s += Dafny.Helpers.ToString(this._body);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3191L, ", ");
            s += Dafny.Helpers.ToString(this._outTypes);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3192L, ", ");
            s += Dafny.Helpers.ToString(this._outVars);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3193L, ")");
            return s;
        }
        private static readonly DAST._IMethod theDefault = create(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(3194L, false), MutateCSharp.Schemata274.ReplaceBooleanConstant_7(3195L, false), Std.Wrappers.Option<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>>.Default(), Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<DAST._IType>.Empty, Dafny.Sequence<DAST._IFormal>.Empty, Dafny.Sequence<DAST._IStatement>.Empty, Dafny.Sequence<DAST._IType>.Empty, Std.Wrappers.Option<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>>.Default());
        public static DAST._IMethod Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST._IMethod> _TYPE = new Dafny.TypeDescriptor<DAST._IMethod>(DAST.Method.Default());
        public static Dafny.TypeDescriptor<DAST._IMethod> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IMethod create(bool isStatic, bool hasBody, Std.Wrappers._IOption<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> overridingPath, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IFormal> @params, Dafny.ISequence<DAST._IStatement> body, Dafny.ISequence<DAST._IType> outTypes, Std.Wrappers._IOption<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> outVars)
        {
            return new Method(isStatic, hasBody, overridingPath, name, typeParams, @params, body, outTypes, outVars);
        }
        public static _IMethod create_Method(bool isStatic, bool hasBody, Std.Wrappers._IOption<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> overridingPath, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IFormal> @params, Dafny.ISequence<DAST._IStatement> body, Dafny.ISequence<DAST._IType> outTypes, Std.Wrappers._IOption<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> outVars)
        {
            return create(isStatic, hasBody, overridingPath, name, typeParams, @params, body, outTypes, outVars);
        }
        public bool is_Method
        {
            get { return MutateCSharp.Schemata274.ReplaceBooleanConstant_7(3196L, true); }
        }

        public bool dtor_isStatic
        {
            get
            {
                return this._isStatic;
            }
        }

        public bool dtor_hasBody
        {
            get
            {
                return this._hasBody;
            }
        }

        public Std.Wrappers._IOption<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> dtor_overridingPath
        {
            get
            {
                return this._overridingPath;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_name
        {
            get
            {
                return this._name;
            }
        }

        public Dafny.ISequence<DAST._IType> dtor_typeParams
        {
            get
            {
                return this._typeParams;
            }
        }

        public Dafny.ISequence<DAST._IFormal> dtor_params
        {
            get
            {
                return this._params;
            }
        }

        public Dafny.ISequence<DAST._IStatement> dtor_body
        {
            get
            {
                return this._body;
            }
        }

        public Dafny.ISequence<DAST._IType> dtor_outTypes
        {
            get
            {
                return this._outTypes;
            }
        }

        public Std.Wrappers._IOption<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> dtor_outVars
        {
            get
            {
                return this._outVars;
            }
        }
    }

    public interface _ICallName
    {
        bool is_Name { get; }
        bool is_MapBuilderAdd { get; }
        bool is_MapBuilderBuild { get; }
        bool is_SetBuilderAdd { get; }
        bool is_SetBuilderBuild { get; }
        Dafny.ISequence<Dafny.Rune> dtor_name { get; }

        _ICallName DowncastClone();
    }
    public abstract class CallName : _ICallName
    {
        public CallName()
        {
        }
        private static readonly DAST._ICallName theDefault = create_Name(Dafny.Sequence<Dafny.Rune>.Empty);
        public static DAST._ICallName Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST._ICallName> _TYPE = new Dafny.TypeDescriptor<DAST._ICallName>(DAST.CallName.Default());
        public static Dafny.TypeDescriptor<DAST._ICallName> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _ICallName create_Name(Dafny.ISequence<Dafny.Rune> name)
        {
            return new CallName_Name(name);
        }
        public static _ICallName create_MapBuilderAdd()
        {
            return new CallName_MapBuilderAdd();
        }
        public static _ICallName create_MapBuilderBuild()
        {
            return new CallName_MapBuilderBuild();
        }
        public static _ICallName create_SetBuilderAdd()
        {
            return new CallName_SetBuilderAdd();
        }
        public static _ICallName create_SetBuilderBuild()
        {
            return new CallName_SetBuilderBuild();
        }
        public bool is_Name
        {
            get { return this is CallName_Name; }
        }

        public bool is_MapBuilderAdd
        {
            get { return this is CallName_MapBuilderAdd; }
        }

        public bool is_MapBuilderBuild
        {
            get { return this is CallName_MapBuilderBuild; }
        }

        public bool is_SetBuilderAdd
        {
            get { return this is CallName_SetBuilderAdd; }
        }

        public bool is_SetBuilderBuild
        {
            get { return this is CallName_SetBuilderBuild; }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_name
        {
            get
            {
                var d = this;
                return ((CallName_Name)d)._name;
            }
        }

        public abstract _ICallName DowncastClone();
    }
    public class CallName_Name : CallName
    {
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public CallName_Name(Dafny.ISequence<Dafny.Rune> name) : base()
        {
            this._name = name;
        }
        public override _ICallName DowncastClone()
        {
            if (this is _ICallName dt) { return dt; }
            return new CallName_Name(_name);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.CallName_Name;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(3198L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_58(3197L, oth, null), () => object.Equals(this._name, oth._name));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(3204L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3221L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3211L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3207L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(3218L, 0));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3239L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3232L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3228L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(3246L, "DAST.CallName.Name");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3247L, "(");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(3248L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3249L, ")");
            return s;
        }
    }
    public class CallName_MapBuilderAdd : CallName
    {
        public CallName_MapBuilderAdd() : base()
        {
        }
        public override _ICallName DowncastClone()
        {
            if (this is _ICallName dt) { return dt; }
            return new CallName_MapBuilderAdd();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.CallName_MapBuilderAdd;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_59(3250L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(3251L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3268L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3258L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3254L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(3265L, 1));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(3275L, "DAST.CallName.MapBuilderAdd");
            return s;
        }
    }
    public class CallName_MapBuilderBuild : CallName
    {
        public CallName_MapBuilderBuild() : base()
        {
        }
        public override _ICallName DowncastClone()
        {
            if (this is _ICallName dt) { return dt; }
            return new CallName_MapBuilderBuild();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.CallName_MapBuilderBuild;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_60(3276L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(3277L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3294L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3284L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3280L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(3291L, 2));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(3301L, "DAST.CallName.MapBuilderBuild");
            return s;
        }
    }
    public class CallName_SetBuilderAdd : CallName
    {
        public CallName_SetBuilderAdd() : base()
        {
        }
        public override _ICallName DowncastClone()
        {
            if (this is _ICallName dt) { return dt; }
            return new CallName_SetBuilderAdd();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.CallName_SetBuilderAdd;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_61(3302L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(3303L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3320L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3310L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3306L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(3317L, 3));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(3327L, "DAST.CallName.SetBuilderAdd");
            return s;
        }
    }
    public class CallName_SetBuilderBuild : CallName
    {
        public CallName_SetBuilderBuild() : base()
        {
        }
        public override _ICallName DowncastClone()
        {
            if (this is _ICallName dt) { return dt; }
            return new CallName_SetBuilderBuild();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.CallName_SetBuilderBuild;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_62(3328L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(3329L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3346L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3336L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3332L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(3343L, 4));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(3353L, "DAST.CallName.SetBuilderBuild");
            return s;
        }
    }

    public interface _IStatement
    {
        bool is_DeclareVar { get; }
        bool is_Assign { get; }
        bool is_If { get; }
        bool is_Labeled { get; }
        bool is_While { get; }
        bool is_Foreach { get; }
        bool is_Call { get; }
        bool is_Return { get; }
        bool is_EarlyReturn { get; }
        bool is_Break { get; }
        bool is_TailRecursive { get; }
        bool is_JumpTailCallStart { get; }
        bool is_Halt { get; }
        bool is_Print { get; }
        Dafny.ISequence<Dafny.Rune> dtor_name { get; }
        DAST._IType dtor_typ { get; }
        Std.Wrappers._IOption<DAST._IExpression> dtor_maybeValue { get; }
        DAST._IAssignLhs dtor_lhs { get; }
        DAST._IExpression dtor_value { get; }
        DAST._IExpression dtor_cond { get; }
        Dafny.ISequence<DAST._IStatement> dtor_thn { get; }
        Dafny.ISequence<DAST._IStatement> dtor_els { get; }
        Dafny.ISequence<Dafny.Rune> dtor_lbl { get; }
        Dafny.ISequence<DAST._IStatement> dtor_body { get; }
        Dafny.ISequence<Dafny.Rune> dtor_boundName { get; }
        DAST._IType dtor_boundType { get; }
        DAST._IExpression dtor_over { get; }
        DAST._IExpression dtor_on { get; }
        DAST._ICallName dtor_callName { get; }
        Dafny.ISequence<DAST._IType> dtor_typeArgs { get; }
        Dafny.ISequence<DAST._IExpression> dtor_args { get; }
        Std.Wrappers._IOption<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> dtor_outs { get; }
        DAST._IExpression dtor_expr { get; }
        Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> dtor_toLabel { get; }
        DAST._IExpression dtor_Print_a0 { get; }

        _IStatement DowncastClone();
    }
    public abstract class Statement : _IStatement
    {
        public Statement()
        {
        }
        private static readonly DAST._IStatement theDefault = create_DeclareVar(Dafny.Sequence<Dafny.Rune>.Empty, DAST.Type.Default(), Std.Wrappers.Option<DAST._IExpression>.Default());
        public static DAST._IStatement Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST._IStatement> _TYPE = new Dafny.TypeDescriptor<DAST._IStatement>(DAST.Statement.Default());
        public static Dafny.TypeDescriptor<DAST._IStatement> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IStatement create_DeclareVar(Dafny.ISequence<Dafny.Rune> name, DAST._IType typ, Std.Wrappers._IOption<DAST._IExpression> maybeValue)
        {
            return new Statement_DeclareVar(name, typ, maybeValue);
        }
        public static _IStatement create_Assign(DAST._IAssignLhs lhs, DAST._IExpression @value)
        {
            return new Statement_Assign(lhs, @value);
        }
        public static _IStatement create_If(DAST._IExpression cond, Dafny.ISequence<DAST._IStatement> thn, Dafny.ISequence<DAST._IStatement> els)
        {
            return new Statement_If(cond, thn, els);
        }
        public static _IStatement create_Labeled(Dafny.ISequence<Dafny.Rune> lbl, Dafny.ISequence<DAST._IStatement> body)
        {
            return new Statement_Labeled(lbl, body);
        }
        public static _IStatement create_While(DAST._IExpression cond, Dafny.ISequence<DAST._IStatement> body)
        {
            return new Statement_While(cond, body);
        }
        public static _IStatement create_Foreach(Dafny.ISequence<Dafny.Rune> boundName, DAST._IType boundType, DAST._IExpression over, Dafny.ISequence<DAST._IStatement> body)
        {
            return new Statement_Foreach(boundName, boundType, over, body);
        }
        public static _IStatement create_Call(DAST._IExpression @on, DAST._ICallName callName, Dafny.ISequence<DAST._IType> typeArgs, Dafny.ISequence<DAST._IExpression> args, Std.Wrappers._IOption<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> outs)
        {
            return new Statement_Call(@on, callName, typeArgs, args, outs);
        }
        public static _IStatement create_Return(DAST._IExpression expr)
        {
            return new Statement_Return(expr);
        }
        public static _IStatement create_EarlyReturn()
        {
            return new Statement_EarlyReturn();
        }
        public static _IStatement create_Break(Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> toLabel)
        {
            return new Statement_Break(toLabel);
        }
        public static _IStatement create_TailRecursive(Dafny.ISequence<DAST._IStatement> body)
        {
            return new Statement_TailRecursive(body);
        }
        public static _IStatement create_JumpTailCallStart()
        {
            return new Statement_JumpTailCallStart();
        }
        public static _IStatement create_Halt()
        {
            return new Statement_Halt();
        }
        public static _IStatement create_Print(DAST._IExpression _a0)
        {
            return new Statement_Print(_a0);
        }
        public bool is_DeclareVar
        {
            get { return this is Statement_DeclareVar; }
        }

        public bool is_Assign
        {
            get { return this is Statement_Assign; }
        }

        public bool is_If
        {
            get { return this is Statement_If; }
        }

        public bool is_Labeled
        {
            get { return this is Statement_Labeled; }
        }

        public bool is_While
        {
            get { return this is Statement_While; }
        }

        public bool is_Foreach
        {
            get { return this is Statement_Foreach; }
        }

        public bool is_Call
        {
            get { return this is Statement_Call; }
        }

        public bool is_Return
        {
            get { return this is Statement_Return; }
        }

        public bool is_EarlyReturn
        {
            get { return this is Statement_EarlyReturn; }
        }

        public bool is_Break
        {
            get { return this is Statement_Break; }
        }

        public bool is_TailRecursive
        {
            get { return this is Statement_TailRecursive; }
        }

        public bool is_JumpTailCallStart
        {
            get { return this is Statement_JumpTailCallStart; }
        }

        public bool is_Halt
        {
            get { return this is Statement_Halt; }
        }

        public bool is_Print
        {
            get { return this is Statement_Print; }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_name
        {
            get
            {
                var d = this;
                return ((Statement_DeclareVar)d)._name;
            }
        }

        public DAST._IType dtor_typ
        {
            get
            {
                var d = this;
                return ((Statement_DeclareVar)d)._typ;
            }
        }

        public Std.Wrappers._IOption<DAST._IExpression> dtor_maybeValue
        {
            get
            {
                var d = this;
                return ((Statement_DeclareVar)d)._maybeValue;
            }
        }

        public DAST._IAssignLhs dtor_lhs
        {
            get
            {
                var d = this;
                return ((Statement_Assign)d)._lhs;
            }
        }

        public DAST._IExpression dtor_value
        {
            get
            {
                var d = this;
                return ((Statement_Assign)d)._value;
            }
        }

        public DAST._IExpression dtor_cond
        {
            get
            {
                var d = this;
                if (d is Statement_If) { return ((Statement_If)d)._cond; }
                return ((Statement_While)d)._cond;
            }
        }

        public Dafny.ISequence<DAST._IStatement> dtor_thn
        {
            get
            {
                var d = this;
                return ((Statement_If)d)._thn;
            }
        }

        public Dafny.ISequence<DAST._IStatement> dtor_els
        {
            get
            {
                var d = this;
                return ((Statement_If)d)._els;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_lbl
        {
            get
            {
                var d = this;
                return ((Statement_Labeled)d)._lbl;
            }
        }

        public Dafny.ISequence<DAST._IStatement> dtor_body
        {
            get
            {
                var d = this;
                if (d is Statement_Labeled) { return ((Statement_Labeled)d)._body; }
                if (d is Statement_While) { return ((Statement_While)d)._body; }
                if (d is Statement_Foreach) { return ((Statement_Foreach)d)._body; }
                return ((Statement_TailRecursive)d)._body;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_boundName
        {
            get
            {
                var d = this;
                return ((Statement_Foreach)d)._boundName;
            }
        }

        public DAST._IType dtor_boundType
        {
            get
            {
                var d = this;
                return ((Statement_Foreach)d)._boundType;
            }
        }

        public DAST._IExpression dtor_over
        {
            get
            {
                var d = this;
                return ((Statement_Foreach)d)._over;
            }
        }

        public DAST._IExpression dtor_on
        {
            get
            {
                var d = this;
                return ((Statement_Call)d)._on;
            }
        }

        public DAST._ICallName dtor_callName
        {
            get
            {
                var d = this;
                return ((Statement_Call)d)._callName;
            }
        }

        public Dafny.ISequence<DAST._IType> dtor_typeArgs
        {
            get
            {
                var d = this;
                return ((Statement_Call)d)._typeArgs;
            }
        }

        public Dafny.ISequence<DAST._IExpression> dtor_args
        {
            get
            {
                var d = this;
                return ((Statement_Call)d)._args;
            }
        }

        public Std.Wrappers._IOption<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> dtor_outs
        {
            get
            {
                var d = this;
                return ((Statement_Call)d)._outs;
            }
        }

        public DAST._IExpression dtor_expr
        {
            get
            {
                var d = this;
                return ((Statement_Return)d)._expr;
            }
        }

        public Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> dtor_toLabel
        {
            get
            {
                var d = this;
                return ((Statement_Break)d)._toLabel;
            }
        }

        public DAST._IExpression dtor_Print_a0
        {
            get
            {
                var d = this;
                return ((Statement_Print)d)._a0;
            }
        }

        public abstract _IStatement DowncastClone();
    }
    public class Statement_DeclareVar : Statement
    {
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public readonly DAST._IType _typ;
        public readonly Std.Wrappers._IOption<DAST._IExpression> _maybeValue;
        public Statement_DeclareVar(Dafny.ISequence<Dafny.Rune> name, DAST._IType typ, Std.Wrappers._IOption<DAST._IExpression> maybeValue) : base()
        {
            this._name = name;
            this._typ = typ;
            this._maybeValue = maybeValue;
        }
        public override _IStatement DowncastClone()
        {
            if (this is _IStatement dt) { return dt; }
            return new Statement_DeclareVar(_name, _typ, _maybeValue);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Statement_DeclareVar;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(3367L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(3361L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(3355L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_63(3354L, oth, null), () => object.Equals(this._name, oth._name)), () => object.Equals(this._typ, oth._typ)), () => object.Equals(this._maybeValue, oth._maybeValue));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(3373L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3390L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3380L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3376L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(3387L, 0));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3408L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3401L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3397L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3426L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3419L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3415L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typ)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3444L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3437L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3433L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._maybeValue)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(3451L, "DAST.Statement.DeclareVar");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3452L, "(");
            s += this._name.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(3453L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3454L, ", ");
            s += Dafny.Helpers.ToString(this._typ);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3455L, ", ");
            s += Dafny.Helpers.ToString(this._maybeValue);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3456L, ")");
            return s;
        }
    }
    public class Statement_Assign : Statement
    {
        public readonly DAST._IAssignLhs _lhs;
        public readonly DAST._IExpression _value;
        public Statement_Assign(DAST._IAssignLhs lhs, DAST._IExpression @value) : base()
        {
            this._lhs = lhs;
            this._value = @value;
        }
        public override _IStatement DowncastClone()
        {
            if (this is _IStatement dt) { return dt; }
            return new Statement_Assign(_lhs, _value);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Statement_Assign;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(3464L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(3458L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_64(3457L, oth, null), () => object.Equals(this._lhs, oth._lhs)), () => object.Equals(this._value, oth._value));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(3470L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3487L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3477L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3473L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(3484L, 1));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3505L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3498L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3494L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._lhs)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3523L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3516L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3512L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._value)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(3530L, "DAST.Statement.Assign");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3531L, "(");
            s += Dafny.Helpers.ToString(this._lhs);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3532L, ", ");
            s += Dafny.Helpers.ToString(this._value);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3533L, ")");
            return s;
        }
    }
    public class Statement_If : Statement
    {
        public readonly DAST._IExpression _cond;
        public readonly Dafny.ISequence<DAST._IStatement> _thn;
        public readonly Dafny.ISequence<DAST._IStatement> _els;
        public Statement_If(DAST._IExpression cond, Dafny.ISequence<DAST._IStatement> thn, Dafny.ISequence<DAST._IStatement> els) : base()
        {
            this._cond = cond;
            this._thn = thn;
            this._els = els;
        }
        public override _IStatement DowncastClone()
        {
            if (this is _IStatement dt) { return dt; }
            return new Statement_If(_cond, _thn, _els);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Statement_If;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(3547L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(3541L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(3535L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_65(3534L, oth, null), () => object.Equals(this._cond, oth._cond)), () => object.Equals(this._thn, oth._thn)), () => object.Equals(this._els, oth._els));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(3553L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3570L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3560L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3556L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(3567L, 2));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3588L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3581L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3577L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._cond)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3606L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3599L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3595L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._thn)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3624L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3617L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3613L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._els)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(3631L, "DAST.Statement.If");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3632L, "(");
            s += Dafny.Helpers.ToString(this._cond);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3633L, ", ");
            s += Dafny.Helpers.ToString(this._thn);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3634L, ", ");
            s += Dafny.Helpers.ToString(this._els);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3635L, ")");
            return s;
        }
    }
    public class Statement_Labeled : Statement
    {
        public readonly Dafny.ISequence<Dafny.Rune> _lbl;
        public readonly Dafny.ISequence<DAST._IStatement> _body;
        public Statement_Labeled(Dafny.ISequence<Dafny.Rune> lbl, Dafny.ISequence<DAST._IStatement> body) : base()
        {
            this._lbl = lbl;
            this._body = body;
        }
        public override _IStatement DowncastClone()
        {
            if (this is _IStatement dt) { return dt; }
            return new Statement_Labeled(_lbl, _body);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Statement_Labeled;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(3643L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(3637L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_66(3636L, oth, null), () => object.Equals(this._lbl, oth._lbl)), () => object.Equals(this._body, oth._body));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(3649L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3666L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3656L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3652L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(3663L, 3));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3684L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3677L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3673L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._lbl)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3702L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3695L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3691L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._body)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(3709L, "DAST.Statement.Labeled");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3710L, "(");
            s += this._lbl.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(3711L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3712L, ", ");
            s += Dafny.Helpers.ToString(this._body);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3713L, ")");
            return s;
        }
    }
    public class Statement_While : Statement
    {
        public readonly DAST._IExpression _cond;
        public readonly Dafny.ISequence<DAST._IStatement> _body;
        public Statement_While(DAST._IExpression cond, Dafny.ISequence<DAST._IStatement> body) : base()
        {
            this._cond = cond;
            this._body = body;
        }
        public override _IStatement DowncastClone()
        {
            if (this is _IStatement dt) { return dt; }
            return new Statement_While(_cond, _body);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Statement_While;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(3721L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(3715L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_67(3714L, oth, null), () => object.Equals(this._cond, oth._cond)), () => object.Equals(this._body, oth._body));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(3727L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3744L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3734L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3730L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(3741L, 4));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3762L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3755L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3751L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._cond)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3780L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3773L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3769L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._body)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(3787L, "DAST.Statement.While");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3788L, "(");
            s += Dafny.Helpers.ToString(this._cond);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3789L, ", ");
            s += Dafny.Helpers.ToString(this._body);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3790L, ")");
            return s;
        }
    }
    public class Statement_Foreach : Statement
    {
        public readonly Dafny.ISequence<Dafny.Rune> _boundName;
        public readonly DAST._IType _boundType;
        public readonly DAST._IExpression _over;
        public readonly Dafny.ISequence<DAST._IStatement> _body;
        public Statement_Foreach(Dafny.ISequence<Dafny.Rune> boundName, DAST._IType boundType, DAST._IExpression over, Dafny.ISequence<DAST._IStatement> body) : base()
        {
            this._boundName = boundName;
            this._boundType = boundType;
            this._over = over;
            this._body = body;
        }
        public override _IStatement DowncastClone()
        {
            if (this is _IStatement dt) { return dt; }
            return new Statement_Foreach(_boundName, _boundType, _over, _body);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Statement_Foreach;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(3810L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(3804L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(3798L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(3792L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_68(3791L, oth, null), () => object.Equals(this._boundName, oth._boundName)), () => object.Equals(this._boundType, oth._boundType)), () => object.Equals(this._over, oth._over)), () => object.Equals(this._body, oth._body));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(3816L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3833L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3823L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3819L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(3830L, 5));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3851L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3844L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3840L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._boundName)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3869L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3862L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3858L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._boundType)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3887L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3880L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3876L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._over)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3905L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3898L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3894L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._body)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(3912L, "DAST.Statement.Foreach");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3913L, "(");
            s += this._boundName.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(3914L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3915L, ", ");
            s += Dafny.Helpers.ToString(this._boundType);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3916L, ", ");
            s += Dafny.Helpers.ToString(this._over);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3917L, ", ");
            s += Dafny.Helpers.ToString(this._body);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(3918L, ")");
            return s;
        }
    }
    public class Statement_Call : Statement
    {
        public readonly DAST._IExpression _on;
        public readonly DAST._ICallName _callName;
        public readonly Dafny.ISequence<DAST._IType> _typeArgs;
        public readonly Dafny.ISequence<DAST._IExpression> _args;
        public readonly Std.Wrappers._IOption<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _outs;
        public Statement_Call(DAST._IExpression @on, DAST._ICallName callName, Dafny.ISequence<DAST._IType> typeArgs, Dafny.ISequence<DAST._IExpression> args, Std.Wrappers._IOption<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> outs) : base()
        {
            this._on = @on;
            this._callName = callName;
            this._typeArgs = typeArgs;
            this._args = args;
            this._outs = outs;
        }
        public override _IStatement DowncastClone()
        {
            if (this is _IStatement dt) { return dt; }
            return new Statement_Call(_on, _callName, _typeArgs, _args, _outs);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Statement_Call;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(3944L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(3938L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(3932L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(3926L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(3920L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_69(3919L, oth, null), () => object.Equals(this._on, oth._on)), () => object.Equals(this._callName, oth._callName)), () => object.Equals(this._typeArgs, oth._typeArgs)), () => object.Equals(this._args, oth._args)), () => object.Equals(this._outs, oth._outs));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(3950L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3967L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3957L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3953L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(3964L, 6));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(3985L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3978L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3974L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._on)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4003L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(3996L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(3992L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._callName)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4021L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4014L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4010L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typeArgs)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4039L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4032L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4028L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._args)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4057L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4050L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4046L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._outs)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4064L, "DAST.Statement.Call");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4065L, "(");
            s += Dafny.Helpers.ToString(this._on);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4066L, ", ");
            s += Dafny.Helpers.ToString(this._callName);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4067L, ", ");
            s += Dafny.Helpers.ToString(this._typeArgs);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4068L, ", ");
            s += Dafny.Helpers.ToString(this._args);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4069L, ", ");
            s += Dafny.Helpers.ToString(this._outs);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4070L, ")");
            return s;
        }
    }
    public class Statement_Return : Statement
    {
        public readonly DAST._IExpression _expr;
        public Statement_Return(DAST._IExpression expr) : base()
        {
            this._expr = expr;
        }
        public override _IStatement DowncastClone()
        {
            if (this is _IStatement dt) { return dt; }
            return new Statement_Return(_expr);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Statement_Return;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(4072L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_70(4071L, oth, null), () => object.Equals(this._expr, oth._expr));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4078L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4095L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4085L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4081L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4092L, 7));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4113L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4106L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4102L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._expr)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4120L, "DAST.Statement.Return");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4121L, "(");
            s += Dafny.Helpers.ToString(this._expr);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4122L, ")");
            return s;
        }
    }
    public class Statement_EarlyReturn : Statement
    {
        public Statement_EarlyReturn() : base()
        {
        }
        public override _IStatement DowncastClone()
        {
            if (this is _IStatement dt) { return dt; }
            return new Statement_EarlyReturn();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Statement_EarlyReturn;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_71(4123L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4124L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4141L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4131L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4127L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4138L, 8));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4148L, "DAST.Statement.EarlyReturn");
            return s;
        }
    }
    public class Statement_Break : Statement
    {
        public readonly Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _toLabel;
        public Statement_Break(Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> toLabel) : base()
        {
            this._toLabel = toLabel;
        }
        public override _IStatement DowncastClone()
        {
            if (this is _IStatement dt) { return dt; }
            return new Statement_Break(_toLabel);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Statement_Break;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(4150L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_72(4149L, oth, null), () => object.Equals(this._toLabel, oth._toLabel));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4156L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4173L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4163L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4159L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4170L, 9));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4191L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4184L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4180L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._toLabel)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4198L, "DAST.Statement.Break");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4199L, "(");
            s += Dafny.Helpers.ToString(this._toLabel);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4200L, ")");
            return s;
        }
    }
    public class Statement_TailRecursive : Statement
    {
        public readonly Dafny.ISequence<DAST._IStatement> _body;
        public Statement_TailRecursive(Dafny.ISequence<DAST._IStatement> body) : base()
        {
            this._body = body;
        }
        public override _IStatement DowncastClone()
        {
            if (this is _IStatement dt) { return dt; }
            return new Statement_TailRecursive(_body);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Statement_TailRecursive;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(4202L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_73(4201L, oth, null), () => object.Equals(this._body, oth._body));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4208L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4225L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4215L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4211L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4222L, 10));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4243L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4236L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4232L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._body)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4250L, "DAST.Statement.TailRecursive");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4251L, "(");
            s += Dafny.Helpers.ToString(this._body);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4252L, ")");
            return s;
        }
    }
    public class Statement_JumpTailCallStart : Statement
    {
        public Statement_JumpTailCallStart() : base()
        {
        }
        public override _IStatement DowncastClone()
        {
            if (this is _IStatement dt) { return dt; }
            return new Statement_JumpTailCallStart();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Statement_JumpTailCallStart;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_74(4253L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4254L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4271L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4261L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4257L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4268L, 11));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4278L, "DAST.Statement.JumpTailCallStart");
            return s;
        }
    }
    public class Statement_Halt : Statement
    {
        public Statement_Halt() : base()
        {
        }
        public override _IStatement DowncastClone()
        {
            if (this is _IStatement dt) { return dt; }
            return new Statement_Halt();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Statement_Halt;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_75(4279L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4280L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4297L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4287L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4283L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4294L, 12));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4304L, "DAST.Statement.Halt");
            return s;
        }
    }
    public class Statement_Print : Statement
    {
        public readonly DAST._IExpression _a0;
        public Statement_Print(DAST._IExpression _a0) : base()
        {
            this._a0 = _a0;
        }
        public override _IStatement DowncastClone()
        {
            if (this is _IStatement dt) { return dt; }
            return new Statement_Print(_a0);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Statement_Print;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(4306L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_76(4305L, oth, null), () => object.Equals(this._a0, oth._a0));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4312L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4329L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4319L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4315L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4326L, 13));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4347L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4340L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4336L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4354L, "DAST.Statement.Print");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4355L, "(");
            s += Dafny.Helpers.ToString(this._a0);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4356L, ")");
            return s;
        }
    }

    public interface _IAssignLhs
    {
        bool is_Ident { get; }
        bool is_Select { get; }
        bool is_Index { get; }
        Dafny.ISequence<Dafny.Rune> dtor_Ident_a0 { get; }
        DAST._IExpression dtor_expr { get; }
        Dafny.ISequence<Dafny.Rune> dtor_field { get; }
        Dafny.ISequence<DAST._IExpression> dtor_indices { get; }

        _IAssignLhs DowncastClone();
    }
    public abstract class AssignLhs : _IAssignLhs
    {
        public AssignLhs()
        {
        }
        private static readonly DAST._IAssignLhs theDefault = create_Ident(Dafny.Sequence<Dafny.Rune>.Empty);
        public static DAST._IAssignLhs Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST._IAssignLhs> _TYPE = new Dafny.TypeDescriptor<DAST._IAssignLhs>(DAST.AssignLhs.Default());
        public static Dafny.TypeDescriptor<DAST._IAssignLhs> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IAssignLhs create_Ident(Dafny.ISequence<Dafny.Rune> _a0)
        {
            return new AssignLhs_Ident(_a0);
        }
        public static _IAssignLhs create_Select(DAST._IExpression expr, Dafny.ISequence<Dafny.Rune> field)
        {
            return new AssignLhs_Select(expr, field);
        }
        public static _IAssignLhs create_Index(DAST._IExpression expr, Dafny.ISequence<DAST._IExpression> indices)
        {
            return new AssignLhs_Index(expr, indices);
        }
        public bool is_Ident
        {
            get { return this is AssignLhs_Ident; }
        }

        public bool is_Select
        {
            get { return this is AssignLhs_Select; }
        }

        public bool is_Index
        {
            get { return this is AssignLhs_Index; }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_Ident_a0
        {
            get
            {
                var d = this;
                return ((AssignLhs_Ident)d)._a0;
            }
        }

        public DAST._IExpression dtor_expr
        {
            get
            {
                var d = this;
                if (d is AssignLhs_Select) { return ((AssignLhs_Select)d)._expr; }
                return ((AssignLhs_Index)d)._expr;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_field
        {
            get
            {
                var d = this;
                return ((AssignLhs_Select)d)._field;
            }
        }

        public Dafny.ISequence<DAST._IExpression> dtor_indices
        {
            get
            {
                var d = this;
                return ((AssignLhs_Index)d)._indices;
            }
        }

        public abstract _IAssignLhs DowncastClone();
    }
    public class AssignLhs_Ident : AssignLhs
    {
        public readonly Dafny.ISequence<Dafny.Rune> _a0;
        public AssignLhs_Ident(Dafny.ISequence<Dafny.Rune> _a0) : base()
        {
            this._a0 = _a0;
        }
        public override _IAssignLhs DowncastClone()
        {
            if (this is _IAssignLhs dt) { return dt; }
            return new AssignLhs_Ident(_a0);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.AssignLhs_Ident;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(4358L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_77(4357L, oth, null), () => object.Equals(this._a0, oth._a0));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4364L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4381L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4371L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4367L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4378L, 0));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4399L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4392L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4388L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4406L, "DAST.AssignLhs.Ident");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4407L, "(");
            s += Dafny.Helpers.ToString(this._a0);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4408L, ")");
            return s;
        }
    }
    public class AssignLhs_Select : AssignLhs
    {
        public readonly DAST._IExpression _expr;
        public readonly Dafny.ISequence<Dafny.Rune> _field;
        public AssignLhs_Select(DAST._IExpression expr, Dafny.ISequence<Dafny.Rune> field) : base()
        {
            this._expr = expr;
            this._field = field;
        }
        public override _IAssignLhs DowncastClone()
        {
            if (this is _IAssignLhs dt) { return dt; }
            return new AssignLhs_Select(_expr, _field);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.AssignLhs_Select;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(4416L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(4410L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_78(4409L, oth, null), () => object.Equals(this._expr, oth._expr)), () => object.Equals(this._field, oth._field));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4422L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4439L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4429L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4425L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4436L, 1));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4457L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4450L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4446L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._expr)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4475L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4468L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4464L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._field)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4482L, "DAST.AssignLhs.Select");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4483L, "(");
            s += Dafny.Helpers.ToString(this._expr);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4484L, ", ");
            s += this._field.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(4485L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4486L, ")");
            return s;
        }
    }
    public class AssignLhs_Index : AssignLhs
    {
        public readonly DAST._IExpression _expr;
        public readonly Dafny.ISequence<DAST._IExpression> _indices;
        public AssignLhs_Index(DAST._IExpression expr, Dafny.ISequence<DAST._IExpression> indices) : base()
        {
            this._expr = expr;
            this._indices = indices;
        }
        public override _IAssignLhs DowncastClone()
        {
            if (this is _IAssignLhs dt) { return dt; }
            return new AssignLhs_Index(_expr, _indices);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.AssignLhs_Index;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(4494L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(4488L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_79(4487L, oth, null), () => object.Equals(this._expr, oth._expr)), () => object.Equals(this._indices, oth._indices));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4500L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4517L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4507L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4503L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4514L, 2));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4535L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4528L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4524L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._expr)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4553L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4546L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4542L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._indices)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4560L, "DAST.AssignLhs.Index");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4561L, "(");
            s += Dafny.Helpers.ToString(this._expr);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4562L, ", ");
            s += Dafny.Helpers.ToString(this._indices);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4563L, ")");
            return s;
        }
    }

    public interface _ICollKind
    {
        bool is_Seq { get; }
        bool is_Array { get; }
        bool is_Map { get; }

        _ICollKind DowncastClone();
    }
    public abstract class CollKind : _ICollKind
    {
        public CollKind()
        {
        }
        private static readonly DAST._ICollKind theDefault = create_Seq();
        public static DAST._ICollKind Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST._ICollKind> _TYPE = new Dafny.TypeDescriptor<DAST._ICollKind>(DAST.CollKind.Default());
        public static Dafny.TypeDescriptor<DAST._ICollKind> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _ICollKind create_Seq()
        {
            return new CollKind_Seq();
        }
        public static _ICollKind create_Array()
        {
            return new CollKind_Array();
        }
        public static _ICollKind create_Map()
        {
            return new CollKind_Map();
        }
        public bool is_Seq
        {
            get { return this is CollKind_Seq; }
        }

        public bool is_Array
        {
            get { return this is CollKind_Array; }
        }

        public bool is_Map
        {
            get { return this is CollKind_Map; }
        }

        public static System.Collections.Generic.IEnumerable<_ICollKind> AllSingletonConstructors
        {
            get
            {
                yield return CollKind.create_Seq();
                yield return CollKind.create_Array();
                yield return CollKind.create_Map();
            }
        }

        public abstract _ICollKind DowncastClone();
    }
    public class CollKind_Seq : CollKind
    {
        public CollKind_Seq() : base()
        {
        }
        public override _ICollKind DowncastClone()
        {
            if (this is _ICollKind dt) { return dt; }
            return new CollKind_Seq();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.CollKind_Seq;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_80(4564L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4565L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4582L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4572L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4568L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4579L, 0));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4589L, "DAST.CollKind.Seq");
            return s;
        }
    }
    public class CollKind_Array : CollKind
    {
        public CollKind_Array() : base()
        {
        }
        public override _ICollKind DowncastClone()
        {
            if (this is _ICollKind dt) { return dt; }
            return new CollKind_Array();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.CollKind_Array;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_81(4590L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4591L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4608L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4598L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4594L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4605L, 1));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4615L, "DAST.CollKind.Array");
            return s;
        }
    }
    public class CollKind_Map : CollKind
    {
        public CollKind_Map() : base()
        {
        }
        public override _ICollKind DowncastClone()
        {
            if (this is _ICollKind dt) { return dt; }
            return new CollKind_Map();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.CollKind_Map;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_82(4616L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4617L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4634L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4624L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4620L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4631L, 2));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4641L, "DAST.CollKind.Map");
            return s;
        }
    }

    public interface _IBinOp
    {
        bool is_Eq { get; }
        bool is_Div { get; }
        bool is_EuclidianDiv { get; }
        bool is_Mod { get; }
        bool is_EuclidianMod { get; }
        bool is_Lt { get; }
        bool is_LtChar { get; }
        bool is_Plus { get; }
        bool is_Minus { get; }
        bool is_Times { get; }
        bool is_BitwiseAnd { get; }
        bool is_BitwiseOr { get; }
        bool is_BitwiseXor { get; }
        bool is_BitwiseShiftRight { get; }
        bool is_BitwiseShiftLeft { get; }
        bool is_And { get; }
        bool is_Or { get; }
        bool is_In { get; }
        bool is_SeqProperPrefix { get; }
        bool is_SeqPrefix { get; }
        bool is_SetMerge { get; }
        bool is_SetSubtraction { get; }
        bool is_SetIntersection { get; }
        bool is_Subset { get; }
        bool is_ProperSubset { get; }
        bool is_SetDisjoint { get; }
        bool is_MapMerge { get; }
        bool is_MapSubtraction { get; }
        bool is_MultisetMerge { get; }
        bool is_MultisetSubtraction { get; }
        bool is_MultisetIntersection { get; }
        bool is_Submultiset { get; }
        bool is_ProperSubmultiset { get; }
        bool is_MultisetDisjoint { get; }
        bool is_Concat { get; }
        bool is_Passthrough { get; }
        bool dtor_referential { get; }
        bool dtor_nullable { get; }
        Dafny.ISequence<Dafny.Rune> dtor_Passthrough_a0 { get; }

        _IBinOp DowncastClone();
    }
    public abstract class BinOp : _IBinOp
    {
        public BinOp()
        {
        }
        private static readonly DAST._IBinOp theDefault = create_Eq(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(4642L, false), MutateCSharp.Schemata274.ReplaceBooleanConstant_7(4643L, false));
        public static DAST._IBinOp Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST._IBinOp> _TYPE = new Dafny.TypeDescriptor<DAST._IBinOp>(DAST.BinOp.Default());
        public static Dafny.TypeDescriptor<DAST._IBinOp> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IBinOp create_Eq(bool referential, bool nullable)
        {
            return new BinOp_Eq(referential, nullable);
        }
        public static _IBinOp create_Div()
        {
            return new BinOp_Div();
        }
        public static _IBinOp create_EuclidianDiv()
        {
            return new BinOp_EuclidianDiv();
        }
        public static _IBinOp create_Mod()
        {
            return new BinOp_Mod();
        }
        public static _IBinOp create_EuclidianMod()
        {
            return new BinOp_EuclidianMod();
        }
        public static _IBinOp create_Lt()
        {
            return new BinOp_Lt();
        }
        public static _IBinOp create_LtChar()
        {
            return new BinOp_LtChar();
        }
        public static _IBinOp create_Plus()
        {
            return new BinOp_Plus();
        }
        public static _IBinOp create_Minus()
        {
            return new BinOp_Minus();
        }
        public static _IBinOp create_Times()
        {
            return new BinOp_Times();
        }
        public static _IBinOp create_BitwiseAnd()
        {
            return new BinOp_BitwiseAnd();
        }
        public static _IBinOp create_BitwiseOr()
        {
            return new BinOp_BitwiseOr();
        }
        public static _IBinOp create_BitwiseXor()
        {
            return new BinOp_BitwiseXor();
        }
        public static _IBinOp create_BitwiseShiftRight()
        {
            return new BinOp_BitwiseShiftRight();
        }
        public static _IBinOp create_BitwiseShiftLeft()
        {
            return new BinOp_BitwiseShiftLeft();
        }
        public static _IBinOp create_And()
        {
            return new BinOp_And();
        }
        public static _IBinOp create_Or()
        {
            return new BinOp_Or();
        }
        public static _IBinOp create_In()
        {
            return new BinOp_In();
        }
        public static _IBinOp create_SeqProperPrefix()
        {
            return new BinOp_SeqProperPrefix();
        }
        public static _IBinOp create_SeqPrefix()
        {
            return new BinOp_SeqPrefix();
        }
        public static _IBinOp create_SetMerge()
        {
            return new BinOp_SetMerge();
        }
        public static _IBinOp create_SetSubtraction()
        {
            return new BinOp_SetSubtraction();
        }
        public static _IBinOp create_SetIntersection()
        {
            return new BinOp_SetIntersection();
        }
        public static _IBinOp create_Subset()
        {
            return new BinOp_Subset();
        }
        public static _IBinOp create_ProperSubset()
        {
            return new BinOp_ProperSubset();
        }
        public static _IBinOp create_SetDisjoint()
        {
            return new BinOp_SetDisjoint();
        }
        public static _IBinOp create_MapMerge()
        {
            return new BinOp_MapMerge();
        }
        public static _IBinOp create_MapSubtraction()
        {
            return new BinOp_MapSubtraction();
        }
        public static _IBinOp create_MultisetMerge()
        {
            return new BinOp_MultisetMerge();
        }
        public static _IBinOp create_MultisetSubtraction()
        {
            return new BinOp_MultisetSubtraction();
        }
        public static _IBinOp create_MultisetIntersection()
        {
            return new BinOp_MultisetIntersection();
        }
        public static _IBinOp create_Submultiset()
        {
            return new BinOp_Submultiset();
        }
        public static _IBinOp create_ProperSubmultiset()
        {
            return new BinOp_ProperSubmultiset();
        }
        public static _IBinOp create_MultisetDisjoint()
        {
            return new BinOp_MultisetDisjoint();
        }
        public static _IBinOp create_Concat()
        {
            return new BinOp_Concat();
        }
        public static _IBinOp create_Passthrough(Dafny.ISequence<Dafny.Rune> _a0)
        {
            return new BinOp_Passthrough(_a0);
        }
        public bool is_Eq
        {
            get { return this is BinOp_Eq; }
        }

        public bool is_Div
        {
            get { return this is BinOp_Div; }
        }

        public bool is_EuclidianDiv
        {
            get { return this is BinOp_EuclidianDiv; }
        }

        public bool is_Mod
        {
            get { return this is BinOp_Mod; }
        }

        public bool is_EuclidianMod
        {
            get { return this is BinOp_EuclidianMod; }
        }

        public bool is_Lt
        {
            get { return this is BinOp_Lt; }
        }

        public bool is_LtChar
        {
            get { return this is BinOp_LtChar; }
        }

        public bool is_Plus
        {
            get { return this is BinOp_Plus; }
        }

        public bool is_Minus
        {
            get { return this is BinOp_Minus; }
        }

        public bool is_Times
        {
            get { return this is BinOp_Times; }
        }

        public bool is_BitwiseAnd
        {
            get { return this is BinOp_BitwiseAnd; }
        }

        public bool is_BitwiseOr
        {
            get { return this is BinOp_BitwiseOr; }
        }

        public bool is_BitwiseXor
        {
            get { return this is BinOp_BitwiseXor; }
        }

        public bool is_BitwiseShiftRight
        {
            get { return this is BinOp_BitwiseShiftRight; }
        }

        public bool is_BitwiseShiftLeft
        {
            get { return this is BinOp_BitwiseShiftLeft; }
        }

        public bool is_And
        {
            get { return this is BinOp_And; }
        }

        public bool is_Or
        {
            get { return this is BinOp_Or; }
        }

        public bool is_In
        {
            get { return this is BinOp_In; }
        }

        public bool is_SeqProperPrefix
        {
            get { return this is BinOp_SeqProperPrefix; }
        }

        public bool is_SeqPrefix
        {
            get { return this is BinOp_SeqPrefix; }
        }

        public bool is_SetMerge
        {
            get { return this is BinOp_SetMerge; }
        }

        public bool is_SetSubtraction
        {
            get { return this is BinOp_SetSubtraction; }
        }

        public bool is_SetIntersection
        {
            get { return this is BinOp_SetIntersection; }
        }

        public bool is_Subset
        {
            get { return this is BinOp_Subset; }
        }

        public bool is_ProperSubset
        {
            get { return this is BinOp_ProperSubset; }
        }

        public bool is_SetDisjoint
        {
            get { return this is BinOp_SetDisjoint; }
        }

        public bool is_MapMerge
        {
            get { return this is BinOp_MapMerge; }
        }

        public bool is_MapSubtraction
        {
            get { return this is BinOp_MapSubtraction; }
        }

        public bool is_MultisetMerge
        {
            get { return this is BinOp_MultisetMerge; }
        }

        public bool is_MultisetSubtraction
        {
            get { return this is BinOp_MultisetSubtraction; }
        }

        public bool is_MultisetIntersection
        {
            get { return this is BinOp_MultisetIntersection; }
        }

        public bool is_Submultiset
        {
            get { return this is BinOp_Submultiset; }
        }

        public bool is_ProperSubmultiset
        {
            get { return this is BinOp_ProperSubmultiset; }
        }

        public bool is_MultisetDisjoint
        {
            get { return this is BinOp_MultisetDisjoint; }
        }

        public bool is_Concat
        {
            get { return this is BinOp_Concat; }
        }

        public bool is_Passthrough
        {
            get { return this is BinOp_Passthrough; }
        }

        public bool dtor_referential
        {
            get
            {
                var d = this;
                return ((BinOp_Eq)d)._referential;
            }
        }

        public bool dtor_nullable
        {
            get
            {
                var d = this;
                return ((BinOp_Eq)d)._nullable;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_Passthrough_a0
        {
            get
            {
                var d = this;
                return ((BinOp_Passthrough)d)._a0;
            }
        }

        public abstract _IBinOp DowncastClone();
    }
    public class BinOp_Eq : BinOp
    {
        public readonly bool _referential;
        public readonly bool _nullable;
        public BinOp_Eq(bool referential, bool nullable) : base()
        {
            this._referential = referential;
            this._nullable = nullable;
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_Eq(_referential, _nullable);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_Eq;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(4663L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(4651L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_83(4644L, oth, null), () => MutateCSharp.Schemata274.ReplaceBinExprOp_2(4645L, () => this._referential, () => oth._referential)), () => MutateCSharp.Schemata274.ReplaceBinExprOp_2(4657L, () => this._nullable, () => oth._nullable));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4669L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4686L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4676L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4672L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4683L, 0));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4704L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4697L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4693L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._referential)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4722L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4715L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4711L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._nullable)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4729L, "DAST.BinOp.Eq");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4730L, "(");
            s += Dafny.Helpers.ToString(this._referential);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4731L, ", ");
            s += Dafny.Helpers.ToString(this._nullable);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(4732L, ")");
            return s;
        }
    }
    public class BinOp_Div : BinOp
    {
        public BinOp_Div() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_Div();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_Div;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_84(4733L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4734L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4751L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4741L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4737L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4748L, 1));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4758L, "DAST.BinOp.Div");
            return s;
        }
    }
    public class BinOp_EuclidianDiv : BinOp
    {
        public BinOp_EuclidianDiv() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_EuclidianDiv();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_EuclidianDiv;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_85(4759L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4760L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4777L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4767L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4763L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4774L, 2));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4784L, "DAST.BinOp.EuclidianDiv");
            return s;
        }
    }
    public class BinOp_Mod : BinOp
    {
        public BinOp_Mod() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_Mod();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_Mod;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_86(4785L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4786L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4803L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4793L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4789L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4800L, 3));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4810L, "DAST.BinOp.Mod");
            return s;
        }
    }
    public class BinOp_EuclidianMod : BinOp
    {
        public BinOp_EuclidianMod() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_EuclidianMod();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_EuclidianMod;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_87(4811L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4812L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4829L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4819L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4815L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4826L, 4));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4836L, "DAST.BinOp.EuclidianMod");
            return s;
        }
    }
    public class BinOp_Lt : BinOp
    {
        public BinOp_Lt() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_Lt();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_Lt;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_88(4837L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4838L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4855L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4845L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4841L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4852L, 5));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4862L, "DAST.BinOp.Lt");
            return s;
        }
    }
    public class BinOp_LtChar : BinOp
    {
        public BinOp_LtChar() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_LtChar();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_LtChar;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_89(4863L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4864L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4881L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4871L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4867L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4878L, 6));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4888L, "DAST.BinOp.LtChar");
            return s;
        }
    }
    public class BinOp_Plus : BinOp
    {
        public BinOp_Plus() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_Plus();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_Plus;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_90(4889L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4890L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4907L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4897L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4893L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4904L, 7));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4914L, "DAST.BinOp.Plus");
            return s;
        }
    }
    public class BinOp_Minus : BinOp
    {
        public BinOp_Minus() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_Minus();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_Minus;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_91(4915L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4916L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4933L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4923L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4919L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4930L, 8));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4940L, "DAST.BinOp.Minus");
            return s;
        }
    }
    public class BinOp_Times : BinOp
    {
        public BinOp_Times() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_Times();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_Times;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_92(4941L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4942L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4959L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4949L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4945L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4956L, 9));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4966L, "DAST.BinOp.Times");
            return s;
        }
    }
    public class BinOp_BitwiseAnd : BinOp
    {
        public BinOp_BitwiseAnd() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_BitwiseAnd();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_BitwiseAnd;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_93(4967L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4968L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(4985L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(4975L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4971L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(4982L, 10));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(4992L, "DAST.BinOp.BitwiseAnd");
            return s;
        }
    }
    public class BinOp_BitwiseOr : BinOp
    {
        public BinOp_BitwiseOr() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_BitwiseOr();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_BitwiseOr;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_94(4993L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(4994L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5011L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5001L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(4997L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5008L, 11));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5018L, "DAST.BinOp.BitwiseOr");
            return s;
        }
    }
    public class BinOp_BitwiseXor : BinOp
    {
        public BinOp_BitwiseXor() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_BitwiseXor();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_BitwiseXor;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_95(5019L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5020L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5037L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5027L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5023L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5034L, 12));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5044L, "DAST.BinOp.BitwiseXor");
            return s;
        }
    }
    public class BinOp_BitwiseShiftRight : BinOp
    {
        public BinOp_BitwiseShiftRight() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_BitwiseShiftRight();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_BitwiseShiftRight;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_96(5045L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5046L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5063L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5053L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5049L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5060L, 13));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5070L, "DAST.BinOp.BitwiseShiftRight");
            return s;
        }
    }
    public class BinOp_BitwiseShiftLeft : BinOp
    {
        public BinOp_BitwiseShiftLeft() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_BitwiseShiftLeft();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_BitwiseShiftLeft;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_97(5071L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5072L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5089L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5079L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5075L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5086L, 14));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5096L, "DAST.BinOp.BitwiseShiftLeft");
            return s;
        }
    }
    public class BinOp_And : BinOp
    {
        public BinOp_And() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_And();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_And;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_98(5097L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5098L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5115L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5105L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5101L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5112L, 15));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5122L, "DAST.BinOp.And");
            return s;
        }
    }
    public class BinOp_Or : BinOp
    {
        public BinOp_Or() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_Or();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_Or;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_99(5123L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5124L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5141L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5131L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5127L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5138L, 16));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5148L, "DAST.BinOp.Or");
            return s;
        }
    }
    public class BinOp_In : BinOp
    {
        public BinOp_In() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_In();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_In;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_100(5149L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5150L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5167L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5157L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5153L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5164L, 17));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5174L, "DAST.BinOp.In");
            return s;
        }
    }
    public class BinOp_SeqProperPrefix : BinOp
    {
        public BinOp_SeqProperPrefix() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_SeqProperPrefix();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_SeqProperPrefix;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_101(5175L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5176L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5193L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5183L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5179L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5190L, 18));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5200L, "DAST.BinOp.SeqProperPrefix");
            return s;
        }
    }
    public class BinOp_SeqPrefix : BinOp
    {
        public BinOp_SeqPrefix() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_SeqPrefix();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_SeqPrefix;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_102(5201L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5202L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5219L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5209L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5205L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5216L, 19));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5226L, "DAST.BinOp.SeqPrefix");
            return s;
        }
    }
    public class BinOp_SetMerge : BinOp
    {
        public BinOp_SetMerge() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_SetMerge();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_SetMerge;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_103(5227L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5228L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5245L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5235L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5231L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5242L, 20));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5252L, "DAST.BinOp.SetMerge");
            return s;
        }
    }
    public class BinOp_SetSubtraction : BinOp
    {
        public BinOp_SetSubtraction() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_SetSubtraction();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_SetSubtraction;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_104(5253L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5254L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5271L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5261L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5257L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5268L, 21));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5278L, "DAST.BinOp.SetSubtraction");
            return s;
        }
    }
    public class BinOp_SetIntersection : BinOp
    {
        public BinOp_SetIntersection() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_SetIntersection();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_SetIntersection;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_105(5279L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5280L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5297L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5287L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5283L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5294L, 22));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5304L, "DAST.BinOp.SetIntersection");
            return s;
        }
    }
    public class BinOp_Subset : BinOp
    {
        public BinOp_Subset() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_Subset();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_Subset;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_106(5305L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5306L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5323L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5313L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5309L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5320L, 23));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5330L, "DAST.BinOp.Subset");
            return s;
        }
    }
    public class BinOp_ProperSubset : BinOp
    {
        public BinOp_ProperSubset() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_ProperSubset();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_ProperSubset;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_107(5331L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5332L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5349L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5339L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5335L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5346L, 24));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5356L, "DAST.BinOp.ProperSubset");
            return s;
        }
    }
    public class BinOp_SetDisjoint : BinOp
    {
        public BinOp_SetDisjoint() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_SetDisjoint();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_SetDisjoint;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_108(5357L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5358L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5375L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5365L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5361L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5372L, 25));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5382L, "DAST.BinOp.SetDisjoint");
            return s;
        }
    }
    public class BinOp_MapMerge : BinOp
    {
        public BinOp_MapMerge() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_MapMerge();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_MapMerge;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_109(5383L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5384L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5401L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5391L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5387L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5398L, 26));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5408L, "DAST.BinOp.MapMerge");
            return s;
        }
    }
    public class BinOp_MapSubtraction : BinOp
    {
        public BinOp_MapSubtraction() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_MapSubtraction();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_MapSubtraction;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_110(5409L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5410L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5427L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5417L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5413L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5424L, 27));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5434L, "DAST.BinOp.MapSubtraction");
            return s;
        }
    }
    public class BinOp_MultisetMerge : BinOp
    {
        public BinOp_MultisetMerge() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_MultisetMerge();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_MultisetMerge;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_111(5435L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5436L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5453L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5443L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5439L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5450L, 28));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5460L, "DAST.BinOp.MultisetMerge");
            return s;
        }
    }
    public class BinOp_MultisetSubtraction : BinOp
    {
        public BinOp_MultisetSubtraction() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_MultisetSubtraction();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_MultisetSubtraction;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_112(5461L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5462L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5479L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5469L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5465L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5476L, 29));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5486L, "DAST.BinOp.MultisetSubtraction");
            return s;
        }
    }
    public class BinOp_MultisetIntersection : BinOp
    {
        public BinOp_MultisetIntersection() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_MultisetIntersection();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_MultisetIntersection;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_113(5487L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5488L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5505L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5495L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5491L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5502L, 30));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5512L, "DAST.BinOp.MultisetIntersection");
            return s;
        }
    }
    public class BinOp_Submultiset : BinOp
    {
        public BinOp_Submultiset() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_Submultiset();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_Submultiset;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_114(5513L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5514L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5531L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5521L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5517L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5528L, 31));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5538L, "DAST.BinOp.Submultiset");
            return s;
        }
    }
    public class BinOp_ProperSubmultiset : BinOp
    {
        public BinOp_ProperSubmultiset() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_ProperSubmultiset();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_ProperSubmultiset;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_115(5539L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5540L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5557L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5547L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5543L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5554L, 32));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5564L, "DAST.BinOp.ProperSubmultiset");
            return s;
        }
    }
    public class BinOp_MultisetDisjoint : BinOp
    {
        public BinOp_MultisetDisjoint() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_MultisetDisjoint();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_MultisetDisjoint;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_116(5565L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5566L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5583L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5573L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5569L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5580L, 33));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5590L, "DAST.BinOp.MultisetDisjoint");
            return s;
        }
    }
    public class BinOp_Concat : BinOp
    {
        public BinOp_Concat() : base()
        {
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_Concat();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_Concat;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_117(5591L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5592L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5609L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5599L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5595L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5606L, 34));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5616L, "DAST.BinOp.Concat");
            return s;
        }
    }
    public class BinOp_Passthrough : BinOp
    {
        public readonly Dafny.ISequence<Dafny.Rune> _a0;
        public BinOp_Passthrough(Dafny.ISequence<Dafny.Rune> _a0) : base()
        {
            this._a0 = _a0;
        }
        public override _IBinOp DowncastClone()
        {
            if (this is _IBinOp dt) { return dt; }
            return new BinOp_Passthrough(_a0);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.BinOp_Passthrough;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(5618L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_118(5617L, oth, null), () => object.Equals(this._a0, oth._a0));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5624L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5641L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5631L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5627L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5638L, 35));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5659L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5652L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5648L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5666L, "DAST.BinOp.Passthrough");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(5667L, "(");
            s += this._a0.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(5668L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(5669L, ")");
            return s;
        }
    }

    public interface _IExpression
    {
        bool is_Literal { get; }
        bool is_Ident { get; }
        bool is_Companion { get; }
        bool is_Tuple { get; }
        bool is_New { get; }
        bool is_NewArray { get; }
        bool is_DatatypeValue { get; }
        bool is_Convert { get; }
        bool is_SeqConstruct { get; }
        bool is_SeqValue { get; }
        bool is_SetValue { get; }
        bool is_MultisetValue { get; }
        bool is_MapValue { get; }
        bool is_MapBuilder { get; }
        bool is_SeqUpdate { get; }
        bool is_MapUpdate { get; }
        bool is_SetBuilder { get; }
        bool is_ToMultiset { get; }
        bool is_This { get; }
        bool is_Ite { get; }
        bool is_UnOp { get; }
        bool is_BinOp { get; }
        bool is_ArrayLen { get; }
        bool is_MapKeys { get; }
        bool is_MapValues { get; }
        bool is_Select { get; }
        bool is_SelectFn { get; }
        bool is_Index { get; }
        bool is_IndexRange { get; }
        bool is_TupleSelect { get; }
        bool is_Call { get; }
        bool is_Lambda { get; }
        bool is_BetaRedex { get; }
        bool is_IIFE { get; }
        bool is_Apply { get; }
        bool is_TypeTest { get; }
        bool is_InitializationValue { get; }
        bool is_BoolBoundedPool { get; }
        bool is_SetBoundedPool { get; }
        bool is_SeqBoundedPool { get; }
        bool is_IntRange { get; }
        DAST._ILiteral dtor_Literal_a0 { get; }
        Dafny.ISequence<Dafny.Rune> dtor_Ident_a0 { get; }
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_Companion_a0 { get; }
        Dafny.ISequence<DAST._IExpression> dtor_Tuple_a0 { get; }
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_path { get; }
        Dafny.ISequence<DAST._IType> dtor_typeArgs { get; }
        Dafny.ISequence<DAST._IExpression> dtor_args { get; }
        Dafny.ISequence<DAST._IExpression> dtor_dims { get; }
        DAST._IType dtor_typ { get; }
        Dafny.ISequence<Dafny.Rune> dtor_variant { get; }
        bool dtor_isCo { get; }
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> dtor_contents { get; }
        DAST._IExpression dtor_value { get; }
        DAST._IType dtor_from { get; }
        DAST._IExpression dtor_length { get; }
        DAST._IExpression dtor_elem { get; }
        Dafny.ISequence<DAST._IExpression> dtor_elements { get; }
        Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> dtor_mapElems { get; }
        DAST._IType dtor_keyType { get; }
        DAST._IType dtor_valueType { get; }
        DAST._IExpression dtor_expr { get; }
        DAST._IExpression dtor_indexExpr { get; }
        DAST._IType dtor_elemType { get; }
        DAST._IExpression dtor_ToMultiset_a0 { get; }
        DAST._IExpression dtor_cond { get; }
        DAST._IExpression dtor_thn { get; }
        DAST._IExpression dtor_els { get; }
        DAST._IUnaryOp dtor_unOp { get; }
        DAST.Format._IUnaryOpFormat dtor_format1 { get; }
        DAST._IBinOp dtor_op { get; }
        DAST._IExpression dtor_left { get; }
        DAST._IExpression dtor_right { get; }
        DAST.Format._IBinaryOpFormat dtor_format2 { get; }
        BigInteger dtor_dim { get; }
        Dafny.ISequence<Dafny.Rune> dtor_field { get; }
        bool dtor_isConstant { get; }
        bool dtor_onDatatype { get; }
        bool dtor_isStatic { get; }
        BigInteger dtor_arity { get; }
        DAST._ICollKind dtor_collKind { get; }
        Dafny.ISequence<DAST._IExpression> dtor_indices { get; }
        bool dtor_isArray { get; }
        Std.Wrappers._IOption<DAST._IExpression> dtor_low { get; }
        Std.Wrappers._IOption<DAST._IExpression> dtor_high { get; }
        BigInteger dtor_index { get; }
        DAST._IExpression dtor_on { get; }
        DAST._ICallName dtor_callName { get; }
        Dafny.ISequence<DAST._IFormal> dtor_params { get; }
        DAST._IType dtor_retType { get; }
        Dafny.ISequence<DAST._IStatement> dtor_body { get; }
        Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> dtor_values { get; }
        Dafny.ISequence<Dafny.Rune> dtor_name { get; }
        DAST._IExpression dtor_iifeBody { get; }
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_dType { get; }
        DAST._IExpression dtor_of { get; }
        bool dtor_includeDuplicates { get; }
        DAST._IExpression dtor_lo { get; }
        DAST._IExpression dtor_hi { get; }

        _IExpression DowncastClone();
    }
    public abstract class Expression : _IExpression
    {
        public Expression()
        {
        }
        private static readonly DAST._IExpression theDefault = create_Literal(DAST.Literal.Default());
        public static DAST._IExpression Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST._IExpression> _TYPE = new Dafny.TypeDescriptor<DAST._IExpression>(DAST.Expression.Default());
        public static Dafny.TypeDescriptor<DAST._IExpression> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IExpression create_Literal(DAST._ILiteral _a0)
        {
            return new Expression_Literal(_a0);
        }
        public static _IExpression create_Ident(Dafny.ISequence<Dafny.Rune> _a0)
        {
            return new Expression_Ident(_a0);
        }
        public static _IExpression create_Companion(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _a0)
        {
            return new Expression_Companion(_a0);
        }
        public static _IExpression create_Tuple(Dafny.ISequence<DAST._IExpression> _a0)
        {
            return new Expression_Tuple(_a0);
        }
        public static _IExpression create_New(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> path, Dafny.ISequence<DAST._IType> typeArgs, Dafny.ISequence<DAST._IExpression> args)
        {
            return new Expression_New(path, typeArgs, args);
        }
        public static _IExpression create_NewArray(Dafny.ISequence<DAST._IExpression> dims, DAST._IType typ)
        {
            return new Expression_NewArray(dims, typ);
        }
        public static _IExpression create_DatatypeValue(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> path, Dafny.ISequence<DAST._IType> typeArgs, Dafny.ISequence<Dafny.Rune> variant, bool isCo, Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> contents)
        {
            return new Expression_DatatypeValue(path, typeArgs, variant, isCo, contents);
        }
        public static _IExpression create_Convert(DAST._IExpression @value, DAST._IType @from, DAST._IType typ)
        {
            return new Expression_Convert(@value, @from, typ);
        }
        public static _IExpression create_SeqConstruct(DAST._IExpression length, DAST._IExpression elem)
        {
            return new Expression_SeqConstruct(length, elem);
        }
        public static _IExpression create_SeqValue(Dafny.ISequence<DAST._IExpression> elements, DAST._IType typ)
        {
            return new Expression_SeqValue(elements, typ);
        }
        public static _IExpression create_SetValue(Dafny.ISequence<DAST._IExpression> elements)
        {
            return new Expression_SetValue(elements);
        }
        public static _IExpression create_MultisetValue(Dafny.ISequence<DAST._IExpression> elements)
        {
            return new Expression_MultisetValue(elements);
        }
        public static _IExpression create_MapValue(Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> mapElems)
        {
            return new Expression_MapValue(mapElems);
        }
        public static _IExpression create_MapBuilder(DAST._IType keyType, DAST._IType valueType)
        {
            return new Expression_MapBuilder(keyType, valueType);
        }
        public static _IExpression create_SeqUpdate(DAST._IExpression expr, DAST._IExpression indexExpr, DAST._IExpression @value)
        {
            return new Expression_SeqUpdate(expr, indexExpr, @value);
        }
        public static _IExpression create_MapUpdate(DAST._IExpression expr, DAST._IExpression indexExpr, DAST._IExpression @value)
        {
            return new Expression_MapUpdate(expr, indexExpr, @value);
        }
        public static _IExpression create_SetBuilder(DAST._IType elemType)
        {
            return new Expression_SetBuilder(elemType);
        }
        public static _IExpression create_ToMultiset(DAST._IExpression _a0)
        {
            return new Expression_ToMultiset(_a0);
        }
        public static _IExpression create_This()
        {
            return new Expression_This();
        }
        public static _IExpression create_Ite(DAST._IExpression cond, DAST._IExpression thn, DAST._IExpression els)
        {
            return new Expression_Ite(cond, thn, els);
        }
        public static _IExpression create_UnOp(DAST._IUnaryOp unOp, DAST._IExpression expr, DAST.Format._IUnaryOpFormat format1)
        {
            return new Expression_UnOp(unOp, expr, format1);
        }
        public static _IExpression create_BinOp(DAST._IBinOp op, DAST._IExpression left, DAST._IExpression right, DAST.Format._IBinaryOpFormat format2)
        {
            return new Expression_BinOp(op, left, right, format2);
        }
        public static _IExpression create_ArrayLen(DAST._IExpression expr, BigInteger dim)
        {
            return new Expression_ArrayLen(expr, dim);
        }
        public static _IExpression create_MapKeys(DAST._IExpression expr)
        {
            return new Expression_MapKeys(expr);
        }
        public static _IExpression create_MapValues(DAST._IExpression expr)
        {
            return new Expression_MapValues(expr);
        }
        public static _IExpression create_Select(DAST._IExpression expr, Dafny.ISequence<Dafny.Rune> field, bool isConstant, bool onDatatype)
        {
            return new Expression_Select(expr, field, isConstant, onDatatype);
        }
        public static _IExpression create_SelectFn(DAST._IExpression expr, Dafny.ISequence<Dafny.Rune> field, bool onDatatype, bool isStatic, BigInteger arity)
        {
            return new Expression_SelectFn(expr, field, onDatatype, isStatic, arity);
        }
        public static _IExpression create_Index(DAST._IExpression expr, DAST._ICollKind collKind, Dafny.ISequence<DAST._IExpression> indices)
        {
            return new Expression_Index(expr, collKind, indices);
        }
        public static _IExpression create_IndexRange(DAST._IExpression expr, bool isArray, Std.Wrappers._IOption<DAST._IExpression> low, Std.Wrappers._IOption<DAST._IExpression> high)
        {
            return new Expression_IndexRange(expr, isArray, low, high);
        }
        public static _IExpression create_TupleSelect(DAST._IExpression expr, BigInteger index)
        {
            return new Expression_TupleSelect(expr, index);
        }
        public static _IExpression create_Call(DAST._IExpression @on, DAST._ICallName callName, Dafny.ISequence<DAST._IType> typeArgs, Dafny.ISequence<DAST._IExpression> args)
        {
            return new Expression_Call(@on, callName, typeArgs, args);
        }
        public static _IExpression create_Lambda(Dafny.ISequence<DAST._IFormal> @params, DAST._IType retType, Dafny.ISequence<DAST._IStatement> body)
        {
            return new Expression_Lambda(@params, retType, body);
        }
        public static _IExpression create_BetaRedex(Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> values, DAST._IType retType, DAST._IExpression expr)
        {
            return new Expression_BetaRedex(values, retType, expr);
        }
        public static _IExpression create_IIFE(Dafny.ISequence<Dafny.Rune> name, DAST._IType typ, DAST._IExpression @value, DAST._IExpression iifeBody)
        {
            return new Expression_IIFE(name, typ, @value, iifeBody);
        }
        public static _IExpression create_Apply(DAST._IExpression expr, Dafny.ISequence<DAST._IExpression> args)
        {
            return new Expression_Apply(expr, args);
        }
        public static _IExpression create_TypeTest(DAST._IExpression @on, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dType, Dafny.ISequence<Dafny.Rune> variant)
        {
            return new Expression_TypeTest(@on, dType, variant);
        }
        public static _IExpression create_InitializationValue(DAST._IType typ)
        {
            return new Expression_InitializationValue(typ);
        }
        public static _IExpression create_BoolBoundedPool()
        {
            return new Expression_BoolBoundedPool();
        }
        public static _IExpression create_SetBoundedPool(DAST._IExpression of)
        {
            return new Expression_SetBoundedPool(of);
        }
        public static _IExpression create_SeqBoundedPool(DAST._IExpression of, bool includeDuplicates)
        {
            return new Expression_SeqBoundedPool(of, includeDuplicates);
        }
        public static _IExpression create_IntRange(DAST._IExpression lo, DAST._IExpression hi)
        {
            return new Expression_IntRange(lo, hi);
        }
        public bool is_Literal
        {
            get { return this is Expression_Literal; }
        }

        public bool is_Ident
        {
            get { return this is Expression_Ident; }
        }

        public bool is_Companion
        {
            get { return this is Expression_Companion; }
        }

        public bool is_Tuple
        {
            get { return this is Expression_Tuple; }
        }

        public bool is_New
        {
            get { return this is Expression_New; }
        }

        public bool is_NewArray
        {
            get { return this is Expression_NewArray; }
        }

        public bool is_DatatypeValue
        {
            get { return this is Expression_DatatypeValue; }
        }

        public bool is_Convert
        {
            get { return this is Expression_Convert; }
        }

        public bool is_SeqConstruct
        {
            get { return this is Expression_SeqConstruct; }
        }

        public bool is_SeqValue
        {
            get { return this is Expression_SeqValue; }
        }

        public bool is_SetValue
        {
            get { return this is Expression_SetValue; }
        }

        public bool is_MultisetValue
        {
            get { return this is Expression_MultisetValue; }
        }

        public bool is_MapValue
        {
            get { return this is Expression_MapValue; }
        }

        public bool is_MapBuilder
        {
            get { return this is Expression_MapBuilder; }
        }

        public bool is_SeqUpdate
        {
            get { return this is Expression_SeqUpdate; }
        }

        public bool is_MapUpdate
        {
            get { return this is Expression_MapUpdate; }
        }

        public bool is_SetBuilder
        {
            get { return this is Expression_SetBuilder; }
        }

        public bool is_ToMultiset
        {
            get { return this is Expression_ToMultiset; }
        }

        public bool is_This
        {
            get { return this is Expression_This; }
        }

        public bool is_Ite
        {
            get { return this is Expression_Ite; }
        }

        public bool is_UnOp
        {
            get { return this is Expression_UnOp; }
        }

        public bool is_BinOp
        {
            get { return this is Expression_BinOp; }
        }

        public bool is_ArrayLen
        {
            get { return this is Expression_ArrayLen; }
        }

        public bool is_MapKeys
        {
            get { return this is Expression_MapKeys; }
        }

        public bool is_MapValues
        {
            get { return this is Expression_MapValues; }
        }

        public bool is_Select
        {
            get { return this is Expression_Select; }
        }

        public bool is_SelectFn
        {
            get { return this is Expression_SelectFn; }
        }

        public bool is_Index
        {
            get { return this is Expression_Index; }
        }

        public bool is_IndexRange
        {
            get { return this is Expression_IndexRange; }
        }

        public bool is_TupleSelect
        {
            get { return this is Expression_TupleSelect; }
        }

        public bool is_Call
        {
            get { return this is Expression_Call; }
        }

        public bool is_Lambda
        {
            get { return this is Expression_Lambda; }
        }

        public bool is_BetaRedex
        {
            get { return this is Expression_BetaRedex; }
        }

        public bool is_IIFE
        {
            get { return this is Expression_IIFE; }
        }

        public bool is_Apply
        {
            get { return this is Expression_Apply; }
        }

        public bool is_TypeTest
        {
            get { return this is Expression_TypeTest; }
        }

        public bool is_InitializationValue
        {
            get { return this is Expression_InitializationValue; }
        }

        public bool is_BoolBoundedPool
        {
            get { return this is Expression_BoolBoundedPool; }
        }

        public bool is_SetBoundedPool
        {
            get { return this is Expression_SetBoundedPool; }
        }

        public bool is_SeqBoundedPool
        {
            get { return this is Expression_SeqBoundedPool; }
        }

        public bool is_IntRange
        {
            get { return this is Expression_IntRange; }
        }

        public DAST._ILiteral dtor_Literal_a0
        {
            get
            {
                var d = this;
                return ((Expression_Literal)d)._a0;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_Ident_a0
        {
            get
            {
                var d = this;
                return ((Expression_Ident)d)._a0;
            }
        }

        public Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_Companion_a0
        {
            get
            {
                var d = this;
                return ((Expression_Companion)d)._a0;
            }
        }

        public Dafny.ISequence<DAST._IExpression> dtor_Tuple_a0
        {
            get
            {
                var d = this;
                return ((Expression_Tuple)d)._a0;
            }
        }

        public Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_path
        {
            get
            {
                var d = this;
                if (d is Expression_New) { return ((Expression_New)d)._path; }
                return ((Expression_DatatypeValue)d)._path;
            }
        }

        public Dafny.ISequence<DAST._IType> dtor_typeArgs
        {
            get
            {
                var d = this;
                if (d is Expression_New) { return ((Expression_New)d)._typeArgs; }
                if (d is Expression_DatatypeValue) { return ((Expression_DatatypeValue)d)._typeArgs; }
                return ((Expression_Call)d)._typeArgs;
            }
        }

        public Dafny.ISequence<DAST._IExpression> dtor_args
        {
            get
            {
                var d = this;
                if (d is Expression_New) { return ((Expression_New)d)._args; }
                if (d is Expression_Call) { return ((Expression_Call)d)._args; }
                return ((Expression_Apply)d)._args;
            }
        }

        public Dafny.ISequence<DAST._IExpression> dtor_dims
        {
            get
            {
                var d = this;
                return ((Expression_NewArray)d)._dims;
            }
        }

        public DAST._IType dtor_typ
        {
            get
            {
                var d = this;
                if (d is Expression_NewArray) { return ((Expression_NewArray)d)._typ; }
                if (d is Expression_Convert) { return ((Expression_Convert)d)._typ; }
                if (d is Expression_SeqValue) { return ((Expression_SeqValue)d)._typ; }
                if (d is Expression_IIFE) { return ((Expression_IIFE)d)._typ; }
                return ((Expression_InitializationValue)d)._typ;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_variant
        {
            get
            {
                var d = this;
                if (d is Expression_DatatypeValue) { return ((Expression_DatatypeValue)d)._variant; }
                return ((Expression_TypeTest)d)._variant;
            }
        }

        public bool dtor_isCo
        {
            get
            {
                var d = this;
                return ((Expression_DatatypeValue)d)._isCo;
            }
        }

        public Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> dtor_contents
        {
            get
            {
                var d = this;
                return ((Expression_DatatypeValue)d)._contents;
            }
        }

        public DAST._IExpression dtor_value
        {
            get
            {
                var d = this;
                if (d is Expression_Convert) { return ((Expression_Convert)d)._value; }
                if (d is Expression_SeqUpdate) { return ((Expression_SeqUpdate)d)._value; }
                if (d is Expression_MapUpdate) { return ((Expression_MapUpdate)d)._value; }
                return ((Expression_IIFE)d)._value;
            }
        }

        public DAST._IType dtor_from
        {
            get
            {
                var d = this;
                return ((Expression_Convert)d)._from;
            }
        }

        public DAST._IExpression dtor_length
        {
            get
            {
                var d = this;
                return ((Expression_SeqConstruct)d)._length;
            }
        }

        public DAST._IExpression dtor_elem
        {
            get
            {
                var d = this;
                return ((Expression_SeqConstruct)d)._elem;
            }
        }

        public Dafny.ISequence<DAST._IExpression> dtor_elements
        {
            get
            {
                var d = this;
                if (d is Expression_SeqValue) { return ((Expression_SeqValue)d)._elements; }
                if (d is Expression_SetValue) { return ((Expression_SetValue)d)._elements; }
                return ((Expression_MultisetValue)d)._elements;
            }
        }

        public Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> dtor_mapElems
        {
            get
            {
                var d = this;
                return ((Expression_MapValue)d)._mapElems;
            }
        }

        public DAST._IType dtor_keyType
        {
            get
            {
                var d = this;
                return ((Expression_MapBuilder)d)._keyType;
            }
        }

        public DAST._IType dtor_valueType
        {
            get
            {
                var d = this;
                return ((Expression_MapBuilder)d)._valueType;
            }
        }

        public DAST._IExpression dtor_expr
        {
            get
            {
                var d = this;
                if (d is Expression_SeqUpdate) { return ((Expression_SeqUpdate)d)._expr; }
                if (d is Expression_MapUpdate) { return ((Expression_MapUpdate)d)._expr; }
                if (d is Expression_UnOp) { return ((Expression_UnOp)d)._expr; }
                if (d is Expression_ArrayLen) { return ((Expression_ArrayLen)d)._expr; }
                if (d is Expression_MapKeys) { return ((Expression_MapKeys)d)._expr; }
                if (d is Expression_MapValues) { return ((Expression_MapValues)d)._expr; }
                if (d is Expression_Select) { return ((Expression_Select)d)._expr; }
                if (d is Expression_SelectFn) { return ((Expression_SelectFn)d)._expr; }
                if (d is Expression_Index) { return ((Expression_Index)d)._expr; }
                if (d is Expression_IndexRange) { return ((Expression_IndexRange)d)._expr; }
                if (d is Expression_TupleSelect) { return ((Expression_TupleSelect)d)._expr; }
                if (d is Expression_BetaRedex) { return ((Expression_BetaRedex)d)._expr; }
                return ((Expression_Apply)d)._expr;
            }
        }

        public DAST._IExpression dtor_indexExpr
        {
            get
            {
                var d = this;
                if (d is Expression_SeqUpdate) { return ((Expression_SeqUpdate)d)._indexExpr; }
                return ((Expression_MapUpdate)d)._indexExpr;
            }
        }

        public DAST._IType dtor_elemType
        {
            get
            {
                var d = this;
                return ((Expression_SetBuilder)d)._elemType;
            }
        }

        public DAST._IExpression dtor_ToMultiset_a0
        {
            get
            {
                var d = this;
                return ((Expression_ToMultiset)d)._a0;
            }
        }

        public DAST._IExpression dtor_cond
        {
            get
            {
                var d = this;
                return ((Expression_Ite)d)._cond;
            }
        }

        public DAST._IExpression dtor_thn
        {
            get
            {
                var d = this;
                return ((Expression_Ite)d)._thn;
            }
        }

        public DAST._IExpression dtor_els
        {
            get
            {
                var d = this;
                return ((Expression_Ite)d)._els;
            }
        }

        public DAST._IUnaryOp dtor_unOp
        {
            get
            {
                var d = this;
                return ((Expression_UnOp)d)._unOp;
            }
        }

        public DAST.Format._IUnaryOpFormat dtor_format1
        {
            get
            {
                var d = this;
                return ((Expression_UnOp)d)._format1;
            }
        }

        public DAST._IBinOp dtor_op
        {
            get
            {
                var d = this;
                return ((Expression_BinOp)d)._op;
            }
        }

        public DAST._IExpression dtor_left
        {
            get
            {
                var d = this;
                return ((Expression_BinOp)d)._left;
            }
        }

        public DAST._IExpression dtor_right
        {
            get
            {
                var d = this;
                return ((Expression_BinOp)d)._right;
            }
        }

        public DAST.Format._IBinaryOpFormat dtor_format2
        {
            get
            {
                var d = this;
                return ((Expression_BinOp)d)._format2;
            }
        }

        public BigInteger dtor_dim
        {
            get
            {
                var d = this;
                return ((Expression_ArrayLen)d)._dim;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_field
        {
            get
            {
                var d = this;
                if (d is Expression_Select) { return ((Expression_Select)d)._field; }
                return ((Expression_SelectFn)d)._field;
            }
        }

        public bool dtor_isConstant
        {
            get
            {
                var d = this;
                return ((Expression_Select)d)._isConstant;
            }
        }

        public bool dtor_onDatatype
        {
            get
            {
                var d = this;
                if (d is Expression_Select) { return ((Expression_Select)d)._onDatatype; }
                return ((Expression_SelectFn)d)._onDatatype;
            }
        }

        public bool dtor_isStatic
        {
            get
            {
                var d = this;
                return ((Expression_SelectFn)d)._isStatic;
            }
        }

        public BigInteger dtor_arity
        {
            get
            {
                var d = this;
                return ((Expression_SelectFn)d)._arity;
            }
        }

        public DAST._ICollKind dtor_collKind
        {
            get
            {
                var d = this;
                return ((Expression_Index)d)._collKind;
            }
        }

        public Dafny.ISequence<DAST._IExpression> dtor_indices
        {
            get
            {
                var d = this;
                return ((Expression_Index)d)._indices;
            }
        }

        public bool dtor_isArray
        {
            get
            {
                var d = this;
                return ((Expression_IndexRange)d)._isArray;
            }
        }

        public Std.Wrappers._IOption<DAST._IExpression> dtor_low
        {
            get
            {
                var d = this;
                return ((Expression_IndexRange)d)._low;
            }
        }

        public Std.Wrappers._IOption<DAST._IExpression> dtor_high
        {
            get
            {
                var d = this;
                return ((Expression_IndexRange)d)._high;
            }
        }

        public BigInteger dtor_index
        {
            get
            {
                var d = this;
                return ((Expression_TupleSelect)d)._index;
            }
        }

        public DAST._IExpression dtor_on
        {
            get
            {
                var d = this;
                if (d is Expression_Call) { return ((Expression_Call)d)._on; }
                return ((Expression_TypeTest)d)._on;
            }
        }

        public DAST._ICallName dtor_callName
        {
            get
            {
                var d = this;
                return ((Expression_Call)d)._callName;
            }
        }

        public Dafny.ISequence<DAST._IFormal> dtor_params
        {
            get
            {
                var d = this;
                return ((Expression_Lambda)d)._params;
            }
        }

        public DAST._IType dtor_retType
        {
            get
            {
                var d = this;
                if (d is Expression_Lambda) { return ((Expression_Lambda)d)._retType; }
                return ((Expression_BetaRedex)d)._retType;
            }
        }

        public Dafny.ISequence<DAST._IStatement> dtor_body
        {
            get
            {
                var d = this;
                return ((Expression_Lambda)d)._body;
            }
        }

        public Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> dtor_values
        {
            get
            {
                var d = this;
                return ((Expression_BetaRedex)d)._values;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_name
        {
            get
            {
                var d = this;
                return ((Expression_IIFE)d)._name;
            }
        }

        public DAST._IExpression dtor_iifeBody
        {
            get
            {
                var d = this;
                return ((Expression_IIFE)d)._iifeBody;
            }
        }

        public Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_dType
        {
            get
            {
                var d = this;
                return ((Expression_TypeTest)d)._dType;
            }
        }

        public DAST._IExpression dtor_of
        {
            get
            {
                var d = this;
                if (d is Expression_SetBoundedPool) { return ((Expression_SetBoundedPool)d)._of; }
                return ((Expression_SeqBoundedPool)d)._of;
            }
        }

        public bool dtor_includeDuplicates
        {
            get
            {
                var d = this;
                return ((Expression_SeqBoundedPool)d)._includeDuplicates;
            }
        }

        public DAST._IExpression dtor_lo
        {
            get
            {
                var d = this;
                return ((Expression_IntRange)d)._lo;
            }
        }

        public DAST._IExpression dtor_hi
        {
            get
            {
                var d = this;
                return ((Expression_IntRange)d)._hi;
            }
        }

        public abstract _IExpression DowncastClone();
    }
    public class Expression_Literal : Expression
    {
        public readonly DAST._ILiteral _a0;
        public Expression_Literal(DAST._ILiteral _a0) : base()
        {
            this._a0 = _a0;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_Literal(_a0);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_Literal;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(5671L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_119(5670L, oth, null), () => object.Equals(this._a0, oth._a0));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5677L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5694L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5684L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5680L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5691L, 0));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5712L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5705L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5701L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5719L, "DAST.Expression.Literal");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(5720L, "(");
            s += Dafny.Helpers.ToString(this._a0);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(5721L, ")");
            return s;
        }
    }
    public class Expression_Ident : Expression
    {
        public readonly Dafny.ISequence<Dafny.Rune> _a0;
        public Expression_Ident(Dafny.ISequence<Dafny.Rune> _a0) : base()
        {
            this._a0 = _a0;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_Ident(_a0);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_Ident;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(5723L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_120(5722L, oth, null), () => object.Equals(this._a0, oth._a0));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5729L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5746L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5736L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5732L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5743L, 1));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5764L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5757L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5753L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5771L, "DAST.Expression.Ident");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(5772L, "(");
            s += this._a0.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(5773L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(5774L, ")");
            return s;
        }
    }
    public class Expression_Companion : Expression
    {
        public readonly Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _a0;
        public Expression_Companion(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _a0) : base()
        {
            this._a0 = _a0;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_Companion(_a0);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_Companion;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(5776L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_121(5775L, oth, null), () => object.Equals(this._a0, oth._a0));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5782L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5799L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5789L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5785L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5796L, 2));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5817L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5810L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5806L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5824L, "DAST.Expression.Companion");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(5825L, "(");
            s += Dafny.Helpers.ToString(this._a0);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(5826L, ")");
            return s;
        }
    }
    public class Expression_Tuple : Expression
    {
        public readonly Dafny.ISequence<DAST._IExpression> _a0;
        public Expression_Tuple(Dafny.ISequence<DAST._IExpression> _a0) : base()
        {
            this._a0 = _a0;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_Tuple(_a0);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_Tuple;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(5828L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_122(5827L, oth, null), () => object.Equals(this._a0, oth._a0));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5834L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5851L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5841L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5837L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5848L, 3));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5869L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5862L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5858L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5876L, "DAST.Expression.Tuple");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(5877L, "(");
            s += Dafny.Helpers.ToString(this._a0);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(5878L, ")");
            return s;
        }
    }
    public class Expression_New : Expression
    {
        public readonly Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _path;
        public readonly Dafny.ISequence<DAST._IType> _typeArgs;
        public readonly Dafny.ISequence<DAST._IExpression> _args;
        public Expression_New(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> path, Dafny.ISequence<DAST._IType> typeArgs, Dafny.ISequence<DAST._IExpression> args) : base()
        {
            this._path = path;
            this._typeArgs = typeArgs;
            this._args = args;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_New(_path, _typeArgs, _args);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_New;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(5892L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(5886L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(5880L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_123(5879L, oth, null), () => object.Equals(this._path, oth._path)), () => object.Equals(this._typeArgs, oth._typeArgs)), () => object.Equals(this._args, oth._args));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5898L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5915L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5905L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5901L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(5912L, 4));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5933L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5926L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5922L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._path)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5951L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5944L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5940L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typeArgs)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(5969L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(5962L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5958L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._args)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(5976L, "DAST.Expression.New");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(5977L, "(");
            s += Dafny.Helpers.ToString(this._path);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(5978L, ", ");
            s += Dafny.Helpers.ToString(this._typeArgs);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(5979L, ", ");
            s += Dafny.Helpers.ToString(this._args);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(5980L, ")");
            return s;
        }
    }
    public class Expression_NewArray : Expression
    {
        public readonly Dafny.ISequence<DAST._IExpression> _dims;
        public readonly DAST._IType _typ;
        public Expression_NewArray(Dafny.ISequence<DAST._IExpression> dims, DAST._IType typ) : base()
        {
            this._dims = dims;
            this._typ = typ;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_NewArray(_dims, _typ);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_NewArray;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(5988L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(5982L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_124(5981L, oth, null), () => object.Equals(this._dims, oth._dims)), () => object.Equals(this._typ, oth._typ));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(5994L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6011L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6001L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(5997L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(6008L, 5));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6029L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6022L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6018L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._dims)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6047L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6040L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6036L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typ)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(6054L, "DAST.Expression.NewArray");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6055L, "(");
            s += Dafny.Helpers.ToString(this._dims);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6056L, ", ");
            s += Dafny.Helpers.ToString(this._typ);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6057L, ")");
            return s;
        }
    }
    public class Expression_DatatypeValue : Expression
    {
        public readonly Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _path;
        public readonly Dafny.ISequence<DAST._IType> _typeArgs;
        public readonly Dafny.ISequence<Dafny.Rune> _variant;
        public readonly bool _isCo;
        public readonly Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _contents;
        public Expression_DatatypeValue(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> path, Dafny.ISequence<DAST._IType> typeArgs, Dafny.ISequence<Dafny.Rune> variant, bool isCo, Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> contents) : base()
        {
            this._path = path;
            this._typeArgs = typeArgs;
            this._variant = variant;
            this._isCo = isCo;
            this._contents = contents;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_DatatypeValue(_path, _typeArgs, _variant, _isCo, _contents);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_DatatypeValue;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(6089L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(6083L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(6071L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(6065L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(6059L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_125(6058L, oth, null), () => object.Equals(this._path, oth._path)), () => object.Equals(this._typeArgs, oth._typeArgs)), () => object.Equals(this._variant, oth._variant)), () => MutateCSharp.Schemata274.ReplaceBinExprOp_2(6077L, () => this._isCo, () => oth._isCo)), () => object.Equals(this._contents, oth._contents));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(6095L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6112L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6102L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6098L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(6109L, 6));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6130L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6123L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6119L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._path)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6148L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6141L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6137L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typeArgs)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6166L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6159L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6155L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._variant)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6184L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6177L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6173L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._isCo)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6202L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6195L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6191L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._contents)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(6209L, "DAST.Expression.DatatypeValue");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6210L, "(");
            s += Dafny.Helpers.ToString(this._path);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6211L, ", ");
            s += Dafny.Helpers.ToString(this._typeArgs);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6212L, ", ");
            s += this._variant.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(6213L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6214L, ", ");
            s += Dafny.Helpers.ToString(this._isCo);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6215L, ", ");
            s += Dafny.Helpers.ToString(this._contents);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6216L, ")");
            return s;
        }
    }
    public class Expression_Convert : Expression
    {
        public readonly DAST._IExpression _value;
        public readonly DAST._IType _from;
        public readonly DAST._IType _typ;
        public Expression_Convert(DAST._IExpression @value, DAST._IType @from, DAST._IType typ) : base()
        {
            this._value = @value;
            this._from = @from;
            this._typ = typ;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_Convert(_value, _from, _typ);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_Convert;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(6230L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(6224L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(6218L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_126(6217L, oth, null), () => object.Equals(this._value, oth._value)), () => object.Equals(this._from, oth._from)), () => object.Equals(this._typ, oth._typ));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(6236L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6253L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6243L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6239L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(6250L, 7));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6271L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6264L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6260L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._value)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6289L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6282L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6278L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._from)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6307L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6300L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6296L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typ)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(6314L, "DAST.Expression.Convert");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6315L, "(");
            s += Dafny.Helpers.ToString(this._value);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6316L, ", ");
            s += Dafny.Helpers.ToString(this._from);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6317L, ", ");
            s += Dafny.Helpers.ToString(this._typ);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6318L, ")");
            return s;
        }
    }
    public class Expression_SeqConstruct : Expression
    {
        public readonly DAST._IExpression _length;
        public readonly DAST._IExpression _elem;
        public Expression_SeqConstruct(DAST._IExpression length, DAST._IExpression elem) : base()
        {
            this._length = length;
            this._elem = elem;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_SeqConstruct(_length, _elem);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_SeqConstruct;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(6326L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(6320L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_127(6319L, oth, null), () => object.Equals(this._length, oth._length)), () => object.Equals(this._elem, oth._elem));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(6332L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6349L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6339L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6335L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(6346L, 8));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6367L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6360L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6356L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._length)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6385L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6378L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6374L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._elem)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(6392L, "DAST.Expression.SeqConstruct");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6393L, "(");
            s += Dafny.Helpers.ToString(this._length);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6394L, ", ");
            s += Dafny.Helpers.ToString(this._elem);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6395L, ")");
            return s;
        }
    }
    public class Expression_SeqValue : Expression
    {
        public readonly Dafny.ISequence<DAST._IExpression> _elements;
        public readonly DAST._IType _typ;
        public Expression_SeqValue(Dafny.ISequence<DAST._IExpression> elements, DAST._IType typ) : base()
        {
            this._elements = elements;
            this._typ = typ;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_SeqValue(_elements, _typ);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_SeqValue;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(6403L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(6397L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_128(6396L, oth, null), () => object.Equals(this._elements, oth._elements)), () => object.Equals(this._typ, oth._typ));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(6409L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6426L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6416L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6412L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(6423L, 9));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6444L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6437L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6433L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._elements)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6462L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6455L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6451L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typ)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(6469L, "DAST.Expression.SeqValue");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6470L, "(");
            s += Dafny.Helpers.ToString(this._elements);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6471L, ", ");
            s += Dafny.Helpers.ToString(this._typ);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6472L, ")");
            return s;
        }
    }
    public class Expression_SetValue : Expression
    {
        public readonly Dafny.ISequence<DAST._IExpression> _elements;
        public Expression_SetValue(Dafny.ISequence<DAST._IExpression> elements) : base()
        {
            this._elements = elements;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_SetValue(_elements);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_SetValue;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(6474L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_129(6473L, oth, null), () => object.Equals(this._elements, oth._elements));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(6480L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6497L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6487L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6483L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(6494L, 10));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6515L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6508L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6504L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._elements)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(6522L, "DAST.Expression.SetValue");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6523L, "(");
            s += Dafny.Helpers.ToString(this._elements);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6524L, ")");
            return s;
        }
    }
    public class Expression_MultisetValue : Expression
    {
        public readonly Dafny.ISequence<DAST._IExpression> _elements;
        public Expression_MultisetValue(Dafny.ISequence<DAST._IExpression> elements) : base()
        {
            this._elements = elements;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_MultisetValue(_elements);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_MultisetValue;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(6526L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_130(6525L, oth, null), () => object.Equals(this._elements, oth._elements));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(6532L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6549L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6539L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6535L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(6546L, 11));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6567L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6560L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6556L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._elements)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(6574L, "DAST.Expression.MultisetValue");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6575L, "(");
            s += Dafny.Helpers.ToString(this._elements);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6576L, ")");
            return s;
        }
    }
    public class Expression_MapValue : Expression
    {
        public readonly Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _mapElems;
        public Expression_MapValue(Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> mapElems) : base()
        {
            this._mapElems = mapElems;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_MapValue(_mapElems);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_MapValue;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(6578L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_131(6577L, oth, null), () => object.Equals(this._mapElems, oth._mapElems));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(6584L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6601L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6591L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6587L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(6598L, 12));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6619L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6612L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6608L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._mapElems)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(6626L, "DAST.Expression.MapValue");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6627L, "(");
            s += Dafny.Helpers.ToString(this._mapElems);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6628L, ")");
            return s;
        }
    }
    public class Expression_MapBuilder : Expression
    {
        public readonly DAST._IType _keyType;
        public readonly DAST._IType _valueType;
        public Expression_MapBuilder(DAST._IType keyType, DAST._IType valueType) : base()
        {
            this._keyType = keyType;
            this._valueType = valueType;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_MapBuilder(_keyType, _valueType);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_MapBuilder;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(6636L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(6630L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_132(6629L, oth, null), () => object.Equals(this._keyType, oth._keyType)), () => object.Equals(this._valueType, oth._valueType));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(6642L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6659L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6649L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6645L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(6656L, 13));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6677L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6670L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6666L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._keyType)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6695L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6688L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6684L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._valueType)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(6702L, "DAST.Expression.MapBuilder");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6703L, "(");
            s += Dafny.Helpers.ToString(this._keyType);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6704L, ", ");
            s += Dafny.Helpers.ToString(this._valueType);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6705L, ")");
            return s;
        }
    }
    public class Expression_SeqUpdate : Expression
    {
        public readonly DAST._IExpression _expr;
        public readonly DAST._IExpression _indexExpr;
        public readonly DAST._IExpression _value;
        public Expression_SeqUpdate(DAST._IExpression expr, DAST._IExpression indexExpr, DAST._IExpression @value) : base()
        {
            this._expr = expr;
            this._indexExpr = indexExpr;
            this._value = @value;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_SeqUpdate(_expr, _indexExpr, _value);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_SeqUpdate;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(6719L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(6713L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(6707L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_133(6706L, oth, null), () => object.Equals(this._expr, oth._expr)), () => object.Equals(this._indexExpr, oth._indexExpr)), () => object.Equals(this._value, oth._value));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(6725L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6742L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6732L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6728L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(6739L, 14));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6760L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6753L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6749L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._expr)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6778L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6771L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6767L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._indexExpr)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6796L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6789L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6785L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._value)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(6803L, "DAST.Expression.SeqUpdate");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6804L, "(");
            s += Dafny.Helpers.ToString(this._expr);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6805L, ", ");
            s += Dafny.Helpers.ToString(this._indexExpr);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6806L, ", ");
            s += Dafny.Helpers.ToString(this._value);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6807L, ")");
            return s;
        }
    }
    public class Expression_MapUpdate : Expression
    {
        public readonly DAST._IExpression _expr;
        public readonly DAST._IExpression _indexExpr;
        public readonly DAST._IExpression _value;
        public Expression_MapUpdate(DAST._IExpression expr, DAST._IExpression indexExpr, DAST._IExpression @value) : base()
        {
            this._expr = expr;
            this._indexExpr = indexExpr;
            this._value = @value;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_MapUpdate(_expr, _indexExpr, _value);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_MapUpdate;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(6821L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(6815L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(6809L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_134(6808L, oth, null), () => object.Equals(this._expr, oth._expr)), () => object.Equals(this._indexExpr, oth._indexExpr)), () => object.Equals(this._value, oth._value));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(6827L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6844L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6834L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6830L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(6841L, 15));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6862L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6855L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6851L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._expr)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6880L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6873L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6869L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._indexExpr)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6898L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6891L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6887L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._value)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(6905L, "DAST.Expression.MapUpdate");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6906L, "(");
            s += Dafny.Helpers.ToString(this._expr);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6907L, ", ");
            s += Dafny.Helpers.ToString(this._indexExpr);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6908L, ", ");
            s += Dafny.Helpers.ToString(this._value);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6909L, ")");
            return s;
        }
    }
    public class Expression_SetBuilder : Expression
    {
        public readonly DAST._IType _elemType;
        public Expression_SetBuilder(DAST._IType elemType) : base()
        {
            this._elemType = elemType;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_SetBuilder(_elemType);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_SetBuilder;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(6911L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_135(6910L, oth, null), () => object.Equals(this._elemType, oth._elemType));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(6917L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6934L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6924L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6920L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(6931L, 16));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6952L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6945L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6941L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._elemType)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(6959L, "DAST.Expression.SetBuilder");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6960L, "(");
            s += Dafny.Helpers.ToString(this._elemType);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(6961L, ")");
            return s;
        }
    }
    public class Expression_ToMultiset : Expression
    {
        public readonly DAST._IExpression _a0;
        public Expression_ToMultiset(DAST._IExpression _a0) : base()
        {
            this._a0 = _a0;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_ToMultiset(_a0);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_ToMultiset;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(6963L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_136(6962L, oth, null), () => object.Equals(this._a0, oth._a0));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(6969L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(6986L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6976L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6972L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(6983L, 17));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7004L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(6997L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(6993L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(7011L, "DAST.Expression.ToMultiset");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7012L, "(");
            s += Dafny.Helpers.ToString(this._a0);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7013L, ")");
            return s;
        }
    }
    public class Expression_This : Expression
    {
        public Expression_This() : base()
        {
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_This();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_This;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_137(7014L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(7015L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7032L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7022L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7018L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(7029L, 18));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(7039L, "DAST.Expression.This");
            return s;
        }
    }
    public class Expression_Ite : Expression
    {
        public readonly DAST._IExpression _cond;
        public readonly DAST._IExpression _thn;
        public readonly DAST._IExpression _els;
        public Expression_Ite(DAST._IExpression cond, DAST._IExpression thn, DAST._IExpression els) : base()
        {
            this._cond = cond;
            this._thn = thn;
            this._els = els;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_Ite(_cond, _thn, _els);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_Ite;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(7053L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(7047L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(7041L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_138(7040L, oth, null), () => object.Equals(this._cond, oth._cond)), () => object.Equals(this._thn, oth._thn)), () => object.Equals(this._els, oth._els));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(7059L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7076L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7066L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7062L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(7073L, 19));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7094L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7087L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7083L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._cond)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7112L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7105L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7101L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._thn)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7130L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7123L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7119L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._els)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(7137L, "DAST.Expression.Ite");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7138L, "(");
            s += Dafny.Helpers.ToString(this._cond);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7139L, ", ");
            s += Dafny.Helpers.ToString(this._thn);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7140L, ", ");
            s += Dafny.Helpers.ToString(this._els);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7141L, ")");
            return s;
        }
    }
    public class Expression_UnOp : Expression
    {
        public readonly DAST._IUnaryOp _unOp;
        public readonly DAST._IExpression _expr;
        public readonly DAST.Format._IUnaryOpFormat _format1;
        public Expression_UnOp(DAST._IUnaryOp unOp, DAST._IExpression expr, DAST.Format._IUnaryOpFormat format1) : base()
        {
            this._unOp = unOp;
            this._expr = expr;
            this._format1 = format1;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_UnOp(_unOp, _expr, _format1);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_UnOp;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(7155L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(7149L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(7143L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_139(7142L, oth, null), () => object.Equals(this._unOp, oth._unOp)), () => object.Equals(this._expr, oth._expr)), () => object.Equals(this._format1, oth._format1));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(7161L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7178L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7168L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7164L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(7175L, 20));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7196L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7189L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7185L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._unOp)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7214L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7207L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7203L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._expr)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7232L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7225L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7221L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._format1)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(7239L, "DAST.Expression.UnOp");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7240L, "(");
            s += Dafny.Helpers.ToString(this._unOp);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7241L, ", ");
            s += Dafny.Helpers.ToString(this._expr);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7242L, ", ");
            s += Dafny.Helpers.ToString(this._format1);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7243L, ")");
            return s;
        }
    }
    public class Expression_BinOp : Expression
    {
        public readonly DAST._IBinOp _op;
        public readonly DAST._IExpression _left;
        public readonly DAST._IExpression _right;
        public readonly DAST.Format._IBinaryOpFormat _format2;
        public Expression_BinOp(DAST._IBinOp op, DAST._IExpression left, DAST._IExpression right, DAST.Format._IBinaryOpFormat format2) : base()
        {
            this._op = op;
            this._left = left;
            this._right = right;
            this._format2 = format2;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_BinOp(_op, _left, _right, _format2);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_BinOp;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(7263L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(7257L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(7251L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(7245L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_140(7244L, oth, null), () => object.Equals(this._op, oth._op)), () => object.Equals(this._left, oth._left)), () => object.Equals(this._right, oth._right)), () => object.Equals(this._format2, oth._format2));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(7269L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7286L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7276L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7272L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(7283L, 21));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7304L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7297L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7293L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._op)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7322L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7315L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7311L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._left)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7340L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7333L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7329L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._right)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7358L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7351L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7347L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._format2)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(7365L, "DAST.Expression.BinOp");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7366L, "(");
            s += Dafny.Helpers.ToString(this._op);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7367L, ", ");
            s += Dafny.Helpers.ToString(this._left);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7368L, ", ");
            s += Dafny.Helpers.ToString(this._right);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7369L, ", ");
            s += Dafny.Helpers.ToString(this._format2);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7370L, ")");
            return s;
        }
    }
    public class Expression_ArrayLen : Expression
    {
        public readonly DAST._IExpression _expr;
        public readonly BigInteger _dim;
        public Expression_ArrayLen(DAST._IExpression expr, BigInteger dim) : base()
        {
            this._expr = expr;
            this._dim = dim;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_ArrayLen(_expr, _dim);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_ArrayLen;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(7379L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(7372L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_141(7371L, oth, null), () => object.Equals(this._expr, oth._expr)), () => MutateCSharp.Schemata274.ReplaceBinExprOp_17(7378L, this._dim, oth._dim));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(7385L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7402L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7392L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7388L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(7399L, 22));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7420L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7413L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7409L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._expr)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7438L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7431L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7427L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._dim)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(7445L, "DAST.Expression.ArrayLen");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7446L, "(");
            s += Dafny.Helpers.ToString(this._expr);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7447L, ", ");
            s += Dafny.Helpers.ToString(this._dim);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7448L, ")");
            return s;
        }
    }
    public class Expression_MapKeys : Expression
    {
        public readonly DAST._IExpression _expr;
        public Expression_MapKeys(DAST._IExpression expr) : base()
        {
            this._expr = expr;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_MapKeys(_expr);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_MapKeys;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(7450L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_142(7449L, oth, null), () => object.Equals(this._expr, oth._expr));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(7456L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7473L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7463L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7459L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(7470L, 23));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7491L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7484L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7480L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._expr)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(7498L, "DAST.Expression.MapKeys");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7499L, "(");
            s += Dafny.Helpers.ToString(this._expr);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7500L, ")");
            return s;
        }
    }
    public class Expression_MapValues : Expression
    {
        public readonly DAST._IExpression _expr;
        public Expression_MapValues(DAST._IExpression expr) : base()
        {
            this._expr = expr;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_MapValues(_expr);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_MapValues;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(7502L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_143(7501L, oth, null), () => object.Equals(this._expr, oth._expr));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(7508L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7525L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7515L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7511L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(7522L, 24));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7543L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7536L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7532L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._expr)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(7550L, "DAST.Expression.MapValues");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7551L, "(");
            s += Dafny.Helpers.ToString(this._expr);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7552L, ")");
            return s;
        }
    }
    public class Expression_Select : Expression
    {
        public readonly DAST._IExpression _expr;
        public readonly Dafny.ISequence<Dafny.Rune> _field;
        public readonly bool _isConstant;
        public readonly bool _onDatatype;
        public Expression_Select(DAST._IExpression expr, Dafny.ISequence<Dafny.Rune> field, bool isConstant, bool onDatatype) : base()
        {
            this._expr = expr;
            this._field = field;
            this._isConstant = isConstant;
            this._onDatatype = onDatatype;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_Select(_expr, _field, _isConstant, _onDatatype);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_Select;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(7584L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(7572L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(7560L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(7554L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_144(7553L, oth, null), () => object.Equals(this._expr, oth._expr)), () => object.Equals(this._field, oth._field)), () => MutateCSharp.Schemata274.ReplaceBinExprOp_2(7566L, () => this._isConstant, () => oth._isConstant)), () => MutateCSharp.Schemata274.ReplaceBinExprOp_2(7578L, () => this._onDatatype, () => oth._onDatatype));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(7590L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7607L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7597L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7593L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(7604L, 25));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7625L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7618L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7614L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._expr)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7643L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7636L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7632L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._field)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7661L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7654L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7650L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._isConstant)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7679L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7672L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7668L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._onDatatype)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(7686L, "DAST.Expression.Select");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7687L, "(");
            s += Dafny.Helpers.ToString(this._expr);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7688L, ", ");
            s += this._field.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(7689L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7690L, ", ");
            s += Dafny.Helpers.ToString(this._isConstant);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7691L, ", ");
            s += Dafny.Helpers.ToString(this._onDatatype);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7692L, ")");
            return s;
        }
    }
    public class Expression_SelectFn : Expression
    {
        public readonly DAST._IExpression _expr;
        public readonly Dafny.ISequence<Dafny.Rune> _field;
        public readonly bool _onDatatype;
        public readonly bool _isStatic;
        public readonly BigInteger _arity;
        public Expression_SelectFn(DAST._IExpression expr, Dafny.ISequence<Dafny.Rune> field, bool onDatatype, bool isStatic, BigInteger arity) : base()
        {
            this._expr = expr;
            this._field = field;
            this._onDatatype = onDatatype;
            this._isStatic = isStatic;
            this._arity = arity;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_SelectFn(_expr, _field, _onDatatype, _isStatic, _arity);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_SelectFn;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(7731L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(7724L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(7712L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(7700L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(7694L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_145(7693L, oth, null), () => object.Equals(this._expr, oth._expr)), () => object.Equals(this._field, oth._field)), () => MutateCSharp.Schemata274.ReplaceBinExprOp_2(7706L, () => this._onDatatype, () => oth._onDatatype)), () => MutateCSharp.Schemata274.ReplaceBinExprOp_2(7718L, () => this._isStatic, () => oth._isStatic)), () => MutateCSharp.Schemata274.ReplaceBinExprOp_17(7730L, this._arity, oth._arity));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(7737L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7754L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7744L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7740L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(7751L, 26));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7772L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7765L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7761L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._expr)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7790L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7783L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7779L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._field)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7808L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7801L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7797L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._onDatatype)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7826L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7819L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7815L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._isStatic)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7844L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7837L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7833L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._arity)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(7851L, "DAST.Expression.SelectFn");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7852L, "(");
            s += Dafny.Helpers.ToString(this._expr);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7853L, ", ");
            s += this._field.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(7854L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7855L, ", ");
            s += Dafny.Helpers.ToString(this._onDatatype);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7856L, ", ");
            s += Dafny.Helpers.ToString(this._isStatic);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7857L, ", ");
            s += Dafny.Helpers.ToString(this._arity);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7858L, ")");
            return s;
        }
    }
    public class Expression_Index : Expression
    {
        public readonly DAST._IExpression _expr;
        public readonly DAST._ICollKind _collKind;
        public readonly Dafny.ISequence<DAST._IExpression> _indices;
        public Expression_Index(DAST._IExpression expr, DAST._ICollKind collKind, Dafny.ISequence<DAST._IExpression> indices) : base()
        {
            this._expr = expr;
            this._collKind = collKind;
            this._indices = indices;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_Index(_expr, _collKind, _indices);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_Index;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(7872L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(7866L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(7860L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_146(7859L, oth, null), () => object.Equals(this._expr, oth._expr)), () => object.Equals(this._collKind, oth._collKind)), () => object.Equals(this._indices, oth._indices));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(7878L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7895L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7885L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7881L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(7892L, 27));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7913L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7906L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7902L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._expr)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7931L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7924L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7920L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._collKind)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(7949L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7942L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7938L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._indices)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(7956L, "DAST.Expression.Index");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7957L, "(");
            s += Dafny.Helpers.ToString(this._expr);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7958L, ", ");
            s += Dafny.Helpers.ToString(this._collKind);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7959L, ", ");
            s += Dafny.Helpers.ToString(this._indices);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(7960L, ")");
            return s;
        }
    }
    public class Expression_IndexRange : Expression
    {
        public readonly DAST._IExpression _expr;
        public readonly bool _isArray;
        public readonly Std.Wrappers._IOption<DAST._IExpression> _low;
        public readonly Std.Wrappers._IOption<DAST._IExpression> _high;
        public Expression_IndexRange(DAST._IExpression expr, bool isArray, Std.Wrappers._IOption<DAST._IExpression> low, Std.Wrappers._IOption<DAST._IExpression> high) : base()
        {
            this._expr = expr;
            this._isArray = isArray;
            this._low = low;
            this._high = high;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_IndexRange(_expr, _isArray, _low, _high);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_IndexRange;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(7986L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(7980L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(7974L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(7962L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_147(7961L, oth, null), () => object.Equals(this._expr, oth._expr)), () => MutateCSharp.Schemata274.ReplaceBinExprOp_2(7968L, () => this._isArray, () => oth._isArray)), () => object.Equals(this._low, oth._low)), () => object.Equals(this._high, oth._high));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(7992L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8009L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(7999L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(7995L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(8006L, 28));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8027L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8020L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8016L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._expr)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8045L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8038L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8034L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._isArray)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8063L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8056L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8052L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._low)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8081L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8074L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8070L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._high)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(8088L, "DAST.Expression.IndexRange");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8089L, "(");
            s += Dafny.Helpers.ToString(this._expr);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8090L, ", ");
            s += Dafny.Helpers.ToString(this._isArray);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8091L, ", ");
            s += Dafny.Helpers.ToString(this._low);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8092L, ", ");
            s += Dafny.Helpers.ToString(this._high);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8093L, ")");
            return s;
        }
    }
    public class Expression_TupleSelect : Expression
    {
        public readonly DAST._IExpression _expr;
        public readonly BigInteger _index;
        public Expression_TupleSelect(DAST._IExpression expr, BigInteger index) : base()
        {
            this._expr = expr;
            this._index = index;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_TupleSelect(_expr, _index);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_TupleSelect;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(8102L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(8095L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_148(8094L, oth, null), () => object.Equals(this._expr, oth._expr)), () => MutateCSharp.Schemata274.ReplaceBinExprOp_17(8101L, this._index, oth._index));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(8108L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8125L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8115L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8111L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(8122L, 29));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8143L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8136L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8132L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._expr)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8161L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8154L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8150L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._index)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(8168L, "DAST.Expression.TupleSelect");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8169L, "(");
            s += Dafny.Helpers.ToString(this._expr);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8170L, ", ");
            s += Dafny.Helpers.ToString(this._index);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8171L, ")");
            return s;
        }
    }
    public class Expression_Call : Expression
    {
        public readonly DAST._IExpression _on;
        public readonly DAST._ICallName _callName;
        public readonly Dafny.ISequence<DAST._IType> _typeArgs;
        public readonly Dafny.ISequence<DAST._IExpression> _args;
        public Expression_Call(DAST._IExpression @on, DAST._ICallName callName, Dafny.ISequence<DAST._IType> typeArgs, Dafny.ISequence<DAST._IExpression> args) : base()
        {
            this._on = @on;
            this._callName = callName;
            this._typeArgs = typeArgs;
            this._args = args;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_Call(_on, _callName, _typeArgs, _args);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_Call;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(8191L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(8185L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(8179L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(8173L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_149(8172L, oth, null), () => object.Equals(this._on, oth._on)), () => object.Equals(this._callName, oth._callName)), () => object.Equals(this._typeArgs, oth._typeArgs)), () => object.Equals(this._args, oth._args));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(8197L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8214L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8204L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8200L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(8211L, 30));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8232L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8225L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8221L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._on)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8250L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8243L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8239L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._callName)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8268L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8261L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8257L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typeArgs)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8286L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8279L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8275L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._args)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(8293L, "DAST.Expression.Call");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8294L, "(");
            s += Dafny.Helpers.ToString(this._on);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8295L, ", ");
            s += Dafny.Helpers.ToString(this._callName);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8296L, ", ");
            s += Dafny.Helpers.ToString(this._typeArgs);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8297L, ", ");
            s += Dafny.Helpers.ToString(this._args);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8298L, ")");
            return s;
        }
    }
    public class Expression_Lambda : Expression
    {
        public readonly Dafny.ISequence<DAST._IFormal> _params;
        public readonly DAST._IType _retType;
        public readonly Dafny.ISequence<DAST._IStatement> _body;
        public Expression_Lambda(Dafny.ISequence<DAST._IFormal> @params, DAST._IType retType, Dafny.ISequence<DAST._IStatement> body) : base()
        {
            this._params = @params;
            this._retType = retType;
            this._body = body;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_Lambda(_params, _retType, _body);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_Lambda;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(8312L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(8306L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(8300L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_150(8299L, oth, null), () => object.Equals(this._params, oth._params)), () => object.Equals(this._retType, oth._retType)), () => object.Equals(this._body, oth._body));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(8318L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8335L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8325L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8321L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(8332L, 31));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8353L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8346L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8342L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._params)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8371L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8364L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8360L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._retType)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8389L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8382L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8378L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._body)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(8396L, "DAST.Expression.Lambda");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8397L, "(");
            s += Dafny.Helpers.ToString(this._params);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8398L, ", ");
            s += Dafny.Helpers.ToString(this._retType);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8399L, ", ");
            s += Dafny.Helpers.ToString(this._body);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8400L, ")");
            return s;
        }
    }
    public class Expression_BetaRedex : Expression
    {
        public readonly Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _values;
        public readonly DAST._IType _retType;
        public readonly DAST._IExpression _expr;
        public Expression_BetaRedex(Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> values, DAST._IType retType, DAST._IExpression expr) : base()
        {
            this._values = values;
            this._retType = retType;
            this._expr = expr;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_BetaRedex(_values, _retType, _expr);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_BetaRedex;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(8414L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(8408L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(8402L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_151(8401L, oth, null), () => object.Equals(this._values, oth._values)), () => object.Equals(this._retType, oth._retType)), () => object.Equals(this._expr, oth._expr));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(8420L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8437L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8427L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8423L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(8434L, 32));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8455L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8448L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8444L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._values)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8473L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8466L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8462L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._retType)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8491L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8484L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8480L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._expr)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(8498L, "DAST.Expression.BetaRedex");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8499L, "(");
            s += Dafny.Helpers.ToString(this._values);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8500L, ", ");
            s += Dafny.Helpers.ToString(this._retType);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8501L, ", ");
            s += Dafny.Helpers.ToString(this._expr);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8502L, ")");
            return s;
        }
    }
    public class Expression_IIFE : Expression
    {
        public readonly Dafny.ISequence<Dafny.Rune> _name;
        public readonly DAST._IType _typ;
        public readonly DAST._IExpression _value;
        public readonly DAST._IExpression _iifeBody;
        public Expression_IIFE(Dafny.ISequence<Dafny.Rune> name, DAST._IType typ, DAST._IExpression @value, DAST._IExpression iifeBody) : base()
        {
            this._name = name;
            this._typ = typ;
            this._value = @value;
            this._iifeBody = iifeBody;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_IIFE(_name, _typ, _value, _iifeBody);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_IIFE;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(8522L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(8516L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(8510L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(8504L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_152(8503L, oth, null), () => object.Equals(this._name, oth._name)), () => object.Equals(this._typ, oth._typ)), () => object.Equals(this._value, oth._value)), () => object.Equals(this._iifeBody, oth._iifeBody));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(8528L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8545L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8535L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8531L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(8542L, 33));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8563L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8556L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8552L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._name)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8581L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8574L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8570L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typ)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8599L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8592L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8588L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._value)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8617L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8610L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8606L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._iifeBody)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(8624L, "DAST.Expression.IIFE");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8625L, "(");
            s += Dafny.Helpers.ToString(this._name);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8626L, ", ");
            s += Dafny.Helpers.ToString(this._typ);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8627L, ", ");
            s += Dafny.Helpers.ToString(this._value);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8628L, ", ");
            s += Dafny.Helpers.ToString(this._iifeBody);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8629L, ")");
            return s;
        }
    }
    public class Expression_Apply : Expression
    {
        public readonly DAST._IExpression _expr;
        public readonly Dafny.ISequence<DAST._IExpression> _args;
        public Expression_Apply(DAST._IExpression expr, Dafny.ISequence<DAST._IExpression> args) : base()
        {
            this._expr = expr;
            this._args = args;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_Apply(_expr, _args);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_Apply;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(8637L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(8631L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_153(8630L, oth, null), () => object.Equals(this._expr, oth._expr)), () => object.Equals(this._args, oth._args));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(8643L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8660L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8650L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8646L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(8657L, 34));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8678L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8671L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8667L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._expr)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8696L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8689L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8685L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._args)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(8703L, "DAST.Expression.Apply");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8704L, "(");
            s += Dafny.Helpers.ToString(this._expr);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8705L, ", ");
            s += Dafny.Helpers.ToString(this._args);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8706L, ")");
            return s;
        }
    }
    public class Expression_TypeTest : Expression
    {
        public readonly DAST._IExpression _on;
        public readonly Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _dType;
        public readonly Dafny.ISequence<Dafny.Rune> _variant;
        public Expression_TypeTest(DAST._IExpression @on, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dType, Dafny.ISequence<Dafny.Rune> variant) : base()
        {
            this._on = @on;
            this._dType = dType;
            this._variant = variant;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_TypeTest(_on, _dType, _variant);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_TypeTest;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(8720L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(8714L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(8708L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_154(8707L, oth, null), () => object.Equals(this._on, oth._on)), () => object.Equals(this._dType, oth._dType)), () => object.Equals(this._variant, oth._variant));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(8726L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8743L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8733L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8729L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(8740L, 35));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8761L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8754L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8750L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._on)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8779L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8772L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8768L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._dType)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8797L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8790L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8786L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._variant)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(8804L, "DAST.Expression.TypeTest");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8805L, "(");
            s += Dafny.Helpers.ToString(this._on);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8806L, ", ");
            s += Dafny.Helpers.ToString(this._dType);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8807L, ", ");
            s += this._variant.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(8808L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8809L, ")");
            return s;
        }
    }
    public class Expression_InitializationValue : Expression
    {
        public readonly DAST._IType _typ;
        public Expression_InitializationValue(DAST._IType typ) : base()
        {
            this._typ = typ;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_InitializationValue(_typ);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_InitializationValue;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(8811L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_155(8810L, oth, null), () => object.Equals(this._typ, oth._typ));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(8817L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8834L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8824L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8820L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(8831L, 36));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8852L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8845L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8841L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._typ)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(8859L, "DAST.Expression.InitializationValue");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8860L, "(");
            s += Dafny.Helpers.ToString(this._typ);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8861L, ")");
            return s;
        }
    }
    public class Expression_BoolBoundedPool : Expression
    {
        public Expression_BoolBoundedPool() : base()
        {
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_BoolBoundedPool();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_BoolBoundedPool;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_156(8862L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(8863L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8880L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8870L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8866L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(8877L, 37));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(8887L, "DAST.Expression.BoolBoundedPool");
            return s;
        }
    }
    public class Expression_SetBoundedPool : Expression
    {
        public readonly DAST._IExpression _of;
        public Expression_SetBoundedPool(DAST._IExpression of) : base()
        {
            this._of = of;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_SetBoundedPool(_of);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_SetBoundedPool;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(8889L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_157(8888L, oth, null), () => object.Equals(this._of, oth._of));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(8895L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8912L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8902L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8898L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(8909L, 38));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8930L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8923L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8919L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._of)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(8937L, "DAST.Expression.SetBoundedPool");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8938L, "(");
            s += Dafny.Helpers.ToString(this._of);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(8939L, ")");
            return s;
        }
    }
    public class Expression_SeqBoundedPool : Expression
    {
        public readonly DAST._IExpression _of;
        public readonly bool _includeDuplicates;
        public Expression_SeqBoundedPool(DAST._IExpression of, bool includeDuplicates) : base()
        {
            this._of = of;
            this._includeDuplicates = includeDuplicates;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_SeqBoundedPool(_of, _includeDuplicates);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_SeqBoundedPool;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(8953L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(8941L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_158(8940L, oth, null), () => object.Equals(this._of, oth._of)), () => MutateCSharp.Schemata274.ReplaceBinExprOp_2(8947L, () => this._includeDuplicates, () => oth._includeDuplicates));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(8959L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8976L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8966L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8962L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(8973L, 39));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(8994L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(8987L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(8983L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._of)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(9012L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(9005L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(9001L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._includeDuplicates)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(9019L, "DAST.Expression.SeqBoundedPool");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(9020L, "(");
            s += Dafny.Helpers.ToString(this._of);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(9021L, ", ");
            s += Dafny.Helpers.ToString(this._includeDuplicates);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(9022L, ")");
            return s;
        }
    }
    public class Expression_IntRange : Expression
    {
        public readonly DAST._IExpression _lo;
        public readonly DAST._IExpression _hi;
        public Expression_IntRange(DAST._IExpression lo, DAST._IExpression hi) : base()
        {
            this._lo = lo;
            this._hi = hi;
        }
        public override _IExpression DowncastClone()
        {
            if (this is _IExpression dt) { return dt; }
            return new Expression_IntRange(_lo, _hi);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Expression_IntRange;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(9030L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(9024L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_159(9023L, oth, null), () => object.Equals(this._lo, oth._lo)), () => object.Equals(this._hi, oth._hi));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(9036L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(9053L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(9043L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(9039L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(9050L, 40));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(9071L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(9064L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(9060L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._lo)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(9089L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(9082L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(9078L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._hi)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(9096L, "DAST.Expression.IntRange");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(9097L, "(");
            s += Dafny.Helpers.ToString(this._lo);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(9098L, ", ");
            s += Dafny.Helpers.ToString(this._hi);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(9099L, ")");
            return s;
        }
    }

    public interface _IUnaryOp
    {
        bool is_Not { get; }
        bool is_BitwiseNot { get; }
        bool is_Cardinality { get; }

        _IUnaryOp DowncastClone();
    }
    public abstract class UnaryOp : _IUnaryOp
    {
        public UnaryOp()
        {
        }
        private static readonly DAST._IUnaryOp theDefault = create_Not();
        public static DAST._IUnaryOp Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST._IUnaryOp> _TYPE = new Dafny.TypeDescriptor<DAST._IUnaryOp>(DAST.UnaryOp.Default());
        public static Dafny.TypeDescriptor<DAST._IUnaryOp> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IUnaryOp create_Not()
        {
            return new UnaryOp_Not();
        }
        public static _IUnaryOp create_BitwiseNot()
        {
            return new UnaryOp_BitwiseNot();
        }
        public static _IUnaryOp create_Cardinality()
        {
            return new UnaryOp_Cardinality();
        }
        public bool is_Not
        {
            get { return this is UnaryOp_Not; }
        }

        public bool is_BitwiseNot
        {
            get { return this is UnaryOp_BitwiseNot; }
        }

        public bool is_Cardinality
        {
            get { return this is UnaryOp_Cardinality; }
        }

        public static System.Collections.Generic.IEnumerable<_IUnaryOp> AllSingletonConstructors
        {
            get
            {
                yield return UnaryOp.create_Not();
                yield return UnaryOp.create_BitwiseNot();
                yield return UnaryOp.create_Cardinality();
            }
        }

        public abstract _IUnaryOp DowncastClone();
    }
    public class UnaryOp_Not : UnaryOp
    {
        public UnaryOp_Not() : base()
        {
        }
        public override _IUnaryOp DowncastClone()
        {
            if (this is _IUnaryOp dt) { return dt; }
            return new UnaryOp_Not();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.UnaryOp_Not;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_160(9100L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(9101L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(9118L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(9108L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(9104L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(9115L, 0));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(9125L, "DAST.UnaryOp.Not");
            return s;
        }
    }
    public class UnaryOp_BitwiseNot : UnaryOp
    {
        public UnaryOp_BitwiseNot() : base()
        {
        }
        public override _IUnaryOp DowncastClone()
        {
            if (this is _IUnaryOp dt) { return dt; }
            return new UnaryOp_BitwiseNot();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.UnaryOp_BitwiseNot;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_161(9126L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(9127L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(9144L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(9134L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(9130L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(9141L, 1));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(9151L, "DAST.UnaryOp.BitwiseNot");
            return s;
        }
    }
    public class UnaryOp_Cardinality : UnaryOp
    {
        public UnaryOp_Cardinality() : base()
        {
        }
        public override _IUnaryOp DowncastClone()
        {
            if (this is _IUnaryOp dt) { return dt; }
            return new UnaryOp_Cardinality();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.UnaryOp_Cardinality;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_162(9152L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(9153L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(9170L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(9160L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(9156L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(9167L, 2));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(9177L, "DAST.UnaryOp.Cardinality");
            return s;
        }
    }

    public interface _ILiteral
    {
        bool is_BoolLiteral { get; }
        bool is_IntLiteral { get; }
        bool is_DecLiteral { get; }
        bool is_StringLiteral { get; }
        bool is_CharLiteral { get; }
        bool is_Null { get; }
        bool dtor_BoolLiteral_a0 { get; }
        Dafny.ISequence<Dafny.Rune> dtor_IntLiteral_a0 { get; }
        DAST._IType dtor_IntLiteral_a1 { get; }
        Dafny.ISequence<Dafny.Rune> dtor_DecLiteral_a0 { get; }
        Dafny.ISequence<Dafny.Rune> dtor_DecLiteral_a1 { get; }
        DAST._IType dtor_DecLiteral_a2 { get; }
        Dafny.ISequence<Dafny.Rune> dtor_StringLiteral_a0 { get; }
        Dafny.Rune dtor_CharLiteral_a0 { get; }
        DAST._IType dtor_Null_a0 { get; }

        _ILiteral DowncastClone();
    }
    public abstract class Literal : _ILiteral
    {
        public Literal()
        {
        }
        private static readonly DAST._ILiteral theDefault = create_BoolLiteral(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(9178L, false));
        public static DAST._ILiteral Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST._ILiteral> _TYPE = new Dafny.TypeDescriptor<DAST._ILiteral>(DAST.Literal.Default());
        public static Dafny.TypeDescriptor<DAST._ILiteral> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _ILiteral create_BoolLiteral(bool _a0)
        {
            return new Literal_BoolLiteral(_a0);
        }
        public static _ILiteral create_IntLiteral(Dafny.ISequence<Dafny.Rune> _a0, DAST._IType _a1)
        {
            return new Literal_IntLiteral(_a0, _a1);
        }
        public static _ILiteral create_DecLiteral(Dafny.ISequence<Dafny.Rune> _a0, Dafny.ISequence<Dafny.Rune> _a1, DAST._IType _a2)
        {
            return new Literal_DecLiteral(_a0, _a1, _a2);
        }
        public static _ILiteral create_StringLiteral(Dafny.ISequence<Dafny.Rune> _a0)
        {
            return new Literal_StringLiteral(_a0);
        }
        public static _ILiteral create_CharLiteral(Dafny.Rune _a0)
        {
            return new Literal_CharLiteral(_a0);
        }
        public static _ILiteral create_Null(DAST._IType _a0)
        {
            return new Literal_Null(_a0);
        }
        public bool is_BoolLiteral
        {
            get { return this is Literal_BoolLiteral; }
        }

        public bool is_IntLiteral
        {
            get { return this is Literal_IntLiteral; }
        }

        public bool is_DecLiteral
        {
            get { return this is Literal_DecLiteral; }
        }

        public bool is_StringLiteral
        {
            get { return this is Literal_StringLiteral; }
        }

        public bool is_CharLiteral
        {
            get { return this is Literal_CharLiteral; }
        }

        public bool is_Null
        {
            get { return this is Literal_Null; }
        }

        public bool dtor_BoolLiteral_a0
        {
            get
            {
                var d = this;
                return ((Literal_BoolLiteral)d)._a0;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_IntLiteral_a0
        {
            get
            {
                var d = this;
                return ((Literal_IntLiteral)d)._a0;
            }
        }

        public DAST._IType dtor_IntLiteral_a1
        {
            get
            {
                var d = this;
                return ((Literal_IntLiteral)d)._a1;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_DecLiteral_a0
        {
            get
            {
                var d = this;
                return ((Literal_DecLiteral)d)._a0;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_DecLiteral_a1
        {
            get
            {
                var d = this;
                return ((Literal_DecLiteral)d)._a1;
            }
        }

        public DAST._IType dtor_DecLiteral_a2
        {
            get
            {
                var d = this;
                return ((Literal_DecLiteral)d)._a2;
            }
        }

        public Dafny.ISequence<Dafny.Rune> dtor_StringLiteral_a0
        {
            get
            {
                var d = this;
                return ((Literal_StringLiteral)d)._a0;
            }
        }

        public Dafny.Rune dtor_CharLiteral_a0
        {
            get
            {
                var d = this;
                return ((Literal_CharLiteral)d)._a0;
            }
        }

        public DAST._IType dtor_Null_a0
        {
            get
            {
                var d = this;
                return ((Literal_Null)d)._a0;
            }
        }

        public abstract _ILiteral DowncastClone();
    }
    public class Literal_BoolLiteral : Literal
    {
        public readonly bool _a0;
        public Literal_BoolLiteral(bool _a0) : base()
        {
            this._a0 = _a0;
        }
        public override _ILiteral DowncastClone()
        {
            if (this is _ILiteral dt) { return dt; }
            return new Literal_BoolLiteral(_a0);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Literal_BoolLiteral;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(9186L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_163(9179L, oth, null), () => MutateCSharp.Schemata274.ReplaceBinExprOp_2(9180L, () => this._a0, () => oth._a0));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(9192L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(9209L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(9199L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(9195L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(9206L, 0));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(9227L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(9220L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(9216L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(9234L, "DAST.Literal.BoolLiteral");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(9235L, "(");
            s += Dafny.Helpers.ToString(this._a0);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(9236L, ")");
            return s;
        }
    }
    public class Literal_IntLiteral : Literal
    {
        public readonly Dafny.ISequence<Dafny.Rune> _a0;
        public readonly DAST._IType _a1;
        public Literal_IntLiteral(Dafny.ISequence<Dafny.Rune> _a0, DAST._IType _a1) : base()
        {
            this._a0 = _a0;
            this._a1 = _a1;
        }
        public override _ILiteral DowncastClone()
        {
            if (this is _ILiteral dt) { return dt; }
            return new Literal_IntLiteral(_a0, _a1);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Literal_IntLiteral;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(9244L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(9238L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_164(9237L, oth, null), () => object.Equals(this._a0, oth._a0)), () => object.Equals(this._a1, oth._a1));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(9250L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(9267L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(9257L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(9253L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(9264L, 1));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(9285L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(9278L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(9274L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(9303L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(9296L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(9292L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a1)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(9310L, "DAST.Literal.IntLiteral");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(9311L, "(");
            s += this._a0.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(9312L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(9313L, ", ");
            s += Dafny.Helpers.ToString(this._a1);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(9314L, ")");
            return s;
        }
    }
    public class Literal_DecLiteral : Literal
    {
        public readonly Dafny.ISequence<Dafny.Rune> _a0;
        public readonly Dafny.ISequence<Dafny.Rune> _a1;
        public readonly DAST._IType _a2;
        public Literal_DecLiteral(Dafny.ISequence<Dafny.Rune> _a0, Dafny.ISequence<Dafny.Rune> _a1, DAST._IType _a2) : base()
        {
            this._a0 = _a0;
            this._a1 = _a1;
            this._a2 = _a2;
        }
        public override _ILiteral DowncastClone()
        {
            if (this is _ILiteral dt) { return dt; }
            return new Literal_DecLiteral(_a0, _a1, _a2);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Literal_DecLiteral;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(9328L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(9322L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_1(9316L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_165(9315L, oth, null), () => object.Equals(this._a0, oth._a0)), () => object.Equals(this._a1, oth._a1)), () => object.Equals(this._a2, oth._a2));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(9334L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(9351L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(9341L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(9337L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(9348L, 2));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(9369L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(9362L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(9358L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(9387L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(9380L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(9376L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a1)));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(9405L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(9398L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(9394L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a2)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(9412L, "DAST.Literal.DecLiteral");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(9413L, "(");
            s += this._a0.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(9414L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(9415L, ", ");
            s += this._a1.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(9416L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(9417L, ", ");
            s += Dafny.Helpers.ToString(this._a2);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(9418L, ")");
            return s;
        }
    }
    public class Literal_StringLiteral : Literal
    {
        public readonly Dafny.ISequence<Dafny.Rune> _a0;
        public Literal_StringLiteral(Dafny.ISequence<Dafny.Rune> _a0) : base()
        {
            this._a0 = _a0;
        }
        public override _ILiteral DowncastClone()
        {
            if (this is _ILiteral dt) { return dt; }
            return new Literal_StringLiteral(_a0);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Literal_StringLiteral;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(9420L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_166(9419L, oth, null), () => object.Equals(this._a0, oth._a0));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(9426L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(9443L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(9433L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(9429L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(9440L, 3));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(9461L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(9454L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(9450L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(9468L, "DAST.Literal.StringLiteral");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(9469L, "(");
            s += this._a0.ToVerbatimString(MutateCSharp.Schemata274.ReplaceBooleanConstant_7(9470L, true));
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(9471L, ")");
            return s;
        }
    }
    public class Literal_CharLiteral : Literal
    {
        public readonly Dafny.Rune _a0;
        public Literal_CharLiteral(Dafny.Rune _a0) : base()
        {
            this._a0 = _a0;
        }
        public override _ILiteral DowncastClone()
        {
            if (this is _ILiteral dt) { return dt; }
            return new Literal_CharLiteral(_a0);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Literal_CharLiteral;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(9474L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_167(9472L, oth, null), () => MutateCSharp.Schemata274.ReplaceBinExprOp_168(9473L, this._a0, oth._a0));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(9480L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(9497L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(9487L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(9483L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(9494L, 4));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(9515L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(9508L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(9504L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(9522L, "DAST.Literal.CharLiteral");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(9523L, "(");
            s += Dafny.Helpers.ToString(this._a0);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(9524L, ")");
            return s;
        }
    }
    public class Literal_Null : Literal
    {
        public readonly DAST._IType _a0;
        public Literal_Null(DAST._IType _a0) : base()
        {
            this._a0 = _a0;
        }
        public override _ILiteral DowncastClone()
        {
            if (this is _ILiteral dt) { return dt; }
            return new Literal_Null(_a0);
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Literal_Null;
            return MutateCSharp.Schemata274.ReplaceBinExprOp_1(9526L, () => MutateCSharp.Schemata274.ReplaceBinExprOp_169(9525L, oth, null), () => object.Equals(this._a0, oth._a0));
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata274.ReplaceNumericConstant_3(9532L, 5381);
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(9549L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(9539L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(9535L, 5)), hash)), MutateCSharp.Schemata274.ReplaceNumericConstant_3(9546L, 5));
            hash = MutateCSharp.Schemata274.ReplaceBinExprOp_5(9567L, (MutateCSharp.Schemata274.ReplaceBinExprOp_5(9560L, (hash << MutateCSharp.Schemata274.ReplaceNumericConstant_4(9556L, 5)), hash)), ((ulong)Dafny.Helpers.GetHashCode(this._a0)));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata274.ReplaceStringConstant_6(9574L, "DAST.Literal.Null");
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(9575L, "(");
            s += Dafny.Helpers.ToString(this._a0);
            s += MutateCSharp.Schemata274.ReplaceStringConstant_6(9576L, ")");
            return s;
        }
    }
} // end of namespace DAST