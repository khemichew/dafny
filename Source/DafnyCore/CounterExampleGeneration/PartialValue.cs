// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
#nullable enable

using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Microsoft.Boogie;
namespace MutateCSharp
{
    internal class Schemata263
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT263");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_8(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.PartialState argument1, Microsoft.Dafny.PartialState argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.PartialValue argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceNumericConstant_3(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.LiteralExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.DatatypeValueConstraint argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{

    /// <summary>
    /// Each PartialValue corresponds to an Element in the counterexample model returned by Boogie and represents a
    /// Dafny value about which we might have limited information (e.g. a sequence of which we only know one element)
    /// </summary>
    public class PartialValue
    {

        public readonly Model.Element Element; // the element in the counterexample model associated with the value
        public readonly List<Constraint> Constraints; // constraints describing this value
        public readonly PartialState state; // corresponding state in the counterexample model
        private readonly Type type; // Dafny type associated with the value
        private bool haveExpanded;

        /// <summary>
        /// This factory method ensures we don't create duplicate partial value objects for the same element and state in the
        /// counterexample model
        /// </summary>
        public static PartialValue Get(Model.Element element, PartialState state)
        {
            if (state.AllPartialValues.TryGetValue(element, out var value))
            {
                return value;
            }

            return new PartialValue(element, state);
        }

        private PartialValue(Model.Element element, PartialState state)
        {
            Element = element;
            this.state = state;
            Constraints = new();
            haveExpanded = MutateCSharp.Schemata263.ReplaceBooleanConstant_0(1L, false);
            state.AllPartialValues[element] = this;
            type = state.Model.GetFormattedDafnyType(element);
            var _ = new TypeTestConstraint(this, type);
            state.Model.AddTypeConstraints(this);
        }

        /// <summary>
        /// Return all partial values that appear in any of the constraints describing this element
        /// </summary>
        public IEnumerable<PartialValue> GetRelatedValues()
        {
            var relatedValues = new HashSet<PartialValue>() { this };
            if (!haveExpanded)
            {
                state.Model.GetExpansion(state, this);
                haveExpanded = MutateCSharp.Schemata263.ReplaceBooleanConstant_0(2L, true);
            }

            foreach (var constraint in Constraints)
            {
                foreach (var value in constraint.ReferencedValues)
                {
                    if (!relatedValues.Contains(value))
                    {
                        relatedValues.Add(value);
                        yield return value;
                    }
                }

                if (constraint is DefinitionConstraint definitionConstraint &&
                    !relatedValues.Contains(definitionConstraint.DefinedValue))
                {
                    relatedValues.Add(definitionConstraint.DefinedValue);
                    yield return definitionConstraint.DefinedValue;
                }
            }

            yield break;
        }

        public bool Nullable => Constraints.OfType<TypeTestConstraint>()
          .Any(test => test.Type is UserDefinedType userDefinedType && userDefinedType.Name.EndsWith(MutateCSharp.Schemata263.ReplaceStringConstant_1(3L, "?")));

        public Type Type => type;

        public string PrimitiveLiteral
        {
            get
            {
                return Constraints.OfType<LiteralExprConstraint>()
                  .Select(literal => literal.LiteralExpr.ToString()).FirstOrDefault() ?? "";
            }
        }

        public Dictionary<string, PartialValue> Fields()
        {
            var fields = new Dictionary<string, PartialValue>();
            foreach (var memberSelectExpr in Constraints.OfType<MemberSelectExprConstraint>()
                       .Where(constraint => Equals(constraint.Obj, this)))
            {
                fields[memberSelectExpr.MemberName] = memberSelectExpr.DefinedValue;
            }

            return fields;
        }

        public IEnumerable<PartialValue> UnnamedDestructors()
        {
            var datatypeValue = Constraints.OfType<DatatypeValueConstraint>()
              .FirstOrDefault(constraint => Equals(constraint.DefinedValue, this));
            if (MutateCSharp.Schemata263.ReplaceBinExprOp_2(4L, datatypeValue, null))
            {
                foreach (var destructor in datatypeValue.UnnamedDestructors)
                {
                    yield return destructor;
                }
            }

            yield break;
        }

