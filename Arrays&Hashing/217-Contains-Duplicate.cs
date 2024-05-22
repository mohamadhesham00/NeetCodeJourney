public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        // Use a HashSet to track the numbers we have seen so far
        HashSet<int> seenNumbers = new(nums.Length);
        
        for (int i = 0; i < nums.Length; i++)
        {
            // Check if the number is already in the set
            if (seenNumbers.Contains(nums[i]))
            {
                // If it is, we found a duplicate, so return true
                return true;
            }
            // Add the number to the set
            seenNumbers.Add(nums[i]);
        }
        
        // If we complete the loop without finding duplicates, return false
        return false;
    }
}
