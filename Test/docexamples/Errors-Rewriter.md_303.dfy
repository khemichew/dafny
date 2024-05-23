// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename --track-print-effects --track-print-effects "%s" > "%t"
 
method m() { print 42; }
