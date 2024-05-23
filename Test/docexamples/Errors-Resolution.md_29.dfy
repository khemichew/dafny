// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
datatype A = A(x: int, ghost y: int)
method m(a: A) returns (r: int) {
    return a.y;
}
