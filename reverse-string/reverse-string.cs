public class Solution {
    public void ReverseString(char[] s) {
        int n = s.Length;
        for(int i=0;i<n/2;i++)
        {
            char temp= s[n-1-i];
            s[n-1-i] = s[i];
            s[i]=temp;           
        }
    }
}