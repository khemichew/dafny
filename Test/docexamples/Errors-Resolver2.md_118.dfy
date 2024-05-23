// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
method {:tailrecursion} m<T,U>(n: nat) returns (r: nat)
{ 
  if n == 0 { return 0; } else { r := m<U,U>(n-1); }
}
