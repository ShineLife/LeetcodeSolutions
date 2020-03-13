public class Solution {
    public bool IsValid(string s) {
        Stack<string> stack = new Stack<string>();
        for(int i = 0;i < s.Length;i ++)
        {
            string text = s[i].ToString();
            if(text == ")" || text == "}" || text == "]")
            {
                if(stack.Count == 0)
                    return false;
                if(!Compare(stack.Pop(), text))
                    return false;
            }
            else
            {
                stack.Push(text);
            }
        }
        if(stack.Count != 0)
            return false;
        return true;
    }
    bool Compare(string input, string text)
    {
        if(text == ")" && input == "(")
            return true;
        if(text == "]" && input == "[")
            return true;
        if(text == "}" && input == "{")
            return true;
        return false;
    }
}