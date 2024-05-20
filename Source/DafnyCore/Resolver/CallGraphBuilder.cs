using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata387
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT387");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceNumericConstant_7(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.ConstantField argument1, Microsoft.Dafny.IASTVisitorContext argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.IASTVisitorContext argument1, Microsoft.Dafny.Function argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.IVariable argument1, Microsoft.Dafny.Formal argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, Microsoft.Dafny.ModuleDefinition argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
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

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, Microsoft.Dafny.ModuleDefinition argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.ICallable argument1, Microsoft.Dafny.ICallable argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.Function argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_9(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.ICallable argument1, Microsoft.Dafny.Method argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    /// <summary>
    /// This class builds the call graph for a resolved list of declarations.
    /// It also sets
    ///   -- the .IsRecursive, .AllCalls, and .ContainsQuantifier fields of Function,
    ///   -- the .Uses field of ExtremePredicate, and
    ///   -- the .IsRecursive and .AssignedAssumptionVariables fields of Method.
    /// It assumes that the given declarations have been resolved (name resolution and type checking).
    ///
    /// The call graph of a module is stored as a field .CallGraph in ModuleDefinition. The edges of such
    /// a call graph are between vertices of the module itself, with one exception: there can also be edges
    /// from trait members in a different module to the overriding members in the module. The methods
    /// in this CallGraphBuilder class populate the .CallGraph of modules.
    ///
    /// The public Build method adds the call-graph edges for the given declarations. It assumes
    /// that the specification of iterators have already been created, and adds call-graph edges for them, too.
    /// The Build method works with the "nested" match constructs and does not need to go into their desugarings
    /// (in fact, it's even okay if those desugarings have not yet been created--creating them later does not
    /// give rise to any new edges).
    ///
    /// A call to a function-by-method goes to the "function" part if the call is in a ghost context and goes
    /// to the "by method" part if the call is in a compiled context. The Build method does not assume ghost
    /// interests have been computed, so the edge to the "by method" part may be missing. (The edge to the
    /// "function" part is added and so is the edge from the "by method" part to the "function" part, so no
    /// edges need to be removed.) Instead, when the resolver later determines that a call goes to the "by method"
    /// part, it will call the AddCallGraphEdge method directly.
    ///
    /// Building the call graph for the "system" module (the module that contains Dafny's built-in declarations)
    /// works a little differently. It calls Build only for a subset of the top-level declarations in the
    /// system module. The other declarations are handled in the resolver's ResolveValuetypeDecls() method,
    /// which calls into the VisitFunction and VisitMethod methods below.
    ///
    /// The Build method does NOT add the edges associated with the bodies of prefix predicates/lemmas, because
    /// those bodies are not created until later in the resolution phases. The creation of those bodies uses
    /// the parts of the call graph that is built up here. After those prefix bodies have been created, the
    /// resolver calls into the VisitFunction/VisitMethod methods here to add edges for the prefix bodies.
    /// </summary>
    public class CallGraphBuilder
    {
        public static void Build(List<TopLevelDecl> declarations, ErrorReporter reporter)
        {
            var astVisitor = new CallGraphASTVisitor(reporter);
            astVisitor.VisitDeclarations(declarations);
        }

        public static void VisitFunction(Function function, ErrorReporter reporter)
        {
            var astVisitor = new CallGraphASTVisitor(reporter);
            astVisitor.VisitFunction(function);
        }

        public static void VisitMethod(Method method, ErrorReporter reporter)
        {
            var astVisitor = new CallGraphASTVisitor(reporter);
            astVisitor.VisitMethod(method);
        }

        public static void AddCallGraphEdge(ICodeContext callingContext, ICallable function, Expression e, ErrorReporter reporter)
        {
            CallGraphASTVisitor.AddCallGraphEdge(CodeContextWrapper.Unwrap(callingContext), function, e, MutateCSharp.Schemata387.ReplaceBooleanConstant_0(1L, false));
        }


        private static void AddCallGraphEdgeRaw(ICallable caller, ICallable callee)
        {
            callee.EnclosingModule.CallGraph.AddEdge(caller, callee);
        }

        /// <summary>
        /// Add edges to the call graph.
        /// See comment about AddCallGraphEdgeForField.
        /// </summary>
        private static void AddTypeDependencyEdges(IASTVisitorContext context, Type type)
        {
            Contract.Requires(type != null);
            Contract.Requires(context != null);
            if (context is ICallable caller && type is NonProxyType)
            {
                type.ForeachTypeComponent(ty =>
                {
                    if ((ty as UserDefinedType)?.ResolvedClass is ICallable cl && MutateCSharp.Schemata387.ReplaceBinExprOp_1(2L, caller.EnclosingModule, cl.EnclosingModule))
                    {
                        caller.EnclosingModule.CallGraph.AddEdge(caller, cl);
                    }
                });
            }
        }

        public class CallGraphBuilderContext : IASTVisitorContext
        {
            public readonly IASTVisitorContext CodeContext;
            public readonly bool InFunctionPostcondition;

            public CallGraphBuilderContext(IASTVisitorContext codeContext, bool inFunctionPostcondition)
            {
                CodeContext = codeContext;
                InFunctionPostcondition = inFunctionPostcondition;
            }

            public ModuleDefinition EnclosingModule => CodeContext.EnclosingModule;
        }

        public class CallGraphASTVisitor : ASTVisitor<CallGraphBuilderContext>
        {
            private readonly ErrorReporter reporter;

            public CallGraphASTVisitor(ErrorReporter reporter)
            {
                this.reporter = reporter;
            }

            public override CallGraphBuilderContext GetContext(IASTVisitorContext astVisitorContext, bool inFunctionPostcondition)
            {
                return new CallGraphBuilderContext(astVisitorContext, inFunctionPostcondition);
            }

            protected override void VisitOneDeclaration(TopLevelDecl decl)
            {
                if (decl is DatatypeDecl datatypeDecl)
                {
                    foreach (var ctor in datatypeDecl.Ctors)
                    {
                        foreach (var formal in ctor.Formals)
                        {
                            AddTypeDependencyEdges(datatypeDecl, formal.Type);
                        }
                    }
                }

                base.VisitOneDeclaration(decl);
            }

            public override void VisitFunction(Function f)
            {
                if (MutateCSharp.Schemata387.ReplaceBinExprOp_2(3L, f.OverriddenFunction, null))
                {
                    // add an edge from the trait function to that of the class/type
                    AddCallGraphEdgeRaw(f.OverriddenFunction, f);
                }

                if (f is PrefixPredicate prefixPredicate)
                {
                    // add an edge from P# to P, since this will have the desired effect of detecting unwanted cycles.
                    AddCallGraphEdgeRaw(prefixPredicate, prefixPredicate.ExtremePred);
                }

                base.VisitFunction(f);
            }

            public override void VisitMethod(Method method)
            {
                if (MutateCSharp.Schemata387.ReplaceBinExprOp_3(4L, method.OverriddenMethod, null))
                {
                    // add an edge from the trait method to that of the class/type
                    AddCallGraphEdgeRaw(method.OverriddenMethod, method);
                }

                if (method is PrefixLemma prefixLemma)
                {
                    // add an edge from M# to M, since this will have the desired effect of detecting unwanted cycles.
                    AddCallGraphEdgeRaw(prefixLemma, prefixLemma.ExtremeLemma);
                }

                base.VisitMethod(method);
            }

            protected override void VisitUserProvidedType(Type type, CallGraphBuilderContext context)
            {
                AddTypeDependencyEdges(context.CodeContext, type);
            }

            protected override bool VisitOneExpression(Expression expr, CallGraphBuilderContext context)
            {
                if (expr is DefaultValueExpression)
                {
                    // A DefaultValueExpression is a wrapper around the expression given as a default in the callee's declaration.
                    // It hasn't yet been resolved, so we can't process it here. But that's okay, because we will set up the necessary
                    // call graph edges when processing the callee's declaration.
                    return MutateCSharp.Schemata387.ReplaceBooleanConstant_0(5L, false);
                }

                if (expr is DatatypeValue dtv)
                {
                    var dt = dtv.Type.AsDatatype;
                    if (context.CodeContext is ICallable caller && MutateCSharp.Schemata387.ReplaceBinExprOp_1(6L, caller.EnclosingModule, dt.EnclosingModuleDefinition))
                    {
                        caller.EnclosingModule.CallGraph.AddEdge(caller, dt);
                    }

                }
                else if (expr is MemberSelectExpr memberSelectExpr)
                {
                    if (memberSelectExpr.Member is Function function)
                    {
                        AddCallGraphEdge(context.CodeContext, function, memberSelectExpr, MutateCSharp.Schemata387.ReplaceBooleanConstant_0(7L, false));
                    }
                    else if (memberSelectExpr.Member is Field field)
                    {
                        AddCallGraphEdgeForField(context.CodeContext, field, memberSelectExpr);
                    }
                    else
                    {
                        // Apparently, we're called on the CallStmt.MemberSelect expression. The call-graph edge is added by the
                        // handling of the CallStmt. Below, we will continue visiting the MemberSelectExpr.Obj subexpression.
                        Contract.Assert(memberSelectExpr.Member is Method);
                    }

                }
                else if (expr is FunctionCallExpr functionCallExpr)
                {
                    var function = functionCallExpr.Function;
                    if (function is ExtremePredicate extremePredicate)
                    {
                        extremePredicate.Uses.Add(functionCallExpr);
                    }
                    AddCallGraphEdge(context.CodeContext, function, functionCallExpr,
                      IsFunctionReturnValue(function, functionCallExpr.Receiver, functionCallExpr.Args, context));

                }
                else if (expr is QuantifierExpr quantifierExpr)
                {
                    Contract.Assert(quantifierExpr.SplitQuantifier == null); // No split quantifiers during resolution
                    if (context.CodeContext is Function enclosingFunction)
                    {
                        enclosingFunction.ContainsQuantifier = MutateCSharp.Schemata387.ReplaceBooleanConstant_0(8L, true);
                    }

                }

                return MutateCSharp.Schemata387.ReplaceBooleanConstant_0(9L, true);
            }

            /// <summary>
            /// Return "true" only if the call to "fn" with arguments "receiver/args" in context "context"
            /// denotes the function result value. (If so, the call is not a recursive call, but just a
            /// way to refer to the function's result value.)
            ///
            /// If the call is in a function postcondition, it is calling itself, and the arguments match the
            /// formal parameters, then it denotes a function return value. In general, matching the actuals with
            /// formals requires verification. Here, the two are compared syntactically. Thus, this method may
            /// return "false" even in some cases where the call denotes the function's result value.
            /// </summary>
            private bool IsFunctionReturnValue(Function fn, Expression receiver, List<Expression> args, CallGraphBuilderContext context)
            {
                if (MutateCSharp.Schemata387.ReplaceBinExprOp_5(11L, () => MutateCSharp.Schemata387.ReplaceBinExprOp_4(10L, context.CodeContext, fn), () => context.InFunctionPostcondition))
                {
                    Contract.Assert(fn.Ins.Count == args.Count);
                    return MutateCSharp.Schemata387.ReplaceBinExprOp_5(28L, () => (MutateCSharp.Schemata387.ReplaceBinExprOp_6(17L, () => fn.IsStatic, () => receiver.Resolved is ThisExpr)), () => Enumerable.Range(MutateCSharp.Schemata387.ReplaceNumericConstant_7(23L, 0), args.Count).All(i => MutateCSharp.Schemata387.ReplaceBinExprOp_8(27L, (args[i].Resolved as IdentifierExpr)?.Var, fn.Ins[i])));
                }
                return MutateCSharp.Schemata387.ReplaceBooleanConstant_0(34L, false);
            }

            protected override bool VisitOneStatement(Statement stmt, CallGraphBuilderContext context)
            {
                if (stmt is AssignStmt assignStmt)
                {
                    // check on assumption variables
                    if (context.CodeContext is Method currentMethod &&
                        (assignStmt.Lhs.Resolved as IdentifierExpr)?.Var is LocalVariable localVar &&
                        Attributes.Contains(localVar.Attributes, MutateCSharp.Schemata387.ReplaceStringConstant_9(35L, "assumption")))
                    {
                        if ((assignStmt.Rhs as ExprRhs)?.Expr is BinaryExpr binaryExpr &&
                            binaryExpr.Op == BinaryExpr.Opcode.And &&
                            (binaryExpr.E0.Resolved as IdentifierExpr)?.Var == localVar &&
                            !currentMethod.AssignedAssumptionVariables.Contains(localVar))
                        {
                            currentMethod.AssignedAssumptionVariables.Add(localVar);
                        }
                        else
                        {
                            reporter.Error(MessageSource.Resolver, stmt,
                              $"there may be at most one assignment to an assumption variable, the RHS of which must match the expression \"{localVar.Name} && <boolean expression>\"");
                        }
                    }

                }
                else if (stmt is CallStmt callStmt)
                {
                    AddCallGraphEdge(callStmt, context);

                }

                return MutateCSharp.Schemata387.ReplaceBooleanConstant_0(36L, true);
            }

            /// <summary>
            /// This method, the two AddCallGraphEdge methods, and AddTypeDependencyEdges are what the
            /// CallGraphBuilder is all about. These two methods are called during the traversal of the
            /// declarations given to the public Build method.
            /// </summary>
            private void AddCallGraphEdgeForField(IASTVisitorContext callingContext, Field field, Expression e)
            {
                Contract.Requires(callingContext != null);
                Contract.Requires(field != null);
                Contract.Requires(e != null);
                if (field is ConstantField cf)
                {
                    if (MutateCSharp.Schemata387.ReplaceBinExprOp_10(37L, cf, callingContext))
                    {
                        // detect self-loops here, since they don't show up in the graph's SSC methods
                        reporter.Error(MessageSource.Resolver, cf.tok, MutateCSharp.Schemata387.ReplaceStringConstant_9(38L, "recursive dependency involving constant initialization: {0} -> {0}"), cf.Name);
                    }
                    else
                    {
                        AddCallGraphEdge(callingContext, cf, e, MutateCSharp.Schemata387.ReplaceBooleanConstant_0(39L, false));
                    }
                }
            }

            /// <summary>
            /// See comment about AddCallGraphEdgeForField.
            /// </summary>
            private void AddCallGraphEdge(CallStmt s, CallGraphBuilderContext context)
            {
                Contract.Requires(s != null);
                Contract.Requires(context != null);
                var callee = s.Method;
                ModuleDefinition callerModule = context.CodeContext.EnclosingModule;
                ModuleDefinition calleeModule = ((IASTVisitorContext)callee).EnclosingModule;
                if (MutateCSharp.Schemata387.ReplaceBinExprOp_11(40L, callerModule, calleeModule))
                {
                    // inter-module call; add edge in module's inter-module call graph
                    if (context.CodeContext is ICallable caller0)
                    {
                        if (caller0 is IteratorDecl iteratorDecl)
                        {
                            // use the MoveNext() method as the caller
                            callerModule.InterModuleCallGraph.AddEdge(iteratorDecl.Member_MoveNext, callee);
                        }
                        else
                        {
                            callerModule.InterModuleCallGraph.AddEdge(caller0, callee);
                        }
                    }

                    return;
                }

                // intra-module call; add edge in module's call graph
                if (context.CodeContext is ICallable caller)
                {
                    if (caller is IteratorDecl iteratorDecl)
                    {
                        // use the MoveNext() method as the caller
                        callerModule.CallGraph.AddEdge(iteratorDecl.Member_MoveNext, callee);
                    }
                    else
                    {
                        callerModule.CallGraph.AddEdge(caller, callee);
                        if (MutateCSharp.Schemata387.ReplaceBinExprOp_12(41L, caller, callee))
                        {
                            callee.IsRecursive = MutateCSharp.Schemata387.ReplaceBooleanConstant_0(42L, true); // self recursion (mutual recursion is determined elsewhere)
                        }
                    }
                }
            }

            /// <summary>
            /// See comment about AddCallGraphEdgeForField.
            /// </summary>
            public static void AddCallGraphEdge(IASTVisitorContext callingContext, ICallable callable, Expression e, bool isFunctionReturnValue)
            {
                Contract.Requires(callingContext != null);
                Contract.Requires(callable != null);
                Contract.Requires(e != null);
                ModuleDefinition callerModule = callingContext.EnclosingModule;
                ModuleDefinition calleeModule = callable is SpecialFunction ? null : callable.EnclosingModule;
                if (MutateCSharp.Schemata387.ReplaceBinExprOp_11(43L, callerModule, calleeModule))
                {
                    // inter-module call; add edge in module's inter-module call graph
                    if (callingContext is ICallable context && callable is Function { EnclosingClass: TraitDecl })
                    {
                        callerModule.CallGraph.AddEdge(context, callable);
                    }
                    if (callingContext is ICallable caller0)
                    {
                        callerModule.InterModuleCallGraph.AddEdge(caller0, callable);
                        if (caller0 is Function f)
                        {
                            if (e is FunctionCallExpr ee)
                            {
                                // f.AllCalls.Add(ee);
                            }
                        }
                    }

                    return;
                }

                // intra-module call; add edge in module's call graph
                if (callingContext is ICallable caller)
                {
                    callerModule.CallGraph.AddEdge(caller, callable);
                    if (caller is Function f)
                    {
                        if (e is FunctionCallExpr ee)
                        {
                            f.AllCalls.Add(ee);
                        }
                        // if the call denotes the function return value in the function postconditions, then we don't
                        // mark it as recursive.
                        if (MutateCSharp.Schemata387.ReplaceBinExprOp_5(45L, () => MutateCSharp.Schemata387.ReplaceBinExprOp_13(44L, caller, callable), () => !isFunctionReturnValue))
                        {
                            f.IsRecursive = MutateCSharp.Schemata387.ReplaceBooleanConstant_0(51L, true);  // self recursion (mutual recursion is determined elsewhere)
                        }
                    }
                }
            }
        }
    }
}
