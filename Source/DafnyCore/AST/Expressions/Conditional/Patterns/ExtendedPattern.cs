using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata44
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT44");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_7(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.ExtendedPattern> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBinExprOp_5(long mutantId, System.Collections.Generic.Dictionary<string, Microsoft.Dafny.DatatypeCtor> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.DatatypeCtor argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.ExtendedPattern> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_2(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Formal> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{

    /*
    ExtendedPattern is either:
    1 - A LitPattern of a LiteralExpr, representing a constant pattern
    2 - An IdPattern of a string and a list of ExtendedPattern, representing either
        a bound variable or a constructor applied to n arguments or a symbolic constant
    */
    public abstract class ExtendedPattern : TokenNode
    {
        public bool IsGhost;

        public ExtendedPattern(IToken tok, bool isGhost = false)
        {
            Contract.Requires(tok != null);
            this.tok = tok;
            this.IsGhost = isGhost;
        }

        public IEnumerable<Node> DescendantsAndSelf =>
          new[] { this }.Concat(Children.OfType<ExtendedPattern>().SelectMany(c => c.DescendantsAndSelf));

        public virtual IEnumerable<Expression> SubExpressions
        {
            get
            {
                yield break;
            }
        }

        public abstract void Resolve(ModuleResolver resolver, ResolutionContext resolutionContext,
          Type sourceType, bool isGhost, bool inStatementContext,
          bool inPattern, bool inDisjunctivePattern);

        /*
        *  Ensures that all ExtendedPattern held in NestedMatchCase are linear
        *  Uses provided type to determine if IdPatterns are datatypes (of the provided type) or variables
        *  pat could be
        *  0 - A DisjunctivePattern
        *  1 - An IdPattern (without argument) at base type
        *  2 - A LitPattern at base type
        *  3* - An IdPattern at tuple type representing a tuple
        *  3 - An IdPattern at datatype type representing a constructor of type
        *  4 - An IdPattern at datatype type with no arguments representing a bound variable
        */
        public void CheckLinearExtendedPattern(Type type, ResolutionContext resolutionContext, ModuleResolver resolver)
        {
            if (MutateCSharp.Schemata44.ReplaceBinExprOp_0(1L, type, null))
            {
                return;
            }

            if (this is DisjunctivePattern dp)
            {
                foreach (var alt in dp.Alternatives)
                {
                    // Pushing a scope silences the “duplicate parameter” error in
                    // `CheckLinearVarPattern`.  This is acceptable because disjunctive
                    // patterns are not allowed to bind variables (the corresponding
                    // error is raised in `RemoveDisjunctivePatterns`).
                    resolver.scope.PushMarker();
                    alt.CheckLinearExtendedPattern(type, resolutionContext, resolver);
                    resolver.scope.PopMarker();
                }
            }
            else if (!type.IsDatatype)
            { // Neither tuple nor datatype
                if (this is IdPattern idPattern)
                {
                    if (MutateCSharp.Schemata44.ReplaceBinExprOp_1(2L, idPattern.Arguments, null))
                    {
                        // pat is a tuple or constructor
                        if (idPattern.Id.StartsWith(SystemModuleManager.TupleTypeCtorNamePrefix))
                        {
                            resolver.reporter.Error(MessageSource.Resolver, this.Tok, $"tuple type does not match type {type.ToString()}");
                        }
                        else
                        {
                            resolver.reporter.Error(MessageSource.Resolver, this.Tok, $"member {idPattern.Id} does not exist in type {type.ToString()}");
                        }
                    }
                    else
                    { // pat is a simple variable or a constant
                        /* =[1]= */
                        idPattern.CheckLinearVarPattern(type, resolutionContext, resolver);
                    }
                    return;
                }
                else if (this is LitPattern)
                { // pat is a literal
                    /* =[2]= */
                    return;
                }
                else
                {
                    Contract.Assert(false); throw new cce.UnreachableException();
                }
            }
            else if (type.AsDatatype is TupleTypeDecl tupleTypeDecl)
            {
                var udt = type.NormalizeExpand() as UserDefinedType;
                if (!(this is IdPattern))
                {
                    resolver.reporter.Error(MessageSource.Resolver, this.Tok, MutateCSharp.Schemata44.ReplaceStringConstant_2(3L, "pattern doesn't correspond to a tuple"));
                    return;
                }

                IdPattern idpat = (IdPattern)this;
                if (MutateCSharp.Schemata44.ReplaceBinExprOp_3(4L, idpat.Arguments, null))
                {
                    // simple variable
                    idpat.CheckLinearVarPattern(udt, resolutionContext, resolver);
                    return;
                }

                Contract.Assert(tupleTypeDecl.Ctors.Count == 1);
                Contract.Assert(tupleTypeDecl.Ctors[0] == tupleTypeDecl.GroundingCtor);
                idpat.Ctor = tupleTypeDecl.GroundingCtor;

                //We expect the number of arguments in the type of the matchee and the provided pattern to match, except if the pattern is a bound variable
                if (MutateCSharp.Schemata44.ReplaceBinExprOp_4(5L, udt.TypeArgs.Count, idpat.Arguments.Count))
                {
                    if (idpat.Id.StartsWith(SystemModuleManager.TupleTypeCtorNamePrefix))
                    {
                        resolver.reporter.Error(MessageSource.Resolver, this.Tok,
                          $"the case pattern is a {idpat.Arguments.Count}-element tuple, while the match expression is a {udt.TypeArgs.Count}-element tuple");
                    }
                    else
                    {
                        resolver.reporter.Error(MessageSource.Resolver, this.Tok,
                          $"case pattern {idpat.Id} has {idpat.Arguments.Count} arguments whereas the match expression has {udt.TypeArgs.Count}");
                    }
                }

                var pairTP = udt.TypeArgs.Zip(idpat.Arguments, (x, y) => new Tuple<Type, ExtendedPattern>(x, y));

                foreach (var tp in pairTP)
                {
                    var t = resolver.PartiallyResolveTypeForMemberSelection(this.Tok, tp.Item1).NormalizeExpand();
                    tp.Item2.CheckLinearExtendedPattern(t, resolutionContext, resolver);
                }
                return;
            }
            else
            { // matching a datatype value
                if (!(this is IdPattern))
                {
                    Contract.Assert(this is LitPattern);
                    resolver.reporter.Error(MessageSource.Resolver, this.Tok, MutateCSharp.Schemata44.ReplaceStringConstant_2(10L, "Constant pattern used in place of datatype"));
                    return;
                }
                IdPattern idpat = (IdPattern)this;

                var dtd = type.AsDatatype;
                Dictionary<string, DatatypeCtor> ctors = dtd.ConstructorsByName;
                if (MutateCSharp.Schemata44.ReplaceBinExprOp_5(11L, ctors, null))
                {
                    Contract.Assert(false); throw new cce.UnreachableException();  // Datatype not found
                }
                DatatypeCtor ctor = null;
                // Check if the head of the pattern is a constructor or a variable
                if (ctors.TryGetValue(idpat.Id, out ctor))
                {
                    /* =[3]= */
                    idpat.Ctor = ctor;
                    if (MutateCSharp.Schemata44.ReplaceBinExprOp_7(29L, () => MutateCSharp.Schemata44.ReplaceBinExprOp_7(14L, () => MutateCSharp.Schemata44.ReplaceBinExprOp_6(12L, ctor, null), () => MutateCSharp.Schemata44.ReplaceBinExprOp_3(13L, idpat.Arguments, null)), () => MutateCSharp.Schemata44.ReplaceBinExprOp_9(24L, ctor.Formals.Count, MutateCSharp.Schemata44.ReplaceNumericConstant_8(20L, 0))))
                    {
                        // nullary constructor without () -- so convert it to a constructor
                        idpat.MakeAConstructor();
                    }
                    if (MutateCSharp.Schemata44.ReplaceBinExprOp_3(35L, idpat.Arguments, null))
                    {
                        // pat is a variable
                        return;
                    }
                    else if (MutateCSharp.Schemata44.ReplaceBinExprOp_7(42L, () => MutateCSharp.Schemata44.ReplaceBinExprOp_10(36L, ctor.Formals, null), () => MutateCSharp.Schemata44.ReplaceBinExprOp_9(37L, ctor.Formals.Count, idpat.Arguments.Count)))
                    {
                        if (MutateCSharp.Schemata44.ReplaceBinExprOp_9(52L, ctor.Formals.Count, MutateCSharp.Schemata44.ReplaceNumericConstant_8(48L, 0)))
                        {
                            // if nullary constructor
                            return;
                        }
                        else
                        {
                            // if non-nullary constructor
                            var subst = TypeParameter.SubstitutionMap(dtd.TypeArgs, type.NormalizeExpand().TypeArgs);
                            var argTypes = ctor.Formals.ConvertAll<Type>(x => x.Type.Subst(subst));
                            var pairFA = argTypes.Zip(idpat.Arguments, (x, y) => new Tuple<Type, ExtendedPattern>(x, y));
                            foreach (var fa in pairFA)
                            {
                                // get DatatypeDecl of Formal, recursive call on argument
                                fa.Item2.CheckLinearExtendedPattern(fa.Item1, resolutionContext, resolver);
                            }
                        }
                    }
                    else
                    {
                        // else applied to the wrong number of arguments
                        resolver.reporter.Error(MessageSource.Resolver, idpat.Tok, MutateCSharp.Schemata44.ReplaceStringConstant_2(57L, "constructor {0} of arity {2} is applied to {1} argument(s)"), idpat.Id, (MutateCSharp.Schemata44.ReplaceBinExprOp_3(58L, idpat.Arguments, null) ? MutateCSharp.Schemata44.ReplaceNumericConstant_8(59L, 0) : idpat.Arguments.Count), ctor.Formals.Count);
                    }
                }
                else
                {
                    /* =[4]= */
                    // pattern is a variable OR error (handled in CheckLinearVarPattern)
                    idpat.CheckLinearVarPattern(type, resolutionContext, resolver);
                }
            }
        }
    }
}