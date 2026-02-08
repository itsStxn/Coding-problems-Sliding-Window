using System;

namespace Minimum_Size_Subarray_Sum;

public class Solution {
	virtual public int MinSubArrayLen(int target, int[] nums) {
		int min = int.MaxValue;
		int sum = 0;

		for (int l = 0, r = 0; r < nums.Length; r++) {
			sum += nums[r];
			while (sum >= target) {
				min = Math.Min(min, r - l + 1);
				sum -= nums[l];
				l++;
			}
		}

		return min == int.MaxValue ? 0 : min;
	}
}
