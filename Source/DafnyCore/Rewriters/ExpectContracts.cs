using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using static Microsoft.Dafny.RewriterErrors;
namespace MutateCSharp
{
    internal class Schemata447
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT447");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_3(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.DafnyOptions.ContractTestingMode argument1, Microsoft.Dafny.DafnyOptions.ContractTestingMode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.CallRedirector argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.DafnyOptions.ContractTestingMode argument1, Microsoft.Dafny.DafnyOptions.ContractTestingMode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{

    /// <summary>
    /// This class implements a rewriter that will insert dynamic checks of
    /// the contracts on certain functions and methods. It proceeds by
    ///
    /// 1. identifying each declaration that should have its contract checked,
    /// 2. creating a new wrapper definition that uses expect statements to
    ///    check all contract clauses for that declarations, and
    /// 3. replacing calls to the original definition with calls to the new
    ///    wrapper definition.
    /// </summary>
    public class ExpectContracts : IRewriter
    {
        private readonly ClonerButDropMethodBodies cloner = new(MutateCSharp.Schemata447.ReplaceBooleanConstant_0(1L, true));
        private readonly Dictionary<MemberDecl, MemberDecl> wrappedDeclarations = new();
        private readonly SystemModuleManager systemModuleManager;

        public ExpectContracts(ErrorReporter reporter, SystemModuleManager systemModuleManager) : base(reporter)
        {
            this.systemModuleManager = systemModuleManager;
        }

        /// <summary>
        /// Create an expect statement that checks the given contract clause
        /// expression and fails with a message that points to the original
        /// location of the contract clause if it is not true at runtime.
        ///
        /// If the given clause is not compilable, emit a warning and construct
        /// an `expect true` statement with a message explaining the situation.
        /// </summary>
        /// <param name="expr">The contract clause expression to evaluate.</param>
        /// <param name="exprType">Either "requires" or "ensures", to use in the
        /// failure message.</param>
        /// <returns>The newly-created expect statement.</returns>
        private Statement CreateContractExpectStatement(AttributedExpression expr, string exprType)
        {
            var tok = expr.E.tok;
            var msg = $"Runtime failure of {exprType} clause from {tok.TokenToString(Reporter.Options)}";
            var exprToCheck = expr.E;
            if (ExpressionTester.UsesSpecFeatures(exprToCheck))
            {
                ReportWarning(ErrorId.rw_clause_cannot_be_compiled, tok,
                  $"The {exprType} clause at this location cannot be compiled to be tested at runtime because it references ghost state.");
                exprToCheck = Expression.CreateBoolLiteral(tok, MutateCSharp.Schemata447.ReplaceBooleanConstant_0(2L, true));
                msg += MutateCSharp.Schemata447.ReplaceStringConstant_1(3L, " (not compiled because it references ghost state)");
            }
            var msgExpr = Expression.CreateStringLiteral(tok, msg);
            return new ExpectStmt(expr.E.RangeToken, exprToCheck, msgExpr, null);
        }

        /// <summary>
        /// Creates a block statement that includes an expect statement for every
        /// requires clause, followed by the provided call statement, followed by
        /// an expect statement for every ensures clause.
        /// </summary>
        /// <param name="requires">The list of requires clause expressions.</param>
        /// <param name="ensures">The list of ensures clause expressions.</param>
        /// <param name="callStmt">The call statement to include.</param>
        /// <returns>The newly-created block statement.</returns>
        private BlockStmt MakeContractCheckingBody(IEnumerable<AttributedExpression> requires,
          IEnumerable<AttributedExpression> ensures, Statement callStmt)
        {
            var expectRequiresStmts = requires.Select(req =>
              CreateContractExpectStatement(req, MutateCSharp.Schemata447.ReplaceStringConstant_1(4L, "requires")));
            var expectEnsuresStmts = ensures.Select(ens =>
              CreateContractExpectStatement(ens, MutateCSharp.Schemata447.ReplaceStringConstant_1(5L, "ensures")));
            var callStmtList = new List<Statement>() { callStmt };
            var bodyStatements = expectRequiresStmts.Concat(callStmtList).Concat(expectEnsuresStmts);
            return new BlockStmt(callStmt.RangeToken, bodyStatements.ToList());
        }

