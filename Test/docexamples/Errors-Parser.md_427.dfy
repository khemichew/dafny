// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
type List<T>
method m<+T>(i: int, list: List<T>) {}
method m<T,-U>(i: int, list: List<T>) {}
