public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();
        foreach(string s in strs){
            char[] c = s.ToCharArray();
            Array.Sort(c);
            String r = new String (c);
            if(!dict.ContainsKey(r))
            {
                dict[r] = new List<string>();
            }
            dict[r].Add(s);
        }
        return new List<IList<string>>(dict.Values);
    }
}