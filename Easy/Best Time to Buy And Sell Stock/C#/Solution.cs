using System;

namespace Best_Time_to_Buy_and_Sell_Stock;

public class Solution {
	public int MaxProfit(int[] prices) {
		int profit = 0, cheapest = prices[0];
		
		foreach (int stock in prices) {
			profit = Math.Max(profit, stock - cheapest);
			cheapest = Math.Min(cheapest, stock);
		}

		return profit;
	}
}
