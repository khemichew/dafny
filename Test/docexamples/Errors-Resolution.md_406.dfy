// RUN: %exits-with 0 %baredafny resolve --function-syntax:4 --use-basename-for-filename --allow-warnings  "%s" > "%t"
 
trait T {}
const m: map<T,T>
const c := null in m
