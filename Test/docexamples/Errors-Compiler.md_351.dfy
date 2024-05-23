// RUN: %exits-with 3 %baredafny run --function-syntax:4 --use-basename-for-filename --enforce-determinism --enforce-determinism "%s" > "%t"
 
method m() {
var y: int;
  if * { y:= 0; } else { y:= 1; }
}
