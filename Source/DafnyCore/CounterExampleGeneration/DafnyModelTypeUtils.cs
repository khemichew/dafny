// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
#nullable enable

using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace MutateCSharp
{
    internal class Schemata260
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT260");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_5(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.ArrowType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static int ReplaceNumericConstant_2(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{

    /// <summary>
    /// This class stores various transformations that could be useful to perform
    /// on types extracted from DafnyModel (e.g. to convert Boogie type names
    /// back to the original Dafny names)
    /// </summary>
    public static class DafnyModelTypeUtils
    {

        private static readonly Regex ModuleSeparatorRegex = new(MutateCSharp.Schemata260.ReplaceStringConstant_0(1L, "(?<=[^_](__)*)_m"));
        private static readonly Regex UnderscoreRemovalRegex = new(MutateCSharp.Schemata260.ReplaceStringConstant_0(2L, "__"));
        private static readonly Regex TupleRegex = new(MutateCSharp.Schemata260.ReplaceStringConstant_0(3L, "_[Ss]ystem\\._?[Tt]uple#?"));

        public static Type GetNonNullable(Type type)
        {
            if (type is not UserDefinedType userType)
            {
                return type;
            }

            return new UserDefinedType(new Token(),
              userType.Name.TrimEnd('?'), userType.TypeArgs);
        }

        public static Type ReplaceTypeVariables(Type type, Type with)
        {
            var result = ReplaceType(type, t => t.Name.Contains('$'), _ => with);
            FillInTypeArgs(result, with);
            return result;
        }

        /// <summary>
        /// Recursively replace all types within <param>type</param> that satisfy
        /// <param>condition</param>
        /// </summary>
        public static Type ReplaceType(Type type, Func<UserDefinedType, Boolean> condition,
          Func<UserDefinedType, Type> replacement)
        {
            if ((type is not UserDefinedType userType) || (type is ArrowType) || (MutateCSharp.Schemata260.ReplaceBinExprOp_1(4L, type.AsArrowType, null)))
            {
                return TransformType(type, t => ReplaceType(t, condition, replacement));
            }
            var newType = condition(userType) ? replacement(userType) : type;
            newType.TypeArgs = newType.TypeArgs.ConvertAll(t =>
              TransformType(t, t => ReplaceType(t, condition, replacement)));
            if (newType is not UserDefinedType newUserType)
            {
                return newType;
            }
            return new UserDefinedType(newUserType.tok, newUserType.Name,
              newUserType.TypeArgs);
        }

        public static Type GetInDafnyFormat(Type type)
        {
            if ((type is not UserDefinedType userType) || (type is ArrowType) || (MutateCSharp.Schemata260.ReplaceBinExprOp_1(5L, type.AsArrowType, null)))
            {
                return TransformType(type, GetInDafnyFormat);
            }
            // The line below converts "_m" used in boogie to separate modules to ".":
            var newName = ModuleSeparatorRegex.Replace(userType.Name, MutateCSharp.Schemata260.ReplaceStringConstant_0(6L, "."));
            // strip everything after @, this is done for type variables:
            newName = newName.Split(MutateCSharp.Schemata260.ReplaceStringConstant_0(7L, "@"))[MutateCSharp.Schemata260.ReplaceNumericConstant_2(8L, 0)];
            // The code below converts every "__" to "_":
            newName = UnderscoreRemovalRegex.Replace(newName, MutateCSharp.Schemata260.ReplaceStringConstant_0(12L, "_"));
            newName = ConvertTupleName(newName);
            newName = string.Join(MutateCSharp.Schemata260.ReplaceStringConstant_0(13L, "."), newName.Split(MutateCSharp.Schemata260.ReplaceStringConstant_0(14L, "."))
              .Where(part => MutateCSharp.Schemata260.ReplaceBinExprOp_4(27L, () => MutateCSharp.Schemata260.ReplaceBinExprOp_4(19L, () => MutateCSharp.Schemata260.ReplaceBinExprOp_3(16L, part, MutateCSharp.Schemata260.ReplaceStringConstant_0(15L, "_module")), () => MutateCSharp.Schemata260.ReplaceBinExprOp_3(18L, part, MutateCSharp.Schemata260.ReplaceStringConstant_0(17L, "_default"))), () => MutateCSharp.Schemata260.ReplaceBinExprOp_3(26L, part, MutateCSharp.Schemata260.ReplaceStringConstant_0(25L, "_System")))));
            return new UserDefinedType(new Token(), newName,
              type.TypeArgs.ConvertAll(t => TransformType(t, GetInDafnyFormat)));
        }

        public static string ConvertTupleName(string name)
        {
            return TupleRegex.Replace(name, MutateCSharp.Schemata260.ReplaceStringConstant_0(33L, "_tuple#"));
        }

        /// <summary>
        /// Recursively transform all UserDefinedType objects within a given type
        /// </summary>
        private static Type TransformType(Type type, Func<UserDefinedType, Type> transform)
        {
            if (MutateCSharp.Schemata260.ReplaceBinExprOp_5(35L, () => type is ArrowType, () => MutateCSharp.Schemata260.ReplaceBinExprOp_1(34L, type.AsArrowType, null)))
            {
                var arrowType = type.AsArrowType;
                return new ArrowType(new Token(),
                  arrowType.Args.Select(t => TransformType(t, transform)).ToList(),
                  TransformType(arrowType.Result, transform));
            }
            switch (type)
            {
                case BasicType:
                    return type;
                    break;
                case MapType mapType when mapType.HasTypeArg():
                    return new MapType(mapType.Finite,
                      TransformType(mapType.Domain, transform),
                      TransformType(mapType.Range, transform));
                    break;
                case SeqType seqType when seqType.HasTypeArg():
                    return new SeqType(TransformType(seqType.Arg, transform));
                    break;
                case SetType setType when setType.HasTypeArg():
                    return new SetType(setType.Finite, TransformType(setType.Arg, transform));
                    break;
                case MultiSetType multiSetType when multiSetType.HasTypeArg():
                    return new MultiSetType(TransformType(multiSetType, transform));
                    break;
                case UserDefinedType userDefinedType:
                    return transform(userDefinedType);
                    break;
                case InferredTypeProxy inferredTypeProxy:
                    var tmp = new InferredTypeProxy();
                    tmp.T = TransformType(inferredTypeProxy.T, transform);
                    return tmp;
                    break;
            }
            return type;
        }

        /// <summary>
        /// Whenever a collection type does not have an argument, fill it in with the provided arg type
        /// </summary>
        private static void FillInTypeArgs(Type type, Type arg)
        {
            switch (type)
            {
                case BasicType:
                    return;
                    break;
                case MapType mapType when !mapType.HasTypeArg():
                    mapType.SetTypeArgs(arg, arg);
                    return;
                    break;
                case SeqType seqType when !seqType.HasTypeArg():
                    seqType.SetTypeArg(arg);
                    return;
                    break;
                case SetType setType when !setType.HasTypeArg():
                    setType.SetTypeArg(arg);
                    return;
                    break;
                case MultiSetType multiSetType when !multiSetType.HasTypeArg():
                    multiSetType.SetTypeArg(arg);
                    return;
                    break;
                case UserDefinedType userDefinedType:
                    userDefinedType.TypeArgs.ForEach(typ => FillInTypeArgs(typ, arg));
                    return;
                    break;
                case InferredTypeProxy inferredTypeProxy:
                    FillInTypeArgs(inferredTypeProxy.T, arg);
                    return;
                    break;
            }
        }
    }
}