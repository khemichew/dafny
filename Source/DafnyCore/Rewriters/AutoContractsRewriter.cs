using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata441
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT441");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceNumericConstant_5(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.SetType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_18(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_20(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.Field argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.IToken argument1, Microsoft.Dafny.IToken argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.Field argument1, object argument2)
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

        internal static bool ReplaceBinExprOp_2(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.Function argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static int ReplacePrefixUnaryExprOp_14(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return --argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return +argument1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return ~argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return ++argument1; }
            return --argument1;
        }

    }
}

namespace Microsoft.Dafny
{

    /// <summary>
    /// AutoContracts is an experimental feature that will fill much of the dynamic-frames boilerplate
    /// into a class.  From the user's perspective, what needs to be done is simply:
    ///  - mark the class with {:autocontracts}
    ///  - declare a function (or predicate) called Valid()
    ///
    /// AutoContracts will then:
    ///
    /// Declare, unless there already exist members with these names:
    ///    ghost var Repr: set(object)
    ///    predicate Valid()
    ///
    /// For function/predicate Valid(), insert:
    ///    reads this, Repr
    ///    ensures Valid() ==> this in Repr
    /// Into body of Valid(), insert (at the beginning of the body):
    ///    this in Repr && null !in Repr
    /// and also insert, for every array-valued field A declared in the class:
    ///    (A != null ==> A in Repr) &&
    /// and for every field F of a class type T where T has a field called Repr, also insert:
    ///    (F != null ==> F in Repr && F.Repr SUBSET Repr && this !in Repr && F.Valid())
    /// Except, if A or F is declared with {:autocontracts false}, then the implication will not
    /// be added.
    ///
    /// For every constructor, add:
    ///    ensures Valid() && fresh(Repr)
    /// At the end of the body of the constructor, add:
    ///    Repr := {this};
    ///    if (A != null) { Repr := Repr + {A}; }
    ///    if (F != null) { Repr := Repr + {F} + F.Repr; }
    ///
    /// In all the following cases, no "modifies" clause or "reads" clause is added if the user
    /// has given one.
    ///
    /// For every non-static non-ghost method that is not a "simple query method",
    /// add:
    ///    requires Valid()
    ///    modifies Repr
    ///    ensures Valid() && fresh(Repr - old(Repr))
    /// At the end of the body of the method, add:
    ///    if (A != null && !(A in Repr)) { Repr := Repr + {A}; }
    ///    if (F != null && !(F in Repr && F.Repr SUBSET Repr)) { Repr := Repr + {F} + F.Repr; }
    /// For every non-static non-twostate method that is either ghost or is a "simple query method",
    /// add:
    ///    requires Valid()
    /// For every non-static twostate method, add:
    ///    requires old(Valid())
    ///
    /// For every non-"Valid" non-static function, add:
    ///    requires Valid()
    ///    reads Repr
    /// </summary>
    public class AutoContractsRewriter : IRewriter
    {
        private readonly SystemModuleManager systemModuleManager;
        public AutoContractsRewriter(Program program, ErrorReporter reporter)
          : base(reporter)
        {
            Contract.Requires(reporter != null);
            Contract.Requires(systemModuleManager != null);
            systemModuleManager = program.SystemModuleManager;
        }

        internal override void PreResolve(ModuleDefinition m)
        {
            foreach (var d in m.TopLevelDecls)
            {
                bool sayYes = MutateCSharp.Schemata441.ReplaceBooleanConstant_0(1L, true);
                if (d is ClassLikeDecl && Attributes.ContainsBool(d.Attributes, MutateCSharp.Schemata441.ReplaceStringConstant_1(2L, "autocontracts"), ref sayYes) && sayYes)
                {
                    ProcessClassPreResolve((TopLevelDeclWithMembers)d);
                }
            }
        }

