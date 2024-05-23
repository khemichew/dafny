// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
ghost method {:tailrecursion} m(n: nat) returns (r: nat)
{ 
  if n == 0 { r := 0; } else { r := m(n-1); }
}
