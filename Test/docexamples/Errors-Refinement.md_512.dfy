// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
module P {
  ghost predicate m(i: nat) { true }
}
module Q refines P {
  predicate m(i: nat) { true }
}
