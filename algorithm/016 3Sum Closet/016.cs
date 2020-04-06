public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        int ans = 0;
        for(int i = 0; i < nums.Length - 2;i ++)
        {
            for(int j = i + 1; j < nums.Length - 1; j ++)
            {
                for(int z = j + 1; z < nums.Length; z ++)
                {
                    int now = nums[i] + nums[j] + nums[z];
                    if(ans == 0)
                        ans = now;
                    if(target == now)
                    {
                        z = nums.Length;
                        j = nums.Length;
                        i = nums.Length;
                    }
                    if(Math.Abs(now - target) < Math.Abs(ans - target)){
                        ans = now;
                    }
                }
            }
        }
        return ans;
    }
}