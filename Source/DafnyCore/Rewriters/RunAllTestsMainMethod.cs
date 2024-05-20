using System.Collections.Generic;
using System.CommandLine;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text.RegularExpressions;
using DafnyCore;
using static Microsoft.Dafny.RewriterErrors;
namespace MutateCSharp
{
    internal class Schemata465
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT465");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_4(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
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
    public class RunAllTestsMainMethod : IRewriter
    {

        static RunAllTestsMainMethod()
        {
            DooFile.RegisterNoChecksNeeded(IncludeTestRunner, MutateCSharp.Schemata465.ReplaceBooleanConstant_0(1L, false));
        }

        public static Option<bool> IncludeTestRunner = new(MutateCSharp.Schemata465.ReplaceStringConstant_1(2L, "--include-test-runner"),
      MutateCSharp.Schemata465.ReplaceStringConstant_1(3L, "Include a program entry point that will run all methods marked with {:test}"));

        /** The name used for Main when executing tests. Should be a name that cannot be a Dafny name,
            that Dafny will not use as a mangled Dafny name for any backend, and that is not likely
            to be chosen by the user as an extern name. **/
        public static string SyntheticTestMainName = MutateCSharp.Schemata465.ReplaceStringConstant_1(4L, "_Test__Main_");

        public RunAllTestsMainMethod(ErrorReporter reporter) : base(reporter)
        {
        }

        /// <summary>
        /// Verifies that there isn't already a main method, and then creates
        /// one with no body (to be filled in by PostResolve()).
        ///
        /// It might be possible to move this to PostResolve() if we created a resolved
        /// Method instead, but for now this is a bit easier. It also allows us to produce
        /// errors much earlier in the pipeline.
        /// </summary>
        internal override void PreResolve(Program program)
        {

            // Verifying the method isn't yet possible since the translation of try/recover statments is not implemented,
            // and would be low-value anyway.
            var noVerifyAttribute = new Attributes(MutateCSharp.Schemata465.ReplaceStringConstant_1(5L, "verify"), new List<Expression> { new LiteralExpr(Token.NoToken, MutateCSharp.Schemata465.ReplaceBooleanConstant_0(6L, false)) }, null);

            var mainMethod = new Method(RangeToken.NoToken.MakeAutoGenerated(), new Name(SyntheticTestMainName), MutateCSharp.Schemata465.ReplaceBooleanConstant_0(7L, false), MutateCSharp.Schemata465.ReplaceBooleanConstant_0(8L, false),
              new List<TypeParameter>(), new List<Formal>(), new List<Formal>(),
              new List<AttributedExpression>(),
              new Specification<FrameExpression>(),
              new Specification<FrameExpression>(new List<FrameExpression>(), null),
              new List<AttributedExpression>(), new Specification<Expression>(new List<Expression>(), null),
              null, noVerifyAttribute, null);
            mainMethod.Attributes = new Attributes(MutateCSharp.Schemata465.ReplaceStringConstant_1(9L, "main"), new List<Expression>(), mainMethod.Attributes);
            var defaultClass = program.DefaultModule.ModuleDef.DefaultClass;
            defaultClass.Members.Add(mainMethod);
        }

