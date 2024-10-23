public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var filteredArray = new HashSet<int>(nums);
        if(filteredArray.Count == nums.Length)
        {
            return false;
        }
        return true;
    }
}