using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
namespace MutateCSharp
{
    internal class Schemata79
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT79");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.RangeToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
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

        internal static bool ReplaceBooleanConstant_7(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_4(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
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

        internal static int ReplaceNumericConstant_1(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static int ReplaceBinExprOp_9(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
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
    public abstract class NonglobalVariable : TokenNode, IVariable
    {
        readonly string name;

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(name != null);
            Contract.Invariant(type != null);
        }

        public string Name
        {
            get
            {
                Contract.Ensures(Contract.Result<string>() != null);
                return name;
            }
        }

        public string DafnyName => MutateCSharp.Schemata79.ReplaceBinExprOp_3(11L, () => MutateCSharp.Schemata79.ReplaceBinExprOp_0(1L, RangeToken, null), () => MutateCSharp.Schemata79.ReplaceBinExprOp_2(6L, tok.line, MutateCSharp.Schemata79.ReplaceNumericConstant_1(2L, 0))) ? Name : RangeToken.PrintOriginal();
        public string DisplayName =>
          LocalVariable.DisplayNameHelper(this);

        private string uniqueName;
        public string UniqueName => uniqueName;
        public bool HasBeenAssignedUniqueName => uniqueName != null;
        public string AssignUniqueName(FreshIdGenerator generator)
        {
            return uniqueName ??= generator.FreshId(Name + MutateCSharp.Schemata79.ReplaceStringConstant_4(17L, "#"));
        }

        static char[] specialChars = { '\'', '_', '?', '\\', '#' };
        /// <summary>
        /// Mangle name <c>nm</c> by replacing and escaping characters most likely to cause issues when compiling and
        /// when translating to Boogie.  This transformation is injective.
        /// </summary>
        /// <returns>A string uniquely determined from <c>nm</c>, containing none of the characters in
        /// <c>specialChars</c>.</returns>
        public static string SanitizeName(string nm)
        {
            if (MutateCSharp.Schemata79.ReplaceBinExprOp_6(36L, () => MutateCSharp.Schemata79.ReplaceBinExprOp_5(22L, '0', nm[MutateCSharp.Schemata79.ReplaceNumericConstant_1(18L, 0)]), () => MutateCSharp.Schemata79.ReplaceBinExprOp_5(31L, nm[MutateCSharp.Schemata79.ReplaceNumericConstant_1(27L, 0)], '9')))
            {
                // the identifier is one that consists of just digits
                return MutateCSharp.Schemata79.ReplaceStringConstant_4(42L, "_") + nm;
            }
            string name = null;
            int i = MutateCSharp.Schemata79.ReplaceNumericConstant_1(43L, 0);
            while (MutateCSharp.Schemata79.ReplaceBooleanConstant_7(47L, true))
            {
                int j = nm.IndexOfAny(specialChars, i);
                if (MutateCSharp.Schemata79.ReplaceBinExprOp_2(52L, j, MutateCSharp.Schemata79.ReplaceNumericConstant_1(48L, -1)))
                {
                    if (MutateCSharp.Schemata79.ReplaceBinExprOp_2(61L, i, MutateCSharp.Schemata79.ReplaceNumericConstant_1(57L, 0)))
                    {
                        return nm;  // this is the common case
                    }
                    else
                    {
                        return name + nm.Substring(i);
                    }
                }
                else
                {
                    string nxt = nm.Substring(i, MutateCSharp.Schemata79.ReplaceBinExprOp_8(66L, j, i));
                    name = name == null ? nxt : name + nxt;
                    switch (nm[j])
                    {
                        case '\'':
                            name += "_k"; break;
                            break;
                        case '_':
                            name += "__"; break;
                            break;
                        case '?':
                            name += "_q"; break;
                            break;
                        case '\\':
                            name += "_b"; break;
                            break;
                        case '#':
                            name += "_h"; break;
                            break;
                        default:
                            Contract.Assume(false);  // unexpected character
                            break;
                            break;
                    }
                    i = MutateCSharp.Schemata79.ReplaceBinExprOp_9(79L, j, MutateCSharp.Schemata79.ReplaceNumericConstant_1(75L, 1));
                    if (MutateCSharp.Schemata79.ReplaceBinExprOp_2(88L, i, nm.Length))
                    {
                        return name;
                    }
                }
            }

            return default;
        }

        private string sanitizedNameShadowable;

        public virtual string SanitizedNameShadowable =>
          sanitizedNameShadowable ??= SanitizeName(Name);

        private string sanitizedName;
        public virtual string SanitizedName =>
          sanitizedName ??= $"_{IVariable.CompileNameIdGenerator.FreshNumericId()}_{SanitizedNameShadowable}";

        protected string compileName;
        public virtual string CompileName =>
          compileName ??= SanitizedName;

        Type type;
        public bool IsTypeExplicit = MutateCSharp.Schemata79.ReplaceBooleanConstant_7(93L, false);
        public Type SyntacticType
        {
            get { return type; }
        }

        public PreType PreType { get; set; }

        public Type Type
        {
            get
            {
                Contract.Ensures(Contract.Result<Type>() != null);
                return type.Normalize();
            }
        }

        /// <summary>
        /// For a description of the difference between .Type and .UnnormalizedType, see Expression.UnnormalizedType.
        /// </summary>
        public Type UnnormalizedType
        {
            get
            {
                Contract.Ensures(Contract.Result<Type>() != null);
                return type;
            }
        }

        Type IVariable.OptionalType
        {
            get { return Type; }  // same as Type for NonglobalVariable
        }

        public abstract bool IsMutable { get; }

        bool isGhost;  // readonly after resolution
        public bool IsGhost
        {
            get
            {
                return isGhost;
            }
            set
            {
                isGhost = value;
            }
        }

        public void MakeGhost()
        {
            IsGhost = MutateCSharp.Schemata79.ReplaceBooleanConstant_7(94L, true);
        }

        public NonglobalVariable(IToken tok, string name, Type type, bool isGhost)
        {
            Contract.Requires(tok != null);
            Contract.Requires(name != null);
            Contract.Requires(type != null);
            this.tok = tok;
            this.name = name;
            this.type = type;
            this.isGhost = isGhost;
        }

        public IToken NameToken => tok;
        public override IEnumerable<INode> Children => IsTypeExplicit ? new List<Node> { Type } : Enumerable.Empty<Node>();
        public override IEnumerable<INode> PreResolveChildren => IsTypeExplicit ? new List<Node>() { Type } : Enumerable.Empty<Node>();
        public SymbolKind Kind => SymbolKind.Variable;
        public string GetDescription(DafnyOptions options)
        {
            return this.AsText();
        }
    }
}