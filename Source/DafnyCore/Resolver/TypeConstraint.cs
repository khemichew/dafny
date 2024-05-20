//-----------------------------------------------------------------------------
//
// Copyright (C) Microsoft Corporation.  All Rights Reserved.
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Diagnostics.Contracts;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis.CSharp.Syntax;
namespace MutateCSharp
{
    internal class Schemata440
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT440");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public record TypeConstraint(Type Super, Type Sub, TypeConstraint.ErrorMsg ErrMsg, bool KeepConstraints)
    {
        public static void ReportErrors(ModuleResolver resolver, ErrorReporter reporter)
        {
            Contract.Requires(reporter != null);
            foreach (var err in resolver.TypeConstraintErrorsToBeReported)
            {
                err.ReportAsError(reporter);
            }
            resolver.TypeConstraintErrorsToBeReported.Clear();
        }
        public abstract class ErrorMsg
        {
            public abstract IToken Tok { get; }

            bool reported;
            public void FlagAsError(ModuleResolver resolver)
            {
                if (resolver.Options.Get(CommonOptionBag.TypeInferenceDebug))
                {
                    resolver.Options.OutputWriter.WriteLine($"DEBUG: flagging error: {ApproximateErrorMessage()}");
                }
                resolver.TypeConstraintErrorsToBeReported.Add(this);
            }
            internal void ReportAsError(ErrorReporter reporter)
            {
                Contract.Requires(reporter != null);
                if (!reported)
                {  // this "reported" bit is checked only for the top-level message, but this message and all nested ones get their "reported" bit set to "true" as a result
                    Reporting(reporter, "");
                }
            }
            private void Reporting(ErrorReporter reporter, string suffix)
            {
                Contract.Requires(reporter != null);
                Contract.Requires(suffix != null);

                if (this is ErrorMsgWithToken)
                {
                    var err = (ErrorMsgWithToken)this;
                    Contract.Assert(err.Tok != null);
                    reporter.Error(MessageSource.Resolver, err.Tok, err.Msg + suffix, RemoveAmbiguity(err.MsgArgs));
                }
                else
                {
                    var err = (ErrorMsgWithBase)this;
                    err.BaseMsg.Reporting(reporter, MutateCSharp.Schemata440.ReplaceStringConstant_0(1L, " (") + string.Format(err.Msg, RemoveAmbiguity(err.MsgArgs)) + MutateCSharp.Schemata440.ReplaceStringConstant_0(2L, ")") + suffix);
                }
                reported = MutateCSharp.Schemata440.ReplaceBooleanConstant_1(3L, true);
            }
            protected object[] RemoveAmbiguity(object[] msgArgs)
            {
                var renderedInterpolated = new HashSet<string>();
                var ambiguity = MutateCSharp.Schemata440.ReplaceBooleanConstant_1(4L, false);
                foreach (var x in msgArgs)
                {
                    var str = x.ToString();
                    if (renderedInterpolated.Contains(str))
                    {
                        ambiguity = MutateCSharp.Schemata440.ReplaceBooleanConstant_1(5L, true);
                    }

                    renderedInterpolated.Add(str);
                }
                if (ambiguity)
                {
                    return msgArgs.Select(x =>
                      (object)(x is UserDefinedType udt ? udt.FullName : x.ToString())
                    ).ToArray();
                }
                return msgArgs;
            }

            protected abstract string ApproximateErrorMessage();
        }
        public class ErrorMsgWithToken : ErrorMsg
        {
            readonly IToken tok;
            public override IToken Tok => tok;
            readonly string msg;
            public virtual string Msg => msg;
            public readonly object[] MsgArgs;
            public ErrorMsgWithToken(IToken tok, string msg, params object[] msgArgs)
            {
                Contract.Requires(tok != null);
                Contract.Requires(msg != null);
                Contract.Requires(msgArgs != null);
                this.tok = tok;
                this.msg = msg;
                this.MsgArgs = msgArgs;
            }

            protected override string ApproximateErrorMessage() => string.Format(Msg, MsgArgs);
        }
        public class ErrorMsgWithBase : ErrorMsg
        {
            public override IToken Tok
            {
                get { return BaseMsg.Tok; }
            }

            public readonly ErrorMsg BaseMsg;
            public readonly string Msg;
            public readonly object[] MsgArgs;
            public ErrorMsgWithBase(ErrorMsg baseMsg, string msg, params object[] msgArgs)
            {
                Contract.Requires(baseMsg != null);
                Contract.Requires(msg != null);
                Contract.Requires(msgArgs != null);
                BaseMsg = baseMsg;
                Msg = msg;
                MsgArgs = msgArgs;
            }

            protected override string ApproximateErrorMessage() => string.Format(Msg, MsgArgs);
        }
        public void FlagAsError(ModuleResolver resolver)
        {
            ErrMsg.FlagAsError(resolver);
        }
    }
}
