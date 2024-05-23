// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
function ff(j: map<int,int>): map<int,int> { j * j }
