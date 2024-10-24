public class Solution {
    public int[] PlusOne(int[] digits) {
        int n = digits.Length;
        int carry = 1;
        for (int i = n-1;i>=0;i--)
        {
            int sum = digits[i]+carry;
            digits[i]= sum%10;
            carry = sum/10;
            if (carry == 0){break;}
        }
        if(carry == 1)
        {
            int[] res = new int[n+1];
            res[0]=1;
            return res;
        }
        return digits;
    }
}