        private bool ShouldGenerateWrapper(MemberDecl decl)
        {
            return MutateCSharp.Schemata447.ReplaceBinExprOp_2(12L, () => MutateCSharp.Schemata447.ReplaceBinExprOp_2(6L, () => !decl.IsGhost, () => decl is not Constructor), () => CallRedirector.HasExternAttribute(decl));
        }

        /// <summary>
        /// Create a wrapper for the given function or method declaration that
        /// dynamically checks all of its preconditions, calls it, and checks
        /// all of its postconditions before returning. Then add the new wrapper
        /// as a sibling of the original declaration.
        /// </summary>
        /// <param name="parent">The declaration containing the on to be wrapped.</param>
        /// <param name="decl">The declaration to be wrapped.</param>
        private void GenerateWrapper(ModuleDefinition module, TopLevelDeclWithMembers parent, MemberDecl decl)
        {
            var tok = decl.tok;

            var newName = decl.Name + MutateCSharp.Schemata447.ReplaceStringConstant_1(18L, "__dafny_checked");
            MemberDecl newDecl = null;

            if (decl is Method origMethod)
            {
                newDecl = GenerateMethodWrapper(parent, decl, origMethod, newName);
            }
            else if (decl is Function origFunc)
            {
                newDecl = GenerateFunctionWrapper(parent, decl, origFunc, newName, tok);
            }

            if (newDecl is not null)
            {
                // We especially want to remove {:extern} from the wrapper, but also any other attributes.
                newDecl.Attributes = null;

                newDecl.EnclosingClass = parent;
                wrappedDeclarations.Add(decl, newDecl);
                parent.Members.Add(newDecl);
                module.CallRedirector.AddFullName(newDecl, decl.FullName + MutateCSharp.Schemata447.ReplaceStringConstant_1(19L, "__dafny_checked"));
            }
        }

        private MemberDecl GenerateFunctionWrapper(TopLevelDeclWithMembers parent, MemberDecl decl, Function origFunc,
          string newName, IToken tok)
        {
            var newFunc = cloner.CloneFunction(origFunc);
            newFunc.NameNode.Value = newName;

            var args = newFunc.Ins.Select(Expression.CreateIdentExpr).ToList();
            var receiver = ModuleResolver.GetReceiver(parent, origFunc, decl.tok);
            var callExpr = Expression.CreateResolvedCall(tok, receiver, origFunc, args,
              newFunc.TypeArgs.Select(tp => (Type)new UserDefinedType(tp)).ToList(), systemModuleManager);

            newFunc.Body = callExpr;

            var localName = origFunc.Result?.Name ?? MutateCSharp.Schemata447.ReplaceStringConstant_1(20L, "__result");
            var localExpr = new IdentifierExpr(tok, localName)
            {
                Type = newFunc.ResultType
            };

            var callRhs = new ExprRhs(callExpr);

            var lhss = new List<Expression> { localExpr };
            var rhss = new List<AssignmentRhs> { callRhs };

            var assignStmt = new AssignStmt(decl.RangeToken, localExpr, callRhs);
            Statement callStmt;
            if (origFunc.Result?.Name is null)
            {
                var local = new LocalVariable(decl.RangeToken, localName, newFunc.ResultType, MutateCSharp.Schemata447.ReplaceBooleanConstant_0(21L, false));
                local.type = newFunc.ResultType;
                var locs = new List<LocalVariable> { local };
                var varDeclStmt = new VarDeclStmt(decl.RangeToken, locs, new UpdateStmt(decl.RangeToken, lhss, rhss)
                {
                    ResolvedStatements = new List<Statement>() { assignStmt }
                });
                localExpr.Var = local;
                callStmt = varDeclStmt;
            }
            else
            {
                localExpr.Var = origFunc.Result;
                callStmt = assignStmt;
            }

            var body = MakeContractCheckingBody(origFunc.Req, origFunc.Ens, callStmt);

            if (origFunc.Result?.Name is null)
            {
                body.AppendStmt(new ReturnStmt(decl.RangeToken, new List<AssignmentRhs> { new ExprRhs(localExpr) }));
            }

            newFunc.ByMethodBody = body;
            // We especially want to remove {:extern} from the wrapper, but also any other attributes.
            newFunc.Attributes = null;
            RegisterResolvedByMethod(newFunc, parent);

            return newFunc;
        }

