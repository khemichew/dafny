// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
class A { function f(): int { 0 } }
const c := (new A).f()
