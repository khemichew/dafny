// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
#nullable enable

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.BaseTypes;
using Microsoft.Boogie;
namespace MutateCSharp
{
    internal class Schemata259
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT259");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_10(long mutantId, int? argument1, int? argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, int argument1, int argument2)
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

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, int? argument1, int? argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_6(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, Microsoft.Dafny.UserDefinedType argument1, Microsoft.Dafny.UserDefinedType argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, Microsoft.Dafny.UserDefinedType argument1, Microsoft.Dafny.UserDefinedType argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, Microsoft.Boogie.Model.Element argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_28(long mutantId, Microsoft.Dafny.ModelFuncWrapper.ModelFuncTupleWrapper argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.ModelFuncWrapper.ModelFuncTupleWrapper argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePrefixUnaryExprOp_26(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return --argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return +argument1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return ~argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return ++argument1; }
            return --argument1;
        }

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, Microsoft.Dafny.BinaryExpr.Opcode argument1, Microsoft.Dafny.BinaryExpr.Opcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static int ReplaceBinExprOp_8(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_23(long mutantId, Microsoft.Dafny.PartialValue argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Boogie.Model.Element argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Type> argument1, object argument2)
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

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Boogie.Model.ElementKind argument1, Microsoft.Boogie.Model.ElementKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{

    /// <summary>
    /// A wrapper around Boogie's Model class that allows extracting
    /// types and values of Elements representing Dafny variables. The three core
    /// methods are: GetDafnyType, DatatypeConstructorName, and GetExpansion
    /// </summary>
    public class DafnyModel
    {
        public readonly List<string> LoopGuards;
        private readonly DafnyOptions options;
        public readonly Model Model;
        public readonly List<PartialState> States = new();
        public static readonly UserDefinedType UnknownType =
          new(new Token(), MutateCSharp.Schemata259.ReplaceStringConstant_0(1L, "?"), null);
        private readonly ModelFuncWrapper fSetSelect, fSeqLength, fSeqIndex, fBox,
          fDim, fIndexField, fMultiIndexField, fDtype, fCharToInt, fTag, fBv,
          fNull, fSetUnion, fSetIntersection, fSetDifference, fSetUnionOne,
          fSetEmpty, fSeqEmpty, fSeqBuild, fSeqAppend, fSeqDrop, fSeqTake,
          fSeqUpdate, fSeqCreate, fU2Real, fU2Bool, fU2Int,
          fMapDomain, fMapElements, fMapValues, fMapBuild, fMapEmpty, fIs, fIsBox, fUnbox, fLs, fLz;
        private readonly Dictionary<Model.Element, Model.FuncTuple> datatypeValues = new();
        private readonly List<Model.Func> bitvectorFunctions = new();

        // the model will begin assigning characters starting from this utf value
        private static readonly Regex UnderscoreRemovalRegex = new(MutateCSharp.Schemata259.ReplaceStringConstant_0(2L, "__"));

        // This set is used by GetDafnyType to prevent infinite recursion
        private HashSet<Model.Element> exploredElements = new();

        private readonly Dictionary<Model.Element, LiteralExpr> concretizedValues = new();

        public DafnyModel(Model model, DafnyOptions options)
        {
            Model = model;
            this.options = options;
            var tyArgMultiplier = options.TypeEncodingMethod switch
            {
                CoreOptions.TypeEncoding.Arguments => MutateCSharp.Schemata259.ReplaceNumericConstant_1(3L, 1),
                _ => MutateCSharp.Schemata259.ReplaceNumericConstant_1(7L, 0
        )
            };
            fSetSelect = ModelFuncWrapper.MergeFunctions(this, new List<string> { MutateCSharp.Schemata259.ReplaceStringConstant_0(11L, "MapType0Select"), MutateCSharp.Schemata259.ReplaceStringConstant_0(12L, "MapType1Select") }, MutateCSharp.Schemata259.ReplaceNumericConstant_1(13L, 2));
            fSeqLength = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(17L, "Seq#Length"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(18L, 1), MutateCSharp.Schemata259.ReplaceNumericConstant_1(22L, 0));
            fSeqBuild = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(26L, "Seq#Build"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(27L, 2), MutateCSharp.Schemata259.ReplaceNumericConstant_1(31L, 0));
            fSeqAppend = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(35L, "Seq#Append"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(36L, 2), MutateCSharp.Schemata259.ReplaceNumericConstant_1(40L, 0));
            fSeqDrop = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(44L, "Seq#Drop"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(45L, 2), MutateCSharp.Schemata259.ReplaceNumericConstant_1(49L, 0));
            fSeqTake = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(53L, "Seq#Take"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(54L, 2), MutateCSharp.Schemata259.ReplaceNumericConstant_1(58L, 0));
            fSeqIndex = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(62L, "Seq#Index"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(63L, 2), MutateCSharp.Schemata259.ReplaceNumericConstant_1(67L, 0));
            fSeqUpdate = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(71L, "Seq#Update"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(72L, 3), MutateCSharp.Schemata259.ReplaceNumericConstant_1(76L, 0));
            fSeqCreate = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(80L, "Seq#Create"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(81L, 4), MutateCSharp.Schemata259.ReplaceNumericConstant_1(85L, 0));
            fSeqEmpty = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(89L, "Seq#Empty"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(90L, 0), MutateCSharp.Schemata259.ReplaceNumericConstant_1(94L, 0));
            fSetEmpty = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(98L, "Set#Empty"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(99L, 0), MutateCSharp.Schemata259.ReplaceNumericConstant_1(103L, 0));
            fSetUnion = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(107L, "Set#Union"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(108L, 2), MutateCSharp.Schemata259.ReplaceNumericConstant_1(112L, 0));
            fSetUnionOne = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(116L, "Set#UnionOne"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(117L, 2), MutateCSharp.Schemata259.ReplaceNumericConstant_1(121L, 0));
            fSetIntersection = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(125L, "Set#Intersection"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(126L, 2), MutateCSharp.Schemata259.ReplaceNumericConstant_1(130L, 0));
            fSetDifference = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(134L, "Set#Difference"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(135L, 2), MutateCSharp.Schemata259.ReplaceNumericConstant_1(139L, 0));
            fMapDomain = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(143L, "Map#Domain"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(144L, 1), MutateCSharp.Schemata259.ReplaceNumericConstant_1(148L, 0));
            fMapElements = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(152L, "Map#Elements"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(153L, 1), MutateCSharp.Schemata259.ReplaceNumericConstant_1(157L, 0));
            fMapValues = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(161L, "Map#Values"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(162L, 1), MutateCSharp.Schemata259.ReplaceNumericConstant_1(166L, 0));
            fMapBuild = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(170L, "Map#Build"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(171L, 3), MutateCSharp.Schemata259.ReplaceNumericConstant_1(175L, 0));
            fMapEmpty = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(179L, "Map#Empty"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(180L, 0), MutateCSharp.Schemata259.ReplaceNumericConstant_1(184L, 0));
            fIs = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(188L, "$Is"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(189L, 2), tyArgMultiplier);
            fIsBox = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(193L, "$IsBox"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(194L, 2), MutateCSharp.Schemata259.ReplaceNumericConstant_1(198L, 0));
            fBox = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(202L, "$Box"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(203L, 1), tyArgMultiplier);
            fDim = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(207L, "FDim"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(208L, 1), MutateCSharp.Schemata259.ReplaceNumericConstant_1(212L, 0));
            fIndexField = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(216L, "IndexField"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(217L, 1), MutateCSharp.Schemata259.ReplaceNumericConstant_1(221L, 0));
            fMultiIndexField = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(225L, "MultiIndexField"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(226L, 2), MutateCSharp.Schemata259.ReplaceNumericConstant_1(230L, 0));
            fDtype = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(234L, "dtype"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(235L, 1), MutateCSharp.Schemata259.ReplaceNumericConstant_1(239L, 0));
            fNull = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(243L, "null"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(244L, 0), MutateCSharp.Schemata259.ReplaceNumericConstant_1(248L, 0));
            fCharToInt = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(252L, "char#ToInt"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(253L, 1), MutateCSharp.Schemata259.ReplaceNumericConstant_1(257L, 0));
            fU2Real = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(261L, "U_2_real"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(262L, 1), MutateCSharp.Schemata259.ReplaceNumericConstant_1(266L, 0));
            fU2Bool = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(270L, "U_2_bool"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(271L, 1), MutateCSharp.Schemata259.ReplaceNumericConstant_1(275L, 0));
            fU2Int = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(279L, "U_2_int"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(280L, 1), MutateCSharp.Schemata259.ReplaceNumericConstant_1(284L, 0));
            fTag = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(288L, "Tag"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(289L, 1), MutateCSharp.Schemata259.ReplaceNumericConstant_1(293L, 0));
            fBv = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(297L, "TBitvector"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(298L, 1), MutateCSharp.Schemata259.ReplaceNumericConstant_1(302L, 0));
            fUnbox = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(306L, "$Unbox"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(307L, 2), MutateCSharp.Schemata259.ReplaceNumericConstant_1(311L, 0));
            fLs = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(315L, "$LS"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(316L, 1), MutateCSharp.Schemata259.ReplaceNumericConstant_1(320L, 0));
            fLz = new ModelFuncWrapper(this, MutateCSharp.Schemata259.ReplaceStringConstant_0(324L, "$LZ"), MutateCSharp.Schemata259.ReplaceNumericConstant_1(325L, 0), MutateCSharp.Schemata259.ReplaceNumericConstant_1(329L, 0));
            InitDataTypes();
            RegisterReservedBitVectors();
            LoopGuards = new List<string>();
            foreach (var s in model.States)
            {
                var sn = new PartialState(this, s);
                States.Add(sn);
                if (sn.IsLoopEntryState)
                {
                    LoopGuards.Add(MutateCSharp.Schemata259.ReplaceStringConstant_0(333L, "counterexampleLoopGuard") + LoopGuards.Count);
                }
                sn.LoopGuards = LoopGuards.ToList();
            }
        }

        public void AssignConcretePrimitiveValues()
        {
            bool isTrueReserved = MutateCSharp.Schemata259.ReplaceBooleanConstant_2(334L, false);
            foreach (var app in fU2Bool.Apps)
            {
                isTrueReserved |= ((Model.Boolean)app.Result).Value;
            }
            foreach (var element in Model.Elements)
            {
                var type = GetFormattedDafnyType(element);
                if (MutateCSharp.Schemata259.ReplaceBinExprOp_4(336L, () => type is BoolType, () => MutateCSharp.Schemata259.ReplaceBinExprOp_3(335L, GetLiteralExpression(element, type), null)))
                {
                    if (isTrueReserved)
                    {
                        concretizedValues[element] = new LiteralExpr(Token.NoToken, MutateCSharp.Schemata259.ReplaceBooleanConstant_2(342L, false));
                    }
                    else
                    {
                        concretizedValues[element] = new LiteralExpr(Token.NoToken, MutateCSharp.Schemata259.ReplaceBooleanConstant_2(343L, true));
                    }
                    continue;
                }
                if (MutateCSharp.Schemata259.ReplaceBinExprOp_5(344L, GetLiteralExpression(element, type), null))
                {
                    continue;
                }
                ModelFuncWrapper? otherValuesFunction = null;
                switch (type)
                {
                    case BitvectorType bitvectorType:
                        {
                            var funcName = "U_2_bv" + bitvectorType.Width;
                            if (Model.HasFunc(funcName))
                            {
                                otherValuesFunction = new ModelFuncWrapper(Model.GetFunc(funcName), 0);
                            }
                            break;
                        }

                        break;
                    case CharType:
                        otherValuesFunction = fCharToInt;
                        break;
                        break;
                    case RealType:
                        otherValuesFunction = fU2Real;
                        break;
                        break;
                    case IntType:
                        otherValuesFunction = fU2Int;
                        break;
                        break;
                    default:
                        continue;
                        break;
                }
                var reservedValues = otherValuesFunction!.Apps
                  .Select(app => GetLiteralExpression(app.Result, type))
                  .OfType<Expression>()
                  .Select(literal => literal.ToString()).ToHashSet();
                reservedValues.UnionWith(concretizedValues.Values.Select(literal => literal.ToString()));
                int numericalValue = MutateCSharp.Schemata259.ReplaceNumericConstant_1(345L, -1);
                LiteralExpr? literal = null;
                bool literalIsReserved = MutateCSharp.Schemata259.ReplaceBooleanConstant_2(349L, true);
                while (literalIsReserved)
                {
                    MutateCSharp.Schemata259.ReplacePostfixUnaryExprOp_6(350L, ref numericalValue);
                    switch (type)
                    {
                        case BitvectorType:
                        case IntType:
                            {
                                literal = new LiteralExpr(Token.NoToken, BigInteger.Parse(numericalValue.ToString()));
                                break;
                            }

                            break;
                        case CharType:
                            literal = new CharLiteralExpr(Token.NoToken, PrettyPrintChar(numericalValue));
                            break;
                            break;
                        case RealType:
                            literal = new LiteralExpr(Token.NoToken, BigDec.FromString(numericalValue.ToString()));
                            break;
                            break;
                    }
                    if (!reservedValues.Contains(literal!.ToString()))
                    {
                        literalIsReserved = MutateCSharp.Schemata259.ReplaceBooleanConstant_2(351L, false);
                    }
                }
                concretizedValues[element] = literal!;
            }
        }

        /// <summary>
        /// Extract and parse the first Dafny model recorded in the model view file.
        /// </summary>
        public static DafnyModel ExtractModel(DafnyOptions options, string mv)
        {
            const string begin = "*** MODEL";
            const string end = "*** END_MODEL";
            int beginIndex = mv.IndexOf(begin, StringComparison.Ordinal);
            int endIndex = mv.IndexOf(end, StringComparison.Ordinal);
            var modelString = mv.Substring(beginIndex, MutateCSharp.Schemata259.ReplaceBinExprOp_8(361L, MutateCSharp.Schemata259.ReplaceBinExprOp_7(352L, endIndex, end.Length), beginIndex));
            var model = Model.ParseModels(new StringReader(modelString)).First();
            return new DafnyModel(model, options);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            AssignConcretePrimitiveValues();
            result.AppendLine(MutateCSharp.Schemata259.ReplaceStringConstant_0(370L, "WARNING: the following counterexample may be inconsistent or invalid. See dafny.org/dafny/DafnyRef/DafnyRef#sec-counterexamples"));
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_9(375L, LoopGuards.Count, MutateCSharp.Schemata259.ReplaceNumericConstant_1(371L, 0)))
            {
                result.AppendLine(MutateCSharp.Schemata259.ReplaceStringConstant_0(380L, "Temporary variables to describe counterexamples: "));
                foreach (var loopGuard in LoopGuards)
                {
                    result.AppendLine($"ghost var {loopGuard} : bool := false;");
                }
            }
            foreach (var state in States.Where(state => state.StateContainsPosition()))
            {
                result.AppendLine(state.FullStateName + MutateCSharp.Schemata259.ReplaceStringConstant_0(381L, ":"));
                result.AppendLine(state.AsAssumption().ToString());
            }
            return result.ToString();
        }

        /// <summary>
        /// Collect the array dimensions from the various array.Length functions,
        /// and collect all known datatype values
        /// </summary>
        private void InitDataTypes()
        {
            const string datatypeConstructorPrefix = "#";
            const string reservedVariablePrefix = "##";
            const string accessorString = ".";
            foreach (var fn in Model.Functions)
            {
                if (MutateCSharp.Schemata259.ReplaceBinExprOp_4(388L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_4(382L, () => fn.Name.StartsWith(datatypeConstructorPrefix), () => !fn.Name.StartsWith(reservedVariablePrefix)), () => fn.Name.Contains(accessorString)))
                {
                    foreach (var tpl in fn.Apps)
                    {
                        var elt = tpl.Result;
                        datatypeValues[elt] = tpl;
                    }
                }
            }
        }

        /// <summary>
        /// Return the character representation of a UTF code understood by Dafny
        /// This is either the character itself, if it is a parsable ASCII,
        /// Escaped character, for the cases specified in Dafny manual,
        /// Or escaped UTF code otherwise
        /// </summary>
        private static string PrettyPrintChar(int utfCode)
        {
            switch (utfCode)
            {
                case 0:
                    return "\\0";
                    break;
                case 9:
                    return "\\t";
                    break;
                case 10:
                    return "\\n";
                    break;
                case 13:
                    return "\\r";
                    break;
                case 34:
                    return "\\\"";
                    break;
                case 39:
                    return "\\\'";
                    break;
                case 92:
                    return "\\\\";
                    break;
                default:
                    if (utfCode is >= 32 and <= 126)
                    {
                        return $"{Convert.ToChar(utfCode)}";
                    }
                    return $"\\U{{{utfCode:X4}}}";
                    break;
            }

            return default;
        }

        /// <summary> Registered all bv values specified by the model </summary>
        private void RegisterReservedBitVectors()
        {
            var bvFuncName = new Regex(MutateCSharp.Schemata259.ReplaceStringConstant_0(394L, "^U_2_bv[0-9]+$"));
            foreach (var func in Model.Functions)
            {
                if (!bvFuncName.IsMatch(func.Name))
                {
                    continue;
                }
                bitvectorFunctions.Add(func);
            }
        }

        /// <summary>
        /// Return the name of a 0-arity type function that maps to the element if such
        /// a function exists and is unique. Return null otherwise.
        /// </summary>
        private static string? GetTrueTypeName(Model.Element element)
        {
            return element.Names.FirstOrDefault(funcTuple => MutateCSharp.Schemata259.ReplaceBinExprOp_10(399L, funcTuple.Func.Arity, MutateCSharp.Schemata259.ReplaceNumericConstant_1(395L, 0)))?.Func.Name;
        }

        /// <summary> Get the Dafny type of an element </summary>
        internal Type GetFormattedDafnyType(Model.Element element)
        {
            exploredElements = new HashSet<Model.Element>();
            return DafnyModelTypeUtils.GetInDafnyFormat(GetDafnyType(element));
        }

        internal void AddTypeConstraints(PartialValue partialValue)
        {
            foreach (var typeElement in GetIsResults(partialValue.Element))
            {
                var reconstructedType = DafnyModelTypeUtils.GetInDafnyFormat(ReconstructType(typeElement));
                if (MutateCSharp.Schemata259.ReplaceBinExprOp_11(404L, reconstructedType.ToString(), partialValue.Type.ToString()))
                {
                    var _ = new TypeTestConstraint(partialValue, reconstructedType);
                }
            }
        }

        /// <summary> Get the Dafny type of an element </summary>
        private Type GetDafnyType(Model.Element element)
        {
            if (exploredElements.Contains(element))
            {
                return UnknownType;
            }
            exploredElements.Add(element);
            switch (element.Kind)
            {
                case Model.ElementKind.Boolean:
                    return Type.Bool;
                    break;
                case Model.ElementKind.Integer:
                    return Type.Int;
                    break;
                case Model.ElementKind.Real:
                    return Type.Real;
                    break;
                case Model.ElementKind.BitVector:
                    return new BitvectorType(options, ((Model.BitVector)element).Size);
                    break;
                case Model.ElementKind.Uninterpreted:
                    return GetDafnyType((element as Model.Uninterpreted)!);
                    break;
                case Model.ElementKind.DataValue:
                    if (((Model.DatatypeValue)element).ConstructorName is "-" or "/")
                    {
                        return GetDafnyType(
                          ((Model.DatatypeValue)element).Arguments.First());
                    }
                    return UnknownType;
                    break;
                default:
                    return UnknownType;
                    break;
            }

            return default;
        }

        /// <summary>
        /// Return all elements x that satisfy ($Is element x)
        /// </summary>
        private List<Model.Element> GetIsResults(Model.Element element)
        {
            List<Model.Element> result = new();
            foreach (var tuple in fIs.AppsWithArg(MutateCSharp.Schemata259.ReplaceNumericConstant_1(405L, 0), element))
            {
                if (((Model.Boolean)tuple.Result).Value)
                {
                    result.Add(tuple.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(409L, 1)]);
                }
            }
            return result;
        }

        private Expression? GetLiteralExpression(Model.Element element, Type type)
        {
            var result = GetLiteralExpressionHelper(element, type);
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_4(414L, () => concretizedValues.ContainsKey(element), () => MutateCSharp.Schemata259.ReplaceBinExprOp_3(413L, result, null)))
            {
                result = concretizedValues[element];
            }
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_5(420L, result, null))
            {
                result.Type = type;
            }
            return result;
        }

