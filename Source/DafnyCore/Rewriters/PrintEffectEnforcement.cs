// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT

using System.Diagnostics.Contracts;
using Microsoft.Boogie;
using Bpl = Microsoft.Boogie;
using static Microsoft.Dafny.RewriterErrors;
namespace MutateCSharp
{
    internal class Schemata458
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT458");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceNumericConstant_6(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_4(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_2(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    // ------------------- PrintEffectEnforcement -------------------

    public class PrintEffectEnforcement : IRewriter
    {
        internal PrintEffectEnforcement(ErrorReporter reporter) : base(reporter)
        {
            Contract.Requires(reporter != null);
        }

        internal override void PostDecreasesResolve(ModuleDefinition m)
        {
            foreach (var decl in m.TopLevelDecls)
            {
                if (decl is IteratorDecl iter)
                {
                    var hasPrintAttribute = HasPrintAttribute(iter.Attributes);
                    if (MutateCSharp.Schemata458.ReplaceBinExprOp_1(2L, () => !hasPrintAttribute, () => MutateCSharp.Schemata458.ReplaceBinExprOp_0(1L, iter.Body, null)))
                    {
                        if (Reporter.Options.EnforcePrintEffects)
                        {
                            iter.Body.Body.ForEach(stmt => CheckNoPrintEffects(stmt, iter));
                        }
                    }
                }
                else if (decl is TopLevelDeclWithMembers cl)
                {
                    foreach (var member in cl.Members)
                    {
                        var hasPrintAttribute = HasPrintAttribute(member.Attributes);
                        if (member is Function f)
                        {
                            if (hasPrintAttribute)
                            {
                                ReportError(ErrorId.rw_print_attribute_forbidden_on_functions, member.tok, MutateCSharp.Schemata458.ReplaceStringConstant_2(8L, ":print attribute is not allowed on functions"));
                            }
                            if (MutateCSharp.Schemata458.ReplaceBinExprOp_1(10L, () => MutateCSharp.Schemata458.ReplaceBinExprOp_3(9L, f.ByMethodDecl, null), () => Reporter.Options.EnforcePrintEffects))
                            {
                                f.ByMethodDecl.Body.Body.ForEach(stmt => CheckNoPrintEffects(stmt, f.ByMethodDecl));
                            }
                        }
                        else if (member is Method method)
                        {
                            if (hasPrintAttribute)
                            {
                                if (member.IsGhost)
                                {
                                    ReportError(ErrorId.rw_print_attribute_forbidden_on_ghost_methods, member.tok, MutateCSharp.Schemata458.ReplaceStringConstant_2(16L, ":print attribute is not allowed on ghost methods"));
                                }
                                else if (MutateCSharp.Schemata458.ReplaceBinExprOp_1(19L, () => MutateCSharp.Schemata458.ReplaceBinExprOp_3(17L, method.OverriddenMethod, null), () => !HasPrintAttribute(method.OverriddenMethod.Attributes, MutateCSharp.Schemata458.ReplaceBooleanConstant_4(18L, false))))
                                {
                                    ReportError(ErrorId.rw_override_must_preserve_printing, member.tok,
                  MutateCSharp.Schemata458.ReplaceStringConstant_2(25L, "not allowed to override a non-printing method with a possibly printing method ('{0}')"), method.Name);
                                }
                            }
                            else if (MutateCSharp.Schemata458.ReplaceBinExprOp_1(27L, () => !member.IsGhost, () => MutateCSharp.Schemata458.ReplaceBinExprOp_0(26L, method.Body, null)))
                            {
                                if (Reporter.Options.EnforcePrintEffects)
                                {
                                    method.Body.Body.ForEach(stmt => CheckNoPrintEffects(stmt, method));
                                }
                            }
                        }
                    }
                }
            }
        }

        bool HasPrintAttribute(Attributes attrs, bool checkParameters = true)
        {
            var printAttribute = Attributes.Find(attrs, MutateCSharp.Schemata458.ReplaceStringConstant_2(33L, "print"));
            if (MutateCSharp.Schemata458.ReplaceBinExprOp_1(50L, () => MutateCSharp.Schemata458.ReplaceBinExprOp_1(35L, () => checkParameters, () => MutateCSharp.Schemata458.ReplaceBinExprOp_5(34L, printAttribute, null)), () => MutateCSharp.Schemata458.ReplaceBinExprOp_7(45L, printAttribute.Args.Count, MutateCSharp.Schemata458.ReplaceNumericConstant_6(41L, 0))))
            {
                ReportError(ErrorId.rw_print_attribute_takes_no_arguments, printAttribute.Args[MutateCSharp.Schemata458.ReplaceNumericConstant_6(56L, 0)].tok, MutateCSharp.Schemata458.ReplaceStringConstant_2(60L, ":print attribute does not take any arguments"));
            }
            return MutateCSharp.Schemata458.ReplaceBinExprOp_5(61L, printAttribute, null);
        }

        private void CheckNoPrintEffects(Statement stmt, IMethodCodeContext codeContext)
        {
            if (stmt is PrintStmt)
            {
                var method = codeContext as Method;
                if (MutateCSharp.Schemata458.ReplaceBinExprOp_1(63L, () => MutateCSharp.Schemata458.ReplaceBinExprOp_3(62L, method, null), () => method.IsByMethod))
                {
                    ReportError(ErrorId.rw_no_print_in_function_by_method, stmt.Tok, MutateCSharp.Schemata458.ReplaceStringConstant_2(69L, "a function-by-method is not allowed to use print statements"));
                }
                else
                {
                    ReportError(ErrorId.rw_print_attribute_required_to_print, stmt.Tok,
          MutateCSharp.Schemata458.ReplaceStringConstant_2(70L, "to use a print statement, the enclosing {0} must be marked with {{:print}}"), method?.WhatKind ?? ((IteratorDecl)codeContext).WhatKind);
                }
            }
            else if (stmt is CallStmt call)
            {
                if (HasPrintAttribute(call.Method.Attributes, MutateCSharp.Schemata458.ReplaceBooleanConstant_4(71L, false)))
                {
                    var method = codeContext as Method;
                    if (MutateCSharp.Schemata458.ReplaceBinExprOp_1(73L, () => MutateCSharp.Schemata458.ReplaceBinExprOp_3(72L, method, null), () => method.IsByMethod))
                    {
                        ReportError(ErrorId.rw_function_by_method_may_not_call_printing_method, stmt.Tok, MutateCSharp.Schemata458.ReplaceStringConstant_2(79L, "a function-by-method is not allowed to call a method with print effects"));
                    }
                    else
                    {
                        ReportError(ErrorId.rw_must_be_print_to_call_printing_method, stmt.Tok,
            MutateCSharp.Schemata458.ReplaceStringConstant_2(80L, "to call a method with print effects, the enclosing {0} must be marked with {{:print}}"),
                          method?.WhatKind ?? ((IteratorDecl)codeContext).WhatKind);
                    }
                }
            }
            stmt.SubStatements.ForEach(s => CheckNoPrintEffects(s, codeContext));
        }
    }
}
