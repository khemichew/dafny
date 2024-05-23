// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename --function-syntax:4 --function-syntax:4 "%s" > "%t"
 
ghost function {:tailrecursion} f(n: nat): int
{ 
  if n == 0 then 0 else f(n-1)
}
