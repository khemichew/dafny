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
using System.IO;
using System.Diagnostics.Contracts;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
namespace MutateCSharp
{
    internal class Schemata238
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT238");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_27(long mutantId, System.Numerics.BigInteger argument1, long argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_34(long mutantId, Microsoft.Dafny.UnaryOpExpr.Opcode argument1, Microsoft.Dafny.UnaryOpExpr.Opcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.DatatypeCtor argument1, Microsoft.Dafny.DatatypeCtor argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_32(long mutantId, Microsoft.Dafny.SeqType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBinExprOp_7(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_11(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_29(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, long argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.NativeType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_33(long mutantId, Microsoft.Dafny.UnaryOpExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_30(long mutantId, Microsoft.Dafny.Compilers.DatatypeWrapperEraser.MemberCompileStatus argument1, Microsoft.Dafny.Compilers.DatatypeWrapperEraser.MemberCompileStatus argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static int ReplaceBinExprOp_28(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.NativeType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.TypeParameter> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, Microsoft.Dafny.SubsetTypeDecl.WKind argument1, Microsoft.Dafny.SubsetTypeDecl.WKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_35(long mutantId, Microsoft.Dafny.MemberSelectExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Type> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, Microsoft.Dafny.NewtypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.Field argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_31(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static long ReplaceNumericConstant_25(long mutantId, long argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny.Compilers
{
    public class JavaScriptCodeGenerator : SinglePassCodeGenerator
    {
        public JavaScriptCodeGenerator(DafnyOptions options, ErrorReporter reporter) : base(options, reporter)
        {
        }

        public override IReadOnlySet<Feature> UnsupportedFeatures => new HashSet<Feature> {
      Feature.MethodSynthesis,
      Feature.ExternalConstructors,
      Feature.SubsetTypeTests,
      Feature.SeparateCompilation,
      Feature.RuntimeCoverageReport
    };

        public override string ModuleSeparator => MutateCSharp.Schemata238.ReplaceStringConstant_0(1L, "_");

        const string DafnySetClass = "_dafny.Set";
        const string DafnyMultiSetClass = "_dafny.MultiSet";
        const string DafnySeqClass = "_dafny.Seq";
        const string DafnyMapClass = "_dafny.Map";

        string FormatDefaultTypeParameterValue(TopLevelDecl tp)
        {
            Contract.Requires(tp is TypeParameter || tp is AbstractTypeDecl);
            return $"_default_{tp.GetCompileName(Options)}";
        }

        protected override void EmitHeader(Program program, ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(2L, "// Dafny program {0} compiled into JavaScript"), program.Name);
            if (Options.IncludeRuntime)
            {
                EmitRuntimeSource(MutateCSharp.Schemata238.ReplaceStringConstant_0(3L, "DafnyRuntimeJs"), wr, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(4L, false));
            }
            if (Options.Get(CommonOptionBag.UseStandardLibraries))
            {
                EmitRuntimeSource(MutateCSharp.Schemata238.ReplaceStringConstant_0(5L, "DafnyStandardLibraries_js"), wr, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(6L, false));
            }
        }

        public override void EmitCallToMain(Method mainMethod, string baseName, ConcreteSyntaxTree wr)
        {
            Coverage.EmitSetup(wr);
            wr.WriteLine($"_dafny.HandleHaltExceptions(() => {mainMethod.EnclosingClass.GetFullCompileName(Options)}.{(mainMethod.IsStatic ? IdName(mainMethod) : MutateCSharp.Schemata238.ReplaceStringConstant_0(7L, "Main"))}(_dafny.{CharMethodQualifier}FromMainArguments(require('process').argv)));");
            Coverage.EmitTearDown(wr);
        }

        protected override ConcreteSyntaxTree CreateStaticMain(IClassWriter cw, string argsParameterName)
        {
            var wr = (cw as JavaScriptCodeGenerator.ClassWriter).MethodWriter;
            return wr.NewBlock($"static Main({argsParameterName})");
        }

        protected override ConcreteSyntaxTree CreateModule(string moduleName, bool isDefault, ModuleDefinition externModule,
          string libraryName /*?*/, ConcreteSyntaxTree wr)
        {
            moduleName = IdProtect(moduleName);
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_3(9L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_2(8L, externModule, null), () => libraryName != null))
            {
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(15L, "let {0} = "), moduleName);
            }

