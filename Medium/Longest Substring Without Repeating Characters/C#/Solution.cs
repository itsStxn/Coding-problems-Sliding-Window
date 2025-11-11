using System;

namespace Longest_Substring_Without_Repeating_Characters;

public class Solution {
	public int LengthOfLongestSubstring(string s) {
		if (s.Length == 0) return 0;
		if (s.Length == 1) return 1;

		Dictionary<char, int> seen = [];
		int maxLength = 0, start = 0;

		for (int end = 0; end < s.Length; end++) {
			if (seen.TryGetValue(s[end], out int lastIndex)) {
				start = Math.Max(lastIndex + 1, start);
				seen[s[end]] = end;
			}
			else seen.Add(s[end], end);
			maxLength = Math.Max(end - start + 1, maxLength);
		}

		return maxLength;
	}
}
