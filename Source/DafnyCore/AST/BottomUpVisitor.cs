using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Microsoft.Boogie;
namespace MutateCSharp
{
    internal class Schemata4
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT4");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class BottomUpVisitor
    {
        public void Visit(IEnumerable<Expression> exprs)
        {
            exprs.ForEach(Visit);
        }
        public void Visit(IEnumerable<Statement> stmts)
        {
            stmts.ForEach(Visit);
        }
        public void Visit(AttributedExpression expr)
        {
            Visit(expr.E);
        }
        public void Visit(FrameExpression expr)
        {
            Visit(expr.E);
        }
        public void Visit(IEnumerable<AttributedExpression> exprs)
        {
            exprs.ForEach(Visit);
        }
        public void Visit(IEnumerable<FrameExpression> exprs)
        {
            exprs.ForEach(Visit);
        }
        public void Visit(ICallable decl)
        {
            if (decl is Function f)
            {
                Visit(f);
            }
            else if (decl is Method m)
            {
                Visit(m);
            }
            else if (decl is TypeSynonymDecl tsd)
            {
                Visit(tsd);
            }
            else if (decl is NewtypeDecl ntd)
            {
                Visit(ntd);
            }
            //TODO More?
        }

        public void Visit(SubsetTypeDecl ntd)
        {
            if (MutateCSharp.Schemata4.ReplaceBinExprOp_0(1L, ntd.Constraint, null))
            {
                Visit(ntd.Constraint);
            }

            if (MutateCSharp.Schemata4.ReplaceBinExprOp_0(2L, ntd.Witness, null))
            {
                Visit(ntd.Witness);
            }
        }
        public void Visit(NewtypeDecl ntd)
        {
            if (MutateCSharp.Schemata4.ReplaceBinExprOp_0(3L, ntd.Constraint, null))
            {
                Visit(ntd.Constraint);
            }

            if (MutateCSharp.Schemata4.ReplaceBinExprOp_0(4L, ntd.Witness, null))
            {
                Visit(ntd.Witness);
            }
        }
        public void Visit(Method method)
        {
            Visit(method.Req);
            Visit(method.Reads.Expressions);
            Visit(method.Mod.Expressions);
            Visit(method.Ens);
            Visit(method.Decreases.Expressions);
            if (MutateCSharp.Schemata4.ReplaceBinExprOp_1(5L, method.Body, null)) { Visit(method.Body); }
            //TODO More?
        }
        public void Visit(Function function)
        {
            Visit(function.Req);
            Visit(function.Reads.Expressions);
            Visit(function.Ens);
            Visit(function.Decreases.Expressions);
            if (MutateCSharp.Schemata4.ReplaceBinExprOp_0(6L, function.Body, null)) { Visit(function.Body); }
            if (MutateCSharp.Schemata4.ReplaceBinExprOp_1(7L, function.ByMethodBody, null)) { Visit(function.ByMethodBody); }
            //TODO More?
        }
        public void Visit(Expression expr)
        {
            Contract.Requires(expr != null);
            // recursively visit all subexpressions and all substatements
            expr.SubExpressions.ForEach(Visit);
            if (expr is StmtExpr)
            {
                // a StmtExpr also has a substatement
                var e = (StmtExpr)expr;
                Visit(e.S);
            }
            VisitOneExpr(expr);
        }
        public void Visit(Statement stmt)
        {
            Contract.Requires(stmt != null);
            // recursively visit all subexpressions and all substatements
            stmt.SubExpressions.ForEach(Visit);
            stmt.SubStatements.ForEach(Visit);
            VisitOneStmt(stmt);
        }
        protected virtual void VisitOneExpr(Expression expr)
        {
            Contract.Requires(expr != null);
            // by default, do nothing
        }
        protected virtual void VisitOneStmt(Statement stmt)
        {
            Contract.Requires(stmt != null);
            // by default, do nothing
        }
    }
}