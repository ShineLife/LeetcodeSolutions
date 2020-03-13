public class Solution {
    public int Jump(int[] nums) {
        int index = 0;
        int count = 0;
        while (index != nums.Length - 1)
        {
            int step = nums[index];
            List<int> distance = new List<int>() { 0 };
            for (int i = 1; i <= step; i++)
            {
                if (i + index == nums.Length - 1)
                {
                    index = index + i;
                    distance = new List<int>() { 0 };
                    break;
                }
                distance.Add(nums[i + index] - (step - i));
            }
            index = index + distance.LastIndexOf(distance.Max());
            count += 1;
        }
        return count;
    }
}