//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

using System;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata418
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT418");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.PreTypeConstraint argument1, object argument2)
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

    }
}

namespace Microsoft.Dafny
{
    public abstract class PreTypeConstraint
    {
        public readonly IToken tok;

        // exactly one of "errorFormatString" and "errorFormatStringProducer" is non-null
        private readonly string errorFormatString;
        private readonly Func<string> errorFormatStringProducer;

        public string ErrorFormatString => errorFormatString ?? errorFormatStringProducer();

        public abstract string ErrorMessage();

        public PreTypeConstraint(IToken tok, string errorFormatString, PreTypeConstraint baseError = null)
        {
            Contract.Requires(tok != null);
            Contract.Requires(errorFormatString != null);
            this.tok = tok;
            if (MutateCSharp.Schemata418.ReplaceBinExprOp_0(1L, baseError, null))
            {
                this.errorFormatString = errorFormatString;
            }
            else
            {
                this.errorFormatStringProducer = () => baseError.ErrorMessage() + MutateCSharp.Schemata418.ReplaceStringConstant_1(2L, " (") + errorFormatString + MutateCSharp.Schemata418.ReplaceStringConstant_1(3L, ")");
            }
        }

        public PreTypeConstraint(IToken tok, Func<string> errorFormatStringProducer)
        {
            Contract.Requires(tok != null);
            Contract.Requires(errorFormatStringProducer != null);
            this.tok = tok;
            this.errorFormatStringProducer = errorFormatStringProducer;
        }
    }

    public abstract class OptionalErrorPreTypeConstraint : PreTypeConstraint
    {
        public readonly bool ReportErrors;
        public OptionalErrorPreTypeConstraint(IToken tok, string errorFormatString, PreTypeConstraint baseError, bool reportErrors)
          : base(tok, errorFormatString, baseError)
        {
            ReportErrors = reportErrors;
        }

        public OptionalErrorPreTypeConstraint(IToken tok, Func<string> errorFormatStringProducer, bool reportErrors)
          : base(tok, errorFormatStringProducer)
        {
            ReportErrors = reportErrors;
        }
    }
}
