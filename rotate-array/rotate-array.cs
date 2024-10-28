public class Solution {
    public void Rotate(int[] nums, int k) {
        int len = nums.Length;
        int[] output = new int[len];
        for(int i=0;i<len;i++)
        {
            output[(i+k)%len]=nums[i];
        }
        Array.Copy(output,nums,len);
    }
}