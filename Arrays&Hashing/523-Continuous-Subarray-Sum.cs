public class Solution
{
    public bool CheckSubarraySum(int[] nums, int k)
    {
        // Dictionary for storing the remainders 
        Dictionary<int, int> remainderDictionary = new();

        // In case of we found subarray from index 0
        remainderDictionary[0] = -1;

        int sum = 0;

        int remainder;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            remainder = sum % k;

            // Check if the remainder already exists in the dictionary 
            if (remainderDictionary.ContainsKey(remainder))
            {
                // Check if the size of the subarray is atleast 2
                if (i - remainderDictionary[remainder] > 1)
                    // Found the subarray 
                    return true;
            }
            else
            {
                // If not add it to the dictionary
                remainderDictionary[remainder] = i;
            }
        }
        return false;
    }
}