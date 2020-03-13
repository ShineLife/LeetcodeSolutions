public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        if(numRows == 0)
            return new List<IList<int>>();
        if (numRows == 1)
            return new List<IList<int>>() { new List<int>() { 1 } };
        if (numRows == 2)
            return new List<IList<int>>() { new List<int>() { 1 }, new List<int>() { 1, 1 } };
        List<IList<int>> ans = new List<IList<int>>() { new List<int>() { 1 }, new List<int>() { 1, 1 } };
        for (int i = 2; i < numRows; i++)
        {
            List<int> list = new List<int>();
            list.Add(1);
            for (int j = 0; j < i - 1; j++)
            {
                list.Add(ans.Last()[j] + ans.Last()[j + 1]);
            }
            list.Add(1);
            ans.Add(list);
        }
        return ans;
    }
}