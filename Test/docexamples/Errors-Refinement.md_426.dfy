// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
module P {
  function f(i: int): bool
}
module Q refines P {
  predicate f(i: int) { true }
}
