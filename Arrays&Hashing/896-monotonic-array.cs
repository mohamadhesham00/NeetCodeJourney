public class Solution
{
    public bool IsMonotonic(int[] nums)
    {
        bool increasing = false, decreasing = false;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
                increasing = true;
            else if (nums[i] < nums[i - 1])
                decreasing = true;

            if (increasing && decreasing)
                return false;
        }

        return true;
    }
}