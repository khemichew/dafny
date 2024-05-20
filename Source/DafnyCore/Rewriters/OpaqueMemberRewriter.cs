using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata455
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT455");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_5(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
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

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_3(long mutantId, ref int argument1)
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

    }
}

namespace Microsoft.Dafny
{

    /// <summary>
    /// For any function foo() with the :opaque attribute,
    /// hide the body, so that it can only be seen within its
    /// recursive clique (if any), or if the programmer
    /// specifically asks to see it via the reveal_foo() lemma
    /// </summary>
    public class OpaqueMemberRewriter : IRewriter
    {
        protected Dictionary<Method, Function> revealOriginal; // Map reveal_* lemmas (or two-state lemmas) back to their original functions

        public OpaqueMemberRewriter(ErrorReporter reporter)
          : base(reporter)
        {
            Contract.Requires(reporter != null);

            revealOriginal = new Dictionary<Method, Function>();
        }

        internal override void PreResolve(ModuleDefinition m)
        {
            foreach (var d in m.TopLevelDecls)
            {
                if (d is TopLevelDeclWithMembers)
                {
                    ProcessOpaqueClassMembers((TopLevelDeclWithMembers)d);
                }
            }
        }

        internal override void PostResolveIntermediate(ModuleDefinition m)
        {
            foreach (var decl in ModuleDefinition.AllCallables(m.TopLevelDecls))
            {
                if (decl is Lemma or TwoStateLemma)
                {
                    var lem = (Method)decl;
                    if (revealOriginal.ContainsKey(lem))
                    {
                        var fn = revealOriginal[lem];
                        AnnotateRevealFunction(lem, fn);
                    }
                }
            }
        }

        protected void AnnotateRevealFunction(Method lemma, Function f)
        {
            Contract.Requires(lemma is Lemma || lemma is TwoStateLemma);
            Expression receiver;
            if (f.IsStatic)
            {
                receiver = new StaticReceiverExpr(f.tok, (TopLevelDeclWithMembers)f.EnclosingClass, MutateCSharp.Schemata455.ReplaceBooleanConstant_0(1L, true));
            }
            else
            {
                receiver = new ImplicitThisExpr(f.tok);
                //receiver.Type = GetThisType(expr.tok, (TopLevelDeclWithMembers)member.EnclosingClass);  // resolve here
            }
            var typeApplication = new List<Type>();
            var typeApplication_JustForMember = new List<Type>();
            for (int i = MutateCSharp.Schemata455.ReplaceNumericConstant_1(2L, 0); MutateCSharp.Schemata455.ReplaceBinExprOp_2(6L, i, f.TypeArgs.Count); MutateCSharp.Schemata455.ReplacePostfixUnaryExprOp_3(11L, ref i))
            {
                // doesn't matter what type, just so we have it to make the resolver happy when resolving function member of
                // the fuel attribute. This might not be needed after fixing codeplex issue #172.
                typeApplication.Add(new IntType());
                typeApplication_JustForMember.Add(new IntType());
            }
            var nameSegment = new NameSegment(f.tok, f.Name, MutateCSharp.Schemata455.ReplaceBinExprOp_4(16L, f.TypeArgs.Count, MutateCSharp.Schemata455.ReplaceNumericConstant_1(12L, 0)) ? null : typeApplication);
            var rr = new MemberSelectExpr(f.tok, receiver, f.Name);
            rr.Member = f;
            rr.TypeApplication_AtEnclosingClass = typeApplication;
            rr.TypeApplication_JustMember = typeApplication_JustForMember;
            List<Type> args = new List<Type>();
            for (int i = MutateCSharp.Schemata455.ReplaceNumericConstant_1(21L, 0); MutateCSharp.Schemata455.ReplaceBinExprOp_2(25L, i, f.Ins.Count); MutateCSharp.Schemata455.ReplacePostfixUnaryExprOp_3(30L, ref i))
            {
                args.Add(new IntType());
            }
            rr.Type = new ArrowType(f.tok, args, new IntType());
            nameSegment.ResolvedExpression = rr;
            nameSegment.Type = rr.Type;
            lemma.Attributes = new Attributes(MutateCSharp.Schemata455.ReplaceStringConstant_5(31L, "revealedFunction"), new List<Expression>() { nameSegment }, lemma.Attributes);
        }


        // Tells the function to use 0 fuel by default
        protected void ProcessOpaqueClassMembers(TopLevelDeclWithMembers c)
        {
            Contract.Requires(c != null);
            var newDecls = new List<MemberDecl>();
            foreach (var member in c.Members.Where(member => member is Function or ConstantField))
            {
                if (!ShouldBeRevealed(member))
                {
                    // Nothing to do
                }
                else if (member is Function { Body: null })
                {
                    // Nothing to do
                }
                else if (!RefinementToken.IsInherited(member.tok, c.EnclosingModuleDefinition))
                {
                    GenerateRevealLemma(member, newDecls);
                }
            }
            c.Members.AddRange(newDecls);
        }

