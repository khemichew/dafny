// RUN: %exits-with 0 %baredafny resolve --function-syntax:4 --use-basename-for-filename --allow-warnings --warn-missing-constructor-parentheses --warn-missing-constructor-parentheses "%s" > "%t"
 
datatype D = A | B

method m(d: D) {
  match d {
    case A => return;
    case B() => return;
  }
}
