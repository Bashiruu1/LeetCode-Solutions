/*
    1. Iterate over the prices array
        a. Find the best price to buy, which is the lowest value in the array
        b. Find the maxProfit in the array, this is the max of either my current max or the current element in the array - the best Price to buy a stock in this case
    2. return the maxProfit
    
    Time Complexity: O(n)
    Space Complexity: O(1);
*/

public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices == null || prices.Length == 0) return 0;
        
        int maxProfit = 0;
        int bestPrice = prices[0];
        
        for(int i = 0; i < prices.Length - 1; i++) {
            bestPrice = Math.Min(prices[i], bestPrice);
            maxProfit = Math.Max(prices[i] - bestPrice, maxProfit);
        }
        
        return maxProfit;
    }
}