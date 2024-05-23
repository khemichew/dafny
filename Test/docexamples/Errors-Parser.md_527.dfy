// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
class C {
  constructor (i: int) returns (j: int) {}
}
