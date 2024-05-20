using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
namespace MutateCSharp
{
    internal class Schemata180
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT180");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplacePostfixUnaryExprOp_4(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.SeqType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBooleanConstant_5(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_2(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static int ReplaceBinExprOp_13(long mutantId, int argument1, int argument2)
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

        internal static int ReplaceNumericConstant_0(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_12(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.ValuetypeVariety argument1, Microsoft.Dafny.ValuetypeVariety argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.MultiSetType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class SystemModuleManager
    {
        public DafnyOptions Options { get; }

        public readonly ModuleDefinition SystemModule;
        internal readonly Dictionary<int, ClassDecl> arrayTypeDecls = new();
        public readonly Dictionary<int, ArrowTypeDecl> ArrowTypeDecls = new();
        public readonly Dictionary<int, SubsetTypeDecl> PartialArrowTypeDecls = new();  // same keys as arrowTypeDecl
        public readonly Dictionary<int, SubsetTypeDecl> TotalArrowTypeDecls = new();  // same keys as arrowTypeDecl
        readonly Dictionary<List<bool>, TupleTypeDecl> tupleTypeDecls = new(new Dafny.IEnumerableComparer<bool>());

        internal readonly ValuetypeDecl[] valuetypeDecls;

        /// <summary>
        /// PreTypeBuiltins is stored here once for the entire program, so that its ToplevelDecl's are unique across the program.
        /// It is used by the pre-type resolver, and its entries are filled in lazily by the pre-type resolver. There may be overlap
        /// between the values of PreTypeBuiltins and the values in the dictionaries above.
        /// </summary>
        public readonly Dictionary<string, TopLevelDecl> PreTypeBuiltins = new();

        public ModuleSignature systemNameInfo;

        public int MaxNonGhostTupleSizeUsed { get; private set; }
        public IToken MaxNonGhostTupleSizeToken { get; private set; }

        private byte[] hash;

        public byte[] MyHash
        {
            get
            {
                if (hash == null)
                {

                    // A tuple type is defined by a list of booleans, where the size of the list determines how many elements the tuple has,
                    // and the value of each boolean determines whether that value is ghost or not.
                    // Here we represent the tuple type as an integer by translating each boolean to a bit and packing the bits in an int.
                    var tupleInts = tupleTypeDecls.Keys.Select(tuple =>
                    {
                        var vector32 = new BitVector32();
                        if (MutateCSharp.Schemata180.ReplaceBinExprOp_1(5L, tuple.Count, MutateCSharp.Schemata180.ReplaceNumericConstant_0(1L, 32)))
                        {
                            throw new Exception(MutateCSharp.Schemata180.ReplaceStringConstant_2(10L, "Tuples of size larger than 32 are not supported"));
                        }
                        for (var index = MutateCSharp.Schemata180.ReplaceNumericConstant_0(11L, 0); MutateCSharp.Schemata180.ReplaceBinExprOp_3(15L, index, tuple.Count); MutateCSharp.Schemata180.ReplacePostfixUnaryExprOp_4(20L, ref index))
                        {
                            vector32[index] = tuple[index];
                        }
                        return vector32.Data;
                    });
                    var ints =
                      new[] {
            arrayTypeDecls.Count, ArrowTypeDecls.Count, PartialArrowTypeDecls.Count, TotalArrowTypeDecls.Count,
            tupleTypeDecls.Count
                      }.
                        Concat(arrayTypeDecls.Keys.OrderBy(x => x)).
                        Concat(ArrowTypeDecls.Keys.OrderBy(x => x)).
                        Concat(PartialArrowTypeDecls.Keys.OrderBy(x => x)).
                        Concat(TotalArrowTypeDecls.Keys.OrderBy(x => x)).
                        Concat(tupleInts.OrderBy(x => x));
                    var bytes = ints.SelectMany(BitConverter.GetBytes).ToArray();
                    hash = HashAlgorithm.Create(MutateCSharp.Schemata180.ReplaceStringConstant_2(21L, "SHA256"))!.ComputeHash(bytes);
                }

                return hash;
            }
        }

        public readonly ISet<int> Bitwidths = new HashSet<int>();
        [FilledInDuringResolution] public SpecialField ORDINAL_Offset;  // used by the translator

        public readonly SubsetTypeDecl NatDecl;
        public UserDefinedType Nat() { return new UserDefinedType(Token.NoToken, MutateCSharp.Schemata180.ReplaceStringConstant_2(22L, "nat"), NatDecl, new List<Type>()); }
        public readonly TraitDecl ObjectDecl;
        public UserDefinedType ObjectQ()
        {
            Contract.Assume(ObjectDecl != null);
            return new UserDefinedType(Token.NoToken, MutateCSharp.Schemata180.ReplaceStringConstant_2(23L, "object?"), null) { ResolvedClass = ObjectDecl };
        }
        /// <summary>
        /// Return a resolved type for "set<object?>".
        /// </summary>
        public Type ObjectSetType()
        {
            return new SetType(MutateCSharp.Schemata180.ReplaceBooleanConstant_5(24L, true), ObjectQ());
        }

        public SystemModuleManager(DafnyOptions options)
        {
            SystemModule = new(RangeToken.NoToken, new Name(MutateCSharp.Schemata180.ReplaceStringConstant_2(25L, "_System")), new List<IToken>(),
              ModuleKindEnum.Concrete, MutateCSharp.Schemata180.ReplaceBooleanConstant_5(26L, false), null, null, null);
            this.Options = options;
            SystemModule.Height = MutateCSharp.Schemata180.ReplaceNumericConstant_0(27L, -1);  // the system module doesn't get a height assigned later, so we set it here to something below everything else
                                                                                               // create type synonym 'string'
            var str = new TypeSynonymDecl(RangeToken.NoToken, new Name(MutateCSharp.Schemata180.ReplaceStringConstant_2(31L, "string")),
              new TypeParameter.TypeParameterCharacteristics(TypeParameter.EqualitySupportValue.InferredRequired, Type.AutoInitInfo.CompilableValue, MutateCSharp.Schemata180.ReplaceBooleanConstant_5(32L, false)),
              new List<TypeParameter>(), SystemModule, new SeqType(new CharType()), null);
            SystemModule.SourceDecls.Add(str);
            // create subset type 'nat'
            var bvNat = new BoundVar(Token.NoToken, MutateCSharp.Schemata180.ReplaceStringConstant_2(33L, "x"), Type.Int);
            var natConstraint = Expression.CreateAtMost(Expression.CreateIntLiteral(Token.NoToken, MutateCSharp.Schemata180.ReplaceNumericConstant_0(34L, 0)), Expression.CreateIdentExpr(bvNat));
            var ax = AxiomAttribute();
            NatDecl = new SubsetTypeDecl(RangeToken.NoToken, new Name(MutateCSharp.Schemata180.ReplaceStringConstant_2(38L, "nat")),
              new TypeParameter.TypeParameterCharacteristics(TypeParameter.EqualitySupportValue.InferredRequired, Type.AutoInitInfo.CompilableValue, MutateCSharp.Schemata180.ReplaceBooleanConstant_5(39L, false)),
              new List<TypeParameter>(), SystemModule, bvNat, natConstraint, SubsetTypeDecl.WKind.CompiledZero, null, ax);
            ((RedirectingTypeDecl)NatDecl).ConstraintIsCompilable = MutateCSharp.Schemata180.ReplaceBooleanConstant_5(40L, true);
            SystemModule.SourceDecls.Add(NatDecl);
            // create trait 'object'
            ObjectDecl = new TraitDecl(RangeToken.NoToken, new Name(MutateCSharp.Schemata180.ReplaceStringConstant_2(41L, "object")), SystemModule, new List<TypeParameter>(), new List<MemberDecl>(), DontCompile(), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(42L, false), null);
            SystemModule.SourceDecls.Add(ObjectDecl);
            // add one-dimensional arrays, since they may arise during type checking
            // Arrays of other dimensions may be added during parsing as the parser detects the need for these
            UserDefinedType tmp = ArrayType(MutateCSharp.Schemata180.ReplaceNumericConstant_0(43L, 1), Type.Int, MutateCSharp.Schemata180.ReplaceBooleanConstant_5(47L, true));
            // Arrow types of other dimensions may be added during parsing as the parser detects the need for these.  For the 0-arity
            // arrow type, the resolver adds a Valid() predicate for iterators, whose corresponding arrow type is conveniently created here.
            CreateArrowTypeDecl(MutateCSharp.Schemata180.ReplaceNumericConstant_0(48L, 0));


            // Map#Items relies on the two destructors for 2-tuples
            TupleType(Token.NoToken, MutateCSharp.Schemata180.ReplaceNumericConstant_0(52L, 2), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(56L, true));
            // Several methods and fields rely on 1-argument arrow types
            CreateArrowTypeDecl(MutateCSharp.Schemata180.ReplaceNumericConstant_0(57L, 1));

            valuetypeDecls = new[] {
      new ValuetypeDecl(MutateCSharp.Schemata180.ReplaceStringConstant_2(61L, "bool"), SystemModule, t => t.IsBoolType, typeArgs => Type.Bool),
      new ValuetypeDecl(MutateCSharp.Schemata180.ReplaceStringConstant_2(62L, "char"), SystemModule, t => t.IsCharType, typeArgs => Type.Char),
      new ValuetypeDecl(MutateCSharp.Schemata180.ReplaceStringConstant_2(63L, "int"), SystemModule, t => t.IsNumericBased(Type.NumericPersuasion.Int), typeArgs => Type.Int),
      new ValuetypeDecl(MutateCSharp.Schemata180.ReplaceStringConstant_2(64L, "real"), SystemModule, t => t.IsNumericBased(Type.NumericPersuasion.Real), typeArgs => Type.Real),
      new ValuetypeDecl(MutateCSharp.Schemata180.ReplaceStringConstant_2(65L, "ORDINAL"), SystemModule, t => t.IsBigOrdinalType, typeArgs => Type.BigOrdinal),
      new ValuetypeDecl(MutateCSharp.Schemata180.ReplaceStringConstant_2(66L, "_bv"), SystemModule, t => MutateCSharp.Schemata180.ReplaceBinExprOp_6(67L, () => t.IsBitVectorType, () => !Options.Get(CommonOptionBag.TypeSystemRefresh)),
        null), // "_bv" represents a family of classes, so no typeTester or type creator is supplied (it's used only in the legacy resolver)
      new ValuetypeDecl(MutateCSharp.Schemata180.ReplaceStringConstant_2(73L, "set"), SystemModule,
        new List<TypeParameter.TPVarianceSyntax>() { TypeParameter.TPVarianceSyntax.Covariant_Strict },
        t => t.AsSetType is { Finite: true }, typeArgs => new SetType(MutateCSharp.Schemata180.ReplaceBooleanConstant_5(74L, true), typeArgs[MutateCSharp.Schemata180.ReplaceNumericConstant_0(75L, 0)])),
      new ValuetypeDecl(MutateCSharp.Schemata180.ReplaceStringConstant_2(79L, "iset"), SystemModule,
        new List<TypeParameter.TPVarianceSyntax>() { TypeParameter.TPVarianceSyntax.Covariant_Permissive },
        t => t.IsISetType, typeArgs => new SetType(MutateCSharp.Schemata180.ReplaceBooleanConstant_5(80L, false), typeArgs[MutateCSharp.Schemata180.ReplaceNumericConstant_0(81L, 0)])),
      new ValuetypeDecl(MutateCSharp.Schemata180.ReplaceStringConstant_2(85L, "seq"), SystemModule,
        new List<TypeParameter.TPVarianceSyntax>() { TypeParameter.TPVarianceSyntax.Covariant_Strict },
        t => MutateCSharp.Schemata180.ReplaceBinExprOp_7(86L, t.AsSeqType, null), typeArgs => new SeqType(typeArgs[MutateCSharp.Schemata180.ReplaceNumericConstant_0(87L, 0)])),
      new ValuetypeDecl(MutateCSharp.Schemata180.ReplaceStringConstant_2(91L, "multiset"), SystemModule,
        new List<TypeParameter.TPVarianceSyntax>() { TypeParameter.TPVarianceSyntax.Covariant_Strict },
        t => MutateCSharp.Schemata180.ReplaceBinExprOp_8(92L, t.AsMultiSetType, null), typeArgs => new MultiSetType(typeArgs[MutateCSharp.Schemata180.ReplaceNumericConstant_0(93L, 0)])),
      new ValuetypeDecl(MutateCSharp.Schemata180.ReplaceStringConstant_2(97L, "map"), SystemModule,
        new List<TypeParameter.TPVarianceSyntax>()
          { TypeParameter.TPVarianceSyntax.Covariant_Strict, TypeParameter.TPVarianceSyntax.Covariant_Strict },
        t => t.IsMapType, typeArgs => new MapType(MutateCSharp.Schemata180.ReplaceBooleanConstant_5(98L, true), typeArgs[MutateCSharp.Schemata180.ReplaceNumericConstant_0(99L, 0)], typeArgs[MutateCSharp.Schemata180.ReplaceNumericConstant_0(103L, 1)])),
      new ValuetypeDecl(MutateCSharp.Schemata180.ReplaceStringConstant_2(107L, "imap"), SystemModule,
        new List<TypeParameter.TPVarianceSyntax>()
          { TypeParameter.TPVarianceSyntax.Covariant_Permissive, TypeParameter.TPVarianceSyntax.Covariant_Strict },
        t => t.IsIMapType, typeArgs => new MapType(MutateCSharp.Schemata180.ReplaceBooleanConstant_5(108L, false), typeArgs[MutateCSharp.Schemata180.ReplaceNumericConstant_0(109L, 0)], typeArgs[MutateCSharp.Schemata180.ReplaceNumericConstant_0(113L, 1)]))
    };
            SystemModule.SourceDecls.AddRange(valuetypeDecls);
            // Resolution error handling relies on being able to get to the 0-tuple declaration
            TupleType(Token.NoToken, MutateCSharp.Schemata180.ReplaceNumericConstant_0(117L, 0), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(121L, true));

            // Populate the members of the basic types

            void AddMember(MemberDecl member, ValuetypeVariety valuetypeVariety)
            {
                var enclosingType = valuetypeDecls[(int)valuetypeVariety];
                member.EnclosingClass = enclosingType;
                member.AddVisibilityScope(SystemModule.VisibilityScope, MutateCSharp.Schemata180.ReplaceBooleanConstant_5(122L, false));
                enclosingType.Members.Add(member);
            }

            var floor = new SpecialField(RangeToken.NoToken, MutateCSharp.Schemata180.ReplaceStringConstant_2(123L, "Floor"), SpecialField.ID.Floor, null, MutateCSharp.Schemata180.ReplaceBooleanConstant_5(124L, false), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(125L, false), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(126L, false), Type.Int, null);
            AddMember(floor, ValuetypeVariety.Real);

            var isLimit = new SpecialField(RangeToken.NoToken, MutateCSharp.Schemata180.ReplaceStringConstant_2(127L, "IsLimit"), SpecialField.ID.IsLimit, null, MutateCSharp.Schemata180.ReplaceBooleanConstant_5(128L, false), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(129L, false), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(130L, false), Type.Bool, null);
            AddMember(isLimit, ValuetypeVariety.BigOrdinal);

            var isSucc = new SpecialField(RangeToken.NoToken, MutateCSharp.Schemata180.ReplaceStringConstant_2(131L, "IsSucc"), SpecialField.ID.IsSucc, null, MutateCSharp.Schemata180.ReplaceBooleanConstant_5(132L, false), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(133L, false), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(134L, false), Type.Bool, null);
            AddMember(isSucc, ValuetypeVariety.BigOrdinal);

            var limitOffset = new SpecialField(RangeToken.NoToken, MutateCSharp.Schemata180.ReplaceStringConstant_2(135L, "Offset"), SpecialField.ID.Offset, null, MutateCSharp.Schemata180.ReplaceBooleanConstant_5(136L, false), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(137L, false), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(138L, false), Type.Int, null);
            AddMember(limitOffset, ValuetypeVariety.BigOrdinal);
            ORDINAL_Offset = limitOffset;

            var isNat = new SpecialField(RangeToken.NoToken, MutateCSharp.Schemata180.ReplaceStringConstant_2(139L, "IsNat"), SpecialField.ID.IsNat, null, MutateCSharp.Schemata180.ReplaceBooleanConstant_5(140L, false), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(141L, false), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(142L, false), Type.Bool, null);
            AddMember(isNat, ValuetypeVariety.BigOrdinal);

            // Add "Keys", "Values", and "Items" to map, imap
            foreach (var typeVariety in new[] { ValuetypeVariety.Map, ValuetypeVariety.IMap })
            {
                var vtd = valuetypeDecls[(int)typeVariety];
                var isFinite = MutateCSharp.Schemata180.ReplaceBinExprOp_9(143L, typeVariety, ValuetypeVariety.Map);

                var r = new SetType(isFinite, new UserDefinedType(vtd.TypeArgs[MutateCSharp.Schemata180.ReplaceNumericConstant_0(144L, 0)]));
                var keys = new SpecialField(RangeToken.NoToken, MutateCSharp.Schemata180.ReplaceStringConstant_2(148L, "Keys"), SpecialField.ID.Keys, null, MutateCSharp.Schemata180.ReplaceBooleanConstant_5(149L, false), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(150L, false), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(151L, false), r, null);

                r = new SetType(isFinite, new UserDefinedType(vtd.TypeArgs[MutateCSharp.Schemata180.ReplaceNumericConstant_0(152L, 1)]));
                var values = new SpecialField(RangeToken.NoToken, MutateCSharp.Schemata180.ReplaceStringConstant_2(156L, "Values"), SpecialField.ID.Values, null, MutateCSharp.Schemata180.ReplaceBooleanConstant_5(157L, false), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(158L, false), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(159L, false), r, null);

                var gt = vtd.TypeArgs.ConvertAll(tp => (Type)new UserDefinedType(tp));
                var dt = TupleType(Token.NoToken, MutateCSharp.Schemata180.ReplaceNumericConstant_0(160L, 2), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(164L, true));
                var tupleType = new UserDefinedType(Token.NoToken, dt.Name, dt, gt);
                r = new SetType(isFinite, tupleType);
                var items = new SpecialField(RangeToken.NoToken, MutateCSharp.Schemata180.ReplaceStringConstant_2(165L, "Items"), SpecialField.ID.Items, null, MutateCSharp.Schemata180.ReplaceBooleanConstant_5(166L, false), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(167L, false), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(168L, false), r, null);

                foreach (var memb in new[] { keys, values, items })
                {
                    AddMember(memb, typeVariety);
                }
            }

            // The result type of the following bitvector methods is the type of the bitvector itself. However, we're representing all bitvector types as
            // a family of types rolled up in one ValuetypeDecl. Therefore, we use the special SelfType as the result type.
            AddRotateMember(valuetypeDecls[(int)ValuetypeVariety.Bitvector], MutateCSharp.Schemata180.ReplaceStringConstant_2(169L, "RotateLeft"), new SelfType());
            AddRotateMember(valuetypeDecls[(int)ValuetypeVariety.Bitvector], MutateCSharp.Schemata180.ReplaceStringConstant_2(170L, "RotateRight"), new SelfType());
        }

        public void AddRotateMember(ValuetypeDecl enclosingType, string name, Type resultType)
        {
            var formals = new List<Formal> { new Formal(Token.NoToken, MutateCSharp.Schemata180.ReplaceStringConstant_2(171L, "w"), Type.Nat(), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(172L, true), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(173L, false), null) };
            var rotateMember = new SpecialFunction(RangeToken.NoToken, name, SystemModule, MutateCSharp.Schemata180.ReplaceBooleanConstant_5(174L, false), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(175L, false),
              new List<TypeParameter>(), formals, resultType,
              new List<AttributedExpression>(), new Specification<FrameExpression>(new List<FrameExpression>(), null), new List<AttributedExpression>(),
              new Specification<Expression>(new List<Expression>(), null), null, null, null);
            rotateMember.EnclosingClass = enclosingType;
            rotateMember.AddVisibilityScope(SystemModule.VisibilityScope, MutateCSharp.Schemata180.ReplaceBooleanConstant_5(176L, false));
            enclosingType.Members.Add(rotateMember);
        }

        private Attributes DontCompile()
        {
            var flse = Expression.CreateBoolLiteral(Token.NoToken, MutateCSharp.Schemata180.ReplaceBooleanConstant_5(177L, false));
            return new Attributes(MutateCSharp.Schemata180.ReplaceStringConstant_2(178L, "compile"), new List<Expression>() { flse }, null);
        }

        public static Attributes AxiomAttribute(Attributes prev = null)
        {
            return new Attributes(MutateCSharp.Schemata180.ReplaceStringConstant_2(179L, "axiom"), new List<Expression>(), prev);
        }

        /// <summary>
        /// Ensures this instance contains the requested type
        /// </summary>
        public UserDefinedType ArrayType(int dims, Type arg, bool allowCreationOfNewClass)
        {
            Contract.Requires(1 <= dims);
            Contract.Requires(arg != null);
            var (result, mod) = ArrayType(Token.NoToken, dims, new List<Type> { arg }, allowCreationOfNewClass);
            mod(this);
            return result;
        }

        public static (UserDefinedType type, Action<SystemModuleManager> ModifyBuiltins) ArrayType(IToken tok, int dims, List<Type> optTypeArgs, bool allowCreationOfNewClass, bool useClassNameType = false)
        {
            Contract.Requires(tok != null);
            Contract.Requires(1 <= dims);
            Contract.Requires(optTypeArgs == null || optTypeArgs.Count > 0);  // ideally, it is 1, but more will generate an error later, and null means it will be filled in automatically
            Contract.Ensures(Contract.Result<UserDefinedType>() != null);

            var arrayName = ArrayClassName(dims);
            if (useClassNameType)
            {
                arrayName += MutateCSharp.Schemata180.ReplaceStringConstant_2(180L, "?");
            }

            void ModifyBuiltins(SystemModuleManager builtIns)
            {
                if (MutateCSharp.Schemata180.ReplaceBinExprOp_10(181L, () => !allowCreationOfNewClass, () => builtIns.arrayTypeDecls.ContainsKey(dims)))
                {
                    return;
                }

                ArrayClassDecl arrayClass = new ArrayClassDecl(dims, builtIns.SystemModule, builtIns.DontCompile());
                for (int d = MutateCSharp.Schemata180.ReplaceNumericConstant_0(187L, 0); MutateCSharp.Schemata180.ReplaceBinExprOp_3(191L, d, dims); MutateCSharp.Schemata180.ReplacePostfixUnaryExprOp_4(196L, ref d))
                {
                    string name = MutateCSharp.Schemata180.ReplaceBinExprOp_11(201L, dims, MutateCSharp.Schemata180.ReplaceNumericConstant_0(197L, 1)) ? MutateCSharp.Schemata180.ReplaceStringConstant_2(206L, "Length") : MutateCSharp.Schemata180.ReplaceStringConstant_2(207L, "Length") + d;
                    Field len = new SpecialField(RangeToken.NoToken, name, SpecialField.ID.ArrayLength, MutateCSharp.Schemata180.ReplaceBinExprOp_11(212L, dims, MutateCSharp.Schemata180.ReplaceNumericConstant_0(208L, 1)) ? null : (object)d, MutateCSharp.Schemata180.ReplaceBooleanConstant_5(217L, false), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(218L, false), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(219L, false), Type.Int, null);
                    len.EnclosingClass = arrayClass; // resolve here
                    arrayClass.Members.Add(len);
                }

                builtIns.arrayTypeDecls.Add(dims, arrayClass);
                builtIns.SystemModule.SourceDecls.Add(arrayClass);
                builtIns.CreateArrowTypeDecl(dims); // also create an arrow type with this arity, since it may be used in an initializing expression for the array
            }

            var udt = new UserDefinedType(tok, arrayName, optTypeArgs);
            return (udt, ModifyBuiltins);
        }

        public static string ArrayClassName(int dims)
        {
            Contract.Requires(1 <= dims);
            if (MutateCSharp.Schemata180.ReplaceBinExprOp_11(224L, dims, MutateCSharp.Schemata180.ReplaceNumericConstant_0(220L, 1)))
            {
                return MutateCSharp.Schemata180.ReplaceStringConstant_2(229L, "array");
            }
            else
            {
                return MutateCSharp.Schemata180.ReplaceStringConstant_2(230L, "array") + dims;
            }

            return default;
        }

        /// <summary>
        /// Idempotently add an arrow type with arity 'arity' to the system module, and along
        /// with this arrow type, the two built-in subset types based on the arrow type.
        /// </summary>
        public void CreateArrowTypeDecl(int arity)
        {
            Contract.Requires(0 <= arity);
            if (ArrowTypeDecls.ContainsKey(arity))
            {
                // The work has already been done.
                return;
            }

            IToken tok = Token.NoToken;
            var tps = Util.Map(Enumerable.Range(MutateCSharp.Schemata180.ReplaceNumericConstant_0(231L, 0), MutateCSharp.Schemata180.ReplaceBinExprOp_12(239L, arity, MutateCSharp.Schemata180.ReplaceNumericConstant_0(235L, 1))),
              x => MutateCSharp.Schemata180.ReplaceBinExprOp_3(248L, x, arity
        ) ? new TypeParameter(RangeToken.NoToken, new Name(MutateCSharp.Schemata180.ReplaceStringConstant_2(253L, "T") + x), TypeParameter.TPVarianceSyntax.Contravariance)
                : new TypeParameter(RangeToken.NoToken, new Name(MutateCSharp.Schemata180.ReplaceStringConstant_2(254L, "R")), TypeParameter.TPVarianceSyntax.Covariant_Strict));
            var tys = tps.ConvertAll(tp => (Type)(new UserDefinedType(tp)));

            Function CreateMember(string name, Type resultType, Function readsFunction = null)
            {
                var args = Util.Map(Enumerable.Range(MutateCSharp.Schemata180.ReplaceNumericConstant_0(255L, 0), arity), i => new Formal(tok, MutateCSharp.Schemata180.ReplaceStringConstant_2(259L, "x") + i, tys[i], MutateCSharp.Schemata180.ReplaceBooleanConstant_5(260L, true), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(261L, false), null));
                var argExprs = args.ConvertAll(a =>
                  (Expression)new IdentifierExpr(tok, a.Name) { Var = a, Type = a.Type });
                var readsIS = new FunctionCallExpr(tok, MutateCSharp.Schemata180.ReplaceStringConstant_2(262L, "reads"), new ImplicitThisExpr(tok), tok, tok, argExprs)
                {
                    Type = ObjectSetType(),
                };
                var readsFrame = new List<FrameExpression> { new FrameExpression(tok, readsIS, null) };
                var function = new Function(RangeToken.NoToken, new Name(name), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(263L, false), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(264L, true), MutateCSharp.Schemata180.ReplaceBooleanConstant_5(265L, false),
                  new List<TypeParameter>(), args, null, resultType,
                  new List<AttributedExpression>(), new Specification<FrameExpression>(readsFrame, null), new List<AttributedExpression>(),
                  new Specification<Expression>(new List<Expression>(), null),
                  null, null, null, null, null);
                readsIS.Function = readsFunction ?? function; // just so we can really claim the member declarations are resolved
                readsIS.TypeApplication_AtEnclosingClass = tys; // ditto
                readsIS.TypeApplication_JustFunction = new List<Type>(); // ditto
                return function;
            }

            var reads = CreateMember(MutateCSharp.Schemata180.ReplaceStringConstant_2(266L, "reads"), ObjectSetType(), null);
            var req = CreateMember(MutateCSharp.Schemata180.ReplaceStringConstant_2(267L, "requires"), Type.Bool, reads);

            var arrowDecl = new ArrowTypeDecl(tps, req, reads, SystemModule, DontCompile());
            ArrowTypeDecls.Add(arity, arrowDecl);
            SystemModule.SourceDecls.Add(arrowDecl);

            // declaration of read-effect-free arrow-type, aka heap-independent arrow-type, aka partial-function arrow-type
            tps = Util.Map(Enumerable.Range(MutateCSharp.Schemata180.ReplaceNumericConstant_0(268L, 0), MutateCSharp.Schemata180.ReplaceBinExprOp_12(276L, arity, MutateCSharp.Schemata180.ReplaceNumericConstant_0(272L, 1))),
              x => MutateCSharp.Schemata180.ReplaceBinExprOp_3(285L, x, arity
        ) ? new TypeParameter(RangeToken.NoToken, new Name(MutateCSharp.Schemata180.ReplaceStringConstant_2(290L, "T") + x), TypeParameter.TPVarianceSyntax.Contravariance)
                : new TypeParameter(RangeToken.NoToken, new Name(MutateCSharp.Schemata180.ReplaceStringConstant_2(291L, "R")), TypeParameter.TPVarianceSyntax.Covariant_Strict));
            tys = tps.ConvertAll(tp => (Type)(new UserDefinedType(tp)));
            var id = new BoundVar(tok, MutateCSharp.Schemata180.ReplaceStringConstant_2(292L, "f"), new ArrowType(tok, arrowDecl, tys));
            var partialArrow = new SubsetTypeDecl(RangeToken.NoToken, new Name(ArrowType.PartialArrowTypeName(arity)),
              new TypeParameter.TypeParameterCharacteristics(MutateCSharp.Schemata180.ReplaceBooleanConstant_5(293L, false)), tps, SystemModule,
              id, ArrowSubtypeConstraint(tok, tok.ToRange(), id, reads, tps, MutateCSharp.Schemata180.ReplaceBooleanConstant_5(294L, false)), SubsetTypeDecl.WKind.Special, null, DontCompile());
            ((RedirectingTypeDecl)partialArrow).ConstraintIsCompilable = MutateCSharp.Schemata180.ReplaceBooleanConstant_5(295L, false);
            PartialArrowTypeDecls.Add(arity, partialArrow);
            SystemModule.SourceDecls.Add(partialArrow);

            // declaration of total arrow-type

            tps = Util.Map(Enumerable.Range(MutateCSharp.Schemata180.ReplaceNumericConstant_0(296L, 0), MutateCSharp.Schemata180.ReplaceBinExprOp_12(304L, arity, MutateCSharp.Schemata180.ReplaceNumericConstant_0(300L, 1))),
              x => MutateCSharp.Schemata180.ReplaceBinExprOp_3(313L, x, arity
        ) ? new TypeParameter(RangeToken.NoToken, new Name(MutateCSharp.Schemata180.ReplaceStringConstant_2(318L, "T") + x), TypeParameter.TPVarianceSyntax.Contravariance)
                : new TypeParameter(RangeToken.NoToken, new Name(MutateCSharp.Schemata180.ReplaceStringConstant_2(319L, "R")), TypeParameter.TPVarianceSyntax.Covariant_Strict));
            tys = tps.ConvertAll(tp => (Type)(new UserDefinedType(tp)));
            id = new BoundVar(tok, MutateCSharp.Schemata180.ReplaceStringConstant_2(320L, "f"), new UserDefinedType(tok, partialArrow.Name, partialArrow, tys));
            var totalArrow = new SubsetTypeDecl(RangeToken.NoToken, new Name(ArrowType.TotalArrowTypeName(arity)),
              new TypeParameter.TypeParameterCharacteristics(MutateCSharp.Schemata180.ReplaceBooleanConstant_5(321L, false)), tps, SystemModule,
              id, ArrowSubtypeConstraint(tok, tok.ToRange(), id, req, tps, MutateCSharp.Schemata180.ReplaceBooleanConstant_5(322L, true)), SubsetTypeDecl.WKind.Special, null, DontCompile());
            ((RedirectingTypeDecl)totalArrow).ConstraintIsCompilable = MutateCSharp.Schemata180.ReplaceBooleanConstant_5(323L, false);
            TotalArrowTypeDecls.Add(arity, totalArrow);
            SystemModule.SourceDecls.Add(totalArrow);
        }

        /// <summary>
        /// Returns an expression that is the constraint of:
        /// the built-in partial-arrow type (if "!total", in which case "member" is expected to denote the "reads" member), or
        /// the built-in total-arrow type (if "total", in which case "member" is expected to denote the "requires" member).
        /// The given "id" is expected to be already resolved.
        /// </summary>
        private Expression ArrowSubtypeConstraint(IToken tok, RangeToken rangeToken, BoundVar id, Function member, List<TypeParameter> tps, bool total)
        {
            Contract.Requires(tok != null);
            Contract.Requires(id != null);
            Contract.Requires(member != null);
            Contract.Requires(tps != null && 1 <= tps.Count);
            var f = new IdentifierExpr(tok, id);
            // forall x0,x1,x2 :: f.reads(x0,x1,x2) == {}
            // OR
            // forall x0,x1,x2 :: f.requires(x0,x1,x2)
            var bvs = new List<BoundVar>();
            var args = new List<Expression>();
            var bounds = new List<BoundedPool>();
            for (int i = MutateCSharp.Schemata180.ReplaceNumericConstant_0(324L, 0); MutateCSharp.Schemata180.ReplaceBinExprOp_3(341L, i, MutateCSharp.Schemata180.ReplaceBinExprOp_13(332L, tps.Count, MutateCSharp.Schemata180.ReplaceNumericConstant_0(328L, 1))); MutateCSharp.Schemata180.ReplacePostfixUnaryExprOp_4(346L, ref i))
            {
                var bv = new BoundVar(tok, MutateCSharp.Schemata180.ReplaceStringConstant_2(347L, "x") + i, new UserDefinedType(tps[i]));
                bvs.Add(bv);
                args.Add(new IdentifierExpr(tok, bv));
                bounds.Add(new SpecialAllocIndependenceAllocatedBoundedPool());
            }
            var fn = new MemberSelectExpr(tok, f, member.Name)
            {
                Member = member,
                TypeApplication_AtEnclosingClass = f.Type.TypeArgs,
                TypeApplication_JustMember = new List<Type>(),
                Type = GetTypeOfFunction(member, tps.ConvertAll(tp => (Type)new UserDefinedType(tp)), new List<Type>())
            };
            Expression body = new ApplyExpr(tok, fn, args, tok);
            body.Type = member.ResultType;  // resolve here
            if (!total)
            {
                Expression emptySet = new SetDisplayExpr(tok, MutateCSharp.Schemata180.ReplaceBooleanConstant_5(348L, true), new List<Expression>());
                emptySet.Type = member.ResultType;  // resolve here
                body = Expression.CreateEq(body, emptySet, member.ResultType);
            }
            if (MutateCSharp.Schemata180.ReplaceBinExprOp_1(353L, tps.Count, MutateCSharp.Schemata180.ReplaceNumericConstant_0(349L, 1)))
            {
                body = new ForallExpr(tok, rangeToken, bvs, null, body, null) { Type = Type.Bool, Bounds = bounds };
            }
            return body;
        }

        Type GetTypeOfFunction(Function f, List<Type> typeArgumentsClass, List<Type> typeArgumentsMember)
        {
            Contract.Requires(f != null);
            Contract.Requires(f.EnclosingClass != null);
            Contract.Requires(typeArgumentsClass != null);
            Contract.Requires(typeArgumentsMember != null);
            Contract.Requires(typeArgumentsClass.Count == f.EnclosingClass.TypeArgs.Count);
            Contract.Requires(typeArgumentsMember.Count == f.TypeArgs.Count);

            var atd = ArrowTypeDecls[f.Ins.Count];

            var formals = Util.Concat(f.EnclosingClass.TypeArgs, f.TypeArgs);
            var actuals = Util.Concat(typeArgumentsClass, typeArgumentsMember);
            var typeMap = TypeParameter.SubstitutionMap(formals, actuals);
            return new ArrowType(f.tok, atd, f.Ins.ConvertAll(arg => arg.Type.Subst(typeMap)), f.ResultType.Subst(typeMap));
        }

        public TupleTypeDecl TupleType(IToken tok, int dims, bool allowCreationOfNewType, List<bool> argumentGhostness = null)
        {
            Contract.Requires(tok != null);
            Contract.Requires(0 <= dims);
            Contract.Requires(argumentGhostness == null || argumentGhostness.Count == dims);
            Contract.Ensures(Contract.Result<TupleTypeDecl>() != null);

            argumentGhostness ??= new bool[dims].Select(_ => MutateCSharp.Schemata180.ReplaceBooleanConstant_5(358L, false)).ToList();
            if (!tupleTypeDecls.TryGetValue(argumentGhostness, out var tt))
            {
                Contract.Assume(allowCreationOfNewType);  // the parser should ensure that all needed tuple types exist by the time of resolution

                // A tuple type with ghost components is represented as the shorter tuple type with the ghost components erased, except
                // possibly when that shorter tuple type is a 1-tuple. Ordinarily, such a 1-tuple is optimized into its component, so
                // there's no reason to create it here; but if either the compiler doesn't support datatype wrapper erasure or if
                // the user has disabled this optimization, then we still create the 1-tuple here.
                var nonGhostDims = argumentGhostness.Count(x => !x);
                TupleTypeDecl nonGhostTupleTypeDecl = null;
                if (MutateCSharp.Schemata180.ReplaceBinExprOp_6(385L, () => MutateCSharp.Schemata180.ReplaceBinExprOp_14(359L, nonGhostDims, dims), () => (MutateCSharp.Schemata180.ReplaceBinExprOp_10(379L, () => MutateCSharp.Schemata180.ReplaceBinExprOp_10(373L, () => MutateCSharp.Schemata180.ReplaceBinExprOp_14(368L, nonGhostDims, MutateCSharp.Schemata180.ReplaceNumericConstant_0(364L, 1)), () => !Options.Backend.SupportsDatatypeWrapperErasure), () => !Options.Get(CommonOptionBag.OptimizeErasableDatatypeWrapper)))))
                {
                    // make sure the corresponding non-ghost tuple type also exists
                    nonGhostTupleTypeDecl = TupleType(tok, nonGhostDims, allowCreationOfNewType);
                }

                tt = new TupleTypeDecl(argumentGhostness, SystemModule, nonGhostTupleTypeDecl, null);
                if (MutateCSharp.Schemata180.ReplaceBinExprOp_1(391L, tt.NonGhostDims, MaxNonGhostTupleSizeUsed))
                {
                    MaxNonGhostTupleSizeToken = tok;
                    MaxNonGhostTupleSizeUsed = tt.NonGhostDims;
                }

                tupleTypeDecls.Add(argumentGhostness, tt);
                SystemModule.SourceDecls.Add(tt);
            }
            return tt;
        }

        public static char IsGhostToChar(bool isGhost)
        {
            return isGhost ? 'G' : 'O';
        }

        public static bool IsGhostFromChar(char c)
        {
            Contract.Requires(c == 'G' || c == 'O');
            return MutateCSharp.Schemata180.ReplaceBinExprOp_11(396L, c, 'G');
        }

        public static string ArgumentGhostnessToString(List<bool> argumentGhostness)
        {
            return argumentGhostness.Count + (!argumentGhostness.Contains(MutateCSharp.Schemata180.ReplaceBooleanConstant_5(401L, true))
              ? "" : String.Concat(argumentGhostness.Select(IsGhostToChar)));
        }

        public static IEnumerable<bool> ArgumentGhostnessFromString(string s, int count)
        {
            List<bool> argumentGhostness = new bool[count].ToList();
            if (System.Char.IsDigit(s[MutateCSharp.Schemata180.ReplaceBinExprOp_13(406L, s.Length, MutateCSharp.Schemata180.ReplaceNumericConstant_0(402L, 1))]))
            {
                return argumentGhostness.Select(_ => MutateCSharp.Schemata180.ReplaceBooleanConstant_5(415L, false));
            }
            else
            {
                return argumentGhostness.Select((_, i) => IsGhostFromChar(s[MutateCSharp.Schemata180.ReplaceBinExprOp_12(425L, MutateCSharp.Schemata180.ReplaceBinExprOp_13(416L, s.Length, count), i)]));
            }

            return default;
        }

        public static string TupleTypeName(List<bool> argumentGhostness)
        {
            return MutateCSharp.Schemata180.ReplaceStringConstant_2(434L, "_tuple#") + ArgumentGhostnessToString(argumentGhostness);
        }

        public static bool IsTupleTypeName(string s)
        {
            Contract.Requires(s != null);
            return s.StartsWith(MutateCSharp.Schemata180.ReplaceStringConstant_2(435L, "_tuple#"));
        }
        public const string TupleTypeCtorNamePrefix = "_#Make";  // the printer wants this name prefix to be uniquely recognizable

        public static string TupleTypeCtorName(int dims)
        {
            Contract.Assert(0 <= dims);
            return TupleTypeCtorNamePrefix + dims;
        }

        public ValuetypeDecl AsValuetypeDecl(Type t)
        {
            Contract.Requires(t != null);
            foreach (var vtd in valuetypeDecls)
            {
                if (vtd.IsThisType(t))
                {
                    return vtd;
                }
            }
            return null;
        }

        public void ResolveValueTypeDecls(ProgramResolver programResolver)
        {
            var moduleResolver = new ModuleResolver(programResolver, programResolver.Options);
            moduleResolver.moduleInfo = systemNameInfo;
            foreach (var valueTypeDecl in valuetypeDecls)
            {
                foreach (var member in valueTypeDecl.Members)
                {
                    if (member is Function function)
                    {
                        moduleResolver.ResolveFunctionSignature(function);
                        CallGraphBuilder.VisitFunction(function, programResolver.Reporter);
                    }
                    else if (member is Method method)
                    {
                        moduleResolver.ResolveMethodSignature(method);
                        CallGraphBuilder.VisitMethod(method, programResolver.Reporter);
                    }
                }
            }
        }

        public void CheckHasAllTupleNonGhostDimsUpTo(int max)
        {
            var allNeededDims = Enumerable.Range(MutateCSharp.Schemata180.ReplaceNumericConstant_0(436L, 0), MutateCSharp.Schemata180.ReplaceBinExprOp_12(444L, max, MutateCSharp.Schemata180.ReplaceNumericConstant_0(440L, 1))).ToHashSet();
            var allDeclaredDims = tupleTypeDecls.Keys
                .Select(argumentGhostness => argumentGhostness.Count(ghost => !ghost))
                .Distinct()
                .ToHashSet();
            if (!allDeclaredDims.SetEquals(allNeededDims))
            {
                throw new ArgumentException(@$"Not all tuple types declared between 0 and {max}!
needed: {allNeededDims.Comma()}
declared: {allDeclaredDims.Comma()}");
            }
        }

        public void CheckHasAllArrayDimsUpTo(int max)
        {
            var allNeededDims = Enumerable.Range(MutateCSharp.Schemata180.ReplaceNumericConstant_0(453L, 1), max).ToHashSet();
            var allDeclaredDims = arrayTypeDecls.Keys.ToHashSet();
            if (!allDeclaredDims.SetEquals(allNeededDims))
            {
                throw new ArgumentException(@$"Not all array types declared between 1 and {max}!
needed: {allNeededDims.Comma()}
declared: {allDeclaredDims.Comma()}");
            }
        }

        public void CheckHasAllArrowAritiesUpTo(int max)
        {
            var allNeededArities = Enumerable.Range(MutateCSharp.Schemata180.ReplaceNumericConstant_0(457L, 0), MutateCSharp.Schemata180.ReplaceBinExprOp_12(465L, max, MutateCSharp.Schemata180.ReplaceNumericConstant_0(461L, 1))).ToHashSet();
            var allDeclaredArities = ArrowTypeDecls.Keys.ToHashSet();
            if (!allDeclaredArities.SetEquals(allNeededArities))
            {
                throw new ArgumentException(@$"Not all arrow types declared between 0 and {max}
needed: {allNeededArities.Comma()}
declared: {allDeclaredArities.Comma()}");
            }
        }
    }

    public
    enum ValuetypeVariety
    {
        Bool = 0,
        Char,
        Int,
        Real,
        BigOrdinal,
        Bitvector,
        Set,
        ISet,
        Seq,
        Multiset,
        Map,
        IMap,
        None
    } // note, these are ordered, so they can be used as indices into valuetypeDecls
} // note, these are ordered, so they can be used as indices into valuetypeDecls
