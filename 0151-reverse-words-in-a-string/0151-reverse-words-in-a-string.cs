public class Solution {
    public string ReverseWords(string s) {
        string[] str = s.Split(" ",StringSplitOptions.RemoveEmptyEntries);
        string res="";
        for(int i =str.Length-1;i>=0;i--)
        {  
            res+=str[i].Trim()+" ";                  
        }
        return res.Trim();
    }
}