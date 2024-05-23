// RUN: %exits-with 3 %baredafny run --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
method {:main} M(s: seq<string>) {}
method {:main} P() {}
