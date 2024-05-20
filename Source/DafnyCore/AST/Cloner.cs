// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Xml;
namespace MutateCSharp
{
    internal class Schemata5
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT5");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_8(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.FrameExpression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.BoundVar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, Microsoft.Dafny.ModuleDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, Microsoft.Dafny.RangeToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.DividedBlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, Microsoft.Dafny.Formal argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.CalcStmt.CalcOp argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.AssertLabel argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.TypeParameter.EqualitySupportValue argument1, Microsoft.Dafny.TypeParameter.EqualitySupportValue argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, Microsoft.Dafny.AttributedToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_7(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.LList<Microsoft.Dafny.Label> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public interface ICloneable<out T>
    {
        T Clone(Cloner cloner);
    }

    public class Cloner
    {
        public bool CloneResolvedFields { get; }

        private readonly Dictionary<Statement, Statement> statementClones = new();
        private readonly Dictionary<IVariable, IVariable> clones = new();
        private readonly Dictionary<MemberDecl, MemberDecl> memberClones = new();
        private readonly Dictionary<TopLevelDecl, TopLevelDecl> typeParameterClones = new();
        public bool CloneLiteralModuleDefinition { get; }

        public void AddStatementClone(Statement original, Statement clone)
        {
            statementClones.Add(original, clone);
        }

        public TopLevelDecl GetCloneIfAvailable(TopLevelDecl topLevelDecl)
        {
            return typeParameterClones.GetOrDefault(topLevelDecl, () => topLevelDecl);
        }

        public Cloner(bool cloneLiteralModuleDefinition = false, bool cloneResolvedFields = false)
        {
            this.CloneLiteralModuleDefinition = cloneLiteralModuleDefinition;
            CloneResolvedFields = cloneResolvedFields;
        }

        public virtual ModuleDefinition CloneModuleDefinition(ModuleDefinition m, ModuleDefinition newParent)
        {
            if (m is DefaultModuleDefinition defaultModuleDefinition)
            {
                var result = new DefaultModuleDefinition(this, defaultModuleDefinition)
                {
                    EnclosingModule = newParent
                };
                return result;
            }

            return new ModuleDefinition(this, m)
            {
                EnclosingModule = newParent
            };
        }

        public virtual ModuleDefinition CloneModuleDefinition(ModuleDefinition m, ModuleDefinition newParent, Name name)
        {
            if (m is DefaultModuleDefinition defaultModuleDefinition)
            {
                var result = new DefaultModuleDefinition(this, defaultModuleDefinition)
                {
                    EnclosingModule = newParent
                };
                return result;
            }

            return new ModuleDefinition(this, m, name)
            {
                EnclosingModule = newParent
            };
        }

