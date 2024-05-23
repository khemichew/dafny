// RUN: %exits-with 0 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
method m() {
  var to: int := 6;
  var downto: int := 8;
  for to := to to downto {}
}