        private MemberDecl GenerateMethodWrapper(TopLevelDeclWithMembers parent, MemberDecl decl, Method origMethod,
          string newName)
        {
            MemberDecl newDecl;
            var newMethod = cloner.CloneMethod(origMethod);
            newMethod.NameNode.Value = newName;

            var args = newMethod.Ins.Select(Expression.CreateIdentExpr).ToList();
            var outs = newMethod.Outs.Select(Expression.CreateIdentExpr).ToList();
            var receiver = ModuleResolver.GetReceiver(parent, origMethod, decl.tok);
            var memberSelectExpr = new MemberSelectExpr(decl.tok, receiver, origMethod.Name);
            memberSelectExpr.Member = origMethod;
            memberSelectExpr.TypeApplication_JustMember =
              newMethod.TypeArgs.Select(tp => (Type)new UserDefinedType(tp)).ToList();
            memberSelectExpr.TypeApplication_AtEnclosingClass =
              parent.TypeArgs.Select(tp => (Type)new UserDefinedType(tp)).ToList();
            var callStmt = new CallStmt(decl.RangeToken, outs, memberSelectExpr, args);

            var body = MakeContractCheckingBody(origMethod.Req, origMethod.Ens, callStmt);
            newMethod.Body = body;
            newDecl = newMethod;
            return newDecl;
        }


        private void RegisterResolvedByMethod(Function f, TopLevelDeclWithMembers cl)
        {

            var tok = f.ByMethodTok;
            var resultVar = f.Result ?? new Formal(tok, MutateCSharp.Schemata447.ReplaceStringConstant_1(22L, "#result"), f.ResultType, MutateCSharp.Schemata447.ReplaceBooleanConstant_0(23L, false), MutateCSharp.Schemata447.ReplaceBooleanConstant_0(24L, false), null);
            var r = Expression.CreateIdentExpr(resultVar);
            // To construct the receiver, we want to know if the function is static or instance. That information is ordinarily computed
            // by f.IsStatic, which looks at f.HasStaticKeyword and f.EnclosingClass. However, at this time, f.EnclosingClass hasn't yet
            // been set. Instead, we compute here directly from f.HasStaticKeyword and "cl".
            var isStatic = MutateCSharp.Schemata447.ReplaceBinExprOp_3(25L, () => f.HasStaticKeyword, () => cl is DefaultClassDecl);
            var receiver = isStatic ? (Expression)new StaticReceiverExpr(tok, cl, MutateCSharp.Schemata447.ReplaceBooleanConstant_0(31L, true)) : new ImplicitThisExpr(tok);
            var fn = Expression.CreateResolvedCall(tok, receiver, f, f.Ins.ConvertAll(Expression.CreateIdentExpr),
              f.TypeArgs.ConvertAll(typeParameter => (Type)new UserDefinedType(f.tok, typeParameter)), systemModuleManager);
            var post = new AttributedExpression(new BinaryExpr(tok, BinaryExpr.Opcode.Eq, r, fn)
            {
                Type = Type.Bool
            });
            // If f.Reads is empty, replace it with an explicit `reads {}` so that we don't replace that
            // with the default `reads *` for methods later.
            var reads = f.Reads;
            if (!reads.Expressions.Any())
            {
                reads = new Specification<FrameExpression>();
                var emptySet = new SetDisplayExpr(tok, MutateCSharp.Schemata447.ReplaceBooleanConstant_0(32L, true), new List<Expression>());
                reads.Expressions.Add(new FrameExpression(tok, emptySet, null));
            }
            var method = new Method(f.RangeToken, f.NameNode, f.HasStaticKeyword, MutateCSharp.Schemata447.ReplaceBooleanConstant_0(33L, false), f.TypeArgs,
              f.Ins, new List<Formal>() { resultVar },
              f.Req, reads, new Specification<FrameExpression>(new List<FrameExpression>(), null), new List<AttributedExpression>() { post }, f.Decreases,
              f.ByMethodBody, f.Attributes, null, MutateCSharp.Schemata447.ReplaceBooleanConstant_0(34L, true));
            Contract.Assert(f.ByMethodDecl == null);
            method.InheritVisibility(f);
            method.FunctionFromWhichThisIsByMethodDecl = f;
            method.EnclosingClass = cl;
            f.ByMethodDecl = method;
        }