        void ProcessClassPreResolve(TopLevelDeclWithMembers cl)
        {
            var range = cl.NameNode.RangeToken.MakeAutoGenerated();
            // Add:  ghost var Repr: set<object>
            // ...unless a field with that name is already present
            if (!cl.Members.Exists(member => MutateCSharp.Schemata441.ReplaceBinExprOp_3(5L, () => member is Field, () => MutateCSharp.Schemata441.ReplaceBinExprOp_2(4L, member.Name, MutateCSharp.Schemata441.ReplaceStringConstant_1(3L, "Repr")))))
            {
                Type ty = systemModuleManager.ObjectSetType();
                var repr = new Field(range, new Name(range, MutateCSharp.Schemata441.ReplaceStringConstant_1(11L, "Repr")), MutateCSharp.Schemata441.ReplaceBooleanConstant_0(12L, true), ty, null);
                cl.Members.Add(repr);
                AddHoverText(cl.tok, MutateCSharp.Schemata441.ReplaceStringConstant_1(13L, "{0}"), Printer.FieldToString(Reporter.Options, repr));
            }
            // Add:  predicate Valid()
            // ...unless an instance function with that name is already present
            if (!cl.Members.Exists(member => MutateCSharp.Schemata441.ReplaceBinExprOp_3(22L, () => MutateCSharp.Schemata441.ReplaceBinExprOp_3(16L, () => member is Function, () => MutateCSharp.Schemata441.ReplaceBinExprOp_2(15L, member.Name, MutateCSharp.Schemata441.ReplaceStringConstant_1(14L, "Valid"))), () => !member.IsStatic)))
            {
                var valid = new Predicate(range, new Name(cl.NameNode.RangeToken, MutateCSharp.Schemata441.ReplaceStringConstant_1(28L, "Valid")), MutateCSharp.Schemata441.ReplaceBooleanConstant_0(29L, false), MutateCSharp.Schemata441.ReplaceBooleanConstant_0(30L, true), MutateCSharp.Schemata441.ReplaceBooleanConstant_0(31L, false), new List<TypeParameter>(), new List<Formal>(), null,
                  new List<AttributedExpression>(), new Specification<FrameExpression>(), new List<AttributedExpression>(), new Specification<Expression>(new List<Expression>(), null),
                  null, Predicate.BodyOriginKind.OriginalOrInherited, null, null, null, null);
                cl.Members.Add(valid);
                // It will be added to hover text later
            }

            foreach (var member in cl.Members)
            {
                bool sayYes = MutateCSharp.Schemata441.ReplaceBooleanConstant_0(32L, true);
                if (Attributes.ContainsBool(member.Attributes, MutateCSharp.Schemata441.ReplaceStringConstant_1(33L, "autocontracts"), ref sayYes) && !sayYes)
                {
                    // the user has excluded this member
                    continue;
                }
                if (MutateCSharp.Schemata441.ReplaceBinExprOp_4(34L, member.RefinementBase, null))
                {
                    // member is inherited from a module where it was already processed
                    continue;
                }
                IToken tok = new AutoGeneratedToken(member.tok);
                if (MutateCSharp.Schemata441.ReplaceBinExprOp_3(43L, () => MutateCSharp.Schemata441.ReplaceBinExprOp_3(37L, () => member is Function, () => MutateCSharp.Schemata441.ReplaceBinExprOp_2(36L, member.Name, MutateCSharp.Schemata441.ReplaceStringConstant_1(35L, "Valid"))), () => !member.IsStatic))
                {
                    var valid = (Function)member;
                    // reads this, Repr
                    var r0 = new ThisExpr(tok);
                    var r1 = CreateUnresolvedThisRepr(tok);
                    valid.Reads.Expressions.Add(new FrameExpression(tok, r0, null));
                    valid.Reads.Expressions.Add(new FrameExpression(tok, r1, null));
                    // ensures Valid() ==> this in Repr
                    var post = new BinaryExpr(tok, BinaryExpr.Opcode.Imp,
                      CreateUnresolvedValidCall(tok),
                      new BinaryExpr(tok, BinaryExpr.Opcode.In,
                        new ThisExpr(tok),
                        CreateUnresolvedThisRepr(tok)));
                    valid.Ens.Insert(MutateCSharp.Schemata441.ReplaceNumericConstant_5(49L, 0), new AttributedExpression(post));
                    if (MutateCSharp.Schemata441.ReplaceBinExprOp_6(53L, member.tok, cl.tok))
                    {
                        // We added this function above, so produce a hover text for the entire function signature
                        AddHoverText(cl.tok, MutateCSharp.Schemata441.ReplaceStringConstant_1(54L, "{0}"), Printer.FunctionSignatureToString(Reporter.Options, valid));
                    }
                    else
                    {
                        AddHoverText(member.tok, MutateCSharp.Schemata441.ReplaceStringConstant_1(55L, "reads {0}, {1}\nensures {2}"), r0, r1, post);
                    }
                }
                else if (MutateCSharp.Schemata441.ReplaceBinExprOp_3(56L, () => member is Function, () => !member.IsStatic))
                {
                    var f = (Function)member;
                    // requires Valid()
                    var valid = CreateUnresolvedValidCall(tok);
                    f.Req.Insert(MutateCSharp.Schemata441.ReplaceNumericConstant_5(62L, 0), new AttributedExpression(valid));
                    var format = MutateCSharp.Schemata441.ReplaceStringConstant_1(66L, "requires {0}");
                    var repr = CreateUnresolvedThisRepr(tok);
                    if (MutateCSharp.Schemata441.ReplaceBinExprOp_7(71L, f.Reads.Expressions.Count, MutateCSharp.Schemata441.ReplaceNumericConstant_5(67L, 0)))
                    {
                        // reads Repr
                        f.Reads.Expressions.Add(new FrameExpression(tok, repr, null));
                        format += MutateCSharp.Schemata441.ReplaceStringConstant_1(76L, "\nreads {1}");
                    }
                    AddHoverText(member.tok, format, valid, repr);
                }
                else if (member is Constructor)
                {
                    var ctor = (Constructor)member;
                    // ensures Valid();
                    var valid = CreateUnresolvedValidCall(tok);
                    ctor.Ens.Insert(MutateCSharp.Schemata441.ReplaceNumericConstant_5(77L, 0), new AttributedExpression(valid));
                    // ensures fresh(Repr);
                    var freshness = new FreshExpr(tok, CreateUnresolvedThisRepr(tok));
                    ctor.Ens.Insert(MutateCSharp.Schemata441.ReplaceNumericConstant_5(81L, 1), new AttributedExpression(freshness));
                    var m0 = new ThisExpr(tok);
                    AddHoverText(member.tok, MutateCSharp.Schemata441.ReplaceStringConstant_1(85L, "modifies {0}\nensures {1} && {2}"), m0, valid, freshness);
                }
            }
        }

