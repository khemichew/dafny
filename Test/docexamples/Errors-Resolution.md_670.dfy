// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
method n() returns (r: int, ghost s: int) {}
method m(a: array<int>) returns (r: bool)
  requires a.Length > 1
{ 
  var x: int;
  var y: int;
  x, y := n();
  a[0] := 0;
}
