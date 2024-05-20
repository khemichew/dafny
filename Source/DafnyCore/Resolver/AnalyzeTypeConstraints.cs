//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata367
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT367");
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

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
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
    public
/// <summary>
/// This class contains the logic to figure out if a subset types and newtypes have compilable constraints.
/// This analysis leads to the setting of the .ConstraintIsCompilable field of the declarations of those types.
/// </summary>
class AnalyzeTypeConstraints
    {
        public static void AssignConstraintIsCompilable(List<TopLevelDecl> declarations, DafnyOptions options)
        {
            // It's important to do the declarations in topological order from how they depend on each other.
            declarations = TopologicallySortedTopLevelDecls(declarations);

            foreach (var d in declarations.Where(decl => decl is SubsetTypeDecl or NewtypeDecl))
            {
                var declWithConstraints = (RedirectingTypeDecl)d;

                var constraintIsCompilable = MutateCSharp.Schemata367.ReplaceBooleanConstant_0(1L, true);

                // Check base type
                var baseType = (declWithConstraints.Var?.Type ?? ((NewtypeDecl)declWithConstraints).BaseType).NormalizeExpandKeepConstraints();
                if (baseType.AsRedirectingType is (SubsetTypeDecl or NewtypeDecl) and var baseDecl)
                {
                    constraintIsCompilable &= baseDecl.ConstraintIsCompilable;
                }

                // Check the type's constraint
                if (MutateCSharp.Schemata367.ReplaceBinExprOp_1(2L, declWithConstraints.Constraint, null))
                {
                    constraintIsCompilable &= ExpressionTester.CheckIsCompilable(options, null, declWithConstraints.Constraint,
                      new CodeContextWrapper(declWithConstraints, MutateCSharp.Schemata367.ReplaceBooleanConstant_0(3L, true)));
                }

                declWithConstraints.ConstraintIsCompilable = constraintIsCompilable;
            }
        }

        /// <summary>
        /// Return "declarations" in sorted order, so that each declaration is preceded by those on which it depends.
        /// It is assumed that "declarations" are all from the same module and that the call graph of that module has been constructed.
        /// If there's some given declaration that's not in the call graph, then that's fine; it just means that the call
        /// graph does not constrain the output order of that declaration.
        /// </summary>
        private static List<TopLevelDecl> TopologicallySortedTopLevelDecls(List<TopLevelDecl> declarations)
        {
            // Dependency information among the declarations is stored in the enclosing module's call graph. To get to that
            // call graph, we need to have the module declaration, which we obtain from one of the given declarations:
            if (MutateCSharp.Schemata367.ReplaceBinExprOp_3(8L, declarations.Count, MutateCSharp.Schemata367.ReplaceNumericConstant_2(4L, 0)))
            {
                return declarations;
            }
            var enclosingModule = declarations[MutateCSharp.Schemata367.ReplaceNumericConstant_2(13L, 0)].EnclosingModuleDefinition;
            Contract.Assert(declarations.TrueForAll(decl => decl.EnclosingModuleDefinition == enclosingModule));

            // From the module declaration, we get the components sorted according to how they depend on each other.
            var sortedComponents = enclosingModule.CallGraph.TopologicallySortedComponents();

            // But... this is a list of ICallable's (which also includes MemberDecl's and may not contain all TopLevelDecl's).
            // So, we filter the ICallable's to consider only the given TopLevelDecl's. We also remember which declarations we
            // have added to the output, so we later can add all the remaining ones.
            var remainingDecls = new HashSet<TopLevelDecl>(declarations);
            var output = new List<TopLevelDecl>();
            foreach (var callable in sortedComponents)
            {
                if (callable is TopLevelDecl topLevelDecl && remainingDecls.Contains(topLevelDecl))
                {
                    output.Add(topLevelDecl);
                    remainingDecls.Remove(topLevelDecl);
                }
            }

            // Finally, add in those TopLevelDecl's that were not in the call graph.
            foreach (var decl in declarations)
            {
                if (remainingDecls.Contains(decl))
                {
                    output.Add(decl);
                }
            }
            Contract.Assert(declarations.Count == output.Count); // this assumes there were no duplicates in the given declarations

            return output;
        }

    }
}
