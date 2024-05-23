// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
class A { var a: int }
method n() returns (r: int, ghost s: int) {}
method m(a: A) returns (r: bool)
{ 
  var x: int;
  var y: int;
  x, a.a := n();
}
