using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
namespace MutateCSharp
{
    internal class Schemata196
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT196");
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

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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
    public class SubsetTypeDecl : TypeSynonymDecl, RedirectingTypeDecl, ICanAutoRevealDependencies, ICanVerify
    {
        public override string WhatKind => MutateCSharp.Schemata196.ReplaceStringConstant_0(1L, "subset type");
        public readonly BoundVar Var;
        public readonly Expression Constraint;
        public enum WKind { CompiledZero, Compiled, Ghost, OptOut, Special }
        public readonly WKind WitnessKind;
        public Expression/*?*/ Witness;  // non-null iff WitnessKind is Compiled or Ghost

        private bool? constraintIsCompilable = null;
        [FilledInDuringResolution]
        bool RedirectingTypeDecl.ConstraintIsCompilable
        {
            get
            {
                Contract.Assert(constraintIsCompilable != null);
                return (bool)constraintIsCompilable;
            }
            set
            {
                Contract.Assert(constraintIsCompilable == null);
                constraintIsCompilable = value;
            }
        }

        public SubsetTypeDecl(RangeToken rangeToken, Name name, TypeParameter.TypeParameterCharacteristics characteristics, List<TypeParameter> typeArgs, ModuleDefinition module,
          BoundVar id, Expression constraint, WKind witnessKind, Expression witness,
          Attributes attributes)
          : base(rangeToken, name, characteristics, typeArgs, module, id.Type, attributes)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(typeArgs != null);
            Contract.Requires(module != null);
            Contract.Requires(id != null && id.Type != null);
            Contract.Requires(constraint != null);
            Contract.Requires((witnessKind == WKind.Compiled || witnessKind == WKind.Ghost) == (witness != null));
            Var = id;
            Constraint = constraint;
            Witness = witness;
            WitnessKind = witnessKind;
        }

        public override IEnumerable<INode> Children =>
          base.Children.Concat(new[] { Constraint }).Concat(
      MutateCSharp.Schemata196.ReplaceBinExprOp_1(2L, Witness, null) ? new[] { Witness } :
              Enumerable.Empty<INode>()
            );

        BoundVar RedirectingTypeDecl.Var => Var;
        Expression RedirectingTypeDecl.Constraint => Constraint;
        WKind RedirectingTypeDecl.WitnessKind => WitnessKind;
        Expression RedirectingTypeDecl.Witness => Witness;

        public override List<Type> ParentTypes(List<Type> typeArgs)
        {
            return new List<Type> { RhsWithArgument(typeArgs) };
        }
        public bool ShouldVerify => MutateCSharp.Schemata196.ReplaceBooleanConstant_2(3L, true); // This could be made more accurate
        public ModuleDefinition ContainingModule => EnclosingModuleDefinition;
        public override SymbolKind Kind => SymbolKind.Class;
        public override string GetDescription(DafnyOptions options)
        {
            return MutateCSharp.Schemata196.ReplaceStringConstant_0(4L, "subset type");
        }

        public void AutoRevealDependencies(AutoRevealFunctionDependencies Rewriter, DafnyOptions Options, ErrorReporter Reporter)
        {
            if (Witness is null)
            {
                return;
            }

            var expressions = Constraint.SubExpressions.ToList().Concat(Witness.SubExpressions.ToList());
            foreach (var expression in expressions)
            {
                if (expression is not FunctionCallExpr funcExpr)
                {
                    continue;
                }

                var func = funcExpr.Function;

                if (!AutoRevealFunctionDependencies.IsRevealable(EnclosingModuleDefinition.AccessibleMembers, func))
                {
                    continue;
                }

                if (func.IsMadeImplicitlyOpaque(Options))
                {
                    var revealStmt0 = AutoRevealFunctionDependencies.BuildRevealStmt(func, Witness.Tok, EnclosingModuleDefinition);

                    if (revealStmt0 is not null)
                    {
                        var newExpr = new StmtExpr(Witness.Tok, revealStmt0, Witness)
                        {
                            Type = Witness.Type
                        };
                        Witness = newExpr;
                    }
                }

                foreach (var newFunc in Rewriter.GetEnumerator(func, func.EnclosingClass, new List<Expression>(), EnclosingModuleDefinition))
                {
                    var origExpr = Witness;
                    var revealStmt = AutoRevealFunctionDependencies.BuildRevealStmt(newFunc.Function, Witness.Tok, EnclosingModuleDefinition);

                    if (revealStmt is null)
                    {
                        continue;
                    }

                    var newExpr = new StmtExpr(Witness.Tok, revealStmt, origExpr)
                    {
                        Type = origExpr.Type
                    };
                    Witness = newExpr;
                }
            }
        }
    }
}