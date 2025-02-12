public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int i=0,j=0;
        int iLen = word1.Length, jLen = word2.Length;
        StringBuilder res= new StringBuilder();
        while(i<iLen && j<jLen)
        {
            res.Append(word1[i]).Append(word2[j]);
            i++;
            j++;
        }
        if(j<jLen)
        {
            res.Append(word2[j..jLen]);
        }
        else if(i<iLen)
        {
            res.Append(word1[i..iLen]);
        }
        return res.ToString();
    }
}