        /// <summary>
        /// Generates the main method body that invokes every {:test} method and prints
        /// out the results.
        ///
        /// Note that this needs to be post-resolving so we can determine if each test method
        /// has a return value we need to check for IsFailure(). That means all the AST nodes
        /// we create need to be already fully-resolved.
        ///
        /// Example output:
        ///
        /// var success := true;
        /// 
        /// print "SomeModule.TestMethod1: ";
        /// try {
        ///   var result := SomeModule.TestMethod1();
        ///   if result.IsFailure() {
        ///     print "FAILED\n\t", result, "\n";
        ///     success := false;
        ///   } else {
        ///     print "PASSED\n";
        ///   }
        /// } recover (haltMessage: string) {
        ///   print "FAILED\n\t", haltMessage, "\n";
        ///   success := false;
        /// }
        /// 
        /// print "SomeOtherModule.TestMethod2NoResultValue: ";
        /// try {
        ///   SomeOtherModule.TestMethod2NoResultValue();
        ///   print "PASSED\n";
        /// } recover (haltMessage: string) {
        ///   print "FAILED\n\t", haltMessage, "\n";
        ///   success := false;
        /// }
        /// 
        /// ...
        ///
        /// if !success {
        ///   print "Test failures occurred: see above.\n";
        /// }
        /// </summary>
        internal override void PostResolve(Program program)
        {
            var tok = program.GetStartOfFirstFileToken();
            List<Statement> mainMethodStatements = new();
            var idGenerator = new FreshIdGenerator();

            // var success := true;
            var successVarStmt = Statement.CreateLocalVariable(tok, MutateCSharp.Schemata465.ReplaceStringConstant_1(10L, "success"), Expression.CreateBoolLiteral(tok, MutateCSharp.Schemata465.ReplaceBooleanConstant_0(11L, true)));
            mainMethodStatements.Add(successVarStmt);
            var successVar = successVarStmt.Locals[MutateCSharp.Schemata465.ReplaceNumericConstant_2(12L, 0)];
            var successVarExpr = new IdentifierExpr(tok, successVar);

            // Don't use Type.String() because that's an unresolved type
            var seqCharType = new SeqType(Type.Char);

            foreach (var moduleDefinition in program.CompileModules)
            {
                foreach (var callable in ModuleDefinition.AllCallables(moduleDefinition.TopLevelDecls))
                {
                    if ((callable is Method method) && Attributes.Contains(method.Attributes, MutateCSharp.Schemata465.ReplaceStringConstant_1(16L, "test")))
                    {
                        var regex = program.Options.MethodsToTest;
                        if (!System.String.IsNullOrEmpty(regex))
                        {
                            string name = method.FullDafnyName;
                            if (!Regex.Match(name, regex).Success)
                            {
                                continue;
                            }
                        }

                        // print "TestMethod: ";
                        mainMethodStatements.Add(Statement.CreatePrintStmt(tok,
                          Expression.CreateStringLiteral(tok, $"{method.FullDafnyName}: ")));

                        // If the test method returns a value:
                        //
                        // var result := TestMethod();
                        // if result.IsFailure() {
                        //   print "FAILED\n\t", result, "\n";
                        //   success := false;
                        // } else {
                        //   print "PASSED\n";
                        // }
                        //
                        // Otherwise, just:
                        //
                        // TestMethod();
                        // print "PASSED\n";
                        var tryBodyStatements = new List<Statement>();

                        var receiverExpr = new StaticReceiverExpr(tok, (TopLevelDeclWithMembers)method.EnclosingClass, MutateCSharp.Schemata465.ReplaceBooleanConstant_0(17L, true));
                        var methodSelectExpr = new MemberSelectExpr(tok, receiverExpr, method.Name)
                        {
                            Member = method,
                            TypeApplication_JustMember = new List<Type>(),
                            TypeApplication_AtEnclosingClass = new List<Type>()
                        };

                        if (MutateCSharp.Schemata465.ReplaceBinExprOp_3(22L, method.Ins.Count, MutateCSharp.Schemata465.ReplaceNumericConstant_2(18L, 0)))
                        {
                            ReportError(ErrorId.rw_test_methods_may_not_have_inputs, method.tok,
                MutateCSharp.Schemata465.ReplaceStringConstant_1(27L, "Methods with the :test attribute may not have input arguments"));
                            continue;
                        }

                        if (MutateCSharp.Schemata465.ReplaceBinExprOp_3(32L, method.TypeArgs.Count, MutateCSharp.Schemata465.ReplaceNumericConstant_2(28L, 0)))
                        {
                            ReportError(ErrorId.rw_test_methods_may_not_have_type_parameters, method.tok,
                MutateCSharp.Schemata465.ReplaceStringConstant_1(37L, "Methods with the :test attribute may not have type parameters"));
                            continue;
                        }

                        Expression resultVarExpr = null;
                        var lhss = new List<Expression>();

                        // If the method returns a value, check for a failure using IsFailure() as if this
                        // was an AssignOrReturnStmt (:-).
                        switch (method.Outs.Count)
                        {
                            case > 1:
                                ReportError(ErrorId.rw_test_method_has_too_many_returns,
                                 method.tok,
                                  "Methods with the :test attribute can have at most one return value");
                                continue;
                                break;
                            case 1:
                                {
                                    var resultVarName = idGenerator.FreshId("result");
                                    var resultVarStmt = Statement.CreateLocalVariable(tok, resultVarName, method.Outs[0].Type);
                                    tryBodyStatements.Add(resultVarStmt);
                                    resultVarExpr = new IdentifierExpr(tok, resultVarStmt.Locals[0]);
                                    resultVarExpr.Type = resultVarStmt.Locals[0].Type;
                                    lhss.Add(resultVarExpr);
                                    break;
                                }

                                break;
                        }

                        var callStmt = new CallStmt(tok.ToRange(), lhss, methodSelectExpr, new List<Expression>());
                        tryBodyStatements.Add(callStmt);

                        Statement passedStmt = Statement.CreatePrintStmt(tok, Expression.CreateStringLiteral(tok, MutateCSharp.Schemata465.ReplaceStringConstant_1(38L, "PASSED\n")));
                        var passedBlock = new BlockStmt(tok.ToRange(), Util.Singleton(passedStmt));

                        if (resultVarExpr?.Type is UserDefinedType udt && udt.ResolvedClass is TopLevelDeclWithMembers resultClass)
                        {
                            var failureGuardExpr =
                              new FunctionCallExpr(tok, MutateCSharp.Schemata465.ReplaceStringConstant_1(39L, "IsFailure"), resultVarExpr, tok, tok, new List<Expression>());
                            var isFailureMember = resultClass.Members.First(m => MutateCSharp.Schemata465.ReplaceBinExprOp_4(41L, m.Name, MutateCSharp.Schemata465.ReplaceStringConstant_1(40L, "IsFailure")));
                            failureGuardExpr.Function = (Function)isFailureMember;
                            failureGuardExpr.Type = Type.Bool;
                            failureGuardExpr.TypeApplication_JustFunction = new List<Type>();
                            failureGuardExpr.TypeApplication_AtEnclosingClass = new List<Type>();

                            var failedBlock = PrintTestFailureStatement(tok, successVarExpr, resultVarExpr);
                            tryBodyStatements.Add(new IfStmt(tok.ToRange(), MutateCSharp.Schemata465.ReplaceBooleanConstant_0(42L, false), failureGuardExpr, failedBlock, passedBlock));
                        }
                        else
                        { // Result is not a failure type
                            tryBodyStatements.Add(passedBlock);
                        }

                        var tryBody = new BlockStmt(tok.ToRange(), tryBodyStatements);

                        // Wrap the code above with:
                        //
                        // try {
                        //   ...
                        // } recover (haltMessage: string) {
                        //   print "FAILED\n\t", haltMessage, "\n";
                        //   success := false;
                        // }
                        //
                        var haltMessageVar = new LocalVariable(tok.ToRange(), MutateCSharp.Schemata465.ReplaceStringConstant_1(43L, "haltMessage"), seqCharType, MutateCSharp.Schemata465.ReplaceBooleanConstant_0(44L, false))
                        {
                            type = seqCharType
                        };
                        var haltMessageVarExpr = new IdentifierExpr(tok, haltMessageVar);
                        var recoverBlock =
                          PrintTestFailureStatement(tok, successVarExpr, haltMessageVarExpr);
                        var tryRecoverStmt = new TryRecoverStatement(tryBody, haltMessageVar, recoverBlock);

                        mainMethodStatements.Add(tryRecoverStmt);
                    }
                }
            }

            // Use an expect statement to halt if there are any failed tests.
            // Ideally we would just set the process return code instead of crashing the program,
            // but since Dafny main methods don't support that yet, that is deferred for now.
            //
            // expect success, "Test failures occurred: see above.\n";
            // 
            Statement expectSuccess = new ExpectStmt(tok.ToRange(), successVarExpr,
              Expression.CreateStringLiteral(tok, MutateCSharp.Schemata465.ReplaceStringConstant_1(45L, "Test failures occurred: see above.\n")), null);
            mainMethodStatements.Add(expectSuccess);

            // Find the resolved main method to attach the body to (which will be a different instance
            // than the Method we added in PreResolve).
            var hasMain = Compilers.SinglePassCodeGenerator.HasMain(program, out var mainMethod);
            Contract.Assert(hasMain);
            mainMethod.Body = new BlockStmt(tok.ToRange(), mainMethodStatements);
        }

        private BlockStmt PrintTestFailureStatement(IToken tok, Expression successVarExpr, Expression failureValueExpr)
        {
            var failedPrintStmt = Statement.CreatePrintStmt(tok,
              Expression.CreateStringLiteral(tok, MutateCSharp.Schemata465.ReplaceStringConstant_1(46L, "FAILED\n\t")),
              failureValueExpr,
              Expression.CreateStringLiteral(tok, MutateCSharp.Schemata465.ReplaceStringConstant_1(47L, "\n")));
            var failSuiteStmt =
              new AssignStmt(tok.ToRange(), successVarExpr, new ExprRhs(Expression.CreateBoolLiteral(tok, MutateCSharp.Schemata465.ReplaceBooleanConstant_0(48L, false))));
            return new BlockStmt(tok.ToRange(), Util.List<Statement>(failedPrintStmt, failSuiteStmt));
        }
    }
}