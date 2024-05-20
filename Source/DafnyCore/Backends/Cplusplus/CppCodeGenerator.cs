//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Diagnostics.Contracts;
using System.Collections.ObjectModel;
using System.IO;
using JetBrains.Annotations;
namespace MutateCSharp
{
    internal class Schemata217
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT217");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_39(long mutantId, Microsoft.Dafny.UnaryOpExpr.Opcode argument1, Microsoft.Dafny.UnaryOpExpr.Opcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static ulong ReplaceBinExprOp_32(long mutantId, ulong argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 >> argument2; }
            return argument1 << argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.DatatypeCtor argument1, Microsoft.Dafny.DatatypeCtor argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBinExprOp_29(long mutantId, System.Numerics.BigInteger argument1, long argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 > argument2;
        }

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, Microsoft.Dafny.DatatypeDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_35(long mutantId, Microsoft.Dafny.SpecialField.ID argument1, Microsoft.Dafny.SpecialField.ID argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_9(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_34(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
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

        internal static bool ReplaceBinExprOp_24(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_36(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, Microsoft.Dafny.IndDatatypeDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.NativeType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_38(long mutantId, Microsoft.Dafny.UnaryOpExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_37(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_30(long mutantId, int argument1, int argument2)
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

        internal static ulong ReplaceBinExprOp_33(long mutantId, ulong argument1, ulong argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 6)) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 ^ argument2; }
            return argument1 - argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.NativeType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.TypeParameter> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static ulong ReplaceNumericConstant_31(long mutantId, ulong argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 2)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.SubsetTypeDecl.WKind argument1, Microsoft.Dafny.SubsetTypeDecl.WKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_7(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_40(long mutantId, Microsoft.Dafny.MemberSelectExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Type> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_23(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, Microsoft.Dafny.NewtypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.TypeParameter> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, Microsoft.Dafny.CallStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static long ReplaceNumericConstant_28(long mutantId, long argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, Microsoft.Dafny.Constructor argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny.Compilers
{
    public class CppCodeGenerator : SinglePassCodeGenerator
    {

        private readonly ReadOnlyCollection<string> headers;

        public CppCodeGenerator(DafnyOptions options, ErrorReporter reporter, ReadOnlyCollection<string> headers) : base(options, reporter)
        {
            this.headers = headers;
        }

        public override IReadOnlySet<Feature> UnsupportedFeatures => new HashSet<Feature> {
      Feature.UnboundedIntegers,
      Feature.RealNumbers,
      Feature.CollectionsOfTraits,
      Feature.Codatatypes,
      Feature.Multisets,
      Feature.ExternalClasses,
      Feature.Traits,
      Feature.Iterators,
      Feature.NonNativeNewtypes,
      Feature.RuntimeTypeDescriptors,
      Feature.MultiDimensionalArrays,
      Feature.CollectionsOfTraits,
      Feature.Quantifiers,
      Feature.NewObject,
      Feature.BitvectorRotateFunctions,
      Feature.NonSequentializableForallStatements,
      Feature.FunctionValues,
      Feature.ArrayLength,
      Feature.Ordinals,
      Feature.MapItems,
      Feature.Codatatypes,
      Feature.LetSuchThatExpressions,
      Feature.NonNativeNewtypes,
      Feature.TypeTests,
      Feature.SubsetTypeTests,
      Feature.SequenceDisplaysOfCharacters,
      Feature.MapComprehensions,
      Feature.ExactBoundedPool,
      Feature.RunAllTests,
      Feature.MethodSynthesis,
      Feature.UnicodeChars,
      Feature.ConvertingValuesToStrings,
      Feature.BuiltinsInRuntime,
      Feature.RuntimeCoverageReport
    };

        private List<DatatypeDecl> datatypeDecls = new();
        private List<string> classDefaults = new();

        /*
         * Unlike other Dafny and Dafny's other backends, C++ cares about
         * the order in which types are declared.  To make this more likely
         * to succeed, we emit type information as gradually as possible
         * in hopes that definitions are in place when needed.
         */

        // Forward declarations of class and struct names
        private ConcreteSyntaxTree modDeclsWr = null;
        private ConcreteSyntaxTree modDeclWr = null;
        // Dafny datatype declarations
        private ConcreteSyntaxTree dtDeclsWr = null;
        private ConcreteSyntaxTree dtDeclWr = null;
        // Dafny class declarations
        private ConcreteSyntaxTree classDeclsWr = null;
        private ConcreteSyntaxTree classDeclWr = null;
        // Dedicated hash-function definitions for each type
        private ConcreteSyntaxTree hashWr = null;

        const string DafnySetClass = "DafnySet";
        const string DafnyMultiSetClass = "DafnyMultiset";
        const string DafnySeqClass = "DafnySequence";
        const string DafnyMapClass = "DafnyMap";

        public override string ModuleSeparator => MutateCSharp.Schemata217.ReplaceStringConstant_0(1L, "::");
        protected override string StaticClassAccessor => MutateCSharp.Schemata217.ReplaceStringConstant_0(2L, "::");
        protected override string InstanceClassAccessor => MutateCSharp.Schemata217.ReplaceStringConstant_0(3L, "->");

        protected override void EmitHeader(Program program, ConcreteSyntaxTree wr)
        {
            // This seems to be a good place to check for unsupported options
            if (UnicodeCharEnabled)
            {
                throw new UnsupportedFeatureException(program.GetStartOfFirstFileToken(), Feature.UnicodeChars);
            }

            wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(4L, "// Dafny program {0} compiled into Cpp"), program.Name);
            wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(5L, "#include \"DafnyRuntime.h\""));
            foreach (var header in this.headers)
            {
                wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(6L, "#include \"{0}\""), Path.GetFileName(header));
            }

            // For "..."s string literals, to avoid interpreting /0 as the C end of the string, cstring-style
            wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(7L, "using namespace std::literals;"));

            var filenameNoExtension = program.Name.Substring(MutateCSharp.Schemata217.ReplaceNumericConstant_1(8L, 0), MutateCSharp.Schemata217.ReplaceBinExprOp_2(16L, program.Name.Length, MutateCSharp.Schemata217.ReplaceNumericConstant_1(12L, 4)));
            var headerFileName = $"{filenameNoExtension}.h";
            wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(25L, "#include \"{0}\""), Path.GetFileName(headerFileName));

            var headerFileWr = wr.NewFile(headerFileName);
            headerFileWr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(26L, "// Dafny program {0} compiled into a Cpp header file"), program.Name);
            headerFileWr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(27L, "#pragma once"));
            headerFileWr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(28L, "#include \"DafnyRuntime.h\""));

            this.modDeclsWr = headerFileWr.Fork();
            this.dtDeclsWr = headerFileWr.Fork();
            this.classDeclsWr = headerFileWr.Fork();
            this.hashWr = headerFileWr.Fork();

            if (Options.IncludeRuntime)
            {
                EmitRuntimeSource(MutateCSharp.Schemata217.ReplaceStringConstant_0(29L, "DafnyRuntimeCpp"), wr);
            }

        }
        protected override void EmitFooter(Program program, ConcreteSyntaxTree wr)
        {
            // Define default values for each datatype
            foreach (var dt in this.datatypeDecls)
            {
                var wd = wr.NewBlock(String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(30L, "template <{0}>\nstruct get_default<{1}::{2}{3} >"),
                  TypeParameters(dt.TypeArgs),
                  dt.EnclosingModuleDefinition.GetCompileName(Options),
                  dt.GetCompileName(Options),
                  InstantiateTemplate(dt.TypeArgs)), MutateCSharp.Schemata217.ReplaceStringConstant_0(31L, ";"));
                var wc = wd.NewBlock(String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(32L, "static {0}::{1}{2} call()"),
                  dt.EnclosingModuleDefinition.GetCompileName(Options),
                  dt.GetCompileName(Options),
                  InstantiateTemplate(dt.TypeArgs)));
                wc.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(33L, "return {0}::{1}{2}();"), dt.EnclosingModuleDefinition.GetCompileName(Options), dt.GetCompileName(Options), InstantiateTemplate(dt.TypeArgs));
            }

            // Define default values for each class
            foreach (var classDefault in classDefaults)
            {
                wr.WriteLine(classDefault);
            }
        }

