public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int total = 0;
        if( s.Length == 0 || s.Length == 1)
        {
            return s.Length;
        }
        for (int i = 0; i< s.Length-1; i++)
        {
            string res="";
            for(int j = i;j<s.Length;j++)
            {
                if(!res.Contains(s[j]))
                {
                    res += s[j];
                }
                else{
                    break;
                }
            }
            if(res.Length > total)
            {
                total = res.Length;
            }
        }
        return total;
    }
}