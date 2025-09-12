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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var res = new List<IList<int>>();
        if (root == null)
        {
            return res;
        }
        res.Add(new List<int>(){root.val});
        Traverse(root.left, res);
        Traverse(root.right, res);
        return res;
    }
    public void Traverse (TreeNode root, IList<IList<int>> res, int depth = 0)
    {
        if (root == null)
        {
            return;
        }
        if(res.Count == ++depth)
        {
            res.Add(new List<int>());
        }
        res[depth].Add(root.val);
        Traverse(root.left, res, depth);
        Traverse(root.right, res, depth);
    }
}