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
    public int GoodNodes(TreeNode root) {
        Stack<(TreeNode node, int greatest)> stack = [];
        int result = 0;

        stack.Push((root, root.val));

        while(stack.Count > 0){
            (TreeNode node, int greatest) = stack.Pop();
            
            if(node.val >= greatest) {
                result++;
                greatest = node.val;
            }

            if(node.left is not null) {
                stack.Push((node.left, greatest));
            }
            if(node.right is not null) {
                stack.Push((node.right, greatest));
            }
        }

        return result;
    }
}