        internal override void PostResolveIntermediate(ModuleDefinition m)
        {
            foreach (var d in m.TopLevelDecls)
            {
                bool sayYes = MutateCSharp.Schemata441.ReplaceBooleanConstant_0(86L, true);
                if (d is ClassLikeDecl && Attributes.ContainsBool(d.Attributes, MutateCSharp.Schemata441.ReplaceStringConstant_1(87L, "autocontracts"), ref sayYes) && sayYes)
                {
                    ProcessClassPostResolve((ClassLikeDecl)d);
                }
            }
        }

        void ProcessClassPostResolve(ClassLikeDecl cl)
        {
            // Find all fields of a reference type, and make a note of whether or not the reference type has a Repr field.
            // Also, find the Repr field and the function Valid in class "cl"
            Field ReprField = null;
            Function Valid = null;
            var subobjects = new List<Tuple<Field, Field, Function>>();
            foreach (var member in cl.Members)
            {
                var field = member as Field;
                if (MutateCSharp.Schemata441.ReplaceBinExprOp_8(88L, field, null))
                {
                    var sayYes = MutateCSharp.Schemata441.ReplaceBooleanConstant_0(89L, true);
                    if (MutateCSharp.Schemata441.ReplaceBinExprOp_2(91L, field.Name, MutateCSharp.Schemata441.ReplaceStringConstant_1(90L, "Repr")))
                    {
                        ReprField = field;
                    }
                    else if (Attributes.ContainsBool(field.Attributes, MutateCSharp.Schemata441.ReplaceStringConstant_1(92L, "autocontracts"), ref sayYes) && !sayYes)
                    {
                        // ignore this field
                    }
                    else if (field.Type.IsRefType)
                    {
                        var rcl = (ClassLikeDecl)((UserDefinedType)field.Type.NormalizeExpand()).ResolvedClass;
                        Field rRepr = null;
                        Function rValid = null;
                        foreach (var memb in rcl.Members)
                        {
                            if (memb is Field { Name: "Repr" } f)
                            {
                                var t = f.Type.AsSetType;
                                if (MutateCSharp.Schemata441.ReplaceBinExprOp_3(94L, () => MutateCSharp.Schemata441.ReplaceBinExprOp_9(93L, t, null), () => t.Arg.IsObjectQ))
                                {
                                    rRepr = f;
                                }
                            }
                            else if (memb is Function { IsStatic: false, Name: "Valid" } fn)
                            {
                                if (MutateCSharp.Schemata441.ReplaceBinExprOp_3(109L, () => MutateCSharp.Schemata441.ReplaceBinExprOp_7(104L, fn.Ins.Count, MutateCSharp.Schemata441.ReplaceNumericConstant_5(100L, 0)), () => fn.ResultType.IsBoolType))
                                {
                                    rValid = fn;
                                }
                            }
                            if (MutateCSharp.Schemata441.ReplaceBinExprOp_3(117L, () => MutateCSharp.Schemata441.ReplaceBinExprOp_8(115L, rRepr, null), () => MutateCSharp.Schemata441.ReplaceBinExprOp_10(116L, rValid, null)))
                            {
                                break;
                            }
                        }
                        subobjects.Add(new Tuple<Field, Field, Function>(field, rRepr, rValid));
                    }
                }
                else if (member is Function { IsStatic: false, Name: "Valid" } validFunction)
                {
                    if (MutateCSharp.Schemata441.ReplaceBinExprOp_3(132L, () => MutateCSharp.Schemata441.ReplaceBinExprOp_7(127L, validFunction.Ins.Count, MutateCSharp.Schemata441.ReplaceNumericConstant_5(123L, 0)), () => validFunction.ResultType.IsBoolType))
                    {
                        Valid = validFunction;
                    }
                }
            }
            Contract.Assert(ReprField != null);  // we expect there to be a "Repr" field, since we added one in PreResolve

            IToken clTok = new AutoGeneratedToken(cl.tok);
            Type ty = ModuleResolver.GetThisType(clTok, cl);
            var self = new ThisExpr(clTok)
            {
                Type = ty
            };
            var implicitSelf = new ImplicitThisExpr(clTok)
            {
                Type = ty
            };
            var Repr = CreateResolvedFieldSelect(clTok, implicitSelf, ReprField);

            foreach (var member in cl.Members)
            {
                bool sayYes = MutateCSharp.Schemata441.ReplaceBooleanConstant_0(138L, true);
                if (Attributes.ContainsBool(member.Attributes, MutateCSharp.Schemata441.ReplaceStringConstant_1(139L, "autocontracts"), ref sayYes) && !sayYes)
                {
                    continue;
                }
                IToken tok = new AutoGeneratedToken(member.tok);
                if (MutateCSharp.Schemata441.ReplaceBinExprOp_3(148L, () => MutateCSharp.Schemata441.ReplaceBinExprOp_3(142L, () => member is Function, () => MutateCSharp.Schemata441.ReplaceBinExprOp_2(141L, member.Name, MutateCSharp.Schemata441.ReplaceStringConstant_1(140L, "Valid"))), () => !member.IsStatic))
                {
                    var valid = (Function)member;
                    var validConjuncts = new List<Expression>();
                    if (MutateCSharp.Schemata441.ReplaceBinExprOp_3(154L, () => valid.IsGhost, () => valid.ResultType.IsBoolType))
                    {
                        if (MutateCSharp.Schemata441.ReplaceBinExprOp_11(160L, valid.RefinementBase, null))
                        {
                            var c0 = BinBoolExpr(tok, BinaryExpr.ResolvedOpcode.InSet, self, Repr);  // this in Repr
                            var c1 = BinBoolExpr(tok, BinaryExpr.ResolvedOpcode.NotInSet, new LiteralExpr(tok) { Type = systemModuleManager.ObjectQ() }, Repr);  // null !in Repr
                            var c = BinBoolExpr(tok, BinaryExpr.ResolvedOpcode.And, c0, c1);
                            validConjuncts.Add(c);
                        }

                        foreach (var ff in subobjects)
                        {
                            if (MutateCSharp.Schemata441.ReplaceBinExprOp_4(161L, ff.Item1.RefinementBase, null))
                            {
                                // the field has been inherited from a refined module, so don't include it here
                                continue;
                            }
                            var F = CreateResolvedFieldSelect(tok, implicitSelf, ff.Item1);
                            var c0 = IsNotNull(tok, F);
                            var c1 = BinBoolExpr(tok, BinaryExpr.ResolvedOpcode.InSet, F, Repr);
                            if (MutateCSharp.Schemata441.ReplaceBinExprOp_12(162L, ff.Item2, null))
                            {
                                // F != null ==> F in Repr  (so, nothing else to do)
                            }
                            else
                            {
                                // F != null ==> F in Repr && F.Repr <= Repr && this !in F.Repr && F.Valid()
                                var FRepr = CreateResolvedFieldSelect(tok, F, ff.Item2);
                                var c2 = BinBoolExpr(tok, BinaryExpr.ResolvedOpcode.Subset, FRepr, Repr);
                                var c3 = BinBoolExpr(tok, BinaryExpr.ResolvedOpcode.NotInSet, self, FRepr);
                                c1 = BinBoolExpr(tok, BinaryExpr.ResolvedOpcode.And, c1,
                                  BinBoolExpr(tok, BinaryExpr.ResolvedOpcode.And, c2, c3));
                                if (MutateCSharp.Schemata441.ReplaceBinExprOp_10(163L, ff.Item3, null))
                                {
                                    // F.Valid()
                                    c1 = BinBoolExpr(tok, BinaryExpr.ResolvedOpcode.And, c1,
                                      CreateResolvedValidCall(tok, F, ff.Item3, valid));
                                }
                            }
                            validConjuncts.Add(Expression.CreateImplies(c0, c1));
                        }

                        var hoverText = "";
                        var sep = "";
                        if (MutateCSharp.Schemata441.ReplaceBinExprOp_13(164L, valid.Body, null))
                        {
                            valid.Body = Expression.CreateBoolLiteral(tok, MutateCSharp.Schemata441.ReplaceBooleanConstant_0(165L, true));
                            if (MutateCSharp.Schemata441.ReplaceBinExprOp_7(170L, validConjuncts.Count, MutateCSharp.Schemata441.ReplaceNumericConstant_5(166L, 0)))
                            {
                                hoverText = MutateCSharp.Schemata441.ReplaceStringConstant_1(175L, "true");
                                sep = MutateCSharp.Schemata441.ReplaceStringConstant_1(176L, "\n");
                            }
                        }
                        for (int i = validConjuncts.Count; MutateCSharp.Schemata441.ReplaceBinExprOp_15(185L, MutateCSharp.Schemata441.ReplaceNumericConstant_5(177L, 0), MutateCSharp.Schemata441.ReplacePrefixUnaryExprOp_14(181L, ref i));)
                        {
                            var c = validConjuncts[i];
                            valid.Body = BinBoolExpr(tok, BinaryExpr.ResolvedOpcode.And, c, valid.Body);
                            hoverText = Printer.ExprToString(Reporter.Options, c) + sep + hoverText;
                            sep = MutateCSharp.Schemata441.ReplaceStringConstant_1(190L, "\n");
                        }
                        AddHoverText(valid.tok, MutateCSharp.Schemata441.ReplaceStringConstant_1(191L, "{0}"), hoverText);
                    }

                }
                else if (member is Constructor)
                {
                    var ctor = (Constructor)member;
                    if (MutateCSharp.Schemata441.ReplaceBinExprOp_16(192L, ctor.Body, null))
                    {
                        var sbs = (DividedBlockStmt)ctor.Body;
                        var n = sbs.Body.Count;
                        if (MutateCSharp.Schemata441.ReplaceBinExprOp_11(193L, ctor.RefinementBase, null))
                        {
                            // Repr := {this};
                            var e = new SetDisplayExpr(tok, MutateCSharp.Schemata441.ReplaceBooleanConstant_0(194L, true), new List<Expression>() { self });
                            e.Type = systemModuleManager.ObjectSetType();
                            Statement s = new AssignStmt(member.RangeToken, Repr, new ExprRhs(e));
                            s.IsGhost = MutateCSharp.Schemata441.ReplaceBooleanConstant_0(195L, true);
                            sbs.AppendStmt(s);
                        }
                        AddSubobjectReprs(tok, ctor.RangeToken.EndToken, subobjects, sbs, n, implicitSelf, Repr);
                    }

                }
                else if (MutateCSharp.Schemata441.ReplaceBinExprOp_3(203L, () => MutateCSharp.Schemata441.ReplaceBinExprOp_3(196L, () => member is Method, () => !member.IsStatic), () => MutateCSharp.Schemata441.ReplaceBinExprOp_10(202L, Valid, null)))
                {
                    var m = (Method)member;
                    var addStatementsToUpdateRepr = MutateCSharp.Schemata441.ReplaceBooleanConstant_0(209L, false);
                    if (MutateCSharp.Schemata441.ReplaceBinExprOp_17(210L, () => member.IsGhost, () => IsSimpleQueryMethod(m)))
                    {
                        if (MutateCSharp.Schemata441.ReplaceBinExprOp_11(216L, m.RefinementBase, null))
                        {
                            // requires Valid()
                            var valid = CreateResolvedValidCall(tok, implicitSelf, Valid, m);
                            if (m is TwoStateLemma)
                            {
                                // Instead use:  requires old(Valid())
                                valid = new OldExpr(tok, valid);
                                valid.Type = Type.Bool;
                            }
                            m.Req.Insert(MutateCSharp.Schemata441.ReplaceNumericConstant_5(217L, 0), new AttributedExpression(valid));
                            AddHoverText(member.tok, MutateCSharp.Schemata441.ReplaceStringConstant_1(221L, "requires {0}"), valid);
                        }
                    }
                    else if (MutateCSharp.Schemata441.ReplaceBinExprOp_11(222L, m.RefinementBase, null))
                    {
                        // requires Valid()
                        var valid = CreateResolvedValidCall(tok, implicitSelf, Valid, m);
                        m.Req.Insert(MutateCSharp.Schemata441.ReplaceNumericConstant_5(223L, 0), new AttributedExpression(valid));
                        var format = MutateCSharp.Schemata441.ReplaceStringConstant_1(227L, "requires {0}");
                        if (MutateCSharp.Schemata441.ReplaceBinExprOp_7(232L, m.Mod.Expressions.Count, MutateCSharp.Schemata441.ReplaceNumericConstant_5(228L, 0)))
                        {
                            // modifies Repr
                            m.Mod.Expressions.Add(new FrameExpression(Repr.tok, Repr, null));
                            format += MutateCSharp.Schemata441.ReplaceStringConstant_1(237L, "\nmodifies {1}");
                            addStatementsToUpdateRepr = MutateCSharp.Schemata441.ReplaceBooleanConstant_0(238L, true);
                        }
                        // ensures Valid()
                        m.Ens.Insert(MutateCSharp.Schemata441.ReplaceNumericConstant_5(239L, 0), new AttributedExpression(valid));
                        // ensures fresh(Repr - old(Repr));
                        var e0 = new OldExpr(tok, Repr);
                        e0.Type = Repr.Type;
                        var e1 = new BinaryExpr(tok, BinaryExpr.Opcode.Sub, Repr, e0);
                        e1.ResolvedOp = BinaryExpr.ResolvedOpcode.SetDifference;
                        e1.Type = Repr.Type;
                        var freshness = new FreshExpr(tok, e1);
                        freshness.Type = Type.Bool;
                        m.Ens.Insert(MutateCSharp.Schemata441.ReplaceNumericConstant_5(243L, 1), new AttributedExpression(freshness));
                        AddHoverText(m.tok, format + MutateCSharp.Schemata441.ReplaceStringConstant_1(247L, "\nensures {0} && {2}"), valid, Repr, freshness);
                    }
                    else
                    {
                        addStatementsToUpdateRepr = MutateCSharp.Schemata441.ReplaceBooleanConstant_0(248L, true);
                    }

                    if (MutateCSharp.Schemata441.ReplaceBinExprOp_3(250L, () => addStatementsToUpdateRepr, () => MutateCSharp.Schemata441.ReplaceBinExprOp_16(249L, m.Body, null)))
                    {
                        var methodBody = (BlockStmt)m.Body;
                        AddSubobjectReprs(tok, methodBody.RangeToken.EndToken, subobjects, methodBody, methodBody.Body.Count, implicitSelf, Repr);
                    }
                }
            }
        }

