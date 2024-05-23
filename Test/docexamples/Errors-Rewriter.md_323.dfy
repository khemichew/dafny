// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename --track-print-effects --track-print-effects "%s" > "%t"
 
function m(): int { 42 }
by method { p(); return 42; }

method {:print} p() {}
