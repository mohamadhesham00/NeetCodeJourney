public class Solution {
    public int[] ApplyOperations(int[] nums) {
        for (int i = 0; i < nums.Length - 1; i++){
            if(nums[i] == nums[i + 1]){
                nums[i] *= 2;
                nums[i + 1] = 0;
            }
        }
        for (int i = 0; i < nums.Length; i++){
            if (nums[i] == 0){
                int j = i + 1;
                while (j < nums.Length && nums[j] == 0)
                    j++;
                if (j >= nums.Length)
                    return nums;
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
        }
        return nums;
    }
}
