// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
module {:options "--function-syntax:3"} M {
  ghost function f(): int { 42 }
}
