using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
namespace MutateCSharp
{
    internal class Schemata98
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT98");
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

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class ConstantField : SpecialField, ICallable, ICanAutoRevealDependencies, ICanVerify
    {
        public override string WhatKind => MutateCSharp.Schemata98.ReplaceStringConstant_0(1L, "const field");
        public Expression Rhs;

        public override bool IsOpaque { get; }

        public ConstantField(RangeToken rangeToken, Name name, Expression/*?*/ rhs, bool hasStaticKeyword, bool isGhost, bool isOpaque, Type type, Attributes attributes)
          : base(rangeToken, name, ID.UseIdParam, NonglobalVariable.SanitizeName(name.Value), hasStaticKeyword, isGhost, MutateCSharp.Schemata98.ReplaceBooleanConstant_1(2L, false), MutateCSharp.Schemata98.ReplaceBooleanConstant_1(3L, false), type, attributes)
        {
            Contract.Requires(tok != null);
            Contract.Requires(name != null);
            Contract.Requires(type != null);
            this.Rhs = rhs;
            this.IsOpaque = isOpaque;
        }

        public override bool CanBeRevealed()
        {
            return MutateCSharp.Schemata98.ReplaceBooleanConstant_1(4L, true);
        }

        public new bool IsGhost
        {
            get { return this.isGhost; }
        }

        public List<TypeParameter> TypeArgs
        {
            get { return new List<TypeParameter>(); }
        }

        public List<Formal> Ins
        {
            get { return new List<Formal>(); }
        }

        public ModuleDefinition EnclosingModule
        {
            get { return this.EnclosingClass.EnclosingModuleDefinition; }
        }

        public bool MustReverify
        {
            get { return MutateCSharp.Schemata98.ReplaceBooleanConstant_1(5L, false); }
        }

        public bool AllowsNontermination
        {
            get
            {
                throw new cce.UnreachableException();
                return default;
            }
        }

        public string NameRelativeToModule
        {
            get
            {
                if (EnclosingClass is DefaultClassDecl)
                {
                    return Name;
                }
                else
                {
                    return EnclosingClass.Name + MutateCSharp.Schemata98.ReplaceStringConstant_0(6L, ".") + Name;
                }

                return default;
            }
        }

        public Specification<Expression> Decreases
        {
            get
            {
                throw new cce.UnreachableException();
                return default;
            }
        }

        public bool InferredDecreases
        {
            get
            {
                throw new cce.UnreachableException();
                return default;
            }
            set { throw new cce.UnreachableException(); }
        }

        public bool AllowsAllocation => MutateCSharp.Schemata98.ReplaceBooleanConstant_1(7L, true);

        public override IEnumerable<INode> Children => base.Children.Concat(new[] { Rhs }.Where(x => MutateCSharp.Schemata98.ReplaceBinExprOp_2(8L, x, null)));
        public override SymbolKind Kind => SymbolKind.Constant;

        public override IEnumerable<INode> PreResolveChildren => Children;
        public ModuleDefinition ContainingModule => EnclosingModule;
        public bool ShouldVerify => MutateCSharp.Schemata98.ReplaceBinExprOp_2(9L, Rhs, null); // This could be made more accurate by checking whether the Rhs needs to be verified.
        public void AutoRevealDependencies(AutoRevealFunctionDependencies Rewriter, DafnyOptions Options, ErrorReporter Reporter)
        {
            if (Rhs is null)
            {
                return;
            }

            var addedReveals = Rewriter.ExprToFunctionalDependencies(Rhs, EnclosingModule);
            Rhs = Rewriter.AddRevealStmtsToExpression(Rhs, addedReveals);

            if (addedReveals.Any())
            {
                Reporter.Message(MessageSource.Rewriter, ErrorLevel.Info, null, tok,
                  AutoRevealFunctionDependencies.GenerateMessage(addedReveals.ToList()));
            }
        }
        public string Designator => WhatKind;
    }
}