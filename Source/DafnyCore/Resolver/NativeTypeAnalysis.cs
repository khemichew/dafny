//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------
using System.Collections.Generic;
using System.Numerics;
using System.Diagnostics.Contracts;
using JetBrains.Annotations;
namespace MutateCSharp
{
    internal class Schemata411
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT411");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceNumericConstant_10(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, System.Numerics.BigInteger? argument1, System.Numerics.BigInteger? argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.NativeType.Selection argument1, Microsoft.Dafny.NativeType.Selection? argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_14(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.NativeType.Selection argument1, Microsoft.Dafny.NativeType.Selection argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.NativeType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, System.Numerics.BigInteger argument1, System.Numerics.BigInteger? argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 >= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 >= argument2;
        }

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.BoundVar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
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

        internal static string ReplaceStringConstant_3(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, bool? argument1, bool argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, System.Numerics.BigInteger argument1, System.Numerics.BigInteger? argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.NativeType> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, System.Numerics.BigInteger? argument1, System.Numerics.BigInteger? argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.NewtypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, System.Numerics.BigInteger? argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, System.Collections.Generic.List<(Microsoft.Dafny.NativeType, bool coversEntireIntegerRange)> argument1, object argument2)
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

    }
}

namespace Microsoft.Dafny
{
    public
class NativeTypeAnalysis
    {
        private readonly ErrorReporter reporter;

        public NativeTypeAnalysis(ErrorReporter reporter)
        {
            this.reporter = reporter;
        }

        public void FigureOutNativeType(NewtypeDecl dd, DafnyOptions options)
        {

            // Look at the :nativeType attribute, if any
            var hasNativeTypePreference = ReadAttributesForNativePreferences(dd.Attributes, out var nativeTypeChoices);
            if (MutateCSharp.Schemata411.ReplaceBinExprOp_1(2L, hasNativeTypePreference, MutateCSharp.Schemata411.ReplaceBooleanConstant_0(1L, false)))
            {
                // don't use native type
                return;
            }
            if (MutateCSharp.Schemata411.ReplaceBinExprOp_2(5L, () => MutateCSharp.Schemata411.ReplaceBinExprOp_1(4L, hasNativeTypePreference, MutateCSharp.Schemata411.ReplaceBooleanConstant_0(3L, true)), () => dd.BaseType.NormalizeToAncestorType() is not (IntType or BitvectorType)))
            {
                reporter.Error(MessageSource.Resolver, dd, MutateCSharp.Schemata411.ReplaceStringConstant_3(11L, ":nativeType can only be used on a newtype based on integers or bitvectors"));
                return;
            }

            var detectedRange = "";
            List<(NativeType, bool coversEntireIntegerRange)> possibleNativeTypes = GetPossibleNativeTypes(dd, nativeTypeChoices, ref detectedRange);
            if (MutateCSharp.Schemata411.ReplaceBinExprOp_4(12L, possibleNativeTypes, null))
            {
                // An error occurred while computing "possibleNativeTypes"
                return;
            }

            // Finally, of the big-enough native types, pick the first one that is supported by the selected target compiler.
            foreach (var (nativeT, coversEntireIntegerRange) in possibleNativeTypes)
            {
                if (options.Backend.SupportedNativeTypes.Contains(nativeT.Name))
                {
                    // Pick this one!
                    dd.NativeType = nativeT;
                    if (MutateCSharp.Schemata411.ReplaceBinExprOp_2(14L, () => coversEntireIntegerRange, () => MutateCSharp.Schemata411.ReplaceBinExprOp_5(13L, nativeT.Sel, NativeType.Selection.Number)))
                    {
                        dd.TargetTypeCoversAllBitPatterns = MutateCSharp.Schemata411.ReplaceBooleanConstant_0(20L, true);
                    }

                    // Give an info message saying which type was selected--unless the user requested
                    // one particular native type, in which case that must have been the one picked.
                    if (nativeTypeChoices is { Count: 1 })
                    {
                        Contract.Assert(dd.NativeType == nativeTypeChoices[0]);
                        if (dd.TargetTypeCoversAllBitPatterns)
                        {
                            reporter.Info(MessageSource.Resolver, dd.tok,
                              $"newtype {dd.Name} is target-complete for {{:nativeType \"{dd.NativeType.Name}\"}}");
                        }
                    }
                    else
                    {
                        var targetComplete = dd.TargetTypeCoversAllBitPatterns ? MutateCSharp.Schemata411.ReplaceStringConstant_3(21L, "target-complete ") : "";
                        reporter.Info(MessageSource.Resolver, dd.tok,
                          $"newtype {dd.Name} resolves as {targetComplete}{{:nativeType \"{dd.NativeType.Name}\"}} (detected range: {detectedRange})");
                    }

                    return;
                }
            }
            // Among the choices available to us, we did not find a native type that is big enough and supported by the compiler.
            if (MutateCSharp.Schemata411.ReplaceBinExprOp_6(22L, nativeTypeChoices, null))
            {
                reporter.Error(MessageSource.Resolver, dd,
          MutateCSharp.Schemata411.ReplaceStringConstant_3(23L, "None of the types given in :nativeType arguments is supported by the current compilation target. Try supplying others."));
            }
            else if (MutateCSharp.Schemata411.ReplaceBinExprOp_1(25L, hasNativeTypePreference, MutateCSharp.Schemata411.ReplaceBooleanConstant_0(24L, true)))
            {
                reporter.Error(MessageSource.Resolver, dd,
          MutateCSharp.Schemata411.ReplaceStringConstant_3(26L, "Dafny's heuristics cannot find a compatible native type. ") +
          MutateCSharp.Schemata411.ReplaceStringConstant_3(27L, "Hint: try writing a newtype constraint of the form 'i: int | lowerBound <= i < upperBound && (...any additional constraints...)'."));
            }
        }

