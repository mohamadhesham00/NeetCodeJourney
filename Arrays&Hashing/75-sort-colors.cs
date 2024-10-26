public class Solution
{
    public void SortColors(int[] nums)
    {
        var temp = nums.OrderBy(x => x).ToArray();
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = temp[i];
        }
    }
}