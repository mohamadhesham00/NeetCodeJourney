public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        // Array for storing the indices of the result
        int[] result = new int[2];
        // Two pointers to sum the numbers
        int left = 0;
        int right = numbers.Length - 1;
        while (left < right)
        {
            // Store the result of sum in a variable 
            int sum = numbers[left] + numbers[right];
            // Check if we found the answer
            if (sum == target)
            {
                // The answer needs it 1 indexed so increase it by 1
                result[0] = left + 1;
                result[1] = right + 1;
                break;
            }
            // If the sum is bigger than target decrease right pointer to decrease the result
            else if (sum > target)
                right--;
            // Otherwise if it's smaller    
            else
                left++;
        }

        return result;
    }
}