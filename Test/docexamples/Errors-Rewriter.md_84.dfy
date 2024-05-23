// RUN: %exits-with 0 %baredafny resolve --function-syntax:4 --use-basename-for-filename --allow-warnings  "%s" > "%t"
 
const c := 0
lemma {:induction 42} m(i: int, j: int) ensures i + j == j + i {} 
