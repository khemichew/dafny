using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata151
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT151");
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

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
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
    /// Class "BreakStmt" represents both "break" and "continue" statements.
    /// </summary>
    public class BreakStmt : Statement, IHasUsages, ICloneable<BreakStmt>
    {
        public readonly IToken TargetLabel;
        public readonly bool IsContinue;
        public string Kind => IsContinue ? MutateCSharp.Schemata151.ReplaceStringConstant_0(1L, "continue") : MutateCSharp.Schemata151.ReplaceStringConstant_0(2L, "break");
        public readonly int BreakAndContinueCount;
        [FilledInDuringResolution] public Statement TargetStmt;
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(TargetLabel != null || 1 <= BreakAndContinueCount);
        }

        public BreakStmt Clone(Cloner cloner)
        {
            return new BreakStmt(cloner, this);
        }

        public BreakStmt(Cloner cloner, BreakStmt original) : base(cloner, original)
        {
            TargetLabel = original.TargetLabel;
            IsContinue = original.IsContinue;
            BreakAndContinueCount = original.BreakAndContinueCount;
            if (cloner.CloneResolvedFields)
            {
                TargetStmt = cloner.CloneStmt(original.TargetStmt, MutateCSharp.Schemata151.ReplaceBooleanConstant_1(3L, true));
            }
        }

        public BreakStmt(RangeToken rangeToken, IToken targetLabel, bool isContinue)
          : base(rangeToken)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(targetLabel != null);
            this.TargetLabel = targetLabel;
            this.IsContinue = isContinue;
        }

        /// <summary>
        /// For "isContinue == false", represents the statement "break ^breakAndContinueCount ;".
        /// For "isContinue == true", represents the statement "break ^(breakAndContinueCount - 1) continue;".
        /// </summary>
        public BreakStmt(RangeToken rangeToken, int breakAndContinueCount, bool isContinue)
          : base(rangeToken)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(1 <= breakAndContinueCount);
            this.BreakAndContinueCount = breakAndContinueCount;
            this.IsContinue = isContinue;
        }

        public IEnumerable<IDeclarationOrUsage> GetResolvedDeclarations()
        {
            return new[] { TargetStmt }.OfType<IDeclarationOrUsage>();
        }

        public IToken NameToken => Tok;
    }
}