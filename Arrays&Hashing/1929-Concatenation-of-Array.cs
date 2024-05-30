public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] result = new int[nums.Length * 2];
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            result[i] = nums[i];
            result[i + n] = nums[i];
        }

        return result;
    }
}