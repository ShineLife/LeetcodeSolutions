public class Solution {
    public string CountAndSay(int n) {
        List<string> ans = new List<string>() { "1" };
        for(int i = 1 ; i < n ;i ++)
        {
            string text = ans.Last();
            string last = "";
            string ans_str = "";
            int count = 0;
            for(int j = 0;j < text.Length; j ++)
            {
                string str = text[j].ToString();
                if(str != last)
                {
                    if(count != 0)
                    {
                        ans_str += count.ToString() + last.ToString();
                        count = 0;
                    }
                }
                count ++;
                last = str;
            }
            if(count != 0)
                ans_str += count.ToString() + last.ToString();
            ans.Add(ans_str);
        }
        return ans.Last();
    }
}