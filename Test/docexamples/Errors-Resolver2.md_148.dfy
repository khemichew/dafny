// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename --function-syntax:4 --function-syntax:4 "%s" > "%t"
 
function g(n: nat): nat { f(n) }
function {:tailrecursion} f(n: nat): nat
{ 
  if n == 0 then 0 else g(n-1)
}
