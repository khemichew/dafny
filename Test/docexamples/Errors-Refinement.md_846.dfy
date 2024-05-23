// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
module P {
  class A {}
  predicate m(a: A)
}
module Q refines P {
  predicate m(older a: A) { true }
}
