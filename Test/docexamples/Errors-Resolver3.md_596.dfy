// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
const x: ORDINAL
const y: int
const z := y < x 
const w := y >= x 
