// RUN: %exits-with 3 %baredafny run --function-syntax:4 --use-basename-for-filename --enforce-determinism --enforce-determinism "%s" > "%t"
 
class A { constructor A(){}}

method m(k: int, o: A) 
  modifies o
{
  var i := k;
  modify o;
}
