public class Solution {
    public int RomanToInt(string s) {
        char[] r = new char[] { 'I','V','X','L','C','D','M' };
        int[] n = new int[] { 1, 5, 10, 50, 100, 500, 1000 };
        string RomanNumber = "";
        int num = 0;
        for(int i = 0; i < s.Length; i ++)
        {
            int v1 = n[Array.IndexOf(r, s[i])];
            num += v1;
            if(i == s.Length - 1) break;
            int v2 = n[Array.IndexOf(r, s[i + 1])];
            if(v2 > v1)
            {
                num += (v2 - v1 - v1);
                i += 1;
            }
        }
        return num;
    }
}