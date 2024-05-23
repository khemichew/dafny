// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
method f(n: int) returns (r: int)
  decreases *, n
{
  r := if n == 0 then n else -1-f(n-1);
}