            string footer = MutateCSharp.Schemata238.ReplaceStringConstant_0(16L, ")(); // end of module ") + moduleName;
            var block = wr.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(17L, "(function()"), footer);
            var beforeReturnBody = block.Fork(MutateCSharp.Schemata238.ReplaceNumericConstant_4(18L, 0));
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_2(22L, externModule, null))
            {
                // create new module here
                beforeReturnBody.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(23L, "let $module = {};"));
            }
            else if (libraryName == null)
            {
                // extend a module provided in another .js file
                beforeReturnBody.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(24L, "let $module = {0};"), moduleName);
            }
            else
            {
                // require a library
                beforeReturnBody.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(25L, "let $module = require(\"{0}\");"), libraryName);
            }
            block.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(26L, "return $module;"));
            return beforeReturnBody;
        }

        protected override string GetHelperModuleName() => MutateCSharp.Schemata238.ReplaceStringConstant_0(27L, "_dafny");

        protected override IClassWriter CreateClass(string moduleName, string name, bool isExtern, string/*?*/ fullPrintName,
          List<TypeParameter> typeParameters, TopLevelDecl cls, List<Type>/*?*/ superClasses, IToken tok, ConcreteSyntaxTree wr)
        {
            var w = wr.NewBlock(string.Format(MutateCSharp.Schemata238.ReplaceStringConstant_0(28L, "$module.{0} = class {0}") + (isExtern ? MutateCSharp.Schemata238.ReplaceStringConstant_0(29L, " extends $module.{0}") : ""), name), MutateCSharp.Schemata238.ReplaceStringConstant_0(30L, ";"));
            w.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(31L, "constructor ("));
            var sep = "";
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(43L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_5(32L, typeParameters, null), () => MutateCSharp.Schemata238.ReplaceBinExprOp_6(38L, WriteRuntimeTypeDescriptorsFormals(typeParameters, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(33L, false), w), MutateCSharp.Schemata238.ReplaceNumericConstant_4(34L, 0))))
            {
                sep = MutateCSharp.Schemata238.ReplaceStringConstant_0(49L, ", ");
            }
            if (cls is NewtypeDecl { ParentTraits: { } parentTraits } && MutateCSharp.Schemata238.ReplaceBinExprOp_6(54L, parentTraits.Count, MutateCSharp.Schemata238.ReplaceNumericConstant_4(50L, 0)))
            {
                w.Write($"{sep}value");
            }
            var fieldWriter = w.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(59L, ")"));
            if (isExtern)
            {
                fieldWriter.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(60L, "super("));
                if (MutateCSharp.Schemata238.ReplaceBinExprOp_5(61L, typeParameters, null))
                {
                    WriteRuntimeTypeDescriptorsFormals(typeParameters, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(62L, false), w);
                }
                fieldWriter.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(63L, ");"));
            }
            if (fullPrintName != null)
            {
                fieldWriter.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(64L, "this._tname = \"{0}\";"), fullPrintName);
            }
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_5(65L, typeParameters, null))
            {
                foreach (var tp in typeParameters)
                {
                    if (NeedsTypeDescriptor(tp))
                    {
                        fieldWriter.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(66L, "this.{0} = {0};"), MutateCSharp.Schemata238.ReplaceStringConstant_0(67L, "rtd$_") + tp.GetCompileName(Options));
                    }
                }
            }
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_8(68L, superClasses, null))
            {
                superClasses = superClasses.Where(trait => !trait.IsObject).ToList();
                var parentTraitsWriter = w.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(69L, "_parentTraits()"));
                parentTraitsWriter.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(70L, "return [{0}];"), Util.Comma(superClasses, parent => TypeName(parent, parentTraitsWriter, tok)));
            }
            var methodWriter = w;
            return new ClassWriter(this, methodWriter, fieldWriter);
        }

        protected override IClassWriter CreateTrait(string name, bool isExtern, List<TypeParameter> typeParameters /*?*/,
          TraitDecl trait, List<Type> superClasses /*?*/, IToken tok, ConcreteSyntaxTree wr)
        {
            var w = wr.NewBlock(string.Format(MutateCSharp.Schemata238.ReplaceStringConstant_0(71L, "$module.{0} = class {0}"), IdProtect(name)), MutateCSharp.Schemata238.ReplaceStringConstant_0(72L, ";"));
            var fieldWriter = w;  // not used for traits, but we need a value to give to the ClassWriter
            var methodWriter = w;
            return new ClassWriter(this, methodWriter, fieldWriter);
        }

        protected override ConcreteSyntaxTree CreateIterator(IteratorDecl iter, ConcreteSyntaxTree wr)
        {
            // An iterator is compiled as follows:
            //   public class MyIteratorExample
            //   {
            //     public T q;  // in-parameter
            //     public T x;  // yield-parameter
            //     public int y;  // yield-parameter
            //     IEnumerator<object> _iter;
            //
            //     public void _MyIteratorExample(T q) {
            //       this.q = q;
            //       _iter = TheIterator();
            //     }
            //
            //     public void MoveNext(out bool more) {
            //       more =_iter.MoveNext();
            //     }
            //
            //     private IEnumerator<object> TheIterator() {
            //       // the translation of the body of the iterator, with each "yield" turning into a "yield return null;"
            //       yield break;
            //     }
            //   }

            var cw = CreateClass(IdProtect(iter.EnclosingModuleDefinition.GetCompileName(Options)), IdName(iter), iter, wr) as JavaScriptCodeGenerator.ClassWriter;
            var w = cw.MethodWriter;
            var instanceFieldsWriter = cw.FieldWriter;
            // here come the fields
            Constructor ct = null;
            foreach (var member in iter.Members)
            {
                var f = member as Field;
                if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(74L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_9(73L, f, null), () => !f.IsGhost))
                {
                    DeclareField(IdName(f), MutateCSharp.Schemata238.ReplaceBooleanConstant_1(80L, false), MutateCSharp.Schemata238.ReplaceBooleanConstant_1(81L, false), f.Type, f.tok, PlaceboValue(f.Type, instanceFieldsWriter, f.tok, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(82L, true)), instanceFieldsWriter);
                }
                else if (member is Constructor)
                {
                    Contract.Assert(ct == null);  // we're expecting just one constructor
                    ct = (Constructor)member;
                }
            }
            Contract.Assert(ct != null);  // we do expect a constructor
            instanceFieldsWriter.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(83L, "this._iter = undefined;"));

            // here's the initializer method
            w.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(84L, "{0}("), IdName(ct));
            string sep = "";
            foreach (var p in ct.Ins)
            {
                if (!p.IsGhost)
                {
                    // here we rely on the parameters and the corresponding fields having the same names
                    w.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(85L, "{0}{1}"), sep, IdName(p));
                    sep = MutateCSharp.Schemata238.ReplaceStringConstant_0(86L, ", ");
                }
            }
            {
                var wBody = w.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(87L, ")"));
                foreach (var p in ct.Ins)
                {
                    if (!p.IsGhost)
                    {
                        wBody.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(88L, "this.{0} = {0};"), IdName(p));
                    }
                }
                wBody.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(89L, "this.__iter = this.TheIterator();"));
            }
            // here are the enumerator methods
            {
                var wBody = w.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(90L, "MoveNext()"));
                wBody.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(91L, "let r = this.__iter.next();"));
                wBody.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(92L, "return !r.done;"));
            }
            var wIter = w.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(93L, "*TheIterator()"));
            wIter.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(94L, "let _this = this;"));
            return wIter;
        }

        protected override IClassWriter/*?*/ DeclareDatatype(DatatypeDecl dt, ConcreteSyntaxTree wr)
        {
            // ===== For inductive datatypes:
            //
            // $module.Dt = class Dt {
            //   constructor(tag) {
            //     this.$tag = tag;
            //   }
            //   static create_Ctor0(field0, field1, ...) {
            //     let $dt = new Dt(0);
            //     $dt.field0 = field0;
            //     $dt.field1 = field1;
            //     ...
            //     return $dt;
            //   }
            //   static create_Ctor1(...) {
            //     let $dt = new Dt(1);
            //     ...
            //   }
            //   ...
            //
            //   get is_Ctor0 { return this.$tag === 0; }
            //   get is_Ctor1 { return this.$tag === 1; }
            //   ...
            //
            //   static get AllSingletonConstructors() {
            //     return this.AllSingletonConstructors_();
            //   }
            //   static *AllSingletonConstructors_() {
            //     yield Berry.create_Ctor0();
            //     ...
            //   }
            //
            //   get dtor_Dtor0() { return this.Dtor0; }
            //   get dtor_Dtor1() { return this.Dtor1; }
            //   ...
            //
            //   toString() {
            //     ...
            //   }
            //   equals(other) {
            //     ...
            //   }
            //   static Rtd(rtd...) {
            //     return class {
            //       static get Default() { return Dt.create_CtorK(...); }
            //     };
            //   }
            // }
            //
            // ===== For co-inductive datatypes:
            //
            // $module.Dt = class Dt {
            //   constructor(tag) {
            //     this.$tag = tag;
            //   }
            //   _D() {
            //     if (this._d === undefined) {
            //       this._d = this._initializer(this);
            //       delete this._initializer;
            //     }
            //     return this._d;
            //   }
            //   static create_Ctor0($dt, field0, field1, ...) {
            //     if ($dt === null) {
            //       $dt = new Dt(0);
            //       $dt._d = $dt;
            //     }
            //     $dt.field0 = field0;
            //     $dt.field1 = field1;
            //     ...
            //     return $dt;
            //   }
            //   static lazy_Ctor0(initializer) {
            //     let dt = new Dt(0);
            //     dt._initializer = initializer;
            //     return dt;
            //   }
            //   static create_Ctor1(initializer) {
            //     let $dt = new Dt(1);
            //     ...
            //   }
            //   ...
            //
            //   get is_Ctor0() { return this.$tag === 0; }
            //   get is_Ctor1() { return this.$tag === 1; }
            //   ...
            //
            //   static get AllSingletonConstructors() {
            //     return this.AllSingletonConstructors_();
            //   }
            //   static *AllSingletonConstructors_() {
            //     yield Berry.create_Ctor0(null);
            //     ...
            //   }
            //
            //   get dtor_Dtor0() { return this._D().Dtor0; }
            //   get dtor_Dtor1() { return this._D().Dtor1; }
            //   ...
            //
            //   toString() {
            //     if ($tag == 0) {
            //       return "module.Dt.Ctor0";
            //     } else if ...
            //   }
            //   equals(other) {
            //     ...
            //   }
            //   static Rtd(rtd...) {
            //     return class {
            //       static get Default() { return Dt.create_CtorK(...); }
            //     };
            //   }
            // }
            if (dt is TupleTypeDecl)
            {
                // Tuple types are declared once and for all in DafnyRuntime.js
                return null;
            }

            string DtT = dt.GetCompileName(Options);
            string DtT_protected = IdProtect(DtT);
            var simplifiedType = DatatypeWrapperEraser.SimplifyType(Options, UserDefinedType.FromTopLevelDecl(dt.tok, dt));

            // from here on, write everything into the new block created here:
            var btw = wr.NewNamedBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(95L, "$module.{0} = class {0}"), DtT_protected);
            wr = btw;

            var wTypeDescriptors = new ConcreteSyntaxTree();
            var typeDescriptorComma = MutateCSharp.Schemata238.ReplaceBinExprOp_10(101L, WriteRuntimeTypeDescriptorsFormals(dt.TypeArgs, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(96L, false), wTypeDescriptors), MutateCSharp.Schemata238.ReplaceNumericConstant_4(97L, 0)) ? MutateCSharp.Schemata238.ReplaceStringConstant_0(106L, ", ") : "";
            var typeDescriptors = wTypeDescriptors.ToString();

            var wBody = wr.NewBlock($"constructor(tag{typeDescriptorComma}{typeDescriptors})");
            wBody.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(107L, "this.$tag = tag;"));
            foreach (var tp in dt.TypeArgs.Where(NeedsTypeDescriptor))
            {
                wBody.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(108L, "this.{0} = {0};"), MutateCSharp.Schemata238.ReplaceStringConstant_0(109L, "rtd$_") + tp.GetCompileName(Options));
            }

            if (dt is CoDatatypeDecl)
            {
                var w0 = wr.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(110L, "_D()"));
                var w1 = EmitIf(MutateCSharp.Schemata238.ReplaceStringConstant_0(111L, "this._d === undefined"), MutateCSharp.Schemata238.ReplaceBooleanConstant_1(112L, false), w0);
                w1.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(113L, "this._d = this._initializer(this);"));
                w1.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(114L, "delete this._initializer;"));
                w0.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(115L, "return this._d"));
            }

            // create methods
            var i = MutateCSharp.Schemata238.ReplaceNumericConstant_4(116L, 0);
            foreach (var ctor in dt.Ctors.Where(ctor => !ctor.IsGhost))
            {
                // collect the names of non-ghost arguments
                var argNames = new List<string>();
                var k = MutateCSharp.Schemata238.ReplaceNumericConstant_4(120L, 0);
                foreach (var formal in ctor.Formals)
                {
                    if (!formal.IsGhost)
                    {
                        argNames.Add(FormalName(formal, k));
                        MutateCSharp.Schemata238.ReplacePostfixUnaryExprOp_11(124L, ref k);
                    }
                }
                // datatype:
                //   static create_Ctor0(params) { let $dt = new Dt(tag); $dt.param0 = param0; ...; return $dt; }
                // codatatype:
                //   static create_Ctor0(params) { if ($dt === null) { $dt = new Dt(tag); $dt._d = $dt; } $dt.param0 = param0; ...; return $dt; }
                //   static lazy_Ctor0(initializer) { let dt = new Dt(tag); dt._initializer = initializer; return dt; }
                wr.Write($"static create_{ctor.GetCompileName(Options)}(");
                wr.Write(typeDescriptors);
                var sep = typeDescriptorComma;
                if (dt is CoDatatypeDecl)
                {
                    wr.Write($"{sep}$dt");
                    sep = MutateCSharp.Schemata238.ReplaceStringConstant_0(125L, ", ");
                }
                if (MutateCSharp.Schemata238.ReplaceBinExprOp_10(130L, argNames.Count, MutateCSharp.Schemata238.ReplaceNumericConstant_4(126L, 0)))
                {
                    wr.Write(sep);
                }
                wr.Write(Util.Comma(argNames, nm => nm));
                var w = wr.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(135L, ")"));
                if (dt is CoDatatypeDecl)
                {
                    var wThen = EmitIf(MutateCSharp.Schemata238.ReplaceStringConstant_0(136L, "$dt === null"), MutateCSharp.Schemata238.ReplaceBooleanConstant_1(137L, false), w);
                    wThen.WriteLine($"$dt = new {DtT_protected}({i}{typeDescriptorComma}{typeDescriptors});");
                    wThen.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(138L, "$dt._d = $dt;"));
                }
                else
                {
                    w.WriteLine($"let $dt = new {DtT_protected}({i}{typeDescriptorComma}{typeDescriptors});");
                }
                foreach (var arg in argNames)
                {
                    w.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(139L, "$dt.{0} = {0};"), arg);
                }
                w.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(140L, "return $dt;"));
                if (dt is CoDatatypeDecl)
                {
                    wBody = wr.NewNamedBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(141L, "static lazy_{0}(initializer)"), ctor.GetCompileName(Options));
                    wBody.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(142L, "let dt = new {0}({1});"), DtT_protected, i);
                    wBody.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(143L, "dt._initializer = initializer;"));
                    wBody.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(144L, "return dt;"));
                }

                MutateCSharp.Schemata238.ReplacePostfixUnaryExprOp_11(145L, ref i);
            }

            // query properties
            i = MutateCSharp.Schemata238.ReplaceNumericConstant_4(146L, 0);
            foreach (var ctor in dt.Ctors.Where(ctor => !ctor.IsGhost))
            {
                // get is_Ctor0() { return _D is Dt_Ctor0; }
                wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(150L, "get is_{0}() {{ return this.$tag === {1}; }}"), ctor.GetCompileName(Options), i);
                MutateCSharp.Schemata238.ReplacePostfixUnaryExprOp_11(151L, ref i);
            }

            if (dt.HasFinitePossibleValues)
            {
                Contract.Assert(dt.TypeArgs.Count == 0);
                {
                    var w = wr.NewNamedBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(152L, "static get AllSingletonConstructors()"));
                    w.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(153L, "return this.AllSingletonConstructors_();"));
                }
                {
                    var w = wr.NewNamedBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(154L, "static *AllSingletonConstructors_()"));
                    foreach (var ctor in dt.Ctors)
                    {
                        Contract.Assert(ctor.Formals.Count == 0);
                        if (ctor.IsGhost)
                        {
                            w.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(155L, "yield {0};"), ForcePlaceboValue(UserDefinedType.FromTopLevelDecl(dt.tok, dt), w, dt.tok));
                        }
                        else
                        {
                            w.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(156L, "yield {0}.create_{1}({2});"), DtT_protected, ctor.GetCompileName(Options), dt is CoDatatypeDecl ? MutateCSharp.Schemata238.ReplaceStringConstant_0(157L, "null") : "");
                        }
                    }
                }
            }

            // destructors
            foreach (var ctor in dt.Ctors)
            {
                foreach (var dtor in ctor.Destructors.Where(dtor => MutateCSharp.Schemata238.ReplaceBinExprOp_12(162L, dtor.EnclosingCtors[MutateCSharp.Schemata238.ReplaceNumericConstant_4(158L, 0)], ctor)))
                {
                    var compiledConstructorCount = dtor.EnclosingCtors.Count(constructor => !constructor.IsGhost);
                    if (MutateCSharp.Schemata238.ReplaceBinExprOp_10(167L, compiledConstructorCount, MutateCSharp.Schemata238.ReplaceNumericConstant_4(163L, 0)))
                    {
                        var arg = dtor.CorrespondingFormals[MutateCSharp.Schemata238.ReplaceNumericConstant_4(172L, 0)];
                        if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(176L, () => !arg.IsGhost, () => arg.HasName))
                        {
                            // datatype:   get dtor_Dtor0() { return this.Dtor0; }
                            // codatatype: get dtor_Dtor0() { return this._D().Dtor0; }
                            wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(182L, "get dtor_{0}() {{ return this{2}.{1}; }}"), arg.CompileName, IdName(arg), dt is CoDatatypeDecl ? MutateCSharp.Schemata238.ReplaceStringConstant_0(183L, "._D()") : "");
                        }
                    }
                }
            }

            if (dt is CoDatatypeDecl)
            {
                // toString method
                var w = wr.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(184L, "toString()"));
                i = MutateCSharp.Schemata238.ReplaceNumericConstant_4(185L, 0);
                foreach (var ctor in dt.Ctors)
                {
                    var thn = EmitIf(string.Format(MutateCSharp.Schemata238.ReplaceStringConstant_0(189L, "this.$tag === {0}"), i), MutateCSharp.Schemata238.ReplaceBooleanConstant_1(190L, true), w);
                    var nm = (dt.EnclosingModuleDefinition.TryToAvoidName ? "" : dt.EnclosingModuleDefinition.Name + MutateCSharp.Schemata238.ReplaceStringConstant_0(191L, ".")) +
                             dt.Name + MutateCSharp.Schemata238.ReplaceStringConstant_0(192L, ".") + ctor.Name;
                    thn.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(193L, "return \"{0}\";"), nm);
                    MutateCSharp.Schemata238.ReplacePostfixUnaryExprOp_11(194L, ref i);
                }
                var els = w.NewBlock("");
                els.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(195L, "return \"{0}.{1}.unexpected\";"), dt.EnclosingModuleDefinition.GetCompileName(Options), DtT);

            }
            else if (dt is IndDatatypeDecl)
            {
                // toString method
                var w = wr.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(196L, "toString()"));
                i = MutateCSharp.Schemata238.ReplaceNumericConstant_4(197L, 0);
                foreach (var ctor in dt.Ctors)
                {
                    var cw = EmitIf(string.Format(MutateCSharp.Schemata238.ReplaceStringConstant_0(201L, "this.$tag === {0}"), i), MutateCSharp.Schemata238.ReplaceBooleanConstant_1(202L, true), w);
                    var nm = (dt.EnclosingModuleDefinition.TryToAvoidName ? "" : dt.EnclosingModuleDefinition.Name + MutateCSharp.Schemata238.ReplaceStringConstant_0(203L, ".")) +
                             dt.Name + MutateCSharp.Schemata238.ReplaceStringConstant_0(204L, ".") + ctor.Name;
                    cw.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(205L, "return \"{0}\""), nm);
                    var sep = MutateCSharp.Schemata238.ReplaceStringConstant_0(206L, " + \"(\" + ");
                    var anyFormals = MutateCSharp.Schemata238.ReplaceBooleanConstant_1(207L, false);
                    var k = MutateCSharp.Schemata238.ReplaceNumericConstant_4(208L, 0);
                    foreach (var arg in ctor.Formals)
                    {
                        if (!arg.IsGhost)
                        {
                            anyFormals = MutateCSharp.Schemata238.ReplaceBooleanConstant_1(212L, true);
                            if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(213L, () => arg.Type.IsStringType, () => UnicodeCharEnabled))
                            {
                                cw.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(219L, "{0}this.{1}.toVerbatimString(true)"), sep, FormalName(arg, k));
                            }
                            else
                            {
                                cw.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(220L, "{0}_dafny.toString(this.{1})"), sep, FormalName(arg, k));
                            }

                            sep = MutateCSharp.Schemata238.ReplaceStringConstant_0(221L, " + \", \" + ");
                            MutateCSharp.Schemata238.ReplacePostfixUnaryExprOp_11(222L, ref k);
                        }
                    }

                    if (anyFormals)
                    {
                        cw.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(223L, " + \")\""));
                    }

                    cw.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(224L, ";"));
                    MutateCSharp.Schemata238.ReplacePostfixUnaryExprOp_11(225L, ref i);
                }

                var wElse = w.NewBlock("");
                wElse.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(226L, "return \"<unexpected>\";"));
            }

            // equals method
            {
                var w = wr.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(227L, "equals(other)"));
                {
                    var thn = EmitIf(MutateCSharp.Schemata238.ReplaceStringConstant_0(228L, "this === other"), MutateCSharp.Schemata238.ReplaceBooleanConstant_1(229L, true), w);
                    EmitReturnExpr(MutateCSharp.Schemata238.ReplaceStringConstant_0(230L, "true"), thn);
                }
                i = MutateCSharp.Schemata238.ReplaceNumericConstant_4(231L, 0);
                foreach (var ctor in dt.Ctors)
                {
                    var thn = EmitIf(string.Format(MutateCSharp.Schemata238.ReplaceStringConstant_0(235L, "this.$tag === {0}"), i), MutateCSharp.Schemata238.ReplaceBooleanConstant_1(236L, true), w);
                    var guard = EmitReturnExpr(thn);
                    guard.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(237L, "other.$tag === {0}"), i);
                    var k = MutateCSharp.Schemata238.ReplaceNumericConstant_4(238L, 0);
                    foreach (Formal arg in ctor.Formals)
                    {
                        if (!arg.IsGhost)
                        {
                            string nm = FormalName(arg, k);
                            if (IsDirectlyComparable(DatatypeWrapperEraser.SimplifyType(Options, arg.Type)))
                            {
                                guard.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(242L, " && this.{0} === other.{0}"), nm);
                            }
                            else
                            {
                                guard.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(243L, " && _dafny.areEqual(this.{0}, other.{0})"), nm);
                            }

                            MutateCSharp.Schemata238.ReplacePostfixUnaryExprOp_11(244L, ref k);
                        }
                    }

                    MutateCSharp.Schemata238.ReplacePostfixUnaryExprOp_11(245L, ref i);
                }
                var els = w.NewBlock("");
                els.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(246L, "return false; // unexpected"));
            }

            // static Default(defaultValues...) {  // where defaultValues are the parameters to the grounding constructor
            //   return Dt.create_GroundingCtor(defaultValues...);
            // }
            wr.Write($"static Default(");
            var usedTypeParameters = UsedTypeParameters(dt);
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(266L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_10(252L, WriteRuntimeTypeDescriptorsFormals(dt.TypeArgs, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(247L, false), wr), MutateCSharp.Schemata238.ReplaceNumericConstant_4(248L, 0)), () => MutateCSharp.Schemata238.ReplaceBinExprOp_10(261L, usedTypeParameters.Count, MutateCSharp.Schemata238.ReplaceNumericConstant_4(257L, 0))))
            {
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(272L, ", "));
            }
            wr.Write(usedTypeParameters.Comma(FormatDefaultTypeParameterValue));
            {
                var wDefault = wr.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(273L, ")"));
                wDefault.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(274L, "return "));
                var groundingCtor = dt.GetGroundingCtor();
                if (groundingCtor.IsGhost)
                {
                    wDefault.Write(ForcePlaceboValue(simplifiedType, wDefault, dt.tok));
                }
                else if (DatatypeWrapperEraser.GetInnerTypeOfErasableDatatypeWrapper(Options, dt, out var innerType))
                {
                    wDefault.Write(DefaultValue(innerType, wDefault, dt.tok));
                }
                else
                {
                    var nonGhostFormals = groundingCtor.Formals.Where(f => !f.IsGhost).ToList();
                    var arguments = nonGhostFormals.Comma(f => DefaultValue(f.Type, wDefault, f.tok));
                    EmitDatatypeValue(dt, groundingCtor, dt is CoDatatypeDecl, typeDescriptors, arguments, wDefault);
                }
                wDefault.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(275L, ";"));
            }

            // Note: It is important that the following be a class with a static getter Default(), as opposed
            // to a simple "{ Default: ... }" object, because we need for any recursive calls in the default
            // expression to be evaluated lazily. (More precisely, not evaluated at all, but that will sort
            // itself out due to the restrictions placed by the resolver.)
            //
            // static Rtd(rtd...) {
            //   return class {
            //     static get Default() { return Dt.create_CtorK(...); }
            //   };
            // }
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(276L, "static Rtd("));
            WriteRuntimeTypeDescriptorsFormals(UsedTypeParameters(dt, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(277L, true)), MutateCSharp.Schemata238.ReplaceBooleanConstant_1(278L, true), wr);
            var wRtd = wr.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(279L, ")"));
            var wClass = wRtd.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(280L, "return class"), MutateCSharp.Schemata238.ReplaceStringConstant_0(281L, ";"));
            {
                var wDefault = wClass.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(282L, "static get Default()"));
                var sep = MutateCSharp.Schemata238.ReplaceBinExprOp_7(301L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_10(287L, typeDescriptors.Length, MutateCSharp.Schemata238.ReplaceNumericConstant_4(283L, 0)), () => MutateCSharp.Schemata238.ReplaceBinExprOp_10(296L, usedTypeParameters.Count, MutateCSharp.Schemata238.ReplaceNumericConstant_4(292L, 0))) ? MutateCSharp.Schemata238.ReplaceStringConstant_0(307L, ", ") : "";
                var arguments = usedTypeParameters.Comma(
                  tp => DefaultValue(new UserDefinedType(tp), wDefault, dt.tok, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(308L, true)));
                wDefault.WriteLine($"return {DtT_protected}.Default({typeDescriptors}{typeDescriptorComma}{arguments});");
            }

            return new ClassWriter(this, btw, btw);
        }

        protected override IClassWriter DeclareNewtype(NewtypeDecl nt, ConcreteSyntaxTree wr)
        {
            var cw = (ClassWriter)CreateClass(IdProtect(nt.EnclosingModuleDefinition.GetCompileName(Options)), IdName(nt), nt, wr);
            var w = cw.MethodWriter;
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_13(309L, nt.NativeType, null))
            {
                var wIntegerRangeBody = w.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(310L, "static *IntegerRange(lo, hi)"));
                var wLoopBody = wIntegerRangeBody.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(311L, "while (lo.isLessThan(hi))"));
                wLoopBody.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(312L, "yield lo.toNumber();"));
                EmitIncrementVar(MutateCSharp.Schemata238.ReplaceStringConstant_0(313L, "lo"), wLoopBody);
            }
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_14(314L, nt.WitnessKind, SubsetTypeDecl.WKind.Compiled))
            {
                var witness = new ConcreteSyntaxTree(w.RelativeIndentLevel);
                var wStmts = w.Fork();
                if (MutateCSharp.Schemata238.ReplaceBinExprOp_15(315L, nt.NativeType, null))
                {
                    witness.Append(Expr(nt.Witness, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(316L, false), wStmts));
                }
                else
                {
                    TrParenExpr(nt.Witness, witness, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(317L, false), wStmts);
                    witness.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(318L, ".toNumber()"));
                }
                DeclareField(MutateCSharp.Schemata238.ReplaceStringConstant_0(319L, "Witness"), MutateCSharp.Schemata238.ReplaceBooleanConstant_1(320L, true), MutateCSharp.Schemata238.ReplaceBooleanConstant_1(321L, true), nt.BaseType, nt.tok, witness.ToString(), w);
            }
            // In JavaScript, the companion class of a newtype (which is what is being declared here) doubles as a
            // type descriptor for the newtype. The Default() method for that type descriptor is declared here.
            var wDefault = w.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(322L, "static get Default()"));
            var udt = new UserDefinedType(nt.tok, nt.Name, nt, new List<Type>());
            var d = TypeInitializationValue(udt, wr, nt.tok, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(323L, false), MutateCSharp.Schemata238.ReplaceBooleanConstant_1(324L, false));
            wDefault.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(325L, "return {0};"), d);

            GenerateIsMethod(nt, cw.MethodWriter);

            if (MutateCSharp.Schemata238.ReplaceBinExprOp_10(330L, nt.ParentTraits.Count, MutateCSharp.Schemata238.ReplaceNumericConstant_4(326L, 0)))
            {
                // in constructor:
                //   this._value = value;
                cw.FieldWriter.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(335L, "this._value = value;"));

                // toString() {
                //   return _dafny.toString(this._value)
                // }
                var wBody = cw.MethodWriter.NewNamedBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(336L, "toString()"));
                wBody.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(337L, "return _dafny.toString(this._value)"));
            }

            return cw;
        }

        void GenerateIsMethod(RedirectingTypeDecl declWithConstraints, ConcreteSyntaxTree wr)
        {
            Contract.Requires(declWithConstraints is SubsetTypeDecl or NewtypeDecl);

            if (declWithConstraints.ConstraintIsCompilable)
            {
                var type = UserDefinedType.FromTopLevelDecl(declWithConstraints.tok, (TopLevelDecl)declWithConstraints);

                wr.Write($"static {IsMethodName}(");

                var count = WriteRuntimeTypeDescriptorsFormals(declWithConstraints.TypeArgs, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(338L, false), wr);
                if (MutateCSharp.Schemata238.ReplaceBinExprOp_10(343L, count, MutateCSharp.Schemata238.ReplaceNumericConstant_4(339L, 0)))
                {
                    wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(348L, ", "));
                }

                var sourceFormal = new Formal(declWithConstraints.tok, MutateCSharp.Schemata238.ReplaceStringConstant_0(349L, "_source"), type, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(350L, true), MutateCSharp.Schemata238.ReplaceBooleanConstant_1(351L, false), null);
                var wrBody = wr.NewBlock($"{IdName(sourceFormal)})");
                GenerateIsMethodBody(declWithConstraints, sourceFormal, wrBody);
            }
        }

        protected override void DeclareSubsetType(SubsetTypeDecl sst, ConcreteSyntaxTree wr)
        {
            var cw = (ClassWriter)CreateClass(IdProtect(sst.EnclosingModuleDefinition.GetCompileName(Options)), IdName(sst), sst, wr);
            var w = cw.MethodWriter;
            var udt = UserDefinedType.FromTopLevelDecl(sst.tok, sst);
            string d;
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_14(352L, sst.WitnessKind, SubsetTypeDecl.WKind.Compiled))
            {
                var sw = new ConcreteSyntaxTree(w.RelativeIndentLevel);
                var wStmts = w.Fork();
                sw.Append(Expr(sst.Witness, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(353L, false), wStmts));
                DeclareField(MutateCSharp.Schemata238.ReplaceStringConstant_0(354L, "Witness"), MutateCSharp.Schemata238.ReplaceBooleanConstant_1(355L, true), MutateCSharp.Schemata238.ReplaceBooleanConstant_1(356L, true), sst.Rhs, sst.tok, sw.ToString(), w);
                d = TypeName_UDT(FullTypeName(udt), udt, wr, udt.tok) + MutateCSharp.Schemata238.ReplaceStringConstant_0(357L, ".Witness");
            }
            else
            {
                d = TypeInitializationValue(udt, wr, sst.tok, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(358L, false), MutateCSharp.Schemata238.ReplaceBooleanConstant_1(359L, false));
            }
            w.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(360L, "static get Default()")).WriteLine($"return {d};");

            GenerateIsMethod(sst, cw.MethodWriter);
        }

        protected override void GetNativeInfo(NativeType.Selection sel, out string name, out string literalSuffix, out bool needsCastAfterArithmetic)
        {
            literalSuffix = "";
            needsCastAfterArithmetic = MutateCSharp.Schemata238.ReplaceBooleanConstant_1(361L, false);
            switch (sel)
            {
                case NativeType.Selection.Number:
                    name = "number";
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
            public readonly JavaScriptCodeGenerator CodeGenerator;
            public readonly ConcreteSyntaxTree MethodWriter;
            public readonly ConcreteSyntaxTree FieldWriter;

            public ClassWriter(JavaScriptCodeGenerator codeGenerator, ConcreteSyntaxTree methodWriter, ConcreteSyntaxTree fieldWriter)
            {
                Contract.Requires(codeGenerator != null);
                Contract.Requires(methodWriter != null);
                Contract.Requires(fieldWriter != null);
                this.CodeGenerator = codeGenerator;
                this.MethodWriter = methodWriter;
                this.FieldWriter = fieldWriter;
            }

            public ConcreteSyntaxTree/*?*/ CreateMethod(Method m, List<TypeArgumentInstantiation> typeArgs, bool createBody, bool forBodyInheritance, bool lookasideBody)
            {
                return CodeGenerator.CreateMethod(m, typeArgs, createBody, MethodWriter, forBodyInheritance, lookasideBody);
            }

            public ConcreteSyntaxTree SynthesizeMethod(Method m, List<TypeArgumentInstantiation> typeArgs, bool createBody, bool forBodyInheritance, bool lookasideBody)
            {
                throw new UnsupportedFeatureException(m.tok, Feature.MethodSynthesis);
                return default;
            }

            public ConcreteSyntaxTree/*?*/ CreateFunction(string name, List<TypeArgumentInstantiation> typeArgs, List<Formal> formals, Type resultType, IToken tok, bool isStatic, bool createBody, MemberDecl member, bool forBodyInheritance, bool lookasideBody)
            {
                return CodeGenerator.CreateFunction(name, typeArgs, formals, resultType, tok, isStatic, createBody, member, MethodWriter, forBodyInheritance, lookasideBody);
            }
            public ConcreteSyntaxTree/*?*/ CreateGetter(string name, TopLevelDecl enclosingDecl, Type resultType, IToken tok, bool isStatic, bool isConst, bool createBody, MemberDecl/*?*/ member, bool forBodyInheritance)
            {
                return CodeGenerator.CreateGetter(name, resultType, tok, isStatic, createBody, MethodWriter);
            }
            public ConcreteSyntaxTree/*?*/ CreateGetterSetter(string name, Type resultType, IToken tok, bool createBody, MemberDecl/*?*/ member, out ConcreteSyntaxTree setterWriter, bool forBodyInheritance)
            {
                return CodeGenerator.CreateGetterSetter(name, resultType, tok, createBody, out setterWriter, MethodWriter);
            }
            public void DeclareField(string name, TopLevelDecl enclosingDecl, bool isStatic, bool isConst, Type type, IToken tok, string rhs, Field field)
            {
                CodeGenerator.DeclareField(name, isStatic, isConst, type, tok, rhs, FieldWriter);
            }
            public void InitializeField(Field field, Type instantiatedFieldType, TopLevelDeclWithMembers enclosingClass)
            {
                throw new cce.UnreachableException();  // InitializeField should be called only for those compilers that set ClassesRedeclareInheritedFields to false.
            }
            public ConcreteSyntaxTree/*?*/ ErrorWriter() => MethodWriter;
            public void Finish() { }
        }

        protected override bool SupportsStaticsInGenericClasses => MutateCSharp.Schemata238.ReplaceBooleanConstant_1(362L, false);

        protected ConcreteSyntaxTree/*?*/ CreateMethod(Method m, List<TypeArgumentInstantiation> typeArgs, bool createBody, ConcreteSyntaxTree wr, bool forBodyInheritance, bool lookasideBody)
        {
            if (!createBody)
            {
                return null;
            }

            var customReceiver = MutateCSharp.Schemata238.ReplaceBinExprOp_7(363L, () => !forBodyInheritance, () => NeedsCustomReceiver(m));
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(369L, "{0}{1}("), MutateCSharp.Schemata238.ReplaceBinExprOp_3(370L, () => m.IsStatic, () => customReceiver) ? MutateCSharp.Schemata238.ReplaceStringConstant_0(376L, "static ") : "", IdName(m));
            var sep = "";
            WriteRuntimeTypeDescriptorsFormals(ForTypeDescriptors(typeArgs, m.EnclosingClass, m, lookasideBody), wr, ref sep, tp => $"rtd$_{tp.GetCompileName(Options)}");
            if (customReceiver)
            {
                var nt = m.EnclosingClass;
                var receiverType = UserDefinedType.FromTopLevelDecl(m.tok, nt);
                DeclareFormal(sep, MutateCSharp.Schemata238.ReplaceStringConstant_0(377L, "_this"), receiverType, m.tok, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(378L, true), wr);
                sep = MutateCSharp.Schemata238.ReplaceStringConstant_0(379L, ", ");
            }
            WriteFormals(sep, m.Ins, wr);
            var w = wr.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(380L, ")"));

            if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(381L, () => !m.IsStatic, () => !customReceiver))
            {
                w.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(387L, "let _this = this;"));
            }
            return w;
        }

        protected override ConcreteSyntaxTree EmitMethodReturns(Method m, ConcreteSyntaxTree wr)
        {
            var beforeReturnBlock = wr.Fork(MutateCSharp.Schemata238.ReplaceNumericConstant_4(388L, 0));
            EmitReturn(m.Outs, wr);
            return beforeReturnBlock;
        }

        protected ConcreteSyntaxTree/*?*/ CreateFunction(string name, List<TypeArgumentInstantiation> typeArgs, List<Formal> formals, Type resultType, IToken tok, bool isStatic, bool createBody, MemberDecl member, ConcreteSyntaxTree wr, bool forBodyInheritance, bool lookasideBody)
        {
            if (!createBody)
            {
                return null;
            }

            var customReceiver = MutateCSharp.Schemata238.ReplaceBinExprOp_7(392L, () => !forBodyInheritance, () => NeedsCustomReceiver(member));
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(398L, "{0}{1}("), MutateCSharp.Schemata238.ReplaceBinExprOp_3(399L, () => isStatic, () => customReceiver) ? MutateCSharp.Schemata238.ReplaceStringConstant_0(405L, "static ") : "", name);
            var sep = "";
            WriteRuntimeTypeDescriptorsFormals(ForTypeDescriptors(typeArgs, member.EnclosingClass, member, lookasideBody), wr, ref sep,
              tp => $"rtd$_{tp.GetCompileName(Options)}");
            if (customReceiver)
            {
                var nt = member.EnclosingClass;
                var receiverType = UserDefinedType.FromTopLevelDecl(tok, nt);
                DeclareFormal(sep, MutateCSharp.Schemata238.ReplaceStringConstant_0(406L, "_this"), receiverType, tok, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(407L, true), wr);
                sep = MutateCSharp.Schemata238.ReplaceStringConstant_0(408L, ", ");
            }
            WriteFormals(sep, formals, wr);
            var w = wr.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(409L, ")"), MutateCSharp.Schemata238.ReplaceStringConstant_0(410L, ";"));
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(411L, () => !isStatic, () => !customReceiver))
            {
                w.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(417L, "let _this = this;"));
            }
            return w;
        }

        int WriteRuntimeTypeDescriptorsFormals(List<TypeParameter> typeParams, bool useAllTypeArgs, ConcreteSyntaxTree wr, string prefix = "")
        {
            Contract.Requires(typeParams != null);
            Contract.Requires(wr != null);

            int c = MutateCSharp.Schemata238.ReplaceNumericConstant_4(418L, 0);
            foreach (var tp in typeParams)
            {
                if (MutateCSharp.Schemata238.ReplaceBinExprOp_3(422L, () => useAllTypeArgs, () => NeedsTypeDescriptor(tp)))
                {
                    wr.Write($"{prefix}rtd$_{tp.GetCompileName(Options)}");
                    prefix = MutateCSharp.Schemata238.ReplaceStringConstant_0(428L, ", ");
                    MutateCSharp.Schemata238.ReplacePostfixUnaryExprOp_11(429L, ref c);
                }
            }
            return c;
        }

        protected override void TypeArgDescriptorUse(bool isStatic, bool lookasideBody, TopLevelDeclWithMembers cl, out bool needsTypeParameter, out bool needsTypeDescriptor)
        {
            if (cl is DatatypeDecl)
            {
                needsTypeParameter = MutateCSharp.Schemata238.ReplaceBooleanConstant_1(430L, false);
                needsTypeDescriptor = MutateCSharp.Schemata238.ReplaceBooleanConstant_1(431L, true);
            }
            else if (cl is TraitDecl)
            {
                needsTypeParameter = MutateCSharp.Schemata238.ReplaceBooleanConstant_1(432L, false);
                needsTypeDescriptor = MutateCSharp.Schemata238.ReplaceBinExprOp_3(433L, () => isStatic, () => lookasideBody);
            }
            else
            {
                Contract.Assert(cl is ClassDecl);
                needsTypeParameter = MutateCSharp.Schemata238.ReplaceBooleanConstant_1(439L, false);
                needsTypeDescriptor = isStatic;
            }
        }

        protected override string TypeDescriptor(Type type, ConcreteSyntaxTree wr, IToken tok)
        {
            Contract.Requires(type != null);
            Contract.Requires(tok != null);
            Contract.Requires(wr != null);

            var xType = DatatypeWrapperEraser.SimplifyTypeAndTrimSubsetTypes(Options, type);
            if (xType is BoolType)
            {
                return MutateCSharp.Schemata238.ReplaceStringConstant_0(440L, "_dafny.Rtd_bool");
            }
            else if (xType is CharType)
            {
                return UnicodeCharEnabled ? MutateCSharp.Schemata238.ReplaceStringConstant_0(441L, "_dafny.Rtd_codepoint") : MutateCSharp.Schemata238.ReplaceStringConstant_0(442L, "_dafny.Rtd_char");
            }
            else if (xType is IntType)
            {
                return MutateCSharp.Schemata238.ReplaceStringConstant_0(443L, "_dafny.Rtd_int");
            }
            else if (xType is BigOrdinalType)
            {
                return MutateCSharp.Schemata238.ReplaceStringConstant_0(444L, "_dafny.BigOrdinal");
            }
            else if (xType is RealType)
            {
                return MutateCSharp.Schemata238.ReplaceStringConstant_0(445L, "_dafny.BigRational");
            }
            else if (xType is BitvectorType)
            {
                var t = (BitvectorType)xType;
                if (MutateCSharp.Schemata238.ReplaceBinExprOp_13(446L, t.NativeType, null))
                {
                    return MutateCSharp.Schemata238.ReplaceStringConstant_0(447L, "_dafny.Rtd_number");
                }
                else
                {
                    return MutateCSharp.Schemata238.ReplaceStringConstant_0(448L, "_dafny.Rtd_int");
                }
            }
            else if (xType is SetType)
            {
                return DafnySetClass;
            }
            else if (xType is MultiSetType)
            {
                return DafnyMultiSetClass;
            }
            else if (xType is SeqType)
            {
                return DafnySeqClass;
            }
            else if (xType is MapType)
            {
                return DafnyMapClass;
            }
            else if (xType.IsBuiltinArrowType)
            {
                return MutateCSharp.Schemata238.ReplaceStringConstant_0(449L, "_dafny.Rtd_ref");  // null suffices as a default value, since the function will never be called
            }
            else if (xType is UserDefinedType)
            {
                var udt = (UserDefinedType)xType;
                if (udt.ResolvedClass is TypeParameter tp)
                {
                    var receiver = MutateCSharp.Schemata238.ReplaceBinExprOp_7(451L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_16(450L, thisContext, null), () => tp.Parent is TopLevelDeclWithMembers and not TraitDecl) ? MutateCSharp.Schemata238.ReplaceStringConstant_0(457L, "this.") : "";
                    return string.Format($"{receiver}rtd$_{tp.GetCompileName(Options)}");
                }
                var cl = udt.ResolvedClass;
                Contract.Assert(cl != null);
                if (cl is ClassLikeDecl)
                {
                    return MutateCSharp.Schemata238.ReplaceStringConstant_0(458L, "_dafny.Rtd_ref");
                }
                else if (cl is DatatypeDecl)
                {
                    var dt = (DatatypeDecl)cl;
                    var w = new ConcreteSyntaxTree();
                    w.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(459L, "{0}.Rtd("), dt is TupleTypeDecl ? MutateCSharp.Schemata238.ReplaceStringConstant_0(460L, "_dafny.Tuple") : FullTypeName(udt));
                    EmitTypeDescriptorsActuals(UsedTypeParameters(dt, udt.TypeArgs, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(461L, true)), udt.tok, w, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(462L, true));
                    w.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(463L, ")"));
                    return w.ToString();
                }
                else if (xType.IsNonNullRefType)
                {
                    // what we emit here will only be used to construct a dummy value that programmer-supplied code will overwrite later
                    return MutateCSharp.Schemata238.ReplaceStringConstant_0(464L, "_dafny.Rtd_ref/*not used*/");
                }
                else
                {
                    Contract.Assert(cl is NewtypeDecl || cl is SubsetTypeDecl);
                    return TypeName_UDT(FullTypeName(udt), udt, wr, udt.tok);
                }
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected type
            }

            return default;
        }

        protected ConcreteSyntaxTree/*?*/ CreateGetter(string name, Type resultType, IToken tok, bool isStatic, bool createBody, ConcreteSyntaxTree wr)
        {
            if (createBody)
            {
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(465L, "{0}get {1}()"), isStatic ? MutateCSharp.Schemata238.ReplaceStringConstant_0(466L, "static ") : "", name);
                var w = wr.NewBlock("", MutateCSharp.Schemata238.ReplaceStringConstant_0(467L, ";"));
                if (!isStatic)
                {
                    w.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(468L, "let _this = this;"));
                }
                return w;
            }
            else
            {
                return null;
            }

            return default;
        }

        protected ConcreteSyntaxTree/*?*/ CreateGetterSetter(string name, Type resultType, IToken tok, bool createBody, out ConcreteSyntaxTree setterWriter, ConcreteSyntaxTree wr)
        {
            if (createBody)
            {
                wr.Write($"get {name}()");
                var wGet = wr.NewBlock("", MutateCSharp.Schemata238.ReplaceStringConstant_0(469L, ";"));
                wGet.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(470L, "let _this = this;"));

                wr.Write($"set {name}(value)");
                var wSet = wr.NewBlock("", MutateCSharp.Schemata238.ReplaceStringConstant_0(471L, ";"));
                wSet.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(472L, "let _this = this;"));

                setterWriter = wSet;
                return wGet;
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
            var block = wr.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(473L, "TAIL_CALL_START: while (true)"));
            if (member is Method m)
            {
                var beforeReturnBlock = block.Fork(MutateCSharp.Schemata238.ReplaceNumericConstant_4(474L, 0));
                EmitReturn(m.Outs, block);
                return beforeReturnBlock;
            }
            return block;
        }

        protected override void EmitJumpToTailCallStart(ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(478L, "continue TAIL_CALL_START;"));
        }

        private string CharFromNumberMethodName()
        {
            return UnicodeCharEnabled ? MutateCSharp.Schemata238.ReplaceStringConstant_0(479L, "new _dafny.CodePoint") : MutateCSharp.Schemata238.ReplaceStringConstant_0(480L, "String.fromCharCode");
        }

        internal override string TypeName(Type type, ConcreteSyntaxTree wr, IToken tok, MemberDecl /*?*/ member = null)
        {
            Contract.Ensures(Contract.Result<string>() != null);
            Contract.Assume(type != null);  // precondition; this ought to be declared as a Requires in the superclass

            var xType = DatatypeWrapperEraser.SimplifyType(Options, type);
            if (xType is BoolType)
            {
                return MutateCSharp.Schemata238.ReplaceStringConstant_0(481L, "bool");
            }
            else if (xType is CharType)
            {
                return MutateCSharp.Schemata238.ReplaceStringConstant_0(482L, "char");
            }
            else if (MutateCSharp.Schemata238.ReplaceBinExprOp_3(483L, () => xType is IntType, () => xType is BigOrdinalType))
            {
                return MutateCSharp.Schemata238.ReplaceStringConstant_0(489L, "BigNumber");
            }
            else if (xType is RealType)
            {
                return MutateCSharp.Schemata238.ReplaceStringConstant_0(490L, "Dafny.BigRational");
            }
            else if (xType is BitvectorType)
            {
                var t = (BitvectorType)xType;
                return MutateCSharp.Schemata238.ReplaceBinExprOp_13(491L, t.NativeType, null) ? GetNativeTypeName(t.NativeType) : MutateCSharp.Schemata238.ReplaceStringConstant_0(492L, "BigNumber");
            }
            else if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(495L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_17(493L, xType.AsNewtype, null), () => MutateCSharp.Schemata238.ReplaceBinExprOp_18(494L, member, null)))
            {  // when member is given, use UserDefinedType case below
                NativeType nativeType = xType.AsNewtype.NativeType;
                if (MutateCSharp.Schemata238.ReplaceBinExprOp_13(501L, nativeType, null))
                {
                    return GetNativeTypeName(nativeType);
                }
                return TypeName(xType.AsNewtype.BaseType, wr, tok);
            }
            else if (xType.IsObjectQ)
            {
                return MutateCSharp.Schemata238.ReplaceStringConstant_0(502L, "object");
            }
            else if (xType.IsArrayType)
            {
                return MutateCSharp.Schemata238.ReplaceStringConstant_0(503L, "Array");
            }
            else if (xType is UserDefinedType udt)
            {
                var s = FullTypeName(udt, member);
                return TypeName_UDT(s, udt, wr, udt.tok);
            }
            else if (xType is SetType)
            {
                Type argType = ((SetType)xType).Arg;
                return DafnySetClass;
            }
            else if (xType is SeqType)
            {
                Type argType = ((SeqType)xType).Arg;
                return DafnySeqClass;
            }
            else if (xType is MultiSetType)
            {
                Type argType = ((MultiSetType)xType).Arg;
                return DafnyMultiSetClass;
            }
            else if (xType is MapType)
            {
                return DafnyMapClass;
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected type
            }

            return default;
        }

        protected override string TypeInitializationValue(Type type, ConcreteSyntaxTree wr, IToken tok, bool usePlaceboValue, bool constructTypeParameterDefaultsFromTypeDescriptors)
        {
            if (usePlaceboValue)
            {
                return MutateCSharp.Schemata238.ReplaceStringConstant_0(504L, "undefined");
            }

            var xType = type.NormalizeExpandKeepConstraints();

            if (xType is BoolType)
            {
                return MutateCSharp.Schemata238.ReplaceStringConstant_0(505L, "false");
            }
            else if (xType is CharType)
            {
                return $"{CharFromNumberMethodName()}({CharType.DefaultValueAsString}.codePointAt(0))";
            }
            else if (MutateCSharp.Schemata238.ReplaceBinExprOp_3(506L, () => xType is IntType, () => xType is BigOrdinalType))
            {
                return IntegerLiteral(0);
            }
            else if (xType is RealType)
            {
                return MutateCSharp.Schemata238.ReplaceStringConstant_0(512L, "_dafny.BigRational.ZERO");
            }
            else if (xType is BitvectorType)
            {
                var t = (BitvectorType)xType;
                return MutateCSharp.Schemata238.ReplaceBinExprOp_13(513L, t.NativeType, null) ? MutateCSharp.Schemata238.ReplaceStringConstant_0(514L, "0") : IntegerLiteral(0);
            }
            else if (xType is SetType)
            {
                return $"{DafnySetClass}.Empty";
            }
            else if (xType is MultiSetType)
            {
                return $"{DafnyMultiSetClass}.Empty";
            }
            else if (xType is SeqType seq)
            {
                if (seq.Arg.IsCharType)
                {
                    if (UnicodeCharEnabled)
                    {
                        return MutateCSharp.Schemata238.ReplaceStringConstant_0(515L, "_dafny.Seq.UnicodeFromString(\"\")");
                    }
                    else
                    {
                        return MutateCSharp.Schemata238.ReplaceStringConstant_0(516L, "\"\"");
                    }
                }
                return $"{DafnySeqClass}.of()";
            }
            else if (xType is MapType)
            {
                return $"{DafnyMapClass}.Empty";
            }

            var udt = (UserDefinedType)xType;
            var cl = udt.ResolvedClass;
            Contract.Assert(cl != null);
            if (cl is TypeParameter)
            {
                if (constructTypeParameterDefaultsFromTypeDescriptors)
                {
                    return string.Format(MutateCSharp.Schemata238.ReplaceStringConstant_0(517L, "{0}.Default"), TypeDescriptor(udt, wr, udt.tok));
                }
                else
                {
                    return FormatDefaultTypeParameterValue((TypeParameter)udt.ResolvedClass);
                }
            }
            else if (cl is AbstractTypeDecl opaque)
            {
                return FormatDefaultTypeParameterValue(opaque);
            }
            else if (cl is NewtypeDecl)
            {
                var td = (NewtypeDecl)cl;
                if (MutateCSharp.Schemata238.ReplaceBinExprOp_19(518L, td.Witness, null))
                {
                    return TypeName_UDT(FullTypeName(udt), udt, wr, udt.tok) + MutateCSharp.Schemata238.ReplaceStringConstant_0(519L, ".Witness");
                }
                else if (MutateCSharp.Schemata238.ReplaceBinExprOp_13(520L, td.NativeType, null))
                {
                    return MutateCSharp.Schemata238.ReplaceStringConstant_0(521L, "0");
                }
                else
                {
                    return TypeInitializationValue(td.BaseType, wr, tok, usePlaceboValue, constructTypeParameterDefaultsFromTypeDescriptors);
                }
            }
            else if (cl is SubsetTypeDecl)
            {
                var td = (SubsetTypeDecl)cl;
                if (MutateCSharp.Schemata238.ReplaceBinExprOp_14(522L, td.WitnessKind, SubsetTypeDecl.WKind.Compiled))
                {
                    return TypeName_UDT(FullTypeName(udt), udt, wr, udt.tok) + MutateCSharp.Schemata238.ReplaceStringConstant_0(523L, ".Default");
                }
                else if (MutateCSharp.Schemata238.ReplaceBinExprOp_14(524L, td.WitnessKind, SubsetTypeDecl.WKind.Special))
                {
                    // WKind.Special is only used with -->, ->, and non-null types:
                    Contract.Assert(ArrowType.IsPartialArrowTypeName(td.Name) || ArrowType.IsTotalArrowTypeName(td.Name) || td is NonNullTypeDecl);
                    if (ArrowType.IsPartialArrowTypeName(td.Name))
                    {
                        return MutateCSharp.Schemata238.ReplaceStringConstant_0(525L, "null");
                    }
                    else if (ArrowType.IsTotalArrowTypeName(td.Name))
                    {
                        var rangeDefaultValue = TypeInitializationValue(udt.TypeArgs.Last(), wr, tok, usePlaceboValue, constructTypeParameterDefaultsFromTypeDescriptors);
                        // return the lambda expression ((Ty0 x0, Ty1 x1, Ty2 x2) => rangeDefaultValue)
                        return string.Format(MutateCSharp.Schemata238.ReplaceStringConstant_0(526L, "function () {{ return {0}; }}"), rangeDefaultValue);
                    }
                    else if (((NonNullTypeDecl)td).Class is ArrayClassDecl)
                    {
                        // non-null array type; we know how to initialize them
                        var arrayClass = (ArrayClassDecl)((NonNullTypeDecl)td).Class;
                        if (MutateCSharp.Schemata238.ReplaceBinExprOp_20(531L, arrayClass.Dims, MutateCSharp.Schemata238.ReplaceNumericConstant_4(527L, 1)))
                        {
                            return MutateCSharp.Schemata238.ReplaceStringConstant_0(536L, "[]");
                        }
                        else
                        {
                            return string.Format(MutateCSharp.Schemata238.ReplaceStringConstant_0(537L, "_dafny.newArray(undefined, {0})"), Util.Comma(arrayClass.Dims, _ => MutateCSharp.Schemata238.ReplaceStringConstant_0(538L, "_dafny.ZERO")));
                        }
                    }
                    else
                    {
                        // non-null (non-array) type
                        // even though the type doesn't necessarily have a known initializer, it could be that the the compiler needs to
                        // lay down some bits to please the C#'s compiler's different definite-assignment rules.
                        return MutateCSharp.Schemata238.ReplaceStringConstant_0(539L, "null");
                    }
                }
                else
                {
                    return TypeInitializationValue(td.RhsWithArgument(udt.TypeArgs), wr, tok, usePlaceboValue, constructTypeParameterDefaultsFromTypeDescriptors);
                }
            }
            else if (cl is ClassLikeDecl or ArrowTypeDecl)
            {
                return MutateCSharp.Schemata238.ReplaceStringConstant_0(540L, "null");
            }
            else if (cl is DatatypeDecl)
            {
                var dt = (DatatypeDecl)cl;
                var s = dt is TupleTypeDecl ? MutateCSharp.Schemata238.ReplaceStringConstant_0(541L, "_dafny.Tuple") : FullTypeName(udt);
                var relevantTypeArgs = UsedTypeParameters(dt, udt.TypeArgs).ConvertAll(ta => ta.Actual);

                var wTypeDescriptors = new ConcreteSyntaxTree();
                EmitTypeDescriptorsActuals(TypeArgumentInstantiation.ListFromClass(dt, udt.TypeArgs), tok, wTypeDescriptors);
                var typeDescriptors = wTypeDescriptors.ToString();

                var sep = MutateCSharp.Schemata238.ReplaceBinExprOp_7(560L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_10(546L, typeDescriptors.Length, MutateCSharp.Schemata238.ReplaceNumericConstant_4(542L, 0)), () => MutateCSharp.Schemata238.ReplaceBinExprOp_10(555L, relevantTypeArgs.Count, MutateCSharp.Schemata238.ReplaceNumericConstant_4(551L, 0))) ? MutateCSharp.Schemata238.ReplaceStringConstant_0(566L, ", ") : "";
                var arguments = relevantTypeArgs.Comma(arg => DefaultValue(arg, wr, tok, constructTypeParameterDefaultsFromTypeDescriptors));
                return string.Format($"{s}.Default({typeDescriptors}{sep}{arguments})");
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected type
            }

            return default;
        }

        protected override string TypeName_UDT(string fullCompileName, List<TypeParameter.TPVariance> variance, List<Type> typeArgs,
          ConcreteSyntaxTree wr, IToken tok, bool omitTypeArguments)
        {
            Contract.Assume(fullCompileName != null);  // precondition; this ought to be declared as a Requires in the superclass
            Contract.Assume(typeArgs != null);  // precondition; this ought to be declared as a Requires in the superclass
            string s = IdProtect(fullCompileName);
            return s;
        }

        protected override string TypeName_Companion(Type type, ConcreteSyntaxTree wr, IToken tok, MemberDecl/*?*/ member)
        {
            // Many (that is, more so than in C# or Java) companion classes in JavaScript are just the same as the type
            type = UserDefinedType.UpcastToMemberEnclosingType(type, member);
            if (type.NormalizeExpandKeepConstraints() is UserDefinedType udt)
            {
                if ((udt.ResolvedClass is DatatypeDecl dt && DatatypeWrapperEraser.IsErasableDatatypeWrapper(Options, dt, out _)) ||
                    udt.ResolvedClass is SubsetTypeDecl or NewtypeDecl)
                {
                    var s = FullTypeName(udt, member);
                    return TypeName_UDT(s, udt, wr, udt.tok);
                }
            }

            return TypeName(type, wr, tok, member);
        }

        // ----- Declarations -------------------------------------------------------------

        protected void DeclareField(string name, bool isStatic, bool isConst, Type type, IToken tok, string rhs, ConcreteSyntaxTree wr)
        {
            if (isStatic)
            {
                var w = wr.NewNamedBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(567L, "static get {0}()"), name);
                EmitReturnExpr(rhs, w);
            }
            else
            {
                wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(568L, "this.{0} = {1};"), name, rhs);
            }
        }

        protected override bool DeclareFormal(string prefix, string name, Type type, IToken tok, bool isInParam, ConcreteSyntaxTree wr)
        {
            if (isInParam)
            {
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(569L, "{0}{1}"), prefix, name);
                return MutateCSharp.Schemata238.ReplaceBooleanConstant_1(570L, true);
            }
            else
            {
                return MutateCSharp.Schemata238.ReplaceBooleanConstant_1(571L, false);
            }

            return default;
        }

        protected override void DeclareLocalVar(string name, Type/*?*/ type, IToken/*?*/ tok, bool leaveRoomForRhs, string/*?*/ rhs, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(572L, "let {0}"), name);
            if (leaveRoomForRhs)
            {
                Contract.Assert(rhs == null);  // follows from precondition
            }
            else if (rhs != null)
            {
                wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(573L, " = {0};"), rhs);
            }
            else
            {
                wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(574L, ";"));
            }
        }

        protected override ConcreteSyntaxTree DeclareLocalVar(string name, Type/*?*/ type, IToken/*?*/ tok, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(575L, "let {0} = "), name);
            var w = wr.Fork();
            wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(576L, ";"));
            return w;
        }

        protected override bool UseReturnStyleOuts(Method m, int nonGhostOutCount) => MutateCSharp.Schemata238.ReplaceBooleanConstant_1(577L, true);

        protected override void DeclareOutCollector(string collectorVarName, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(578L, "let {0} = "), collectorVarName);
        }

        protected override void DeclareLocalOutVar(string name, Type type, IToken tok, string rhs, bool useReturnStyleOuts, ConcreteSyntaxTree wr)
        {
            DeclareLocalVar(name, type, tok, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(579L, false), rhs, wr);
        }

        protected override void EmitOutParameterSplits(string outCollector, List<string> actualOutParamNames, ConcreteSyntaxTree wr)
        {
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_20(584L, actualOutParamNames.Count, MutateCSharp.Schemata238.ReplaceNumericConstant_4(580L, 1)))
            {
                EmitAssignment(actualOutParamNames[MutateCSharp.Schemata238.ReplaceNumericConstant_4(589L, 0)], null, outCollector, null, wr);
            }
            else
            {
                for (var i = MutateCSharp.Schemata238.ReplaceNumericConstant_4(593L, 0); MutateCSharp.Schemata238.ReplaceBinExprOp_21(597L, i, actualOutParamNames.Count); MutateCSharp.Schemata238.ReplacePostfixUnaryExprOp_11(602L, ref i))
                {
                    wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(603L, "{0} = {1}[{2}];"), actualOutParamNames[i], outCollector, i);
                }
            }
        }

        protected override void EmitActualTypeArgs(List<Type> typeArgs, IToken tok, ConcreteSyntaxTree wr)
        {
            // emit nothing
        }

        // ----- Statements -------------------------------------------------------------

        protected override void EmitPrintStmt(ConcreteSyntaxTree wr, Expression arg)
        {
            bool isString = DatatypeWrapperEraser.SimplifyTypeAndTrimNewtypes(Options, arg.Type).IsStringType;
            bool isStringLiteral = arg is StringLiteralExpr;
            bool isGeneric = arg.Type.NormalizeToAncestorType().AsSeqType is { Arg.IsTypeParameter: true };
            var wStmts = wr.Fork();
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(604L, () => isStringLiteral, () => !UnicodeCharEnabled))
            {
                // process.stdout.write(_dafny.toString(x));
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(610L, "process.stdout.write(_dafny.toString("));
                wr.Append(Expr(arg, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(611L, false), wStmts));
                wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(612L, "));"));
            }
            else if (isString)
            {
                if (UnicodeCharEnabled)
                {
                    wr.Write($"process.stdout.write(");
                    TrParenExpr(arg, wr, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(613L, false), wStmts);
                    wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(614L, ".toVerbatimString(false));"));
                }
                else
                {
                    wr.Write($"process.stdout.write(_dafny.toString({DafnySeqClass}.JoinIfPossible(");
                    wr.Append(Expr(arg, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(615L, false), wStmts));
                    wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(616L, ")));"));
                }
            }
            else if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(617L, () => isGeneric, () => !UnicodeCharEnabled))
            {
                // try { process.stdout.write(_dafny.toString(((x) instanceof Array && typeof((x)[0]) == \"string\") ? (x).join("") : (x))); } catch (_error) { process.stdout.write(_dafny.toString(x)); }
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(623L, "try { process.stdout.write(_dafny.toString("));
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(624L, "("));
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(625L, "("));
                wr.Append(Expr(arg, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(626L, false), wStmts));
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(627L, ") instanceof Array && typeof(("));
                wr.Append(Expr(arg, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(628L, false), wStmts));
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(629L, ")[0]) == \"string\") ? "));
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(630L, "("));
                wr.Append(Expr(arg, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(631L, false), wStmts));
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(632L, ").join(\"\")"));
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(633L, ":"));
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(634L, "("));
                wr.Append(Expr(arg, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(635L, false), wStmts));
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(636L, ")));"));
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(637L, "} catch (_error) { process.stdout.write(_dafny.toString("));
                wr.Append(Expr(arg, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(638L, false), wStmts));
                wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(639L, "));}"));
            }
            else
            { // !isString && !isGeneric
              // process.stdout.write(_dafny.toString(x));
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(640L, "process.stdout.write(_dafny.toString("));
                wr.Append(Expr(arg, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(641L, false), wStmts));
                wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(642L, "));"));
            }
        }

        protected override void EmitReturn(List<Formal> outParams, ConcreteSyntaxTree wr)
        {
            outParams = outParams.Where(f => !f.IsGhost).ToList();
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_20(647L, outParams.Count, MutateCSharp.Schemata238.ReplaceNumericConstant_4(643L, 0)))
            {
                wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(652L, "return;"));
            }
            else if (MutateCSharp.Schemata238.ReplaceBinExprOp_20(657L, outParams.Count, MutateCSharp.Schemata238.ReplaceNumericConstant_4(653L, 1)))
            {
                wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(662L, "return {0};"), IdName(outParams[MutateCSharp.Schemata238.ReplaceNumericConstant_4(663L, 0)]));
            }
            else
            {
                wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(667L, "return [{0}];"), Util.Comma(outParams, IdName));
            }
        }

        protected override ConcreteSyntaxTree CreateLabeledCode(string label, bool createContinueLabel, ConcreteSyntaxTree wr)
        {
            var prefix = createContinueLabel ? MutateCSharp.Schemata238.ReplaceStringConstant_0(668L, "C") : MutateCSharp.Schemata238.ReplaceStringConstant_0(669L, "L");
            return wr.NewNamedBlock($"{prefix}{label}:");
        }

        protected override void EmitBreak(string/*?*/ label, ConcreteSyntaxTree wr)
        {
            if (label == null)
            {
                wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(670L, "break;"));
            }
            else
            {
                wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(671L, "break L{0};"), label);
            }
        }

        protected override void EmitContinue(string label, ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(672L, "break C{0};"), label);
        }

        protected override void EmitYield(ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(673L, "yield null;"));
        }

        protected override void EmitAbsurd(string/*?*/ message, ConcreteSyntaxTree wr)
        {
            if (message == null)
            {
                message = MutateCSharp.Schemata238.ReplaceStringConstant_0(674L, "unexpected control point");
            }
            wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(675L, "throw new Error(\"{0}\");"), message);
        }

        protected override void EmitHalt(IToken tok, Expression/*?*/ messageExpr, ConcreteSyntaxTree wr)
        {
            var wStmts = wr.Fork();
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(676L, "throw new _dafny.HaltException("));
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_22(677L, tok, null))
            {
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(678L, "\"") + tok.TokenToString(Options) + MutateCSharp.Schemata238.ReplaceStringConstant_0(679L, ": \" + "));
            }

            TrParenExpr(messageExpr, wr, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(680L, false), wStmts);
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(681L, () => UnicodeCharEnabled, () => messageExpr.Type.IsStringType))
            {
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(687L, ".toVerbatimString(false)"));
            }
            wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(688L, ");"));
        }

        protected override ConcreteSyntaxTree EmitForStmt(IToken tok, IVariable loopIndex, bool goingUp, string /*?*/ endVarName,
          List<Statement> body, LList<Label> labels, ConcreteSyntaxTree wr)
        {

            var nativeType = AsNativeType(loopIndex.Type);

            wr.Write($"for (let {loopIndex.CompileName} = ");
            var startWr = wr.Fork();
            wr.Write($"; ");

            ConcreteSyntaxTree bodyWr;
            if (goingUp)
            {
                if (endVarName == null)
                {
                    wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(689L, "true"));
                }
                else if (MutateCSharp.Schemata238.ReplaceBinExprOp_15(690L, nativeType, null))
                {
                    wr.Write($"{loopIndex.CompileName}.isLessThan({endVarName})");
                }
                else
                {
                    wr.Write($"{loopIndex.CompileName} < {endVarName}");
                }
                if (MutateCSharp.Schemata238.ReplaceBinExprOp_15(691L, nativeType, null))
                {
                    bodyWr = wr.NewBlock($"; {loopIndex.CompileName} = {loopIndex.CompileName}.plus(_dafny.ONE))");
                }
                else
                {
                    bodyWr = wr.NewBlock($"; {loopIndex.CompileName}++)");
                }
            }
            else
            {
                if (endVarName == null)
                {
                    wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(692L, "true"));
                }
                else if (MutateCSharp.Schemata238.ReplaceBinExprOp_15(693L, nativeType, null))
                {
                    wr.Write($"{endVarName}.isLessThan({loopIndex.CompileName})");
                }
                else
                {
                    wr.Write($"{endVarName} < {loopIndex.CompileName}");
                }
                bodyWr = wr.NewBlock($"; )");
                if (MutateCSharp.Schemata238.ReplaceBinExprOp_15(694L, nativeType, null))
                {
                    bodyWr.WriteLine($"{loopIndex.CompileName} = {loopIndex.CompileName}.minus(_dafny.ONE);");
                }
                else
                {
                    bodyWr.WriteLine($"{loopIndex.CompileName}--;");
                }
            }
            bodyWr = EmitContinueLabel(labels, bodyWr);
            TrStmtList(body, bodyWr);

            return startWr;
        }

        protected override ConcreteSyntaxTree CreateForLoop(string indexVar, Action<ConcreteSyntaxTree> boundAction, ConcreteSyntaxTree wr, string start = null)
        {
            start = start ?? MutateCSharp.Schemata238.ReplaceStringConstant_0(695L, "0");
            var boundWriter = new ConcreteSyntaxTree();
            boundAction(boundWriter);
            var bound = boundWriter.ToString();
            return wr.NewNamedBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(696L, "for (let {0} = {2}; {0} < {1}; {0}++)"), indexVar, bound, start);
        }

        protected override ConcreteSyntaxTree CreateDoublingForLoop(string indexVar, int start, ConcreteSyntaxTree wr)
        {
            return wr.NewNamedBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(697L, "for (let {0} = new BigNumber({1}); ; {0} = {0}.multipliedBy(2))"), indexVar, start);
        }

        protected override void EmitIncrementVar(string varName, ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(698L, "{0} = {0}.plus(1);"), varName);
        }

        protected override void EmitDecrementVar(string varName, ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(699L, "{0} = {0}.minus(1);"), varName);
        }

        protected override string GetQuantifierName(string bvType)
        {
            return string.Format(MutateCSharp.Schemata238.ReplaceStringConstant_0(700L, "_dafny.Quantifier"));
        }

        protected override ConcreteSyntaxTree CreateForeachLoop(string tmpVarName, Type collectionElementType, IToken tok,
          out ConcreteSyntaxTree collectionWriter, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(701L, "for (const {0} of "), tmpVarName);
            collectionWriter = wr.Fork();
            var wwr = wr.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(702L, ")"));
            return wwr;
        }

        protected override void EmitDowncastVariableAssignment(string boundVarName, Type boundVarType, string tmpVarName,
          Type sourceType, bool introduceBoundVar, IToken tok, ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(703L, "{0}{1} = {2};"), introduceBoundVar ? MutateCSharp.Schemata238.ReplaceStringConstant_0(704L, "let ") : "", boundVarName, tmpVarName);
        }

        [CanBeNull]
        protected override Action<ConcreteSyntaxTree> GetSubtypeCondition(string tmpVarName, Type boundVarType, IToken tok, ConcreteSyntaxTree preconditions)
        {
            string typeTest;
            if (boundVarType.IsRefType)
            {
                if (MutateCSharp.Schemata238.ReplaceBinExprOp_3(705L, () => boundVarType.IsObject, () => boundVarType.IsObjectQ))
                {
                    typeTest = MutateCSharp.Schemata238.ReplaceStringConstant_0(711L, "true");
                }
                else if (boundVarType.IsTraitType)
                {
                    typeTest = $"_dafny.InstanceOfTrait({tmpVarName}, {TypeName(boundVarType, preconditions, tok)})";
                }
                else
                {
                    typeTest = $"{tmpVarName} instanceof {TypeName(boundVarType, preconditions, tok)}";
                }

                if (boundVarType.IsNonNullRefType)
                {
                    typeTest = $"{tmpVarName} !== null && " + typeTest;
                }
                else
                {
                    typeTest = $"{tmpVarName} === null || " + typeTest;
                }
            }
            else
            {
                typeTest = MutateCSharp.Schemata238.ReplaceStringConstant_0(712L, "true");
            }

            typeTest = MutateCSharp.Schemata238.ReplaceBinExprOp_23(714L, typeTest, MutateCSharp.Schemata238.ReplaceStringConstant_0(713L, "true")) ? null : typeTest;
            return typeTest == null ? null : wr => wr.Write(typeTest);
        }

        protected override ConcreteSyntaxTree CreateForeachIngredientLoop(string boundVarName, int L, string tupleTypeArgs, out ConcreteSyntaxTree collectionWriter, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(715L, "for (const {0} of "), boundVarName);
            collectionWriter = wr.Fork();
            return wr.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(716L, ")"));
        }

        // ----- Expressions -------------------------------------------------------------

        protected override void EmitNew(Type type, IToken tok, CallStmt initCall /*?*/, ConcreteSyntaxTree wr,
          ConcreteSyntaxTree wStmts)
        {
            var cl = ((UserDefinedType)type.NormalizeExpand()).ResolvedClass;
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_23(718L, cl.Name, MutateCSharp.Schemata238.ReplaceStringConstant_0(717L, "object")))
            {
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(719L, "_dafny.NewObject()"));
            }
            else
            {
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(720L, "new {0}("), TypeName(type, wr, tok));
                EmitTypeDescriptorsActuals(TypeArgumentInstantiation.ListFromClass(cl, type.TypeArgs), tok, wr);
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(721L, ")"));
            }
        }

        protected override void EmitNewArray(Type elementType, IToken tok, List<string> dimensions,
            bool mustInitialize, [CanBeNull] string exampleElement, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var initValue = mustInitialize ? DefaultValue(elementType, wr, tok, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(722L, true)) : null;
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_20(727L, dimensions.Count, MutateCSharp.Schemata238.ReplaceNumericConstant_4(723L, 1)))
            {
                // handle the common case of 1-dimensional arrays separately
                wr.Write($"Array(({dimensions[MutateCSharp.Schemata238.ReplaceNumericConstant_4(732L, 0)]}).toNumber())");
                if (initValue != null)
                {
                    wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(736L, ".fill({0})"), initValue);
                }
            }
            else
            {
                // the general case
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(737L, "_dafny.newArray({0}, {1})"), initValue ?? MutateCSharp.Schemata238.ReplaceStringConstant_0(738L, "undefined"), dimensions.Comma(s => s));
            }
        }

        protected string TranslateEscapes(string s)
        {
            s = Util.ReplaceNullEscapesWithCharacterEscapes(s);

            s = Util.UnicodeEscapesToLowercase(s);

            return s;
        }

        protected override void EmitLiteralExpr(ConcreteSyntaxTree wr, LiteralExpr e)
        {
            if (e is StaticReceiverExpr)
            {
                wr.Write(TypeName(e.Type, wr, e.tok));
            }
            else if (e.Value == null)
            {
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(739L, "null"));
            }
            else if (e.Value is bool)
            {
                wr.Write((bool)e.Value ? MutateCSharp.Schemata238.ReplaceStringConstant_0(740L, "true") : MutateCSharp.Schemata238.ReplaceStringConstant_0(741L, "false"));
            }
            else if (e is CharLiteralExpr)
            {
                var escaped = TranslateEscapes((string)e.Value);
                if (UnicodeCharEnabled)
                {
                    wr.Write($"new _dafny.CodePoint('{escaped}'.codePointAt(0))");
                }
                else
                {
                    wr.Write($"'{escaped}'");
                }
            }
            else if (e is StringLiteralExpr)
            {
                var str = (StringLiteralExpr)e;
                if (UnicodeCharEnabled)
                {
                    wr.Write($"_dafny.Seq.UnicodeFromString(");
                    TrStringLiteral(str, wr);
                    wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(742L, ")"));
                }
                else
                {
                    TrStringLiteral(str, wr);
                }
            }
            else if (MutateCSharp.Schemata238.ReplaceBinExprOp_13(743L, AsNativeType(e.Type), null))
            {
                wr.Write(e.Value.ToString());
            }
            else if (e.Value is BigInteger)
            {
                var i = (BigInteger)e.Value;
                wr.Write(IntegerLiteral(i));
            }
            else if (e.Value is BaseTypes.BigDec)
            {
                var n = (BaseTypes.BigDec)e.Value;
                if (MutateCSharp.Schemata238.ReplaceBinExprOp_24(748L, MutateCSharp.Schemata238.ReplaceNumericConstant_4(744L, 0), n.Exponent))
                {
                    wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(753L, "new _dafny.BigRational(new BigNumber(\"{0}"), n.Mantissa);
                    for (int i = MutateCSharp.Schemata238.ReplaceNumericConstant_4(754L, 0); MutateCSharp.Schemata238.ReplaceBinExprOp_21(758L, i, n.Exponent); MutateCSharp.Schemata238.ReplacePostfixUnaryExprOp_11(763L, ref i))
                    {
                        wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(764L, "0"));
                    }
                    wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(765L, "\"))"));
                }
                else
                {
                    wr.Write($"new _dafny.BigRational({IntegerLiteral(n.Mantissa)}, new BigNumber(\"1");
                    for (int i = n.Exponent; MutateCSharp.Schemata238.ReplaceBinExprOp_21(770L, i, MutateCSharp.Schemata238.ReplaceNumericConstant_4(766L, 0)); MutateCSharp.Schemata238.ReplacePostfixUnaryExprOp_11(775L, ref i))
                    {
                        wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(776L, "0"));
                    }
                    wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(777L, "\"))"));
                }
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected literal
            }
        }
        string IntegerLiteral(BigInteger i)
        {
            if (i.IsZero)
            {
                return MutateCSharp.Schemata238.ReplaceStringConstant_0(778L, "_dafny.ZERO");
            }
            else if (i.IsOne)
            {
                return MutateCSharp.Schemata238.ReplaceStringConstant_0(779L, "_dafny.ONE");
            }
            else if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(792L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_26(784L, MutateCSharp.Schemata238.ReplaceNumericConstant_25(780L, -0x20_0000_0000_0000L), i), () => MutateCSharp.Schemata238.ReplaceBinExprOp_27(790L, i, MutateCSharp.Schemata238.ReplaceNumericConstant_25(786L, 0x20_0000_0000_0000L))))
            {  // 53 bits, plus sign
                return $"new BigNumber({i})";
            }
            else
            {
                return $"new BigNumber(\"{i}\")";
            }

            return default;
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
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(798L, "\""));
                for (var i = MutateCSharp.Schemata238.ReplaceNumericConstant_4(799L, 0); MutateCSharp.Schemata238.ReplaceBinExprOp_21(803L, i, n); MutateCSharp.Schemata238.ReplacePostfixUnaryExprOp_11(808L, ref i))
                {
                    if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(856L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_7(832L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_20(809L, str[i], '\"'), () => MutateCSharp.Schemata238.ReplaceBinExprOp_21(827L, MutateCSharp.Schemata238.ReplaceBinExprOp_28(818L, i, MutateCSharp.Schemata238.ReplaceNumericConstant_4(814L, 1)), n)), () => MutateCSharp.Schemata238.ReplaceBinExprOp_20(851L, str[MutateCSharp.Schemata238.ReplaceBinExprOp_28(842L, i, MutateCSharp.Schemata238.ReplaceNumericConstant_4(838L, 1))], '\"')))
                    {
                        wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(862L, "\\\""));
                        MutateCSharp.Schemata238.ReplacePostfixUnaryExprOp_11(863L, ref i);
                    }
                    else if (MutateCSharp.Schemata238.ReplaceBinExprOp_20(864L, str[i], '\\'))
                    {
                        wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(869L, "\\\\"));
                    }
                    else if (MutateCSharp.Schemata238.ReplaceBinExprOp_20(870L, str[i], '\n'))
                    {
                        wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(875L, "\\n"));
                    }
                    else if (MutateCSharp.Schemata238.ReplaceBinExprOp_20(876L, str[i], '\r'))
                    {
                        wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(881L, "\\r"));
                    }
                    else
                    {
                        wr.Write(str[i]);
                    }
                }
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(882L, "\""));
            }
        }

        protected override ConcreteSyntaxTree EmitBitvectorTruncation(BitvectorType bvType, [CanBeNull] NativeType nativeType,
          bool surroundByUnchecked, ConcreteSyntaxTree wr)
        {

            Contract.Assert(nativeType == null || bvType.Width == 0); // JavaScript only supports "number" as a native type, and it is used just for bv0

            if (MutateCSharp.Schemata238.ReplaceBinExprOp_20(887L, bvType.Width, MutateCSharp.Schemata238.ReplaceNumericConstant_4(883L, 0)))
            {
                return wr;
            }
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(892L, "("));
            var middle = wr.Fork();
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(893L, ").mod(new BigNumber(2).exponentiatedBy({0}))"), bvType.Width);
            return middle;
        }

        protected override void EmitRotate(Expression e0, Expression e1, bool isRotateLeft, ConcreteSyntaxTree wr,
            bool inLetExprBody, ConcreteSyntaxTree wStmts, FCE_Arg_Translator tr)
        {
            bool needsCast = MutateCSharp.Schemata238.ReplaceBooleanConstant_1(894L, false);
            var nativeType = AsNativeType(e0.Type);
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_13(895L, nativeType, null))
            {
                GetNativeInfo(nativeType.Sel, out _, out _, out needsCast);
            }

            var bv = e0.Type.NormalizeToAncestorType().AsBitVectorType;
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_20(900L, bv.Width, MutateCSharp.Schemata238.ReplaceNumericConstant_4(896L, 0)))
            {
                tr(e0, wr, inLetExprBody, wStmts);
            }
            else
            {
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(905L, "_dafny.{0}("), isRotateLeft ? MutateCSharp.Schemata238.ReplaceStringConstant_0(906L, "RotateLeft") : MutateCSharp.Schemata238.ReplaceStringConstant_0(907L, "RotateRight"));
                tr(e0, wr, inLetExprBody, wStmts);
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(908L, ", ("));
                tr(e1, wr, inLetExprBody, wStmts);
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(909L, ").toNumber(), {0})"), bv.Width);
                if (needsCast)
                {
                    wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(910L, ".toNumber()"));
                }
            }
        }

        protected override void EmitEmptyTupleList(string tupleTypeArgs, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(911L, "[]"), tupleTypeArgs);
        }

        protected override ConcreteSyntaxTree EmitAddTupleToList(string ingredients, string tupleTypeArgs, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(912L, "{0}.push(_dafny.Tuple.of("), ingredients, tupleTypeArgs);
            var wrTuple = wr.Fork();
            wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(913L, "));"));
            return wrTuple;
        }

        protected override void EmitTupleSelect(string prefix, int i, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(914L, "{0}[{1}]"), prefix, i);
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
                case "arguments":
                case "await":
                case "boolean":
                case "byte":
                case "catch":
                case "continue":
                case "debugger":
                case "default":
                case "delete":
                case "do":
                case "double":
                case "enum":
                case "eval":
                case "final":
                case "finally":
                case "float":
                case "for":
                case "goto":
                case "implements":
                case "instanceof":
                case "interface":
                case "let":
                case "long":
                case "native":
                case "package":
                case "private":
                case "public":
                case "short":
                case "super":
                case "switch":
                case "synchronized":
                case "throw":
                case "throws":
                case "transient":
                case "try":
                case "typeof":
                case "void":
                case "volatile":
                case "with":
                case "toString":
                case "equals":
                    return "_$$_" + name;
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
                return ArrowType.Arrow_FullCompileName;
            }
            var cl = udt.ResolvedClass;
            if (cl is TypeParameter)
            {
                return IdProtect(udt.GetCompileName(Options));
            }
            else if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(930L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_7(923L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_7(916L, () => cl is DefaultClassDecl, () => Attributes.Contains(cl.EnclosingModuleDefinition.Attributes, MutateCSharp.Schemata238.ReplaceStringConstant_0(915L, "extern"))), () => MutateCSharp.Schemata238.ReplaceBinExprOp_29(922L, member, null)), () => Attributes.Contains(member.Attributes, MutateCSharp.Schemata238.ReplaceStringConstant_0(929L, "extern"))))
            {
                // omit the default class name ("_default") in extern modules, when the class is used to qualify an extern member
                Contract.Assert(!cl.EnclosingModuleDefinition.TryToAvoidName); // default module is not marked ":extern"
                return IdProtect(cl.EnclosingModuleDefinition.GetCompileName(Options));
            }
            else
            {
                return IdProtect(cl.EnclosingModuleDefinition.GetCompileName(Options)) + MutateCSharp.Schemata238.ReplaceStringConstant_0(936L, ".") + IdProtect(cl.GetCompileName(Options));
            }

            return default;
        }

        protected override void EmitThis(ConcreteSyntaxTree wr, bool callToInheritedMember)
        {
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(937L, "_this"));
        }

        protected override ConcreteSyntaxTree EmitCast(ICanRender toType, ConcreteSyntaxTree wr)
        {
            return wr;
        }

        protected override void EmitDatatypeValue(DatatypeValue dtv, string typeDescriptorArguments, string arguments, ConcreteSyntaxTree wr)
        {
            var dt = dtv.Ctor.EnclosingDatatype;
            EmitDatatypeValue(dt, dtv.Ctor, dtv.IsCoCall, typeDescriptorArguments, arguments, wr);
        }

        void EmitDatatypeValue(DatatypeDecl dt, DatatypeCtor ctor, bool isCoCall, string typeDescriptorArguments, string arguments, ConcreteSyntaxTree wr)
        {
            var dtName = dt.GetFullCompileName(Options);
            var ctorName = ctor.GetCompileName(Options);

            var sep = MutateCSharp.Schemata238.ReplaceBinExprOp_7(956L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_10(942L, typeDescriptorArguments.Length, MutateCSharp.Schemata238.ReplaceNumericConstant_4(938L, 0)), () => MutateCSharp.Schemata238.ReplaceBinExprOp_10(951L, arguments.Length, MutateCSharp.Schemata238.ReplaceNumericConstant_4(947L, 0))) ? MutateCSharp.Schemata238.ReplaceStringConstant_0(962L, ", ") : "";
            if (dt is TupleTypeDecl)
            {
                Contract.Assert(typeDescriptorArguments.Length == 0);
                wr.Write($"_dafny.Tuple.of({arguments})");
            }
            else if (!isCoCall)
            {
                // Ordinary constructor (that is, one that does not guard any co-recursive calls)
                // Generate: Dt.create_Ctor(arguments)
                var lazyArgument = dt is IndDatatypeDecl ? "" : MutateCSharp.Schemata238.ReplaceBinExprOp_20(967L, arguments.Length, MutateCSharp.Schemata238.ReplaceNumericConstant_4(963L, 0)) ? MutateCSharp.Schemata238.ReplaceStringConstant_0(972L, "null") : MutateCSharp.Schemata238.ReplaceStringConstant_0(973L, "null, ");
                wr.Write($"{dtName}.create_{ctorName}({lazyArgument}{typeDescriptorArguments}{sep}{arguments})");
            }
            else
            {
                var sep0 = MutateCSharp.Schemata238.ReplaceBinExprOp_10(978L, typeDescriptorArguments.Length, MutateCSharp.Schemata238.ReplaceNumericConstant_4(974L, 0)) ? MutateCSharp.Schemata238.ReplaceStringConstant_0(983L, ", ") : "";
                // Co-recursive call
                // Generate:  Dt.lazy_Ctor(($dt) => Dt.create_Ctor($dt, args))
                wr.Write($"{dtName}.lazy_{ctorName}(($dt{sep0}{typeDescriptorArguments}) => ");
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(984L, "{0}.create_{1}($dt{2}{3}{4}{5})"), dtName, ctorName, MutateCSharp.Schemata238.ReplaceBinExprOp_20(989L, arguments.Length, MutateCSharp.Schemata238.ReplaceNumericConstant_4(985L, 0)) ? "" : MutateCSharp.Schemata238.ReplaceStringConstant_0(994L, ", "), typeDescriptorArguments, sep, arguments);
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(995L, ")"));
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
                    compiledName = IdProtect((string)idParam);
                    break;
                    break;
                case SpecialField.ID.ArrayLength:
                case SpecialField.ID.ArrayLengthInt:
                    if (idParam == null)
                    {
                        compiledName = "length";
                    }
                    else
                    {
                        compiledName = "dims[" + (int)idParam + "]";
                    }
                    if (id == SpecialField.ID.ArrayLength)
                    {
                        preString = "new BigNumber(";
                        postString = ")";
                    }
                    break;
                    break;
                case SpecialField.ID.Floor:
                    compiledName = "toBigNumber()";
                    break;
                    break;
                case SpecialField.ID.IsLimit:
                    preString = "_dafny.BigOrdinal.IsLimit(";
                    postString = ")";
                    break;
                    break;
                case SpecialField.ID.IsSucc:
                    preString = "_dafny.BigOrdinal.IsSucc(";
                    postString = ")";
                    break;
                    break;
                case SpecialField.ID.Offset:
                    preString = "_dafny.BigOrdinal.Offset(";
                    postString = ")";
                    break;
                    break;
                case SpecialField.ID.IsNat:
                    preString = "_dafny.BigOrdinal.IsNat(";
                    postString = ")";
                    break;
                    break;
                case SpecialField.ID.Keys:
                    compiledName = "Keys";
                    break;
                    break;
                case SpecialField.ID.Values:
                    compiledName = "Values";
                    break;
                    break;
                case SpecialField.ID.Items:
                    compiledName = "Items";
                    break;
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
          Type expectedType, string/*?*/ additionalCustomParameter, bool internalAccess = false)
        {
            var memberStatus = DatatypeWrapperEraser.GetMemberStatus(Options, member);
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_30(996L, memberStatus, DatatypeWrapperEraser.MemberCompileStatus.Identity))
            {
                return SimpleLvalue(obj);
            }
            else if (MutateCSharp.Schemata238.ReplaceBinExprOp_30(997L, memberStatus, DatatypeWrapperEraser.MemberCompileStatus.AlwaysTrue))
            {
                return SimpleLvalue(w => w.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(998L, "true")));
            }
            else if (member is DatatypeDestructor dtor && dtor.EnclosingClass is TupleTypeDecl)
            {
                Contract.Assert(dtor.CorrespondingFormals.Count == 1);
                var formal = dtor.CorrespondingFormals[MutateCSharp.Schemata238.ReplaceNumericConstant_4(999L, 0)];
                return SuffixLvalue(obj, MutateCSharp.Schemata238.ReplaceStringConstant_0(1003L, "[{0}]"), formal.NameForCompilation);
            }
            else if (member is SpecialField sf && !(member is ConstantField))
            {
                GetSpecialFieldInfo(sf.SpecialId, sf.IdParam, objType, out var compiledName, out var preStr, out var postStr);
                if (MutateCSharp.Schemata238.ReplaceBinExprOp_10(1008L, compiledName.Length, MutateCSharp.Schemata238.ReplaceNumericConstant_4(1004L, 0)))
                {
                    return SuffixLvalue(obj, MutateCSharp.Schemata238.ReplaceStringConstant_0(1013L, ".{0}"), compiledName);
                }
                else
                {
                    // this member selection is handled by some kind of enclosing function call, so nothing to do here
                    return SimpleLvalue(obj);
                }
            }
            else if (member is Function fn)
            {
                typeArgs = typeArgs.Where(ta => NeedsTypeDescriptor(ta.Formal)).ToList();
                if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(1023L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_20(1018L, typeArgs.Count, MutateCSharp.Schemata238.ReplaceNumericConstant_4(1014L, 0)), () => additionalCustomParameter == null))
                {
                    if (member.IsStatic)
                    {
                        return SuffixLvalue(obj, MutateCSharp.Schemata238.ReplaceStringConstant_0(1029L, ".{0}"), IdName(member));
                    }
                    else
                    {
                        // generate: obj.F.bind(obj)
                        return SimpleLvalue(w =>
                        {
                            var objWriter = new ConcreteSyntaxTree();
                            obj(objWriter);
                            var objString = objWriter.ToString();
                            w.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1030L, "{0}.{1}.bind({0})"), objString, IdName(member));
                        });
                    }
                }
                else
                {
                    // We need an eta conversion to adjust for the difference in arity.
                    // (T0 a0, T1 a1, ...) -> obj.F(rtd0, rtd1, ..., additionalCustomParameter, a0, a1, ...)
                    // Start by writing to the suffix:  F(rtd0, rtd1, ...
                    var suffixWr = new ConcreteSyntaxTree();
                    suffixWr.Write(IdName(member));
                    suffixWr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1031L, "("));
                    var suffixSep = "";
                    EmitTypeDescriptorsActuals(ForTypeDescriptors(typeArgs, member.EnclosingClass, member, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(1032L, false)), fn.tok, suffixWr, ref suffixSep);
                    if (additionalCustomParameter != null)
                    {
                        suffixWr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1033L, "{0}{1}"), suffixSep, additionalCustomParameter);
                        suffixSep = MutateCSharp.Schemata238.ReplaceStringConstant_0(1034L, ", ");
                    }
                    // Write the prefix and the rest of the suffix
                    var prefixWr = new ConcreteSyntaxTree();
                    var prefixSep = "";
                    prefixWr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1035L, "("));
                    foreach (var arg in fn.Ins)
                    {
                        if (!arg.IsGhost)
                        {
                            var name = idGenerator.FreshId(MutateCSharp.Schemata238.ReplaceStringConstant_0(1036L, "_eta"));
                            prefixWr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1037L, "{0}{1}"), prefixSep, name);
                            suffixWr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1038L, "{0}{1}"), suffixSep, name);
                            suffixSep = MutateCSharp.Schemata238.ReplaceStringConstant_0(1039L, ", ");
                            prefixSep = MutateCSharp.Schemata238.ReplaceStringConstant_0(1040L, ", ");
                        }
                    }
                    prefixWr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1041L, ") => "));
                    suffixWr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1042L, ")"));
                    return EnclosedLvalue(prefixWr.ToString(), obj, $".{suffixWr.ToString()}");
                }
            }
            else
            {
                Contract.Assert(member is Field);
                if (member.IsStatic)
                {
                    return SimpleLvalue(w =>
                    {
                        w.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1043L, "{0}.{1}"), TypeName_Companion(objType, w, member.tok, member), IdName(member));
                        var sep = MutateCSharp.Schemata238.ReplaceStringConstant_0(1044L, "(");
                        EmitTypeDescriptorsActuals(ForTypeDescriptors(typeArgs, member.EnclosingClass, member, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(1045L, false)), member.tok, w, ref sep);
                        if (MutateCSharp.Schemata238.ReplaceBinExprOp_31(1047L, sep, MutateCSharp.Schemata238.ReplaceStringConstant_0(1046L, "(")))
                        {
                            w.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1048L, ")"));
                        }
                    });
                }
                else if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(1049L, () => NeedsCustomReceiver(member), () => !(member.EnclosingClass is TraitDecl)))
                {
                    // instance const in a newtype
                    return SimpleLvalue(w =>
                    {
                        w.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1055L, "{0}.{1}("), TypeName_Companion(objType, w, member.tok, member), IdName(member));
                        obj(w);
                        w.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1056L, ")"));
                    });
                }
                else if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(1063L, () => internalAccess, () => (MutateCSharp.Schemata238.ReplaceBinExprOp_3(1057L, () => member is ConstantField, () => member.EnclosingClass is TraitDecl))))
                {
                    return SuffixLvalue(obj, $"._{member.GetCompileName(Options)}");
                }
                else
                {
                    return SimpleLvalue(w =>
                    {
                        obj(w);
                        w.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1069L, ".{0}"), IdName(member));
                        var sep = MutateCSharp.Schemata238.ReplaceStringConstant_0(1070L, "(");
                        EmitTypeDescriptorsActuals(ForTypeDescriptors(typeArgs, member.EnclosingClass, member, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(1071L, false)), member.tok, w, ref sep);
                        if (MutateCSharp.Schemata238.ReplaceBinExprOp_31(1073L, sep, MutateCSharp.Schemata238.ReplaceStringConstant_0(1072L, "(")))
                        {
                            w.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1074L, ")"));
                        }
                    });
                }
            }

            return default;
        }

        protected override ConcreteSyntaxTree ExprToInt(Type fromType, ConcreteSyntaxTree wr)
        {
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_15(1075L, AsNativeType(fromType), null))
            {
                return wr;
            }
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1076L, "BigNumber"));
            return wr.ForkInParens();
        }

        protected override ConcreteSyntaxTree EmitArraySelect(List<Action<ConcreteSyntaxTree>> indices, Type elmtType, ConcreteSyntaxTree wr)
        {
            var w = wr.Fork();
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_20(1081L, indices.Count, MutateCSharp.Schemata238.ReplaceNumericConstant_4(1077L, 1)))
            {
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1086L, "["));
                indices[MutateCSharp.Schemata238.ReplaceNumericConstant_4(1087L, 0)](wr);
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1091L, "]"));
            }
            else
            {
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1092L, ".elmts"));
                foreach (var index in indices)
                {
                    wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1093L, "["));
                    index(wr);
                    wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1094L, "]"));
                }
            }
            return w;
        }

        protected override ConcreteSyntaxTree EmitArraySelect(List<Expression> indices, Type elmtType, bool inLetExprBody,
            ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            Contract.Assert(indices != null && 1 <= indices.Count);  // follows from precondition
            var w = wr.Fork();
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_20(1099L, indices.Count, MutateCSharp.Schemata238.ReplaceNumericConstant_4(1095L, 1)))
            {
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1104L, "["));
                wr.Append(Expr(indices[MutateCSharp.Schemata238.ReplaceNumericConstant_4(1105L, 0)], inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1109L, "]"));
            }
            else
            {
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1110L, ".elmts"));
                foreach (var index in indices)
                {
                    wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1111L, "["));
                    wr.Append(Expr(index, inLetExprBody, wStmts));
                    wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1112L, "]"));
                }
            }
            return w;
        }

        protected override string ArrayIndexToInt(string arrayIndex) => $"new BigNumber({arrayIndex})";

        protected override void EmitExprAsNativeInt(Expression expr, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            TrParenExpr(expr, wr, inLetExprBody, wStmts);
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_15(1113L, AsNativeType(expr.Type), null))
            {
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1114L, ".toNumber()"));
            }
        }

        protected override void EmitIndexCollectionSelect(Expression source, Expression index, bool inLetExprBody,
            ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            TrParenExpr(source, wr, inLetExprBody, wStmts);
            if (source.Type.NormalizeToAncestorType() is SeqType)
            {
                // seq
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1115L, "["));
                wr.Append(Expr(index, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1116L, "]"));
            }
            else
            {
                // map or imap
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1117L, ".get("));
                wr.Append(Expr(index, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1118L, ")"));
            }
        }

        protected override void EmitIndexCollectionUpdate(Expression source, Expression index, Expression value,
            CollectionType resultCollectionType, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_32(1119L, resultCollectionType.AsSeqType, null))
            {
                wr.Write($"{DafnySeqClass}.update(");
                wr.Append(Expr(source, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1120L, ", "));
            }
            else
            {
                TrParenExpr(source, wr, inLetExprBody, wStmts);
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1121L, ".update("));
            }
            wr.Append(Expr(index, inLetExprBody, wStmts));
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1122L, ", "));
            wr.Append(CoercedExpr(value, resultCollectionType.ValueArg, inLetExprBody, wStmts));
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1123L, ")"));
        }

        protected override void EmitSeqSelectRange(Expression source, Expression lo /*?*/, Expression hi /*?*/,
            bool fromArray, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (fromArray)
            {
                wr.Write($"{DafnySeqClass}.of(...");
            }
            TrParenExpr(source, wr, inLetExprBody, wStmts);
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_19(1124L, lo, null))
            {
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1125L, ".slice("));
                wr.Append(Expr(lo, inLetExprBody, wStmts));
                if (MutateCSharp.Schemata238.ReplaceBinExprOp_19(1126L, hi, null))
                {
                    wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1127L, ", "));
                    wr.Append(Expr(hi, inLetExprBody, wStmts));
                }
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1128L, ")"));
            }
            else if (MutateCSharp.Schemata238.ReplaceBinExprOp_19(1129L, hi, null))
            {
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1130L, ".slice(0, "));
                wr.Append(Expr(hi, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1131L, ")"));
            }
            else if (fromArray)
            {
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1132L, ".slice()"));
            }
            if (fromArray)
            {
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1133L, ")"));
            }
        }

        protected override void EmitSeqConstructionExpr(SeqConstructionExpr expr, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var fromType = (ArrowType)expr.Initializer.Type.NormalizeExpand();
            wr.Write($"{DafnySeqClass}.Create(");
            wr.Append(Expr(expr.N, inLetExprBody, wStmts));
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1134L, ", "));
            wr.Append(Expr(expr.Initializer, inLetExprBody, wStmts));
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1135L, ")"));
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(1136L, () => fromType.Result.IsCharType, () => !UnicodeCharEnabled))
            {
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1142L, ".join('')"));
            }
        }

        protected override void EmitMultiSetFormingExpr(MultiSetFormingExpr expr, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            TrParenExpr($"{DafnyMultiSetClass}.FromArray", expr.E, wr, inLetExprBody, wStmts);
        }

        protected override void EmitApplyExpr(Type functionType, IToken tok, Expression function,
            List<Expression> arguments, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            TrParenExpr(function, wr, inLetExprBody, wStmts);
            TrExprList(arguments, wr, inLetExprBody, wStmts);
        }

        protected override ConcreteSyntaxTree EmitBetaRedex(List<string> boundVars, List<Expression> arguments,
          List<Type> boundTypes, Type resultType, IToken tok, bool inLetExprBody, ConcreteSyntaxTree wr,
          ref ConcreteSyntaxTree wStmts)
        {
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1143L, "(({0}) => "), Util.Comma(boundVars));
            var w = wr.Fork();
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1144L, ")"));
            TrExprList(arguments, wr, inLetExprBody, wStmts);
            return w;
        }

        protected override void EmitDestructor(Action<ConcreteSyntaxTree> source, Formal dtor, int formalNonGhostIndex, DatatypeCtor ctor, List<Type> typeArgs, Type bvType, ConcreteSyntaxTree wr)
        {
            if (DatatypeWrapperEraser.IsErasableDatatypeWrapper(Options, ctor.EnclosingDatatype, out var coreDtor))
            {
                Contract.Assert(coreDtor.CorrespondingFormals.Count == 1);
                Contract.Assert(dtor == coreDtor.CorrespondingFormals[0]); // any other destructor is a ghost
                source(wr);
            }
            else if (ctor.EnclosingDatatype is TupleTypeDecl tupleTypeDecl)
            {
                Contract.Assert(tupleTypeDecl.NonGhostDims != 1); // such a tuple is an erasable-wrapper type, handled above
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1145L, "("));
                source(wr);
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1146L, ")[{0}]"), formalNonGhostIndex);
            }
            else
            {
                var dtorName = FormalName(dtor, formalNonGhostIndex);
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1147L, "("));
                source(wr);
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1148L, "){0}.{1}"), ctor.EnclosingDatatype is CoDatatypeDecl ? MutateCSharp.Schemata238.ReplaceStringConstant_0(1149L, "._D()") : "", dtorName);
            }
        }

        protected override ConcreteSyntaxTree CreateLambda(List<Type> inTypes, IToken tok, List<string> inNames,
            Type resultType, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts, bool untyped = false)
        {
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1150L, "function ("));
            Contract.Assert(inTypes.Count == inNames.Count);  // guaranteed by precondition
            for (var i = MutateCSharp.Schemata238.ReplaceNumericConstant_4(1151L, 0); MutateCSharp.Schemata238.ReplaceBinExprOp_21(1155L, i, inNames.Count); MutateCSharp.Schemata238.ReplacePostfixUnaryExprOp_11(1160L, ref i))
            {
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1161L, "{0}{1}"), MutateCSharp.Schemata238.ReplaceBinExprOp_20(1166L, i, MutateCSharp.Schemata238.ReplaceNumericConstant_4(1162L, 0)) ? "" : MutateCSharp.Schemata238.ReplaceStringConstant_0(1171L, ", "), inNames[i]);
            }
            var w = wr.NewExprBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(1172L, ")"));
            return w;
        }

        protected override void CreateIIFE(string bvName, Type bvType, IToken bvTok, Type bodyType, IToken bodyTok,
          ConcreteSyntaxTree wr, ref ConcreteSyntaxTree wStmts, out ConcreteSyntaxTree wrRhs, out ConcreteSyntaxTree wrBody)
        {
            var w = wr.NewExprBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(1173L, "function ({0})"), bvName);
            wStmts = w.Fork();
            w.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1174L, "return "));
            wrBody = w.Fork();
            w.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(1175L, ";"));
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1176L, "("));
            wrRhs = wr.Fork();
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1177L, ")"));
        }

        protected override ConcreteSyntaxTree CreateIIFE0(Type resultType, IToken resultTok, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var w = wr.NewBigExprBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(1178L, "function ()"), MutateCSharp.Schemata238.ReplaceStringConstant_0(1179L, "()"));
            return w;
        }

        protected override ConcreteSyntaxTree CreateIIFE1(int source, Type resultType, IToken resultTok, string bvName,
            ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var w = wr.NewExprBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(1180L, "function ({0})"), bvName);
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1181L, "({0})"), source);
            return w;
        }

        protected override ConcreteSyntaxTree FromFatPointer(Type type, ConcreteSyntaxTree wr)
        {
            if (type.HasFatPointer)
            {
                var w = wr.ForkInParens();
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1182L, "._value"));
                return w;
            }
            else
            {
                return wr;
            }

            return default;
        }

        protected override ConcreteSyntaxTree ToFatPointer(Type type, ConcreteSyntaxTree wr)
        {
            if (type.HasFatPointer)
            {
                wr.Write($"new {type.AsNewtype.GetFullCompileName(Options)}");
                return wr.ForkInParens();
            }
            else
            {
                return wr;
            }

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
                    {
                        var exprType = expr.Type.NormalizeToAncestorType();
                        if (AsNativeType(exprType) != null)
                        {
                            // JavaScript bitwise operators are weird (numeric operands are first converted into
                            // signed 32-bit values), and it could be easy to forget how weird they are.
                            // Therefore, as a protective measure, the following assert is here to catch against any future
                            // change that would render this translation incorrect.
                            Contract.Assert(exprType.AsBitVectorType.Width == 0);
                            wr.Write("0");
                        }
                        else
                        {
                            wr.Write("_dafny.BitwiseNot(");
                            wr.Append(Expr(expr, inLetExprBody, wStmts));
                            wr.Write(", {0})", exprType.AsBitVectorType.Width);
                        }
                        break;
                    }

                    break;
                case ResolvedUnaryOp.Cardinality:
                    TrParenExpr("new BigNumber(", expr, wr, inLetExprBody, wStmts);
                    if (expr.Type.NormalizeToAncestorType().AsMultiSetType != null)
                    {
                        wr.Write(".cardinality())");
                    }
                    else
                    {
                        wr.Write(".length)");
                    }
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
            return MutateCSharp.Schemata238.ReplaceBinExprOp_3(1202L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_3(1196L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_3(1189L, () => t.IsBoolType, () => (MutateCSharp.Schemata238.ReplaceBinExprOp_7(1183L, () => t.IsCharType, () => !UnicodeCharEnabled))), () => MutateCSharp.Schemata238.ReplaceBinExprOp_13(1195L, AsNativeType(t), null)), () => t.IsRefType);
        }

        bool IsRepresentedAsBigNumber(Type t)
        {
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_13(1208L, AsNativeType(t), null))
            {
                return MutateCSharp.Schemata238.ReplaceBooleanConstant_1(1209L, false);
            }
            else
            {
                return MutateCSharp.Schemata238.ReplaceBinExprOp_3(1216L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_3(1210L, () => t.IsNumericBased(Type.NumericPersuasion.Int)
        , () => t.NormalizeToAncestorType().IsBitVectorType
        ), () => t.IsBigOrdinalType);
            }

            return default;
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
            reverseArguments = MutateCSharp.Schemata238.ReplaceBooleanConstant_1(1222L, false);
            truncateResult = MutateCSharp.Schemata238.ReplaceBooleanConstant_1(1223L, false);
            convertE1_to_int = MutateCSharp.Schemata238.ReplaceBooleanConstant_1(1224L, false);
            coerceE1 = MutateCSharp.Schemata238.ReplaceBooleanConstant_1(1225L, false);

            switch (op)
            {
                case BinaryExpr.ResolvedOpcode.Iff:
                    opString = "==="; break;
                    break;
                case BinaryExpr.ResolvedOpcode.BitwiseAnd:
                    if (AsNativeType(resultType) != null)
                    {
                        // JavaScript bitwise operators are weird (numeric operands are first converted into
                        // signed 32-bit values), and it could be easy to forget how weird they are.
                        // Therefore, as a protective measure, the following assert is here to catch against any future
                        // change that would render this translation incorrect.
                        Contract.Assert(resultType.AsBitVectorType.Width < 32);
                        opString = "&";
                    }
                    else
                    {
                        staticCallString = "_dafny.BitwiseAnd";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.BitwiseOr:
                    if (AsNativeType(resultType) != null)
                    {
                        // JavaScript bitwise operators are weird (numeric operands are first converted into
                        // signed 32-bit values), and it could be easy to forget how weird they are.
                        // Therefore, as a protective measure, the following assert is here to catch against any future
                        // change that would render this translation incorrect.
                        Contract.Assert(resultType.AsBitVectorType.Width < 32);
                        opString = "|";
                    }
                    else
                    {
                        staticCallString = "_dafny.BitwiseOr";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.BitwiseXor:
                    if (AsNativeType(resultType) != null)
                    {
                        // JavaScript bitwise operators are weird (numeric operands are first converted into
                        // signed 32-bit values), and it could be easy to forget how weird they are.
                        // Therefore, as a protective measure, the following assert is here to catch against any future
                        // change that would render this translation incorrect.
                        Contract.Assert(resultType.AsBitVectorType.Width < 32);
                        opString = "^";
                    }
                    else
                    {
                        staticCallString = "_dafny.BitwiseXor";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.EqCommon:
                    {
                        var eqType = DatatypeWrapperEraser.SimplifyTypeAndTrimNewtypes(Options, e0.Type);
                        if (IsDirectlyComparable(eqType))
                        {
                            opString = "===";
                        }
                        else if (eqType.IsIntegerType || eqType.IsBitVectorType)
                        {
                            callString = "isEqualTo";
                        }
                        else if (eqType.IsRealType)
                        {
                            callString = "equals";
                        }
                        else
                        {
                            staticCallString = "_dafny.areEqual";
                        }
                        break;
                    }

                    break;
                case BinaryExpr.ResolvedOpcode.NeqCommon:
                    {
                        var eqType = DatatypeWrapperEraser.SimplifyTypeAndTrimNewtypes(Options, e0.Type);
                        if (IsDirectlyComparable(eqType))
                        {
                            opString = "!==";
                        }
                        else if (eqType.IsIntegerType)
                        {
                            preOpString = "!";
                            callString = "isEqualTo";
                        }
                        else if (eqType.IsRealType)
                        {
                            preOpString = "!";
                            callString = "equals";
                        }
                        else
                        {
                            preOpString = "!";
                            staticCallString = "_dafny.areEqual";
                        }
                        break;
                    }

                    break;
                case BinaryExpr.ResolvedOpcode.Lt:
                    if (AsNativeType(e0.Type) != null)
                    {
                        opString = "<";
                    }
                    else if (IsRepresentedAsBigNumber(e0.Type) || e0.Type.IsNumericBased(Type.NumericPersuasion.Real))
                    {
                        callString = "isLessThan";
                    }
                    else
                    {
                        Contract.Assert(false); throw new cce.UnreachableException();
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Le:
                    if (AsNativeType(e0.Type) != null)
                    {
                        opString = "<=";
                    }
                    else if (IsRepresentedAsBigNumber(e0.Type))
                    {
                        callString = "isLessThanOrEqualTo";
                    }
                    else if (e0.Type.IsNumericBased(Type.NumericPersuasion.Real))
                    {
                        callString = "isAtMost";
                    }
                    else
                    {
                        Contract.Assert(false); throw new cce.UnreachableException();
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Ge:
                    if (AsNativeType(e0.Type) != null)
                    {
                        opString = ">=";
                    }
                    else if (IsRepresentedAsBigNumber(e0.Type))
                    {
                        callString = "isLessThanOrEqualTo";
                        reverseArguments = true;
                    }
                    else if (e0.Type.IsNumericBased(Type.NumericPersuasion.Real))
                    {
                        callString = "isAtMost";
                        reverseArguments = true;
                    }
                    else
                    {
                        Contract.Assert(false); throw new cce.UnreachableException();
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Gt:
                    if (AsNativeType(e0.Type) != null)
                    {
                        opString = ">";
                    }
                    else if (IsRepresentedAsBigNumber(e0.Type) || e0.Type.IsNumericBased(Type.NumericPersuasion.Real))
                    {
                        callString = "isLessThan";
                        reverseArguments = true;
                    }
                    else
                    {
                        Contract.Assert(false); throw new cce.UnreachableException();
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.LtChar when UnicodeCharEnabled:
                    callString = "isLessThan";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.LeChar when UnicodeCharEnabled:
                    callString = "isLessThanOrEqual";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.GtChar when UnicodeCharEnabled:
                    callString = "isLessThan";
                    reverseArguments = true;
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.GeChar when UnicodeCharEnabled:
                    callString = "isLessThanOrEqual";
                    reverseArguments = true;
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.LeftShift:
                    if (AsNativeType(resultType) != null)
                    {
                        // JavaScript bitwise operators are weird (numeric operands are first converted into
                        // signed 32-bit values), and it could be easy to forget how weird they are.
                        // Therefore, as a protective measure, the following assert is here to catch against any future
                        // change that would render this translation incorrect.
                        Contract.Assert(resultType.AsBitVectorType.Width == 0);
                        opString = "+";  // 0 + 0 == 0 == 0 << 0
                        convertE1_to_int = true;
                    }
                    else
                    {
                        staticCallString = "_dafny.ShiftLeft";
                        truncateResult = true; convertE1_to_int = true;
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.RightShift:
                    if (AsNativeType(resultType) != null)
                    {
                        // JavaScript bitwise operators are weird (numeric operands are first converted into
                        // signed 32-bit values), and it could be easy to forget how weird they are.
                        // Therefore, as a protective measure, the following assert is here to catch against any future
                        // change that would render this translation incorrect.
                        Contract.Assert(resultType.AsBitVectorType.Width == 0);
                        opString = "+";  // 0 + 0 == 0 == 0 << 0
                        convertE1_to_int = true;
                    }
                    else
                    {
                        staticCallString = "_dafny.ShiftRight";
                        truncateResult = true; convertE1_to_int = true;
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Add:
                    if (resultType.IsIntegerType || resultType.IsRealType || resultType.IsBigOrdinalType)
                    {
                        callString = "plus"; truncateResult = true;
                    }
                    else if (AsNativeType(resultType) != null)
                    {
                        opString = "+";
                    }
                    else if (resultType.IsCharType)
                    {
                        staticCallString = $"_dafny.{CharMethodQualifier}PlusChar";
                    }
                    else
                    {
                        callString = "plus"; truncateResult = true;
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Sub:
                    if (resultType.IsIntegerType || resultType.IsRealType || resultType.IsBigOrdinalType)
                    {
                        callString = "minus"; truncateResult = true;
                    }
                    else if (AsNativeType(resultType) != null)
                    {
                        opString = "-";
                    }
                    else if (resultType.IsCharType)
                    {
                        staticCallString = $"_dafny.{CharMethodQualifier}MinusChar";
                    }
                    else
                    {
                        callString = "minus"; truncateResult = true;
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Mul:
                    if (resultType.IsIntegerType || resultType.IsRealType)
                    {
                        callString = "multipliedBy"; truncateResult = true;
                    }
                    else if (AsNativeType(resultType) != null)
                    {
                        opString = "*";
                    }
                    else
                    {
                        callString = "multipliedBy"; truncateResult = true;
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Div:
                    if (resultType.IsNumericBased(Type.NumericPersuasion.Real))
                    {
                        callString = "dividedBy";
                    }
                    else if (resultType.IsIntegerType || AsNativeType(resultType) == null)
                    {
                        staticCallString = "_dafny.EuclideanDivision";
                    }
                    else if (AsNativeType(resultType).LowerBound < BigInteger.Zero)
                    {
                        staticCallString = "_dafny.EuclideanDivisionNumber";
                    }
                    else
                    {
                        opString = "/";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Mod:
                    if (resultType.IsIntegerType)
                    {
                        callString = "mod";
                    }
                    else if (AsNativeType(resultType) == null)
                    {
                        callString = "mod";
                    }
                    else if (AsNativeType(resultType).LowerBound < BigInteger.Zero)
                    {
                        staticCallString = "_dafny.EuclideanModuloNumber";
                    }
                    else
                    {
                        opString = "%";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.SetEq:
                case BinaryExpr.ResolvedOpcode.MultiSetEq:
                case BinaryExpr.ResolvedOpcode.MapEq:
                    callString = "equals"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.SeqEq:
                    // a sequence may be represented as an array or as a string
                    staticCallString = "_dafny.areEqual"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.ProperSubset:
                case BinaryExpr.ResolvedOpcode.ProperMultiSubset:
                    callString = "IsProperSubsetOf"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Subset:
                case BinaryExpr.ResolvedOpcode.MultiSubset:
                    callString = "IsSubsetOf"; break;
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
                case BinaryExpr.ResolvedOpcode.Union:
                case BinaryExpr.ResolvedOpcode.MultiSetUnion:
                    callString = "Union"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.MapMerge:
                    callString = "Merge"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Intersection:
                case BinaryExpr.ResolvedOpcode.MultiSetIntersection:
                    callString = "Intersect"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.SetDifference:
                case BinaryExpr.ResolvedOpcode.MultiSetDifference:
                    callString = "Difference"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.MapSubtraction:
                    callString = "Subtract"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.ProperPrefix:
                    staticCallString = $"{DafnySeqClass}.IsProperPrefixOf"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Prefix:
                    staticCallString = $"{DafnySeqClass}.IsPrefixOf"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Concat:
                    staticCallString = $"{DafnySeqClass}.Concat"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.InSeq:
                    staticCallString = $"{DafnySeqClass}.contains"; reverseArguments = true; break;
                    break;
                default:
                    base.CompileBinOp(op, e0, e1, tok, resultType,
                      out opString, out preOpString, out postOpString, out callString, out staticCallString, out reverseArguments, out truncateResult, out convertE1_to_int, out coerceE1,
                      errorWr);
                    break;
                    break;
            }
        }

        protected override void EmitIsZero(string varName, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1226L, "{0}.isZero()"), varName);
        }

        protected override void EmitConversionExpr(Expression fromExpr, Type fromType, Type toType, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_3(1239L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_3(1233L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_3(1227L, () => fromType.IsNumericBased(Type.NumericPersuasion.Int), () => fromType.NormalizeToAncestorType().IsBitVectorType), () => fromType.IsCharType), () => fromType.IsBigOrdinalType))
            {
                if (toType.Equals(fromType))
                {
                    TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                }
                else if (toType.IsNumericBased(Type.NumericPersuasion.Real))
                {
                    // (int or bv or char) -> real
                    Contract.Assert(AsNativeType(toType) == null);
                    wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1245L, "new _dafny.BigRational("));
                    if (MutateCSharp.Schemata238.ReplaceBinExprOp_3(1247L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_13(1246L, AsNativeType(fromType), null), () => fromType.IsCharType))
                    {
                        wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1253L, "new BigNumber"));
                    }
                    if (fromType.IsCharType)
                    {
                        wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1254L, "("));
                    }

                    TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                    if (fromType.IsCharType)
                    {
                        wr.Write(UnicodeCharEnabled ? MutateCSharp.Schemata238.ReplaceStringConstant_0(1255L, ".value)") : MutateCSharp.Schemata238.ReplaceStringConstant_0(1256L, ".charCodeAt(0))"));
                    }

                    wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1257L, ", new BigNumber(1))"));
                }
                else if (toType.IsCharType)
                {
                    if (fromType.IsCharType)
                    {
                        EmitExpr(fromExpr, inLetExprBody, wr, wStmts);
                    }
                    else
                    {
                        wr.Write($"{CharFromNumberMethodName()}(");
                        TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                        if (MutateCSharp.Schemata238.ReplaceBinExprOp_15(1258L, AsNativeType(fromType), null))
                        {
                            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1259L, ".toNumber()"));
                        }
                        wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1260L, ")"));
                    }
                }
                else
                {
                    // (int or bv or char) -> (int or bv or ORDINAL)
                    var fromNative = AsNativeType(fromType);
                    var toNative = AsNativeType(toType);
                    if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(1263L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_13(1261L, fromNative, null), () => MutateCSharp.Schemata238.ReplaceBinExprOp_13(1262L, toNative, null)))
                    {
                        // from a native, to a native -- simple!
                        wr.Append(Expr(fromExpr, inLetExprBody, wStmts));
                    }
                    else if (fromType.IsCharType)
                    {
                        Contract.Assert(fromNative == null);
                        if (MutateCSharp.Schemata238.ReplaceBinExprOp_15(1269L, toNative, null))
                        {
                            // char -> big-integer (int or bv or ORDINAL)
                            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1270L, "new BigNumber("));
                            TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                            wr.Write(UnicodeCharEnabled ? MutateCSharp.Schemata238.ReplaceStringConstant_0(1271L, ".value)") : MutateCSharp.Schemata238.ReplaceStringConstant_0(1272L, ".charCodeAt(0))"));
                        }
                        else
                        {
                            // char -> native
                            TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                            wr.Write(UnicodeCharEnabled ? MutateCSharp.Schemata238.ReplaceStringConstant_0(1273L, ".value") : MutateCSharp.Schemata238.ReplaceStringConstant_0(1274L, ".charCodeAt(0)"));
                        }
                    }
                    else if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(1277L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_15(1275L, fromNative, null), () => MutateCSharp.Schemata238.ReplaceBinExprOp_15(1276L, toNative, null)))
                    {
                        // big-integer (int or bv) -> big-integer (int or bv or ORDINAL), so identity will do
                        wr.Append(Expr(fromExpr, inLetExprBody, wStmts));
                    }
                    else if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(1285L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_13(1283L, fromNative, null), () => MutateCSharp.Schemata238.ReplaceBinExprOp_15(1284L, toNative, null)))
                    {
                        // native (int or bv) -> big-integer (int or bv)
                        wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1291L, "new BigNumber"));
                        TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
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
                            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1292L, "(") + literal + MutateCSharp.Schemata238.ReplaceStringConstant_0(1293L, ")"));
                        }
                        else if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(1296L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_33(1294L, u, null), () => MutateCSharp.Schemata238.ReplaceBinExprOp_34(1295L, u.Op, UnaryOpExpr.Opcode.Cardinality)))
                        {
                            // Optimize .Count to avoid intermediate BigInteger
                            TrParenExpr(u.E, wr, inLetExprBody, wStmts);
                            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1302L, ".length"));
                        }
                        else if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(1312L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_7(1306L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_35(1303L, m, null), () => MutateCSharp.Schemata238.ReplaceBinExprOp_23(1305L, m.MemberName, MutateCSharp.Schemata238.ReplaceStringConstant_0(1304L, "Length"))), () => m.Obj.Type.IsArrayType))
                        {
                            // Optimize .Length to avoid intermediate BigInteger
                            TrParenExpr(m.Obj, wr, inLetExprBody, wStmts);
                            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1318L, ".length"));
                        }
                        else
                        {
                            // no optimization applies; use the standard translation
                            TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1319L, ".toNumber()"));
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
                else if (toType.IsCharType)
                {
                    wr.Write($"{CharFromNumberMethodName()}(");
                    TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                    wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1320L, ".toBigNumber().toNumber())"));
                }
                else
                {
                    // real -> (int or bv)
                    TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                    wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1321L, ".toBigNumber()"));
                    if (MutateCSharp.Schemata238.ReplaceBinExprOp_13(1322L, AsNativeType(toType), null))
                    {
                        wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1323L, ".toNumber()"));
                    }
                }
            }
            else if (fromType.IsBigOrdinalType)
            {
                if (toType.IsCharType)
                {
                    wr.Write($"{CharFromNumberMethodName()}((");
                }

                wr.Append(Expr(fromExpr, inLetExprBody, wStmts));
                if (toType.IsCharType)
                {
                    wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1324L, ").toNumber())"));
                }
            }
            else if (MutateCSharp.Schemata238.ReplaceBinExprOp_3(1333L, () => MutateCSharp.Schemata238.ReplaceBinExprOp_3(1326L, () => fromType.Equals(toType), () => MutateCSharp.Schemata238.ReplaceBinExprOp_17(1325L, fromType.AsNewtype, null)), () => MutateCSharp.Schemata238.ReplaceBinExprOp_17(1332L, toType.AsNewtype, null)))
            {
                wr.Append(Expr(fromExpr, inLetExprBody, wStmts));
            }
            else
            {
                Contract.Assert(false, $"not implemented for javascript: {fromType} -> {toType}");
            }
        }

        protected override void EmitTypeTest(string localName, Type fromType, Type toType, IToken tok, ConcreteSyntaxTree wr)
        {
            if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(1339L, () => fromType.IsRefType, () => !fromType.IsNonNullRefType))
            {
                Contract.Assert(toType.IsRefType);
                if (toType.IsNonNullRefType)
                {
                    wr.Write($"{localName} != null && ");
                }
                else
                {
                    wr.Write($"{localName} == null || ");
                }
            }

            if (MutateCSharp.Schemata238.ReplaceBinExprOp_3(1345L, () => toType.IsObject, () => toType.IsObjectQ))
            {
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1351L, "true"));
            }
            else if (toType.IsTraitType)
            {
                wr.Write($"_dafny.InstanceOfTrait({localName}, {TypeName(toType, wr, tok)})");
            }
            else if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(1353L, () => fromType.IsTraitType, () => MutateCSharp.Schemata238.ReplaceBinExprOp_17(1352L, toType.AsNewtype, null)))
            {
                wr.Write($"{localName} instanceof {toType.AsNewtype.GetFullCompileName(Options)}");
            }
            else
            {
                wr.Write($"{localName} instanceof {TypeName(toType, wr, tok)}");
            }
        }

        protected override void EmitIsIntegerTest(Expression source, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            EmitExpr(source, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(1359L, false), wr.ForkInParens(), wStmts);
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1360L, ".isInteger() && "));
        }

        protected override void EmitIsUnicodeScalarValueTest(Expression source, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1361L, "_dafny.CodePoint.isCodePoint"));
            EmitExpr(source, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(1362L, false), wr.ForkInParens(), wStmts);
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1363L, " && "));
        }

        protected override void EmitIsInIntegerRange(Expression source, BigInteger lo, BigInteger hi, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            EmitLiteralExpr(wr.ForkInParens(), new LiteralExpr(source.tok, lo) { Type = Type.Int });
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1364L, ".isLessThanOrEqualTo"));
            EmitExpr(source, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(1365L, false), wr.ForkInParens(), wStmts);
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1366L, " && "));

            EmitExpr(source, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(1367L, false), wr.ForkInParens(), wStmts);
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1368L, ".isLessThan"));
            EmitLiteralExpr(wr.ForkInParens(), new LiteralExpr(source.tok, hi) { Type = Type.Int });
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1369L, " && "));
        }

        protected override void EmitCollectionDisplay(CollectionType ct, IToken tok, List<Expression> elements,
            bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (ct is SetType)
            {
                wr.Write($"{DafnySetClass}.fromElements");
                TrExprList(elements, wr, inLetExprBody, wStmts);
            }
            else if (ct is MultiSetType)
            {
                wr.Write($"{DafnyMultiSetClass}.fromElements");
                TrExprList(elements, wr, inLetExprBody, wStmts);
            }
            else
            {
                Contract.Assert(ct is SeqType);  // follows from precondition
                ConcreteSyntaxTree wrElements;
                if (MutateCSharp.Schemata238.ReplaceBinExprOp_7(1370L, () => ct.Arg.IsCharType, () => !UnicodeCharEnabled))
                {
                    // We're really constructing a string.
                    // TODO: It may be that ct.Arg is a type parameter that may stand for char. We currently don't catch that case here.
                    wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1376L, "["));
                    wrElements = wr.Fork();
                    wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1377L, "].join(\"\")"));
                }
                else
                {
                    wr.Write($"{DafnySeqClass}.of(");
                    wrElements = wr.Fork();
                    wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1378L, ")"));
                }
                TrExprList(elements, wrElements, inLetExprBody, wStmts, typeAt: _ => ct.Arg, parens: MutateCSharp.Schemata238.ReplaceBooleanConstant_1(1379L, false));
            }
        }

        protected override void EmitMapDisplay(MapType mt, IToken tok, List<ExpressionPair> elements,
            bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write($"{DafnyMapClass}.Empty.slice()");
            foreach (ExpressionPair p in elements)
            {
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1380L, ".updateUnsafe("));
                wr.Append(Expr(p.A, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1381L, ","));
                wr.Append(Expr(p.B, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1382L, ")"));
            }
        }

        protected override void EmitSetBuilder_New(ConcreteSyntaxTree wr, SetComprehension e, string collectionName)
        {
            var wrVarInit = DeclareLocalVar(collectionName, null, null, wr);
            wrVarInit.Write($"new {DafnySetClass}()");
        }

        protected override void EmitMapBuilder_New(ConcreteSyntaxTree wr, MapComprehension e, string collectionName)
        {
            var wrVarInit = DeclareLocalVar(collectionName, null, null, wr);
            wrVarInit.Write($"new {DafnyMapClass}()");
        }

        protected override void EmitSetBuilder_Add(CollectionType ct, string collName, Expression elmt, bool inLetExprBody, ConcreteSyntaxTree wr)
        {
            Contract.Assume(ct is SetType || ct is MultiSetType);  // follows from precondition
            var wStmts = wr.Fork();
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1383L, "{0}.add("), collName);
            wr.Append(Expr(elmt, inLetExprBody, wStmts));
            wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(1384L, ");"));
        }

        protected override ConcreteSyntaxTree EmitMapBuilder_Add(MapType mt, IToken tok, string collName, Expression term, bool inLetExprBody, ConcreteSyntaxTree wr)
        {
            var wStmts = wr.Fork();
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1385L, "{0}.push(["), collName);
            var termLeftWriter = wr.Fork();
            wr.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1386L, ","));
            wr.Append(Expr(term, inLetExprBody, wStmts));
            wr.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(1387L, "]);"));
            return termLeftWriter;
        }

        protected override void GetCollectionBuilder_Build(CollectionType ct, IToken tok, string collName,
          ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmt)
        {
            // collections are built in place
            wr.Write(collName);
        }

        protected override void EmitSingleValueGenerator(Expression e, bool inLetExprBody, string type, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            TrParenExpr(MutateCSharp.Schemata238.ReplaceStringConstant_0(1388L, "_dafny.SingleValue"), e, wr, inLetExprBody, wStmts);
        }

        protected override void EmitHaltRecoveryStmt(Statement body, string haltMessageVarName, Statement recoveryBody, ConcreteSyntaxTree wr)
        {
            var tryBlock = wr.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(1389L, "try"));
            TrStmt(body, tryBlock);
            var catchBlock = wr.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(1390L, "catch (e)"));
            var ifBlock = catchBlock.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(1391L, "if (e instanceof _dafny.HaltException)"));
            ifBlock.Write($"let {haltMessageVarName} = ");
            if (UnicodeCharEnabled)
            {
                ifBlock.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1392L, "_dafny.Seq.UnicodeFromString(e.message)"));
            }
            else
            {
                ifBlock.Write(MutateCSharp.Schemata238.ReplaceStringConstant_0(1393L, "e.message"));
            }
            ifBlock.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(1394L, ";"));

            TrStmt(recoveryBody, ifBlock);
            var elseBlock = catchBlock.NewBlock(MutateCSharp.Schemata238.ReplaceStringConstant_0(1395L, "else"));
            elseBlock.WriteLine(MutateCSharp.Schemata238.ReplaceStringConstant_0(1396L, "throw e"));
        }

        public string ToStringLiteral(string s)
        {
            var wr = new ConcreteSyntaxTree();
            EmitStringLiteral(s, MutateCSharp.Schemata238.ReplaceBooleanConstant_1(1397L, false), wr);
            return wr.ToString();
        }
    }
}
