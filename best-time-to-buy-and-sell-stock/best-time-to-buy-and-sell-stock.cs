public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length==0)
        {
            return 0;
        }
        int lowVal = prices[0];
        int maxP = 0;
        for(int i = 1;i<prices.Length;i++)
        {
            lowVal = Math.Min(prices[i],lowVal);
            int currP = prices[i] - lowVal;
             maxP = Math.Max(maxP,currP);
        }
        return maxP;
        
    }
}