using System;

namespace Maximum_Subarray;

public class Solution {
	virtual public int MaxSubArray(int[] nums) {
		int max = int.MinValue;
		int sum = 0;
		
		foreach (int n in nums) {
			sum += n;
			max = Math.Max(max, sum);
			sum = Math.Max(sum, 0);
		}

		return max;
	}
}
