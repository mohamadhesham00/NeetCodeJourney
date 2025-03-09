public class Solution {
    public int MaxProfit(int[] prices)
    {
        bool isBuying = true;
        int mxProfit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (!isBuying && prices[i] > prices[i - 1])
            {
                isBuying = true;
                mxProfit += (prices[i] - prices[i - 1]);
            }
            if (isBuying && i + 1 < prices.Length && prices[i] < prices[i + 1])
            {
                isBuying = false;
            }
        }
        return mxProfit;
    }
}
