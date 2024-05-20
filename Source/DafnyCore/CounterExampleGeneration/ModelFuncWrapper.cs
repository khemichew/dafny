// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Boogie;
namespace MutateCSharp
{
    internal class Schemata261
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT261");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Boogie.Model.FuncTuple argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_8(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 - argument2;
        }

        internal static int ReplaceBinExprOp_0(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 + argument2;
        }

        internal static string ReplaceStringConstant_5(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
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

        internal static bool ReplaceBinExprOp_7(long mutantId, int? argument1, int? argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_6(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static int ReplaceNumericConstant_4(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Boogie.Model.Element argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public

/// <summary>
/// The wrapper acts exactly like Model.Func in Boogie except that it skips first N arguments of a function application.
/// This means that the behavior of ModelFuncWrapper is independent of the polymorphism encoding mode in Boogie
/// provided the argsToSkip argument is passed correctly during initialization.
/// 
/// The reason this is a wrapper rather than a subclass is to prevent the use of functionality that might be added to
/// the base class in the future unless it is explicitly supported here and because the creation of Model.Func
/// objects in Boogie is tied to updates to various fields in the Model itself (see MkFunc method)
/// </summary>
class ModelFuncWrapper
    {

        private readonly Model.Func func;
        private readonly int argsToSkip;

        public ModelFuncWrapper(DafnyModel model, string name, int arity, int argsToSkip)
        {
            this.argsToSkip = argsToSkip;
            func = model.Model.MkFunc(name, MutateCSharp.Schemata261.ReplaceBinExprOp_0(1L, arity, this.argsToSkip));
        }

        public ModelFuncWrapper(Model.Func func, int argsToSkip)
        {
            this.func = func;
            this.argsToSkip = argsToSkip;
        }

        private ModelFuncTupleWrapper? ConvertFuncTuple(Model.FuncTuple? tuple)
        {
            return MutateCSharp.Schemata261.ReplaceBinExprOp_1(10L, tuple, null) ? null : new ModelFuncTupleWrapper(tuple.Result, tuple.Args[argsToSkip..]);
        }

        public ModelFuncTupleWrapper? AppWithResult(Model.Element element)
        {
            return ConvertFuncTuple(func.AppWithResult(element));
        }

        public IEnumerable<ModelFuncTupleWrapper> AppsWithResult(Model.Element element)
        {
            return func.AppsWithResult(element).Select(ConvertFuncTuple).OfType<ModelFuncTupleWrapper>();
        }

        public IEnumerable<ModelFuncTupleWrapper> Apps => func.Apps.Select(ConvertFuncTuple).OfType<ModelFuncTupleWrapper>();

        public Model.Element? GetConstant()
        {
            return func.GetConstant();
        }

        public Model.Element? OptEval(Model.Element? element)
        {
            if (MutateCSharp.Schemata261.ReplaceBinExprOp_2(11L, element, null))
            {
                return null;
            }
            var app = func.AppWithArg(argsToSkip, element);
            return app?.Result;
        }

        public ModelFuncTupleWrapper? AppWithArg(int index, Model.Element element)
        {
            return ConvertFuncTuple(func.AppWithArg(MutateCSharp.Schemata261.ReplaceBinExprOp_0(12L, argsToSkip, index), element));
        }

        public Model.Element? OptEval(Model.Element? first, Model.Element? second)
        {
            if (MutateCSharp.Schemata261.ReplaceBinExprOp_3(23L, () => MutateCSharp.Schemata261.ReplaceBinExprOp_2(21L, first, null), () => MutateCSharp.Schemata261.ReplaceBinExprOp_2(22L, second, null)))
            {
                return null;
            }
            var apps = func.AppsWithArgs(argsToSkip, first, MutateCSharp.Schemata261.ReplaceBinExprOp_0(33L, argsToSkip, MutateCSharp.Schemata261.ReplaceNumericConstant_4(29L, 1)), second).ToList();
            return !apps.Any() ? null : apps.First().Result;
        }

        public IEnumerable<ModelFuncTupleWrapper> AppsWithArg(int i, Model.Element element)
        {
            return func.AppsWithArg(MutateCSharp.Schemata261.ReplaceBinExprOp_0(42L, i, argsToSkip), element).Select(ConvertFuncTuple).OfType<ModelFuncTupleWrapper>();
        }

        public IEnumerable<ModelFuncTupleWrapper> AppsWithArgs(int i0, Model.Element element0, int i1, Model.Element element1)
        {
            return func.AppsWithArgs(MutateCSharp.Schemata261.ReplaceBinExprOp_0(51L, i0, argsToSkip), element0, MutateCSharp.Schemata261.ReplaceBinExprOp_0(60L, i1, argsToSkip), element1).Select(ConvertFuncTuple).OfType<ModelFuncTupleWrapper>();
        }

        /// <summary>
        /// Create a new function that merges together the applications of all functions with the given name and arity
        /// at least equal to <param name="arity"></param>
        /// </summary>
        internal static ModelFuncWrapper MergeFunctions(DafnyModel model, List<string> names, int arity)
        {
            var name = MutateCSharp.Schemata261.ReplaceStringConstant_5(69L, "[") + arity + MutateCSharp.Schemata261.ReplaceStringConstant_5(70L, "]");
            if (model.Model.HasFunc(name))
            {
                // Coming up with a new name if the ideal one is reserved
                int id = MutateCSharp.Schemata261.ReplaceNumericConstant_4(71L, 0);
                while (model.Model.HasFunc(name + MutateCSharp.Schemata261.ReplaceStringConstant_5(75L, "#") + id))
                {
                    MutateCSharp.Schemata261.ReplacePostfixUnaryExprOp_6(76L, ref id);
                }
                name += MutateCSharp.Schemata261.ReplaceStringConstant_5(77L, "#") + id;
            }
            var result = new ModelFuncWrapper(model, name, arity, MutateCSharp.Schemata261.ReplaceNumericConstant_4(78L, 0));
            foreach (var func in model.Model.Functions)
            {
                if (MutateCSharp.Schemata261.ReplaceBinExprOp_3(93L, () => MutateCSharp.Schemata261.ReplaceBinExprOp_3(82L, () => !names.Contains(func.Name), () => func.Arity == null), () => MutateCSharp.Schemata261.ReplaceBinExprOp_7(88L, func.Arity, arity)))
                {
                    continue;
                }
                // this removes type arguments when TypeEncodingMethod == Bpl.CoreOptions.TypeEncoding.Arguments
                int offset = MutateCSharp.Schemata261.ReplaceBinExprOp_8(99L, func.Arity.Value, arity);
                foreach (var app in func.Apps)
                {
                    result.func.AddApp(app.Result, app.Args[offset..]);
                }
                result.func.Else ??= func.Else;
            }
            return result;
        }

        public class ModelFuncTupleWrapper
        {

            static readonly Model.Element[] EmptyArgs = Array.Empty<Model.Element>();

            public readonly Model.Element Result;
            public readonly Model.Element[] Args;

            public ModelFuncTupleWrapper(Model.Element res, Model.Element[] args)
            {
                Args = args ?? EmptyArgs;
                Result = res;
            }
        }
    }
}