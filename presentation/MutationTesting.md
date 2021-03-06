# Mutation Testing

### What?

- small modifications to production code
  - each modified version is called a `mutant`
- run tests against each mutant
  - at least one failing test will `kill` the mutant
  - no failing tests let the mutant `survive`
- effectiveness of test suites is measured by percentage of killed mutants

A mutant survives if it is not covered by an assertion.
Kill all the mutants.

### Why?
- support Test-driven development
- Code Coverage vs Test Effectiveness

### How?
[Example](./MutationTesting_Mutators.md)

---
###### [TOC](./TOC.md) < | > [Mutators](./MutationTesting_Mutators.md)
