public class Solution {
    public int[][] DivideArray(int[] nums, int k) {
        int numOfArrays = nums.Count() / 3;
        int[][] answers = new int[numOfArrays][];
        SortedDictionary<int, int> freq = new SortedDictionary<int, int>();
        foreach(int num in nums){
            if(freq.ContainsKey(num))
                freq[num]++;
            else 
                freq[num] = 1;
        }
        int i = 0;
        int j = 0;
        int[] temp = new int[3];
        foreach (var item in freq){
            if (i == numOfArrays)
                break;
            int value = item.Value;
            while(value > 0){
                temp[j++] = item.Key;
                if (j == 3){
                    // To avoid passing by reference because it will cause a problem
                    answers[i++] = (int[])temp.Clone();
                    j = 0;
                }
                value--;
            }
        }
        foreach(var answer in answers){
            if (answer[2] - answer[0] > k)
                return new int[0][];
        }
        return answers;
    }
}
