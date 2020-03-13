public class Solution {
    public int SearchInsert(int[] nums, int target) {
        List<int> nn = nums.ToList();
        nn.Add(target);
        nn.Sort();
        return nn.IndexOf(target);
    }
}