        /// <summary>
        /// If the provided <param name="element"></param> represents a literal in Dafny, return that literal.
        /// Otherwise, return null.
        /// </summary>
        private Expression? GetLiteralExpressionHelper(Model.Element element, Type type)
        {
            if (Equals(element, fNull.GetConstant()))
            {
                return new LiteralExpr(Token.NoToken);
            }

            if (element is not Model.Real && element is Model.Number number)
            {
                return new LiteralExpr(Token.NoToken, BigInteger.Parse(number.Numeral));
            }

            if (element is Model.Real real)
            {
                return new LiteralExpr(Token.NoToken, BigDec.FromString(real.ToString()));
            }

            if (element is Model.Boolean boolean)
            {
                return new LiteralExpr(Token.NoToken, boolean.Value);
            }

            if (MutateCSharp.Schemata259.ReplaceBinExprOp_12(421L, element.Kind, Model.ElementKind.DataValue))
            {
                var datatypeValue = (Model.DatatypeValue)element;
                switch (datatypeValue.ConstructorName)
                {
                    case "-":
                        return new NegationExpression(Token.NoToken,
                          GetLiteralExpression(datatypeValue.Arguments.First(), type));
                        break;
                    case "/":
                        return new BinaryExpr(Token.NoToken, BinaryExpr.Opcode.Div,
                          GetLiteralExpression(datatypeValue.Arguments[0], type),
                          GetLiteralExpression(datatypeValue.Arguments[1], type));
                        break;
                }
            }

            var unboxedValue = fU2Int.OptEval(element);
            unboxedValue ??= fU2Bool.OptEval(element);
            unboxedValue ??= fU2Real.OptEval(element);
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_13(422L, unboxedValue, null))
            {
                return GetLiteralExpression(unboxedValue, type);
            }

