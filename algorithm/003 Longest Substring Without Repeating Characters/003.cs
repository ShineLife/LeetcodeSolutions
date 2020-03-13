public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int[] map = new int[128];
            int max = 0, j = 0;
            char[] str = s.ToCharArray();
            int length = s.Length;
            for(int i = 0; i < length; i++)
            {
                if (map[str[i]] > 0)
                    j = Math.Max(j, map[str[i]]);
                map[str[i]] = i + 1;
                max = Math.Max(max, i - j + 1);
            }
        return max;
    }
}