        /// <summary>
        /// Return the native types that are big enough to hold values of for "newtypeDecl". If "nativeTypeChoices" is given, then the
        /// search is restricted to those native types.
        ///
        /// For each native type returned, also indicate if that native type covers the entire integer range of "newtypeDecl".
        /// </summary>
        private List<(NativeType, bool coversEntireIntegerRange)> GetPossibleNativeTypes(NewtypeDecl newtypeDecl,
          [CanBeNull] List<NativeType> nativeTypeChoices, ref string detectedRange)
        {

            // Figure out the variable and constraint.  Usually, these would be just .Var and .Constraint, but
            // in the case .Var/.Constraint are null, these can be computed from the .BaseType recursively.
            var ddVar = newtypeDecl.Var;
            var ddConstraint = newtypeDecl.Constraint;
            for (var ddWhereConstraintsAre = newtypeDecl; MutateCSharp.Schemata411.ReplaceBinExprOp_7(28L, ddVar, null);)
            {
                ddWhereConstraintsAre = ddWhereConstraintsAre.BaseType.AsNewtype;
                if (MutateCSharp.Schemata411.ReplaceBinExprOp_8(29L, ddWhereConstraintsAre, null))
                {
                    break;
                }
                ddVar = ddWhereConstraintsAre.Var;
                ddConstraint = ddWhereConstraintsAre.Constraint;
            }

            var ancestorType = newtypeDecl.BaseType.NormalizeToAncestorType();
            if (ancestorType is BitvectorType bitvectorAncestorType)
            {
                return FigureOutNativeTypeForBitvectorNewtype(newtypeDecl, bitvectorAncestorType, MutateCSharp.Schemata411.ReplaceBinExprOp_7(30L, ddVar, null),
                  nativeTypeChoices ?? ModuleResolver.NativeTypes, MutateCSharp.Schemata411.ReplaceBinExprOp_6(31L, nativeTypeChoices, null));
            }
            else if (ancestorType is IntType)
            {
                return FigureOutNativeTypeForIntegerNewtype(newtypeDecl, ddVar, ddConstraint,
                  nativeTypeChoices ?? ModuleResolver.NativeTypes, MutateCSharp.Schemata411.ReplaceBinExprOp_6(32L, nativeTypeChoices, null), out detectedRange);
            }
            else
            {
                // No native type available
                return new List<(NativeType, bool coversEntireIntegerRange)>();
            }

            return default;
        }

