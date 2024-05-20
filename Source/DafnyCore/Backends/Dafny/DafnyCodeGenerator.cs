using System;
using System.Collections.Generic;
using Dafny;
using JetBrains.Annotations;
using DAST;
using System.Numerics;
using Microsoft.BaseTypes;
using System.Linq;
using System.Diagnostics.Contracts;
using DAST.Format;
using Std.Wrappers;
namespace MutateCSharp
{
    internal class Schemata223
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT223");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.TypeParameter.TPVariance argument1, Microsoft.Dafny.TypeParameter.TPVariance argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_33(long mutantId, object argument1, Microsoft.Dafny.Compilers.ExprBuffer argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceNumericConstant_11(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_41(long mutantId, Microsoft.Dafny.SetType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_36(long mutantId, Microsoft.Dafny.SpecialField.ID argument1, Microsoft.Dafny.SpecialField.ID argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_26(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_29(long mutantId, DAST.AssignLhs argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_38(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.SubsetTypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_35(long mutantId, Microsoft.Dafny.Compilers.DatatypeWrapperEraser.MemberCompileStatus argument1, Microsoft.Dafny.Compilers.DatatypeWrapperEraser.MemberCompileStatus argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static int ReplacePrefixUnaryExprOp_40(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return ++argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return +argument1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return ~argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return --argument1; }
            return ++argument1;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.Type argument1, Microsoft.Dafny.Type argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_39(long mutantId, DAST.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, Std.Wrappers._IOption<DAST._IExpression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, Microsoft.Dafny.NativeType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_28(long mutantId, Microsoft.Dafny.Method argument1, Microsoft.Dafny.Method argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.SubsetTypeDecl.WKind argument1, Microsoft.Dafny.SubsetTypeDecl.WKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, Microsoft.Dafny.DatatypeDecl argument1, object argument2)
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

        internal static bool ReplaceBinExprOp_14(long mutantId, Microsoft.Dafny.TypeParameter.EqualitySupportValue argument1, Microsoft.Dafny.TypeParameter.EqualitySupportValue argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_30(long mutantId, Microsoft.Dafny.Compilers.StatementContainer argument1, Microsoft.Dafny.Compilers.StatementContainer argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_37(long mutantId, Microsoft.Dafny.SpecialField.ID argument1, Microsoft.Dafny.SpecialField.ID argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, Microsoft.Dafny.NewtypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_34(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, Std.Wrappers._IOption<DAST._IExpression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_32(long mutantId, Microsoft.Dafny.ArrayClassDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.Compilers.ProgramBuilder argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_31(long mutantId, Microsoft.Dafny.Constructor argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny.Compilers
{
    public
      class DafnyCodeGenerator : SinglePassCodeGenerator
    {
        ProgramBuilder items;
        public object currentBuilder;
        public bool emitUncompilableCode;
        public bool preventShadowing;

        public void Start()
        {
            if (MutateCSharp.Schemata223.ReplaceBinExprOp_0(1L, items, null))
            {
                throw new InvalidOperationException("");
            }

            items = new ProgramBuilder();
            this.currentBuilder = items;
        }

        public List<Module> Build()
        {
            var res = items.Finish();
            items = null;
            this.currentBuilder = null;
            return res;
        }

        public DafnyCodeGenerator(DafnyOptions options, ErrorReporter reporter, bool preventShadowing, bool canEmitUncompilableCode) : base(options, reporter)
        {
            options.SystemModuleTranslationMode = CommonOptionBag.SystemModuleMode.Include;
            if (Options?.CoverageLegendFile != null)
            {
                Imports.Add(MutateCSharp.Schemata223.ReplaceStringConstant_1(2L, "DafnyProfiling"));
            }

            emitUncompilableCode = MutateCSharp.Schemata223.ReplaceBinExprOp_2(3L, () => options.Get(CommonOptionBag.EmitUncompilableCode), () => canEmitUncompilableCode);
            this.preventShadowing = preventShadowing;
        }

        protected override string GetCompileNameNotProtected(IVariable v)
        {
            return preventShadowing ? v.CompileName : v.SanitizedNameShadowable;
        }

        public void AddUnsupported(string why)
        {
            if (emitUncompilableCode && currentBuilder is Container container)
            {
                container.AddUnsupported(why);
            }
            else
            {
                throw new UnsupportedInvalidOperationException(why);
            }
        }

        public void AddUnsupportedFeature(IToken token, Feature feature)
        {
            if (emitUncompilableCode && currentBuilder is Container container)
            {
                container.AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(9L, "<i>") + feature.ToString() + MutateCSharp.Schemata223.ReplaceStringConstant_1(10L, "</i>"));
            }
            else
            {
                throw new RecoverableUnsupportedFeatureException(token, feature);
            }
        }

        public override IReadOnlySet<Feature> UnsupportedFeatures => new HashSet<Feature> {
      Feature.Ordinals,
      Feature.Iterators,
      Feature.Multisets,
      Feature.MapComprehensions,
      Feature.MethodSynthesis,
      Feature.ExternalClasses,
      Feature.NewObject,
      Feature.NonSequentializableForallStatements,
      Feature.MapItems,
      Feature.RunAllTests,
      Feature.ExactBoundedPool,
      Feature.SequenceDisplaysOfCharacters,
      Feature.TypeTests,
      Feature.SubsetTypeTests,
      Feature.BitvectorRotateFunctions,
      Feature.AssignSuchThatWithNonFiniteBounds,
      Feature.SequenceUpdateExpressions,
      Feature.SequenceConstructionsWithNonLambdaInitializers,
      Feature.ExternalConstructors,
      Feature.SubtypeConstraintsInQuantifiers,
      Feature.TuplesWiderThan20,
      Feature.ForLoops,
      Feature.Traits,
      Feature.RuntimeCoverageReport,
      Feature.MultiDimensionalArrays,
      Feature.NonNativeNewtypes
    };

        private readonly List<string> Imports = new() { DafnyDefaultModule };

        private const string DafnyRuntimeModule = "_dafny";
        private const string DafnyDefaultModule = "module_";

        protected override string AssignmentSymbol { get => null; }

        protected override void EmitHeader(Program program, ConcreteSyntaxTree wr)
        {
        }

        public override void EmitCallToMain(Method mainMethod, string baseName, ConcreteSyntaxTree wr)
        {
            AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(11L, "<i>Call to main</i>"));
        }

        protected override ConcreteSyntaxTree CreateStaticMain(IClassWriter cw, string argsParameterName)
        {
            AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(12L, "<i>create static main</i>"));
            return new BuilderSyntaxTree<ExprContainer>(
              new ExprBuffer(this), this);
        }

        protected override ConcreteSyntaxTree CreateModule(string moduleName, bool isDefault, ModuleDefinition externModule,
          string libraryName, ConcreteSyntaxTree wr)
        {
            if (currentBuilder is ModuleContainer moduleBuilder)
            {
                currentBuilder = moduleBuilder.Module(moduleName, MutateCSharp.Schemata223.ReplaceBinExprOp_3(13L, externModule, null));
            }
            else
            {
                throw new InvalidOperationException();
            }

            return wr;
        }

        protected override void FinishModule()
        {
            if (currentBuilder is ModuleBuilder builder)
            {
                currentBuilder = builder.Finish();
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected override string GetHelperModuleName() => DafnyRuntimeModule;

        private static string MangleName(string name)
        {
            return name;
        }

        protected override ConcreteSyntaxTree EmitCoercionIfNecessary(Type from, Type to, IToken tok, ConcreteSyntaxTree wr, Type toOrig = null)
        {
            if (currentBuilder is ExprBuffer buf && wr is not BuilderSyntaxTree<ExprContainer>)
            {
                // the writers are not currently wired properly for DatatypeValue
                wr = new BuilderSyntaxTree<ExprContainer>(buf, this);
            }

            if (MutateCSharp.Schemata223.ReplaceBinExprOp_4(14L, from, to))
            {
                return wr;
            }

            if (MutateCSharp.Schemata223.ReplaceBinExprOp_2(29L, () => MutateCSharp.Schemata223.ReplaceBinExprOp_2(17L, () => MutateCSharp.Schemata223.ReplaceBinExprOp_5(15L, from, null), () => MutateCSharp.Schemata223.ReplaceBinExprOp_5(16L, to, null)), () => MutateCSharp.Schemata223.ReplaceBinExprOp_6(23L, () => from.IsNonNullRefType, () => to.IsNonNullRefType)))
            {
                if (wr is BuilderSyntaxTree<ExprContainer> stmt)
                {
                    var nullConvert = stmt.Builder.Convert(GenType(from), GenType(to));

                    if (from is UserDefinedType fromUdt && fromUdt.ResolvedClass is NonNullTypeDecl fromNonNull)
                    {
                        from = fromNonNull.RhsWithArgument(fromUdt.TypeArgs);
                    }

                    if (to is UserDefinedType toUdt && toUdt.ResolvedClass is NonNullTypeDecl toNonNull)
                    {
                        to = toNonNull.RhsWithArgument(toUdt.TypeArgs);
                    }

                    return EmitCoercionIfNecessary(from, to, tok, new BuilderSyntaxTree<ExprContainer>(nullConvert, this));
                }
                else
                {
                    return base.EmitCoercionIfNecessary(from, to, tok, wr);
                }
            }
            else if (MutateCSharp.Schemata223.ReplaceBinExprOp_2(51L, () => MutateCSharp.Schemata223.ReplaceBinExprOp_2(37L, () => MutateCSharp.Schemata223.ReplaceBinExprOp_5(35L, from, null), () => MutateCSharp.Schemata223.ReplaceBinExprOp_5(36L, to, null)), () => (MutateCSharp.Schemata223.ReplaceBinExprOp_8(45L, () => MutateCSharp.Schemata223.ReplaceBinExprOp_7(43L, from.AsSubsetType, null), () => MutateCSharp.Schemata223.ReplaceBinExprOp_7(44L, to.AsSubsetType, null)))))
            {
                if (wr is BuilderSyntaxTree<ExprContainer> stmt)
                {
                    return new BuilderSyntaxTree<ExprContainer>(stmt.Builder.Convert(GenType(from), GenType(to)), this);
                }
                else
                {
                    return base.EmitCoercionIfNecessary(from, to, tok, wr);
                }
            }
            else
            {
                if (MutateCSharp.Schemata223.ReplaceBinExprOp_8(66L, () => MutateCSharp.Schemata223.ReplaceBinExprOp_8(59L, () => MutateCSharp.Schemata223.ReplaceBinExprOp_9(57L, from, null), () => MutateCSharp.Schemata223.ReplaceBinExprOp_9(58L, to, null)), () => from.Equals(to, MutateCSharp.Schemata223.ReplaceBooleanConstant_10(65L, true))))
                {
                    return wr;
                }
                else
                {
                    AddUnsupported($"<i>Coercion</i> from {from} to {to}");
                    return new BuilderSyntaxTree<ExprContainer>(
                      new ExprBuffer(this), this);
                }
            }

            return default;
        }

        protected override IClassWriter CreateClass(string moduleName, string name, bool isExtern, string fullPrintName,
          List<TypeParameter> typeParameters, TopLevelDecl cls, List<Type> superClasses, IToken tok, ConcreteSyntaxTree wr)
        {
            if (currentBuilder is ClassContainer builder)
            {
                List<DAST.Type> typeParams = new();
                foreach (var tp in typeParameters)
                {
                    var compileName = IdProtect(tp.GetCompileName(Options));
                    if (!isTpSupported(tp, out var why))
                    {
                        AddUnsupported(why);
                    }

                    typeParams.Add((DAST.Type)DAST.Type.create_TypeArg(Sequence<Rune>.UnicodeFromString(compileName)));
                }

                return new ClassWriter(this, MutateCSharp.Schemata223.ReplaceBinExprOp_12(76L, typeParams.Count, MutateCSharp.Schemata223.ReplaceNumericConstant_11(72L, 0)), builder.Class(name, moduleName, typeParams, superClasses.Select(t => GenType(t)).ToList()));
            }
            else
            {
                throw new InvalidOperationException();
            }

            return default;
        }

        protected override IClassWriter CreateTrait(string name, bool isExtern, List<TypeParameter> typeParameters,
          TraitDecl trait, List<Type> superClasses, IToken tok, ConcreteSyntaxTree wr)
        {

            if (currentBuilder is TraitContainer builder)
            {
                List<DAST.Type> typeParams = new();
                foreach (var tp in trait.TypeArgs)
                {
                    typeParams.Add((DAST.Type)DAST.Type.create_TypeArg(Sequence<Rune>.UnicodeFromString(IdProtect(tp.GetCompileName(Options)))));
                }

                return new ClassWriter(this, typeParameters.Any(), builder.Trait(name, typeParams));
            }
            else
            {
                throw new InvalidOperationException();
            }

            return default;
        }

        protected override ConcreteSyntaxTree CreateIterator(IteratorDecl iter, ConcreteSyntaxTree wr)
        {
            AddUnsupportedFeature(iter.tok, Feature.Iterators);
            return wr;
        }

        private static bool isTpSupported(TypeParameter tp, [CanBeNull] out string why)
        {
            if (MutateCSharp.Schemata223.ReplaceBinExprOp_13(81L, tp.Variance, TypeParameter.TPVariance.Non))
            {
                why = $"<b>Unsupported: <i>Type variance {tp.Variance} not supported</i></b>";
                return MutateCSharp.Schemata223.ReplaceBooleanConstant_10(82L, false);
            }

            if (MutateCSharp.Schemata223.ReplaceBinExprOp_14(83L, tp.Characteristics.EqualitySupport, TypeParameter.EqualitySupportValue.Unspecified))
            {
                why = $"<b>Unsupported: <i>Type parameter Equality support {tp.Characteristics.EqualitySupport} not supported for type parameters</i></b>";
                return MutateCSharp.Schemata223.ReplaceBooleanConstant_10(84L, false);
            }

            why = null;
            return MutateCSharp.Schemata223.ReplaceBooleanConstant_10(85L, true);
        }

        protected override IClassWriter DeclareDatatype(DatatypeDecl dt, ConcreteSyntaxTree wr)
        {
            if (currentBuilder is DatatypeContainer builder)
            {
                List<DAST.Type> typeParams = new();
                foreach (var tp in dt.TypeArgs)
                {
                    var compileName = IdProtect(tp.GetCompileName(Options));
                    if (!isTpSupported(tp, out var why) && !(dt is TupleTypeDecl))
                    {
                        AddUnsupported(why);
                    }

                    typeParams.Add((DAST.Type)DAST.Type.create_TypeArg(Sequence<Rune>.UnicodeFromString(compileName)));
                }

                List<DAST.DatatypeCtor> ctors = new();
                foreach (var ctor in dt.Ctors)
                {
                    List<DAST.Formal> args = new();
                    foreach (var arg in ctor.Formals)
                    {
                        if (!arg.IsGhost)
                        {
                            args.Add((DAST.Formal)DAST.Formal.create_Formal(Sequence<Rune>.UnicodeFromString(arg.CompileName), GenType(arg.Type)));
                        }
                    }
                    ctors.Add((DAST.DatatypeCtor)DAST.DatatypeCtor.create_DatatypeCtor(Sequence<Rune>.UnicodeFromString(ctor.GetCompileName(Options)), Sequence<DAST.Formal>.FromArray(args.ToArray()), MutateCSharp.Schemata223.ReplaceBinExprOp_12(90L, ctor.Formals.Count, MutateCSharp.Schemata223.ReplaceNumericConstant_11(86L, 0))));
                }

                return new ClassWriter(this, MutateCSharp.Schemata223.ReplaceBinExprOp_12(99L, typeParams.Count, MutateCSharp.Schemata223.ReplaceNumericConstant_11(95L, 0)), builder.Datatype(
                  dt.GetCompileName(Options),
                  dt.EnclosingModuleDefinition.GetCompileName(Options),
                  typeParams,
                  ctors,
                  dt is CoDatatypeDecl
                ));
            }
            else
            {
                throw new InvalidOperationException(MutateCSharp.Schemata223.ReplaceStringConstant_1(104L, "Cannot declare datatype outside of a module: ") + currentBuilder);
            }

            return default;
        }

        protected override IClassWriter DeclareNewtype(NewtypeDecl nt, ConcreteSyntaxTree wr)
        {
            if (currentBuilder is NewtypeContainer builder)
            {
                var erasedType = EraseNewtypeLayers(nt);

                List<DAST.Statement> witnessStmts = new();
                DAST.Expression witness = null;
                var buf = new ExprBuffer(null);
                var statementBuf = new StatementBuffer();
                if (MutateCSharp.Schemata223.ReplaceBinExprOp_15(105L, nt.WitnessKind, SubsetTypeDecl.WKind.Compiled))
                {
                    EmitExpr(
                      nt.Witness, MutateCSharp.Schemata223.ReplaceBooleanConstant_10(106L, false),
                      EmitCoercionIfNecessary(nt.Witness.Type, erasedType, null,
                        new BuilderSyntaxTree<ExprContainer>(buf, this)),
                      new BuilderSyntaxTree<StatementContainer>(statementBuf, this)
                    );
                    witness = buf.Finish();
                    witnessStmts = statementBuf.PopAll();
                }

                return new ClassWriter(this, MutateCSharp.Schemata223.ReplaceBooleanConstant_10(107L, false), builder.Newtype(
                  nt.GetCompileName(Options), new(),
                  GenType(erasedType), NativeTypeToNewtypeRange(nt.NativeType), witnessStmts, witness));
            }
            else
            {
                throw new InvalidOperationException();
            }

            return default;
        }

        private DAST.Type GenType(Type typ)
        {
            // TODO(shadaj): this is leaking Rust types into the AST, but we do need native types
            var xType = DatatypeWrapperEraser.SimplifyTypeAndTrimSubsetTypes(Options, typ);

            if (xType is BoolType)
            {
                return (DAST.Type)DAST.Type.create_Primitive(DAST.Primitive.create_Bool());
            }
            else if (xType is IntType)
            {
                return (DAST.Type)DAST.Type.create_Primitive(DAST.Primitive.create_Int());
            }
            else if (xType is RealType)
            {
                return (DAST.Type)DAST.Type.create_Primitive(DAST.Primitive.create_Real());
            }
            else if (xType.IsStringType)
            {
                return (DAST.Type)DAST.Type.create_Primitive(DAST.Primitive.create_String());
            }
            else if (xType.IsCharType)
            {
                return (DAST.Type)DAST.Type.create_Primitive(DAST.Primitive.create_Char());
            }
            else if (xType is UserDefinedType udt)
            {
                if (udt.ResolvedClass is TypeParameter tp)
                {
                    if (MutateCSharp.Schemata223.ReplaceBinExprOp_16(108L, thisContext, null) && thisContext.ParentFormalTypeParametersToActuals.TryGetValue(tp, out var instantiatedTypeParameter))
                    {
                        return GenType(instantiatedTypeParameter);
                    }
                }

                return FullTypeNameAST(udt, null);
            }
            else if (MutateCSharp.Schemata223.ReplaceBinExprOp_17(109L, AsNativeType(typ), null))
            {
                return (DAST.Type)(AsNativeType(typ).Sel switch
                {
                    NativeType.Selection.Byte => DAST.Type.create_Passthrough(Sequence<Rune>.UnicodeFromString(MutateCSharp.Schemata223.ReplaceStringConstant_1(110L, "u8"))),
                    NativeType.Selection.SByte => DAST.Type.create_Passthrough(Sequence<Rune>.UnicodeFromString(MutateCSharp.Schemata223.ReplaceStringConstant_1(111L, "i8"))),
                    NativeType.Selection.Short => DAST.Type.create_Passthrough(Sequence<Rune>.UnicodeFromString(MutateCSharp.Schemata223.ReplaceStringConstant_1(112L, "i16"))),
                    NativeType.Selection.UShort => DAST.Type.create_Passthrough(Sequence<Rune>.UnicodeFromString(MutateCSharp.Schemata223.ReplaceStringConstant_1(113L, "u16"))),
                    NativeType.Selection.Int => DAST.Type.create_Passthrough(Sequence<Rune>.UnicodeFromString(MutateCSharp.Schemata223.ReplaceStringConstant_1(114L, "i32"))),
                    NativeType.Selection.UInt => DAST.Type.create_Passthrough(Sequence<Rune>.UnicodeFromString(MutateCSharp.Schemata223.ReplaceStringConstant_1(115L, "u32"))),
                    NativeType.Selection.Long => DAST.Type.create_Passthrough(Sequence<Rune>.UnicodeFromString(MutateCSharp.Schemata223.ReplaceStringConstant_1(116L, "i64"))),
                    NativeType.Selection.ULong => DAST.Type.create_Passthrough(Sequence<Rune>.UnicodeFromString(MutateCSharp.Schemata223.ReplaceStringConstant_1(117L, "u64"))),
                    NativeType.Selection.DoubleLong => DAST.Type.create_Passthrough(Sequence<Rune>.UnicodeFromString(MutateCSharp.Schemata223.ReplaceStringConstant_1(118L, "i128"))),
                    NativeType.Selection.UDoubleLong => DAST.Type.create_Passthrough(Sequence<Rune>.UnicodeFromString(MutateCSharp.Schemata223.ReplaceStringConstant_1(119L, "u128"))),
                    _ => throw new InvalidOperationException(),
                });
            }
            else if (xType is SeqType seq)
            {
                var argType = seq.Arg;
                return (DAST.Type)DAST.Type.create_Seq(GenType(argType));
            }
            else if (xType is SetType set)
            {
                var argType = set.Arg;
                return (DAST.Type)DAST.Type.create_Set(GenType(argType));
            }
            else if (xType is MultiSetType multiSet)
            {
                var argType = multiSet.Arg;
                return (DAST.Type)DAST.Type.create_Multiset(GenType(argType));
            }
            else if (xType is MapType map)
            {
                var keyType = map.Domain;
                var valueType = map.Range;
                return (DAST.Type)DAST.Type.create_Map(GenType(keyType), GenType(valueType));
            }
            else if (xType is BitvectorType)
            {
                AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(120L, "<i>Bitvector types</i>"));
                return (DAST.Type)DAST.Type.create_Passthrough(Sequence<Rune>.UnicodeFromString(MutateCSharp.Schemata223.ReplaceStringConstant_1(121L, "Missing feature: Bitvector types")));
            }
            else
            {
                var why = MutateCSharp.Schemata223.ReplaceStringConstant_1(122L, "<i>Type name for ") + xType + MutateCSharp.Schemata223.ReplaceStringConstant_1(123L, " (") + typ.GetType() + MutateCSharp.Schemata223.ReplaceStringConstant_1(124L, ")</i>");
                AddUnsupported(why);
                return (DAST.Type)DAST.Type.create_Passthrough(Sequence<Rune>.UnicodeFromString($"<b>Unsupported: {why}</b>"));
            }

            return default;
        }

        protected override void DeclareSubsetType(SubsetTypeDecl sst, ConcreteSyntaxTree wr)
        {
            if (currentBuilder is NewtypeContainer builder)
            {
                var erasedType = EraseNewtypeLayers(sst);

                List<DAST.Statement> witnessStmts = new();
                DAST.Expression witness = null;
                var statementBuf = new StatementBuffer();
                var buf = new ExprBuffer(null);
                if (MutateCSharp.Schemata223.ReplaceBinExprOp_15(125L, sst.WitnessKind, SubsetTypeDecl.WKind.Compiled))
                {
                    EmitExpr(
                      sst.Witness, MutateCSharp.Schemata223.ReplaceBooleanConstant_10(126L, false),
                      EmitCoercionIfNecessary(sst.Witness.Type, erasedType, null, new BuilderSyntaxTree<ExprContainer>(buf, this)),
                      new BuilderSyntaxTree<StatementContainer>(statementBuf, this)
                    );
                    witness = buf.Finish();
                    witnessStmts = statementBuf.PopAll();
                }
                string baseName = sst.Var.CompileName;
                DAST.Expression baseConstraint = buf.Finish();
                var baseConstraintStmts = statementBuf.PopAll(); // TODO: Integrate in AST.

                List<DAST.Type> typeParams = new();
                foreach (var tp in sst.TypeArgs)
                {
                    var compileName = tp.Name;
                    if (!isTpSupported(tp, out var why))
                    {
                        AddUnsupported(why);
                    }

                    typeParams.Add((DAST.Type)DAST.Type.create_TypeArg(Sequence<Rune>.UnicodeFromString(compileName)));
                }

                builder.Newtype(sst.GetCompileName(Options), typeParams,
                  GenType(erasedType), (NewtypeRange)NewtypeRange.create_NoRange(), witnessStmts, witness).Finish();
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected override void GetNativeInfo(NativeType.Selection sel, out string name, out string literalSuffix, out bool needsCastAfterArithmetic)
        {
            name = null;
            literalSuffix = null;
            needsCastAfterArithmetic = MutateCSharp.Schemata223.ReplaceBooleanConstant_10(127L, false);
        }

        public class ClassWriter : IClassWriter
        {
            private readonly DafnyCodeGenerator compiler;
            private readonly ClassLike builder;
            private readonly bool hasTypeArgs;
            private readonly List<MethodBuilder> methods = new();

            public ClassWriter(DafnyCodeGenerator compiler, bool hasTypeArgs, ClassLike builder)
            {
                this.compiler = compiler;
                this.hasTypeArgs = hasTypeArgs;
                this.builder = builder;
            }

            public ConcreteSyntaxTree CreateMethod(Method m, List<TypeArgumentInstantiation> typeArgs, bool createBody,
              bool forBodyInheritance, bool lookasideBody)
            {
                if (MutateCSharp.Schemata223.ReplaceBinExprOp_2(128L, () => m.IsStatic, () => this.hasTypeArgs))
                {
                    compiler.AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(134L, "<i>Static methods with type arguments</i>"));
                    return new BuilderSyntaxTree<StatementContainer>(new StatementBuffer(), this.compiler);
                }

                List<DAST.Type> astTypeArgs = new();
                foreach (var typeArg in typeArgs)
                {
                    var compileName = compiler.IdProtect(typeArg.Formal.GetCompileName(compiler.Options));
                    if (!isTpSupported(typeArg.Formal, out var why))
                    {
                        compiler.AddUnsupported(why);
                    }

                    astTypeArgs.Add((DAST.Type)DAST.Type.create_TypeArg(Sequence<Rune>.UnicodeFromString(compileName)));
                }

                List<DAST.Formal> params_ = new();
                foreach (var param in m.Ins)
                {
                    if (MutateCSharp.Schemata223.ReplaceBinExprOp_2(135L, () => param is not ImplicitFormal, () => !param.IsGhost))
                    {
                        params_.Add((DAST.Formal)DAST.Formal.create_Formal(Sequence<Rune>.UnicodeFromString(compiler.IdProtect(param.CompileName)), compiler.GenType(param.Type)));
                    }
                }

                List<ISequence<Rune>> outVars = new();
                List<DAST.Type> outTypes = new();
                foreach (var outVar in m.Outs)
                {
                    if (!outVar.IsGhost)
                    {
                        outVars.Add(Sequence<Rune>.UnicodeFromString(compiler.IdProtect(outVar.CompileName)));
                        outTypes.Add(compiler.GenType(outVar.Type));
                    }
                }

                var overridingTrait = m.OverriddenMethod?.EnclosingClass;
                var builder = this.builder.Method(
                  m.IsStatic, createBody,
        MutateCSharp.Schemata223.ReplaceBinExprOp_18(141L, overridingTrait, null) ? compiler.PathFromTopLevel(overridingTrait) : null,
                  m.GetCompileName(compiler.Options),
                  astTypeArgs, params_,
                  outTypes, outVars
                );
                methods.Add(builder);

                if (createBody)
                {
                    return new BuilderSyntaxTree<StatementContainer>(builder, this.compiler);
                }
                else
                {
                    // TODO(shadaj): actually create a trait
                    return null;
                }

                return default;
            }

            public ConcreteSyntaxTree SynthesizeMethod(Method m, List<TypeArgumentInstantiation> typeArgs, bool createBody, bool forBodyInheritance, bool lookasideBody)
            {
                compiler.AddUnsupportedFeature(m.tok, Feature.MethodSynthesis);
                return new BuilderSyntaxTree<StatementContainer>(new StatementBuffer(), this.compiler);
            }

            public ConcreteSyntaxTree CreateFunction(string name, List<TypeArgumentInstantiation> typeArgs,
                List<Formal> formals, Type resultType, IToken tok, bool isStatic, bool createBody, MemberDecl member,
                bool forBodyInheritance, bool lookasideBody)
            {
                if (MutateCSharp.Schemata223.ReplaceBinExprOp_2(142L, () => isStatic, () => this.hasTypeArgs))
                {
                    compiler.AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(148L, "<i>Static functions with type arguments</i>"));
                    return new BuilderSyntaxTree<StatementContainer>(new StatementBuffer(), this.compiler);
                }

                List<DAST.Type> astTypeArgs = new();
                foreach (var typeArg in typeArgs)
                {
                    var compileName = compiler.IdProtect(typeArg.Formal.GetCompileName(compiler.Options));
                    if (!isTpSupported(typeArg.Formal, out var why))
                    {
                        compiler.AddUnsupported(why);
                    }

                    astTypeArgs.Add((DAST.Type)DAST.Type.create_TypeArg(Sequence<Rune>.UnicodeFromString(compileName)));
                }

                List<DAST.Formal> params_ = new();
                foreach (var param in formals)
                {
                    if (!param.IsGhost)
                    {
                        params_.Add((DAST.Formal)DAST.Formal.create_Formal(Sequence<Rune>.UnicodeFromString(compiler.IdProtect(param.CompileName)), compiler.GenType(param.Type)));
                    }
                }

                var overridingTrait = member.OverriddenMember?.EnclosingClass;

                var builder = this.builder.Method(
                  isStatic, createBody,
        MutateCSharp.Schemata223.ReplaceBinExprOp_18(149L, overridingTrait, null) ? compiler.PathFromTopLevel(overridingTrait) : null,
                  name,
                  astTypeArgs, params_,
                  new() {
            compiler.GenType(resultType)
                  }, null
                );
                methods.Add(builder);

                if (createBody)
                {
                    return new BuilderSyntaxTree<StatementContainer>(builder, this.compiler);
                }
                else
                {
                    return null;
                }

                return default;
            }

            public ConcreteSyntaxTree CreateGetter(string name, TopLevelDecl enclosingDecl, Type resultType, IToken tok,
                bool isStatic, bool isConst, bool createBody, MemberDecl member, bool forBodyInheritance)
            {
                if (MutateCSharp.Schemata223.ReplaceBinExprOp_2(150L, () => isStatic, () => this.hasTypeArgs))
                {
                    compiler.AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(156L, "<i>Static fields with type arguments</i>"));
                    return new BuilderSyntaxTree<StatementContainer>(new StatementBuffer(), this.compiler);
                }

                var overridingTrait = member.OverriddenMember?.EnclosingClass;

                var builder = this.builder.Method(
                  isStatic, createBody,
        MutateCSharp.Schemata223.ReplaceBinExprOp_18(157L, overridingTrait, null) ? compiler.PathFromTopLevel(overridingTrait) : null,
                  name,
                  new(), new(),
                  new() {
            compiler.GenType(resultType)
                  }, null
                );
                methods.Add(builder);

                if (createBody)
                {
                    return new BuilderSyntaxTree<StatementContainer>(builder, this.compiler);
                }
                else
                {
                    return null;
                }

                return default;
            }

            public ConcreteSyntaxTree CreateGetterSetter(string name, Type resultType, IToken tok,
                bool createBody, MemberDecl member, out ConcreteSyntaxTree setterWriter, bool forBodyInheritance)
            {
                compiler.AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(158L, "<i>Create Getter Setter</i>"));
                if (createBody)
                {
                    setterWriter = new BuilderSyntaxTree<StatementContainer>(new StatementBuffer(), this.compiler);
                    return new BuilderSyntaxTree<StatementContainer>(new StatementBuffer(), this.compiler);
                }
                else
                {
                    setterWriter = null;
                    return null;
                }

                return default;
            }

            public void DeclareField(string name, TopLevelDecl enclosingDecl, bool isStatic, bool isConst, Type type,
                IToken tok, string rhs, Field field)
            {
                _IOption<DAST._IExpression> rhsExpr = null;
                if (rhs != null)
                {
                    rhsExpr = compiler.bufferedInitializationValue;
                    compiler.bufferedInitializationValue = null;

                    if (MutateCSharp.Schemata223.ReplaceBinExprOp_19(159L, rhsExpr, null))
                    {
                        throw new InvalidOperationException();
                    }
                }
                else
                {
                    rhsExpr = Option<DAST._IExpression>.create_None();
                }

                builder.AddField((DAST.Formal)DAST.Formal.create_Formal(
                  Sequence<Rune>.UnicodeFromString(name),
                  compiler.GenType(type)
                ), rhsExpr);
            }

            public void InitializeField(Field field, Type instantiatedFieldType, TopLevelDeclWithMembers enclosingClass)
            {
                throw new cce.UnreachableException();
            }

            public ConcreteSyntaxTree ErrorWriter() => null;

            public void Finish()
            {
                foreach (var method in methods)
                {
                    builder.AddMethod(method.Build());
                }

                compiler.currentBuilder = builder.Finish();
            }
        }

        protected override ConcreteSyntaxTree EmitReturnExpr(ConcreteSyntaxTree wr)
        {
            if (wr is BuilderSyntaxTree<StatementContainer> stmtContainer)
            {
                return new BuilderSyntaxTree<ExprContainer>(stmtContainer.Builder.Return(), this);
            }
            else
            {
                throw new InvalidOperationException();
            }

            return default;
        }

        protected override void EmitReturnExpr(string returnExpr, ConcreteSyntaxTree wr)
        {
            if (MutateCSharp.Schemata223.ReplaceBinExprOp_20(161L, returnExpr, MutateCSharp.Schemata223.ReplaceStringConstant_1(160L, "BUFFERED")))
            {
                if (MutateCSharp.Schemata223.ReplaceBinExprOp_19(162L, bufferedInitializationValue, null))
                {
                    throw new InvalidOperationException(MutateCSharp.Schemata223.ReplaceStringConstant_1(163L, "Expected a buffered value to have been populated because rhs != null"));
                }

                var rhsValue = bufferedInitializationValue;
                bufferedInitializationValue = null;

                if (wr is BuilderSyntaxTree<StatementContainer> stmtContainer)
                {
                    var returnBuilder = stmtContainer.Builder.Return();
                    returnBuilder.AddExpr((DAST.Expression)rhsValue.dtor_value);
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
            else
            {
                // TODO(shadaj): this may not be robust, we should use the writer version directly
                EmitIdentifier(returnExpr, EmitReturnExpr(wr));
            }
        }

        protected override string TypeDescriptor(Type type, ConcreteSyntaxTree wr, IToken tok)
        {
            type = DatatypeWrapperEraser.SimplifyType(Options, type);
            return type.ToString();
        }

        protected override ConcreteSyntaxTree EmitMethodReturns(Method m, ConcreteSyntaxTree wr)
        {
            var beforeReturnBlock = wr.Fork();
            EmitReturn(m.Outs, wr);
            return beforeReturnBlock;
        }

        protected override ConcreteSyntaxTree EmitTailCallStructure(MemberDecl member, ConcreteSyntaxTree wr)
        {
            if (wr is BuilderSyntaxTree<StatementContainer> stmtContainer)
            {
                var recBuilder = stmtContainer.Builder.TailRecursive();
                return new BuilderSyntaxTree<StatementContainer>(recBuilder, this);
            }
            else
            {
                throw new InvalidOperationException();
            }

            return default;
        }

        protected override void EmitJumpToTailCallStart(ConcreteSyntaxTree wr)
        {
            if (wr is BuilderSyntaxTree<StatementContainer> stmtContainer)
            {
                stmtContainer.Builder.AddStatement((DAST.Statement)DAST.Statement.create_JumpTailCallStart());
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        internal override string TypeName(Type type, ConcreteSyntaxTree wr, IToken tok, MemberDecl/*?*/ member = null)
        {
            return MutateCSharp.Schemata223.ReplaceStringConstant_1(164L, "PLACEBO_TYPE");
        }

        // sometimes, the compiler generates the initial value before the declaration,
        // so we buffer it here
        _IOption<DAST._IExpression> bufferedInitializationValue = null;

        protected override string TypeInitializationValue(Type type, ConcreteSyntaxTree wr, IToken tok,
            bool usePlaceboValue, bool constructTypeParameterDefaultsFromTypeDescriptors)
        {
            if (MutateCSharp.Schemata223.ReplaceBinExprOp_21(165L, bufferedInitializationValue, null))
            {
                throw new InvalidOperationException();
            }
            else
            {
                type = type.NormalizeExpandKeepConstraints();
                if (usePlaceboValue)
                {
                    bufferedInitializationValue = Option<DAST._IExpression>.create_None();
                }
                else
                {
                    if (MutateCSharp.Schemata223.ReplaceBinExprOp_2(168L, () => MutateCSharp.Schemata223.ReplaceBinExprOp_22(166L, type.AsNewtype, null), () => MutateCSharp.Schemata223.ReplaceBinExprOp_15(167L, type.AsNewtype.WitnessKind, SubsetTypeDecl.WKind.Compiled)))
                    {
                        var buf = new ExprBuffer(null);
                        EmitExpr(type.AsNewtype.Witness, MutateCSharp.Schemata223.ReplaceBooleanConstant_10(174L, false), new BuilderSyntaxTree<ExprContainer>(buf, this), null);
                        bufferedInitializationValue = Option<DAST._IExpression>.create_Some(buf.Finish());
                    }
                    else if (MutateCSharp.Schemata223.ReplaceBinExprOp_2(177L, () => MutateCSharp.Schemata223.ReplaceBinExprOp_7(175L, type.AsSubsetType, null), () => MutateCSharp.Schemata223.ReplaceBinExprOp_15(176L, type.AsSubsetType.WitnessKind, SubsetTypeDecl.WKind.Compiled)))
                    {
                        var buf = new ExprBuffer(null);
                        EmitExpr(type.AsSubsetType.Witness, MutateCSharp.Schemata223.ReplaceBooleanConstant_10(183L, false), new BuilderSyntaxTree<ExprContainer>(buf, this), null);
                        bufferedInitializationValue = Option<DAST._IExpression>.create_Some(buf.Finish());
                    }
                    else if (MutateCSharp.Schemata223.ReplaceBinExprOp_2(194L, () => MutateCSharp.Schemata223.ReplaceBinExprOp_23(184L, type.AsDatatype, null), () => MutateCSharp.Schemata223.ReplaceBinExprOp_24(189L, type.AsDatatype.Ctors.Count, MutateCSharp.Schemata223.ReplaceNumericConstant_11(185L, 1))) && type.AsDatatype.Ctors[0].EnclosingDatatype is TupleTypeDecl tupleDecl)
                    {
                        var elems = new List<DAST._IExpression>();
                        for (var i = MutateCSharp.Schemata223.ReplaceNumericConstant_11(200L, 0); MutateCSharp.Schemata223.ReplaceBinExprOp_25(208L, i, tupleDecl.Ctors[MutateCSharp.Schemata223.ReplaceNumericConstant_11(204L, 0)].Formals.Count); MutateCSharp.Schemata223.ReplacePostfixUnaryExprOp_26(213L, ref i))
                        {
                            if (!tupleDecl.Ctors[MutateCSharp.Schemata223.ReplaceNumericConstant_11(214L, 0)].Formals[i].IsGhost)
                            {
                                TypeInitializationValue(type.TypeArgs[i], wr, tok, usePlaceboValue, constructTypeParameterDefaultsFromTypeDescriptors);
                                elems.Add(bufferedInitializationValue.dtor_value);
                                bufferedInitializationValue = null;
                            }
                        }

                        if (MutateCSharp.Schemata223.ReplaceBinExprOp_24(222L, elems.Count, MutateCSharp.Schemata223.ReplaceNumericConstant_11(218L, 1)))
                        {
                            bufferedInitializationValue = Option<DAST._IExpression>.create_Some(elems[MutateCSharp.Schemata223.ReplaceNumericConstant_11(227L, 0)]);
                        }
                        else
                        {
                            bufferedInitializationValue = Option<DAST._IExpression>.create_Some(
                              DAST.Expression.create_Tuple(Sequence<DAST._IExpression>.FromArray(elems.ToArray()))
                            );
                        }
                    }
                    else if (type.IsArrowType)
                    {
                        this.AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(231L, "<i>Initializer for arrow type</i>"));
                    }
                    else
                    {
                        bufferedInitializationValue = Option<DAST._IExpression>.create_Some(
                          DAST.Expression.create_InitializationValue(GenType(type))
                        );
                    }
                }
                return MutateCSharp.Schemata223.ReplaceStringConstant_1(232L, "BUFFERED"); // used by DeclareLocal(Out)Var
            }

            return default;
        }

        protected override string TypeName_UDT(string fullCompileName, List<TypeParameter.TPVariance> variance,
            List<Type> typeArgs, ConcreteSyntaxTree wr, IToken tok, bool omitTypeArguments)
        {
            return fullCompileName;
        }

        protected override string TypeName_Companion(Type type, ConcreteSyntaxTree wr, IToken tok, MemberDecl member)
        {
            ExprContainer actualBuilder;
            if (wr is BuilderSyntaxTree<ExprContainer> st)
            {
                actualBuilder = st.Builder;
            }
            else
            {
                throw new InvalidOperationException();
            }

            EmitTypeName_Companion(type, new BuilderSyntaxTree<ExprContainer>(actualBuilder, this), wr, tok, member);
            return "";
        }

        protected override void EmitTypeName_Companion(Type type, ConcreteSyntaxTree wr, ConcreteSyntaxTree surrounding, IToken tok, MemberDecl member)
        {
            if (wr is BuilderSyntaxTree<ExprContainer> container)
            {
                type = UserDefinedType.UpcastToMemberEnclosingType(type, member);

                if (type.NormalizeExpandKeepConstraints() is UserDefinedType udt && udt.ResolvedClass is DatatypeDecl dt &&
                    DatatypeWrapperEraser.IsErasableDatatypeWrapper(Options, dt, out _))
                {
                    container.Builder.AddExpr((DAST.Expression)DAST.Expression.create_Companion(PathFromTopLevel(udt.ResolvedClass)));
                }
                else
                {
                    if (MutateCSharp.Schemata223.ReplaceBinExprOp_27(233L, type.AsTopLevelTypeWithMembers, null))
                    { // git-issues/git-issue-697g.dfy while iterating over "nat"
                        AddUnsupportedFeature(tok, Feature.SubtypeConstraintsInQuantifiers);
                    }
                    else
                    {
                        container.Builder.AddExpr(
                          (DAST.Expression)DAST.Expression.create_Companion(PathFromTopLevel(type.AsTopLevelTypeWithMembers)));
                    }
                }
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected override void EmitNameAndActualTypeArgs(string protectedName, List<Type> typeArgs, IToken tok, ConcreteSyntaxTree wr)
        {
            if (GetExprBuilder(wr, out var st) && st.Builder is CallExprBuilder callExpr)
            {
                callExpr.SetName((DAST.CallName)DAST.CallName.create_Name(Sequence<Rune>.UnicodeFromString(protectedName)));
            }
            else if (GetExprBuilder(wr, out var st2) && st2.Builder is CallStmtBuilder callStmt)
            {
                callStmt.SetName((DAST.CallName)DAST.CallName.create_Name(Sequence<Rune>.UnicodeFromString(protectedName)));
            }
            else
            {
                AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(234L, "Builder issue: wr is as ") + wr.GetType() +
                                        (GetExprBuilder(wr, out var st3) ?
                                          " and its builder is a " + st3.Builder.GetType() : ""
                                          ));
                return;
            }

            base.EmitNameAndActualTypeArgs(protectedName, typeArgs, tok, wr);
        }

        protected override void TypeArgDescriptorUse(bool isStatic, bool lookasideBody, TopLevelDeclWithMembers cl, out bool needsTypeParameter, out bool needsTypeDescriptor)
        {
            needsTypeParameter = MutateCSharp.Schemata223.ReplaceBooleanConstant_10(235L, false);
            needsTypeDescriptor = MutateCSharp.Schemata223.ReplaceBooleanConstant_10(236L, false);
        }

        protected override bool DeclareFormal(string prefix, string name, Type type, IToken tok, bool isInParam, ConcreteSyntaxTree wr)
        {
            AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(237L, "<i>Declare formal</i>"));
            return MutateCSharp.Schemata223.ReplaceBooleanConstant_10(238L, true);
        }

        protected override void DeclareLocalVar(string name, Type type, IToken tok, bool leaveRoomForRhs, string rhs,
            ConcreteSyntaxTree wr)
        {
            if (wr is BuilderSyntaxTree<StatementContainer> stmtContainer)
            {
                var typ = GenType(type);

                if (rhs == null)
                {
                    // we expect an initializer to come *after* this declaration
                    var variable = stmtContainer.Builder.DeclareAndAssign(typ, name);

                    if (leaveRoomForRhs)
                    {
                        throw new InvalidOperationException();
                    }
                }
                else if (MutateCSharp.Schemata223.ReplaceBinExprOp_20(240L, rhs, MutateCSharp.Schemata223.ReplaceStringConstant_1(239L, "BUFFERED")))
                {
                    if (MutateCSharp.Schemata223.ReplaceBinExprOp_19(241L, bufferedInitializationValue, null))
                    {
                        throw new InvalidOperationException(
            MutateCSharp.Schemata223.ReplaceStringConstant_1(242L, "Expected a buffered value to have been populated because rhs != null"));
                    }

                    var rhsValue = bufferedInitializationValue;
                    bufferedInitializationValue = null;

                    stmtContainer.Builder.AddStatement(
                      (DAST.Statement)DAST.Statement.create_DeclareVar(
                        Sequence<Rune>.UnicodeFromString(name),
                        typ,
                        rhsValue
                      )
                    );
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
            else
            {
                throw new InvalidOperationException(MutateCSharp.Schemata223.ReplaceStringConstant_1(243L, "Cannot declare local var outside of a statement container: ") + wr);
            }
        }

        protected override ConcreteSyntaxTree DeclareLocalVar(string name, Type type, IToken tok, ConcreteSyntaxTree wr)
        {
            if (wr is BuilderSyntaxTree<StatementContainer> stmtContainer)
            {
                var variable = stmtContainer.Builder.DeclareAndAssign(GenType(type), name);
                return new BuilderSyntaxTree<ExprContainer>(variable, this);
            }
            else
            {
                throw new InvalidOperationException();
            }

            return default;
        }

        protected override bool UseReturnStyleOuts(Method m, int nonGhostOutCount) => MutateCSharp.Schemata223.ReplaceBooleanConstant_10(244L, true);
        protected override bool SupportsMultipleReturns => MutateCSharp.Schemata223.ReplaceBooleanConstant_10(245L, true);

        protected override void DeclareLocalOutVar(string name, Type type, IToken tok, string rhs, bool useReturnStyleOuts,
            ConcreteSyntaxTree wr)
        {
            DeclareLocalVar(name, type, tok, MutateCSharp.Schemata223.ReplaceBooleanConstant_10(246L, true), rhs, wr);
        }

        protected override void EmitCallReturnOuts(List<string> outTmps, ConcreteSyntaxTree wr)
        {
            if (GetExprBuilder(wr, out var builder) && builder.Builder is CallStmtBuilder call)
            {
                call.SetOuts(outTmps.Select(i => Sequence<Rune>.UnicodeFromString(i)).ToList());
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected override void TrCallStmt(CallStmt s, string receiverReplacement, ConcreteSyntaxTree wr, ConcreteSyntaxTree wrStmts, ConcreteSyntaxTree wrStmtsAfterCall)
        {
            if (wr is BuilderSyntaxTree<StatementContainer> stmtContainer)
            {
                if (MutateCSharp.Schemata223.ReplaceBinExprOp_2(248L, () => MutateCSharp.Schemata223.ReplaceBinExprOp_28(247L, s.Method, enclosingMethod), () => enclosingMethod.IsTailRecursive))
                {
                    base.TrCallStmt(s, receiverReplacement, wr, wrStmts, wrStmtsAfterCall);
                }
                else
                {
                    var callBuilder = stmtContainer.Builder.Call();
                    base.TrCallStmt(s, receiverReplacement, new BuilderSyntaxTree<ExprContainer>(callBuilder, this), wrStmts, wrStmtsAfterCall);
                }
            }
            else
            {
                throw new InvalidOperationException(MutateCSharp.Schemata223.ReplaceStringConstant_1(254L, "Cannot call statement in this context: ") + currentBuilder);
            }
        }

        protected override void EmitCallToInheritedMethod(Method method, [CanBeNull] TopLevelDeclWithMembers heir, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts, ConcreteSyntaxTree wStmtsAfterCall)
        {
            if (wr is BuilderSyntaxTree<StatementContainer> stmtContainer)
            {
                var callBuilder = stmtContainer.Builder.Call();
                base.EmitCallToInheritedMethod(method, heir, new BuilderSyntaxTree<ExprContainer>(callBuilder, this), wStmts, wStmtsAfterCall);
            }
            else
            {
                throw new InvalidOperationException(MutateCSharp.Schemata223.ReplaceStringConstant_1(255L, "Cannot call statement in this context: ") + currentBuilder);
            }
        }

        protected override void EmitMultiReturnTuple(List<Formal> outs, List<Type> outTypes, List<string> outTmps, IToken methodToken, ConcreteSyntaxTree wr)
        {
            // nothing to do, we auto-emit a return for the method
        }

        protected override void CompileFunctionCallExpr(FunctionCallExpr e, ConcreteSyntaxTree wr, bool inLetExprBody,
            ConcreteSyntaxTree wStmts, FCE_Arg_Translator tr, bool alreadyCoerced)
        {
            var toType = MutateCSharp.Schemata223.ReplaceBinExprOp_27(256L, thisContext, null) ? e.Type : e.Type.Subst(thisContext.ParentFormalTypeParametersToActuals);
            wr = EmitCoercionIfNecessary(e.Function.Original.ResultType, toType, e.tok, wr);

            if (wr is BuilderSyntaxTree<ExprContainer> builder)
            {
                var callBuilder = builder.Builder.Call();
                base.CompileFunctionCallExpr(e, new BuilderSyntaxTree<ExprContainer>(callBuilder, this), inLetExprBody, wStmts, tr, MutateCSharp.Schemata223.ReplaceBooleanConstant_10(257L, true));
            }
            else
            {
                throw new InvalidOperationException(MutateCSharp.Schemata223.ReplaceStringConstant_1(258L, "Cannot call function in this context: ") + currentBuilder);
            }
        }

        protected override void EmitActualTypeArgs(List<Type> typeArgs, IToken tok, ConcreteSyntaxTree wr)
        {
            if (GetExprBuilder(wr, out var st) && st.Builder is CallExprBuilder callExpr)
            {
                callExpr.SetTypeArgs(typeArgs.Select(GenType).ToList());
            }
            else if (GetExprBuilder(wr, out var st2) && st2.Builder is CallStmtBuilder callStmt)
            {
                callStmt.SetTypeArgs(typeArgs.Select(GenType).ToList());
            }
            else
            {
                throw new InvalidOperationException(MutateCSharp.Schemata223.ReplaceStringConstant_1(259L, "Cannot emit actual type args in this context: ") + currentBuilder);
            }
        }

        public class BuilderLvalue : ILvalue
        {
            readonly string name;
            private readonly DafnyCodeGenerator compiler;

            public BuilderLvalue(string name, DafnyCodeGenerator compiler)
            {
                this.name = name;
                this.compiler = compiler;
            }

            public void EmitRead(ConcreteSyntaxTree wr)
            {
                throw new InvalidOperationException();
            }

            public ConcreteSyntaxTree EmitWrite(ConcreteSyntaxTree wr)
            {
                if (wr is BuilderSyntaxTree<StatementContainer> stmtContainer)
                {
                    var assign = stmtContainer.Builder.Assign();
                    assign.AddLhs((DAST.AssignLhs)DAST.AssignLhs.create_Ident(Sequence<Rune>.UnicodeFromString(name)));
                    return new BuilderSyntaxTree<ExprContainer>(assign, this.compiler);
                }
                else
                {
                    throw new InvalidOperationException();
                }

                return default;
            }
        }

        public class ExprLvalue : ILvalue
        {
            readonly DAST.Expression expr;
            readonly DAST.AssignLhs assignExpr;
            private readonly DafnyCodeGenerator compiler;

            public ExprLvalue(DAST.Expression expr, DAST.AssignLhs assignExpr, DafnyCodeGenerator compiler)
            {
                this.expr = expr;
                this.assignExpr = assignExpr;
                this.compiler = compiler;
            }

            public void EmitRead(ConcreteSyntaxTree wr)
            {
                if (GetExprBuilder(wr, out var exprContainer))
                {
                    exprContainer.Builder.AddExpr(expr);
                }
                else
                {
                    compiler.AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(260L, "<i>EmitRead</i> without ExprContainer builder"));
                }
            }

            public ConcreteSyntaxTree EmitWrite(ConcreteSyntaxTree wr)
            {
                if (MutateCSharp.Schemata223.ReplaceBinExprOp_29(261L, assignExpr, null))
                {
                    throw new InvalidOperationException();
                }

                if (wr is BuilderSyntaxTree<StatementContainer> stmtContainer)
                {
                    var assign = stmtContainer.Builder.Assign();
                    assign.AddLhs(assignExpr);
                    return new BuilderSyntaxTree<ExprContainer>(assign, this.compiler);
                }
                else
                {
                    throw new InvalidOperationException();
                }

                return default;
            }
        }

        protected override void EmitAssignment(string lhs, Type/*?*/ lhsType, string rhs, Type/*?*/ rhsType, ConcreteSyntaxTree wr)
        {
            throw new InvalidOperationException(MutateCSharp.Schemata223.ReplaceStringConstant_1(262L, "Cannot use stringified version of assignment"));
        }

        protected override ILvalue IdentLvalue(string var)
        {
            return new BuilderLvalue(var, this);
        }

        protected override ILvalue SeqSelectLvalue(SeqSelectExpr ll, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var sourceBuf = new ExprBuffer(null);
            EmitExpr(
              ll.Seq, MutateCSharp.Schemata223.ReplaceBooleanConstant_10(263L, false),
              EmitCoercionIfNecessary(
                ll.Seq.Type,
      MutateCSharp.Schemata223.ReplaceBinExprOp_8(264L, () => ll.Seq.Type.IsNonNullRefType, () => !ll.Seq.Type.IsRefType) ? null : UserDefinedType.CreateNonNullType((UserDefinedType)ll.Seq.Type.NormalizeExpand()),
                null, new BuilderSyntaxTree<ExprContainer>(sourceBuf, this)
              ),
              wStmts
            );

            var indexBuf = new ExprBuffer(null);
            EmitExpr(ll.E0, MutateCSharp.Schemata223.ReplaceBooleanConstant_10(270L, false), new BuilderSyntaxTree<ExprContainer>(indexBuf, this), wStmts);

            var source = sourceBuf.Finish();
            var index = indexBuf.Finish();


            DAST._ICollKind collKind;
            if (ll.Seq.Type.IsArrayType)
            {
                collKind = DAST.CollKind.create_Array();
            }
            else if (ll.Seq.Type.IsMapType)
            {
                collKind = DAST.CollKind.create_Map();
            }
            else
            {
                collKind = DAST.CollKind.create_Seq();
            }

            return new ExprLvalue(
              (DAST.Expression)DAST.Expression.create_Index(source, collKind, Sequence<DAST.Expression>.FromElements(index)),
              (DAST.AssignLhs)DAST.AssignLhs.create_Index(source, Sequence<DAST.Expression>.FromElements(index)),
              this
            );
        }

        protected override ILvalue MultiSelectLvalue(MultiSelectExpr ll, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            throw new UnsupportedFeatureException(ll.tok, Feature.MultiDimensionalArrays);
            return default;
        }

        protected override void EmitPrintStmt(ConcreteSyntaxTree wr, Expression arg)
        {
            if (wr is BuilderSyntaxTree<StatementContainer> stmtContainer)
            {
                ExprBuffer buffer = new(null);
                EmitExpr(arg, MutateCSharp.Schemata223.ReplaceBooleanConstant_10(271L, false), new BuilderSyntaxTree<ExprContainer>(buffer, this), wr);
                stmtContainer.Builder.Print(buffer.Finish());
            }
            else
            {
                throw new InvalidOperationException(MutateCSharp.Schemata223.ReplaceStringConstant_1(272L, "Cannot print outside of a statement container: ") + currentBuilder);
            }
        }

        protected override void EmitReturn(List<Formal> outParams, ConcreteSyntaxTree wr)
        {
            if (wr is BuilderSyntaxTree<StatementContainer> stmtContainer)
            {
                stmtContainer.Builder.AddStatement((DAST.Statement)DAST.Statement.create_EarlyReturn());
            }
            else
            {
                throw new InvalidOperationException(MutateCSharp.Schemata223.ReplaceStringConstant_1(273L, "Cannot return outside of a statement container: ") + currentBuilder);
            }
        }

        protected override ConcreteSyntaxTree CreateLabeledCode(string label, bool createContinueLabel, ConcreteSyntaxTree wr)
        {
            if (wr is BuilderSyntaxTree<StatementContainer> stmtContainer)
            {
                var labelBuilder = stmtContainer.Builder.Labeled((createContinueLabel ? MutateCSharp.Schemata223.ReplaceStringConstant_1(274L, "continue_") : MutateCSharp.Schemata223.ReplaceStringConstant_1(275L, "goto_")) + label);
                return new BuilderSyntaxTree<StatementContainer>(labelBuilder, this);
            }
            else
            {
                throw new InvalidOperationException();
            }

            return default;
        }

        protected override void EmitBreak(string label, ConcreteSyntaxTree wr)
        {
            if (wr is BuilderSyntaxTree<StatementContainer> stmtContainer)
            {
                stmtContainer.Builder.AddStatement((DAST.Statement)DAST.Statement.create_Break(
                  label == null ? Option<ISequence<Rune>>.create_None() : Option<ISequence<Rune>>.create_Some(Sequence<Rune>.UnicodeFromString(MutateCSharp.Schemata223.ReplaceStringConstant_1(276L, "goto_") + label))
                ));
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected override void EmitContinue(string label, ConcreteSyntaxTree wr)
        {
            if (wr is BuilderSyntaxTree<StatementContainer> stmtContainer)
            {
                stmtContainer.Builder.AddStatement((DAST.Statement)DAST.Statement.create_Break(
                  Option<ISequence<Rune>>.create_Some(Sequence<Rune>.UnicodeFromString(MutateCSharp.Schemata223.ReplaceStringConstant_1(277L, "continue_") + label))
                ));
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected override void EmitYield(ConcreteSyntaxTree wr)
        {
            AddUnsupportedFeature(Token.NoToken, Feature.Iterators);
        }

        protected override void EmitAbsurd(string message, ConcreteSyntaxTree wr)
        {
            // TODO(shadaj): emit correct message
            if (wr is BuilderSyntaxTree<StatementContainer> container)
            {
                container.Builder.AddStatement((DAST.Statement)DAST.Statement.create_Halt());
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected override void EmitHalt(IToken tok, Expression messageExpr, ConcreteSyntaxTree wr)
        {
            if (wr is BuilderSyntaxTree<StatementContainer> container)
            {
                container.Builder.AddStatement((DAST.Statement)DAST.Statement.create_Halt());
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        private readonly Stack<(ElseBuilder, StatementContainer)> elseBuilderStack = new();

        protected override ConcreteSyntaxTree EmitIf(out ConcreteSyntaxTree guardWriter, bool hasElse, ConcreteSyntaxTree wr)
        {
            if (wr is BuilderSyntaxTree<StatementContainer> statementContainer)
            {
                var containingBuilder = statementContainer.Builder;
                if (MutateCSharp.Schemata223.ReplaceBinExprOp_2(288L, () => MutateCSharp.Schemata223.ReplaceBinExprOp_12(282L, elseBuilderStack.Count, MutateCSharp.Schemata223.ReplaceNumericConstant_11(278L, 0)), () => MutateCSharp.Schemata223.ReplaceBinExprOp_30(287L, elseBuilderStack.Peek().Item2, statementContainer.Builder)))
                {
                    var popped = elseBuilderStack.Pop();
                    statementContainer = new BuilderSyntaxTree<StatementContainer>(popped.Item1, this);
                    containingBuilder = popped.Item2;
                }

                var ifBuilder = statementContainer.Builder.IfElse();
                if (hasElse)
                {
                    elseBuilderStack.Push((ifBuilder.Else(), containingBuilder));
                }

                guardWriter = new BuilderSyntaxTree<ExprContainer>(ifBuilder, this);
                return new BuilderSyntaxTree<StatementContainer>(ifBuilder, this);
            }
            else
            {
                throw new InvalidOperationException();
            }

            return default;
        }

        protected override ConcreteSyntaxTree EmitBlock(ConcreteSyntaxTree wr)
        {
            if (wr is BuilderSyntaxTree<StatementContainer> statementContainer)
            {
                if (MutateCSharp.Schemata223.ReplaceBinExprOp_2(304L, () => MutateCSharp.Schemata223.ReplaceBinExprOp_12(298L, elseBuilderStack.Count, MutateCSharp.Schemata223.ReplaceNumericConstant_11(294L, 0)), () => MutateCSharp.Schemata223.ReplaceBinExprOp_30(303L, elseBuilderStack.Peek().Item2, statementContainer.Builder)))
                {
                    return new BuilderSyntaxTree<StatementContainer>(elseBuilderStack.Pop().Item1, this);
                }
                else
                {
                    return wr.Fork();
                }
            }
            else
            {
                throw new InvalidOperationException();
            }

            return default;
        }

        protected override ConcreteSyntaxTree EmitForStmt(IToken tok, IVariable loopIndex, bool goingUp, string endVarName,
          List<Statement> body, LList<Label> labels, ConcreteSyntaxTree wr)
        {
            AddUnsupportedFeature(tok, Feature.ForLoops);
            return wr;
        }

        protected override ConcreteSyntaxTree CreateWhileLoop(out ConcreteSyntaxTree guardWriter, ConcreteSyntaxTree wr)
        {
            if (wr is BuilderSyntaxTree<StatementContainer> statementContainer)
            {
                var whileBuilder = statementContainer.Builder.While();
                guardWriter = new BuilderSyntaxTree<ExprContainer>(whileBuilder, this);
                return new BuilderSyntaxTree<StatementContainer>(whileBuilder, this);
            }
            else
            {
                throw new InvalidOperationException();
            }

            return default;
        }

        protected override ConcreteSyntaxTree CreateForLoop(string indexVar, Action<ConcreteSyntaxTree> bound, ConcreteSyntaxTree wr, string start = null)
        {
            AddUnsupportedFeature(Token.NoToken, Feature.ForLoops);
            return wr;
        }

        protected override ConcreteSyntaxTree CreateDoublingForLoop(string indexVar, int start, ConcreteSyntaxTree wr)
        {
            AddUnsupportedFeature(Token.NoToken, Feature.ForLoops);
            return wr;
        }

        protected override void EmitIncrementVar(string varName, ConcreteSyntaxTree wr)
        {
            AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(310L, "<i>EmitIncrementVar</i>"));
        }

        protected override void EmitDecrementVar(string varName, ConcreteSyntaxTree wr)
        {
            AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(311L, "<i>EmitDecrementVar</i>"));
        }

        protected override ConcreteSyntaxTree EmitQuantifierExpr(Action<ConcreteSyntaxTree> collection, bool isForall, Type collectionElementType, BoundVar bv, ConcreteSyntaxTree wr)
        {
            if (GetExprBuilder(wr, out var builder))
            {
                var collectionBuf = new ExprBuffer(null);
                collection(new BuilderSyntaxTree<ExprContainer>(collectionBuf, this));
                var collectionAST = collectionBuf.Finish();

                builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_Literal(DAST.Literal.create_BoolLiteral(MutateCSharp.Schemata223.ReplaceBooleanConstant_10(312L, false))));

                return new BuilderSyntaxTree<ExprContainer>(new ExprBuffer(null), this);
            }
            else
            {
                throw new InvalidOperationException();
            }

            return default;
        }

        protected override string GetQuantifierName(string bvType)
        {
            throw new InvalidOperationException();
            return default;
        }

        protected override ConcreteSyntaxTree CreateForeachLoop(string tmpVarName, Type collectionElementType, IToken tok,
          out ConcreteSyntaxTree collectionWriter, ConcreteSyntaxTree wr)
        {
            if (wr is BuilderSyntaxTree<StatementContainer> statementContainer)
            {
                var foreachBuilder = statementContainer.Builder.Foreach(tmpVarName, GenType(collectionElementType));
                collectionWriter = new BuilderSyntaxTree<ExprContainer>(foreachBuilder, this);
                return new BuilderSyntaxTree<StatementContainer>(foreachBuilder, this);
            }
            else
            {
                throw new InvalidOperationException();
            }

            return default;
        }

        protected override ConcreteSyntaxTree EmitDowncast(Type from, Type to, IToken tok, ConcreteSyntaxTree wr)
        {
            return EmitCoercionIfNecessary(from, to, tok, wr);
        }

        protected override void EmitDowncastVariableAssignment(string boundVarName, Type boundVarType, string tmpVarName,
          Type sourceType, bool introduceBoundVar, IToken tok, ConcreteSyntaxTree wr)
        {
            var w = introduceBoundVar ? DeclareLocalVar(boundVarName, boundVarType, tok, wr) : IdentLvalue(boundVarName).EmitWrite(wr);
            EmitIdentifier(tmpVarName, EmitCoercionIfNecessary(sourceType, boundVarType, tok, w));
        }

        protected override ConcreteSyntaxTree CreateForeachIngredientLoop(string boundVarName, int L, string tupleTypeArgs,
            out ConcreteSyntaxTree collectionWriter, ConcreteSyntaxTree wr)
        {
            AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(313L, "<i>CreateForeachIngredientLoop</i>"));
            collectionWriter = new BuilderSyntaxTree<ExprContainer>(new ExprBuffer(null), this);
            return new BuilderSyntaxTree<StatementContainer>(new StatementBuffer(), this);
        }

        protected override void EmitNew(Type type, IToken tok, CallStmt initCall, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (GetExprConverter(wr, wStmts, out var builder, out var convert))
            {
                var ctor = (Constructor)initCall?.Method;
                var arguments = Enumerable.Empty<DAST.Expression>();
                if (MutateCSharp.Schemata223.ReplaceBinExprOp_31(314L, ctor, null) && ctor.IsExtern(Options, out _, out _))
                {
                    // the arguments of any external constructor are placed here
                    arguments = ctor.Ins.Select((f, i) => (f, i))
                      .Where(tp => !tp.f.IsGhost)
                      .Select(tp =>
                      {
                          var buf = new ExprBuffer(null);
                          var localWriter = new BuilderSyntaxTree<ExprContainer>(buf, this);
                          EmitExpr(initCall.Args[tp.i], MutateCSharp.Schemata223.ReplaceBooleanConstant_10(315L, false), localWriter, wStmts);
                          return buf.Finish();
                      });
                }

                var typeArgs = type.TypeArgs.Select(GenType).ToArray();

                builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_New(
                  PathFromTopLevel(type.AsTopLevelTypeWithMembers),
                  Sequence<DAST.Type>.FromArray(typeArgs),
                  Sequence<DAST.Expression>.FromArray(arguments.ToArray())
                ));
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected override void EmitNewArray(Type elementType, IToken tok, List<string> dimensions,
          bool mustInitialize, [CanBeNull] string exampleElement, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            throw new InvalidOperationException();
        }

        protected override void EmitNewArray(Type elementType, IToken tok, List<Expression> dimensions, bool mustInitialize, [CanBeNull] string exampleElement, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (GetExprConverter(wr, wStmts, out var builder, out var convert))
            {
                var dimensionsAST = dimensions.Select(convert).ToArray();

                builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_NewArray(
                  Sequence<DAST.Expression>.FromArray(dimensionsAST),
                  GenType(elementType)
                ));
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected override void EmitIdentifier(string ident, ConcreteSyntaxTree wr)
        {
            if (GetExprBuilder(wr, out var builder))
            {
                builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_Ident(
                  Sequence<Rune>.UnicodeFromString(ident)
                ));
            }
            else
            {
                AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(316L, "Expected ExprContainer, got ") + wr.GetType());
            }
        }

        protected override void EmitLiteralExpr(ConcreteSyntaxTree wr, LiteralExpr e)
        {
            if (GetExprBuilder(wr, out var builder))
            {
                DAST.Expression baseExpr;

                switch (e)
                {
                    case CharLiteralExpr c:
                        if (UnicodeCharEnabled)
                        {
                            var codePoint = Util.UnescapedCharacters(Options, (string)c.Value, false).Single();
                            baseExpr = (DAST.Expression)DAST.Expression.create_Literal(DAST.Literal.create_CharLiteral(
                              new Rune(codePoint)
                            ));
                        }
                        else
                        {
                            AddUnsupported("<i>Char literal without unicode char enabled</i>");
                            return;
                        }
                        break;
                        break;
                    case StringLiteralExpr str:
                        baseExpr = (DAST.Expression)DAST.Expression.create_Literal(DAST.Literal.create_StringLiteral(
                          Sequence<Rune>.UnicodeFromString(str.AsStringLiteral())
                        ));
                        break;
                        break;
                    case StaticReceiverExpr:
                        if (e.Type.NormalizeExpandKeepConstraints() is UserDefinedType udt && udt.ResolvedClass is DatatypeDecl dt &&
                            DatatypeWrapperEraser.IsErasableDatatypeWrapper(Options, dt, out _))
                        {
                            baseExpr = (DAST.Expression)DAST.Expression.create_Companion(PathFromTopLevel(udt.ResolvedClass));
                        }
                        else
                        {
                            baseExpr = (DAST.Expression)DAST.Expression.create_Companion(PathFromTopLevel(e.Type.AsTopLevelTypeWithMembers));
                        }
                        break;
                        break;
                    default:
                        DAST.Type baseType = GenType(e.Type.NormalizeToAncestorType());

                        switch (e.Value)
                        {
                            case null:
                                baseExpr = (DAST.Expression)DAST.Expression.create_Literal(DAST.Literal.create_Null(GenType(e.Type)));
                                break;
                            case bool value:
                                baseExpr = (DAST.Expression)DAST.Expression.create_Literal(DAST.Literal.create_BoolLiteral(value));
                                break;
                            case BigInteger integer:
                                baseExpr = (DAST.Expression)DAST.Expression.create_Literal(DAST.Literal.create_IntLiteral(
                                  Sequence<Rune>.UnicodeFromString(integer.ToString()),
                                  baseType
                                ));
                                break;
                            case BigDec n:
                                var mantissaStr = n.Mantissa.ToString();
                                var denominator = "1";
                                if (n.Exponent > 0)
                                {
                                    for (var i = 0; i < n.Exponent; i++)
                                    {
                                        mantissaStr += "0";
                                    }
                                }
                                else
                                {
                                    for (var i = 0; i < -n.Exponent; i++)
                                    {
                                        denominator += "0";
                                    }
                                }

                                baseExpr = (DAST.Expression)DAST.Expression.create_Literal(DAST.Literal.create_DecLiteral(
                                  Sequence<Rune>.UnicodeFromString(mantissaStr),
                                  Sequence<Rune>.UnicodeFromString(denominator),
                                  baseType
                                ));
                                break;
                            default:
                                // TODO: This may not be exhaustive
                                throw new cce.UnreachableException();
                        }
                        break;
                        break;
                }

                if (MutateCSharp.Schemata223.ReplaceBinExprOp_22(317L, e.Type.AsNewtype, null))
                {
                    baseExpr = (DAST.Expression)DAST.Expression.create_Convert(baseExpr, GenType(e.Type.AsNewtype.BaseType), GenType(e.Type));
                }
                else if (MutateCSharp.Schemata223.ReplaceBinExprOp_7(318L, e.Type.AsSubsetType, null))
                {
                    baseExpr = (DAST.Expression)DAST.Expression.create_Convert(baseExpr, GenType(e.Type.AsSubsetType.Rhs), GenType(e.Type));
                }

                builder.Builder.AddExpr(baseExpr);
            }
            else if (emitUncompilableCode && GetStatementBuilder(wr, out var builder2))
            {
                builder2.Builder.AddStatement(StatementContainer.UnsupportedToStatement($"Cannot emit literal expression {e} outside of expression context: " + wr.GetType()));
            }
            else
            {
                throw new InvalidOperationException(MutateCSharp.Schemata223.ReplaceStringConstant_1(319L, "Cannot emit literal expression outside of expression context: ") + wr.GetType());
            }
        }

        protected override void EmitStringLiteral(string str, bool isVerbatim, ConcreteSyntaxTree wr)
        {
            throw new UnsupportedInvalidOperationException(MutateCSharp.Schemata223.ReplaceStringConstant_1(320L, "<i>EmitStringLiteral</i>"));
        }

        protected override ConcreteSyntaxTree EmitBitvectorTruncation(BitvectorType bvType, [CanBeNull] NativeType nativeType,
          bool surroundByUnchecked, ConcreteSyntaxTree wr)
        {
            throw new UnsupportedInvalidOperationException(MutateCSharp.Schemata223.ReplaceStringConstant_1(321L, "<i>EmitBitvectorTruncation</i>"));
            return default;
        }

        protected override void EmitRotate(Expression e0, Expression e1, bool isRotateLeft, ConcreteSyntaxTree wr,
            bool inLetExprBody, ConcreteSyntaxTree wStmts, FCE_Arg_Translator tr)
        {
            AddUnsupportedFeature(e0.tok, Feature.BitvectorRotateFunctions);
        }

        protected override void EmitEmptyTupleList(string tupleTypeArgs, ConcreteSyntaxTree wr)
        {
            AddUnsupportedFeature(Token.NoToken, Feature.NonSequentializableForallStatements);
        }

        protected override ConcreteSyntaxTree EmitIngredients(ConcreteSyntaxTree wr, string ingredients, int L,
          string tupleTypeArgs, ForallStmt s, AssignStmt s0, Expression rhs)
        {
            AddUnsupportedFeature(Token.NoToken, Feature.NonSequentializableForallStatements);
            return wr;
        }
        protected override ConcreteSyntaxTree EmitAddTupleToList(string ingredients, string tupleTypeArgs, ConcreteSyntaxTree wr)
        {
            AddUnsupportedFeature(Token.NoToken, Feature.NonSequentializableForallStatements);
            return wr;
        }

        protected override void EmitTupleSelect(string prefix, int i, ConcreteSyntaxTree wr)
        {
            AddUnsupportedFeature(Token.NoToken, Feature.NonSequentializableForallStatements);
        }

        protected override string IdProtect(string name)
        {
            return PublicIdProtect(name);
        }

        public override string PublicIdProtect(string name)
        {
            return MangleName(name);
        }

        protected override string FullTypeName(UserDefinedType udt, MemberDecl member = null)
        {
            AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(322L, "<i>FullTypeName</i>"));
            return MutateCSharp.Schemata223.ReplaceStringConstant_1(323L, "FullTypeName");
        }

        private DAST.Type FullTypeNameAST(UserDefinedType udt, MemberDecl member = null)
        {
            if (udt.IsArrowType)
            {
                var arrow = udt.AsArrowType;
                return (DAST.Type)DAST.Type.create_Arrow(
                  Sequence<DAST.Type>.FromArray(arrow.Args.Select(m => GenType(m)).ToArray()),
                  GenType(arrow.Result)
                );
            }
            else if (udt.AsArrayType is var array && MutateCSharp.Schemata223.ReplaceBinExprOp_32(324L, array, null))
            {
                if (udt.IsNonNullRefType)
                {
                    return (DAST.Type)DAST.Type.create_Array(GenType(udt.TypeArgs[MutateCSharp.Schemata223.ReplaceNumericConstant_11(325L, 0)]), array.Dims);
                }
                else
                {
                    return (DAST.Type)DAST.Type.create_Nullable(
                      (DAST.Type)DAST.Type.create_Array(GenType(udt.TypeArgs[MutateCSharp.Schemata223.ReplaceNumericConstant_11(329L, 0)]), array.Dims)
                    );
                }
            }

            var cl = udt.ResolvedClass;
            switch (cl)
            {
                case TypeParameter:
                    return (DAST.Type)DAST.Type.create_TypeArg(Sequence<Rune>.UnicodeFromString(IdProtect(udt.GetCompileName(Options))));
                    break;
                case TupleTypeDecl:
                    return (DAST.Type)DAST.Type.create_Tuple(Sequence<DAST.Type>.FromArray(
                      udt.TypeArgs.Select(m => GenType(m)).ToArray()
                    ));
                    break;
                default:
                    return TypeNameASTFromTopLevel(cl, udt.TypeArgs);
                    break;
            }

            return default;
        }

        private ISequence<ISequence<Rune>> PathFromTopLevel(TopLevelDecl topLevel)
        {
            List<ISequence<Rune>> path = new();
            path.Add(Sequence<Rune>.UnicodeFromString(topLevel.EnclosingModuleDefinition.GetCompileName(Options)));
            path.Add(Sequence<Rune>.UnicodeFromString(topLevel.GetCompileName(Options)));
            return Sequence<ISequence<Rune>>.FromArray(path.ToArray());
        }

        private DAST.NewtypeRange NativeTypeToNewtypeRange(NativeType nativeType)
        {
            return (DAST.NewtypeRange)(nativeType?.Sel switch
            {
                NativeType.Selection.Byte => NewtypeRange.create_U8(),
                NativeType.Selection.SByte => NewtypeRange.create_I8(),
                NativeType.Selection.UShort => NewtypeRange.create_U16(),
                NativeType.Selection.Short => NewtypeRange.create_I16(),
                NativeType.Selection.UInt => NewtypeRange.create_U32(),
                NativeType.Selection.Int => NewtypeRange.create_I32(),
                NativeType.Selection.ULong => NewtypeRange.create_U64(),
                NativeType.Selection.Long => NewtypeRange.create_I64(),
                NativeType.Selection.UDoubleLong => NewtypeRange.create_U128(),
                NativeType.Selection.DoubleLong => NewtypeRange.create_I128(),
                _ => NewtypeRange.create_NoRange()
            });
        }

        private DAST.Type TypeNameASTFromTopLevel(TopLevelDecl topLevel, List<Type> typeArgs)
        {
            var path = PathFromTopLevel(topLevel);

            bool nonNull = MutateCSharp.Schemata223.ReplaceBooleanConstant_10(333L, true);
            if (topLevel is NonNullTypeDecl non)
            {
                topLevel = non.Rhs.AsTopLevelTypeWithMembers;
            }
            else if (topLevel is ClassLikeDecl)
            {
                nonNull = MutateCSharp.Schemata223.ReplaceBooleanConstant_10(334L, false);
            }

            ResolvedType resolvedType;
            if (topLevel is NewtypeDecl newType)
            {
                var range = NativeTypeToNewtypeRange(newType.NativeType);
                resolvedType = (DAST.ResolvedType)DAST.ResolvedType.create_Newtype(
                  GenType(EraseNewtypeLayers(topLevel)), range, MutateCSharp.Schemata223.ReplaceBooleanConstant_10(335L, true));
            }
            else if (topLevel is TypeSynonymDecl typeSynonym)
            { // Also SubsetTypeDecl
                resolvedType = (DAST.ResolvedType)DAST.ResolvedType.create_Newtype(GenType(EraseNewtypeLayers(topLevel)), NewtypeRange.create_NoRange(), MutateCSharp.Schemata223.ReplaceBooleanConstant_10(336L, true));
            }
            else if (topLevel is TraitDecl)
            {
                AddUnsupportedFeature(Token.NoToken, Feature.Traits);
                resolvedType = (DAST.ResolvedType)DAST.ResolvedType.create_Newtype(
                  DAST.Type.create_Passthrough(Sequence<Rune>.UnicodeFromString(MutateCSharp.Schemata223.ReplaceStringConstant_1(337L, "<b>Unsupported: <i>Traits</i></b>"))),
                  NewtypeRange.create_NoRange(), MutateCSharp.Schemata223.ReplaceBooleanConstant_10(338L, true
        ));
                // traits need a bit more work

                // resolvedType = (DAST.ResolvedType)DAST.ResolvedType.create_Trait(path);
            }
            else if (topLevel is DatatypeDecl)
            {
                resolvedType = (DAST.ResolvedType)DAST.ResolvedType.create_Datatype(path);
            }
            else if (topLevel is ClassDecl)
            {
                // TODO(Mikael): have a separate type when we properly support classes
                resolvedType = (DAST.ResolvedType)DAST.ResolvedType.create_Datatype(path);
            }
            else
            {
                // SubsetTypeDecl are covered by TypeSynonymDecl
                throw new InvalidOperationException(topLevel.GetType().ToString());
            }

            DAST.Type baseType = (DAST.Type)DAST.Type.create_Path(
              path,
              Sequence<DAST.Type>.FromArray(typeArgs.Select(m => GenType(m)).ToArray()),
              resolvedType
            );

            if (nonNull)
            {
                return baseType;
            }
            else
            {
                return (DAST.Type)DAST.Type.create_Nullable(baseType);
            }

            return default;
        }

        private static Type EraseNewtypeLayers(TopLevelDecl topLevel)
        {
            var topLevelType = UserDefinedType.FromTopLevelDecl(topLevel.tok, topLevel);
            return topLevelType.NormalizeToAncestorType();
        }

        public override ConcreteSyntaxTree Expr(Expression expr, bool inLetExprBody, ConcreteSyntaxTree wStmts)
        {
            if (currentBuilder is ExprContainer container)
            {
                EmitExpr(expr, inLetExprBody, new BuilderSyntaxTree<ExprContainer>(container, this), wStmts);
                return new BuilderSyntaxTree<ExprContainer>(new ExprBuffer(null), this);
            }
            else
            {
                throw new InvalidOperationException();
            }

            return default;
        }

        public override void EmitExpr(Expression expr, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var actualWr = wr;
            if (currentBuilder is ExprBuffer buf && wr is not BuilderSyntaxTree<ExprContainer>)
            {
                // the writers are not currently wired properly for DatatypeValue
                actualWr = new BuilderSyntaxTree<ExprContainer>(buf, this);
            }

            if (expr is DatatypeValue)
            {
                ExprBuffer buffer = new(currentBuilder);
                var origBuilder = currentBuilder;
                currentBuilder = buffer;
                base.EmitExpr(expr, inLetExprBody, actualWr, wStmts);

                if (MutateCSharp.Schemata223.ReplaceBinExprOp_33(339L, currentBuilder, buffer))
                {
                    // sometimes, we don't actually call EmitDatatypeValue
                    currentBuilder = origBuilder;
                }
            }
            else if (expr is BinaryExpr bin)
            {
                var origBuilder = currentBuilder;
                base.EmitExpr(expr, inLetExprBody, actualWr, wStmts);
                currentBuilder = origBuilder;
            }
            else if (expr is IdentifierExpr)
            {
                // we don't need to create a copy of the identifier, that's language specific
                base.EmitExpr(expr, MutateCSharp.Schemata223.ReplaceBooleanConstant_10(340L, false), actualWr, wStmts);
            }
            else if (expr is QuantifierExpr)
            {
                AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(341L, "<i>QuantifierExpr</i>"));
            }
            else
            {
                base.EmitExpr(expr, inLetExprBody, actualWr, wStmts);
            }
        }

        protected override void EmitThis(ConcreteSyntaxTree wr, bool callToInheritedMember)
        {
            if (GetExprBuilder(wr, out var builder))
            {
                builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_This());
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected override void EmitDatatypeValue(DatatypeValue dtv, string typeDescriptorArguments, string arguments, ConcreteSyntaxTree wr)
        {
            if (GetExprBuilder(wr, out var builder) && currentBuilder is ExprBuffer buf)
            {
                List<DAST.Expression> contents = buf.PopAll();
                currentBuilder = buf.parent; // pop early to make sure the receiving builder is in the expected state
                List<_System._ITuple2<ISequence<Rune>, DAST.Expression>> namedContents = new();

                int argI = MutateCSharp.Schemata223.ReplaceNumericConstant_11(342L, 0);
                for (int i = MutateCSharp.Schemata223.ReplaceNumericConstant_11(346L, 0); MutateCSharp.Schemata223.ReplaceBinExprOp_25(350L, i, dtv.Ctor.Formals.Count); MutateCSharp.Schemata223.ReplacePostfixUnaryExprOp_26(355L, ref i))
                {
                    var formal = dtv.Ctor.Formals[i];
                    if (formal.IsGhost)
                    {
                        continue;
                    }

                    var actual = contents[argI];
                    namedContents.Add(_System.Tuple2<ISequence<Rune>, DAST.Expression>.create(
                      Sequence<Rune>.UnicodeFromString(formal.CompileName),
                      actual
                    ));
                    MutateCSharp.Schemata223.ReplacePostfixUnaryExprOp_26(356L, ref argI);
                }

                if (MutateCSharp.Schemata223.ReplaceBinExprOp_34(357L, argI, contents.Count))
                {
                    var error = MutateCSharp.Schemata223.ReplaceStringConstant_1(362L, "Datatype constructor "
          ) + dtv.Ctor.Name + MutateCSharp.Schemata223.ReplaceStringConstant_1(363L, " expects ") + dtv.Ctor.Formals.Count + MutateCSharp.Schemata223.ReplaceStringConstant_1(364L, " arguments, but "
          ) + contents.Count + MutateCSharp.Schemata223.ReplaceStringConstant_1(365L, " were provided");
                    if (emitUncompilableCode)
                    {
                        contents.Insert(MutateCSharp.Schemata223.ReplaceNumericConstant_11(366L, 0),
                          ExprContainer.UnsupportedToExpr(
                            error));
                        builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_Tuple(
                          Sequence<DAST.Expression>.FromArray(contents.ToArray())
                          ));
                        return;
                    }
                    throw new InvalidOperationException(error);
                }

                if (dtv.Ctor.EnclosingDatatype is TupleTypeDecl tupleDecl)
                {
                    builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_Tuple(
                      Sequence<DAST.Expression>.FromArray(namedContents.Select(x => x.dtor__1).ToArray())
                    ));
                }
                else
                {
                    var dtPath = PathFromTopLevel(dtv.Ctor.EnclosingDatatype);
                    var dtTypeArgs = Sequence<DAST.Type>.FromArray(dtv.InferredTypeArgs.Select(m => GenType(m)).ToArray());
                    builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_DatatypeValue(
                      dtPath,
                      dtTypeArgs,
                      Sequence<Rune>.UnicodeFromString(dtv.Ctor.GetCompileName(Options)),
                      dtv.Ctor.EnclosingDatatype is CoDatatypeDecl,
                      Sequence<_System._ITuple2<ISequence<Rune>, DAST.Expression>>.FromArray(namedContents.ToArray())
                    ));
                }
            }
            else
            {
                throw new InvalidOperationException(MutateCSharp.Schemata223.ReplaceStringConstant_1(370L, "Cannot emit datatype value outside of expression context: ") + wr.GetType() + MutateCSharp.Schemata223.ReplaceStringConstant_1(371L, ", ") + currentBuilder);
            }
        }

        protected override void GetSpecialFieldInfo(SpecialField.ID id, object idParam, Type receiverType,
            out string compiledName, out string preString, out string postString)
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
                    break;
                    break;
                case SpecialField.ID.Keys:
                    break;
                    break;
                case SpecialField.ID.Values:
                    break;
                    break;
                default:
                    AddUnsupported("<i>Special field: " + id + "</i>");
                    break;
                    break;
            }
        }

        protected override ILvalue EmitMemberSelect(Action<ConcreteSyntaxTree> obj, Type objType, MemberDecl member,
          List<TypeArgumentInstantiation> typeArgs, Dictionary<TypeParameter, Type> typeMap, Type expectedType,
          string additionalCustomParameter = null, bool internalAccess = false)
        {
            var objReceiver = new ExprBuffer(null);

            var memberStatus = DatatypeWrapperEraser.GetMemberStatus(Options, member);

            if (MutateCSharp.Schemata223.ReplaceBinExprOp_35(372L, memberStatus, DatatypeWrapperEraser.MemberCompileStatus.Identity))
            {
                obj(new BuilderSyntaxTree<ExprContainer>(objReceiver, this));
                var objExpr = objReceiver.Finish();
                return new ExprLvalue(objExpr, null, this);
            }
            else if (MutateCSharp.Schemata223.ReplaceBinExprOp_35(373L, memberStatus, DatatypeWrapperEraser.MemberCompileStatus.AlwaysTrue))
            {
                return new ExprLvalue((DAST.Expression)DAST.Expression.create_Literal(DAST.Literal.create_BoolLiteral(MutateCSharp.Schemata223.ReplaceBooleanConstant_10(374L, true))), null, this);
            }
            else if (member is DatatypeDestructor dtor)
            {
                obj(new BuilderSyntaxTree<ExprContainer>(objReceiver, this));
                var objExpr = objReceiver.Finish();
                if (dtor.EnclosingClass is TupleTypeDecl)
                {
                    return new ExprLvalue((DAST.Expression)DAST.Expression.create_TupleSelect(
                      objExpr,
                      int.Parse(dtor.CorrespondingFormals[MutateCSharp.Schemata223.ReplaceNumericConstant_11(375L, 0)].NameForCompilation)
                    ), null, this);
                }
                else
                {
                    return new ExprLvalue((DAST.Expression)DAST.Expression.create_Select(
                      objExpr,
                      Sequence<Rune>.UnicodeFromString(member.GetCompileName(Options)),
                      member is ConstantField,
                      member.EnclosingClass is DatatypeDecl
                    ), (DAST.AssignLhs)DAST.AssignLhs.create_Select(
                      objExpr,
                      Sequence<Rune>.UnicodeFromString(member.GetCompileName(Options))
                    ), this);
                }
            }
            else if (member is SpecialField arraySpecial && MutateCSharp.Schemata223.ReplaceBinExprOp_36(379L, arraySpecial.SpecialId, SpecialField.ID.ArrayLength))
            {
                obj(EmitCoercionIfNecessary(
                    objType,
        MutateCSharp.Schemata223.ReplaceBinExprOp_8(380L, () => objType.IsNonNullRefType, () => !objType.IsRefType) ? null : UserDefinedType.CreateNonNullType((UserDefinedType)objType.NormalizeExpand()),
                  null, new BuilderSyntaxTree<ExprContainer>(objReceiver, this)
                ));
                var objExpr = objReceiver.Finish();

                return new ExprLvalue((DAST.Expression)DAST.Expression.create_ArrayLen(
                  objExpr,
                  arraySpecial.IdParam != null ? ((int)arraySpecial.IdParam) : MutateCSharp.Schemata223.ReplaceNumericConstant_11(386L, 0
        )), null, this);
            }
            else if (member is SpecialField { SpecialId: SpecialField.ID.Keys })
            {
                obj(new BuilderSyntaxTree<ExprContainer>(objReceiver, this));
                var objExpr = objReceiver.Finish();
                return new ExprLvalue((DAST.Expression)DAST.Expression.create_MapKeys(
                  objExpr), null, this);
            }
            else if (member is SpecialField { SpecialId: SpecialField.ID.Values })
            {
                obj(new BuilderSyntaxTree<ExprContainer>(objReceiver, this));
                var objExpr = objReceiver.Finish();
                return new ExprLvalue((DAST.Expression)DAST.Expression.create_MapValues(
                  objExpr), null, this);
            }
            else if (member is SpecialField sf && MutateCSharp.Schemata223.ReplaceBinExprOp_37(390L, sf.SpecialId, SpecialField.ID.UseIdParam))
            {
                obj(new BuilderSyntaxTree<ExprContainer>(objReceiver, this));
                var objExpr = objReceiver.Finish();

                GetSpecialFieldInfo(sf.SpecialId, sf.IdParam, objType, out var compiledName, out _, out _);
                return new ExprLvalue((DAST.Expression)DAST.Expression.create_Select(
                  objExpr,
                  Sequence<Rune>.UnicodeFromString(compiledName),
                  member is ConstantField,
                  member.EnclosingClass is DatatypeDecl
                ), (DAST.AssignLhs)DAST.AssignLhs.create_Select(
                  objExpr,
                  Sequence<Rune>.UnicodeFromString(compiledName)
                ), this);
            }
            else if (member is SpecialField sf2 && sf2.SpecialId == SpecialField.ID.UseIdParam && sf2.IdParam is string fieldName && fieldName.StartsWith(MutateCSharp.Schemata223.ReplaceStringConstant_1(391L, "is_")))
            {
                obj(new BuilderSyntaxTree<ExprContainer>(objReceiver, this));
                var objExpr = objReceiver.Finish();

                return new ExprLvalue((DAST.Expression)DAST.Expression.create_TypeTest(
                  objExpr,
                  PathFromTopLevel(objType.AsTopLevelTypeWithMembers),
                  Sequence<Rune>.UnicodeFromString(fieldName.Substring(MutateCSharp.Schemata223.ReplaceNumericConstant_11(392L, 3)))
                ), null, this);
            }
            else
            {
                obj(new BuilderSyntaxTree<ExprContainer>(objReceiver, this));
                var objExpr = objReceiver.Finish();

                if (expectedType.IsArrowType)
                {
                    return new ExprLvalue((DAST.Expression)DAST.Expression.create_SelectFn(
                      objExpr,
                      Sequence<Rune>.UnicodeFromString(member.GetCompileName(Options)),
                      member.EnclosingClass is DatatypeDecl,
                      member.IsStatic,
                      expectedType.AsArrowType.Arity
                    ), null, this);
                }
                else if (MutateCSharp.Schemata223.ReplaceBinExprOp_2(402L, () => internalAccess, () => (MutateCSharp.Schemata223.ReplaceBinExprOp_8(396L, () => member is ConstantField, () => member.EnclosingClass is TraitDecl))))
                {
                    return new ExprLvalue((DAST.Expression)DAST.Expression.create_Select(
                      objExpr,
                      Sequence<Rune>.UnicodeFromString(MutateCSharp.Schemata223.ReplaceStringConstant_1(408L, "_") + member.GetCompileName(Options)),
          MutateCSharp.Schemata223.ReplaceBooleanConstant_10(409L, false),
                      member.EnclosingClass is DatatypeDecl
                    ), (DAST.AssignLhs)DAST.AssignLhs.create_Select(
                      objExpr,
                      Sequence<Rune>.UnicodeFromString(MutateCSharp.Schemata223.ReplaceStringConstant_1(410L, "_") + member.GetCompileName(Options))
                    ), this);
                }
                else
                {
                    return new ExprLvalue((DAST.Expression)DAST.Expression.create_Select(
                      objExpr,
                      Sequence<Rune>.UnicodeFromString(member.GetCompileName(Options)),
                      member is ConstantField,
                      member.EnclosingClass is DatatypeDecl
                    ), (DAST.AssignLhs)DAST.AssignLhs.create_Select(
                      objExpr,
                      Sequence<Rune>.UnicodeFromString(member.GetCompileName(Options))
                    ), this);
                }
            }

            return default;
        }

        protected override ConcreteSyntaxTree EmitArraySelect(List<Action<ConcreteSyntaxTree>> indices, Type elmtType, ConcreteSyntaxTree wr)
        {
            if (GetExprBuilder(wr, out var builder))
            {
                var indicesAST = indices.Select(i =>
                {
                    var buf = new ExprBuffer(null);
                    var localWriter = new BuilderSyntaxTree<ExprContainer>(buf, this);
                    i(localWriter);
                    return buf.Finish();
                }).ToList();

                return new BuilderSyntaxTree<ExprContainer>(builder.Builder.Index(indicesAST, DAST.CollKind.create_Array()), this);
            }
            else
            {
                throw new InvalidOperationException();
            }

            return default;
        }

        protected override ConcreteSyntaxTree EmitArraySelect(List<Expression> indices, Type elmtType, bool inLetExprBody,
            ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (GetExprConverter(wr, wStmts, out var builder, out var convert))
            {
                var indicesAST = indices.Select(convert).ToList();

                return new BuilderSyntaxTree<ExprContainer>(builder.Builder.Index(
                  indicesAST, DAST.CollKind.create_Array()), this);
            }
            else
            {
                throw new InvalidOperationException();
            }

            return default;
        }

        protected override (ConcreteSyntaxTree wArray, ConcreteSyntaxTree wRhs) EmitArrayUpdate(List<Action<ConcreteSyntaxTree>> indices, Type elmtType, ConcreteSyntaxTree wr)
        {
            if (GetStatementBuilder(wr, out var builder))
            {
                var indicesAST = indices.Select(i =>
                {
                    var buf = new ExprBuffer(null);
                    var localWriter = new BuilderSyntaxTree<ExprContainer>(buf, this);
                    i(localWriter);
                    return buf.Finish();
                }).ToList();

                var assign = builder.Builder.Assign();

                return (new BuilderSyntaxTree<ExprContainer>(((LhsContainer)assign).Array(indicesAST), this), new BuilderSyntaxTree<ExprContainer>(assign, this));
            }
            else
            {
                throw new InvalidOperationException();
            }

            return default;
        }

        protected override void EmitExprAsNativeInt(Expression expr, bool inLetExprBody, ConcreteSyntaxTree wr,
          ConcreteSyntaxTree wStmts)
        {
            EmitExpr(expr, inLetExprBody, wr, wStmts);
        }

        protected override void EmitIndexCollectionSelect(Expression source, Expression index, bool inLetExprBody,
          ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var sourceBuf = new ExprBuffer(null);
            EmitExpr(source, inLetExprBody, new BuilderSyntaxTree<ExprContainer>(sourceBuf, this), wStmts);

            var indexBuf = new ExprBuffer(null);
            EmitExpr(index, inLetExprBody, new BuilderSyntaxTree<ExprContainer>(indexBuf, this), wStmts);

            DAST._ICollKind collKind;
            if (source.Type.IsArrayType)
            {
                collKind = DAST.CollKind.create_Array();
            }
            else if (source.Type.NormalizeToAncestorType().IsMapType)
            {
                collKind = DAST.CollKind.create_Map();
            }
            else
            {
                collKind = DAST.CollKind.create_Seq();
            }

            if (GetExprBuilder(wr, out var builder))
            {
                builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_Index(
                  sourceBuf.Finish(),
                  collKind,
                  Sequence<DAST.Expression>.FromElements(indexBuf.Finish())
                ));
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected static bool GetStatementBuilder(ConcreteSyntaxTree wStmts,
          out BuilderSyntaxTree<StatementContainer> statementBuilder)
        {
            if (wStmts is BuilderSyntaxTree<StatementContainer> s)
            {
                statementBuilder = s;
                return MutateCSharp.Schemata223.ReplaceBooleanConstant_10(411L, true);
            }
            statementBuilder = null;
            return MutateCSharp.Schemata223.ReplaceBooleanConstant_10(412L, false);
        }

        protected static bool GetExprBuilder(ConcreteSyntaxTree wr,
          out BuilderSyntaxTree<ExprContainer> builder)
        {
            if (wr is BuilderSyntaxTree<ExprContainer> exprBuilder)
            {
                builder = exprBuilder;
                return MutateCSharp.Schemata223.ReplaceBooleanConstant_10(413L, true);
            }
            builder = null;
            return MutateCSharp.Schemata223.ReplaceBooleanConstant_10(414L, false);
        }

        protected bool GetExprConverter(ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts,
          out BuilderSyntaxTree<ExprContainer> builder,
          out Func<Expression, DAST.Expression> converter)
        {
            if (wr is BuilderSyntaxTree<ExprContainer> b)
            {
                converter = (Expression expr) => ConvertExpression(expr, wStmts);
                builder = b;
                return MutateCSharp.Schemata223.ReplaceBooleanConstant_10(415L, true);
            }
            converter = null;
            builder = null;
            return MutateCSharp.Schemata223.ReplaceBooleanConstant_10(416L, false);
        }

        protected override void EmitIndexCollectionUpdate(Expression source, Expression index, Expression value,
          CollectionType resultCollectionType, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (GetExprConverter(wr, wStmts, out var builder, out var convert))
            {
                if (resultCollectionType.AsSeqType is { })
                {
                    builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_SeqUpdate(
                      convert(source), convert(index), convert(value)
                    ));
                }
                else if (resultCollectionType.AsMapType is { })
                {
                    builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_MapUpdate(
                      convert(source), convert(index), convert(value)
                    ));
                }
                else
                {
                    AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(417L, "<i>EmitIndexCollectionUpdate for ") + resultCollectionType.ToString() + MutateCSharp.Schemata223.ReplaceStringConstant_1(418L, "</i>"));
                }
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected override void EmitSeqSelectRange(Expression source, Expression lo, Expression hi, bool fromArray,
          bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var sourceBuf = new ExprBuffer(null);
            EmitExpr(
              source,
              inLetExprBody,
              EmitCoercionIfNecessary(
                source.Type,
      MutateCSharp.Schemata223.ReplaceBinExprOp_8(419L, () => source.Type.IsNonNullRefType, () => !source.Type.IsRefType) ? null : UserDefinedType.CreateNonNullType((UserDefinedType)source.Type.NormalizeExpand()),
                null, new BuilderSyntaxTree<ExprContainer>(sourceBuf, this)
              ),
              wStmts
            );
            var sourceExpr = sourceBuf.Finish();

            DAST.Expression loExpr = null;
            if (MutateCSharp.Schemata223.ReplaceBinExprOp_38(425L, lo, null))
            {
                var loBuf = new ExprBuffer(null);
                EmitExpr(lo, inLetExprBody, new BuilderSyntaxTree<ExprContainer>(loBuf, this), wStmts);
                loExpr = loBuf.Finish();
            }

            DAST.Expression hiExpr = null;
            if (MutateCSharp.Schemata223.ReplaceBinExprOp_38(426L, hi, null))
            {
                var hiBuf = new ExprBuffer(null);
                EmitExpr(hi, inLetExprBody, new BuilderSyntaxTree<ExprContainer>(hiBuf, this), wStmts);
                hiExpr = hiBuf.Finish();
            }

            if (GetExprBuilder(wr, out var builder))
            {
                builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_IndexRange(
                  sourceExpr,
                  fromArray,
        MutateCSharp.Schemata223.ReplaceBinExprOp_39(427L, loExpr, null) ? Option<DAST._IExpression>.create_Some(loExpr) : Option<DAST._IExpression>.create_None(),
        MutateCSharp.Schemata223.ReplaceBinExprOp_39(428L, hiExpr, null) ? Option<DAST._IExpression>.create_Some(hiExpr) : Option<DAST._IExpression>.create_None()
                ));
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected override void EmitSeqConstructionExpr(SeqConstructionExpr expr, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (GetExprConverter(wr, wStmts, out var builder, out var convert))
            {
                var size = expr.N;
                if (size.Type.AsNewtype is { })
                {
                    size = new ConversionExpr(expr.N.tok, size, new IntType());
                }
                builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_SeqConstruct(
                  convert(size),
                  convert(expr.Initializer)
                ));
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected override void EmitMultiSetFormingExpr(MultiSetFormingExpr expr, bool inLetExprBody, ConcreteSyntaxTree wr,
          ConcreteSyntaxTree wStmts)
        {
            if (GetExprConverter(wr, wStmts, out var builder, out var convert))
            {
                builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_ToMultiset(
                  convert(expr.E)));
            }
            else
            {
                AddUnsupportedFeature(expr.tok, Feature.Multisets);
            }
        }

        protected override void EmitApplyExpr(Type functionType, IToken tok, Expression function,
            List<Expression> arguments, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (GetExprConverter(wr, wStmts, out var builder, out var convert))
            {
                builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_Apply(
                  convert(function),
                  Sequence<DAST.Expression>.FromArray(
                    arguments.Select(arg => convert(arg)).ToArray())));
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected override ConcreteSyntaxTree EmitBetaRedex(List<string> boundVars, List<Expression> arguments,
          List<Type> boundTypes, Type resultType, IToken resultTok, bool inLetExprBody, ConcreteSyntaxTree wr,
          ref ConcreteSyntaxTree wStmts)
        {
            if (GetExprConverter(wr, wStmts, out var builder, out var convert))
            {
                var argsAST = arguments.Select((t, i) =>
                  (_System.Tuple2<DAST.Formal, DAST.Expression>)
                  _System.Tuple2<DAST.Formal, DAST.Expression>.create(
                    (DAST.Formal)DAST.Formal.create_Formal(Sequence<Rune>.UnicodeFromString(boundVars[i]),
                      GenType(boundTypes[i])), convert(t))).ToList();

                var retType = GenType(resultType);

                return new BuilderSyntaxTree<ExprContainer>(builder.Builder.BetaRedex(
                  argsAST, retType
                ), this);
            }
            else
            {
                throw new InvalidOperationException();
            }

            return default;
        }

        protected override void EmitDestructor(Action<ConcreteSyntaxTree> source, Formal dtor, int formalNonGhostIndex, DatatypeCtor ctor,
            List<Type> typeArgs, Type bvType, ConcreteSyntaxTree wr)
        {
            if (GetExprBuilder(wr, out var builder))
            {
                if (DatatypeWrapperEraser.IsErasableDatatypeWrapper(Options, ctor.EnclosingDatatype, out var coreDtor))
                {
                    Contract.Assert(coreDtor.CorrespondingFormals.Count == 1);
                    Contract.Assert(dtor == coreDtor.CorrespondingFormals[0]); // any other destructor is a ghost
                    source(wr);
                }
                else
                {
                    var buf = new ExprBuffer(null);
                    source(new BuilderSyntaxTree<ExprContainer>(buf, this));
                    var sourceAST = buf.Finish();
                    if (ctor.EnclosingDatatype is TupleTypeDecl)
                    {
                        builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_TupleSelect(
                          sourceAST,
                          int.Parse(dtor.NameForCompilation)
                        ));
                    }
                    else
                    {
                        builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_Select(
                          sourceAST,
                          Sequence<Rune>.UnicodeFromString(dtor.CompileName),
            MutateCSharp.Schemata223.ReplaceBooleanConstant_10(429L, false),
            MutateCSharp.Schemata223.ReplaceBooleanConstant_10(430L, true
            )));
                    }
                }
            }
        }

        protected override ConcreteSyntaxTree CreateLambda(List<Type> inTypes, IToken tok, List<string> inNames,
            Type resultType, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts, bool untyped = false)
        {
            if (GetExprBuilder(wr, out var builder))
            {
                var formals = new List<DAST.Formal>();
                for (int i = MutateCSharp.Schemata223.ReplaceNumericConstant_11(431L, 0); MutateCSharp.Schemata223.ReplaceBinExprOp_25(435L, i, inTypes.Count); MutateCSharp.Schemata223.ReplacePrefixUnaryExprOp_40(440L, ref i))
                {
                    formals.Add((DAST.Formal)DAST.Formal.create_Formal(
                      Sequence<Rune>.UnicodeFromString(inNames[i]),
                      GenType(inTypes[i])
                    ));
                }

                var retType = GenType(resultType);

                return new BuilderSyntaxTree<StatementContainer>(builder.Builder.Lambda(formals, retType), this);
            }
            else
            {
                throw new InvalidOperationException();
            }

            return default;
        }

        protected override void EmitLambdaApply(ConcreteSyntaxTree wr, out ConcreteSyntaxTree wLambda, out ConcreteSyntaxTree wArg)
        {
            if (GetExprBuilder(wr, out var exprBuilder))
            {
                var lambda = exprBuilder.Builder.Apply();
                wLambda = new BuilderSyntaxTree<ExprContainer>(lambda, this);
                wArg = new BuilderSyntaxTree<ExprContainer>(lambda, this);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected override ConcreteSyntaxTree EmitAnd(Action<ConcreteSyntaxTree> lhs, ConcreteSyntaxTree wr)
        {
            if (GetExprBuilder(wr, out var builder))
            {
                var binOp = builder.Builder.BinOp((DAST.BinOp)DAST.BinOp.create_Passthrough(
                  Sequence<Rune>.UnicodeFromString(MutateCSharp.Schemata223.ReplaceStringConstant_1(444L, "&&"))
                ));
                lhs(new BuilderSyntaxTree<ExprContainer>(binOp, this));

                return new BuilderSyntaxTree<ExprContainer>(binOp, this);
            }
            else
            {
                throw new InvalidOperationException();
            }

            return default;
        }

        protected override void EmitBoolBoundedPool(bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (GetExprBuilder(wr, out var exprBuilder))
            {
                exprBuilder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_BoolBoundedPool());
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected override void EmitCharBoundedPool(bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(445L, "<i>EmitCharBoundedPool</i>"));
        }

        protected override void EmitWiggleWaggleBoundedPool(bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(446L, "<i>EmitWiggleWaggleBoundedPool</i>"));
        }

        protected override void EmitSetBoundedPool(Expression of, string propertySuffix, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (GetExprConverter(wr, wStmts, out var exprBuilder, out var convert))
            {
                exprBuilder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_SetBoundedPool(
                  convert(of)
                ));
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected override void EmitMultiSetBoundedPool(Expression of, bool includeDuplicates, string propertySuffix, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(447L, "<i>EmitMultiSetBoundedPool</i>"));
        }

        protected override void EmitSubSetBoundedPool(Expression of, string propertySuffix, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(448L, "<i>EmitSubSetBoundedPool</i>"));
        }

        protected override void EmitMapBoundedPool(Expression map, string propertySuffix, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(449L, "<i>EmitMapBoundedPool</i>"));
        }

        protected override void EmitSeqBoundedPool(Expression of, bool includeDuplicates, string propertySuffix, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (GetExprConverter(wr, wStmts, out var exprBuilder, out var convert))
            {
                exprBuilder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_SeqBoundedPool(
                  convert(of),
                  includeDuplicates
                ));
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected override void EmitDatatypeBoundedPool(IVariable bv, string propertySuffix, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(450L, "<i>EmitDatatypeBoundedPool</i>"));
        }

        protected override void CreateIIFE(string bvName, Type bvType, IToken bvTok, Type bodyType, IToken bodyTok,
          ConcreteSyntaxTree wr, ref ConcreteSyntaxTree wStmts, out ConcreteSyntaxTree wrRhs, out ConcreteSyntaxTree wrBody)
        {
            if (GetExprBuilder(wr, out var builder))
            {
                var iife = builder.Builder.IIFE(bvName, GenType(bvType));
                wrRhs = new BuilderSyntaxTree<ExprContainer>(iife.RhsBuilder(), this);
                wrBody = new BuilderSyntaxTree<ExprContainer>(iife, this);
            }
            else
            {
                throw new InvalidOperationException(MutateCSharp.Schemata223.ReplaceStringConstant_1(451L, "Invalid context for IIFE: ") + wr.GetType());
            }
        }

        protected override ConcreteSyntaxTree CreateIIFE0(Type resultType, IToken resultTok, ConcreteSyntaxTree wr,
            ConcreteSyntaxTree wStmts)
        {
            EmitLambdaApply(wr, out var wLambda, out var wArg);
            return CreateLambda(new(), null, new(), resultType, wLambda, wStmts);
        }

        protected override ConcreteSyntaxTree CreateIIFE1(int source, Type resultType, IToken resultTok, string bvName,
            ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            EmitLambdaApply(wr, out var wLambda, out var wArg);
            var ret = CreateLambda(new() { Type.Int }, null, new() { bvName }, resultType, wLambda, wStmts);
            EmitLiteralExpr(wArg, new LiteralExpr(null, source)
            {
                Type = Type.Int
            });
            return ret;
        }

        protected override void EmitUnaryExpr(ResolvedUnaryOp op, Expression expr, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (GetExprConverter(wr, wStmts, out var container, out var convert))
            {
                switch (op)
                {
                    case ResolvedUnaryOp.BoolNot:
                        {
                            container.Builder.AddExpr((DAST.Expression)DAST.Expression.create_UnOp(
                              UnaryOp.create_Not(),
                              convert(expr),
                              new UnaryOpFormat_NoFormat()
                            ));
                            break;
                        }

                        break;
                    case ResolvedUnaryOp.BitwiseNot:
                        {
                            container.Builder.AddExpr((DAST.Expression)DAST.Expression.create_UnOp(
                              UnaryOp.create_BitwiseNot(),
                              convert(expr),
                              new UnaryOpFormat_NoFormat()
                            ));
                            break;
                        }

                        break;
                    case ResolvedUnaryOp.Cardinality:
                        {
                            container.Builder.AddExpr((DAST.Expression)DAST.Expression.create_UnOp(
                              UnaryOp.create_Cardinality(),
                              convert(expr),
                              new UnaryOpFormat_NoFormat()
                            ));
                            break;
                        }

                        break;
                }
            }
            else
            {
                AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(452L, "<i>UnaryExpr ") + op + MutateCSharp.Schemata223.ReplaceStringConstant_1(453L, "</i>"));
            }
        }

        // A few helpers to reduce the size of expressions
        private static DAST.Expression Not(_IExpression expr, bool mergeInner = true)
        {
            return (DAST.Expression)DAST.Expression.create_UnOp(
              new UnaryOp_Not(),
              (DAST.Expression)expr,
              mergeInner ? new UnaryOpFormat_CombineFormat() : new UnaryOpFormat_NoFormat());
        }

        private static DAST.Expression BinaryOp(_IBinOp op, _IExpression left, _IExpression right, _IBinaryOpFormat format = null)
        {
            format ??= new BinaryOpFormat_NoFormat();

            return (DAST.Expression)DAST.Expression.create_BinOp(
              op, left, right, format
            );
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
            if (errorWr is BuilderSyntaxTree<ExprContainer> builder)
            {
                opString = null;
                preOpString = "";
                postOpString = "";
                callString = null;
                staticCallString = null;
                reverseArguments = MutateCSharp.Schemata223.ReplaceBooleanConstant_10(454L, false);
                truncateResult = MutateCSharp.Schemata223.ReplaceBooleanConstant_10(455L, false);
                convertE1_to_int = MutateCSharp.Schemata223.ReplaceBooleanConstant_10(456L, false);
                coerceE1 = MutateCSharp.Schemata223.ReplaceBooleanConstant_10(457L, false);

                opString = op switch
                {
                    BinaryExpr.ResolvedOpcode.Iff => MutateCSharp.Schemata223.ReplaceStringConstant_1(458L, "=="),
                    BinaryExpr.ResolvedOpcode.And => MutateCSharp.Schemata223.ReplaceStringConstant_1(459L, "&&"),
                    BinaryExpr.ResolvedOpcode.Or => MutateCSharp.Schemata223.ReplaceStringConstant_1(460L, "||"),
                    BinaryExpr.ResolvedOpcode.BitwiseAnd => MutateCSharp.Schemata223.ReplaceStringConstant_1(461L, "&"),
                    BinaryExpr.ResolvedOpcode.BitwiseOr => MutateCSharp.Schemata223.ReplaceStringConstant_1(462L, "|"),
                    BinaryExpr.ResolvedOpcode.BitwiseXor => MutateCSharp.Schemata223.ReplaceStringConstant_1(463L, "^"),
                    BinaryExpr.ResolvedOpcode.Lt => MutateCSharp.Schemata223.ReplaceStringConstant_1(464L, "<"),
                    BinaryExpr.ResolvedOpcode.LtChar => MutateCSharp.Schemata223.ReplaceStringConstant_1(465L, "<"),
                    BinaryExpr.ResolvedOpcode.Le => MutateCSharp.Schemata223.ReplaceStringConstant_1(466L, "<="),
                    BinaryExpr.ResolvedOpcode.LeChar => MutateCSharp.Schemata223.ReplaceStringConstant_1(467L, "<="),
                    BinaryExpr.ResolvedOpcode.Ge => MutateCSharp.Schemata223.ReplaceStringConstant_1(468L, ">="),
                    BinaryExpr.ResolvedOpcode.GeChar => MutateCSharp.Schemata223.ReplaceStringConstant_1(469L, ">="),
                    BinaryExpr.ResolvedOpcode.Gt => MutateCSharp.Schemata223.ReplaceStringConstant_1(470L, ">"),
                    BinaryExpr.ResolvedOpcode.GtChar => MutateCSharp.Schemata223.ReplaceStringConstant_1(471L, ">"),
                    BinaryExpr.ResolvedOpcode.LeftShift => MutateCSharp.Schemata223.ReplaceStringConstant_1(472L, "<<"),
                    BinaryExpr.ResolvedOpcode.RightShift => MutateCSharp.Schemata223.ReplaceStringConstant_1(473L, ">>"),
                    BinaryExpr.ResolvedOpcode.Add => MutateCSharp.Schemata223.ReplaceStringConstant_1(474L, "+"),
                    BinaryExpr.ResolvedOpcode.Sub => MutateCSharp.Schemata223.ReplaceStringConstant_1(475L, "-"),
                    BinaryExpr.ResolvedOpcode.Mul => MutateCSharp.Schemata223.ReplaceStringConstant_1(476L, "*"),
                    BinaryExpr.ResolvedOpcode.SetEq => MutateCSharp.Schemata223.ReplaceStringConstant_1(477L, "=="),
                    BinaryExpr.ResolvedOpcode.SetNeq => MutateCSharp.Schemata223.ReplaceStringConstant_1(478L, "!="),
                    BinaryExpr.ResolvedOpcode.MultiSetEq => MutateCSharp.Schemata223.ReplaceStringConstant_1(479L, "=="),
                    BinaryExpr.ResolvedOpcode.MultiSetNeq => MutateCSharp.Schemata223.ReplaceStringConstant_1(480L, "!="),
                    BinaryExpr.ResolvedOpcode.SeqEq => MutateCSharp.Schemata223.ReplaceStringConstant_1(481L, "=="),
                    BinaryExpr.ResolvedOpcode.SeqNeq => MutateCSharp.Schemata223.ReplaceStringConstant_1(482L, "!="),
                    BinaryExpr.ResolvedOpcode.MapEq => MutateCSharp.Schemata223.ReplaceStringConstant_1(483L, "=="),
                    BinaryExpr.ResolvedOpcode.MapNeq => MutateCSharp.Schemata223.ReplaceStringConstant_1(484L, "!="),
                    BinaryExpr.ResolvedOpcode.ProperSubset => MutateCSharp.Schemata223.ReplaceStringConstant_1(485L, "<"),
                    BinaryExpr.ResolvedOpcode.ProperMultiSubset => MutateCSharp.Schemata223.ReplaceStringConstant_1(486L, "<"),
                    BinaryExpr.ResolvedOpcode.Subset => MutateCSharp.Schemata223.ReplaceStringConstant_1(487L, "<="),
                    BinaryExpr.ResolvedOpcode.MultiSubset => MutateCSharp.Schemata223.ReplaceStringConstant_1(488L, "<="),
                    BinaryExpr.ResolvedOpcode.Disjoint => MutateCSharp.Schemata223.ReplaceStringConstant_1(489L, "!!"),
                    BinaryExpr.ResolvedOpcode.MultiSetDisjoint => MutateCSharp.Schemata223.ReplaceStringConstant_1(490L, "!!"),
                    BinaryExpr.ResolvedOpcode.InMultiSet => MutateCSharp.Schemata223.ReplaceStringConstant_1(491L, "in"),
                    BinaryExpr.ResolvedOpcode.InMap => MutateCSharp.Schemata223.ReplaceStringConstant_1(492L, "in"),
                    BinaryExpr.ResolvedOpcode.NotInMap => MutateCSharp.Schemata223.ReplaceStringConstant_1(493L, "notin"),
                    BinaryExpr.ResolvedOpcode.Union => MutateCSharp.Schemata223.ReplaceStringConstant_1(494L, "+"),
                    BinaryExpr.ResolvedOpcode.MultiSetUnion => MutateCSharp.Schemata223.ReplaceStringConstant_1(495L, "+"),
                    BinaryExpr.ResolvedOpcode.MapMerge => MutateCSharp.Schemata223.ReplaceStringConstant_1(496L, "+"),
                    BinaryExpr.ResolvedOpcode.Intersection => MutateCSharp.Schemata223.ReplaceStringConstant_1(497L, "*"),
                    BinaryExpr.ResolvedOpcode.MultiSetIntersection => MutateCSharp.Schemata223.ReplaceStringConstant_1(498L, "*"),
                    BinaryExpr.ResolvedOpcode.MultiSetDifference => MutateCSharp.Schemata223.ReplaceStringConstant_1(499L, "-"),
                    BinaryExpr.ResolvedOpcode.MapSubtraction => MutateCSharp.Schemata223.ReplaceStringConstant_1(500L, "-"),
                    BinaryExpr.ResolvedOpcode.ProperPrefix => MutateCSharp.Schemata223.ReplaceStringConstant_1(501L, "<="),
                    BinaryExpr.ResolvedOpcode.Prefix => MutateCSharp.Schemata223.ReplaceStringConstant_1(502L, "<"),
                    BinaryExpr.ResolvedOpcode.NeqCommon => MutateCSharp.Schemata223.ReplaceStringConstant_1(503L, "!="),
                    _ => null
                };

                object B(_IBinOp binOp)
                {
                    return builder.Builder.BinOp((DAST.BinOp)binOp);
                }

                var opStringClosure = opString;
                object C(System.Func<DAST.Expression, DAST.Expression, DAST.Expression> callback)
                {
                    return builder.Builder.BinOp(opStringClosure, callback);
                }

                var newBuilder = op switch
                {
                    BinaryExpr.ResolvedOpcode.EqCommon => B((BinOp)BinOp.create_Eq(
                      e0.Type.IsRefType,
                      !e0.Type.IsNonNullRefType
                    )),
                    BinaryExpr.ResolvedOpcode.SetEq => B((BinOp)BinOp.create_Eq(MutateCSharp.Schemata223.ReplaceBooleanConstant_10(504L, false), MutateCSharp.Schemata223.ReplaceBooleanConstant_10(505L, false))),
                    BinaryExpr.ResolvedOpcode.MapEq => B((BinOp)BinOp.create_Eq(MutateCSharp.Schemata223.ReplaceBooleanConstant_10(506L, false), MutateCSharp.Schemata223.ReplaceBooleanConstant_10(507L, false))),
                    BinaryExpr.ResolvedOpcode.SeqEq => B((BinOp)BinOp.create_Eq(MutateCSharp.Schemata223.ReplaceBooleanConstant_10(508L, false), MutateCSharp.Schemata223.ReplaceBooleanConstant_10(509L, false))),
                    BinaryExpr.ResolvedOpcode.MultiSetEq => B((BinOp)BinOp.create_Eq(MutateCSharp.Schemata223.ReplaceBooleanConstant_10(510L, false), MutateCSharp.Schemata223.ReplaceBooleanConstant_10(511L, false))),
                    BinaryExpr.ResolvedOpcode.NeqCommon => C((left, right) =>
                      Not(BinaryOp(
                        BinOp.create_Eq(
                          e0.Type.IsRefType,
                          !e0.Type.IsNonNullRefType
                        ), left, right))),
                    BinaryExpr.ResolvedOpcode.SetNeq => C((left, right) =>
                      Not(BinaryOp(BinOp.create_Eq(MutateCSharp.Schemata223.ReplaceBooleanConstant_10(512L, false), MutateCSharp.Schemata223.ReplaceBooleanConstant_10(513L, false)), left, right))),
                    BinaryExpr.ResolvedOpcode.SeqNeq => C((left, right) =>
                      Not(BinaryOp(BinOp.create_Eq(MutateCSharp.Schemata223.ReplaceBooleanConstant_10(514L, false), MutateCSharp.Schemata223.ReplaceBooleanConstant_10(515L, false)), left, right))),
                    BinaryExpr.ResolvedOpcode.MultiSetNeq => C((left, right) =>
                      Not(BinaryOp(BinOp.create_Eq(MutateCSharp.Schemata223.ReplaceBooleanConstant_10(516L, false), MutateCSharp.Schemata223.ReplaceBooleanConstant_10(517L, false)), left, right))),

                    BinaryExpr.ResolvedOpcode.Div =>
                      B(NeedsEuclideanDivision(resultType) ? BinOp.create_EuclidianDiv() : BinOp.create_Div()),
                    BinaryExpr.ResolvedOpcode.Mod =>
                      B(NeedsEuclideanDivision(resultType) ? BinOp.create_EuclidianMod() : BinOp.create_Mod()),
                    BinaryExpr.ResolvedOpcode.Imp =>
                      C((left, right) =>
                        BinaryOp(
                          DAST.BinOp.create_Or(),
                          Not(left, MutateCSharp.Schemata223.ReplaceBooleanConstant_10(518L, false)), right, new BinaryOpFormat_ImpliesFormat()
                        )),
                    BinaryExpr.ResolvedOpcode.Iff =>
                      C((left, right) =>
                        BinaryOp(
                          BinOp.create_Eq(MutateCSharp.Schemata223.ReplaceBooleanConstant_10(519L, false), MutateCSharp.Schemata223.ReplaceBooleanConstant_10(520L, false)),
                          left, right, new BinaryOpFormat_EquivalenceFormat()
                        )),
                    BinaryExpr.ResolvedOpcode.InSet => B(DAST.BinOp.create_In()), // TODO: Differentiate?
                    BinaryExpr.ResolvedOpcode.InSeq => B(DAST.BinOp.create_In()),
                    BinaryExpr.ResolvedOpcode.InMap => B(DAST.BinOp.create_In()),
                    BinaryExpr.ResolvedOpcode.InMultiSet => B(DAST.BinOp.create_In()),


                    BinaryExpr.ResolvedOpcode.Union =>
                      B(DAST.BinOp.create_SetMerge()),
                    BinaryExpr.ResolvedOpcode.SetDifference =>
                      B(DAST.BinOp.create_SetSubtraction()),
                    BinaryExpr.ResolvedOpcode.Intersection =>
                      B(DAST.BinOp.create_SetIntersection()),
                    BinaryExpr.ResolvedOpcode.Disjoint =>
                      B(DAST.BinOp.create_SetDisjoint()),
                    BinaryExpr.ResolvedOpcode.ProperSubset =>
                      B(DAST.BinOp.create_ProperSubset()),
                    BinaryExpr.ResolvedOpcode.Subset =>
                      B(DAST.BinOp.create_Subset()),
                    BinaryExpr.ResolvedOpcode.Superset =>
                      C((left, right) =>
                        BinaryOp(new BinOp_Subset(), right, left,
                          new BinaryOpFormat_ReverseFormat())),
                    BinaryExpr.ResolvedOpcode.ProperSuperset =>
                      C((left, right) =>
                        BinaryOp(new BinOp_ProperSubset(), right, left,
                          new BinaryOpFormat_ReverseFormat())),

                    BinaryExpr.ResolvedOpcode.MultiSetUnion =>
                      B(DAST.BinOp.create_MultisetMerge()),
                    BinaryExpr.ResolvedOpcode.MultiSetDifference =>
                      B(DAST.BinOp.create_MultisetSubtraction()),
                    BinaryExpr.ResolvedOpcode.MultiSetIntersection =>
                      B(DAST.BinOp.create_MultisetIntersection()),
                    BinaryExpr.ResolvedOpcode.MultiSetDisjoint =>
                      B(DAST.BinOp.create_MultisetDisjoint()),
                    BinaryExpr.ResolvedOpcode.ProperMultiSubset =>
                      B(DAST.BinOp.create_ProperSubmultiset()),
                    BinaryExpr.ResolvedOpcode.MultiSubset =>
                      B(DAST.BinOp.create_Submultiset()),
                    BinaryExpr.ResolvedOpcode.MultiSuperset =>
                      C((left, right) =>
                        BinaryOp(new BinOp_Submultiset(), right, left,
                          new BinaryOpFormat_ReverseFormat())),
                    BinaryExpr.ResolvedOpcode.ProperMultiSuperset =>
                      C((left, right) =>
                        BinaryOp(new BinOp_ProperSubmultiset(), right, left,
                          new BinaryOpFormat_ReverseFormat())),

                    BinaryExpr.ResolvedOpcode.MapMerge =>
                      B(DAST.BinOp.create_MapMerge()),
                    BinaryExpr.ResolvedOpcode.MapSubtraction =>
                      B(DAST.BinOp.create_MapSubtraction()),

                    BinaryExpr.ResolvedOpcode.ProperPrefix =>
                      B(DAST.BinOp.create_SeqProperPrefix()),
                    BinaryExpr.ResolvedOpcode.Prefix =>
                      B(DAST.BinOp.create_SeqPrefix()),

                    BinaryExpr.ResolvedOpcode.NotInMap =>
                      C((left, right) =>
                        Not(BinaryOp(new BinOp_In(), left, right))),
                    BinaryExpr.ResolvedOpcode.NotInSet =>
                      C((left, right) =>
                        Not(BinaryOp(new BinOp_In(), left, right))),
                    BinaryExpr.ResolvedOpcode.NotInSeq =>
                      C((left, right) =>
                        Not(BinaryOp(new BinOp_In(), left, right))),
                    BinaryExpr.ResolvedOpcode.NotInMultiSet =>
                      C((left, right) =>
                        Not(BinaryOp(new BinOp_In(), left, right))),
                    BinaryExpr.ResolvedOpcode.Concat => B(BinOp.create_Concat()),
                    BinaryExpr.ResolvedOpcode.And => B(BinOp.create_And()),
                    BinaryExpr.ResolvedOpcode.Or => B(BinOp.create_Or()),
                    BinaryExpr.ResolvedOpcode.Add => B(BinOp.create_Plus()),
                    BinaryExpr.ResolvedOpcode.Sub => B(BinOp.create_Minus()),
                    BinaryExpr.ResolvedOpcode.Mul => B(BinOp.create_Times()),
                    BinaryExpr.ResolvedOpcode.BitwiseAnd => B(BinOp.create_BitwiseAnd()),
                    BinaryExpr.ResolvedOpcode.BitwiseOr => B(BinOp.create_BitwiseOr()),
                    BinaryExpr.ResolvedOpcode.BitwiseXor => B(BinOp.create_BitwiseXor()),
                    BinaryExpr.ResolvedOpcode.LeftShift => B(BinOp.create_BitwiseShiftLeft()),
                    BinaryExpr.ResolvedOpcode.RightShift => B(BinOp.create_BitwiseShiftRight()),
                    BinaryExpr.ResolvedOpcode.Lt =>
                      B(BinOp.create_Lt()),
                    BinaryExpr.ResolvedOpcode.LtChar =>
                      B(BinOp.create_LtChar()),
                    BinaryExpr.ResolvedOpcode.Le =>
                      C((left, right) =>
                        Not(BinaryOp(new BinOp_Lt(), right, left,
                          new BinaryOpFormat_ReverseFormat()))),
                    BinaryExpr.ResolvedOpcode.LeChar =>
                      C((left, right) =>
                        Not(BinaryOp(new BinOp_LtChar(), right, left,
                          new BinaryOpFormat_ReverseFormat()))),
                    BinaryExpr.ResolvedOpcode.Gt =>
                      C((left, right) =>
                        BinaryOp(new BinOp_Lt(), right, left, new BinaryOpFormat_ReverseFormat())),
                    BinaryExpr.ResolvedOpcode.GtChar =>
                      C((left, right) =>
                        BinaryOp(new BinOp_LtChar(), right, left, new BinaryOpFormat_ReverseFormat())),
                    BinaryExpr.ResolvedOpcode.Ge =>
                      C((left, right) =>
                        Not(BinaryOp(new BinOp_Lt(), left, right))),
                    BinaryExpr.ResolvedOpcode.GeChar =>
                      C((left, right) =>
                        Not(BinaryOp(new BinOp_LtChar(), left, right))),

                    _ => B(DAST.BinOp.create_Passthrough(Sequence<Rune>.UnicodeFromString($"<b>Unsupported: <i>Operator {op}</i></b>"))),
                };

                opString = "";

                currentBuilder = newBuilder;
                // cleaned up by EmitExpr
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected override void EmitITE(Expression guard, Expression thn, Expression els, Type resultType, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (GetExprConverter(wr, wStmts, out var builder, out var convert))
            {
                builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_Ite(
                  convert(guard),
                  convert(thn),
                  convert(els)
                ));
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected override void EmitIsZero(string varName, ConcreteSyntaxTree wr)
        {
            AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(521L, "<i>EmitIsZero</i>"));
        }

        protected override void EmitConversionExpr(Expression fromExpr, Type fromType, Type toType, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (GetExprBuilder(wr, out var builder))
            {
                if (toType.Equals(fromType))
                {
                    EmitExpr(fromExpr, inLetExprBody, builder, wStmts);
                }
                else
                {
                    EmitExpr(fromExpr, inLetExprBody, new BuilderSyntaxTree<ExprContainer>(builder.Builder.Convert(
                      GenType(fromType),
                      GenType(toType)
                    ), this), wStmts);
                }
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected override void EmitConstructorCheck(string source, DatatypeCtor ctor, ConcreteSyntaxTree wr)
        {
            if (GetExprBuilder(wr, out var builder))
            {
                builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_TypeTest(
                  DAST.Expression.create_Ident(Sequence<Rune>.UnicodeFromString(source)),
                  PathFromTopLevel(ctor.EnclosingDatatype),
                  Sequence<Rune>.UnicodeFromString(ctor.GetCompileName(Options))
                ));
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected override void EmitTypeTest(string localName, Type fromType, Type toType, IToken tok, ConcreteSyntaxTree wr)
        {
            AddUnsupportedFeature(tok, Feature.TypeTests);
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
            if (GetExprConverter(wr, wStmts, out var builder, out var convert))
            {
                var elementsAST = elements.Select(convert).ToArray();

                if (ct is SetType set)
                {
                    builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_SetValue(
                      Sequence<DAST.Expression>.FromArray(elementsAST)
                    ));
                }
                else if (ct is MultiSetType multiSet)
                {
                    builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_MultisetValue(
                      Sequence<DAST.Expression>.FromArray(elementsAST)
                    ));
                }
                else if (ct is SeqType seq)
                {
                    builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_SeqValue(
                      Sequence<DAST.Expression>.FromArray(elementsAST),
                      GenType(ct.TypeArgs[MutateCSharp.Schemata223.ReplaceNumericConstant_11(522L, 0)])
                    ));
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
            else
            {
                throw new InvalidOperationException();//TODO
            }
        }

        protected override void EmitMapDisplay(MapType mt, IToken tok, List<ExpressionPair> elements, bool inLetExprBody,
          ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (GetExprConverter(wr, wStmts, out var builder, out var converter))
            {
                var elementsAST = new List<_System.Tuple2<DAST.Expression, DAST.Expression>>();
                foreach (var e in elements)
                {
                    elementsAST.Add((_System.Tuple2<DAST.Expression, DAST.Expression>)_System.Tuple2<DAST.Expression, DAST.Expression>.create(
                      converter(e.A),
                      converter(e.B)
                    ));
                }

                builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_MapValue(
                  Sequence<_System.Tuple2<DAST.Expression, DAST.Expression>>.FromArray(elementsAST.ToArray())
                ));
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        protected override void EmitSetBuilder_New(ConcreteSyntaxTree wr, SetComprehension e, string collectionName)
        {
            if (GetStatementBuilder(wr, out var builder))
            {
                var eType = e.Type.AsSetType;
                if (MutateCSharp.Schemata223.ReplaceBinExprOp_41(526L, eType, null))
                {// dafny0/GeneralNewtypeCollections
                    throw new UnsupportedFeatureException(e.tok, Feature.NonNativeNewtypes);
                }
                var elemType = GenType(eType.Arg);
                var setBuilderType = DAST.Type.create_SetBuilder(elemType);
                builder.Builder.AddStatement(
                  (DAST.Statement)DAST.Statement.create_DeclareVar(
                    Sequence<Rune>.UnicodeFromString(collectionName),
                    setBuilderType,
                    Option<_IExpression>.create_Some(
                      DAST.Expression.create_SetBuilder(elemType)
                    )
                  ));
            }
            else
            {
                AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(527L, "<i>EmitSetBuilder_New</i>"));
            }
        }

        protected override void EmitMapBuilder_New(ConcreteSyntaxTree wr, MapComprehension e, string collectionName)
        {
            if (GetStatementBuilder(wr, out var builder))
            {
                var eType = e.Type.AsMapType;
                var keyType = GenType(eType.Range);
                var valueType = GenType(eType.Domain);
                var mapType = DAST.Type.create_MapBuilder(keyType, valueType);
                builder.Builder.AddStatement(
                  (DAST.Statement)DAST.Statement.create_DeclareVar(
                    Sequence<Rune>.UnicodeFromString(collectionName),
                    mapType,
                    Option<_IExpression>.create_Some(
                      DAST.Expression.create_MapBuilder(keyType, valueType)
                      )
                    ));
            }
            else
            {
                AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(528L, "<i>EmitMapBuilder_New (non-statement)</i>"));
            }
            //throw new InvalidOperationException();
        }

        protected override void EmitSetBuilder_Add(CollectionType ct, string collName, Expression elmt, bool inLetExprBody,
            ConcreteSyntaxTree wr)
        {
            if (GetStatementBuilder(wr, out var builder))
            {
                var stmtBuilder = new CallStmtBuilder();
                stmtBuilder.SetName((DAST.CallName)DAST.CallName.create_SetBuilderAdd());
                stmtBuilder.SetTypeArgs(new List<DAST.Type> { });
                stmtBuilder.SetOuts(new List<ISequence<Rune>> { }); ;
                stmtBuilder.AddExpr((DAST.Expression)DAST.Expression.create_Ident(Sequence<Rune>.UnicodeFromString(collName)));
                stmtBuilder.AddExpr(ConvertExpression(elmt, builder));
                builder.Builder.AddBuildable(stmtBuilder);
            }
            else
            {
                AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(529L, "<i>EmitSetBuilder_Add</i>"));
            }
            //throw new InvalidOperationException();
        }

        // Normally wStmt is a BuilderSyntaxTree<StatementContainer> but it might not while the compiler is being developed
        private DAST.Expression ConvertExpression(Expression term, ConcreteSyntaxTree wStmt)
        {
            var buffer0 = new ExprBuffer(null);
            EmitExpr(term, MutateCSharp.Schemata223.ReplaceBooleanConstant_10(530L, false), new BuilderSyntaxTree<ExprContainer>(buffer0, this), wStmt);
            return buffer0.Finish();
        }

        private BuilderSyntaxTree<ExprContainer> CreateExprBuilder()
        {
            var exprBuffer = new ExprBuffer(null);
            var exprBuilder = new BuilderSyntaxTree<ExprContainer>(exprBuffer, this);
            return exprBuilder;
        }

        protected override ConcreteSyntaxTree EmitMapBuilder_Add(MapType mt, IToken tok, string collName, Expression term,
            bool inLetExprBody, ConcreteSyntaxTree wr)
        {
            if (GetStatementBuilder(wr, out var builder))
            {
                var stmtBuilder = new CallStmtBuilder();
                stmtBuilder.SetName((DAST.CallName)DAST.CallName.create_MapBuilderAdd());
                stmtBuilder.SetTypeArgs(new List<DAST.Type> { });
                stmtBuilder.SetOuts(new List<ISequence<Rune>> { }); ;
                stmtBuilder.AddExpr((DAST.Expression)DAST.Expression.create_Ident(Sequence<Rune>.UnicodeFromString(collName)));
                var keyBuilder = CreateExprBuilder();
                stmtBuilder.AddBuildable((ExprBuffer)keyBuilder.Builder);
                stmtBuilder.AddExpr(ConvertExpression(term, builder));
                builder.Builder.AddBuildable(stmtBuilder);
                return keyBuilder;
            }
            else
            {
                AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(531L, "<i>EMitMapBuilder_Add</i>"));
                var buffer1 = new ExprBuffer(null);
                return new BuilderSyntaxTree<ExprContainer>(buffer1, this);
            }

            return default;
        }

        protected override Action<ConcreteSyntaxTree> GetSubtypeCondition(string tmpVarName, Type boundVarType, IToken tok, ConcreteSyntaxTree wPreconditions)
        {
            Action<ConcreteSyntaxTree> typeTest;

            if (boundVarType.IsRefType)
            {
                DAST._IExpression baseExpr;
                if (MutateCSharp.Schemata223.ReplaceBinExprOp_8(532L, () => boundVarType.IsObject, () => boundVarType.IsObjectQ))
                {
                    baseExpr = DAST.Expression.create_Literal(DAST.Literal.create_BoolLiteral(MutateCSharp.Schemata223.ReplaceBooleanConstant_10(538L, true)));
                }
                else
                {
                    // typeTest = $"{tmpVarName} instanceof {TypeName(boundVarType, wPreconditions, tok)}";
                    AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(539L, "<i>TypeName</i>"));
                    return (ConcreteSyntaxTree w) => { };
                }

                if (boundVarType.IsNonNullRefType)
                {
                    typeTest = wr =>
                    {
                        if (GetExprBuilder(wr, out var builder))
                        {
                            builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_BinOp(
                              DAST.BinOp.create_Passthrough(Sequence<Rune>.UnicodeFromString(MutateCSharp.Schemata223.ReplaceStringConstant_1(540L, "&&"))),
                              DAST.Expression.create_BinOp(
                                DAST.BinOp.create_Passthrough(Sequence<Rune>.UnicodeFromString(MutateCSharp.Schemata223.ReplaceStringConstant_1(541L, "!="))),
                                DAST.Expression.create_Ident(Sequence<Rune>.UnicodeFromString(tmpVarName)),
                                DAST.Expression.create_Literal(DAST.Literal.create_Null(GenType(boundVarType))),
                                new BinaryOpFormat_NoFormat()),
                              baseExpr,
                              new BinaryOpFormat_NoFormat()
                            ));
                        }
                        else
                        {
                            throw new InvalidOperationException();
                        }
                    };
                }
                else
                {
                    typeTest = wr =>
                    {
                        if (GetExprBuilder(wr, out var builder))
                        {
                            builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_BinOp(
                              DAST.BinOp.create_Passthrough(Sequence<Rune>.UnicodeFromString(MutateCSharp.Schemata223.ReplaceStringConstant_1(542L, "||"))),
                              DAST.Expression.create_BinOp(
                                DAST.BinOp.create_Passthrough(Sequence<Rune>.UnicodeFromString(MutateCSharp.Schemata223.ReplaceStringConstant_1(543L, "=="))),
                                DAST.Expression.create_Ident(Sequence<Rune>.UnicodeFromString(tmpVarName)),
                                DAST.Expression.create_Literal(DAST.Literal.create_Null(GenType(boundVarType))),
                                new BinaryOpFormat_NoFormat()
                              ),
                              baseExpr,
                              new BinaryOpFormat_NoFormat()
                            ));
                        }
                        else
                        {
                            throw new InvalidOperationException();
                        }
                    };
                }
            }
            else
            {
                typeTest = wr => EmitExpr(Expression.CreateBoolLiteral(tok, MutateCSharp.Schemata223.ReplaceBooleanConstant_10(544L, true)), MutateCSharp.Schemata223.ReplaceBooleanConstant_10(545L, false), wr, null);
            }

            return typeTest;
        }

        protected override void GetCollectionBuilder_Build(CollectionType ct, IToken tok, string collName,
          ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmt)
        {
            if (GetExprBuilder(wr, out var builder))
            {
                var callExpr = new CallExprBuilder();
                if (ct.IsMapType)
                {
                    callExpr.SetName((DAST.CallName)DAST.CallName.create_MapBuilderBuild());
                }
                else
                {
                    callExpr.SetName((DAST.CallName)DAST.CallName.create_SetBuilderBuild());
                }

                callExpr.SetTypeArgs(new List<DAST.Type> { });
                callExpr.SetOuts(new List<ISequence<Rune>> { }); ;
                callExpr.AddExpr((DAST.Expression)DAST.Expression.create_Ident(Sequence<Rune>.UnicodeFromString(collName)));
                builder.Builder.AddBuildable(callExpr);
            }
            else
            {
                AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(546L, "<i>GetCollectionBuilder_Build</i>"));
            }
        }

        protected override (Type, Action<ConcreteSyntaxTree>) EmitIntegerRange(Type type, Action<ConcreteSyntaxTree> wLo, Action<ConcreteSyntaxTree> wHi)
        {
            Type result;
            if (MutateCSharp.Schemata223.ReplaceBinExprOp_17(547L, AsNativeType(type), null))
            {
                result = type;
            }
            else
            {
                result = new IntType();
            }

            return (result, (wr) =>
            {
                var loBuf = new ExprBuffer(null);
                wLo(new BuilderSyntaxTree<ExprContainer>(loBuf, this));
                var hiBuf = new ExprBuffer(null);
                wHi(new BuilderSyntaxTree<ExprContainer>(hiBuf, this));

                if (GetExprBuilder(wr, out var builder))
                {
                    builder.Builder.AddExpr((DAST.Expression)DAST.Expression.create_IntRange(
                      loBuf.Finish(),
                      hiBuf.Finish()
                    ));
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
            );
        }

        protected override void EmitNull(Type _, ConcreteSyntaxTree wr)
        {
            AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(548L, "<i>EmitNull</i>"));
        }

        protected override void EmitSingleValueGenerator(Expression e, bool inLetExprBody, string type,
          ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            AddUnsupportedFeature(e.Tok, Feature.ExactBoundedPool);
        }

        protected override void EmitHaltRecoveryStmt(Statement body, string haltMessageVarName, Statement recoveryBody, ConcreteSyntaxTree wr)
        {
            AddUnsupported(MutateCSharp.Schemata223.ReplaceStringConstant_1(549L, "<i>EmitHaltRecoveryStmt</i>"));
        }

    }
}
