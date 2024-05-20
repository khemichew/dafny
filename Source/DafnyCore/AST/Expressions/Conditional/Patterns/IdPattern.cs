using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.AccessControl;
using Microsoft.CodeAnalysis.CSharp.Syntax;
namespace MutateCSharp
{
    internal class Schemata45
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT45");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_2(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_0(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.ExtendedPattern> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceNumericConstant_5(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.LiteralExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, Microsoft.Dafny.IDeclarationOrUsage argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.LiteralExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_13(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.IVariable argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.DatatypeCtor argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
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

        internal static bool ReplaceBinExprOp_3(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_4(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.ExtendedPattern> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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
    public class IdPattern : ExtendedPattern, IHasUsages
    {
        public bool HasParenthesis { get; }

        public String Id;
        public PreType PreType;
        public Type Type; // This is the syntactic type, ExtendedPatterns disappear during resolution.
        public IVariable BoundVar { get; set; }

        public List<ExtendedPattern> Arguments; // null if just an identifier; possibly empty argument list if a constructor call
        public LiteralExpr ResolvedLit; // null if just an identifier
        [FilledInDuringResolution]
        public DatatypeCtor Ctor;

        public bool IsWildcardPattern => MutateCSharp.Schemata45.ReplaceBinExprOp_2(3L, () => MutateCSharp.Schemata45.ReplaceBinExprOp_0(1L, Arguments, null), () => Id.StartsWith(MutateCSharp.Schemata45.ReplaceStringConstant_1(2L, "_")));

        public bool IsWildcardExact => MutateCSharp.Schemata45.ReplaceBinExprOp_2(12L, () => MutateCSharp.Schemata45.ReplaceBinExprOp_0(9L, Arguments, null), () => MutateCSharp.Schemata45.ReplaceBinExprOp_3(11L, Id, MutateCSharp.Schemata45.ReplaceStringConstant_1(10L, "_")));

        public void MakeAConstructor()
        {
            this.Arguments = new List<ExtendedPattern>();
        }

        public IdPattern(Cloner cloner, IdPattern original) : base(cloner.Tok(original.Tok), original.IsGhost)
        {
            Id = original.Id;
            Arguments = original.Arguments?.Select(cloner.CloneExtendedPattern).ToList();
            HasParenthesis = original.HasParenthesis;
            Type = cloner.CloneType(original.Type);
            if (cloner.CloneResolvedFields)
            {
                BoundVar = cloner.CloneIVariable(original.BoundVar, MutateCSharp.Schemata45.ReplaceBooleanConstant_4(18L, false));
            }
        }

        public IdPattern(IToken tok, String id, List<ExtendedPattern> arguments, bool isGhost = false, bool hasParenthesis = false) : base(tok, isGhost)
        {
            Contract.Requires(id != null);
            Contract.Requires(arguments != null); // Arguments can be empty, but shouldn't be null
            HasParenthesis = hasParenthesis;
            this.Id = id;
            this.Type = new InferredTypeProxy();
            this.Arguments = arguments;
        }

        public IdPattern(IToken tok, String id, Type type, List<ExtendedPattern> arguments, bool isGhost = false) : base(tok, isGhost)
        {
            Contract.Requires(id != null);
            Contract.Requires(arguments != null); // Arguments can be empty, but shouldn't be null
            this.Id = id;
            this.Type = type ?? new InferredTypeProxy();
            this.Arguments = arguments;
            this.IsGhost = isGhost;
        }

        public override string ToString()
        {
            if (MutateCSharp.Schemata45.ReplaceBinExprOp_7(29L, () => MutateCSharp.Schemata45.ReplaceBinExprOp_0(19L, Arguments, null), () => MutateCSharp.Schemata45.ReplaceBinExprOp_6(24L, Arguments.Count, MutateCSharp.Schemata45.ReplaceNumericConstant_5(20L, 0))))
            {
                return Id;
            }
            else
            {
                List<string> cps = Arguments.ConvertAll<string>(x => x.ToString());
                return string.Format(MutateCSharp.Schemata45.ReplaceStringConstant_1(35L, "{0}({1})"), Id, String.Join(MutateCSharp.Schemata45.ReplaceStringConstant_1(36L, ", "), cps));
            }

            return default;
        }

        public override IEnumerable<INode> Children => Arguments ?? Enumerable.Empty<Node>();
        public override IEnumerable<INode> PreResolveChildren => Children;

        public override IEnumerable<Expression> SubExpressions
        {
            get
            {
                if (MutateCSharp.Schemata45.ReplaceBinExprOp_8(37L, ResolvedLit, null))
                {
                    yield return ResolvedLit;
                }
                if (MutateCSharp.Schemata45.ReplaceBinExprOp_9(38L, Arguments, null))
                {
                    foreach (var alternative in Arguments)
                    {
                        foreach (var ee in alternative.SubExpressions)
                        {
                            yield return ee;
                        }
                    }
                }

                yield break;
            }
        }

        public override void Resolve(ModuleResolver resolver, ResolutionContext resolutionContext,
          Type sourceType, bool isGhost, bool inStatementContext,
          bool inPattern, bool inDisjunctivePattern)
        {

            if (MutateCSharp.Schemata45.ReplaceBinExprOp_2(53L, () => MutateCSharp.Schemata45.ReplaceBinExprOp_2(47L, () => MutateCSharp.Schemata45.ReplaceBinExprOp_2(40L, () => inDisjunctivePattern, () => MutateCSharp.Schemata45.ReplaceBinExprOp_10(39L, ResolvedLit, null)), () => MutateCSharp.Schemata45.ReplaceBinExprOp_0(46L, Arguments, null)), () => !IsWildcardPattern))
            {
                resolver.reporter.Error(MessageSource.Resolver, Tok, MutateCSharp.Schemata45.ReplaceStringConstant_1(59L, "Disjunctive patterns may not bind variables"));
            }

            resolver.ResolveType(Tok, Type, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);

            if (MutateCSharp.Schemata45.ReplaceBinExprOp_8(60L, ResolvedLit, null))
            {
                // we're done
            }
            else if (MutateCSharp.Schemata45.ReplaceBinExprOp_0(61L, Arguments, null))
            {
                // If the type was not given explicitly, set it to the sourceType
                if (Type.Normalize() is TypeProxy proxy)
                {
                    proxy.T = sourceType;
                }

                if (inStatementContext)
                {
                    var localVariable = new LocalVariable(RangeToken, Id, null, isGhost)
                    {
                        type = Type
                    };
                    BoundVar = localVariable;
                }
                else
                {
                    var boundVar = new BoundVar(Tok, Id, Type)
                    {
                        IsGhost = isGhost
                    };
                    BoundVar = boundVar;
                }

                resolver.ConstrainSubtypeRelation(Type, sourceType, Tok,
          MutateCSharp.Schemata45.ReplaceStringConstant_1(62L, "match source type '{1}' not assignable to bound variable (of type '{0}')"), Type, sourceType);
                resolver.scope.Push(Id, BoundVar);

            }
            else if (MutateCSharp.Schemata45.ReplaceBinExprOp_11(63L, Ctor, null))
            {
                var subst = TypeParameter.SubstitutionMap(sourceType.AsDatatype.TypeArgs, sourceType.NormalizeExpand().TypeArgs);
                for (var index = MutateCSharp.Schemata45.ReplaceNumericConstant_5(64L, 0); MutateCSharp.Schemata45.ReplaceBinExprOp_12(68L, index, Arguments.Count); MutateCSharp.Schemata45.ReplacePostfixUnaryExprOp_13(73L, ref index))
                {
                    var argument = Arguments[index];
                    var formal = Ctor.Formals[index];
                    argument.Resolve(resolver, resolutionContext, formal.Type.Subst(subst),
            MutateCSharp.Schemata45.ReplaceBinExprOp_7(74L, () => isGhost, () => formal.IsGhost), inStatementContext, MutateCSharp.Schemata45.ReplaceBooleanConstant_4(80L, true), inDisjunctivePattern);
                }
            }
        }

        public IEnumerable<IDeclarationOrUsage> GetResolvedDeclarations()
        {
            return new IDeclarationOrUsage[] { Ctor }.Where(x => MutateCSharp.Schemata45.ReplaceBinExprOp_14(81L, x, null));
        }

        public IToken NameToken => Tok;

        public void CheckLinearVarPattern(Type type, ResolutionContext resolutionContext, ModuleResolver resolver)
        {
            if (MutateCSharp.Schemata45.ReplaceBinExprOp_9(82L, Arguments, null))
            {
                if (MutateCSharp.Schemata45.ReplaceBinExprOp_3(87L, Id, SystemModuleManager.TupleTypeCtorName(MutateCSharp.Schemata45.ReplaceNumericConstant_5(83L, 1))))
                {
                    resolver.reporter.Error(MessageSource.Resolver, this.Tok, MutateCSharp.Schemata45.ReplaceStringConstant_1(88L, "parentheses are not allowed around a pattern"));
                }
                else
                {
                    resolver.reporter.Error(MessageSource.Resolver, this.Tok, MutateCSharp.Schemata45.ReplaceStringConstant_1(89L, "member {0} does not exist in type {1}"), this.Id, type);
                }
                return;
            }

            if (MutateCSharp.Schemata45.ReplaceBinExprOp_15(90L, resolver.scope.FindInCurrentScope(this.Id), null))
            {
                resolver.reporter.Error(MessageSource.Resolver, this.Tok, MutateCSharp.Schemata45.ReplaceStringConstant_1(91L, "Duplicate parameter name: {0}"), this.Id);
            }
            else if (IsWildcardPattern)
            {
                // Wildcard, ignore
                return;
            }
            else
            {
                NameSegment e = new NameSegment(this.Tok, this.Id, null);
                resolver.ResolveNameSegment(e, MutateCSharp.Schemata45.ReplaceBooleanConstant_4(92L, true), null, resolutionContext, MutateCSharp.Schemata45.ReplaceBooleanConstant_4(93L, false), MutateCSharp.Schemata45.ReplaceBooleanConstant_4(94L, false));
                if (MutateCSharp.Schemata45.ReplaceBinExprOp_16(95L, e.ResolvedExpression, null))
                {
                    resolver.ScopePushAndReport(resolver.scope, new BoundVar(this.Tok, this.Id, type), MutateCSharp.Schemata45.ReplaceStringConstant_1(96L, "parameter"));
                }
                else
                {
                    // finds in full scope, not just current scope
                    if (e.Resolved is MemberSelectExpr mse)
                    {
                        if (mse.Member.IsStatic && mse.Member is ConstantField cf)
                        {
                            Expression c = cf.Rhs;
                            if (c is LiteralExpr lit)
                            {
                                this.ResolvedLit = lit;
                                if (type.Equals(e.ResolvedExpression.Type))
                                {
                                    // OK - type is correct
                                }
                                else
                                {
                                    // may well be a proxy so add a type constraint
                                    resolver.ConstrainSubtypeRelation(e.ResolvedExpression.Type, type, this.Tok,
                    MutateCSharp.Schemata45.ReplaceStringConstant_1(97L, "the type of the pattern ({0}) does not agree with the match expression ({1})"), e.ResolvedExpression.Type, type);
                                }
                            }
                            else
                            {
                                resolver.reporter.Error(MessageSource.Resolver, this.Tok, MutateCSharp.Schemata45.ReplaceStringConstant_1(98L, "{0} is not initialized as a constant literal"), this.Id);
                                resolver.ScopePushAndReport(resolver.scope, new BoundVar(this.Tok, this.Id, type), MutateCSharp.Schemata45.ReplaceStringConstant_1(99L, "parameter"));
                            }
                        }
                        else
                        {
                            // Not a static const, so just a variable
                            resolver.ScopePushAndReport(resolver.scope, new BoundVar(this.Tok, this.Id, type), MutateCSharp.Schemata45.ReplaceStringConstant_1(100L, "parameter"));
                        }
                    }
                    else
                    {
                        resolver.ScopePushAndReport(resolver.scope, new BoundVar(this.Tok, this.Id, type), MutateCSharp.Schemata45.ReplaceStringConstant_1(101L, "parameter"));
                    }
                }
            }
        }
    }
}
