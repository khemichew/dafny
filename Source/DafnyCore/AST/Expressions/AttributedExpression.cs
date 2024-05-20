using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata19
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT19");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
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

        internal static int ReplaceNumericConstant_2(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static int ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 + argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class AttributedExpression : TokenNode, IAttributeBearingDeclaration
    {
        public readonly Expression E;
        public readonly AssertLabel/*?*/ Label;

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(E != null);
        }

        private Attributes attributes;
        public Attributes Attributes
        {
            get
            {
                return attributes;
            }
            set
            {
                attributes = value;
            }
        }

        public override RangeToken RangeToken => E.RangeToken;

        public bool HasAttributes()
        {
            return MutateCSharp.Schemata19.ReplaceBinExprOp_0(1L, Attributes, null);
        }

        public AttributedExpression(Expression e)
          : this(e, null)
        {
            Contract.Requires(e != null);
        }

        public AttributedExpression(Expression e, Attributes attrs) : this(e, null, attrs)
        {
        }

        public AttributedExpression(Expression e, AssertLabel/*?*/ label, Attributes attrs)
        {
            Contract.Requires(e != null);
            E = e;
            Label = label;
            Attributes = attrs;
            this.tok = e.Tok;
        }

        public void AddCustomizedErrorMessage(IToken tok, string s)
        {
            var args = new List<Expression>() { new StringLiteralExpr(tok, s, MutateCSharp.Schemata19.ReplaceBooleanConstant_1(2L, true)) };
            IToken openBrace = tok;
            IToken closeBrace = new Token(tok.line, MutateCSharp.Schemata19.ReplaceBinExprOp_3(29L, MutateCSharp.Schemata19.ReplaceBinExprOp_3(16L, MutateCSharp.Schemata19.ReplaceBinExprOp_3(7L, tok.col, MutateCSharp.Schemata19.ReplaceNumericConstant_2(3L, 7)), s.Length), MutateCSharp.Schemata19.ReplaceNumericConstant_2(25L, 1))); // where 7 = length(":error ")
            this.Attributes = new UserSuppliedAttributes(tok, openBrace, closeBrace, args, this.Attributes);
        }

        public override IEnumerable<INode> Children =>
          (MutateCSharp.Schemata19.ReplaceBinExprOp_0(38L, Attributes, null) ? new List<Node>() { Attributes } : Enumerable.Empty<Node>()).Concat(
            new List<Node>() { E });

        public override IEnumerable<INode> PreResolveChildren => Children;
    }
}