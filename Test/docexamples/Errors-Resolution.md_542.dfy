// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
method m(i: int) {
  ghost var b: bool := true;
  label x: while i > 0 {
    while (b) {
      break x;
    }
  }
}
