using System.Collections.Generic;

public class Solution
{
    public int SubarraySum(int[] nums, int k)
    {
        int sum = 0;
        List<int> preSum = new List<int>();
        preSum.Add(0);
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            preSum.Add(sum);
        }
        int answer = 0;
        for (int i = 0; i < preSum.Count; i++)
        {
            for (int j = i + 1; j < preSum.Count; j++)
            {
                int value = preSum[j] - preSum[i];
                if (value == k)
                    answer++;
            }
        }
        return answer;
    }
}