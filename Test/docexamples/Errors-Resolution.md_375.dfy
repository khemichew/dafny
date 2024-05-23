// RUN: %exits-with 0 %baredafny resolve --function-syntax:4 --use-basename-for-filename --allow-warnings  "%s" > "%t"
 
class C {}
function f(): C
method m(c: C) {
  var b: bool := f() != null;
  var a: bool := c != null;
}
