public class Solution {
    public string Multiply(string num1, string num2) {
        string ret = "0";
        for(int i = num1.Length - 1;i >= 0;i --)
        {
            string ans = "".PadRight(num1.Length - i - 1, '0');
            int carry = 0;
            for(int j = num2.Length - 1; j >= 0; j--)
            {
                int num = (num1[i] - 48) * (num2[j] - 48) + carry;
                ans = (num % 10).ToString() + ans;
                if(num > 9)
                    carry = (int)Math.Floor((double)num / 10);
                else
                    carry = 0;
            }
            if(carry != 0)
                ans = carry.ToString() + ans;
            carry = 0;
            ret = ret.PadLeft(ans.Length, '0');
            ans = ans.PadLeft(ret.Length, '0');
            string rr = "";
            for(int j = ans.Length - 1; j >= 0; j--)
            {
                int num = (ans[j] - 48) + (ret[j] - 48) + carry;
                rr = (num % 10).ToString() + rr;
                if(num > 9)
                    carry = (int)Math.Floor((double)num / 10);
                else
                    carry = 0;
            }
            if(carry != 0)
                rr = carry.ToString() + rr;
            ret = rr;
        }
        string aa = "0";
        for(int i = 0;i<ret.Length;i++)
            if(ret[i] != '0')
            {
                aa = ret.Substring(i);
                break;
            }
        
        return aa;
    }
}