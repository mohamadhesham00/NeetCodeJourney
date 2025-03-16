public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        Array.Sort(nums, (a,b) => (a % 2).CompareTo(b % 2));
        return nums;  
    }
}
