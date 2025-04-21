public class Solution {
    public int[][] MergeArrays(int[][] nums1, int[][] nums2) {
        return nums1.Concat(nums2)
        .GroupBy(arr => arr[0])
        .Select(kvp => new int[] { kvp.Key, kvp.Sum(p => p[1]) })
        .OrderBy(arr => arr[0])
        .ToArray();
    }
}
