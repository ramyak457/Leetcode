public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            int req = target - nums[i];
            if(dict.ContainsKey(nums[i]))
            {
                
                return new int[]{dict[nums[i]],i};
            }
            else{dict[req] = i;}
        }
        return new int[2];
    }
}