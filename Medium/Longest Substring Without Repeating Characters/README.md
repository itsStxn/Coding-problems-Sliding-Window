# Longest Substring Without Repeating Characters

## Description
Given a string `s`, find the length of the longest substring without duplicate characters.

### Example 1
**Input**: `s` = "abcabcbb"  
**Output**: 3  
**Explanation**: The answer is "abc", with the length of 3. Note that "bca" and "cab" are also correct answers.

### Example 2
**Input**: `s` = "bbbbb"  
**Output**: 1  
**Explanation**: The answer is "b", with the length of 1.

### Example 3
**Input**: `s` = "pwwkew"  
**Output**: 3  
**Explanation**:
- The answer is "wke", with the length of 3.
- Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.

### Constraints
0 <= `s.length` <= 5 * 104  
`s` consists of English letters, digits, symbols and spaces.

## Strategy
Read through the string and use a dicrionary to store characters and the last indexes they where seen occupying. Use `start` and `end` pointers to move through the string. If `end` finds a character that has already been seen, move `start` at the right of its last index. Then update the index as the current one. 

## Time Complexity - O(n)
Each element is preocessed once.

## Space Complexity - O(n)
Using a dictionay to store seen characters.