        public virtual TopLevelDecl CloneDeclaration(TopLevelDecl d, ModuleDefinition newParent)
        {
            Contract.Requires(d != null);
            Contract.Requires(newParent != null);

            if (d is AbstractTypeDecl)
            {
                var dd = (AbstractTypeDecl)d;
                return new AbstractTypeDecl(Range(dd.RangeToken), dd.NameNode.Clone(this), newParent,
                  CloneTPChar(dd.Characteristics), dd.TypeArgs.ConvertAll(CloneTypeParam),
                  dd.ParentTraits.ConvertAll(CloneType),
                  dd.Members.ConvertAll(d => CloneMember(d, MutateCSharp.Schemata5.ReplaceBooleanConstant_0(1L, false))), CloneAttributes(dd.Attributes), dd.IsRefining);
            }
            else if (d is SubsetTypeDecl)
            {
                Contract.Assume(
                  !(d is NonNullTypeDecl)); // don't clone the non-null type declaration; close the class, which will create a new non-null type declaration
                var dd = (SubsetTypeDecl)d;
                var tps = dd.TypeArgs.ConvertAll(CloneTypeParam);
                return new SubsetTypeDecl(Range(dd.RangeToken), dd.NameNode.Clone(this), CloneTPChar(dd.Characteristics), tps,
                  newParent, CloneBoundVar(dd.Var, MutateCSharp.Schemata5.ReplaceBooleanConstant_0(2L, false)), CloneExpr(dd.Constraint), dd.WitnessKind, CloneExpr(dd.Witness),
                  CloneAttributes(dd.Attributes));
            }
            else if (d is TypeSynonymDecl)
            {
                var dd = (TypeSynonymDecl)d;
                var tps = dd.TypeArgs.ConvertAll(CloneTypeParam);
                return new TypeSynonymDecl(Range(dd.RangeToken), dd.NameNode.Clone(this), CloneTPChar(dd.Characteristics), tps,
                  newParent, CloneType(dd.Rhs), CloneAttributes(dd.Attributes));
            }
            else if (d is NewtypeDecl)
            {
                var dd = (NewtypeDecl)d;
                if (MutateCSharp.Schemata5.ReplaceBinExprOp_1(3L, dd.Var, null))
                {
                    return new NewtypeDecl(Range(dd.RangeToken), dd.NameNode.Clone(this), newParent, CloneType(dd.BaseType),
                      dd.ParentTraits.ConvertAll(CloneType),
                      dd.Members.ConvertAll(d => CloneMember(d, MutateCSharp.Schemata5.ReplaceBooleanConstant_0(4L, false))), CloneAttributes(dd.Attributes), dd.IsRefining);
                }
                else
                {
                    return new NewtypeDecl(Range(dd.RangeToken), dd.NameNode.Clone(this), newParent, CloneBoundVar(dd.Var, MutateCSharp.Schemata5.ReplaceBooleanConstant_0(5L, false)),
                      CloneExpr(dd.Constraint), dd.WitnessKind, CloneExpr(dd.Witness),
                      dd.ParentTraits.ConvertAll(CloneType),
                      dd.Members.ConvertAll(d => CloneMember(d, MutateCSharp.Schemata5.ReplaceBooleanConstant_0(6L, false))), CloneAttributes(dd.Attributes), dd.IsRefining);
                }
            }
            else if (d is TupleTypeDecl)
            {
                // Tuple type declarations only exist in the system module. Therefore, they are never cloned.
                Contract.Assert(false);
                throw new cce.UnreachableException();
            }
            else if (d is IndDatatypeDecl)
            {
                var dd = (IndDatatypeDecl)d;
                var tps = dd.TypeArgs.ConvertAll(CloneTypeParam);
                var ctors = dd.Ctors.ConvertAll(CloneCtor);
                var dt = new IndDatatypeDecl(Range(dd.RangeToken), dd.NameNode.Clone(this), newParent, tps, ctors,
                  dd.ParentTraits.ConvertAll(CloneType),
                  dd.Members.ConvertAll(d => CloneMember(d, MutateCSharp.Schemata5.ReplaceBooleanConstant_0(7L, false))), CloneAttributes(dd.Attributes), dd.IsRefining);
                return dt;
            }
            else if (d is CoDatatypeDecl)
            {
                var dd = (CoDatatypeDecl)d;
                var tps = dd.TypeArgs.ConvertAll(CloneTypeParam);
                var ctors = dd.Ctors.ConvertAll(CloneCtor);
                var dt = new CoDatatypeDecl(Range(dd.RangeToken), dd.NameNode.Clone(this), newParent, tps, ctors,
                  dd.ParentTraits.ConvertAll(CloneType),
                  dd.Members.ConvertAll(d => CloneMember(d, MutateCSharp.Schemata5.ReplaceBooleanConstant_0(8L, false))), CloneAttributes(dd.Attributes), dd.IsRefining);
                return dt;
            }
            else if (d is IteratorDecl)
            {
                var dd = (IteratorDecl)d;
                var tps = dd.TypeArgs.ConvertAll(CloneTypeParam);
                var ins = dd.Ins.ConvertAll(bv => CloneFormal(bv, MutateCSharp.Schemata5.ReplaceBooleanConstant_0(9L, false)));
                var outs = dd.Outs.ConvertAll(bv => CloneFormal(bv, MutateCSharp.Schemata5.ReplaceBooleanConstant_0(10L, false)));
                var reads = CloneSpecFrameExpr(dd.Reads);
                var mod = CloneSpecFrameExpr(dd.Modifies);
                var decr = CloneSpecExpr(dd.Decreases);
                var req = dd.Requires.ConvertAll(CloneAttributedExpr);
                var yreq = dd.YieldRequires.ConvertAll(CloneAttributedExpr);
                var ens = dd.Ensures.ConvertAll(CloneAttributedExpr);
                var yens = dd.YieldEnsures.ConvertAll(CloneAttributedExpr);
                var body = CloneBlockStmt(dd.Body);
                var iter = new IteratorDecl(Range(dd.RangeToken), dd.NameNode.Clone(this), newParent,
                  tps, ins, outs, reads, mod, decr,
                  req, ens, yreq, yens,
                  body, CloneAttributes(dd.Attributes), dd.SignatureEllipsis);
                return iter;
            }
            else if (d is TraitDecl)
            {
                var dd = (TraitDecl)d;
                var tps = dd.TypeArgs.ConvertAll(CloneTypeParam);
                var mm = dd.Members.ConvertAll(member => CloneMember(member, MutateCSharp.Schemata5.ReplaceBooleanConstant_0(11L, false)));
                var cl = new TraitDecl(Range(dd.RangeToken), dd.NameNode.Clone(this), newParent, tps, mm,
                  CloneAttributes(dd.Attributes), dd.IsRefining, dd.ParentTraits.ConvertAll(CloneType));
                return cl;
            }
            else if (d is DefaultClassDecl)
            {
                var dd = (DefaultClassDecl)d;
                var tps = dd.TypeArgs.ConvertAll(CloneTypeParam);
                var mm = dd.Members.ConvertAll(member => CloneMember(member, MutateCSharp.Schemata5.ReplaceBooleanConstant_0(12L, false)));
                return new DefaultClassDecl(newParent, mm);
            }
            else if (d is ClassDecl)
            {
                var dd = (ClassDecl)d;
                var tps = dd.TypeArgs.ConvertAll(CloneTypeParam);
                var mm = dd.Members.ConvertAll(member => CloneMember(member, MutateCSharp.Schemata5.ReplaceBooleanConstant_0(13L, false)));
                return new ClassDecl(Range(dd.RangeToken), dd.NameNode.Clone(this), newParent, tps, mm,
                  CloneAttributes(dd.Attributes), dd.IsRefining, dd.ParentTraits.ConvertAll(CloneType));
            }
            else if (d is ModuleDecl)
            {
                if (d is LiteralModuleDecl moduleDecl)
                {
                    return new LiteralModuleDecl(this, moduleDecl, newParent);
                }
                else if (d is AliasModuleDecl)
                {
                    var a = (AliasModuleDecl)d;
                    return new AliasModuleDecl(this, a, newParent);
                }
                else if (d is AbstractModuleDecl)
                {
                    var a = (AbstractModuleDecl)d;
                    return new AbstractModuleDecl(this, a, newParent);
                }
                else if (d is ModuleExportDecl)
                {
                    var a = (ModuleExportDecl)d;
                    return new ModuleExportDecl(this, a, newParent);
                }
                else
                {
                    Contract.Assert(false); // unexpected declaration
                    return null; // to please compiler
                }
            }
            else
            {
                Contract.Assert(false); // unexpected declaration
                return null; // to please compiler
            }

            return default;
        }

