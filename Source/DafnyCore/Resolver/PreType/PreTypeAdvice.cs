//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

using System.Collections.Generic;
namespace MutateCSharp
{
    internal class Schemata417
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT417");
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

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.PreType argument1, Microsoft.Dafny.PreTypeProxy argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.CommonAdvice.Target argument1, Microsoft.Dafny.CommonAdvice.Target argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_3(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    /// <summary>
    /// A piece of "Advice" is information about a default type.
    ///
    /// A "newtype" of a base type "B" defines a new type that is distinct from "B", with the constructors, operators, and members of "B"
    /// cloned for the new type. For example,
    ///     newtype MyInt = int
    /// defines the type "MyInt". It has the same constructors of "int" (for example, the constructors "7" and "19") and the same operators
    /// as "int" (for example, "+"). As another example,
    ///     newtype MyIntSet = set<int>
    /// defines the type "MyIntSet", and thus set displays (like "{2, 3}"), set comprehensions (like "set x | 0 <= x < 10 :: 2 * x"),
    /// and set operators (like "+") are cloned for the new type.
    ///
    /// Consequently, built-in constructors (like "7" and "{2, 3}") are overloaded. Type inference can therefore not immediately
    /// the type of these constructors. Using the examples above, the type of "7" could be either "int" or "MyInt". (For numeric constructors
    /// like "7", the type could also be the bitvector type of any width as well as the type "ORDINAL".) During type inference,
    /// if any of these constructors is used with specific types, then the overloading can be resolved. But if there are other such types,
    /// as for example in this program:
    ///     method Main() {
    ///       var x := 7 + 19;
    ///       print x, "\n";
    ///     }
    /// then the "Advice" kicks in.
    ///
    /// So, a piece of "Advice" is saying that a given "PreType" should have a specific type *if* the program does not have any other
    /// specific type for it.
    /// </summary>
    public abstract class Advice
    {
        public readonly PreType PreType;

        public Advice(PreType pretype)
        {
            PreType = pretype;
        }

        public abstract string WhatString { get; }

        public bool Apply(PreTypeResolver preTypeResolver)
        {
            if (PreType.Normalize() is PreTypeProxy proxy)
            {
                ActOnAdvice(proxy, preTypeResolver);
                return MutateCSharp.Schemata417.ReplaceBooleanConstant_0(1L, true);
            }
            return MutateCSharp.Schemata417.ReplaceBooleanConstant_0(2L, false);
        }

        public bool ApplyFor(PreTypeProxy proxy, PreTypeResolver preTypeResolver)
        {
            if (MutateCSharp.Schemata417.ReplaceBinExprOp_1(3L, PreType.Normalize(), proxy))
            {
                ActOnAdvice(proxy, preTypeResolver);
                return MutateCSharp.Schemata417.ReplaceBooleanConstant_0(4L, true);
            }
            return MutateCSharp.Schemata417.ReplaceBooleanConstant_0(5L, false);
        }

        private void ActOnAdvice(PreTypeProxy proxy, PreTypeResolver preTypeResolver)
        {
            // Note, the following debug print may come out _before_ the "Type inference state ..." header, if ActOnAdvice is called
            // during what is only a partial constraint solving round.
            preTypeResolver.Constraints.DebugPrint($"    DEBUG: acting on advice, setting {proxy} := {WhatString}");

            var adviceType = GetAdviceType(preTypeResolver);
            proxy.Set(adviceType);
        }

        protected abstract PreType GetAdviceType(PreTypeResolver preTypeResolver);
    }

    public class TypeAdvice : Advice
    {
        private readonly PreType adviceType;
        public TypeAdvice(PreType preType, PreType adviceType)
          : base(preType)
        {
            this.adviceType = adviceType;
        }

        public override string WhatString => adviceType.ToString();

        protected override PreType GetAdviceType(PreTypeResolver preTypeResolver)
        {
            return adviceType;
        }
    }

    public class CommonAdvice : Advice
    {
        public enum Target
        {
            Bool,
            Char,
            Int,
            Real,
            String,
            Object
        }

        private readonly Target what;

        public override string WhatString => MutateCSharp.Schemata417.ReplaceBinExprOp_2(6L, what, Target.Object) ? PreType.TypeNameObjectQ : what.ToString().ToLower();

        public CommonAdvice(PreType preType, Target advice)
          : base(preType)
        {
            what = advice;
        }

        protected override PreType GetAdviceType(PreTypeResolver preTypeResolver)
        {
            Type StringDecl()
            {
                var s = preTypeResolver.resolver.moduleInfo.TopLevels[MutateCSharp.Schemata417.ReplaceStringConstant_3(7L, "string")];
                return new UserDefinedType(s.tok, s.Name, s, new List<Type>());
            }

            var target = what switch
            {
                Target.Bool => preTypeResolver.Type2PreType(Type.Bool),
                Target.Char => preTypeResolver.Type2PreType(Type.Char),
                Target.Int => preTypeResolver.Type2PreType(Type.Int),
                Target.Real => preTypeResolver.Type2PreType(Type.Real),
                Target.String => preTypeResolver.Type2PreType(StringDecl()),
                Target.Object => preTypeResolver.Type2PreType(preTypeResolver.resolver.SystemModuleManager.ObjectQ()),
                _ => throw new cce.UnreachableException() // unexpected case
            };
            return target;
        }
    }
}
