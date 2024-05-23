// RUN: %exits-with 0 %baredafny resolve --function-syntax:4 --use-basename-for-filename --allow-warnings  "%s" > "%t"
 
predicate g(i: int, j: int)
function f(): int
  ensures forall i: int, j: int {:induction j,i} | true :: g(i,j)
{ 0 }