        public TypeParameter.TypeParameterCharacteristics CloneTPChar(
          TypeParameter.TypeParameterCharacteristics characteristics)
        {
            TypeParameter.EqualitySupportValue eqSupport;
            if (MutateCSharp.Schemata5.ReplaceBinExprOp_2(14L, characteristics.EqualitySupport, TypeParameter.EqualitySupportValue.InferredRequired))
            {
                eqSupport = TypeParameter.EqualitySupportValue.Unspecified;
            }
            else
            {
                eqSupport = characteristics.EqualitySupport;
            }

            return new TypeParameter.TypeParameterCharacteristics(eqSupport, characteristics.AutoInit,
              characteristics.ContainsNoReferenceTypes);
        }

        public DatatypeCtor CloneCtor(DatatypeCtor ct)
        {
            return new DatatypeCtor(Range(ct.RangeToken), ct.NameNode.Clone(this), ct.IsGhost,
              ct.Formals.ConvertAll(bv => CloneFormal(bv, MutateCSharp.Schemata5.ReplaceBooleanConstant_0(15L, false))), CloneAttributes(ct.Attributes));
        }

        public TypeParameter CloneTypeParam(TypeParameter tp)
        {
            return (TypeParameter)typeParameterClones.GetOrCreate(tp,
              () => new TypeParameter(Range(tp.RangeToken), tp.NameNode.Clone(this), tp.VarianceSyntax,
                CloneTPChar(tp.Characteristics)));
        }

        public virtual MemberDecl CloneMember(MemberDecl member, bool isReference)
        {
            return memberClones.GetOrCreate(member, () =>
            {
                if (isReference)
                {
                    return member;
                }

                if (member is Field)
                {
                    var f = (Field)member;
                    return CloneField(f);
                }
                else if (member is Function)
                {
                    var f = (Function)member;
                    return CloneFunction(f);
                }
                else
                {
                    var m = (Method)member;
                    return CloneMethod(m);
                }

                return default;
            });
        }

