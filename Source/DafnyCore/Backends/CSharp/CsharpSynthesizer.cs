using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.CSharp;
namespace MutateCSharp
{
    internal class Schemata220
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT220");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.BinaryExpr.Opcode argument1, Microsoft.Dafny.BinaryExpr.Opcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_9(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 - argument2;
        }

        internal static int ReplaceNumericConstant_4(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, System.Tuple<Microsoft.Dafny.IVariable, string> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_7(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.BinaryExpr.Opcode argument1, Microsoft.Dafny.BinaryExpr.Opcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_2(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny.Compilers
{

    /// <summary>
    /// Below is the full grammar of ensures clauses that can specify
    /// the behavior of an object returned by a synthesize-annotated method
    /// (S is the starting symbol, ID refers to a variable/field/method/type
    /// identifier, EXPR stands for an arbitrary Dafny expression):
    ///
    /// S         = FORALL
    ///           | EQUALS 
    ///           | S && S
    /// EQUALS    = ID.ID (ARGLIST)  == EXPR // stubs a method call
    ///           | ID.ID            == EXPR // stubs field access
    ///           | EQUALS && EQUALS
    /// FORALL    = forall BOUNDVARS :: EXPR ==> EQUALS
    /// ARGLIST   = ID   // this can be one of the bound variables
    ///           | EXPR // this expr may not reference any of the bound variables 
    ///           | ARGLIST, ARGLIST
    /// BOUNDVARS = ID : ID 
    ///           | BOUNDVARS, BOUNDVARS
    /// 
    /// </summary>
    public class CsharpSynthesizer
    {

        private readonly CsharpCodeGenerator codeGenerator;
        private readonly ConcreteSyntaxTree ErrorWriter;
        // maps identifiers to the names of the corresponding mock:
        private Dictionary<IVariable, string> objectToMockName = new();
        // associates a bound variable with the lambda passed to argument matcher
        private Dictionary<IVariable, string> bounds = new();
        private Method lastSynthesizedMethod = null;
        private DafnyOptions Options => codeGenerator.Options;

        public CsharpSynthesizer(CsharpCodeGenerator codeGenerator, ConcreteSyntaxTree errorWriter)
        {
            this.codeGenerator = codeGenerator;
            ErrorWriter = errorWriter;
        }

        /// <summary>
        /// Create a body of a method that synthesizes one or more objects.
        /// For instance, the following Dafny method:
        /// 
        /// method {:synthesize} CrossReferentialMock()
        ///     returns (e1:Even, e2:Even) 
        ///     ensures fresh(e1) && fresh(e2) 
        ///     ensures e1.Next() == e2
        ///     ensures e2.Next() == e1
        ///
        /// Gets compiled to the following C# code:
        /// (Note that e1Return and e2Return are introduced because e1 and e2
        /// are used inside a lambda and cannot, therefore, be out parameters)
        ///
        /// public static void CrossReferentialMock(out Even e1Return,
        ///                                         out Even e2Return) {
        ///     var e1Mock = new Mock<Even>();
        ///     var e1 = e1Mock.Object;
        ///     var e2Mock = new Mock<Even>();
        ///     var e2 = e2Mock.Object;
        ///     e1Mock.Setup(x => x.Next()).Returns(()=>e2);
        ///     e2Mock.Setup(x => x.Next()).Returns(()=>e1);
        ///     e1Return = e1;
        ///     e2Return = e2;
        /// }
        /// </summary>
        public ConcreteSyntaxTree SynthesizeMethod(Method method,
          List<SinglePassCodeGenerator.TypeArgumentInstantiation> typeArgs, bool createBody,
          ConcreteSyntaxTree wr, bool forBodyInheritance, bool lookasideBody)
        {

            lastSynthesizedMethod = method;
            // The following few lines are identical to those in Compiler.CreateMethod:
            var customReceiver = MutateCSharp.Schemata220.ReplaceBinExprOp_0(7L, () => MutateCSharp.Schemata220.ReplaceBinExprOp_0(1L, () => createBody, () => !forBodyInheritance), () => codeGenerator.NeedsCustomReceiver(method));
            var keywords = codeGenerator.Keywords(MutateCSharp.Schemata220.ReplaceBooleanConstant_1(13L, true), MutateCSharp.Schemata220.ReplaceBooleanConstant_1(14L, true));
            var returnType = codeGenerator.GetTargetReturnTypeReplacement(method, wr);
            var typeParameters = codeGenerator.TypeParameters(SinglePassCodeGenerator.TypeArgumentInstantiation.
              ToFormals(codeGenerator.ForTypeParameters(typeArgs, method, lookasideBody)));
            var parameters = codeGenerator
              .GetMethodParameters(method, typeArgs, lookasideBody, customReceiver, returnType);

            // Out parameters cannot be used inside lambda expressions in Csharp
            // but the mocked objects may appear in lambda expressions during
            // mocking (e.g. two objects may cross-reference each other).
            // The solution is to rename the out parameters.
            var parameterString = parameters.ToString();
            var objectToReturnName = method.Outs.ToDictionary(o => o,
              o => codeGenerator.idGenerator.FreshId(o.CompileName + MutateCSharp.Schemata220.ReplaceStringConstant_2(15L, "Return")));
            foreach (var (obj, returnName) in objectToReturnName)
            {
                parameterString = Regex.Replace(parameterString,
                  $"(^|[^a-zA-Z0-9_]){obj.CompileName}([^a-zA-Z0-9_]|$)",
          MutateCSharp.Schemata220.ReplaceStringConstant_2(16L, "$1") + returnName + MutateCSharp.Schemata220.ReplaceStringConstant_2(17L, "$2"));
            }
            wr.FormatLine($"{keywords}{returnType} {codeGenerator.PublicIdProtect(method.GetCompileName(Options))}{typeParameters}({parameterString}) {{");

            // Initialize the mocks
            objectToMockName = method.Outs.ToDictionary(o => (IVariable)o,
              o => codeGenerator.idGenerator.FreshId(o.CompileName + MutateCSharp.Schemata220.ReplaceStringConstant_2(18L, "Mock")));
            foreach (var (obj, mockName) in objectToMockName)
            {
                var typeName = codeGenerator.TypeName(obj.Type, wr, obj.Tok);
                // Mocking a trait works only so long as no trait member is accessed
                if ((method.Outs.First().Type is UserDefinedType userDefinedType) &&
                    userDefinedType.IsTraitType)
                {
                    wr.FormatLine($"var {mockName} = new Mock<{typeName}>(MockBehavior.Strict);");
                }
                else
                {
                    wr.FormatLine($"var {mockName} = new Mock<{typeName}>();");
                    wr.FormatLine($"{mockName}.CallBase = true;");
                }
                wr.FormatLine($"var {obj.CompileName} = {mockName}.Object;");
            }

            // Stub methods and fields according to the Dafny post-conditions:
            foreach (var ensureClause in method.Ens)
            {
                bounds = new();
                var wStmts = wr.Fork();
                SynthesizeExpression(wr, ensureClause.E, wStmts);
            }

            // Return the mocked objects:
            if (MutateCSharp.Schemata220.ReplaceBinExprOp_3(20L, returnType, MutateCSharp.Schemata220.ReplaceStringConstant_2(19L, "void")))
            {
                wr.FormatLine($"return {method.Outs[MutateCSharp.Schemata220.ReplaceNumericConstant_4(21L, 0)].CompileName};");
            }
            else
            {
                foreach (var o in method.Outs)
                {
                    wr.FormatLine($"{objectToReturnName[o]} = {o.CompileName};");
                }
            }
            wr.WriteLine(MutateCSharp.Schemata220.ReplaceStringConstant_2(25L, "}"));
            return wr;
        }

        /// <summary>
        /// If the expression is a bound variable identifier, return the
        /// variable and the string representation of the bounding condition
        /// </summary>
        private Tuple<IVariable, string> GetBound(Expression exp)
        {
            if (exp is not NameSegment)
            {
                return null;
            }
            var variable = ((IdentifierExpr)exp.Resolved).Var;
            if (!bounds.ContainsKey(variable))
            {
                return null;
            }
            return new Tuple<IVariable, string>(variable, bounds[variable]);
        }

        private void SynthesizeExpression(ConcreteSyntaxTree wr, Expression expr, ConcreteSyntaxTree wStmts)
        {
            switch (expr)
            {
                case LiteralExpr literalExpr:
                    wr.Append(codeGenerator.Expr(literalExpr, false, wStmts));
                    break;
                    break;
                case ApplySuffix applySuffix:
                    SynthesizeExpression(wr, applySuffix, wStmts);
                    break;
                    break;
                case BinaryExpr binaryExpr:
                    SynthesizeExpression(wr, binaryExpr, wStmts);
                    break;
                    break;
                case ForallExpr forallExpr:
                    SynthesizeExpression(wr, forallExpr, wStmts);
                    break;
                    break;
                case FreshExpr:
                    break;
                    break;
                default:
                    // TODO: Have the resolver reject all these unimplemented cases,
                    // or convert them to UnsupportedFeatureExceptions
                    throw new NotImplementedException();
                    break;
            }
        }

        private void SynthesizeExpression(ConcreteSyntaxTree wr, ApplySuffix applySuffix, ConcreteSyntaxTree wStmts)
        {

            var methodApp = (ExprDotName)applySuffix.Lhs;
            var receiver = ((IdentifierExpr)methodApp.Lhs.Resolved).Var;
            var method = ((MemberSelectExpr)methodApp.Resolved).Member;
            var methodName = method.GetCompileName(Options);

            if (MutateCSharp.Schemata220.ReplaceBinExprOp_5(30L, ((Function)method).Ens.Count, MutateCSharp.Schemata220.ReplaceNumericConstant_4(26L, 0)))
            {
                codeGenerator.Reporter.Warning(MessageSource.Compiler,
                    GeneratorErrors.ErrorId.c_possibly_unsatisfied_postconditions, lastSynthesizedMethod.tok,
          MutateCSharp.Schemata220.ReplaceStringConstant_2(35L, "Post-conditions on function {0} might ") +
          MutateCSharp.Schemata220.ReplaceStringConstant_2(36L, "be unsatisfied when synthesizing code ") +
          MutateCSharp.Schemata220.ReplaceStringConstant_2(37L, "for method {1}"),
                  methodName, lastSynthesizedMethod.Name);
            }

            var tmpId = codeGenerator.idGenerator.FreshId(MutateCSharp.Schemata220.ReplaceStringConstant_2(38L, "tmp"));
            wr.Format($"{objectToMockName[receiver]}.Setup({tmpId} => {tmpId}.{methodName}(");

            // The remaining part of the method uses Moq's argument matching to
            // describe the arguments for which the method should be stubbed
            // (in Dafny, this condition is the antecedent over bound variables)
            for (int i = MutateCSharp.Schemata220.ReplaceNumericConstant_4(39L, 0); MutateCSharp.Schemata220.ReplaceBinExprOp_6(43L, i, applySuffix.Args.Count); MutateCSharp.Schemata220.ReplacePostfixUnaryExprOp_7(48L, ref i))
            {
                var arg = applySuffix.Args[i];
                var bound = GetBound(arg);
                if (MutateCSharp.Schemata220.ReplaceBinExprOp_8(49L, bound, null))
                { // if true, arg is a bound variable
                    wr.Write(bound.Item2);
                }
                else
                {
                    wr.Append(codeGenerator.Expr(arg, MutateCSharp.Schemata220.ReplaceBooleanConstant_1(50L, false), wStmts));
                }
                if (MutateCSharp.Schemata220.ReplaceBinExprOp_5(64L, i, MutateCSharp.Schemata220.ReplaceBinExprOp_9(55L, applySuffix.Args.Count, MutateCSharp.Schemata220.ReplaceNumericConstant_4(51L, 1))))
                {
                    wr.Write(MutateCSharp.Schemata220.ReplaceStringConstant_2(69L, ", "));
                }
            }
            wr.Write(MutateCSharp.Schemata220.ReplaceStringConstant_2(70L, "))"));
        }

        private void SynthesizeExpression(ConcreteSyntaxTree wr, BinaryExpr binaryExpr, ConcreteSyntaxTree wStmts)
        {
            if (MutateCSharp.Schemata220.ReplaceBinExprOp_10(71L, binaryExpr.Op, BinaryExpr.Opcode.And))
            {
                Dictionary<IVariable, string> oldBounds = bounds
                  .ToDictionary(entry => entry.Key, entry => entry.Value);
                SynthesizeExpression(wr, binaryExpr.E0, wStmts);
                bounds = oldBounds;
                SynthesizeExpression(wr, binaryExpr.E1, wStmts);
                return;
            }
            if (MutateCSharp.Schemata220.ReplaceBinExprOp_11(72L, binaryExpr.Op, BinaryExpr.Opcode.Eq))
            {
                throw new NotImplementedException();
            }
            if (binaryExpr.E0 is ExprDotName exprDotName)
            { // field stubbing
                var obj = ((IdentifierExpr)exprDotName.Lhs.Resolved).Var;
                var field = ((MemberSelectExpr)exprDotName.Resolved).Member;
                var fieldName = field.GetCompileName(Options);
                codeGenerator.Reporter.Warning(MessageSource.Compiler,
                  GeneratorErrors.ErrorId.c_stubbing_fields_not_recommended, lastSynthesizedMethod.tok,
          MutateCSharp.Schemata220.ReplaceStringConstant_2(73L, "Stubbing fields is not recommended (field {0} of object {1} inside method {2})"),
                  fieldName, obj.Name, lastSynthesizedMethod.Name);
                var tmpId = codeGenerator.idGenerator.FreshId(MutateCSharp.Schemata220.ReplaceStringConstant_2(74L, "tmp"));
                wr.Format($"{objectToMockName[obj]}.SetupGet({tmpId} => {tmpId}.@{fieldName}).Returns( ");
                wr.Append(codeGenerator.Expr(binaryExpr.E1, MutateCSharp.Schemata220.ReplaceBooleanConstant_1(75L, false), wStmts));
                wr.WriteLine(MutateCSharp.Schemata220.ReplaceStringConstant_2(76L, ");"));
                return;
            }
            if (binaryExpr.E0 is not ApplySuffix applySuffix)
            {
                throw new NotImplementedException();
            }
            SynthesizeExpression(wr, applySuffix, wStmts);
            wr.Write(MutateCSharp.Schemata220.ReplaceStringConstant_2(77L, ".Returns("));
            wr.Write(MutateCSharp.Schemata220.ReplaceStringConstant_2(78L, "("));
            for (int i = MutateCSharp.Schemata220.ReplaceNumericConstant_4(79L, 0); MutateCSharp.Schemata220.ReplaceBinExprOp_6(83L, i, applySuffix.Args.Count); MutateCSharp.Schemata220.ReplacePostfixUnaryExprOp_7(88L, ref i))
            {
                var arg = applySuffix.Args[i];
                var typeName = codeGenerator.TypeName(arg.Type, wr, arg.tok);
                var bound = GetBound(arg);
                if (MutateCSharp.Schemata220.ReplaceBinExprOp_8(89L, bound, null))
                {
                    wr.Format($"{typeName} {bound.Item1.CompileName}");
                }
                else
                {
                    // if the argument is not a bound variable, it is irrelevant to the
                    // expression in the lambda
                    wr.Format($"{typeName} _");
                }
                if (MutateCSharp.Schemata220.ReplaceBinExprOp_5(103L, i, MutateCSharp.Schemata220.ReplaceBinExprOp_9(94L, applySuffix.Args.Count, MutateCSharp.Schemata220.ReplaceNumericConstant_4(90L, 1))))
                {
                    wr.Write(MutateCSharp.Schemata220.ReplaceStringConstant_2(108L, ", "));
                }
            }
            wr.Write(MutateCSharp.Schemata220.ReplaceStringConstant_2(109L, ")=>"));
            wr.Append(codeGenerator.Expr(binaryExpr.E1, MutateCSharp.Schemata220.ReplaceBooleanConstant_1(110L, false), wStmts));
            wr.WriteLine(MutateCSharp.Schemata220.ReplaceStringConstant_2(111L, ");"));
        }

        private void SynthesizeExpression(ConcreteSyntaxTree wr, ForallExpr forallExpr, ConcreteSyntaxTree wStmts)
        {
            if (forallExpr.Term is not BinaryExpr binaryExpr)
            {
                throw new NotImplementedException();
            }
            var declarations = new List<string>();

            // a MultiMatcher is created to convert an antecedent of the implication
            // following the forall statement to argument matching calls in Moq
            var matcherName = codeGenerator.idGenerator.FreshId(MutateCSharp.Schemata220.ReplaceStringConstant_2(112L, "matcher"));

            var tmpId = codeGenerator.idGenerator.FreshId(MutateCSharp.Schemata220.ReplaceStringConstant_2(113L, "tmp"));
            for (int i = MutateCSharp.Schemata220.ReplaceNumericConstant_4(114L, 0); MutateCSharp.Schemata220.ReplaceBinExprOp_6(118L, i, forallExpr.BoundVars.Count); MutateCSharp.Schemata220.ReplacePostfixUnaryExprOp_7(123L, ref i))
            {
                var boundVar = forallExpr.BoundVars[i];
                var varType = codeGenerator.TypeName(boundVar.Type, wr, boundVar.tok);
                bounds[boundVar] = $"It.Is<{varType}>(x => {matcherName}.Match(x))";
                declarations.Add($"var {boundVar.CompileName} = ({varType}) {tmpId}[{i}];");
            }

            wr.WriteLine($"var {matcherName} = new Dafny.MultiMatcher({declarations.Count}, {tmpId} => {{");
            foreach (var declaration in declarations)
            {
                wr.WriteLine($"\t{declaration}");
            }

            switch (binaryExpr.Op)
            {
                case BinaryExpr.Opcode.Imp:
                    wr.Write("\treturn ");
                    wr.Append(codeGenerator.Expr(binaryExpr.E0, false, wStmts));
                    wr.WriteLine(";");
                    binaryExpr = (BinaryExpr)binaryExpr.E1.Resolved;
                    break;
                    break;
                case BinaryExpr.Opcode.Eq:
                    wr.WriteLine("\treturn true;");
                    break;
                    break;
                default:
                    throw new NotImplementedException();
                    break;
            }
            wr.WriteLine(MutateCSharp.Schemata220.ReplaceStringConstant_2(124L, "});"));
            SynthesizeExpression(wr, binaryExpr, wStmts);
        }

        /// <summary>
        /// Adds MultiMatcher class to the specified ConcreteSyntaxTree.
        /// MultiMatcher allows converting one expression over many arguments
        /// (like ones one finds in Dafny in antecedent of a forall statement)
        /// to many separate predicates over each argument (which is how argument
        /// matching is done in expressionC#'s Moq library)
        /// So, for instance, a Dafny postcondition
        ///   forall a,b:int :: a > b ==> o.m(a, b) == 4
        /// is converted to:
        /// 
        ///   var matcher = new Dafny.MultiMatcher(2, args => {
        ///     return args[0] > args[1];
        ///   });
        ///   o.Setup(x => x.m(It.Is<int>(a => matcher.Match(a)),
        ///                    It.Is<int>(b => matcher.Match(b)))).Returns(4);
        /// 
        /// </summary>
        internal static void EmitMultiMatcher(ConcreteSyntaxTree dafnyNamespace)
        {
            const string multiMatcher = @"
    internal class MultiMatcher {

      private readonly Func<object[], bool> predicate;
      private readonly int argumentCount;
      private readonly List<object> collectedArguments;

      public MultiMatcher(int argumentCount, Func<object[], bool> predicate) {
        this.predicate = predicate;
        this.argumentCount = argumentCount;
        collectedArguments = new List<object>();
      }

      public bool Match(object argument) {
        collectedArguments.Add(argument);
        if (collectedArguments.Count != argumentCount) {
          return true;
        }
        bool result = predicate(collectedArguments.ToArray());
        collectedArguments.Clear();
        return result;
      }
    }";
            var memberDeclaration = SyntaxFactory.ParseMemberDeclaration(multiMatcher);
            dafnyNamespace.WriteLine(memberDeclaration.ToFullString());
        }

        internal static void EmitImports(ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata220.ReplaceStringConstant_2(125L, "using Moq;"));
            wr.WriteLine(MutateCSharp.Schemata220.ReplaceStringConstant_2(126L, "using System.Collections.Generic;"));
        }
    }
}