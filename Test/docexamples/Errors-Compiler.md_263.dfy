// RUN: %exits-with 3 %baredafny run --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
method m(x: int) {
  assume x > 0;
}
