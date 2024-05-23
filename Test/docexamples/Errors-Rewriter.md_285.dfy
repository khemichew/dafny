// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename --track-print-effects --track-print-effects "%s" > "%t"
 
function f(): int {42 }
by method {
  print "I'm here\n";
  return 42;
}
