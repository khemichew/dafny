// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
method m(ghost c: int) 
{
  var x := 7;
  if (c == 1) { x :| x < 8; }
}