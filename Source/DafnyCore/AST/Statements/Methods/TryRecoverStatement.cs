using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata167
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT167");
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

    }
}

namespace Microsoft.Dafny
{

    /// <summary>
    /// A statement something like a try/catch block that recovers from halting.
    /// Not actually useable in Dafny syntax, but would likely look something like this if it was:
    ///
    /// try {
    ///   <Body>
    /// } recover (haltMessage: string) {
    ///   <RecoveryBlock>
    /// }
    ///
    /// </summary>
    public class TryRecoverStatement : Statement, ICloneable<TryRecoverStatement>
    {
        public readonly Statement TryBody;
        public readonly IVariable HaltMessageVar;
        public readonly Statement RecoverBody;

        public TryRecoverStatement Clone(Cloner cloner)
        {
            return new TryRecoverStatement(cloner, this);
        }

        public TryRecoverStatement(Cloner cloner, TryRecoverStatement original) : base(cloner, original)
        {
            TryBody = cloner.CloneStmt(original.TryBody, MutateCSharp.Schemata167.ReplaceBooleanConstant_0(1L, false));
            RecoverBody = cloner.CloneStmt(original.RecoverBody, MutateCSharp.Schemata167.ReplaceBooleanConstant_0(2L, false));
            HaltMessageVar = cloner.CloneIVariable(original.HaltMessageVar, MutateCSharp.Schemata167.ReplaceBooleanConstant_0(3L, false));
        }

        public TryRecoverStatement(Statement tryBody, IVariable haltMessageVar, Statement recoverBody)
          : base(new RangeToken(tryBody.StartToken, recoverBody.EndToken))
        {
            Contract.Requires(tryBody != null);
            Contract.Requires(haltMessageVar != null);
            Contract.Requires(recoverBody != null);
            TryBody = tryBody;
            HaltMessageVar = haltMessageVar;
            RecoverBody = recoverBody;
        }
    }
}