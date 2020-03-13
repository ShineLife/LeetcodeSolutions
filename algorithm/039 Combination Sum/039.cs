public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        List<IList<int>> ans = new List<IList<int>>();
        for (int i = 0; i < candidates.Length; i++)
        {
            Search(ref ans, new List<int>() { candidates[i] }, target, candidates);
        }
        return ans.Distinct().ToList();
    }
    void Search(ref List<IList<int>> ans, List<int> collection, int target, int[] source)
    {
        if (collection.Sum() == target)
        {
            collection = collection.OrderBy(x => x).ToList();
            if(!ans.Any(x => x.SequenceEqual(collection)))
                ans.Add(collection);
            return;
        }
        else if (collection.Sum() > target)
            return;
        for (int i = 0; i < source.Length; i++)
        {
            List<int> new_collection = new List<int>(collection);
            new_collection.Add(source[i]);
            Search(ref ans, new_collection, target, source);
        }
    }
}