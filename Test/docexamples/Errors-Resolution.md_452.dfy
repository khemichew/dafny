// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
codatatype EnormousTree<X> = Node(left: EnormousTree, val: X, right: EnormousTree)
ghost function {:abstemious} BadDestruct(t: EnormousTree): EnormousTree
{ 
  Node(t.left, t.val, t.right.right)  // error: cannot destruct t.right
}   
