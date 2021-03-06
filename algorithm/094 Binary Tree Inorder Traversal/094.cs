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
    public IList<int> InorderTraversal(TreeNode root) {
        Search(root);
        return ans;
    }
    List<int> ans = new List<int>();
    void Search(TreeNode now)
    {
        if(now == null)
            return;
        Search(now.left);
        ans.Add(now.val);
        Search(now.right);
    }
}