// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
method m(i: int, s: seq<int>) 
  requires |s| > 100
{
  var ss := i[1 := 10];
}
