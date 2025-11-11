using System;

namespace Permutation_in_String;

public class Solution {
	public bool CheckInclusion(string s1, string s2) {
		if (s1.Length > s2.Length) return false;

		var s1Count = new int[26];
		var s2Count = new int[26];

		for (int i = 0; i < s1.Length; i++) {
			s1Count[s1[i] - 'a']++; 
			s2Count[s2[i] - 'a']++; 
		}

		if (IsEqualArrays(s1Count, s2Count)) return true;

		for (int i = s1.Length; i < s2.Length; i++) {
			s2Count[s2[i] - 'a']++; 
			s2Count[s2[i - s1.Length] - 'a']--; 
			if (IsEqualArrays(s1Count, s2Count)) return true;
		}

		return false;
	}

	private bool IsEqualArrays(int[] arr1, int[] arr2) {
		for (int i = 0; i < arr1.Length; i++) {
			if (arr1[i] != arr2[i]) return false;
		}
		return true;
	}
}
