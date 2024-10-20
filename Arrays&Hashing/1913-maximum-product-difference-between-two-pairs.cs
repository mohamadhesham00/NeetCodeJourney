using System.Linq;

public class Solution
{
    public int MaxProductDifference(int[] nums)
    {
        var distinct = nums.OrderBy(x => x).ToList();
        if (distinct.Count == 1)
            return 0;
        return (distinct[distinct.Count - 1] * distinct[distinct.Count - 2]) - (distinct[0] * distinct[1]);
    }
}