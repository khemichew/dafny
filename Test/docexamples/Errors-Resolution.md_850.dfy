// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
class A { var a: int }
lemma lem(aa: A) {
  aa.a := 1;
}
method m(aa: A) {
  ghost var b := true;
  if b { aa.a := 1; }
}
