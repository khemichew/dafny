// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT

using System.Collections.Generic;
using static Microsoft.Dafny.ErrorRegistry;
namespace MutateCSharp
{
    internal class Schemata88
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT88");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class ParseErrors
    {

        public enum ErrorId
        {
            // ReSharper disable once InconsistentNaming
            none,
            p_duplicate_modifier,
            p_abstract_not_allowed,
            p_no_ghost_for_by_method,
            p_ghost_forbidden_default_3,
            p_ghost_forbidden_default,
            p_ghost_forbidden,
            p_no_static,
            p_no_opaque,
            p_deprecated_attribute,
            p_literal_string_required,
            p_no_leading_underscore,
            p_bitvector_too_large,
            p_array_dimension_too_large,
            p_superfluous_export,
            p_bad_module_decl,
            p_misplaced_least_or_greatest,
            p_extraneous_comma_in_export,
            p_top_level_field,
            p_module_level_function_always_static,
            p_module_level_method_always_static,
            p_bad_datatype_refinement,
            p_module_level_const_always_static,
            p_const_decl_missing_identifier,
            p_bad_const_initialize_op,
            p_const_is_missing_type_or_init,
            p_misplaced_ellipsis_in_newtype,
            p_output_of_function_not_ghost,
            p_no_new_on_output_formals,
            p_no_nameonly_on_output_formals,
            p_no_older_on_output_formals,
            p_var_decl_must_have_type,
            p_no_init_for_var_field,
            p_datatype_formal_is_not_id,
            p_nameonly_must_have_parameter_name,
            p_should_be_yields_instead_of_returns,
            p_type_parameter_variance_forbidden,
            p_unexpected_type_characteristic,
            p_missing_type_characteristic,
            p_illegal_type_characteristic,
            p_deprecated_colemma,
            p_deprecated_inductive_lemma,
            p_constructor_not_in_class,
            p_method_missing_name,
            p_extraneous_k,
            p_constructors_have_no_out_parameters,
            p_reads_star_must_be_alone,
            p_no_defaults_for_out_parameters,
            p_set_only_one_type_parameter,
            p_iset_only_one_type_parameter,
            p_multiset_only_one_type_parameter,
            p_seq_only_one_type_parameter,
            p_map_needs_two_type_parameters,
            p_imap_needs_two_type_parameters,
            p_no_ghost_arrow_type_arguments,
            p_no_empty_type_parameter_list,
            p_formal_ktype_only_in_least_and_greatest_predicates,
            p_deprecated_inductive_predicate,
            p_deprecated_copredicate,
            p_no_by_method_in_twostate,
            p_no_by_method_in_extreme_predicate,
            p_no_by_method_for_ghost_function,
            p_twostate_and_extreme_are_always_ghost,
            p_old_ghost_syntax,
            p_deprecating_predicate_method,
            p_deprecating_function_method,
            p_no_ghost_predicate_method,
            p_no_ghost_function_method,
            p_migration_syntax,
            p_no_ghost_formal,
            p_no_decreases_for_extreme_predicates,
            p_predicate_return_type_must_be_bool,
            p_no_return_type_for_predicate,
            p_no_wild_expression,
            p_no_wild_frame_expression,
            p_missing_semicolon,
            p_invalid_colon,
            p_initializing_display_only_for_1D_arrays,
            p_no_equal_for_initializing,
            p_no_patterns_and_such_that,
            p_no_modifies_on_refining_loops, // refining loops are deprecated
            p_to_or_downto,
            p_no_decreases_expressions_with_star,
            p_assert_needs_by_or_semicolon,
            p_deprecated_forall_with_no_bound_variables,
            p_forall_with_ensures_must_have_body,
            p_deprecated_modify_statement_with_block,
            p_calc_operator_must_be_transitive,
            p_invalid_calc_op_combination,
            p_calc_dangling_operator,
            p_no_side_effects_in_expressions,
            p_ambiguous_implies,
            p_ambiguous_implies_2,
            p_ambiguous_and_or,
            p_invalid_equal_chaining,
            p_invalid_notequal_chaining,
            p_invalid_operator_in_chain,
            p_invalid_descending_chaining,
            p_invalid_ascending_chaining,
            p_invalid_disjoint_chaining,
            p_operator_does_not_chain,
            p_bang_not_a_relational_op,
            p_invalid_relational_op,
            p_ambiguous_bitop,
            p_invalid_char_literal,
            p_no_parenthesized_binding,
            p_must_be_multiset,
            p_seq_display_has_one_type_argument,
            p_map_comprehension_must_have_term_expression,
            p_no_patterns_in_let_such_that,
            p_no_equal_in_let_initialization,
            p_elephant_has_one_lhs,
            p_elephant_has_one_rhs,
            p_set_comprehension_needs_term_expression,
            p_deprecated_opaque_as_identifier,
            p_invalid_name_after_dot, // not reachable
            p_no_leading_underscore_2,
            p_deprecated_semicolon,
            p_bad_number_format,
            p_bad_hex_number_format,
            p_bad_decimal_number_format,
            p_generic_syntax_error,
            sc_malformed_pragma,
            sc_unknown_pragma,
            p_deprecated_statement_refinement,
            p_internal_exception,
            p_file_has_no_code,
            p_general_traits_datatype,
            p_general_traits_full,
        }

        static ParseErrors()
        {

            Add(ErrorId.p_duplicate_modifier,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(1L, @"
No Dafny modifier, such as [`abstract`, `static`, `ghost`](https://dafny.org/latest/DafnyRef/DafnyRef#sec-declaration-modifiers) may be repeated
Such repetition would be superfluous even if allowed.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(2L, true), MutateCSharp.Schemata88.ReplaceStringConstant_0(3L, "remove duplicate modifier")));

            Add(ErrorId.p_abstract_not_allowed,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(4L, @"
Only modules may be declared abstract.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(5L, true)));

            Add(ErrorId.p_general_traits_datatype,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(6L, @"
A newtype extending a trait is not generally supported. The option --general-traits=full causes
Dafny to allow them in the input, but is not recommended.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(7L, true)));

            Add(ErrorId.p_general_traits_full,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(8L, @"
Use of traits as non-reference types is supported, but is not yet the default. Until it becomes the
default, use --general--traits=datatype to enable it.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(9L, true)));

            Add(ErrorId.p_no_ghost_for_by_method,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(10L, @"
Functions with a [by method](https://dafny.org/latest/DafnyRef/DafnyRef#sec-function-declarations)
section to their body can be used both in ghost contexts and in non-ghost contexts; 
in ghost contexts the function body is used and in compiled contexts
the by-method body is used. The `ghost` keyword is not permitted on the
declaration.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(11L, true)));

            Add(ErrorId.p_ghost_forbidden_default_3,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(12L, @"
For versions prior to Dafny 4, the `function` keyword meant a ghost function
and `function method` meant a non-ghost function. 
From Dafny 4 on, `ghost function` means a ghost function and 
`function` means a non-ghost function. 
See the discussion [here](https://dafny.org/latest/DafnyRef/DafnyRef#sec-function-syntax) for
a discussion of options to control this feature.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(13L, true)));

            Add(ErrorId.p_ghost_forbidden_default,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(14L, @"
For versions prior to Dafny 4, the `function` keyword meant a ghost function
and `function method` meant a non-ghost function. 
From Dafny 4 on, `ghost function` means a ghost function and 
`function` means a non-ghost function. 
See the discussion [here](https://dafny.org/latest/DafnyRef/DafnyRef#sec-function-syntax) for
a discussion of options to control this feature.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(15L, true)));

            Add(ErrorId.p_ghost_forbidden,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(16L, @"
Only some kinds of declarations can be declared `ghost`, most often functions,
fields, and local declarations.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(17L, true)));

            Add(ErrorId.p_no_static,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(18L, @"
Only some kinds of declarations can be declared 'static', most often
fields, constants, methods, and functions, and only within classes.
Modules and the declarations within them are already always static.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(19L, true)));

            Add(ErrorId.p_no_opaque,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(20L, @"
Only some kinds of declarations can be declared 'opaque':
const fields and the various kinds of functions.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(21L, true)));

            // TODO - not used at present
            Add(ErrorId.p_deprecated_attribute,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(22L, @"
This attribute is obsolete and unmaintained. It will be removed from dafny in the future.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(23L, true), MutateCSharp.Schemata88.ReplaceStringConstant_0(24L, "remove attribute")));

            Add(ErrorId.p_literal_string_required,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(25L, @"
The value of an options attribute cannot be a computed expression. It must be a literal string.
").TrimStart(), range => new List<DafnyAction> {
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(26L, "enclose in quotes"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(27L, "\"") + range.PrintOriginal() + MutateCSharp.Schemata88.ReplaceStringConstant_0(28L, "\""))
        });

            // TODO - what about multiple leading underscores
            Add(ErrorId.p_no_leading_underscore,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(29L, @"
User-declared identifiers may not begin with an underscore;
such identifiers are reserved for internal use.
In match statements and expressions, an identifier
that is a single underscore is used as a wild-card match.
").TrimStart(), range => new List<DafnyAction> {
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(30L, "remove underscore"), range, range.PrintOriginal().Substring(MutateCSharp.Schemata88.ReplaceNumericConstant_2(31L, 1)))
          });

            Add(ErrorId.p_no_leading_underscore_2,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(35L, @"
User-declared identifiers may not begin with an underscore;
such identifiers are reserved for internal use.
In match statements and expressions, an identifier
that is a single underscore is used as a wild-card match.
").TrimStart(), range => new List<DafnyAction> {
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(36L, "remove underscore"), range, range.PrintOriginal().Substring(MutateCSharp.Schemata88.ReplaceNumericConstant_2(37L, 1)))
          });

            Add(ErrorId.p_bitvector_too_large,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(41L, @"
A bitvector type name is the characters 'bv' followed by a non-negative
integer literal. However, dafny only supports widths up to the largest
signed 32-bit integer (2147483647).
").TrimStart());

            Add(ErrorId.p_array_dimension_too_large,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(42L, @"
A multi-dimensional array type name is the characters 'array' followed by
a positive integer literal. However, dafny only supports numbers of 
dimensions up to the largest signed 32-bit integer (2147483647).
In practice (as of v3.9.1) dimensions of more than a few can take 
overly long to resolve ([Issue #3180](https://github.com/dafny-lang/dafny/issues/3180)).
").TrimStart());

            Add(ErrorId.p_superfluous_export,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(43L, @"
Although all top-level declarations are contained in an implicit top-level module, there is no syntax to import that module.
Such an import would likely cause a circular module dependency error.
If the implicit module cannot be imported, there is no point to any export declarations inside the implicit module.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(44L, false), MutateCSharp.Schemata88.ReplaceStringConstant_0(45L, "remove export declaration")));

            Add(ErrorId.p_bad_module_decl,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(46L, @"
The [syntax for a module declaration](https://dafny.org/latest/DafnyRef/DafnyRef#sec-modules) is either `module M { ... }` or
`module M refines N { ... }` with optional attributes after the `module` keyword.
This error message often occurs if the `refines` keyword is misspelled.
").TrimStart(), range => new List<DafnyAction> {
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(47L, "replace '") + range.PrintOriginal() + MutateCSharp.Schemata88.ReplaceStringConstant_0(48L, "' with 'refines'"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(49L, "refines")),
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(50L, "remove '") + range.PrintOriginal() + MutateCSharp.Schemata88.ReplaceStringConstant_0(51L, "'"), range, "", MutateCSharp.Schemata88.ReplaceBooleanConstant_1(52L, true))
          });

            Add(ErrorId.p_misplaced_least_or_greatest,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(53L, @"
A `least` or `greatest` token between `export` and `predicate` is a bit ambiguous:
it can be either the name of the export set or associated with the `predicate` declaration.
The parser associates it with the `export`. To avoid this warning, do not put the
`least` or `greatest` token on the same line as the `predicate` token.
If you intend for the `least` to go with the predicate, change the order of the declarations.
").TrimStart()); // TODO - could use a quick fix

            Add(ErrorId.p_extraneous_comma_in_export,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(54L, @"
An export declaration consists of one or more `reveals`, `provides`, and extends clauses. Each clause contains
a comma-separated list of identifiers, but the clauses themselves are not separated by any delimiter.
So in the example above, the comma after `a` is wrong in each export declaration. 
This mistake is easy to make when the clauses are on the same line.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(55L, false), MutateCSharp.Schemata88.ReplaceStringConstant_0(56L, "remove comma")));

            Add(ErrorId.p_top_level_field,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(57L, @"
`var` declarations are used to declare mutable fields of classes, local variables in method bodies, and identifiers in let-expressions.
But mutable field declarations are not permitted at the static module level, including in the (implicit) toplevel module.
Rather, you may want the declaration to be a `const` declaration or you may want the mutable field to be declared in the body of a class.
").TrimStart(), Replace(MutateCSharp.Schemata88.ReplaceStringConstant_0(58L, "const")));

            Add(ErrorId.p_bad_datatype_refinement, // TODO - add a code action
        MutateCSharp.Schemata88.ReplaceStringConstant_0(59L, @"
There are limitations on refining a datatype, namely that the set of constructors cannot be changed.
It is only allowed to add members to the body of the datatype.
").TrimStart());

            Add(ErrorId.p_module_level_function_always_static,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(60L, @"
All names declared in a module (outside a class-like entity) are implicitly `static`.
Dafny does not allow them to be explictly, redundantly, declared `static`.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(61L, true)));

            Add(ErrorId.p_module_level_method_always_static,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(62L, @"
All names declared in a module (outside a class-like entity) are implicitly `static`.
Dafny does not allow them to be explictly, redundantly, declared `static`.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(63L, true)));

            Add(ErrorId.p_const_decl_missing_identifier,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(64L, @"
This error arises from a truncated declarations of a const field, namely just a const keyword.
To correct the error, add an identifier and either or both a type and initializing expression (or remove the const keyword).
").TrimStart());

            Add(ErrorId.p_module_level_const_always_static,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(65L, @"
All names declared in a module (outside a class-like entity) are implicitly `static`.
Dafny does not allow them to be explictly, redundantly, declared `static`.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(66L, true)));

            Add(ErrorId.p_bad_const_initialize_op,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(67L, @"
Dafny's syntax for initialization of const fields uses `:=`, not `=`.
In Dafny, `=` is used only in type definitions.
").TrimStart(), Replace(MutateCSharp.Schemata88.ReplaceStringConstant_0(68L, ":=")));

            Add(ErrorId.p_const_is_missing_type_or_init,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(69L, @"
A `const` declaration needs its type indicated by either an explicit type
or a right-hand-side expression, whose type is then the type of the 
declared identifier. 
So use syntax either like `const i: int` or `const i := 5` (or both together).
").TrimStart(), InsertAfter(MutateCSharp.Schemata88.ReplaceStringConstant_0(70L, ": int := 42"), MutateCSharp.Schemata88.ReplaceStringConstant_0(71L, "add example")));

            Add(ErrorId.p_misplaced_ellipsis_in_newtype,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(72L, @"
There are limitations on refining a newtype, namely that the base type cannot be changed. You can change an abstract type into a newtype, however.
When refining a newtype by adding a body, the ... stands in place of both the '=' and the base type.
").TrimStart()); // TODO - add an action

            Add(ErrorId.p_output_of_function_not_ghost,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(73L, @"
The output of a predicate or function cannot be ghost.
It is implicitly ghost if the function is ghost itself.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(74L, true)));

            Add(ErrorId.p_no_new_on_output_formals,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(75L, @"
The `new` modifier only applies to input parameters.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(76L, true)));

            Add(ErrorId.p_no_nameonly_on_output_formals,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(77L, @"
The `nameonly` modifier only applies to input parameters.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(78L, true)));

            Add(ErrorId.p_no_older_on_output_formals,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(79L, @"
The `older` modifier only applies to input parameters.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(80L, true)));

            Add(ErrorId.p_var_decl_must_have_type,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(81L, @"
Because a mutable field does not have initializer, it must have a type (as in `var f: int`).
`const` declarations may have initializers; if they do they do not need an explicit type.
").TrimStart(), range => new List<DafnyAction> {
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(82L, "insert ': bool'"), range, range.PrintOriginal() + MutateCSharp.Schemata88.ReplaceStringConstant_0(83L, ": bool")),
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(84L, "insert ': int'"), range, range.PrintOriginal() + MutateCSharp.Schemata88.ReplaceStringConstant_0(85L, ": int"))
          });

            Add(ErrorId.p_no_init_for_var_field,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(86L, @"
Dafny does not allow field declarations to have initializers. They are initialized in constructors.
Local variable declarations (which also begin with `var`) may have initializers.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(87L, false), MutateCSharp.Schemata88.ReplaceStringConstant_0(88L, "remove := and expression")));
            // TODO - when there is capability to find constructors, enhance this with a code action that moves the initialization to the constructor

            Add(ErrorId.p_datatype_formal_is_not_id,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(89L, @"
Datatype constructors can have formal parameters, declared with the usual syntax: 'name: type'.
In datatype constructors the 'name :' is optional; one can just state the type.
However, if there is a name, it may not be a typename.
The formal parameter name should be a simple identifier that is not a reserved word.
").TrimStart(), Replace(MutateCSharp.Schemata88.ReplaceStringConstant_0(90L, "_")));

            Add(ErrorId.p_nameonly_must_have_parameter_name,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(91L, @"
The parameters of a datatype constructor do not need to have names -- it is allowed to just give the type.
However, if `nameonly` is used, meaning the constructor can be called using named parameters,
then the name must be given, as in `datatype D = D (i: int, nameonly j: int) {}`

More detail is given [here](https://dafny.org/latest/DafnyRef/DafnyRef#sec-parameter-bindings).
").TrimStart(), range => new List<DafnyAction> {
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(92L, "remove 'nameonly'"), range, "", MutateCSharp.Schemata88.ReplaceBooleanConstant_1(93L, true)),
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(94L, "insert '_:'"), range, range.PrintOriginal() + MutateCSharp.Schemata88.ReplaceStringConstant_0(95L, " _:"))
          });

            Add(ErrorId.p_should_be_yields_instead_of_returns,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(96L, @"
An [iterator](https://dafny.org/latest/DafnyRef/DafnyRef#sec-iterator-types) is like a co-routine: 
its control flow produces (yields) a value, but the execution continues from that point (a yield statement) to go on to produce the next value, rather than exiting the method. 
To accentuate this difference, a `yield` statement is used to say when the next value of the iterator is ready, rather than a `return` statement.
In addition, the declaration does not use `returns` to state the out-parameter, as a method would. Rather it has a `yields` clause.
The example above is a valid example if `returns` is replaced by `yields`.
").TrimStart(), Replace(MutateCSharp.Schemata88.ReplaceStringConstant_0(97L, "yields")));

            Add(ErrorId.p_type_parameter_variance_forbidden,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(98L, @"
[Type-parameter variance](https://dafny.org/latest/DafnyRef/DafnyRef#sec-type-parameter-variance) is specified by a 
`+`, `-`, `*` or `!` before the type-parameter name.
Such designations are allowed in generic type declarations but not in generic method, function, or predicate declarations.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(99L, false), MutateCSharp.Schemata88.ReplaceStringConstant_0(100L, "remove type parameter variance")));

            Add(ErrorId.p_unexpected_type_characteristic,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(101L, @"
[Type characteristics](https://dafny.org/latest/DafnyRef/DafnyRef#sec-type-parameters), 
indicated in parentheses after the type name, state properties of the otherwise uninterpreted or abstract type.
The currently defined type characteristics are designated by `==` (equality-supporting), `0` (auto-initializable), `00` (non-empty), and `!new` (non-reference).
").TrimStart(), Replacements(new[] {
      (MutateCSharp.Schemata88.ReplaceStringConstant_0(102L, "=="), MutateCSharp.Schemata88.ReplaceStringConstant_0(103L, "replace with '==' - this type supports equality")),
      (MutateCSharp.Schemata88.ReplaceStringConstant_0(104L, "0"), MutateCSharp.Schemata88.ReplaceStringConstant_0(105L, "replace with '0' - this type is auto-initializable")),
      (MutateCSharp.Schemata88.ReplaceStringConstant_0(106L, "00"), MutateCSharp.Schemata88.ReplaceStringConstant_0(107L, "replace with '00' - this type is nonempty")),
      (MutateCSharp.Schemata88.ReplaceStringConstant_0(108L, "!new"), MutateCSharp.Schemata88.ReplaceStringConstant_0(109L, "replace with '!new' - this type is not allocated on the heap"))
            }));

            Add(ErrorId.p_missing_type_characteristic,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(110L, @"
[Type characteristics](https://dafny.org/latest/DafnyRef/DafnyRef#sec-type-parameters), 
state properties of the otherwise uninterpreted or abstract type.
They are given in a parentheses-enclosed, comma-separated list after the type name.
The currently defined type characteristics are designated by `==` (equality - supporting),
`0` (auto - initializable), `00` (non - empty), and `!new` (non - reference).
").TrimStart(), range => MutateCSharp.Schemata88.ReplaceBinExprOp_3(112L, range.Prev.val, MutateCSharp.Schemata88.ReplaceStringConstant_0(111L, ",")) ?
              new List<DafnyAction> {
      OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(113L, "remove comma"), range.Prev.ToRange(), ""),
      OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(114L, "insert '=='"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(115L, "==") + range.PrintOriginal()),
      OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(116L, "insert '0'"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(117L, "0") + range.PrintOriginal()),
      OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(118L, "insert '00'"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(119L, "00") + range.PrintOriginal()),
      OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(120L, "insert '!new'"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(121L, "!new") + range.PrintOriginal()) }
           : new List<DafnyAction> {
      OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(122L, "insert '=='"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(123L, "==") + range.PrintOriginal()),
      OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(124L, "insert '0'"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(125L, "0") + range.PrintOriginal()),
      OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(126L, "insert '00'"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(127L, "00") + range.PrintOriginal()),
      OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(128L, "insert '!new'"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(129L, "!new") + range.PrintOriginal())
          });

            Add(ErrorId.p_illegal_type_characteristic,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(130L, @"
[Type characteristics](https://dafny.org/latest/DafnyRef/DafnyRef#sec-type-parameters),
indicated in parentheses after the type name, state properties of the otherwise uninterpreted or abstract type.
The currently defined type characteristics are designated by `==` (equality - supporting),
`0` (auto - initializable), `00` (non - empty), and `!new` (non - reference).
Type characteristics are given in a parentheses-enclosed, comma-separated list after the type name.
").TrimStart(), Replacements(new[] {
      (MutateCSharp.Schemata88.ReplaceStringConstant_0(131L, "=="), MutateCSharp.Schemata88.ReplaceStringConstant_0(132L, "replace with '==' - this type supports equality")),
      (MutateCSharp.Schemata88.ReplaceStringConstant_0(133L, "0"), MutateCSharp.Schemata88.ReplaceStringConstant_0(134L, "replace with '0' - this type is auto-initializable")),
      (MutateCSharp.Schemata88.ReplaceStringConstant_0(135L, "00"), MutateCSharp.Schemata88.ReplaceStringConstant_0(136L, "replace with '00' - this type is nonempty")),
      (MutateCSharp.Schemata88.ReplaceStringConstant_0(137L, "!new"), MutateCSharp.Schemata88.ReplaceStringConstant_0(138L, "replace with '!new' - this type is not allocated on the heap"))
            }));

            Add(ErrorId.p_deprecated_colemma,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(139L, @"
The adjectives `least` and `greatest` for lemmas and functions are more consistent with the nomenclature for coinduction.
").TrimStart(), Replace(MutateCSharp.Schemata88.ReplaceStringConstant_0(140L, "greatest lemma")));

            Add(ErrorId.p_deprecated_inductive_lemma,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(141L, @"
The adjectives `least` and `greatest` for lemmas and functions are more consistent with the nomenclature for coinduction.
").TrimStart(), Replace(MutateCSharp.Schemata88.ReplaceStringConstant_0(142L, "least")));

            Add(ErrorId.p_constructor_not_in_class,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(143L, @"
Constructors are methods that initialize class instances. That is, when a new instance of a class is being created, 
using the `new` object syntax, some constructor of the class is called, perhaps a default anonymous one.
So, constructor declarations only make sense within classes.
").TrimStart(), Replace(MutateCSharp.Schemata88.ReplaceStringConstant_0(144L, "method")));

            Add(ErrorId.p_method_missing_name,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(145L, @"
A method declaration always requires an identifier between the `method` keyword and the `(` that starts the formal parameter list.
This is the case even when, as in the example above, a name is specified using `:extern`. The extern name is only used in the
compiled code; it is not the name used to refer to the method in Dafny code
").TrimStart(), InsertBefore(MutateCSharp.Schemata88.ReplaceStringConstant_0(146L, "M")));

            Add(ErrorId.p_extraneous_k,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(147L, @"
Least and greatest lemmas and predicates have a special parameter named `k`.
Its type is specified in square brackets between the lemma/predicate name and the rest of the signature.
The type may be either `nat` or `ORDINAL`.
But this type is specified only for `least` and `greatest` constructs.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(148L, false)));

            Add(ErrorId.p_constructors_have_no_out_parameters,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(149L, @"
Constructors are used to initalize the state of an instance of a class.
Thus they typically set the values of the fields of the class instance.
Constructors are used in `new` object expressions, which return 
a reference to the newly constructed object (as in `new C(42)`).
There is no syntax to receive out-parameter values of a constructor
and they may not be declared. 
(This is similar to constructors in other programming languages, like Java.)
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(150L, true), MutateCSharp.Schemata88.ReplaceStringConstant_0(151L, "remove out parameters")));

            Add(ErrorId.p_reads_star_must_be_alone,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(152L, @"
A reads clause lists the objects whose fields the function is allowed to read (or expressions 
containing such objects). `reads *` means the function may read anything.
So it does not make sense to list `*` along with something more specific.
If you mean that the function should be able to read anything, just list `*`.
Otherwise, omit the `*` and list expressions containing all the objects that are read.
").TrimStart(), range => new List<DafnyAction> {
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(153L, "remove *"), IncludeComma(range), "", MutateCSharp.Schemata88.ReplaceBooleanConstant_1(154L, true))
        });

            Add(ErrorId.p_no_defaults_for_out_parameters,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(155L, @"
Out-parameters of a method are declared (inside the parentheses after the `returns` keyword)
with just an identifier and a type, separated by a colon. 
No initializing value may be given. If a default value is needed, assign the out-parameter
that value as a first statement in the body of the method.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(156L, true), MutateCSharp.Schemata88.ReplaceStringConstant_0(157L, "remove initializer"))); // TODO - could be improved by removing leading whitespace

            Add(ErrorId.p_set_only_one_type_parameter,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(158L, @"
A `set` type has one type parameter, namely the type of the elements of the set.
The error message states that the parser sees some number of type parameters different than one.
The type parameters are listed in a comma-separated list between `<` and `>`, after the type name.
").TrimStart()); // TODO - code action: keep only first parameter, and for susequent errors

            Add(ErrorId.p_iset_only_one_type_parameter,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(159L, @"
A `iset` type has one type parameter, namely the type of the elements of the set.
The error message states that the parser sees some number of type parameters different than one.
The type parameters are listed in a comma-separated list between `<` and `>`, after the type name.
").TrimStart());

            Add(ErrorId.p_multiset_only_one_type_parameter,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(160L, @"
A `multiset` type has one type parameter, namely the type of the elements of the multiset.
The error message states that the parser sees some number of type parameters different than one.
The type parameters are listed in a comma-separated list between `<` and `>`, after the type name.
").TrimStart());

            Add(ErrorId.p_seq_only_one_type_parameter,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(161L, @"
A `seq` type has one type parameter, namely the type of the elements of the sequence.
The error message states that the parser sees some number of type parameters different than one.
The type parameters are listed in a comma-separated list between `<` and `>`, after the type name.
").TrimStart());

            Add(ErrorId.p_map_needs_two_type_parameters,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(162L, @"
A `map` type has two type parameters: the type of the keys and the type of the values.
The error message states that the parser sees some number of type parameters different than two.
").TrimStart());

            Add(ErrorId.p_imap_needs_two_type_parameters,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(163L, @"
A `imap` type has two type parameters: the type of the keys and the type of the values.
The error message states that the parser sees some number of type parameters different than two.
").TrimStart());

            Add(ErrorId.p_no_ghost_arrow_type_arguments,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(164L, @"
[Arrow types](../DafnyRef/DafnyRef#sec-arrow-types) are the types of functions in Dafny.
They are designated with the arrow syntax, as shown in the example,
except that the types used cannot be declared as ghost.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(165L, true), MutateCSharp.Schemata88.ReplaceStringConstant_0(166L, "remove ghost keyword")));

            Add(ErrorId.p_no_empty_type_parameter_list,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(167L, @"
An instantiation of a generic type consists of the generic type name followed by a comma-separated
list of type arguments enclosed in angle brackets. If a type has no type arguments, then
there is no list and no angle brackets either.

However, this particular error message is not reachable in the current parser. 
If the message is seen, please report the code that caused it so that the bug or documentation can be corrected.
").TrimStart());

            Add(ErrorId.p_formal_ktype_only_in_least_and_greatest_predicates,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(168L, @"
A declaration of an extreme predicate includes a special formal 
in addition to the regular parenthesis-enclosed list of formals.
The type of that special formal is given in square brackets between the 
predicate name and the opening parenthesis of the formals.
The type may be either `nat` or `ORDINAL`.
This special formal is not permitted in a regular (non-extreme) predicate.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(169L, true))); // TODO - would like to have option to add 'least' or 'greatest', but that takes a different token location

            Add(ErrorId.p_no_by_method_in_twostate,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(170L, @"
Two state functions and predicates are always ghost and do not have a compiled representation.
Such functions use values from two different program (heap) states, which is not 
something that can be implemented (at least with any degree of good performance) in conventional programming languages.

Because there is no feasible compiled verion of a two-state function, it cannot have a `by method` block (which is always compiled).
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(171L, false), MutateCSharp.Schemata88.ReplaceStringConstant_0(172L, "remove by method block")));

            Add(ErrorId.p_no_by_method_in_extreme_predicate,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(173L, @"
Least and greatest predicates are always ghost and do not have a compiled representation, 
so it makes no sense to have a `by method` alternative implementation.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(174L, false), MutateCSharp.Schemata88.ReplaceStringConstant_0(175L, "remove by method block")));

            Add(ErrorId.p_no_by_method_for_ghost_function,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(176L, @"
`by method` constructs combine a ghost function (or predicate) with a non-ghost method.
The two parts compute the same result, and are verified to do so.
Uses of the function are verified using the function body, but the method body is used when the function is compiled.

Thus the function part is always implicitly `ghost` and may not be explicitly declared `ghost`.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(177L, true)));

            Add(ErrorId.p_twostate_and_extreme_are_always_ghost,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(178L, @"
The `twostate`, `least`, and `greatest` functions and predicates are always ghost and cannot be compiled, so they cannot be
declared as a `function method` (v3 only).
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(179L, true)));

            Add(ErrorId.p_old_ghost_syntax,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(180L, @"
This error only occurs when the `experimentalPredicateAlwaysGhost` option is chosen.
It indicates that `predicates` are always ghost and cannot be declared with the (Dafny 3) syntax `predicate method`.
- If you intend to predicate to be ghost, remove `method`.
- If you intend the predicate to be non-ghost, you either cannot use `experimentalPredicateAlwaysGhost` or you should use `function` with a `bool` return type instead of `predicate`
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(181L, true)));

            Add(ErrorId.p_deprecating_predicate_method,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(182L, @"
From Dafny 4 on, the phrases `function method` and `predicate method` are no
longer accepted. Use `function` for compiled, non-ghost functions and
`ghost function` for non-compiled, ghost functions, and similarly for predicates.
See [the documentation here](https://dafny.org/latest/DafnyRef/DafnyRef#sec-function-syntax).
").TrimStart(), range => new List<DafnyAction> {
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(183L, "remove 'method'"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(184L, "predicate"), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(185L, false)),
        });

            Add(ErrorId.p_deprecating_function_method,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(186L, @"
From Dafny 4 on, the phrases `function method` and `predicate method` are no
longer accepted. Use `function` for compiled, non-ghost functions and
`ghost function` for non-compiled, ghost functions, and similarly for predicates.
See [the documentation here](https://dafny.org/latest/DafnyRef/DafnyRef#sec-function-syntax).
").TrimStart(), range => new List<DafnyAction> {
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(187L, "remove 'method'"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(188L, "function"), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(189L, false)),
        });

            Add(ErrorId.p_no_ghost_function_method,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(190L, @"
Pre-Dafny 4, a `function method` and a `predicate method` are explicitly
non-ghost, compiled functions, and therefore cannot be declared `ghost` as well.
If indeed the function or predicate is intended to be ghost, leave out `method`;
 if it is intended to be non-ghost, leave out `ghost`.

From Dafny 4 on, a ghost function is declared `ghost function` and a non-ghost function is declared `function` 
and there is no longer any declaration of the form `function method`, and similarly for predicates. 

See [the documentation here](../DafnyRef/DafnyRef#sec-function-syntax).
").TrimStart(), range => new List<DafnyAction> {
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(191L, "remove 'method'"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(192L, "function"), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(193L, false)),
        });

            Add(ErrorId.p_no_ghost_predicate_method,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(194L, @"
Pre-Dafny 4, a `function method` and a `predicate method` are explicitly
non-ghost, compiled functions, and therefore cannot be declared `ghost` as well.
If indeed the function or predicate is intended to be ghost, leave out `method`;
 if it is intended to be non-ghost, leave out `ghost`.

From Dafny 4 on, a ghost function is declared `ghost function` and a non-ghost function is declared `function` 
and there is no longer any declaration of the form `function method`, and similarly for predicates. 

See [the documentation here](../DafnyRef/DafnyRef#sec-function-syntax).
").TrimStart(), range => new List<DafnyAction> {
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(195L, "remove 'method'"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(196L, "predicate"), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(197L, false)),
        });

            Add(ErrorId.p_migration_syntax,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(198L, @"
This error occurs only when using `migration3to4`. With this option, ghost functions are declared using `ghost function` and compiled functions using `function method`.
Change `function` in the declaration to one of these.
").TrimStart(), range => new List<DafnyAction> {
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(199L, "add 'ghost'"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(200L, "ghost function"), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(201L, false)),
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(202L, "add 'method'"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(203L, "function method"), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(204L, false)),
        });

            Add(ErrorId.p_no_ghost_formal,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(205L, @"
A ghost predicate or function effectively has all ghost formal parameters, so they cannot be declared ghost in addition.
").TrimStart(), range => MutateCSharp.Schemata88.ReplaceBinExprOp_4(207L, range.PrintOriginal(), MutateCSharp.Schemata88.ReplaceStringConstant_0(206L, "ghost")) ?
            new List<DafnyAction> { }
            : new List<DafnyAction> { OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(208L, "remove 'ghost'"), range, "", MutateCSharp.Schemata88.ReplaceBooleanConstant_1(209L, true)) }
        );

            Add(ErrorId.p_no_decreases_for_extreme_predicates,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(210L, @"
Least and greatest predicates are not checked for termination. In fact, unbounded recursion is part of being coinductive.
Hence `decreases` clauses are inappropriate and not allowed.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(211L, false), MutateCSharp.Schemata88.ReplaceStringConstant_0(212L, "remove decreases clause")));

            Add(ErrorId.p_predicate_return_type_must_be_bool,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(213L, @"
A predicate is a function that returns `bool`. The return type here is something else.
If you mean to have a non-`bool` return type, use `function` instead of `predicate`.
").TrimStart(), range => new List<DafnyAction> {
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(214L, "remove type"), new RangeToken(range.StartToken.Prev, range.EndToken), "", MutateCSharp.Schemata88.ReplaceBooleanConstant_1(215L, true)),
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(216L, "replace type with 'bool'"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(217L, "bool"), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(218L, true)) }
        );

            Add(ErrorId.p_no_return_type_for_predicate,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(219L, @"
A `predicate` is simply a `function` that returns a `bool` value.
Accordingly, the type is (required to be) omitted, unless the result is being named.
So `predicate p(): (res: bool) { true }` is permitted.
").TrimStart(), range => new List<DafnyAction> {
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(220L, "remove type"), new RangeToken(range.StartToken.Prev, range.EndToken), "", MutateCSharp.Schemata88.ReplaceBooleanConstant_1(221L, true)),
          });

            Add(ErrorId.p_no_wild_expression,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(222L, @"
A method or loop with a `decreases *` clause is not checked for termination.
This is only permitted for non-ghost methods and loops.
Insert an actual decreases expression.
").TrimStart());

            Add(ErrorId.p_no_wild_frame_expression,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(223L, @"
A `reads *` clause means the reads clause allows the functions it specifies to read anything.
Such a clause is not allowed in an iterator specification.
Insert a specific reads expression.
").TrimStart());

            Add(ErrorId.p_invalid_colon,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(224L, @"
In this situation the parser sees the identifier (x) and the following colon.
This is not a legal start to a statement. Most commonly either
* a `var` or `const` keyword is missing, and the `x:` is the beginning of a declaration, or
* a `label` keyword is missing and the identifier is the label for the statement that follows.
(The second error is somewhat common because in C/C++ and Java, there is no keyword introducing a label, just the identifier and the colon.)
").TrimStart(), range => new List<DafnyAction> {
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(225L, "insert 'label'"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(226L, "label ") + range.PrintOriginal(), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(227L, false)),
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(228L, "insert 'var'"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(229L, "var ") + range.PrintOriginal(), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(230L, false)),
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(231L, "insert 'const'"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(232L, "const ") + range.PrintOriginal(), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(233L, false)),
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(234L, "change ':' to ':='"), range, range.PrintOriginal() + MutateCSharp.Schemata88.ReplaceStringConstant_0(235L, "="), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(236L, false)),
          });

            Add(ErrorId.p_initializing_display_only_for_1D_arrays,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(237L, @"
One-dimensional arrays can be initialized like `var s := new int[][1,2,3,4];`,
but multi-dimensional arrays cannot. The alternatives are to initialize the array
in a loop after it is allocated, or to initialize with a function, as in
`var a:= new int[2,2]((i: int, j: int)=>i+j)`.
").TrimStart());

            ActionSignature sharedLambda = delegate (RangeToken range)
            {
                return new List<DafnyAction> {
        OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(238L, "replace with ':='"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(239L, ":="), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(240L, false)),
        OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(241L, "replace with ':-"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(242L, ":-"), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(243L, false)),
        OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(244L, "replace with ':|'"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(245L, ":|"), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(246L, false)),
    };
            };

            Add(ErrorId.p_no_equal_for_initializing,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(247L, @"
Local variables are initialized with `:=` (and sometimes with `:-` or `:|`), but not with `=`.
In Dafny `=` is used only in type definitions.
").TrimStart(), sharedLambda);

            Add(ErrorId.p_no_patterns_and_such_that,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(248L, @"
The `:|` syntax is called _assign-such-that_: the variables on the left-hand-side are initialized or assigned
some non-deterministic values that satisfy the predicate on the right-hand-side.

However, Dafny only allows a list of simple variables on the left, not datatype deconstructor patterns, as seen here.
").TrimStart());

            Add(ErrorId.p_no_modifies_on_refining_loops,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(249L, @"
_Refining statements, including loops, are deprecated._
").TrimStart());

            Add(ErrorId.p_to_or_downto,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(250L, @"
A for loop can express a computation to be performed for each value of a _loop index_.
In Dafny, the loop index is an int-based variable that is either 
- incremented up from a starting value to just before an ending value: `3 to 7` means 3, 4, 5, and 6
- or decremented from just below a starting value down to an ending value: `7 downto 3` means 6, 5, 4, and 3.

The contextual keywords `to` and `downto` indicate incrementing and decrementing, respectively.
No other words are allowed here, including writing them with different case.

These two words have special meaning only in this part of a for-loop; they are not reserved words elsewhere.
That is, the code
<!-- %check-resolve %exit 0 %nomsg -->
```dafny
method m() {
  var to: int := 6;
  var downto: int := 8;
  for to := to to downto {}
}
```
is legal, but not at all recommended.
").TrimStart(), range => new List<DafnyAction> {
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(251L, "replace with 'to'"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(252L, "to"), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(253L, false)),
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(254L, "replace with 'downto'"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(255L, "downto"), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(256L, false)),
          });

            Add(ErrorId.p_no_decreases_expressions_with_star,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(257L, @"
A `decreases` clause provides a metric that must decrease from one call to the next, 
in order to assure termination of a sequence of recursive calls. 
In loops it assures termination of the loop iteration.

`decreases *` means to skip the termination check.
So it does not make sense to both list a metric and to list '*'.
Use one or the other.
").TrimStart());  // TODO - somewhere else where we remove the * or replace the whole works?

            Add(ErrorId.p_assert_needs_by_or_semicolon,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(258L, @"
Assert statements, like all statements, end in either a semicolon or a block. Most assert statements end in semicolons,
but an assert-by statement has the form `assert expr by { ... }` where the by-block contains statements such as lemma calls
that assist in proving the validity of the asserted expression.
").TrimStart(), InsertAfter(MutateCSharp.Schemata88.ReplaceStringConstant_0(259L, ";"), MutateCSharp.Schemata88.ReplaceStringConstant_0(260L, "insert semicolon")));

            Add(ErrorId.p_forall_with_ensures_must_have_body,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(261L, @"
A forall statement without a body is like an assume statement: the ensures clause is assumed in the following code.
Assumptions like that are a risk to soundness because there is no check that the assumption is true.
Thus in a context in which open assumptions are not allowed, body-less forall statements are also not allowed.
").TrimStart());

            Add(ErrorId.p_calc_operator_must_be_transitive,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(262L, @"
A [calc statement](../DafnyRef/DafnyRef#sec-calc-statement)
contains a sequence of expressions interleaved by operators.
Such a sequence aids the verifier in establishing a desired conclusion.
But the sequence of operators must obey certain patterns similar to chaining expressions.
In this case a default operator is stated (the `!=` between `calc` and `{`).
This default operator is the implicit operator between each consecutive pair of expressions
in the body of the calc statement.

But the operator has to be transitive: `!=` is not allowed; `==`, `<`, `<=`, '>' and '>=' are allowed.
").TrimStart(), range => new List<DafnyAction> {
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(263L, "replace with '=='"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(264L, "=="), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(265L, false)),
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(266L, "replace with '<'"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(267L, "<"), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(268L, false)),
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(269L, "replace with '<='"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(270L, "<="), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(271L, false)),
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(272L, "replace with '>='"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(273L, ">="), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(274L, false)),
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(275L, "replace with '>'"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(276L, ">"), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(277L, false)),
          });

            Add(ErrorId.p_invalid_calc_op_combination,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(278L, @"
A [calc statement](../DafnyRef/DafnyRef#sec-calc-statement)
contains a sequence of expressions interleaved by operators.
Such a sequence aids the verifier in establishing a desired conclusion.
But the sequence of operators must obey certain patterns similar to chaining expressions.

In particular, this error message is complaining that it sees an unacceptable operator.
In this case, the reason is that the sequence may contain only one `!=` operator;
another reason causing this message would be a combination of `<` and `>` operators.
").TrimStart());

            Add(ErrorId.p_calc_dangling_operator,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(279L, @"
A [calc statement](../DafnyRef/DafnyRef#sec-calc-statement)
contains a sequence of expressions interleaved by operators.
Such a sequence aids the verifier in establishing a desired conclusion.
But the sequence must begin and end with (semicolon-terminated) expressions.

This error message is complaining that it sees an operator ending the sequence.
This may be because there is no following expression or that the parser 
does not recognize the material after the last operator as a legal ending expression.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(280L, false)));

            Add(ErrorId.p_no_side_effects_in_expressions,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(281L, @"
Dafny expressions may not have side-effects. This prohibits both assignments to local variables and any
changes to the heap. Thus method and constructor calls may not occur in expressions.
This check is syntactic, so even methods that do not modify anything are not permitted in expressions.
").TrimStart());

            Add(ErrorId.p_ambiguous_implies,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(282L, @"
The `==>` and `<==` operators have the same precedence but do not associate with each other.
You must use parentheses to show how they are grouped. Write `p ==> q <== r` as either
`(p ==> q) <== r` or `p ==> (q <== r)`.

In contrast, `p ==> q ==> r` is `p ==> (q ==> r)` and
`p <== q <== r` is `(p <== q) <== r`.

See [this section](../DafnyRef/DafnyRef#sec-implication-and-reverse-implication) for more information.
").TrimStart()); // TODO - would be nice to have code actions for the alternatives, but that requires passing multiple ranges
            Add(ErrorId.p_ambiguous_implies_2,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(283L, @"
The `==>` and `<==` operators have the same precedence but do not associate with each other.
You must use parentheses to show how they are grouped. Write `p ==> q <== r` as either
`(p ==> q) <== r` or `p ==> (q <== r)`.

In contrast, `p ==> q ==> r` is `p ==> (q ==> r)` and
`p <== q <== r` is `(p <== q) <== r`.

See [this section](../DafnyRef/DafnyRef#sec-implication-and-reverse-implication) for more information.
").TrimStart()); // TODO - would be nice to have code actions for the alternatives, but that requires passing multiple ranges

            Add(ErrorId.p_ambiguous_and_or,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(284L, @"
The `&&` and `||` operators have the same precedence but do not associate with each other.
You must use parentheses to show how they are grouped. Write `p && q || r` as either
`(p && q) || r` or `p && (q || r)`.
").TrimStart());// TODO - would be nice to have code actions for the alternatives, but that requires passing multiple ranges

            Add(ErrorId.p_invalid_equal_chaining,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(285L, @"
[Chained operations](../DafnyRef/DafnyRef#sec-basic-types)
are a sequence of binary operations without parentheses: _a op b op c op d op e_.
But there are limitations on which operators can be in one chain together.

In particular, the relational operators `in` and `!in` may not be part of a chain.
Use parentheses as necessary to group the operations.
").TrimStart());

            Add(ErrorId.p_invalid_notequal_chaining,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(286L, @"
[Chained operations](../DafnyRef/DafnyRef#sec-basic-types)
are a sequence of binary operations without parentheses: _a op b op c op d op e_.
But there are limitations on which operators can be in one chain together.

In particular for this error message, one cannot have chains that include more than one `!=` operator.
").TrimStart());

            Add(ErrorId.p_invalid_operator_in_chain,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(287L, @"
[Chained operations](../DafnyRef/DafnyRef#sec-basic-types)
are a sequence of binary operations without parentheses: _a op b op c op d op e_.
But there are limitations on which operators can be in one chain together.

In particular for this error message, the designated operator is not permitted to extend the existing chain.
").TrimStart());

            Add(ErrorId.p_invalid_descending_chaining,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(288L, @"
[Chained operations](../DafnyRef/DafnyRef#sec-basic-types)
are a sequence of binary operations without parentheses: _a op b op c op d op e_.
But there are limitations on which operators can be in one chain together.

In particular for this error message, one cannot have chains that include both
less-than operations (either `<` or `<=`) and greater-than operations (either `>` or `>=`).
").TrimStart());

            Add(ErrorId.p_invalid_ascending_chaining,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(289L, @"
[Chained operations](../DafnyRef/DafnyRef#sec-basic-types)
are a sequence of binary operations without parentheses: _a op b op c op d op e_.
But there are limitations on which operators can be in one chain together.

In particular for this error message, one cannot have chains that include both
less-than operations (either `<` or `<=`) and greater-than operations (either `>` or `>=`).
").TrimStart());

            Add(ErrorId.p_invalid_disjoint_chaining,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(290L, @"
[Chained operations](../DafnyRef/DafnyRef#sec-basic-types)
are a sequence of binary operations without parentheses: _a op b op c op d op e_.
But there are limitations on which operators can be in one chain together.

In particular for this error message, a disjoint operator (`!!`) can appear in a chain
only if all the operators in the chain are disjoint operators.

As described [here](../DafnyRef/DafnyRef#sec-collection-types),
`a !! b !! c !! d` means that `a`, `b`, `c`, and `d` are all mutually disjoint
(which is a different rewriting of the chain than for other operations).
").TrimStart());

            Add(ErrorId.p_operator_does_not_chain,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(291L, @"
The operators `in` and `!in` are relational operators, but they may not occur in a chain.
Use parentheses if necessary. Such expressions are usually not type-correct in any case.
").TrimStart());

            Add(ErrorId.p_bang_not_a_relational_op,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(292L, @"
The parser is expecting a relational expression, that is, two expressions separated by a relational operator
(one of `==`, `!=`, `>`, `>=`, `<`, `<=`, `!!`, `in`, `!in`). But the parser saw just a `!` ,
which could be the beginning of `!=`, `!!`, or `!in`, but is not continued as such.
So perhaps there is extraneous white space or something else entirely is intended.
").TrimStart(), range => new List<DafnyAction> {
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(293L, "replace with `!=`"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(294L, "!="), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(295L, false)),
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(296L, "replace with `!!`"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(297L, "!!"), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(298L, false)),
        });

            Add(ErrorId.p_invalid_relational_op,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(299L, @"
The parser is expecting a relational expression, that is, two expressions separated by a relational operator
(one of `==`, `!=`, `>`, `>=`, `<`, `<=`, `!!`, `in`, `!in`). But the parser saw two `!` separated by
white space. This is possibly meant to be a `!!` operator, but it could also just be an illegal expression.
").TrimStart(), Replace(MutateCSharp.Schemata88.ReplaceStringConstant_0(300L, "!!")));

            Add(ErrorId.p_ambiguous_bitop,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(301L, @"
The bit-operators `&`, `|`, and `^` have the same precedence but do not associate with each other.
So if they are used within the same expression, parentheses have to be used to show how they
are grouped. The example `5 | 6 & 7` should be written as either `(5 | 6) & 7` or `5 | (6 & 7)`.
").TrimStart());

            Add(ErrorId.p_invalid_char_literal,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(302L, @"
A character literal can only contain a single value of the built-in char type.
When --unicode-char is disabled, the char type represents UTF-16 code units, 
so this means a character literal can only contain a character that can be represented
with a single such unit, i.e. characters in the Basic Multilingual Plane. 
The rocket ship emoji ('🚀'), for example, is encoded with two surrogate code points.

This can be fixed by enabling the --unicode-char mode, as that defines char as any
Unicode scalar value, but be aware that it may change the meaning of your program.

More detail is given [here](../DafnyRef/DafnyRef#sec-character-constant-token) and [here](../DafnyRef/DafnyRef#sec-escaped-characters).;
").TrimStart());

            Add(ErrorId.p_no_parenthesized_binding,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(303L, @"
Bindings of the form `x := y` are used in map-display expressions, in which case they are enclosed in square brackets,
not parentheses. `var c := ( 4 := 5 )` should be `var c := map[ 4 := 5 ]`.
").TrimStart(), range => new List<DafnyAction> {
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(304L, "replace `( )` with `map[ ]`"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(305L, "map[") + range.PrintOriginal()[1..^MutateCSharp.Schemata88.ReplaceNumericConstant_2(306L, 1)] + MutateCSharp.Schemata88.ReplaceStringConstant_0(310L, "]"), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(311L, false)),
    OneAction(MutateCSharp.Schemata88.ReplaceStringConstant_0(312L, "replace `( )` with `imap[ ]`"), range, MutateCSharp.Schemata88.ReplaceStringConstant_0(313L, "imap[") + range.PrintOriginal()[1..^MutateCSharp.Schemata88.ReplaceNumericConstant_2(314L, 1)] + MutateCSharp.Schemata88.ReplaceStringConstant_0(318L, "]"), MutateCSharp.Schemata88.ReplaceBooleanConstant_1(319L, false)),
        });

            Add(ErrorId.p_must_be_multiset,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(320L, @"
A set/iset/multiset display expression can have two forms. 
One form is a list of values enclosed by curly braces: `var c := multiset{1,2,2,3}`.
The other appears as a conversion operation: `var c := multiset(s)`.
However, this second form can only be used to convert a set to a multiset.

In the current parser, however, this error message is unreachable,
so if it appears please report the error.
The tests that check for this error case are already known to be false by previous testing.
").TrimStart());

            Add(ErrorId.p_seq_display_has_one_type_argument,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(321L, @"
The built-in `seq` (sequence) type takes one type parameter, which in some situations is inferred.
That type parameter is the type of the sequence elements.
").TrimStart()); // TODO - get rid of the extra parameters

            Add(ErrorId.p_map_comprehension_must_have_term_expression,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(322L, @"
A map comprehension defines a map, which associates a value with each member of a set of keys.
The full syntax for a map comprehension looks like `map x | 0 <= x < 5 :: x*2 := x*3`
which maps the keys `0, 2, 4, 6, 8` to the values `0, 3, 6, 9, 12` respectively.

One can abbreviate the above syntax to expressions like `map x | 0 <= x < 5 :: x*3`,
which is equivalent to `map x | 0 <= x < 5 :: x := x*3`. The missing expression before
the `:=` is just the declared identifier.

One can also have multiple variables involved as in `map x, y | 0 < x < y < 5 :: 10*x+y := 10*y+x`,
which defines the mappings `(12=>21, 13=>31, 14=>41, 23=>32, 24=>42, 34=>43)`.

But when there are multiple variables, one cannot abbreviate the `:=` syntax with just its right-hand expression,
because it is not clear what the left-hand expression should be. 

Incorrect text like `const s := map x, y | 0 <= x < y < 10 :: x*y` should be written
as `const s := map x, y | 0 <= x < y < 10 :: f(x,y) := x*y` for some `f(x,y)` that gives
a unique value for each pair of `x,y` permitted by the range expression (here `0 <= x < y < 10`).
").TrimStart());

            Add(ErrorId.p_no_patterns_in_let_such_that,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(323L, @"
The let-such-that expression initializes a variable to some value satisfying a given condition.
For example, one might write `const cc := var x: int :| x <= 10; x`,
where `cc` would get some value `x` satisfying `x < 10`.

For simplicity, however, Dafny requires the variables being initialized to be simple names, not patterns.
").TrimStart());

            Add(ErrorId.p_no_equal_in_let_initialization,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(324L, @"
Like local variables, let variables are initialized with `:=` (and sometimes with `:-` or `:|`), but not with `=`.
In Dafny `=` is used only in type definitions.
").TrimStart(), sharedLambda);

            Add(ErrorId.p_elephant_has_one_lhs,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(325L, @"
Within a function, the `:-` operator is limited to a most one left-hand-side and exactly one-right-hand-side.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(326L, false), MutateCSharp.Schemata88.ReplaceStringConstant_0(327L, "remove extra LHSs")));

            Add(ErrorId.p_elephant_has_one_rhs,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(328L, @"
This error only occurs when using the elephant operator `:-` in conjunction with
[failure-compatible types](../DafnyRef/DafnyRef#sec-failure-compatible-types)
and in the context of a let-or-fail expression.

In contrast to the let expression (`:=`), which allows multiple parallel initializations, 
the let-or-fail expression (`:-`) is implemented to
only allow at most a single left-hand-side and exactly one right-hand-side.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(329L, false), MutateCSharp.Schemata88.ReplaceStringConstant_0(330L, "remove extra RHSs")));

            Add(ErrorId.p_set_comprehension_needs_term_expression,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(331L, @"
A set comprehension (1) declares one or more variables, (2) possibly states some limits on those variables, 
and (3) states an expression over those variables that are the values in the set.

If there is no expression, then the expression is taken to be just the _one_ declared variable.
For instance one could write `set b: bool`, which is equivalent to `set b: bool :: b` and would be the set of all `bool` values.
Another example is `set x: nat | x < 5, which is equivalent to `set x: nat | x < 5:: x` and would be the set `{0, 1, 2, 3, 4}`.

But if more than one variable is declared, then there is no natural implicit expression to fill in after the `::` if it is omitted, 
so some expression is required. The failing example above, for example, might use the expression `x * y`, as in 
`set x, y  | 0 <= x < y < 10 :: x * y`, or any other expression over `x` and `y`.
").TrimStart(), InsertAfter(MutateCSharp.Schemata88.ReplaceStringConstant_0(332L, " :: 0"), MutateCSharp.Schemata88.ReplaceStringConstant_0(333L, "insert example expression")));

            Add(ErrorId.p_invalid_name_after_dot,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(334L, @"
This error message is not reachable in current Dafny.
If it occurs, please report an internal bug (or obsolete documentation).
").TrimStart());

            Add(ErrorId.p_bad_number_format,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(335L, @"
This error can only result from an internal bug in the Dafny parser.
The parser recognizes a legitimate sequence of digits (as an integer literal
and then passes that string to a library routine to create a BigInteger
or BigDecimal. Given the parser logic, that parsing should never fail.
").TrimStart());

            Add(ErrorId.p_bad_hex_number_format,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(336L, @"
This error can only result from an internal bug in the Dafny parser.
The parser recognizes a legitimate sequence of hexdigits
and then passes that string to a library routine to create a BigInteger. 
Given the parser logic, that parsing should never fail.
").TrimStart());

            Add(ErrorId.p_bad_decimal_number_format,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(337L, @"
This error can only result from an internal bug in the Dafny parser.
The parser recognizes a legitimate Dafny decimal number 
and then passes that string to a library routine to create a BigDecimal. 
Given the parser logic, that parsing should never fail.
").TrimStart());

            Add(ErrorId.p_generic_syntax_error,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(338L, @"
This ""invalid something"" message where the something is typically
the name of an internal parser non-terminal means that the text being parsed
is a badly malformed instance of whatever parser entity was being parsed.
This is an automatically generated message by the CoCo parser generator
for a situation in which no specific recovery or a
more informative error message has been implemented.

The only advice we can give is to carefully scrutinize the location of the
error to see what might be wrong with the text. If you think this is a
common or confusing enough occurrence to warrant special error handling,
please suggest the improvement, with this sample code, to the Dafny team.
").TrimStart());

            Add(ErrorId.p_deprecated_semicolon,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(339L, @"
Semicolons are required after statements and declarations in method bodies,  
but are deprecated after declarations within modules and types.
").TrimStart(), Remove(MutateCSharp.Schemata88.ReplaceBooleanConstant_1(340L, true), MutateCSharp.Schemata88.ReplaceStringConstant_0(341L, "remove semicolon")));

            Add(ErrorId.p_file_has_no_code,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(342L, @"
The indicated file has no code. This can be because the file is empty, because some parse error
left the top-level module with no well-formed declarations, or because a unclosed comment
has commented-out the whole file.
").TrimStart());

            Add(ErrorId.p_internal_exception,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(343L, @"
This error indicates an internal crashing bug in Dafny. Please report it with as much of 
the source code that causes the problem as possible.
").TrimStart());

            Add(ErrorId.p_deprecated_inductive_predicate,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(344L, @"
The terms `least predicate` and `greatest predicate` are more descriptive of the relationship between them than was the old terminology.
").TrimStart());

            Add(ErrorId.p_deprecated_copredicate,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(345L, @"
The terms `least predicate` and `greatest predicate` are more descriptive of the relationship between them than was the old terminology.
").TrimStart());

            Add(ErrorId.p_deprecated_statement_refinement,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(346L, @"
Statement refinement has been deprecated. Refinement is restricted to changing declarations, not bodies of methods or functions.
").TrimStart());

            Add(ErrorId.p_deprecated_forall_with_no_bound_variables,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(347L, @"
<!-- TODO -->
").TrimStart());

            Add(ErrorId.p_deprecated_modify_statement_with_block,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(348L, @"
<!-- TODO-->
").TrimStart());

            Add(ErrorId.p_deprecated_opaque_as_identifier,
        MutateCSharp.Schemata88.ReplaceStringConstant_0(349L, @"
Because of the value to proof success of using `opaque` declarations and `reveal`ing them in appropriate contexts,
the word `opaque` is being converted to a reserved keyword, whereas it used to be a normal identifier.
Please rename your use of opaque as an identifier to some other name.
").TrimStart());

        }

        public static void RunStaticConstructor()
        {
        }
    }
}
