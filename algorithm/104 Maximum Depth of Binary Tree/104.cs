/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int MaxDepth(TreeNode root) {
        int ans = 0;
        Search(root, ref ans, 1);
        return ans;
    }
    void Search(TreeNode now, ref int ans, int count)
    {
        if(now == null)
            return;
        if(now.left == null && now.right == null)
        {
            ans = Math.Max(ans, count);
            return;
        }
        if(now.left != null)
            Search(now.left, ref ans, count + 1);
        if(now.right != null)
            Search(now.right, ref ans, count + 1);
    }
}