        /// <summary>
        /// Look at the :nativeType attribute, if any, to determine preferences.
        /// A return of false means: don't use native type. (nativeTypes returns as null)
        /// A return of null means: no preference. (nativeTypes returns as null)
        /// A return of true means: make sure a native type is used. Furthermore,
        ///   * if nativeTypes is null, then no particular preference about which native type is picked
        ///   * if nativeTypes is non-null, then the choices of native types are restricted to those.
        /// </summary>
        bool? ReadAttributesForNativePreferences(Attributes attributes, [CanBeNull] out List<NativeType> nativeTypes)
        {
            nativeTypes = null;
            var args = Attributes.FindExpressions(attributes, MutateCSharp.Schemata411.ReplaceStringConstant_3(33L, "nativeType"));
            if (MutateCSharp.Schemata411.ReplaceBinExprOp_9(34L, args, null))
            {
                // There was no :nativeType attribute
                return null;
            }
            if (MutateCSharp.Schemata411.ReplaceBinExprOp_11(39L, args.Count, MutateCSharp.Schemata411.ReplaceNumericConstant_10(35L, 0)))
            {
                // {:nativeType}
                return MutateCSharp.Schemata411.ReplaceBooleanConstant_0(44L, true);
            }
            if (args[MutateCSharp.Schemata411.ReplaceNumericConstant_10(45L, 0)] is LiteralExpr { Value: bool and var boolValue })
            {
                return boolValue;
            }

            var choices = new List<NativeType>();
            foreach (var arg in args)
            {
                if (arg is LiteralExpr { Value: string s })
                {
                    // Get the NativeType for "s"
                    var nativeType = ModuleResolver.NativeTypes.Find(nativeType => MutateCSharp.Schemata411.ReplaceBinExprOp_12(49L, nativeType.Name, s));
                    if (MutateCSharp.Schemata411.ReplaceBinExprOp_13(50L, nativeType, null))
                    {
                        reporter.Error(MessageSource.Resolver, arg.tok, MutateCSharp.Schemata411.ReplaceStringConstant_3(51L, ":nativeType '{0}' not known"), s);
                        return MutateCSharp.Schemata411.ReplaceBooleanConstant_0(52L, false);
                    }
                    choices.Add(nativeType);
                }
                else
                {
                    reporter.Error(MessageSource.Resolver, arg, MutateCSharp.Schemata411.ReplaceStringConstant_3(53L, "unexpected :nativeType argument"));
                    return MutateCSharp.Schemata411.ReplaceBooleanConstant_0(54L, false);
                }
            }
            nativeTypes = choices;
            return MutateCSharp.Schemata411.ReplaceBooleanConstant_0(55L, true);
        }

