public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        List<IList<int>> result = new();
        Dictionary<int, int> freq1 = new();
        Dictionary<int, int> freq2 = new();
        foreach(int num in nums1){
            freq1[num] = 1;
        }
        foreach(int num in nums2){
            if(!freq1.ContainsKey(num)){
                freq2[num] = 1;
            }
            else{
                freq1[num] = 0;
            }
        }
        result.Add(freq1.Where(item => item.Value > 0).Select(item => item.Key).ToList());
        result.Add(freq2.Keys.ToList());
        return result;
    }
}
