public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        foreach(int i in nums)
        {
            if(dict.ContainsKey(i))
            {
                dict[i]++;
            }
            else{
                dict.Add(i,1);
            }
        }
        return dict.FirstOrDefault (x=> x.Value==1).Key;
    }
}