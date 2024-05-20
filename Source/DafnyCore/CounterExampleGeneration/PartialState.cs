// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.Boogie;
namespace MutateCSharp
{
    internal class Schemata262
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT262");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_8(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
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

        internal static bool ReplaceBinExprOp_11(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBooleanConstant_4(long mutantId, bool argument1)
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

        internal static bool ReplaceBinExprOp_14(long mutantId, Microsoft.Boogie.Model.Element argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_13(long mutantId, int argument1, int argument2)
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

        internal static int ReplaceNumericConstant_1(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static int ReplaceBinExprOp_6(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 / argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, int? argument1, int? argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_12(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
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
    public class PartialState
    {

        public bool IsLoopEntryState => FullStateName.Contains(CaptureStateExtensions.AfterLoopIterationsStateMarker);
        // ghost variables introduced by the counterexample whose values must be true for the counterexample to hold:
        public List<string> LoopGuards = new();
        public readonly Dictionary<PartialValue, List<string>> KnownVariableNames = new();
        private readonly List<PartialValue> initialPartialValues;
        internal readonly DafnyModel Model;
        internal readonly Model.CapturedState State;
        private const string InitialStateName = "<initial>";
        private static readonly Regex StatePositionRegex = new(
      MutateCSharp.Schemata262.ReplaceStringConstant_0(1L, @".*\((?<line>\d+),(?<character>\d+)\)"),
          RegexOptions.IgnoreCase | RegexOptions.Singleline
        );
        internal readonly Dictionary<Model.Element, PartialValue> AllPartialValues = new();

        private const string BoundVarPrefix = "boundVar";

        internal PartialState(DafnyModel model, Model.CapturedState state)
        {
            Model = model;
            State = state;
            initialPartialValues = new List<PartialValue>();
            SetupBoundVars();
            SetupVars();
        }

        /// <summary>
        /// Start with the union of vars and boundVars and expand the set by adding 
        /// all partial values that are necessary to fully constrain the counterexample.
        /// </summary>
        /// <returns>Set of partial values</returns>
        public HashSet<PartialValue> ExpandedVariableSet()
        {
            HashSet<PartialValue> expandedSet = new();
            // The following is the queue for elements to be added to the set. The 2nd
            // element of a tuple is the depth of the variable w.r.t. the original set
            List<Tuple<PartialValue, int>> varsToAdd = new();
            initialPartialValues.ForEach(variable => varsToAdd.Add(new(variable, MutateCSharp.Schemata262.ReplaceNumericConstant_1(2L, 0))));
            while (MutateCSharp.Schemata262.ReplaceBinExprOp_2(10L, varsToAdd.Count, MutateCSharp.Schemata262.ReplaceNumericConstant_1(6L, 0)))
            {
                var (next, depth) = varsToAdd[MutateCSharp.Schemata262.ReplaceNumericConstant_1(15L, 0)];
                varsToAdd.RemoveAt(MutateCSharp.Schemata262.ReplaceNumericConstant_1(19L, 0));
                if (expandedSet.Contains(next))
                {
                    continue;
                }
                expandedSet.Add(next);
                // fields of primitive types are skipped:
                foreach (var v in next.GetRelatedValues().
                    Where(variable => !expandedSet.Contains(variable)))
                {
                    varsToAdd.Add(new(v, MutateCSharp.Schemata262.ReplaceBinExprOp_3(27L, depth, MutateCSharp.Schemata262.ReplaceNumericConstant_1(23L, 1))));
                }
            }
            return expandedSet;
        }

        /// <summary>
        /// Return a conjunction of expression that is represented by a balanced AST. This is intended to prevent
        /// stackoverflow errors that occur if multiple conjuncts are joined in a linked list fashion.
        /// </summary>
        /// <returns></returns>
        private Expression GetCompactConjunction(List<Expression> conjuncts)
        {
            if (!conjuncts.Any())
            {
                return new LiteralExpr(Token.NoToken, MutateCSharp.Schemata262.ReplaceBooleanConstant_4(36L, true));
            }

            if (MutateCSharp.Schemata262.ReplaceBinExprOp_5(41L, conjuncts.Count(), MutateCSharp.Schemata262.ReplaceNumericConstant_1(37L, 1)))
            {
                return conjuncts.First();
            }

            var middle = MutateCSharp.Schemata262.ReplaceBinExprOp_6(50L, conjuncts.Count(), MutateCSharp.Schemata262.ReplaceNumericConstant_1(46L, 2));
            var left = GetCompactConjunction(conjuncts.Take(middle).ToList());
            var right = GetCompactConjunction(conjuncts.Skip(middle).ToList());
            return new BinaryExpr(Token.NoToken, BinaryExpr.Opcode.And, left, right);
        }

        /// <summary>
        /// Convert this counterexample state into an assumption that could be inserted in Dafny source code
        /// </summary>
        public Statement AsAssumption()
        {
            var allVariableNames = new Dictionary<PartialValue, Expression>();
            var variables = ExpandedVariableSet().ToArray();
            var constraintSet = new HashSet<Constraint>();

            // Collect all constraints into one list:
            foreach (var variable in variables)
            {
                foreach (var constraint in variable.Constraints)
                {
                    constraintSet.Add(constraint);
                }
            }

            // Ignore TypeTest constraints because they make the counterexample too verbose
            var constraints = constraintSet.Where(constraint => constraint is not TypeTestConstraint).ToList();
            constraints = Constraint.ResolveAndOrder(allVariableNames, constraints, MutateCSharp.Schemata262.ReplaceBooleanConstant_4(59L, true), MutateCSharp.Schemata262.ReplaceBooleanConstant_4(60L, true));

            // Create a bound variable for every partial value that we cannot otherwise refer to using variables in scope
            var boundVars = new List<BoundVar>();
            for (int i = MutateCSharp.Schemata262.ReplaceNumericConstant_1(61L, 0); MutateCSharp.Schemata262.ReplaceBinExprOp_7(65L, i, variables.Length); MutateCSharp.Schemata262.ReplacePostfixUnaryExprOp_8(70L, ref i))
            {
                if (!allVariableNames.ContainsKey(variables[i]))
                {
                    boundVars.Add(new BoundVar(Token.NoToken, BoundVarPrefix + boundVars.Count, variables[i].Type));
                    allVariableNames[variables[i]] = new IdentifierExpr(Token.NoToken, boundVars.Last());
                }
            }

            // Translate all constraints to Dafny expressions, removing any duplicates:
            var constraintsAsExpressions = new List<Expression>();
            var constraintsAsStrings = new HashSet<String>();
            foreach (var constraint in constraints)
            {
                var constraintAsExpression = constraint.AsExpression(allVariableNames);
                if (MutateCSharp.Schemata262.ReplaceBinExprOp_9(71L, constraintAsExpression, null))
                {
                    continue;
                }
                var constraintAsString = constraintAsExpression.ToString();
                if (constraintsAsStrings.Contains(constraintAsString))
                {
                    continue;
                }

                constraintsAsStrings.Add(constraintAsString);
                constraintsAsExpressions.Add(constraintAsExpression);
            }

            // Convert the constraints into one conjunction
            Expression expression = GetCompactConjunction(constraintsAsExpressions);

            if (MutateCSharp.Schemata262.ReplaceBinExprOp_11(90L, () => MutateCSharp.Schemata262.ReplaceBinExprOp_10(76L, constraintsAsExpressions.Count, MutateCSharp.Schemata262.ReplaceNumericConstant_1(72L, 0)), () => MutateCSharp.Schemata262.ReplaceBinExprOp_10(85L, boundVars.Count, MutateCSharp.Schemata262.ReplaceNumericConstant_1(81L, 0))))
            {
                expression = new ExistsExpr(Token.NoToken, RangeToken.NoToken, boundVars, null, expression, null);
            }

            if (MutateCSharp.Schemata262.ReplaceBinExprOp_12(120L, () => (MutateCSharp.Schemata262.ReplaceBinExprOp_11(105L, () => MutateCSharp.Schemata262.ReplaceBinExprOp_2(100L, LoopGuards.Count, MutateCSharp.Schemata262.ReplaceNumericConstant_1(96L, 0)), () => !IsLoopEntryState)), () => MutateCSharp.Schemata262.ReplaceBinExprOp_10(115L, LoopGuards.Count, MutateCSharp.Schemata262.ReplaceNumericConstant_1(111L, 1))))
            {
                Expression loopGuard = new IdentifierExpr(Token.NoToken, LoopGuards[MutateCSharp.Schemata262.ReplaceNumericConstant_1(126L, 0)]);
                for (int i = MutateCSharp.Schemata262.ReplaceNumericConstant_1(130L, 1); MutateCSharp.Schemata262.ReplaceBinExprOp_7(134L, i, LoopGuards.Count); MutateCSharp.Schemata262.ReplacePostfixUnaryExprOp_8(139L, ref i))
                {
                    if (MutateCSharp.Schemata262.ReplaceBinExprOp_11(158L, () => MutateCSharp.Schemata262.ReplaceBinExprOp_5(153L, i, MutateCSharp.Schemata262.ReplaceBinExprOp_13(144L, LoopGuards.Count, MutateCSharp.Schemata262.ReplaceNumericConstant_1(140L, 1))), () => IsLoopEntryState))
                    {
                        continue;
                    }
                    loopGuard = new BinaryExpr(Token.NoToken, BinaryExpr.Opcode.And, loopGuard,
                      new IdentifierExpr(Token.NoToken, LoopGuards[i]));
                }
                expression = new BinaryExpr(Token.NoToken, BinaryExpr.Opcode.Imp, loopGuard, expression);
            }

            if (!IsLoopEntryState)
            {
                return new AssumeStmt(RangeToken.NoToken, expression, null);
            }
            return new UpdateStmt(RangeToken.NoToken, new List<Expression>() { new IdentifierExpr(Token.NoToken, LoopGuards.Last()) },
                new List<AssignmentRhs>() { new ExprRhs(expression) });
        }

        /// <summary>
        /// Initialize the vars list, which stores all variables relevant to
        /// the counterexample except for the bound variables
        /// </summary>
        private void SetupVars()
        {
            var names = Enumerable.Empty<string>();
            foreach (var partialState in Model.States)
            {
                names = names.Concat(partialState.State.Variables);
            }
            names = names.Concat(State.Variables).Distinct().ToList();
            var notDefinitelyAssigned = new HashSet<string>();
            foreach (var name in names.Where(name => name.StartsWith(MutateCSharp.Schemata262.ReplaceStringConstant_0(164L, "defass#"))))
            {
                var val = State.TryGet(name);
                if (MutateCSharp.Schemata262.ReplaceBinExprOp_14(165L, val, null))
                {
                    continue;
                }
                if (val is Model.Boolean { Value: false })
                {
                    notDefinitelyAssigned.Add(name[7..]);
                }
            }
            foreach (var v in names)
            {
                if (MutateCSharp.Schemata262.ReplaceBinExprOp_12(166L, () => !IsUserVariableName(v), () => notDefinitelyAssigned.Contains(v)))
                {
                    continue;
                }
                var val = State.TryGet(v);
                if (MutateCSharp.Schemata262.ReplaceBinExprOp_14(172L, val, null))
                {
                    continue; // This variable has no value in the model, so ignore it.
                }

                var value = PartialValue.Get(val, this);
                initialPartialValues.Add(value);
                var _ = new IdentifierExprConstraint(value, v.Split(MutateCSharp.Schemata262.ReplaceStringConstant_0(173L, "#")).First());
                if (!KnownVariableNames.ContainsKey(value))
                {
                    KnownVariableNames[value] = new List<string>();
                }
                KnownVariableNames[value].Add(v.Split(MutateCSharp.Schemata262.ReplaceStringConstant_0(174L, "#")).First());
            }
        }

        /// <summary>
        /// Return True iff the variable name is referring to a variable that has
        /// a direct analog in Dafny source (i.e. not $Heap, $_Frame, $nw, etc.)
        /// </summary>
        private static bool IsUserVariableName(string name) => MutateCSharp.Schemata262.ReplaceBinExprOp_11(190L, () => !name.Contains(MutateCSharp.Schemata262.ReplaceStringConstant_0(175L, "$")), () => MutateCSharp.Schemata262.ReplaceBinExprOp_15(185L, name.Count(c => MutateCSharp.Schemata262.ReplaceBinExprOp_5(176L, c, '#')), MutateCSharp.Schemata262.ReplaceNumericConstant_1(181L, 1)));

        /// <summary>
        /// Instantiate BoundVariables
        /// </summary>
        private void SetupBoundVars()
        {
            foreach (var f in Model.Model.Functions)
            {
                if (MutateCSharp.Schemata262.ReplaceBinExprOp_16(200L, f.Arity, MutateCSharp.Schemata262.ReplaceNumericConstant_1(196L, 0)))
                {
                    continue;
                }
                int n = f.Name.IndexOf('!');
                if (MutateCSharp.Schemata262.ReplaceBinExprOp_5(209L, n, MutateCSharp.Schemata262.ReplaceNumericConstant_1(205L, -1)))
                {
                    continue;
                }
                var name = f.Name[..n];
                if (MutateCSharp.Schemata262.ReplaceBinExprOp_12(214L, () => !name.Contains('#'), () => name.Contains('$')))
                {
                    continue;
                }

                var value = PartialValue.Get(f.GetConstant(), this);
                initialPartialValues.Add(value);
                var _ = new IdentifierExprConstraint(value, name);
                if (!KnownVariableNames.ContainsKey(value))
                {
                    KnownVariableNames[value] = new();
                }
                KnownVariableNames[value].Add(name);
            }
        }

        public string FullStateName => State.Name;

        private string ShortenedStateName => ShortenName(State.Name, MutateCSharp.Schemata262.ReplaceNumericConstant_1(220L, 20));

        public bool IsInitialState => FullStateName.Equals(InitialStateName);

        public bool StateContainsPosition()
        {
            return StatePositionRegex.Match(ShortenedStateName).Success;
        }

        public int GetLineId()
        {
            var match = StatePositionRegex.Match(ShortenedStateName);
            if (!match.Success)
            {
                throw new ArgumentException(
                  $"state does not contain position: {ShortenedStateName}");
            }
            return int.Parse(match.Groups[MutateCSharp.Schemata262.ReplaceStringConstant_0(224L, "line")].Value);
        }

        public int GetCharId()
        {
            var match = StatePositionRegex.Match(ShortenedStateName);
            if (!match.Success)
            {
                throw new ArgumentException(
                  $"state does not contain position: {ShortenedStateName}");
            }
            return int.Parse(match.Groups[MutateCSharp.Schemata262.ReplaceStringConstant_0(225L, "character")].Value);
        }

        private static string ShortenName(string name, int fnLimit)
        {
            var loc = TryParseSourceLocation(name);
            if (loc != null)
            {
                var fn = loc.Filename;
                int idx = fn.LastIndexOfAny(new[] { '\\', '/' });
                if (MutateCSharp.Schemata262.ReplaceBinExprOp_10(230L, idx, MutateCSharp.Schemata262.ReplaceNumericConstant_1(226L, 0)))
                {
                    fn = fn[(MutateCSharp.Schemata262.ReplaceBinExprOp_3(239L, idx, MutateCSharp.Schemata262.ReplaceNumericConstant_1(235L, 1)))..];
                }
                if (MutateCSharp.Schemata262.ReplaceBinExprOp_10(248L, fn.Length, fnLimit))
                {
                    fn = fn[..fnLimit] + MutateCSharp.Schemata262.ReplaceStringConstant_0(253L, "..");
                }
                var addInfo = loc.AddInfo;
                if (MutateCSharp.Schemata262.ReplaceBinExprOp_17(254L, addInfo, ""))
                {
                    addInfo = MutateCSharp.Schemata262.ReplaceStringConstant_0(255L, ":") + addInfo;
                }
                return $"{fn}({loc.Line},{loc.Column}){addInfo}";
            }
            return name;
        }

        /// <summary>
        /// Parse a string (typically the name of the captured state in Boogie) to
        /// extract a SourceLocation from it. An example of a string to be parsed:
        /// @"c:\users\foo\bar.c(12,10) : random string"
        /// The ": random string" part is optional.
        /// </summary>
        private static SourceLocation? TryParseSourceLocation(string name)
        {
            int par = name.LastIndexOf('(');
            if (MutateCSharp.Schemata262.ReplaceBinExprOp_15(260L, par, MutateCSharp.Schemata262.ReplaceNumericConstant_1(256L, 0)))
            {
                return null;
            }
            // var res = new SourceLocation { Filename = name[..par] };
            var words = name[(MutateCSharp.Schemata262.ReplaceBinExprOp_3(269L, par, MutateCSharp.Schemata262.ReplaceNumericConstant_1(265L, 1)))..]
              .Split(',', ')', ':')
              .Where(x => MutateCSharp.Schemata262.ReplaceBinExprOp_17(278L, x, ""))
              .ToArray();
            if (MutateCSharp.Schemata262.ReplaceBinExprOp_7(283L, words.Length, MutateCSharp.Schemata262.ReplaceNumericConstant_1(279L, 2)))
            {
                return null;
            }
            if (!int.TryParse(words[0], out var line) ||
                !int.TryParse(words[1], out var column))
            {
                return null;
            }
            int colon = name.IndexOf(':', par);
            var res = new SourceLocation(
              name[..par],
        MutateCSharp.Schemata262.ReplaceBinExprOp_10(292L, colon, MutateCSharp.Schemata262.ReplaceNumericConstant_1(288L, 0)) ? name[(MutateCSharp.Schemata262.ReplaceBinExprOp_3(301L, colon, MutateCSharp.Schemata262.ReplaceNumericConstant_1(297L, 1)))..].Trim() : "",
              line,
              column);
            return res;
        }

        public class SourceLocation
        {
            public readonly string Filename;
            public readonly string AddInfo;
            public readonly int Line;
            public readonly int Column;

            public SourceLocation(string filename, string addInfo, int line, int column)
            {
                Filename = filename;
                AddInfo = addInfo;
                Line = line;
                Column = column;
            }
        }

    }
}