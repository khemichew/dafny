using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using JetBrains.Annotations;
namespace MutateCSharp
{
    internal class Schemata200
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT200");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBooleanConstant_3(long mutantId, bool argument1)
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

        internal static bool ReplaceBinExprOp_1(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_2(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
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

    }
}

namespace Microsoft.Dafny
{
    public class TupleTypeDecl : IndDatatypeDecl
    {
        public readonly List<bool> ArgumentGhostness;

        public int Dims => ArgumentGhostness.Count;

        public int NonGhostDims => ArgumentGhostness.Count(x => !x);

        [CanBeNull]
        public TupleTypeDecl NonGhostTupleTypeDecl { get; }

        /// <summary>
        /// Construct a resolved built-in tuple type with "dim" arguments.  "systemModule" is expected to be the _System module.
        /// </summary>
        public TupleTypeDecl(List<bool> argumentGhostness, ModuleDefinition systemModule, [CanBeNull] TupleTypeDecl nonGhostTupleTypeDecl, Attributes attributes)
          : this(systemModule, CreateCovariantTypeParameters(argumentGhostness.Count), argumentGhostness, attributes)
        {
            Contract.Requires(0 <= argumentGhostness.Count);
            Contract.Requires(systemModule != null);

            // Resolve the type parameters here
            Contract.Assert(TypeArgs.Count == Dims);
            for (var i = MutateCSharp.Schemata200.ReplaceNumericConstant_0(1L, 0); MutateCSharp.Schemata200.ReplaceBinExprOp_1(5L, i, Dims); MutateCSharp.Schemata200.ReplacePostfixUnaryExprOp_2(10L, ref i))
            {
                var tp = TypeArgs[i];
                tp.Parent = this;
                tp.PositionalIndex = i;
            }

            NonGhostTupleTypeDecl = nonGhostTupleTypeDecl;
        }

        private TupleTypeDecl(ModuleDefinition systemModule, List<TypeParameter> typeArgs, List<bool> argumentGhostness, Attributes attributes)
          : base(RangeToken.NoToken, new Name(SystemModuleManager.TupleTypeName(argumentGhostness)), systemModule, typeArgs,
            CreateConstructors(typeArgs, argumentGhostness),
            new List<Type>(), new List<MemberDecl>(), attributes, MutateCSharp.Schemata200.ReplaceBooleanConstant_3(11L, false))
        {
            Contract.Requires(systemModule != null);
            Contract.Requires(typeArgs != null);
            Contract.Assert(Ctors.Count == 1);
            ArgumentGhostness = argumentGhostness;
            foreach (var ctor in Ctors)
            {
                ctor.EnclosingDatatype = this;  // resolve here
                GroundingCtor = ctor;
                TypeParametersUsedInConstructionByGroundingCtor = new bool[typeArgs.Count];
                for (int i = MutateCSharp.Schemata200.ReplaceNumericConstant_0(12L, 0); MutateCSharp.Schemata200.ReplaceBinExprOp_1(16L, i, typeArgs.Count); MutateCSharp.Schemata200.ReplacePostfixUnaryExprOp_2(21L, ref i))
                {
                    TypeParametersUsedInConstructionByGroundingCtor[i] = !argumentGhostness[i];
                }
            }
            this.EqualitySupport = argumentGhostness.Contains(MutateCSharp.Schemata200.ReplaceBooleanConstant_3(22L, true)) ? ES.Never : ES.ConsultTypeArguments;

            // Resolve parent type information - not currently possible for tuples to have any parent traits
            ParentTypeInformation = new InheritanceInformationClass();
        }
        private static List<TypeParameter> CreateCovariantTypeParameters(int dims)
        {
            Contract.Requires(0 <= dims);
            var ts = new List<TypeParameter>();
            for (int i = MutateCSharp.Schemata200.ReplaceNumericConstant_0(23L, 0); MutateCSharp.Schemata200.ReplaceBinExprOp_1(27L, i, dims); MutateCSharp.Schemata200.ReplacePostfixUnaryExprOp_2(32L, ref i))
            {
                var tp = new TypeParameter(RangeToken.NoToken, new Name(MutateCSharp.Schemata200.ReplaceStringConstant_4(33L, "T") + i), TypeParameter.TPVarianceSyntax.Covariant_Strict);
                tp.NecessaryForEqualitySupportOfSurroundingInductiveDatatype = MutateCSharp.Schemata200.ReplaceBooleanConstant_3(34L, true);
                ts.Add(tp);
            }
            return ts;
        }

        /// <summary>
        /// Creates the one and only constructor of the tuple type.
        /// </summary>
        private static List<DatatypeCtor> CreateConstructors(List<TypeParameter> typeArgs, List<bool> argumentGhostness)
        {
            Contract.Requires(typeArgs != null);
            var formals = new List<Formal>();
            var nonGhostArgs = MutateCSharp.Schemata200.ReplaceNumericConstant_0(35L, 0);
            for (int i = MutateCSharp.Schemata200.ReplaceNumericConstant_0(39L, 0); MutateCSharp.Schemata200.ReplaceBinExprOp_1(43L, i, typeArgs.Count); MutateCSharp.Schemata200.ReplacePostfixUnaryExprOp_2(48L, ref i))
            {
                string compileName;
                if (argumentGhostness[i])
                {
                    // This name is irrelevant, since it won't be used in compilation. Give it a strange name
                    // that would alert us of any bug that nevertheless tries to access this name.
                    compileName = MutateCSharp.Schemata200.ReplaceStringConstant_4(49L, "this * ghost * arg * should * never * be * compiled * ") + i.ToString();
                }
                else
                {
                    compileName = nonGhostArgs.ToString();
                    MutateCSharp.Schemata200.ReplacePostfixUnaryExprOp_2(50L, ref nonGhostArgs);
                }
                var tp = typeArgs[i];
                var f = new Formal(Token.NoToken, i.ToString(), new UserDefinedType(Token.NoToken, tp), MutateCSharp.Schemata200.ReplaceBooleanConstant_3(51L, true), argumentGhostness[i], null, nameForCompilation: compileName);
                formals.Add(f);
            }
            string ctorName = SystemModuleManager.TupleTypeCtorName(typeArgs.Count);
            var ctor = new DatatypeCtor(RangeToken.NoToken, new Name(ctorName), MutateCSharp.Schemata200.ReplaceBooleanConstant_3(52L, false), formals, null);
            return new List<DatatypeCtor>() { ctor };
        }

        public override string SanitizedName =>
          sanitizedName ??= $"Tuple{SystemModuleManager.ArgumentGhostnessToString(ArgumentGhostness)}";

        public override string GetCompileName(DafnyOptions options) => NonGhostTupleTypeDecl?.GetCompileName(options) ?? $"Tuple{NonGhostDims}";
    }
}