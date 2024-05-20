#nullable enable
using System;
using System.Reflection.Metadata;
namespace MutateCSharp
{
    internal class Schemata469
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT469");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, System.Reflection.Metadata.PrimitiveTypeCode argument1, System.Reflection.Metadata.PrimitiveTypeCode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class StringOnlyCustomAttributeTypeProvider : ICustomAttributeTypeProvider<System.Type>
    {
        public System.Type GetPrimitiveType(PrimitiveTypeCode typeCode)
        {
            if (MutateCSharp.Schemata469.ReplaceBinExprOp_0(1L, typeCode, PrimitiveTypeCode.String))
            {
                return typeof(string);
            }
            throw new NotImplementedException();
            return default;
        }

        public System.Type GetTypeFromDefinition(MetadataReader reader, TypeDefinitionHandle handle, byte rawTypeKind)
        {
            throw new NotImplementedException();
            return default;
        }

        public System.Type GetTypeFromReference(MetadataReader reader, TypeReferenceHandle handle, byte rawTypeKind)
        {
            throw new NotImplementedException();
            return default;
        }

        public System.Type GetSZArrayType(System.Type elementType)
        {
            throw new NotImplementedException();
            return default;
        }

        public System.Type GetSystemType()
        {
            throw new NotImplementedException();
            return default;
        }

        public System.Type GetTypeFromSerializedName(string name)
        {
            throw new NotImplementedException();
            return default;
        }

        public PrimitiveTypeCode GetUnderlyingEnumType(System.Type type)
        {
            throw new NotImplementedException();
            return default;
        }

        public bool IsSystemType(System.Type type)
        {
            throw new NotImplementedException();
            return default;
        }
    }
}