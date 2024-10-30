public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        int maxProfit=0;
        if(n==0){
            return 0;
        }
        for(int i=1;i<n;i++)
        {
            if(prices[i-1]<prices[i])
            {
                maxProfit+=prices[i]-prices[i-1];
            }
        }
        return maxProfit;
    }
}