        public virtual Type CloneType(Type t)
        {
            if (MutateCSharp.Schemata5.ReplaceBinExprOp_3(16L, t, null))
            {
                return null;
            }

            if (t is BasicType)
            {
                return t;
            }
            else if (t is SetType)
            {
                var tt = (SetType)t;
                return new SetType(tt.Finite, tt.HasTypeArg() ? CloneType(tt.Arg) : null);
            }
            else if (t is SeqType)
            {
                var tt = (SeqType)t;
                return new SeqType(tt.HasTypeArg() ? CloneType(tt.Arg) : null);
            }
            else if (t is MultiSetType)
            {
                var tt = (MultiSetType)t;
                return new MultiSetType(tt.HasTypeArg() ? CloneType(tt.Arg) : null);
            }
            else if (t is MapType mapType)
            {
                return new MapType(this, mapType);
            }
            else if (t is ArrowType)
            {
                var tt = (ArrowType)t;
                return new ArrowType(Tok(tt.tok), tt.Args.ConvertAll(CloneType), CloneType(tt.Result));
            }
            else if (t is UserDefinedType)
            {
                var tt = (UserDefinedType)t;
#if TEST_TYPE_SYNONYM_TRANSPARENCY
        if (tt.Name == "type#synonym#transparency#test") {
          // time to drop the synonym wrapper
          var syn = (TypeSynonymDecl)tt.ResolvedClass;
          return CloneType(syn.Rhs);
        }
#endif
                return new UserDefinedType(this, tt);
            }
            else if (t is InferredTypeProxy proxy)
            {
                var inferredTypeProxy = new InferredTypeProxy();
                if (CloneResolvedFields)
                {
                    inferredTypeProxy.T = proxy.T;
                }

                return inferredTypeProxy;
            }
            else if (t is ParamTypeProxy)
            {
                return new ParamTypeProxy(CloneTypeParam(((ParamTypeProxy)t).orig));
            }
            else if (t is TypeRefinementWrapper typeRefinementWrapper)
            {
                // don't bother keeping TypeRefinementWrapper wrappers
                return CloneType(typeRefinementWrapper.T);
            }
            else
            {
                Contract.Assert(false); // unexpected type (e.g., no other type proxies are expected at this time)
                return null; // to please compiler
            }

            return default;
        }

        public virtual Formal CloneFormal(Formal formal, bool isReference)
        {
            return (Formal)clones.GetOrCreate(formal, () => isReference
             ? formal
             : new Formal(Tok(formal.tok), formal.Name, CloneType(formal.Type), formal.InParam, formal.IsGhost,
               CloneExpr(formal.DefaultValue), CloneAttributes(formal.Attributes),
               formal.IsOld, formal.IsNameOnly, formal.IsOlder, formal.NameForCompilation)
             {
                 RangeToken = formal.RangeToken,
                 IsTypeExplicit = formal.IsTypeExplicit
             });
        }

        public virtual BoundVar CloneBoundVar(BoundVar bv, bool isReference)
        {
            return (BoundVar)clones.GetOrCreate(bv, () =>
            {
                if (isReference)
                {
                    return bv;
                }

                var bvNew = new BoundVar(Tok(bv.tok), bv.Name, CloneType(bv.SyntacticType));
                bvNew.IsGhost = bv.IsGhost;
                return bvNew;
            });
        }

        public virtual LocalVariable CloneLocalVariable(LocalVariable local, bool isReference)
        {
            return (LocalVariable)clones.GetOrCreate(local, () => isReference ? local : new LocalVariable(this, local));
        }

        public virtual VT CloneIVariable<VT>(VT v, bool isReference)
          where VT : class, IVariable
        {
            if (v == null)
            {
                return null;
            }

            var iv = (IVariable)v;
            if (iv is Formal formal)
            {
                iv = CloneFormal(formal, isReference);
            }
            else if (iv is BoundVar boundVar)
            {
                iv = CloneBoundVar(boundVar, isReference);
            }
            else if (iv is LocalVariable localVariable)
            {
                iv = CloneLocalVariable(localVariable, isReference);
            }
            else
            {
                Contract.Assume(false); // unexpected IVariable
                iv = null; // please compiler
            }

            return (VT)iv;
        }

        public Specification<Expression> CloneSpecExpr(Specification<Expression> spec)
        {
            var ee = MutateCSharp.Schemata5.ReplaceBinExprOp_4(17L, spec.Expressions, null) ? null : spec.Expressions.ConvertAll(CloneExpr);
            return new Specification<Expression>(ee, CloneAttributes(spec.Attributes));
        }

        public Specification<FrameExpression> CloneSpecFrameExpr(Specification<FrameExpression> frame)
        {
            var ee = MutateCSharp.Schemata5.ReplaceBinExprOp_5(18L, frame.Expressions, null) ? null : frame.Expressions.ConvertAll(CloneFrameExpr);
            return new Specification<FrameExpression>(ee, CloneAttributes(frame.Attributes));
        }

