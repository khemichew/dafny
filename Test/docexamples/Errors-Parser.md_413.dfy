// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
iterator Count(n: nat) returns (x: nat) {
  var i := 0;
  while i < n {
    x := i;
    yield;
    i := i + 1;
  }
}
