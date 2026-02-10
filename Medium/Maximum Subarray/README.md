# Maximum Subarray

## Description
Given an integer array nums, find the subarray with the largest sum, and return its sum.

### Example 1
***Input***: `nums` = [-2,1,-3,4,-1,2,1,-5,4]  
***Output***: 6  
***Explanation***: The subarray [4,-1,2,1] has the largest sum 6.

### Example 2
***Input***: `nums` = [1]  
***Output***: 1  
***Explanation***: The subarray [1] has the largest sum 1.

### Example 3
***Input***: `nums` = [5,4,-1,7,8]  
***Output***: 23  
***Explanation***: The subarray [5,4,-1,7,8] has the largest sum 23.

### Constraints
- 1 <= `nums.length` <= 105
- -104 <= `nums[i]` <= 104

**Follow up:** If you have figured out the `O(n)` solution, try coding another solution using the **divide and conquer** approach, which is more subtle.

## Strategy

### Kadane's algorithm
Traverse the array and keep storing the sum. Reset the sum whenever it is negative. It makes sense, because why would you care about negative sums at all?

### Divide and conquer
Get a mid pointer, then travers backwards from mid to the left and from mid to the right. Get the max sum to the left and to the right, then sum them together. Do this recursively to the left and right halves. The value to return is the max among the traversed sum, the left recursion and the right recursion.

## Time Complexity

### Kadane's algorithm - O(n)
Each number is processed once.

### Divide and conquer - O(n * log n)
A `n` long operation is done at each recursive level, on both the array halves.

## Space Complexity - O(1)
Both methods do not use `n` sized data structures.
