// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
class A {}
method m(a: A) returns (b: bool){
  b := unchanged(a);
}
