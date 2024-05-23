// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
function f(i: set<int>): set<int> { set k: int <- i |  true || k  }
