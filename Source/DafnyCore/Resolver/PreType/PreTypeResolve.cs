//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.Contracts;
using JetBrains.Annotations;
namespace MutateCSharp
{
    internal class Schemata422
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT422");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, Microsoft.Dafny.BoundVar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceNumericConstant_4(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_20(long mutantId, Microsoft.Dafny.Formal argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_32(long mutantId, Microsoft.Dafny.AssertLabel argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.TypeParameter.TPVariance argument1, Microsoft.Dafny.TypeParameter.TPVariance argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, Microsoft.Dafny.DatatypeCtor argument1, Microsoft.Dafny.DatatypeCtor argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, Microsoft.Dafny.IAttributeBearingDeclaration argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_31(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_30(long mutantId, Microsoft.Dafny.SubsetTypeDecl.WKind argument1, Microsoft.Dafny.SubsetTypeDecl.WKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.PreType> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_35(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, Microsoft.Dafny.TypeParameter.TPVariance argument1, Microsoft.Dafny.TypeParameter.TPVariance argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.DPreType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_6(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, Microsoft.Dafny.BoundVar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_28(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() == argument2();
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.ValuetypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_34(long mutantId, Microsoft.Dafny.FrameExpressionUse argument1, Microsoft.Dafny.FrameExpressionUse argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, Microsoft.Dafny.TopLevelDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_33(long mutantId, Microsoft.Dafny.Label argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_13(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, Microsoft.Dafny.Scope<Microsoft.Dafny.TypeParameter>.PushResult argument1, Microsoft.Dafny.Scope<Microsoft.Dafny.TypeParameter>.PushResult argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_36(long mutantId, Microsoft.Dafny.PreType argument1, object argument2)
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

        internal static bool ReplaceBinExprOp_37(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.DPreType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_29(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, Microsoft.Dafny.TopLevelDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public abstract class ResolverPass
    {
        public readonly ModuleResolver resolver;

        protected ResolverPass(ModuleResolver resolver)
        {
            Contract.Requires(resolver != null);
            this.resolver = resolver;
        }

        protected int ErrorCount => resolver.Reporter.Count(ErrorLevel.Error);

        protected void ReportError(Declaration d, string msg, params object[] args)
        {
            Contract.Requires(d != null);
            Contract.Requires(msg != null);
            Contract.Requires(args != null);
            ReportError(d.tok, msg, args);
        }

        protected void ReportError(Statement stmt, string msg, params object[] args)
        {
            Contract.Requires(stmt != null);
            Contract.Requires(msg != null);
            Contract.Requires(args != null);
            ReportError(stmt.Tok, msg, args);
        }

        protected void ReportError(Expression expr, string msg, params object[] args)
        {
            Contract.Requires(expr != null);
            Contract.Requires(msg != null);
            Contract.Requires(args != null);
            ReportError(expr.tok, msg, args);
        }

        public void ReportError(IToken tok, string msg, params object[] args)
        {
            Contract.Requires(tok != null);
            Contract.Requires(msg != null);
            Contract.Requires(args != null);
            resolver.Reporter.Error(MessageSource.Resolver, tok, msg, args);
        }

        public void ReportWarning(IToken tok, string msg, params object[] args)
        {
            Contract.Requires(tok != null);
            Contract.Requires(msg != null);
            Contract.Requires(args != null);
            resolver.Reporter.Warning(MessageSource.Resolver, ParseErrors.ErrorId.none, tok, msg, args);
        }

        protected void ReportInfo(IToken tok, string msg, params object[] args)
        {
            Contract.Requires(tok != null);
            Contract.Requires(msg != null);
            Contract.Requires(args != null);
            resolver.Reporter.Info(MessageSource.Resolver, tok, msg, args);
        }
    }

    public partial class PreTypeResolver : ResolverPass
    {
        private readonly Scope<IVariable> scope;
        public ErrorReporter Reporter => resolver.Reporter;
        public DafnyOptions Options => resolver.Options;
        public Scope<IVariable> Scope => scope;

        TopLevelDeclWithMembers currentClass;
        Method currentMethod;

        private readonly Dictionary<string, TopLevelDecl> preTypeBuiltins = new();
        public readonly PreTypeConstraints Constraints;

        TopLevelDecl BuiltInTypeDecl(string name)
        {
            Contract.Requires(name != null);
            if (preTypeInferenceModuleState.PreTypeBuiltins.TryGetValue(name, out var decl))
            {
                return decl;
            }
            if (IsArrayName(name, out var dims))
            {
                // make sure the array class has been created
                SystemModuleManager.ArrayType(Token.NoToken, dims,
                  new List<Type> { new InferredTypeProxy() }, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(1L, true)).ModifyBuiltins(resolver.SystemModuleManager);
                decl = resolver.SystemModuleManager.arrayTypeDecls[dims];
            }
            else if (IsBitvectorName(name, out var width))
            {
                var bvDecl = (ValuetypeDecl)resolver.SystemModuleManager.SystemModule.SourceDecls.Find(topLevelDecl => MutateCSharp.Schemata422.ReplaceBinExprOp_1(2L, topLevelDecl.Name, name));
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_2(3L, bvDecl, null))
                {
                    bvDecl = resolver.AddBitvectorTypeDecl(name, width);
                }
                preTypeInferenceModuleState.PreTypeBuiltins.Add(name, bvDecl);
                FillInPreTypesInSignature(bvDecl);
                foreach (var bitvectorMember in bvDecl.Members)
                {
                    FillInPreTypesInSignature(bitvectorMember);
                }
                return bvDecl;
            }
            else
            {
                decl = null;
                foreach (var valueTypeDecl in resolver.ProgramResolver.SystemModuleManager.valuetypeDecls)
                {
                    if (MutateCSharp.Schemata422.ReplaceBinExprOp_1(4L, valueTypeDecl.Name, name))
                    {
                        // bool, int, real, ORDINAL, map, imap
                        decl = valueTypeDecl;
                        break;
                    }
                }
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_3(5L, decl, null))
                {
                    if (name is PreType.TypeNameSet or PreType.TypeNameSeq or PreType.TypeNameMultiset)
                    {
                        var variances = new List<TypeParameter.TPVarianceSyntax>() { TypeParameter.TPVarianceSyntax.Covariant_Strict };
                        decl = new ValuetypeDecl(name, resolver.SystemModuleManager.SystemModule, variances, _ => MutateCSharp.Schemata422.ReplaceBooleanConstant_0(6L, false), null);
                    }
                    else if (MutateCSharp.Schemata422.ReplaceBinExprOp_1(7L, name, PreType.TypeNameIset))
                    {
                        var variances = new List<TypeParameter.TPVarianceSyntax>() { TypeParameter.TPVarianceSyntax.Covariant_Permissive };
                        decl = new ValuetypeDecl(name, resolver.SystemModuleManager.SystemModule, variances, _ => MutateCSharp.Schemata422.ReplaceBooleanConstant_0(8L, false), null);
                    }
                    else if (MutateCSharp.Schemata422.ReplaceBinExprOp_1(9L, name, PreType.TypeNameObjectQ))
                    {
                        decl = resolver.SystemModuleManager.ObjectDecl;
                    }
                    else
                    {
                        decl = new ValuetypeDecl(name, resolver.SystemModuleManager.SystemModule, _ => MutateCSharp.Schemata422.ReplaceBooleanConstant_0(10L, false), null);
                    }
                }
            }
            preTypeInferenceModuleState.PreTypeBuiltins.Add(name, decl);
            return decl;
        }

        TopLevelDecl BuiltInArrowTypeDecl(int arity)
        {
            Contract.Requires(0 <= arity);
            var name = ArrowType.ArrowTypeName(arity);
            if (!preTypeInferenceModuleState.PreTypeBuiltins.TryGetValue(name, out var decl))
            {
                // the arrow type declaration should already have been created by the parser
                decl = resolver.SystemModuleManager.ArrowTypeDecls[arity];
                preTypeInferenceModuleState.PreTypeBuiltins.Add(name, decl);
            }
            return decl;
        }

        DPreType BuiltInArrowType(List<PreType> inPreTypes, PreType resultPreType)
        {
            return new DPreType(BuiltInArrowTypeDecl(inPreTypes.Count), Util.Snoc(inPreTypes, resultPreType));
        }

        DPreType BuiltInArrayType(int dims, PreType elementPreType)
        {
            Contract.Requires(1 <= dims);
            var arrayName = MutateCSharp.Schemata422.ReplaceBinExprOp_5(15L, dims, MutateCSharp.Schemata422.ReplaceNumericConstant_4(11L, 1)) ? PreType.TypeNameArray : $"{PreType.TypeNameArray}{dims}";
            return new DPreType(BuiltInTypeDecl(arrayName), new List<PreType>() { elementPreType });
        }

        private int typeProxyCount = MutateCSharp.Schemata422.ReplaceNumericConstant_4(20L, 0); // used to give each PreTypeProxy a unique ID

        public readonly List<(PreTypeProxy, string)> allPreTypeProxies = new();

        public PreType CreatePreTypeProxy(string description = null)
        {
            var proxy = new PreTypeProxy(MutateCSharp.Schemata422.ReplacePostfixUnaryExprOp_6(24L, ref typeProxyCount));
            allPreTypeProxies.Add((proxy, description));
            return proxy;
        }

        /// <summary>
        /// This method can be used when .PreType has been found to be erroneous and its current value
        /// would be unexpected by the rest of the resolver. This method then sets .Type and .PreType to neutral values.
        /// </summary>
        void ResetTypeAssignment(Expression expr)
        {
            expr.PreType = CreatePreTypeProxy();
            expr.ResetTypeAssignment();
        }

        public enum Type2PreTypeOption { GoodForInference, GoodForPrinting, GoodForBoth }

        public PreType Type2PreType(Type type, string description = null, Type2PreTypeOption option = Type2PreTypeOption.GoodForBoth)
        {
            Contract.Requires(type != null);

            type = type.Normalize(); // keep type synonyms
            if (type.AsTypeSynonym is { } typeSynonymDecl && option != Type2PreTypeOption.GoodForInference &&
                typeSynonymDecl.IsRevealedInScope(Type.GetScope()))
            {
                // Compute a pre-type for the non-instantiated ("raw") RHS type (that is, for the RHS of the type-synonym declaration with the
                // formal type parameters of the type-synonym declaration).
                var rawRhsType = UserDefinedType.FromTopLevelDecl(typeSynonymDecl.tok, typeSynonymDecl);
                var preTypeArguments = type.TypeArgs.ConvertAll(ty => Type2PreType(ty, null, Type2PreTypeOption.GoodForBoth));

                // The printable pre-type is the original type synonym, but with preTypeArguments as arguments
                var printablePreType = new DPreType(typeSynonymDecl, preTypeArguments);

                // The expanded pre-type is the raw RHS pre-type, but substituting in preTypeArguments for the type parameters
                var rawRhsPreTypeForInference = Type2PreType(rawRhsType, null, Type2PreTypeOption.GoodForInference);
                var preType = rawRhsPreTypeForInference.Substitute(PreType.PreTypeSubstMap(typeSynonymDecl.TypeArgs, preTypeArguments));

                // Typically, preType is a DPreType. However, it could be that the RHS of the type synonym fizzles out to just one of the type
                // parameters of the type synonym, and if that type synonym started off a proxy, then "preType" will be a proxy.
                if (preType is DPreType dPreType)
                {
                    return new DPreType(dPreType.Decl, dPreType.Arguments, printablePreType);
                }
                else
                {
                    // TODO: it would be nice to have a place to include "printablePreType" as part of what's returned, but currently only DPreType allows that
                    return preType;
                }
            }

            type = type.NormalizeExpandKeepConstraints(); // blow past proxies and type synonyms
            if (type.AsSubsetType is { } subsetType)
            {
                ResolvePreTypeSignature(subsetType);
                Contract.Assert(subsetType.Var.PreType != null);
                var typeArguments = type.TypeArgs.ConvertAll(ty => Type2PreType(ty, null, option));
                var preTypeMap = PreType.PreTypeSubstMap(subsetType.TypeArgs, typeArguments);
                return subsetType.Var.PreType.Substitute(preTypeMap);
            }
            else if (type is UserDefinedType { ResolvedClass: NewtypeDecl newtypeDecl })
            {
                // Make sure the newtype declaration itself has been pre-type resolved
                ResolvePreTypeSignature(newtypeDecl);
                Contract.Assert(newtypeDecl.Var == null || newtypeDecl.Var.PreType != null);
                Contract.Assert(newtypeDecl.BasePreType != null);
            }

            if (type is TypeProxy)
            {
                return CreatePreTypeProxy(description ?? $"from type proxy {type}");
            }

            var decl = Type2Decl(type);
            var arguments = type.TypeArgs.ConvertAll(ty => Type2PreType(ty, null, option));
            return new DPreType(decl, arguments);
        }

        public TopLevelDecl Type2Decl(Type type)
        {
            Contract.Requires(type != null);
            Contract.Requires(type is NonProxyType and not SelfType);
            TopLevelDecl decl;
            if (type is BoolType)
            {
                decl = BuiltInTypeDecl(PreType.TypeNameBool);
            }
            else if (type is CharType)
            {
                decl = BuiltInTypeDecl(PreType.TypeNameChar);
            }
            else if (type is IntType)
            {
                decl = BuiltInTypeDecl(PreType.TypeNameInt);
            }
            else if (type is RealType)
            {
                decl = BuiltInTypeDecl(PreType.TypeNameReal);
            }
            else if (type is BigOrdinalType)
            {
                decl = BuiltInTypeDecl(PreType.TypeNameORDINAL);
            }
            else if (type is BitvectorType bitvectorType)
            {
                decl = BuiltInTypeDecl(PreType.TypeNameBvPrefix + bitvectorType.Width);
            }
            else if (type is CollectionType)
            {
                var name =
                  type is SetType st ? PreType.SetTypeName(st.Finite) :
                  type is MultiSetType ? PreType.TypeNameMultiset :
                  type is MapType mt ? PreType.MapTypeName(mt.Finite) :
                  PreType.TypeNameSeq;
                decl = BuiltInTypeDecl(name);
            }
            else if (type is ArrowType at)
            {
                decl = BuiltInArrowTypeDecl(at.Arity);
            }
            else if (type is UserDefinedType udt)
            {
                decl = udt.ResolvedClass;
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected type
            }
            return decl;
        }

        /// <summary>
        /// Returns the non-newtype ancestor of "decl".
        /// This method assumes that the ancestors of "decl" do not form any cycles. That is, any such cycle detection must already
        /// have been done.
        /// </summary>
        public static TopLevelDecl AncestorDecl(TopLevelDecl decl)
        {
            while (decl is NewtypeDecl newtypeDecl)
            {
                var parent = newtypeDecl.BasePreType.Normalize();
                decl = ((DPreType)parent).Decl;
            }
            return decl;
        }

        /// <summary>
        /// Returns the non-newtype ancestor pre-type of "preType".
        /// This method assumes that the ancestors of "preType.Decl" do not form any cycles. That is, any such cycle detection must already
        /// have been done.
        /// </summary>
        public static DPreType AncestorPreType(DPreType preType)
        {
            while (preType.Decl is NewtypeDecl newtypeDecl)
            {
                var subst = PreType.PreTypeSubstMap(newtypeDecl.TypeArgs, preType.Arguments);
                preType = (DPreType)newtypeDecl.BasePreType.Substitute(subst);
            }
            return preType;
        }

        [CanBeNull]
        public static string AncestorName(PreType preType)
        {
            var dp = preType.Normalize() as DPreType;
            return MutateCSharp.Schemata422.ReplaceBinExprOp_7(25L, dp, null) ? null : AncestorDecl(dp.Decl).Name;
        }

        /// <summary>
        /// Returns the non-newtype ancestor of "preType".
        /// If the ancestor chain has a cycle or if some part of the chain hasn't yet been resolved, this method ends the traversal
        /// early (and returns the last ancestor traversed). This method does not return any error; that's assumed to be done elsewhere.
        /// </summary>
        public static DPreType NewTypeAncestor(DPreType preType)
        {
            Contract.Requires(preType != null);
            ISet<NewtypeDecl> visited = null;
            while (preType.Decl is NewtypeDecl newtypeDecl)
            {
                visited ??= new HashSet<NewtypeDecl>();
                if (visited.Contains(newtypeDecl))
                {
                    // The parents of the originally given "preType" are in a cycle; the error has been reported elsewhere, but here we just want to get out
                    break;
                }
                visited.Add(newtypeDecl);
                var parent = newtypeDecl.BasePreType.Normalize() as DPreType;
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_7(26L, parent, null))
                {
                    // The parent type of this newtype apparently hasn't been inferred yet, so stop traversal here
                    break;
                }
                var subst = PreType.PreTypeSubstMap(newtypeDecl.TypeArgs, preType.Arguments);
                preType = (DPreType)parent.Substitute(subst);
            }
            return preType;
        }

        public static bool HasTraitSupertypes(DPreType dp)
        {
            /*
             * When traits can be used as supertypes for non-reference types (and "object" is an implicit parent trait of every
             * class), then this method can be implemented by
             *         return dp.Decl is TopLevelDeclWithMembers md && md.ParentTraits.Count != 0;
             * For now, every reference type except "object" has trait supertypes.
             */
            if (dp.Decl is TopLevelDeclWithMembers md && MutateCSharp.Schemata422.ReplaceBinExprOp_8(31L, md.ParentTraits.Count, MutateCSharp.Schemata422.ReplaceNumericConstant_4(27L, 0)))
            {
                // this type has explicitly declared parent traits
                return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(36L, true);
            }
            if (dp.Decl is TraitDecl trait && trait.IsObjectTrait)
            {
                // the built-in type "object" has no parent traits
                return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(37L, false);
            }
            // any non-object reference type has "object" as an implicit parent trait
            return DPreType.IsReferenceTypeDecl(dp.Decl);
        }

        /// <summary>
        /// Add to "ancestors" every TopLevelDecl that is a reflexive, transitive parent of "d",
        /// but not exploring past any TopLevelDecl that is already in "ancestors".
        /// </summary>
        public static void ComputeAncestors(TopLevelDecl decl, ISet<TopLevelDecl> ancestors, SystemModuleManager systemModuleManager)
        {
            if (!ancestors.Contains(decl))
            {
                ancestors.Add(decl);
                if (decl is TopLevelDeclWithMembers topLevelDeclWithMembers)
                {
                    topLevelDeclWithMembers.ParentTraitHeads.ForEach(parent => ComputeAncestors(parent, ancestors, systemModuleManager));
                }
                if (decl is TraitDecl { IsObjectTrait: true })
                {
                    // we're done
                }
                else if (DPreType.IsReferenceTypeDecl(decl))
                {
                    // object is also a parent type
                    ComputeAncestors(systemModuleManager.ObjectDecl, ancestors, systemModuleManager);
                }
            }
        }

        /// <summary>
        /// Return "true" if "super" is a super-(pre)type of "sub".
        /// Otherwise, return "false".
        /// Note, if either "super" or "sub" contains a type proxy, then "false" is returned.
        /// </summary>
        public bool IsSuperPreTypeOf(DPreType super, DPreType sub)
        {
            var subAncestors = new HashSet<TopLevelDecl>();
            ComputeAncestors(sub.Decl, subAncestors, resolver.SystemModuleManager);
            if (!subAncestors.Contains(super.Decl))
            {
                return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(38L, false);
            }
            sub = sub.AsParentType(super.Decl, this);
            var argumentCount = super.Decl.TypeArgs.Count;
            Contract.Assert(super.Arguments.Count == argumentCount);
            Contract.Assert(sub.Arguments.Count == argumentCount);
            for (var i = MutateCSharp.Schemata422.ReplaceNumericConstant_4(39L, 0); MutateCSharp.Schemata422.ReplaceBinExprOp_9(43L, i, argumentCount); MutateCSharp.Schemata422.ReplacePostfixUnaryExprOp_6(48L, ref i))
            {
                var superI = super.Arguments[i].Normalize() as DPreType;
                var subI = sub.Arguments[i].Normalize() as DPreType;
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_10(51L, () => MutateCSharp.Schemata422.ReplaceBinExprOp_7(49L, superI, null), () => MutateCSharp.Schemata422.ReplaceBinExprOp_7(50L, subI, null)))
                {
                    return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(57L, false);
                }
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_12(59L, () => MutateCSharp.Schemata422.ReplaceBinExprOp_11(58L, super.Decl.TypeArgs[i].Variance, TypeParameter.TPVariance.Contra), () => !IsSuperPreTypeOf(superI, subI)))
                {
                    return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(65L, false);
                }
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_12(67L, () => MutateCSharp.Schemata422.ReplaceBinExprOp_11(66L, super.Decl.TypeArgs[i].Variance, TypeParameter.TPVariance.Co), () => !IsSuperPreTypeOf(subI, superI)))
                {
                    return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(73L, false);
                }
            }
            return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(74L, true);
        }

