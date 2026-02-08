using System;

namespace Maximum_Subarray;

public class AlternativeSolution : Solution {
	public int MaxSubArray_DivideAndConq(int[] nums) {
		Func<int, int, int> max = Math.Max;
		
		int divideConquer(int left, int right) {
			if (left == right)
				return nums[left];

			int mid = left + (right - left) / 2;

			int lSum = int.MinValue, sum = 0;
			for (int i = mid; i >= left; i--) {
				sum += nums[i];
				lSum = max(lSum, sum);
			}

			int rSum = int.MinValue; sum = 0;
			for (int i = mid + 1; i <= right; i++) {
				sum += nums[i];
				rSum = max(rSum, sum);
			}

			int mMax = lSum + rSum;
			int lMax = divideConquer(left, mid);
			int rMax = divideConquer(mid + 1, right);

			return max(mMax, max(lMax, rMax));
		}
		
		return divideConquer(0, nums.Length - 1);
	}
}
