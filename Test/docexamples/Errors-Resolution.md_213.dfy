// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
codatatype Stream = SNil | SCons(head: int, tail: Stream)
const s: Stream
const t: Stream
const b := s == #[1] t
