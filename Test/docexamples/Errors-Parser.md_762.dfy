// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
module {:options "--function-syntax:4"} M {
  function method f(): int { 42 }
}
