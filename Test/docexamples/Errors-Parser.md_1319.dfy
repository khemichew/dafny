// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
const s := map x, y  | 0 <= x < y < 10 :: x*y
