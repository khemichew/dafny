using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata143
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT143");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.ActualBindings argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.CallStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.ActualBindings argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBooleanConstant_3(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.ActualBinding> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{

    /// <summary>
    /// A TypeRhs represents one of five things, each having to do with allocating something in the heap:
    ///  * new T[EE]
    ///    This allocates an array of objects of type T (where EE is a list of expression)
    ///  * new T[EE] (elementInit)
    ///    This is like the previous, but uses "elementInit" to initialize the elements of the new array.
    ///  * new T[E] [EE]
    ///    This is like the first one, but uses the elements displayed in the list EE as the initial
    ///    elements of the array.  Only a 1-dimensional array may be used in this case.  The size denoted
    ///    by E must equal the length of EE.
    ///  * new C
    ///    This allocates an object of type C
    ///  * new C.Init(EE)
    ///    This allocates an object of type C and then invokes the method/constructor Init on it
    /// There are three ways to construct a TypeRhs syntactically:
    ///  * TypeRhs(T, EE, initExpr)
    ///      -- represents "new T[EE]" (with "elementInit" being "null") and "new T[EE] (elementInit)"
    ///  * TypeRhs(T, E, EE)
    ///      -- represents "new T[E] [EE]"
    ///  * TypeRhs(C)
    ///      -- represents new C
    ///  * TypeRhs(Path, EE)
    ///    Here, Path may either be of the form C.Init
    ///      -- represents new C.Init(EE)
    ///    or all of Path denotes a type
    ///      -- represents new C._ctor(EE), where _ctor is the anonymous constructor for class C
    /// </summary>
    public class TypeRhs : AssignmentRhs, ICloneable<TypeRhs>
    {
        /// <summary>
        /// If ArrayDimensions != null, then the TypeRhs represents "new EType[ArrayDimensions]",
        ///     ElementInit is non-null to represent "new EType[ArrayDimensions] (elementInit)",
        ///     InitDisplay is non-null to represent "new EType[ArrayDimensions] [InitDisplay]",
        ///     and Arguments, Path, and InitCall are all null.
        /// If ArrayDimentions == null && Arguments == null, then the TypeRhs represents "new EType"
        ///     and ElementInit, Path, and InitCall are all null.
        /// If Arguments != null, then the TypeRhs represents "new Path(Arguments)"
        ///     and EType and InitCall is filled in by resolution, and ArrayDimensions == null and ElementInit == null.
        /// If OptionalNameComponent == null and Arguments != null, then the TypeRHS has not been resolved yet;
        ///   resolution will either produce an error or will chop off the last part of "EType" and move it to
        ///   OptionalNameComponent, after which the case above applies.
        /// </summary>
        [FilledInDuringResolution] public Type EType;  // in the case of Arguments != null
        public readonly List<Expression> ArrayDimensions;
        public readonly Expression ElementInit;
        public readonly List<Expression> InitDisplay;
        public readonly ActualBindings/*?*/ Bindings;
        public List<Expression> Arguments
        {
            get
            {
                Contract.Requires(Bindings != null);
                return Bindings.Arguments;
            }
        }

        public TypeRhs Clone(Cloner cloner)
        {
            return new TypeRhs(cloner, this);
        }

        public TypeRhs(Cloner cloner, TypeRhs original)
          : base(cloner, original)
        {
            EType = cloner.CloneType(original.EType);
            if (MutateCSharp.Schemata143.ReplaceBinExprOp_0(1L, original.ArrayDimensions, null))
            {
                if (MutateCSharp.Schemata143.ReplaceBinExprOp_0(2L, original.InitDisplay, null))
                {
                    Contract.Assert(original.ArrayDimensions.Count == 1);
                    ArrayDimensions = new List<Expression> { cloner.CloneExpr(original.ArrayDimensions[MutateCSharp.Schemata143.ReplaceNumericConstant_1(3L, 0)]) };
                    InitDisplay = original.InitDisplay.ConvertAll(cloner.CloneExpr);
                }
                else
                {
                    ArrayDimensions = original.ArrayDimensions.Select(cloner.CloneExpr).ToList();
                    ElementInit = cloner.CloneExpr(original.ElementInit);
                }
            }
            else if (MutateCSharp.Schemata143.ReplaceBinExprOp_2(7L, original.Bindings, null))
            {
            }
            else
            {
                Path = cloner.CloneType(original.Path);
                Bindings = new ActualBindings(cloner, original.Bindings);
            }

            if (cloner.CloneResolvedFields)
            {
                InitCall = cloner.CloneStmt(original.InitCall, MutateCSharp.Schemata143.ReplaceBooleanConstant_3(8L, false)) as CallStmt;
                Type = cloner.CloneType(original.Type);
            }
        }

        public Type Path;
        [FilledInDuringResolution] public CallStmt InitCall;  // may be null (and is definitely null for arrays),
        [FilledInDuringResolution] public PreType PreType;
        [FilledInDuringResolution] public Type Type;
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(EType != null || Bindings != null);
            Contract.Invariant(ElementInit == null || InitDisplay == null);
            Contract.Invariant(InitDisplay == null || ArrayDimensions.Count == 1);
            Contract.Invariant(ArrayDimensions == null || (Bindings == null && Path == null && InitCall == null && 1 <= ArrayDimensions.Count));
            Contract.Invariant(Bindings == null || (Path != null && ArrayDimensions == null && ElementInit == null && InitDisplay == null));
            Contract.Invariant(!(ArrayDimensions == null && Bindings == null) || (Path == null && InitCall == null && ElementInit == null && InitDisplay == null));
        }

        public TypeRhs(IToken tok, Type type, List<Expression> arrayDimensions, Expression elementInit)
          : base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(type != null);
            Contract.Requires(arrayDimensions != null && 1 <= arrayDimensions.Count);
            EType = type;
            ArrayDimensions = arrayDimensions;
            ElementInit = elementInit;
        }
        public TypeRhs(IToken tok, Type type, Expression dim, List<Expression> initDisplay)
          : base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(type != null);
            Contract.Requires(dim != null);
            Contract.Requires(initDisplay != null);
            EType = type;
            ArrayDimensions = new List<Expression> { dim };
            InitDisplay = initDisplay;
        }
        public TypeRhs(IToken tok, Type type)
          : base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(type != null);
            EType = type;
        }
        public TypeRhs(IToken tok, Type path, List<ActualBinding> arguments)
          : base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(path != null);
            Contract.Requires(arguments != null);
            Path = path;
            Bindings = new ActualBindings(arguments);
        }
        public override bool CanAffectPreviouslyKnownExpressions
        {
            get
            {
                if (MutateCSharp.Schemata143.ReplaceBinExprOp_4(9L, InitCall, null))
                {
                    foreach (var mod in InitCall.Method.Mod.Expressions)
                    {
                        if (!(mod.E is ThisExpr))
                        {
                            return MutateCSharp.Schemata143.ReplaceBooleanConstant_3(10L, true);
                        }
                    }
                }
                return MutateCSharp.Schemata143.ReplaceBooleanConstant_3(11L, false);
            }
        }

        public override IEnumerable<Expression> NonSpecificationSubExpressions
        {
            get
            {
                if (MutateCSharp.Schemata143.ReplaceBinExprOp_0(12L, ArrayDimensions, null))
                {
                    foreach (var e in ArrayDimensions)
                    {
                        yield return e;
                    }
                    if (MutateCSharp.Schemata143.ReplaceBinExprOp_5(13L, ElementInit, null))
                    {
                        yield return ElementInit;
                    }
                    if (MutateCSharp.Schemata143.ReplaceBinExprOp_0(14L, InitDisplay, null))
                    {
                        foreach (var e in InitDisplay)
                        {
                            yield return e;
                        }
                    }
                }

                if (MutateCSharp.Schemata143.ReplaceBinExprOp_7(17L, () => MutateCSharp.Schemata143.ReplaceBinExprOp_6(15L, Bindings, null), () => MutateCSharp.Schemata143.ReplaceBinExprOp_0(16L, Arguments, null)))
                {
                    foreach (var e in Arguments)
                    {
                        yield return e;
                    }
                }

                yield break;
            }
        }

        public override IEnumerable<Statement> SubStatements
        {
            get
            {
                if (MutateCSharp.Schemata143.ReplaceBinExprOp_4(23L, InitCall, null))
                {
                    yield return InitCall;
                }

                yield break;
            }
        }

        public IToken Start => Tok;

        public override IEnumerable<INode> Children
        {
            get
            {
                if (MutateCSharp.Schemata143.ReplaceBinExprOp_8(24L, Type, null))
                {
                    return PreResolveChildren;
                }

                if (MutateCSharp.Schemata143.ReplaceBinExprOp_9(25L, ArrayDimensions, null))
                {
                    if (MutateCSharp.Schemata143.ReplaceBinExprOp_4(26L, InitCall, null))
                    {
                        return new[] { InitCall };
                    }

                    return EType.Nodes;
                }

                return EType.Nodes.Concat(SubExpressions).Concat<Node>(SubStatements);
            }
        }

        public override IEnumerable<INode> PreResolveChildren =>
            new[] { EType, Type, Path }.OfType<Node>()
              .Concat<Node>(ArrayDimensions ?? Enumerable.Empty<Node>())
              .Concat<Node>(MutateCSharp.Schemata143.ReplaceBinExprOp_5(27L, ElementInit, null) ? new[] { ElementInit } : Enumerable.Empty<Node>())
              .Concat<Node>(InitDisplay ?? Enumerable.Empty<Node>())
              .Concat<Node>((MutateCSharp.Schemata143.ReplaceBinExprOp_7(30L, () => MutateCSharp.Schemata143.ReplaceBinExprOp_6(28L, Bindings, null), () => MutateCSharp.Schemata143.ReplaceBinExprOp_10(29L, Bindings.ArgumentBindings, null)) ?
                               Bindings.ArgumentBindings.Select(a => a.Actual) : null) ??
                            (MutateCSharp.Schemata143.ReplaceBinExprOp_6(36L, Bindings, null) ? Arguments : null) ??
                            Enumerable.Empty<Node>());

        public override IEnumerable<Statement> PreResolveSubStatements => Enumerable.Empty<Statement>();
    }
}