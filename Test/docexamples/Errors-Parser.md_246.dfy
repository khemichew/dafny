// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
abstract module M { datatype D = A | B }
module N refines M { datatype D = ... Y | Z }