        void AddSubobjectReprs(IToken tok, IToken endCurlyTok, List<Tuple<Field, Field, Function>> subobjects, BlockStmt block, int hoverTextFromHere,
          Expression implicitSelf, Expression Repr)
        {
            Contract.Requires(tok != null);
            Contract.Requires(endCurlyTok != null);
            Contract.Requires(subobjects != null);
            Contract.Requires(block != null);
            Contract.Requires(0 <= hoverTextFromHere && hoverTextFromHere <= block.Body.Count);
            Contract.Requires(implicitSelf != null);
            Contract.Requires(Repr != null);
            // TODO: these assignments should be included on every return path

            foreach (var ff in subobjects)
            {
                var F = CreateResolvedFieldSelect(tok, implicitSelf, ff.Item1);  // create a resolved MemberSelectExpr
                Expression e = new SetDisplayExpr(tok, MutateCSharp.Schemata441.ReplaceBooleanConstant_0(256L, true), new List<Expression>() { F })
                {
                    Type = systemModuleManager.ObjectSetType()
                };
                var rhs = new BinaryExpr(tok, BinaryExpr.Opcode.Add, Repr, e)
                {
                    ResolvedOp = BinaryExpr.ResolvedOpcode.Union,
                    Type = Repr.Type
                };
                Expression nguard = BinBoolExpr(tok, BinaryExpr.ResolvedOpcode.InSet, F, Repr);  // F in Repr
                if (MutateCSharp.Schemata441.ReplaceBinExprOp_12(257L, ff.Item2, null))
                {
                    // Repr := Repr + {F}  (so, nothing else to do)
                }
                else
                {
                    // Repr := Repr + {F} + F.Repr
                    var FRepr = CreateResolvedFieldSelect(tok, F, ff.Item2);  // create resolved MemberSelectExpr
                    rhs = new BinaryExpr(tok, BinaryExpr.Opcode.Add, rhs, FRepr)
                    {
                        ResolvedOp = BinaryExpr.ResolvedOpcode.Union,
                        Type = Repr.Type
                    };
                    var ng = BinBoolExpr(tok, BinaryExpr.ResolvedOpcode.Subset, FRepr, Repr);  // F.Repr <= Repr
                    nguard = Expression.CreateAnd(nguard, ng);
                }
                // Repr := Repr + ...;
                Statement s = new AssignStmt(tok.ToRange(), Repr, new ExprRhs(rhs));
                s.IsGhost = MutateCSharp.Schemata441.ReplaceBooleanConstant_0(258L, true);
                // wrap if statement around s
                e = Expression.CreateAnd(IsNotNull(tok, F), Expression.CreateNot(tok, nguard));
                var thn = new BlockStmt(tok.ToRange(), new List<Statement>() { s });
                thn.IsGhost = MutateCSharp.Schemata441.ReplaceBooleanConstant_0(259L, true);
                s = new IfStmt(tok.ToRange(), MutateCSharp.Schemata441.ReplaceBooleanConstant_0(260L, false), e, thn, null);
                s.IsGhost = MutateCSharp.Schemata441.ReplaceBooleanConstant_0(261L, true);
                // finally, add s to the block
                block.AppendStmt(s);
            }
            if (MutateCSharp.Schemata441.ReplaceBinExprOp_18(262L, hoverTextFromHere, block.Body.Count))
            {
                var hoverText = "";
                var sep = "";
                for (int i = hoverTextFromHere; MutateCSharp.Schemata441.ReplaceBinExprOp_19(267L, i, block.Body.Count); MutateCSharp.Schemata441.ReplacePostfixUnaryExprOp_20(272L, ref i))
                {
                    hoverText += sep + Printer.StatementToString(Reporter.Options, block.Body[i]);
                    sep = MutateCSharp.Schemata441.ReplaceStringConstant_1(273L, "\n");
                }
                AddHoverText(endCurlyTok, MutateCSharp.Schemata441.ReplaceStringConstant_1(274L, "{0}"), hoverText);
            }
        }

