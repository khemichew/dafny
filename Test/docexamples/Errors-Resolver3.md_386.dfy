// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
class B {}
const bbb: B
predicate p() { allocated(bbb) }
