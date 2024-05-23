// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
const a: object
function f(): int
  reads a, *
{
  0
}
