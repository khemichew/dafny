// RUN: %exits-with 3 %baredafny run --function-syntax:4 --use-basename-for-filename --enforce-determinism --target cpp --unicode-char:false --enforce-determinism --target cpp --unicode-char:false "%s" > "%t"
 
type {:extern "class" } T
