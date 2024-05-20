using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata169
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT169");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_3(long mutantId, System.Collections.Generic.IEnumerable<Microsoft.Dafny.Statement> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
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
    /// The class represents several possible scenarios:
    /// * ...;
    ///   S == null
    /// * assert ...
    ///   ConditionOmitted == true
    /// * assume ...
    ///   ConditionOmitted == true
    /// * if ... { Stmt }
    ///   if ... { Stmt } else ElseStmt
    ///   ConditionOmitted == true
    /// * while ... invariant J;
    ///   ConditionOmitted == true && BodyOmitted == true
    /// * while ... invariant J; { Stmt }
    ///   ConditionOmitted == true && BodyOmitted == false
    /// * modify ...;
    ///   ConditionOmitted == true && BodyOmitted == false
    /// * modify ... { Stmt }
    ///   ConditionOmitted == true && BodyOmitted == false
    /// </summary>
    public class SkeletonStatement : Statement, ICloneable<SkeletonStatement>, ICanFormat
    {
        public readonly Statement S;
        public bool ConditionOmitted
        {
            get { return MutateCSharp.Schemata169.ReplaceBinExprOp_0(1L, ConditionEllipsis, null); }
        }

        public readonly IToken ConditionEllipsis;
        public bool BodyOmitted
        {
            get { return MutateCSharp.Schemata169.ReplaceBinExprOp_0(2L, BodyEllipsis, null); }
        }

        public readonly IToken BodyEllipsis;

        public SkeletonStatement Clone(Cloner cloner)
        {
            return new SkeletonStatement(cloner, this);
        }

        public SkeletonStatement(Cloner cloner, SkeletonStatement original) : base(cloner, original)
        {
            S = MutateCSharp.Schemata169.ReplaceBinExprOp_1(3L, original.S, null) ? null : cloner.CloneStmt(original.S, MutateCSharp.Schemata169.ReplaceBooleanConstant_2(4L, false));
            ConditionEllipsis = original.ConditionEllipsis;
            BodyEllipsis = original.BodyEllipsis;
        }

        public SkeletonStatement(RangeToken rangeToken)
          : base(rangeToken)
        {
            Contract.Requires(rangeToken != null);
            S = null;
        }
        public SkeletonStatement(Statement s, IToken conditionEllipsis, IToken bodyEllipsis)
          : base(s.RangeToken)
        {
            Contract.Requires(s != null);
            S = s;
            ConditionEllipsis = conditionEllipsis;
            BodyEllipsis = bodyEllipsis;
        }
        public override IEnumerable<Statement> SubStatements
        {
            get
            {
                // The SkeletonStatement is really a modification of its inner statement S.  Therefore,
                // we don't consider S to be a substatement.  Instead, the substatements of S are the
                // substatements of the SkeletonStatement.  In the case the SkeletonStatement modifies
                // S by omitting its body (which is true only for loops), there are no substatements.
                if (MutateCSharp.Schemata169.ReplaceBinExprOp_4(6L, () => !BodyOmitted, () => MutateCSharp.Schemata169.ReplaceBinExprOp_3(5L, S.SubStatements, null)))
                {
                    foreach (var s in S.SubStatements)
                    {
                        yield return s;
                    }
                }

                yield break;
            }
        }

        public override IEnumerable<Statement> PreResolveSubStatements
        {
            get
            {
                yield return S;
            }
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            return MutateCSharp.Schemata169.ReplaceBooleanConstant_2(12L, true);
        }
    }
}