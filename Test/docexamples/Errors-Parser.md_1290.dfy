// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
method m() {
  var c := ( 4 := 5 );
}
