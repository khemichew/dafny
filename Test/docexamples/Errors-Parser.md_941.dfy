// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
datatype D = D(x: int, y: int)
method m() {
  var D(x,y) :| x + y == 5;
}