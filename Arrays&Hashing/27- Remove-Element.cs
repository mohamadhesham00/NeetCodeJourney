public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int count = 0; // Variable to count non-val elements
        int left = 0; // Left pointer
        int right = nums.Length - 1; // Right pointer

        // Iterate until left pointer crosses or meets the right pointer
        while (left <= right)
        {
            // Move right pointer to the left until it points to a non-val element
            while (nums[left] == val && left < right)
            {
                nums[left] = nums[right]; // Replace val with the element at right pointer
                right--; // Move right pointer to the left
            }

            // Increment count if the element at left pointer is not equal to val
            if (nums[left] != val)
                count++;

            left++; // Move left pointer to the right
        }

        return count; // Return the count of non-val elements
    }
}
