public class Solution
{
    public int[] SortArray(int[] nums)
    {
        return nums.OrderBy(x => x).ToArray();
    }
}