// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
const a: int
const x: ORDINAL
method m() 
{  
  var c := a[0,0];
}
