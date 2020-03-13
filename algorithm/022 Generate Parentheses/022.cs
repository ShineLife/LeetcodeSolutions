public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<string> ans = new List<string>();
        Gene(n, n, "", ref ans);
        return ans;
    }
    void Gene(int left, int right, string output, ref List<string> ans)
    {
        if(left < 0 || right < 0 || left > right) return;
        if(left == 0 && right == 0)
        {
            ans.Add(output);
            return;
        }
        Gene(left - 1, right, output + "(", ref ans);
        Gene(left, right - 1, output + ")", ref ans);
    }
}