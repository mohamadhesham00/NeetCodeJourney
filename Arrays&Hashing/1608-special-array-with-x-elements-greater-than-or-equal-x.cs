public class Solution {
    public int SpecialArray(int[] nums) {
        Array.Sort(nums);
        for(int i = 0; i < nums.Length; i++){
            if((i <= nums[i]) && (i == nums.Length - i + 1))
                return i;
        }
        return -1;
    }
}
