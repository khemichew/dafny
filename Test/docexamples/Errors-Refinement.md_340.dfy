// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
module P {
 class A {const c: int }
}
module Q refines P {
  class A ... { static const c := 7 }
}
