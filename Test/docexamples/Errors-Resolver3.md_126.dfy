// RUN: %exits-with 2 %baredafny resolve --function-syntax:4 --use-basename-for-filename  "%s" > "%t"
 
module M { type T }
module N { type T }

import opened M
import opened N
const t: T

