// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
abstract module M { newtype T = int }
module N refines M { newtype T = ... int }
