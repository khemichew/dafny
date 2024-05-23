// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
class A {
  var x: int := 6
  var y: int, x: int := 6, z: int
}
