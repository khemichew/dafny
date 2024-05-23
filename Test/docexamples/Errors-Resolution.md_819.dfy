// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
class A {  }
lemma m(a: A)
{
  var aa := new A;
}
