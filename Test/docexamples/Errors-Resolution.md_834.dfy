// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
class A { ghost var k: int }
lemma m(a: A)
{
  a.k := 9;
}