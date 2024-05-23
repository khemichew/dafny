// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename --allow-deprecation --unicode-char:false --allow-deprecation --unicode-char:false "%s" > "%t"
 
const c := '🚀'
