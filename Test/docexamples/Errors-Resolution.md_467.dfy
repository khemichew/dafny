// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
codatatype EnormousTree<X> = Node(left: EnormousTree, val: X, right: EnormousTree)
ghost function {:abstemious} BadMatch(t: EnormousTree): EnormousTree
{ 
  match t.right  // error: cannot destruct t.right
  case Node(a, x, b) =>
    Node(a, x, b)
}
