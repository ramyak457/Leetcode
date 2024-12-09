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
    private int max_Depth;
    public int MaxDepth(TreeNode root) {
        max_Depth = 0;
        max_Depth = Traverse(root, 0);
        return max_Depth;      
    }
    public int Traverse(TreeNode root, int layer)
    {
        if(root!=null)
        {
            Traverse(root.right,layer+1);
            Traverse(root.left, layer+1);
        }
        else{
           max_Depth = max_Depth>layer ? max_Depth : layer; 
        }
        return max_Depth;
    }
}