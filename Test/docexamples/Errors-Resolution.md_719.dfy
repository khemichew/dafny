// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
class A { var a: int }
method m(aa: A)
  modifies aa
{ 
  assert true by {
    var i:= 10;
    while (i > 0) 
      decreases i
      modifies aa
    {
    i := i - 1;
    }
  }
}