        public IEnumerable<PartialValue> SetElements()
        {
            return Constraints.OfType<ContainmentConstraint>()
              .Where(containment => Equals(containment.Set, this))
              .Select(containment => containment.Element);
        }

        public string DatatypeConstructorName()
        {
            return Constraints.OfType<DatatypeConstructorCheckConstraint>()
              .Select(constructorCheck => constructorCheck.ConstructorName).FirstOrDefault() ?? "";
        }

        public IEnumerable<(PartialValue Key, PartialValue Value)> Mappings()
        {
            foreach (var mapping in Constraints.OfType<MapSelectExprConstraint>().Where(constraint => Equals(constraint.Map, this)))
            {
                yield return new(mapping.Key, mapping.DefinedValue);
            }

            yield break;
        }

        public int? Cardinality()
        {
            if (Constraints.OfType<LiteralExprConstraint>().Any(constraint =>
                  (constraint.LiteralExpr is DisplayExpression displayExpression && !displayExpression.SubExpressions.Any()) ||
                  (constraint.LiteralExpr is MapDisplayExpr mapDisplayExpr && !mapDisplayExpr.Elements.Any())))
            {
                return MutateCSharp.Schemata263.ReplaceNumericConstant_3(5L, 0);
            }

            var cardinality = Constraints.OfType<CardinalityConstraint>()
              .FirstOrDefault(constraint => Equals(constraint.Collection, this))?.DefinedValue;
            if (MutateCSharp.Schemata263.ReplaceBinExprOp_4(9L, cardinality, null))
            {
                return MutateCSharp.Schemata263.ReplaceNumericConstant_3(10L, -1);
            }

            var cardinalityLiteral =
              cardinality.Constraints.OfType<LiteralExprConstraint>().FirstOrDefault()?.LiteralExpr as LiteralExpr;
            if (MutateCSharp.Schemata263.ReplaceBinExprOp_5(14L, cardinalityLiteral, null))
            {
                return MutateCSharp.Schemata263.ReplaceNumericConstant_3(15L, -1);
            }

            if (cardinalityLiteral.Value is not BigInteger bigInteger ||
                !bigInteger.LessThanOrEquals(new BigInteger(int.MaxValue)))
            {
                return MutateCSharp.Schemata263.ReplaceNumericConstant_3(19L, -1);
            }

            return (int)bigInteger;
        }


        public PartialValue? this[int i]
        {
            get
            {
                foreach (var seqSelectConstraint in Constraints.OfType<SeqSelectExprWithLiteralConstraint>()
                           .Where(constraint => Equals(constraint.Seq, this)))
                {
                    if (MutateCSharp.Schemata263.ReplaceBinExprOp_6(23L, seqSelectConstraint.Index.ToString(), i.ToString()))
                    {
                        return seqSelectConstraint.DefinedValue;
                    }
                }

                foreach (var seqSelectConstraint in Constraints.OfType<SeqSelectExprConstraint>()
                           .Where(constraint => Equals(constraint.Seq, this)))
                {
                    var indexLiteral = seqSelectConstraint.Index.Constraints.OfType<LiteralExprConstraint>().FirstOrDefault()
                      ?.LiteralExpr;
                    if (MutateCSharp.Schemata263.ReplaceBinExprOp_8(26L, () => MutateCSharp.Schemata263.ReplaceBinExprOp_7(24L, indexLiteral, null), () => MutateCSharp.Schemata263.ReplaceBinExprOp_6(25L, indexLiteral.ToString(), i.ToString())))
                    {
                        return seqSelectConstraint.DefinedValue;
                    }
                }

                return null;
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is PartialValue other && other.Element == Element && MutateCSharp.Schemata263.ReplaceBinExprOp_9(32L, other.state, state);
        }

        public override int GetHashCode()
        {
            return Element.GetHashCode();
        }

    }
}