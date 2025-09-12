/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    //Solution 1
    private int max_Depth = 0;
    public int MaxDepth(TreeNode root) {
        max_Depth = Traverse(root, 0);
        return max_Depth;
    }
    public int Traverse(TreeNode root, int depth)
    {
        if(root!= null)
        {
            Traverse (root.left, depth+1);
            Traverse (root.right, depth+1);
        }
        else
        {
            max_Depth = (max_Depth>depth? max_Depth : depth);
        }
        return max_Depth;
    }
    //Solution 2
    /*public int MaxDepth (TreeNode root)
    {
        if(root==null)
        {
            return 0;
        }
        return Math.Max(MaxDepth(root.left),MaxDepth(root.right))+1;
    }*/
}