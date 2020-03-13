public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0; int right = nums.Length - 1;
        while(right >= left)
        {
            if(nums[left] == target)
                return left;
            if(nums[right] == target)
                return right;
            left ++;
            right --;
        }
        return -1;
    }
}