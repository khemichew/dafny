// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
type Small = i: nat | i < 10
const i := 10
const b := i is Small
