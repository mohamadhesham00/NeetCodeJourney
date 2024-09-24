public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (int i in nums)
        {
            if(freq.ContainsKey(i))
            {
                freq[i]++;
            }
            else freq[i] = 1;
            if (freq[i] >= ((nums.Length + 1) / 2))
                return i;
        }
        return 0; 
    }
}