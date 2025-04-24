public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        int mn = int.MaxValue;
        for (int i = 0; i < blocks.Length; i++){
            int numOfWhite = 0;
            int j = i;
            for (; j < blocks.Length && j - i + 1 <= k; j++){
                if (blocks[j] == 'W')
                    numOfWhite++;
            }
            if(j - i == k)
                mn = Math.Min(mn, numOfWhite);
        }
        return mn;
    }
}
