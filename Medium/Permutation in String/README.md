# Permutation in String

## Description
Given two strings `s1` and `s2`, return true if `s2` contains a permutation of `s1`, or false otherwise.

In other words, return true if one of `s1`'s permutations is the substring of `s2`.

### Example 1
**Input**: `s1` = "ab", `s2` = "eidbaooo"  
**Output**: true  
**Explanation**: `s2` contains one permutation of `s1` ("ba").

### Example 2
**Input**: `s1` = "ab", `s2` = "eidboaoo"  
**Output**: false

### Constraints
1 <= `s1.length`, `s2.length` <= 104  
`s1` and `s2` consist of lowercase English letters.

## Strategy
Checking every permutation possible is a demanding task. A workaround is turning words into frequency arrays.

Map each character count to an array of 26 integers initialized as 0. Each index represents a letter. Permutations of a word share the exact same frequency array.

Make a frequency array of `s1` and compare it to the frequency of `s2` by updating its values using its sliding window. Constantly compare the two frequency arrays to detect the permutation.

## Time Complexity - O(n)
Althogh there are notable operations like comparing arrays, those operations do not depend on `n`, rather they run at constant time. The loops used in the solution depend on `n`.

## Space Complexity - O(1)
No data structure variables with `n` size are used.