        public FrameExpression CloneFrameExpr(FrameExpression frame)
        {
            return new FrameExpression(this, frame);
        }

        public Attributes CloneAttributes(Attributes attrs)
        {
            if (MutateCSharp.Schemata5.ReplaceBinExprOp_6(19L, attrs, null))
            {
                return null;
            }
            else if (MutateCSharp.Schemata5.ReplaceBinExprOp_8(21L, () => !CloneResolvedFields, () => attrs.Name.StartsWith(MutateCSharp.Schemata5.ReplaceStringConstant_7(20L, "_"))))
            {
                // skip this attribute, since it would have been produced during resolution
                return CloneAttributes(attrs.Prev);
            }
            else if (attrs is UserSuppliedAttributes)
            {
                var usa = (UserSuppliedAttributes)attrs;
                return new UserSuppliedAttributes(Tok(usa.tok), Tok(usa.OpenBrace), Tok(usa.CloseBrace),
                  attrs.Args.ConvertAll(CloneExpr), CloneAttributes(attrs.Prev));
            }
            else
            {
                return new Attributes(attrs.Name, attrs.Args.ConvertAll(CloneExpr), CloneAttributes(attrs.Prev));
            }

            return default;
        }

        public AttributedExpression CloneAttributedExpr(AttributedExpression expr)
        {
            var mfe = new AttributedExpression(CloneExpr(expr.E),
      MutateCSharp.Schemata5.ReplaceBinExprOp_9(27L, expr.Label, null) ? null : new AssertLabel(Tok(expr.Label.Tok), expr.Label.Name),
              CloneAttributes(expr.Attributes));
            mfe.Attributes = CloneAttributes(expr.Attributes);
            return mfe;
        }

        public virtual ActualBinding CloneActualBinding(ActualBinding binding)
        {
            return new ActualBinding(MutateCSharp.Schemata5.ReplaceBinExprOp_10(28L, binding.FormalParameterName, null) ? null : Tok(binding.FormalParameterName),
              CloneExpr(binding.Actual));
        }

        public virtual Expression CloneExpr(Expression expr)
        {
            if (MutateCSharp.Schemata5.ReplaceBinExprOp_11(29L, expr, null))
            {
                return null;
            }

            if (expr is ICloneable<Expression> cloneableExpression)
            {
                return cloneableExpression.Clone(this);
            }

            throw new Exception($"No clone implementation found for {expr.GetType()}"); // unexpected expression
            return default;
        }

        public MatchCaseExpr CloneMatchCaseExpr(MatchCaseExpr c)
        {
            Contract.Requires(c != null);
            Contract.Requires(c.Arguments != null);
            return new MatchCaseExpr(Tok(c.tok), c.Ctor, c.FromBoundVar,
              c.Arguments.ConvertAll(bv => CloneBoundVar(bv, MutateCSharp.Schemata5.ReplaceBooleanConstant_0(30L, false))), CloneExpr(c.Body), CloneAttributes(c.Attributes));
        }

        public NestedMatchCaseExpr CloneNestedMatchCaseExpr(NestedMatchCaseExpr c)
        {
            Contract.Requires(c != null);
            return new NestedMatchCaseExpr(Tok(c.Tok), CloneExtendedPattern(c.Pat), CloneExpr(c.Body),
              CloneAttributes(c.Attributes));
        }

        public virtual CasePattern<VT> CloneCasePattern<VT>(CasePattern<VT> pat)
          where VT : class, IVariable
        {
            Contract.Requires(pat != null);
            return new CasePattern<VT>(this, pat);
        }

        public virtual NameSegment CloneNameSegment(Expression expr)
        {
            return new NameSegment(this, (NameSegment)expr);
        }

        public virtual AssignmentRhs CloneRHS(AssignmentRhs rhs)
        {
            if (rhs is ICloneable<AssignmentRhs> cloneable)
            {
                return cloneable.Clone(this);
            }

            throw new Exception($"No clone implementation found for {rhs.GetType()}"); // unexpected RHS
            return default;
        }

        public virtual BlockStmt CloneBlockStmt(BlockStmt stmt)
        {
            Contract.Requires(
              !(stmt is DividedBlockStmt)); // for blocks that may be DividedBlockStmt's, call CloneDividedBlockStmt instead
            if (MutateCSharp.Schemata5.ReplaceBinExprOp_12(31L, stmt, null))
            {
                return null;
            }
            else
            {
                return new BlockStmt(Tok(stmt.RangeToken), stmt.Body.ConvertAll(stmt1 => CloneStmt(stmt1, MutateCSharp.Schemata5.ReplaceBooleanConstant_0(32L, false))));
            }

            return default;
        }

