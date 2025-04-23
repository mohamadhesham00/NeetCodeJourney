// Solution using sliding window
public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        for(int i = 0; i < nums.Length; i++){
            for(int j = i + 1; j < nums.Length && j - i <= k; j++){
                if (nums[i] == nums[j])
                    return true;
            }
        }
        return false;

    }
}

// Solution using dictionary 

// public class Solution {
//     public bool ContainsNearbyDuplicate(int[] nums, int k) {
//         Dictionary<int, int> lastIndex = new();
//         for(int i = 0; i < nums.Length; i++){
//             int key = nums[i];
//             if (lastIndex.ContainsKey(key)){
//                 if (i - lastIndex[key] <= k)
//                     return true;
//             }
//             lastIndex[key] = i;
//         }
//         return false;

//     }
// }
