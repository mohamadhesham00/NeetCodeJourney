public class Solution
{
    public long Factorial(int n)
    {
        if (n == 1)
            return 1;
        return n + Factorial(n - 1);
    }
    public long ZeroFilledSubarray(int[] nums)
    {
        int consecutive = 0;
        long solution = 0;
        foreach (int i in nums)
        {
            if (i == 0)
                consecutive++;
            else if (consecutive != 0)
            {
                solution += Factorial(consecutive);
                consecutive = 0;
            }
        }
        if (consecutive != 0)
            solution += Factorial(consecutive);
        return solution;
    }
}