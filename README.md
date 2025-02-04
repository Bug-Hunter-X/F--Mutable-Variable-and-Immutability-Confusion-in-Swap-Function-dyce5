# F# Mutable Variable and Immutability Confusion

This example demonstrates a common error in F# related to the misuse of mutable variables, particularly when dealing with shadowing and immutability.

The `bug.fs` file contains code that attempts to swap two variables.  The issue arises when trying to apply the swap function to immutable values, resulting in a compile-time error. The `bugSolution.fs` file provides a corrected version showing how to properly handle mutability and immutability.

## How to Reproduce
1. Compile and run `bug.fs`.  Observe the error when using immutable variables.
2. Compile and run `bugSolution.fs` to see the correct implementation.

## Learning Points
* Understand the difference between mutable and immutable variables in F#.
* Be mindful of variable shadowing; ensure that you're modifying the intended variable.
* Leverage the type system to prevent accidental misuse of mutability.