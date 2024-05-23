// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
module P {
  function f(a: int): int { 0 }
}
module Q refines P {
  function f(a: int): int { 0 }
}
