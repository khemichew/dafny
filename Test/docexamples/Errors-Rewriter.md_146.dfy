// RUN: %exits-with 0 %baredafny resolve --function-syntax:4 --use-basename-for-filename --allow-warnings  "%s" > "%t"
 
function f(b: bool): bool
{
  b ==> b && 
  b          // this parses as b ==> (b && b), but reads as (b ==> b) && b
}
