// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename --function-syntax:4 --function-syntax:4 "%s" > "%t"
 
function {:tailrecursion} f(n: nat): nat
{
  if n < 2 then n else f(n-2)+f(n-1)
}
