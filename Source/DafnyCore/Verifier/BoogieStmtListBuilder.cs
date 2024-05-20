using System.Linq;
using Microsoft.Boogie;
namespace MutateCSharp
{
    internal class Schemata502
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT502");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplacePostfixUnaryExprOp_0(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

    }
}

namespace Microsoft.Dafny
{
    public class BoogieStmtListBuilder
    {
        public DafnyOptions Options { get; }

        public StmtListBuilder builder;
        public BoogieGenerator tran;

        public BoogieStmtListBuilder(BoogieGenerator tran, DafnyOptions options)
        {
            builder = new Boogie.StmtListBuilder();
            this.tran = tran;
            this.Options = options;
        }

        public void Add(Cmd cmd)
        {
            builder.Add(cmd);
            if (cmd is Boogie.AssertCmd)
            {
                MutateCSharp.Schemata502.ReplacePostfixUnaryExprOp_0(1L, ref tran.assertionCount);
            }
            else if (cmd is Boogie.CallCmd call)
            {
                // A call command may involve a precondition, but we can't tell for sure until the callee
                // procedure has been generated. Therefore, to be on the same side, we count this call
                // as a possible assertion, unless it's a procedure that's part of the translation and
                // known not to have any preconditions.
                if (MutateCSharp.Schemata502.ReplaceBinExprOp_3(14L, () => MutateCSharp.Schemata502.ReplaceBinExprOp_3(6L, () => MutateCSharp.Schemata502.ReplaceBinExprOp_2(3L, call.callee, MutateCSharp.Schemata502.ReplaceStringConstant_1(2L, "$IterHavoc0")), () => MutateCSharp.Schemata502.ReplaceBinExprOp_2(5L, call.callee, MutateCSharp.Schemata502.ReplaceStringConstant_1(4L, "$IterHavoc1"))), () => MutateCSharp.Schemata502.ReplaceBinExprOp_2(13L, call.callee, MutateCSharp.Schemata502.ReplaceStringConstant_1(12L, "$YieldHavoc"))))
                {
                    // known not to have any preconditions
                }
                else
                {
                    MutateCSharp.Schemata502.ReplacePostfixUnaryExprOp_0(20L, ref tran.assertionCount);
                }
            }
        }

        public void Add(StructuredCmd scmd)
        {
            builder.Add(scmd);
            if (scmd is Boogie.WhileCmd whyle && whyle.Invariants.Any(inv => inv is Boogie.AssertCmd))
            {
                MutateCSharp.Schemata502.ReplacePostfixUnaryExprOp_0(21L, ref tran.assertionCount);
            }
        }

        public void Add(TransferCmd tcmd) { builder.Add(tcmd); }
        public void AddLabelCmd(string label) { builder.AddLabelCmd(label); }
        public void AddLocalVariable(string name) { builder.AddLocalVariable(name); }

        public StmtList Collect(Boogie.IToken tok)
        {
            return builder.Collect(tok);
        }
    }
}