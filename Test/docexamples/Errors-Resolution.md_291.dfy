// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
const d: bv4
const c := match d { case -0 => 0 case _ => 1 }