        /// <summary>
        /// Adds wrappers for certain top-level declarations in the given
        /// program and redirects callers to call those wrappers instead of
        /// the original members.
        ///
        /// This runs after resolution so that it has access to ghostness
        /// information, attributes and call targets and after verification
        /// because that makes the interaction with the refinement transformer
        /// more straightforward.
        /// </summary>
        /// <param name="program">The program to generate wrappers for and in.</param>
        public override void PostVerification(Program program)
        {
            // Create wrappers
            foreach (var moduleDefinition in program.Modules())
            {

                // Keep a list of members to wrap so that we don't modify the collection we're iterating over.
                List<(TopLevelDeclWithMembers, MemberDecl)> membersToWrap = new();

                moduleDefinition.CallRedirector = new(Reporter);

                // Find module members to wrap.
                foreach (var topLevelDecl in moduleDefinition.TopLevelDecls.OfType<TopLevelDeclWithMembers>())
                {
                    foreach (var decl in topLevelDecl.Members)
                    {
                        if (ShouldGenerateWrapper(decl))
                        {
                            membersToWrap.Add((topLevelDecl, decl));
                        }
                    }
                }

                // Generate a wrapper for each of the members identified above. This
                // need to happen after all declarations to wrap have been identified
                // because it adds new declarations and would invalidate the iterator
                // used during identification.
                foreach (var (topLevelDecl, decl) in membersToWrap)
                {
                    GenerateWrapper(moduleDefinition, topLevelDecl, decl);
                }
                moduleDefinition.CallRedirector.NewRedirections = wrappedDeclarations;

                // Put redirections in place. Any wrappers to call will be in either
                // this module or to a previously-processed module, so they'll already
                // exist.
                foreach (var topLevelDecl in moduleDefinition.TopLevelDecls.OfType<TopLevelDeclWithMembers>())
                {
                    foreach (var decl in topLevelDecl.Members)
                    {
                        if (decl is ICallable callable)
                        {
                            moduleDefinition.CallRedirector?.Visit(callable, decl);
                        }
                    }
                }
            }

            if (MutateCSharp.Schemata447.ReplaceBinExprOp_4(35L, Reporter.Options.TestContracts, DafnyOptions.ContractTestingMode.TestedExterns))
            {
                return;
            }

            foreach (var module in program.Modules())
            {
                if (MutateCSharp.Schemata447.ReplaceBinExprOp_5(36L, module.CallRedirector, null))
                {
                    continue;
                }
                // If running in TestedExterns, warn if any extern has no corresponding test.
                var uncalledRedirections =
                  module.CallRedirector.NewRedirections.ExceptBy(module.CallRedirector.CalledWrappers, x => x.Value);
                foreach (var uncalledRedirection in uncalledRedirections)
                {
                    var uncalledOriginal = uncalledRedirection.Key;
                    ReportWarning(ErrorId.rw_unreachable_by_test, uncalledOriginal.tok, $"No :test code calls {uncalledOriginal.FullDafnyName}");
                }
            }

        }
    }

