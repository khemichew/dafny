// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
module P {
  type T(==)
}
module Q refines P {
  type T = AlwaysAndForeverMore
  codatatype AlwaysAndForeverMore = Cons(int, AlwaysAndForeverMore)
}
