// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
module P {
  type T = bool
  class A { const c: bool }
}
module Q refines P {
  class A ... { const c: T }
}
