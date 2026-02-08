using System;

namespace Minimum_Size_Subarray_Sum;

public class AlternativeSolution : Solution {
	override public int MinSubArrayLen(int target, int[] nums) {
		int n = nums.Length;
		var prefix = new int[n + 1];

		for (int i = 0; i < n; i++) {
			prefix[i + 1] = prefix[i] + nums[i];
		}

		int min = int.MaxValue;
		for (int i = 0; i < nums.Length; i++) {
			int search = prefix[i] + target;
			int j = BinarySearch(prefix, search);

			if (j != -1)
				min = Math.Min(min, j - i);
		}

		return min == int.MaxValue ? 0 : min;
	}

	private static int BinarySearch(int[] prefix, int target) {
		int l = 0;
		int r  = prefix.Length - 1;
		int result = -1;

		while (l <= r) {
			int mid = l + (r - l) / 2;
			if (prefix[mid] >= target) {
				result = mid;
				r = mid - 1;
			}
			else
				l = mid + 1;
		}

		return result;
	}
}