        public virtual DividedBlockStmt CloneDividedBlockStmt(DividedBlockStmt stmt)
        {
            if (MutateCSharp.Schemata5.ReplaceBinExprOp_13(33L, stmt, null))
            {
                return null;
            }
            else
            {
                return new DividedBlockStmt(Tok(stmt.RangeToken), stmt.BodyInit.ConvertAll(stmt1 => CloneStmt(stmt1, MutateCSharp.Schemata5.ReplaceBooleanConstant_0(34L, false))),
        MutateCSharp.Schemata5.ReplaceBinExprOp_10(35L, stmt.SeparatorTok, null) ? null : Tok(stmt.SeparatorTok), stmt.BodyProper.ConvertAll(stmt1 => CloneStmt(stmt1, MutateCSharp.Schemata5.ReplaceBooleanConstant_0(36L, false))));
            }

            return default;
        }

        public virtual Statement CloneStmt(Statement stmt, bool isReference)
        {
            if (MutateCSharp.Schemata5.ReplaceBinExprOp_14(37L, stmt, null))
            {
                return null;
            }


            if (statementClones.TryGetValue(stmt, out var cachedResult))
            {
                return cachedResult;
            }

            if (isReference)
            {
                return stmt;
            }

            if (stmt is ICloneable<Statement> cloneable)
            {
                var r = cloneable.Clone(this);
                // add labels to the cloned statement
                AddStmtLabels(r, stmt.Labels);
                r.Attributes = CloneAttributes(stmt.Attributes);

                return r;
            }

            Contract.Assert(false);
            throw new cce.UnreachableException(); // unexpected statement TODO, make all statements inherit from ICloneable.
            return default;
        }

        public MatchCaseStmt CloneMatchCaseStmt(MatchCaseStmt c)
        {
            Contract.Requires(c != null);
            Contract.Assert(c.Arguments != null);
            return new MatchCaseStmt(Tok(c.RangeToken), c.Ctor, c.FromBoundVar,
              c.Arguments.ConvertAll(v => CloneBoundVar(v, MutateCSharp.Schemata5.ReplaceBooleanConstant_0(38L, false))),
              c.Body.ConvertAll(stmt => CloneStmt(stmt, MutateCSharp.Schemata5.ReplaceBooleanConstant_0(39L, false))), CloneAttributes(c.Attributes));
        }

        public ExtendedPattern CloneExtendedPattern(ExtendedPattern pat)
        {
            switch (pat)
            {
                case LitPattern p:
                    return new LitPattern(p.Tok, CloneExpr(p.OrigLit));
                    break;
                case IdPattern p:
                    return new IdPattern(this, p);
                    break;
                case DisjunctivePattern p:
                    return new DisjunctivePattern(p.Tok, p.Alternatives.ConvertAll(CloneExtendedPattern), p.IsGhost);
                    break;
                default:
                    Contract.Assert(false);
                    return null;
                    break;
            }

            return default;
        }

        public NestedMatchCaseStmt CloneNestedMatchCaseStmt(NestedMatchCaseStmt c)
        {
            Contract.Requires(c != null);
            return new NestedMatchCaseStmt(c.Tok, CloneExtendedPattern(c.Pat), c.Body.ConvertAll(stmt => CloneStmt(stmt, MutateCSharp.Schemata5.ReplaceBooleanConstant_0(40L, false))),
              CloneAttributes(c.Attributes));
        }

        public CalcStmt.CalcOp CloneCalcOp(CalcStmt.CalcOp op)
        {
            if (MutateCSharp.Schemata5.ReplaceBinExprOp_15(41L, op, null))
            {
                return null;
            }
            else if (op is CalcStmt.BinaryCalcOp)
            {
                return new CalcStmt.BinaryCalcOp(((CalcStmt.BinaryCalcOp)op).Op);
            }
            else if (op is CalcStmt.TernaryCalcOp)
            {
                return new CalcStmt.TernaryCalcOp(CloneExpr(((CalcStmt.TernaryCalcOp)op).Index));
            }
            else
            {
                Contract.Assert(false);
                throw new cce.UnreachableException();
            }

            return default;
        }

        public void AddStmtLabels(Statement s, LList<Label> node)
        {
            if (MutateCSharp.Schemata5.ReplaceBinExprOp_16(42L, node, null))
            {
                AddStmtLabels(s, node.Next);
                if (node.Data.Name == null)
                {
                    // this indicates an implicit-target break statement that has been resolved; don't add it
                }
                else
                {
                    s.Labels = new LList<Label>(new Label(Tok(node.Data.Tok), node.Data.Name), s.Labels);
                }
            }
        }

