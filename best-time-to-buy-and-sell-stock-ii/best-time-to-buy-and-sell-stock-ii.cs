public class Solution {
    public int MaxProfit(int[] prices) { 
        int n = prices.Length;
        int currBuy = prices[n-1];
        int currMin = prices[n-1];
        int maxProfit =0;
        for (int i=0;i<n;i++)
        {
            if(prices[n-1-i]>currMin)
            {
                maxProfit += currBuy-currMin;
                currBuy = prices[n-1-i];
                currMin = prices[n-1-i];
            }
            if(prices[n-1-i]<currMin)
            {
                currMin = prices[n-1-i];
            }
        }
        maxProfit += currBuy-currMin;
        return maxProfit;
    }
}