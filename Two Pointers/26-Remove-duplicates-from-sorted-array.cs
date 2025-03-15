public class Solution {
    public int RemoveDuplicates(int[] nums) {
        HashSet<int> set = new();
        foreach(int num in nums){
            set.Add(num);
        }
        int i = 0;
        foreach(var item in set){
            nums[i++] = item;
        }
        return set.Count;
    }
}
