public class NumArray
{
    int[] prefSum;

    public NumArray(int[] nums)
    {
        int sum = 0;
        prefSum = new int[nums.Length + 1];
        prefSum[0] = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            prefSum[i + 1] = sum;
        }
    }

    public int SumRange(int left, int right)
    {
        return prefSum[right + 1] - prefSum[left];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */