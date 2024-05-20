using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Numerics;
namespace MutateCSharp
{
    internal class Schemata3
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT3");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.LiteralExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBooleanConstant_6(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static int ReplaceNumericConstant_7(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.StringLiteralExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBinExprOp_8(long mutantId, int argument1, int argument2)
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
static class AttributeBearingDeclaration
    {

        public static bool IsExtern(this IAttributeBearingDeclaration me, DafnyOptions options) => MutateCSharp.Schemata3.ReplaceBinExprOp_1(2L, () => options.AllowExterns, () => Attributes.Contains(me.Attributes, MutateCSharp.Schemata3.ReplaceStringConstant_0(1L, "extern")));

        public static bool IsExplicitAxiom(this IAttributeBearingDeclaration me) =>
          Attributes.Contains(me.Attributes, MutateCSharp.Schemata3.ReplaceStringConstant_0(8L, "axiom"));
    }

    public class Attributes : TokenNode
    {
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(Name != null);
            Contract.Invariant(cce.NonNullElements(Args));
        }

        public static string AxiomAttributeName = MutateCSharp.Schemata3.ReplaceStringConstant_0(9L, "axiom");
        public static string ConcurrentAttributeName = MutateCSharp.Schemata3.ReplaceStringConstant_0(10L, "concurrent");
        public static string AssumeConcurrentAttributeName = MutateCSharp.Schemata3.ReplaceStringConstant_0(11L, "assume_concurrent");
        public static string ExternAttributeName = MutateCSharp.Schemata3.ReplaceStringConstant_0(12L, "extern");
        public static string VerifyAttributeName = MutateCSharp.Schemata3.ReplaceStringConstant_0(13L, "verify");
        public static string AutoGeneratedAttributeName = MutateCSharp.Schemata3.ReplaceStringConstant_0(14L, "auto_generated");

        public string Name;
        /*Frozen*/
        public readonly List<Expression> Args;

        public readonly Attributes Prev;
        public Attributes(string name, [Captured] List<Expression> args, Attributes prev)
        {
            Contract.Requires(name != null);
            Contract.Requires(cce.NonNullElements(args));
            Name = name;
            Args = args;
            Prev = prev;
        }

        public override string ToString()
        {
            string result = Prev?.ToString() + MutateCSharp.Schemata3.ReplaceStringConstant_0(15L, "{:") + Name;
            if (MutateCSharp.Schemata3.ReplaceBinExprOp_3(17L, () => MutateCSharp.Schemata3.ReplaceBinExprOp_2(16L, Args, null), () => !Args.Any()))
            {
                return result + MutateCSharp.Schemata3.ReplaceStringConstant_0(23L, "}");
            }
            else
            {
                var exprs = String.Join(MutateCSharp.Schemata3.ReplaceStringConstant_0(24L, ", "), Args.Select(e => e.ToString()));
                return result + MutateCSharp.Schemata3.ReplaceStringConstant_0(25L, " ") + exprs + MutateCSharp.Schemata3.ReplaceStringConstant_0(26L, "}");
            }

            return default;
        }

        public static IEnumerable<Expression> SubExpressions(Attributes attrs)
        {
            return attrs.AsEnumerable().SelectMany(aa => aa.Args);
        }

        public static bool Contains(Attributes attrs, string nm)
        {
            Contract.Requires(nm != null);
            return attrs.AsEnumerable().Any(aa => MutateCSharp.Schemata3.ReplaceBinExprOp_4(27L, aa.Name, nm));
        }

        /// <summary>
        /// Returns first occurrence of an attribute named <c>nm</c>, or <c>null</c> if there is no such
        /// attribute.
        /// </summary>
        [Pure]
        public static Attributes/*?*/ Find(Attributes attrs, string nm)
        {
            Contract.Requires(nm != null);
            return attrs.AsEnumerable().FirstOrDefault(attr => MutateCSharp.Schemata3.ReplaceBinExprOp_4(28L, attr.Name, nm));
        }

        /// <summary>
        /// Returns true if "nm" is a specified attribute.  If it is, then:
        /// - if the attribute is {:nm true}, then value==true
        /// - if the attribute is {:nm false}, then value==false
        /// - if the attribute is anything else, then value returns as whatever it was passed in as.
        /// This method does NOT use type information of the attribute arguments, so it can safely
        /// be called very early during resolution before types are available and names have been resolved.
        /// </summary>
        [Pure]
        public static bool ContainsBool(Attributes attrs, string nm, ref bool value)
        {
            Contract.Requires(nm != null);
            var attr = attrs.AsEnumerable().FirstOrDefault(attr => MutateCSharp.Schemata3.ReplaceBinExprOp_4(29L, attr.Name, nm));
            if (MutateCSharp.Schemata3.ReplaceBinExprOp_5(30L, attr, null))
            {
                return MutateCSharp.Schemata3.ReplaceBooleanConstant_6(31L, false);
            }

            if (MutateCSharp.Schemata3.ReplaceBinExprOp_8(36L, attr.Args.Count, MutateCSharp.Schemata3.ReplaceNumericConstant_7(32L, 1)) && attr.Args[0] is LiteralExpr { Value: bool v })
            {
                value = v;
            }
            return MutateCSharp.Schemata3.ReplaceBooleanConstant_6(41L, true);
        }

