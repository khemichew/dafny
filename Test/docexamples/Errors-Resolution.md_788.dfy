// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
lemma p(a: array<int>)
{
  forall i | 0 <= i < a.Length { a[i] := 0; } 
}
