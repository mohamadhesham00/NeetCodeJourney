public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        if (tickets[k] == 1)
            return k + 1;
        int result = 0;
        for (int i = 0; i < tickets.Count(); i++){
            result += Math.Min(tickets[i], tickets[k]);
            if ( i > k && tickets[i] >= tickets[k]) result--;
        }
        return result;
    }
}
