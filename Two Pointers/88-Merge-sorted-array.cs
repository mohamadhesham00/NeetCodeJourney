public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int[] result = new int[m + n];
        int mIterator = 0, nIterator = 0;
        for(int i = 0; i < result.Length; i++){
            if(mIterator < m && nIterator < n){
                result[i] = Math.Min(nums1[mIterator], nums2[nIterator]);
            }
            else if(mIterator < m){
                result[i] = nums1[mIterator];
            }
            else{
                result[i] = nums2[nIterator];
            }

            // This is for incrementing the iterator
            if (mIterator < m && result[i] == nums1[mIterator])
                mIterator++;
            else
                nIterator++;
        }
        Array.Copy(result, nums1, result.Length);
        return;
    }
}
