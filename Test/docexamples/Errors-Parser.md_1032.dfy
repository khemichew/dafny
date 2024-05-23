// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
lemma abs(a: int, b: int, c: int)
  ensures a + b + c == c + b + a
{
  calc != {
    a + b + c;
    a + c + b;
    c + a + b;
  }
}