        public GuardedAlternative CloneGuardedAlternative(GuardedAlternative alt)
        {
            return new GuardedAlternative(Tok(alt.Tok), alt.IsBindingGuard, CloneExpr(alt.Guard),
              alt.Body.ConvertAll(stmt => CloneStmt(stmt, MutateCSharp.Schemata5.ReplaceBooleanConstant_0(43L, false))), CloneAttributes(alt.Attributes));
        }

        public virtual Field CloneField(Field f)
        {
            Contract.Requires(f != null);
            return f switch
            {
                ConstantField c => new ConstantField(Range(c.RangeToken), c.NameNode.Clone(this), CloneExpr(c.Rhs),
                  c.HasStaticKeyword, c.IsGhost, c.IsOpaque, CloneType(c.Type), CloneAttributes(c.Attributes)),
                // We don't expect a SpecialField to ever be cloned. However, it can happen for malformed programs, for example if
                // an iterator in a refined module is replaced by a class in the refining module.
                SpecialField s => new SpecialField(Range(s.RangeToken), s.Name, s.SpecialId, s.IdParam, s.IsGhost, s.IsMutable,
                  s.IsUserMutable, CloneType(s.Type), CloneAttributes(s.Attributes)),
                _ => new Field(Range(f.RangeToken), f.NameNode.Clone(this), f.HasStaticKeyword, f.IsGhost, f.IsMutable,
                  f.IsUserMutable, CloneType(f.Type), CloneAttributes(f.Attributes))
            };
        }

        public virtual Function CloneFunction(Function f, string newName = null)
        {
            var tps = f.TypeArgs.ConvertAll(CloneTypeParam);
            var formals = f.Ins.ConvertAll(p => CloneFormal(p, MutateCSharp.Schemata5.ReplaceBooleanConstant_0(44L, false)));
            var result = MutateCSharp.Schemata5.ReplaceBinExprOp_17(45L, f.Result, null) ? CloneFormal(f.Result, MutateCSharp.Schemata5.ReplaceBooleanConstant_0(46L, false)) : null;
            var req = f.Req.ConvertAll(CloneAttributedExpr);
            var reads = CloneSpecFrameExpr(f.Reads);
            var decreases = CloneSpecExpr(f.Decreases);
            var ens = f.Ens.ConvertAll(CloneAttributedExpr);
            Expression body = CloneExpr(f.Body);
            BlockStmt byMethodBody = CloneBlockStmt(f.ByMethodBody);

            if (newName == null)
            {
                newName = f.Name;
            }

            var newNameNode = new Name(Range(f.NameNode.RangeToken), newName);

            if (f is Predicate)
            {
                return new Predicate(Range(f.RangeToken), newNameNode, f.HasStaticKeyword, f.IsGhost, f.IsOpaque, tps, formals,
                  result,
                  req, reads, ens, decreases, body, Predicate.BodyOriginKind.OriginalOrInherited,
        MutateCSharp.Schemata5.ReplaceBinExprOp_10(47L, f.ByMethodTok, null) ? null : Tok(f.ByMethodTok), byMethodBody,
                  CloneAttributes(f.Attributes), null);
            }
            else if (f is LeastPredicate)
            {
                return new LeastPredicate(Range(f.RangeToken), newNameNode, f.HasStaticKeyword, f.IsOpaque,
                  ((LeastPredicate)f).TypeOfK, tps, formals, result,
                  req, reads, ens, body, CloneAttributes(f.Attributes), null);
            }
            else if (f is GreatestPredicate greatestPredicate)
            {
                return new GreatestPredicate(Range(f.RangeToken), newNameNode, f.HasStaticKeyword, f.IsOpaque,
                  ((GreatestPredicate)f).TypeOfK, tps, formals, result,
                  req, reads, ens, body, CloneAttributes(f.Attributes), null);
            }
            else if (f is TwoStatePredicate)
            {
                return new TwoStatePredicate(Range(f.RangeToken), newNameNode, f.HasStaticKeyword, f.IsOpaque, tps, formals,
                  result,
                  req, reads, ens, decreases, body, CloneAttributes(f.Attributes), null);
            }
            else if (f is TwoStateFunction)
            {
                return new TwoStateFunction(Range(f.RangeToken), newNameNode, f.HasStaticKeyword, f.IsOpaque, tps, formals,
                  result, CloneType(f.ResultType),
                  req, reads, ens, decreases, body, CloneAttributes(f.Attributes), null);
            }
            else
            {
                return new Function(Range(f.RangeToken), newNameNode, f.HasStaticKeyword, f.IsGhost, f.IsOpaque, tps, formals,
                  result, CloneType(f.ResultType),
                  req, reads, ens, decreases, body, MutateCSharp.Schemata5.ReplaceBinExprOp_10(48L, f.ByMethodTok, null) ? null : Tok(f.ByMethodTok), byMethodBody,
                  CloneAttributes(f.Attributes), null);
            }

            return default;
        }

