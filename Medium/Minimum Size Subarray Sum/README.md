# Minimum Size Subarray Sum

## Description
Given an array of positive integers `nums` and a positive integer target, return *the minimal length of a subarray whose sum is greater than or equal to target*. If there is no such subarray, return 0 instead.

### Example 1
***Input***: target = 7, nums = [2,3,1,2,4,3]  
***Output***: 2  
***Explanation***: The subarray [4,3] has the minimal length under the problem constraint.

### Example 2
***Input***: target = 4, nums = [1,4,4]  
***Output***: 1  

### Example 3
***Input***: target = 11, nums = [1,1,1,1,1,1,1,1]  
***Output***: 0  

### Constraints
- 1 <= `target` <= 10^9
- 1 <= `nums.length` <= 10^5
- 1 <= `nums[i]` <= 10^4

## Strategy

### Standard
Traverse the array using a right pointer. If the numbers seen sum up to a value greater or equal to the target, keep moving left forward to see if it is possible to reduce the window' length.

### Prefix Sum
Use Prefix Sum algorithm, so create a prefix array. Prefix is sorted because of its cumulative sum nature. This condition allow to perform binary search for each index of the prefix array. The target is anything greater or equal to a `prefix[i] + target`, meaning the sum of anything before `i + the target`. Let's call the index found with binary search as `j`. This index represents a later index than i so that the target is found. Return `j - i` as the length of the subarray.  

## Time Complexity

### Standard - O(n)
Each element in `nums` is processed once on average.

### Prefix Sum - O(n * log n)
Binary search is run for every sum value in the prefix array.

## Space Complexity

### Standard - O(1)
No data structures of `n` size are implemented.

### Prefix Sum - O(n)
A prefix array of `n + 1` elements is used.
