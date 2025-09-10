public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int,int> d = new Dictionary<int,int>();
        for (int i = 0; i<numbers.Length; i++)
        {
            int reqd = target - numbers[i];
            if (d.ContainsKey(reqd))
            {
                return new int[] {d[reqd]+1,i+1};
            }
            else
            {
                d[numbers[i]] = i;
            }
        }
        return new int[2];
    }
}