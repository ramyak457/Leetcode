public class Solution {
    public int Reverse(int x) {
       long res =0;
        while(x!=0)
        {
            int rem = x%10;
            x=x/10;
            res = res*10+rem;
        }
        if(res< Int32.MinValue || res>Int32.MaxValue){
            return 0;
        }
        return (int)res;
    }
}