public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i ++)
            if(dictionary.ContainsKey(nums[i]))
                dictionary[nums[i]] += 1;
            else
                dictionary.Add(nums[i], 1);
        return dictionary.Where(x => x.Value == 1).First().Key;
    }
}