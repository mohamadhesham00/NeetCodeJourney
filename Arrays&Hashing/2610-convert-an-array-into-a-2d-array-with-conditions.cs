public class Solution {
    public IList<IList<int>> FindMatrix(int[] nums) {
        List<IList<int>> result = new();
        Dictionary<int, int> freq = new();
        foreach(int num in nums){
            if (!freq.ContainsKey(num))
                freq[num] = 1;
            else
                freq[num]++;
        }

        while(freq.Any(item => item.Value > 0)){
            List<int> temp = new();
            foreach(var item in freq){
                if(item.Value > 0){
                    temp.Add(item.Key);
                    freq[item.Key]--;
                }
            }
            result.Add(temp);
        }
        return result;
    }
}
