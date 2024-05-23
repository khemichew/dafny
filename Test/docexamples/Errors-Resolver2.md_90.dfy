// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
method {:tailrecursion} m(n: nat) returns (r: nat)
{ 
  var x := m(n-1);
}
