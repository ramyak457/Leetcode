using System.Text.RegularExpressions;
public class Solution {
    public int MyAtoi(string s) {
        Regex pattern = new Regex("^[+-]?[0-9]+");
        Match matchSet = pattern.Match(s.Trim());
        if(matchSet.Success)
        {
            String numVal = matchSet.Value; 
            int res = 0;
            
            if(!int.TryParse(numVal, out res))
            {
                if(numVal[0]=='-')
                {
                    return int.MinValue;
                }
                else{
                    return int.MaxValue;
                }
            }
            else{
                return res;
            }
        }
        return 0;
    }
}