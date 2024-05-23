// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
least predicate m(i: int)
  decreases i
{
  true
}
