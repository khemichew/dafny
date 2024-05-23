// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
codatatype D = A | B(i: bool)
ghost function {:abstemious} f(d: D, e: D): D { B(d == e) }
