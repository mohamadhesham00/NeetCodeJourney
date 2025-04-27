public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        int answer = 0;
        for (int i = 0; i <= arr.Length - k; i++){
            int sum = arr[i];
            for(int j = i + 1; j < arr.Length && j - i + 1 <= k; j++){
                sum += arr[j];
            }
            double avg = sum / k;
            if (avg >= threshold)
                answer++;
        }
        return answer;    
    }
}
// Another one using Linq but I got time limit exceeded in the last test case
// public class Solution {
//     public int NumOfSubarrays(int[] arr, int k, int threshold) {
//         int answer = 0;
//         for (int i = 0; i <= arr.Length - k; i++){
//             double avg = arr.Skip(i).Take(k).Average();
//             if (avg >= threshold)
//                 answer++;
//         }
//         return answer;    
//     }
// }
