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
    public bool IsValidBST(TreeNode root) {
        return Validate (root, long.MinValue, long.MaxValue);
    }
    public bool Validate (TreeNode root, long min, long max)
    {
        if(root == null)
        {
            return true;
        }
        if(root.val > min && root.val < max)
        {
            var left = Validate(root.left, min, root.val);
            var right = Validate(root.right, root.val, max);
            if (left && right)
            {
                return true;
            }
        }
        return false;
    }
}