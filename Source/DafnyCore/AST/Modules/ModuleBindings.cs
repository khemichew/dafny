using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata125
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT125");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, Microsoft.Dafny.ModuleDefinition argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
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

        internal static bool ReplaceBinExprOp_7(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.ModuleBindings argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.AliasModuleDecl argument1, Microsoft.Dafny.ModuleDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, Microsoft.Dafny.ModuleDefinition argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.AbstractModuleDecl argument1, Microsoft.Dafny.ModuleDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class ModuleBindings
    {
        private ModuleBindings parent;
        private Dictionary<string, ModuleDecl> modules;
        private Dictionary<string, ModuleBindings> bindings;

        public ModuleBindings(ModuleBindings p)
        {
            parent = p;
            modules = new Dictionary<string, ModuleDecl>();
            bindings = new Dictionary<string, ModuleBindings>();
        }

        public bool BindName(string name, ModuleDecl subModule, ModuleBindings b)
        {
            if (modules.ContainsKey(name))
            {
                return MutateCSharp.Schemata125.ReplaceBooleanConstant_0(1L, false);
            }
            else
            {
                modules.Add(name, subModule);
                bindings.Add(name, b);
                return MutateCSharp.Schemata125.ReplaceBooleanConstant_0(2L, true);
            }

            return default;
        }

        public bool TryLookup(string name, out ModuleDecl m)
        {
            Contract.Requires(name != null);
            return TryLookupFilter(name, out m, l => MutateCSharp.Schemata125.ReplaceBooleanConstant_0(3L, true));
        }

        public bool TryLookupFilter(string name, out ModuleDecl m, Func<ModuleDecl, bool> filter)
        {
            Contract.Requires(name != null);
            if (modules.TryGetValue(name, out m) && filter(m))
            {
                return MutateCSharp.Schemata125.ReplaceBooleanConstant_0(4L, true);
            }
            else if (MutateCSharp.Schemata125.ReplaceBinExprOp_1(5L, parent, null))
            {
                return parent.TryLookupFilter(name, out m, filter);
            }
            else
            {
                return MutateCSharp.Schemata125.ReplaceBooleanConstant_0(6L, false);
            }

            return default;
        }

        public IEnumerable<ModuleDecl> ModuleList
        {
            get { return modules.Values; }
        }

        public ModuleBindings SubBindings(string name)
        {
            ModuleBindings v = null;
            bindings.TryGetValue(name, out v);
            return v;
        }

        public bool ResolveQualifiedModuleIdRootAbstract(AbstractModuleDecl context, ModuleQualifiedId qid,
          out ModuleDecl result)
        {
            Contract.Assert(qid != null);
            IToken root = qid.Path[MutateCSharp.Schemata125.ReplaceNumericConstant_2(7L, 0)].StartToken;
            result = null;
            bool res = TryLookupFilter(root.val, out result,
              m => MutateCSharp.Schemata125.ReplaceBinExprOp_6(34L, () => MutateCSharp.Schemata125.ReplaceBinExprOp_3(11L, context, m), () => (MutateCSharp.Schemata125.ReplaceBinExprOp_7(28L, () => (MutateCSharp.Schemata125.ReplaceBinExprOp_6(22L, () => MutateCSharp.Schemata125.ReplaceBinExprOp_4(12L, context.EnclosingModuleDefinition, m.EnclosingModuleDefinition), () => MutateCSharp.Schemata125.ReplaceBinExprOp_5(17L, context.Exports.Count, MutateCSharp.Schemata125.ReplaceNumericConstant_2(13L, 0)))), () => m is LiteralModuleDecl))));
            return res;
        }

        /// <summary>
        /// Find a matching module for the root of the QualifiedId, ignoring
        /// (a) the module (context) itself and (b) any local imports
        /// The latter is so that if one writes 'import A`E  import F = A`F' the second A does not
        /// resolve to the alias produced by the first import
        /// </summary>
        public bool ResolveQualifiedModuleIdRootImport(AliasModuleDecl context, ModuleQualifiedId qid,
          out ModuleDecl result)
        {
            Contract.Assert(qid != null);
            IToken root = qid.Path[MutateCSharp.Schemata125.ReplaceNumericConstant_2(40L, 0)].StartToken;
            result = null;
            bool res = TryLookupFilter(root.val, out result,
              m => MutateCSharp.Schemata125.ReplaceBinExprOp_6(67L, () => MutateCSharp.Schemata125.ReplaceBinExprOp_8(44L, context, m), () => (MutateCSharp.Schemata125.ReplaceBinExprOp_7(61L, () => (MutateCSharp.Schemata125.ReplaceBinExprOp_6(55L, () => MutateCSharp.Schemata125.ReplaceBinExprOp_4(45L, context.EnclosingModuleDefinition, m.EnclosingModuleDefinition), () => MutateCSharp.Schemata125.ReplaceBinExprOp_5(50L, context.Exports.Count, MutateCSharp.Schemata125.ReplaceNumericConstant_2(46L, 0)))), () => m is LiteralModuleDecl))));
            return res;
        }

        public bool ResolveQualifiedModuleIdRootRefines(ModuleDefinition context, ModuleQualifiedId qid,
          out ModuleDecl result)
        {
            Contract.Assert(qid != null);
            IToken root = qid.Path[MutateCSharp.Schemata125.ReplaceNumericConstant_2(73L, 0)].StartToken;
            result = null;
            bool res = TryLookupFilter(root.val, out result, m => MutateCSharp.Schemata125.ReplaceBinExprOp_9(77L, m.EnclosingModuleDefinition, context));
            return res;
        }
    }
}