// This is my solution
// A better solution I found https://leetcode.com/problems/non-decreasing-array/solutions/5821889/non-decreasing-array/
public class Solution {
    public bool CheckPossibility(int[] nums) {
        if (nums.Length <= 2)
            return true;
        bool isModified = false;
        for (int i = 1; i < nums.Length - 1; i++){
            if (nums[i] < nums[i - 1] && !isModified){
                if (nums[i - 1] > nums[i + 1]){
                    nums[i - 1] = nums[i];
                }
                else{
                    nums[i] = nums[i - 1];
                }
                isModified = true;
            }
            else if (nums[i] < nums[i - 1]){
                return false;
            }

            if (nums[i] > nums[i + 1] && !isModified){
                if (nums[i + 1] < nums[i - 1]){
                    nums[i + 1] = nums[i];
                }
                else {
                    nums[i] = nums[i - 1];
                }
                isModified = true;
            }
            else if (nums[i] > nums[i + 1]){
                return false;
            }
        }
        return true;
    }
}
