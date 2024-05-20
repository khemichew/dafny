// Dafny program the_program compiled into C#
// To recompile, you will need the libraries
//     System.Runtime.Numerics.dll System.Collections.Immutable.dll
// but the 'dotnet' tool in net6.0 should pick those up automatically.
// Optionally, you may want to include compiler switches like
//     /debug /nowarn:162,164,168,183,219,436,1717,1718

using System;
using System.Numerics;
using System.Collections;
namespace MutateCSharp
{
    internal class Schemata275
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT275");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_6(long mutantId, DAST.Format.BinaryOpFormat_NoFormat argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, DAST.Format.BinaryOpFormat_EquivalenceFormat argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceNumericConstant_2(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, DAST.Format.UnaryOpFormat_NoFormat argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, DAST.Format.UnaryOpFormat_CombineFormat argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_4(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static ulong ReplaceNumericConstant_1(long mutantId, ulong argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 2)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return 0; }
            return argument1;
        }

        internal static ulong ReplaceBinExprOp_3(long mutantId, ulong argument1, ulong argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 6)) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 ^ argument2; }
            return argument1 + argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, DAST.Format.BinaryOpFormat_ImpliesFormat argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, DAST.Format.BinaryOpFormat_ReverseFormat argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace DAST.Format
{


    public interface _IUnaryOpFormat
    {
        bool is_NoFormat { get; }
        bool is_CombineFormat { get; }

        _IUnaryOpFormat DowncastClone();
    }
    public abstract class UnaryOpFormat : _IUnaryOpFormat
    {
        public UnaryOpFormat()
        {
        }
        private static readonly DAST.Format._IUnaryOpFormat theDefault = create_NoFormat();
        public static DAST.Format._IUnaryOpFormat Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST.Format._IUnaryOpFormat> _TYPE = new Dafny.TypeDescriptor<DAST.Format._IUnaryOpFormat>(DAST.Format.UnaryOpFormat.Default());
        public static Dafny.TypeDescriptor<DAST.Format._IUnaryOpFormat> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IUnaryOpFormat create_NoFormat()
        {
            return new UnaryOpFormat_NoFormat();
        }
        public static _IUnaryOpFormat create_CombineFormat()
        {
            return new UnaryOpFormat_CombineFormat();
        }
        public bool is_NoFormat
        {
            get { return this is UnaryOpFormat_NoFormat; }
        }

        public bool is_CombineFormat
        {
            get { return this is UnaryOpFormat_CombineFormat; }
        }

        public static System.Collections.Generic.IEnumerable<_IUnaryOpFormat> AllSingletonConstructors
        {
            get
            {
                yield return UnaryOpFormat.create_NoFormat();
                yield return UnaryOpFormat.create_CombineFormat();
            }
        }

        public abstract _IUnaryOpFormat DowncastClone();
    }
    public class UnaryOpFormat_NoFormat : UnaryOpFormat
    {
        public UnaryOpFormat_NoFormat() : base()
        {
        }
        public override _IUnaryOpFormat DowncastClone()
        {
            if (this is _IUnaryOpFormat dt) { return dt; }
            return new UnaryOpFormat_NoFormat();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Format.UnaryOpFormat_NoFormat;
            return MutateCSharp.Schemata275.ReplaceBinExprOp_0(1L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata275.ReplaceNumericConstant_1(2L, 5381);
            hash = MutateCSharp.Schemata275.ReplaceBinExprOp_3(19L, (MutateCSharp.Schemata275.ReplaceBinExprOp_3(9L, (hash << MutateCSharp.Schemata275.ReplaceNumericConstant_2(5L, 5)), hash)), MutateCSharp.Schemata275.ReplaceNumericConstant_1(16L, 0));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata275.ReplaceStringConstant_4(26L, "Format.UnaryOpFormat.NoFormat");
            return s;
        }
    }
    public class UnaryOpFormat_CombineFormat : UnaryOpFormat
    {
        public UnaryOpFormat_CombineFormat() : base()
        {
        }
        public override _IUnaryOpFormat DowncastClone()
        {
            if (this is _IUnaryOpFormat dt) { return dt; }
            return new UnaryOpFormat_CombineFormat();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Format.UnaryOpFormat_CombineFormat;
            return MutateCSharp.Schemata275.ReplaceBinExprOp_5(27L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata275.ReplaceNumericConstant_1(28L, 5381);
            hash = MutateCSharp.Schemata275.ReplaceBinExprOp_3(45L, (MutateCSharp.Schemata275.ReplaceBinExprOp_3(35L, (hash << MutateCSharp.Schemata275.ReplaceNumericConstant_2(31L, 5)), hash)), MutateCSharp.Schemata275.ReplaceNumericConstant_1(42L, 1));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata275.ReplaceStringConstant_4(52L, "Format.UnaryOpFormat.CombineFormat");
            return s;
        }
    }

    public interface _IBinaryOpFormat
    {
        bool is_NoFormat { get; }
        bool is_ImpliesFormat { get; }
        bool is_EquivalenceFormat { get; }
        bool is_ReverseFormat { get; }

        _IBinaryOpFormat DowncastClone();
    }
    public abstract class BinaryOpFormat : _IBinaryOpFormat
    {
        public BinaryOpFormat()
        {
        }
        private static readonly DAST.Format._IBinaryOpFormat theDefault = create_NoFormat();
        public static DAST.Format._IBinaryOpFormat Default()
        {
            return theDefault;
        }
        private static readonly Dafny.TypeDescriptor<DAST.Format._IBinaryOpFormat> _TYPE = new Dafny.TypeDescriptor<DAST.Format._IBinaryOpFormat>(DAST.Format.BinaryOpFormat.Default());
        public static Dafny.TypeDescriptor<DAST.Format._IBinaryOpFormat> _TypeDescriptor()
        {
            return _TYPE;
        }
        public static _IBinaryOpFormat create_NoFormat()
        {
            return new BinaryOpFormat_NoFormat();
        }
        public static _IBinaryOpFormat create_ImpliesFormat()
        {
            return new BinaryOpFormat_ImpliesFormat();
        }
        public static _IBinaryOpFormat create_EquivalenceFormat()
        {
            return new BinaryOpFormat_EquivalenceFormat();
        }
        public static _IBinaryOpFormat create_ReverseFormat()
        {
            return new BinaryOpFormat_ReverseFormat();
        }
        public bool is_NoFormat
        {
            get { return this is BinaryOpFormat_NoFormat; }
        }

        public bool is_ImpliesFormat
        {
            get { return this is BinaryOpFormat_ImpliesFormat; }
        }

        public bool is_EquivalenceFormat
        {
            get { return this is BinaryOpFormat_EquivalenceFormat; }
        }

        public bool is_ReverseFormat
        {
            get { return this is BinaryOpFormat_ReverseFormat; }
        }

        public static System.Collections.Generic.IEnumerable<_IBinaryOpFormat> AllSingletonConstructors
        {
            get
            {
                yield return BinaryOpFormat.create_NoFormat();
                yield return BinaryOpFormat.create_ImpliesFormat();
                yield return BinaryOpFormat.create_EquivalenceFormat();
                yield return BinaryOpFormat.create_ReverseFormat();
            }
        }

        public abstract _IBinaryOpFormat DowncastClone();
    }
    public class BinaryOpFormat_NoFormat : BinaryOpFormat
    {
        public BinaryOpFormat_NoFormat() : base()
        {
        }
        public override _IBinaryOpFormat DowncastClone()
        {
            if (this is _IBinaryOpFormat dt) { return dt; }
            return new BinaryOpFormat_NoFormat();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Format.BinaryOpFormat_NoFormat;
            return MutateCSharp.Schemata275.ReplaceBinExprOp_6(53L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata275.ReplaceNumericConstant_1(54L, 5381);
            hash = MutateCSharp.Schemata275.ReplaceBinExprOp_3(71L, (MutateCSharp.Schemata275.ReplaceBinExprOp_3(61L, (hash << MutateCSharp.Schemata275.ReplaceNumericConstant_2(57L, 5)), hash)), MutateCSharp.Schemata275.ReplaceNumericConstant_1(68L, 0));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata275.ReplaceStringConstant_4(78L, "Format.BinaryOpFormat.NoFormat");
            return s;
        }
    }
    public class BinaryOpFormat_ImpliesFormat : BinaryOpFormat
    {
        public BinaryOpFormat_ImpliesFormat() : base()
        {
        }
        public override _IBinaryOpFormat DowncastClone()
        {
            if (this is _IBinaryOpFormat dt) { return dt; }
            return new BinaryOpFormat_ImpliesFormat();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Format.BinaryOpFormat_ImpliesFormat;
            return MutateCSharp.Schemata275.ReplaceBinExprOp_7(79L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata275.ReplaceNumericConstant_1(80L, 5381);
            hash = MutateCSharp.Schemata275.ReplaceBinExprOp_3(97L, (MutateCSharp.Schemata275.ReplaceBinExprOp_3(87L, (hash << MutateCSharp.Schemata275.ReplaceNumericConstant_2(83L, 5)), hash)), MutateCSharp.Schemata275.ReplaceNumericConstant_1(94L, 1));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata275.ReplaceStringConstant_4(104L, "Format.BinaryOpFormat.ImpliesFormat");
            return s;
        }
    }
    public class BinaryOpFormat_EquivalenceFormat : BinaryOpFormat
    {
        public BinaryOpFormat_EquivalenceFormat() : base()
        {
        }
        public override _IBinaryOpFormat DowncastClone()
        {
            if (this is _IBinaryOpFormat dt) { return dt; }
            return new BinaryOpFormat_EquivalenceFormat();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Format.BinaryOpFormat_EquivalenceFormat;
            return MutateCSharp.Schemata275.ReplaceBinExprOp_8(105L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata275.ReplaceNumericConstant_1(106L, 5381);
            hash = MutateCSharp.Schemata275.ReplaceBinExprOp_3(123L, (MutateCSharp.Schemata275.ReplaceBinExprOp_3(113L, (hash << MutateCSharp.Schemata275.ReplaceNumericConstant_2(109L, 5)), hash)), MutateCSharp.Schemata275.ReplaceNumericConstant_1(120L, 2));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata275.ReplaceStringConstant_4(130L, "Format.BinaryOpFormat.EquivalenceFormat");
            return s;
        }
    }
    public class BinaryOpFormat_ReverseFormat : BinaryOpFormat
    {
        public BinaryOpFormat_ReverseFormat() : base()
        {
        }
        public override _IBinaryOpFormat DowncastClone()
        {
            if (this is _IBinaryOpFormat dt) { return dt; }
            return new BinaryOpFormat_ReverseFormat();
        }
        public override bool Equals(object other)
        {
            var oth = other as DAST.Format.BinaryOpFormat_ReverseFormat;
            return MutateCSharp.Schemata275.ReplaceBinExprOp_9(131L, oth, null);
        }
        public override int GetHashCode()
        {
            ulong hash = MutateCSharp.Schemata275.ReplaceNumericConstant_1(132L, 5381);
            hash = MutateCSharp.Schemata275.ReplaceBinExprOp_3(149L, (MutateCSharp.Schemata275.ReplaceBinExprOp_3(139L, (hash << MutateCSharp.Schemata275.ReplaceNumericConstant_2(135L, 5)), hash)), MutateCSharp.Schemata275.ReplaceNumericConstant_1(146L, 3));
            return (int)hash;
        }
        public override string ToString()
        {
            string s = MutateCSharp.Schemata275.ReplaceStringConstant_4(156L, "Format.BinaryOpFormat.ReverseFormat");
            return s;
        }
    }
} // end of namespace DAST.Format