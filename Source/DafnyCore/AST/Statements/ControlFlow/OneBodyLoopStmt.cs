using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using Microsoft.Dafny.Auditor;
namespace MutateCSharp
{
    internal class Schemata158
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT158");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static int ReplaceNumericConstant_5(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static string ReplaceStringConstant_7(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.FrameExpression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.WhileStmt.LoopBodySurrogate argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public abstract class OneBodyLoopStmt : LoopStmt
    {
        public readonly BlockStmt/*?*/ Body;
        [FilledInDuringResolution]
        public WhileStmt.LoopBodySurrogate/*?*/ BodySurrogate;  // set by Resolver; remains null unless Body==null

        protected OneBodyLoopStmt(Cloner cloner, OneBodyLoopStmt original) : base(cloner, original)
        {
            Body = (BlockStmt)cloner.CloneStmt(original.Body, MutateCSharp.Schemata158.ReplaceBooleanConstant_0(1L, false));
            if (cloner.CloneResolvedFields)
            {
                if (MutateCSharp.Schemata158.ReplaceBinExprOp_1(2L, original.BodySurrogate, null))
                {
                    BodySurrogate = new WhileStmt.LoopBodySurrogate(
                      original.BodySurrogate.LocalLoopTargets.Select(v => cloner.CloneIVariable(v, MutateCSharp.Schemata158.ReplaceBooleanConstant_0(3L, true))).ToList(),
                      original.BodySurrogate.UsesHeap);
                }
            }
        }

        protected OneBodyLoopStmt(RangeToken rangeToken,
          List<AttributedExpression> invariants, Specification<Expression> decreases, Specification<FrameExpression> mod,
          BlockStmt /*?*/ body, Attributes/*?*/ attrs)
          : base(rangeToken, invariants, decreases, mod, attrs)
        {
            Body = body;
        }

        public override IEnumerable<Statement> SubStatements
        {
            get
            {
                if (MutateCSharp.Schemata158.ReplaceBinExprOp_2(4L, Body, null))
                {
                    yield return Body;
                }

                yield break;
            }
        }

        public override IEnumerable<Assumption> Assumptions(Declaration decl)
        {
            if (Body is null)
            {
                yield return new Assumption(decl, tok, AssumptionDescription.LoopWithoutBody);
            }

            yield break;
        }

        public void ComputeBodySurrogate(ErrorReporter reporter)
        {
            if (MutateCSharp.Schemata158.ReplaceBinExprOp_2(5L, Body, null))
            {
                // the loop already has a body
                return;
            }

            var fvs = new HashSet<IVariable>();
            var usesHeap = MutateCSharp.Schemata158.ReplaceBooleanConstant_0(6L, false);

            if (this is WhileStmt { Guard: { } whileGuard })
            {
                FreeVariablesUtil.ComputeFreeVariables(reporter.Options, whileGuard, fvs, ref usesHeap);

            }
            else if (this is ForLoopStmt forS)
            {
                var loopIndex = forS.LoopIndex;
                fvs.Add(loopIndex);

                FreeVariablesUtil.ComputeFreeVariables(reporter.Options, forS.Start, fvs, ref usesHeap);
                if (MutateCSharp.Schemata158.ReplaceBinExprOp_3(7L, forS.End, null))
                {
                    FreeVariablesUtil.ComputeFreeVariables(reporter.Options, forS.End, fvs, ref usesHeap);
                }
            }

            foreach (AttributedExpression inv in Invariants)
            {
                FreeVariablesUtil.ComputeFreeVariables(reporter.Options, inv.E, fvs, ref usesHeap);
            }
            foreach (Expression e in Decreases.Expressions)
            {
                FreeVariablesUtil.ComputeFreeVariables(reporter.Options, e, fvs, ref usesHeap);
            }
            if (MutateCSharp.Schemata158.ReplaceBinExprOp_4(8L, Mod.Expressions, null))
            {
                usesHeap = MutateCSharp.Schemata158.ReplaceBooleanConstant_0(9L, true);  // bearing a modifies clause counts as using the heap
            }

            Contract.Assert(BodySurrogate == null); // .BodySurrogate is set only once
            var loopFrame = new List<IVariable>();
            if (this is ForLoopStmt forLoopStmt)
            {
                loopFrame.Add(forLoopStmt.LoopIndex);
            }
            loopFrame.AddRange(fvs.Where(fv => fv.IsMutable));
            BodySurrogate = new WhileStmt.LoopBodySurrogate(loopFrame, usesHeap);
            var text = BodySurrogate.LocalLoopTargets.Comma(fv => fv.Name);
            if (BodySurrogate.UsesHeap)
            {
                text += MutateCSharp.Schemata158.ReplaceBinExprOp_6(14L, text.Length, MutateCSharp.Schemata158.ReplaceNumericConstant_5(10L, 0)) ? MutateCSharp.Schemata158.ReplaceStringConstant_7(19L, "$Heap") : MutateCSharp.Schemata158.ReplaceStringConstant_7(20L, ", $Heap");
            }
            text = $"this loop has no body{(MutateCSharp.Schemata158.ReplaceBinExprOp_6(25L, text.Length, MutateCSharp.Schemata158.ReplaceNumericConstant_5(21L, 0)) ? "" : MutateCSharp.Schemata158.ReplaceStringConstant_7(30L, " (loop frame: ") + text + MutateCSharp.Schemata158.ReplaceStringConstant_7(31L, ")"))}";
            reporter.Warning(MessageSource.Resolver, ErrorRegistry.NoneId, Tok, text);
        }

    }
}