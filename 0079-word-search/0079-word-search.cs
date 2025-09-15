public class Solution {
    private bool IsSafe(int i, int j, int m, int n, bool [,] visa)
    {
        return i>=0 && j>=0 && i<m && j<n && !visa[i,j];
    }
    private bool Rec (int i, int j, int index, int m, int n, char[][] board, string word, bool[,] visa)
    {
        if (index == word.Length) { return true;}
        if(!IsSafe(i,j,m,n,visa) || board[i][j]!= word[index] ){return false;}
        visa[i,j] = true;

        bool left = Rec(i-1, j, index + 1,m,n,board, word, visa);
        bool right = Rec(i+1, j, index + 1,m,n,board, word, visa);
        bool up = Rec(i, j-1, index + 1,m,n,board, word, visa);
        bool down = Rec(i, j+1, index + 1,m,n,board, word, visa);

        visa[i,j] = false;

        return left || right || up|| down;


    }
    public bool Exist(char[][] board, string word) {
        int m = board.Length;
        int n = board[0].Length;
        for (int i=0;i<m;i++)
        {
            for (int j=0;j<n;j++)
            {
                if(board[i][j]==word[0])
                {
                    bool[,] visa = new bool [m,n];
                    if (Rec(i,j,0,m,n,board,word,visa))
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
}