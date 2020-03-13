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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        Search(root, 0);
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
        {
            if(index % 2 == 0)
                ans[index].Add(now.val);
            else
                ans[index].Insert(0, now.val);
        }
        Search(now.left, index + 1);        
        Search(now.right, index + 1);
    }
}