public class Solution {
    public void MoveZeroes(int[] nums) {
        int i = 0;
        int j = i + 1;
        while (i < nums.Length && j < nums.Length){
            if (nums[i] == 0){
                if (nums[j] != 0){
                    nums[i] = nums[j];
                    nums[j] = 0;
                    i++;
                }
                j++;
            }
            else{
                i++;
                j++;
            }
        }
        return;
    }
}
