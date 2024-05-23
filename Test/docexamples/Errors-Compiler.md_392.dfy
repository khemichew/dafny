// RUN: %exits-with 3 %baredafny run --function-syntax:4 --use-basename-for-filename --enforce-determinism --enforce-determinism "%s" > "%t"
 
method m(k: int) {
  var i := k;
  if
  {
    case i >= 0 => i := i - 1;
    case i <= 0 => i := i + 1;
  }
}
