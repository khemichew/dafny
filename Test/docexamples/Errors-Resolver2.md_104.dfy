// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
method {:tailrecursion} m(n: nat) returns (r: nat, s: nat)
{ 
  var x, y := m(n-1);
}