        /// <summary>
        /// Checks whether a Boolean attribute has been set on the declaration itself,
        /// the enclosing class, or any enclosing module.  Settings closer to the declaration
        /// override those further away.
        /// </summary>
        public static bool ContainsBoolAtAnyLevel(MemberDecl decl, string attribName, bool defaultVal = false)
        {
            bool setting = MutateCSharp.Schemata3.ReplaceBooleanConstant_6(42L, true);
            if (Attributes.ContainsBool(decl.Attributes, attribName, ref setting))
            {
                return setting;
            }

            if (Attributes.ContainsBool(decl.EnclosingClass.Attributes, attribName, ref setting))
            {
                return setting;
            }

            // Check the entire stack of modules
            var mod = decl.EnclosingClass.EnclosingModuleDefinition;
            while (MutateCSharp.Schemata3.ReplaceBinExprOp_9(43L, mod, null))
            {
                if (Attributes.ContainsBool(mod.Attributes, attribName, ref setting))
                {
                    return setting;
                }
                mod = mod.EnclosingModule;
            }

            return defaultVal;
        }

        /// <summary>
        /// Returns list of expressions if "nm" is a specified attribute:
        /// - if the attribute is {:nm e1,...,en}, then returns (e1,...,en)
        /// Otherwise, returns null.
        /// </summary>
        public static List<Expression> FindExpressions(Attributes attrs, string nm)
        {
            Contract.Requires(nm != null);
            foreach (var attr in attrs.AsEnumerable())
            {
                if (MutateCSharp.Schemata3.ReplaceBinExprOp_4(44L, attr.Name, nm))
                {
                    return attr.Args;
                }
            }
            return null;
        }

        /// <summary>
        /// Same as FindExpressions, but returns all matches
        /// </summary>
        public static List<List<Expression>> FindAllExpressions(Attributes attrs, string nm)
        {
            Contract.Requires(nm != null);
            List<List<Expression>> ret = null;
            for (; MutateCSharp.Schemata3.ReplaceBinExprOp_10(45L, attrs, null); attrs = attrs.Prev)
            {
                if (MutateCSharp.Schemata3.ReplaceBinExprOp_4(46L, attrs.Name, nm))
                {
                    ret = ret ?? new List<List<Expression>>();   // Avoid allocating the list in the common case where we don't find nm
                    ret.Add(attrs.Args);
                }
            }
            return ret;
        }

