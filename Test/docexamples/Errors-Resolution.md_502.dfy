// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
method m(ghost b: bool)
{
  var x := 0;
  if b { expect x == 0; }
}
