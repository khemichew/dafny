// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
module P {
  type T(0)
}
module Q refines P {
  type T = A
  class A { }
}