            if (fCharToInt.OptEval(element) is Model.Integer literalCharValue)
            {
                if (int.TryParse(literalCharValue.Numeral,
                      out var utfCode) && utfCode is <= char.MaxValue and >= 0)
                {
                    return new CharLiteralExpr(Token.NoToken, PrettyPrintChar(utfCode));
                }
            }

            foreach (var bitvectorFunction in bitvectorFunctions)
            {
                if (bitvectorFunction.OptEval(element) is Model.Number literalBitVectorValur)
                {
                    return new LiteralExpr(Token.NoToken,
                      BigInteger.Parse(literalBitVectorValur.Numeral));
                }
            }

            return null;
        }

        public void GetExpansion(PartialState state, PartialValue value)
        {
            var literalExpr = GetLiteralExpression(value.Element, value.Type);
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_5(423L, literalExpr, null))
            {
                var _ = new LiteralExprConstraint(value, literalExpr);
                return;
            }

            if (value.Nullable)
            {
                var _ = new NotNullConstraint(value);
            }

            if (MutateCSharp.Schemata259.ReplaceBinExprOp_14(442L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_14(436L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_14(430L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_14(424L, () => value.Type is BitvectorType, () => value.Type is CharType), () => value.Type is RealType), () => value.Type is BoolType), () => value.Type is IntType))
            {
                foreach (var element in Model.Elements.Where(element => !Equals(element, value.Element)))
                {
                    var elementType = GetFormattedDafnyType(element);
                    if (MutateCSharp.Schemata259.ReplaceBinExprOp_15(448L, elementType.ToString(), value.Type.ToString()))
                    {
                        var partialValue = PartialValue.Get(element, state);
                        var _ = new NeqConstraint(value, partialValue);
                    }
                }
                return;
            }

            var valueIsDatatype = datatypeValues.TryGetValue(value.Element, out var fnTuple);

            var layerValue = fLz.GetConstant();
            while (MutateCSharp.Schemata259.ReplaceBinExprOp_4(465L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_4(455L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_13(449L, layerValue, null), () => MutateCSharp.Schemata259.ReplaceBinExprOp_16(454L, fLs.AppWithArg(MutateCSharp.Schemata259.ReplaceNumericConstant_1(450L, 0), layerValue), null)), () => !Equals(fLs.AppWithArg(MutateCSharp.Schemata259.ReplaceNumericConstant_1(461L, 0), layerValue)!.Result, fLz.GetConstant())))
            {
                layerValue = fLs.AppWithArg(MutateCSharp.Schemata259.ReplaceNumericConstant_1(471L, 0), layerValue)!.Result;
            }
            var functionApplications = GetFunctionConstants(value.Element, layerValue);
            foreach (var functionApplication in functionApplications)
            {
                var result = PartialValue.Get(functionApplication.Result, state);
                var args = functionApplication.Args.Select(arg => PartialValue.Get(arg, state)).ToList();
                args = Equals(functionApplication.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(475L, 0)], layerValue) ? args.Skip(MutateCSharp.Schemata259.ReplaceNumericConstant_1(479L, 2)).ToList() : args.Skip(MutateCSharp.Schemata259.ReplaceNumericConstant_1(483L, 1)).ToList();
                var _ = new FunctionCallConstraint(result, value, args, functionApplication.Func.Name.Split(MutateCSharp.Schemata259.ReplaceStringConstant_0(487L, ".")).Last(), !valueIsDatatype);
            }

            if (valueIsDatatype)
            {
                var __ = new DatatypeConstructorCheckConstraint(value, fnTuple!.Func.Name.Split(MutateCSharp.Schemata259.ReplaceStringConstant_0(488L, ".")).Last());
                // Elt is a datatype value
                var destructors = GetDestructorFunctions(value.Element).OrderBy(f => f.Name).ToList();
                if (MutateCSharp.Schemata259.ReplaceBinExprOp_9(489L, destructors.Count, fnTuple.Args.Length))
                {
                    // Try to filter out predicate functions
                    // (that follow a format very similar to that of destructor names)
                    destructors = destructors.Where(destructor =>
                        fnTuple.Args.Any(arg => Equals(destructor.OptEval(value.Element), arg)))
                      .ToList();
                }

                var elements = new List<PartialValue>();
                if (MutateCSharp.Schemata259.ReplaceBinExprOp_17(494L, destructors.Count, fnTuple.Args.Length))
                {
                    // we know all destructor names
                    foreach (var func in destructors)
                    {
                        if (func.OptEval(value.Element) is not { } modelElement)
                        {
                            continue;
                        }
                        var element = PartialValue.Get(UnboxNotNull(modelElement), state);
                        elements.Add(element);
                        var elementName = UnderscoreRemovalRegex.Replace(func.Name.Split(MutateCSharp.Schemata259.ReplaceStringConstant_0(499L, ".")).Last(), MutateCSharp.Schemata259.ReplaceStringConstant_0(500L, "_"));
                        var _ = new MemberSelectExprDatatypeConstraint(element, value, elementName);
                    }
                }
                else
                {
                    // we don't know destructor names, so we use indices instead
                    for (int i = MutateCSharp.Schemata259.ReplaceNumericConstant_1(501L, 0); MutateCSharp.Schemata259.ReplaceBinExprOp_18(505L, i, fnTuple.Args.Length); MutateCSharp.Schemata259.ReplacePostfixUnaryExprOp_6(510L, ref i))
                    {
                        var element = PartialValue.Get(UnboxNotNull(fnTuple.Args[i]), state);
                        elements.Add(element);
                    }
                }
                var ___ = new DatatypeValueConstraint(value, value.Type.ToString(), fnTuple.Func.Name.Split(MutateCSharp.Schemata259.ReplaceStringConstant_0(511L, ".")).Last(), elements);
                return;
            }

            switch (value.Type)
            {
                case SeqType:
                    {
                        if (fSeqEmpty.AppWithResult(value.Element) != null)
                        {
                            var _ = new LiteralExprConstraint(value, new SeqDisplayExpr(Token.NoToken, new List<Expression>()));
                            return;
                        }
                        var lenghtTuple = fSeqLength.AppWithArg(0, value.Element);
                        BigNum seqLength = BigNum.MINUS_ONE;
                        if (lenghtTuple != null)
                        {
                            var lengthValue = PartialValue.Get(lenghtTuple.Result, state);
                            var lengthValueLiteral = GetLiteralExpression(lengthValue.Element, lengthValue.Type);
                            if (lengthValueLiteral != null)
                            {
                                BigNum.TryParse(lengthValueLiteral.ToString(), out seqLength);
                            }
                            var _ = new CardinalityConstraint(lengthValue, value);
                        }

                        // Sequences can be constructed with the build operator:
                        List<PartialValue> elements = new();

                        Model.Element substring = value.Element;
                        while (fSeqBuild.AppWithResult(substring) != null)
                        {
                            elements.Insert(0, PartialValue.Get(UnboxNotNull(fSeqBuild.AppWithResult(substring)!.Args[1]), state));
                            substring = fSeqBuild.AppWithResult(substring)!.Args[0];
                        }

                        for (int i = 0; i < elements.Count; i++)
                        {
                            var index = new LiteralExpr(Token.NoToken, i)
                            {
                                Type = Type.Int
                            };
                            var _ = new SeqSelectExprWithLiteralConstraint(elements[i], value, index);
                        }

                        if (elements.Count == 0)
                        {
                            foreach (var funcTuple in fSeqIndex.AppsWithArg(0, value.Element))
                            {
                                var elementId = PartialValue.Get(funcTuple.Args[1], state);
                                var elementIdTry = GetLiteralExpression(funcTuple.Args[1], Type.Int);
                                if (elementIdTry != null && elementIdTry.ToString().Contains("-"))
                                {
                                    continue;
                                }
                                if (elementIdTry != null && BigNum.TryParse(elementIdTry.ToString(), out var elementIdTryBigNum))
                                {
                                    if (!seqLength.Equals(BigNum.MINUS_ONE) && !(elementIdTryBigNum - seqLength).IsNegative)
                                    {
                                        continue; // element out of bounds for sequence
                                    }
                                }
                                var element = PartialValue.Get(UnboxNotNull(funcTuple.Result), state);
                                var _ = new SeqSelectExprConstraint(element, value, elementId);
                            }
                        }
                        else
                        {
                            var _ = new SeqDisplayConstraint(value, elements);
                        }

                        return;
                    }

                    break;
                case SetType:
                    {
                        if (fMapDomain.AppsWithResult(value.Element).Any())
                        {
                            foreach (var map in fMapDomain.AppsWithResult(value.Element))
                            {
                                var mapValue = PartialValue.Get(map.Args[0], state);
                                var _ = new MemberSelectExprDatatypeConstraint(value, mapValue, "Keys");
                            }
                            return;
                        }
                        if (fMapValues.AppsWithResult(value.Element).Any())
                        {
                            foreach (var map in fMapValues.AppsWithResult(value.Element))
                            {
                                var mapValue = PartialValue.Get(map.Args[0], state);
                                var _ = new MemberSelectExprDatatypeConstraint(value, mapValue, "Values");
                            }
                        }
                        if (fSetEmpty.AppWithResult(value.Element) != null)
                        {
                            var _ = new LiteralExprConstraint(value, new SetDisplayExpr(Token.NoToken, true, new List<Expression>()));
                            return;
                        }

                        foreach (var tpl in fSetSelect.AppsWithArg(0, value.Element))
                        {
                            var setElement = PartialValue.Get(UnboxNotNull(tpl.Args[1]), state);
                            var containment = tpl.Result;
                            if (containment is Model.Boolean boolean)
                            {
                                var _ = new ContainmentConstraint(setElement, value, boolean.Value);
                            }
                        }

                        return;
                    }

                    break;
                case MapType:
                    {
                        var mapKeysAdded = new HashSet<Model.Element>(); // prevents mapping a key to multiple values
                        var mapsElementsVisited = new HashSet<Model.Element>(); // prevents infinite recursion
                        var current = value.Element;
                        var mapBuilds = fMapBuild.AppsWithResult(current).ToList();
                        var result = new List<PartialValue>();
                        while (mapBuilds.Count != 0)
                        {
                            foreach (var mapBuild in mapBuilds.Where(m => Equals(m.Args[0], current)))
                            {
                                result.AddRange(AddMappingHelper(
                                  state,
                                  value,
                                  Unbox(mapBuild.Args[1]),
                                  Unbox(mapBuild.Args[2]),
                                  mapKeysAdded));
                            }

                            mapsElementsVisited.Add(current);
                            var nextMapBuild = mapBuilds.FirstOrDefault(m => !mapsElementsVisited.Contains(m.Args[0]));
                            if (nextMapBuild == null)
                            {
                                return;
                            }

                            current = nextMapBuild.Args[0];
                            mapBuilds = fMapBuild.AppsWithResult(nextMapBuild.Args[0])
                              .Where(m => !mapsElementsVisited.Contains(m.Args[0])).ToList();
                            result.AddRange(AddMappingHelper(
                              state,
                              value,
                              Unbox(nextMapBuild.Args[1]),
                              Unbox(nextMapBuild.Args[2]),
                              mapKeysAdded));
                        }

                        var mapDomain = fMapDomain.OptEval(current);
                        var mapElements = fMapElements.OptEval(current);
                        if (mapDomain != null && mapElements != null)
                        {
                            foreach (var app in fSetSelect.AppsWithArg(0, mapDomain))
                            {
                                var valueElement = fSetSelect.OptEval(mapElements, app.Args[1]);
                                if (valueElement != null)
                                {
                                    valueElement = Unbox(valueElement);
                                }
                                result.AddRange(AddMappingHelper(
                                  state,
                                  value,
                                  Unbox(app.Args[1]),
                                  valueElement,
                                  mapKeysAdded, !((Model.Boolean)app.Result).Value));
                            }
                        }


                        if (!result.Any() && fMapEmpty.AppWithResult(value.Element) != null)
                        {
                            var _ = new LiteralExprConstraint(value, new MapDisplayExpr(Token.NoToken, true, new List<ExpressionPair>()));
                        }

                        return;

                    }

                    break;
                default:
                    {

                        var heap = state.State.TryGet("$Heap");
                        // Elt is an array or an object:
                        if (heap == null)
                        {
                            return;
                        }

                        var constantFields = GetDestructorFunctions(value.Element).OrderBy(f => f.Name).ToList();
                        var fields = fSetSelect.AppsWithArgs(0, heap, 1, value.Element).ToList();

                        foreach (var fieldFunc in constantFields)
                        {
                            if (fieldFunc.OptEval(value.Element) is not { } modelElement)
                            {
                                continue;
                            }
                            var field = PartialValue.Get(UnboxNotNull(modelElement), state);
                            var fieldName = UnderscoreRemovalRegex.Replace(fieldFunc.Name.Split(".").Last(), "_");
                            if (fieldName.Contains("#"))
                            {
                                continue;
                            }
                            var _ = new MemberSelectExprClassConstraint(field, value, fieldName);
                        }

                        if (!fields.Any())
                        {
                            return;
                        }

                        foreach (var tpl in fSetSelect.AppsWithArg(0, fields.ToList()[0].Result))
                        {
                            foreach (var fieldName in GetFieldNames(tpl.Args[1]))
                            {
                                if (fieldName != "alloc")
                                {
                                    var field = PartialValue.Get(UnboxNotNull(tpl.Result), state);
                                    // make sure the field in quetion is not an array index
                                    if (fieldName.Contains("#"))
                                    {
                                        continue;
                                    }
                                    if (fieldName.StartsWith('[') && fieldName.EndsWith(']'))
                                    {
                                        var indexStrings = fieldName.TrimStart('[').TrimEnd(']').Split(",");
                                        var indices = new List<LiteralExpr>();
                                        foreach (var indexString in indexStrings)
                                        {
                                            if (BigInteger.TryParse(indexString, out var index))
                                            {
                                                var indexLiteral = new LiteralExpr(Token.NoToken, index);
                                                indexLiteral.Type = Type.Int;
                                                indices.Add(indexLiteral);
                                            }
                                        }
                                        if (indices.Count != indexStrings.Length)
                                        {
                                            continue;
                                        }
                                        var _ = new ArraySelectionConstraint(field, value, indices);
                                    }
                                    else
                                    {
                                        var _ = new MemberSelectExprClassConstraint(field, value, fieldName);
                                    }
                                }
                            }
                        }
                        return;
                    }

                    break;
            }
        }

        /// <summary>
        /// Get the Dafny type of the value indicated by <param name="element"></param>
        /// This is in contrast to ReconstructType, which returns the type indicated by the element itself.
        /// This method tries to extract the base type (so sequence of characters instead of string)
        /// </summary>
        private Type GetDafnyType(Model.Uninterpreted element)
        {
            var finalResult = UnknownType;
            foreach (var typeElement in GetIsResults(element))
            {
                var reconstructedType = ReconstructType(typeElement);
                if (reconstructedType is not UserDefinedType userDefinedType)
                {
                    return reconstructedType;
                }
                if (MutateCSharp.Schemata259.ReplaceBinExprOp_14(514L, () => finalResult.Name.EndsWith(MutateCSharp.Schemata259.ReplaceStringConstant_0(512L, "?")), () => MutateCSharp.Schemata259.ReplaceBinExprOp_19(513L, finalResult, UnknownType)))
                {
                    finalResult = userDefinedType;
                }
            }
            var seqOperation = fSeqAppend.AppWithResult(element);
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_4(525L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_16(520L, seqOperation, null), () => !exploredElements.Contains(seqOperation.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(521L, 0)]))) { return GetDafnyType(seqOperation.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(531L, 0)]); }
            seqOperation = fSeqDrop.AppWithResult(element);
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_4(540L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_16(535L, seqOperation, null), () => !exploredElements.Contains(seqOperation.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(536L, 0)]))) { return GetDafnyType(seqOperation.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(546L, 0)]); }
            seqOperation = fSeqTake.AppWithResult(element);
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_4(555L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_16(550L, seqOperation, null), () => !exploredElements.Contains(seqOperation.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(551L, 0)]))) { return GetDafnyType(seqOperation.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(561L, 0)]); }
            seqOperation = fSeqUpdate.AppWithResult(element);
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_4(570L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_16(565L, seqOperation, null), () => !exploredElements.Contains(seqOperation.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(566L, 0)]))) { return GetDafnyType(seqOperation.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(576L, 0)]); }
            seqOperation = fSeqBuild.AppWithResult(element);
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_4(585L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_16(580L, seqOperation, null), () => !exploredElements.Contains(UnboxNotNull(seqOperation.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(581L, 1)])))) { return new SeqType(GetDafnyType(UnboxNotNull(seqOperation.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(591L, 1)]))); }
            seqOperation = fSeqCreate.AppWithResult(element);
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_4(596L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_16(595L, seqOperation, null), () => !exploredElements.Contains(UnboxNotNull(seqOperation.Args.First())))) { return new SeqType(ReconstructType(seqOperation.Args.First())); }
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_16(602L, fSeqEmpty.AppWithResult(element), null)) { return new SeqType(null); }
            var setOperation = fSetUnion.AppWithResult(element);
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_4(608L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_16(603L, setOperation, null), () => !exploredElements.Contains(setOperation.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(604L, 0)]))) { return GetDafnyType(setOperation.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(614L, 0)]); }
            setOperation = fSetIntersection.AppWithResult(element);
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_4(623L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_16(618L, setOperation, null), () => !exploredElements.Contains(setOperation.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(619L, 0)]))) { return GetDafnyType(setOperation.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(629L, 0)]); }
            setOperation = fSetDifference.AppWithResult(element);
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_4(638L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_16(633L, setOperation, null), () => !exploredElements.Contains(setOperation.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(634L, 0)]))) { return GetDafnyType(setOperation.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(644L, 0)]); }
            setOperation = fSetUnionOne.AppWithResult(element);
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_4(653L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_16(648L, setOperation, null), () => !exploredElements.Contains(setOperation.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(649L, 1)]))) { return new SetType(MutateCSharp.Schemata259.ReplaceBooleanConstant_2(659L, true), GetDafnyType(UnboxNotNull(setOperation.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(660L, 1)]))); }
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_16(664L, fSetEmpty.AppWithResult(element), null)) { return new SetType(MutateCSharp.Schemata259.ReplaceBooleanConstant_2(665L, true), null); }
            var mapOperation = fMapBuild.AppWithResult(element);
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_16(666L, mapOperation, null))
            {
                return new MapType(MutateCSharp.Schemata259.ReplaceBooleanConstant_2(667L, true), GetDafnyType(UnboxNotNull(mapOperation.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(668L, 1)])), GetDafnyType(UnboxNotNull(mapOperation.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(672L, 2)])));
            }
            var unboxedTypes = fIsBox.AppsWithArg(MutateCSharp.Schemata259.ReplaceNumericConstant_1(676L, 0), element)
              .Where(tuple => ((Model.Boolean)tuple.Result).Value)
              .Select(tuple => tuple.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(680L, 1)]).ToList();
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_17(688L, unboxedTypes.Count, MutateCSharp.Schemata259.ReplaceNumericConstant_1(684L, 1)))
            {
                return ReconstructType(unboxedTypes[MutateCSharp.Schemata259.ReplaceNumericConstant_1(693L, 0)]);
            }
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_13(697L, fCharToInt.OptEval(element), null))
            {
                return Type.Char;
            }
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_20(698L, finalResult, UnknownType))
            {
                return finalResult;
            }
            var dtypeElement = fDtype.OptEval(element);
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_13(699L, dtypeElement, null))
            {
                ReconstructType(dtypeElement);
            }
            if (datatypeValues.TryGetValue(element, out var fnTuple))
            {
                var fullyQualifiedPath = fnTuple.Func.Name[1..].Split(MutateCSharp.Schemata259.ReplaceStringConstant_0(700L, "."));
                return new UserDefinedType(Token.NoToken, string.Join(MutateCSharp.Schemata259.ReplaceStringConstant_0(701L, "."), fullyQualifiedPath.Take(MutateCSharp.Schemata259.ReplaceBinExprOp_8(706L, fullyQualifiedPath.Count(), MutateCSharp.Schemata259.ReplaceNumericConstant_1(702L, 1)))), null);
            }
            return finalResult;
        }

        /// <summary>
        /// Reconstruct Dafny type from an element that represents a type in Z3
        /// </summary>
        private Type ReconstructType(Model.Element? typeElement)
        {
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_21(715L, typeElement, null))
            {
                return UnknownType;
            }
            var fullName = GetTrueTypeName(typeElement);
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_4(717L, () => fullName is { Length: > 7 }, () => fullName[..7].Equals(MutateCSharp.Schemata259.ReplaceStringConstant_0(716L, "Tclass."))))
            {
                return new UserDefinedType(new Token(), fullName[7..], null);
            }
            switch (fullName)
            {
                case "TInt":
                    return Type.Int;
                    break;
                case "TBool":
                    return Type.Bool;
                    break;
                case "TReal":
                    return Type.Real;
                    break;
                case "TChar":
                    return Type.Char;
                    break;
            }
            if (fBv.AppWithResult(typeElement) is { } tupleWrapper)
            {
                return new BitvectorType(options, ((Model.Integer)tupleWrapper.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(723L, 0)]).AsInt());
            }

            Type fallBackType = UnknownType; // to be returned in the event all else fails
            if (fullName != null)
            { // this means this is a type variable
                fallBackType = new UserDefinedType(new Token(), fullName, null);
            }
            var tagElement = fTag.OptEval(typeElement);
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_21(727L, tagElement, null))
            {
                return fallBackType;
            }
            var tagName = GetTrueTypeName(tagElement);
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_14(769L, () => tagName == null, () => (MutateCSharp.Schemata259.ReplaceBinExprOp_4(763L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_4(755L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_4(747L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_4(739L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_18(732L, tagName.Length, MutateCSharp.Schemata259.ReplaceNumericConstant_1(728L, 10)), () => MutateCSharp.Schemata259.ReplaceBinExprOp_11(738L, tagName, MutateCSharp.Schemata259.ReplaceStringConstant_0(737L, "TagSeq"))), () => MutateCSharp.Schemata259.ReplaceBinExprOp_11(746L, tagName, MutateCSharp.Schemata259.ReplaceStringConstant_0(745L, "TagSet"))), () => MutateCSharp.Schemata259.ReplaceBinExprOp_11(754L, tagName, MutateCSharp.Schemata259.ReplaceStringConstant_0(753L, "TagBitVector"))), () => MutateCSharp.Schemata259.ReplaceBinExprOp_11(762L, tagName, MutateCSharp.Schemata259.ReplaceStringConstant_0(761L, "TagMap"))))))
            {
                return fallBackType;
            }
            var typeArgs = Model.GetFunc(MutateCSharp.Schemata259.ReplaceStringConstant_0(775L, "T") + tagName.Substring(MutateCSharp.Schemata259.ReplaceNumericConstant_1(776L, 3)))?.
              AppWithResult(typeElement)?.
              Args.Select(ReconstructType).ToList();
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_22(780L, typeArgs, null))
            {
                return new UserDefinedType(new Token(), tagName.Substring(MutateCSharp.Schemata259.ReplaceNumericConstant_1(781L, 9)), null);
            }

            switch (tagName)
            {
                case "TagSeq":
                    return new SeqType(typeArgs.First());
                    break;
                case "TagMap":
                    return new MapType(true, typeArgs[0], typeArgs[1]);
                    break;
                case "TagSet":
                    return new SetType(true, typeArgs.First());
                    break;
                default:
                    tagName = tagName.Substring(9);
                    if (tagName.StartsWith("_System.___hFunc") ||
                        tagName.StartsWith("_System.___hTotalFunc") ||
                        tagName.StartsWith("_System.___hPartialFunc"))
                    {
                        return new ArrowType(new Token(), typeArgs.SkipLast(1).ToList(),
                          typeArgs.Last());
                    }
                    return new UserDefinedType(new Token(), tagName, typeArgs);
                    break;
            }

            return default;
        }

        /// <summary>
        /// Perform operations necessary to add a mapping to a map variable,
        /// return newly created PartialValue objects
        /// </summary>
        private IEnumerable<PartialValue> AddMappingHelper(PartialState state, PartialValue? mapVariable, Model.Element? keyElement, Model.Element? valueElement, HashSet<Model.Element> keySet, bool keyNotPresent = false)
        {
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_14(793L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_14(787L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_23(785L, mapVariable, null), () => MutateCSharp.Schemata259.ReplaceBinExprOp_21(786L, keyElement, null)), () => keySet.Contains(keyElement)))
            {
                yield break;
            }
            var key = PartialValue.Get(keyElement, state);
            var opcode = keyNotPresent ? BinaryExpr.Opcode.NotIn : BinaryExpr.Opcode.In;
            var _ = new ContainmentConstraint(key, mapVariable, MutateCSharp.Schemata259.ReplaceBinExprOp_24(799L, opcode, BinaryExpr.Opcode.In));
            // Note that it is possible for valueElement to not be null while the element is not present in the set!
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_4(801L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_13(800L, valueElement, null), () => !keyNotPresent))
            {
                var value = PartialValue.Get(valueElement, state);
                var __ = new MapSelectExprConstraint(value, mapVariable, key);
                yield return value;
            }
            keySet.Add(keyElement);
            yield return key;
        }

        /// <summary>
        /// Return all functions application relevant to an element. These can be:
        /// 1) destructor values of a datatype
        /// 2) constant fields of an object
        /// 3) function applications
        /// </summary>
        private List<Model.Func> GetDestructorFunctions(Model.Element element)
        {
            var possibleTypeIdentifiers = GetIsResults(element);
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_13(807L, fDtype.OptEval(element), null))
            {
                possibleTypeIdentifiers.Add(fDtype.OptEval(element)!);
            }
            var possiblyNullableTypes = possibleTypeIdentifiers
              .Select(ReconstructType).OfType<UserDefinedType>()
              .Where(type => MutateCSharp.Schemata259.ReplaceBinExprOp_11(808L, type.Name, UnknownType.Name));
            var types = possiblyNullableTypes.Select(DafnyModelTypeUtils.GetNonNullable).OfType<UserDefinedType>().ToList();
            List<Model.Func> result = new();
            var builtInDatatypeDestructor = new Regex(MutateCSharp.Schemata259.ReplaceStringConstant_0(809L, "^.*[^_](__)*_q$"));
            var canCallFunctions = new HashSet<string>();
            foreach (var app in element.References)
            {
                if (MutateCSharp.Schemata259.ReplaceBinExprOp_14(845L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_14(837L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_14(830L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_14(823L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_25(814L, app.Func.Arity, MutateCSharp.Schemata259.ReplaceNumericConstant_1(810L, 1)), () => !Equals(app.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(819L, 0)], element)), () => !types.Any(type => app.Func.Name.StartsWith(type.Name + MutateCSharp.Schemata259.ReplaceStringConstant_0(829L, ".")))), () => builtInDatatypeDestructor.IsMatch(app.Func.Name.Split(MutateCSharp.Schemata259.ReplaceStringConstant_0(836L, ".")).Last())), () => app.Func.Name.Split(MutateCSharp.Schemata259.ReplaceStringConstant_0(843L, ".")).Last().StartsWith(MutateCSharp.Schemata259.ReplaceStringConstant_0(844L, "_"))))
                {
                    continue;
                }

                if (app.Func.Name.EndsWith(MutateCSharp.Schemata259.ReplaceStringConstant_0(851L, "#canCall")))
                {
                    canCallFunctions.Add(app.Func.Name);
                }
                else
                {
                    result.Add(app.Func);
                }
            }
            return result.Where(func => canCallFunctions.All(canCall => !canCall.StartsWith(func.Name))).ToList();
        }

        /// <summary>
        /// Return all function applications relevant to an element. 
        /// </summary>
        private List<Model.FuncTuple> GetFunctionConstants(Model.Element element, Model.Element? heap)
        {
            var possibleTypeIdentifiers = GetIsResults(element);
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_13(852L, fDtype.OptEval(element), null))
            {
                possibleTypeIdentifiers.Add(fDtype.OptEval(element)!);
            }
            var possiblyNullableTypes = possibleTypeIdentifiers
              .Select(ReconstructType).OfType<UserDefinedType>()
              .Where(type => MutateCSharp.Schemata259.ReplaceBinExprOp_11(853L, type.Name, UnknownType.Name));
            var types = possiblyNullableTypes.Select(DafnyModelTypeUtils.GetNonNullable).OfType<UserDefinedType>().ToList();
            List<Model.FuncTuple> applications = new();
            List<Model.FuncTuple> wellFormed = new();
            foreach (var app in element.References)
            {
                if (MutateCSharp.Schemata259.ReplaceBinExprOp_14(924L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_14(916L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_14(909L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_17(858L, app.Args.Length, MutateCSharp.Schemata259.ReplaceNumericConstant_1(854L, 0)), () => (MutateCSharp.Schemata259.ReplaceBinExprOp_4(903L, () => !Equals(app.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(863L, 0)], element), () => (MutateCSharp.Schemata259.ReplaceBinExprOp_14(897L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_14(887L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_14(872L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_21(867L, heap, null), () => !Equals(app.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(868L, 0)], heap)), () => MutateCSharp.Schemata259.ReplaceBinExprOp_17(882L, app.Args.Length, MutateCSharp.Schemata259.ReplaceNumericConstant_1(878L, 1))), () => !Equals(app.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(893L, 1)], element)))))), () => !types.Any(type => app.Func.Name.StartsWith(type.Name + MutateCSharp.Schemata259.ReplaceStringConstant_0(915L, ".")))), () => app.Func.Name.Split(MutateCSharp.Schemata259.ReplaceStringConstant_0(922L, ".")).Last().StartsWith(MutateCSharp.Schemata259.ReplaceStringConstant_0(923L, "_"))))
                {
                    continue;
                }

                if (app.Func.Name.EndsWith(MutateCSharp.Schemata259.ReplaceStringConstant_0(930L, "#canCall")))
                {
                    if (app.Result is Model.Boolean { Value: true })
                    {
                        wellFormed.Add(app);
                    }
                }
                else
                {
                    applications.Add(app);
                }
            }

            return applications.Where(application =>
              wellFormed.Any(wellFormedTuple => MutateCSharp.Schemata259.ReplaceBinExprOp_4(974L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_15(932L, wellFormedTuple.Func.Name, application.Func.Name + MutateCSharp.Schemata259.ReplaceStringConstant_0(931L, "#canCall")), () => (MutateCSharp.Schemata259.ReplaceBinExprOp_14(968L, () => (MutateCSharp.Schemata259.ReplaceBinExprOp_4(938L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_17(933L, wellFormedTuple.Args.Length, application.Args.Length), () => wellFormedTuple.Args.SequenceEqual(application.Args))), () => (MutateCSharp.Schemata259.ReplaceBinExprOp_4(962L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_17(957L, wellFormedTuple.Args.Length, MutateCSharp.Schemata259.ReplaceBinExprOp_8(948L, application.Args.Length, MutateCSharp.Schemata259.ReplaceNumericConstant_1(944L, 1))), () => wellFormedTuple.Args.SequenceEqual(application.Args[1..])))))))
            ).ToList();
        }

        /// <summary>
        /// Return the name of the field represented by the given element.
        /// Special care is required if the element represents an array index
        /// </summary>
        private List<string> GetFieldNames(Model.Element? elt)
        {
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_21(980L, elt, null))
            {
                return new List<string>();
            }
            var dims = fDim.OptEval(elt)?.AsInt();
            if (dims is null or 0)
            { // meaning elt is not an array index
                return elt.Names.Where(tuple => MutateCSharp.Schemata259.ReplaceBinExprOp_4(991L, () => MutateCSharp.Schemata259.ReplaceBinExprOp_10(985L, tuple.Func.Arity, MutateCSharp.Schemata259.ReplaceNumericConstant_1(981L, 0)), () => !tuple.Func.Name.Contains(MutateCSharp.Schemata259.ReplaceStringConstant_0(990L, "$"))))
                  .Select(tuple => UnderscoreRemovalRegex
                    .Replace(tuple.Func.Name.Split(MutateCSharp.Schemata259.ReplaceStringConstant_0(997L, ".")).Last(), MutateCSharp.Schemata259.ReplaceStringConstant_0(998L, "_")))
                  .ToList();
            }
            // Reaching this code means elt is an index into an array
            var indices = new Model.Element?[(int)dims];
            for (int i = (int)dims; MutateCSharp.Schemata259.ReplaceBinExprOp_27(1007L, MutateCSharp.Schemata259.ReplaceNumericConstant_1(999L, 0), MutateCSharp.Schemata259.ReplacePrefixUnaryExprOp_26(1003L, ref i));)
            {
                ModelFuncWrapper.ModelFuncTupleWrapper? dimTuple;
                if (MutateCSharp.Schemata259.ReplaceBinExprOp_17(1016L, i, MutateCSharp.Schemata259.ReplaceNumericConstant_1(1012L, 0)))
                {
                    dimTuple = fIndexField.AppWithResult(elt);
                    if (MutateCSharp.Schemata259.ReplaceBinExprOp_28(1021L, dimTuple, null))
                    {
                        continue;
                    }
                    indices[i] = dimTuple.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(1022L, 0)];
                }
                else
                {
                    dimTuple = fMultiIndexField.AppWithResult(elt);
                    if (MutateCSharp.Schemata259.ReplaceBinExprOp_28(1026L, dimTuple, null))
                    {
                        continue;
                    }
                    indices[i] = dimTuple.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(1027L, 1)];
                    elt = dimTuple.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(1031L, 0)];
                }
            }
            return new List<string>()
            {
                MutateCSharp.Schemata259.ReplaceStringConstant_0(1035L, "[") + string.Join(MutateCSharp.Schemata259.ReplaceStringConstant_0(1036L, ","),
                indices.ToList().ConvertAll(element => MutateCSharp.Schemata259.ReplaceBinExprOp_21(1037L, element, null) ? MutateCSharp.Schemata259.ReplaceStringConstant_0(1038L, "null") : element.ToString())) + MutateCSharp.Schemata259.ReplaceStringConstant_0(1039L, "]"
      )
            };
        }

        /// <summary> Unboxes an element, if possible </summary>
        private Model.Element? Unbox(Model.Element? elt)
        {
            return MutateCSharp.Schemata259.ReplaceBinExprOp_21(1040L, elt, null) ? null : UnboxNotNull(elt);
        }

        /// <summary> Unboxes an element, if possible </summary>
        private Model.Element UnboxNotNull(Model.Element elt)
        {
            var unboxed = fBox.AppWithResult(elt);
            if (MutateCSharp.Schemata259.ReplaceBinExprOp_16(1041L, unboxed, null))
            {
                return UnboxNotNull(unboxed.Args[MutateCSharp.Schemata259.ReplaceNumericConstant_1(1042L, 0)]);
            }
            unboxed = fUnbox.AppWithArg(MutateCSharp.Schemata259.ReplaceNumericConstant_1(1046L, 1), elt);
            return MutateCSharp.Schemata259.ReplaceBinExprOp_16(1050L, unboxed, null) ? UnboxNotNull(unboxed.Result) : elt;
        }
    }
}