        /// <summary>
        /// Returns an expression denoting "expr != null".  If the type
        /// of "expr" already implies "expr" is non-null, then an expression
        /// denoting "true" is returned.
        /// </summary>
        Expression IsNotNull(IToken tok, Expression expr)
        {
            Contract.Requires(tok != null);
            Contract.Requires(expr != null);
            if (expr.Type.IsNonNullRefType)
            {
                return Expression.CreateBoolLiteral(tok, MutateCSharp.Schemata441.ReplaceBooleanConstant_0(275L, true));
            }
            else
            {
                var cNull = new LiteralExpr(tok);
                cNull.Type = expr.Type;
                return BinBoolExpr(tok, BinaryExpr.ResolvedOpcode.NeqCommon, expr, cNull);
            }

            return default;
        }

        bool IsSimpleQueryMethod(Method m)
        {
            // A simple query method has out parameters, its body has no effect other than to assign to them,
            // and the postcondition does not explicitly mention the pre-state.
            return MutateCSharp.Schemata441.ReplaceBinExprOp_3(298L, () => MutateCSharp.Schemata441.ReplaceBinExprOp_3(292L, () => MutateCSharp.Schemata441.ReplaceBinExprOp_3(286L, () => MutateCSharp.Schemata441.ReplaceBinExprOp_18(280L, m.Outs.Count, MutateCSharp.Schemata441.ReplaceNumericConstant_5(276L, 0)), () => MutateCSharp.Schemata441.ReplaceBinExprOp_16(285L, m.Body, null)), () => LocalAssignsOnly(m.Body)), () => m.Ens.TrueForAll(mfe => !MentionsOldState(mfe.E)));
        }

