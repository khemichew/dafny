//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using ResolutionContext = Microsoft.Dafny.ResolutionContext;
namespace MutateCSharp
{
    internal class Schemata425
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT425");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_9(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.ExtendedPattern> argument1, object argument2)
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

        internal static int ReplacePostfixUnaryExprOp_8(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBinExprOp_4(long mutantId, string argument1, string argument2)
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

    }
}

namespace Microsoft.Dafny
{
    public partial class PreTypeResolver
    {

        void ResolveNestedMatchStmt(NestedMatchStmt stmt, ResolutionContext resolutionContext)
        {
            ResolveExpression(stmt.Source, resolutionContext);

            foreach (var mc in stmt.Cases)
            {
                ResolveAttributes(mc, resolutionContext, MutateCSharp.Schemata425.ReplaceBooleanConstant_0(1L, false));

                scope.PushMarker();
                ResolveExtendedPattern(stmt.Source.tok, mc.Pat, stmt.Source.PreType, MutateCSharp.Schemata425.ReplaceBooleanConstant_0(2L, false), resolutionContext);

                dominatingStatementLabels.PushMarker();
                mc.Body.ForEach(ss => ResolveStatementWithLabels(ss, resolutionContext));
                dominatingStatementLabels.PopMarker();

                scope.PopMarker();
            }
        }

        void ResolveNestedMatchExpr(NestedMatchExpr expr, ResolutionContext resolutionContext)
        {
            ResolveExpression(expr.Source, resolutionContext);

            expr.PreType = CreatePreTypeProxy(MutateCSharp.Schemata425.ReplaceStringConstant_1(3L, "result of match expression"));
            foreach (var mc in expr.Cases)
            {
                ResolveAttributes(mc, resolutionContext, MutateCSharp.Schemata425.ReplaceBooleanConstant_0(4L, false));

                scope.PushMarker();
                ResolveExtendedPattern(expr.Source.tok, mc.Pat, expr.Source.PreType, MutateCSharp.Schemata425.ReplaceBooleanConstant_0(5L, false), resolutionContext);

                ResolveExpression(mc.Body, resolutionContext);
                AddSubtypeConstraint(expr.PreType, mc.Body.PreType, mc.Body.tok,
        MutateCSharp.Schemata425.ReplaceStringConstant_1(6L, "type of case bodies do not agree (found {1}, previous types {0})"));

                scope.PopMarker();
            }
        }

        /// <summary>
        /// Try to make sure "preType" is not an unresolved proxy. If it is a proxy, then partially solve type constraints in hopes
        /// of resolving it. If that still doesn't resolve it, then report and error and return "false".
        /// Otherwise (that is, upon success), return "true".
        /// </summary>
        bool InsistOnKnowingPreType(IToken tok, PreType preType)
        {
            if (preType.Normalize() is PreTypeProxy)
            {
                Constraints.PartiallySolveTypeConstraints(null, MutateCSharp.Schemata425.ReplaceBooleanConstant_0(7L, true));

                if (preType.Normalize() is PreTypeProxy)
                {
                    ReportError(tok, MutateCSharp.Schemata425.ReplaceStringConstant_1(8L, "Could not resolve the type of the source of the match expression. Please provide additional typing annotations."));
                    return MutateCSharp.Schemata425.ReplaceBooleanConstant_0(9L, false);
                }
            }
            return MutateCSharp.Schemata425.ReplaceBooleanConstant_0(10L, true); // success: preType.Normalize() is a DPreType
        }

