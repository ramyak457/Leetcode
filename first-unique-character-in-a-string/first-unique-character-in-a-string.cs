public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char,int> dict = new Dictionary<char,int>();
        for(int i=0;i<s.Length;i++)
        {
            if(dict.ContainsKey(s[i]))
            {
                dict[s[i]]++;
                continue;
            }
            dict.Add(s[i],1);
        } 
        char val = dict.FirstOrDefault(x=>x.Value==1).Key;
        return s.IndexOf(val);
    }
}