public class Solution
{
    public int ArraySign(int[] nums)
    {
        long numOfNegative = 0;
        foreach (var i in nums)
        {
            if (i < 0)
            {
                numOfNegative++;
            }
            else if (i == 0)
                return 0;
        }
        if (numOfNegative % 2 == 0)
            return 1;
        return -1;
    }
}