        bool LocalAssignsOnly(Statement s)
        {
            Contract.Requires(s != null);
            if (s is AssignStmt)
            {
                var ss = (AssignStmt)s;
                return ss.Lhs.Resolved is IdentifierExpr;
            }
            else if (s is ConcreteUpdateStatement)
            {
                var ss = (ConcreteUpdateStatement)s;
                return ss.Lhss.TrueForAll(e => e.Resolved is IdentifierExpr);
            }
            else if (s is CallStmt)
            {
                return MutateCSharp.Schemata441.ReplaceBooleanConstant_0(304L, false);
            }
            else
            {
                foreach (var ss in s.SubStatements)
                {
                    if (!LocalAssignsOnly(ss))
                    {
                        return MutateCSharp.Schemata441.ReplaceBooleanConstant_0(305L, false);
                    }
                }
            }
            return MutateCSharp.Schemata441.ReplaceBooleanConstant_0(306L, true);
        }

        /// <summary>
        /// Returns true iff 'expr' is a two-state expression, that is, if it mentions "old/fresh/unchanged(...)".
        /// </summary>
        static bool MentionsOldState(Expression expr)
        {
            Contract.Requires(expr != null);
            if (MutateCSharp.Schemata441.ReplaceBinExprOp_17(313L, () => MutateCSharp.Schemata441.ReplaceBinExprOp_17(307L, () => expr is OldExpr, () => expr is UnchangedExpr), () => expr is FreshExpr))
            {
                return MutateCSharp.Schemata441.ReplaceBooleanConstant_0(319L, true);
            }
            foreach (var ee in expr.SubExpressions)
            {
                if (MentionsOldState(ee))
                {
                    return MutateCSharp.Schemata441.ReplaceBooleanConstant_0(320L, true);
                }
            }
            return MutateCSharp.Schemata441.ReplaceBooleanConstant_0(321L, false);
        }

