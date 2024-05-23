// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
method {:tailrecursion} m(n: nat) returns (r: nat)
{ 
  while n > 0 { r := m(n-1); }
}
