// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
module P {
  predicate m() reads {}
}
module Q refines P {
  predicate m() reads this {true }
}