        /// <summary>
        /// Returns a list of (n, b) pairs, where "n" is a big enough native type to hold "dd" and "b" says whether or not
        /// all bit patterns of "n" are possible values for "dd".
        /// Returns null if a failure is detected and reported.
        /// </summary>
        [CanBeNull]
        private List<(NativeType, bool coversEntireIntegerRange)> FigureOutNativeTypeForBitvectorNewtype(NewtypeDecl dd,
          BitvectorType bitvectorAncestorType, bool noFurtherConstraints,
          List<NativeType> nativeTypesUnderConsideration, bool reportErrorIfTUCDoesNotFit)
        {

            var bigEnoughNativeTypes = new List<(NativeType, bool coversEntireIntegerRange)>();
            foreach (var nativeType in nativeTypesUnderConsideration)
            {
                if (MutateCSharp.Schemata411.ReplaceBinExprOp_2(70L, () => MutateCSharp.Schemata411.ReplaceBinExprOp_14(60L, nativeType.Bitwidth, MutateCSharp.Schemata411.ReplaceNumericConstant_10(56L, 0)), () => MutateCSharp.Schemata411.ReplaceBinExprOp_15(65L, bitvectorAncestorType.Width, nativeType.Bitwidth)))
                {
                    bigEnoughNativeTypes.Add((nativeType, MutateCSharp.Schemata411.ReplaceBinExprOp_2(81L, () => noFurtherConstraints, () => MutateCSharp.Schemata411.ReplaceBinExprOp_11(76L, bitvectorAncestorType.Width, nativeType.Bitwidth))));
                }
                else if (MutateCSharp.Schemata411.ReplaceBinExprOp_2(96L, () => reportErrorIfTUCDoesNotFit, () => MutateCSharp.Schemata411.ReplaceBinExprOp_11(91L, nativeType.Bitwidth, MutateCSharp.Schemata411.ReplaceNumericConstant_10(87L, 0))))
                {
                    var hint = "";
                    if (nativeType.UnsignedCounterpart() is not null and var unsignedCounterpart)
                    {
                        var counterpart = ModuleResolver.NativeTypes.Find(nativeT => MutateCSharp.Schemata411.ReplaceBinExprOp_16(102L, nativeT.Sel, unsignedCounterpart));
                        Contract.Assert(counterpart != null);
                        hint = $" Hint: Try using the unsigned native type '{counterpart.Name}'.";
                    }
                    reporter.Error(MessageSource.Resolver, dd,
                      $"A newtype based on a bitvector type ({bitvectorAncestorType.Name}) cannot use a native type that admits negative values ('{nativeType.Name}').{hint}");
                    return null;
                }
                else if (reportErrorIfTUCDoesNotFit)
                {
                    var hint = noFurtherConstraints ? "" : MutateCSharp.Schemata411.ReplaceStringConstant_3(103L, " Note: constraints of bitvector-based newtypes are not considered when determining native types.");
                    reporter.Error(MessageSource.Resolver, dd,
                      $"The width of bitvector type {bitvectorAncestorType.Name} cannot fit into native type '{nativeType.Name}'.{hint}");
                    return null;
                }
            }

            return bigEnoughNativeTypes;
        }

