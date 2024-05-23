// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename --function-syntax:4 --function-syntax:4 "%s" > "%t"
 
ghost function f(): int { 42 }
method m() returns (a: int)
{
  a := f();
}
