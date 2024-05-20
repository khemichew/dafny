using System;
using System.Collections.Generic;
using Dafny;
using DAST;
using DAST.Format;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Microsoft.Dafny.Compilers;
using Std.Wrappers;
namespace MutateCSharp
{
    internal class Schemata221
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT221");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_4(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static int ReplaceNumericConstant_1(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, DAST.CallName argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, object argument1, Microsoft.Dafny.Compilers.BuildableLhs argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, DAST.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, System.Collections.Generic.List<Dafny.ISequence<Dafny.Rune>> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_3(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
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

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, object argument1, DAST.AssignLhs argument2)
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

        internal static bool ReplaceBinExprOp_13(long mutantId, System.Collections.Generic.List<Dafny.ISequence<Dafny.Rune>> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_8(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, System.Collections.Generic.List<DAST.Type> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny.Compilers
{
    public
      interface Container
    {
        public void AddUnsupported(string why);
    }

    public
      class ProgramBuilder : ModuleContainer
    {
        readonly List<Module> items = new();

        public void AddModule(Module item)
        {
            items.Add(item);
        }

        public List<Module> Finish()
        {
            return items;
        }

        public void AddUnsupported(string why)
        {
            items.Add(ModuleContainer.UnsupportedToModule(why));
        }
    }

    public
      interface ModuleContainer : Container
    {
        void AddModule(Module item);

        public ModuleBuilder Module(string name, bool isExtern)
        {
            return new ModuleBuilder(this, name, isExtern);
        }

        static public Module UnsupportedToModule(string why)
        {
            return new Module(Sequence<Rune>.UnicodeFromString(why), MutateCSharp.Schemata221.ReplaceBooleanConstant_0(1L, true),
              Sequence<ModuleItem>.FromArray(new ModuleItem[] { }));
        }
    }

    public
      class ModuleBuilder : ClassContainer, TraitContainer, NewtypeContainer, DatatypeContainer
    {
        readonly ModuleContainer parent;
        readonly string name;
        readonly bool isExtern;
        readonly List<ModuleItem> body = new();

        public ModuleBuilder(ModuleContainer parent, string name, bool isExtern)
        {
            this.parent = parent;
            this.name = name;
            this.isExtern = isExtern;
        }

        public void AddModule(Module item)
        {
            body.Add((ModuleItem)ModuleItem.create_Module(item));
        }

        public void AddClass(Class item)
        {
            body.Add((ModuleItem)ModuleItem.create_Class(item));
        }

        public void AddTrait(Trait item)
        {
            body.Add((ModuleItem)ModuleItem.create_Trait(item));
        }

        public void AddNewtype(Newtype item)
        {
            body.Add((ModuleItem)ModuleItem.create_Newtype(item));
        }

        public void AddDatatype(Datatype item)
        {
            body.Add((ModuleItem)ModuleItem.create_Datatype(item));
        }

        public object Finish()
        {
            parent.AddModule((Module)Module.create(
              Sequence<Rune>.UnicodeFromString(this.name),
              this.isExtern,
              Sequence<ModuleItem>.FromArray(body.ToArray())
            ));
            return parent;
        }

        public void AddUnsupported(string why)
        {
            body.Add((ModuleItem)ModuleItem.create_Module(ModuleContainer.UnsupportedToModule(why)));
        }
    }

    public
      interface ClassContainer : Container
    {
        void AddClass(Class item);

        public ClassBuilder Class(string name, string enclosingModule, List<DAST.Type> typeParams, List<DAST.Type> superClasses)
        {
            return new ClassBuilder(this, name, enclosingModule, typeParams, superClasses);
        }
    }

    public
      class ClassBuilder : ClassLike
    {
        readonly ClassContainer parent;
        readonly string name;
        readonly string enclosingModule;
        readonly List<DAST.Type> typeParams;
        readonly List<DAST.Type> superClasses;
        readonly List<DAST.Field> fields = new();
        readonly List<DAST.Method> body = new();

        public ClassBuilder(ClassContainer parent, string name, string enclosingModule, List<DAST.Type> typeParams, List<DAST.Type> superClasses)
        {
            this.parent = parent;
            this.name = name;
            this.enclosingModule = enclosingModule;
            this.typeParams = typeParams;
            this.superClasses = superClasses;
        }

        public void AddMethod(DAST.Method item)
        {
            body.Add(item);
        }

        public void AddField(DAST.Formal item, _IOption<DAST._IExpression> defaultValue)
        {
            fields.Add((DAST.Field)DAST.Field.create_Field(item, defaultValue));
        }

        public object Finish()
        {
            parent.AddClass((Class)Class.create(
              Sequence<Rune>.UnicodeFromString(this.name),
              Sequence<Rune>.UnicodeFromString(this.enclosingModule),
              Sequence<DAST.Type>.FromArray(this.typeParams.ToArray()),
              Sequence<DAST.Type>.FromArray(this.superClasses.ToArray()),
              Sequence<DAST.Field>.FromArray(this.fields.ToArray()),
              Sequence<DAST.Method>.FromArray(body.ToArray())
            ));
            return parent;
        }
    }

    public
      interface TraitContainer : Container
    {
        void AddTrait(Trait item);

        public TraitBuilder Trait(string name, List<DAST.Type> typeParams)
        {
            return new TraitBuilder(this, name, typeParams);
        }
    }

    public
      class TraitBuilder : ClassLike
    {
        readonly TraitContainer parent;
        readonly string name;
        readonly List<DAST.Type> typeParams;
        readonly List<DAST.Method> body = new();

        public TraitBuilder(TraitContainer parent, string name, List<DAST.Type> typeParams)
        {
            this.parent = parent;
            this.name = name;
            this.typeParams = typeParams;
        }

        public void AddMethod(DAST.Method item)
        {
            // remove existing method with the same name, because we're going to define an implementation
            for (int i = MutateCSharp.Schemata221.ReplaceNumericConstant_1(2L, 0); MutateCSharp.Schemata221.ReplaceBinExprOp_2(6L, i, body.Count); MutateCSharp.Schemata221.ReplacePostfixUnaryExprOp_3(11L, ref i))
            {
                if (MutateCSharp.Schemata221.ReplaceBinExprOp_4(12L, () => body[i].is_Method, () => body[i].dtor_name.Equals(item.dtor_name)))
                {
                    body.RemoveAt(i);
                    break;
                }
            }

            body.Add(item);
        }

        public void AddField(DAST.Formal item, _IOption<DAST._IExpression> defaultValue)
        {
            throw new UnsupportedFeatureException(Token.NoToken, Feature.RunAllTests);
        }

        public object Finish()
        {
            parent.AddTrait((Trait)Trait.create(
              Sequence<Rune>.UnicodeFromString(this.name),
              Sequence<DAST.Type>.FromArray(typeParams.ToArray()),
              Sequence<DAST.Method>.FromArray(body.ToArray()))
            );
            return parent;
        }
    }

    public
      interface NewtypeContainer : Container
    {
        void AddNewtype(Newtype item);

        public NewtypeBuilder Newtype(string name, List<DAST.Type> typeParams,
          DAST.Type baseType, DAST.NewtypeRange newtypeRange, List<DAST.Statement> witnessStmts, DAST.Expression witness)
        {
            return new NewtypeBuilder(this, name, typeParams, newtypeRange, baseType, witnessStmts, witness);
        }
    }

    public
      class NewtypeBuilder : ClassLike
    {
        readonly NewtypeContainer parent;
        readonly string name;
        readonly List<DAST.Type> typeParams;
        readonly DAST.Type baseType;
        private readonly DAST.NewtypeRange newtypeRange;
        readonly List<DAST.Statement> witnessStmts;
        readonly DAST.Expression witness;

        public NewtypeBuilder(NewtypeContainer parent, string name, List<DAST.Type> typeParams,
          DAST.NewtypeRange newtypeRange, DAST.Type baseType, List<DAST.Statement> statements, DAST.Expression witness)
        {
            this.parent = parent;
            this.name = name;
            this.typeParams = typeParams;
            this.newtypeRange = newtypeRange;
            this.baseType = baseType;
            this.witnessStmts = statements;
            this.witness = witness;
        }

        public void AddMethod(DAST.Method item)
        {
            throw new UnsupportedFeatureException(Token.NoToken, Feature.RunAllTests);
        }

        public void AddField(DAST.Formal item, _IOption<DAST._IExpression> defaultValue)
        {
            throw new UnsupportedFeatureException(Token.NoToken, Feature.RunAllTests);
        }

        public object Finish()
        {
            parent.AddNewtype((Newtype)Newtype.create(
              Sequence<Rune>.UnicodeFromString(this.name),
              Sequence<DAST.Type>.FromArray(this.typeParams.ToArray()),
              this.baseType,
              newtypeRange,
              Sequence<DAST.Statement>.FromArray(this.witnessStmts.ToArray()),
      MutateCSharp.Schemata221.ReplaceBinExprOp_5(18L, this.witness, null) ? Option<DAST._IExpression>.create_None() : Option<DAST._IExpression>.create_Some(this.witness)
            ));
            return parent;
        }
    }

    public
      interface DatatypeContainer : Container
    {
        void AddDatatype(Datatype item);

        public DatatypeBuilder Datatype(string name, string enclosingModule, List<DAST.Type> typeParams, List<DAST.DatatypeCtor> ctors, bool isCo)
        {
            return new DatatypeBuilder(this, name, enclosingModule, typeParams, ctors, isCo);
        }
    }

    public
      class DatatypeBuilder : ClassLike
    {
        readonly DatatypeContainer parent;
        readonly string name;
        readonly string enclosingModule;
        readonly List<DAST.Type> typeParams;
        readonly List<DAST.DatatypeCtor> ctors;
        readonly bool isCo;
        readonly List<DAST.Method> body = new();

        public DatatypeBuilder(DatatypeContainer parent, string name, string enclosingModule, List<DAST.Type> typeParams, List<DAST.DatatypeCtor> ctors, bool isCo)
        {
            this.parent = parent;
            this.name = name;
            this.typeParams = typeParams;
            this.enclosingModule = enclosingModule;
            this.ctors = ctors;
            this.isCo = isCo;
        }

        public void AddMethod(DAST.Method item)
        {
            body.Add(item);
        }

        public void AddField(DAST.Formal item, _IOption<DAST._IExpression> defaultValue)
        {
            throw new UnsupportedFeatureException(Token.NoToken, Feature.RunAllTests);
        }

        public object Finish()
        {
            parent.AddDatatype((Datatype)Datatype.create(
              Sequence<Rune>.UnicodeFromString(this.name),
              Sequence<Rune>.UnicodeFromString(this.enclosingModule),
              Sequence<DAST.Type>.FromArray(typeParams.ToArray()),
              Sequence<DAST.DatatypeCtor>.FromArray(ctors.ToArray()),
              Sequence<DAST.Method>.FromArray(body.ToArray()),
              this.isCo
            ));
            return parent;
        }
    }

    public
      interface ClassLike
    {
        void AddMethod(DAST.Method item);

        void AddField(DAST.Formal item, _IOption<DAST._IExpression> defaultValue);

        public MethodBuilder Method(
          bool isStatic, bool hasBody,
          ISequence<ISequence<Rune>> overridingPath,
          string name,
          List<DAST.Type> typeArgs,
          List<DAST.Formal> params_,
          List<DAST.Type> outTypes, List<ISequence<Rune>> outVars
        )
        {
            return new MethodBuilder(this, isStatic, hasBody, overridingPath, name, typeArgs, params_, outTypes, outVars);
        }

        public object Finish();
    }

    public
      class MethodBuilder : StatementContainer
    {
        readonly ClassLike parent;
        readonly string name;
        readonly bool isStatic;
        readonly bool hasBody;
        readonly ISequence<ISequence<Rune>> overridingPath;
        readonly List<DAST.Type> typeArgs;
        readonly List<DAST.Formal> params_;
        readonly List<DAST.Type> outTypes;
        readonly List<ISequence<Rune>> outVars;
        readonly List<object> body = new();

        public MethodBuilder(
          ClassLike parent,
          bool isStatic, bool hasBody,
          ISequence<ISequence<Rune>> overridingPath,
          string name,
          List<DAST.Type> typeArgs,
          List<DAST.Formal> params_,
          List<DAST.Type> outTypes, List<ISequence<Rune>> outVars
        )
        {
            this.parent = parent;
            this.isStatic = isStatic;
            this.hasBody = hasBody;
            this.overridingPath = overridingPath;
            this.name = name;
            this.typeArgs = typeArgs;
            this.params_ = params_;
            this.outTypes = outTypes;
            this.outVars = outVars;
        }

        public List<object> ForkList()
        {
            var ret = new List<object>();
            body.Add(ret);
            return ret;
        }

        public void AddStatement(DAST.Statement item)
        {
            body.Add(item);
        }

        public void AddBuildable(BuildableStatement item)
        {
            body.Add(item);
        }

        public DAST.Method Build()
        {
            List<DAST.Statement> builtStatements = new();
            StatementContainer.RecursivelyBuild(body, builtStatements);

            return (DAST.Method)DAST.Method.create(
              isStatic,
              hasBody,
      MutateCSharp.Schemata221.ReplaceBinExprOp_6(19L, overridingPath, null) ? Option<ISequence<ISequence<Rune>>>.create_Some(overridingPath) : Option<ISequence<ISequence<Rune>>>.create_None(),
              Sequence<Rune>.UnicodeFromString(this.name),
              Sequence<DAST.Type>.FromArray(typeArgs.ToArray()),
              Sequence<DAST.Formal>.FromArray(params_.ToArray()),
              Sequence<DAST.Statement>.FromArray(builtStatements.ToArray()),
              Sequence<DAST.Type>.FromArray(outTypes.ToArray()),
      MutateCSharp.Schemata221.ReplaceBinExprOp_7(20L, outVars, null) ? Option<ISequence<ISequence<Rune>>>.create_Some(Sequence<ISequence<Rune>>.FromArray(outVars.ToArray())) : Option<ISequence<ISequence<Rune>>>.create_None()
            );
        }

        public void AddUnsupported(string why)
        {
            AddStatement(StatementContainer.UnsupportedToStatement(why));
        }
    }

    public
      interface StatementContainer : Container
    {
        void AddStatement(DAST.Statement item);

        void AddBuildable(BuildableStatement item);

        public static DAST.Statement UnsupportedToStatement(string why)
        {
            return (DAST.Statement)DAST.Statement.create_Print(ExprContainer.UnsupportedToExpr(why));
        }

        List<object> ForkList();

        public StatementContainer Fork()
        {
            return new ForkedStatementContainer(ForkList());
        }

        protected static void RecursivelyBuild(List<object> body, List<DAST.Statement> builtStatements)
        {
            foreach (var maybeBuilt in body)
            {
                if (maybeBuilt is DAST.Statement built)
                {
                    builtStatements.Add(built);
                }
                else if (maybeBuilt is BuildableStatement buildable)
                {
                    builtStatements.Add(buildable.Build());
                }
                else if (maybeBuilt is List<object> rec)
                {
                    RecursivelyBuild(rec, builtStatements);
                }
                else
                {
                    throw new InvalidOperationException(MutateCSharp.Schemata221.ReplaceStringConstant_8(21L, "Unknown buildable type"));
                }
            }
        }

        public void Print(DAST.Expression expr)
        {
            AddStatement((DAST.Statement)DAST.Statement.create_Print(expr));
        }

        public AssignBuilder Assign()
        {
            var ret = new AssignBuilder();
            AddBuildable(ret);
            return ret;
        }

        public DeclareBuilder DeclareAndAssign(DAST.Type type, string name)
        {
            var ret = new DeclareBuilder(type, name);
            AddBuildable(ret);
            return ret;
        }

        public IfElseBuilder IfElse()
        {
            var ret = new IfElseBuilder();
            AddBuildable(ret);
            return ret;
        }

        public WhileBuilder While()
        {
            var ret = new WhileBuilder();
            AddBuildable(ret);
            return ret;
        }

        public ForeachBuilder Foreach(string boundName, DAST.Type boundType)
        {
            var ret = new ForeachBuilder(boundName, boundType);
            AddBuildable(ret);
            return ret;
        }

        public TailRecursiveBuilder TailRecursive()
        {
            var ret = new TailRecursiveBuilder();
            AddBuildable(ret);
            return ret;
        }

        public CallStmtBuilder Call()
        {
            var ret = new CallStmtBuilder();
            AddBuildable(ret);
            return ret;
        }

        public ReturnBuilder Return()
        {
            var ret = new ReturnBuilder();
            AddBuildable(ret);
            return ret;
        }

        public LabeledBuilder Labeled(string label)
        {
            var ret = new LabeledBuilder(label);
            AddBuildable(ret);
            return ret;
        }
    }

    public
      interface BuildableStatement
    {
        DAST.Statement Build();
    }

    public
      class ForkedStatementContainer : StatementContainer
    {
        readonly List<object> list;

        public ForkedStatementContainer(List<object> list)
        {
            this.list = list;
        }

        public void AddStatement(DAST.Statement item)
        {
            list.Add(item);
        }

        public void AddBuildable(BuildableStatement item)
        {
            list.Add(item);
        }

        public List<object> ForkList()
        {
            var ret = new List<object>();
            list.Add(ret);
            return ret;
        }

        public void AddUnsupported(string why)
        {
            AddStatement(StatementContainer.UnsupportedToStatement(why));
        }
    }

    public
      class DeclareBuilder : ExprContainer, BuildableStatement
    {
        readonly DAST.Type type;
        readonly string name;
        public object value;

        public DeclareBuilder(DAST.Type type, string name)
        {
            this.type = type;
            this.name = name;
        }

        public void AddExpr(DAST.Expression value)
        {
            if (this.value != null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                this.value = value;
            }
        }

        public void AddBuildable(BuildableExpr value)
        {
            if (this.value != null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                this.value = value;
            }
        }

        public DAST.Statement Build()
        {
            if (this.value == null)
            {
                return (DAST.Statement)DAST.Statement.create_DeclareVar(Sequence<Rune>.UnicodeFromString(name), type, Option<DAST._IExpression>.create_None());
            }
            else
            {
                var builtValue = new List<DAST.Expression>();
                ExprContainer.RecursivelyBuild(new List<object> { value }, builtValue);
                return (DAST.Statement)DAST.Statement.create_DeclareVar(Sequence<Rune>.UnicodeFromString(name), type, Option<DAST._IExpression>.create_Some(builtValue[MutateCSharp.Schemata221.ReplaceNumericConstant_1(22L, 0)]));
            }

            return default;
        }

        public void AddUnsupported(string why)
        {
            AddExpr(Compilers.ExprContainer.UnsupportedToExpr(why));
        }
    }

    public
      class AssignBuilder : LhsContainer, ExprContainer, BuildableStatement
    {
        object lhs = null;
        public object value;

        public void AddLhs(DAST.AssignLhs lhs)
        {
            if (MutateCSharp.Schemata221.ReplaceBinExprOp_4(27L, () => this.lhs != null, () => MutateCSharp.Schemata221.ReplaceBinExprOp_9(26L, this.lhs, lhs)))
            {
                throw new InvalidOperationException(MutateCSharp.Schemata221.ReplaceStringConstant_8(33L, "Cannot change name of variable in assignment: ") + this.lhs + MutateCSharp.Schemata221.ReplaceStringConstant_8(34L, " -> ") + lhs);
            }
            else
            {
                this.lhs = lhs;
            }
        }

        public void AddBuildable(BuildableLhs lhs)
        {
            if (MutateCSharp.Schemata221.ReplaceBinExprOp_4(36L, () => this.lhs != null, () => MutateCSharp.Schemata221.ReplaceBinExprOp_10(35L, this.lhs, lhs)))
            {
                throw new InvalidOperationException(MutateCSharp.Schemata221.ReplaceStringConstant_8(42L, "Cannot change name of variable in assignment: ") + this.lhs + MutateCSharp.Schemata221.ReplaceStringConstant_8(43L, " -> ") + lhs);
            }
            else
            {
                this.lhs = lhs;
            }
        }

        public void AddExpr(DAST.Expression value)
        {
            if (this.value != null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                this.value = value;
            }
        }

        public void AddBuildable(BuildableExpr value)
        {
            if (this.value != null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                this.value = value;
            }
        }
        public void AddUnsupported(string why)
        {
            AddExpr(Compilers.ExprContainer.UnsupportedToExpr(why));
        }

        public DAST.Statement Build()
        {

            var builtLhs = LhsContainer.Build(lhs);
            DAST.Expression rhs;
            if (this.value == null)
            {
                rhs = ExprContainer.UnsupportedToExpr(MutateCSharp.Schemata221.ReplaceStringConstant_8(44L, "<i>Cannot assign null value to variable</i>: ") + lhs);
            }
            else
            {
                var builtValue = new List<DAST.Expression>();
                ExprContainer.RecursivelyBuild(new List<object> { value }, builtValue);
                rhs = builtValue[MutateCSharp.Schemata221.ReplaceNumericConstant_1(45L, 0)];
            }

            return (DAST.Statement)DAST.Statement.create_Assign(builtLhs, rhs);
        }
    }

    public
      class IfElseBuilder : ExprContainer, StatementContainer, BuildableStatement
    {
        object condition = null;
        readonly List<object> ifBody = new();
        readonly List<object> elseBody = new();

        public IfElseBuilder() { }

        public void AddExpr(DAST.Expression value)
        {
            if (condition != null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                condition = value;
            }
        }

        public void AddBuildable(BuildableExpr value)
        {
            if (condition != null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                condition = value;
            }
        }

        public void AddStatement(DAST.Statement item)
        {
            ifBody.Add(item);
        }

        public void AddBuildable(BuildableStatement item)
        {
            ifBody.Add(item);
        }

        public List<object> ForkList()
        {
            var ret = new List<object>();
            this.ifBody.Add(ret);
            return ret;
        }

        public void AddElseStatement(DAST.Statement item)
        {
            elseBody.Add(item);
        }

        public void AddElseBuildable(BuildableStatement item)
        {
            elseBody.Add(item);
        }

        public List<object> ElseForkList()
        {
            var ret = new List<object>();
            this.elseBody.Add(ret);
            return ret;
        }

        public ElseBuilder Else()
        {
            return new ElseBuilder(this);
        }

        public DAST.Statement Build()
        {
            List<DAST.Expression> builtCondition = new();
            ExprContainer.RecursivelyBuild(new List<object> {
        condition ?? ExprContainer.UnsupportedToExpr(MutateCSharp.Schemata221.ReplaceStringConstant_8(49L, "<i>condition to if expression</i>"))
      }, builtCondition);

            List<DAST.Statement> builtIfStatements = new();
            StatementContainer.RecursivelyBuild(ifBody, builtIfStatements);

            List<DAST.Statement> builtElseStatements = new();
            StatementContainer.RecursivelyBuild(elseBody, builtElseStatements);

            return (DAST.Statement)DAST.Statement.create_If(
              builtCondition[MutateCSharp.Schemata221.ReplaceNumericConstant_1(50L, 0)],
              Sequence<DAST.Statement>.FromArray(builtIfStatements.ToArray()),
              Sequence<DAST.Statement>.FromArray(builtElseStatements.ToArray())
            );
        }

        public void AddUnsupported(string why)
        {
            condition = ExprContainer.UnsupportedToExpr(why);
        }
    }

    public
      class ElseBuilder : StatementContainer
    {
        public readonly IfElseBuilder parent;

        public ElseBuilder(IfElseBuilder parent)
        {
            this.parent = parent;
        }

        public List<object> ForkList()
        {
            return parent.ElseForkList();
        }

        public void AddStatement(DAST.Statement item)
        {
            parent.AddElseStatement(item);
        }

        public void AddBuildable(BuildableStatement item)
        {
            parent.AddElseBuildable(item);
        }

        public void AddUnsupported(string why)
        {
            AddStatement(StatementContainer.UnsupportedToStatement(why));
        }
    }

    public
      class WhileBuilder : ExprContainer, StatementContainer, BuildableStatement
    {
        object condition = null;
        readonly List<object> body = new();

        public void AddExpr(DAST.Expression value)
        {
            if (condition != null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                condition = value;
            }
        }

        public void AddBuildable(BuildableExpr value)
        {
            if (condition != null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                condition = value;
            }
        }

        public void AddStatement(DAST.Statement item)
        {
            body.Add(item);
        }

        public void AddBuildable(BuildableStatement item)
        {
            body.Add(item);
        }

        public List<object> ForkList()
        {
            var ret = new List<object>();
            this.body.Add(ret);
            return ret;
        }

        public DAST.Statement Build()
        {
            List<DAST.Expression> builtCondition = new();
            ExprContainer.RecursivelyBuild(new List<object> { condition }, builtCondition);

            List<DAST.Statement> builtStatements = new();
            StatementContainer.RecursivelyBuild(body, builtStatements);

            return (DAST.Statement)DAST.Statement.create_While(
              builtCondition[MutateCSharp.Schemata221.ReplaceNumericConstant_1(54L, 0)],
              Sequence<DAST.Statement>.FromArray(builtStatements.ToArray())
            );
        }

        public void AddUnsupported(string why)
        {
            AddStatement(StatementContainer.UnsupportedToStatement(why));
        }
    }

    public
      class ForeachBuilder : ExprContainer, StatementContainer, BuildableStatement
    {
        readonly string boundName;
        readonly DAST.Type boundType;
        object over = null;
        readonly List<object> body = new();

        public ForeachBuilder(string boundName, DAST.Type boundType)
        {
            this.boundName = boundName;
            this.boundType = boundType;
        }

        public void AddExpr(DAST.Expression value)
        {
            if (over != null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                over = value;
            }
        }

        public void AddBuildable(BuildableExpr value)
        {
            if (over != null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                over = value;
            }
        }

        public void AddStatement(DAST.Statement item)
        {
            body.Add(item);
        }

        public void AddBuildable(BuildableStatement item)
        {
            body.Add(item);
        }

        public List<object> ForkList()
        {
            var ret = new List<object>();
            this.body.Add(ret);
            return ret;
        }

        public DAST.Statement Build()
        {
            List<DAST.Expression> builtOver = new();
            ExprContainer.RecursivelyBuild(new List<object> {
        over ?? ExprContainer.UnsupportedToExpr(MutateCSharp.Schemata221.ReplaceStringConstant_8(58L, "<i>Foreach over is null</i>"))
      }, builtOver);

            List<DAST.Statement> builtStatements = new();
            StatementContainer.RecursivelyBuild(body, builtStatements);

            return (DAST.Statement)DAST.Statement.create_Foreach(
              Sequence<Rune>.UnicodeFromString(boundName),
              boundType,
              builtOver[MutateCSharp.Schemata221.ReplaceNumericConstant_1(59L, 0)],
              Sequence<DAST.Statement>.FromArray(builtStatements.ToArray())
            );
        }

        public void AddUnsupported(string why)
        {
            AddStatement(StatementContainer.UnsupportedToStatement(why));
        }
    }

    public
      class TailRecursiveBuilder : StatementContainer, BuildableStatement
    {
        readonly List<object> body = new();

        public TailRecursiveBuilder() { }

        public void AddStatement(DAST.Statement item)
        {
            body.Add(item);
        }

        public void AddBuildable(BuildableStatement item)
        {
            body.Add(item);
        }

        public List<object> ForkList()
        {
            var ret = new List<object>();
            this.body.Add(ret);
            return ret;
        }

        public DAST.Statement Build()
        {
            List<DAST.Statement> builtStatements = new();
            StatementContainer.RecursivelyBuild(body, builtStatements);

            return (DAST.Statement)DAST.Statement.create_TailRecursive(
              Sequence<DAST.Statement>.FromArray(builtStatements.ToArray())
            );
        }

        public void AddUnsupported(string why)
        {
            AddStatement(StatementContainer.UnsupportedToStatement(why));
        }
    }

    public
      class CallStmtBuilder : ExprContainer, BuildableStatement
    {
        object on = null;
        DAST.CallName name = null;
        List<DAST.Type> typeArgs = null;
        readonly List<object> args = new();
        List<ISequence<Rune>> outs = null;

        public CallStmtBuilder() { }

        public void SetName(CallName name)
        {
            if (MutateCSharp.Schemata221.ReplaceBinExprOp_11(63L, this.name, null))
            {
                throw new InvalidOperationException();
            }
            else
            {
                this.name = name;
            }
        }

        public void SetTypeArgs(List<DAST.Type> typeArgs)
        {
            if (MutateCSharp.Schemata221.ReplaceBinExprOp_12(64L, this.typeArgs, null))
            {
                throw new InvalidOperationException();
            }
            else
            {
                this.typeArgs = typeArgs;
            }
        }

        public void AddExpr(DAST.Expression value)
        {
            if (on == null)
            {
                on = value;
            }
            else
            {
                args.Add(value);
            }
        }

        public void AddBuildable(BuildableExpr value)
        {
            if (on == null)
            {
                on = value;
            }
            else
            {
                args.Add(value);
            }
        }

        public void SetOuts(List<ISequence<Rune>> outs)
        {
            if (MutateCSharp.Schemata221.ReplaceBinExprOp_7(65L, this.outs, null))
            {
                throw new InvalidOperationException();
            }
            else
            {
                this.outs = outs;
            }
        }

        public DAST.Statement Build()
        {
            List<DAST.Expression> builtOn = new();
            ExprContainer.RecursivelyBuild(new List<object> { on }, builtOn);

            List<DAST.Expression> builtArgs = new();
            ExprContainer.RecursivelyBuild(args, builtArgs);

            return (DAST.Statement)DAST.Statement.create_Call(
              builtOn[MutateCSharp.Schemata221.ReplaceNumericConstant_1(66L, 0)],
              name,
              Sequence<DAST.Type>.FromArray(typeArgs.ToArray()),
              Sequence<DAST.Expression>.FromArray(builtArgs.ToArray()),
      MutateCSharp.Schemata221.ReplaceBinExprOp_13(70L, outs, null) ? Option<ISequence<ISequence<Rune>>>.create_None() : Option<ISequence<ISequence<Rune>>>.create_Some(Sequence<ISequence<Rune>>.FromArray(outs.ToArray()))
            );
        }

        public void AddUnsupported(string why)
        {
            AddExpr(ExprContainer.UnsupportedToExpr(why));
        }
    }

    public
      class ReturnBuilder : ExprContainer, BuildableStatement
    {
        object value = null;

        public ReturnBuilder() { }

        public void AddExpr(DAST.Expression value)
        {
            if (this.value != null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                this.value = value;
            }
        }

        public void AddBuildable(BuildableExpr value)
        {
            if (this.value != null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                this.value = value;
            }
        }

        public DAST.Statement Build()
        {
            var builtValue = new List<DAST.Expression>();
            if (value == null)
            {
                return (DAST.Statement)DAST.Statement.create_EarlyReturn();
            }
            ExprContainer.RecursivelyBuild(new List<object> { value }, builtValue);

            return (DAST.Statement)DAST.Statement.create_Return(builtValue[MutateCSharp.Schemata221.ReplaceNumericConstant_1(71L, 0)]);
        }

        public void AddUnsupported(string why)
        {
            value = ExprContainer.UnsupportedToExpr(why);
        }
    }

    public
      class LabeledBuilder : BuildableStatement, StatementContainer
    {
        readonly string label;
        readonly List<object> statements = new();

        public LabeledBuilder(string label)
        {
            this.label = label;
        }

        public void AddStatement(DAST.Statement item)
        {
            statements.Add(item);
        }

        public void AddBuildable(BuildableStatement item)
        {
            statements.Add(item);
        }

        public StatementContainer Fork()
        {
            return new ForkedStatementContainer(ForkList());
        }

        public List<object> ForkList()
        {
            var ret = new List<object>();
            statements.Add(ret);
            return ret;
        }

        public DAST.Statement Build()
        {
            List<DAST.Statement> builtStatements = new();
            StatementContainer.RecursivelyBuild(statements, builtStatements);

            return (DAST.Statement)DAST.Statement.create_Labeled(
              Sequence<Rune>.UnicodeFromString(label),
              Sequence<DAST.Statement>.FromArray(builtStatements.ToArray())
            );
        }

        public void AddUnsupported(string why)
        {
            AddStatement(StatementContainer.UnsupportedToStatement(why));
        }
    }

    public
      class StatementBuffer : StatementContainer
    {
        readonly List<object> statements = new();

        public void AddStatement(DAST.Statement item)
        {
            statements.Add(item);
        }

        public void AddBuildable(BuildableStatement item)
        {
            statements.Add(item);
        }

        public List<object> ForkList()
        {
            var ret = new List<object>();
            statements.Add(ret);
            return ret;
        }

        public List<DAST.Statement> PopAll()
        {
            var builtResult = new List<DAST.Statement>();
            StatementContainer.RecursivelyBuild(statements, builtResult);

            return builtResult;
        }

        public void AddUnsupported(string why)
        {
            AddStatement(StatementContainer.UnsupportedToStatement(why));
        }
    }

    public
      class ExprBuffer : ExprContainer, BuildableExpr
    {
        Stack<object> exprs = new();
        public readonly object parent;

        public ExprBuffer(object returnTo)
        {
            this.parent = returnTo;
        }

        public void AddExpr(DAST.Expression item)
        {
            exprs.Push(item);
        }

        public void AddBuildable(BuildableExpr item)
        {
            exprs.Push(item);
        }

        public List<DAST.Expression> PopN(int n)
        {
            if (MutateCSharp.Schemata221.ReplaceBinExprOp_2(75L, exprs.Count, n))
            {
                throw new InvalidOperationException();
            }
            else
            {
                var result = new List<object>();
                for (int i = MutateCSharp.Schemata221.ReplaceNumericConstant_1(80L, 0); MutateCSharp.Schemata221.ReplaceBinExprOp_2(84L, i, n); MutateCSharp.Schemata221.ReplacePostfixUnaryExprOp_3(89L, ref i))
                {
                    result.Insert(MutateCSharp.Schemata221.ReplaceNumericConstant_1(90L, 0), exprs.Pop());
                }

                var builtResult = new List<DAST.Expression>();
                ExprContainer.RecursivelyBuild(result, builtResult);

                return builtResult;
            }

            return default;
        }

        public List<DAST.Expression> PopAll()
        {
            return PopN(exprs.Count);
        }

        public DAST.Expression Finish()
        {
            if (MutateCSharp.Schemata221.ReplaceBinExprOp_14(98L, exprs.Count, MutateCSharp.Schemata221.ReplaceNumericConstant_1(94L, 1)))
            {
                return ExprContainer.UnsupportedToExpr(MutateCSharp.Schemata221.ReplaceStringConstant_8(103L, "Expected exactly one expression in buffer, got ") +
                                                       exprs.Comma(e => e.ToString()));
                throw new UnsupportedFeatureException(Token.NoToken, Feature.RunAllTests); // Warning: this is an invalid operation
                                                                                           //throw new InvalidOperationException("Expected exactly one expression in buffer, got " + exprs.Comma(e => e.ToString()));
            }
            else
            {
                return PopN(MutateCSharp.Schemata221.ReplaceNumericConstant_1(104L, 1))[MutateCSharp.Schemata221.ReplaceNumericConstant_1(108L, 0)];
            }

            return default;
        }

        public void AddUnsupported(string why)
        {
            AddExpr(ExprContainer.UnsupportedToExpr(why));
        }

        public DAST.Expression Build()
        {
            return Finish();
        }
    }

    public
      interface ExprContainer : Container
    {
        void AddExpr(DAST.Expression item);

        void AddBuildable(BuildableExpr item);

        BinOpBuilder BinOp(DAST.BinOp op)
        {
            var ret = new BinOpBuilder(op);
            AddBuildable(ret);
            return ret;
        }

        BinOpBuilder BinOp(string op, Func<DAST.Expression, DAST.Expression, DAST.Expression> callback)
        {
            var ret = new BinOpBuilder(op, callback);
            AddBuildable(ret);
            return ret;
        }

        CallExprBuilder Call()
        {
            var ret = new CallExprBuilder();
            AddBuildable(ret);
            return ret;
        }

        ApplyExprBuilder Apply()
        {
            var ret = new ApplyExprBuilder();
            AddBuildable(ret);
            return ret;
        }

        LambdaExprBuilder Lambda(List<DAST.Formal> formals, DAST.Type retType)
        {
            var ret = new LambdaExprBuilder(formals, retType);
            AddBuildable(ret);
            return ret;
        }

        IIFEExprBuilder IIFE(string name, DAST.Type tpe)
        {
            var ret = new IIFEExprBuilder(name, tpe);
            AddBuildable(ret);
            return ret;
        }

        BetaRedexBuilder BetaRedex(List<_System.Tuple2<DAST.Formal, DAST.Expression>> bindings, DAST.Type retType)
        {
            var ret = new BetaRedexBuilder(bindings, retType);
            AddBuildable(ret);
            return ret;
        }

        ConvertBuilder Convert(DAST.Type fromType, DAST.Type toType)
        {
            var ret = new ConvertBuilder(fromType, toType);
            AddBuildable(ret);
            return ret;
        }

        IndexBuilder Index(List<DAST.Expression> indices, DAST._ICollKind collKind)
        {
            var ret = new IndexBuilder(indices, collKind);
            AddBuildable(ret);
            return ret;
        }

        protected static void RecursivelyBuild(List<object> body, List<DAST.Expression> builtExprs)
        {
            foreach (var maybeBuilt in body)
            {
                if (maybeBuilt is DAST.Expression built)
                {
                    builtExprs.Add(built);
                }
                else if (maybeBuilt is BuildableExpr buildable)
                {
                    builtExprs.Add(buildable.Build());
                }
                else
                {
                    throw new InvalidOperationException(
          MutateCSharp.Schemata221.ReplaceStringConstant_8(112L, "Unknown buildable type: ") +
                      (maybeBuilt == null ? MutateCSharp.Schemata221.ReplaceStringConstant_8(113L, "NULL") :
                       maybeBuilt.GetType())
                      );
                }
            }
        }

        static DAST.Expression UnsupportedToExpr(string why)
        {
            return (DAST.Expression)DAST.Expression.create_Ident(
              Sequence<ISequence<Rune>>.UnicodeFromString($"<b>Unsupported: {why}</b>")
            );
        }
    }

    public
      interface LhsContainer : Container
    {
        void AddLhs(DAST.AssignLhs lhs);

        void AddBuildable(BuildableLhs lhs);

        ArrayLhs Array(List<DAST.Expression> indices)
        {
            var ret = new ArrayLhs(indices);
            AddBuildable(ret);
            return ret;
        }

        protected static DAST.AssignLhs Build(object maybeBuilt)
        {
            if (maybeBuilt is DAST.AssignLhs built)
            {
                return built;
            }
            else if (maybeBuilt is BuildableLhs buildable)
            {
                return buildable.Build();
            }
            else
            {
                throw new InvalidOperationException(MutateCSharp.Schemata221.ReplaceStringConstant_8(114L, "Unknown buildable type: ") + maybeBuilt.GetType());
            }

            return default;
        }
    }

    public
      interface BuildableLhs
    {
        DAST.AssignLhs Build();
    }

    public
      class ArrayLhs : BuildableLhs, ExprContainer
    {
        readonly List<DAST.Expression> indices;
        object arrayExpr = null;
        readonly System.Diagnostics.StackTrace stackTrace = new(MutateCSharp.Schemata221.ReplaceBooleanConstant_0(115L, true));

        public ArrayLhs(List<DAST.Expression> indices)
        {
            this.indices = indices;
        }

        public void AddExpr(DAST.Expression item)
        {
            if (arrayExpr != null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                arrayExpr = item;
            }
        }

        public void AddBuildable(BuildableExpr item)
        {
            if (arrayExpr != null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                arrayExpr = item;
            }
        }

        public DAST.AssignLhs Build()
        {
            if (arrayExpr == null)
            {
                Console.WriteLine(stackTrace);
            }
            var builtArrayExpr = new List<DAST.Expression>();
            ExprContainer.RecursivelyBuild(new List<object> { arrayExpr }, builtArrayExpr);

            return (DAST.AssignLhs)DAST.AssignLhs.create_Index(builtArrayExpr[MutateCSharp.Schemata221.ReplaceNumericConstant_1(116L, 0)], Sequence<DAST.Expression>.FromArray(indices.ToArray()));
        }

        public void AddUnsupported(string why)
        {
            arrayExpr = ExprContainer.UnsupportedToExpr(why);
        }
    }

    public
      interface BuildableExpr
    {
        DAST.Expression Build();
    }

    public
      class BinOpBuilder : ExprContainer, BuildableExpr
    {
        private readonly Func<DAST.Expression, DAST.Expression, DAST.Expression> internalBuilder;
        readonly List<object> operands = new();
        private readonly string op;

        public BinOpBuilder(DAST.BinOp op)
        {
            this.internalBuilder = (DAST.Expression left, DAST.Expression right) =>
              (DAST.Expression)DAST.Expression.create_BinOp(op, left, right, new BinaryOpFormat_NoFormat());
            this.op = op.ToString();
        }

        public BinOpBuilder(string op, Func<DAST.Expression, DAST.Expression, DAST.Expression> callback)
        {
            this.op = op;
            internalBuilder = callback;
        }

        public void AddExpr(DAST.Expression item)
        {
            operands.Add(item);
        }

        public void AddBuildable(BuildableExpr item)
        {
            operands.Add(item);
        }

        public DAST.Expression Build()
        {
            var builtOperands = new List<DAST.Expression>();
            ExprContainer.RecursivelyBuild(operands, builtOperands);

            if (MutateCSharp.Schemata221.ReplaceBinExprOp_14(124L, operands.Count, MutateCSharp.Schemata221.ReplaceNumericConstant_1(120L, 2)))
            {
                builtOperands.Insert(MutateCSharp.Schemata221.ReplaceNumericConstant_1(129L, 0), ExprContainer.UnsupportedToExpr(op + MutateCSharp.Schemata221.ReplaceStringConstant_8(133L, " with not 2 elements")));
                return (DAST.Expression)DAST.Expression.create_SetValue(
                  Sequence<DAST.Expression>.FromElements(builtOperands.ToArray()));
            }

            return internalBuilder(builtOperands[MutateCSharp.Schemata221.ReplaceNumericConstant_1(134L, 0)], builtOperands[MutateCSharp.Schemata221.ReplaceNumericConstant_1(138L, 1)]);
        }

        public void AddUnsupported(string why)
        {
            AddExpr(ExprContainer.UnsupportedToExpr(why));
        }
    }

    public
      class CallExprBuilder : ExprContainer, BuildableExpr
    {
        object on = null;
        DAST.CallName name = null;
        List<DAST.Type> typeArgs = null;
        readonly List<object> args = new();
        List<ISequence<Rune>> outs = null;

        public CallExprBuilder() { }

        public void SetName(DAST.CallName name)
        {
            if (MutateCSharp.Schemata221.ReplaceBinExprOp_11(142L, this.name, null))
            {
                throw new InvalidOperationException();
            }
            else
            {
                this.name = name;
            }
        }

        public void SetTypeArgs(List<DAST.Type> typeArgs)
        {
            if (MutateCSharp.Schemata221.ReplaceBinExprOp_12(143L, this.typeArgs, null))
            {
                throw new InvalidOperationException();
            }
            else
            {
                this.typeArgs = typeArgs;
            }
        }

        public void AddExpr(DAST.Expression value)
        {
            if (on == null)
            {
                on = value;
            }
            else
            {
                args.Add(value);
            }
        }

        public void AddBuildable(BuildableExpr value)
        {
            if (on == null)
            {
                on = value;
            }
            else
            {
                args.Add(value);
            }
        }

        public void SetOuts(List<ISequence<Rune>> outs)
        {
            if (MutateCSharp.Schemata221.ReplaceBinExprOp_7(144L, this.outs, null))
            {
                throw new InvalidOperationException();
            }
            else
            {
                this.outs = outs;
            }
        }

        public DAST.Expression Build()
        {
            var builtOn = new List<DAST.Expression>();
            ExprContainer.RecursivelyBuild(new List<object> { on }, builtOn);

            var builtArgs = new List<DAST.Expression>();
            ExprContainer.RecursivelyBuild(args, builtArgs);

            return (DAST.Expression)DAST.Expression.create_Call(
              builtOn[MutateCSharp.Schemata221.ReplaceNumericConstant_1(145L, 0)],
              name,
              Sequence<DAST.Type>.FromArray((typeArgs ?? new()).ToArray()),
              Sequence<DAST.Expression>.FromArray(builtArgs.ToArray())
            );
        }

        public void AddUnsupported(string why)
        {
            AddExpr(ExprContainer.UnsupportedToExpr(why));
        }
    }

    public
      class ApplyExprBuilder : ExprContainer, BuildableExpr
    {
        object on = null;
        readonly List<object> args = new();

        public ApplyExprBuilder() { }

        public void AddExpr(DAST.Expression value)
        {
            if (on == null)
            {
                on = value;
            }
            else
            {
                args.Add(value);
            }
        }

        public void AddBuildable(BuildableExpr value)
        {
            if (on == null)
            {
                on = value;
            }
            else
            {
                args.Add(value);
            }
        }

        public DAST.Expression Build()
        {
            var builtOn = new List<DAST.Expression>();
            ExprContainer.RecursivelyBuild(new List<object> { on }, builtOn);

            var builtArgs = new List<DAST.Expression>();
            ExprContainer.RecursivelyBuild(args, builtArgs);

            return (DAST.Expression)DAST.Expression.create_Apply(
              builtOn[MutateCSharp.Schemata221.ReplaceNumericConstant_1(149L, 0)],
              Sequence<DAST.Expression>.FromArray(builtArgs.ToArray())
            );
        }

        public void AddUnsupported(string why)
        {
            AddExpr(ExprContainer.UnsupportedToExpr(why));
        }
    }

    public
      class LambdaExprBuilder : StatementContainer, BuildableExpr
    {
        readonly List<DAST.Formal> formals;
        readonly DAST.Type retType;
        readonly List<object> body = new();

        public LambdaExprBuilder(List<DAST.Formal> formals, DAST.Type retType)
        {
            this.formals = formals;
            this.retType = retType;
        }

        public void AddStatement(DAST.Statement item)
        {
            body.Add(item);
        }

        public void AddBuildable(BuildableStatement item)
        {
            body.Add(item);
        }

        public List<object> ForkList()
        {
            var ret = new List<object>();
            body.Add(ret);
            return ret;
        }

        public DAST.Expression Build()
        {
            var builtBody = new List<DAST.Statement>();
            StatementContainer.RecursivelyBuild(body, builtBody);

            return (DAST.Expression)DAST.Expression.create_Lambda(
              Sequence<DAST.Formal>.FromArray(formals.ToArray()),
              retType,
              Sequence<DAST.Statement>.FromArray(builtBody.ToArray())
            );
        }

        public void AddUnsupported(string why)
        {
            AddStatement(StatementContainer.UnsupportedToStatement(why));
        }
    }

    public
      class IIFEExprBuilder : ExprContainer, BuildableExpr
    {
        readonly string name;
        readonly DAST.Type tpe;

        object body = null;
        public object value = null;

        public IIFEExprBuilder(string name, DAST.Type tpe)
        {
            this.name = name;
            this.tpe = tpe;
        }

        public IIFEExprRhs RhsBuilder()
        {
            return new IIFEExprRhs(this);
        }

        public void AddExpr(DAST.Expression item)
        {
            if (body != null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                body = item;
            }
        }

        public void AddBuildable(BuildableExpr item)
        {
            if (body != null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                body = item;
            }
        }

        public DAST.Expression Build()
        {
            var builtBody = new List<DAST.Expression>();
            ExprContainer.RecursivelyBuild(new List<object> { body }, builtBody);

            var builtValue = new List<DAST.Expression>();
            ExprContainer.RecursivelyBuild(new List<object> { value
       ?? ExprContainer.UnsupportedToExpr(MutateCSharp.Schemata221.ReplaceStringConstant_8(153L, "IIFEExprBuilder with empty value"))
       }, builtValue);

            return (DAST.Expression)DAST.Expression.create_IIFE(
              Sequence<Rune>.UnicodeFromString(name),
              tpe,
              builtValue[MutateCSharp.Schemata221.ReplaceNumericConstant_1(154L, 0)],
              builtBody[MutateCSharp.Schemata221.ReplaceNumericConstant_1(158L, 0)]
            );
        }

        public void AddUnsupported(string why)
        {
            AddExpr(ExprContainer.UnsupportedToExpr(why));
        }
    }

    public
      class IIFEExprRhs : ExprContainer
    {
        readonly IIFEExprBuilder parent;

        public IIFEExprRhs(IIFEExprBuilder parent)
        {
            this.parent = parent;
        }

        public void AddExpr(DAST.Expression item)
        {
            if (parent.value != null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                parent.value = item;
            }
        }

        public void AddBuildable(BuildableExpr item)
        {
            if (parent.value != null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                parent.value = item;
            }
        }

        public void AddUnsupported(string why)
        {
            AddExpr(ExprContainer.UnsupportedToExpr(why));
        }
    }

    public
      class BetaRedexBuilder : ExprContainer, BuildableExpr
    {
        readonly List<_System.Tuple2<DAST.Formal, DAST.Expression>> bindings;
        readonly DAST.Type retType;
        object body = null;

        public BetaRedexBuilder(List<_System.Tuple2<DAST.Formal, DAST.Expression>> bindings, DAST.Type retType)
        {
            this.bindings = bindings;
            this.retType = retType;
        }

        public void AddExpr(DAST.Expression item)
        {
            body = item;
        }

        public void AddBuildable(BuildableExpr item)
        {
            body = item;
        }

        public DAST.Expression Build()
        {
            var builtBody = new List<DAST.Expression>();
            ExprContainer.RecursivelyBuild(new List<object> { body }, builtBody);

            return (DAST.Expression)DAST.Expression.create_BetaRedex(
              Sequence<_System.Tuple2<DAST.Formal, DAST.Expression>>.FromArray(bindings.ToArray()),
              retType,
              builtBody[MutateCSharp.Schemata221.ReplaceNumericConstant_1(162L, 0)]
            );
        }

        public void AddUnsupported(string why)
        {
            AddExpr(ExprContainer.UnsupportedToExpr(why));
        }
    }

    public
      class ConvertBuilder : ExprContainer, BuildableExpr
    {
        readonly DAST.Type fromType;
        readonly DAST.Type toType;
        object value = null;

        public ConvertBuilder(DAST.Type fromType, DAST.Type toType)
        {
            this.fromType = fromType;
            this.toType = toType;
        }

        public void AddExpr(DAST.Expression item)
        {
            if (value != null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                value = item;
            }
        }

        public void AddBuildable(BuildableExpr item)
        {
            if (value != null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                value = item;
            }
        }

        public DAST.Expression Build()
        {
            var builtValue = new List<DAST.Expression>();
            DAST.Expression v;
            if (value == null)
            {
                v = ExprContainer.UnsupportedToExpr($"Conversion from {fromType} to {toType} of something missing");
            }
            else
            {
                ExprContainer.RecursivelyBuild(new List<object> { value }, builtValue);
                v = builtValue[MutateCSharp.Schemata221.ReplaceNumericConstant_1(166L, 0)];
            }

            return (DAST.Expression)DAST.Expression.create_Convert(
              v,
              fromType,
              toType
            );
        }

        public void AddUnsupported(string why)
        {
            AddExpr(ExprContainer.UnsupportedToExpr(why));
        }
    }

    public
      class IndexBuilder : ExprContainer, BuildableExpr
    {
        readonly List<DAST.Expression> indices;
        readonly DAST._ICollKind collKind;
        object value = null;

        public IndexBuilder(List<DAST.Expression> indices, DAST._ICollKind collKind)
        {
            this.indices = indices;
            this.collKind = collKind;
        }

        public void AddExpr(DAST.Expression item)
        {
            if (value != null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                value = item;
            }
        }

        public void AddBuildable(BuildableExpr item)
        {
            if (value != null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                value = item;
            }
        }

        public DAST.Expression Build()
        {
            var builtValue = new List<DAST.Expression>();
            ExprContainer.RecursivelyBuild(new List<object> { value }, builtValue);

            return (DAST.Expression)DAST.Expression.create_Index(
              builtValue[MutateCSharp.Schemata221.ReplaceNumericConstant_1(170L, 0)],
              collKind,
              Sequence<DAST.Expression>.FromArray(indices.ToArray())
            );
        }

        public void AddUnsupported(string why)
        {
            AddExpr(ExprContainer.UnsupportedToExpr(why));
        }
    }

}
