public class Solution {
    public void Rotate(int[][] matrix) {
        int n = matrix.Length;
        for (int d=0;d<n/2;d++)
        {
            for(int x=d;x<n-1-d;x++)
            {
                int tmp = matrix[d][x];
                matrix[d][x] = matrix[n-1-x][d];
                matrix[n-1-x][d]= matrix[n-1-d][n-1-x];
                matrix[n-1-d][n-1-x] = matrix[x][n-1-d];
                matrix[x][n-1-d] = tmp;                
                
            }
        }
    }
}