// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
module P {
  predicate m(i: nat)
}
module Q refines P {
  predicate m(i: nat) requires true { true }
}
