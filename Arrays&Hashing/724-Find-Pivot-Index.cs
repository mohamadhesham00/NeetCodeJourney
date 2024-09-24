public class Solution {
    public int PivotIndex(int[] nums) {
        int[] prefSum = new int[nums.Length];
        prefSum[0] = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            prefSum[i] = nums[i];
            prefSum[i] += i > 0 ? prefSum[i - 1] : 0;
        }
        int left, right;
        for(int i = 0; i < nums.Length; i++)
        {
            left = i > 0 ? prefSum[i - 1] : 0;
            right = prefSum[nums.Length - 1] - prefSum[i];
            if (left - right == 0)
                return i;
        }
        return -1;
    }
}