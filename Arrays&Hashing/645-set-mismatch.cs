public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        int[] answers = new int[2];
        bool[] exists = new bool[nums.Length + 1];
        foreach (int i in nums)
        {
            if (exists[i])
            {
                answers[0] = i;
            }
            exists[i] = true;
        }
        for (int i = 0; i < exists.Length; i++)
        {
            if (!exists[i])
                answers[1] = i;
        }
        return answers;
    }
}