        private bool ShouldBeRevealed(MemberDecl member)
        {
            return MutateCSharp.Schemata455.ReplaceBinExprOp_6(33L, () => Attributes.Contains(member.Attributes, MutateCSharp.Schemata455.ReplaceStringConstant_5(32L, "opaque"))
        , () => member.IsOpaque
        ) || (member is Function func && func.IsMadeImplicitlyOpaque(Options));
        }
        private void GenerateRevealLemma(MemberDecl m, List<MemberDecl> newDecls)
        {
            if (m is Function f)
            {

                // TODO: The following comment will need to be updated.
                // That is, given:
                //   function {:opaque} foo(x:int, y:int) : int
                //     requires 0 <= x < 5;
                //     requires 0 <= y < 5;
                //     ensures foo(x, y) < 10;
                //   { x + y }
                // We produce:
                //   lemma {:axiom} {:auto_generated} {:fuel foo, 1, 2 } reveal_foo()
                //
                // If "foo" is a two-state function, then "reveal_foo" will be declared as a two-state lemma.
                //
                // The translator, in AddMethod, then adds ensures clauses to bump up the fuel parameters appropriately

                var cloner = new Cloner();

                List<TypeParameter> typeVars = new List<TypeParameter>();
                List<Type> optTypeArgs = new List<Type>();
                foreach (var tp in f.TypeArgs)
                {
                    typeVars.Add(cloner.CloneTypeParam(tp));
                    // doesn't matter what type, just so we have it to make the resolver happy when resolving function member of
                    // the fuel attribute. This might not be needed after fixing codeplex issue #172.
                    optTypeArgs.Add(new IntType());
                }
            }

            // Given:
            //   const {:opaque} foo := x
            // We produce:
            //   lemma {:auto_generated} {:opaque_reveal} {:verify false} reveal_foo()
            //     ensures foo == x

            // Add an axiom attribute so that the compiler won't complain about the lemma's lack of a body
            Attributes lemma_attrs = null;
            if (m is Function)
            {
                lemma_attrs = new Attributes(MutateCSharp.Schemata455.ReplaceStringConstant_5(39L, "axiom"), new List<Expression>(), lemma_attrs);
            }
            lemma_attrs = new Attributes(MutateCSharp.Schemata455.ReplaceStringConstant_5(40L, "auto_generated"), new List<Expression>(), lemma_attrs);
            lemma_attrs = new Attributes(MutateCSharp.Schemata455.ReplaceStringConstant_5(41L, "opaque_reveal"), new List<Expression>(), lemma_attrs);
            lemma_attrs = new Attributes(MutateCSharp.Schemata455.ReplaceStringConstant_5(42L, "verify"), new List<Expression>() { new LiteralExpr(m.tok, MutateCSharp.Schemata455.ReplaceBooleanConstant_0(43L, false)) }, lemma_attrs);
            var ens = new List<AttributedExpression>();

            var isStatic = MutateCSharp.Schemata455.ReplaceBooleanConstant_0(44L, true);
            if (m is ConstantField { Rhs: not null } c)
            {
                ens.Add(new AttributedExpression(new BinaryExpr(c.tok, BinaryExpr.Opcode.Eq, new NameSegment(c.Tok, c.Name, null), c.Rhs)));
                isStatic = m.HasStaticKeyword;
            }
            Method reveal;
            if (m is TwoStateFunction)
            {
                reveal = new TwoStateLemma(m.RangeToken.MakeAutoGenerated(), m.NameNode.Prepend(RevealStmt.RevealLemmaPrefix), isStatic,
                  new List<TypeParameter>(), new List<Formal>(), new List<Formal>(), new List<AttributedExpression>(),
                  new Specification<FrameExpression>(), new Specification<FrameExpression>(), ens,
                  new Specification<Expression>(new List<Expression>(), null), null, lemma_attrs, null);
            }
            else
            {
                reveal = new Lemma(m.RangeToken.MakeAutoGenerated(), m.NameNode.Prepend(RevealStmt.RevealLemmaPrefix), isStatic, new List<TypeParameter>(),
                  new List<Formal>(), new List<Formal>(), new List<AttributedExpression>(),
                  new Specification<FrameExpression>(), new Specification<FrameExpression>(), ens,
                  new Specification<Expression>(new List<Expression>(), null), null, lemma_attrs, null);
            }
            newDecls.Add(reveal);
            reveal.InheritVisibility(m, MutateCSharp.Schemata455.ReplaceBooleanConstant_0(45L, true));
            if (m is Function fn)
            {
                revealOriginal[reveal] = fn;
            }
        }
    }
}
