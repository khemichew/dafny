// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
datatype D = A | ghost B(c: int)
method m(d:D) 
  requires d.B?
{
  print d.(c := 0);
}