    /// <summary>
    /// This class implements a top-down AST traversal to replace certain
    /// function and method calls with calls to wrappers that dynamically
    /// check contracts using expect statements.
    /// </summary>
    public class CallRedirector : TopDownVisitor<MemberDecl>
    {
        public Dictionary<MemberDecl, MemberDecl> NewRedirections { get; set; } = new();
        private readonly Dictionary<MemberDecl, string> newFullNames = new();
        private readonly ErrorReporter reporter;
        public HashSet<MemberDecl> CalledWrappers { get; } = new();

        public CallRedirector(ErrorReporter reporter)
        {
            this.reporter = reporter;
        }

        internal void AddFullName(MemberDecl decl, string fullName)
        {
            newFullNames.Add(decl, fullName);
        }

        internal static bool HasTestAttribute(MemberDecl decl)
        {
            return MutateCSharp.Schemata447.ReplaceBinExprOp_2(38L, () => decl.Attributes is not null, () => Attributes.Contains(decl.Attributes, MutateCSharp.Schemata447.ReplaceStringConstant_1(37L, "test")));
        }

        internal static bool HasExternAttribute(MemberDecl decl)
        {
            return MutateCSharp.Schemata447.ReplaceBinExprOp_2(45L, () => decl.Attributes is not null, () => Attributes.Contains(decl.Attributes, MutateCSharp.Schemata447.ReplaceStringConstant_1(44L, "extern")));
        }

        private bool ShouldCallWrapper(MemberDecl caller, MemberDecl callee)
        {
            if (!HasExternAttribute(callee))
            {
                return MutateCSharp.Schemata447.ReplaceBooleanConstant_0(51L, false);
            }
            // If there's no wrapper for the callee, don't try to call it, but warn.
            if (!NewRedirections.ContainsKey(callee))
            {
                reporter.Warning(MessageSource.Rewriter, ErrorId.rw_no_wrapper, caller.tok, $"Internal: no wrapper for {callee.FullDafnyName}");
                return MutateCSharp.Schemata447.ReplaceBooleanConstant_0(52L, false);
            }

            var opt = reporter.Options.TestContracts;
            return MutateCSharp.Schemata447.ReplaceBinExprOp_2(67L, () => (MutateCSharp.Schemata447.ReplaceBinExprOp_3(61L, () => (MutateCSharp.Schemata447.ReplaceBinExprOp_2(54L, () => HasTestAttribute(caller), () => MutateCSharp.Schemata447.ReplaceBinExprOp_6(53L, opt, DafnyOptions.ContractTestingMode.TestedExterns))), () => (MutateCSharp.Schemata447.ReplaceBinExprOp_6(60L, opt, DafnyOptions.ContractTestingMode.Externs)))), () =>
                   // Skip if the caller is a wrapper, otherwise it'd just call itself recursively.
                   !NewRedirections.ContainsValue(caller));
        }

        protected override bool VisitOneExpr(Expression expr, ref MemberDecl decl)
        {
            if (expr is FunctionCallExpr fce)
            {
                var f = fce.Function;
                if (ShouldCallWrapper(decl, f))
                {
                    var newTarget = NewRedirections[f];
                    var resolved = (FunctionCallExpr)fce.Resolved;
                    resolved.Function = (Function)newTarget;
                    resolved.Name = newTarget.Name;
                    CalledWrappers.Add(newTarget);
                }
            }

            return MutateCSharp.Schemata447.ReplaceBooleanConstant_0(73L, true);
        }

        protected override bool VisitOneStmt(Statement stmt, ref MemberDecl decl)
        {
            if (stmt is CallStmt cs)
            {
                var m = cs.Method;
                if (ShouldCallWrapper(decl, m))
                {
                    var newTarget = NewRedirections[m];
                    var resolved = (MemberSelectExpr)cs.MethodSelect.Resolved;
                    resolved.Member = newTarget;
                    resolved.MemberName = newTarget.Name;
                    CalledWrappers.Add(newTarget);
                }
            }

            return MutateCSharp.Schemata447.ReplaceBooleanConstant_0(74L, true);
        }
    }
}
