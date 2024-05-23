// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
module P {
  class A { predicate m(i: nat) }
}
module Q refines P {
  class A ... { static predicate m(i: nat) {true } }
}
