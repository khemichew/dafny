// RUN: %exits-with 0 %baredafny resolve --function-syntax:4 --use-basename-for-filename --allow-warnings  "%s" > "%t"
 
method m() {
  assert!(1 == 1);
}
