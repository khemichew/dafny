//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata426
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT426");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_9(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.PreType> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_8(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.TypeParameter.TPVariance argument1, Microsoft.Dafny.TypeParameter.TPVariance argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_6(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
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

        internal static bool ReplaceBinExprOp_0(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.DPreType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class SubtypeConstraint : OptionalErrorPreTypeConstraint
    {
        public readonly PreType Super;
        public readonly PreType Sub;

        public override string ErrorMessage()
        {
            return string.Format(ErrorFormatString, Super, Sub);
        }

        public SubtypeConstraint(PreType super, PreType sub, IToken tok, string errorFormatString, PreTypeConstraint baseError = null, bool reportErrors = true)
          : base(tok, errorFormatString, baseError, reportErrors)
        {
            Contract.Assert(super != null);
            Contract.Assert(sub != null);
            Super = super.Normalize();
            Sub = sub.Normalize();
        }

        public SubtypeConstraint(PreType super, PreType sub, IToken tok, Func<string> errorFormatStringProducer, bool reportErrors = true)
          : base(tok, errorFormatStringProducer, reportErrors)
        {
            Contract.Assert(super != null);
            Contract.Assert(sub != null);
            Super = super.Normalize();
            Sub = sub.Normalize();
        }

        public SubtypeConstraint Normalize()
        {
            var super = Super.Normalize();
            var sub = Sub.Normalize();
            if (MutateCSharp.Schemata426.ReplaceBinExprOp_0(1L, () => object.ReferenceEquals(super, Super), () => object.ReferenceEquals(sub, Sub)))
            {
                return this;
            }
            else
            {
                return new SubtypeConstraint(super, sub, Token.NoToken, ErrorFormatString, null, ReportErrors);
            }

            return default;
        }

        public bool Apply(PreTypeConstraints constraints)
        {
            var super = Super.NormalizeWrtScope();
            var sub = Sub.NormalizeWrtScope();
            var ptSuper = super as DPreType;
            var ptSub = sub as DPreType;
            // In the following explanations, D is assumed to be a type with three
            // type parameters, being co-variant, contra-variant, and non-variant, respectively.
            if (MutateCSharp.Schemata426.ReplaceBinExprOp_0(9L, () => MutateCSharp.Schemata426.ReplaceBinExprOp_1(7L, ptSuper, null), () => MutateCSharp.Schemata426.ReplaceBinExprOp_1(8L, ptSub, null)))
            {
                // We're looking at D<a,b,c> :> E<x,y>
                // If E<x,y> can be rewritten as D<f(x,y), g(x,y), h(x,y)>, then
                //     Constrain a :> f(x,y)
                //     Constrain g(x,y) :> b
                //     Constrain c == h(x,y)
                // else report an error
                var arguments = constraints.GetTypeArgumentsForSuperType(ptSuper.Decl, ptSub, MutateCSharp.Schemata426.ReplaceBooleanConstant_2(15L, false));
                if (MutateCSharp.Schemata426.ReplaceBinExprOp_3(16L, arguments, null))
                {
                    Contract.Assert(arguments.Count == ptSuper.Decl.TypeArgs.Count);
                    ConstrainTypeArguments(ptSuper.Decl.TypeArgs, ptSuper.Arguments, arguments, tok, this, constraints);
                    return MutateCSharp.Schemata426.ReplaceBooleanConstant_2(17L, true);
                }
                else if (ReportErrors)
                {
                    constraints.PreTypeResolver.ReportError(tok, ErrorMessage());
                    return MutateCSharp.Schemata426.ReplaceBooleanConstant_2(18L, true);
                }
            }
            else if (MutateCSharp.Schemata426.ReplaceBinExprOp_1(19L, ptSuper, null))
            {
                // We're looking at D<a,b,c> :> sub
                // If the head of D has no proper subtypes (i.e., it is not a trait), then
                //     Introduce alpha, beta
                //     Constrain sub == D<alpha, beta, c>
                //     Constrain a :> alpha
                //     Constrain beta :> b
                // else do nothing for now
                if (ptSuper.Decl is not TraitDecl)
                {
                    var arguments = CreateProxiesForTypesAccordingToVariance(tok, ptSuper.Decl.TypeArgs, ptSuper.Arguments, MutateCSharp.Schemata426.ReplaceBooleanConstant_2(20L, false), ReportErrors, constraints);
                    var pt = new DPreType(ptSuper.Decl, arguments);
                    constraints.AddEqualityConstraint(pt, sub, tok, ErrorFormatString, null, ReportErrors);
                    return MutateCSharp.Schemata426.ReplaceBooleanConstant_2(21L, true);
                }
            }
            else if (MutateCSharp.Schemata426.ReplaceBinExprOp_1(22L, ptSub, null))
            {
                // We're looking at super :> D<a,b,c>
                // If the head of D has no proper supertypes (i.e., D has no parent traits), then
                //     Introduce alpha, beta
                //     Constrain super == D<alpha, beta, c>
                //     Constrain alpha :> a
                //     Constrain b :> beta
                // else do nothing for now
                if (PreTypeResolver.HasTraitSupertypes(ptSub))
                {
                    // there are parent traits
                }
                else
                {
                    var arguments = CreateProxiesForTypesAccordingToVariance(tok, ptSub.Decl.TypeArgs, ptSub.Arguments, MutateCSharp.Schemata426.ReplaceBooleanConstant_2(23L, true), ReportErrors, constraints);
                    var pt = new DPreType(ptSub.Decl, arguments);
                    constraints.AddEqualityConstraint(super, pt, tok, ErrorFormatString, null, ReportErrors);
                    return MutateCSharp.Schemata426.ReplaceBooleanConstant_2(24L, true);
                }
            }
            else
            {
                // do nothing for now
            }
            return MutateCSharp.Schemata426.ReplaceBooleanConstant_2(25L, false);
        }

        /// <summary>
        /// For every non-variant parameters[i], constrain superArguments[i] == subArguments[i].
        /// For every co-variant parameters[i], constrain superArguments[i] :> subArguments[i].
        /// For every contra-variant parameters[i], constrain subArguments[i] :> superArguments[i].
        /// </summary>
        static void ConstrainTypeArguments(List<TypeParameter> parameters, List<PreType> superArguments, List<PreType> subArguments, IToken tok,
          OptionalErrorPreTypeConstraint baseError, PreTypeConstraints constraints)
        {
            Contract.Requires(parameters.Count == superArguments.Count && superArguments.Count == subArguments.Count);

            for (var i = MutateCSharp.Schemata426.ReplaceNumericConstant_4(26L, 0); MutateCSharp.Schemata426.ReplaceBinExprOp_5(30L, i, parameters.Count); MutateCSharp.Schemata426.ReplacePostfixUnaryExprOp_6(35L, ref i))
            {
                var tp = parameters[i];
                var arg0 = superArguments[i];
                var arg1 = subArguments[i];
                if (MutateCSharp.Schemata426.ReplaceBinExprOp_7(36L, tp.Variance, TypeParameter.TPVariance.Non))
                {
                    constraints.AddEqualityConstraint(arg0, arg1, tok,
                      $"non-variant type parameter '{tp.Name}' would require {{0}} = {{1}}", baseError, baseError.ReportErrors);
                }
                else if (MutateCSharp.Schemata426.ReplaceBinExprOp_7(37L, tp.Variance, TypeParameter.TPVariance.Co))
                {
                    constraints.AddSubtypeConstraint(arg0, arg1, tok,
                      $"covariant type parameter '{tp.Name}' would require {{0}} :> {{1}}", baseError, baseError.ReportErrors);
                }
                else
                {
                    constraints.AddSubtypeConstraint(arg1, arg0, tok,
                      $"contravariant type parameter '{tp.Name}' would require {{0}} :> {{1}}", baseError, baseError.ReportErrors);
                }
            }
        }

        /// <summary>
        /// For the given arguments: [a0, a1, a2, ...]
        /// use the variance given by parameters: [p0, p1, p2, ...]
        /// to return a list: [t0, t1, t2, ...]
        /// where for each i,
        ///   - if pi is Non, then ai
        ///   - else if (pi is Co) == proxiesAreSupertypes, then a new proxy constrained by:  proxy :> ai
        ///   - else a new proxy constrained by:  ai :> proxy
        /// </summary>
        static List<PreType> CreateProxiesForTypesAccordingToVariance(IToken tok, List<TypeParameter> parameters, List<PreType> arguments,
          bool proxiesAreSupertypes, bool reportErrors, PreTypeConstraints state)
        {
            Contract.Requires(parameters.Count == arguments.Count);

            if (parameters.All(tp => MutateCSharp.Schemata426.ReplaceBinExprOp_7(38L, tp.Variance, TypeParameter.TPVariance.Non)))
            {
                // special case this common situation
                return arguments;
            }
            var newArgs = new List<PreType>();
            for (var i = MutateCSharp.Schemata426.ReplaceNumericConstant_4(39L, 0); MutateCSharp.Schemata426.ReplaceBinExprOp_5(43L, i, parameters.Count); MutateCSharp.Schemata426.ReplacePostfixUnaryExprOp_6(48L, ref i))
            {
                var tp = parameters[i];
                if (MutateCSharp.Schemata426.ReplaceBinExprOp_7(49L, tp.Variance, TypeParameter.TPVariance.Non))
                {
                    newArgs.Add(arguments[i]);
                }
                else
                {
                    var co = MutateCSharp.Schemata426.ReplaceBinExprOp_7(50L, tp.Variance, TypeParameter.TPVariance.Co) ? MutateCSharp.Schemata426.ReplaceStringConstant_8(51L, "co") : MutateCSharp.Schemata426.ReplaceStringConstant_8(52L, "contra");
                    var proxy = state.PreTypeResolver.CreatePreTypeProxy($"type used in {co}variance constraint");
                    newArgs.Add(proxy);
                    if (MutateCSharp.Schemata426.ReplaceBinExprOp_9(54L, () => (MutateCSharp.Schemata426.ReplaceBinExprOp_7(53L, tp.Variance, TypeParameter.TPVariance.Co)), () => proxiesAreSupertypes))
                    {
                        state.AddSubtypeConstraint(proxy, arguments[i], tok, MutateCSharp.Schemata426.ReplaceStringConstant_8(60L, "bad"), null, reportErrors); // TODO: improve error message
                    }
                    else
                    {
                        state.AddSubtypeConstraint(arguments[i], proxy, tok, MutateCSharp.Schemata426.ReplaceStringConstant_8(61L, "bad"), null, reportErrors); // TODO: improve error message
                    }
                }
            }
            return newArgs;
        }
    }

}
