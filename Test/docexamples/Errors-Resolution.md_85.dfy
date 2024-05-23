// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
twostate function f(): int { 42 }
method m() returns (r: int) {
  r := f();
}
