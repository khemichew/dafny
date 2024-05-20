using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata62
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT62");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.UnaryOpExpr.ResolvedOpcode argument1, Microsoft.Dafny.UnaryOpExpr.ResolvedOpcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.UnaryOpExpr.Opcode argument1, Microsoft.Dafny.UnaryOpExpr.Opcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class UnaryOpExpr : UnaryExpr, ICloneable<UnaryOpExpr>
    {
        public enum Opcode
        {
            Not,  // boolean negation or bitwise negation
            Cardinality,
            Fresh, // fresh also has a(n optional) second argument, namely the @-label
            Allocated,
            Lit,  // there is no syntax for this operator, but it is sometimes introduced during translation
        }
        public readonly Opcode Op;

        public enum ResolvedOpcode
        {
            YetUndetermined,
            BVNot,
            BoolNot,
            SeqLength,
            SetCard,
            MultiSetCard,
            MapCard,
            Fresh,
            Allocated,
            Lit
        }

        private ResolvedOpcode _ResolvedOp = ResolvedOpcode.YetUndetermined;
        public ResolvedOpcode ResolvedOp => ResolveOp();

        public ResolvedOpcode ResolveOp()
        {
            if (MutateCSharp.Schemata62.ReplaceBinExprOp_0(1L, _ResolvedOp, ResolvedOpcode.YetUndetermined))
            {
                Contract.Assert(Type != null);
                Contract.Assert(Type is not TypeProxy);
                _ResolvedOp = (Op, E.Type.NormalizeToAncestorType()) switch
                {
                    (Opcode.Not, BoolType _) => ResolvedOpcode.BoolNot,
                    (Opcode.Not, BitvectorType _) => ResolvedOpcode.BVNot,
                    (Opcode.Cardinality, SeqType _) => ResolvedOpcode.SeqLength,
                    (Opcode.Cardinality, SetType _) => ResolvedOpcode.SetCard,
                    (Opcode.Cardinality, MultiSetType _) => ResolvedOpcode.MultiSetCard,
                    (Opcode.Cardinality, MapType _) => ResolvedOpcode.MapCard,
                    (Opcode.Fresh, _) => ResolvedOpcode.Fresh,
                    (Opcode.Allocated, _) => ResolvedOpcode.Allocated,
                    (Opcode.Lit, _) => ResolvedOpcode.Lit,
                    _ => ResolvedOpcode.YetUndetermined // Unreachable
                };
                Contract.Assert(_ResolvedOp != ResolvedOpcode.YetUndetermined);
            }

            return _ResolvedOp;
        }

        public void SetResolveOp(ResolvedOpcode resolvedOpcode)
        {
            Contract.Assert(resolvedOpcode != ResolvedOpcode.YetUndetermined);
            Contract.Assert(_ResolvedOp == ResolvedOpcode.YetUndetermined || _ResolvedOp == resolvedOpcode);
            _ResolvedOp = resolvedOpcode;
        }

        public UnaryOpExpr(IToken tok, Opcode op, Expression e)
          : base(tok, e)
        {
            Contract.Requires(tok != null);
            Contract.Requires(e != null);
            Contract.Requires(op != Opcode.Fresh || this is FreshExpr);
            this.Op = op;
        }

        public UnaryOpExpr(Cloner cloner, UnaryOpExpr original) : base(cloner, original)
        {
            Op = original.Op;
        }

        public override bool IsImplicit => MutateCSharp.Schemata62.ReplaceBinExprOp_1(2L, Op, Opcode.Lit);
        public UnaryOpExpr Clone(Cloner cloner)
        {
            return new UnaryOpExpr(cloner, this);
        }
    }
}