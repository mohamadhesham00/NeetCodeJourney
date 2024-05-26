public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Dictionary to store the numbers and their indices
        Dictionary<int, int> numDictionary = new Dictionary<int, int>();
        // Arrray for storing the results
        int[] result = new int[2];
        for(int i = 0; i < nums.Length; i++)
        {

            int complement = target - nums[i];
            // Check if the complement of that number exists
            if(numDictionary.ContainsKey(complement))
            {
                // Store the induces in result exit the loop
                result[0] = numDictionary[complement];
                result[1] = i;
                break;
            }
            // Store the current number and its index in the dictionary
            numDictionary[nums[i]] = i;
        }
        return result;
    }
}