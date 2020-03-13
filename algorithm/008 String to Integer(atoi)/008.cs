public class Solution {
    public int MyAtoi(string str) {
        str = str.Trim();
        if(str.Length == 0)
            return 0;
        var num = str[0];
        if(num != '+' && num != '-' && (num < '0' || num > '9')) return 0;
        string number = num.ToString();
        for(int i = 1;i<str.Length;i++)
        {
            var word = str[i];
            if(word < '0' || word > '9') break;
            number += word.ToString();
        }
        if(number.Length == 1 && (number[0] == '+' || number[0] == '-')) return 0;
        double ans = double.Parse(number);
        if(ans < -2147483648) ans = -2147483648;
        if(ans > 2147483647) ans = 2147483647;
        return (int)ans;
    }
}