public class Solution {
    public int MaxArea(int[] height) {
        int max_area = 0, l = 0, r = height.Length - 1;
        while(l < r)
        {
            max_area = Math.Max(max_area, Math.Min(height[l], height[r]) * (r - l));
            if(height[l] < height[r])
                l ++;
            else
                r --;
        }
        return max_area;
    }
}