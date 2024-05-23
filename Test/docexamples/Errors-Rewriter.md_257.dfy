// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
trait T {
  method m()
}

class C extends T {
  method {:print} m() {}
}
