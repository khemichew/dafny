// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
datatype D = D()
class A {}
method m(a: D, b: A) {
  assert a < b;
  assert a > b;
}
