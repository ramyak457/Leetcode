public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
       List<int> outArr = new List<int>();
       Dictionary<int,int> dict = new Dictionary<int,int>();
        foreach(int i in nums1)
        {
            if(dict.ContainsKey(i))
            {
                dict[i]++;
            }
            else{
                dict.Add(i,1);
            }
        }
        int count;
        foreach(int j in nums2)
        {
            if(dict.TryGetValue(j, out count) && count>0)
            {
                outArr.Add(j);
                dict[j]-=1;
            }
            else{continue;}
        }
        return outArr.ToArray();
    }
}