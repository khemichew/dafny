// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
module P {
  type T<+U> 
}
module Q refines P {
  type T<U> = int
}
