// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
module P {
  method m(i: int)
}
module Q refines P {
  method m(i: int, j: int) {}
}