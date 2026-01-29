class Solution:
	def characterReplacement(self, s: str, k: int) -> int:
		freq = [0 for _ in range(26)]
		longest_repl = 0
		max_freq = 0
		left = 0

		for right in range(len(s)):
			i = ord(s[right]) - ord('A')
			freq[i] += 1
			max_freq = max(max_freq, freq[i])

			window_size = right - left + 1
			if k < window_size - max_freq:
				freq[ord(s[left]) - ord('A')] -= 1
				left += 1

			longest_repl = max(longest_repl, right - left + 1)

		return longest_repl
