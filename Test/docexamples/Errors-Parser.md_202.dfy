// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
module M {
  export A reveals b, a, reveals b
  export B reveals b, a, provides b
  export C provides b, a, reveals b
  export D provides b, a, provides b
  const a: int
  const b: int
}
