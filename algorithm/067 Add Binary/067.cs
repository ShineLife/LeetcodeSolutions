public class Solution {
    public string AddBinary(string a, string b) {
        a = a.PadLeft(b.Length, '0');        
        b = b.PadLeft(a.Length, '0');
        string ans = "";
        int carry = 0;
        for(int i = a.Length - 1; i >= 0; i --)
        {
            int sum = a[i] - 48 + b[i] - 48 + carry;
            ans = (sum % 2).ToString() + ans;
            carry = (int)Math.Floor((double)sum / 2);
        }
        if(carry != 0)
            ans = carry.ToString() + ans;
        return ans;
    }
}