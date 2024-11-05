public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string res = strs[0];
        int i = res.Length;
        foreach(string word in strs)
        {
            int j =0;
            foreach(char c in word)
            {
                if(j>=i || res[j]!=c){break;}
                j+=1;
            }
            i=Math.Min(i,j);
        }
        return res.Substring(0,i);
    }
}