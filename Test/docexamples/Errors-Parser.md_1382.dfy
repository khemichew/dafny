// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
datatype Outcome<T> = 
  | Success(value: T) 
  | Failure(error: string) 
{ predicate IsFailure() { this.Failure? } 
  function PropagateFailure<U>(): Outcome<U> 
    requires IsFailure() 
  { Outcome<U>.Failure(this.error) // this is Outcome<U>.Failure(...) 
  }
 
  function Extract(): T requires !IsFailure() { this.value } 
}

function m(): Outcome<int> { Outcome<int>.Success(0) }
function test(): Outcome<int> {
  var rr, rrr :- m(); Outcome.Success(1) 
}
