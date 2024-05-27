public class Solution {
    public int LongestConsecutive(int[] nums) {
        // Store the Longest streak
        int longest = 0;
        int currentStreak = 0;
        // For storing the previous value to compare to
        int previous;
        Array.Sort(nums);
        // Set the previous to the first element in the array   
        if (nums.Length >= 1)
            previous = nums[0];
        else previous = 0;
        foreach (int i in nums)
        {
            // Skip duplicate numbers if it's not the first element
            if(i == previous && i != nums[0]) 
                continue;
            else if (i != previous + 1){
                // The number is not consecutive so reset the current streak
                longest = Math.Max(currentStreak, longest);
                currentStreak = 0;
            }
            currentStreak += 1;
            previous = i;
        }

        longest = Math.Max(currentStreak, longest);
        return longest;
    }
}