public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // Array for storing the result 
        int[] result = new int[nums.Length];
        // Variable for storing the product of nums in the array except 0
        int product = 1;
        // Flag to check if the array has a zero value or not
        bool hasZero = false;
        for (int i = 0; i < nums.Length; i++)
        {
            // Check if the array has more than one zero
            if (nums[i] == 0 && hasZero)
                // More than one zero means the result will be zero for all
                return result;
            else if (nums[i] == 0)
                hasZero = true;
            // In case it's not zero we multiply the current to product
            else
                product *= nums[i];
        }
        for (int i = 0; i < result.Length; i++) {
            // If the current is zero this means we can't divide by it 
            if (nums[i] == 0) { result[i] = product; }
            // Divide by the current to find product expcept self
            else if (!hasZero) { result[i] = product / nums[i]; }
            // If the array contains a zero and this is the current
            else result[i] = 0;

        }

        return result;
    }
}