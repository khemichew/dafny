using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata73
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT73");
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
    public class Formal : NonglobalVariable
    {
        public Attributes Attributes { get; set; }

        public readonly bool InParam;  // true to in-parameter, false for out-parameter
        public override bool IsMutable => !InParam;
        public readonly bool IsOld;
        public Expression DefaultValue;
        public readonly bool IsNameOnly;
        public readonly bool IsOlder;
        public readonly string NameForCompilation;

        public Formal(IToken tok, string name, Type type, bool inParam, bool isGhost, Expression defaultValue,
          Attributes attributes = null,
          bool isOld = false, bool isNameOnly = false, bool isOlder = false, string nameForCompilation = null)
          : base(tok, name, type, isGhost)
        {
            Contract.Requires(tok != null);
            Contract.Requires(name != null);
            Contract.Requires(type != null);
            Contract.Requires(inParam || defaultValue == null);
            Contract.Requires(!isNameOnly || (inParam && !name.StartsWith("#")));
            InParam = inParam;
            IsOld = isOld;
            DefaultValue = defaultValue;
            Attributes = attributes;
            IsNameOnly = isNameOnly;
            IsOlder = isOlder;
            NameForCompilation = nameForCompilation ?? name;
        }

        public bool HasName => !Name.StartsWith(MutateCSharp.Schemata73.ReplaceStringConstant_0(1L, "#"));

        private string sanitizedName;
        public override string SanitizedName =>
          sanitizedName ??= SanitizeName(Name); // No unique-ification
        public override string CompileName =>
          compileName ??= SanitizeName(NameForCompilation);

        public override IEnumerable<INode> Children =>
          (MutateCSharp.Schemata73.ReplaceBinExprOp_1(2L, DefaultValue, null) ? new List<Node> { DefaultValue } : Enumerable.Empty<Node>()).Concat(base.Children);

        public override IEnumerable<INode> PreResolveChildren => Children;
    }

    /// <summary>
    /// An ImplicitFormal is a parameter that is declared implicitly, in particular the "_k" depth parameter
    /// of each extreme lemma (for use in the extreme-method body only, not the specification).
    /// </summary>
    public class ImplicitFormal : Formal
    {
        public ImplicitFormal(IToken tok, string name, Type type, bool inParam, bool isGhost)
          : base(tok, name, type, inParam, isGhost, null, null)
        {
            Contract.Requires(tok != null);
            Contract.Requires(name != null);
            Contract.Requires(type != null);
        }
    }

    /// <summary>
    /// ThisSurrogate represents the implicit parameter "this". It is used to allow more uniform handling of
    /// parameters. A pointer value of a ThisSurrogate object is not important, only the fact that it is
    /// a ThisSurrogate is. ThisSurrogate objects are only used in specially marked places in the Dafny
    /// implementation.
    /// </summary>
    public class ThisSurrogate : ImplicitFormal
    {
        public ThisSurrogate(IToken tok, Type type)
          : base(tok, MutateCSharp.Schemata73.ReplaceStringConstant_0(3L, "this"), type, MutateCSharp.Schemata73.ReplaceBooleanConstant_2(4L, true), MutateCSharp.Schemata73.ReplaceBooleanConstant_2(5L, false))
        {
            Contract.Requires(tok != null);
            Contract.Requires(type != null);
        }
    }
}