using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata404
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT404");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
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

        internal static bool ReplaceBinExprOp_10(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_11(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public class InferDecreasesClause
    {
        private readonly ModuleResolver resolver;

        public InferDecreasesClause(ModuleResolver resolver)
        {
            this.resolver = resolver;
        }

        public void FillInDefaultDecreasesClauses(ModuleDefinition module)
        {

            Contract.Assert(Type.GetScope() != null);
            foreach (var clbl in ModuleDefinition.AllCallables(module.TopLevelDecls))
            {
                ICallable m;
                string s;
                if (clbl is ExtremeLemma)
                {
                    var prefixLemma = ((ExtremeLemma)clbl).PrefixLemma;
                    m = prefixLemma;
                    s = prefixLemma.Name + MutateCSharp.Schemata404.ReplaceStringConstant_0(1L, " ");
                }
                else
                {
                    m = clbl;
                    s = "";
                }

                var anyChangeToDecreases = FillInDefaultDecreases(m, MutateCSharp.Schemata404.ReplaceBooleanConstant_1(2L, true));

                if (MutateCSharp.Schemata404.ReplaceBinExprOp_2(9L, () => MutateCSharp.Schemata404.ReplaceBinExprOp_2(3L, () => anyChangeToDecreases, () => m.InferredDecreases), () => m is PrefixLemma))
                {
                    bool showIt = MutateCSharp.Schemata404.ReplaceBooleanConstant_1(15L, false);
                    if (m is Function)
                    {
                        // show the inferred decreases clause only if it will ever matter, i.e., if the function is recursive
                        showIt = ((Function)m).IsRecursive;
                    }
                    else if (m is PrefixLemma)
                    {
                        // always show the decrease clause, since at the very least it will start with "_k", which the programmer did not write explicitly
                        showIt = MutateCSharp.Schemata404.ReplaceBooleanConstant_1(16L, true);
                    }
                    else
                    {
                        showIt = ((Method)m).IsRecursive;
                    }

                    if (showIt)
                    {
                        s += MutateCSharp.Schemata404.ReplaceStringConstant_0(17L, "decreases ") + Util.Comma(m.Decreases.Expressions, expr => Printer.ExprToString(resolver.Options, expr));
                        // Note, in the following line, we use the location information for "clbl", not "m".  These
                        // are the same, except in the case where "clbl" is a GreatestLemma and "m" is a prefix lemma.
                        resolver.reporter.Info(MessageSource.Resolver, clbl.Tok, s);
                    }
                }
            }
        }

        /// <summary>
        /// Return "true" if this routine makes any change to the decreases clause.  If the decreases clause
        /// starts off essentially empty and a default is provided, then clbl.InferredDecreases is also set
        /// to true.
        /// </summary>
        public bool FillInDefaultDecreases(ICallable clbl, bool addPrefixInCoClusters)
        {
            Contract.Requires(clbl != null);

            if (clbl is ExtremePredicate)
            {
                // extreme predicates don't have decreases clauses
                return MutateCSharp.Schemata404.ReplaceBooleanConstant_1(18L, false);
            }

            var anyChangeToDecreases = MutateCSharp.Schemata404.ReplaceBooleanConstant_1(19L, false);
            var decr = clbl.Decreases.Expressions;
            if (MutateCSharp.Schemata404.ReplaceBinExprOp_2(44L, () => MutateCSharp.Schemata404.ReplaceBinExprOp_4(24L, decr.Count, MutateCSharp.Schemata404.ReplaceNumericConstant_3(20L, 0)), () => (MutateCSharp.Schemata404.ReplaceBinExprOp_5(38L, () => clbl is PrefixLemma, () => MutateCSharp.Schemata404.ReplaceBinExprOp_4(33L, decr.Count, MutateCSharp.Schemata404.ReplaceNumericConstant_3(29L, 1))))))
            {
                // The default for a function starts with the function's reads clause, if any
                if (clbl is Function)
                {
                    var fn = (Function)clbl;
                    if (MutateCSharp.Schemata404.ReplaceBinExprOp_6(54L, fn.Reads.Expressions.Count, MutateCSharp.Schemata404.ReplaceNumericConstant_3(50L, 0)))
                    {
                        // start the default lexicographic tuple with the reads clause
                        var r = FrameToObjectSet(fn.Reads.Expressions);
                        decr.Add(AutoGeneratedExpression.Create(r));
                        anyChangeToDecreases = MutateCSharp.Schemata404.ReplaceBooleanConstant_1(59L, true);
                    }
                }

                if (MutateCSharp.Schemata404.ReplaceBinExprOp_2(60L, () => clbl is Function, () => clbl is Method))
                {
                    TopLevelDeclWithMembers enclosingType;
                    MemberDecl originalMember;
                    if (clbl is Function fc && !fc.IsStatic)
                    {
                        enclosingType = (TopLevelDeclWithMembers)fc.EnclosingClass;
                        originalMember = fc.Original;
                    }
                    else if (clbl is Method mc && !mc.IsStatic)
                    {
                        enclosingType = (TopLevelDeclWithMembers)mc.EnclosingClass;
                        originalMember = mc.Original;
                    }
                    else
                    {
                        enclosingType = null;
                        originalMember = null;
                    }

                    if (MutateCSharp.Schemata404.ReplaceBinExprOp_5(67L, () => MutateCSharp.Schemata404.ReplaceBinExprOp_7(66L, enclosingType, null), () => originalMember == clbl))
                    {
                        var receiverType = ModuleResolver.GetThisType(clbl.Tok, enclosingType);
                        if (MutateCSharp.Schemata404.ReplaceBinExprOp_5(73L, () => receiverType.IsOrdered, () => !receiverType.IsRefType))
                        {
                            var th = new ThisExpr(new AutoGeneratedToken(clbl.Tok)) { Type = receiverType }; // resolve here
                            decr.Add(AutoGeneratedExpression.Create(th));
                            anyChangeToDecreases = MutateCSharp.Schemata404.ReplaceBooleanConstant_1(79L, true);
                        }
                    }
                }

                // Add one component for each parameter, unless the parameter's type is one that
                // doesn't appear useful to orderings.
                foreach (var p in clbl.Ins)
                {
                    if (MutateCSharp.Schemata404.ReplaceBinExprOp_5(80L, () => !(p is ImplicitFormal), () => p.Type.IsOrdered))
                    {
                        var ie = new IdentifierExpr(new AutoGeneratedToken(p.tok), p.Name);
                        ie.Var = p;
                        ie.Type = p.Type; // resolve it here
                        decr.Add(AutoGeneratedExpression.Create(ie));
                        anyChangeToDecreases = MutateCSharp.Schemata404.ReplaceBooleanConstant_1(86L, true);
                    }
                }

                clbl.InferredDecreases = MutateCSharp.Schemata404.ReplaceBooleanConstant_1(87L, true); // this indicates that finding a default decreases clause was attempted
            }

            if (MutateCSharp.Schemata404.ReplaceBinExprOp_5(88L, () => addPrefixInCoClusters, () => clbl is Function))
            {
                var fn = (Function)clbl;
                switch (fn.CoClusterTarget)
                {
                    case Function.CoCallClusterInvolvement.None:
                        break;
                        break;
                    case Function.CoCallClusterInvolvement.IsMutuallyRecursiveTarget:
                        // prefix: decreases 0,
                        clbl.Decreases.Expressions.Insert(0, Expression.CreateIntLiteral(fn.tok, 0));
                        anyChangeToDecreases = true;
                        break;
                        break;
                    case Function.CoCallClusterInvolvement.CoRecursiveTargetAllTheWay:
                        // prefix: decreases 1,
                        clbl.Decreases.Expressions.Insert(0, Expression.CreateIntLiteral(fn.tok, 1));
                        anyChangeToDecreases = true;
                        break;
                        break;
                    default:
                        Contract.Assume(false); // unexpected case
                        break;
                        break;
                }
            }

            return anyChangeToDecreases;
        }

        public Expression FrameToObjectSet(List<FrameExpression> fexprs)
        {
            Contract.Requires(fexprs != null);
            Contract.Ensures(Contract.Result<Expression>() != null);

            List<Expression> sets = new List<Expression>();
            List<Expression> singletons = null;
            var idGen = new FreshIdGenerator();
            // drop wildcards altogether in the following iterations
            foreach (FrameExpression fe in fexprs.Where(fe => fe.E is not WildcardExpr))
            {
                Contract.Assert(fe != null);
                Expression e = new Cloner(MutateCSharp.Schemata404.ReplaceBooleanConstant_1(94L, false), MutateCSharp.Schemata404.ReplaceBooleanConstant_1(95L, true)).CloneExpr(fe.E); // keep only fe.E, drop any fe.Field designation
                Contract.Assert(e.Type != null); // fe.E should have been resolved already, and the clone should still have that type
                var eType = e.Type.NormalizeToAncestorType();
                if (eType.IsRefType)
                {
                    // e represents a singleton set
                    if (MutateCSharp.Schemata404.ReplaceBinExprOp_8(96L, singletons, null))
                    {
                        singletons = new List<Expression>();
                    }
                    singletons.Add(e);

                }
                else if (MutateCSharp.Schemata404.ReplaceBinExprOp_2(97L, () => eType is SeqType or MultiSetType, () => LiteralExpr.IsEmptySet(e)))
                {
                    // e represents a sequence or multiset
                    var collectionType = (CollectionType)eType;
                    var resolvedOpcode = collectionType.ResolvedOpcodeForIn;
                    var boundedPool = collectionType.GetBoundedPool(e);

                    // Add:  set x :: x in e
                    var bvDecl = new BoundVar(e.tok, idGen.FreshId(MutateCSharp.Schemata404.ReplaceStringConstant_0(103L, "_s2s_")), collectionType.Arg.NormalizeExpand());
                    var bv = new IdentifierExpr(e.tok, bvDecl.Name)
                    {
                        Var = bvDecl,
                        Type = bvDecl.Type
                    };
                    var bvInE = new BinaryExpr(e.tok, BinaryExpr.Opcode.In, bv, e)
                    {
                        ResolvedOp = resolvedOpcode,
                        Type = Type.Bool
                    };
                    var s = new SetComprehension(e.tok, e.RangeToken, MutateCSharp.Schemata404.ReplaceBooleanConstant_1(104L, true), new List<BoundVar>() { bvDecl }, bvInE, bv,
                      new Attributes(MutateCSharp.Schemata404.ReplaceStringConstant_0(105L, "trigger"), new List<Expression> { bvInE }, null))
                    {
                        Type = resolver.SystemModuleManager.ObjectSetType(),
                        Bounds = new List<BoundedPool>() { boundedPool }
                    };
                    sets.Add(s);

                }
                else
                {
                    // e is already a set
                    Contract.Assert(eType is SetType);
                    sets.Add(e);
                }
            }

            if (MutateCSharp.Schemata404.ReplaceBinExprOp_9(106L, singletons, null))
            {
                Expression display = new SetDisplayExpr(singletons[MutateCSharp.Schemata404.ReplaceNumericConstant_3(107L, 0)].tok, MutateCSharp.Schemata404.ReplaceBooleanConstant_1(111L, true), singletons)
                {
                    Type = resolver.SystemModuleManager.ObjectSetType()
                };
                sets.Add(display);
            }

            if (MutateCSharp.Schemata404.ReplaceBinExprOp_4(116L, sets.Count, MutateCSharp.Schemata404.ReplaceNumericConstant_3(112L, 0)))
            {
                var emptySet = new SetDisplayExpr(Token.NoToken, MutateCSharp.Schemata404.ReplaceBooleanConstant_1(121L, true), new List<Expression>())
                {
                    Type = resolver.SystemModuleManager.ObjectSetType()
                };
                return emptySet;
            }
            else
            {
                Expression s = sets[MutateCSharp.Schemata404.ReplaceNumericConstant_3(122L, 0)];
                for (var i = MutateCSharp.Schemata404.ReplaceNumericConstant_3(126L, 1); MutateCSharp.Schemata404.ReplaceBinExprOp_10(130L, i, sets.Count); MutateCSharp.Schemata404.ReplacePostfixUnaryExprOp_11(135L, ref i))
                {
                    var union = new BinaryExpr(s.tok, BinaryExpr.Opcode.Add, s, sets[i])
                    {
                        ResolvedOp = BinaryExpr.ResolvedOpcode.Union,
                        Type = resolver.SystemModuleManager.ObjectSetType()
                    };
                    s = union;
                }

                return s;
            }

            return default;
        }
    }
}