        public static bool IsBitvectorName(string name, out int width)
        {
            Contract.Requires(name != null);
            if (name.StartsWith(PreType.TypeNameBvPrefix))
            {
                var bits = name.Substring(MutateCSharp.Schemata422.ReplaceNumericConstant_4(75L, 2));
                width = MutateCSharp.Schemata422.ReplaceNumericConstant_4(79L, 0); // set to 0, in case the first disjunct of the next line evaluates to true
                return MutateCSharp.Schemata422.ReplaceBinExprOp_1(84L, bits, MutateCSharp.Schemata422.ReplaceStringConstant_13(83L, "0")) || (bits.Length != 0 && bits[0] != '0' && int.TryParse(bits, out width));
            }
            width = MutateCSharp.Schemata422.ReplaceNumericConstant_4(85L, 0); // unused by caller
            return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(89L, false);
        }

        public static bool IsBitvectorName(string name)
        {
            return IsBitvectorName(name, out _);
        }

        public static bool IsArrayName(string name, out int dimensions)
        {
            Contract.Requires(name != null);
            if (name.StartsWith(PreType.TypeNameArray))
            {
                var dims = name[PreType.TypeNameArray.Length..];
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_5(94L, dims.Length, MutateCSharp.Schemata422.ReplaceNumericConstant_4(90L, 0)))
                {
                    dimensions = MutateCSharp.Schemata422.ReplaceNumericConstant_4(99L, 1);
                    return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(103L, true);
                }
                else if (MutateCSharp.Schemata422.ReplaceBinExprOp_12(115L, () => MutateCSharp.Schemata422.ReplaceBinExprOp_8(108L, dims[MutateCSharp.Schemata422.ReplaceNumericConstant_4(104L, 0)], '0'), () => MutateCSharp.Schemata422.ReplaceBinExprOp_14(114L, dims, MutateCSharp.Schemata422.ReplaceStringConstant_13(113L, "1"))) && int.TryParse(dims, out dimensions))
                {
                    return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(121L, true);
                }
            }
            dimensions = MutateCSharp.Schemata422.ReplaceNumericConstant_4(122L, 0); // unused by caller
            return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(126L, false);
        }

        public class PreTypeInferenceModuleState
        {
            public readonly ISet<Declaration> StillNeedsPreTypeSignature;
            public readonly Stack<Declaration> InFirstPhase = new Stack<Declaration>();
            public readonly Dictionary<string, TopLevelDecl> PreTypeBuiltins;

            public PreTypeInferenceModuleState(List<Declaration> declarations, Dictionary<string, TopLevelDecl> preTypeBuiltins)
            {
                StillNeedsPreTypeSignature = new HashSet<Declaration>(declarations);
                PreTypeBuiltins = preTypeBuiltins;
            }
        }

        private readonly PreTypeInferenceModuleState preTypeInferenceModuleState;

        private PreTypeResolver(ModuleResolver resolver, PreTypeInferenceModuleState preTypeInferenceModuleState)
          : base(resolver)
        {
            this.preTypeInferenceModuleState = preTypeInferenceModuleState;

            scope = new Scope<IVariable>(resolver.Options);
            EnclosingStatementLabels = new Scope<Statement>(resolver.Options);
            dominatingStatementLabels = new Scope<Label>(resolver.Options);
            Constraints = new PreTypeConstraints(this);
        }

        void ScopePushAndReport(IVariable v, string kind, bool assignPreType = true)
        {
            Contract.Requires(scope != null);
            Contract.Requires(v != null);
            Contract.Requires(kind != null);
            if (assignPreType)
            {
                Contract.Assert(v.PreType == null);
                v.PreType = Type2PreType(v.Type, $"type of identifier '{v.Name}'");
                Contract.Assert(v.PreType is not DPreType { Decl: null }); // sanity check that the .Decl field was set
            }
            else
            {
                Contract.Assert(v.PreType != null);
            }
            ScopePushAndReport(scope, v.Name, v, v.Tok, kind);
        }

        void ScopePushExpectSuccess(IVariable v, string kind, bool assignPreType = true)
        {
            Contract.Requires(scope != null);
            Contract.Requires(v != null);
            Contract.Requires(kind != null);
            if (assignPreType)
            {
                Contract.Assert(v.PreType == null);
                v.PreType = Type2PreType(v.Type, $"type of identifier '{v.Name}'");
            }
            else
            {
                Contract.Assert(v.PreType != null);
            }
            var r = ScopePushAndReport(scope, v.Name, v, v.Tok, kind);
            Contract.Assert(r == Scope<IVariable>.PushResult.Success);
        }

        private Scope<Thing>.PushResult ScopePushAndReport<Thing>(Scope<Thing> scope, string name, Thing thing, IToken tok, string kind) where Thing : class
        {
            Contract.Requires(scope != null);
            Contract.Requires(name != null);
            Contract.Requires(thing != null);
            Contract.Requires(tok != null);
            Contract.Requires(kind != null);
            var r = scope.Push(name, thing);
            switch (r)
            {
                case Scope<Thing>.PushResult.Success:
                    break;
                    break;
                case Scope<Thing>.PushResult.Duplicate:
                    ReportError(tok, "Duplicate {0} name: {1}", kind, name);
                    break;
                    break;
                case Scope<Thing>.PushResult.Shadow:
                    ReportWarning(tok, "Shadowed {0} name: {1}", kind, name);
                    break;
                    break;
            }
            return r;
        }

        void AddSubtypeConstraint(PreType super, PreType sub, IToken tok, string errorFormatString)
        {
            Constraints.AddSubtypeConstraint(super, sub, tok, errorFormatString);
        }

        void AddConfirmation(PreTypeConstraints.CommonConfirmationBag check, PreType preType, IToken tok, string errorFormatString, Action onProxyAction = null)
        {
            Constraints.AddConfirmation(check, preType, tok, errorFormatString, onProxyAction);
        }

        void AddComparableConstraint(PreType a, PreType b, IToken tok, bool allowBaseTypeCast, string errorFormatString)
        {
            // A "comparable types" constraint involves a disjunction. This can get gnarly for inference, so the full disjunction
            // is checked post inference. The constraint can, however, be of use during inference, so we also add an approximate
            // constraint (which is set up NOT to generate any error messages by itself, since otherwise errors would be duplicated).
            Constraints.AddGuardedConstraint(() => ApproximateComparableConstraints(a, b, tok, allowBaseTypeCast,
      MutateCSharp.Schemata422.ReplaceStringConstant_13(127L, "(Duplicate error message) ") + errorFormatString, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(128L, false)));
            Constraints.AddConfirmation(tok, () => CheckComparableTypes(a, b, allowBaseTypeCast), () => string.Format(errorFormatString, a, b));
        }

        /// <summary>
        /// This method returns whether or not A and B are comparable types (notated with the constraint A ~~ B).
        ///
        /// The meaning of a comparable constraint
        ///     A ~~ B
        /// is the disjunction
        ///     A ::> B    or    B ::> A
        ///
        /// If "!allowConversion", then "X ::> Y" means
        ///     X :> Y
        ///
        /// If "allowConversion", then "X ::> Y" means
        ///     X' :> Y', or
        ///     X' and Y' are various bv types, or
        ///     X' is int and Y' is in {int, char, bv, ORDINAL, real}.
        /// where X' and Y' are the newtype ancestors of X and Y, respectively.
        /// Additionally, under the legacy option /generalNewtypes:0 (which will be phased out over time), the latter also allows
        /// several additional cases, see IsConversionCompatible.
        /// </summary>
        bool CheckComparableTypes(PreType a, PreType b, bool allowConversion)
        {
            if (PreType.Same(a, b))
            {
                // this allows the case where "a" and "b" are proxies that are equal
                return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(129L, true);
            }
            if (a.Normalize() is not DPreType aa || b.Normalize() is not DPreType bb)
            {
                return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(130L, false);
            }
            if (MutateCSharp.Schemata422.ReplaceBinExprOp_10(131L, () => IsSuperPreTypeOf(aa, bb), () => IsSuperPreTypeOf(bb, aa)))
            {
                return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(137L, true);
            }
            if (!allowConversion)
            {
                return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(138L, false);
            }
            if (MutateCSharp.Schemata422.ReplaceBinExprOp_10(139L, () => IsConversionCompatible(aa, bb), () => IsConversionCompatible(bb, aa)))
            {
                return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(145L, true);
            }
            return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(146L, false);
        }

        bool IsConversionCompatible(DPreType fromType, DPreType toType)
        {
            var fromAncestor = AncestorPreType(fromType);
            var toAncestor = AncestorPreType(toType);

            if (PreType.Same(fromAncestor, toAncestor))
            {
                return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(147L, true);
            }
            var fromFamily = fromAncestor.Decl.Name;
            var toFamily = toAncestor.Decl.Name;
            var toName = toType.Decl.Name;

            if (MutateCSharp.Schemata422.ReplaceBinExprOp_12(155L, () => IsBitvectorName(fromFamily), () => (MutateCSharp.Schemata422.ReplaceBinExprOp_10(149L, () => MutateCSharp.Schemata422.ReplaceBinExprOp_1(148L, toFamily, PreType.TypeNameInt), () => IsBitvectorName(toFamily)))))
            {
                return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(161L, true);
            }
            if (MutateCSharp.Schemata422.ReplaceBinExprOp_12(163L, () => MutateCSharp.Schemata422.ReplaceBinExprOp_1(162L, fromFamily, PreType.TypeNameInt), () => toName is PreType.TypeNameChar or PreType.TypeNameReal or PreType.TypeNameORDINAL))
            {
                return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(169L, true);
            }

            var legacy = !resolver.Options.Get(CommonOptionBag.GeneralNewtypes);
            if (legacy)
            {
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_12(177L, () => MutateCSharp.Schemata422.ReplaceBinExprOp_1(170L, fromFamily, PreType.TypeNameReal), () => (MutateCSharp.Schemata422.ReplaceBinExprOp_10(171L, () => toFamily is PreType.TypeNameInt or PreType.TypeNameChar or PreType.TypeNameORDINAL, () => IsBitvectorName(toFamily)))))
                {
                    return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(183L, true);
                }
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_12(191L, () => MutateCSharp.Schemata422.ReplaceBinExprOp_1(184L, fromFamily, PreType.TypeNameChar), () => (MutateCSharp.Schemata422.ReplaceBinExprOp_10(185L, () => toFamily is PreType.TypeNameInt or PreType.TypeNameORDINAL, () => IsBitvectorName(toFamily)))))
                {
                    return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(197L, true);
                }
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_12(198L, () => IsBitvectorName(fromFamily), () => (toFamily is PreType.TypeNameInt or PreType.TypeNameReal or PreType.TypeNameChar or PreType.TypeNameORDINAL)))
                {
                    return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(204L, true);
                }
            }

            return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(205L, false);
        }

        bool ApproximateComparableConstraints(PreType a, PreType b, IToken tok, bool allowBaseTypeCast, string errorFormatString, bool reportErrors = true)
        {
            // See CheckComparableTypes for the meaning of "comparable type".
            // To decide between these two possibilities, enough information must be available about A and/or B.
            var normalizedA = a.Normalize() as DPreType;
            var normalizedB = b.Normalize() as DPreType;
            if (MutateCSharp.Schemata422.ReplaceBinExprOp_12(215L, () => MutateCSharp.Schemata422.ReplaceBinExprOp_12(208L, () => MutateCSharp.Schemata422.ReplaceBinExprOp_15(206L, normalizedA, null), () => MutateCSharp.Schemata422.ReplaceBinExprOp_15(207L, normalizedB, null)), () => MutateCSharp.Schemata422.ReplaceBinExprOp_16(214L, normalizedA.Decl, normalizedB.Decl)))
            {
                var subArguments = Constraints.GetTypeArgumentsForSuperType(normalizedB.Decl, normalizedA, allowBaseTypeCast);
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_17(221L, subArguments, null))
                {
                    // use B :> A
                    var aa = new DPreType(normalizedB.Decl, subArguments, normalizedA.PrintablePreType);
                    Constraints.DebugPrint($"    DEBUG: turning ~~ into {b} :> {aa}");
                    Constraints.AddSubtypeConstraint(b, aa, tok, errorFormatString, null, reportErrors);
                    return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(222L, true);
                }
                subArguments = Constraints.GetTypeArgumentsForSuperType(normalizedA.Decl, normalizedB, allowBaseTypeCast);
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_17(223L, subArguments, null))
                {
                    // use A :> B
                    var bb = new DPreType(normalizedA.Decl, subArguments, normalizedB.PrintablePreType);
                    Constraints.DebugPrint($"    DEBUG: turning ~~ into {a} :> {bb}");
                    Constraints.AddSubtypeConstraint(a, bb, tok, errorFormatString, null, reportErrors);
                    return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(224L, true);
                }

                if (MutateCSharp.Schemata422.ReplaceBinExprOp_12(231L, () => allowBaseTypeCast, () => (MutateCSharp.Schemata422.ReplaceBinExprOp_10(225L, () => IsConversionCompatible(normalizedA, normalizedB), () => IsConversionCompatible(normalizedB, normalizedA)))))
                {
                    return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(237L, true);
                }

                // neither A :> B nor B :> A is possible
                if (reportErrors)
                {
                    ReportError(tok, errorFormatString, a, b);
                }
                return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(238L, true);
            }

            if (!allowBaseTypeCast)
            {
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_10(253L, () => (MutateCSharp.Schemata422.ReplaceBinExprOp_12(240L, () => MutateCSharp.Schemata422.ReplaceBinExprOp_15(239L, normalizedA, null), () => normalizedA.IsLeafType())), () => (MutateCSharp.Schemata422.ReplaceBinExprOp_12(247L, () => MutateCSharp.Schemata422.ReplaceBinExprOp_15(246L, normalizedB, null), () => normalizedB.IsRootType()))))
                {
                    // use B :> A
                    Constraints.DebugPrint($"    DEBUG: turning ~~ into {b} :> {a}");
                    Constraints.AddSubtypeConstraint(b, a, tok, errorFormatString, null, reportErrors);
                    return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(259L, true);
                }
                else if (MutateCSharp.Schemata422.ReplaceBinExprOp_10(274L, () => (MutateCSharp.Schemata422.ReplaceBinExprOp_12(261L, () => MutateCSharp.Schemata422.ReplaceBinExprOp_15(260L, normalizedA, null), () => normalizedA.IsRootType())), () => (MutateCSharp.Schemata422.ReplaceBinExprOp_12(268L, () => MutateCSharp.Schemata422.ReplaceBinExprOp_15(267L, normalizedB, null), () => normalizedB.IsLeafType()))))
                {
                    // use A :> B
                    Constraints.DebugPrint($"    DEBUG: turning ~~ into {a} :> {b}");
                    Constraints.AddSubtypeConstraint(a, b, tok, errorFormatString, null, reportErrors);
                    return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(280L, true);
                }
            }

            if (MutateCSharp.Schemata422.ReplaceBinExprOp_12(290L, () => MutateCSharp.Schemata422.ReplaceBinExprOp_12(283L, () => MutateCSharp.Schemata422.ReplaceBinExprOp_15(281L, normalizedA, null), () => MutateCSharp.Schemata422.ReplaceBinExprOp_15(282L, normalizedB, null)), () => MutateCSharp.Schemata422.ReplaceBinExprOp_18(289L, normalizedA.Decl, normalizedB.Decl)))
            {
                // Here is where we approximate the answer. We'll only constrain that variant type parameters are *comparable*, not that
                // they are consistently comparable. For example, if ptA is C<A0, A1> and ptB is C<B0, A1> and C is declared as C<+T, +U>,
                // then "comparable types" says
                //     (A0 ::> B0 and A1 ::> B1)  or  (B0 ::> A0 and B1 ::> A1)
                // but we will use only
                //     (A0 ::> B0 or B0 ::> A0)  and  (A1 ::> B1 or B1 ::> A1)
                Contract.Assert(normalizedA.Decl.TypeArgs.Count == normalizedA.Arguments.Count);
                Contract.Assert(normalizedA.Arguments.Count == normalizedB.Arguments.Count);
                for (var i = MutateCSharp.Schemata422.ReplaceNumericConstant_4(296L, 0); MutateCSharp.Schemata422.ReplaceBinExprOp_9(300L, i, normalizedA.Decl.TypeArgs.Count); MutateCSharp.Schemata422.ReplacePostfixUnaryExprOp_6(305L, ref i))
                {
                    var aa = normalizedA.Arguments[i];
                    var bb = normalizedB.Arguments[i];
                    var msgFormat = $"{errorFormatString} (type argument {i})"; // TODO: this should be improved to use ptA/ptB
                    if (MutateCSharp.Schemata422.ReplaceBinExprOp_19(306L, normalizedA.Decl.TypeArgs[i].Variance, TypeParameter.TPVariance.Non))
                    {
                        Constraints.AddEqualityConstraint(aa, bb, tok, msgFormat, null, reportErrors);
                    }
                    else
                    {
                        Constraints.AddGuardedConstraint(() => ApproximateComparableConstraints(aa, bb, tok, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(307L, false), msgFormat, reportErrors));
                    }
                }

                return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(308L, true);
            }

            // not enough information to determine
            return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(309L, false);
        }

        /// <summary>
        /// For every declaration in "declarations", resolve names and determine pre-types.
        /// </summary>
        public static void ResolveDeclarations(List<TopLevelDecl> declarations, ModuleResolver resolver, bool firstPhaseOnly = false)
        {
            // Each (top-level or member) declaration is done in two phases.
            //
            // The goal of the first phase is to fill in the pre-types in the declaration's signature (and, if the declaration is a
            // type with a base type or with parent traits, inherit the members from the base and parent types). For many declarations,
            // this is as easy as calling PreType2Type on each type that appears in the declaration's signature.
            // Since the base type of a newtype or subset type and the type of a const may be omitted in the program text,
            // obtaining the pre-type for these 3 declarations requires doing resolution. It is not clear a-priori which
            // order to process the (first phase of the) declarations in, so that the necessary pre-type information is
            // available when the first phase of a declaration needs it. Therefore, the order is determined lazily.
            //
            // In more detail, for this first phase, the declarations are processed in the given order. When such processing
            // is started for a declaration, the declaration is pushed onto a stack, and when the processing of the first
            // phase is completed, the declaration is popped off the stack and added to a set of first-phase-finished
            // declarations. If the processing requires pre-type information for a declaration whose processing has not
            // yet started, processing continues recursively with it. If the processing for the other declaration is ongoing,
            // then a cyclic-dependency error is reported.
            //
            // When the first-phase processing is finished for all the declarations, the second-phase processing is done
            // for each declaration, in the order given.

            var allDeclarations = AllTopLevelOrMemberDeclarations(declarations).ToList();
            var preTypeInferenceModuleState = new PreTypeInferenceModuleState(allDeclarations, resolver.SystemModuleManager.PreTypeBuiltins);
            foreach (var d in allDeclarations)
            {
                Contract.Assert(resolver.VisibleInScope(d));
                ResolvePreTypeSignature(d, preTypeInferenceModuleState, resolver);
            }

            if (!firstPhaseOnly)
            {
                var basicPreTypeResolver = new PreTypeResolver(resolver, preTypeInferenceModuleState);
                foreach (var d in allDeclarations)
                {
                    basicPreTypeResolver.ResolveDeclarationBody(d);
                }
                basicPreTypeResolver.Constraints.AssertThatStateIsClear();
            }
        }

        void ResolvePreTypeSignature(Declaration d)
        {
            ResolvePreTypeSignature(d, preTypeInferenceModuleState, resolver);
        }

        /// <summary>
        /// This method resolves the pre-types the signature of declaration "d".
        /// If the declaration is a newtype (and thus has a base type) or extends some traits, then the members from the base type
        /// and parent types are inherited.
        /// </summary>
        private static void ResolvePreTypeSignature(Declaration d, PreTypeInferenceModuleState preTypeInferenceModuleState, ModuleResolver resolver)
        {
            var preTypeResolver = new PreTypeResolver(resolver, preTypeInferenceModuleState);
            var previousErrorCount = preTypeResolver.ErrorCount;

            // The "allTypeParameters" scope is stored in "resolver", and there's only one such "resolver". Since
            // "ResolvePreTypeSignature" is recursive, a simple "PushMarker()" would still leave previous type parameters
            // in the scope. Instead, we create a whole new "Scope<TypeParameter>" here. (This makes the "PushMarker()"
            // and "PopMarker()" unnecessary, but they're included here for good style.)
            var oldAllTypeParameters = resolver.allTypeParameters;
            resolver.allTypeParameters = new Scope<TypeParameter>(resolver.Options);
            resolver.allTypeParameters.PushMarker();

            if (d is TopLevelDecl topLevelDecl)
            {
                preTypeResolver.ResolveTypeParameters(topLevelDecl.TypeArgs, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(310L, false), topLevelDecl);
            }
            else
            {
                var memberDecl = (MemberDecl)d;
                preTypeResolver.ResolveTypeParameters(memberDecl.EnclosingClass.TypeArgs, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(311L, false), memberDecl.EnclosingClass);
                if (memberDecl is Method method)
                {
                    preTypeResolver.ResolveTypeParameters(method.TypeArgs, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(312L, false), method);
                }
                else if (memberDecl is Function function)
                {
                    preTypeResolver.ResolveTypeParameters(function.TypeArgs, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(313L, false), function);
                }
            }

            preTypeResolver.ResolveDeclarationSignature(d);
            preTypeResolver.Constraints.AssertThatStateIsClear();

            resolver.allTypeParameters.PopMarker();
            resolver.allTypeParameters = oldAllTypeParameters;

            if (d is TopLevelDeclWithMembers topLevelDeclWithMembers)
            {
                DPreType basePreType = null;
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_5(314L, preTypeResolver.ErrorCount, previousErrorCount) && topLevelDeclWithMembers is NewtypeDecl newtypeDecl)
                {
                    basePreType = newtypeDecl.BasePreType.Normalize() as DPreType;
                }
                resolver.RegisterInheritedMembers(topLevelDeclWithMembers, basePreType);
            }
        }

        static IEnumerable<Declaration> AllTopLevelOrMemberDeclarations(List<TopLevelDecl> declarations)
        {
            foreach (var d in declarations)
            {
                yield return d;
                /*
                if (d is ClassLikeDecl { NonNullTypeDecl: { } nonNullTypeDecl }) {
                  yield return nonNullTypeDecl;
                }
                */
                if (d is TopLevelDeclWithMembers cl)
                {
                    foreach (var member in cl.Members)
                    {
                        yield return member;
                    }
                }
            }

            yield break;
        }

        /// <summary>
        /// Assumes that the type parameters in scope for "d" have been pushed.
        /// </summary>
        public void ResolveDeclarationSignature(Declaration d)
        {
            Contract.Requires(d is TopLevelDecl or MemberDecl);

            if (!preTypeInferenceModuleState.StillNeedsPreTypeSignature.Contains(d))
            {
                // already processed
                return;
            }

            if (preTypeInferenceModuleState.InFirstPhase.Contains(d))
            {
                var cycle = Util.Comma(MutateCSharp.Schemata422.ReplaceStringConstant_13(319L, " -> "), preTypeInferenceModuleState.InFirstPhase, d => d.ToString());
                ReportError(d, $"Cyclic dependency among declarations: {d} -> {cycle}");
            }
            else
            {
                preTypeInferenceModuleState.InFirstPhase.Push(d);
                FillInPreTypesInSignature(d);
                preTypeInferenceModuleState.InFirstPhase.Pop();
            }

            preTypeInferenceModuleState.StillNeedsPreTypeSignature.Remove(d);
        }

        /// <summary>
        /// Assumes the type parameters in scope for "declaration" have been pushed.
        /// </summary>
        public void FillInPreTypesInSignature(Declaration declaration)
        {
            PreType CreateTemporaryPreTypeProxy()
            {
                return CreatePreTypeProxy(MutateCSharp.Schemata422.ReplaceStringConstant_13(320L, "temporary proxy until after cyclicity tests have completed"));
            }

            void ComputePreTypeField(Field field)
            {
                Contract.Assume(field.PreType == null); // precondition
                field.PreType = CreateTemporaryPreTypeProxy();
                field.PreType = Type2PreType(field.Type);
                if (field is ConstantField cfield)
                {
                    var parent = (TopLevelDeclWithMembers)cfield.EnclosingClass;
                    Contract.Assert(currentClass == null);
                    currentClass = parent;

                    ResolveConstRHS(cfield, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(321L, true));

                    Contract.Assert(currentClass == parent);
                    currentClass = null;
                }
            }

            void ComputePreTypeFormal(Formal formal)
            {
                Contract.Assume(formal.PreType == null); // precondition
                formal.PreType = CreateTemporaryPreTypeProxy();
                formal.PreType = Type2PreType(formal.Type);
            }

            void ComputePreTypeFunction(Function function)
            {
                function.Ins.ForEach(ComputePreTypeFormal);
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_20(322L, function.Result, null))
                {
                    ComputePreTypeFormal(function.Result);
                }
                else if (MutateCSharp.Schemata422.ReplaceBinExprOp_21(323L, function.ByMethodDecl, null))
                {
                    // The by-method out-parameter is not the same as the one given in the function declaration, since the
                    // function declaration didn't give one.
                    function.ByMethodDecl.Outs.ForEach(ComputePreTypeFormal);
                }
                function.ResultPreType = CreateTemporaryPreTypeProxy();
                function.ResultPreType = Type2PreType(function.ResultType);
            }

            void ComputePreTypeMethod(Method method)
            {
                method.Ins.ForEach(ComputePreTypeFormal);
                method.Outs.ForEach(ComputePreTypeFormal);
            }

            if (declaration is SubsetTypeDecl std)
            {
                std.Var.PreType = CreateTemporaryPreTypeProxy();
                std.Var.PreType = Type2PreType(std.Var.Type);
                ResolveConstraintAndWitness(std, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(324L, true));
            }
            else if (declaration is NewtypeDecl nd)
            {
                nd.BasePreType = CreateTemporaryPreTypeProxy();
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_22(325L, nd.Var, null))
                {
                    nd.Var.PreType = nd.BasePreType;
                }
                nd.BasePreType = Type2PreType(nd.BaseType);
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_22(326L, nd.Var, null))
                {
                    Contract.Assert(object.ReferenceEquals(nd.BaseType, nd.Var.Type));
                    nd.Var.PreType = nd.BasePreType;
                }
                var onProxyAction = () =>
                {
                    resolver.ReportError(ResolutionErrors.ErrorId.r_newtype_base_undetermined, nd.tok,
                      $"base type of {nd.WhatKindAndName} is not fully determined; add an explicit type for bound variable '{nd.Var.Name}'");
                };
                if (resolver.Options.Get(CommonOptionBag.GeneralNewtypes))
                {
                    AddConfirmation(PreTypeConstraints.CommonConfirmationBag.IsNewtypeBaseTypeGeneral, nd.BasePreType, nd.tok,
                      $"a newtype ('{nd.Name}') must be based on some non-reference, non-trait, non-arrow, non-ORDINAL, non-datatype type (got {{0}})",
                      onProxyAction);
                }
                else
                {
                    AddConfirmation(PreTypeConstraints.CommonConfirmationBag.IsNewtypeBaseTypeLegacy, nd.BasePreType, nd.tok,
                      $"a newtype ('{nd.Name}') must be based on some numeric type (got {{0}})", onProxyAction);
                }
                ResolveConstraintAndWitness(nd, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(327L, true));

            }
            else if (declaration is IteratorDecl iter)
            {
                // Note, iter.Ins are reused with the parameters of the iterator's automatically generated _ctor, and
                // the iter.OutsFields are shared with the automatically generated fields of the iterator class. To avoid
                // computing their pre-types twice, we omit their pre-type computations here and instead do them in
                // the _ctor Method and for each Field of the iterator class.
                iter.Outs.ForEach(ComputePreTypeFormal);
            }
            else if (declaration is DatatypeDecl dtd)
            {
                foreach (var ctor in dtd.Ctors)
                {
                    ctor.Formals.ForEach(ComputePreTypeFormal);
                    ComputePreTypeField(ctor.QueryField);
                    foreach (var dtor in ctor.Destructors)
                    {
                        // The following "if" condition makes sure ComputePreTypeField is called just once (since a destructor
                        // can be shared among several constructors).
                        if (MutateCSharp.Schemata422.ReplaceBinExprOp_23(332L, dtor.EnclosingCtors[MutateCSharp.Schemata422.ReplaceNumericConstant_4(328L, 0)], ctor))
                        {
                            ComputePreTypeField(dtor);
                        }
                    }
                }
            }
            else if (declaration is TopLevelDeclWithMembers or ValuetypeDecl or TypeSynonymDecl or ModuleDecl)
            {
                // nothing to do
            }
            else if (declaration is Field field)
            {
                ComputePreTypeField(field);
            }
            else if (declaration is Function function)
            {
                if (function.ResultType is SelfType)
                {
                    // This is a special case that, with the legacy type inference, handled the .Rotate{Left, Right} method of
                    // bitvector types. That's now handled in a different way, which does not use SelfType.
                }
                else
                {
                    ComputePreTypeFunction(function);
                    if (function is ExtremePredicate { PrefixPredicate: { } prefixPredicate })
                    {
                        ComputePreTypeFunction(prefixPredicate);
                    }
                }
            }
            else if (declaration is Method method)
            {
                ComputePreTypeMethod(method);
                if (method is ExtremeLemma { PrefixLemma: { } prefixLemma })
                {
                    ComputePreTypeMethod(prefixLemma);
                }
            }
            else
            {
                Contract.Assert(false); // unexpected declaration
            }
        }

        public void ResolveDeclarationBody(Declaration d)
        {
            Contract.Requires(d is TopLevelDecl or MemberDecl);

            resolver.allTypeParameters.PushMarker();

            if (d is TopLevelDecl topLevelDecl)
            {
                ResolveTypeParameters(topLevelDecl.TypeArgs, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(333L, false), topLevelDecl);
                ResolveTopLevelDeclaration(topLevelDecl);
            }
            else
            {
                var member = (MemberDecl)d;
                var parent = (TopLevelDeclWithMembers)member.EnclosingClass;
                ResolveTypeParameters(parent.TypeArgs, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(334L, false), parent);
                Contract.Assert(currentClass == null);
                currentClass = parent;
                ResolveMember(member);
                Contract.Assert(currentClass == parent);
                currentClass = null;
            }

            resolver.allTypeParameters.PopMarker();
        }

        /// <summary>
        /// Resolve declaration "d".
        ///
        /// This method assumes type parameters have been pushed.
        /// </summary>
        private void ResolveTopLevelDeclaration(TopLevelDecl d)
        {
            if (d is not IteratorDecl)
            {
                // Note, attributes of iterators are resolved by ResolveIterator, after registering any names in the iterator signature
                scope.PushMarker();
                Contract.Assert(currentClass == null);
                scope.AllowInstance = MutateCSharp.Schemata422.ReplaceBooleanConstant_0(335L, false);
                ResolveAttributes(d, new ResolutionContext(new NoContext(d.EnclosingModuleDefinition), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(336L, false)), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(337L, true));
                scope.PopMarker();
            }

            if (d is NewtypeDecl newtypeDecl)
            {
                ResolveConstraintAndWitness(newtypeDecl, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(338L, false));
            }
            else if (d is SubsetTypeDecl subsetTypeDecl)
            {
                ResolveConstraintAndWitness(subsetTypeDecl, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(339L, false));
            }
            else if (d is IteratorDecl iter)
            {
                // Note, attributes of iterators are resolved by ResolveIterator, after registering any names in the iterator signature.
                // The following method generates the iterator's members, which in turn are resolved below.
                ResolveIterator(iter);
            }
            else if (d is DatatypeDecl dt)
            {
                // resolve any default parameters
                foreach (var ctor in dt.Ctors)
                {
                    scope.PushMarker();
                    scope.AllowInstance = MutateCSharp.Schemata422.ReplaceBooleanConstant_0(340L, false);
                    ctor.Formals.ForEach(p => ScopePushAndReport(p, MutateCSharp.Schemata422.ReplaceStringConstant_13(341L, "destructor"), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(342L, false)));
                    ResolveAttributes(ctor, new ResolutionContext(new NoContext(d.EnclosingModuleDefinition), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(343L, false)), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(344L, true));
                    ResolveParameterDefaultValues(ctor.Formals, dt);
                    scope.PopMarker();
                }
            }
        }

        void ResolveTypeParameters(List<TypeParameter> tparams, bool emitErrors, TypeParameter.ParentType parent)
        {
            Contract.Requires(tparams != null);
            Contract.Requires(parent != null);
            // push non-duplicated type parameter names
            int index = MutateCSharp.Schemata422.ReplaceNumericConstant_4(345L, 0);
            foreach (TypeParameter tp in tparams)
            {
                if (emitErrors)
                {
                    // we're seeing this TypeParameter for the first time
                    tp.Parent = parent;
                    tp.PositionalIndex = index;
                }
                var r = resolver.allTypeParameters.Push(tp.Name, tp);
                if (emitErrors)
                {
                    if (MutateCSharp.Schemata422.ReplaceBinExprOp_24(349L, r, Scope<TypeParameter>.PushResult.Duplicate))
                    {
                        ReportError(tp, MutateCSharp.Schemata422.ReplaceStringConstant_13(350L, "Duplicate type-parameter name: {0}"), tp.Name);
                    }
                    else if (MutateCSharp.Schemata422.ReplaceBinExprOp_24(351L, r, Scope<TypeParameter>.PushResult.Shadow))
                    {
                        ReportWarning(tp.tok, MutateCSharp.Schemata422.ReplaceStringConstant_13(352L, "Shadowed type-parameter name: {0}"), tp.Name);
                    }
                }
            }
        }

        public void ResolveAttributes(IAttributeBearingDeclaration attributeHost, ResolutionContext opts, bool solveConstraints)
        {
            Contract.Requires(attributeHost != null);
            Contract.Requires(opts != null);

            // order does not matter much for resolution, so resolve them in reverse order
            foreach (var attr in attributeHost.Attributes.AsEnumerable())
            {
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_25(353L, attributeHost, null) && attr is UserSuppliedAttributes usa)
                {
#if TODO
          usa.Recognized = resolver.IsRecognizedAttribute(usa, attributeHost); // TODO: this could be done in a later resolution pass
#endif
                }
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_26(354L, attr.Args, null))
                {
                    foreach (var arg in attr.Args)
                    {
                        if (MutateCSharp.Schemata422.ReplaceBinExprOp_12(356L, () => Attributes.Contains(attributeHost.Attributes, MutateCSharp.Schemata422.ReplaceStringConstant_13(355L, "opaque_reveal")), () => attr.Name is "revealedFunction") && arg is NameSegment nameSegment)
                        {
                            ResolveNameSegment(nameSegment, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(362L, true), null, opts, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(363L, false), specialOpaqueHackAllowance: MutateCSharp.Schemata422.ReplaceBooleanConstant_0(364L, true));
                        }
                        else
                        {
                            ResolveExpression(arg, opts);
                        }
                    }
                    if (solveConstraints)
                    {
                        Constraints.SolveAllTypeConstraints($"attribute of {attributeHost.ToString()}");
                    }
                }
            }
        }

        void ResolveConstraintAndWitness(RedirectingTypeDecl dd, bool initialResolutionPass)
        {
            Contract.Requires(dd != null);
            Contract.Requires(dd.Constraint != null);

            if (MutateCSharp.Schemata422.ReplaceBinExprOp_27(365L, dd.Var, null))
            {
                if (initialResolutionPass)
                {
                    Constraints.SolveAllTypeConstraints($"{dd.WhatKind} '{dd.Name}' constraint");
                }
            }
            else
            {
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_28(366L, () => initialResolutionPass, () => dd.Var.Type is TypeProxy))
                {
                    scope.PushMarker();
                    scope.AllowInstance = MutateCSharp.Schemata422.ReplaceBooleanConstant_0(372L, false);
                    ScopePushExpectSuccess(dd.Var, dd.WhatKind + MutateCSharp.Schemata422.ReplaceStringConstant_13(373L, " variable"), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(374L, false));
                    ResolveExpression(dd.Constraint, new ResolutionContext(new CodeContextWrapper(dd, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(375L, true)), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(376L, false)));
                    ConstrainTypeExprBool(dd.Constraint, dd.WhatKind + MutateCSharp.Schemata422.ReplaceStringConstant_13(377L, " constraint must be of type bool (instead got {0})"));
                    scope.PopMarker();
                    Constraints.SolveAllTypeConstraints($"{dd.WhatKind} '{dd.Name}' constraint");
                }
                else
                {
                    Constraints.SolveAllTypeConstraints($"{dd.WhatKind} '{dd.Name}' constraint");
                }
            }

            if (MutateCSharp.Schemata422.ReplaceBinExprOp_12(379L, () => !initialResolutionPass, () => MutateCSharp.Schemata422.ReplaceBinExprOp_29(378L, dd.Witness, null)))
            {
                var codeContext = new CodeContextWrapper(dd, MutateCSharp.Schemata422.ReplaceBinExprOp_30(385L, dd.WitnessKind, SubsetTypeDecl.WKind.Ghost));
                scope.PushMarker();
                scope.AllowInstance = MutateCSharp.Schemata422.ReplaceBooleanConstant_0(386L, false);
                ResolveExpression(dd.Witness, new ResolutionContext(codeContext, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(387L, false)));
                scope.PopMarker();
                AddSubtypeConstraint(dd.Var.PreType, dd.Witness.PreType, dd.Witness.tok, MutateCSharp.Schemata422.ReplaceStringConstant_13(388L, "witness expression must have type '{0}' (got '{1}')"));
                Constraints.SolveAllTypeConstraints($"{dd.WhatKind} '{dd.Name}' witness");
            }
        }

        /// <summary>
        /// Assumes the type parameters in scope for "cfield" have been pushed.
        /// Assumes that "currentClass" has been set to the parent of "cfield".
        /// </summary>
        void ResolveConstRHS(ConstantField cfield, bool initialResolutionPass)
        {
            if (MutateCSharp.Schemata422.ReplaceBinExprOp_12(396L, () => MutateCSharp.Schemata422.ReplaceBinExprOp_29(389L, cfield.Rhs, null), () => MutateCSharp.Schemata422.ReplaceBinExprOp_28(390L, () => initialResolutionPass, () => cfield.Type is TypeProxy)))
            {
                var opts = new ResolutionContext(cfield, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(402L, false));
                scope.PushMarker();
                if (cfield.IsStatic)
                {
                    scope.AllowInstance = MutateCSharp.Schemata422.ReplaceBooleanConstant_0(403L, false);
                }
                ResolveExpression(cfield.Rhs, opts);
                scope.PopMarker();
                AddSubtypeConstraint(cfield.PreType, cfield.Rhs.PreType, cfield.Tok, MutateCSharp.Schemata422.ReplaceStringConstant_13(404L, "RHS (of type {1}) not assignable to LHS (of type {0})"));
                Constraints.SolveAllTypeConstraints($"{cfield.WhatKind} '{cfield.Name}' constraint");
            }
        }

        void ResolveParameterDefaultValues(List<Formal> formals, ICodeContext codeContext)
        {
            Contract.Requires(formals != null);
            Contract.Requires(codeContext != null);

            var dependencies = new Graph<IVariable>();
            var allowMoreRequiredParameters = MutateCSharp.Schemata422.ReplaceBooleanConstant_0(405L, true);
            var allowNamelessParameters = MutateCSharp.Schemata422.ReplaceBooleanConstant_0(406L, true);
            foreach (var formal in formals)
            {
                var d = formal.DefaultValue;
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_29(407L, d, null))
                {
                    allowMoreRequiredParameters = MutateCSharp.Schemata422.ReplaceBooleanConstant_0(408L, false);
                    ResolveExpression(d, new ResolutionContext(codeContext, MutateCSharp.Schemata422.ReplaceBinExprOp_10(409L, () => codeContext is TwoStateFunction, () => codeContext is TwoStateLemma)));
                    AddSubtypeConstraint(Type2PreType(formal.Type), d.PreType, d.tok, MutateCSharp.Schemata422.ReplaceStringConstant_13(415L, "default-value expression (of type '{1}') is not assignable to formal (of type '{0}')"));
                    foreach (var v in ModuleResolver.FreeVariables(d))
                    {
                        dependencies.AddEdge(formal, v);
                    }
                }
                else if (!allowMoreRequiredParameters)
                {
                    ReportError(formal.tok, MutateCSharp.Schemata422.ReplaceStringConstant_13(416L, "a required parameter must precede all optional parameters"));
                }
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_12(417L, () => !allowNamelessParameters, () => !formal.HasName))
                {
                    ReportError(formal.tok, MutateCSharp.Schemata422.ReplaceStringConstant_13(423L, "a nameless parameter must precede all nameonly parameters"));
                }
                if (formal.IsNameOnly)
                {
                    allowNamelessParameters = MutateCSharp.Schemata422.ReplaceBooleanConstant_0(424L, false);
                }
            }
            Constraints.SolveAllTypeConstraints($"parameter default values of {codeContext.FullSanitizedName}");

            foreach (var cycle in dependencies.AllCycles())
            {
                var cy = Util.Comma(MutateCSharp.Schemata422.ReplaceStringConstant_13(425L, " -> "), cycle, v => v.Name) + MutateCSharp.Schemata422.ReplaceStringConstant_13(426L, " -> ") + cycle[MutateCSharp.Schemata422.ReplaceNumericConstant_4(427L, 0)].Name;
                ReportError(cycle[MutateCSharp.Schemata422.ReplaceNumericConstant_4(431L, 0)].Tok, $"default-value expressions for parameters contain a cycle: {cy}");
            }
        }

        /// <summary>
        /// Resolve declaration "member", assuming that the member's pre-type signature has already been resolved.
        ///
        /// Type constraints are solved here.
        ///
        /// This method assumes type parameters of the enclosing type have been pushed.
        /// Also assumes that "currentClass" has been set to the parent of "member".
        /// </summary>
        void ResolveMember(MemberDecl member)
        {
            Contract.Requires(member != null);
            Contract.Requires(currentClass != null);

            if (member is ConstantField cfield)
            {
                scope.PushMarker();
                if (cfield.IsStatic)
                {
                    scope.AllowInstance = MutateCSharp.Schemata422.ReplaceBooleanConstant_0(435L, false);
                }
                ResolveAttributes(member, new ResolutionContext(new NoContext(currentClass.EnclosingModuleDefinition), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(436L, false)), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(437L, true));
                scope.PopMarker();
                ResolveConstRHS(cfield, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(438L, false));

            }
            else if (member is Field)
            {
                ResolveAttributes(member, new ResolutionContext(new NoContext(currentClass.EnclosingModuleDefinition), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(439L, false)), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(440L, true));

            }
            else if (member is Function f)
            {
                var ec = ErrorCount;
                resolver.allTypeParameters.PushMarker();
                ResolveTypeParameters(f.TypeArgs, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(441L, false), f);
                ResolveFunction(f);
                resolver.allTypeParameters.PopMarker();

                if (f is ExtremePredicate extremePredicate && extremePredicate.PrefixPredicate != null && MutateCSharp.Schemata422.ReplaceBinExprOp_5(442L, ec, ErrorCount))
                {
                    var ff = extremePredicate.PrefixPredicate;
                    resolver.allTypeParameters.PushMarker();
                    ResolveTypeParameters(ff.TypeArgs, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(447L, false), ff);
                    ResolveFunction(ff);
                    resolver.allTypeParameters.PopMarker();
                }

            }
            else if (member is Method m)
            {
                var ec = ErrorCount;
                resolver.allTypeParameters.PushMarker();
                ResolveTypeParameters(m.TypeArgs, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(448L, false), m);
                ResolveMethod(m);
                resolver.allTypeParameters.PopMarker();

                if (m is ExtremeLemma em && em.PrefixLemma != null && MutateCSharp.Schemata422.ReplaceBinExprOp_5(449L, ec, ErrorCount))
                {
                    var mm = em.PrefixLemma;
                    resolver.allTypeParameters.PushMarker();
                    ResolveTypeParameters(mm.TypeArgs, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(454L, false), mm);
                    ResolveMethod(mm);
                    resolver.allTypeParameters.PopMarker();
                }

            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected member type
            }
        }

        /// <summary>
        /// Assumes type parameters have already been pushed
        /// </summary>
        void ResolveIterator(IteratorDecl iter)
        {
            Contract.Requires(iter != null);
            Contract.Requires(currentClass != null);
            Contract.Ensures(currentClass == null);

            var initialErrorCount = ErrorCount;

            // Add in-parameters to the scope, but don't care about any duplication errors, since they have already been reported
            scope.PushMarker();
            scope.AllowInstance = MutateCSharp.Schemata422.ReplaceBooleanConstant_0(455L, false);  // disallow 'this' from use, which means that the special fields and methods added are not accessible in the syntactically given spec
            iter.Ins.ForEach(p => ScopePushAndReport(p, MutateCSharp.Schemata422.ReplaceStringConstant_13(456L, "in-parameter"), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(457L, false)));
            ResolveParameterDefaultValues(iter.Ins, iter);

            // In-parameters (but not "this" and yield parameters) are in scope for the iterator's attributes.
            ResolveAttributes(iter, new ResolutionContext(iter, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(458L, false)), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(459L, true));

            // Start resolving specification...
            // we start with the decreases clause, because the _decreases<n> fields were only given type proxies before; we'll know
            // the types only after resolving the decreases clause (and it may be that some of resolution has already seen uses of
            // these fields; so, with no further ado, here we go
            Contract.Assert(iter.Decreases.Expressions.Count == iter.DecreasesFields.Count);
            ResolveAttributes(iter.Decreases, new ResolutionContext(iter, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(460L, false)), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(461L, false));
            for (int i = MutateCSharp.Schemata422.ReplaceNumericConstant_4(462L, 0); MutateCSharp.Schemata422.ReplaceBinExprOp_9(466L, i, iter.Decreases.Expressions.Count); MutateCSharp.Schemata422.ReplacePostfixUnaryExprOp_6(471L, ref i))
            {
                var e = iter.Decreases.Expressions[i];
                ResolveExpression(e, new ResolutionContext(iter, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(472L, false)));
                // any type is fine, but associate this type with the corresponding _decreases<n> field
                var d = iter.DecreasesFields[i];
                // If the following type constraint does not hold, then: Bummer, there was a use--and a bad use--of the field before, so this won't be the best of error messages
                AddSubtypeConstraint(d.PreType, e.PreType, e.tok, MutateCSharp.Schemata422.ReplaceStringConstant_13(473L, "type of field '") + d.Name + MutateCSharp.Schemata422.ReplaceStringConstant_13(474L, "' is {1}, but has been constrained elsewhere to be of type {0}"));
            }
            foreach (FrameExpression fe in iter.Reads.Expressions)
            {
                ResolveFrameExpression(fe, FrameExpressionUse.Reads, iter);
            }
            ResolveAttributes(iter.Modifies, new ResolutionContext(iter, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(475L, false)), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(476L, false));
            foreach (FrameExpression fe in iter.Modifies.Expressions)
            {
                ResolveFrameExpression(fe, FrameExpressionUse.Modifies, iter);
            }
            foreach (AttributedExpression e in iter.Requires)
            {
                ResolveAttributes(e, new ResolutionContext(iter, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(477L, false)), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(478L, false));
                ResolveExpression(e.E, new ResolutionContext(iter, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(479L, false)));
                ConstrainTypeExprBool(e.E, MutateCSharp.Schemata422.ReplaceStringConstant_13(480L, "Precondition must be a boolean (got {0})"));
            }

            scope.PopMarker();  // for the in-parameters

            // We resolve the rest of the specification in an instance context.  So mentions of the in- or yield-parameters
            // get resolved as field dereferences (with an implicit "this")
            scope.PushMarker();
            currentClass = iter;
            Contract.Assert(scope.AllowInstance);

            foreach (AttributedExpression e in iter.YieldRequires)
            {
                ResolveAttributes(e, new ResolutionContext(iter, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(481L, false)), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(482L, false));
                ResolveExpression(e.E, new ResolutionContext(iter, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(483L, false)));
                ConstrainTypeExprBool(e.E, MutateCSharp.Schemata422.ReplaceStringConstant_13(484L, "Yield precondition must be a boolean (got {0})"));
            }
            foreach (AttributedExpression e in iter.YieldEnsures)
            {
                ResolveAttributes(e, new ResolutionContext(iter, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(485L, true)), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(486L, false));
                ResolveExpression(e.E, new ResolutionContext(iter, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(487L, true)));
                ConstrainTypeExprBool(e.E, MutateCSharp.Schemata422.ReplaceStringConstant_13(488L, "Yield postcondition must be a boolean (got {0})"));
            }
            foreach (AttributedExpression e in iter.Ensures)
            {
                ResolveAttributes(e, new ResolutionContext(iter, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(489L, true)), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(490L, false));
                ResolveExpression(e.E, new ResolutionContext(iter, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(491L, true)));
                ConstrainTypeExprBool(e.E, MutateCSharp.Schemata422.ReplaceStringConstant_13(492L, "Postcondition must be a boolean (got {0})"));
            }
            Constraints.SolveAllTypeConstraints($"specification of iterator '{iter.Name}'");

            var postSpecErrorCount = ErrorCount;

            // Resolve body
            if (MutateCSharp.Schemata422.ReplaceBinExprOp_31(493L, iter.Body, null))
            {
                dominatingStatementLabels.PushMarker();
                foreach (var req in iter.Requires)
                {
                    if (MutateCSharp.Schemata422.ReplaceBinExprOp_32(494L, req.Label, null))
                    {
                        if (MutateCSharp.Schemata422.ReplaceBinExprOp_33(495L, dominatingStatementLabels.Find(req.Label.Name), null))
                        {
                            ReportError(req.Label.Tok, MutateCSharp.Schemata422.ReplaceStringConstant_13(496L, "assert label shadows a dominating label"));
                        }
                        else
                        {
                            var rr = dominatingStatementLabels.Push(req.Label.Name, req.Label);
                            Contract.Assert(rr == Scope<Label>.PushResult.Success);  // since we just checked for duplicates, we expect the Push to succeed
                        }
                    }
                }
                ResolveBlockStatement(iter.Body, ResolutionContext.FromCodeContext(iter));
                dominatingStatementLabels.PopMarker();
                Constraints.SolveAllTypeConstraints($"body of iterator '{iter.Name}'");
            }

            currentClass = null;
            scope.PopMarker();  // pop off the AllowInstance setting

            if (MutateCSharp.Schemata422.ReplaceBinExprOp_5(497L, postSpecErrorCount, initialErrorCount))
            {
                iter.CreateIteratorMethodSpecs(resolver);
            }
        }

        /// <summary>
        /// Assumes type parameters have already been pushed.
        /// Also assumes that "currentClass" has been set to the parent of "f".
        /// </summary>
        void ResolveFunction(Function f)
        {
            Contract.Requires(f != null);

            f.ResolveNewOrOldPart(this);

            // make note of the warnShadowing attribute
            bool warnShadowingOption = resolver.Options.WarnShadowing;  // save the original warnShadowing value
            bool warnShadowing = MutateCSharp.Schemata422.ReplaceBooleanConstant_0(502L, true);
            // take care of the warnShadowing attribute
            if (Attributes.ContainsBool(f.Attributes, MutateCSharp.Schemata422.ReplaceStringConstant_13(503L, "warnShadowing"), ref warnShadowing))
            {
                resolver.Options.WarnShadowing = warnShadowing;  // set the value according to the attribute
            }

            scope.PushMarker();
            if (f.IsStatic)
            {
                scope.AllowInstance = MutateCSharp.Schemata422.ReplaceBooleanConstant_0(504L, false);
            }

            foreach (Formal p in f.Ins)
            {
                ScopePushAndReport(p, MutateCSharp.Schemata422.ReplaceStringConstant_13(505L, "parameter"), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(506L, false));
            }
            ResolveParameterDefaultValues(f.Ins, f);

            foreach (var req in f.Req)
            {
                ResolveAttributes(req, new ResolutionContext(f, f is TwoStateFunction), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(507L, false));
                Expression r = req.E;
                ResolveExpression(r, new ResolutionContext(f, f is TwoStateFunction));
                ConstrainTypeExprBool(r, MutateCSharp.Schemata422.ReplaceStringConstant_13(508L, "Precondition must be a boolean (got {0})"));
            }

            ResolveAttributes(f.Reads, new ResolutionContext(f, f is TwoStateFunction), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(509L, false));
            foreach (FrameExpression fr in f.Reads.Expressions)
            {
                ResolveFrameExpression(fr, FrameExpressionUse.Reads, f);
            }

            scope.PushMarker();
            if (MutateCSharp.Schemata422.ReplaceBinExprOp_20(510L, f.Result, null))
            {
                ScopePushAndReport(f.Result, MutateCSharp.Schemata422.ReplaceStringConstant_13(511L, "function result"), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(512L, false)); // function return only visible in post-conditions
            }
            foreach (var ens in f.Ens)
            {
                ResolveAttributes(ens, new ResolutionContext(f, f is TwoStateFunction), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(513L, false));
                Expression r = ens.E;
                ResolveExpression(r, new ResolutionContext(f, f is TwoStateFunction) with { InFunctionPostcondition = MutateCSharp.Schemata422.ReplaceBooleanConstant_0(514L, true) });
                ConstrainTypeExprBool(r, MutateCSharp.Schemata422.ReplaceStringConstant_13(515L, "Postcondition must be a boolean (got {0})"));
            }
            // resolve attributes on the function itself, now that in-parameters and any result name are part of the scope
            ResolveAttributes(f, new ResolutionContext(f, f is TwoStateFunction), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(516L, true));
            scope.PopMarker(); // function result name

            ResolveAttributes(f.Decreases, new ResolutionContext(f, f is TwoStateFunction), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(517L, false));
            foreach (Expression r in f.Decreases.Expressions)
            {
                ResolveExpression(r, new ResolutionContext(f, f is TwoStateFunction));
                // any type is fine
            }

            Constraints.SolveAllTypeConstraints($"specification of {f.WhatKind} '{f.Name}'");

            if (MutateCSharp.Schemata422.ReplaceBinExprOp_31(518L, f.ByMethodBody, null))
            {
                // The following conditions are assured by the parser and other callers of the Function constructor
                Contract.Assert(f.Body != null);
                Contract.Assert(!f.IsGhost);
            }
            if (MutateCSharp.Schemata422.ReplaceBinExprOp_29(519L, f.Body, null))
            {
                var prevErrorCount = ErrorCount;
                ResolveExpression(f.Body, new ResolutionContext(f, f is TwoStateFunction));
                AddSubtypeConstraint(Type2PreType(f.ResultType), f.Body.PreType, f.tok, MutateCSharp.Schemata422.ReplaceStringConstant_13(520L, "Function body type mismatch (expected {0}, got {1})"));
                Constraints.SolveAllTypeConstraints($"body of {f.WhatKind} '{f.Name}'");
            }

            scope.PopMarker();

            if (MutateCSharp.Schemata422.ReplaceBinExprOp_31(521L, f.ByMethodBody, null))
            {
                var method = f.ByMethodDecl;
                Contract.Assert(method != null); // this should have been filled in by now
                ResolveMethod(method);
            }

            resolver.Options.WarnShadowing = warnShadowingOption; // restore the original warnShadowing value
        }

        /// <summary>
        /// Assumes type parameters have already been pushed.
        /// Also assumes that "currentClass" has been set to the parent of "m".
        /// </summary>
        void ResolveMethod(Method m)
        {
            Contract.Requires(m != null);

            m.ResolveNewOrOldPart(this);

            try
            {
                currentMethod = m;

                bool warnShadowingOption = resolver.Options.WarnShadowing;  // save the original warnShadowing value
                bool warnShadowing = MutateCSharp.Schemata422.ReplaceBooleanConstant_0(522L, true);
                // take care of the warnShadowing attribute
                if (Attributes.ContainsBool(m.Attributes, MutateCSharp.Schemata422.ReplaceStringConstant_13(523L, "warnShadowing"), ref warnShadowing))
                {
                    resolver.Options.WarnShadowing = warnShadowing;  // set the value according to the attribute
                }

                // Add in-parameters to the scope, but don't care about any duplication errors, since they have already been reported
                scope.PushMarker();
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_10(524L, () => m.IsStatic, () => m is Constructor))
                {
                    scope.AllowInstance = MutateCSharp.Schemata422.ReplaceBooleanConstant_0(530L, false);
                }
                foreach (Formal p in m.Ins)
                {
                    ScopePushAndReport(p, MutateCSharp.Schemata422.ReplaceStringConstant_13(531L, "in-parameter"), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(532L, false));
                }
                ResolveParameterDefaultValues(m.Ins, m);

                // Start resolving specification...
                foreach (AttributedExpression e in m.Req)
                {
                    ResolveAttributes(e, new ResolutionContext(m, m is TwoStateLemma), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(533L, false));
                    ResolveExpression(e.E, new ResolutionContext(m, m is TwoStateLemma));
                    ConstrainTypeExprBool(e.E, MutateCSharp.Schemata422.ReplaceStringConstant_13(534L, "Precondition must be a boolean (got {0})"));
                }

                ResolveAttributes(m.Reads, new ResolutionContext(m, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(535L, false)), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(536L, false));
                foreach (FrameExpression fe in m.Reads.Expressions)
                {
                    ResolveFrameExpression(fe, FrameExpressionUse.Reads, m);
                }

                ResolveAttributes(m.Mod, new ResolutionContext(m, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(537L, false)), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(538L, false));
                foreach (FrameExpression fe in m.Mod.Expressions)
                {
                    ResolveFrameExpression(fe, FrameExpressionUse.Modifies, m);
                }

                ResolveAttributes(m.Decreases, new ResolutionContext(m, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(539L, false)), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(540L, false));
                foreach (Expression e in m.Decreases.Expressions)
                {
                    ResolveExpression(e, new ResolutionContext(m, m is TwoStateLemma));
                    // any type is fine
                }

                if (m is Constructor)
                {
                    scope.PopMarker();
                    // start the scope again, but this time allowing instance
                    scope.PushMarker();
                    foreach (Formal p in m.Ins)
                    {
                        ScopePushAndReport(p, MutateCSharp.Schemata422.ReplaceStringConstant_13(541L, "in-parameter"), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(542L, false));
                    }
                }

                // Add out-parameters to a new scope that will also include the outermost-level locals of the body
                // Don't care about any duplication errors among the out-parameters, since they have already been reported
                scope.PushMarker();
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_12(552L, () => m is ExtremeLemma, () => MutateCSharp.Schemata422.ReplaceBinExprOp_8(547L, m.Outs.Count, MutateCSharp.Schemata422.ReplaceNumericConstant_4(543L, 0))))
                {
                    ReportError(m.Outs[MutateCSharp.Schemata422.ReplaceNumericConstant_4(558L, 0)].tok, MutateCSharp.Schemata422.ReplaceStringConstant_13(562L, "{0}s are not allowed to have out-parameters"), m.WhatKind);
                }
                else
                {
                    foreach (Formal p in m.Outs)
                    {
                        ScopePushAndReport(p, MutateCSharp.Schemata422.ReplaceStringConstant_13(563L, "out-parameter"), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(564L, false));
                    }
                }

                // ... continue resolving specification
                foreach (AttributedExpression e in m.Ens)
                {
                    ResolveAttributes(e, new ResolutionContext(m, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(565L, true)), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(566L, false));
                    ResolveExpression(e.E, new ResolutionContext(m, MutateCSharp.Schemata422.ReplaceBooleanConstant_0(567L, true)));
                    ConstrainTypeExprBool(e.E, MutateCSharp.Schemata422.ReplaceStringConstant_13(568L, "Postcondition must be a boolean (got {0})"));
                }
                Constraints.SolveAllTypeConstraints($"specification of {m.WhatKind} '{m.Name}'");

                // Resolve body
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_31(569L, m.Body, null))
                {
                    if (m is ExtremeLemma { PrefixLemma: { } } com)
                    {
                        // The body may mentioned the implicitly declared parameter _k.  Throw it into the
                        // scope before resolving the body.
                        var k = com.PrefixLemma.Ins[MutateCSharp.Schemata422.ReplaceNumericConstant_4(570L, 0)];
                        ScopePushExpectSuccess(k, MutateCSharp.Schemata422.ReplaceStringConstant_13(574L, "_k parameter"), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(575L, false));
                    }

                    dominatingStatementLabels.PushMarker();
                    foreach (var req in m.Req)
                    {
                        if (MutateCSharp.Schemata422.ReplaceBinExprOp_32(576L, req.Label, null))
                        {
                            if (MutateCSharp.Schemata422.ReplaceBinExprOp_33(577L, dominatingStatementLabels.Find(req.Label.Name), null))
                            {
                                ReportError(req.Label.Tok, MutateCSharp.Schemata422.ReplaceStringConstant_13(578L, "assert label shadows a dominating label"));
                            }
                            else
                            {
                                var rr = dominatingStatementLabels.Push(req.Label.Name, req.Label);
                                Contract.Assert(rr == Scope<Label>.PushResult.Success);  // since we just checked for duplicates, we expect the Push to succeed
                            }
                        }
                    }
                    ResolveBlockStatement(m.Body, ResolutionContext.FromCodeContext(m));
                    dominatingStatementLabels.PopMarker();
                    Constraints.SolveAllTypeConstraints($"body of {m.WhatKind} '{m.Name}'");
                }

                // attributes are allowed to mention both in- and out-parameters (including the implicit _k, for greatest lemmas)
                ResolveAttributes(m, new ResolutionContext(m, m is TwoStateLemma), MutateCSharp.Schemata422.ReplaceBooleanConstant_0(579L, true));

                resolver.Options.WarnShadowing = warnShadowingOption; // restore the original warnShadowing value
                scope.PopMarker();  // for the out-parameters and outermost-level locals
                scope.PopMarker();  // for the in-parameters
            }
            finally
            {
                currentMethod = null;
            }
        }

        void ResolveFrameExpression(FrameExpression fe, FrameExpressionUse use, ICodeContext codeContext)
        {
            Contract.Requires(fe != null);
            Contract.Requires(codeContext != null);
            var resolutionContext = new ResolutionContext(codeContext, MutateCSharp.Schemata422.ReplaceBinExprOp_10(581L, () => codeContext is TwoStateLemma, () => MutateCSharp.Schemata422.ReplaceBinExprOp_34(580L, use, FrameExpressionUse.Unchanged)));
            ResolveExpression(fe.E, resolutionContext);
            Constraints.AddGuardedConstraint(() =>
            {
                DPreType dp = fe.E.PreType.NormalizeWrtScope() as DPreType;
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_7(587L, dp, null))
                {
                    // no information yet
                    return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(588L, false);
                }
                // A FrameExpression is allowed to have one of the following types:
                //     C
                //     collection<C>
                // where C is a reference type and collection is set, iset, seq, or multiset.
                // In a reads clause, a FrameExpression is additionally allowed to have type
                //     ... ~> collection<C>
                // A FrameExpression can also specify a field name using the syntax FE`fieldName,
                // which is allowed if fieldName is a field of C.
                var hasArrowType = MutateCSharp.Schemata422.ReplaceBooleanConstant_0(589L, false);
                var hasCollectionType = MutateCSharp.Schemata422.ReplaceBooleanConstant_0(590L, false);
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_12(592L, () => MutateCSharp.Schemata422.ReplaceBinExprOp_34(591L, use, FrameExpressionUse.Reads), () => DPreType.IsArrowType(dp.Decl)))
                {
                    hasArrowType = MutateCSharp.Schemata422.ReplaceBooleanConstant_0(598L, true);
                    dp = dp.Arguments.Last().Normalize() as DPreType;
                    if (MutateCSharp.Schemata422.ReplaceBinExprOp_7(599L, dp, null))
                    {
                        // function's image type not yet known
                        return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(600L, false);
                    }
                }

                if (dp.UrAncestor(this) is DPreType
                    {
                        Decl.Name: PreType.TypeNameSet or PreType.TypeNameIset or PreType.TypeNameSeq or PreType.TypeNameMultiset
                    } dpAncestor)
                {
                    hasCollectionType = MutateCSharp.Schemata422.ReplaceBooleanConstant_0(601L, true);
                    var elementType = dpAncestor.Arguments[MutateCSharp.Schemata422.ReplaceNumericConstant_4(602L, 0)].Normalize();
                    dp = elementType as DPreType;
                    if (MutateCSharp.Schemata422.ReplaceBinExprOp_7(606L, dp, null))
                    {
                        // element type not yet known
                        Constraints.AddDefaultAdvice(elementType, CommonAdvice.Target.Object);
                        return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(607L, false);
                    }
                }

                if (MutateCSharp.Schemata422.ReplaceBinExprOp_10(614L, () => !DPreType.IsReferenceTypeDecl(dp.Decl), () => (MutateCSharp.Schemata422.ReplaceBinExprOp_12(608L, () => hasArrowType, () => !hasCollectionType))))
                {
                    var expressionMustDenoteObject = MutateCSharp.Schemata422.ReplaceStringConstant_13(620L, "expression must denote an object");
                    var collection = MutateCSharp.Schemata422.ReplaceStringConstant_13(621L, "a set/iset/multiset/seq of objects");
                    var instead = MutateCSharp.Schemata422.ReplaceStringConstant_13(622L, "(instead got {0})");
                    var errorMsgFormat = use switch
                    {
                        FrameExpressionUse.Reads =>
                          $"a reads-clause {expressionMustDenoteObject}, {collection}, or a function to {collection} {instead}",
                        FrameExpressionUse.Modifies =>
                          $"a modifies-clause {expressionMustDenoteObject} or {collection} {instead}",
                        FrameExpressionUse.Unchanged =>
                          $"an unchanged {expressionMustDenoteObject} or {collection} {instead}",
                        _ => throw new ArgumentOutOfRangeException(nameof(use), use, null)
                    };
                    ReportError(fe.E.tok, errorMsgFormat, fe.E.PreType);
                }

                if (fe.FieldName != null)
                {
                    var (member, tentativeReceiverType) = FindMember(fe.E.tok, dp, fe.FieldName, resolutionContext);
                    Contract.Assert((member == null) == (tentativeReceiverType == null)); // follows from contract of FindMember
                    if (MutateCSharp.Schemata422.ReplaceBinExprOp_35(623L, member, null))
                    {
                        // error has already been reported by FindMember
                    }
                    else if (!(member is Field))
                    {
                        ReportError(fe.E, MutateCSharp.Schemata422.ReplaceStringConstant_13(624L, "member {0} in type {1} does not refer to a field"), fe.FieldName, tentativeReceiverType.Decl.Name);
                    }
                    else if (member is ConstantField)
                    {
                        ReportError(fe.E, MutateCSharp.Schemata422.ReplaceStringConstant_13(625L, "expression is not allowed to refer to constant field {0}"), fe.FieldName);
                    }
                    else
                    {
                        fe.Field = (Field)member;
                    }
                }

                return MutateCSharp.Schemata422.ReplaceBooleanConstant_0(626L, true);
            });
        }

        // ---------------------------------------- Utilities ----------------------------------------

        public Dictionary<TypeParameter, PreType> BuildPreTypeArgumentSubstitute(Dictionary<TypeParameter, PreType> typeArgumentSubstitutions, DPreType/*?*/ receiverTypeBound = null)
        {
            Contract.Requires(typeArgumentSubstitutions != null);

            var subst = new Dictionary<TypeParameter, PreType>();
            foreach (var entry in typeArgumentSubstitutions)
            {
                subst.Add(entry.Key, entry.Value);
            }

            if (receiverTypeBound?.Decl is TopLevelDeclWithMembers cl)
            {
                foreach (var entry in cl.ParentFormalTypeParametersToActuals)
                {
                    var v = Type2PreType(entry.Value).Substitute(subst);
                    subst.Add(entry.Key, v);
                }
            }

            return subst;
        }

        // ---------------------------------------- Migration sanity checks ----------------------------------------

        public void SanityCheckOldAndNewInference(List<TopLevelDecl> declarations)
        {
            var visitor = new PreTypeSanityChecker(this);
            foreach (var decl in declarations)
            {
                foreach (var attr in decl.Attributes.AsEnumerable())
                {
                    visitor.Visit(attr.Args);
                }
                if (decl is RedirectingTypeDecl rtd)
                {
                    if (MutateCSharp.Schemata422.ReplaceBinExprOp_29(627L, rtd.Constraint, null))
                    {
                        visitor.Visit(rtd.Constraint);
                    }
                    if (MutateCSharp.Schemata422.ReplaceBinExprOp_29(628L, rtd.Witness, null))
                    {
                        visitor.Visit(rtd.Witness);
                    }
                }
                else if (decl is IteratorDecl iter)
                {
                    visitor.Visit(iter);
                }
                else if (decl is TopLevelDeclWithMembers md)
                {
                    foreach (var member in md.Members)
                    {
                        if (member is ConstantField cfield && MutateCSharp.Schemata422.ReplaceBinExprOp_29(629L, cfield.Rhs, null))
                        {
                            visitor.Visit(cfield.Rhs);
                        }
                        else if (member is Function f)
                        {
                            visitor.Visit(f);
                            if (f is ExtremePredicate extremePredicate)
                            {
                                visitor.Visit(extremePredicate.PrefixPredicate);
                            }
                        }
                        else if (member is Method m)
                        {
                            visitor.Visit(m);
                            if (m is ExtremeLemma extremeLemma)
                            {
                                visitor.Visit(extremeLemma.PrefixLemma);
                            }
                        }
                    }
                }
            }
        }

        public
            class PreTypeSanityChecker : BottomUpVisitor
        {
            private PreTypeResolver preTypeResolver;

            public PreTypeSanityChecker(PreTypeResolver preTypeResolver)
            {
                this.preTypeResolver = preTypeResolver;
            }

            protected override void VisitOneExpr(Expression expr)
            {
                // compare expr.PreType and expr.Type
                if (MutateCSharp.Schemata422.ReplaceBinExprOp_36(630L, expr.PreType, null))
                {
                    preTypeResolver.ReportWarning(expr.tok, $"sanity check WARNING: no pre-type was computed");
                }
                else if (MutateCSharp.Schemata422.ReplaceBinExprOp_37(631L, expr.Type, null))
                {
                    preTypeResolver.ReportError(expr.tok, $"SANITY CHECK FAILED: .PreType is '{expr.PreType}' but .Type is null");
                }
                else if (PreType.Same(expr.PreType, preTypeResolver.Type2PreType(expr.Type)))
                {
                    // all is cool
                }
                else if (MutateCSharp.Schemata422.ReplaceBinExprOp_12(632L, () => expr.PreType is UnusedPreType, () => expr.Type is TypeProxy))
                {
                    // this is expected
                }
                else
                {
                    preTypeResolver.ReportError(expr.tok, $"SANITY CHECK FAILED: pre-type '{expr.PreType}' does not correspond to type '{expr.Type}'");
                }
            }
        }
    }
}
