using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<int> MajorityElement(int[] nums)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (int i in nums)
        {
            if (!freq.ContainsKey(i))
                freq[i] = 1;
            else
                freq[i]++;
        }
        var solution = new List<int>();
        foreach (var i in freq)
        {
            if (i.Value > (nums.Count() / 3))
                solution.Add(i.Key);
        }
        return solution;
    }
}