        private static Expression CreateUnresolvedThisRepr(IToken tok)
        {
            return new ExprDotName(tok, new ImplicitThisExpr(tok), MutateCSharp.Schemata441.ReplaceStringConstant_1(322L, "Repr"), null);
        }

        public static Expression CreateUnresolvedValidCall(IToken tok)
        {
            return new ApplySuffix(tok, null,
              new ExprDotName(tok, new ImplicitThisExpr(tok), MutateCSharp.Schemata441.ReplaceStringConstant_1(323L, "Valid"), null),
              new List<ActualBinding>(), tok);
        }

        /// <summary>
        /// Returns a resolved expression of the form "receiver.Valid()"
        /// </summary>
        public Expression CreateResolvedValidCall(IToken tok, Expression receiver, Function Valid, ICallable callingContext)
        {
            Contract.Requires(tok != null);
            Contract.Requires(receiver != null);
            Contract.Requires(Valid != null);
            Contract.Requires(callingContext != null);
            Contract.Requires(receiver.Type.NormalizeExpand() is UserDefinedType udt && udt.ResolvedClass == Valid.EnclosingClass);
            Contract.Requires(receiver.Type.NormalizeExpand().TypeArgs.Count == Valid.EnclosingClass.TypeArgs.Count);

            callingContext.EnclosingModule.CallGraph.AddEdge((ICallable)CodeContextWrapper.Unwrap(callingContext), Valid);
            return Expression.CreateResolvedCall(tok, receiver, Valid, new List<Expression>(), new List<Type>(), systemModuleManager);
        }

