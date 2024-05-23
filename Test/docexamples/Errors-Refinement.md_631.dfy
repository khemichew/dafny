// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
module P {
  class A { method m(i: nat) }
}
module Q refines P {
  class A ... { static method m(i: nat) { } }
}
