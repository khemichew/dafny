// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
method g(n: nat) returns (r: nat) { r := f(n); }
method {:tailrecursion} f(n: nat) returns (r: nat)
{ 
  if n == 0 { r := 0; } else { r := g(n-1); }
}
