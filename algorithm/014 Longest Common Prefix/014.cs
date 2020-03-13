public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length == 0) return "";
        string ans = "";
        for(int i = 0; i < strs[0].Length;i ++)
        {
            string str = strs[0][i].ToString();
            for(int j = 0; j < strs.Length; j ++)
            {
                string text = strs[j].Length <= i ? "" : strs[j][i].ToString();
                if(str != text)
                    return ans;
            }
            ans += str;
        }
        return ans;
    }
}