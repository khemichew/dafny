// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
module P {
  type T(!new)
}
module Q refines P {
  type T = (int, bool, array<real>)
}
