public class Solution {
    public int[] RearrangeArray(int[] nums) {
        int[] result = new int[nums.Length];
        bool isPostiveTurn = true;
        int i = 0;
        int postive = 0, negative = 0;
        while(i < result.Length){
            while(isPostiveTurn){
                if(nums[postive] > 0){
                    isPostiveTurn = false;
                    result[i++] = nums[postive];
                }
                postive++;
            }
            while(nums[negative] > 0)
                negative++;
            result[i++] = nums[negative++];
            isPostiveTurn = true;
        }
        return result;

    }
}
