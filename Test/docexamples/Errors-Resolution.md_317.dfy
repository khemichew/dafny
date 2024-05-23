// RUN: %exits-with 0 %baredafny resolve --function-syntax:4 --use-basename-for-filename --allow-warnings  "%s" > "%t"
 
ghost const c := exists i: int :: true ==> true
