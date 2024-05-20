//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using JetBrains.Annotations;
namespace MutateCSharp
{
    internal class Schemata439
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT439");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.Specification<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_5(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.TypeParameter argument1, Microsoft.Dafny.TypeParameter argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static int ReplaceNumericConstant_3(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.TypeParameter.EqualitySupportValue argument1, Microsoft.Dafny.TypeParameter.EqualitySupportValue argument2)
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

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.SubsetTypeDecl.WKind argument1, Microsoft.Dafny.SubsetTypeDecl.WKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}


namespace Microsoft.Dafny
{
    public class TypeCharacteristicChecker
    {

        /// <summary>
        /// Infer required equality support from looking at signatures of declarations.
        /// Then, check that all type characteristics are used and passed in properly.
        ///
        /// Note that this method can only be called after determining which expressions are ghosts.
        /// </summary>
        public static void InferAndCheck(List<TopLevelDecl> declarations, bool isAnExport, ErrorReporter reporter)
        {
            InferEqualitySupport(declarations);
            Check(declarations, isAnExport, reporter);
        }

        /// <summary>
        /// Inferred required equality support for datatypes and type synonyms, and for Function and Method signatures.
        /// </summary>
        private static void InferEqualitySupport(List<TopLevelDecl> declarations)
        {
            // First, do datatypes and type synonyms until a fixpoint is reached.
            bool inferredSomething;
            do
            {
                inferredSomething = MutateCSharp.Schemata439.ReplaceBooleanConstant_0(1L, false);
                foreach (var d in declarations)
                {
                    if (Attributes.Contains(d.Attributes, MutateCSharp.Schemata439.ReplaceStringConstant_1(2L, "_provided")))
                    {
                        // Don't infer required-equality-support for the type parameters, since there are
                        // scopes that see the name of the declaration but not its body.
                    }
                    else if (d is DatatypeDecl dt)
                    {
                        foreach (var tp in dt.TypeArgs)
                        {
                            if (MutateCSharp.Schemata439.ReplaceBinExprOp_2(3L, tp.Characteristics.EqualitySupport, TypeParameter.EqualitySupportValue.Unspecified))
                            {
                                // here's our chance to infer the need for equality support
                                foreach (var ctor in dt.Ctors)
                                {
                                    foreach (var arg in ctor.Formals)
                                    {
                                        if (InferRequiredEqualitySupport(tp, arg.Type))
                                        {
                                            tp.Characteristics.EqualitySupport = TypeParameter.EqualitySupportValue.InferredRequired;
                                            inferredSomething = MutateCSharp.Schemata439.ReplaceBooleanConstant_0(4L, true);
                                            goto DONE_DT; // break out of the doubly-nested loop
                                        }
                                    }
                                }
                            DONE_DT:;
                            }
                        }
                    }
                    else if (d is TypeSynonymDecl syn)
                    {
                        foreach (var tp in syn.TypeArgs)
                        {
                            if (MutateCSharp.Schemata439.ReplaceBinExprOp_2(5L, tp.Characteristics.EqualitySupport, TypeParameter.EqualitySupportValue.Unspecified))
                            {
                                // here's our chance to infer the need for equality support
                                if (InferRequiredEqualitySupport(tp, syn.Rhs))
                                {
                                    tp.Characteristics.EqualitySupport = TypeParameter.EqualitySupportValue.InferredRequired;
                                    inferredSomething = MutateCSharp.Schemata439.ReplaceBooleanConstant_0(6L, true);
                                }
                            }
                        }
                    }
                }
            } while (inferredSomething);

            // Now do it for Function and Method signatures.
            foreach (var d in declarations)
            {
                if (d is IteratorDecl iter)
                {
                    var done = MutateCSharp.Schemata439.ReplaceBooleanConstant_0(7L, false);
                    var nonnullIter = iter.NonNullTypeDecl;
                    Contract.Assert(nonnullIter.TypeArgs.Count == iter.TypeArgs.Count);
                    for (var i = MutateCSharp.Schemata439.ReplaceNumericConstant_3(8L, 0); MutateCSharp.Schemata439.ReplaceBinExprOp_4(12L, i, iter.TypeArgs.Count); MutateCSharp.Schemata439.ReplacePostfixUnaryExprOp_5(17L, ref i))
                    {
                        var tp = iter.TypeArgs[i];
                        var correspondingNonnullIterTypeParameter = nonnullIter.TypeArgs[i];
                        if (MutateCSharp.Schemata439.ReplaceBinExprOp_2(18L, tp.Characteristics.EqualitySupport, TypeParameter.EqualitySupportValue.Unspecified))
                        {
                            // here's our chance to infer the need for equality support
                            foreach (var p in iter.Ins)
                            {
                                if (InferRequiredEqualitySupport(tp, p.Type))
                                {
                                    tp.Characteristics.EqualitySupport = TypeParameter.EqualitySupportValue.InferredRequired;
                                    correspondingNonnullIterTypeParameter.Characteristics.EqualitySupport =
                                      TypeParameter.EqualitySupportValue.InferredRequired;
                                    done = MutateCSharp.Schemata439.ReplaceBooleanConstant_0(19L, true);
                                    break;
                                }
                            }

                            foreach (var p in iter.Outs)
                            {
                                if (done)
                                {
                                    break;
                                }
                                if (InferRequiredEqualitySupport(tp, p.Type))
                                {
                                    tp.Characteristics.EqualitySupport = TypeParameter.EqualitySupportValue.InferredRequired;
                                    correspondingNonnullIterTypeParameter.Characteristics.EqualitySupport =
                                      TypeParameter.EqualitySupportValue.InferredRequired;
                                    break;
                                }
                            }
                        }
                    }
                }
                else if (d is ClassLikeDecl or DefaultClassDecl)
                {
                    var cl = (TopLevelDeclWithMembers)d;
                    foreach (var member in cl.Members.Where(member => !member.IsGhost))
                    {
                        if (member is Function function)
                        {
                            foreach (var tp in function.TypeArgs)
                            {
                                if (MutateCSharp.Schemata439.ReplaceBinExprOp_2(20L, tp.Characteristics.EqualitySupport, TypeParameter.EqualitySupportValue.Unspecified))
                                {
                                    // here's our chance to infer the need for equality support
                                    if (InferRequiredEqualitySupport(tp, function.ResultType))
                                    {
                                        tp.Characteristics.EqualitySupport = TypeParameter.EqualitySupportValue.InferredRequired;
                                    }
                                    else
                                    {
                                        foreach (var p in function.Ins)
                                        {
                                            if (InferRequiredEqualitySupport(tp, p.Type))
                                            {
                                                tp.Characteristics.EqualitySupport = TypeParameter.EqualitySupportValue.InferredRequired;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (member is Method method)
                        {
                            bool done = MutateCSharp.Schemata439.ReplaceBooleanConstant_0(21L, false);
                            foreach (var tp in method.TypeArgs)
                            {
                                if (MutateCSharp.Schemata439.ReplaceBinExprOp_2(22L, tp.Characteristics.EqualitySupport, TypeParameter.EqualitySupportValue.Unspecified))
                                {
                                    // here's our chance to infer the need for equality support
                                    foreach (var p in method.Ins)
                                    {
                                        if (InferRequiredEqualitySupport(tp, p.Type))
                                        {
                                            tp.Characteristics.EqualitySupport = TypeParameter.EqualitySupportValue.InferredRequired;
                                            done = MutateCSharp.Schemata439.ReplaceBooleanConstant_0(23L, true);
                                            break;
                                        }
                                    }

                                    foreach (var p in method.Outs)
                                    {
                                        if (done)
                                        {
                                            break;
                                        }
                                        if (InferRequiredEqualitySupport(tp, p.Type))
                                        {
                                            tp.Characteristics.EqualitySupport = TypeParameter.EqualitySupportValue.InferredRequired;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private static bool InferRequiredEqualitySupport(TypeParameter tp, Type type)
        {
            Contract.Requires(tp != null);
            Contract.Requires(type != null);

            type = type.Normalize();  // we only do a .Normalize() here, because we want to keep stop at any type synonym or subset type
            if (type is BasicType)
            {
            }
            else if (type is SetType setType)
            {
                return MutateCSharp.Schemata439.ReplaceBinExprOp_7(25L, () => MutateCSharp.Schemata439.ReplaceBinExprOp_6(24L, setType.Arg.AsTypeParameter, tp), () => InferRequiredEqualitySupport(tp, setType.Arg));
            }
            else if (type is MultiSetType multiSetType)
            {
                return MutateCSharp.Schemata439.ReplaceBinExprOp_7(32L, () => MutateCSharp.Schemata439.ReplaceBinExprOp_6(31L, multiSetType.Arg.AsTypeParameter, tp), () => InferRequiredEqualitySupport(tp, multiSetType.Arg));
            }
            else if (type is MapType mapType)
            {
                return MutateCSharp.Schemata439.ReplaceBinExprOp_7(45L, () => MutateCSharp.Schemata439.ReplaceBinExprOp_7(39L, () => MutateCSharp.Schemata439.ReplaceBinExprOp_6(38L, mapType.Domain.AsTypeParameter, tp), () => InferRequiredEqualitySupport(tp, mapType.Domain)), () => InferRequiredEqualitySupport(tp, mapType.Range));
            }
            else if (type is SeqType seqType)
            {
                return InferRequiredEqualitySupport(tp, seqType.Arg);
            }
            else if (type is UserDefinedType udt)
            {
                var formalTypeArgs = udt.ResolvedClass.TypeArgs;
                Contract.Assert(formalTypeArgs != null);
                Contract.Assert(formalTypeArgs.Count == udt.TypeArgs.Count);
                var i = MutateCSharp.Schemata439.ReplaceNumericConstant_3(51L, 0);
                foreach (var argType in udt.TypeArgs)
                {
                    var formalTypeArg = formalTypeArgs[i];
                    if (MutateCSharp.Schemata439.ReplaceBinExprOp_7(62L, () => (MutateCSharp.Schemata439.ReplaceBinExprOp_8(56L, () => formalTypeArg.SupportsEquality, () => MutateCSharp.Schemata439.ReplaceBinExprOp_6(55L, argType.AsTypeParameter, tp))), () => InferRequiredEqualitySupport(tp, argType)))
                    {
                        return MutateCSharp.Schemata439.ReplaceBooleanConstant_0(68L, true);
                    }

                    MutateCSharp.Schemata439.ReplacePostfixUnaryExprOp_5(69L, ref i);
                }
                if (udt.ResolvedClass is TypeSynonymDecl syn)
                {
                    if (syn.IsRevealedInScope(Type.GetScope()))
                    {
                        return InferRequiredEqualitySupport(tp, syn.RhsWithArgument(udt.TypeArgs));
                    }
                }
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected type
            }
            return MutateCSharp.Schemata439.ReplaceBooleanConstant_0(70L, false);
        }

        private static void Check(List<TopLevelDecl> declarations, bool isAnExport, ErrorReporter reporter)
        {
            var visitor = new CheckTypeCharacteristics_Visitor(reporter);

            foreach (var d in declarations)
            {
                CheckAttributes(d.Attributes, visitor);

                if (d is IteratorDecl iter)
                {
                    CheckFormals(iter.Ins, MutateCSharp.Schemata439.ReplaceBooleanConstant_0(71L, false), visitor);
                    CheckFormals(iter.Outs, MutateCSharp.Schemata439.ReplaceBooleanConstant_0(72L, false), visitor);
                    CheckSpecification(iter.Requires, iter.Modifies, iter.Ensures, iter.Decreases, visitor);
                    CheckSpecification(iter.YieldRequires, iter.Reads, iter.YieldEnsures, null, visitor);
                    if (MutateCSharp.Schemata439.ReplaceBinExprOp_9(73L, iter.Body, null))
                    {
                        visitor.Visit(iter.Body, MutateCSharp.Schemata439.ReplaceBooleanConstant_0(74L, false));
                    }
                }
                else if (d is ClassLikeDecl cl)
                {
                    foreach (var parentTrait in cl.ParentTraits)
                    {
                        visitor.VisitType(cl.tok, parentTrait, MutateCSharp.Schemata439.ReplaceBooleanConstant_0(75L, false));
                    }
                }
                else if (d is DatatypeDecl dt)
                {
                    foreach (var ctor in dt.Ctors)
                    {
                        CheckAttributes(ctor.Attributes, visitor);
                        CheckFormals(ctor.Formals, ctor.IsGhost, visitor);
                    }
                }
                else if (d is TypeSynonymDecl syn)
                {
                    visitor.VisitType(syn.tok, syn.Rhs, MutateCSharp.Schemata439.ReplaceBooleanConstant_0(76L, false));
                    if (!isAnExport)
                    {
                        if (MutateCSharp.Schemata439.ReplaceBinExprOp_8(77L, () => syn.SupportsEquality, () => !syn.Rhs.SupportsEquality))
                        {
                            reporter.Error(MessageSource.Resolver, syn.tok, MutateCSharp.Schemata439.ReplaceStringConstant_1(83L, "type '{0}' declared as supporting equality, but the RHS type ({1}) might not"),
                              syn.Name, syn.Rhs);
                        }
                        if (MutateCSharp.Schemata439.ReplaceBinExprOp_8(84L, () => syn.Characteristics.IsNonempty, () => !syn.Rhs.IsNonempty))
                        {
                            reporter.Error(MessageSource.Resolver, syn.tok, MutateCSharp.Schemata439.ReplaceStringConstant_1(90L, "type '{0}' declared as being nonempty, but the RHS type ({1}) may be empty"),
                              syn.Name, syn.Rhs);
                        }
                        else if (MutateCSharp.Schemata439.ReplaceBinExprOp_8(91L, () => syn.Characteristics.HasCompiledValue, () => !syn.Rhs.HasCompilableValue))
                        {
                            reporter.Error(MessageSource.Resolver, syn.tok,
              MutateCSharp.Schemata439.ReplaceStringConstant_1(97L, "type '{0}' declared as auto-initialization type, but the RHS type ({1}) does not support auto-initialization"), syn.Name,
                              syn.Rhs);
                        }
                        if (MutateCSharp.Schemata439.ReplaceBinExprOp_8(98L, () => syn.Characteristics.ContainsNoReferenceTypes, () => syn.Rhs.MayInvolveReferences))
                        {
                            reporter.Error(MessageSource.Resolver, syn.tok,
              MutateCSharp.Schemata439.ReplaceStringConstant_1(104L, "type '{0}' declared as containing no reference types, but the RHS type ({1}) may contain reference types"), syn.Name,
                              syn.Rhs);
                        }
                    }
                }

                if (d is RedirectingTypeDecl rtd)
                {
                    if (MutateCSharp.Schemata439.ReplaceBinExprOp_10(105L, rtd.Constraint, null))
                    {
                        // TODO: In some places, constraints are checked at run time. Those places need to be checked with isGhostContext:=false. Ugh! Better
                        // would be if the language design was such that the declaration said directly whether or not the constraint is intended to be ghost
                        // or compiled.
                        visitor.Visit(rtd.Constraint, MutateCSharp.Schemata439.ReplaceBooleanConstant_0(106L, true));
                    }
                    if (MutateCSharp.Schemata439.ReplaceBinExprOp_10(107L, rtd.Witness, null))
                    {
                        visitor.Visit(rtd.Witness, MutateCSharp.Schemata439.ReplaceBinExprOp_11(108L, rtd.WitnessKind, SubsetTypeDecl.WKind.Ghost));
                    }
                }

                if (d is TopLevelDeclWithMembers topLevelDeclWithMembers)
                {
                    foreach (var member in topLevelDeclWithMembers.Members)
                    {
                        CheckAttributes(member.Attributes, visitor);
                        if (member is Field field)
                        {
                            visitor.VisitType(field.tok, field.Type, field.IsGhost);
                            if (field is ConstantField { Rhs: { } } cf)
                            {
                                visitor.Visit(cf.Rhs, cf.IsGhost);
                            }
                        }
                        else if (member is Function function)
                        {
                            CheckFormals(function.Ins, function.IsGhost, visitor);
                            visitor.VisitType(function.Result?.tok ?? function.tok, function.ResultType, function.IsGhost);
                            CheckSpecification(function.Req, function.Reads, function.Ens, function.Decreases, visitor);
                            if (MutateCSharp.Schemata439.ReplaceBinExprOp_10(109L, function.Body, null))
                            {
                                visitor.Visit(function.Body, function.IsGhost);
                            }
                        }
                        else if (member is Method method)
                        {
                            CheckFormals(method.Ins, method.IsGhost, visitor);
                            CheckFormals(method.Outs, method.IsGhost, visitor);
                            CheckSpecification(method.Req, method.Mod, method.Ens, method.Decreases, visitor);
                            if (MutateCSharp.Schemata439.ReplaceBinExprOp_9(110L, method.Body, null))
                            {
                                visitor.Visit(method.Body, method.IsGhost);
                            }
                        }
                    }
                }
            }
        }

        private static void CheckAttributes(Attributes attributes, CheckTypeCharacteristics_Visitor visitor)
        {
            for (var attr = attributes; MutateCSharp.Schemata439.ReplaceBinExprOp_12(111L, attr, null); attr = attr.Prev)
            {
                attr.Args.ForEach(e => visitor.Visit(e, MutateCSharp.Schemata439.ReplaceBooleanConstant_0(112L, true)));
            }
        }

        private static void CheckFormals(List<Formal> formals, bool isGhostContext, CheckTypeCharacteristics_Visitor visitor)
        {
            foreach (var p in formals)
            {
                visitor.VisitType(p.tok, p.Type, MutateCSharp.Schemata439.ReplaceBinExprOp_7(113L, () => isGhostContext, () => p.IsGhost));
                if (MutateCSharp.Schemata439.ReplaceBinExprOp_10(119L, p.DefaultValue, null))
                {
                    visitor.Visit(p.DefaultValue, MutateCSharp.Schemata439.ReplaceBinExprOp_7(120L, () => isGhostContext, () => p.IsGhost));
                }
            }
        }

        private static void CheckSpecification(List<AttributedExpression> requires, Specification<FrameExpression> frame,
          List<AttributedExpression> ensures, [CanBeNull] Specification<Expression> decreases,
          CheckTypeCharacteristics_Visitor visitor)
        {

            foreach (var aexpr in requires)
            {
                CheckAttributes(aexpr.Attributes, visitor);
                visitor.Visit(aexpr.E, MutateCSharp.Schemata439.ReplaceBooleanConstant_0(126L, true));
            }

            CheckAttributes(frame.Attributes, visitor);
            foreach (var expr in frame.Expressions)
            {
                visitor.Visit(expr, MutateCSharp.Schemata439.ReplaceBooleanConstant_0(127L, true));
            }

            foreach (var aexpr in ensures)
            {
                CheckAttributes(aexpr.Attributes, visitor);
                visitor.Visit(aexpr.E, MutateCSharp.Schemata439.ReplaceBooleanConstant_0(128L, true));
            }

            if (MutateCSharp.Schemata439.ReplaceBinExprOp_13(129L, decreases, null))
            {
                CheckAttributes(decreases.Attributes, visitor);
                foreach (var expr in decreases.Expressions)
                {
                    visitor.Visit(expr, MutateCSharp.Schemata439.ReplaceBooleanConstant_0(130L, true));
                }
            }
        }

    }
}
