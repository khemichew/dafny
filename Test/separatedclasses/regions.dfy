// RUN: %exits-with 4 %baredafny verify %args --region-checks:true "%s" > "%t"
// RUN: %diff "%s.expect" "%t"

module RegionTests {
  // A node that, when attached to another, cannot be modified except by that other node
  class Node {
    ghost var Repr: set<object>
    var value: int
    var next: Node?

    ghost predicate Invariant()
      reads this, Repr
    {
      && this in Repr
      && (if next == null then Repr == {this} else
          && next in Repr
          && this !in next.Repr
          && Repr == {this} + next.Repr
          && next.Region == this)
    }
    function GetValue(): int
      reads this
    {
      value
    }
    method Obtain() returns (v: int) {
      v := value;
    }
    method SetValue(newValue: int)
      modifies this`value
      ensures value == newValue
    {
      value := newValue;
    }

    constructor Wrong(value: int, next: Node?)
      modifies next
      requires next != null ==> next.Invariant() // && next.Region == null
      // Forgot to require the region of next to be null
      ensures next != null ==>
         && old(next.value) == next.value
         && old(next.next) == next.next
         && next.Region == this
      ensures Region == null && this.value == value && this.next == next
      ensures Invariant()
    {
      this.value := value;
      this.next := next;
      Region := null;
      Repr := if next == null then {this} else {this} + next.Repr;
      new;
      if next != null {
        next.Region := this;  // Error: could not prove that next.Region == this || next.Region == this.Region || next.Region == null;
      }
    }

    constructor(value: int, next: Node?)
      modifies next
      requires next != null ==> next.Invariant() && next.Region == null
      ensures next != null ==>
         && old(next.value) == next.value
         && old(next.next) == next.next
         && next.Region == this
      ensures Region == null && this.value == value && this.next == next
      ensures Invariant()
    {
      this.value := value;
      this.next := next;
      Region := null;
      Repr := if next == null then {this} else {this} + next.Repr;
      new;
      if next != null {
        next.Region := this; // Ok because next.Region == this.Region at this point
      }
    }
    method ChangeNextValueWrong(newValue: int)
      requires next != null && next != this
      //requires next.Region == this // Oops forgot
      modifies next
      ensures next.next == old(next.next) && next.Region == old(next.Region)
      ensures next.value == newValue
    {
      next.value := newValue; // Error: could not prove next.Region == this.Region || next.Region == this || next.Region == null
    }
    method ChangeNextValue(newValue: int)
      requires next != null && next != this
      requires next.Region == this // Guaranteed by the invariant
      modifies next
      ensures next.next == old(next.next) && next.Region == old(next.Region)
      ensures next.value == newValue
    {
      next.value := newValue; // OK
    }
    method ChangeNextValueWrong2(newValue: int)
      requires next != null && next != this
      //requires next.Region == this // Forgotten
      modifies next
      ensures next.next == old(next.next) && next.Region == old(next.Region)
      ensures next.value == newValue
    {
      next.SetValue(newValue); // Error: Could not prove next.Region == this
    }
    method ChangeNextValue2(newValue: int)
      requires next != null && next != this
      requires next.Region == this // Guaranteed by the invariant
      modifies next
      ensures next.next == old(next.next) && next.Region == old(next.Region)
      ensures next.value == newValue
    {
      next.SetValue(newValue); // OK
    }
  }

  method Test() {
    var c := new Node(0, null);
    c.value := 2;            // OK
    var d := new Node(0, c); // At this point, c belongs to the region d
    assert c.Region == d;    // OK
    assert d.next == c;      // OK
    var x := c.value;        // OK even if not in the same region
    var y := c.GetValue();   // OK, it's only a function read
    var z := c.Obtain();     // OK, it's only a method without modifies clause
    if * {
      c.value := 3;          // Error: Cannot prove that c.Region == null
    } else {
      c.SetValue(3);          // Error, cannot prove that c.Region == null
    }
  }

  method Test2() {
    var c := new Node(0, null);
    c.value := 2;            // OK
    var d := new Node(0, c); // After this, c belongs to the region d
    assert c.Region == d;    // OK
    assert d.next == c;
    d.ChangeNextValue(3);
    assert c.value == 3;     // OK
  }

  class ArrayWrapper {
    const elements: array<int>
    constructor()
      ensures elements.Region == this
      ensures elements.Length == 4
      ensures this.Region == null
    {
      this.elements := new int[4];
      this.Region := null; // Makes it possible to modify by caller
      new;
      elements.Region := this;  // OK because fresh arrays have a Region set to null
    }
    method SetWrong(index: int, newValue: int) returns (previousValue: int)
      requires 0 <= index < elements.Length
      // requires elements.Region == this // If forgotten, error
      modifies elements
      ensures elements[index] == newValue
    {
      var r := this.Region;
      previousValue := elements[index]; // OK, it's only a read
      if * {
        elements[index] := newValue;  // Error: Cannot prove that elements.Region == this || elements.Region == this.Region || elements.Region == null
      } else {
        elements.Region := null;  // Error: elements's region is unknown
        SetStatic(elements, index, newValue, this);
        assert elements.Region == this;
      }
    }
    static method SetStatic(elements: array<int>, index: int, newValue: int, previousOwner: ArrayWrapper)
      requires 0 <= index < elements.Length
      requires elements.Region == null
      modifies elements
      ensures elements[index] == newValue
      ensures elements.Region == previousOwner
    {
      elements[index] := newValue;      // OK
      elements.Region := previousOwner; // OK because elements.Region == null and we are in a static context
    }
    method Set(index: int, newValue: int) returns (previousValue: int)
      requires 0 <= index < elements.Length
      requires elements.Region == this
      modifies elements
      ensures elements[index] == newValue
    {
      previousValue := elements[index]; // OK
      elements[index] := newValue;      // OK
    }
    method SetOk(index: int, newValue: int) returns (previousValue: int)
      requires 0 <= index < elements.Length
      requires elements.Region == this
      modifies elements
      ensures elements[index] == newValue
    {
      previousValue := elements[index]; // OK
      if * {
        elements[index] := newValue;  // Ok
      } else {
        elements.Region := null;  // OK
        SetStatic(elements, index, newValue, this);
        assert elements.Region == this;
      }
    }
  }

  method Test3() {
    var c := new ArrayWrapper();
    var x := c.elements[0];       // OK
    if * {
      c.elements[0] := 3;         // Error: Cannot prove that c.elements.Region == null
    } else {
      var previousValue := c.Set(0, 3);                // OK
      assert c.elements[0] == 3;  // OK
    }
  }
}