        /// <summary>
        /// Returns true if "nm" is a specified attribute whose arguments match the "allowed" parameter.
        /// - if "nm" is not found in attrs, return false and leave value unmodified.  Otherwise,
        /// - if "allowed" contains Empty and the Args contains zero elements, return true and leave value unmodified.  Otherwise,
        /// - if "allowed" contains Bool and Args contains one bool literal, return true and set value to the bool literal.  Otherwise,
        /// - if "allowed" contains Int and Args contains one BigInteger literal, return true and set value to the BigInteger literal.  Otherwise,
        /// - if "allowed" contains String and Args contains one string literal, return true and set value to the string literal.  Otherwise,
        /// - if "allowed" contains Expression and Args contains one element, return true and set value to the one element (of type Expression).  Otherwise,
        /// - return false, leave value unmodified, and call reporter with an error string.
        /// </summary>
        public enum MatchingValueOption { Empty, Bool, Int, String, Expression }
        public static bool ContainsMatchingValue(Attributes attrs, string nm, ref object value, IEnumerable<MatchingValueOption> allowed, Action<string> reporter)
        {
            Contract.Requires(nm != null);
            Contract.Requires(allowed != null);
            Contract.Requires(reporter != null);
            List<Expression> args = FindExpressions(attrs, nm);
            if (MutateCSharp.Schemata3.ReplaceBinExprOp_2(47L, args, null))
            {
                return MutateCSharp.Schemata3.ReplaceBooleanConstant_6(48L, false);
            }
            else if (MutateCSharp.Schemata3.ReplaceBinExprOp_8(53L, args.Count, MutateCSharp.Schemata3.ReplaceNumericConstant_7(49L, 0)))
            {
                if (allowed.Contains(MatchingValueOption.Empty))
                {
                    return MutateCSharp.Schemata3.ReplaceBooleanConstant_6(58L, true);
                }
                else
                {
                    reporter(MutateCSharp.Schemata3.ReplaceStringConstant_0(59L, "Attribute ") + nm + MutateCSharp.Schemata3.ReplaceStringConstant_0(60L, " requires one argument"));
                    return MutateCSharp.Schemata3.ReplaceBooleanConstant_6(61L, false);
                }
            }
            else if (MutateCSharp.Schemata3.ReplaceBinExprOp_8(66L, args.Count, MutateCSharp.Schemata3.ReplaceNumericConstant_7(62L, 1)))
            {
                Expression arg = args[MutateCSharp.Schemata3.ReplaceNumericConstant_7(71L, 0)];
                StringLiteralExpr stringLiteral = arg as StringLiteralExpr;
                LiteralExpr literal = arg as LiteralExpr;
                if (MutateCSharp.Schemata3.ReplaceBinExprOp_1(82L, () => MutateCSharp.Schemata3.ReplaceBinExprOp_1(76L, () => MutateCSharp.Schemata3.ReplaceBinExprOp_11(75L, literal, null), () => literal.Value is bool), () => allowed.Contains(MatchingValueOption.Bool)))
                {
                    value = literal.Value;
                    return MutateCSharp.Schemata3.ReplaceBooleanConstant_6(88L, true);
                }
                else if (MutateCSharp.Schemata3.ReplaceBinExprOp_1(96L, () => MutateCSharp.Schemata3.ReplaceBinExprOp_1(90L, () => MutateCSharp.Schemata3.ReplaceBinExprOp_11(89L, literal, null), () => literal.Value is BigInteger), () => allowed.Contains(MatchingValueOption.Int)))
                {
                    value = literal.Value;
                    return MutateCSharp.Schemata3.ReplaceBooleanConstant_6(102L, true);
                }
                else if (MutateCSharp.Schemata3.ReplaceBinExprOp_1(110L, () => MutateCSharp.Schemata3.ReplaceBinExprOp_1(104L, () => MutateCSharp.Schemata3.ReplaceBinExprOp_12(103L, stringLiteral, null), () => stringLiteral.Value is string), () => allowed.Contains(MatchingValueOption.String)))
                {
                    value = stringLiteral.Value;
                    return MutateCSharp.Schemata3.ReplaceBooleanConstant_6(116L, true);
                }
                else if (allowed.Contains(MatchingValueOption.Expression))
                {
                    value = arg;
                    return MutateCSharp.Schemata3.ReplaceBooleanConstant_6(117L, true);
                }
                else
                {
                    reporter(MutateCSharp.Schemata3.ReplaceStringConstant_0(118L, "Attribute ") + nm + MutateCSharp.Schemata3.ReplaceStringConstant_0(119L, " expects an argument in one of the following categories: ") + String.Join(MutateCSharp.Schemata3.ReplaceStringConstant_0(120L, ", "), allowed));
                    return MutateCSharp.Schemata3.ReplaceBooleanConstant_6(121L, false);
                }
            }
            else
            {
                reporter(MutateCSharp.Schemata3.ReplaceStringConstant_0(122L, "Attribute ") + nm + MutateCSharp.Schemata3.ReplaceStringConstant_0(123L, " cannot have more than one argument"));
                return MutateCSharp.Schemata3.ReplaceBooleanConstant_6(124L, false);
            }

            return default;
        }

        public override IEnumerable<INode> Children => Args.Concat<Node>(
      MutateCSharp.Schemata3.ReplaceBinExprOp_5(125L, Prev, null
      ) ? Enumerable.Empty<Node>()
            : new List<Node> { Prev });

        public override IEnumerable<INode> PreResolveChildren => Children;
    }

    public static class AttributesExtensions
    {
        /// <summary>
        /// By making this an extension method, it can also be invoked for a null receiver.
        /// </summary>
        public static IEnumerable<Attributes> AsEnumerable(this Attributes attr)
        {
            while (MutateCSharp.Schemata3.ReplaceBinExprOp_10(126L, attr, null))
            {
                yield return attr;
                attr = attr.Prev;
            }

            yield break;
        }
    }

    public class UserSuppliedAttributes : Attributes
    {
        public readonly IToken OpenBrace;
        public readonly IToken CloseBrace;
        public bool Recognized;  // set to true to indicate an attribute that is processed by some part of Dafny; this allows it to be colored in the IDE
        public UserSuppliedAttributes(IToken tok, IToken openBrace, IToken closeBrace, List<Expression> args, Attributes prev)
          : base(tok.val, args, prev)
        {
            Contract.Requires(tok != null);
            Contract.Requires(openBrace != null);
            Contract.Requires(closeBrace != null);
            Contract.Requires(args != null);
            this.tok = tok;
            OpenBrace = openBrace;
            CloseBrace = closeBrace;
        }
    }

    /// <summary>
    /// A class implementing this interface is one that can carry attributes.
    /// </summary>
    public interface IAttributeBearingDeclaration
    {
        Attributes Attributes { get; }
    }

    public static class AttributeBearingDeclarationExtensions
    {
        public static bool HasUserAttribute(this IAttributeBearingDeclaration decl, string name, out Attributes attribute)
        {
            if (Attributes.Find(decl.Attributes, name) is UserSuppliedAttributes attr)
            {
                attribute = attr;
                return MutateCSharp.Schemata3.ReplaceBooleanConstant_6(127L, true);
            }

            attribute = null;
            return MutateCSharp.Schemata3.ReplaceBooleanConstant_6(128L, false);
        }
    }
}