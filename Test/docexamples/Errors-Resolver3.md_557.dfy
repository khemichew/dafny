// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
predicate m(x: int, s: set<int>)  { s !! x }
