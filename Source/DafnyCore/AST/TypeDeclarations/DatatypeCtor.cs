using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
namespace MutateCSharp
{
    internal class Schemata189
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT189");
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

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class DatatypeCtor : Declaration, TypeParameter.ParentType, IHasDocstring, ICanVerify
    {
        public readonly bool IsGhost;
        public readonly List<Formal> Formals;
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(cce.NonNullElements(Formals));
            Contract.Invariant(Destructors != null);
            Contract.Invariant(
              Destructors.Count == 0 || // this is until resolution
              Destructors.Count == Formals.Count);  // after resolution
        }

        public override IEnumerable<INode> Children => base.Children.Concat(Formals);

        // TODO: One could imagine having a precondition on datatype constructors
        [FilledInDuringResolution] public DatatypeDecl EnclosingDatatype;
        [FilledInDuringResolution] public SpecialField QueryField;
        [FilledInDuringResolution] public List<DatatypeDestructor> Destructors = new List<DatatypeDestructor>();  // includes both implicit (not mentionable in source) and explicit destructors

        public DatatypeCtor(RangeToken rangeToken, Name name, bool isGhost, [Captured] List<Formal> formals, Attributes attributes)
          : base(rangeToken, name, attributes, MutateCSharp.Schemata189.ReplaceBooleanConstant_0(1L, false))
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(cce.NonNullElements(formals));
            this.Formals = formals;
            this.IsGhost = isGhost;
        }

        public string FullName
        {
            get
            {
                Contract.Ensures(Contract.Result<string>() != null);
                Contract.Assume(EnclosingDatatype != null);

                return MutateCSharp.Schemata189.ReplaceStringConstant_1(2L, "#") + EnclosingDatatype.FullName + MutateCSharp.Schemata189.ReplaceStringConstant_1(3L, ".") + Name;
            }
        }

        public string GetTriviaContainingDocstring()
        {
            if (MutateCSharp.Schemata189.ReplaceBinExprOp_2(4L, EndToken.TrailingTrivia.Trim(), ""))
            {
                return EndToken.TrailingTrivia;
            }

            return GetTriviaContainingDocstringFromStartTokenOrNull();
        }

        public SymbolKind Kind => SymbolKind.EnumMember;
        public string GetDescription(DafnyOptions options)
        {
            var formals = string.Join(MutateCSharp.Schemata189.ReplaceStringConstant_1(5L, ", "), Formals.Select(f => f.AsText()));
            return $"{EnclosingDatatype.Name}.{Name}({formals})";
        }

        public ModuleDefinition ContainingModule => EnclosingDatatype.EnclosingModuleDefinition;
        public bool ShouldVerify => Formals.Any(f => MutateCSharp.Schemata189.ReplaceBinExprOp_3(6L, f.DefaultValue, null));
        public string FullDafnyName => FullName;
    }
}