public class Solution {
    public void DFS (char[][] grid, int i, int j)
    {
        if(i<0 || j< 0 || i>=grid.Length || j>=grid[0].Length || grid[i][j]=='0')
        {
            return;
        }
        grid[i][j] = '0';

        DFS(grid,i+1,j);
        DFS(grid, i-1, j);
        DFS(grid,i,j+1);
        DFS(grid, i, j-1);
    }
    public int NumIslands(char[][] grid) {
        int cnt = 0;
        for (int i = 0;i<grid.Length;i++)
        {
            for(int j = 0;j<grid[0].Length;j++)
            {
                if(grid[i][j]=='1')
                {
                    cnt++;
                    DFS(grid,i,j);
                }

            }
        }
        return cnt;
    }
}