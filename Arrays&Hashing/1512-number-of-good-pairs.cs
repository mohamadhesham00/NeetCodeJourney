using System.Collections.Generic;

public class Solution
{
    public int NumIdenticalPairs(int[] nums)
    {
        int answer = 0;
        Dictionary<int, int> map = new Dictionary<int, int>();
        foreach (int i in nums)
        {
            map[i] = map.GetValueOrDefault(i) + 1;
        }
        foreach (KeyValuePair<int, int> pair in map)
        {
            for (int i = 1; i < pair.Value; i++)
            {
                answer += i;
            }
        }
        return answer;
    }
}