using System.Collections.Generic;
using System.CommandLine;
using System.Diagnostics.Contracts;
using System.Linq;
using DafnyCore;
using DafnyCore.Options;
namespace MutateCSharp
{
    internal class Schemata164
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT164");
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
    public class PrintStmt : Statement, ICloneable<PrintStmt>, ICanFormat
    {
        public readonly List<Expression> Args;

        public static readonly Option<bool> TrackPrintEffectsOption = new(MutateCSharp.Schemata164.ReplaceStringConstant_0(1L, "--track-print-effects"),
      MutateCSharp.Schemata164.ReplaceStringConstant_0(2L, "A compiled method, constructor, or iterator is allowed to have print effects only if it is marked with {{:print}}."));
        static PrintStmt()
        {
            DafnyOptions.RegisterLegacyBinding(TrackPrintEffectsOption, (options, value) =>
            {
                options.EnforcePrintEffects = value;
            });

            DooFile.RegisterLibraryChecks(
              checks: new Dictionary<Option, OptionCompatibility.OptionCheck> {
        { TrackPrintEffectsOption, OptionCompatibility.CheckOptionLocalImpliesLibrary }
              });
        }

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(cce.NonNullElements(Args));
        }

        public PrintStmt Clone(Cloner cloner)
        {
            return new PrintStmt(cloner, this);
        }

        public PrintStmt(Cloner cloner, PrintStmt original) : base(cloner, original)
        {
            Args = original.Args.Select(cloner.CloneExpr).ToList();
        }

        public PrintStmt(RangeToken rangeToken, List<Expression> args)
          : base(rangeToken)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(cce.NonNullElements(args));

            Args = args;
        }
        public override IEnumerable<Expression> NonSpecificationSubExpressions
        {
            get
            {
                foreach (var e in base.NonSpecificationSubExpressions) { yield return e; }
                foreach (var arg in Args)
                {
                    yield return arg;
                }

                yield break;
            }
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            return formatter.SetIndentPrintRevealStmt(indentBefore, OwnedTokens);
        }
    }
}
