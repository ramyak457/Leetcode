public class Solution {
    public void MoveZeroes(int[] nums) {
        int j=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]!=0)
            {
                nums[j]=nums[i];
                j++;
            }
        }
        for(int k=j;k<nums.Length;k++)
        {
            nums[k]=0;
        }
    }
}