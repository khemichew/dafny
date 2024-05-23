// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
codatatype D = A | B
function {:abstemious} f(): int {0}
