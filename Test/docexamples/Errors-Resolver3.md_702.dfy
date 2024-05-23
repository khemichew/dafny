// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
function f(mx: map<int,int>, my: map<int,int>): map<int,int> { mx - my }
