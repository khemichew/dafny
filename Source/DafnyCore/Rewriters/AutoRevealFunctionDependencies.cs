using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Numerics;
namespace MutateCSharp
{
    internal class Schemata444
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT444");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 >= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 > argument2; }
            return argument1 >= argument2;
        }

        internal static bool ReplaceBooleanConstant_10(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_6(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static int ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
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

        internal static int ReplaceNumericConstant_1(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_11(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_12(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.AutoRevealFunctionDependencies.RevealStmtWithDepth argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{

    /// <summary>
    /// When Dafny is called with `--default-function-opacity autoRevealDependencies`, this rewriter computes
    /// all transitive functional dependencies for each callable, and inserts (in-memory, on the AST) reveal stmts for each such dependency
    /// at the top of the callable body, and also in a precondition.
    ///
    /// For example:
    ///   function f()
    ///     ensures true
    ///   { g(h()) }
    ///
    /// would get transformed to:
    ///   function f()
    ///     requires reveal g(); reveal h(); true
    ///     ensures true
    ///   {
    ///     reveal g(); reveal h();
    ///     g(h())
    ///   }
    ///
    /// assuming that g() and h() don't have the `{:transparent}` attribute.
    /// </summary>
    public class AutoRevealFunctionDependencies : IRewriter
    {
        public AutoRevealFunctionDependencies(ErrorReporter reporter) : base(reporter)
        {
        }

        internal override void PostResolveIntermediate(ModuleDefinition moduleDefinition)
        {
            Contract.Requires(moduleDefinition != null);

            foreach (var decl in moduleDefinition.TopLevelDecls)
            {
                if (decl is ICanAutoRevealDependencies m)
                {
                    m.AutoRevealDependencies(this, Options, Reporter);
                }

                if (decl is TopLevelDeclWithMembers cl)
                {
                    foreach (var member in cl.Members)
                    {
                        if (member is ICanAutoRevealDependencies mem)
                        {
                            mem.AutoRevealDependencies(this, Options, Reporter);
                        }
                    }
                }
            }
        }

        public class GraphTraversalVertex
        {
            public readonly Graph<ICallable>.Vertex Vertex;
            public readonly bool Local;
            public readonly int Depth;

            public GraphTraversalVertex(Graph<ICallable>.Vertex vertex, bool local, int depth)
            {
                Vertex = vertex;
                Local = local;
                Depth = depth;
            }

            public override bool Equals(object obj)
            {
                var other = obj as GraphTraversalVertex;
                return MutateCSharp.Schemata444.ReplaceBinExprOp_0(1L, other?.Vertex.N.FullSanitizedName, Vertex.N.FullSanitizedName);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Vertex.N.FullSanitizedName);
            }
        }

        private static string RenderRevealStmts(List<RevealStmtWithDepth> addedRevealStmtList, int depth = 1)
        {
            Contract.Requires(addedRevealStmtList.Any());

            var currentDepth = MutateCSharp.Schemata444.ReplaceBinExprOp_2(6L, depth, MutateCSharp.Schemata444.ReplaceNumericConstant_1(2L, 1));

            string result = "";

            foreach (var revealStmt in addedRevealStmtList.Where(stmt => MutateCSharp.Schemata444.ReplaceBinExprOp_3(15L, stmt.Depth, depth)))
            {
                if (MutateCSharp.Schemata444.ReplaceBinExprOp_4(20L, revealStmt.Depth, currentDepth))
                {
                    currentDepth = revealStmt.Depth;
                    var stmtCount = addedRevealStmtList.Count(stmt => MutateCSharp.Schemata444.ReplaceBinExprOp_5(25L, stmt.Depth, currentDepth));
                    result += $"\n\n// depth {currentDepth}: {stmtCount} {(MutateCSharp.Schemata444.ReplaceBinExprOp_5(34L, stmtCount, MutateCSharp.Schemata444.ReplaceNumericConstant_1(30L, 1)) ? MutateCSharp.Schemata444.ReplaceStringConstant_6(39L, "stmt") : MutateCSharp.Schemata444.ReplaceStringConstant_6(40L, "stmts"))}\n";
                }

                result += $"{revealStmt.RevealStmt} ";


            }
            // Removing the initial `\n\n`
            return result[2..];
        }

        public static string GenerateMessage(List<RevealStmtWithDepth> addedReveals, int autoRevealDepth = Int32.MaxValue)
        {
            var numInsertedReveals = addedReveals.Count(stmt => MutateCSharp.Schemata444.ReplaceBinExprOp_7(41L, stmt.Depth, autoRevealDepth));
            var message = "";

            message +=
              $"Found {addedReveals.Count} function {(MutateCSharp.Schemata444.ReplaceBinExprOp_5(50L, addedReveals.Count, MutateCSharp.Schemata444.ReplaceNumericConstant_1(46L, 1)) ? MutateCSharp.Schemata444.ReplaceStringConstant_6(55L, "dependency") : MutateCSharp.Schemata444.ReplaceStringConstant_6(56L, "dependencies"))}.";

            message +=
              $" {numInsertedReveals} reveal {(MutateCSharp.Schemata444.ReplaceBinExprOp_5(61L, numInsertedReveals, MutateCSharp.Schemata444.ReplaceNumericConstant_1(57L, 1)) ? MutateCSharp.Schemata444.ReplaceStringConstant_6(66L, "statement") : MutateCSharp.Schemata444.ReplaceStringConstant_6(67L, "statements"))} inserted implicitly.";

            // if (numInsertedReveals < addedReveals.Count) {
            //   message += $" Remaining:\n{RenderRevealStmts(addedReveals, 1 + autoRevealDepth)}";
            // } else {
            message += $" Reveal statements:\n{RenderRevealStmts(addedReveals)}";
            // }

            return message;
        }

        public class RevealStmtWithDepth
        {
            public RevealStmtWithDepth(RevealStmt RevealStmt, int Depth)
            {
                this.RevealStmt = RevealStmt;
                this.Depth = Depth;
            }

            public override bool Equals(object obj)
            {
                var item = obj as RevealStmtWithDepth;
                return MutateCSharp.Schemata444.ReplaceBinExprOp_9(69L, () => MutateCSharp.Schemata444.ReplaceBinExprOp_8(68L, item, null), () => this.RevealStmt.ToString().Equals(item.RevealStmt.ToString()));
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(RevealStmt.ToString());
            }

            public RevealStmt RevealStmt { get; }
            public int Depth { get; }
        };

        public record FunctionWithDepth(Function Function, int Depth);

        public IEnumerable<FunctionWithDepth> GetEnumerator(ICallable m, TopLevelDecl currentClass, IEnumerable<Expression> subexpressions, ModuleDefinition rootModule = null)
        {
            var origVertex = currentClass.EnclosingModuleDefinition.CallGraph.FindVertex(m);
            var interModuleVertex = currentClass.EnclosingModuleDefinition.InterModuleCallGraph.FindVertex(m);

            if (origVertex is null)
            {
                yield break;
            }  //vertex can be null if m is a Test method.

            var visited = new HashSet<GraphTraversalVertex>();
            var queue = new Queue<GraphTraversalVertex>();

            var defaultRootModule = rootModule is null ? currentClass.EnclosingModuleDefinition : rootModule;

            // The rootModule parameter is used in the case when GetEnumerator is called, not on a function from a class, but on subset type expressions.
            // Here this function may be called with a callable that is in a different module than the original one.

            foreach (var callable in origVertex.Successors)
            {
                queue.Enqueue(new GraphTraversalVertex(callable, MutateCSharp.Schemata444.ReplaceBooleanConstant_10(75L, true), MutateCSharp.Schemata444.ReplaceNumericConstant_1(76L, 1)));
            }

            var typeList = ExprListToTypeList(subexpressions.ToList()).ToList();

            if (m is Function f)
            {
                typeList.Add(f.ResultType);
            }

            typeList.ForEach(newType =>
            {
                if (newType is Type { AsSubsetType: not null })
                {
                    foreach (var subexpression in newType.AsSubsetType.Constraint.SubExpressions)
                    {
                        if (subexpression is FunctionCallExpr funcExpr)
                        {
                            var func = funcExpr.Function;

                            if (IsRevealable(defaultRootModule.AccessibleMembers, func))
                            {
                                var newVertex = func.EnclosingClass.EnclosingModuleDefinition.CallGraph.FindVertex(func);

                                if (newVertex is not null)
                                {
                                    queue.Enqueue(new GraphTraversalVertex(newVertex, MutateCSharp.Schemata444.ReplaceBooleanConstant_10(80L, false), MutateCSharp.Schemata444.ReplaceNumericConstant_1(81L, 1)));
                                }
                            }
                        }
                    }
                }
            });

            if (interModuleVertex is not null)
            {
                foreach (var callable in interModuleVertex.Successors)
                {

                    if (IsRevealable(defaultRootModule.AccessibleMembers, (Declaration)callable.N))
                    {

                        queue.Enqueue(new GraphTraversalVertex(callable, MutateCSharp.Schemata444.ReplaceBooleanConstant_10(85L, false), MutateCSharp.Schemata444.ReplaceNumericConstant_1(86L, 1)));
                    }
                }
            }

            while (queue.Any())
            {
                var vertex = queue.Dequeue();
                if (!visited.Contains(vertex))
                {
                    visited.Add(vertex);

                    Graph<ICallable>.Vertex graphVertex;
                    Graph<ICallable>.Vertex interModuleGraphVertex;

                    if (vertex.Local)
                    {
                        graphVertex = vertex.Vertex;

                    }
                    else
                    {
                        graphVertex = vertex.Vertex.N.EnclosingModule.CallGraph.FindVertex(vertex.Vertex.N);

                        if (graphVertex is null)
                        {
                            continue;
                        }
                    }

                    interModuleGraphVertex = graphVertex.N.EnclosingModule.InterModuleCallGraph.FindVertex(graphVertex.N);

                    foreach (var vertex0 in graphVertex.Successors)
                    {
                        if (IsRevealable(defaultRootModule.AccessibleMembers, (Declaration)vertex0.N))
                        {
                            var newGraphTraversalVertex =
                              new GraphTraversalVertex(vertex0, MutateCSharp.Schemata444.ReplaceBooleanConstant_10(90L, true), MutateCSharp.Schemata444.ReplaceBinExprOp_11(95L, MutateCSharp.Schemata444.ReplaceNumericConstant_1(91L, 1), vertex.Depth));

                            if (!visited.Contains(newGraphTraversalVertex))
                            {
                                queue.Enqueue(newGraphTraversalVertex);
                            }
                        }
                    }

                    if (interModuleGraphVertex is not null)
                    {
                        foreach (var vertex0 in interModuleGraphVertex.Successors)
                        {
                            if (IsRevealable(defaultRootModule.AccessibleMembers, (Declaration)vertex0.N))
                            {
                                queue.Enqueue(new GraphTraversalVertex(vertex0, MutateCSharp.Schemata444.ReplaceBooleanConstant_10(104L, false), MutateCSharp.Schemata444.ReplaceBinExprOp_11(109L, MutateCSharp.Schemata444.ReplaceNumericConstant_1(105L, 1), vertex.Depth)));
                            }
                        }
                    }

                    var callable = graphVertex.N;

                    if (callable is Function func && func.IsMadeImplicitlyOpaque(Options))
                    {
                        yield return new FunctionWithDepth(func, vertex.Depth);
                    }
                }
            }

            yield break;
        }

        private static IEnumerable<Type> ExprListToTypeList(IEnumerable<Expression> exprList)
        {
            if (MutateCSharp.Schemata444.ReplaceBinExprOp_12(118L, () => exprList is null, () => !exprList.Any()))
            {
                return new List<Type>();
            }

            var subExprList = exprList.SelectMany(expr => Triggers.ExprExtensions.AllSubExpressions(expr, MutateCSharp.Schemata444.ReplaceBooleanConstant_10(124L, false), MutateCSharp.Schemata444.ReplaceBooleanConstant_10(125L, false)));

            var typeList = subExprList.Select(expr => expr.Type);

            return typeList;
        }

        public IEnumerable<RevealStmtWithDepth> ExprToFunctionalDependencies(Expression expr, ModuleDefinition enclosingModule)
        {
            var expressionList = Triggers.ExprExtensions.AllSubExpressions(expr, MutateCSharp.Schemata444.ReplaceBooleanConstant_10(126L, false), MutateCSharp.Schemata444.ReplaceBooleanConstant_10(127L, false));
            var revealStmtList = new List<RevealStmtWithDepth>();

            foreach (var expression in expressionList)
            {
                if (expression is FunctionCallExpr funcExpr)
                {
                    var func = funcExpr.Function;

                    if (IsRevealable(enclosingModule.AccessibleMembers, func))
                    {
                        if (func.IsMadeImplicitlyOpaque(Options))
                        {

                            var revealStmt0 = BuildRevealStmt(func,
                              expr.Tok, enclosingModule);

                            if (revealStmt0 is not null)
                            {
                                revealStmtList.Add(new RevealStmtWithDepth(revealStmt0, MutateCSharp.Schemata444.ReplaceNumericConstant_1(128L, 1)));
                            }
                        }

                        foreach (var newFunc in GetEnumerator(func, func.EnclosingClass, new List<Expression> { expr },
                                   enclosingModule))
                        {

                            var revealStmt1 = BuildRevealStmt(newFunc.Function, expr.Tok, enclosingModule);

                            if (revealStmt1 is not null)
                            {
                                revealStmtList.Add(new RevealStmtWithDepth(revealStmt1, newFunc.Depth));
                            }
                        }
                    }
                }
            }

            revealStmtList = revealStmtList.Distinct().ToList();
            return revealStmtList;
        }

        public Expression AddRevealStmtsToExpression(Expression expr, IEnumerable<RevealStmtWithDepth> revealStmtList)
        {
            var finalExpr = expr;

            foreach (var revealStmt in revealStmtList)
            {
                var oldExpr = finalExpr;

                finalExpr = new StmtExpr(expr.Tok, revealStmt.RevealStmt, oldExpr)
                {
                    Type = oldExpr.Type
                };
            }

            return finalExpr;
        }

        public static RevealStmt BuildRevealStmt(Function func, IToken tok, ModuleDefinition rootModule)
        {
            List<Type> args = new List<Type>();
            foreach (var _ in func.EnclosingClass.TypeArgs)
            {
                args.Add(new IntType());
            }

            AccessibleMember accessibleMember = rootModule.AccessibleMembers[func];

            var resolveExpr = ConstructExpressionFromPath(func, accessibleMember);

            var callableClass = ((TopLevelDeclWithMembers)func.EnclosingClass);

            var callableName = RevealStmt.RevealLemmaPrefix + func.Name;
            var member = callableClass.Members.Find(decl => MutateCSharp.Schemata444.ReplaceBinExprOp_0(132L, decl.Name, callableName));

            Type.PushScope(callableClass.EnclosingModuleDefinition.VisibilityScope);
            var receiver = new StaticReceiverExpr(tok, new UserDefinedType(tok, callableName, callableClass, callableClass.TypeArgs.ConvertAll(obj => (Type)Type.Int)), callableClass, MutateCSharp.Schemata444.ReplaceBooleanConstant_10(133L, true));
            Type.PopScope(callableClass.EnclosingModuleDefinition.VisibilityScope);

            if (member is null)
            {
                return null;
            }

            callableName = ((ICallable)member).NameRelativeToModule;
            var rr = new MemberSelectExpr(func.Tok, receiver, callableName);
            rr.Type = new InferredTypeProxy();
            rr.Member = member;
            rr.TypeApplication_JustMember = new List<Type>();
            rr.TypeApplication_AtEnclosingClass = args;

            var call = new CallStmt(func.RangeToken, new List<Expression>(), rr, new List<ActualBinding>(),
              func.Tok);
            call.IsGhost = MutateCSharp.Schemata444.ReplaceBooleanConstant_10(134L, true);
            call.Bindings.AcceptArgumentExpressionsAsExactParameterList(new List<Expression>());

            resolveExpr.Type = new InferredTypeProxy();
            ((ConcreteSyntaxExpression)resolveExpr).ResolvedExpression = rr;

            List<Expression> expressionList = new List<Expression> {
      new ApplySuffix(tok, null,
        resolveExpr,
        new List<ActualBinding>(), tok)
    };

            var revealStmt = new RevealStmt(func.RangeToken, expressionList);
            revealStmt.ResolvedStatements.Add(call);
            revealStmt.IsGhost = MutateCSharp.Schemata444.ReplaceBooleanConstant_10(135L, true);

            return revealStmt;
        }

        private static Expression ConstructExpressionFromPath(Function func, AccessibleMember accessibleMember)
        {

            var topLevelDeclsList = accessibleMember.AccessPath;
            var nameList = topLevelDeclsList.Where(decl => MutateCSharp.Schemata444.ReplaceBinExprOp_13(137L, decl.Name, MutateCSharp.Schemata444.ReplaceStringConstant_6(136L, "_default"))).ToList();

            nameList.Add(new NameSegment(func.tok, func.Name, new List<Type>()));

            Expression nameSeed = nameList[MutateCSharp.Schemata444.ReplaceNumericConstant_1(138L, 0)];
            var resolveExpr = nameList.Skip(MutateCSharp.Schemata444.ReplaceNumericConstant_1(142L, 1))
            .Aggregate(nameSeed, (acc, name) => new ExprDotName(func.tok, acc, name.Name, name.OptTypeArguments));

            return resolveExpr;
        }

        public static bool IsRevealable(Dictionary<Declaration, AccessibleMember> accessibleMembers,
          Declaration decl)
        {
            if (accessibleMembers.TryGetValue(decl, out var member))
            {
                return member.IsRevealed;
            }

            return MutateCSharp.Schemata444.ReplaceBooleanConstant_10(146L, false);
        }
    }
}