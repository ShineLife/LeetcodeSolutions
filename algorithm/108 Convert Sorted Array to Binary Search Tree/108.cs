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
    public TreeNode SortedArrayToBST(int[] nums) {
        return Search(nums, 0, nums.Length-1);
    }
    TreeNode Search(int[] nums, int left, int right)
    {
        if(left>right)
            return null;
        if(left==right)
            return new TreeNode(nums[left]);
        int mid = (left + right)/2;
        TreeNode node = new TreeNode(nums[mid]);
        node.left = Search(nums, left, mid-1);
        node.right = Search(nums, mid+1, right);
        return node;
    }
}