        /// <summary>
        /// Resolve "pattern" and push onto "scope" all its bound variables.
        /// </summary>
        public void ResolveExtendedPattern(IToken sourceExprToken, ExtendedPattern pattern, PreType preType, bool inDisjunctivePattern, ResolutionContext resolutionContext)
        {
            if (pattern is DisjunctivePattern dp)
            {
                foreach (var alt in dp.Alternatives)
                {
                    ResolveExtendedPattern(sourceExprToken, alt, preType, MutateCSharp.Schemata425.ReplaceBooleanConstant_0(11L, true), resolutionContext);
                }
                return;
            }

            if (pattern is LitPattern litPattern)
            {
                var lit = litPattern.OptimisticallyDesugaredLit;
                ResolveExpression(lit, resolutionContext);
                AddSubtypeConstraint(preType, lit.PreType, litPattern.tok,
        MutateCSharp.Schemata425.ReplaceStringConstant_1(12L, "literal pattern (of type {1}) cannot be used with source type {0}"));
                return;
            }

            var idPattern = (IdPattern)pattern;
            if (idPattern.Type is not TypeProxy)
            {
                Contract.Assert(idPattern.Arguments == null); // the parser ensures this condition (the ID cannot be followed by both "(...)" and ": ...")
                resolver.ResolveType(idPattern.Tok, idPattern.Type, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                // When a type is supplied, the ID is understood to be a bound variable.
                ResolveParameterlessIdPattern(idPattern, preType, inDisjunctivePattern, resolutionContext);
                return;
            }

            // Note: If the language were to (be extended to) allow qualified names in patterns, then
            // that qualified name should be resolved here, which also provides its pre-type. Then, that
            // pre-type should be checked to be assignable to "preType". All of this can be done even if
            // "preType" is a proxy.
            // Maybe the language should change to work this way even for non-qualified names. But as it
            // currently stands, "preType" is needed to look up the given ID.
            // (End of Note.)

            if (TryResolvingAsConst(idPattern, preType, MutateCSharp.Schemata425.ReplaceBooleanConstant_0(13L, false), resolutionContext))
            {
                // the ID is a const with a LiteralExpr RHS, so pick it
                return;
            }

            // Use "preType" as a guide to looking up the given ID. This requires knowing what "preType" is.
            if (!InsistOnKnowingPreType(sourceExprToken, preType))
            {
                return;
            }
            var dpreType = (DPreType)preType.Normalize();

            if (dpreType.Decl is DatatypeDecl dtd && dtd.ConstructorsByName.TryGetValue(idPattern.Id, out var ctor))
            {
                // the given ID is a datatype constructor
                idPattern.Ctor = ctor;
            }
            else if (MutateCSharp.Schemata425.ReplaceBinExprOp_2(14L, idPattern.Arguments, null))
            {
                // not a datatype constructor, so either a named constant or a bound variable
                ResolveParameterlessIdPattern(idPattern, preType, inDisjunctivePattern, resolutionContext);
                return;
            }
            else
            {
                // this is an error; if tuples are involved, specialize the error message
                if (MutateCSharp.Schemata425.ReplaceBinExprOp_4(19L, idPattern.Id, SystemModuleManager.TupleTypeCtorName(MutateCSharp.Schemata425.ReplaceNumericConstant_3(15L, 1))))
                {
                    ReportError(idPattern.Tok, MutateCSharp.Schemata425.ReplaceStringConstant_1(20L, "parentheses are not allowed around a pattern"));
                }
                else if (idPattern.Id.StartsWith(SystemModuleManager.TupleTypeCtorNamePrefix))
                {
                    ReportError(pattern.Tok, $"tuple type does not match type '{preType}'");
                }
                else
                {
                    ReportError(idPattern.Tok, $"type '{preType}' does not contain a datatype constructor '{idPattern.Id}'");
                }
                return;
            }

            if (MutateCSharp.Schemata425.ReplaceBinExprOp_2(21L, idPattern.Arguments, null))
            {
                if (MutateCSharp.Schemata425.ReplaceBinExprOp_5(26L, ctor.Formals.Count, MutateCSharp.Schemata425.ReplaceNumericConstant_3(22L, 0)))
                {
                    // nullary constructor without () -- so convert it to a constructor
                    idPattern.MakeAConstructor();
                }
                else
                {
                    ReportError(idPattern.Tok, $"constructor '{ctor.Name}' of arity {ctor.Formals.Count} is applied without any arguments");
                    return;
                }
            }
            if (MutateCSharp.Schemata425.ReplaceBinExprOp_6(31L, idPattern.Arguments.Count, ctor.Formals.Count))
            {
                ReportError(idPattern.Tok, $"constructor '{ctor.Name}' of arity {ctor.Formals.Count} is applied to {idPattern.Arguments.Count} argument(s)");
                return;
            }

            var subst = PreType.PreTypeSubstMap(dtd.TypeArgs, dpreType.Arguments);
            for (var i = MutateCSharp.Schemata425.ReplaceNumericConstant_3(36L, 0); MutateCSharp.Schemata425.ReplaceBinExprOp_7(40L, i, idPattern.Arguments.Count); MutateCSharp.Schemata425.ReplacePostfixUnaryExprOp_8(45L, ref i))
            {
                var argumentPreType = ctor.Formals[i].PreType.Substitute(subst);
                ResolveExtendedPattern(sourceExprToken, idPattern.Arguments[i], argumentPreType, inDisjunctivePattern, resolutionContext);
            }
        }

        /// <summary>
        /// Tries to resolve "idPattern" as a symbolic constant with a LiteralExpr RHS.
        ///
        /// Return "true" iff "idPattern" is a symbolic constant with a RHS (regardless of what that RHS is).
        ///
        /// If there is such a RHS and that RHS is a LiteralExpr, then
        ///   * record the RHS literal as "idPattern.ResolvedLit", and
        ///   * constrain its type to be assignable to "preType".
        /// If there is such a RHS, but that RHS is not a LiteralExpr, then
        ///   * report an error, if "reportErrors".
        /// </summary>
        private bool TryResolvingAsConst(IdPattern idPattern, PreType preType, bool reportErrors, ResolutionContext resolutionContext)
        {
            var e = new NameSegment(idPattern.Tok, idPattern.Id, null);
            ResolveNameSegment(e, MutateCSharp.Schemata425.ReplaceBooleanConstant_0(46L, true), null, resolutionContext, MutateCSharp.Schemata425.ReplaceBooleanConstant_0(47L, false), MutateCSharp.Schemata425.ReplaceBooleanConstant_0(48L, false));
            if (e.ResolvedExpression is MemberSelectExpr { Member: ConstantField { IsStatic: true, Rhs: { } rhs } })
            {
                if (rhs is LiteralExpr lit)
                {
                    // the ID refers to a const whose RHS is a literal
                    idPattern.ResolvedLit = lit;
                    AddSubtypeConstraint(preType, lit.PreType, idPattern.Tok, MutateCSharp.Schemata425.ReplaceStringConstant_1(49L, "literal pattern (of type {1}) cannot be used with source type {0}"));
                }
                else if (reportErrors)
                {
                    ReportError(idPattern.Tok, $"{idPattern.Id} is not initialized as a constant literal");
                }
                return MutateCSharp.Schemata425.ReplaceBooleanConstant_0(50L, true);
            }
            return MutateCSharp.Schemata425.ReplaceBooleanConstant_0(51L, false);
        }

        private void ResolveParameterlessIdPattern(IdPattern idPattern, PreType preType, bool inDisjunctivePattern, ResolutionContext resolutionContext)
        {
            Contract.Requires(idPattern.Arguments == null);

            if (idPattern.Type is TypeProxy)
            {
                if (TryResolvingAsConst(idPattern, preType, MutateCSharp.Schemata425.ReplaceBooleanConstant_0(52L, true), resolutionContext))
                {
                    return;
                }
            }

            // no other options remain; the ID denotes a new bound variable

            if (MutateCSharp.Schemata425.ReplaceBinExprOp_9(53L, () => inDisjunctivePattern, () => !idPattern.IsWildcardPattern))
            {
                ReportError(idPattern.Tok, MutateCSharp.Schemata425.ReplaceStringConstant_1(59L, "Disjunctive patterns may not bind variables"));
            }

            idPattern.BoundVar = new BoundVar(idPattern.Tok, idPattern.Id, idPattern.Type)
            {
                PreType = Type2PreType(idPattern.Type, MutateCSharp.Schemata425.ReplaceStringConstant_1(60L, "case pattern ID"))
            };
            AddSubtypeConstraint(preType, idPattern.BoundVar.PreType, idPattern.Tok,
      MutateCSharp.Schemata425.ReplaceStringConstant_1(61L, "pattern (of type {1}) cannot be used with source type {0}"));
            if (!idPattern.IsWildcardPattern)
            {
                resolver.ScopePushAndReport(scope, idPattern.BoundVar, MutateCSharp.Schemata425.ReplaceStringConstant_1(62L, "parameter"));
            }
        }
    }
}
