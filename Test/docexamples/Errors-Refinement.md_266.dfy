// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
module P {
  iterator I() yields (x: int)
}
module Q refines P {
  iterator I... modifies {}
}
