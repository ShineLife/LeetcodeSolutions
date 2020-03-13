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
    public bool IsValidBST(TreeNode root) {
        return helper(root, -2147483646, 2147483646);
    }
    public bool helper(TreeNode node, int lower, int upper) {
        if (node == null) return true;

        int val = node.val;
        if (lower != -2147483646 && val <= lower) return false;
        if (upper != 2147483646 && val >= upper) return false;

        if (! helper(node.right, val, upper)) return false;
        if (! helper(node.left, lower, val)) return false;
        return true;
    }
}