        public override void EmitCallToMain(Method mainMethod, string baseName, ConcreteSyntaxTree wr)
        {
            var w = wr.NewBlock(MutateCSharp.Schemata217.ReplaceStringConstant_0(34L, "int main(int argc, char *argv[])"));
            var tryWr = w.NewBlock(MutateCSharp.Schemata217.ReplaceStringConstant_0(35L, "try"));
            tryWr.WriteLine(string.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(36L, "{0}::{1}::{2}(dafny_get_args(argc, argv));"), mainMethod.EnclosingClass.EnclosingModuleDefinition.GetCompileName(Options), mainMethod.EnclosingClass.GetCompileName(Options), mainMethod.Name));
            var catchWr = w.NewBlock(MutateCSharp.Schemata217.ReplaceStringConstant_0(37L, "catch (DafnyHaltException & e)"));
            catchWr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(38L, "std::cout << \"Program halted: \" << e.what() << std::endl;"));
        }

        protected override ConcreteSyntaxTree CreateStaticMain(IClassWriter cw, string argsParameterName)
        {
            var wr = (cw as ClassWriter).MethodWriter;
            return wr.NewBlock($"int main(DafnySequence<DafnySequence<char>> {argsParameterName})");
        }

        protected override ConcreteSyntaxTree CreateModule(string moduleName, bool isDefault, ModuleDefinition externModule,
          string libraryName /*?*/, ConcreteSyntaxTree wr)
        {
            var s = $"namespace {IdProtect(moduleName)} ";
            string footer = MutateCSharp.Schemata217.ReplaceStringConstant_0(39L, "// end of ") + s + MutateCSharp.Schemata217.ReplaceStringConstant_0(40L, " declarations");
            this.modDeclWr = this.modDeclsWr.NewBlock(s, footer);
            string footer1 = MutateCSharp.Schemata217.ReplaceStringConstant_0(41L, "// end of ") + s + MutateCSharp.Schemata217.ReplaceStringConstant_0(42L, " datatype declarations");
            this.dtDeclWr = this.dtDeclsWr.NewBlock(s, footer1);
            string footer2 = MutateCSharp.Schemata217.ReplaceStringConstant_0(43L, "// end of ") + s + MutateCSharp.Schemata217.ReplaceStringConstant_0(44L, " class declarations");
            this.classDeclWr = this.classDeclsWr.NewBlock(s, footer2);
            string footer3 = MutateCSharp.Schemata217.ReplaceStringConstant_0(45L, "// end of ") + s;
            return wr.NewBlock(s, footer3);
        }

        private string TypeParameters(List<TypeParameter> targs)
        {
            Contract.Requires(cce.NonNullElements(targs));
            Contract.Ensures(Contract.Result<string>() != null);
            if (MutateCSharp.Schemata217.ReplaceBinExprOp_3(46L, targs, null))
            {
                return Util.Comma(targs, tp => MutateCSharp.Schemata217.ReplaceStringConstant_0(47L, "typename ") + IdName(tp));
            }
            else
            {
                return "";
            }

            return default;
        }

        private string DeclareTemplate(List<TypeParameter> typeArgs)
        {
            var targs = "";
            if (MutateCSharp.Schemata217.ReplaceBinExprOp_5(58L, () => MutateCSharp.Schemata217.ReplaceBinExprOp_3(48L, typeArgs, null), () => MutateCSharp.Schemata217.ReplaceBinExprOp_4(53L, typeArgs.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(49L, 0))))
            {
                targs = String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(64L, "template <{0}>"), TypeParameters(typeArgs));
            }
            return targs;
        }

        private string DeclareTemplate(List<Type> typeArgs)
        {
            var targs = "";
            if (MutateCSharp.Schemata217.ReplaceBinExprOp_5(75L, () => MutateCSharp.Schemata217.ReplaceBinExprOp_6(65L, typeArgs, null), () => MutateCSharp.Schemata217.ReplaceBinExprOp_4(70L, typeArgs.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(66L, 0))))
            {
                targs = String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(81L, "template <{0}>"), Util.Comma(typeArgs, t => MutateCSharp.Schemata217.ReplaceStringConstant_0(82L, "typename ") + TypeName(t, null, null)));
            }
            return targs;
        }

        private string InstantiateTemplate(List<TypeParameter> typeArgs)
        {
            if (MutateCSharp.Schemata217.ReplaceBinExprOp_3(83L, typeArgs, null))
            {
                var targs = "";
                if (MutateCSharp.Schemata217.ReplaceBinExprOp_4(88L, typeArgs.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(84L, 0)))
                {
                    targs = String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(93L, "<{0}>"), Util.Comma(typeArgs, ta => ta.GetCompileName(Options)));
                }
                return targs;
            }
            else
            {
                return "";
            }

            return default;
        }

        private string InstantiateTemplate(List<Type> typeArgs)
        {
            if (MutateCSharp.Schemata217.ReplaceBinExprOp_6(94L, typeArgs, null))
            {
                var targs = "";
                if (MutateCSharp.Schemata217.ReplaceBinExprOp_4(99L, typeArgs.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(95L, 0)))
                {
                    targs = String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(104L, "<{0}>"), Util.Comma(typeArgs, ta => TypeName(ta, null, Token.NoToken)));
                }

                return targs;
            }
            else
            {
                return "";
            }

            return default;
        }

        protected override string GetHelperModuleName() => MutateCSharp.Schemata217.ReplaceStringConstant_0(105L, "_dafny");

        protected override IClassWriter CreateClass(string moduleName, string name, bool isExtern, string/*?*/ fullPrintName, List<TypeParameter>/*?*/ typeParameters, TopLevelDecl cls, List<Type>/*?*/ superClasses, IToken tok, ConcreteSyntaxTree wr)
        {
            if (isExtern)
            {
                throw new UnsupportedFeatureException(tok, Feature.ExternalClasses, String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(106L, "extern in class {0}"), name));
            }
            if (MutateCSharp.Schemata217.ReplaceBinExprOp_5(108L, () => MutateCSharp.Schemata217.ReplaceBinExprOp_6(107L, superClasses, null), () => superClasses.Any(trait => !trait.IsObject)))
            {
                throw new UnsupportedFeatureException(tok, Feature.Traits);
            }

            var classDeclWriter = modDeclWr;
            var classDefWriter = this.classDeclWr;

            if (MutateCSharp.Schemata217.ReplaceBinExprOp_5(124L, () => MutateCSharp.Schemata217.ReplaceBinExprOp_3(114L, typeParameters, null), () => MutateCSharp.Schemata217.ReplaceBinExprOp_4(119L, typeParameters.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(115L, 0))))
            {
                classDeclWriter.WriteLine(DeclareTemplate(typeParameters));
                classDefWriter.WriteLine(DeclareTemplate(typeParameters));
            }

            var methodDeclWriter = classDefWriter.NewBlock(string.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(130L, "class {0}"), name), MutateCSharp.Schemata217.ReplaceStringConstant_0(131L, ";"));
            var methodDefWriter = wr;

            classDeclWriter.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(132L, "class {0};"), name);

            methodDeclWriter.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(133L, "public:\n"));
            methodDeclWriter.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(134L, "// Default constructor"));
            methodDeclWriter.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(135L, "{0}() {{}}"), name);

            // Create the code for the specialization of get_default
            var fullName = moduleName + MutateCSharp.Schemata217.ReplaceStringConstant_0(136L, "::") + name;
            var getDefaultStr = String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(137L, "template <{0}>\nstruct get_default<std::shared_ptr<{1}{2} > > {{\n"),
              TypeParameters(typeParameters),
              fullName,
              InstantiateTemplate(typeParameters));
            getDefaultStr += String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(138L, "static std::shared_ptr<{0}{1} > call() {{\n"),
              fullName,
              InstantiateTemplate(typeParameters));
            getDefaultStr += String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(139L, "return std::shared_ptr<{0}{1} >();"), fullName, InstantiateTemplate(typeParameters));
            getDefaultStr += MutateCSharp.Schemata217.ReplaceStringConstant_0(140L, "}\n};");
            this.classDefaults.Add(getDefaultStr);

            var fieldWriter = methodDeclWriter;

            return new ClassWriter(name, this, methodDeclWriter, methodDefWriter, fieldWriter, wr);
        }

        protected override bool SupportsProperties { get => MutateCSharp.Schemata217.ReplaceBooleanConstant_7(141L, false); }

        protected override IClassWriter CreateTrait(string name, bool isExtern, List<TypeParameter> typeParameters /*?*/,
          TraitDecl trait, List<Type> superClasses /*?*/, IToken tok, ConcreteSyntaxTree wr)
        {
            throw new UnsupportedFeatureException(tok, Feature.Traits);
            return default;
        }

        protected override ConcreteSyntaxTree CreateIterator(IteratorDecl iter, ConcreteSyntaxTree wr)
        {
            throw new UnsupportedFeatureException(iter.tok, Feature.Iterators);
            return default;
        }

        protected bool IsRecursiveConstructor(DatatypeDecl dt, DatatypeCtor ctor)
        {
            foreach (var dtor in ctor.Destructors)
            {
                if (dtor.Type is UserDefinedType t)
                {
                    if (MutateCSharp.Schemata217.ReplaceBinExprOp_8(142L, t.ResolvedClass, dt))
                    {
                        return MutateCSharp.Schemata217.ReplaceBooleanConstant_7(143L, true);
                    }
                }
            }
            return MutateCSharp.Schemata217.ReplaceBooleanConstant_7(144L, false);
        }

        protected bool IsRecursiveDatatype(DatatypeDecl dt)
        {
            foreach (var ctor in dt.Ctors)
            {
                if (IsRecursiveConstructor(dt, ctor))
                {
                    return MutateCSharp.Schemata217.ReplaceBooleanConstant_7(145L, true);
                }
            }
            return MutateCSharp.Schemata217.ReplaceBooleanConstant_7(146L, false);
        }

        // Uniform naming convention
        protected string DatatypeSubStructName(DatatypeCtor ctor, bool inclTemplateArgs = false)
        {
            string args = "";
            if (inclTemplateArgs)
            {
                args = InstantiateTemplate(ctor.EnclosingDatatype.TypeArgs);
            }
            return String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(147L, "{0}_{1}{2}"), IdProtect(ctor.EnclosingDatatype.GetCompileName(Options)), ctor.GetCompileName(Options), args);
        }

        protected override bool DatatypeDeclarationAndMemberCompilationAreSeparate => MutateCSharp.Schemata217.ReplaceBooleanConstant_7(148L, false);
        public override bool SupportsDatatypeWrapperErasure => MutateCSharp.Schemata217.ReplaceBooleanConstant_7(149L, false);

        protected override IClassWriter DeclareDatatype(DatatypeDecl dt, ConcreteSyntaxTree writer)
        {
            if (dt is TupleTypeDecl)
            {
                // Tuple types are declared once and for all in DafnyRuntime.h
                return null;
            }

            this.datatypeDecls.Add(dt);

            string DtT = dt.GetCompileName(Options);
            string DtT_protected = IdProtect(DtT);

            // Forward declaration of the type
            this.modDeclWr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(150L, "{0}\nstruct {1};"), DeclareTemplate(dt.TypeArgs), DtT_protected);
            var wdecl = this.dtDeclWr;
            var wdef = writer;

            if (IsRecursiveDatatype(dt))
            { // Note that if this is true, there must be more than one constructor!
              // Add some forward declarations
                wdecl.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(151L, "{0}\nstruct {1};"), DeclareTemplate(dt.TypeArgs), DtT_protected);
                wdecl.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(152L, "{2}\nbool operator==(const {0}{1} &left, const {0}{1} &right); "), DtT_protected, InstantiateTemplate(dt.TypeArgs), DeclareTemplate(dt.TypeArgs));
            }

            // Optimize a not-uncommon case
            if (dt.IsRecordType)
            {
                var ctor = dt.Ctors[MutateCSharp.Schemata217.ReplaceNumericConstant_1(153L, 0)];
                var ws = wdecl.NewBlock(String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(157L, "{0}\nstruct {1}"), DeclareTemplate(dt.TypeArgs), DtT_protected), MutateCSharp.Schemata217.ReplaceStringConstant_0(158L, ";"));

                // Declare the struct members
                var i = MutateCSharp.Schemata217.ReplaceNumericConstant_1(159L, 0);
                var argNames = new List<string>();
                foreach (Formal arg in ctor.Formals)
                {
                    if (!arg.IsGhost)
                    {
                        ws.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(163L, "{0} {1};"), TypeName(arg.Type, wdecl, arg.tok), FormalName(arg, i));
                        argNames.Add(FormalName(arg, i));
                        MutateCSharp.Schemata217.ReplacePostfixUnaryExprOp_9(164L, ref i);
                    }
                }

                if (MutateCSharp.Schemata217.ReplaceBinExprOp_4(169L, argNames.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(165L, 0)))
                {
                    // Create a constructor with arguments
                    ws.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(174L, "{0}("), DtT_protected);
                    WriteFormals("", ctor.Formals, ws);
                    ws.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(175L, ")"));
                    if (MutateCSharp.Schemata217.ReplaceBinExprOp_4(180L, argNames.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(176L, 0)))
                    {
                        // Add initializers
                        ws.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(185L, " :"));
                        ws.Write(Util.Comma(argNames, nm => String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(186L, " {0} ({0})"), IdProtect(nm))));
                    }

                    ws.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(187L, " {}"));
                }

                // Create a constructor with no arguments
                ws.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(188L, "{0}();"), DtT_protected);
                var wc = wdef.NewNamedBlock(MutateCSharp.Schemata217.ReplaceStringConstant_0(189L, "{1}\n{0}{2}::{0}()"), DtT_protected, DeclareTemplate(dt.TypeArgs), InstantiateTemplate(dt.TypeArgs));
                foreach (var arg in ctor.Formals)
                {
                    if (!arg.IsGhost)
                    {
                        wc.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(190L, "{0} = {1};"), arg.CompileName, DefaultValue(arg.Type, wc, arg.tok));
                    }
                }

                // Overload the comparison operator
                var wrCompOp = ws.NewNamedBlock(MutateCSharp.Schemata217.ReplaceStringConstant_0(191L, "friend bool operator==(const {0} &left, const {0} &right)"), DtT_protected);
                wrCompOp.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(192L, "\treturn true"));
                foreach (var arg in argNames)
                {
                    wrCompOp.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(193L, "\t\t&& left.{0} == right.{0}"), arg);
                }
                wrCompOp.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(194L, ";"));

                // Overload the not-comparison operator
                ws.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(195L, "friend bool operator!=(const {0} &left, const {0} &right) {{ return !(left == right); }} "), DtT_protected);

                wdecl.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(196L, "{0}\ninline bool is_{1}(const struct {2}{3} d) {{ (void) d; return true; }}"), DeclareTemplate(dt.TypeArgs), ctor.GetCompileName(Options), DtT_protected, InstantiateTemplate(dt.TypeArgs));

                // Define a custom hasher
                hashWr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(197L, "template <{0}>"), TypeParameters(dt.TypeArgs));
                var fullName = dt.EnclosingModuleDefinition.GetCompileName(Options) + MutateCSharp.Schemata217.ReplaceStringConstant_0(198L, "::") + DtT_protected + InstantiateTemplate(dt.TypeArgs);
                var hwr = hashWr.NewBlock(string.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(199L, "struct std::hash<{0}>"), fullName), MutateCSharp.Schemata217.ReplaceStringConstant_0(200L, ";"));
                var owr = hwr.NewBlock(string.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(201L, "std::size_t operator()(const {0}& x) const"), fullName));
                owr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(202L, "size_t seed = 0;"));
                foreach (var arg in ctor.Formals)
                {
                    if (!arg.IsGhost)
                    {
                        owr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(203L, "hash_combine<{0}>(seed, x.{1});"), TypeName(arg.Type, owr, dt.tok), arg.CompileName);
                    }
                }
                owr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(204L, "return seed;"));
            }
            else
            {

                /*** Create one struct for each constructor ***/
                foreach (var ctor in dt.Ctors.Where(ctor => !ctor.IsGhost))
                {
                    string structName = DatatypeSubStructName(ctor);
                    var wstruct = wdecl.NewBlock(String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(205L, "{0}\nstruct {1}"), DeclareTemplate(dt.TypeArgs), structName), MutateCSharp.Schemata217.ReplaceStringConstant_0(206L, ";"));
                    // Declare the struct members
                    var i = MutateCSharp.Schemata217.ReplaceNumericConstant_1(207L, 0);
                    foreach (Formal arg in ctor.Formals)
                    {
                        if (!arg.IsGhost)
                        {
                            if (arg.Type is UserDefinedType udt && MutateCSharp.Schemata217.ReplaceBinExprOp_8(211L, udt.ResolvedClass, dt))
                            {  // Recursive declaration needs to use a pointer
                                wstruct.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(212L, "std::shared_ptr<{0}> {1};"), TypeName(arg.Type, wdecl, arg.tok), FormalName(arg, i));
                            }
                            else
                            {
                                wstruct.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(213L, "{0} {1};"), TypeName(arg.Type, wdecl, arg.tok), FormalName(arg, i));
                            }

                            MutateCSharp.Schemata217.ReplacePostfixUnaryExprOp_9(214L, ref i);
                        }
                    }

                    // Overload the comparison operator
                    wstruct.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(215L, "friend bool operator==(const {0} &left, const {0} &right) {{ "), structName);

                    var preReturn = wstruct.Fork();
                    wstruct.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(216L, "\treturn true "));
                    i = MutateCSharp.Schemata217.ReplaceNumericConstant_1(217L, 0);
                    foreach (Formal arg in ctor.Formals)
                    {
                        if (!arg.IsGhost)
                        {
                            if (arg.Type is UserDefinedType udt && MutateCSharp.Schemata217.ReplaceBinExprOp_8(221L, udt.ResolvedClass, dt))
                            {  // Recursive destructor needs to use a pointer
                                wstruct.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(222L, "\t\t&& *(left.{0}) == *(right.{0})"), FormalName(arg, i));
                            }
                            else
                            {
                                wstruct.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(223L, "\t\t&& left.{0} == right.{0}"), FormalName(arg, i));
                            }

                            MutateCSharp.Schemata217.ReplacePostfixUnaryExprOp_9(224L, ref i);
                        }
                    }

                    if (MutateCSharp.Schemata217.ReplaceBinExprOp_10(229L, i, MutateCSharp.Schemata217.ReplaceNumericConstant_1(225L, 0)))
                    { // Avoid a warning from the C++ compiler
                        preReturn.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(234L, "(void)left; (void) right;"));
                    }

                    wstruct.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(235L, ";\n}"));

                    // Overload the not-comparison operator
                    wstruct.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(236L, "friend bool operator!=(const {0} &left, const {0} &right) {{ return !(left == right); }} "), structName);

                    // Define a custom hasher
                    hashWr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(237L, "template <{0}>"), TypeParameters(dt.TypeArgs));
                    var fullName = dt.EnclosingModuleDefinition.GetCompileName(Options) + MutateCSharp.Schemata217.ReplaceStringConstant_0(238L, "::") + structName + InstantiateTemplate(dt.TypeArgs);
                    var hwr = hashWr.NewBlock(string.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(239L, "struct std::hash<{0}>"), fullName), MutateCSharp.Schemata217.ReplaceStringConstant_0(240L, ";"));
                    var owr = hwr.NewBlock(string.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(241L, "std::size_t operator()(const {0}& x) const"), fullName));
                    owr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(242L, "size_t seed = 0;"));
                    int argCount = MutateCSharp.Schemata217.ReplaceNumericConstant_1(243L, 0);
                    foreach (var arg in ctor.Formals)
                    {
                        if (!arg.IsGhost)
                        {
                            if (arg.Type is UserDefinedType udt && MutateCSharp.Schemata217.ReplaceBinExprOp_8(247L, udt.ResolvedClass, dt))
                            {
                                // Recursive destructor needs to use a pointer
                                owr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(248L, "hash_combine<std::shared_ptr<{0}>>(seed, x.{1});"), TypeName(arg.Type, owr, dt.tok), arg.CompileName);
                            }
                            else
                            {
                                owr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(249L, "hash_combine<{0}>(seed, x.{1});"), TypeName(arg.Type, owr, dt.tok), arg.CompileName);
                            }

                            MutateCSharp.Schemata217.ReplacePostfixUnaryExprOp_9(250L, ref argCount);
                        }
                    }
                    if (MutateCSharp.Schemata217.ReplaceBinExprOp_10(255L, argCount, MutateCSharp.Schemata217.ReplaceNumericConstant_1(251L, 0)))
                    {
                        owr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(260L, "(void)x;"));
                    }
                    owr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(261L, "return seed;"));
                }

                /*** Declare the overall tagged union ***/
                var ws = wdecl.NewBlock(String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(262L, "{0}\nstruct {1}"), DeclareTemplate(dt.TypeArgs), DtT_protected), MutateCSharp.Schemata217.ReplaceStringConstant_0(263L, ";"));
                ws.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(264L, "std::variant<{0}> v;"), Util.Comma(dt.Ctors, ctor => DatatypeSubStructName(ctor, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(265L, true))));

                // Declare static "constructors" for each Dafny constructor
                foreach (var ctor in dt.Ctors)
                {
                    var wc = ws.NewNamedBlock(MutateCSharp.Schemata217.ReplaceStringConstant_0(266L, "static {0} create_{1}({2})"),
                      DtT_protected, ctor.GetCompileName(Options),
                      DeclareFormals(ctor.Formals));
                    wc.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(267L, "{0}{1} COMPILER_result;"), DtT_protected, InstantiateTemplate(dt.TypeArgs));
                    wc.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(268L, "{0} COMPILER_result_subStruct;"), DatatypeSubStructName(ctor, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(269L, true)));

                    foreach (Formal arg in ctor.Formals)
                    {
                        if (!arg.IsGhost)
                        {
                            if (arg.Type is UserDefinedType udt && MutateCSharp.Schemata217.ReplaceBinExprOp_8(270L, udt.ResolvedClass, dt))
                            {
                                // This is a recursive destuctor, so we need to allocate space and copy the input in
                                wc.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(271L, "COMPILER_result_subStruct.{0} = std::make_shared<{1}>({0});"), arg.CompileName,
                                  DtT_protected);
                            }
                            else
                            {
                                wc.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(272L, "COMPILER_result_subStruct.{0} = {0};"), arg.CompileName);
                            }
                        }
                    }

                    wc.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(273L, "COMPILER_result.v = COMPILER_result_subStruct;"));
                    wc.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(274L, "return COMPILER_result;"));
                }

                // Declare a default constructor
                ws.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(275L, "{0}();"), DtT_protected);
                var wd = wdef.NewNamedBlock(String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(276L, "{1}\n{0}{2}::{0}()"), DtT_protected, DeclareTemplate(dt.TypeArgs), InstantiateTemplate(dt.TypeArgs)));
                var default_ctor = dt.Ctors[MutateCSharp.Schemata217.ReplaceNumericConstant_1(277L, 0)]; // Arbitrarily choose the first one
                wd.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(281L, "{0} COMPILER_result_subStruct;"), DatatypeSubStructName(default_ctor, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(282L, true)));
                foreach (Formal arg in default_ctor.Formals)
                {
                    if (!arg.IsGhost)
                    {
                        wd.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(283L, "COMPILER_result_subStruct.{0} = {1};"), arg.CompileName,
                          DefaultValue(arg.Type, wd, arg.tok));
                    }
                }

                wd.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(284L, "v = COMPILER_result_subStruct;"));

                // Declare a default destructor
                ws.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(285L, "~{0}() {{}}"), DtT_protected);

                {
                    // Declare a default copy constructor (just in case any of our components are non-trivial, i.e., contain smart_ptr)
                    var wcc = ws.NewNamedBlock(String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(286L, "{0}(const {0} &other)"), DtT_protected));
                    wcc.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(287L, "v = other.v;"));
                }
                {
                    // Declare a default copy assignment operator (just in case any of our components are non-trivial, i.e., contain smart_ptr)
                    var wcc = ws.NewNamedBlock(String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(288L, "{0}& operator=(const {0} other)"), DtT_protected));
                    wcc.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(289L, "v = other.v;"));
                    wcc.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(290L, "return *this;"));
                }

                // Declare type queries, both as members and general-purpose functions
                foreach (var ctor in dt.Ctors)
                {
                    var name = DatatypeSubStructName(ctor);
                    var holds = String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(291L, "std::holds_alternative<{0}{1}>"), name, InstantiateTemplate(dt.TypeArgs));
                    ws.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(292L, "bool is_{0}() const {{ return {1}(v); }}"), name, holds);
                    wdecl.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(293L, "{0}\ninline bool is_{1}(const struct {2}{3} d);"), DeclareTemplate(dt.TypeArgs), name, DtT_protected, InstantiateTemplate(dt.TypeArgs));
                    wdef.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(294L, "{0}\ninline bool is_{1}(const struct {2}{3} d) {{ return {4}(d.v); }}"),
                      DeclareTemplate(dt.TypeArgs), name, DtT_protected, InstantiateTemplate(dt.TypeArgs), holds);
                }

                // Overload the comparison operator
                ws.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(295L, "friend bool operator==(const {0} &left, const {0} &right) {{ "), DtT_protected);
                ws.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(296L, "\treturn left.v == right.v;\n}"));

                // Create destructors
                foreach (var ctor in dt.Ctors)
                {
                    foreach (var dtor in ctor.Destructors)
                    {
                        if (MutateCSharp.Schemata217.ReplaceBinExprOp_11(301L, dtor.EnclosingCtors[MutateCSharp.Schemata217.ReplaceNumericConstant_1(297L, 0)], ctor))
                        {
                            var arg = dtor.CorrespondingFormals[MutateCSharp.Schemata217.ReplaceNumericConstant_1(302L, 0)];
                            if (MutateCSharp.Schemata217.ReplaceBinExprOp_5(306L, () => !arg.IsGhost, () => arg.HasName))
                            {
                                var returnType = TypeName(arg.Type, ws, arg.tok);
                                if (arg.Type is UserDefinedType udt && MutateCSharp.Schemata217.ReplaceBinExprOp_8(312L, udt.ResolvedClass, dt))
                                {
                                    // This is a recursive destuctor, so return a pointer
                                    returnType = String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(313L, "std::shared_ptr<{0}>"), returnType);
                                }

                                var wDtor = ws.NewNamedBlock(MutateCSharp.Schemata217.ReplaceStringConstant_0(314L, "{0} dtor_{1}()"), returnType,
                                  arg.CompileName);
                                if (dt.IsRecordType)
                                {
                                    wDtor.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(315L, "return this.{0};"), IdName(arg));
                                }
                                else
                                {
                                    var n = dtor.EnclosingCtors.Count;
                                    for (int i = MutateCSharp.Schemata217.ReplaceNumericConstant_1(316L, 0); MutateCSharp.Schemata217.ReplaceBinExprOp_12(333L, i, MutateCSharp.Schemata217.ReplaceBinExprOp_2(324L, n, MutateCSharp.Schemata217.ReplaceNumericConstant_1(320L, 1))); MutateCSharp.Schemata217.ReplacePostfixUnaryExprOp_9(338L, ref i))
                                    {
                                        var ctor_i = dtor.EnclosingCtors[i];
                                        var ctor_name = DatatypeSubStructName(ctor_i);
                                        Contract.Assert(arg.CompileName == dtor.CorrespondingFormals[i].CompileName);
                                        wDtor.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(339L, "if (is_{0}()) {{ return std::get<{0}{1}>(v).{2}; }}"),
                                          ctor_name, InstantiateTemplate(dt.TypeArgs), IdName(arg));
                                    }

                                    Contract.Assert(arg.CompileName == dtor.CorrespondingFormals[n - 1].CompileName);
                                    var final_ctor_name = DatatypeSubStructName(dtor.EnclosingCtors[MutateCSharp.Schemata217.ReplaceBinExprOp_2(344L, n, MutateCSharp.Schemata217.ReplaceNumericConstant_1(340L, 1))], MutateCSharp.Schemata217.ReplaceBooleanConstant_7(353L, true));
                                    wDtor.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(354L, "return std::get<{0}>(v).{1}; "),
                                      final_ctor_name, IdName(arg));
                                }
                            }
                        }
                    }
                }

                // Overload the not-comparison operator
                ws.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(355L, "friend bool operator!=(const {0} &left, const {0} &right) {{ return !(left == right); }} "), DtT_protected);

                // Define a custom hasher for the struct as a whole
                hashWr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(356L, "template <{0}>"), TypeParameters(dt.TypeArgs));
                var fullStructName = dt.EnclosingModuleDefinition.GetCompileName(Options) + MutateCSharp.Schemata217.ReplaceStringConstant_0(357L, "::") + DtT_protected;
                var hwr2 = hashWr.NewBlock(string.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(358L, "struct std::hash<{0}{1}>"), fullStructName, InstantiateTemplate(dt.TypeArgs)), MutateCSharp.Schemata217.ReplaceStringConstant_0(359L, ";"));
                var owr2 = hwr2.NewBlock(string.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(360L, "std::size_t operator()(const {0}{1}& x) const"), fullStructName, InstantiateTemplate(dt.TypeArgs)));
                owr2.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(361L, "size_t seed = 0;"));
                var index = MutateCSharp.Schemata217.ReplaceNumericConstant_1(362L, 0);
                foreach (var ctor in dt.Ctors)
                {
                    var ifwr = owr2.NewBlock(string.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(366L, "if (x.is_{0}())"), DatatypeSubStructName(ctor)));
                    ifwr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(367L, "hash_combine<uint64>(seed, {0});"), index);
                    ifwr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(368L, "hash_combine<struct {0}::{1}>(seed, std::get<{0}::{1}>(x.v));"), dt.EnclosingModuleDefinition.GetCompileName(Options), DatatypeSubStructName(ctor, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(369L, true)));
                    MutateCSharp.Schemata217.ReplacePostfixUnaryExprOp_9(370L, ref index);
                }
                owr2.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(371L, "return seed;"));

                if (IsRecursiveDatatype(dt))
                {
                    // Emit a custom hasher for a pointer to this type
                    hashWr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(372L, "template <{0}>"), TypeParameters(dt.TypeArgs));
                    hwr2 = hashWr.NewBlock(string.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(373L, "struct std::hash<std::shared_ptr<{0}{1}>>"), fullStructName, InstantiateTemplate(dt.TypeArgs)), MutateCSharp.Schemata217.ReplaceStringConstant_0(374L, ";"));
                    owr2 = hwr2.NewBlock(string.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(375L, "std::size_t operator()(const std::shared_ptr<{0}{1}>& x) const"), fullStructName, InstantiateTemplate(dt.TypeArgs)));
                    owr2.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(376L, "struct std::hash<{0}{1}> hasher;"), fullStructName, InstantiateTemplate(dt.TypeArgs));
                    owr2.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(377L, "std::size_t h = hasher(*x);"));
                    owr2.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(378L, "return h;"));
                }
            }

            return null;
        }

        protected override IClassWriter DeclareNewtype(NewtypeDecl nt, ConcreteSyntaxTree wr)
        {
            if (MutateCSharp.Schemata217.ReplaceBinExprOp_13(379L, nt.NativeType, null))
            {
                if (MutateCSharp.Schemata217.ReplaceBinExprOp_14(380L, nt.NativeType.Name, nt.Name))
                {
                    GetNativeInfo(nt.NativeType.Sel, out var nt_name_def, out var literalSuffice_def, out var needsCastAfterArithmetic_def);
                    wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(381L, "typedef {0} {1};"), nt_name_def, nt.Name);
                }
            }
            else
            {
                throw new UnsupportedFeatureException(nt.tok, Feature.NonNativeNewtypes);
            }
            var className = MutateCSharp.Schemata217.ReplaceStringConstant_0(382L, "class_") + IdName(nt);
            var cw = CreateClass(nt.EnclosingModuleDefinition.GetCompileName(Options), className, nt, wr) as ClassWriter;
            var w = cw.MethodDeclWriter;
            if (MutateCSharp.Schemata217.ReplaceBinExprOp_15(383L, nt.WitnessKind, SubsetTypeDecl.WKind.Compiled))
            {
                var witness = new ConcreteSyntaxTree(w.RelativeIndentLevel);
                var wStmts = w.Fork();
                if (MutateCSharp.Schemata217.ReplaceBinExprOp_16(384L, nt.NativeType, null))
                {
                    witness.Append(Expr(nt.Witness, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(385L, false), wStmts));
                }
                else
                {
                    TrParenExpr(nt.Witness, witness, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(386L, false), wStmts);
                    witness.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(387L, ".toNumber()"));
                }
                DeclareField(className, nt.TypeArgs, MutateCSharp.Schemata217.ReplaceStringConstant_0(388L, "Witness"), MutateCSharp.Schemata217.ReplaceBooleanConstant_7(389L, true), MutateCSharp.Schemata217.ReplaceBooleanConstant_7(390L, true), nt.BaseType, nt.tok, witness.ToString(), w, wr);
            }

            GetNativeInfo(nt.NativeType.Sel, out var nt_name, out var literalSuffice, out var needsCastAfterArithmetic);
            var wDefault = w.NewBlock(string.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(391L, "static {0} get_Default()"), nt_name));
            var udt = new UserDefinedType(nt.tok, nt.Name, nt, new List<Type>());
            var d = TypeInitializationValue(udt, wr, nt.tok, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(392L, false), MutateCSharp.Schemata217.ReplaceBooleanConstant_7(393L, false));
            wDefault.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(394L, "return {0};"), d);

            return cw;
        }

        protected override void DeclareSubsetType(SubsetTypeDecl sst, ConcreteSyntaxTree wr)
        {
            if (MutateCSharp.Schemata217.ReplaceBinExprOp_17(396L, sst.Name, MutateCSharp.Schemata217.ReplaceStringConstant_0(395L, "nat")))
            {
                return;  // C++ does not support Nats
            }

            string templateDecl = "";
            if (sst.Var.Type is SeqType s)
            {
                templateDecl = DeclareTemplate(s.TypeArgs[MutateCSharp.Schemata217.ReplaceNumericConstant_1(397L, 0)].TypeArgs);  // We want the type args (if any) for the seq-elt type, not the seq
            }
            else
            {
                templateDecl = DeclareTemplate(sst.Var.Type.TypeArgs);
            }

            this.modDeclWr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(401L, "{0} using {1} = {2};"), templateDecl, IdName(sst), TypeName(sst.Var.Type, wr, sst.tok));

            var className = MutateCSharp.Schemata217.ReplaceStringConstant_0(402L, "class_") + IdName(sst);
            var cw = CreateClass(sst.EnclosingModuleDefinition.GetCompileName(Options), className, sst, wr) as ClassWriter;
            var w = cw.MethodDeclWriter;

            if (MutateCSharp.Schemata217.ReplaceBinExprOp_15(403L, sst.WitnessKind, SubsetTypeDecl.WKind.Compiled))
            {
                var witness = new ConcreteSyntaxTree(w.RelativeIndentLevel);
                witness.Append(Expr(sst.Witness, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(404L, false), w));
                DeclareField(className, sst.TypeArgs, MutateCSharp.Schemata217.ReplaceStringConstant_0(405L, "Witness"), MutateCSharp.Schemata217.ReplaceBooleanConstant_7(406L, true), MutateCSharp.Schemata217.ReplaceBooleanConstant_7(407L, true), sst.Rhs, sst.tok, witness.ToString(), w, wr);
            }

            var wDefault = w.NewBlock(String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(408L, "static {0}{1} get_Default()"), IdName(sst), InstantiateTemplate(sst.TypeArgs)));
            var udt = new UserDefinedType(sst.tok, sst.Name, sst,
              sst.TypeArgs.ConvertAll(tp => (Type)new UserDefinedType(tp)));
            var d = TypeInitializationValue(udt, wr, sst.tok, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(409L, false), MutateCSharp.Schemata217.ReplaceBooleanConstant_7(410L, false));
            wDefault.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(411L, "return {0};"), d);
        }

        protected override void GetNativeInfo(NativeType.Selection sel, out string name, out string literalSuffix, out bool needsCastAfterArithmetic)
        {
            literalSuffix = "";
            needsCastAfterArithmetic = MutateCSharp.Schemata217.ReplaceBooleanConstant_7(412L, false);
            switch (sel)
            {
                case NativeType.Selection.Byte:
                    name = "uint8";
                    break;
                    break;
                case NativeType.Selection.SByte:
                    name = "int8";
                    break;
                    break;
                case NativeType.Selection.UShort:
                    name = "uint16";
                    break;
                    break;
                case NativeType.Selection.Short:
                    name = "int16";
                    break;
                    break;
                case NativeType.Selection.UInt:
                    name = "uint32";
                    break;
                    break;
                case NativeType.Selection.Int:
                    name = "int32";
                    break;
                    break;
                case NativeType.Selection.ULong:
                    name = "uint64";
                    break;
                    break;
                case NativeType.Selection.Number:
                case NativeType.Selection.Long:
                    name = "int64";
                    break;
                    break;
                default:
                    Contract.Assert(false);  // unexpected native type
                    throw new cce.UnreachableException();  // to please the compiler
                    break;
            }
        }

        public class ClassWriter : IClassWriter
        {
            public string ClassName;
            public readonly CppCodeGenerator CodeGenerator;
            public readonly ConcreteSyntaxTree MethodDeclWriter;
            public readonly ConcreteSyntaxTree MethodWriter;
            public readonly ConcreteSyntaxTree FieldWriter;
            public readonly ConcreteSyntaxTree Finisher;

            public ClassWriter(string className, CppCodeGenerator codeGenerator, ConcreteSyntaxTree methodDeclWriter, ConcreteSyntaxTree methodWriter, ConcreteSyntaxTree fieldWriter, ConcreteSyntaxTree finisher)
            {
                Contract.Requires(codeGenerator != null);
                Contract.Requires(methodDeclWriter != null);
                Contract.Requires(methodWriter != null);
                Contract.Requires(fieldWriter != null);
                this.ClassName = className;
                this.CodeGenerator = codeGenerator;
                this.MethodDeclWriter = methodDeclWriter;
                this.MethodWriter = methodWriter;
                this.FieldWriter = fieldWriter;
                this.Finisher = finisher;
            }

            public ConcreteSyntaxTree/*?*/ CreateMethod(Method m, List<TypeArgumentInstantiation> typeArgs, bool createBody, bool forBodyInheritance, bool lookasideBody)
            {
                return CodeGenerator.CreateMethod(m, typeArgs, createBody, MethodDeclWriter, MethodWriter, lookasideBody);
            }

            public ConcreteSyntaxTree SynthesizeMethod(Method m, List<TypeArgumentInstantiation> typeArgs, bool createBody, bool forBodyInheritance, bool lookasideBody)
            {
                throw new UnsupportedFeatureException(m.tok, Feature.MethodSynthesis);
                return default;
            }

            public ConcreteSyntaxTree/*?*/ CreateFunction(string name, List<TypeArgumentInstantiation>/*?*/ typeArgs,
              List<Formal> formals, Type resultType, IToken tok, bool isStatic, bool createBody, MemberDecl member, bool forBodyInheritance, bool lookasideBody)
            {
                return CodeGenerator.CreateFunction(member.EnclosingClass.GetCompileName(CodeGenerator.Options),
                  member.EnclosingClass.TypeArgs, name, typeArgs, formals, resultType, tok, isStatic, createBody, member,
                  MethodDeclWriter, MethodWriter, lookasideBody);
            }
            public ConcreteSyntaxTree/*?*/ CreateGetter(string name, TopLevelDecl enclosingDecl, Type resultType, IToken tok, bool isStatic, bool isConst, bool createBody, MemberDecl/*?*/ member, bool forBodyInheritance)
            {
                return CodeGenerator.CreateGetter(name, enclosingDecl, resultType, tok, isStatic, isConst, createBody, MethodDeclWriter, MethodWriter);
            }
            public ConcreteSyntaxTree/*?*/ CreateGetterSetter(string name, Type resultType, IToken tok, bool createBody, MemberDecl/*?*/ member, out ConcreteSyntaxTree setterWriter, bool forBodyInheritance)
            {
                return CodeGenerator.CreateGetterSetter(name, resultType, tok, createBody, out setterWriter, MethodWriter);
            }
            public void DeclareField(string name, TopLevelDecl enclosingDecl, bool isStatic, bool isConst, Type type, IToken tok, string rhs, Field field)
            {
                CodeGenerator.DeclareField(ClassName, enclosingDecl.TypeArgs, name, isStatic, isConst, type, tok, rhs, FieldWriter, Finisher);
            }
            public void InitializeField(Field field, Type instantiatedFieldType, TopLevelDeclWithMembers enclosingClass)
            {
                throw new cce.UnreachableException();  // InitializeField should be called only for those compilers that set ClassesRedeclareInheritedFields to false.
            }
            public ConcreteSyntaxTree/*?*/ ErrorWriter() => MethodWriter;
            public void Finish() { }
        }

        protected ConcreteSyntaxTree/*?*/ CreateMethod(Method m, List<TypeArgumentInstantiation> typeArgs, bool createBody, ConcreteSyntaxTree wdr, ConcreteSyntaxTree wr, bool lookasideBody)
        {
            List<Formal> nonGhostOuts = m.Outs.Where(o => !o.IsGhost).ToList();
            string targetReturnTypeReplacement = null;
            if (MutateCSharp.Schemata217.ReplaceBinExprOp_10(417L, nonGhostOuts.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(413L, 1)))
            {
                targetReturnTypeReplacement = TypeName(nonGhostOuts[MutateCSharp.Schemata217.ReplaceNumericConstant_1(422L, 0)].Type, wr, nonGhostOuts[MutateCSharp.Schemata217.ReplaceNumericConstant_1(426L, 0)].tok);
            }
            else if (MutateCSharp.Schemata217.ReplaceBinExprOp_4(434L, nonGhostOuts.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(430L, 1)))
            {
                targetReturnTypeReplacement = String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(439L, "struct Tuple{0}"), InstantiateTemplate(nonGhostOuts.ConvertAll(n => n.Type)));
            }

            if (!createBody)
            {
                return null;
            }

            if (MutateCSharp.Schemata217.ReplaceBinExprOp_18(444L, typeArgs.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(440L, 0)))
            {
                var formalTypeParameters = TypeArgumentInstantiation.ToFormals(ForTypeParameters(typeArgs, m, lookasideBody));
                // Filter out type parameters we've already emitted at the class level, to avoid shadowing
                // the class' template parameter (which C++ treats as an error)
                formalTypeParameters = formalTypeParameters.Where(param => MutateCSharp.Schemata217.ReplaceBinExprOp_20(450L, () => MutateCSharp.Schemata217.ReplaceBinExprOp_19(449L, m.EnclosingClass.TypeArgs, null), () => !m.EnclosingClass.TypeArgs.Contains(param))).ToList();
                wdr.WriteLine(DeclareTemplate(formalTypeParameters));
                wr.WriteLine(DeclareTemplate(formalTypeParameters));
            }

            if (MutateCSharp.Schemata217.ReplaceBinExprOp_5(466L, () => MutateCSharp.Schemata217.ReplaceBinExprOp_3(456L, m.EnclosingClass.TypeArgs, null), () => MutateCSharp.Schemata217.ReplaceBinExprOp_4(461L, m.EnclosingClass.TypeArgs.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(457L, 0))))
            {
                wr.WriteLine(DeclareTemplate(m.EnclosingClass.TypeArgs));
            }

            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(472L, "{0} {1}{2}::{3}"),
              targetReturnTypeReplacement ?? MutateCSharp.Schemata217.ReplaceStringConstant_0(473L, "void"),
              m.EnclosingClass.GetCompileName(Options),
              InstantiateTemplate(m.EnclosingClass.TypeArgs),
              IdName(m));

            wdr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(474L, "{0}{1} {2}"),
              m.IsStatic ? MutateCSharp.Schemata217.ReplaceStringConstant_0(475L, "static ") : "",
              targetReturnTypeReplacement ?? MutateCSharp.Schemata217.ReplaceStringConstant_0(476L, "void"),
              IdName(m));

            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(477L, "("));
            wdr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(478L, "("));
            int nIns = WriteFormals("", m.Ins, wr);
            WriteFormals("", m.Ins, wdr);
            if (targetReturnTypeReplacement == null)
            {
                WriteFormals(MutateCSharp.Schemata217.ReplaceBinExprOp_10(483L, nIns, MutateCSharp.Schemata217.ReplaceNumericConstant_1(479L, 0)) ? "" : MutateCSharp.Schemata217.ReplaceStringConstant_0(488L, ", "), m.Outs, wr);
                WriteFormals(MutateCSharp.Schemata217.ReplaceBinExprOp_10(493L, nIns, MutateCSharp.Schemata217.ReplaceNumericConstant_1(489L, 0)) ? "" : MutateCSharp.Schemata217.ReplaceStringConstant_0(498L, ", "), m.Outs, wdr);
            }
            wdr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(499L, ");\n"));

            var block = wr.NewBlock(MutateCSharp.Schemata217.ReplaceStringConstant_0(500L, ")"), null, BlockStyle.NewlineBrace, BlockStyle.NewlineBrace);

            if (targetReturnTypeReplacement != null)
            {
                var beforeReturnBlock = block.Fork(MutateCSharp.Schemata217.ReplaceNumericConstant_1(501L, 0));
                EmitReturn(m.Outs, block);
                return beforeReturnBlock;
            }
            return block;
        }

        protected ConcreteSyntaxTree/*?*/ CreateFunction(string className, List<TypeParameter> classArgs, string name, List<TypeArgumentInstantiation>/*?*/ typeArgs, List<Formal> formals, Type resultType, IToken tok, bool isStatic, bool createBody, MemberDecl member, ConcreteSyntaxTree wdr, ConcreteSyntaxTree wr, bool lookasideBody)
        {
            if (!createBody)
            {
                return null;
            }

            if (MutateCSharp.Schemata217.ReplaceBinExprOp_18(509L, typeArgs.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(505L, 0)))
            {
                var formalTypeParameters = TypeArgumentInstantiation.ToFormals(ForTypeParameters(typeArgs, member, lookasideBody));
                // Filter out type parameters we've already emitted at the class level, to avoid shadowing
                // the class' template parameter (which C++ treats as an error)
                formalTypeParameters = formalTypeParameters.Where(param =>
                  !classArgs.Contains(param)).ToList();
                wdr.WriteLine(DeclareTemplate(formalTypeParameters));
                wr.WriteLine(DeclareTemplate(formalTypeParameters));
            }
            if (MutateCSharp.Schemata217.ReplaceBinExprOp_5(524L, () => MutateCSharp.Schemata217.ReplaceBinExprOp_3(514L, classArgs, null), () => MutateCSharp.Schemata217.ReplaceBinExprOp_18(519L, classArgs.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(515L, 0))))
            {
                wr.WriteLine(DeclareTemplate(classArgs));
            }

            wdr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(530L, "{0}{1} {2}"),
              isStatic ? MutateCSharp.Schemata217.ReplaceStringConstant_0(531L, "static ") : "",
              TypeName(resultType, wr, tok),
              name);
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(532L, "{0} {1}{2}::{3}"),
              TypeName(resultType, wr, tok),
              className,
              InstantiateTemplate(classArgs),
              name);

            wdr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(533L, "("));
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(534L, "("));
            WriteFormals("", formals, wdr);
            int nIns = WriteFormals("", formals, wr);

            wdr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(535L, ");"));
            var w = wr.NewBlock(MutateCSharp.Schemata217.ReplaceStringConstant_0(536L, ")"), null, BlockStyle.NewlineBrace, BlockStyle.NewlineBrace);

            return w;
        }

        protected override void TypeArgDescriptorUse(bool isStatic, bool lookasideBody, TopLevelDeclWithMembers cl, out bool needsTypeParameter, out bool needsTypeDescriptor)
        {
            needsTypeParameter = MutateCSharp.Schemata217.ReplaceBooleanConstant_7(537L, false);
            needsTypeDescriptor = MutateCSharp.Schemata217.ReplaceBooleanConstant_7(538L, false);
        }

        protected override string TypeDescriptor(Type type, ConcreteSyntaxTree wr, IToken tok)
        {
            Contract.Requires(type != null);
            Contract.Requires(tok != null);
            Contract.Requires(wr != null);
            throw new UnsupportedFeatureException(tok, Feature.RuntimeTypeDescriptors, string.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(539L, "RuntimeTypeDescriptor {0} not yet supported"), type));
            return default;
        }

        protected ConcreteSyntaxTree/*?*/ CreateGetter(string name, TopLevelDecl cls, Type resultType, IToken tok, bool isStatic, bool isConst, bool createBody, ConcreteSyntaxTree wdr, ConcreteSyntaxTree wr)
        {
            // Compiler insists on using Getter for constants, but we just use the raw variable name to hold the value,
            // because o/w Compiler tries to use the Getter function as an Lvalue in assignments
            // Unfortunately, Compiler doesn't tell us what the initial value is, so we hack around it
            // by declaring the variable and a function to statically initialize it

            ConcreteSyntaxTree w = null;
            string postfix = null;
            if (createBody)
            {
                w = wdr.NewNamedBlock(MutateCSharp.Schemata217.ReplaceStringConstant_0(540L, "{0}{1} init__{2}()"), isStatic ? MutateCSharp.Schemata217.ReplaceStringConstant_0(541L, "static ") : "", TypeName(resultType, wr, tok), name);
                postfix = String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(542L, " init__{0}()"), name);
            }
            DeclareField(cls.GetCompileName(Options), cls.TypeArgs, name, isStatic, isConst, resultType, tok, postfix, wdr, wr);
            //wdr.Write("{0}{1} {2}{3};", isStatic ? "static " : "", TypeName(resultType, wr, tok), name, postfix);
            return w;
        }

        protected ConcreteSyntaxTree/*?*/ CreateGetterSetter(string name, Type resultType, IToken tok, bool createBody, out ConcreteSyntaxTree setterWriter, ConcreteSyntaxTree wr)
        {
            // We don't use getter/setter pairs; we just embed the trait's fields.
            if (createBody)
            {
                var abyss = new ConcreteSyntaxTree();
                setterWriter = abyss;
                return abyss.NewBlock("");
            }
            else
            {
                setterWriter = null;
                return null;
            }

            return default;
        }

        protected override ConcreteSyntaxTree EmitTailCallStructure(MemberDecl member, ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(543L, "TAIL_CALL_START:"));
            return wr;
        }

        protected override void EmitJumpToTailCallStart(ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(544L, "goto TAIL_CALL_START;"));
        }

        protected void Warn(string msg, IToken tok)
        {
            Options.ErrorWriter.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(545L, "WARNING: {3} ({0}:{1}:{2})"), tok.Filepath, tok.line, tok.col, msg);
        }

        // Because we use reference counting (via shared_ptr), the TypeName of a class differs
        // depending on whether we are declaring a variable or talking about the class itself.
        // Use class_name = true if you want the actual name of the class, not the type used when declaring variables/arguments/etc.
        protected string TypeName(Type type, ConcreteSyntaxTree wr, IToken tok, MemberDecl/*?*/ member = null, bool class_name = false)
        {
            Contract.Ensures(Contract.Result<string>() != null);
            Contract.Assume(type != null);  // precondition; this ought to be declared as a Requires in the superclass

            var xType = type.NormalizeExpand();
            if (xType is TypeProxy)
            {
                // unresolved proxy; just treat as ref, since no particular type information is apparently needed for this type
                return MutateCSharp.Schemata217.ReplaceStringConstant_0(546L, "object");
            }

            if (xType is BoolType)
            {
                return MutateCSharp.Schemata217.ReplaceStringConstant_0(547L, "bool");
            }
            else if (xType is CharType)
            {
                return MutateCSharp.Schemata217.ReplaceStringConstant_0(548L, "char");
            }
            else if (MutateCSharp.Schemata217.ReplaceBinExprOp_20(549L, () => xType is IntType, () => xType is BigOrdinalType))
            {
                UnsupportedFeatureError(tok, Feature.UnboundedIntegers);
                return MutateCSharp.Schemata217.ReplaceStringConstant_0(555L, "BigNumber");
            }
            else if (xType is RealType)
            {
                UnsupportedFeatureError(tok, Feature.RealNumbers);
                return MutateCSharp.Schemata217.ReplaceStringConstant_0(556L, "Dafny.BigRational");
            }
            else if (xType is BitvectorType)
            {
                var t = (BitvectorType)xType;
                return MutateCSharp.Schemata217.ReplaceBinExprOp_13(557L, t.NativeType, null) ? GetNativeTypeName(t.NativeType) : MutateCSharp.Schemata217.ReplaceStringConstant_0(558L, "BigNumber");
            }
            else if (MutateCSharp.Schemata217.ReplaceBinExprOp_21(559L, xType.AsNewtype, null))
            {
                NativeType nativeType = xType.AsNewtype.NativeType;
                if (MutateCSharp.Schemata217.ReplaceBinExprOp_13(560L, nativeType, null))
                {
                    return GetNativeTypeName(nativeType);
                }
                return TypeName(xType.AsNewtype.BaseType, wr, tok);
            }
            else if (xType.IsObjectQ)
            {
                return MutateCSharp.Schemata217.ReplaceStringConstant_0(561L, "object");
            }
            else if (xType.IsArrayType)
            {
                ArrayClassDecl at = xType.AsArrayType;
                Contract.Assert(at != null);  // follows from type.IsArrayType
                Type elType = UserDefinedType.ArrayElementType(xType);
                if (MutateCSharp.Schemata217.ReplaceBinExprOp_10(566L, at.Dims, MutateCSharp.Schemata217.ReplaceNumericConstant_1(562L, 1)))
                {
                    return MutateCSharp.Schemata217.ReplaceStringConstant_0(571L, "DafnyArray<") + TypeName(elType, wr, tok, null, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(572L, false)) + MutateCSharp.Schemata217.ReplaceStringConstant_0(573L, ">");
                }
                else
                {
                    throw new UnsupportedFeatureException(tok, Feature.MultiDimensionalArrays);
                }
            }
            else if (xType is UserDefinedType)
            {
                var udt = (UserDefinedType)xType;
                var s = FullTypeName(udt, member);
                var cl = udt.ResolvedClass;
                if (MutateCSharp.Schemata217.ReplaceBinExprOp_20(586L, () => MutateCSharp.Schemata217.ReplaceBinExprOp_20(580L, () => MutateCSharp.Schemata217.ReplaceBinExprOp_20(574L, () => class_name, () => xType.IsTypeParameter), () => xType.IsAbstractType), () => xType.IsDatatype))
                {  // Don't add pointer decorations to class names or type parameters
                    return IdProtect(s) + ActualTypeArgs(xType.TypeArgs);
                }
                else
                {
                    return TypeName_UDT(s, udt, wr, udt.tok);
                }
            }
            else if (xType is SetType)
            {
                Type argType = ((SetType)xType).Arg;
                if (ComplicatedTypeParameterForCompilation(TypeParameter.TPVariance.Co, argType))
                {
                    UnsupportedFeatureError(tok, Feature.CollectionsOfTraits, MutateCSharp.Schemata217.ReplaceStringConstant_0(592L, "compilation of set<TRAIT> is not supported; consider introducing a ghost"), wr);
                }
                return DafnySetClass + MutateCSharp.Schemata217.ReplaceStringConstant_0(593L, "<") + TypeName(argType, wr, tok) + MutateCSharp.Schemata217.ReplaceStringConstant_0(594L, ">");
            }
            else if (xType is SeqType)
            {
                Type argType = ((SeqType)xType).Arg;
                if (ComplicatedTypeParameterForCompilation(TypeParameter.TPVariance.Co, argType))
                {
                    UnsupportedFeatureError(tok, Feature.CollectionsOfTraits, MutateCSharp.Schemata217.ReplaceStringConstant_0(595L, "compilation of seq<TRAIT> is not supported; consider introducing a ghost"), wr);
                }
                return DafnySeqClass + MutateCSharp.Schemata217.ReplaceStringConstant_0(596L, "<") + TypeName(argType, wr, tok) + MutateCSharp.Schemata217.ReplaceStringConstant_0(597L, ">");
            }
            else if (xType is MultiSetType)
            {
                Type argType = ((MultiSetType)xType).Arg;
                if (ComplicatedTypeParameterForCompilation(TypeParameter.TPVariance.Co, argType))
                {
                    UnsupportedFeatureError(tok, Feature.CollectionsOfTraits, MutateCSharp.Schemata217.ReplaceStringConstant_0(598L, "compilation of multiset<TRAIT> is not supported; consider introducing a ghost"), wr);
                }
                return DafnyMultiSetClass + MutateCSharp.Schemata217.ReplaceStringConstant_0(599L, "<") + TypeName(argType, wr, tok) + MutateCSharp.Schemata217.ReplaceStringConstant_0(600L, ">");
            }
            else if (xType is MapType)
            {
                Type domType = ((MapType)xType).Domain;
                Type ranType = ((MapType)xType).Range;
                if (MutateCSharp.Schemata217.ReplaceBinExprOp_20(601L, () => ComplicatedTypeParameterForCompilation(TypeParameter.TPVariance.Co, domType), () => ComplicatedTypeParameterForCompilation(TypeParameter.TPVariance.Co, ranType)))
                {
                    UnsupportedFeatureError(tok, Feature.CollectionsOfTraits, MutateCSharp.Schemata217.ReplaceStringConstant_0(607L, "compilation of map<TRAIT, _> or map<_, TRAIT> is not supported; consider introducing a ghost"), wr);
                }
                return DafnyMapClass + MutateCSharp.Schemata217.ReplaceStringConstant_0(608L, "<") + TypeName(domType, wr, tok) + MutateCSharp.Schemata217.ReplaceStringConstant_0(609L, ",") + TypeName(ranType, wr, tok) + MutateCSharp.Schemata217.ReplaceStringConstant_0(610L, ">");
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected type
            }

            return default;
        }

        internal override string TypeName(Type type, ConcreteSyntaxTree wr, IToken tok, MemberDecl/*?*/ member = null)
        {
            Contract.Ensures(Contract.Result<string>() != null);
            Contract.Assume(type != null);  // precondition; this ought to be declared as a Requires in the superclass
            return TypeName(type, wr, tok, member, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(611L, false));
        }

        protected override string TypeInitializationValue(Type type, ConcreteSyntaxTree wr, IToken tok, bool usePlaceboValue, bool constructTypeParameterDefaultsFromTypeDescriptors)
        {
            var xType = type.NormalizeExpandKeepConstraints();
            if (xType is BoolType)
            {
                return MutateCSharp.Schemata217.ReplaceStringConstant_0(612L, "false");
            }
            else if (xType is CharType)
            {
                return CharType.DefaultValueAsString;
            }
            else if (xType is IntType or BigOrdinalType)
            {
                UnsupportedFeatureError(tok, Feature.UnboundedIntegers);
                return MutateCSharp.Schemata217.ReplaceStringConstant_0(613L, "new BigNumber(0)");
            }
            else if (xType is RealType)
            {
                UnsupportedFeatureError(tok, Feature.RealNumbers);
                return MutateCSharp.Schemata217.ReplaceStringConstant_0(614L, "_dafny.BigRational.ZERO");
            }
            else if (xType is BitvectorType)
            {
                var t = (BitvectorType)xType;
                if (MutateCSharp.Schemata217.ReplaceBinExprOp_13(615L, t.NativeType, null))
                {
                    return MutateCSharp.Schemata217.ReplaceStringConstant_0(616L, "0");
                }
                else
                {
                    Warn(MutateCSharp.Schemata217.ReplaceStringConstant_0(617L, "Non-native bitvector type used.  Code will not compile."), tok);
                    return MutateCSharp.Schemata217.ReplaceStringConstant_0(618L, "new BigNumber(0)");
                }
            }
            else if (xType is SetType)
            {
                var s = (SetType)xType;
                return String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(619L, "DafnySet<{0}>::empty()"), TypeName(s.Arg, wr, tok));
            }
            else if (xType is MultiSetType)
            {
                throw new UnsupportedFeatureException(tok, Feature.Multisets);
            }
            else if (xType is SeqType)
            {
                return string.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(620L, "DafnySequence<{0}>()"), TypeName(xType.AsSeqType.Arg, wr, tok, null, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(621L, false)));
            }
            else if (xType is MapType)
            {
                var m = (MapType)xType;
                return String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(622L, "DafnyMap<{0},{1}>::empty()"), TypeName(m.Domain, wr, tok), TypeName(m.Range, wr, tok));
            }

            var udt = (UserDefinedType)xType;
            var cl = udt.ResolvedClass;
            Contract.Assert(cl != null);
            if (cl is TypeParameter or AbstractTypeDecl)
            {
                var hasCompiledValue = (cl is TypeParameter ? ((TypeParameter)cl).Characteristics : ((AbstractTypeDecl)cl).Characteristics).HasCompiledValue;
                if (Attributes.Contains(udt.ResolvedClass.Attributes, MutateCSharp.Schemata217.ReplaceStringConstant_0(623L, "extern")))
                {
                    // Assume the external definition includes a default value
                    return String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(624L, "{1}::get_{0}_default()"), IdProtect(udt.Name), udt.ResolvedClass.EnclosingModuleDefinition.GetCompileName(Options));
                }
                else if (MutateCSharp.Schemata217.ReplaceBinExprOp_5(625L, () => usePlaceboValue, () => !hasCompiledValue))
                {
                    return String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(631L, "get_default<{0}>::call()"), IdProtect(udt.GetCompileName(Options)));
                }
                else
                {
                    return String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(632L, "get_default<{0}>::call()"), IdProtect(udt.GetCompileName(Options)));
                }
            }
            else if (cl is NewtypeDecl)
            {
                var td = (NewtypeDecl)cl;
                if (MutateCSharp.Schemata217.ReplaceBinExprOp_22(633L, td.Witness, null))
                {
                    return td.EnclosingModuleDefinition.GetCompileName(Options) + MutateCSharp.Schemata217.ReplaceStringConstant_0(634L, "::class_") + td.GetCompileName(Options) + MutateCSharp.Schemata217.ReplaceStringConstant_0(635L, "::Witness");
                }
                else if (MutateCSharp.Schemata217.ReplaceBinExprOp_13(636L, td.NativeType, null))
                {
                    return MutateCSharp.Schemata217.ReplaceStringConstant_0(637L, "0");
                }
                else
                {
                    return TypeInitializationValue(td.BaseType, wr, tok, usePlaceboValue, constructTypeParameterDefaultsFromTypeDescriptors);
                }
            }
            else if (cl is SubsetTypeDecl)
            {
                var td = (SubsetTypeDecl)cl;
                if (MutateCSharp.Schemata217.ReplaceBinExprOp_15(638L, td.WitnessKind, SubsetTypeDecl.WKind.Compiled))
                {
                    return td.EnclosingModuleDefinition.GetCompileName(Options) + MutateCSharp.Schemata217.ReplaceStringConstant_0(639L, "::class_") + td.GetCompileName(Options) + MutateCSharp.Schemata217.ReplaceStringConstant_0(640L, "::Witness");
                }
                else if (MutateCSharp.Schemata217.ReplaceBinExprOp_15(641L, td.WitnessKind, SubsetTypeDecl.WKind.Special))
                {
                    // WKind.Special is only used with -->, ->, and non-null types:
                    Contract.Assert(ArrowType.IsPartialArrowTypeName(td.Name) || ArrowType.IsTotalArrowTypeName(td.Name) || td is NonNullTypeDecl);
                    if (ArrowType.IsPartialArrowTypeName(td.Name))
                    {
                        return MutateCSharp.Schemata217.ReplaceStringConstant_0(642L, "nullptr");
                    }
                    else if (ArrowType.IsTotalArrowTypeName(td.Name))
                    {
                        var rangeDefaultValue = TypeInitializationValue(udt.TypeArgs.Last(), wr, tok, usePlaceboValue, constructTypeParameterDefaultsFromTypeDescriptors);
                        // return the lambda expression ((Ty0 x0, Ty1 x1, Ty2 x2) => rangeDefaultValue)
                        return string.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(643L, "function () {{ return {0}; }}"), rangeDefaultValue);
                    }
                    else if (((NonNullTypeDecl)td).Class is ArrayClassDecl)
                    {
                        // non-null array type; we know how to initialize them
                        var arrayClass = (ArrayClassDecl)((NonNullTypeDecl)td).Class;
                        Type elType = UserDefinedType.ArrayElementType(xType);
                        if (MutateCSharp.Schemata217.ReplaceBinExprOp_10(648L, arrayClass.Dims, MutateCSharp.Schemata217.ReplaceNumericConstant_1(644L, 1)))
                        {
                            return string.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(653L, "DafnyArray<{0}>::Null()"), TypeName(elType, wr, tok));
                        }
                        else
                        {
                            return string.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(654L, "_dafny.newArray(nullptr, {0})"), Util.Comma(arrayClass.Dims, _ => MutateCSharp.Schemata217.ReplaceStringConstant_0(655L, "0")));
                        }
                    }
                    else
                    {
                        // non-null (non-array) type
                        // even though the type doesn't necessarily have a known initializer, it could be that the the compiler needs to
                        // lay down some bits to please the C++ compiler's different definite-assignment rules.
                        return MutateCSharp.Schemata217.ReplaceStringConstant_0(656L, "nullptr");
                    }
                }
                else
                {
                    return TypeInitializationValue(td.RhsWithArgument(udt.TypeArgs), wr, tok, usePlaceboValue, constructTypeParameterDefaultsFromTypeDescriptors);
                }
            }
            else if (cl is ClassLikeDecl or ArrowTypeDecl)
            {
                if (cl is ArrayClassDecl)
                {
                    var arrayClass = (ArrayClassDecl)cl;
                    Type elType = UserDefinedType.ArrayElementType(xType);
                    if (MutateCSharp.Schemata217.ReplaceBinExprOp_10(661L, arrayClass.Dims, MutateCSharp.Schemata217.ReplaceNumericConstant_1(657L, 1)))
                    {
                        return string.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(666L, "DafnyArray<{0}>::Null()"), TypeName(elType, wr, tok));
                    }
                    else
                    {
                        throw new UnsupportedFeatureException(tok, Feature.MultiDimensionalArrays);
                    }
                }
                else
                {
                    return MutateCSharp.Schemata217.ReplaceStringConstant_0(667L, "nullptr");
                }
            }
            else if (cl is DatatypeDecl)
            {
                var dt = (DatatypeDecl)cl;
                var s = dt is TupleTypeDecl ? MutateCSharp.Schemata217.ReplaceStringConstant_0(668L, "Tuple") : FullTypeName(udt);
                var w = new ConcreteSyntaxTree();
                w.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(669L, "{0}{1}()"), s, InstantiateTemplate(udt.TypeArgs));
                return w.ToString();
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected type
            }

            return default;
        }

        private string ActualTypeArgs(List<Type> typeArgs)
        {
            return MutateCSharp.Schemata217.ReplaceBinExprOp_4(674L, typeArgs.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(670L, 0
      )) ? String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(679L, " <{0}> "), Util.Comma(typeArgs, tp => TypeName(tp, null, Token.NoToken))) : "";
        }

        protected override string TypeName_UDT(string fullCompileName, List<TypeParameter.TPVariance> variance, List<Type> typeArgs,
          ConcreteSyntaxTree wr, IToken tok, bool omitTypeArguments)
        {
            Contract.Assume(fullCompileName != null);  // precondition; this ought to be declared as a Requires in the superclass
            Contract.Assume(typeArgs != null);  // precondition; this ought to be declared as a Requires in the superclass
            string s = IdProtect(fullCompileName);
            return String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(680L, "std::shared_ptr<{0}{1}>"), s, ActualTypeArgs(typeArgs));
        }

        protected override string TypeName_Companion(Type type, ConcreteSyntaxTree wr, IToken tok, MemberDecl/*?*/ member)
        {
            // There are no companion classes for Cpp
            var t = TypeName(type, wr, tok, member, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(681L, true));
            return t;
        }

        // ----- Declarations -------------------------------------------------------------
        protected override void DeclareExternType(AbstractTypeDecl d, Expression compileTypeHint, ConcreteSyntaxTree wr)
        {
            if (MutateCSharp.Schemata217.ReplaceBinExprOp_17(683L, compileTypeHint.AsStringLiteral(), MutateCSharp.Schemata217.ReplaceStringConstant_0(682L, "struct")))
            {
                modDeclWr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(684L, "// Extern declaration of {1}\n{0} struct {1};"), DeclareTemplate(d.TypeArgs), d.Name);
            }
            else
            {
                Error(GeneratorErrors.ErrorId.c_abstract_type_cannot_be_compiled_extern, d.tok, MutateCSharp.Schemata217.ReplaceStringConstant_0(685L, "Abstract type ('{0}') with unrecognized extern attribute {1} cannot be compiled.  Expected {{:extern compile_type_hint}}, e.g., 'struct'."), wr, d.FullName, compileTypeHint.AsStringLiteral());
            }
        }

        protected void DeclareField(string className, List<TypeParameter> targs, string name, bool isStatic, bool isConst, Type type, IToken tok, string rhs, ConcreteSyntaxTree wr, ConcreteSyntaxTree finisher)
        {
            var r = rhs != null ? rhs : DefaultValue(type, wr, tok);
            var t = TypeName(type, wr, tok);
            if (isStatic)
            {
                wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(686L, "static {0} {1};"), t, name);
                finisher.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(687L, "{5} {0} {1}{4}::{2} = {3};"), t, className, name, r, InstantiateTemplate(targs), DeclareTemplate(targs));
            }
            else
            {
                wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(688L, "{0} {1} = {2};"), t, name, r);
            }
        }

        private string DeclareFormalString(string prefix, string name, Type type, IToken tok, bool isInParam)
        {
            if (isInParam)
            {
                var result = String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(689L, "{0}{2} {1}"), prefix, name, TypeName(type, null, tok));
                if (MutateCSharp.Schemata217.ReplaceBinExprOp_17(691L, name, MutateCSharp.Schemata217.ReplaceStringConstant_0(690L, "__noArgsParameter")))
                {
                    result += MutateCSharp.Schemata217.ReplaceStringConstant_0(692L, " __attribute__((unused))");
                }

                return result;
            }
            else
            {
                return null;
            }

            return default;
        }

        protected override bool DeclareFormal(string prefix, string name, Type type, IToken tok, bool isInParam, ConcreteSyntaxTree wr)
        {
            var formal_str = DeclareFormalString(prefix, name, type, tok, isInParam);
            if (formal_str != null)
            {
                wr.Write(formal_str);
                return MutateCSharp.Schemata217.ReplaceBooleanConstant_7(693L, true);
            }
            else
            {
                return MutateCSharp.Schemata217.ReplaceBooleanConstant_7(694L, false);
            }

            return default;
        }

        private string DeclareFormals(List<Formal> formals)
        {
            var i = MutateCSharp.Schemata217.ReplaceNumericConstant_1(695L, 0);
            var ret = "";
            var sep = "";
            foreach (Formal arg in formals)
            {
                if (!arg.IsGhost)
                {
                    string name = FormalName(arg, i);
                    string decl = DeclareFormalString(sep, name, arg.Type, arg.tok, arg.InParam);
                    if (decl != null)
                    {
                        ret += decl;
                        sep = MutateCSharp.Schemata217.ReplaceStringConstant_0(699L, ", ");
                    }

                    MutateCSharp.Schemata217.ReplacePostfixUnaryExprOp_9(700L, ref i);
                }
            }
            return ret;
        }

        protected override void DeclareLocalVar(string name, Type/*?*/ type, IToken/*?*/ tok, bool leaveRoomForRhs, string/*?*/ rhs, ConcreteSyntaxTree wr)
        {
            if (MutateCSharp.Schemata217.ReplaceBinExprOp_23(701L, type, null))
            {
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(702L, "{0} "), TypeName(type, wr, tok));
            }
            else
            {
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(703L, "auto "));
            }
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(704L, "{0}"), name);
            if (leaveRoomForRhs)
            {
                Contract.Assert(rhs == null);  // follows from precondition
            }
            else if (rhs != null)
            {
                wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(705L, " = {0};"), rhs);
            }
            else
            {
                wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(706L, ";"));
            }
        }

        protected override ConcreteSyntaxTree DeclareLocalVar(string name, Type/*?*/ type, IToken/*?*/ tok, ConcreteSyntaxTree wr)
        {
            if (MutateCSharp.Schemata217.ReplaceBinExprOp_23(707L, type, null))
            {
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(708L, "{0} "), TypeName(type, wr, tok));
            }
            else
            {
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(709L, "auto "));
            }
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(710L, "{0} = "), name);
            var w = wr.Fork();
            wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(711L, ";"));
            return w;
        }

        protected override bool UseReturnStyleOuts(Method m, int nonGhostOutCount) => MutateCSharp.Schemata217.ReplaceBooleanConstant_7(712L, true);

        protected override void DeclareOutCollector(string collectorVarName, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(713L, "auto {0} = "), collectorVarName);
        }

        protected override void DeclareLocalOutVar(string name, Type type, IToken tok, string rhs, bool useReturnStyleOuts, ConcreteSyntaxTree wr)
        {
            DeclareLocalVar(name, type, tok, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(714L, false), rhs, wr);
        }

        protected override void EmitOutParameterSplits(string outCollector, List<string> actualOutParamNames, ConcreteSyntaxTree wr)
        {
            if (MutateCSharp.Schemata217.ReplaceBinExprOp_10(719L, actualOutParamNames.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(715L, 1)))
            {
                EmitAssignment(actualOutParamNames[MutateCSharp.Schemata217.ReplaceNumericConstant_1(724L, 0)], null, outCollector, null, wr);
            }
            else
            {
                for (var i = MutateCSharp.Schemata217.ReplaceNumericConstant_1(728L, 0); MutateCSharp.Schemata217.ReplaceBinExprOp_12(732L, i, actualOutParamNames.Count); MutateCSharp.Schemata217.ReplacePostfixUnaryExprOp_9(737L, ref i))
                {
                    wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(738L, "{0} = {1}.template get<{2}>();"), actualOutParamNames[i], outCollector, i);
                }
            }
        }

        protected override void EmitActualTypeArgs(List<Type> typeArgs, IToken tok, ConcreteSyntaxTree wr)
        {
            wr.Write(ActualTypeArgs(typeArgs));
        }

        protected void EmitNullText(Type type, ConcreteSyntaxTree wr)
        {
            var xType = type.NormalizeExpand();
            if (xType.IsArrayType)
            {
                ArrayClassDecl at = xType.AsArrayType;
                Contract.Assert(at != null);  // follows from xType.IsArrayType
                Type elType = UserDefinedType.ArrayElementType(xType);
                if (MutateCSharp.Schemata217.ReplaceBinExprOp_10(743L, at.Dims, MutateCSharp.Schemata217.ReplaceNumericConstant_1(739L, 1)))
                {
                    wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(748L, "DafnyArray<{0}>::Null()"), TypeName(elType, wr, null));
                }
                else
                {
                    throw new UnsupportedFeatureException(Token.NoToken, Feature.MultiDimensionalArrays);
                }
            }
            else
            {
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(749L, "nullptr"));
            }
        }

        protected override void EmitNull(Type type, ConcreteSyntaxTree wr)
        {
            EmitNullText(type, wr);
        }

        // ----- Statements -------------------------------------------------------------

        protected override void EmitPrintStmt(ConcreteSyntaxTree wr, Expression arg)
        {
            var wStmts = wr.Fork();
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(750L, "dafny_print("));
            wr.Append(Expr(arg, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(751L, false), wStmts));
            wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(752L, ");"));
        }

        protected override void EmitReturn(List<Formal> outParams, ConcreteSyntaxTree wr)
        {
            outParams = outParams.Where(f => !f.IsGhost).ToList();
            if (!outParams.Any())
            {
                wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(753L, "return;"));
            }
            else if (MutateCSharp.Schemata217.ReplaceBinExprOp_10(758L, outParams.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(754L, 1)))
            {
                wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(763L, "return {0};"), IdName(outParams[MutateCSharp.Schemata217.ReplaceNumericConstant_1(764L, 0)]));
            }
            else
            {
                wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(768L, "return Tuple{0}({1});"), InstantiateTemplate(outParams.ConvertAll(o => o.Type)), Util.Comma(outParams, IdName));
            }
        }

        protected override ConcreteSyntaxTree CreateLabeledCode(string label, bool createContinueLabel, ConcreteSyntaxTree wr)
        {
            var w = wr.Fork();
            var prefix = createContinueLabel ? MutateCSharp.Schemata217.ReplaceStringConstant_0(769L, "continue_") : MutateCSharp.Schemata217.ReplaceStringConstant_0(770L, "after_");
            wr.Fork(MutateCSharp.Schemata217.ReplaceNumericConstant_1(771L, -1)).WriteLine($"{prefix}{label}: ;");
            return w;
        }

        protected override void EmitBreak(string/*?*/ label, ConcreteSyntaxTree wr)
        {
            if (label == null)
            {
                wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(775L, "break;"));
            }
            else
            {
                wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(776L, "goto after_{0};"), label);
            }
        }

        protected override void EmitContinue(string label, ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(777L, "goto continue_{0};"), label);
        }

        protected override void EmitYield(ConcreteSyntaxTree wr)
        {
            throw new UnsupportedFeatureException(Token.NoToken, Feature.Iterators);
        }

        protected override void EmitAbsurd(string/*?*/ message, ConcreteSyntaxTree wr)
        {
            if (message == null)
            {
                message = MutateCSharp.Schemata217.ReplaceStringConstant_0(778L, "unexpected control point");
            }
            wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(779L, "throw \"{0}\";"), message);
        }

        protected override void EmitHalt(IToken tok, Expression messageExpr, ConcreteSyntaxTree wr)
        {
            var wStmts = wr.Fork();
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(780L, "throw DafnyHaltException("));
            if (MutateCSharp.Schemata217.ReplaceBinExprOp_24(781L, tok, null))
            {
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(782L, "\"") + tok.TokenToString(Options) + MutateCSharp.Schemata217.ReplaceStringConstant_0(783L, ": \" + "));
            }

            if (messageExpr.Type.IsStringType)
            {
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(784L, "ToVerbatimString("));
                wr.Append(Expr(messageExpr, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(785L, false), wStmts));
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(786L, ")"));
            }
            else
            {
                throw new UnsupportedFeatureException(tok, Feature.ConvertingValuesToStrings);
            }

            wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(787L, ");"));
        }

        protected override ConcreteSyntaxTree EmitForStmt(IToken tok, IVariable loopIndex, bool goingUp, string /*?*/ endVarName,
          List<Statement> body, LList<Label> labels, ConcreteSyntaxTree wr)
        {
            throw new UnsupportedFeatureException(tok, Feature.ForLoops, MutateCSharp.Schemata217.ReplaceStringConstant_0(788L, "for loops have not yet been implemented"));
            return default;
        }

        protected override ConcreteSyntaxTree CreateForLoop(string indexVar, Action<ConcreteSyntaxTree> boundAction, ConcreteSyntaxTree wr, string start = null)
        {
            start = start ?? MutateCSharp.Schemata217.ReplaceStringConstant_0(789L, "0");
            var boundWriter = new ConcreteSyntaxTree();
            boundAction(boundWriter);
            var bound = boundWriter.ToString();
            return wr.NewNamedBlock(MutateCSharp.Schemata217.ReplaceStringConstant_0(790L, "for (auto {0} = {2}; {0} < {1}; {0}++)"), indexVar, bound, start);
        }

        protected override ConcreteSyntaxTree CreateDoublingForLoop(string indexVar, int start, ConcreteSyntaxTree wr)
        {
            return wr.NewNamedBlock(MutateCSharp.Schemata217.ReplaceStringConstant_0(791L, "for (unsigned long long {0} = 1; ; {0} = {0} * 2)"), indexVar, start);
        }

        protected override void EmitIncrementVar(string varName, ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(792L, "{0} += 1;"), varName);
        }

        protected override void EmitDecrementVar(string varName, ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(793L, "{0} = {0} -= 1;"), varName);
        }

        protected override string GetQuantifierName(string bvType)
        {
            throw new UnsupportedFeatureException(Token.NoToken, Feature.Quantifiers);
            return default;
        }

        protected override ConcreteSyntaxTree CreateForeachLoop(string tmpVarName, Type collectionElementType, IToken tok,
          out ConcreteSyntaxTree collectionWriter, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(794L, "for ({1} {0} : "), tmpVarName, TypeName(collectionElementType, wr, tok));
            collectionWriter = wr.Fork();
            var wwr = wr.NewBlock(MutateCSharp.Schemata217.ReplaceStringConstant_0(795L, ")"));
            return wwr;
        }

        [CanBeNull]
        protected override Action<ConcreteSyntaxTree> GetSubtypeCondition(string tmpVarName, Type boundVarType, IToken tok, ConcreteSyntaxTree wPreconditions)
        {
            string typeTest;
            if (boundVarType.IsRefType)
            {
                if (MutateCSharp.Schemata217.ReplaceBinExprOp_20(796L, () => boundVarType.IsObject, () => boundVarType.IsObjectQ))
                {
                    typeTest = MutateCSharp.Schemata217.ReplaceStringConstant_0(802L, "true");
                }
                else if (boundVarType.IsTraitType)
                {
                    typeTest = $"_dafny.InstanceOfTrait({tmpVarName}, {TypeName(boundVarType, wPreconditions, tok)})";
                }
                else
                {
                    typeTest = $"typeid({tmpVarName}) is typeid({TypeName(boundVarType, wPreconditions, tok)})";
                }
                if (boundVarType.IsNonNullRefType)
                {
                    typeTest = $"{tmpVarName} != null && {typeTest}";
                }
                else
                {
                    typeTest = $"{tmpVarName} == null || {typeTest}";
                }
            }
            else
            {
                typeTest = MutateCSharp.Schemata217.ReplaceStringConstant_0(803L, "true");
            }

            typeTest = MutateCSharp.Schemata217.ReplaceBinExprOp_17(805L, typeTest, MutateCSharp.Schemata217.ReplaceStringConstant_0(804L, "true")) ? null : typeTest;
            return typeTest == null ? null : wr => wr.Write(typeTest);
        }

        protected override void EmitDowncastVariableAssignment(string boundVarName, Type boundVarType, string tmpVarName,
          Type sourceType, bool introduceBoundVar, IToken tok, ConcreteSyntaxTree wr)
        {
            var typeName = TypeName(boundVarType, wr, tok);
            wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(806L, "{0}{1} = ({2}){3};"), introduceBoundVar ? typeName + MutateCSharp.Schemata217.ReplaceStringConstant_0(807L, " ") : "", boundVarName, typeName, tmpVarName);
        }

        protected override ConcreteSyntaxTree CreateForeachIngredientLoop(string boundVarName, int L, string tupleTypeArgs, out ConcreteSyntaxTree collectionWriter, ConcreteSyntaxTree wr)
        {
            wr.Write($"for (auto {boundVarName} : ");
            collectionWriter = wr.Fork();
            return wr.NewBlock(MutateCSharp.Schemata217.ReplaceStringConstant_0(808L, ")"));
        }

        // ----- Expressions -------------------------------------------------------------

        protected override void EmitNew(Type type, IToken tok, CallStmt initCall /*?*/, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var cl = (type.NormalizeExpand() as UserDefinedType)?.ResolvedClass;
            if (MutateCSharp.Schemata217.ReplaceBinExprOp_5(812L, () => MutateCSharp.Schemata217.ReplaceBinExprOp_25(809L, cl, null), () => MutateCSharp.Schemata217.ReplaceBinExprOp_17(811L, cl.Name, MutateCSharp.Schemata217.ReplaceStringConstant_0(810L, "object"))))
            {
                //wr.Write("_dafny.NewObject()");
                throw new UnsupportedFeatureException(tok, Feature.NewObject);
            }
            else
            {
                var ctor = MutateCSharp.Schemata217.ReplaceBinExprOp_26(818L, initCall, null) ? null : (Constructor)initCall.Method;  // correctness of cast follows from precondition of "EmitNew"
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(819L, "std::make_shared<{0}> ("), TypeName(type, wr, tok, null, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(820L, true)));
                var tas = TypeArgumentInstantiation.ListFromClass(cl, type.TypeArgs);
                var sep = "";
                EmitTypeDescriptorsActuals(tas, tok, wr, ref sep);
                if (MutateCSharp.Schemata217.ReplaceBinExprOp_27(821L, ctor, null) && ctor.IsExtern(Options, out var q, out var n))
                {
                    // the arguments of any external constructor are placed here
                    for (int i = MutateCSharp.Schemata217.ReplaceNumericConstant_1(822L, 0); MutateCSharp.Schemata217.ReplaceBinExprOp_12(826L, i, ctor.Ins.Count); MutateCSharp.Schemata217.ReplacePostfixUnaryExprOp_9(831L, ref i))
                    {
                        Formal p = ctor.Ins[i];
                        if (!p.IsGhost)
                        {
                            wr.Write(sep);
                            wr.Append(Expr(initCall.Args[i], MutateCSharp.Schemata217.ReplaceBooleanConstant_7(832L, false), wStmts));
                            sep = MutateCSharp.Schemata217.ReplaceStringConstant_0(833L, ", ");
                        }
                    }
                }
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(834L, ")"));
            }
        }

        protected override void EmitNewArray(Type elementType, IToken tok, List<string> dimensions,
            bool mustInitialize, [CanBeNull] string exampleElement, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var initValue = mustInitialize ? DefaultValue(elementType, wr, tok) : null;
            // TODO: Handle initValue
            if (MutateCSharp.Schemata217.ReplaceBinExprOp_10(839L, dimensions.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(835L, 1)))
            {
                // handle the common case of 1-dimensional arrays separately
                wr.Write($"DafnyArray<{TypeName(elementType, wr, tok)}>::New({dimensions[MutateCSharp.Schemata217.ReplaceNumericConstant_1(844L, 0)]})");
            }
            else
            {
                throw new UnsupportedFeatureException(tok, Feature.MultiDimensionalArrays);
            }
        }

        protected override void EmitLiteralExpr(ConcreteSyntaxTree wr, LiteralExpr e)
        {
            if (e is StaticReceiverExpr)
            {
                wr.Write(TypeName(e.Type, wr, e.tok));
            }
            else if (e.Value == null)
            {
                EmitNullText(e.Type, wr);
            }
            else if (e.Value is bool)
            {
                wr.Write((bool)e.Value ? MutateCSharp.Schemata217.ReplaceStringConstant_0(848L, "true") : MutateCSharp.Schemata217.ReplaceStringConstant_0(849L, "false"));
            }
            else if (e is CharLiteralExpr)
            {
                var v = (string)e.Value;
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(850L, "'{0}'"), v);
            }
            else if (e is StringLiteralExpr)
            {
                var str = (StringLiteralExpr)e;
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(851L, "DafnySequenceFromString("));
                TrStringLiteral(str, wr);
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(852L, ")"));
            }
            else if (AsNativeType(e.Type) is NativeType nt)
            {
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(853L, "({0}){1}"), GetNativeTypeName(nt), (BigInteger)e.Value);
                if (MutateCSharp.Schemata217.ReplaceBinExprOp_29(858L, (BigInteger)e.Value, MutateCSharp.Schemata217.ReplaceNumericConstant_28(854L, 9223372036854775807)))
                {
                    // Avoid compiler warning: integer literal is too large to be represented in a signed integer type
                    wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(860L, "U"));
                }
            }
            else if (e.Value is BigInteger i)
            {
                EmitIntegerLiteral(i, wr);
            }
            else if (e.Value is BaseTypes.BigDec)
            {
                throw new UnsupportedFeatureException(e.tok, Feature.RealNumbers);
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected literal
            }
        }
        void EmitIntegerLiteral(BigInteger i, ConcreteSyntaxTree wr)
        {
            Contract.Requires(wr != null);
            wr.Write(i.ToString());
        }

        protected override void EmitStringLiteral(string str, bool isVerbatim, ConcreteSyntaxTree wr)
        {
            var n = str.Length;
            if (!isVerbatim)
            {
                wr.Write($"\"{TranslateEscapes(str)}\"");
            }
            else
            {
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(861L, "\""));
                for (var i = MutateCSharp.Schemata217.ReplaceNumericConstant_1(862L, 0); MutateCSharp.Schemata217.ReplaceBinExprOp_12(866L, i, n); MutateCSharp.Schemata217.ReplacePostfixUnaryExprOp_9(871L, ref i))
                {
                    if (MutateCSharp.Schemata217.ReplaceBinExprOp_5(919L, () => MutateCSharp.Schemata217.ReplaceBinExprOp_5(895L, () => MutateCSharp.Schemata217.ReplaceBinExprOp_10(872L, str[i], '\"'), () => MutateCSharp.Schemata217.ReplaceBinExprOp_12(890L, MutateCSharp.Schemata217.ReplaceBinExprOp_30(881L, i, MutateCSharp.Schemata217.ReplaceNumericConstant_1(877L, 1)), n)), () => MutateCSharp.Schemata217.ReplaceBinExprOp_10(914L, str[MutateCSharp.Schemata217.ReplaceBinExprOp_30(905L, i, MutateCSharp.Schemata217.ReplaceNumericConstant_1(901L, 1))], '\"')))
                    {
                        wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(925L, "\\\""));
                        MutateCSharp.Schemata217.ReplacePostfixUnaryExprOp_9(926L, ref i);
                    }
                    else if (MutateCSharp.Schemata217.ReplaceBinExprOp_10(927L, str[i], '\\'))
                    {
                        wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(932L, "\\\\"));
                    }
                    else if (MutateCSharp.Schemata217.ReplaceBinExprOp_10(933L, str[i], '\n'))
                    {
                        wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(938L, "\\n"));
                    }
                    else if (MutateCSharp.Schemata217.ReplaceBinExprOp_10(939L, str[i], '\r'))
                    {
                        wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(944L, "\\r"));
                    }
                    else
                    {
                        wr.Write(str[i]);
                    }
                }
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(945L, "\""));
            }

            // Use the postfix "..."s operator (operator""s) to convert to std::string values
            // without interpreting /0 as a terminator:
            // https://en.cppreference.com/w/cpp/string/basic_string/operator%22%22s
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(946L, "s"));
        }

        private static string TranslateEscapes(string s)
        {
            s = Util.ReplaceNullEscapesWithCharacterEscapes(s);
            // TODO: Other cases, once we address the fact that we shouldn't be
            // using the C++ char as the Dafny 16-bit char in the first place.
            return s;
        }

        protected override ConcreteSyntaxTree EmitBitvectorTruncation(BitvectorType bvType, [CanBeNull] NativeType nativeType,
          bool surroundByUnchecked, ConcreteSyntaxTree wr)
        {
            string literalSuffix = null;
            if (MutateCSharp.Schemata217.ReplaceBinExprOp_13(947L, nativeType, null))
            {
                GetNativeInfo(nativeType.Sel, out _, out literalSuffix, out _);
            }

            if (MutateCSharp.Schemata217.ReplaceBinExprOp_16(948L, nativeType, null))
            {
                throw new UnsupportedFeatureException(Token.NoToken, Feature.UnboundedIntegers, MutateCSharp.Schemata217.ReplaceStringConstant_0(949L, "EmitBitvectorTruncation with BigInteger value"));
            }
            else if (MutateCSharp.Schemata217.ReplaceBinExprOp_12(950L, bvType.Width, nativeType.Bitwidth))
            {
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(955L, "(("));
                var middle = wr.Fork();
                // print in hex, because that looks nice
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(956L, ") & 0x{0:X}{1})"), MutateCSharp.Schemata217.ReplaceBinExprOp_33(964L, (MutateCSharp.Schemata217.ReplaceBinExprOp_32(960L, MutateCSharp.Schemata217.ReplaceNumericConstant_31(957L, 1UL), bvType.Width)), MutateCSharp.Schemata217.ReplaceNumericConstant_31(961L, 1)), literalSuffix);
                return middle;
            }
            else
            {
                // no truncation needed
                return wr;
            }

            return default;
        }

        protected override void EmitRotate(Expression e0, Expression e1, bool isRotateLeft, ConcreteSyntaxTree wr,
          bool inLetExprBody, ConcreteSyntaxTree wStmts, FCE_Arg_Translator tr)
        {
            throw new UnsupportedFeatureException(e0.tok, Feature.BitvectorRotateFunctions);
        }

        protected override void EmitEmptyTupleList(string tupleTypeArgs, ConcreteSyntaxTree wr)
        {
            throw new UnsupportedFeatureException(Token.NoToken, Feature.NonSequentializableForallStatements);
        }

        protected override ConcreteSyntaxTree EmitAddTupleToList(string ingredients, string tupleTypeArgs, ConcreteSyntaxTree wr)
        {
            throw new UnsupportedFeatureException(Token.NoToken, Feature.NonSequentializableForallStatements);
            return default;
        }

        protected override void EmitTupleSelect(string prefix, int i, ConcreteSyntaxTree wr)
        {
            throw new UnsupportedFeatureException(Token.NoToken, Feature.NonSequentializableForallStatements);
        }

        protected override string IdProtect(string name)
        {
            return PublicIdProtect(name);
        }

        public override string PublicIdProtect(string name)
        {
            Contract.Requires(name != null);
            switch (name)
            {
                // Taken from: https://www.w3schools.in/cplusplus-tutorial/keywords/
                // Keywords
                case "asm":
                case "auto":
                case "bool":
                case "break":
                case "case":
                case "catch":
                case "char":
                case "class":
                case "const":
                case "const_cast":
                case "continue":
                case "default":
                case "delete":
                case "do":
                case "double":
                case "dynamic_cast":
                case "else":
                case "enum":
                case "explicit":
                case "export":
                case "extern":
                case "false":
                case "float":
                case "for":
                case "friend":
                case "goto":
                case "if":
                case "inline":
                case "int":
                case "long":
                case "mutable":
                case "namespace":
                case "new":
                case "operator":
                case "private":
                case "public":
                case "register":
                case "reinterpret_cast":
                case "return":
                case "short":
                case "signed":
                case "sizeof":
                case "static":
                case "static_cast":
                case "struct":
                case "switch":
                case "template":
                case "this":
                case "throw":
                case "true":
                case "try":
                case "typedef":
                case "typeid":
                case "typename":
                case "union":
                case "unsigned":
                case "using":
                case "virtual":
                case "void":
                case "volatile":
                case "wchar_t":
                case "while":

                // Also reserved
                case "And":
                case "and_eq":
                case "bitand":
                case "bitor":
                case "compl":
                case "not":
                case "not_eq":
                case "or":
                case "or_eq":
                case "xor":
                case "xor_eq":
                    return name + "_";
                    break;
                default:
                    return name;
                    break;
            }

            return default;
        }

        protected override string FullTypeName(UserDefinedType udt, MemberDecl/*?*/ member = null)
        {
            Contract.Assume(udt != null);  // precondition; this ought to be declared as a Requires in the superclass
            if (udt is ArrowType)
            {
                throw new UnsupportedFeatureException(udt.tok, Feature.FunctionValues, string.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(971L, "UserDefinedTypeName {0}"), udt.Name));
                //return ArrowType.Arrow_FullCompileName;
            }
            var cl = udt.ResolvedClass;
            if (cl is TypeParameter)
            {
                return IdProtect(udt.GetCompileName(Options));
            }
            else if (MutateCSharp.Schemata217.ReplaceBinExprOp_5(987L, () => MutateCSharp.Schemata217.ReplaceBinExprOp_5(980L, () => MutateCSharp.Schemata217.ReplaceBinExprOp_5(973L, () => cl is DefaultClassDecl, () => Attributes.Contains(cl.EnclosingModuleDefinition.Attributes, MutateCSharp.Schemata217.ReplaceStringConstant_0(972L, "extern"))), () => MutateCSharp.Schemata217.ReplaceBinExprOp_34(979L, member, null)), () => Attributes.Contains(member.Attributes, MutateCSharp.Schemata217.ReplaceStringConstant_0(986L, "extern"))))
            {
                // omit the default class name ("_default") in extern modules, when the class is used to qualify an extern member
                Contract.Assert(!cl.EnclosingModuleDefinition.IsDefaultModule); // default module is not marked ":extern"
                return IdProtect(cl.EnclosingModuleDefinition.GetCompileName(Options));
            }
            else if (Attributes.Contains(cl.Attributes, MutateCSharp.Schemata217.ReplaceStringConstant_0(993L, "extern")))
            {
                return IdProtect(cl.EnclosingModuleDefinition.GetCompileName(Options)) + MutateCSharp.Schemata217.ReplaceStringConstant_0(994L, "::") + IdProtect(cl.Name);
            }
            else if (cl is TupleTypeDecl)
            {
                if (MutateCSharp.Schemata217.ReplaceBinExprOp_4(999L, udt.TypeArgs.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(995L, 0)))
                {
                    return MutateCSharp.Schemata217.ReplaceStringConstant_0(1004L, "Tuple");
                }
                else
                {
                    return MutateCSharp.Schemata217.ReplaceStringConstant_0(1005L, "Tuple0"); // Need to special case this, as C++ won't infer the correct type arguments
                }
            }
            else
            {
                return IdProtect(cl.EnclosingModuleDefinition.GetCompileName(Options)) + MutateCSharp.Schemata217.ReplaceStringConstant_0(1006L, "::") + IdProtect(cl.GetCompileName(Options));
            }

            return default;
        }

        protected override void EmitThis(ConcreteSyntaxTree wr, bool callToInheritedMember)
        {
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1007L, "this"));
        }

        protected override void EmitDatatypeValue(DatatypeValue dtv, string typeDescriptorArguments, string arguments, ConcreteSyntaxTree wr)
        {
            EmitDatatypeValue(dtv, dtv.Ctor, dtv.IsCoCall, arguments, wr);
        }

        void EmitDatatypeValue(DatatypeValue dtv, DatatypeCtor ctor, bool isCoCall, string arguments, ConcreteSyntaxTree wr)
        {
            var dt = dtv.Ctor.EnclosingDatatype;
            var dtName = dt.GetCompileName(Options);
            var ctorName = ctor.GetCompileName(Options);

            if (dt is TupleTypeDecl)
            {
                var tuple = dt as TupleTypeDecl;
                var types = new List<Type>();
                foreach (var arg in dtv.Arguments)
                {
                    types.Add(arg.Type);
                }

                if (MutateCSharp.Schemata217.ReplaceBinExprOp_10(1012L, types.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(1008L, 0)))
                {
                    wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1017L, "Tuple0()"));
                }
                else
                {
                    wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1018L, "Tuple{0}({1})"), InstantiateTemplate(types), arguments);
                }
            }
            else if (!isCoCall)
            {
                // Ordinary constructor (that is, one that does not guard any co-recursive calls)
                // Generate:  Dt.create_Ctor(arguments)
                if (MutateCSharp.Schemata217.ReplaceBinExprOp_10(1023L, dt.Ctors.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(1019L, 1)))
                {
                    wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1028L, "{3}::{0}{1}({2})"),
                      dtName,
                      InstantiateTemplate(dt.TypeArgs),
                      arguments,
                      dt.EnclosingModuleDefinition.GetCompileName(Options));
                }
                else
                {
                    wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1029L, "{4}::{0}{1}::create_{2}({3})"),
                      dtName, ActualTypeArgs(dtv.InferredTypeArgs), ctorName,
                      arguments, dt.EnclosingModuleDefinition.GetCompileName(Options));
                }

            }
            else
            {
                // Co-recursive call
                // Generate:  Dt.lazy_Ctor(($dt) => Dt.create_Ctor($dt, args))
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1030L, "{0}.lazy_{1}(($dt) => "), dtName, ctorName);
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1031L, "{0}.create_{1}($dt{2}{3})"), dtName, ctorName, MutateCSharp.Schemata217.ReplaceBinExprOp_10(1036L, arguments.Length, MutateCSharp.Schemata217.ReplaceNumericConstant_1(1032L, 0)) ? "" : MutateCSharp.Schemata217.ReplaceStringConstant_0(1041L, ", "), arguments);
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1042L, ")"));
            }
        }

        protected override void GetSpecialFieldInfo(SpecialField.ID id, object idParam, Type receiverType, out string compiledName, out string preString, out string postString)
        {
            compiledName = "";
            preString = "";
            postString = "";
            switch (id)
            {
                case SpecialField.ID.UseIdParam:
                    compiledName = (string)idParam;
                    break;
                    break;
                case SpecialField.ID.ArrayLength:
                case SpecialField.ID.ArrayLengthInt:
                    throw new UnsupportedFeatureException(Token.NoToken, Feature.ArrayLength);
                    break;
                case SpecialField.ID.Floor:
                    compiledName = "int()";
                    break;
                    break;
                case SpecialField.ID.IsLimit:
                    throw new UnsupportedFeatureException(Token.NoToken, Feature.Ordinals);
                    break;
                case SpecialField.ID.IsSucc:
                    throw new UnsupportedFeatureException(Token.NoToken, Feature.Ordinals);
                    break;
                case SpecialField.ID.Offset:
                    throw new UnsupportedFeatureException(Token.NoToken, Feature.Ordinals);
                    break;
                case SpecialField.ID.IsNat:
                    throw new UnsupportedFeatureException(Token.NoToken, Feature.Ordinals);
                    break;
                case SpecialField.ID.Keys:
                    compiledName = "dafnyKeySet()";
                    break;
                    break;
                case SpecialField.ID.Values:
                    compiledName = "dafnyValues()";
                    break;
                    break;
                case SpecialField.ID.Items:
                    throw new UnsupportedFeatureException(Token.NoToken, Feature.MapItems);
                    break;
                case SpecialField.ID.Reads:
                    compiledName = "_reads";
                    break;
                    break;
                case SpecialField.ID.Modifies:
                    compiledName = "_modifies";
                    break;
                    break;
                case SpecialField.ID.New:
                    compiledName = "_new";
                    break;
                    break;
                default:
                    Contract.Assert(false); // unexpected ID
                    break;
                    break;
            }
        }

        protected override ILvalue EmitMemberSelect(Action<ConcreteSyntaxTree> obj, Type objType, MemberDecl member, List<TypeArgumentInstantiation> typeArgs, Dictionary<TypeParameter, Type> typeMap,
          Type expectedType, string/*?*/ additionalCustomParameter = null, bool internalAccess = false)
        {
            if (MutateCSharp.Schemata217.ReplaceBinExprOp_5(1043L, () => member.IsStatic, () => member is ConstantField))
            {
                // This used to work, but now obj comes in wanting to use TypeName on the class, which results in (std::shared_ptr<_module::MyClass>)::c;
                //return SuffixLvalue(obj, "::{0}", member.CompileName);
                return SimpleLvalue(wr =>
                {
                    wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1049L, "{0}::{1}::{2}"), IdProtect(member.EnclosingClass.EnclosingModuleDefinition.GetCompileName(Options)), IdProtect(member.EnclosingClass.GetCompileName(Options)), IdProtect(member.GetCompileName(Options)));
                });
            }
            else if (member is DatatypeDestructor dtor && dtor.EnclosingClass is TupleTypeDecl)
            {
                return SuffixLvalue(obj, MutateCSharp.Schemata217.ReplaceStringConstant_0(1050L, ".get<{0}>()"), dtor.Name);
            }
            else if (member is SpecialField sf2 && sf2.SpecialId == SpecialField.ID.UseIdParam && sf2.IdParam is string fieldName
                       && fieldName.StartsWith(MutateCSharp.Schemata217.ReplaceStringConstant_0(1051L, "is_")))
            {
                // Ugly hack of a check to figure out if this is a datatype query: f.Constructor?
                return SuffixLvalue(obj, MutateCSharp.Schemata217.ReplaceStringConstant_0(1052L, ".is_{0}_{1}()"), IdProtect(sf2.EnclosingClass.GetCompileName(Options)), fieldName.Substring(MutateCSharp.Schemata217.ReplaceNumericConstant_1(1053L, 3)));
            }
            else if (member is SpecialField sf)
            {
                GetSpecialFieldInfo(sf.SpecialId, sf.IdParam, objType, out var compiledName, out var preStr, out var postStr);
                if (MutateCSharp.Schemata217.ReplaceBinExprOp_20(1059L, () => MutateCSharp.Schemata217.ReplaceBinExprOp_35(1057L, sf.SpecialId, SpecialField.ID.Keys), () => MutateCSharp.Schemata217.ReplaceBinExprOp_35(1058L, sf.SpecialId, SpecialField.ID.Values)))
                {
                    return SuffixLvalue(obj, MutateCSharp.Schemata217.ReplaceStringConstant_0(1065L, ".{0}"), compiledName);
                }
                else if (sf is DatatypeDestructor dtor2)
                {
                    if (!(dtor2.EnclosingClass is IndDatatypeDecl))
                    {
                        UnsupportedFeatureError(dtor2.tok, Feature.Codatatypes,
                          String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(1066L, "Unexpected use of a destructor {0} that isn't for an inductive datatype.  Panic!"),
                            member.Name));
                    }

                    var dt = dtor2.EnclosingClass as IndDatatypeDecl;
                    return SimpleLvalue(wr =>
                    {
                        if (MutateCSharp.Schemata217.ReplaceBinExprOp_4(1071L, dt.Ctors.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(1067L, 1)))
                        {
                            if (dtor2.Type is UserDefinedType udt && MutateCSharp.Schemata217.ReplaceBinExprOp_36(1076L, udt.ResolvedClass, dt))
                            {
                                // This a recursively defined datatype; need to dereference the pointer
                                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1077L, "*"));
                            }

                            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1078L, "("));
                            obj(wr);
                            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1079L, ".dtor_{0}()"), sf.GetCompileName(Options));
                        }
                        else
                        {
                            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1080L, "("));
                            obj(wr);
                            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1081L, ".{0}"), sf.GetCompileName(Options));
                        }

                        wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1082L, ")"));
                    });
                }
                else if (MutateCSharp.Schemata217.ReplaceBinExprOp_5(1092L, () => !member.IsStatic, () => MutateCSharp.Schemata217.ReplaceBinExprOp_18(1087L, compiledName.Length, MutateCSharp.Schemata217.ReplaceNumericConstant_1(1083L, 0))))
                {
                    return SuffixLvalue(obj, MutateCSharp.Schemata217.ReplaceStringConstant_0(1098L, "->{0}"), compiledName);
                }
                else if (MutateCSharp.Schemata217.ReplaceBinExprOp_18(1103L, compiledName.Length, MutateCSharp.Schemata217.ReplaceNumericConstant_1(1099L, 0)))
                {
                    return SuffixLvalue(obj, MutateCSharp.Schemata217.ReplaceStringConstant_0(1108L, "::{0}"), compiledName);
                }
                else
                {
                    // this member selection is handled by some kind of enclosing function call, so nothing to do here
                    return SimpleLvalue(obj);
                }
            }
            else if (member is Function)
            {
                return StringLvalue(String.Format(MutateCSharp.Schemata217.ReplaceStringConstant_0(1109L, "{0}::{1}::{2}"),
                  IdProtect(member.EnclosingClass.EnclosingModuleDefinition.GetCompileName(Options)),
                  IdName(member.EnclosingClass),
                  IdName(member)
                ));
            }
            else
            {
                return SuffixLvalue(obj, MutateCSharp.Schemata217.ReplaceStringConstant_0(1110L, "->{0}"), IdName(member));
            }

            return default;
        }

        protected override ConcreteSyntaxTree EmitArraySelect(List<Action<ConcreteSyntaxTree>> indices, Type elmtType, ConcreteSyntaxTree wr)
        {
            var w = wr.Fork();
            foreach (var index in indices)
            {
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1111L, ".at("));
                index(wr);
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1112L, ")"));
            }
            return w;
        }

        protected override ConcreteSyntaxTree EmitArraySelect(List<Expression> indices, Type elmtType, bool inLetExprBody,
            ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            Contract.Assert(indices != null && 1 <= indices.Count);  // follows from precondition
            var w = wr.Fork();
            foreach (var index in indices)
            {
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1113L, ".at("));
                wr.Append(Expr(index, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1114L, ")"));
            }
            return w;
        }

        protected override void EmitExprAsNativeInt(Expression expr, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            EmitExpr(expr, inLetExprBody, wr, wStmts);
        }

        protected override void EmitIndexCollectionSelect(Expression source, Expression index, bool inLetExprBody,
            ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            TrParenExpr(source, wr, inLetExprBody, wStmts);
            if (source.Type.NormalizeToAncestorType() is SeqType)
            {
                // seq
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1115L, ".select("));
                wr.Append(Expr(index, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1116L, ")"));
            }
            else
            {
                // map or imap
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1117L, ".get("));
                wr.Append(Expr(index, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1118L, ")"));
            }
        }

        protected override void EmitIndexCollectionUpdate(Expression source, Expression index, Expression value,
            CollectionType resultCollectionType, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            TrParenExpr(source, wr, inLetExprBody, wStmts);
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1119L, ".update("));
            wr.Append(Expr(index, inLetExprBody, wStmts));
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1120L, ", "));
            wr.Append(CoercedExpr(value, resultCollectionType.ValueArg, inLetExprBody, wStmts));
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1121L, ")"));
        }

        protected override void EmitSeqSelectRange(Expression source, Expression lo /*?*/, Expression hi /*?*/,
            bool fromArray, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (fromArray)
            {
                string typeName = "";

                if (source.Type.TypeArgs.Count == 0 && source.Type is UserDefinedType udt && udt.ResolvedClass != null &&
                    udt.ResolvedClass is TypeSynonymDecl tsd)
                {
                    // Hack to workaround type synonyms wrapped around the actual array type
                    // TODO: Come up with a more systematic way of resolving this!
                    typeName = TypeName(tsd.Rhs.TypeArgs[MutateCSharp.Schemata217.ReplaceNumericConstant_1(1122L, 0)], wr, source.tok, null, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(1126L, false));
                }
                else
                {
                    typeName = TypeName(source.Type.TypeArgs[MutateCSharp.Schemata217.ReplaceNumericConstant_1(1127L, 0)], wr, source.tok, null, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(1131L, false));
                }
                if (MutateCSharp.Schemata217.ReplaceBinExprOp_37(1132L, lo, null))
                {
                    if (MutateCSharp.Schemata217.ReplaceBinExprOp_37(1133L, hi, null))
                    {
                        wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1134L, "DafnySequence<{0}>::SeqFromArray"), typeName);
                        TrParenExpr(source, wr, inLetExprBody, wStmts);
                    }
                    else
                    {
                        wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1135L, "DafnySequence<{0}>::SeqFromArrayPrefix("), typeName);
                        TrParenExpr(source, wr, inLetExprBody, wStmts);
                        wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1136L, ","));
                        TrParenExpr(hi, wr, inLetExprBody, wStmts);
                        wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1137L, ")"));
                    }
                }
                else
                {
                    if (MutateCSharp.Schemata217.ReplaceBinExprOp_37(1138L, hi, null))
                    {
                        wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1139L, "DafnySequence<{0}>::SeqFromArraySuffix("), typeName);
                        TrParenExpr(source, wr, inLetExprBody, wStmts);
                        wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1140L, ","));
                        TrParenExpr(lo, wr, inLetExprBody, wStmts);
                        wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1141L, ")"));
                    }
                    else
                    {
                        wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1142L, "DafnySequence<{0}>::SeqFromArraySlice("), typeName);
                        TrParenExpr(source, wr, inLetExprBody, wStmts);
                        wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1143L, ","));
                        TrParenExpr(lo, wr, inLetExprBody, wStmts);
                        wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1144L, ","));
                        TrParenExpr(hi, wr, inLetExprBody, wStmts);
                        wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1145L, ")"));
                    }
                }
            }
            else
            {
                TrParenExpr(source, wr, inLetExprBody, wStmts);

                if (MutateCSharp.Schemata217.ReplaceBinExprOp_22(1146L, hi, null))
                {
                    TrParenExpr(MutateCSharp.Schemata217.ReplaceStringConstant_0(1147L, ".take"), hi, wr, inLetExprBody, wStmts);
                }
                if (MutateCSharp.Schemata217.ReplaceBinExprOp_22(1148L, lo, null))
                {
                    TrParenExpr(MutateCSharp.Schemata217.ReplaceStringConstant_0(1149L, ".drop"), lo, wr, inLetExprBody, wStmts);
                }
            }
        }

        protected override void EmitSeqConstructionExpr(SeqConstructionExpr expr, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1150L, "DafnySequence<{0}>::Create("), TypeName(expr.Type, wr, expr.tok, null, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(1151L, false)));
            wr.Append(Expr(expr.N, inLetExprBody, wStmts));
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1152L, ", "));
            wr.Append(Expr(expr.Initializer, inLetExprBody, wStmts));
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1153L, ")"));
        }

        protected override void EmitMultiSetFormingExpr(MultiSetFormingExpr expr, bool inLetExprBody, ConcreteSyntaxTree wr,
          ConcreteSyntaxTree wStmts)
        {
            throw new UnsupportedFeatureException(expr.tok, Feature.Multisets);
        }

        protected override void EmitApplyExpr(Type functionType, IToken tok, Expression function, List<Expression> arguments,
            bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            TrParenExpr(function, wr, inLetExprBody, wStmts);
            TrExprList(arguments, wr, inLetExprBody, wStmts);
        }

        protected override ConcreteSyntaxTree EmitBetaRedex(List<string> boundVars, List<Expression> arguments,
          List<Type> boundTypes, Type resultType, IToken tok, bool inLetExprBody, ConcreteSyntaxTree wr,
          ref ConcreteSyntaxTree wStmts)
        {
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1154L, "(({0}) => "), Util.Comma(boundVars));
            var w = wr.Fork();
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1155L, ")"));
            TrExprList(arguments, wr, inLetExprBody, wStmts);
            return w;
        }

        protected override void EmitConstructorCheck(string source, DatatypeCtor ctor, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1156L, "is_{1}({0})"), source, DatatypeSubStructName(ctor));
        }

        protected override void EmitDestructor(Action<ConcreteSyntaxTree> source, Formal dtor, int formalNonGhostIndex, DatatypeCtor ctor, List<Type> typeArgs, Type bvType, ConcreteSyntaxTree wr)
        {
            if (ctor.EnclosingDatatype is TupleTypeDecl)
            {
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1157L, "("));
                source(wr);
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1158L, ").template get<{0}>()"), formalNonGhostIndex);
            }
            else
            {
                var dtorName = FormalName(dtor, formalNonGhostIndex);
                if (dtor.Type is UserDefinedType udt && MutateCSharp.Schemata217.ReplaceBinExprOp_8(1159L, udt.ResolvedClass, ctor.EnclosingDatatype))
                {
                    // Recursively defined datatype requires a dereference here
                    wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1160L, "*"));
                }

                if (MutateCSharp.Schemata217.ReplaceBinExprOp_4(1165L, ctor.EnclosingDatatype.Ctors.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(1161L, 1)))
                {
                    wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1170L, "(("));
                    source(wr);
                    wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1171L, ").dtor_{0}())"), dtorName);
                }
                else
                {
                    wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1172L, "(("));
                    source(wr);
                    wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1173L, ").{0})"), dtorName);
                }
            }
        }

        protected override ConcreteSyntaxTree CreateLambda(List<Type> inTypes, IToken tok, List<string> inNames,
            Type resultType, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts, bool untyped = false)
        {
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1174L, "function ("));
            Contract.Assert(inTypes.Count == inNames.Count);  // guaranteed by precondition
            for (var i = MutateCSharp.Schemata217.ReplaceNumericConstant_1(1175L, 0); MutateCSharp.Schemata217.ReplaceBinExprOp_12(1179L, i, inNames.Count); MutateCSharp.Schemata217.ReplacePostfixUnaryExprOp_9(1184L, ref i))
            {
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1185L, "{0}{1}"), MutateCSharp.Schemata217.ReplaceBinExprOp_10(1190L, i, MutateCSharp.Schemata217.ReplaceNumericConstant_1(1186L, 0)) ? "" : MutateCSharp.Schemata217.ReplaceStringConstant_0(1195L, ", "), inNames[i]);
            }
            var w = wr.NewExprBlock(MutateCSharp.Schemata217.ReplaceStringConstant_0(1196L, ")"));
            return w;
        }

        protected override void CreateIIFE(string bvName, Type bvType, IToken bvTok, Type bodyType, IToken bodyTok,
          ConcreteSyntaxTree wr, ref ConcreteSyntaxTree wStmts, out ConcreteSyntaxTree wrRhs, out ConcreteSyntaxTree wrBody)
        {
            var w = wr.NewExprBlock(MutateCSharp.Schemata217.ReplaceStringConstant_0(1197L, "[&]({0} {1}) -> {2} "), TypeName(bvType, wr, bvTok), bvName, TypeName(bodyType, wr, bodyTok));
            wStmts = w.Fork();
            w.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1198L, "return "));
            wrBody = w.Fork();
            w.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(1199L, ";"));
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1200L, "("));
            wrRhs = wr.Fork();
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1201L, ")"));
        }

        protected override ConcreteSyntaxTree CreateIIFE0(Type resultType, IToken resultTok, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var w = wr.NewBigExprBlock(MutateCSharp.Schemata217.ReplaceStringConstant_0(1202L, "[&] "), MutateCSharp.Schemata217.ReplaceStringConstant_0(1203L, " ()"));
            return w;
        }

        protected override ConcreteSyntaxTree CreateIIFE1(int source, Type resultType, IToken resultTok, string bvName,
            ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            throw new UnsupportedFeatureException(resultTok, Feature.LetSuchThatExpressions);
            return default;
        }

        protected override void EmitUnaryExpr(ResolvedUnaryOp op, Expression expr, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            switch (op)
            {
                case ResolvedUnaryOp.BoolNot:
                    TrParenExpr("!", expr, wr, inLetExprBody, wStmts);
                    break;
                    break;
                case ResolvedUnaryOp.BitwiseNot:
                    if (AsNativeType(expr.Type) != null)
                    {
                        wr.Write("~ ");
                        TrParenExpr(expr, wr, inLetExprBody, wStmts);
                    }
                    else
                    {
                        TrParenExpr(expr, wr, inLetExprBody, wStmts);
                        wr.Write(".Not()");
                    }
                    break;
                    break;
                case ResolvedUnaryOp.Cardinality:
                    TrParenExpr(expr, wr, inLetExprBody, wStmts);
                    wr.Write(".size()");
                    break;
                    break;
                default:
                    Contract.Assert(false); throw new cce.UnreachableException();  // unexpected unary expression
                    break;
            }
        }

        bool IsDirectlyComparable(Type t)
        {
            Contract.Requires(t != null);
            return MutateCSharp.Schemata217.ReplaceBinExprOp_20(1211L, () => MutateCSharp.Schemata217.ReplaceBinExprOp_20(1204L, () => t.IsBoolType, () => t.IsCharType), () => MutateCSharp.Schemata217.ReplaceBinExprOp_13(1210L, AsNativeType(t), null));
        }

        protected override void CompileBinOp(BinaryExpr.ResolvedOpcode op,
          Expression e0, Expression e1, IToken tok, Type resultType,
          out string opString,
          out string preOpString,
          out string postOpString,
          out string callString,
          out string staticCallString,
          out bool reverseArguments,
          out bool truncateResult,
          out bool convertE1_to_int,
          out bool coerceE1,
          ConcreteSyntaxTree errorWr)
        {

            opString = null;
            preOpString = "";
            postOpString = "";
            callString = null;
            staticCallString = null;
            reverseArguments = MutateCSharp.Schemata217.ReplaceBooleanConstant_7(1217L, false);
            truncateResult = MutateCSharp.Schemata217.ReplaceBooleanConstant_7(1218L, false);
            convertE1_to_int = MutateCSharp.Schemata217.ReplaceBooleanConstant_7(1219L, false);
            coerceE1 = MutateCSharp.Schemata217.ReplaceBooleanConstant_7(1220L, false);

            switch (op)
            {
                case BinaryExpr.ResolvedOpcode.Iff:
                    opString = "=="; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Imp:
                    preOpString = "!"; opString = "||"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Or:
                    opString = "||"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.And:
                    opString = "&&"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.BitwiseAnd:
                    if (AsNativeType(resultType) != null)
                    {
                        opString = "&";
                    }
                    else
                    {
                        callString = "And";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.BitwiseOr:
                    if (AsNativeType(resultType) != null)
                    {
                        opString = "|";
                    }
                    else
                    {
                        callString = "Or";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.BitwiseXor:
                    if (AsNativeType(resultType) != null)
                    {
                        opString = "^";
                    }
                    else
                    {
                        callString = "Xor";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.EqCommon:
                    {
                        if (IsDirectlyComparable(e0.Type))
                        {
                            opString = "==";
                        }
                        else if (e0.Type.IsRefType)
                        {
                            opString = "==";
                        }
                        else
                        {
                            //staticCallString = "==";
                            opString = "==";
                        }
                        break;
                    }

                    break;
                case BinaryExpr.ResolvedOpcode.NeqCommon:
                    {
                        if (IsDirectlyComparable(e0.Type))
                        {
                            opString = "!=";
                        }
                        else if (e0.Type.IsRefType)
                        {
                            opString = "!=";
                        }
                        else
                        {
                            opString = "!=";
                        }
                        break;
                    }

                    break;
                case BinaryExpr.ResolvedOpcode.Lt:
                case BinaryExpr.ResolvedOpcode.LtChar:
                    opString = "<";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Le:
                case BinaryExpr.ResolvedOpcode.LeChar:
                    opString = "<=";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Ge:
                case BinaryExpr.ResolvedOpcode.GeChar:
                    opString = ">=";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Gt:
                case BinaryExpr.ResolvedOpcode.GtChar:
                    opString = ">";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.LeftShift:
                    if (resultType.NormalizeToAncestorType().IsBitVectorType)
                    {
                        truncateResult = true;
                    }
                    if (AsNativeType(resultType) != null)
                    {
                        opString = "<<";
                    }
                    else
                    {
                        throw new UnsupportedFeatureException(tok, Feature.NonNativeNewtypes,
                          "LeftShift of non-native type");
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.RightShift:
                    if (AsNativeType(resultType) != null)
                    {
                        opString = ">>";
                        if (AsNativeType(e1.Type) == null)
                        {
                            postOpString = ".Uint64()";
                        }
                    }
                    else
                    {
                        throw new UnsupportedFeatureException(tok, Feature.NonNativeNewtypes,
                          "LeftShift of non-native type");
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Add:
                    if (resultType.NormalizeToAncestorType().IsBitVectorType)
                    {
                        truncateResult = true;
                    }
                    if (resultType.IsCharType || AsNativeType(resultType) != null)
                    {
                        opString = "+";
                    }
                    else
                    {
                        throw new UnsupportedFeatureException(tok, Feature.NonNativeNewtypes,
                          "Add of non-native type");
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Sub:
                    if (resultType.NormalizeToAncestorType().IsBitVectorType)
                    {
                        truncateResult = true;
                    }
                    if (resultType.IsCharType || AsNativeType(resultType) != null)
                    {
                        opString = "-";
                    }
                    else
                    {
                        throw new UnsupportedFeatureException(tok, Feature.NonNativeNewtypes);
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Mul:
                    if (resultType.NormalizeToAncestorType().IsBitVectorType)
                    {
                        truncateResult = true;
                    }
                    if (AsNativeType(resultType) != null)
                    {
                        opString = "*";
                    }
                    else
                    {
                        throw new UnsupportedFeatureException(tok, Feature.NonNativeNewtypes);
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Div:
                    if (AsNativeType(resultType) != null)
                    {
                        var nt = AsNativeType(resultType);
                        if (nt.LowerBound < BigInteger.Zero)
                        {
                            // Want Euclidean division for signed types
                            staticCallString = "EuclideanDivision_" + GetNativeTypeName(AsNativeType(resultType));
                        }
                        else
                        {
                            // Native division is fine for unsigned
                            opString = "/";
                        }
                    }
                    else
                    {
                        callString = "DivBy";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Mod:
                    if (AsNativeType(resultType) != null)
                    {
                        var nt = AsNativeType(resultType);
                        if (nt.LowerBound < BigInteger.Zero)
                        {
                            // Want Euclidean division for signed types
                            staticCallString = "_dafny.Mod" + Capitalize(GetNativeTypeName(AsNativeType(resultType)));
                        }
                        else
                        {
                            // Native division is fine for unsigned
                            opString = "%";
                        }
                    }
                    else
                    {
                        callString = "Modulo";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.SetEq:
                case BinaryExpr.ResolvedOpcode.MultiSetEq:
                case BinaryExpr.ResolvedOpcode.MapEq:
                case BinaryExpr.ResolvedOpcode.SeqEq:
                    callString = "equals"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.SetNeq:
                case BinaryExpr.ResolvedOpcode.MultiSetNeq:
                case BinaryExpr.ResolvedOpcode.MapNeq:
                case BinaryExpr.ResolvedOpcode.SeqNeq:
                    preOpString = "!"; callString = "equals"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.ProperSubset:
                case BinaryExpr.ResolvedOpcode.ProperMultiSubset:
                    callString = "IsProperSubsetOf"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Subset:
                case BinaryExpr.ResolvedOpcode.MultiSubset:
                    callString = "IsSubsetOf"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Superset:
                case BinaryExpr.ResolvedOpcode.MultiSuperset:
                    callString = "IsSupersetOf"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.ProperSuperset:
                case BinaryExpr.ResolvedOpcode.ProperMultiSuperset:
                    callString = "IsProperSupersetOf"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Disjoint:
                case BinaryExpr.ResolvedOpcode.MultiSetDisjoint:
                    callString = "IsDisjointFrom"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.InSet:
                case BinaryExpr.ResolvedOpcode.InMultiSet:
                case BinaryExpr.ResolvedOpcode.InMap:
                    callString = "contains"; reverseArguments = true; break;
                    break;
                case BinaryExpr.ResolvedOpcode.NotInSet:
                case BinaryExpr.ResolvedOpcode.NotInMultiSet:
                case BinaryExpr.ResolvedOpcode.NotInMap:
                    preOpString = "!"; callString = "contains"; reverseArguments = true; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Union:
                case BinaryExpr.ResolvedOpcode.MultiSetUnion:
                    callString = "Union"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.MapMerge:
                    callString = "Merge"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Intersection:
                case BinaryExpr.ResolvedOpcode.MultiSetIntersection:
                    callString = "Intersection"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.SetDifference:
                case BinaryExpr.ResolvedOpcode.MultiSetDifference:
                    callString = "Difference"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.MapSubtraction:
                    callString = "Subtract"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.ProperPrefix:
                    callString = "IsProperPrefixOf"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Prefix:
                    callString = "IsPrefixOf"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Concat:
                    callString = "concatenate"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.InSeq:
                    callString = "contains"; reverseArguments = true; break;
                    break;
                case BinaryExpr.ResolvedOpcode.NotInSeq:
                    preOpString = "!"; callString = "contains"; reverseArguments = true; break;
                    break;
                default:
                    Contract.Assert(false); throw new cce.UnreachableException();  // unexpected binary expression
                    break;
            }
        }

        protected override void EmitIsZero(string varName, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1221L, "{0} == 0"), varName);
        }

        protected override void EmitConversionExpr(Expression fromExpr, Type fromType, Type toType, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (MutateCSharp.Schemata217.ReplaceBinExprOp_20(1228L, () => MutateCSharp.Schemata217.ReplaceBinExprOp_20(1222L, () => fromType.IsNumericBased(Type.NumericPersuasion.Int), () => fromType.IsBitVectorType), () => fromType.IsCharType))
            {
                if (toType.IsNumericBased(Type.NumericPersuasion.Real))
                {
                    throw new UnsupportedFeatureException(fromExpr.tok, Feature.RealNumbers);
                }
                else if (toType.IsCharType)
                {
                    wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1234L, "(char)"));
                    TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                }
                else
                {
                    // (int or bv or char) -> (int or bv or ORDINAL)
                    var fromNative = AsNativeType(fromType);
                    var toNative = AsNativeType(toType);
                    if (MutateCSharp.Schemata217.ReplaceBinExprOp_5(1237L, () => MutateCSharp.Schemata217.ReplaceBinExprOp_13(1235L, fromNative, null), () => MutateCSharp.Schemata217.ReplaceBinExprOp_13(1236L, toNative, null)))
                    {
                        // from a native, to a native -- simple!
                        wr.Write(GetNativeTypeName(toNative));
                        TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                    }
                    else if (fromType.IsCharType)
                    {
                        Contract.Assert(fromNative == null);
                        if (MutateCSharp.Schemata217.ReplaceBinExprOp_16(1243L, toNative, null))
                        {
                            throw new UnsupportedFeatureException(fromExpr.tok, Feature.UnboundedIntegers);
                        }
                        else
                        {
                            // char -> native
                            wr.Write($"({GetNativeTypeName(toNative)})");
                            TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                        }
                    }
                    else if (MutateCSharp.Schemata217.ReplaceBinExprOp_5(1246L, () => MutateCSharp.Schemata217.ReplaceBinExprOp_16(1244L, fromNative, null), () => MutateCSharp.Schemata217.ReplaceBinExprOp_16(1245L, toNative, null)))
                    {
                        // big-integer (int or bv) -> big-integer (int or bv or ORDINAL), so identity will do
                        wr.Append(Expr(fromExpr, inLetExprBody, wStmts));
                    }
                    else if (MutateCSharp.Schemata217.ReplaceBinExprOp_13(1252L, fromNative, null))
                    {
                        Contract.Assert(toNative == null); // follows from other checks

                        // native (int or bv) -> big-integer (int or bv)
                        wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1253L, "_dafny.IntOf{0}("), Capitalize(GetNativeTypeName(fromNative)));
                        wr.Append(Expr(fromExpr, inLetExprBody, wStmts));
                        wr.Write(')');
                    }
                    else
                    {
                        // any (int or bv) -> native (int or bv)
                        // Consider some optimizations
                        var literal = PartiallyEvaluate(fromExpr);
                        UnaryOpExpr u = fromExpr.Resolved as UnaryOpExpr;
                        MemberSelectExpr m = fromExpr.Resolved as MemberSelectExpr;
                        if (literal != null)
                        {
                            // Optimize constant to avoid intermediate BigInteger
                            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1254L, "{0}({1})"), GetNativeTypeName(toNative), literal);
                        }
                        else if (MutateCSharp.Schemata217.ReplaceBinExprOp_5(1257L, () => MutateCSharp.Schemata217.ReplaceBinExprOp_38(1255L, u, null), () => MutateCSharp.Schemata217.ReplaceBinExprOp_39(1256L, u.Op, UnaryOpExpr.Opcode.Cardinality)))
                        {
                            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1263L, "({0})("), GetNativeTypeName(toNative));
                            TrParenExpr(u.E, wr, inLetExprBody, wStmts);
                            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1264L, ".size())"));
                        }
                        else if (MutateCSharp.Schemata217.ReplaceBinExprOp_5(1274L, () => MutateCSharp.Schemata217.ReplaceBinExprOp_5(1268L, () => MutateCSharp.Schemata217.ReplaceBinExprOp_40(1265L, m, null), () => MutateCSharp.Schemata217.ReplaceBinExprOp_17(1267L, m.MemberName, MutateCSharp.Schemata217.ReplaceStringConstant_0(1266L, "Length"))), () => m.Obj.Type.IsArrayType))
                        {
                            // Optimize .Length to avoid intermediate BigInteger
                            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1280L, "({0})("), GetNativeTypeName(toNative));
                            TrParenExpr(m.Obj, wr, inLetExprBody, wStmts);
                            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1281L, ".size())"));
                        }
                        else
                        {
                            // no optimization applies; use the standard translation
                            TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1282L, ".{0}()"), Capitalize(GetNativeTypeName(toNative)));
                        }

                    }
                }
            }
            else if (fromType.IsNumericBased(Type.NumericPersuasion.Real))
            {
                Contract.Assert(AsNativeType(fromType) == null);
                if (toType.IsNumericBased(Type.NumericPersuasion.Real))
                {
                    // real -> real
                    Contract.Assert(AsNativeType(toType) == null);
                    wr.Append(Expr(fromExpr, inLetExprBody, wStmts));
                }
                else
                {
                    // real -> (int or bv)
                    TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                    wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1283L, ".Int()"));
                    if (AsNativeType(toType) is NativeType nt)
                    {
                        wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1284L, ".{0}()"), Capitalize(GetNativeTypeName(nt)));
                    }
                }
            }
            else if (fromType.IsBigOrdinalType)
            {
                Contract.Assert(toType.IsNumericBased(Type.NumericPersuasion.Int));
                // identity will do
                wr.Append(Expr(fromExpr, inLetExprBody, wStmts));
            }
            else
            {
                // identity will do
                Contract.Assert(fromType.Equals(toType) || fromType.AsNewtype != null || toType.AsNewtype != null);
                wr.Append(Expr(fromExpr, inLetExprBody, wStmts));
            }
        }

        protected override void EmitTypeTest(string localName, Type fromType, Type toType, IToken tok, ConcreteSyntaxTree wr)
        {
            throw new UnsupportedFeatureException(tok, Feature.TypeTests);
        }

        protected override void EmitIsIntegerTest(Expression source, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            throw new UnsupportedFeatureException(source.Tok, Feature.TypeTests);
        }

        protected override void EmitIsUnicodeScalarValueTest(Expression source, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            throw new UnsupportedFeatureException(source.Tok, Feature.TypeTests);
        }

        protected override void EmitIsInIntegerRange(Expression source, BigInteger lo, BigInteger hi, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            throw new UnsupportedFeatureException(source.Tok, Feature.TypeTests);
        }

        protected override void EmitCollectionDisplay(CollectionType ct, IToken tok, List<Expression> elements,
          bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (ct is SetType)
            {
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1285L, "DafnySet<{0}>::Create({{"), TypeName(ct.TypeArgs[MutateCSharp.Schemata217.ReplaceNumericConstant_1(1286L, 0)], wr, tok, null, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(1290L, false)));
                for (var i = MutateCSharp.Schemata217.ReplaceNumericConstant_1(1291L, 0); MutateCSharp.Schemata217.ReplaceBinExprOp_12(1295L, i, elements.Count); MutateCSharp.Schemata217.ReplacePostfixUnaryExprOp_9(1300L, ref i))
                {
                    wr.Append(Expr(elements[i], inLetExprBody, wStmts));
                    if (MutateCSharp.Schemata217.ReplaceBinExprOp_12(1314L, i, MutateCSharp.Schemata217.ReplaceBinExprOp_2(1305L, elements.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(1301L, 1))))
                    {
                        wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1319L, ","));
                    }
                }
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1320L, "})"));
            }
            else if (ct is MultiSetType)
            {
                throw new UnsupportedFeatureException(tok, Feature.Multisets);
            }
            else
            {
                Contract.Assert(ct is SeqType);  // follows from precondition
                if (ct.Arg.IsCharType)
                {
                    throw new UnsupportedFeatureException(tok, Feature.SequenceDisplaysOfCharacters);
                }
                else
                {
                    wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1321L, "DafnySequence<{0}>::Create({{"), TypeName(ct.TypeArgs[MutateCSharp.Schemata217.ReplaceNumericConstant_1(1322L, 0)], wr, tok, null, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(1326L, false)));
                    for (var i = MutateCSharp.Schemata217.ReplaceNumericConstant_1(1327L, 0); MutateCSharp.Schemata217.ReplaceBinExprOp_12(1331L, i, elements.Count); MutateCSharp.Schemata217.ReplacePostfixUnaryExprOp_9(1336L, ref i))
                    {
                        wr.Append(Expr(elements[i], inLetExprBody, wStmts));
                        if (MutateCSharp.Schemata217.ReplaceBinExprOp_12(1350L, i, MutateCSharp.Schemata217.ReplaceBinExprOp_2(1341L, elements.Count, MutateCSharp.Schemata217.ReplaceNumericConstant_1(1337L, 1))))
                        {
                            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1355L, ","));
                        }
                    }
                    wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1356L, "})"));
                }
            }
        }

        protected override void EmitMapDisplay(MapType mt, IToken tok, List<ExpressionPair> elements,
          bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1357L, "DafnyMap<{0},{1}>::Create({{"),
                     TypeName(mt.TypeArgs[MutateCSharp.Schemata217.ReplaceNumericConstant_1(1358L, 0)], wr, tok, null, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(1362L, false)),
                     TypeName(mt.TypeArgs[MutateCSharp.Schemata217.ReplaceNumericConstant_1(1363L, 1)], wr, tok, null, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(1367L, false)));
            string sep = "";
            foreach (ExpressionPair p in elements)
            {
                wr.Write(sep);
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1368L, "{"));
                wr.Append(Expr(p.A, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1369L, ","));
                wr.Append(Expr(p.B, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1370L, "}"));
                sep = MutateCSharp.Schemata217.ReplaceStringConstant_0(1371L, ", ");
            }
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1372L, "})"));
        }

        protected override void EmitSetBuilder_New(ConcreteSyntaxTree wr, SetComprehension e, string collectionName)
        {
            var wrVarInit = DeclareLocalVar(collectionName, null, null, wr);
            wrVarInit.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1373L, "DafnySet<{0}>()"), TypeName(e.Type.NormalizeToAncestorType().AsSetType.Arg, wrVarInit, e.tok, null, MutateCSharp.Schemata217.ReplaceBooleanConstant_7(1374L, false)));
        }

        protected override void EmitMapBuilder_New(ConcreteSyntaxTree wr, MapComprehension e, string collectionName)
        {
            throw new UnsupportedFeatureException(e.tok, Feature.MapComprehensions);
        }

        protected override void EmitSetBuilder_Add(CollectionType ct, string collName, Expression elmt, bool inLetExprBody, ConcreteSyntaxTree wr)
        {
            Contract.Assume(ct is SetType || ct is MultiSetType);  // follows from precondition
            if (ct is MultiSetType)
            {
                // This should never occur since there is no syntax for multiset comprehensions yet
                throw new cce.UnreachableException();
            }
            var wStmts = wr.Fork();
            wr.Write(MutateCSharp.Schemata217.ReplaceStringConstant_0(1375L, "{0}.set.emplace("), collName);
            wr.Append(Expr(elmt, inLetExprBody, wStmts));
            wr.WriteLine(MutateCSharp.Schemata217.ReplaceStringConstant_0(1376L, ");"));
        }

        protected override ConcreteSyntaxTree EmitMapBuilder_Add(MapType mt, IToken tok, string collName, Expression term, bool inLetExprBody, ConcreteSyntaxTree wr)
        {
            throw new UnsupportedFeatureException(tok, Feature.MapComprehensions);
            return default;
        }

        protected override void GetCollectionBuilder_Build(CollectionType ct, IToken tok, string collName,
          ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmt)
        {
            // collections are built in place
            wr.Write(collName);
        }

        protected override void EmitSingleValueGenerator(Expression e, bool inLetExprBody, string type,
          ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            throw new UnsupportedFeatureException(Token.NoToken, Feature.ExactBoundedPool);
        }

        protected override void EmitHaltRecoveryStmt(Statement body, string haltMessageVarName, Statement recoveryBody, ConcreteSyntaxTree wr)
        {
            throw new UnsupportedFeatureException(Token.NoToken, Feature.RunAllTests);
        }
    }
}
