using System;

namespace Best_Time_to_Buy_and_Sell_Stock;

public class Solution {
	public int MaxProfit(int[] prices) {
		if (prices.Length == 1) return 0;

		int maxProfit = 0, minPrice = prices[0];
		for (int day = 1; day < prices.Length; day++) {
			maxProfit = Math.Max(prices[day] - minPrice, maxProfit);
			minPrice = Math.Min(prices[day], minPrice);
		}

		return maxProfit;
	}
}
