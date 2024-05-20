using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata113
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT113");
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

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_2(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public class SpecialField : Field
    {
        public enum ID
        {
            UseIdParam,  // IdParam is a string
            ArrayLength,  // IdParam is null for .Length; IdParam is an int "x" for GetLength(x)
            ArrayLengthInt,  // same as ArrayLength, but produces int instead of BigInteger
            Floor,
            IsLimit,
            IsSucc,
            Offset,
            IsNat,
            Keys,
            Values,
            Items,
            Reads,
            Modifies,
            New,
        }
        public readonly ID SpecialId;
        public readonly object IdParam;

        public SpecialField(RangeToken rangeToken, string name, ID specialId, object idParam,
          bool isGhost, bool isMutable, bool isUserMutable, Type type, Attributes attributes)
          : this(rangeToken, new Name(name), specialId, idParam, MutateCSharp.Schemata113.ReplaceBooleanConstant_0(1L, false), isGhost, isMutable, isUserMutable, type, attributes)
        {
        }

        public SpecialField(RangeToken rangeToken, Name name, ID specialId, object idParam,
          bool hasStaticKeyword, bool isGhost, bool isMutable, bool isUserMutable, Type type, Attributes attributes)
          : base(rangeToken, name, hasStaticKeyword, isGhost, isMutable, isUserMutable, type, attributes)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(!isUserMutable || isMutable);
            Contract.Requires(type != null);

            SpecialId = specialId;
            IdParam = idParam;
        }

        public override string FullName
        {
            get
            {
                Contract.Ensures(Contract.Result<string>() != null);
                return MutateCSharp.Schemata113.ReplaceBinExprOp_1(2L, EnclosingClass, null) ? EnclosingClass.FullName + MutateCSharp.Schemata113.ReplaceStringConstant_2(3L, ".") + Name : Name;
            }
        }

        public override string FullSanitizedName
        {
            get
            {
                Contract.Ensures(Contract.Result<string>() != null);
                return MutateCSharp.Schemata113.ReplaceBinExprOp_1(4L, EnclosingClass, null) ? EnclosingClass.FullSanitizedName + MutateCSharp.Schemata113.ReplaceStringConstant_2(5L, ".") + SanitizedName : SanitizedName;
            }
        }

        public override string GetCompileName(DafnyOptions options)
        {
            Contract.Ensures(Contract.Result<string>() != null);
            return MutateCSharp.Schemata113.ReplaceBinExprOp_1(6L, EnclosingClass, null) ? base.GetCompileName(options) : Name;
        }
    }

    public class DatatypeDiscriminator : SpecialField
    {
        public override string WhatKind
        {
            get { return MutateCSharp.Schemata113.ReplaceStringConstant_2(7L, "discriminator"); }
        }

        public DatatypeDiscriminator(RangeToken rangeToken, Name name, ID specialId, object idParam, bool isGhost, Type type, Attributes attributes)
          : base(rangeToken, name, specialId, idParam, MutateCSharp.Schemata113.ReplaceBooleanConstant_0(8L, false), isGhost, MutateCSharp.Schemata113.ReplaceBooleanConstant_0(9L, false), MutateCSharp.Schemata113.ReplaceBooleanConstant_0(10L, false), type, attributes)
        {
        }
    }

    public class DatatypeDestructor : SpecialField
    {
        public readonly List<DatatypeCtor> EnclosingCtors = new List<DatatypeCtor>();  // is always a nonempty list
        public readonly List<Formal> CorrespondingFormals = new List<Formal>();  // is always a nonempty list
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(EnclosingCtors != null);
            Contract.Invariant(CorrespondingFormals != null);
            Contract.Invariant(EnclosingCtors.Count > 0);
            Contract.Invariant(EnclosingCtors.Count == CorrespondingFormals.Count);
        }

        public DatatypeDestructor(RangeToken rangeToken, DatatypeCtor enclosingCtor, Formal correspondingFormal, Name name, string compiledName, bool isGhost, Type type, Attributes attributes)
          : base(rangeToken, name, SpecialField.ID.UseIdParam, compiledName, MutateCSharp.Schemata113.ReplaceBooleanConstant_0(11L, false), isGhost, MutateCSharp.Schemata113.ReplaceBooleanConstant_0(12L, false), MutateCSharp.Schemata113.ReplaceBooleanConstant_0(13L, false), type, attributes)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(enclosingCtor != null);
            Contract.Requires(correspondingFormal != null);
            Contract.Requires(name != null);
            Contract.Requires(type != null);
            EnclosingCtors.Add(enclosingCtor);  // more enclosing constructors may be added later during resolution
            CorrespondingFormals.Add(correspondingFormal);  // more corresponding formals may be added later during resolution
        }

        /// <summary>
        /// To be called only by the resolver. Called to share this datatype destructor between multiple constructors
        /// of the same datatype.
        /// </summary>
        internal void AddAnotherEnclosingCtor(DatatypeCtor ctor, Formal formal)
        {
            Contract.Requires(ctor != null);
            Contract.Requires(formal != null);
            EnclosingCtors.Add(ctor);  // more enclosing constructors may be added later during resolution
            CorrespondingFormals.Add(formal);  // more corresponding formals may be added later during resolution
        }

        internal string EnclosingCtorNames(string grammaticalConjunction)
        {
            Contract.Requires(grammaticalConjunction != null);
            return PrintableCtorNameList(EnclosingCtors, grammaticalConjunction);
        }

        static internal string PrintableCtorNameList(List<DatatypeCtor> ctors, string grammaticalConjunction)
        {
            Contract.Requires(ctors != null);
            Contract.Requires(grammaticalConjunction != null);
            return Util.PrintableNameList(ctors.ConvertAll(ctor => ctor.Name), grammaticalConjunction);
        }
    }
}