        public virtual Method CloneMethod(Method m)
        {
            Contract.Requires(m != null);
            return m switch
            {
                Constructor constructor => new Constructor(this, constructor),
                LeastLemma leastLemma => new LeastLemma(this, leastLemma),
                GreatestLemma greatestLemma => new GreatestLemma(this, greatestLemma),
                Lemma lemma => new Lemma(this, lemma),
                TwoStateLemma lemma => new TwoStateLemma(this, lemma),
                _ => new Method(this, m)
            };
        }

        public virtual BlockStmt CloneMethodBody(Method m)
        {
            if (m.Body is DividedBlockStmt)
            {
                return CloneDividedBlockStmt((DividedBlockStmt)m.Body);
            }
            else
            {
                return CloneBlockStmt(m.Body);
            }

            return default;
        }

        public virtual RangeToken Range(RangeToken range)
        {
            if (MutateCSharp.Schemata5.ReplaceBinExprOp_18(49L, range, null))
            {
                return null;
            }
            return new RangeToken(Tok(range.StartToken), Tok(range.EndToken));
        }

        public virtual IToken Tok(IToken tok)
        {
            Contract.Requires(tok != null);
            return tok;
        }

        public RangeToken Tok(RangeToken tok)
        {
            Contract.Requires(tok != null);
            return new RangeToken(Tok(tok.StartToken), Tok(tok.EndToken));
        }

        public virtual AttributedToken AttributedTok(AttributedToken tok)
        {
            if (MutateCSharp.Schemata5.ReplaceBinExprOp_19(50L, tok, null))
            {
                return null;
            }

            return new AttributedToken(Tok(tok.Token), CloneAttributes(tok.Attrs));
        }
    }

    public class ClonerKeepParensExpressions : Cloner
    {
        public override Expression CloneExpr(Expression expr)
        {
            if (expr is ParensExpression parensExpression)
            {
                return new ParensExpression(Tok(parensExpression.tok), CloneExpr(parensExpression.E));
            }

            return base.CloneExpr(expr);
        }
    }

    public
      /// <summary>
      /// This cloner copies the origin module signatures to their cloned declarations
      /// </summary>
      class DeepModuleSignatureCloner : Cloner
    {
        public DeepModuleSignatureCloner(bool cloneResolvedFields = false) : base(MutateCSharp.Schemata5.ReplaceBooleanConstant_0(51L, false), cloneResolvedFields)
        {
        }

        public override TopLevelDecl CloneDeclaration(TopLevelDecl d, ModuleDefinition newParent)
        {
            var dd = base.CloneDeclaration(d, newParent);
            if (d is ModuleDecl)
            {
                ((ModuleDecl)dd).Signature = ((ModuleDecl)d).Signature;
                if (d is AbstractModuleDecl)
                {
                    var sourcefacade = (AbstractModuleDecl)d;

                    ((AbstractModuleDecl)dd).OriginalSignature = sourcefacade.OriginalSignature;
                    if (MutateCSharp.Schemata5.ReplaceBinExprOp_20(52L, sourcefacade.QId.Root, null))
                    {
                        ((AbstractModuleDecl)dd).QId.Root = (ModuleDecl)CloneDeclaration(sourcefacade.QId.Root, newParent);
                    }
                }
                else if (d is AliasModuleDecl)
                {
                    var sourcealias = (AliasModuleDecl)d;

                    if (MutateCSharp.Schemata5.ReplaceBinExprOp_20(53L, sourcealias.TargetQId.Root, null))
                    {
                        ((AliasModuleDecl)dd).TargetQId.Root =
                          (ModuleDecl)CloneDeclaration(sourcealias.TargetQId.Root, newParent);
                    }
                }
            }

            return dd;
        }
    }

    public

      /// <summary>
      /// This cloner is used during the creation of a module signature for a method facade.
      /// It does not clone method bodies, and it copies module signatures.
      /// </summary>
      class ClonerButDropMethodBodies : DeepModuleSignatureCloner
    {
        public ClonerButDropMethodBodies(bool cloneResolvedFields = false) : base(cloneResolvedFields)
        {
        }

        public override BlockStmt CloneBlockStmt(BlockStmt stmt)
        {
            return null;
        }
    }
}