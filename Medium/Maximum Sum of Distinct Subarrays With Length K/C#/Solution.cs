using System;

namespace Maximum_Sum_of_Distinct_Subarrays_With_Length_K;

public class Solution {
	public long MaximumSubarraySum(int[] nums, int k) {
		long max = 0;
		long sum = 0;

		Dictionary<int, int> window = [];
		for (int l = 0, r = 0; r < nums.Length; r++) {
			if (!window.TryAdd(nums[r], 1))
				window[nums[r]]++;
			
			sum += nums[r];

			if (r - l + 1 > k) {
				window[nums[l]]--;
				if (window[nums[l]] == 0)
					window.Remove(nums[l]);
				
				sum -= nums[l];
				l++; 
			}

			if (r - l + 1 == k && window.Count == k)
				max = Math.Max(max, sum);
		}

		return max;
	}
}
