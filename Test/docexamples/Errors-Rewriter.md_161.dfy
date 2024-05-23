// RUN: %exits-with 2 %baredafny test --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
method {:test} m(i: int) {}
