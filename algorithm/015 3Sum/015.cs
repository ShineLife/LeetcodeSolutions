public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var list = new List<IList<int>>();
        Array.Sort(nums);
        
        for (int i = 0; i + 2 < nums.Length; i++) {
            if (nums[i] > 0) break; 
            if (i > 0 && nums[i] == nums[i - 1]) continue; 
            
            int target = 0 - nums[i], left = i + 1, right = nums.Length - 1;
            while (left < right) {
                if (nums[left] + nums[right] == target) {
                    list.Add(new List<int>() { nums[i], nums[left], nums[right] });
                    while (left < right && nums[left] == nums[left + 1]) left++; 
                    while (left < right && nums[right] == nums[right - 1]) right--; 
                    left++;
                    right--;
                } else if (nums[left] + nums[right] > target) {
                    right--;
                } else {
                    left++;
                }
            }
        }
        
        return list;
    }
}