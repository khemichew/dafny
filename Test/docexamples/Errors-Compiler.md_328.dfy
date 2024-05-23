// RUN: %exits-with 3 %baredafny run --function-syntax:4 --use-basename-for-filename --enforce-determinism --enforce-determinism "%s" > "%t"
 
method m() {
  var x: int;
  x :| x < 5;
}
