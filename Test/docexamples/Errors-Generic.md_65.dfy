// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename --unicode-char=false --unicode-char=false "%s" > "%t"
 
const c := '\U{D000}'
