public class Solution {
    public int MinimumDifference(int[] nums, int k) {
        Array.Sort(nums);
        int result = int.MaxValue;
        for (int i = 0; i < nums.Length - k + 1; i++){
            int temp = 0;
            int mx = -1;
            int mn = int.MaxValue;
            for(int j = i; j < i + k; j++){
                mx = Math.Max(mx, nums[j]);
                mn = Math.Min(mn, nums[j]);
            }
            temp += (mx - mn);
            result = Math.Min(temp, result);
        }
        return result;
    }
}
