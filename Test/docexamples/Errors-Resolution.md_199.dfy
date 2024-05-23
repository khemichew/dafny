// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
datatype D = A | B
method m(dd: D) 
{
  var d := A;
  print d < dd;
}
