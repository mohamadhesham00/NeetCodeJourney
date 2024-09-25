using System.Collections.Generic;

public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        IList<int> result = new List<int>();
        bool[] freq = new bool[nums.Length];
        foreach (int i in nums)
        {
            freq[i - 1] = true;
        }
        for (int i = 0; i < freq.Length; i++)
        {
            if (freq[i] == false)
                result.Add(i + 1);
        }
        return result;
    }
}