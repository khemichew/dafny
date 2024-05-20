//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata420
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT420");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.PreType argument1, Microsoft.Dafny.PreType argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_4(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
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

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, Microsoft.Dafny.TopLevelDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public
      class EqualityConstraint : OptionalErrorPreTypeConstraint
    {
        public PreType A;
        public PreType B;

        public EqualityConstraint(PreType a, PreType b, IToken tok, string msgFormat, PreTypeConstraint baseError = null, bool reportErrors = true)
          : base(tok, msgFormat, baseError, reportErrors)
        {
            A = a;
            B = b;
        }

        public override string ErrorMessage()
        {
            return string.Format(ErrorFormatString, A, B);
        }

        /// <summary>
        /// Constrain "A" to be the same type as "B".
        /// Because this method makes calls that eventually call constraints.DirectionalBounds, it should be
        /// called only when constraints.unnormalizedSubtypeConstraints is in a stable state. That means,
        /// in particular, that this method cannot be called in middle of constraints.ApplySubtypeConstraints.
        /// </summary>
        public IEnumerable<EqualityConstraint> Apply(PreTypeConstraints constraints)
        {
            var a = A.NormalizeWrtScope();
            var b = B.NormalizeWrtScope();
            if (MutateCSharp.Schemata420.ReplaceBinExprOp_0(1L, a, b))
            {
                // we're already there
            }
            else if (a is PreTypeProxy pa && !b.Contains(pa, MutateCSharp.Schemata420.ReplaceNumericConstant_1(2L, 1), new HashSet<PreTypeProxy>(), constraints, MutateCSharp.Schemata420.ReplaceNumericConstant_1(6L, 0)))
            {
                pa.Set(b);
            }
            else if (b is PreTypeProxy pb && !a.Contains(pb, MutateCSharp.Schemata420.ReplaceNumericConstant_1(10L, 1), new HashSet<PreTypeProxy>(), constraints, MutateCSharp.Schemata420.ReplaceNumericConstant_1(14L, 0)))
            {
                pb.Set(a);
            }
            else if (a is DPreType da && b is DPreType db && MutateCSharp.Schemata420.ReplaceBinExprOp_2(18L, da.Decl, db.Decl))
            {
                Contract.Assert(da.Arguments.Count == db.Arguments.Count);
                for (var i = MutateCSharp.Schemata420.ReplaceNumericConstant_1(19L, 0); MutateCSharp.Schemata420.ReplaceBinExprOp_3(23L, i, da.Arguments.Count); MutateCSharp.Schemata420.ReplacePostfixUnaryExprOp_4(28L, ref i))
                {
                    // TODO: should the error message in the following line be more specific?
                    yield return new EqualityConstraint(da.Arguments[i], db.Arguments[i], tok, ErrorFormatString, null, ReportErrors);
                }
            }
            else if (ReportErrors)
            {
                constraints.PreTypeResolver.ReportError(tok, ErrorFormatString, a, b);
            }

            yield break;
        }

    }
}
