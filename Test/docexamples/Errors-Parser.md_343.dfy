// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
method m(i: int) returns (nameonly r: int) { r := 0; }
