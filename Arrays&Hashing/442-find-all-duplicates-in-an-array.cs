public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        int[] freq = new int[nums.Length + 1];
        List<int> result = new();
        foreach(int num in nums){
            freq[num]++;
            if(freq[num] == 2)
                result.Add(num);
        }
        return result;
    }
}
