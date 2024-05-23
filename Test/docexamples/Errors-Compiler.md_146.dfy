// RUN: %exits-with 3 %baredafny run --function-syntax:4 --use-basename-for-filename --main-method:m --main-method:m "%s" > "%t"
 
class A { static method mm() {} }
