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
    public bool IsSymmetric(TreeNode root) {
        if(root == null){return false;}
        return DFS(root.left, root.right);
    }
    public bool DFS(TreeNode n1, TreeNode n2)
    {
        if(n1 == null && n2 == null){ return true;}
        if(n1==null || n2 == null){ return false;}
        if(n1.val == n2.val)
        {
            return DFS(n1.left, n2.right) && DFS(n1.right, n2.left);
        }
        return false;
    }
}