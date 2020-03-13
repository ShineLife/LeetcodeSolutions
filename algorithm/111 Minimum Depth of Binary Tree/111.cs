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
    public int MinDepth(TreeNode root) {
        if(root == null)
            return 0;
        Search(root, 1);
        return ans;
    }
    int ans = 2147483647;
    void Search(TreeNode now, int count)
    {
        if(now == null)
            return;
        if(now.left == null && now.right == null)
        {
            ans = Math.Min(ans, count);
            return;
        }
        Search(now.left, count + 1);
        Search(now.right, count + 1);
    }
}