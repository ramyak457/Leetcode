public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var filter = new HashSet<int>();
        int prevHashSize=0;
        
        for(int i=0;i<nums.Length;i++)
        {
            filter.Add(nums[i]);
            if(filter.Count>prevHashSize)
            {
                nums[prevHashSize++]=nums[i];
            }
        }
        return filter.Count;
    }
}