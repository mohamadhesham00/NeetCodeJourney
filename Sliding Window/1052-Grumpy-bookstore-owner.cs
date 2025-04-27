public class Solution {
    public int MaxSatisfied(int[] customers, int[] grumpy, int minutes) {
        int answer = customers.Where((value, index) => grumpy[index] == 0).Sum();
        int mx = -1;
        for (int i = 0; i + minutes <= customers.Length; i++){
            int sum = 0;
            for (int  j = i; j < customers.Length && j - i + 1 <= minutes; j++){
                if (grumpy[j] == 1)
                    sum += customers[j];
            }
            mx = Math.Max(mx, sum);
        }
        return answer + mx;
    }
}
