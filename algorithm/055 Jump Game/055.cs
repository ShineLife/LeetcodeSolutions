public class Solution {
    public bool CanJump(int[] nums) {
        int min, len = min = nums.Length - 1;
        for(int i = len; i>=0; i--)
            if(i + nums[i] >= min) min = i;
        return min == 0 ? true : false;
    }
}