        /// <summary>
        /// Returns a list of (n, b) pairs, where "n" is a big enough native type to hold "dd" and "b" says whether or not
        /// all bit patterns of "n" are possible values for "dd".
        /// Returns null if a failure is detected and reported.
        /// </summary>
        [CanBeNull]
        private List<(NativeType, bool coversEntireIntegerRange)> FigureOutNativeTypeForIntegerNewtype(NewtypeDecl dd,
          [CanBeNull] BoundVar ddVar, [CanBeNull] Expression ddConstraint,
          List<NativeType> nativeTypesUnderConsideration, bool reportErrorIfTUCDoesNotFit,
          out string detectedRange)
        {
            Contract.Requires((ddVar == null) == (ddConstraint == null));

            bool constraintConsistsSolelyOfRangeConstraints;
            BigInteger? lowBound = null;
            BigInteger? highBound = null;
            if (MutateCSharp.Schemata411.ReplaceBinExprOp_7(104L, ddVar, null))
            {
                constraintConsistsSolelyOfRangeConstraints = MutateCSharp.Schemata411.ReplaceBooleanConstant_0(105L, true);
            }
            else
            {
                var bounds = ModuleResolver.DiscoverAllBounds_SingleVar(ddVar, ddConstraint, out constraintConsistsSolelyOfRangeConstraints);

                foreach (var bound in bounds)
                {
                    void UpdateBounds(BigInteger? lo, BigInteger? hi)
                    {
                        if (MutateCSharp.Schemata411.ReplaceBinExprOp_2(114L, () => lo != null, () => (MutateCSharp.Schemata411.ReplaceBinExprOp_18(108L, () => lowBound == null, () => MutateCSharp.Schemata411.ReplaceBinExprOp_17(106L, lowBound, lo)))))
                        {
                            lowBound = lo; // we found a more restrictive lower bound
                        }
                        if (MutateCSharp.Schemata411.ReplaceBinExprOp_2(128L, () => hi != null, () => (MutateCSharp.Schemata411.ReplaceBinExprOp_18(122L, () => highBound == null, () => MutateCSharp.Schemata411.ReplaceBinExprOp_17(120L, hi, highBound)))))
                        {
                            highBound = hi; // we found a more restrictive lower bound
                        }
                    }

                    if (bound is IntBoundedPool range)
                    {
                        if (MutateCSharp.Schemata411.ReplaceBinExprOp_19(134L, range.LowerBound, null) && ConstantFolder.TryFoldInteger(range.LowerBound) is not null and var lo)
                        {
                            UpdateBounds(lo, null);
                        }
                        if (MutateCSharp.Schemata411.ReplaceBinExprOp_19(135L, range.UpperBound, null) && ConstantFolder.TryFoldInteger(range.UpperBound) is not null and var hi)
                        {
                            UpdateBounds(null, hi);
                        }
                    }
                    else if (bound is ExactBoundedPool exact && ConstantFolder.TryFoldInteger(exact.E) is not null and var value)
                    {
                        UpdateBounds(value, value + 1);
                    }
                }
            }

            var emptyRange = MutateCSharp.Schemata411.ReplaceBinExprOp_2(144L, () => MutateCSharp.Schemata411.ReplaceBinExprOp_2(136L, () => lowBound != null, () => highBound != null), () => MutateCSharp.Schemata411.ReplaceBinExprOp_20(142L, highBound, lowBound));
            detectedRange = MutateCSharp.Schemata411.ReplaceBinExprOp_18(150L, () => lowBound == null, () => highBound == null) ? "" : emptyRange ? MutateCSharp.Schemata411.ReplaceStringConstant_3(156L, "empty") : $"{lowBound} .. {highBound}";

            var bigEnoughNativeTypes = new List<(NativeType, bool coversEntireIntegerRange)>();
            foreach (var nativeT in nativeTypesUnderConsideration)
            {
                bool lowerOk = MutateCSharp.Schemata411.ReplaceBinExprOp_18(165L, () => emptyRange, () => (MutateCSharp.Schemata411.ReplaceBinExprOp_2(159L, () => lowBound != null, () => MutateCSharp.Schemata411.ReplaceBinExprOp_21(157L, nativeT.LowerBound, lowBound))));
                bool upperOk = MutateCSharp.Schemata411.ReplaceBinExprOp_18(179L, () => emptyRange, () => (MutateCSharp.Schemata411.ReplaceBinExprOp_2(173L, () => highBound != null, () => MutateCSharp.Schemata411.ReplaceBinExprOp_22(171L, nativeT.UpperBound, highBound))));
                if (MutateCSharp.Schemata411.ReplaceBinExprOp_2(185L, () => lowerOk, () => upperOk))
                {
                    var coversAllBitPatterns = MutateCSharp.Schemata411.ReplaceBinExprOp_2(199L, () => MutateCSharp.Schemata411.ReplaceBinExprOp_2(192L, () => constraintConsistsSolelyOfRangeConstraints, () => MutateCSharp.Schemata411.ReplaceBinExprOp_23(191L, lowBound, nativeT.LowerBound)), () => MutateCSharp.Schemata411.ReplaceBinExprOp_23(198L, highBound, nativeT.UpperBound));
                    bigEnoughNativeTypes.Add((nativeT, coversAllBitPatterns));
                }
                else if (reportErrorIfTUCDoesNotFit)
                {
                    var hint = MutateCSharp.Schemata411.ReplaceStringConstant_3(205L, " Hint: try writing a newtype constraint of the form 'i: int | lowerBound <= i < upperBound && (...any additional constraints...)'.");
                    reporter.Error(MessageSource.Resolver, dd,
                      $"Dafny's heuristics failed to confirm '{nativeT.Name}' to be a compatible native type.{hint}");
                    return null;
                }
            }
            return bigEnoughNativeTypes;
        }

    }
}