// RUN: %exits-with 0 %baredafny resolve --function-syntax:4 --use-basename-for-filename --allow-warnings  "%s" > "%t"
 
method m(i: int) 
{
   var j: int;
   j := 1;
   label L:
   j := 2;
   ghost var k := old@L(j);   
}
