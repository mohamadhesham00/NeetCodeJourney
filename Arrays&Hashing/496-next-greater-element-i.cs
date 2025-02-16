public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        // An array for storing the result
        int[] answers = new int[nums1.Length];
        for(int i = 0; i < nums1.Length; i++){
            int num = nums1[i];
            // Initalize the var with -1 in case of we didn't reassign it
            answers[i] = -1;
            // Store the index of a number
            var index = Array.IndexOf(nums2, num);
            // Begin with the next element after that number
            for(int j = index + 1; j < nums2.Length; j++){
                if (nums2[j] > num){
                    // Store the next greater element
                    answers[i] = nums2[j];
                    break;
                }
            }
        }
        return answers;
        
    }
}
