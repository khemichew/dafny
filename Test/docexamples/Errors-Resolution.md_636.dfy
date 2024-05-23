// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
method n() {}
method m()
{  
  var i: int;
  assert true by {
    n();
  }
}
