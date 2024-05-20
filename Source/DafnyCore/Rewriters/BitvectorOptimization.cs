// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT

using System;
using System.Linq.Expressions;
using System.Numerics;
namespace MutateCSharp
{
    internal class Schemata445
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT445");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public class BitvectorOptimization : IRewriter
    {
        private readonly SystemModuleManager systemModuleManager;
        public BitvectorOptimization(Program program, ErrorReporter reporter) : base(reporter)
        {
            systemModuleManager = program.SystemModuleManager;
        }

        internal override void PostResolveIntermediate(ModuleDefinition m)
        {
            var visitor = new BitvectorOptimizationVisitor(Reporter.Options, systemModuleManager);
            foreach (var decl in ModuleDefinition.AllItersAndCallables(m.TopLevelDecls))
            {
                visitor.Visit(decl);
            }
        }
    }

    public class BitvectorOptimizationVisitor : BottomUpVisitor
    {
        private readonly DafnyOptions options;
        private readonly SystemModuleManager systemModuleManager;

        public BitvectorOptimizationVisitor(DafnyOptions options, SystemModuleManager systemModuleManager)
        {
            this.options = options;
            this.systemModuleManager = systemModuleManager;
        }

        private bool IsShiftOp(BinaryExpr.Opcode op)
        {
            return op is BinaryExpr.Opcode.LeftShift or BinaryExpr.Opcode.RightShift;
        }

        private Expression ShrinkBitVectorShiftAmount(Expression expr, BitvectorType originalType)
        {
            var width = new BigInteger(originalType.Width);
            var intermediateType = new BitvectorType(options, (int)width.GetBitLength());
            systemModuleManager.Bitwidths.Add(intermediateType.Width);
            var newExpr = new ConversionExpr(expr.tok, expr, intermediateType, MutateCSharp.Schemata445.ReplaceStringConstant_0(1L, "when converting shift amount to a bit vector, the "));
            newExpr.Type = intermediateType;
            return newExpr;
        }

        protected override void VisitOneExpr(Expression expr)
        {
            if (expr.Type is BitvectorType bvType)
            {

                if (expr is BinaryExpr binExpr && IsShiftOp(binExpr.Op))
                {
                    binExpr.E1 = ShrinkBitVectorShiftAmount(binExpr.E1, bvType);
                }
            }
        }
    }
}