        public static Expression CreateResolvedFieldSelect(IToken tok, Expression receiver, Field field)
        {
            var memberSelectExpr = new MemberSelectExpr(tok, receiver, field);
            return new ExprDotName(tok, receiver, field.Name, null)
            {
                ResolvedExpression = memberSelectExpr,
                Type = memberSelectExpr.Type
            };
        }

        public static BinaryExpr BinBoolExpr(IToken tok, BinaryExpr.ResolvedOpcode rop, Expression e0, Expression e1)
        {
            var p = new BinaryExpr(tok, BinaryExpr.ResolvedOp2SyntacticOp(rop), e0, e1);
            p.ResolvedOp = rop;  // resolve here
            p.Type = Type.Bool;  // resolve here
            return p;
        }

        void AddHoverText(IToken tok, string format, params object[] args)
        {
            Contract.Requires(tok != null);
            Contract.Requires(format != null);
            Contract.Requires(args != null);
            for (int i = MutateCSharp.Schemata441.ReplaceNumericConstant_5(324L, 0); MutateCSharp.Schemata441.ReplaceBinExprOp_19(328L, i, args.Length); MutateCSharp.Schemata441.ReplacePostfixUnaryExprOp_20(333L, ref i))
            {
                if (args[i] is Expression)
                {
                    args[i] = Printer.ExprToString(Reporter.Options, (Expression)args[i]);
                }
            }
            var s = MutateCSharp.Schemata441.ReplaceStringConstant_1(334L, "autocontracts:\n") + string.Format(format, args);
            Reporter.Info(MessageSource.Rewriter, tok, s.Replace(MutateCSharp.Schemata441.ReplaceStringConstant_1(335L, "\n"), MutateCSharp.Schemata441.ReplaceStringConstant_1(336L, "\n  ")));
        }
    }
}