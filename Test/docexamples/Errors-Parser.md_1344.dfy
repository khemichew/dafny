// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
datatype Data = D(i: int, j: int)
const c: int := var Data(d,dd) :| d == 10 && dd == 11; d
