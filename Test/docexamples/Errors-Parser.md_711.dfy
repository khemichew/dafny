// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
function method m(): int {
  42
} by method {
  return 42;
}
