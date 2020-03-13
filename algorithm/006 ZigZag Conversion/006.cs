public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1) return s;
        if (numRows == 0) return "";
        int distance = (numRows - 1) * 2;
        string[] ans = new string[numRows];
        int mod = 1;
        int count = 0;
        for(int i = 0; i < s.Length ; i ++)
        {
            ans[count] += s[i].ToString();
            if(count == numRows - 1)
                mod = -1;
            else if(count == 0)
                mod = 1;
            count += mod;
        }
        return String.Join("", ans);
    }
}