#define TI_DEBUG_PRINT
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading;
namespace MutateCSharp
{
    internal class Schemata208
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT208");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_46(long mutantId, Microsoft.Dafny.TypeParameter.TPVariance argument1, Microsoft.Dafny.TypeParameter.TPVariance argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_32(long mutantId, Microsoft.Dafny.IndDatatypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_47(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_28(long mutantId, Microsoft.Dafny.ArrayClassDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_49(long mutantId, Microsoft.Dafny.SetType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBinExprOp_14(long mutantId, bool? argument1, bool argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_52(long mutantId, Microsoft.Dafny.SeqType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_42(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, Microsoft.Dafny.TypeParameter argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_29(long mutantId, Microsoft.Dafny.UserDefinedType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.NewtypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_21(long mutantId, Microsoft.Dafny.SetType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_48(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Type> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_31(long mutantId, Microsoft.Dafny.ArrowType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_45(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_40(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_23(long mutantId, Microsoft.Dafny.DatatypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.Type.NumericPersuasion argument1, Microsoft.Dafny.Type.NumericPersuasion argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.UserDefinedType> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBinExprOp_61(long mutantId, Microsoft.Dafny.SeqType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, Microsoft.Dafny.DatatypeDecl argument1, Microsoft.Dafny.TopLevelDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_56(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Type> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_41(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, Microsoft.Dafny.TopLevelDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.NewtypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, Microsoft.Dafny.TraitDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_35(long mutantId, Microsoft.Dafny.AbstractTypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_55(long mutantId, Microsoft.Dafny.ArrowType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_51(long mutantId, Microsoft.Dafny.MultiSetType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, Microsoft.Dafny.Type.AutoInitInfo argument1, Microsoft.Dafny.Type.AutoInitInfo argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_33(long mutantId, Microsoft.Dafny.CoDatatypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_63(long mutantId, Microsoft.Dafny.CollectionType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_50(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() != argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() == argument2(); }
            return argument1() != argument2();
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.BitvectorType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.InternalTypeSynonymDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_62(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.Type.ExpandMode argument1, Microsoft.Dafny.Type.ExpandMode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_64(long mutantId, Microsoft.Dafny.TypeProxy argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, Microsoft.Dafny.UserDefinedType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_54(long mutantId, Microsoft.Dafny.DatatypeDecl argument1, Microsoft.Dafny.DatatypeDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_57(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_36(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_53(long mutantId, Microsoft.Dafny.MapType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_34(long mutantId, Microsoft.Dafny.TypeParameter argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_39(long mutantId, Microsoft.Dafny.Type argument1, Microsoft.Dafny.Type argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, Microsoft.Dafny.MapType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_38(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_44(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_30(long mutantId, Microsoft.Dafny.SubsetTypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_59(long mutantId, System.Type argument1, System.Type argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePrefixUnaryExprOp_37(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return --argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return +argument1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return ~argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return ++argument1; }
            return --argument1;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, Microsoft.Dafny.Type.AutoInitInfo argument1, Microsoft.Dafny.Type.AutoInitInfo argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_60(long mutantId, Microsoft.Dafny.MultiSetType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_58(long mutantId, Microsoft.Dafny.Type argument1, Microsoft.Dafny.TypeProxy argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, Microsoft.Dafny.TopLevelDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_43(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, Microsoft.Dafny.TopLevelDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.Type.ExpandMode argument1, Microsoft.Dafny.Type.ExpandMode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.RevealableTypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public abstract class Type : TokenNode
    {
        public static readonly BoolType Bool = new BoolType();
        public static readonly CharType Char = new CharType();
        public static readonly IntType Int = new IntType();
        public static readonly RealType Real = new RealType();
        public override IEnumerable<INode> Children => TypeArgs;
        public override IEnumerable<INode> PreResolveChildren => TypeArgs.OfType<Node>();
        public static Type Nat() { return new UserDefinedType(Token.NoToken, MutateCSharp.Schemata208.ReplaceStringConstant_0(1L, "nat"), null); }  // note, this returns an unresolved type
        public static Type String() { return new UserDefinedType(Token.NoToken, MutateCSharp.Schemata208.ReplaceStringConstant_0(2L, "string"), null); }  // note, this returns an unresolved type
        public static readonly BigOrdinalType BigOrdinal = new BigOrdinalType();

        private static ThreadLocal<List<VisibilityScope>> _scopes = new();
        private static List<VisibilityScope> Scopes => _scopes.Value ??= new();

        [ThreadStatic]
        private static bool scopesEnabled = MutateCSharp.Schemata208.ReplaceBooleanConstant_1(3L, false);

        public virtual IEnumerable<Node> Nodes => Enumerable.Empty<Node>();

        public static void PushScope(VisibilityScope scope)
        {
            Scopes.Add(scope);
        }

        public static void ResetScopes()
        {
            _scopes.Value = new();
            scopesEnabled = MutateCSharp.Schemata208.ReplaceBooleanConstant_1(4L, false);
        }

        public static void PopScope()
        {
            Contract.Assert(Scopes.Count > 0);
            Scopes.RemoveAt(MutateCSharp.Schemata208.ReplaceBinExprOp_3(9L, Scopes.Count, MutateCSharp.Schemata208.ReplaceNumericConstant_2(5L, 1)));
        }

        public static void PopScope(VisibilityScope expected)
        {
            Contract.Assert(Scopes.Count > 0);
            Contract.Assert(Scopes[^1] == expected);
            PopScope();
        }

        public static VisibilityScope GetScope()
        {
            if (MutateCSharp.Schemata208.ReplaceBinExprOp_5(27L, () => scopesEnabled, () => MutateCSharp.Schemata208.ReplaceBinExprOp_4(22L, Scopes.Count, MutateCSharp.Schemata208.ReplaceNumericConstant_2(18L, 0))))
            {
                return Scopes[^MutateCSharp.Schemata208.ReplaceNumericConstant_2(33L, 1)];
            }
            return null;
        }

        public static void EnableScopes()
        {
            Contract.Assert(!scopesEnabled);
            scopesEnabled = MutateCSharp.Schemata208.ReplaceBooleanConstant_1(37L, true);
        }

        public static void DisableScopes()
        {
            Contract.Assert(scopesEnabled);
            scopesEnabled = MutateCSharp.Schemata208.ReplaceBooleanConstant_1(38L, false);
        }

        public static string TypeArgsToString(DafnyOptions options, ModuleDefinition/*?*/ context, List<Type> typeArgs, bool parseAble = false)
        {
            Contract.Requires(typeArgs == null ||
                              (typeArgs.All(ty => ty != null && ty.TypeName(options, context, parseAble) != null) &&
                               (typeArgs.All(ty => ty.TypeName(options, context, parseAble).StartsWith("_")) ||
                                typeArgs.All(ty => !ty.TypeName(options, context, parseAble).StartsWith("_")))));

            if (MutateCSharp.Schemata208.ReplaceBinExprOp_5(66L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_5(49L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_6(39L, typeArgs, null), () => MutateCSharp.Schemata208.ReplaceBinExprOp_4(44L, typeArgs.Count, MutateCSharp.Schemata208.ReplaceNumericConstant_2(40L, 0))), () => (MutateCSharp.Schemata208.ReplaceBinExprOp_7(60L, () => !parseAble, () => !typeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(55L, 0)].TypeName(options, context, parseAble).StartsWith(MutateCSharp.Schemata208.ReplaceStringConstant_0(59L, "_"))))))
            {
                return string.Format(MutateCSharp.Schemata208.ReplaceStringConstant_0(72L, "<{0}>"), Util.Comma(typeArgs, ty => ty.TypeName(options, context, parseAble)));
            }
            return "";
        }

        public static string TypeArgsToString(DafnyOptions options, List<Type> typeArgs, bool parseAble = false)
        {
            return TypeArgsToString(options, null, typeArgs, parseAble);
        }

        public string TypeArgsToString(DafnyOptions options, ModuleDefinition/*?*/ context, bool parseAble = false)
        {
            return Type.TypeArgsToString(options, context, this.TypeArgs, parseAble);
        }

        // Type arguments to the type
        public List<Type> TypeArgs = new List<Type>();

        /// <summary>
        /// Add to "tps" the free type parameters in "this".
        /// Requires the type to be resolved.
        /// </summary>
        public void AddFreeTypeParameters(ISet<TypeParameter> tps)
        {
            Contract.Requires(tps != null);
            var ty = this.NormalizeExpandKeepConstraints();
            if (ty.AsTypeParameter is { } tp)
            {
                tps.Add(tp);
            }
            foreach (var ta in ty.TypeArgs)
            {
                ta.AddFreeTypeParameters(tps);
            }
        }

        [System.Diagnostics.Contracts.Pure]
        public abstract string TypeName(DafnyOptions options, ModuleDefinition/*?*/ context, bool parseAble = false);

        [System.Diagnostics.Contracts.Pure]
        public override string ToString()
        {
            return TypeName(DafnyOptions.DefaultImmutableOptions, null, MutateCSharp.Schemata208.ReplaceBooleanConstant_1(73L, false));
        }

        /// <summary>
        /// Return the most constrained version of "this", getting to the bottom of proxies.
        ///
        /// Here is a description of the Normalize(), NormalizeExpandKeepConstraints(), and NormalizeExpand() methods:
        /// * Any .Type field in the AST can, in general, be an AST node that is not really a type, but an AST node that has
        ///   a field where the type is filled in, once the type has been inferred. Such "types" are called "type proxies".
        ///   To follow a .Type (or other variable denoting a type) past its chain of type proxies, you call .Normalize().
        ///   If you do this after type inference (more precisely, after the CheckTypeInference calls in Pass 1 of the
        ///   Resolver), then you will get back a NonProxyType.
        /// * That may not be enough. Even after calling .Normalize(), you may get a type that denotes a type synonym. If
        ///   you compare it with, say, is SetType, you will get false if the type you're looking at is a type synonym for
        ///   a SetType. Therefore, to go past both type proxies and type synonyms, you call .NormalizeExpandKeepConstraints().
        /// * Actually, that may not be enough, either. Because .NormalizeExpandKeepConstraints() may return a subset type
        ///   whose base type is what you're looking for. If you want to go all the way to the base type, then you should
        ///   call .NormalizeExpand(). This is what is done most commonly when something is trying to look for a specific type.
        /// * So, in conclusion: Usually you have to call .NormalizeExpand() on a type to unravel type proxies, type synonyms,
        ///   and subset types. But in other places (in particular, in the verifier) where you want to know about any type
        ///   constraints, then you call .NormalizeExpandKeepConstraints().
        /// </summary>
        public Type Normalize()
        {
            Contract.Ensures(Contract.Result<Type>() != null);
            Type type = this;
            while (MutateCSharp.Schemata208.ReplaceBooleanConstant_1(74L, true))
            {
                if (type is TypeProxy { T: { } proxyTarget })
                {
                    type = proxyTarget;
                }
                else
                {
                    return type;
                }
            }

            return default;
        }

        /// <summary>
        /// Return the type that "this" stands for, getting to the bottom of proxies, and then using an InternalTypeSynonym if
        /// the type is not in scope.
        ///
        /// For more documentation, see method Normalize().
        /// </summary>
        [System.Diagnostics.Contracts.Pure]
        public Type NormalizeAndAdjustForScope()
        {
            return NormalizeExpand(ExpandMode.DontExpandJustAdjustForScopes);
        }

        /// <summary>
        /// Call NormalizeExpand() repeatedly, also on the base type of newtype's.
        /// </summary>
        public Type NormalizeToAncestorType()
        {
            Type result = this;
            while (MutateCSharp.Schemata208.ReplaceBooleanConstant_1(75L, true))
            {
                result = result.NormalizeExpand();
                if (result.AsNewtype is { } newtypeDecl)
                {
                    result = newtypeDecl.ConcreteBaseType(result.TypeArgs);
                }
                else
                {
                    return result;
                }
            }

            return default;
        }

        /// <summary>
        /// Return the type that "this" stands for, getting to the bottom of proxies and following type synonyms, but does
        /// not follow subset types.
        ///
        /// For more documentation, see method Normalize().
        /// </summary>
        [System.Diagnostics.Contracts.Pure]
        public Type NormalizeExpandKeepConstraints()
        {
            return NormalizeExpand(ExpandMode.ExpandSynonymsOnly);
        }

        public Type NormalizeExpand(bool keepConstraints)
        {
            return NormalizeExpand(keepConstraints ? ExpandMode.ExpandSynonymsOnly : ExpandMode.ExpandSynonymsAndSubsetTypes);
        }

        public enum ExpandMode
        {
            DontExpandJustAdjustForScopes,
            ExpandSynonymsOnly,
            ExpandSynonymsAndSubsetTypes
        }

        public NativeType AsNativeType()
        {
            if (MutateCSharp.Schemata208.ReplaceBinExprOp_8(76L, AsNewtype, null))
            {
                return AsNewtype.NativeType;
            }
            else if (IsBitVectorType)
            {
                return AsBitVectorType.NativeType;
            }
            return null;
        }

        /// <summary>
        /// Return the type that "this" stands for, getting to the bottom of proxies and following type synonyms.
        ///
        /// For more documentation, see method Normalize().
        /// </summary>
        [System.Diagnostics.Contracts.Pure]
        public Type NormalizeExpand(ExpandMode expandMode = ExpandMode.ExpandSynonymsAndSubsetTypes)
        {
            Contract.Ensures(Contract.Result<Type>() != null);
            Contract.Ensures(!(Contract.Result<Type>() is TypeProxy) || ((TypeProxy)Contract.Result<Type>()).T == null);  // return a proxy only if .T == null

            Type type = this;
            while (MutateCSharp.Schemata208.ReplaceBooleanConstant_1(77L, true))
            {
                if (type is TypeProxy { T: not null } pt)
                {
                    type = pt.T;
                    continue;
                }

                var scope = Type.GetScope();
                var rtd = type.AsRevealableType;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_9(78L, rtd, null))
                {
                    var udt = (UserDefinedType)type;

                    if (!rtd.AsTopLevelDecl.IsVisibleInScope(scope))
                    {
                        // This can only mean "rtd" is a class/trait that is only provided, not revealed. For a provided class/trait,
                        // it is the non-null type declaration that is visible, not the class/trait declaration itself.
                        if (rtd is ClassLikeDecl cl)
                        {
                            Contract.Assert(cl.NonNullTypeDecl != null);
                            Contract.Assert(cl.NonNullTypeDecl.IsVisibleInScope(scope));
                        }
                        else
                        {
                            Contract.Assert(rtd is AbstractTypeDecl);
                        }
                    }

                    if (rtd.IsRevealedInScope(scope))
                    {
                        if (MutateCSharp.Schemata208.ReplaceBinExprOp_10(79L, expandMode, ExpandMode.DontExpandJustAdjustForScopes) && rtd is TypeSynonymDecl typeSynonymDecl)
                        {
                            if (MutateCSharp.Schemata208.ReplaceBinExprOp_7(81L, () => typeSynonymDecl is not SubsetTypeDecl, () => MutateCSharp.Schemata208.ReplaceBinExprOp_11(80L, expandMode, ExpandMode.ExpandSynonymsAndSubsetTypes)))
                            {
                                type = typeSynonymDecl.RhsWithArgumentIgnoringScope(udt.TypeArgs);
                                continue;
                            }
                        }
                        return type;
                    }
                    else
                    { // type is hidden, no more normalization is possible
                        return rtd.SelfSynonym(type.TypeArgs);
                    }
                }

                // A hidden type may become visible in another scope
                var isyn = type.AsInternalTypeSynonym;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_12(87L, isyn, null))
                {
                    var udt = (UserDefinedType)type;

                    if (!isyn.IsVisibleInScope(scope))
                    {
                        // This can only mean "isyn" refers to a class/trait that is only provided, not revealed. For a provided class/trait,
                        // it is the non-null type declaration that is visible, not the class/trait declaration itself.
                        var rhs = isyn.RhsWithArgumentIgnoringScope(udt.TypeArgs);
                        Contract.Assert(rhs is UserDefinedType);
                        var cl = ((UserDefinedType)rhs).ResolvedClass as ClassLikeDecl;
                        Contract.Assert(cl != null && cl.NonNullTypeDecl != null, rhs.ToString());
                        Contract.Assert(cl.NonNullTypeDecl.IsVisibleInScope(scope));
                    }

                    if (isyn.IsRevealedInScope(scope))
                    {
                        type = isyn.RhsWithArgument(udt.TypeArgs);
                        continue;
                    }
                    else
                    {
                        return type;
                    }
                }

                return type;
            }

            return default;
        }

        /// <summary>
        /// Return "the type that "this" stands for, getting to the bottom of proxies and following type synonyms.
        /// </summary>
        public Type UseInternalSynonym()
        {
            Contract.Ensures(Contract.Result<Type>() != null);
            Contract.Ensures(!(Contract.Result<Type>() is TypeProxy) || ((TypeProxy)Contract.Result<Type>()).T == null);  // return a proxy only if .T == null

            Type type = Normalize();
            var scope = Type.GetScope();
            var rtd = type.AsRevealableType;
            if (MutateCSharp.Schemata208.ReplaceBinExprOp_9(88L, rtd, null))
            {
                var udt = (UserDefinedType)type;
                if (!rtd.AsTopLevelDecl.IsVisibleInScope(scope))
                {
                    // This can only mean "rtd" is a class/trait that is only provided, not revealed. For a provided class/trait,
                    // it is the non-null type declaration that is visible, not the class/trait declaration itself.
                    var cl = rtd as ClassLikeDecl;
                    Contract.Assert(cl != null && cl.NonNullTypeDecl != null);
                    Contract.Assert(cl.NonNullTypeDecl.IsVisibleInScope(scope));
                }
                if (!rtd.IsRevealedInScope(scope))
                {
                    return rtd.SelfSynonym(type.TypeArgs, udt.NamePath);
                }
            }

            return type;
        }

        /// <summary>
        /// Return a type that is like "this", but where occurrences of type parameters are substituted as indicated by "subst".
        /// </summary>
        public abstract Type Subst(IDictionary<TypeParameter, Type> subst);

        /// <summary>
        /// Return a type that is like "type", but with type arguments "arguments".
        /// </summary>
        public abstract Type ReplaceTypeArguments(List<Type> arguments);

        /// <summary>
        /// Returns whether or not "this" and "that" denote the same type, modulo proxies and type synonyms and subset types.
        /// </summary>
        [System.Diagnostics.Contracts.Pure]
        public abstract bool Equals(Type that, bool keepConstraints = false);

        public bool IsBoolType => NormalizeExpand() is BoolType;
        public bool IsCharType => NormalizeExpand() is CharType;
        public bool IsIntegerType => NormalizeExpand() is IntType;
        public bool IsRealType => NormalizeExpand() is RealType;
        public bool IsBigOrdinalType => NormalizeExpand() is BigOrdinalType;
        public bool IsBitVectorType => MutateCSharp.Schemata208.ReplaceBinExprOp_13(89L, AsBitVectorType, null);
        public bool IsStringType => MutateCSharp.Schemata208.ReplaceBinExprOp_14(91L, AsSeqType?.Arg.IsCharType, MutateCSharp.Schemata208.ReplaceBooleanConstant_1(90L, true));
        public BitvectorType AsBitVectorType => NormalizeExpand() as BitvectorType;

        public bool IsNumericBased()
        {
            var t = NormalizeExpand();
            return MutateCSharp.Schemata208.ReplaceBinExprOp_7(100L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(92L, () => t.IsIntegerType, () => t.IsRealType), () => MutateCSharp.Schemata208.ReplaceBinExprOp_14(99L, t.AsNewtype?.BaseType.IsNumericBased(), MutateCSharp.Schemata208.ReplaceBooleanConstant_1(98L, true)));
        }
        public enum NumericPersuasion { Int, Real }
        [System.Diagnostics.Contracts.Pure]
        public bool IsNumericBased(NumericPersuasion p)
        {
            Type t = this;
            while (MutateCSharp.Schemata208.ReplaceBooleanConstant_1(106L, true))
            {
                t = t.NormalizeExpand();
                if (t.IsIntegerType)
                {
                    return MutateCSharp.Schemata208.ReplaceBinExprOp_15(107L, p, NumericPersuasion.Int);
                }
                else if (t.IsRealType)
                {
                    return MutateCSharp.Schemata208.ReplaceBinExprOp_15(108L, p, NumericPersuasion.Real);
                }
                var d = t.AsNewtype;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_16(109L, d, null))
                {
                    return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(110L, false);
                }
                t = d.BaseType;
            }

            return default;
        }

        /// <summary>
        /// Returns true if the type has two representations at run time, the ordinary representation and a
        /// "fat pointer" representation (which is a boxing of the ordinary representation, plus a vtable pointer).
        /// </summary>
        public bool HasFatPointer => NormalizeExpand() is UserDefinedType { ResolvedClass: NewtypeDecl { ParentTraits: { Count: > 0 } } };

        /// <summary>
        /// This property returns true if the type is known to be nonempty.
        /// This property should be used only after successful resolution. It is assumed that all type proxies have
        /// been resolved and that all recursion through types comes to an end.
        /// Note, HasCompilableValue ==> IsNonEmpty.
        /// </summary>
        public bool IsNonempty => MutateCSharp.Schemata208.ReplaceBinExprOp_17(111L, GetAutoInit(), AutoInitInfo.MaybeEmpty);

        /// <summary>
        /// This property returns true if the type has a known compilable value.
        /// This property should be used only after successful resolution. It is assumed that all type proxies have
        /// been resolved and that all recursion through types comes to an end.
        /// Note, HasCompilableValue ==> IsNonEmpty.
        /// </summary>
        public bool HasCompilableValue => MutateCSharp.Schemata208.ReplaceBinExprOp_18(112L, GetAutoInit(), AutoInitInfo.CompilableValue);

        public bool KnownToHaveToAValue(bool ghostContext)
        {
            return ghostContext ? IsNonempty : HasCompilableValue;
        }

        public enum AutoInitInfo { MaybeEmpty, Nonempty, CompilableValue }

        public bool HavocCountsAsDefiniteAssignment(bool inGhostContext)
        {
            return inGhostContext ? IsNonempty : HasCompilableValue;
        }

        /// <summary>
        /// This property returns
        ///     - CompilableValue, if the type has a known compilable value
        ///     - Nonempty,        if the type is known to contain some value
        ///     - MaybeEmpty,      otherwise
        /// This property should be used only after successful resolution. It is assumed that all type proxies have
        /// been resolved and that all recursion through types comes to an end.
        /// </summary>
        public AutoInitInfo GetAutoInit(List<UserDefinedType>/*?*/ coDatatypesBeingVisited = null)
        {
            var t = NormalizeExpandKeepConstraints();
            Contract.Assume(t is NonProxyType); // precondition

            AutoInitInfo CharacteristicToAutoInitInfo(TypeParameter.TypeParameterCharacteristics c)
            {
                if (c.HasCompiledValue)
                {
                    return AutoInitInfo.CompilableValue;
                }
                else if (c.IsNonempty)
                {
                    return AutoInitInfo.Nonempty;
                }
                else
                {
                    return AutoInitInfo.MaybeEmpty;
                }

                return default;
            }

            if (MutateCSharp.Schemata208.ReplaceBinExprOp_7(137L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(131L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(125L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(119L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(113L, () => t is BoolType, () => t is CharType), () => t is IntType), () => t is BigOrdinalType), () => t is RealType), () => t is BitvectorType))
            {
                return AutoInitInfo.CompilableValue;
            }
            else if (t is CollectionType)
            {
                return AutoInitInfo.CompilableValue;
            }

            var udt = (UserDefinedType)t;
            var cl = udt.ResolvedClass;
            Contract.Assert(cl != null);
            if (cl is AbstractTypeDecl)
            {
                var otd = (AbstractTypeDecl)cl;
                return CharacteristicToAutoInitInfo(otd.Characteristics);
            }
            else if (cl is TypeParameter)
            {
                var tp = (TypeParameter)cl;
                return CharacteristicToAutoInitInfo(tp.Characteristics);
            }
            else if (cl is InternalTypeSynonymDecl)
            {
                var isyn = (InternalTypeSynonymDecl)cl;
                return CharacteristicToAutoInitInfo(isyn.Characteristics);
            }
            else if (cl is NewtypeDecl)
            {
                var td = (NewtypeDecl)cl;
                switch (td.WitnessKind)
                {
                    case SubsetTypeDecl.WKind.CompiledZero:
                    case SubsetTypeDecl.WKind.Compiled:
                        return AutoInitInfo.CompilableValue;
                        break;
                    case SubsetTypeDecl.WKind.Ghost:
                        return AutoInitInfo.Nonempty;
                        break;
                    case SubsetTypeDecl.WKind.OptOut:
                        return AutoInitInfo.MaybeEmpty;
                        break;
                    case SubsetTypeDecl.WKind.Special:
                    default:
                        Contract.Assert(false); // unexpected case
                        throw new cce.UnreachableException();
                        break;
                }
            }
            else if (cl is SubsetTypeDecl)
            {
                var td = (SubsetTypeDecl)cl;
                switch (td.WitnessKind)
                {
                    case SubsetTypeDecl.WKind.CompiledZero:
                    case SubsetTypeDecl.WKind.Compiled:
                        return AutoInitInfo.CompilableValue;
                        break;
                    case SubsetTypeDecl.WKind.Ghost:
                        return AutoInitInfo.Nonempty;
                        break;
                    case SubsetTypeDecl.WKind.OptOut:
                        return AutoInitInfo.MaybeEmpty;
                        break;
                    case SubsetTypeDecl.WKind.Special:
                        // WKind.Special is only used with -->, ->, and non-null types:
                        Contract.Assert(ArrowType.IsPartialArrowTypeName(td.Name) || ArrowType.IsTotalArrowTypeName(td.Name) || td is NonNullTypeDecl);
                        if (ArrowType.IsPartialArrowTypeName(td.Name))
                        {
                            // partial arrow
                            return AutoInitInfo.CompilableValue;
                        }
                        else if (ArrowType.IsTotalArrowTypeName(td.Name))
                        {
                            // total arrow
                            return udt.TypeArgs.Last().GetAutoInit(coDatatypesBeingVisited);
                        }
                        else if (((NonNullTypeDecl)td).Class is ArrayClassDecl)
                        {
                            // non-null array type; we know how to initialize them
                            return AutoInitInfo.CompilableValue;
                        }
                        else
                        {
                            // non-null (non-array) type
                            return AutoInitInfo.MaybeEmpty;
                        }

                        break;
                    default:
                        Contract.Assert(false); // unexpected case
                        throw new cce.UnreachableException();
                        break;
                }
            }
            else if (cl is TraitDecl traitDecl)
            {
                return traitDecl.IsReferenceTypeDecl ? AutoInitInfo.CompilableValue : AutoInitInfo.MaybeEmpty;
            }
            else if (cl is ClassDecl)
            {
                return AutoInitInfo.CompilableValue; // null is a value of this type
            }
            else if (cl is ArrowTypeDecl)
            {
                return AutoInitInfo.CompilableValue;
            }
            else if (cl is DatatypeDecl)
            {
                var dt = (DatatypeDecl)cl;
                var subst = TypeParameter.SubstitutionMap(dt.TypeArgs, udt.TypeArgs);
                var r = AutoInitInfo.CompilableValue;  // assume it's compilable, until we find out otherwise
                if (cl is CoDatatypeDecl)
                {
                    if (MutateCSharp.Schemata208.ReplaceBinExprOp_19(143L, coDatatypesBeingVisited, null))
                    {
                        if (coDatatypesBeingVisited.Exists(coType => udt.Equals(coType)))
                        {
                            // This can be compiled into a lazy constructor call
                            return AutoInitInfo.CompilableValue;
                        }
                        else if (coDatatypesBeingVisited.Exists(coType => MutateCSharp.Schemata208.ReplaceBinExprOp_20(144L, dt, coType.ResolvedClass)))
                        {
                            // This requires more recursion and bookkeeping than we care to try out
                            return AutoInitInfo.MaybeEmpty;
                        }
                        coDatatypesBeingVisited = new List<UserDefinedType>(coDatatypesBeingVisited);
                    }
                    else
                    {
                        coDatatypesBeingVisited = new List<UserDefinedType>();
                    }
                    coDatatypesBeingVisited.Add(udt);
                }
                foreach (var formal in dt.GetGroundingCtor().Formals)
                {
                    var autoInit = formal.Type.Subst(subst).GetAutoInit(coDatatypesBeingVisited);
                    if (MutateCSharp.Schemata208.ReplaceBinExprOp_18(145L, autoInit, AutoInitInfo.MaybeEmpty))
                    {
                        return AutoInitInfo.MaybeEmpty;
                    }
                    else if (formal.IsGhost)
                    {
                        // cool
                    }
                    else if (MutateCSharp.Schemata208.ReplaceBinExprOp_18(146L, autoInit, AutoInitInfo.CompilableValue))
                    {
                        // cool
                    }
                    else
                    {
                        r = AutoInitInfo.Nonempty;
                    }
                }
                return r;
            }
            else
            {
                Contract.Assert(false); // unexpected type
                throw new cce.UnreachableException();
            }

            return default;
        }

        public bool HasFinitePossibleValues
        {
            get
            {
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_7(153L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(147L, () => IsBoolType, () => IsCharType), () => IsRefType))
                {
                    return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(159L, true);
                }
                var st = AsSetType;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_5(161L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_21(160L, st, null), () => st.Arg.HasFinitePossibleValues))
                {
                    return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(167L, true);
                }
                var mt = AsMapType;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_5(169L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_22(168L, mt, null), () => mt.Domain.HasFinitePossibleValues))
                {
                    return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(175L, true);
                }
                var dt = AsDatatype;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_5(177L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_23(176L, dt, null), () => dt.HasFinitePossibleValues))
                {
                    return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(183L, true);
                }
                return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(184L, false);
            }
        }

        public CollectionType AsCollectionType
        {
            get { return NormalizeExpand() as CollectionType; }
        }

        public SetType AsSetType
        {
            get { return NormalizeExpand() as SetType; }
        }

        public MultiSetType AsMultiSetType
        {
            get { return NormalizeExpand() as MultiSetType; }
        }

        public SeqType AsSeqType
        {
            get { return NormalizeExpand() as SeqType; }
        }

        public MapType AsMapType
        {
            get { return NormalizeExpand() as MapType; }
        }

        public bool IsRefType
        {
            get
            {
                return NormalizeExpand() is UserDefinedType { ResolvedClass: ClassLikeDecl { IsReferenceTypeDecl: true } };
            }
        }

        public bool IsTopLevelTypeWithMembers
        {
            get
            {
                return MutateCSharp.Schemata208.ReplaceBinExprOp_24(185L, AsTopLevelTypeWithMembers, null);
            }
        }

        public TopLevelDeclWithMembers/*?*/ AsTopLevelTypeWithMembers
        {
            get
            {
                var udt = NormalizeExpand() as UserDefinedType;
                return udt?.ResolvedClass as TopLevelDeclWithMembers;
            }
        }

        public TopLevelDeclWithMembers/*?*/ AsTopLevelTypeWithMembersBypassInternalSynonym
        {
            get
            {
                var udt = NormalizeExpand() as UserDefinedType;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_25(186L, udt, null) && udt.ResolvedClass is InternalTypeSynonymDecl isyn)
                {
                    udt = isyn.RhsWithArgumentIgnoringScope(udt.TypeArgs) as UserDefinedType;
                    if (udt?.ResolvedClass is NonNullTypeDecl nntd)
                    {
                        return nntd.Class;
                    }
                }
                return udt?.ResolvedClass as TopLevelDeclWithMembers;
            }
        }

        /// <summary>
        /// Returns "true" if the type represents the type "object?".
        /// </summary>
        public bool IsObjectQ
        {
            get
            {
                return NormalizeExpandKeepConstraints() is UserDefinedType { ResolvedClass: TraitDecl { IsObjectTrait: true } };
            }
        }

        /// <summary>
        /// Returns "true" if the type represents the type "object".
        /// </summary>
        public bool IsObject
        {
            get
            {
                var nn = AsNonNullRefType;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_25(187L, nn, null))
                {
                    var nonNullRefDecl = (NonNullTypeDecl)nn.ResolvedClass;
                    return nonNullRefDecl.Class is TraitDecl { IsObjectTrait: true };
                }
                return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(188L, false);
            }
        }

        /// <summary>
        /// Returns "true" if the type is a non-null type or any subset type thereof.
        /// </summary>
        public bool IsNonNullRefType
        {
            get
            {
                return MutateCSharp.Schemata208.ReplaceBinExprOp_25(189L, AsNonNullRefType, null);
            }
        }

        /// <summary>
        /// If the type is a non-null type or any subset type thereof, return the UserDefinedType whose
        /// .ResolvedClass value is a NonNullTypeDecl.
        /// Otherwise, return "null".
        /// </summary>
        public UserDefinedType AsNonNullRefType
        {
            get
            {
                var t = this;
                while (MutateCSharp.Schemata208.ReplaceBooleanConstant_1(190L, true))
                {
                    if (t.NormalizeExpandKeepConstraints() is not UserDefinedType udt)
                    {
                        return null;
                    }
                    if (udt.ResolvedClass is NonNullTypeDecl)
                    {
                        return udt;
                    }
                    if (udt.ResolvedClass is SubsetTypeDecl sst)
                    {
                        t = sst.RhsWithArgument(udt.TypeArgs);  // continue the search up the chain of subset types
                    }
                    else
                    {
                        return null;
                    }
                }

                return default;
            }
        }

        /// <summary>
        /// Returns the type "parent<X>", where "X" is a list of type parameters that makes "parent<X>" a supertype of "this".
        /// Requires "this" to be some type "C<Y>" and "parent" to be among the reflexive, transitive parent traits of "C".
        /// </summary>
        public UserDefinedType AsParentType(TopLevelDecl parent)
        {
            Contract.Requires(parent != null);

            var udt = (UserDefinedType)NormalizeExpand();
            if (udt.ResolvedClass is InternalTypeSynonymDecl isyn)
            {
                udt = (UserDefinedType)isyn.RhsWithArgumentIgnoringScope(udt.TypeArgs);
            }
            TopLevelDeclWithMembers cl;
            if (udt.ResolvedClass is NonNullTypeDecl nntd)
            {
                cl = (TopLevelDeclWithMembers)nntd.ViewAsClass;
            }
            else
            {
                cl = (TopLevelDeclWithMembers)udt.ResolvedClass;
            }
            if (MutateCSharp.Schemata208.ReplaceBinExprOp_26(191L, cl, parent))
            {
                return udt;
            }
            var typeMapParents = cl.ParentFormalTypeParametersToActuals;
            var typeMapUdt = TypeParameter.SubstitutionMap(cl.TypeArgs, udt.TypeArgs);
            var typeArgs = parent.TypeArgs.ConvertAll(tp => typeMapParents[tp].Subst(typeMapUdt));
            return new UserDefinedType(udt.tok, parent.Name, parent, typeArgs);
        }

        public bool IsTraitType => MutateCSharp.Schemata208.ReplaceBinExprOp_27(192L, AsTraitType, null);
        public TraitDecl/*?*/ AsTraitType
        {
            get
            {
                var udt = NormalizeExpand() as UserDefinedType;
                return udt?.ResolvedClass as TraitDecl;
            }
        }

        public SubsetTypeDecl /*?*/ AsSubsetType
        {
            get
            {
                var std = NormalizeExpand(MutateCSharp.Schemata208.ReplaceBooleanConstant_1(193L, true)) as UserDefinedType;
                return std?.ResolvedClass as SubsetTypeDecl;
            }
        }

        public bool IsArrayType
        {
            get
            {
                return MutateCSharp.Schemata208.ReplaceBinExprOp_28(194L, AsArrayType, null);
            }
        }

        public ArrayClassDecl/*?*/ AsArrayType
        {
            get
            {
                var udt = UserDefinedType.DenotesClass(this);
                return udt?.ResolvedClass as ArrayClassDecl;
            }
        }

        /// <summary>
        /// Returns "true" if the type is one of the 3 built-in arrow types.
        /// </summary>
        public bool IsBuiltinArrowType
        {
            get
            {
                var t = Normalize();  // but don't expand synonyms or strip off constraints
                if (t is ArrowType)
                {
                    return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(195L, true);
                }
                var udt = t as UserDefinedType;
                return MutateCSharp.Schemata208.ReplaceBinExprOp_5(203L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_25(196L, udt, null), () => (MutateCSharp.Schemata208.ReplaceBinExprOp_7(197L, () => ArrowType.IsPartialArrowTypeName(udt.Name), () => ArrowType.IsTotalArrowTypeName(udt.Name))));
            }
        }

        /// <summary>
        /// Returns "true" if the type is a partial arrow or any subset type thereof.
        /// </summary>
        public bool IsArrowTypeWithoutReadEffects
        {
            get
            {
                var t = this;
                while (MutateCSharp.Schemata208.ReplaceBooleanConstant_1(209L, true))
                {
                    var udt = t.NormalizeExpandKeepConstraints() as UserDefinedType;
                    if (MutateCSharp.Schemata208.ReplaceBinExprOp_29(210L, udt, null))
                    {
                        return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(211L, false);
                    }
                    else if (ArrowType.IsPartialArrowTypeName(udt.Name))
                    {
                        return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(212L, true);
                    }
                    var sst = udt.ResolvedClass as SubsetTypeDecl;
                    if (MutateCSharp.Schemata208.ReplaceBinExprOp_30(213L, sst, null))
                    {
                        t = sst.RhsWithArgument(udt.TypeArgs);  // continue the search up the chain of subset types
                    }
                    else
                    {
                        return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(214L, false);
                    }
                }

                return default;
            }
        }

        /// <summary>
        /// Returns "true" if the type is a total arrow or any subset type thereof.
        /// </summary>
        public bool IsArrowTypeWithoutPreconditions
        {
            get
            {
                var t = this;
                while (MutateCSharp.Schemata208.ReplaceBooleanConstant_1(215L, true))
                {
                    var udt = t.NormalizeExpandKeepConstraints() as UserDefinedType;
                    if (MutateCSharp.Schemata208.ReplaceBinExprOp_29(216L, udt, null))
                    {
                        return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(217L, false);
                    }
                    else if (ArrowType.IsTotalArrowTypeName(udt.Name))
                    {
                        return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(218L, true);
                    }
                    var sst = udt.ResolvedClass as SubsetTypeDecl;
                    if (MutateCSharp.Schemata208.ReplaceBinExprOp_30(219L, sst, null))
                    {
                        t = sst.RhsWithArgument(udt.TypeArgs);  // continue the search up the chain of subset types
                    }
                    else
                    {
                        return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(220L, false);
                    }
                }

                return default;
            }
        }

        public bool IsArrowType => MutateCSharp.Schemata208.ReplaceBinExprOp_31(221L, AsArrowType, null);

        public ArrowType AsArrowType => NormalizeExpand() as ArrowType;

        public bool IsMapType => NormalizeExpand() is MapType { Finite: true };

        public bool IsIMapType => NormalizeExpand() is MapType { Finite: false };

        public bool IsISetType => NormalizeExpand() is SetType { Finite: false };

        public NewtypeDecl AsNewtype
        {
            get
            {
                var udt = NormalizeExpand() as UserDefinedType;
                return udt?.ResolvedClass as NewtypeDecl;
            }
        }

        public TypeSynonymDecl AsTypeSynonym
        {
            get
            {
                var udt = this as UserDefinedType;  // note, it is important to use 'this' here, not 'this.NormalizeExpand()'
                return udt?.ResolvedClass as TypeSynonymDecl;
            }
        }

        public InternalTypeSynonymDecl AsInternalTypeSynonym
        {
            get
            {
                var udt = this as UserDefinedType;  // note, it is important to use 'this' here, not 'this.NormalizeExpand()'
                return udt?.ResolvedClass as InternalTypeSynonymDecl;
            }
        }

        public RedirectingTypeDecl AsRedirectingType
        {
            get
            {
                var udt = this as UserDefinedType;  // Note, it is important to use 'this' here, not 'this.NormalizeExpand()'.  This property getter is intended to be used during resolution, or with care thereafter.
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_29(222L, udt, null))
                {
                    return null;
                }
                else
                {
                    return (RedirectingTypeDecl)(udt.ResolvedClass as TypeSynonymDecl) ?? udt.ResolvedClass as NewtypeDecl;
                }

                return default;
            }
        }

        public RevealableTypeDecl AsRevealableType
        {
            get
            {
                var udt = this as UserDefinedType;
                return udt?.ResolvedClass as RevealableTypeDecl;
            }
        }

        public bool IsRevealableType => MutateCSharp.Schemata208.ReplaceBinExprOp_9(223L, AsRevealableType, null);

        public bool IsDatatype => MutateCSharp.Schemata208.ReplaceBinExprOp_23(224L, AsDatatype, null);

        public DatatypeDecl AsDatatype
        {
            get
            {
                var udt = NormalizeExpand() as UserDefinedType;
                return udt?.ResolvedClass as DatatypeDecl;
            }
        }

        public bool IsIndDatatype => MutateCSharp.Schemata208.ReplaceBinExprOp_32(225L, AsIndDatatype, null);

        public IndDatatypeDecl AsIndDatatype
        {
            get
            {
                var udt = NormalizeExpand() as UserDefinedType;
                return udt?.ResolvedClass as IndDatatypeDecl;
            }
        }

        public bool IsCoDatatype => MutateCSharp.Schemata208.ReplaceBinExprOp_33(226L, AsCoDatatype, null);

        public CoDatatypeDecl AsCoDatatype
        {
            get
            {
                var udt = NormalizeExpand() as UserDefinedType;
                return udt?.ResolvedClass as CoDatatypeDecl;
            }
        }

        public bool InvolvesCoDatatype
        {
            get
            {
                return IsCoDatatype;  // TODO: should really check structure of the type recursively
            }
        }

        public bool IsTypeParameter => MutateCSharp.Schemata208.ReplaceBinExprOp_34(227L, AsTypeParameter, null);

        public bool IsInternalTypeSynonym => MutateCSharp.Schemata208.ReplaceBinExprOp_12(228L, AsInternalTypeSynonym, null);

        public TypeParameter AsTypeParameter
        {
            get
            {
                var ct = NormalizeExpandKeepConstraints() as UserDefinedType;
                return ct?.ResolvedClass as TypeParameter;
            }
        }

        public bool IsAbstractType => MutateCSharp.Schemata208.ReplaceBinExprOp_35(229L, AsAbstractType, null);

        public AbstractTypeDecl AsAbstractType
        {
            get
            {
                var udt = this.Normalize() as UserDefinedType;  // note, it is important to use 'this.Normalize()' here, not 'this.NormalizeExpand()'
                return udt?.ResolvedClass as AbstractTypeDecl;
            }
        }

        /// <summary>
        /// Returns whether or not any values of the type can be checked for equality in compiled contexts
        /// </summary>
        public virtual bool SupportsEquality => MutateCSharp.Schemata208.ReplaceBooleanConstant_1(230L, true);

        /// <summary>
        /// Returns whether or not some values of the type can be checked for equality in compiled contexts.
        /// This differs from SupportsEquality for types where the equality operation is partial, e.g.,
        /// for datatypes where some, but not all, constructors are ghost.
        /// Note, whereas SupportsEquality sometimes consults some constituent type for SupportEquality
        /// (e.g., seq<T> supports equality if T does), PartiallySupportsEquality does not (because the
        /// semantic check would be more complicated and it currently doesn't seem worth the trouble).
        /// </summary>
        public virtual bool PartiallySupportsEquality => SupportsEquality;

        public bool MayInvolveReferences => ComputeMayInvolveReferences(null);

        /// <summary>
        /// This is an auxiliary method used to compute the value of MayInvolveReferences (above). It is
        /// needed to handle datatypes, because determining whether or not a datatype contains references
        /// involves recursing over the types in the datatype's constructor parameters. Since those types
        /// may be mutually dependent on the datatype itself, care must be taken to avoid infinite recursion.
        ///
        /// Parameter visitedDatatypes is used to prevent infinite recursion. It is passed in as null
        /// (the "first phase") as long as no datatype has been encountered. From the time a first datatype
        /// is encountered and through all subsequent recursive calls to ComputeMayInvolveReferences that
        /// are performed on the types of the parameters of the datatype's constructors, the method enters
        /// a "second phase", where visitedDatatypes is passed in as a set that records all datatypes visited.
        /// By not recursing through a datatype that's already being visited, infinite recursion is prevented.
        ///
        /// The type parameters to recursive uses of datatypes may be passed in in different ways. In fact,
        /// there is no bound on the set of different instantiations one can encounter with the recursive uses
        /// of the datatypes. Rather than keeping track of type instantiations in (some variation of)
        /// visitedDatatypes, the type arguments passed to a datatype are checked separately. If the datatype
        /// uses all the type parameters it declares, then this will have the same effect. During the second
        /// phase, formal type parameters (which necessarily are ones declared in datatypes) are ignored.
        /// </summary>
        public abstract bool ComputeMayInvolveReferences(ISet<DatatypeDecl> /*?*/ visitedDatatypes);

        /// <summary>
        /// Returns true if it is known how to meaningfully compare the type's inhabitants.
        /// </summary>
        public bool IsOrdered
        {
            get
            {
                var ct = NormalizeExpand();
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_7(267L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(261L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(255L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(249L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(243L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(237L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(231L, () => ct.IsTypeParameter, () => ct.IsAbstractType), () => ct.IsInternalTypeSynonym), () => ct.IsCoDatatype), () => ct.IsArrowType), () => ct.IsIMapType), () => ct.IsISetType), () => ct is UserDefinedType { ResolvedClass: TraitDecl { IsReferenceTypeDecl: false } }))
                {
                    return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(273L, false);
                }
                return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(274L, true);
            }
        }

        /// <summary>
        /// Returns "true" iff "sub" is a subtype of "super".
        /// Expects that neither "super" nor "sub" is an unresolved proxy.
        /// </summary>
        public static bool IsSupertype(Type super, Type sub)
        {
            Contract.Requires(super != null);
            Contract.Requires(sub != null);
            return sub.IsSubtypeOf(super, MutateCSharp.Schemata208.ReplaceBooleanConstant_1(275L, false), MutateCSharp.Schemata208.ReplaceBooleanConstant_1(276L, false));
        }

        /// <summary>
        /// Expects that "type" has already been normalized.
        /// </summary>
        public static List<TypeParameter.TPVariance> GetPolarities(Type type)
        {
            Contract.Requires(type != null);
            if (MutateCSharp.Schemata208.ReplaceBinExprOp_7(277L, () => type is BasicType, () => type is ArtificialType))
            {
                // there are no type parameters
                return new List<TypeParameter.TPVariance>();
            }
            else if (type is MapType)
            {
                return new List<TypeParameter.TPVariance> { TypeParameter.TPVariance.Co, TypeParameter.TPVariance.Co };
            }
            else if (type is CollectionType)
            {
                return new List<TypeParameter.TPVariance> { TypeParameter.TPVariance.Co };
            }
            else
            {
                var udf = (UserDefinedType)type;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_36(287L, udf.TypeArgs.Count, MutateCSharp.Schemata208.ReplaceNumericConstant_2(283L, 0)))
                {
                    return new List<TypeParameter.TPVariance>();
                }
                // look up the declaration of the formal type parameters
                var cl = udf.ResolvedClass;
                return cl.TypeArgs.ConvertAll(tp => tp.Variance);
            }

            return default;
        }

        public static bool FromSameHead_Subtype(Type t, Type u, out Type a, out Type b)
        {
            Contract.Requires(t != null);
            Contract.Requires(u != null);
            if (FromSameHead(t, u, out a, out b))
            {
                return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(292L, true);
            }
            t = t.NormalizeExpand();
            u = u.NormalizeExpand();
            if (MutateCSharp.Schemata208.ReplaceBinExprOp_5(293L, () => t.IsRefType, () => u.IsRefType))
            {
                if (t.IsObjectQ)
                {
                    a = b = t;
                    return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(299L, true);
                }
                else if (u.IsObjectQ)
                {
                    a = b = u;
                    return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(300L, true);
                }
                var tt = ((UserDefinedType)t).ResolvedClass as ClassLikeDecl;
                var uu = ((UserDefinedType)u).ResolvedClass as ClassLikeDecl;
                if (uu.HeadDerivesFrom(tt))
                {
                    a = b = t;
                    return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(301L, true);
                }
                else if (tt.HeadDerivesFrom(uu))
                {
                    a = b = u;
                    return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(302L, true);
                }
            }
            return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(303L, false);
        }

        public static bool FromSameHead(Type t, Type u, out Type a, out Type b)
        {
            a = t;
            b = u;
            var towerA = GetTowerOfSubsetTypes(a);
            var towerB = GetTowerOfSubsetTypes(b);
            for (var n = Math.Min(towerA.Count, towerB.Count); MutateCSharp.Schemata208.ReplaceBinExprOp_38(312L, MutateCSharp.Schemata208.ReplaceNumericConstant_2(304L, 0), MutateCSharp.Schemata208.ReplacePrefixUnaryExprOp_37(308L, ref n));)
            {
                a = towerA[n];
                b = towerB[n];
                if (SameHead(a, b))
                {
                    return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(317L, true);
                }
            }
            return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(318L, false);
        }

        /// <summary>
        /// Returns true if t and u have the same head type.
        /// It is assumed that t and u have been normalized and expanded by the caller, according
        /// to its purposes.
        /// The value of "allowNonNull" matters only if both "t" and "u" denote reference types.
        /// If "t" is a non-null reference type "T" or a possibly-null type "T?"
        /// and "u" is a non-null reference type "U" or a possibly-null type "U?", then
        /// SameHead returns:
        ///            !allowNonNull     allowNonNull
        ///   T?  U?        true           true
        ///   T?  U         false          true
        ///   T   U?        false          false
        ///   T   U         true           true
        /// </summary>
        public static bool SameHead(Type t, Type u)
        {
            Contract.Requires(t != null);
            Contract.Requires(u != null);
            if (t is TypeProxy)
            {
                return MutateCSharp.Schemata208.ReplaceBinExprOp_39(319L, t, u);
            }
            else if (MutateCSharp.Schemata208.ReplaceBinExprOp_36(324L, t.TypeArgs.Count, MutateCSharp.Schemata208.ReplaceNumericConstant_2(320L, 0)))
            {
                return Equal_Improved(t, u);
            }
            else if (t is SetType)
            {
                return MutateCSharp.Schemata208.ReplaceBinExprOp_5(335L, () => u is SetType, () => MutateCSharp.Schemata208.ReplaceBinExprOp_40(329L, () => t.IsISetType, () => u.IsISetType));
            }
            else if (t is SeqType)
            {
                return u is SeqType;
            }
            else if (t is MultiSetType)
            {
                return u is MultiSetType;
            }
            else if (t is MapType)
            {
                return MutateCSharp.Schemata208.ReplaceBinExprOp_5(347L, () => u is MapType, () => MutateCSharp.Schemata208.ReplaceBinExprOp_40(341L, () => t.IsIMapType, () => u.IsIMapType));
            }
            else
            {
                var udtT = (UserDefinedType)t;
                var udtU = u as UserDefinedType;
                return MutateCSharp.Schemata208.ReplaceBinExprOp_5(355L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_25(353L, udtU, null), () => MutateCSharp.Schemata208.ReplaceBinExprOp_41(354L, udtT.ResolvedClass, udtU.ResolvedClass));
            }

            return default;
        }

        /// <summary>
        /// Returns "true" iff the head symbols of "sub" can be a subtype of the head symbol of "super".
        /// Expects that neither "super" nor "sub" is an unresolved proxy type (but their type arguments are
        /// allowed to be, since this method does not inspect the type arguments).
        /// </summary>
        public static bool IsHeadSupertypeOf(Type super, Type sub)
        {
            Contract.Requires(super != null);
            Contract.Requires(sub != null);
            super = super.NormalizeExpandKeepConstraints();  // expand type synonyms
            var origSub = sub;
            sub = sub.NormalizeExpand();  // expand type synonyms AND constraints
            if (super is TypeProxy)
            {
                return MutateCSharp.Schemata208.ReplaceBinExprOp_39(361L, super, sub);
            }
            else if (super is BoolType)
            {
                return sub is BoolType;
            }
            else if (super is CharType)
            {
                return sub is CharType;
            }
            else if (super is IntType)
            {
                return sub is IntType;
            }
            else if (super is RealType)
            {
                return sub is RealType;
            }
            else if (super is BitvectorType)
            {
                var bitvectorSuper = (BitvectorType)super;
                var bitvectorSub = sub as BitvectorType;
                return MutateCSharp.Schemata208.ReplaceBinExprOp_5(368L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_13(362L, bitvectorSub, null), () => MutateCSharp.Schemata208.ReplaceBinExprOp_36(363L, bitvectorSuper.Width, bitvectorSub.Width));
            }
            else if (super is IntVarietiesSupertype)
            {
                while (MutateCSharp.Schemata208.ReplaceBinExprOp_8(374L, sub.AsNewtype, null))
                {
                    sub = sub.AsNewtype.BaseType.NormalizeExpand();
                }
                return MutateCSharp.Schemata208.ReplaceBinExprOp_7(381L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(375L, () => sub.IsIntegerType, () => sub is BitvectorType), () => sub is BigOrdinalType);
            }
            else if (super is RealVarietiesSupertype)
            {
                while (MutateCSharp.Schemata208.ReplaceBinExprOp_8(387L, sub.AsNewtype, null))
                {
                    sub = sub.AsNewtype.BaseType.NormalizeExpand();
                }
                return sub is RealType;
            }
            else if (super is BigOrdinalType)
            {
                return sub is BigOrdinalType;
            }
            else if (super is SetType)
            {
                return MutateCSharp.Schemata208.ReplaceBinExprOp_5(394L, () => sub is SetType, () => (MutateCSharp.Schemata208.ReplaceBinExprOp_7(388L, () => super.IsISetType, () => !sub.IsISetType)));
            }
            else if (super is SeqType)
            {
                return sub is SeqType;
            }
            else if (super is MultiSetType)
            {
                return sub is MultiSetType;
            }
            else if (super is MapType)
            {
                return MutateCSharp.Schemata208.ReplaceBinExprOp_5(406L, () => sub is MapType, () => (MutateCSharp.Schemata208.ReplaceBinExprOp_7(400L, () => super.IsIMapType, () => !sub.IsIMapType)));
            }
            else if (super is ArrowType)
            {
                var asuper = (ArrowType)super;
                var asub = sub as ArrowType;
                return MutateCSharp.Schemata208.ReplaceBinExprOp_5(418L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_31(412L, asub, null), () => MutateCSharp.Schemata208.ReplaceBinExprOp_36(413L, asuper.Arity, asub.Arity));
            }
            else if (super.IsObjectQ)
            {
                return sub.IsObjectQ || (sub is UserDefinedType { ResolvedClass: ClassLikeDecl cl } && cl.IsReferenceTypeDecl);
            }
            else if (super is UserDefinedType)
            {
                var udtSuper = (UserDefinedType)super;
                Contract.Assert(udtSuper.ResolvedClass != null);
                if (udtSuper.ResolvedClass is TypeParameter)
                {
                    return MutateCSharp.Schemata208.ReplaceBinExprOp_42(424L, udtSuper.ResolvedClass, sub.AsTypeParameter);
                }
                else
                {
                    sub = origSub;  // get back to the starting point
                    while (MutateCSharp.Schemata208.ReplaceBooleanConstant_1(425L, true))
                    {
                        sub = sub.NormalizeExpandKeepConstraints();  // skip past proxies and type synonyms
                        var udtSub = sub as UserDefinedType;
                        if (MutateCSharp.Schemata208.ReplaceBinExprOp_29(426L, udtSub, null))
                        {
                            return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(427L, false);
                        }
                        else if (MutateCSharp.Schemata208.ReplaceBinExprOp_41(428L, udtSuper.ResolvedClass, udtSub.ResolvedClass))
                        {
                            return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(429L, true);
                        }
                        else if (udtSub.ResolvedClass is SubsetTypeDecl)
                        {
                            sub = ((SubsetTypeDecl)udtSub.ResolvedClass).RhsWithArgument(udtSub.TypeArgs);
                            if (MutateCSharp.Schemata208.ReplaceBinExprOp_5(430L, () => udtSub.ResolvedClass is NonNullTypeDecl, () => udtSuper.ResolvedClass is NonNullTypeDecl))
                            {
                                // move "super" up the base-type chain, as was done with "sub", because non-nullness is essentially a co-variant type constructor
                                var possiblyNullSuper = ((SubsetTypeDecl)udtSuper.ResolvedClass).RhsWithArgument(udtSuper.TypeArgs);
                                udtSuper = (UserDefinedType)possiblyNullSuper;  // applying .RhsWithArgument to a NonNullTypeDecl should always yield a UserDefinedType
                                if (udtSuper.IsObjectQ)
                                {
                                    return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(436L, true);
                                }
                            }
                        }
                        else if (udtSub.ResolvedClass is ClassLikeDecl)
                        {
                            var cl = (TopLevelDeclWithMembers)udtSub.ResolvedClass;
                            return cl.HeadDerivesFrom(udtSuper.ResolvedClass);
                        }
                        else
                        {
                            return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(437L, false);
                        }
                    }
                }
            }
            else
            {
                Contract.Assert(false);  // unexpected kind of type
                return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(438L, true);  // to please the compiler
            }

            return default;
        }

        /// <summary>
        /// Returns "true" iff "a" and "b" denote the same type, expanding type synonyms (but treating types with
        /// constraints as being separate types).
        /// Any unresolved proxy type contained in either "a" or "b" is compared with reference equality; in other
        /// words, the proxy itself is compared, not what the proxy will eventually stand for.
        /// </summary>
        public static bool Equal_Improved(Type a, Type b)
        {
            Contract.Requires(a != null);
            Contract.Requires(b != null);
            a = a.NormalizeExpandKeepConstraints();  // expand type synonyms
            b = b.NormalizeExpandKeepConstraints();  // expand type synonyms
            if (object.ReferenceEquals(a, b))
            {
                return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(439L, true);
            }
            else if (a is BoolType)
            {
                return b is BoolType;
            }
            else if (a is CharType)
            {
                return b is CharType;
            }
            else if (a is IntType)
            {
                return b is IntType;
            }
            else if (a is RealType)
            {
                return b is RealType;
            }
            else if (a is BitvectorType)
            {
                var bitvectorSuper = (BitvectorType)a;
                var bitvectorSub = b as BitvectorType;
                return MutateCSharp.Schemata208.ReplaceBinExprOp_5(446L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_13(440L, bitvectorSub, null), () => MutateCSharp.Schemata208.ReplaceBinExprOp_36(441L, bitvectorSuper.Width, bitvectorSub.Width));
            }
            else if (a is BigOrdinalType)
            {
                return b is BigOrdinalType;
            }
            else if (a is SetType)
            {
                return MutateCSharp.Schemata208.ReplaceBinExprOp_5(472L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_5(460L, () => b is SetType, () => Equal_Improved(a.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(452L, 0)], b.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(456L, 0)])), () => (MutateCSharp.Schemata208.ReplaceBinExprOp_40(466L, () => a.IsISetType, () => b.IsISetType)));
            }
            else if (a is SeqType)
            {
                return MutateCSharp.Schemata208.ReplaceBinExprOp_5(486L, () => b is SeqType, () => Equal_Improved(a.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(478L, 0)], b.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(482L, 0)]));
            }
            else if (a is MultiSetType)
            {
                return MutateCSharp.Schemata208.ReplaceBinExprOp_5(500L, () => b is MultiSetType, () => Equal_Improved(a.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(492L, 0)], b.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(496L, 0)]));
            }
            else if (a is MapType)
            {
                return MutateCSharp.Schemata208.ReplaceBinExprOp_5(540L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_5(528L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_5(514L, () => b is MapType, () => Equal_Improved(a.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(506L, 0)], b.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(510L, 0)])), () => Equal_Improved(a.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(520L, 1)], b.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(524L, 1)])), () => (MutateCSharp.Schemata208.ReplaceBinExprOp_40(534L, () => a.IsIMapType, () => b.IsIMapType)));
            }
            else if (a is ArrowType)
            {
                var asuper = (ArrowType)a;
                var asub = b as ArrowType;
                return MutateCSharp.Schemata208.ReplaceBinExprOp_5(552L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_31(546L, asub, null), () => MutateCSharp.Schemata208.ReplaceBinExprOp_36(547L, asuper.Arity, asub.Arity));
            }
            else if (a is UserDefinedType)
            {
                var udtA = (UserDefinedType)a;
                Contract.Assert(udtA.ResolvedClass != null);
                if (udtA.ResolvedClass is TypeParameter)
                {
                    Contract.Assert(udtA.TypeArgs.Count == 0);
                    return MutateCSharp.Schemata208.ReplaceBinExprOp_42(558L, udtA.ResolvedClass, b.AsTypeParameter);
                }
                else
                {
                    var udtB = b as UserDefinedType;
                    if (MutateCSharp.Schemata208.ReplaceBinExprOp_29(559L, udtB, null))
                    {
                        return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(560L, false);
                    }
                    else if (MutateCSharp.Schemata208.ReplaceBinExprOp_43(561L, udtA.ResolvedClass, udtB.ResolvedClass))
                    {
                        return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(562L, false);
                    }
                    else
                    {
                        Contract.Assert(udtA.TypeArgs.Count == udtB.TypeArgs.Count);
                        for (int i = MutateCSharp.Schemata208.ReplaceNumericConstant_2(563L, 0); MutateCSharp.Schemata208.ReplaceBinExprOp_44(567L, i, udtA.TypeArgs.Count); MutateCSharp.Schemata208.ReplacePostfixUnaryExprOp_45(572L, ref i))
                        {
                            if (!Equal_Improved(udtA.TypeArgs[i], udtB.TypeArgs[i]))
                            {
                                return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(573L, false);
                            }
                        }
                        return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(574L, true);
                    }
                }
            }
            else if (a is Resolver_IdentifierExpr.ResolverType_Module)
            {
                return b is Resolver_IdentifierExpr.ResolverType_Module;
            }
            else if (a is Resolver_IdentifierExpr.ResolverType_Type)
            {
                return b is Resolver_IdentifierExpr.ResolverType_Type;
            }
            else
            {
                // this is an unexpected type; however, it may be that we get here during the resolution of an erroneous
                // program, so we'll just return false
                return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(575L, false);
            }

            return default;
        }

        public static Type HeadWithProxyArgs(Type t)
        {
            Contract.Requires(t != null);
            Contract.Requires(!(t is TypeProxy));
            if (MutateCSharp.Schemata208.ReplaceBinExprOp_36(580L, t.TypeArgs.Count, MutateCSharp.Schemata208.ReplaceNumericConstant_2(576L, 0)))
            {
                return t;
            }
            else if (t is SetType)
            {
                var s = (SetType)t;
                return new SetType(s.Finite, new InferredTypeProxy());
            }
            else if (t is MultiSetType)
            {
                return new MultiSetType(new InferredTypeProxy());
            }
            else if (t is SeqType)
            {
                return new SeqType(new InferredTypeProxy());
            }
            else if (t is MapType)
            {
                var s = (MapType)t;
                return new MapType(s.Finite, new InferredTypeProxy(), new InferredTypeProxy());
            }
            else if (t is ArrowType)
            {
                var s = (ArrowType)t;
                var args = s.TypeArgs.ConvertAll(_ => (Type)new InferredTypeProxy());
                return new ArrowType(s.tok, (ArrowTypeDecl)s.ResolvedClass, args);
            }
            else
            {
                var s = (UserDefinedType)t;
                var args = s.TypeArgs.ConvertAll(_ => (Type)new InferredTypeProxy());
                return new UserDefinedType(s.tok, s.Name, s.ResolvedClass, args);
            }

            return default;
        }

        /// <summary>
        /// Returns a stack of base types leading to "type".  More precisely:
        ///
        /// With "typeSynonymsAreSignificant" being "false", then, of the tower returned,
        ///     tower[0] == type.NormalizeExpand()
        ///     tower.Last == type.NormalizeExpandKeepConstraints()
        /// In between, for consecutive indices i and i+1:
        ///     tower[i] is the base type (that is, .Rhs) of the subset type tower[i+1]
        /// The tower thus has the property that:
        ///     tower[0] is not a UserDefinedType with .ResolvedClass being a SubsetTypeDecl,
        ///     but all other tower[i] (for i > 0) are.
        ///
        /// With "typeSynonymsAreSignificant" being "true", then, of the tower returned,
        ///     tower[0] == type.Normalize()
        ///     tower.Last == type.NormalizeExpandKeepConstraints()
        /// In between, for consecutive indices i and i+1:
        ///     tower[i] is the base type (that is, .Rhs) of the subset type or type synonym tower[i+1]
        /// The tower thus has the property that:
        ///     tower[0] is not a UserDefinedType with .ResolvedClass being a TypeSynonymDecl,
        ///     but all other tower[i] (for i > 0) are.
        /// </summary>
        public static List<Type> GetTowerOfSubsetTypes(Type type, bool typeSynonymsAreSignificant = false)
        {
            Contract.Requires(type != null);
            type = typeSynonymsAreSignificant ? type.NormalizeAndAdjustForScope() : type.NormalizeExpandKeepConstraints();
            List<Type> tower;
            if (type is UserDefinedType { ResolvedClass: TypeSynonymDecl sst } && (MutateCSharp.Schemata208.ReplaceBinExprOp_7(585L, () => typeSynonymsAreSignificant, () => sst is SubsetTypeDecl)))
            {
                var parent = sst.RhsWithArgument(type.TypeArgs);
                tower = GetTowerOfSubsetTypes(parent, typeSynonymsAreSignificant);
            }
            else
            {
                tower = new List<Type>();
            }
            tower.Add(type);
            return tower;
        }

        /// <summary>
        /// For each i, computes some combination of a[i] and b[i], according to direction[i].
        /// For a negative direction (Contra), computes Join(a[i], b[i]), provided this join exists.
        /// For a zero direction (Inv), uses a[i], provided a[i] and b[i] are equal.
        /// For a positive direction (Co), computes Meet(a[i], b[i]), provided this meet exists.
        /// Returns null if any operation fails.
        /// </summary>
        public static List<Type> ComputeExtrema(List<TypeParameter.TPVariance> directions, List<Type> a, List<Type> b, SystemModuleManager systemModuleManager)
        {
            Contract.Requires(directions != null);
            Contract.Requires(a != null);
            Contract.Requires(b != null);
            Contract.Requires(directions.Count == a.Count);
            Contract.Requires(directions.Count == b.Count);
            Contract.Requires(systemModuleManager != null);
            var n = directions.Count;
            var r = new List<Type>(n);
            for (int i = MutateCSharp.Schemata208.ReplaceNumericConstant_2(591L, 0); MutateCSharp.Schemata208.ReplaceBinExprOp_44(595L, i, n); MutateCSharp.Schemata208.ReplacePostfixUnaryExprOp_45(600L, ref i))
            {
                if (a[i].Normalize() is TypeProxy)
                {
                    r.Add(b[i]);
                }
                else if (b[i].Normalize() is TypeProxy)
                {
                    r.Add(a[i]);
                }
                else if (MutateCSharp.Schemata208.ReplaceBinExprOp_46(601L, directions[i], TypeParameter.TPVariance.Non))
                {
                    if (a[i].Equals(b[i]))
                    {
                        r.Add(a[i]);
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    var t = MutateCSharp.Schemata208.ReplaceBinExprOp_46(602L, directions[i], TypeParameter.TPVariance.Contra) ? Join(a[i], b[i], systemModuleManager) : Meet(a[i], b[i], systemModuleManager);
                    if (MutateCSharp.Schemata208.ReplaceBinExprOp_47(603L, t, null))
                    {
                        return null;
                    }
                    r.Add(t);
                }
            }
            return r;
        }

        /// <summary>
        /// Does a best-effort to compute the join of "a" and "b", returning "null" if not successful.
        ///
        /// Since some type parameters may still be proxies, it could be that the returned type is not
        /// really a join, so the caller should set up additional constraints that the result is
        /// assignable to both a and b.
        /// </summary>
        public static Type Join(Type a, Type b, SystemModuleManager systemModuleManager)
        {
            Contract.Requires(a != null);
            Contract.Requires(b != null);
            Contract.Requires(systemModuleManager != null);
            var j = JoinX(a, b, systemModuleManager);
            if (systemModuleManager.Options.Get(CommonOptionBag.TypeInferenceDebug))
            {
                systemModuleManager.Options.OutputWriter.WriteLine(MutateCSharp.Schemata208.ReplaceStringConstant_0(604L, "DEBUG: Join( {0}, {1} ) = {2}"), a, b, j);
            }
            return j;
        }
        public static Type JoinX(Type a, Type b, SystemModuleManager systemModuleManager)
        {
            Contract.Requires(a != null);
            Contract.Requires(b != null);
            Contract.Requires(systemModuleManager != null);

            // As a special-case optimization, check for equality here, which will better preserve un-expanded type synonyms
            if (a.Equals(b, MutateCSharp.Schemata208.ReplaceBooleanConstant_1(605L, true)))
            {
                return a;
            }

            // Before we do anything else, make a note of whether or not both "a" and "b" are non-null types.
            var abNonNullTypes = MutateCSharp.Schemata208.ReplaceBinExprOp_5(606L, () => a.IsNonNullRefType, () => b.IsNonNullRefType);

            var towerA = GetTowerOfSubsetTypes(a);
            var towerB = GetTowerOfSubsetTypes(b);
            for (var n = Math.Min(towerA.Count, towerB.Count); MutateCSharp.Schemata208.ReplaceBinExprOp_38(620L, MutateCSharp.Schemata208.ReplaceNumericConstant_2(612L, 1), MutateCSharp.Schemata208.ReplacePrefixUnaryExprOp_37(616L, ref n));)
            {
                a = towerA[n];
                b = towerB[n];
                var udtA = (UserDefinedType)a;
                var udtB = (UserDefinedType)b;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_41(625L, udtA.ResolvedClass, udtB.ResolvedClass))
                {
                    // We have two subset types with equal heads
                    if (a.Equals(b))
                    {  // optimization for a special case, which applies for example when there are no arguments or when the types happen to be the same
                        return a;
                    }
                    Contract.Assert(a.TypeArgs.Count == b.TypeArgs.Count);
                    var directions = udtA.ResolvedClass.TypeArgs.ConvertAll(tp => TypeParameter.Negate(tp.Variance));
                    var typeArgs = ComputeExtrema(directions, a.TypeArgs, b.TypeArgs, systemModuleManager);
                    if (MutateCSharp.Schemata208.ReplaceBinExprOp_48(626L, typeArgs, null))
                    {
                        return null;
                    }
                    return new UserDefinedType(udtA.tok, udtA.Name, udtA.ResolvedClass, typeArgs);
                }
            }
            // We exhausted all possibilities of subset types being equal, so use the base-most types.
            a = towerA[MutateCSharp.Schemata208.ReplaceNumericConstant_2(627L, 0)];
            b = towerB[MutateCSharp.Schemata208.ReplaceNumericConstant_2(631L, 0)];

            if (a is IntVarietiesSupertype)
            {
                return MutateCSharp.Schemata208.ReplaceBinExprOp_7(647L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(641L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(635L, () => b is IntVarietiesSupertype, () => b.IsNumericBased(NumericPersuasion.Int)), () => b.IsBigOrdinalType), () => b.IsBitVectorType) ? b : null;
            }
            else if (b is IntVarietiesSupertype)
            {
                return MutateCSharp.Schemata208.ReplaceBinExprOp_7(659L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(653L, () => a.IsNumericBased(NumericPersuasion.Int), () => a.IsBigOrdinalType), () => a.IsBitVectorType) ? a : null;
            }
            else if (MutateCSharp.Schemata208.ReplaceBinExprOp_7(695L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(689L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(683L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(677L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(671L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(665L, () => a.IsBoolType, () => a.IsCharType), () => a.IsBitVectorType), () => a.IsBigOrdinalType), () => a.IsTypeParameter), () => a.IsInternalTypeSynonym), () => a is TypeProxy))
            {
                return a.Equals(b) ? a : null;
            }
            else if (a is RealVarietiesSupertype)
            {
                return MutateCSharp.Schemata208.ReplaceBinExprOp_7(701L, () => b is RealVarietiesSupertype, () => b.IsNumericBased(NumericPersuasion.Real)) ? b : null;
            }
            else if (b is RealVarietiesSupertype)
            {
                return a.IsNumericBased(NumericPersuasion.Real) ? a : null;
            }
            else if (a.IsNumericBased())
            {
                // Note, for join, we choose not to step down to IntVarietiesSupertype or RealVarietiesSupertype
                return a.Equals(b) ? a : null;
            }
            else if (a.IsBitVectorType)
            {
                return a.Equals(b) ? a : null;
            }
            else if (a is SetType)
            {
                var aa = (SetType)a;
                var bb = b as SetType;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_7(714L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_49(707L, bb, null), () => MutateCSharp.Schemata208.ReplaceBinExprOp_50(708L, () => aa.Finite, () => bb.Finite)))
                {
                    return null;
                }
                // sets are co-variant in their argument type
                var typeArg = Join(a.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(720L, 0)], b.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(724L, 0)], systemModuleManager);
                return MutateCSharp.Schemata208.ReplaceBinExprOp_47(728L, typeArg, null) ? null : new SetType(aa.Finite, typeArg);
            }
            else if (a is MultiSetType)
            {
                var aa = (MultiSetType)a;
                var bb = b as MultiSetType;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_51(729L, bb, null))
                {
                    return null;
                }
                // multisets are co-variant in their argument type
                var typeArg = Join(a.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(730L, 0)], b.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(734L, 0)], systemModuleManager);
                return MutateCSharp.Schemata208.ReplaceBinExprOp_47(738L, typeArg, null) ? null : new MultiSetType(typeArg);
            }
            else if (a is SeqType)
            {
                var aa = (SeqType)a;
                var bb = b as SeqType;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_52(739L, bb, null))
                {
                    return null;
                }
                // sequences are co-variant in their argument type
                var typeArg = Join(a.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(740L, 0)], b.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(744L, 0)], systemModuleManager);
                return MutateCSharp.Schemata208.ReplaceBinExprOp_47(748L, typeArg, null) ? null : new SeqType(typeArg);
            }
            else if (a is MapType)
            {
                var aa = (MapType)a;
                var bb = b as MapType;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_7(756L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_53(749L, bb, null), () => MutateCSharp.Schemata208.ReplaceBinExprOp_50(750L, () => aa.Finite, () => bb.Finite)))
                {
                    return null;
                }
                // maps are co-variant in both argument types
                var typeArgDomain = Join(a.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(762L, 0)], b.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(766L, 0)], systemModuleManager);
                var typeArgRange = Join(a.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(770L, 1)], b.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(774L, 1)], systemModuleManager);
                return MutateCSharp.Schemata208.ReplaceBinExprOp_7(780L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_47(778L, typeArgDomain, null), () => MutateCSharp.Schemata208.ReplaceBinExprOp_47(779L, typeArgRange, null)) ? null : new MapType(aa.Finite, typeArgDomain, typeArgRange);
            }
            else if (a.IsDatatype)
            {
                var aa = a.AsDatatype;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_54(786L, aa, b.AsDatatype))
                {
                    return null;
                }
                if (a.Equals(b))
                {  // optimization for a special case, which applies for example when there are no arguments or when the types happen to be the same
                    return a;
                }
                Contract.Assert(a.TypeArgs.Count == b.TypeArgs.Count);
                var directions = aa.TypeArgs.ConvertAll(tp => TypeParameter.Negate(tp.Variance));
                var typeArgs = ComputeExtrema(directions, a.TypeArgs, b.TypeArgs, systemModuleManager);
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_48(787L, typeArgs, null))
                {
                    return null;
                }
                var udt = (UserDefinedType)a;
                return new UserDefinedType(udt.tok, udt.Name, aa, typeArgs);
            }
            else if (MutateCSharp.Schemata208.ReplaceBinExprOp_31(788L, a.AsArrowType, null))
            {
                var aa = a.AsArrowType;
                var bb = b.AsArrowType;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_7(795L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_55(789L, bb, null), () => MutateCSharp.Schemata208.ReplaceBinExprOp_56(790L, aa.Arity, bb.Arity)))
                {
                    return null;
                }
                int arity = aa.Arity;
                Contract.Assert(a.TypeArgs.Count == arity + 1);
                Contract.Assert(b.TypeArgs.Count == arity + 1);
                Contract.Assert(((ArrowType)a).ResolvedClass == ((ArrowType)b).ResolvedClass);
                var directions = new List<TypeParameter.TPVariance>();
                for (int i = MutateCSharp.Schemata208.ReplaceNumericConstant_2(801L, 0); MutateCSharp.Schemata208.ReplaceBinExprOp_44(805L, i, arity); MutateCSharp.Schemata208.ReplacePostfixUnaryExprOp_45(810L, ref i))
                {
                    directions.Add(TypeParameter.Negate(TypeParameter.TPVariance.Contra));  // arrow types are contra-variant in the argument types, so compute joins of these
                }
                directions.Add(TypeParameter.Negate(TypeParameter.TPVariance.Co));  // arrow types are co-variant in the result type, so compute the meet of these
                var typeArgs = ComputeExtrema(directions, a.TypeArgs, b.TypeArgs, systemModuleManager);
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_48(811L, typeArgs, null))
                {
                    return null;
                }
                var arr = (ArrowType)aa;
                return new ArrowType(arr.tok, (ArrowTypeDecl)arr.ResolvedClass, typeArgs);
            }
            else if (b.IsObjectQ)
            {
                var udtB = (UserDefinedType)b;
                return !a.IsRefType ? null : abNonNullTypes ? UserDefinedType.CreateNonNullType(udtB) : udtB;
            }
            else if (a.IsObjectQ)
            {
                var udtA = (UserDefinedType)a;
                return !b.IsRefType ? null : abNonNullTypes ? UserDefinedType.CreateNonNullType(udtA) : udtA;
            }
            else
            {
                // "a" is a class, trait, or abstract type
                var aa = ((UserDefinedType)a).ResolvedClass;
                Contract.Assert(aa != null);
                if (!(b is UserDefinedType))
                {
                    return null;
                }
                var bb = ((UserDefinedType)b).ResolvedClass;
                if (a.Equals(b))
                {  // optimization for a special case, which applies for example when there are no arguments or when the types happen to be the same
                    return a;
                }
                else if (MutateCSharp.Schemata208.ReplaceBinExprOp_41(812L, aa, bb))
                {
                    Contract.Assert(a.TypeArgs.Count == b.TypeArgs.Count);
                    var directions = aa.TypeArgs.ConvertAll(tp => TypeParameter.Negate(tp.Variance));
                    var typeArgs = ComputeExtrema(directions, a.TypeArgs, b.TypeArgs, systemModuleManager);
                    if (MutateCSharp.Schemata208.ReplaceBinExprOp_48(813L, typeArgs, null))
                    {
                        return null;
                    }
                    var udt = (UserDefinedType)a;
                    var xx = new UserDefinedType(udt.tok, udt.Name, aa, typeArgs);
                    return abNonNullTypes ? UserDefinedType.CreateNonNullType(xx) : xx;
                }
                else if (MutateCSharp.Schemata208.ReplaceBinExprOp_5(814L, () => aa is ClassLikeDecl, () => bb is ClassLikeDecl))
                {
                    var A = (TopLevelDeclWithMembers)aa;
                    var B = (TopLevelDeclWithMembers)bb;
                    if (A.HeadDerivesFrom(B))
                    {
                        var udtB = (UserDefinedType)b;
                        return abNonNullTypes ? UserDefinedType.CreateNonNullType(udtB) : udtB;
                    }
                    else if (B.HeadDerivesFrom(A))
                    {
                        var udtA = (UserDefinedType)a;
                        return abNonNullTypes ? UserDefinedType.CreateNonNullType(udtA) : udtA;
                    }
                    // A and B are classes or traits. They always have object as a common supertype, but they may also both be extending some other
                    // trait.  If such a trait is unique, pick it. (Unfortunately, this makes the join operation not associative.)
                    var commonTraits = TopLevelDeclWithMembers.CommonTraits(A, B);
                    if (MutateCSharp.Schemata208.ReplaceBinExprOp_36(824L, commonTraits.Count, MutateCSharp.Schemata208.ReplaceNumericConstant_2(820L, 1)))
                    {
                        var typeMap = TypeParameter.SubstitutionMap(A.TypeArgs, a.TypeArgs);
                        var r = (UserDefinedType)commonTraits[MutateCSharp.Schemata208.ReplaceNumericConstant_2(829L, 0)].Subst(typeMap);
                        return abNonNullTypes ? UserDefinedType.CreateNonNullType(r) : r;
                    }
                    else
                    {
                        // the unfortunate part is when commonTraits.Count > 1 here :(
                        return abNonNullTypes ? UserDefinedType.CreateNonNullType(systemModuleManager.ObjectQ()) : systemModuleManager.ObjectQ();
                    }
                }
                else
                {
                    return null;
                }
            }

            return default;
        }

        /// <summary>
        /// Does a best-effort to compute the meet of "a" and "b", returning "null" if not successful.
        ///
        /// Since some type parameters may still be proxies, it could be that the returned type is not
        /// really a meet, so the caller should set up additional constraints that the result is
        /// assignable to both a and b.
        /// </summary>
        public static Type Meet(Type a, Type b, SystemModuleManager systemModuleManager)
        {
            Contract.Requires(a != null);
            Contract.Requires(b != null);
            Contract.Requires(systemModuleManager != null);
            a = a.NormalizeExpandKeepConstraints();
            b = b.NormalizeExpandKeepConstraints();

            var joinNeedsNonNullConstraint = MutateCSharp.Schemata208.ReplaceBooleanConstant_1(833L, false);
            Type j;
            if (a is UserDefinedType { ResolvedClass: NonNullTypeDecl aClass })
            {
                joinNeedsNonNullConstraint = MutateCSharp.Schemata208.ReplaceBooleanConstant_1(834L, true);
                j = MeetX(aClass.RhsWithArgument(a.TypeArgs), b, systemModuleManager);
            }
            else if (b is UserDefinedType { ResolvedClass: NonNullTypeDecl bClass })
            {
                joinNeedsNonNullConstraint = MutateCSharp.Schemata208.ReplaceBooleanConstant_1(835L, true);
                j = MeetX(a, bClass.RhsWithArgument(b.TypeArgs), systemModuleManager);
            }
            else
            {
                j = MeetX(a, b, systemModuleManager);
            }
            if (MutateCSharp.Schemata208.ReplaceBinExprOp_5(843L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_5(837L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_57(836L, j, null), () => joinNeedsNonNullConstraint), () => !j.IsNonNullRefType))
            {
                // try to make j into a non-null type; if that's not possible, then there is no meet
                var udt = j as UserDefinedType;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_5(850L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_25(849L, udt, null), () => udt.ResolvedClass is ClassLikeDecl { IsReferenceTypeDecl: true }))
                {
                    // add the non-null constraint back in
                    j = UserDefinedType.CreateNonNullType(udt);
                }
                else
                {
                    // the original a and b have no meet
                    j = null;
                }
            }
            if (systemModuleManager.Options.Get(CommonOptionBag.TypeInferenceDebug))
            {
                systemModuleManager.Options.OutputWriter.WriteLine(MutateCSharp.Schemata208.ReplaceStringConstant_0(856L, "DEBUG: Meet( {0}, {1} ) = {2}"), a, b, j);
            }
            return j;
        }
        public static Type MeetX(Type a, Type b, SystemModuleManager systemModuleManager)
        {
            Contract.Requires(a != null);
            Contract.Requires(b != null);
            Contract.Requires(systemModuleManager != null);

            a = a.NormalizeExpandKeepConstraints();
            b = b.NormalizeExpandKeepConstraints();
            if (a is IntVarietiesSupertype)
            {
                return MutateCSharp.Schemata208.ReplaceBinExprOp_7(869L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(863L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(857L, () => b is IntVarietiesSupertype, () => b.IsNumericBased(NumericPersuasion.Int)), () => b.IsBigOrdinalType), () => b.IsBitVectorType) ? b : null;
            }
            else if (b is IntVarietiesSupertype)
            {
                return MutateCSharp.Schemata208.ReplaceBinExprOp_7(881L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(875L, () => a.IsNumericBased(NumericPersuasion.Int), () => a.IsBigOrdinalType), () => a.IsBitVectorType) ? a : null;
            }
            else if (a is RealVarietiesSupertype)
            {
                return MutateCSharp.Schemata208.ReplaceBinExprOp_7(887L, () => b is RealVarietiesSupertype, () => b.IsNumericBased(NumericPersuasion.Real)) ? b : null;
            }
            else if (b is RealVarietiesSupertype)
            {
                return a.IsNumericBased(NumericPersuasion.Real) ? a : null;
            }

            var towerA = GetTowerOfSubsetTypes(a);
            var towerB = GetTowerOfSubsetTypes(b);
            if (MutateCSharp.Schemata208.ReplaceBinExprOp_44(893L, towerB.Count, towerA.Count))
            {
                // make A be the shorter tower
                var tmp0 = a; a = b; b = tmp0;
                var tmp1 = towerA; towerA = towerB; towerB = tmp1;
            }
            var n = towerA.Count;
            Contract.Assert(1 <= n);  // guaranteed by GetTowerOfSubsetTypes
            if (MutateCSharp.Schemata208.ReplaceBinExprOp_44(898L, towerA.Count, towerB.Count))
            {
                // B is strictly taller. The meet exists only if towerA[n-1] is a supertype of towerB[n-1], and
                // then the meet is "b".
                return Type.IsSupertype(towerA[MutateCSharp.Schemata208.ReplaceBinExprOp_3(907L, n, MutateCSharp.Schemata208.ReplaceNumericConstant_2(903L, 1))], towerB[MutateCSharp.Schemata208.ReplaceBinExprOp_3(920L, n, MutateCSharp.Schemata208.ReplaceNumericConstant_2(916L, 1))]) ? b : null;
            }
            Contract.Assert(towerA.Count == towerB.Count);
            a = towerA[MutateCSharp.Schemata208.ReplaceBinExprOp_3(933L, n, MutateCSharp.Schemata208.ReplaceNumericConstant_2(929L, 1))];
            b = towerB[MutateCSharp.Schemata208.ReplaceBinExprOp_3(946L, n, MutateCSharp.Schemata208.ReplaceNumericConstant_2(942L, 1))];
            if (MutateCSharp.Schemata208.ReplaceBinExprOp_38(959L, MutateCSharp.Schemata208.ReplaceNumericConstant_2(955L, 2), n))
            {
                var udtA = (UserDefinedType)a;
                var udtB = (UserDefinedType)b;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_41(964L, udtA.ResolvedClass, udtB.ResolvedClass))
                {
                    // We have two subset types with equal heads
                    if (a.Equals(b))
                    {  // optimization for a special case, which applies for example when there are no arguments or when the types happen to be the same
                        return a;
                    }
                    Contract.Assert(a.TypeArgs.Count == b.TypeArgs.Count);
                    var directions = udtA.ResolvedClass.TypeArgs.ConvertAll(tp => tp.Variance);
                    var typeArgs = ComputeExtrema(directions, a.TypeArgs, b.TypeArgs, systemModuleManager);
                    if (MutateCSharp.Schemata208.ReplaceBinExprOp_48(965L, typeArgs, null))
                    {
                        return null;
                    }
                    return new UserDefinedType(udtA.tok, udtA.Name, udtA.ResolvedClass, typeArgs);
                }
                else
                {
                    // The two subset types do not have the same head, so there is no meet
                    return null;
                }
            }
            Contract.Assert(towerA.Count == 1 && towerB.Count == 1);

            if (MutateCSharp.Schemata208.ReplaceBinExprOp_7(1002L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(996L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(990L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(984L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(978L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(972L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(966L, () => a.IsBoolType, () => a.IsCharType), () => a.IsNumericBased()), () => a.IsBitVectorType), () => a.IsBigOrdinalType), () => a.IsTypeParameter), () => a.IsInternalTypeSynonym), () => a is TypeProxy))
            {
                return a.Equals(b) ? a : null;
            }
            else if (a is SetType)
            {
                var aa = (SetType)a;
                var bb = b as SetType;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_7(1015L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_49(1008L, bb, null), () => MutateCSharp.Schemata208.ReplaceBinExprOp_50(1009L, () => aa.Finite, () => bb.Finite)))
                {
                    return null;
                }
                // sets are co-variant in their argument type
                var typeArg = Meet(a.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(1021L, 0)], b.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(1025L, 0)], systemModuleManager);
                return MutateCSharp.Schemata208.ReplaceBinExprOp_47(1029L, typeArg, null) ? null : new SetType(aa.Finite, typeArg);
            }
            else if (a is MultiSetType)
            {
                var aa = (MultiSetType)a;
                var bb = b as MultiSetType;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_51(1030L, bb, null))
                {
                    return null;
                }
                // multisets are co-variant in their argument type
                var typeArg = Meet(a.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(1031L, 0)], b.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(1035L, 0)], systemModuleManager);
                return MutateCSharp.Schemata208.ReplaceBinExprOp_47(1039L, typeArg, null) ? null : new MultiSetType(typeArg);
            }
            else if (a is SeqType)
            {
                var aa = (SeqType)a;
                var bb = b as SeqType;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_52(1040L, bb, null))
                {
                    return null;
                }
                // sequences are co-variant in their argument type
                var typeArg = Meet(a.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(1041L, 0)], b.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(1045L, 0)], systemModuleManager);
                return MutateCSharp.Schemata208.ReplaceBinExprOp_47(1049L, typeArg, null) ? null : new SeqType(typeArg);
            }
            else if (a is MapType)
            {
                var aa = (MapType)a;
                var bb = b as MapType;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_7(1057L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_53(1050L, bb, null), () => MutateCSharp.Schemata208.ReplaceBinExprOp_50(1051L, () => aa.Finite, () => bb.Finite)))
                {
                    return null;
                }
                // maps are co-variant in both argument types
                var typeArgDomain = Meet(a.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(1063L, 0)], b.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(1067L, 0)], systemModuleManager);
                var typeArgRange = Meet(a.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(1071L, 1)], b.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(1075L, 1)], systemModuleManager);
                return MutateCSharp.Schemata208.ReplaceBinExprOp_7(1081L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_47(1079L, typeArgDomain, null), () => MutateCSharp.Schemata208.ReplaceBinExprOp_47(1080L, typeArgRange, null)) ? null : new MapType(aa.Finite, typeArgDomain, typeArgRange);
            }
            else if (a.IsDatatype)
            {
                var aa = a.AsDatatype;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_54(1087L, aa, b.AsDatatype))
                {
                    return null;
                }
                if (a.Equals(b))
                {  // optimization for a special case, which applies for example when there are no arguments or when the types happen to be the same
                    return a;
                }
                Contract.Assert(a.TypeArgs.Count == b.TypeArgs.Count);
                var directions = aa.TypeArgs.ConvertAll(tp => tp.Variance);
                var typeArgs = ComputeExtrema(directions, a.TypeArgs, b.TypeArgs, systemModuleManager);
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_48(1088L, typeArgs, null))
                {
                    return null;
                }
                var udt = (UserDefinedType)a;
                return new UserDefinedType(udt.tok, udt.Name, aa, typeArgs);
            }
            else if (MutateCSharp.Schemata208.ReplaceBinExprOp_31(1089L, a.AsArrowType, null))
            {
                var aa = a.AsArrowType;
                var bb = b.AsArrowType;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_7(1096L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_55(1090L, bb, null), () => MutateCSharp.Schemata208.ReplaceBinExprOp_56(1091L, aa.Arity, bb.Arity)))
                {
                    return null;
                }
                int arity = aa.Arity;
                Contract.Assert(a.TypeArgs.Count == arity + 1);
                Contract.Assert(b.TypeArgs.Count == arity + 1);
                Contract.Assert(((ArrowType)a).ResolvedClass == ((ArrowType)b).ResolvedClass);
                var directions = new List<TypeParameter.TPVariance>();
                for (int i = MutateCSharp.Schemata208.ReplaceNumericConstant_2(1102L, 0); MutateCSharp.Schemata208.ReplaceBinExprOp_44(1106L, i, arity); MutateCSharp.Schemata208.ReplacePostfixUnaryExprOp_45(1111L, ref i))
                {
                    directions.Add(TypeParameter.TPVariance.Contra);  // arrow types are contra-variant in the argument types, so compute joins of these
                }
                directions.Add(TypeParameter.TPVariance.Co);  // arrow types are co-variant in the result type, so compute the meet of these
                var typeArgs = ComputeExtrema(directions, a.TypeArgs, b.TypeArgs, systemModuleManager);
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_48(1112L, typeArgs, null))
                {
                    return null;
                }
                var arr = (ArrowType)aa;
                return new ArrowType(arr.tok, (ArrowTypeDecl)arr.ResolvedClass, typeArgs);
            }
            else if (b.IsObjectQ)
            {
                return a.IsRefType ? a : null;
            }
            else if (a.IsObjectQ)
            {
                return b.IsRefType ? b : null;
            }
            else
            {
                // "a" is a class, trait, or abstract type
                var aa = ((UserDefinedType)a).ResolvedClass;
                Contract.Assert(aa != null);
                if (!(b is UserDefinedType))
                {
                    return null;
                }
                var bb = ((UserDefinedType)b).ResolvedClass;
                if (a.Equals(b))
                {  // optimization for a special case, which applies for example when there are no arguments or when the types happen to be the same
                    return a;
                }
                else if (MutateCSharp.Schemata208.ReplaceBinExprOp_41(1113L, aa, bb))
                {
                    Contract.Assert(a.TypeArgs.Count == b.TypeArgs.Count);
                    var directions = aa.TypeArgs.ConvertAll(tp => tp.Variance);
                    var typeArgs = ComputeExtrema(directions, a.TypeArgs, b.TypeArgs, systemModuleManager);
                    if (MutateCSharp.Schemata208.ReplaceBinExprOp_48(1114L, typeArgs, null))
                    {
                        return null;
                    }
                    var udt = (UserDefinedType)a;
                    return new UserDefinedType(udt.tok, udt.Name, aa, typeArgs);
                }
                else if (MutateCSharp.Schemata208.ReplaceBinExprOp_5(1115L, () => aa is ClassLikeDecl, () => bb is ClassLikeDecl))
                {
                    if (a.IsSubtypeOf(b, MutateCSharp.Schemata208.ReplaceBooleanConstant_1(1121L, false), MutateCSharp.Schemata208.ReplaceBooleanConstant_1(1122L, false)))
                    {
                        return a;
                    }
                    else if (b.IsSubtypeOf(a, MutateCSharp.Schemata208.ReplaceBooleanConstant_1(1123L, false), MutateCSharp.Schemata208.ReplaceBooleanConstant_1(1124L, false)))
                    {
                        return b;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }

            return default;
        }

        public void ForeachTypeComponent(Action<Type> action)
        {
            action(this);
            TypeArgs.ForEach(x => x.ForeachTypeComponent(action));
        }

        public bool ContainsProxy(TypeProxy proxy)
        {
            Contract.Requires(proxy != null && proxy.T == null);
            if (MutateCSharp.Schemata208.ReplaceBinExprOp_58(1125L, this, proxy))
            {
                return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(1126L, true);
            }
            else
            {
                return TypeArgs.Exists(t => t.ContainsProxy(proxy));
            }

            return default;
        }

        public virtual List<Type> ParentTypes()
        {
            return new List<Type>();
        }

        /// <summary>
        /// Return whether or not "this" is a subtype of "super".
        /// If "ignoreTypeArguments" is "true", then proceed as if the type arguments were equal.
        /// If "ignoreNullity" is "true", then the difference between a non-null reference type C
        /// and the corresponding nullable reference type C? is ignored.
        /// </summary>
        public virtual bool IsSubtypeOf(Type super, bool ignoreTypeArguments, bool ignoreNullity)
        {
            Contract.Requires(super != null);

            super = super.NormalizeExpandKeepConstraints();
            var sub = NormalizeExpandKeepConstraints();
            bool equivalentHeads = SameHead(sub, super);
            if (MutateCSharp.Schemata208.ReplaceBinExprOp_5(1127L, () => !equivalentHeads, () => ignoreNullity))
            {
                if (super is UserDefinedType a && sub is UserDefinedType b)
                {
                    var clA = (a.ResolvedClass as NonNullTypeDecl)?.Class ?? a.ResolvedClass;
                    var clB = (b.ResolvedClass as NonNullTypeDecl)?.Class ?? b.ResolvedClass;
                    equivalentHeads = MutateCSharp.Schemata208.ReplaceBinExprOp_41(1133L, clA, clB);
                }
            }
            if (equivalentHeads)
            {
                return MutateCSharp.Schemata208.ReplaceBinExprOp_7(1134L, () => ignoreTypeArguments, () => CompatibleTypeArgs(super, sub));
            }

            return sub.ParentTypes().Any(parentType => parentType.IsSubtypeOf(super, ignoreTypeArguments, ignoreNullity));
        }

        public static bool CompatibleTypeArgs(Type super, Type sub)
        {
            var polarities = GetPolarities(super);
            Contract.Assert(polarities.Count == super.TypeArgs.Count && polarities.Count == sub.TypeArgs.Count);
            var allGood = MutateCSharp.Schemata208.ReplaceBooleanConstant_1(1140L, true);
            for (int i = MutateCSharp.Schemata208.ReplaceNumericConstant_2(1141L, 0); MutateCSharp.Schemata208.ReplaceBinExprOp_5(1150L, () => allGood, () => MutateCSharp.Schemata208.ReplaceBinExprOp_44(1145L, i, polarities.Count)); MutateCSharp.Schemata208.ReplacePostfixUnaryExprOp_45(1156L, ref i))
            {
                switch (polarities[i])
                {
                    case TypeParameter.TPVariance.Co:
                        allGood = IsSupertype(super.TypeArgs[i], sub.TypeArgs[i]);
                        break;
                        break;
                    case TypeParameter.TPVariance.Contra:
                        allGood = IsSupertype(sub.TypeArgs[i], super.TypeArgs[i]);
                        break;
                        break;
                    case TypeParameter.TPVariance.Non:
                    default:  // "default" shouldn't ever happen
                        allGood = Equal_Improved(super.TypeArgs[i], sub.TypeArgs[i]);
                        break;
                        break;
                }
            }
            return allGood;
        }
    }

    /// <summary>
    /// An ArtificialType is only used during type checking. It should never be assigned as the type of any expression.
    /// It works as a supertype to numeric literals. For example, the literal 6 can be an "int", a "bv16", a
    /// newtype based on integers, or an "ORDINAL". Type inference thus uses an "artificial" supertype of all of
    /// these types as the type of literal 6, until a more precise (and non-artificial) type is inferred for it.
    /// </summary>
    public abstract class ArtificialType : Type
    {
        public override bool ComputeMayInvolveReferences(ISet<DatatypeDecl>/*?*/ visitedDatatypes)
        {
            // ArtificialType's are used only with numeric types.
            return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(1157L, false);
        }

        public override Type Subst(IDictionary<TypeParameter, Type> subst)
        {
            throw new NotSupportedException();
            return default;
        }

        public override Type ReplaceTypeArguments(List<Type> arguments)
        {
            throw new NotSupportedException();
            return default;
        }
    }
    /// <summary>
    /// The type "IntVarietiesSupertype" is used to denote a decimal-less number type, namely an int-based type
    /// or a bitvector type.
    /// </summary>
    public class IntVarietiesSupertype : ArtificialType
    {
        [System.Diagnostics.Contracts.Pure]
        public override string TypeName(DafnyOptions options, ModuleDefinition context, bool parseAble)
        {
            return MutateCSharp.Schemata208.ReplaceStringConstant_0(1158L, "int");
        }
        public override bool Equals(Type that, bool keepConstraints = false)
        {
            return keepConstraints ? MutateCSharp.Schemata208.ReplaceBinExprOp_59(1159L, this.GetType(), that.GetType()) : that is IntVarietiesSupertype;
        }
    }
    public class RealVarietiesSupertype : ArtificialType
    {
        [System.Diagnostics.Contracts.Pure]
        public override string TypeName(DafnyOptions options, ModuleDefinition context, bool parseAble)
        {
            return MutateCSharp.Schemata208.ReplaceStringConstant_0(1160L, "real");
        }
        public override bool Equals(Type that, bool keepConstraints = false)
        {
            return keepConstraints ? MutateCSharp.Schemata208.ReplaceBinExprOp_59(1161L, this.GetType(), that.GetType()) : that is RealVarietiesSupertype;
        }
    }

    /// <summary>
    /// A NonProxy type is a fully constrained type.  It may contain members.
    /// </summary>
    public abstract class NonProxyType : Type
    {
    }

    public abstract class BasicType : NonProxyType
    {
        public override IEnumerable<INode> Children => Enumerable.Empty<Node>();
        public override bool ComputeMayInvolveReferences(ISet<DatatypeDecl>/*?*/ visitedDatatypes)
        {
            return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(1162L, false);
        }

        public override Type Subst(IDictionary<TypeParameter, Type> subst)
        {
            return this;
        }

        public override Type ReplaceTypeArguments(List<Type> arguments)
        {
            return this;
        }
    }

    public class BoolType : BasicType
    {
        [System.Diagnostics.Contracts.Pure]
        public override string TypeName(DafnyOptions options, ModuleDefinition context, bool parseAble)
        {
            return MutateCSharp.Schemata208.ReplaceStringConstant_0(1163L, "bool");
        }
        public override bool Equals(Type that, bool keepConstraints = false)
        {
            return that.IsBoolType;
        }
    }

    public class CharType : BasicType
    {
        public const char DefaultValue = 'D';
        public const string DefaultValueAsString = "'D'";
        [System.Diagnostics.Contracts.Pure]
        public override string TypeName(DafnyOptions options, ModuleDefinition context, bool parseAble)
        {
            return MutateCSharp.Schemata208.ReplaceStringConstant_0(1164L, "char");
        }
        public override bool Equals(Type that, bool keepConstraints = false)
        {
            return that.IsCharType;
        }
    }

    public class IntType : BasicType
    {
        [System.Diagnostics.Contracts.Pure]
        public override string TypeName(DafnyOptions options, ModuleDefinition context, bool parseAble)
        {
            return MutateCSharp.Schemata208.ReplaceStringConstant_0(1165L, "int");
        }
        public override bool Equals(Type that, bool keepConstraints = false)
        {
            return that.NormalizeExpand(keepConstraints) is IntType;
        }
        public override bool IsSubtypeOf(Type super, bool ignoreTypeArguments, bool ignoreNullity)
        {
            if (super is IntVarietiesSupertype)
            {
                return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(1166L, true);
            }
            return base.IsSubtypeOf(super, ignoreTypeArguments, ignoreNullity);
        }
    }

    public class RealType : BasicType
    {
        [System.Diagnostics.Contracts.Pure]
        public override string TypeName(DafnyOptions options, ModuleDefinition context, bool parseAble)
        {
            return MutateCSharp.Schemata208.ReplaceStringConstant_0(1167L, "real");
        }
        public override bool Equals(Type that, bool keepConstraints = false)
        {
            return that.NormalizeExpand(keepConstraints) is RealType;
        }
        public override bool IsSubtypeOf(Type super, bool ignoreTypeArguments, bool ignoreNullity)
        {
            if (super is RealVarietiesSupertype)
            {
                return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(1168L, true);
            }
            return base.IsSubtypeOf(super, ignoreTypeArguments, ignoreNullity);
        }
    }

    public class BigOrdinalType : BasicType
    {
        [System.Diagnostics.Contracts.Pure]
        public override string TypeName(DafnyOptions options, ModuleDefinition context, bool parseAble)
        {
            return MutateCSharp.Schemata208.ReplaceStringConstant_0(1169L, "ORDINAL");
        }
        public override bool Equals(Type that, bool keepConstraints = false)
        {
            return that.NormalizeExpand(keepConstraints) is BigOrdinalType;
        }
        public override bool IsSubtypeOf(Type super, bool ignoreTypeArguments, bool ignoreNullity)
        {
            if (super is IntVarietiesSupertype)
            {
                return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(1170L, true);
            }
            return base.IsSubtypeOf(super, ignoreTypeArguments, ignoreNullity);
        }
    }

    public class BitvectorType : BasicType
    {
        public readonly int Width;
        public readonly NativeType NativeType;
        public BitvectorType(DafnyOptions options, int width)
          : base()
        {
            Contract.Requires(0 <= width);
            Width = width;
            foreach (var nativeType in ModuleResolver.NativeTypes)
            {
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_5(1176L, () => options.Backend.SupportedNativeTypes.Contains(nativeType.Name), () => MutateCSharp.Schemata208.ReplaceBinExprOp_38(1171L, width, nativeType.Bitwidth)))
                {
                    NativeType = nativeType;
                    break;
                }
            }
        }

        public string Name => MutateCSharp.Schemata208.ReplaceStringConstant_0(1182L, "bv") + Width;

        [System.Diagnostics.Contracts.Pure]
        public override string TypeName(DafnyOptions options, ModuleDefinition context, bool parseAble)
        {
            return Name;
        }
        public override bool Equals(Type that, bool keepConstraints = false)
        {
            var bv = that.NormalizeExpand(keepConstraints) as BitvectorType;
            return MutateCSharp.Schemata208.ReplaceBinExprOp_5(1189L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_13(1183L, bv, null), () => MutateCSharp.Schemata208.ReplaceBinExprOp_36(1184L, bv.Width, Width));
        }
        public override bool IsSubtypeOf(Type super, bool ignoreTypeArguments, bool ignoreNullity)
        {
            if (super is IntVarietiesSupertype)
            {
                return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(1195L, true);
            }
            return base.IsSubtypeOf(super, ignoreTypeArguments, ignoreNullity);
        }
    }

    public class SelfType : NonProxyType
    {
        public TypeParameter TypeArg;
        public Type ResolvedType;
        public SelfType() : base()
        {
            TypeArg = new TypeParameter(RangeToken.NoToken, new Name(MutateCSharp.Schemata208.ReplaceStringConstant_0(1196L, "selfType")), TypeParameter.TPVarianceSyntax.NonVariant_Strict);
        }

        [System.Diagnostics.Contracts.Pure]
        public override string TypeName(DafnyOptions options, ModuleDefinition context, bool parseAble)
        {
            return MutateCSharp.Schemata208.ReplaceStringConstant_0(1197L, "selftype");
        }
        public override bool Equals(Type that, bool keepConstraints = false)
        {
            return that.NormalizeExpand(keepConstraints) is SelfType;
        }

        public override Type Subst(IDictionary<TypeParameter, Type> subst)
        {
            if (subst.TryGetValue(TypeArg, out var t))
            {
                return t;
            }
            else
            {
                // SelfType's are used only in certain restricted situations. In those situations, we need to be able
                // to substitute for the the SelfType's TypeArg. That's the only case in which we expect to see a
                // SelfType being part of a substitution operation at all.
                Contract.Assert(false); throw new cce.UnreachableException();
            }

            return default;
        }

        public override Type ReplaceTypeArguments(List<Type> arguments)
        {
            throw new NotSupportedException();
            return default;
        }

        public override bool ComputeMayInvolveReferences(ISet<DatatypeDecl>/*?*/ visitedDatatypes)
        {
            // SelfType is used only with bitvector types
            return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(1198L, false);
        }
    }

    public abstract class CollectionType : NonProxyType
    {
        public abstract string CollectionTypeName { get; }

        public override IEnumerable<Node> Nodes => TypeArgs.SelectMany(ta => ta.Nodes);

        public override string TypeName(DafnyOptions options, ModuleDefinition context, bool parseAble)
        {
            Contract.Ensures(Contract.Result<string>() != null);
            var targs = HasTypeArg() ? this.TypeArgsToString(options, context, parseAble) : "";
            return CollectionTypeName + targs;
        }
        public Type Arg
        {
            get
            {
                Contract.Ensures(Contract.Result<Type>() != null);  // this is true only after "arg" has really been set (i.e., it follows from the precondition)
                Contract.Assume(arg != null);  // This is really a precondition.  Don't call Arg until "arg" has been set.
                return arg;
            }
        }

        [FilledInDuringResolution]
        private Type arg;
        public Type ValueArg => TypeArgs.Last();

        // The following methods, HasTypeArg and SetTypeArg/SetTypeArgs, are to be called during resolution to make sure that "arg" becomes set.
        public bool HasTypeArg()
        {
            return MutateCSharp.Schemata208.ReplaceBinExprOp_57(1199L, arg, null);
        }
        public void SetTypeArg(Type arg)
        {
            Contract.Requires(arg != null);
            Contract.Requires(1 <= this.TypeArgs.Count);  // this is actually an invariant of all collection types
            Contract.Assume(this.arg == null);  // Can only set it once.  This is really a precondition.
            this.arg = arg;
            this.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(1200L, 0)] = arg;
        }
        public virtual void SetTypeArgs(Type arg, Type other)
        {
            Contract.Requires(arg != null);
            Contract.Requires(other != null);
            Contract.Requires(this.TypeArgs.Count == 2);
            Contract.Assume(this.arg == null);  // Can only set it once.  This is really a precondition.
            this.arg = arg;
            this.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(1204L, 0)] = arg;
            this.TypeArgs[MutateCSharp.Schemata208.ReplaceNumericConstant_2(1208L, 1)] = other;
        }
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            // Contract.Invariant(Contract.ForAll(TypeArgs, tp => tp != null));
            // After resolution, the following is invariant:  Contract.Invariant(Arg != null);
            // However, it may not be true until then.
        }
        /// <summary>
        /// This constructor is a collection types with 1 type argument
        /// </summary>
        protected CollectionType(Type arg)
        {
            this.arg = arg;
            this.TypeArgs = new List<Type> { arg };
        }
        /// <summary>
        /// This constructor is a collection types with 2 type arguments
        /// </summary>
        protected CollectionType(Type arg, Type other)
        {
            this.arg = arg;
            this.TypeArgs = new List<Type> { arg, other };
        }

        protected CollectionType(Cloner cloner, CollectionType original)
        {
            this.arg = cloner.CloneType(original.arg);
        }

        public override bool ComputeMayInvolveReferences(ISet<DatatypeDecl> visitedDatatypes)
        {
            return Arg.ComputeMayInvolveReferences(visitedDatatypes);
        }

        /// <summary>
        /// This property returns the ResolvedOpcode for the "in" operator when used with this collection type.
        /// </summary>
        public abstract BinaryExpr.ResolvedOpcode ResolvedOpcodeForIn { get; }

        /// <summary>
        /// For a given "source", denoting an expression of this CollectionType, return the BoundedPool corresponding
        /// to an expression "x in source".
        /// </summary>
        public abstract CollectionBoundedPool GetBoundedPool(Expression source);
    }

    public class SetType : CollectionType
    {
        private bool finite;

        public bool Finite
        {
            get { return finite; }
            set { finite = value; }
        }

        public SetType(bool finite, Type arg) : base(arg)
        {
            this.finite = finite;
        }
        public override string CollectionTypeName
        {
            get { return finite ? MutateCSharp.Schemata208.ReplaceStringConstant_0(1212L, "set") : MutateCSharp.Schemata208.ReplaceStringConstant_0(1213L, "iset"); }
        }

        [System.Diagnostics.Contracts.Pure]
        public override bool Equals(Type that, bool keepConstraints = false)
        {
            var t = that.NormalizeExpand(keepConstraints) as SetType;
            return MutateCSharp.Schemata208.ReplaceBinExprOp_5(1227L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_5(1221L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_21(1214L, t, null), () => MutateCSharp.Schemata208.ReplaceBinExprOp_40(1215L, () => Finite, () => t.Finite)), () => Arg.Equals(t.Arg, keepConstraints));
        }

        public override Type Subst(IDictionary<TypeParameter, Type> subst)
        {
            var arg = Arg.Subst(subst);
            if (arg is InferredTypeProxy)
            {
                ((InferredTypeProxy)arg).KeepConstraints = MutateCSharp.Schemata208.ReplaceBooleanConstant_1(1233L, true);
            }
            return MutateCSharp.Schemata208.ReplaceBinExprOp_39(1234L, arg, Arg) ? this : new SetType(Finite, arg);
        }

        public override Type ReplaceTypeArguments(List<Type> arguments)
        {
            return new SetType(Finite, arguments[MutateCSharp.Schemata208.ReplaceNumericConstant_2(1235L, 0)]);
        }

        public override bool SupportsEquality
        {
            get
            {
                // Sets always support equality, because there is a check that the set element type always does.
                return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(1239L, true);
            }
        }

        public override BinaryExpr.ResolvedOpcode ResolvedOpcodeForIn => BinaryExpr.ResolvedOpcode.InSet;
        public override CollectionBoundedPool GetBoundedPool(Expression source)
        {
            return new SetBoundedPool(source, Arg, Arg, Finite);
        }
    }

    public class MultiSetType : CollectionType
    {
        public MultiSetType(Type arg) : base(arg)
        {
        }
        public override string CollectionTypeName
        {
            get { return MutateCSharp.Schemata208.ReplaceStringConstant_0(1240L, "multiset"); }
        }

        public override bool Equals(Type that, bool keepConstraints = false)
        {
            var t = that.NormalizeExpand(keepConstraints) as MultiSetType;
            return MutateCSharp.Schemata208.ReplaceBinExprOp_5(1242L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_60(1241L, t, null), () => Arg.Equals(t.Arg, keepConstraints));
        }

        public override Type Subst(IDictionary<TypeParameter, Type> subst)
        {
            var arg = Arg.Subst(subst);
            if (arg is InferredTypeProxy)
            {
                ((InferredTypeProxy)arg).KeepConstraints = MutateCSharp.Schemata208.ReplaceBooleanConstant_1(1248L, true);
            }
            return MutateCSharp.Schemata208.ReplaceBinExprOp_39(1249L, arg, Arg) ? this : new MultiSetType(arg);
        }

        public override Type ReplaceTypeArguments(List<Type> arguments)
        {
            return new MultiSetType(arguments[MutateCSharp.Schemata208.ReplaceNumericConstant_2(1250L, 0)]);
        }

        public override bool SupportsEquality
        {
            get
            {
                // Multisets always support equality, because there is a check that the set element type always does.
                return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(1254L, true);
            }
        }

        public override BinaryExpr.ResolvedOpcode ResolvedOpcodeForIn => BinaryExpr.ResolvedOpcode.InMultiSet;
        public override CollectionBoundedPool GetBoundedPool(Expression source)
        {
            return new MultiSetBoundedPool(source, Arg, Arg);
        }
    }

    public class SeqType : CollectionType
    {
        public SeqType(Type arg) : base(arg)
        {
        }
        public override string CollectionTypeName
        {
            get { return MutateCSharp.Schemata208.ReplaceStringConstant_0(1255L, "seq"); }
        }

        public override bool Equals(Type that, bool keepConstraints = false)
        {
            var t = that.NormalizeExpand(keepConstraints) as SeqType;
            return MutateCSharp.Schemata208.ReplaceBinExprOp_5(1257L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_61(1256L, t, null), () => Arg.Equals(t.Arg, keepConstraints));
        }

        public override Type Subst(IDictionary<TypeParameter, Type> subst)
        {
            var arg = Arg.Subst(subst);
            if (arg is InferredTypeProxy)
            {
                ((InferredTypeProxy)arg).KeepConstraints = MutateCSharp.Schemata208.ReplaceBooleanConstant_1(1263L, true);
            }
            return MutateCSharp.Schemata208.ReplaceBinExprOp_39(1264L, arg, Arg) ? this : new SeqType(arg);
        }

        public override Type ReplaceTypeArguments(List<Type> arguments)
        {
            return new SeqType(arguments[MutateCSharp.Schemata208.ReplaceNumericConstant_2(1265L, 0)]);
        }

        public override bool SupportsEquality
        {
            get
            {
                // The sequence type supports equality if its element type does
                return Arg.SupportsEquality;
            }
        }

        public override BinaryExpr.ResolvedOpcode ResolvedOpcodeForIn => BinaryExpr.ResolvedOpcode.InSeq;
        public override CollectionBoundedPool GetBoundedPool(Expression source)
        {
            return new SeqBoundedPool(source, Arg, Arg);
        }
    }

    public abstract class TypeProxy : Type
    {
        public override IEnumerable<INode> Children => Enumerable.Empty<Node>();
        [FilledInDuringResolution] public Type T;
        public readonly List<TypeConstraint> SupertypeConstraints = new List<TypeConstraint>();
        public readonly List<TypeConstraint> SubtypeConstraints = new List<TypeConstraint>();

        public override Type Subst(IDictionary<TypeParameter, Type> subst)
        {
            if (MutateCSharp.Schemata208.ReplaceBinExprOp_47(1269L, T, null))
            {
                return this;
            }
            var s = T.Subst(subst);
            return MutateCSharp.Schemata208.ReplaceBinExprOp_39(1270L, s, T) ? this : s;

        }

        public override Type ReplaceTypeArguments(List<Type> arguments)
        {
            throw new NotSupportedException();
            return default;
        }

        public IEnumerable<Type> Supertypes
        {
            get
            {
                foreach (var c in SupertypeConstraints)
                {
                    if (c.KeepConstraints)
                    {
                        yield return c.Super.NormalizeExpandKeepConstraints();
                    }
                    else
                    {
                        yield return c.Super.NormalizeExpand();
                    }
                }

                yield break;
            }
        }

        public IEnumerable<Type> SupertypesKeepConstraints
        {
            get
            {
                foreach (var c in SupertypeConstraints)
                {
                    yield return c.Super.NormalizeExpandKeepConstraints();
                }

                yield break;
            }
        }

        public void AddSupertype(TypeConstraint c)
        {
            Contract.Requires(c != null);
            Contract.Requires(c.Sub == this);
            SupertypeConstraints.Add(c);
        }
        public IEnumerable<Type> Subtypes
        {
            get
            {
                foreach (var c in SubtypeConstraints)
                {
                    if (c.KeepConstraints)
                    {
                        yield return c.Sub.NormalizeExpandKeepConstraints();
                    }
                    else
                    {
                        yield return c.Sub.NormalizeExpand();
                    }
                }

                yield break;
            }
        }

        public IEnumerable<Type> SubtypesKeepConstraints
        {
            get
            {
                foreach (var c in SubtypeConstraints)
                {
                    yield return c.Sub.NormalizeExpandKeepConstraints();
                }

                yield break;
            }
        }

        public IEnumerable<Type> SubtypesKeepConstraints_WithAssignable(List<XConstraint> allXConstraints)
        {
            Contract.Requires(allXConstraints != null);
            foreach (var c in SubtypeConstraints)
            {
                yield return c.Sub.NormalizeExpandKeepConstraints();
            }
            foreach (var xc in allXConstraints)
            {
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_62(1272L, xc.ConstraintName, MutateCSharp.Schemata208.ReplaceStringConstant_0(1271L, "Assignable")))
                {
                    if (MutateCSharp.Schemata208.ReplaceBinExprOp_58(1277L, xc.Types[MutateCSharp.Schemata208.ReplaceNumericConstant_2(1273L, 0)].Normalize(), this))
                    {
                        yield return xc.Types[MutateCSharp.Schemata208.ReplaceNumericConstant_2(1278L, 1)].NormalizeExpandKeepConstraints();
                    }
                }
            }

            yield break;
        }

        public void AddSubtype(TypeConstraint c)
        {
            Contract.Requires(c != null);
            Contract.Requires(c.Super == this);
            SubtypeConstraints.Add(c);
        }

        public enum Family { Unknown, Bool, Char, IntLike, RealLike, Ordinal, BitVector, ValueType, Ref, Opaque }
        public Family family = Family.Unknown;
        public static Family GetFamily(Type t)
        {
            Contract.Ensures(Contract.Result<Family>() != Family.Unknown || t is TypeProxy || t is Resolver_IdentifierExpr.ResolverType);  // return Unknown ==> t is TypeProxy || t is ResolverType
            if (t.IsBoolType)
            {
                return Family.Bool;
            }
            else if (t.IsCharType)
            {
                return Family.Char;
            }
            else if (MutateCSharp.Schemata208.ReplaceBinExprOp_7(1282L, () => t.IsNumericBased(NumericPersuasion.Int), () => t is IntVarietiesSupertype))
            {
                return Family.IntLike;
            }
            else if (MutateCSharp.Schemata208.ReplaceBinExprOp_7(1288L, () => t.IsNumericBased(NumericPersuasion.Real), () => t is RealVarietiesSupertype))
            {
                return Family.RealLike;
            }
            else if (t.IsBigOrdinalType)
            {
                return Family.Ordinal;
            }
            else if (t.IsBitVectorType)
            {
                return Family.BitVector;
            }
            else if (MutateCSharp.Schemata208.ReplaceBinExprOp_7(1302L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(1296L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_63(1294L, t.AsCollectionType, null), () => MutateCSharp.Schemata208.ReplaceBinExprOp_31(1295L, t.AsArrowType, null)), () => t.IsDatatype))
            {
                return Family.ValueType;
            }
            else if (t.IsRefType)
            {
                return Family.Ref;
            }
            else if (MutateCSharp.Schemata208.ReplaceBinExprOp_7(1314L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_7(1308L, () => t.IsTypeParameter, () => t.IsAbstractType), () => t.IsInternalTypeSynonym))
            {
                return Family.Opaque;
            }
            else if (t is TypeProxy)
            {
                return ((TypeProxy)t).family;
            }
            else
            {
                return Family.Unknown;
            }

            return default;
        }

        internal TypeProxy()
        {
        }

