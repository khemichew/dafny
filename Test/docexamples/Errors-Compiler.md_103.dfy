// RUN: %exits-with 3 %baredafny run --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
iterator Gen(start: int) yields (x: int)
  yield ensures |xs| <= 10 && x == start + |xs| - 1
