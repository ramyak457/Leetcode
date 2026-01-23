public class Solution {
    public int MinCapability(int[] nums, int k) {
        var left = nums.Min();
        var right = nums.Max();
        while(left<right)
        {
            var mid = left +(right-left)/2;
            if(CanStealK(nums,k,mid))
            {
                right = mid;
            }
            else
            {
                left = mid+1;
            }
        }
        return left;
    }
    public bool CanStealK(int[] nums, int k, int cap)
    {
        var theft=0;
        for (int i=0;i<nums.Length;i++)
        {
            if(nums[i]<=cap)
            {
                theft++;
                i++;
            }
        }
        return theft >= k;
    }
}