#if TI_DEBUG_PRINT
        static int _id = MutateCSharp.Schemata208.ReplaceNumericConstant_2(1320L, 0);
        int id = MutateCSharp.Schemata208.ReplacePostfixUnaryExprOp_45(1324L, ref _id);
#endif
        [System.Diagnostics.Contracts.Pure]
        public override string TypeName(DafnyOptions options, ModuleDefinition context, bool parseAble)
        {
            Contract.Ensures(Contract.Result<string>() != null);
#if TI_DEBUG_PRINT
            if (options.Get(CommonOptionBag.TypeInferenceDebug))
            {
                return MutateCSharp.Schemata208.ReplaceBinExprOp_47(1325L, T, null) ? MutateCSharp.Schemata208.ReplaceStringConstant_0(1326L, "?") + id : T.TypeName(options, context);
            }
#endif
            return MutateCSharp.Schemata208.ReplaceBinExprOp_47(1327L, T, null) ? MutateCSharp.Schemata208.ReplaceStringConstant_0(1328L, "?") : T.TypeName(options, context, parseAble);
        }
        public override bool SupportsEquality
        {
            get
            {
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_57(1329L, T, null))
                {
                    return T.SupportsEquality;
                }
                else
                {
                    return base.SupportsEquality;
                }

                return default;
            }
        }

        public override bool ComputeMayInvolveReferences(ISet<DatatypeDecl> visitedDatatypes)
        {
            if (MutateCSharp.Schemata208.ReplaceBinExprOp_57(1330L, T, null))
            {
                return T.ComputeMayInvolveReferences(visitedDatatypes);
            }
            else
            {
                return MutateCSharp.Schemata208.ReplaceBooleanConstant_1(1331L, true);
            }

            return default;
        }
        public override bool Equals(Type that, bool keepConstraints = false)
        {
            var i = NormalizeExpand(keepConstraints);
            if (i is TypeProxy)
            {
                var u = that.NormalizeExpand(keepConstraints) as TypeProxy;
                return MutateCSharp.Schemata208.ReplaceBinExprOp_5(1333L, () => MutateCSharp.Schemata208.ReplaceBinExprOp_64(1332L, u, null), () => object.ReferenceEquals(i, u));
            }
            else
            {
                return i.Equals(that, keepConstraints);
            }

            return default;
        }

        [System.Diagnostics.Contracts.Pure]
        internal static bool IsSupertypeOfLiteral(Type t)
        {
            Contract.Requires(t != null);
            return t is ArtificialType;
        }
        internal Type InClusterOfArtificial(List<XConstraint> allXConstraints)
        {
            Contract.Requires(allXConstraints != null);
            return InClusterOfArtificial_aux(new HashSet<TypeProxy>(), allXConstraints);
        }
        private Type InClusterOfArtificial_aux(ISet<TypeProxy> visitedProxies, List<XConstraint> allXConstraints)
        {
            Contract.Requires(visitedProxies != null);
            Contract.Requires(allXConstraints != null);
            if (visitedProxies.Contains(this))
            {
                return null;
            }
            visitedProxies.Add(this);
            foreach (var c in SupertypeConstraints)
            {
                var sup = c.Super.Normalize();
                if (sup is IntVarietiesSupertype)
                {
                    return Type.Int;
                }
                else if (sup is RealVarietiesSupertype)
                {
                    return Type.Real;
                }
                else if (sup is TypeProxy)
                {
                    var a = ((TypeProxy)sup).InClusterOfArtificial_aux(visitedProxies, allXConstraints);
                    if (MutateCSharp.Schemata208.ReplaceBinExprOp_57(1339L, a, null))
                    {
                        return a;
                    }
                }
            }
            foreach (var su in SubtypesKeepConstraints_WithAssignable(allXConstraints))
            {
                var pr = su as TypeProxy;
                if (MutateCSharp.Schemata208.ReplaceBinExprOp_64(1340L, pr, null))
                {
                    var a = pr.InClusterOfArtificial_aux(visitedProxies, allXConstraints);
                    if (MutateCSharp.Schemata208.ReplaceBinExprOp_57(1341L, a, null))
                    {
                        return a;
                    }
                }
            }
            return null;
        }
    }

    /// <summary>
    /// This proxy stands for any type.
    /// </summary>
    public class InferredTypeProxy : TypeProxy
    {
        public bool KeepConstraints;
        public InferredTypeProxy() : base()
        {
            KeepConstraints = MutateCSharp.Schemata208.ReplaceBooleanConstant_1(1342L, false); // whether the typeProxy should be inferred to base type or as subset type
        }
    }

    /// <summary>
    /// This proxy stands for any type, but it originates from an instantiated type parameter.
    /// </summary>
    public class ParamTypeProxy : TypeProxy
    {
        public override IEnumerable<INode> Children => Enumerable.Empty<Node>();
        public TypeParameter orig;
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(orig != null);
        }

        public ParamTypeProxy(TypeParameter orig)
        {
            Contract.Requires(orig != null);
            this.orig = orig;
        }
    }
}
