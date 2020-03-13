public class Solution {
    public int SingleNumber(int[] nums) {
        return nums.Aggregate((a, b) => a ^ b);
    }
}