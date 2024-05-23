// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
module P {
  method m(i: nat) 
}
module Q refines P {
  ghost method m(i: nat) { } 
}
