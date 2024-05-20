using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata74
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT74");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceNumericConstant_0(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.IVariable argument1, Microsoft.Dafny.IVariable argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class IdentifierExpr : Expression, IHasUsages, ICloneable<IdentifierExpr>
    {
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(Name != null);
        }

        public readonly string Name;
        [FilledInDuringResolution] public IVariable Var;

        public string DafnyName => MutateCSharp.Schemata74.ReplaceBinExprOp_1(5L, tok.line, MutateCSharp.Schemata74.ReplaceNumericConstant_0(1L, 0)) ? RangeToken.PrintOriginal() : Name;

        public IdentifierExpr(IToken tok, string name)
          : base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(name != null);
            Name = name;
        }
        /// <summary>
        /// Constructs a resolved IdentifierExpr.
        /// </summary>
        public IdentifierExpr(IToken tok, IVariable v)
          : base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(v != null);
            Name = v.Name;
            Var = v;
            Type = v.Type;
        }

        public IdentifierExpr Clone(Cloner cloner)
        {
            return new IdentifierExpr(cloner, this);
        }

        public IdentifierExpr(Cloner cloner, IdentifierExpr original) : base(cloner, original)
        {
            Name = original.Name;

            if (cloner.CloneResolvedFields)
            {
                Var = cloner.CloneIVariable(original.Var, MutateCSharp.Schemata74.ReplaceBooleanConstant_2(10L, true));
            }
        }

        /// <summary>
        /// Returns whether or not "expr" is an IdentifierExpr for "variable".
        /// </summary>
        public static bool Is(Expression expr, IVariable variable)
        {
            return expr.Resolved is IdentifierExpr identifierExpr && MutateCSharp.Schemata74.ReplaceBinExprOp_3(11L, identifierExpr.Var, variable);
        }

        public IEnumerable<IDeclarationOrUsage> GetResolvedDeclarations()
        {
            return Enumerable.Repeat(Var, MutateCSharp.Schemata74.ReplaceNumericConstant_0(12L, 1));
        }

        public IToken NameToken => tok;
        public override IEnumerable<INode> Children { get; } = Enumerable.Empty<Node>();
    }

    /// <summary>
    /// An implicit identifier is used in the context of a ReturnStmt tacetly
    /// assigning a value to a Method's out parameter.
    /// </summary>
    public class ImplicitIdentifierExpr : IdentifierExpr
    {
        public ImplicitIdentifierExpr(IToken tok, string name)
          : base(tok, name) { }

        /// <summary>
        /// Constructs a resolved implicit identifier.
        /// </summary>
        public ImplicitIdentifierExpr(IToken tok, IVariable v)
          : base(tok, v) { }

        public override bool IsImplicit => MutateCSharp.Schemata74.ReplaceBooleanConstant_2(16L, true);
    }
}