public class Solution {
    public int MinimumDifference(int[] nums, int k) {
        Array.Sort(nums);
        int result = int.MaxValue;
        for (int i = 0; i < nums.Length - k + 1; i++){
            int mx = nums[i + k - 1];
            int mn = nums[i];
            result = Math.Min(mx - mn, result);
        }
        return result;
    }
}
