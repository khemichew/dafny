// RUN: %exits-with 3 %baredafny run --function-syntax:4 --use-basename-for-filename --main-method:mmm --main-method:mmm "%s" > "%t"
 
method mmm(i: int) {}
