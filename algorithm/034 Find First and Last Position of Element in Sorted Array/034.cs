public class Solution {
    public int[] SearchRange(int[] nums, int target) {
         int[] x = { nums.ToList().IndexOf(target),nums.ToList().LastIndexOf(target)};
        return x;
    }
}