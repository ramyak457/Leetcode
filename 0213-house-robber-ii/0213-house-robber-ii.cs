public class Solution {
    public int findMaxRob(int[] nums, int start, int end)
    {
        int m = nums[start];
        int n= 0;
        for (int i= start+1;i<=end;i++)
        {
            int m1 = n+nums[i];
            int n1 = Math.Max(m,n);
            m = m1;
            n = n1;
        }
        return Math.Max(m,n);
    }
    public int Rob(int[] nums) 
    {
        if (nums.Length == 0)
        {
            return 0;
        }
        if (nums.Length == 1)
        {
            return nums[0];
        }
        return Math.Max(findMaxRob(nums,0, nums.Length-2), 
        findMaxRob(nums, 1, nums.Length-1));
    } 
}