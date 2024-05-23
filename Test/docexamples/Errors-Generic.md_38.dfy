// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename --unicode-char=true --unicode-char=true "%s" > "%t"
 
const c := '\U{00AABBCC}'
