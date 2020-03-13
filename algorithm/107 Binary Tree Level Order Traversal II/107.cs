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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        Search(root, 0);
        ans.Reverse();
        return ans;
    }
    List<IList<int>> ans = new List<IList<int>>();
    void Search(TreeNode now, int index)
    {
        if(now == null)
            return;
        if(ans.Count <= index)
            ans.Add(new List<int>() { now.val });
        else
            ans[index].Add(now.val);
        Search(now.left, index + 1);        
        Search(now.right, index + 1);
    }
}