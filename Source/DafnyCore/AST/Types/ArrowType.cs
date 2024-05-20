using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata205
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT205");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static int ReplaceNumericConstant_0(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static int ReplaceBinExprOp_1(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_12(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 >= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 > argument2; }
            return argument1 >= argument2;
        }

        internal static string ReplaceStringConstant_4(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.UserDefinedType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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
    public class ArrowType : UserDefinedType
    {

        public List<Type> Args
        {
            get { return TypeArgs.GetRange(MutateCSharp.Schemata205.ReplaceNumericConstant_0(1L, 0), Arity); }
        }

        public List<TypeParameter.TPVariance> Variances(bool negate = false)
        {
            if (negate)
            {
                return Enumerable.Range(MutateCSharp.Schemata205.ReplaceNumericConstant_0(5L, 0), MutateCSharp.Schemata205.ReplaceBinExprOp_1(13L, Arity, MutateCSharp.Schemata205.ReplaceNumericConstant_0(9L, 1))).Select(i => MutateCSharp.Schemata205.ReplaceBinExprOp_2(22L, i, Arity) ? TypeParameter.TPVariance.Contra : TypeParameter.TPVariance.Co).ToList();
            }
            else
            {
                return Enumerable.Range(MutateCSharp.Schemata205.ReplaceNumericConstant_0(27L, 0), MutateCSharp.Schemata205.ReplaceBinExprOp_1(35L, Arity, MutateCSharp.Schemata205.ReplaceNumericConstant_0(31L, 1))).Select(i => MutateCSharp.Schemata205.ReplaceBinExprOp_2(44L, i, Arity) ? TypeParameter.TPVariance.Co : TypeParameter.TPVariance.Contra).ToList();
            }

            return default;
        }

        public Type Result
        {
            get { return TypeArgs[Arity]; }
        }

        public int Arity
        {
            get { return MutateCSharp.Schemata205.ReplaceBinExprOp_3(53L, TypeArgs.Count, MutateCSharp.Schemata205.ReplaceNumericConstant_0(49L, 1)); }
        }

        /// <summary>
        /// Constructs a(n unresolved) arrow type.
        /// </summary>
        public ArrowType(IToken tok, List<Type> args, Type result)
          : base(tok, ArrowTypeName(args.Count), Util.Snoc(args, result))
        {
            Contract.Requires(tok != null);
            Contract.Requires(args != null);
            Contract.Requires(result != null);
        }
        /// <summary>
        /// Constructs and returns a resolved arrow type.
        /// </summary>
        public ArrowType(IToken tok, ArrowTypeDecl atd, List<Type> typeArgsAndResult)
          : base(tok, ArrowTypeName(atd.Arity), atd, typeArgsAndResult)
        {
            Contract.Requires(tok != null);
            Contract.Requires(atd != null);
            Contract.Requires(typeArgsAndResult != null);
            Contract.Requires(typeArgsAndResult.Count == atd.Arity + 1);
        }
        /// <summary>
        /// Constructs and returns a resolved arrow type.
        /// </summary>
        public ArrowType(IToken tok, ArrowTypeDecl atd, List<Type> typeArgs, Type result)
          : this(tok, atd, Util.Snoc(typeArgs, result))
        {
            Contract.Requires(tok != null);
            Contract.Requires(atd != null);
            Contract.Requires(typeArgs != null);
            Contract.Requires(typeArgs.Count == atd.Arity);
            Contract.Requires(result != null);
        }

        public const string Arrow_FullCompileName = "Func";  // this is the same for all arities

        public static string ArrowTypeName(int arity)
        {
            return MutateCSharp.Schemata205.ReplaceStringConstant_4(62L, "_#Func") + arity;
        }

        [Pure]
        public static bool IsArrowTypeName(string s)
        {
            return s.StartsWith(MutateCSharp.Schemata205.ReplaceStringConstant_4(63L, "_#Func"));
        }

        public static string PartialArrowTypeName(int arity)
        {
            return MutateCSharp.Schemata205.ReplaceStringConstant_4(64L, "_#PartialFunc") + arity;
        }

        [Pure]
        public static bool IsPartialArrowTypeName(string s)
        {
            return s.StartsWith(MutateCSharp.Schemata205.ReplaceStringConstant_4(65L, "_#PartialFunc"));
        }

        public static string TotalArrowTypeName(int arity)
        {
            return MutateCSharp.Schemata205.ReplaceStringConstant_4(66L, "_#TotalFunc") + arity;
        }

        [Pure]
        public static bool IsTotalArrowTypeName(string s)
        {
            return s.StartsWith(MutateCSharp.Schemata205.ReplaceStringConstant_4(67L, "_#TotalFunc"));
        }

        public const string ANY_ARROW = "~>";
        public const string PARTIAL_ARROW = "-->";
        public const string TOTAL_ARROW = "->";

        public override string TypeName(DafnyOptions options, ModuleDefinition context, bool parseAble)
        {
            return PrettyArrowTypeName(options, ANY_ARROW, Args, Result, context, parseAble);
        }

        /// <summary>
        /// Pretty prints an arrow type.  If "result" is null, then all arguments, including the result type are expected in "typeArgs".
        /// If "result" is non-null, then only the in-arguments are in "typeArgs".
        /// </summary>
        public static string PrettyArrowTypeName(DafnyOptions options, string arrow, List<Type> typeArgs, Type result, ModuleDefinition context, bool parseAble)
        {
            Contract.Requires(arrow != null);
            Contract.Requires(typeArgs != null);
            Contract.Requires(result != null || 1 <= typeArgs.Count);

            int arity = MutateCSharp.Schemata205.ReplaceBinExprOp_5(68L, result, null) ? MutateCSharp.Schemata205.ReplaceBinExprOp_3(73L, typeArgs.Count, MutateCSharp.Schemata205.ReplaceNumericConstant_0(69L, 1)) : typeArgs.Count;
            var domainNeedsParens = MutateCSharp.Schemata205.ReplaceBooleanConstant_6(82L, false);
            if (MutateCSharp.Schemata205.ReplaceBinExprOp_7(87L, arity, MutateCSharp.Schemata205.ReplaceNumericConstant_0(83L, 1)))
            {
                // 0 or 2-or-more arguments:  need parentheses
                domainNeedsParens = MutateCSharp.Schemata205.ReplaceBooleanConstant_6(92L, true);
            }
            else if (typeArgs[MutateCSharp.Schemata205.ReplaceNumericConstant_0(93L, 0)].IsBuiltinArrowType)
            {
                // arrows are right associative, so we need parentheses around the domain type
                domainNeedsParens = MutateCSharp.Schemata205.ReplaceBooleanConstant_6(97L, true);
            }
            else
            {
                // if the domain type consists of a single tuple type, then an extra set of parentheses is needed
                // Note, we do NOT call .AsDatatype or .AsIndDatatype here, because those calls will do a NormalizeExpand().  Instead, we do the check manually.
                var udt = typeArgs[MutateCSharp.Schemata205.ReplaceNumericConstant_0(98L, 0)].Normalize() as UserDefinedType;  // note, we do Normalize(), not NormalizeExpand(), since the TypeName will use any synonym
                if (MutateCSharp.Schemata205.ReplaceBinExprOp_9(115L, () => MutateCSharp.Schemata205.ReplaceBinExprOp_8(102L, udt, null), () => (MutateCSharp.Schemata205.ReplaceBinExprOp_10(109L, () => (MutateCSharp.Schemata205.ReplaceBinExprOp_9(103L, () => udt.FullName != null, () => SystemModuleManager.IsTupleTypeName(udt.FullName))), () => udt.ResolvedClass is TupleTypeDecl))))
                {
                    domainNeedsParens = MutateCSharp.Schemata205.ReplaceBooleanConstant_6(121L, true);
                }
            }
            string s = "";
            if (domainNeedsParens) { s += MutateCSharp.Schemata205.ReplaceStringConstant_4(122L, "("); }
            s += Util.Comma(typeArgs.Take(arity), arg => arg.TypeName(options, context, parseAble));
            if (domainNeedsParens) { s += MutateCSharp.Schemata205.ReplaceStringConstant_4(123L, ")"); }
            s += MutateCSharp.Schemata205.ReplaceStringConstant_4(124L, " ") + arrow + MutateCSharp.Schemata205.ReplaceStringConstant_4(125L, " ");
            if (MutateCSharp.Schemata205.ReplaceBinExprOp_10(136L, () => MutateCSharp.Schemata205.ReplaceBinExprOp_11(126L, result, null), () => MutateCSharp.Schemata205.ReplaceBinExprOp_12(131L, typeArgs.Count, MutateCSharp.Schemata205.ReplaceNumericConstant_0(127L, 1))))
            {
                s += (result ?? typeArgs.Last()).TypeName(options, context, parseAble);
            }
            else
            {
                s += MutateCSharp.Schemata205.ReplaceStringConstant_4(142L, "<unable to infer result type>");
            }
            return s;
        }

        public override Type Subst(IDictionary<TypeParameter, Type> subst)
        {
            return new ArrowType(tok, (ArrowTypeDecl)ResolvedClass, Args.ConvertAll(u => u.Subst(subst)), Result.Subst(subst));
        }

        public override Type ReplaceTypeArguments(List<Type> arguments)
        {
            return new ArrowType(tok, (ArrowTypeDecl)ResolvedClass, arguments);
        }

        public override bool SupportsEquality
        {
            get
            {
                return MutateCSharp.Schemata205.ReplaceBooleanConstant_6(143L, false);
            }
        }

        public override IEnumerable<INode> Children => Args.Concat(new List<Node>() { Result });
        public override IEnumerable<INode> PreResolveChildren => Args.Concat(new List<Node>() { Result });
    }
}