// RUN: %exits-with 2 %baredafny test --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
method {:test} m() returns (j: int, k: int) 
{
  j, k := 0,0;
}
