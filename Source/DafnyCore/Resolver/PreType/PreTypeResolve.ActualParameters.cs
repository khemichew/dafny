//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.Contracts;
using ResolutionContext = Microsoft.Dafny.ResolutionContext;
namespace MutateCSharp
{
    internal class Schemata421
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT421");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
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

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.ActualBinding argument1, object argument2)
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

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static int ReplaceNumericConstant_8(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
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

        internal static bool ReplaceBinExprOp_15(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.ActualBinding argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public partial class PreTypeResolver
    {
        /// <summary>
        /// Resolve the actual arguments given in "bindings". Then, check that there is exactly one
        /// actual for each formal, and impose assignable constraints.
        /// "typeMap" is applied to the type of each formal.
        /// This method should be called only once. That is, bindings.arguments is required to be null on entry to this method.
        /// </summary>
        void ResolveActualParameters(ActualBindings bindings, List<Formal> formals, IToken callTok, object context, ResolutionContext opts,
          Dictionary<TypeParameter, PreType> typeMap, Expression/*?*/ receiver)
        {
            Contract.Requires(bindings != null);
            Contract.Requires(formals != null);
            Contract.Requires(callTok != null);
            Contract.Requires(context is Method || context is Function || context is DatatypeCtor || context is ArrowType);
            Contract.Requires(typeMap != null);

            string whatKind;
            string name;
            if (context is Method cMethod)
            {
                whatKind = cMethod.WhatKind;
                name = $"{whatKind} '{cMethod.Name}'";
            }
            else if (context is Function cFunction)
            {
                whatKind = cFunction.WhatKind;
                name = $"{whatKind} '{cFunction.Name}'";
            }
            else if (context is DatatypeCtor cCtor)
            {
                whatKind = MutateCSharp.Schemata421.ReplaceStringConstant_0(1L, "datatype constructor");
                name = $"{whatKind} '{cCtor.Name}'";
            }
            else
            {
                var arrowPreType = (DPreType)context;
                Contract.Assert(DPreType.IsArrowType(arrowPreType.Decl));
                whatKind = MutateCSharp.Schemata421.ReplaceStringConstant_0(2L, "function application");
                name = $"function type '{arrowPreType}'";
            }

            // If all arguments are passed positionally, use simple error messages that talk about the count of arguments.
            var onlyPositionalArguments = bindings.ArgumentBindings.TrueForAll(binding => MutateCSharp.Schemata421.ReplaceBinExprOp_1(3L, binding.FormalParameterName, null));
            var simpleErrorReported = MutateCSharp.Schemata421.ReplaceBooleanConstant_2(4L, false);
            if (onlyPositionalArguments)
            {
                var requiredParametersCount = formals.Count(f => MutateCSharp.Schemata421.ReplaceBinExprOp_3(5L, f.DefaultValue, null));
                var actualsCounts = bindings.ArgumentBindings.Count;
                if (MutateCSharp.Schemata421.ReplaceBinExprOp_5(16L, () => MutateCSharp.Schemata421.ReplaceBinExprOp_4(6L, requiredParametersCount, actualsCounts), () => MutateCSharp.Schemata421.ReplaceBinExprOp_4(11L, actualsCounts, formals.Count)))
                {
                    // the situation is plausible
                }
                else if (MutateCSharp.Schemata421.ReplaceBinExprOp_6(22L, requiredParametersCount, formals.Count))
                {
                    // this is the common, classical case of no default parameter values; generate a straightforward error message
                    ReportError(callTok, $"wrong number of arguments ({name} expects {formals.Count}, got {actualsCounts})");
                    simpleErrorReported = MutateCSharp.Schemata421.ReplaceBooleanConstant_2(27L, true);
                }
                else if (MutateCSharp.Schemata421.ReplaceBinExprOp_7(28L, actualsCounts, requiredParametersCount))
                {
                    ReportError(callTok, $"wrong number of arguments ({name} expects at least {requiredParametersCount}, got {actualsCounts})");
                    simpleErrorReported = MutateCSharp.Schemata421.ReplaceBooleanConstant_2(33L, true);
                }
                else
                {
                    ReportError(callTok, $"wrong number of arguments ({name} expects at most {formals.Count}, got {actualsCounts})");
                    simpleErrorReported = MutateCSharp.Schemata421.ReplaceBooleanConstant_2(34L, true);
                }
            }

            // resolve given arguments and populate the "namesToActuals" map
            var namesToActuals = new Dictionary<string, ActualBinding>();
            formals.ForEach(f => namesToActuals.Add(f.Name, null)); // a name mapping to "null" says it hasn't been filled in yet
            var stillAcceptingPositionalArguments = MutateCSharp.Schemata421.ReplaceBooleanConstant_2(35L, true);
            var bindingIndex = MutateCSharp.Schemata421.ReplaceNumericConstant_8(36L, 0);
            foreach (var binding in bindings.ArgumentBindings)
            {
                var arg = binding.Actual;
                // insert the actual into "namesToActuals" under an appropriate name, unless there is an error
                if (MutateCSharp.Schemata421.ReplaceBinExprOp_9(40L, binding.FormalParameterName, null))
                {
                    var pname = binding.FormalParameterName.val;
                    stillAcceptingPositionalArguments = MutateCSharp.Schemata421.ReplaceBooleanConstant_2(41L, false);
                    if (!namesToActuals.TryGetValue(pname, out var b))
                    {
                        ReportError(binding.FormalParameterName, $"the binding named '{pname}' does not correspond to any formal parameter");
                    }
                    else if (MutateCSharp.Schemata421.ReplaceBinExprOp_10(42L, b, null))
                    {
                        // all is good
                        namesToActuals[pname] = binding;
                    }
                    else if (MutateCSharp.Schemata421.ReplaceBinExprOp_1(43L, b.FormalParameterName, null))
                    {
                        ReportError(binding.FormalParameterName, $"the parameter named '{pname}' is already given positionally");
                    }
                    else
                    {
                        ReportError(binding.FormalParameterName, $"duplicate binding for parameter name '{pname}'");
                    }
                }
                else if (!stillAcceptingPositionalArguments)
                {
                    ReportError(arg.tok, MutateCSharp.Schemata421.ReplaceStringConstant_0(44L, "a positional argument is not allowed to follow named arguments"));
                }
                else if (MutateCSharp.Schemata421.ReplaceBinExprOp_7(45L, bindingIndex, formals.Count))
                {
                    // use the name of formal corresponding to this positional argument, unless the parameter is name-only
                    var formal = formals[bindingIndex];
                    var pname = formal.Name;
                    if (formal.IsNameOnly)
                    {
                        ReportError(arg.tok, $"nameonly parameter '{pname}' must be passed using a name binding; it cannot be passed positionally");
                    }
                    Contract.Assert(namesToActuals[pname] == null); // we expect this, since we've only filled parameters positionally so far
                    namesToActuals[pname] = binding;
                }
                else
                {
                    // too many positional arguments
                    if (onlyPositionalArguments)
                    {
                        // error was reported before the "foreach" loop
                        Contract.Assert(simpleErrorReported);
                    }
                    else if (MutateCSharp.Schemata421.ReplaceBinExprOp_7(50L, formals.Count, bindingIndex))
                    {
                        // error was reported on a previous iteration of this "foreach" loop
                    }
                    else
                    {
                        ReportError(callTok, $"wrong number of arguments ({name} expects {formals.Count}, got {bindings.ArgumentBindings.Count})");
                    }
                }

                // resolve argument
                ResolveExpression(arg, opts);
                MutateCSharp.Schemata421.ReplacePostfixUnaryExprOp_11(55L, ref bindingIndex);
            }

            var actuals = new List<Expression>();
            var formalIndex = MutateCSharp.Schemata421.ReplaceNumericConstant_8(56L, 0);
            var substMap = new Dictionary<IVariable, Expression>();
            foreach (var formal in formals)
            {
                var b = namesToActuals[formal.Name];
                if (MutateCSharp.Schemata421.ReplaceBinExprOp_12(60L, b, null))
                {
                    actuals.Add(b.Actual);
                    substMap.Add(formal, b.Actual);
                    var what = GetLocationInformation(formal,
                      bindings.ArgumentBindings.Count, bindings.ArgumentBindings.IndexOf(b),
                      whatKind + (context is Method ? MutateCSharp.Schemata421.ReplaceStringConstant_0(61L, " in-parameter") : MutateCSharp.Schemata421.ReplaceStringConstant_0(62L, " parameter")));

                    Constraints.AddSubtypeConstraint(
                      formal.PreType.Substitute(typeMap), b.Actual.PreType, callTok,
                      $"incorrect argument type {what} (expected {{0}}, found {{1}})");
                }
                else if (MutateCSharp.Schemata421.ReplaceBinExprOp_13(63L, formal.DefaultValue, null))
                {
                    // Note, in the following line, "substMap" is passed in, but it hasn't been fully filled in until the
                    // end of this foreach loop. Still, that's soon enough, because DefaultValueExpression won't use it
                    // until FillInDefaultValueExpressions at the end of Pass 0 of the Resolver.
                    var n = new DefaultValueExpressionPreType(callTok, formal, receiver, substMap, typeMap) { PreType = formal.PreType.Substitute(typeMap) };
                    resolver.allDefaultValueExpressions.Add(n);
                    actuals.Add(n);
                    substMap.Add(formal, n);
                }
                else
                {
                    // parameter has no value
                    if (!simpleErrorReported)
                    {
                        var formalDescription = whatKind + (context is Method ? MutateCSharp.Schemata421.ReplaceStringConstant_0(64L, " in-parameter") : MutateCSharp.Schemata421.ReplaceStringConstant_0(65L, " parameter"));
                        var nameWithIndex = MutateCSharp.Schemata421.ReplaceBinExprOp_5(66L, () => formal.HasName, () => formal is not ImplicitFormal) ? MutateCSharp.Schemata421.ReplaceStringConstant_0(72L, "'") + formal.Name + MutateCSharp.Schemata421.ReplaceStringConstant_0(73L, "'") : "";
                        if (MutateCSharp.Schemata421.ReplaceBinExprOp_16(84L, () => MutateCSharp.Schemata421.ReplaceBinExprOp_14(78L, formals.Count, MutateCSharp.Schemata421.ReplaceNumericConstant_8(74L, 1)), () => MutateCSharp.Schemata421.ReplaceBinExprOp_15(83L, nameWithIndex, "")))
                        {
                            nameWithIndex += MutateCSharp.Schemata421.ReplaceBinExprOp_15(90L, nameWithIndex, "") ? "" : MutateCSharp.Schemata421.ReplaceStringConstant_0(91L, " ");
                            nameWithIndex += $"at index {formalIndex}";
                        }

                        var message = $"{formalDescription} {nameWithIndex} requires an argument of type {formal.Type}";
                        ReportError(callTok, message);
                    }
                }

                MutateCSharp.Schemata421.ReplacePostfixUnaryExprOp_11(92L, ref formalIndex);
            }

            bindings.AcceptArgumentExpressionsAsExactParameterList(actuals);
        }

        private static string GetLocationInformation(Formal parameter, int bindingCount, int bindingIndex, string formalDescription)
        {
            Contract.Requires(parameter != null);
            Contract.Requires(0 <= bindingIndex);
            Contract.Requires(bindingIndex < bindingCount);
            Contract.Requires(formalDescription != null);

            var description = "";
            if (MutateCSharp.Schemata421.ReplaceBinExprOp_14(97L, bindingCount, MutateCSharp.Schemata421.ReplaceNumericConstant_8(93L, 1)))
            {
                description += $"at index {bindingIndex} ";
            }

            description += $"for {formalDescription}";

            if (MutateCSharp.Schemata421.ReplaceBinExprOp_5(102L, () => parameter.HasName, () => parameter is not ImplicitFormal))
            {
                description += $" '{parameter.Name}'";
            }

            return description;
        }
    }
}
