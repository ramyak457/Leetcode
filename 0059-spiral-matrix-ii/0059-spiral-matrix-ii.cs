public class Solution {
    public int[][] GenerateMatrix(int n) {
        int[][] res = Initialize(n);
        int num = 1;
        for(int i=0,j=n-1;i<=j;i++,j--)
        {
            for(int x=i;x<=j;x++)
            {
                res[i][x] = num++;
            }
            for(int x= i+1; x<=j;x++)
            {
                res[x][j] = num++;
            }
            for(int x = j-1;x>=i;x--)
            {
                res[j][x] = num++;
            }
            for(int x= j-1;x>i; x--)
            {
                res[x][i] = num++;
            }
            
        }
        return res;

    }
    private int[][] Initialize(int n)
    {
        int[][] result = new int[n][];
        for(int i=0;i<n;i++)
        {
            result[i] = new int[n];
        }
        return result;
    }
}