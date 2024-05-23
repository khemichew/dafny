// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
module P {
  predicate m(i: nat) reads {}
}
module Q refines P {
  predicate m(i: nat) decreases i {true }
}
