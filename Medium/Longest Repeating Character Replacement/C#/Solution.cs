using System;

namespace Longest_Repeating_Character_Replacement;

public class Solution {
	public int CharacterReplacement(string s, int k) {
		var freq = new int[26];
		int maxFreq = 0;
		int longest = 0;

		for (int left = 0, right = 0; right < s.Length; right++) {
			int i = s[right] - 'A';
			maxFreq = Math.Max(maxFreq, ++freq[i]);

			int windowSize = right - left + 1;
			if (windowSize - maxFreq > k) {
				freq[s[left] - 'A']--;
				left++;
			}
			longest = Math.Max(right - left + 1, longest);
		}

		return longest;		
	}
}
