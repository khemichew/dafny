using System.Collections.Generic;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata505
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT505");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, Microsoft.Dafny.TraitDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

    }
}

namespace Microsoft.Dafny
{
    public class FunctionCallSubstituter : Substituter
    {
        public readonly TraitDecl Tr;
        public readonly TopLevelDeclWithMembers Impl;

        // We replace all occurrences of the trait version of the function with the class version. This is only allowed if
        // the receiver is `this`. We underapproximate this by looking for a `ThisExpr`, which misses more complex
        // expressions that evaluate to one.
        public FunctionCallSubstituter(Dictionary<IVariable, Expression /*!*/> /*!*/ substMap, Dictionary<TypeParameter, Type> typeMap,
          TraitDecl parentTrait, TopLevelDeclWithMembers impl)
          : base(new ThisExpr(impl.tok) { Type = UserDefinedType.FromTopLevelDecl(impl.tok, impl) }, substMap, typeMap)
        {
            Tr = parentTrait;
            Impl = impl;
        }

        public override Expression Substitute(Expression expr)
        {
            if (expr is FunctionCallExpr e)
            {
                var receiver = Substitute(e.Receiver);
                var newArgs = SubstituteExprList(e.Args);
                var typeApplicationAtEnclosingClass = e.TypeApplication_AtEnclosingClass;
                Function function;
                if (MutateCSharp.Schemata505.ReplaceBinExprOp_2(14L, () => MutateCSharp.Schemata505.ReplaceBinExprOp_2(8L, () => (MutateCSharp.Schemata505.ReplaceBinExprOp_1(2L, () => MutateCSharp.Schemata505.ReplaceBinExprOp_0(1L, e.Function.EnclosingClass, Tr), () => Tr.InheritedMembers.Contains(e.Function))), () => e.Receiver.Resolved is ThisExpr), () => receiver.Resolved is ThisExpr) &&
                    Impl.Members.Find(m => m.OverriddenMember == e.Function) is { } f)
                {
                    receiver = new ThisExpr((TopLevelDeclWithMembers)f.EnclosingClass);
                    function = (Function)f;
                    typeApplicationAtEnclosingClass = receiver.Type.AsParentType(Impl).TypeArgs.ToList();
                }
                else
                {
                    function = e.Function;
                }
                return new FunctionCallExpr(e.tok, e.Name, receiver, e.OpenParen, e.CloseParen, newArgs, e.AtLabel)
                {
                    Function = function,
                    Type = e.Type.Subst(typeMap),
                    TypeApplication_AtEnclosingClass = SubstituteTypeList(typeApplicationAtEnclosingClass), // resolve here
                    TypeApplication_JustFunction = SubstituteTypeList(e.TypeApplication_JustFunction), // resolve here
                    IsByMethodCall = e.IsByMethodCall
                };
            }
            return base.Substitute(expr);
        }
    }
}