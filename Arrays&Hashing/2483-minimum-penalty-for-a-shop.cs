public class Solution {
    public int BestClosingTime(string customers) {
        int[] numOfY = new int[customers.Length + 1];
        int[] numOfN = new int[customers.Length + 1];
        int y = 0;
        int n = 0;
        for (int i = 0; i < numOfY.Length; i++){
            numOfY[i] = y;
            numOfN[i] = n;
            if (i < customers.Length && customers[i] == 'Y')
                y++;
            else
                n++;
        }
        int index = customers.Length + 1;
        int value = int.MaxValue;
        int lastElement = numOfY.Length - 1;
        for(int i = 0; i < numOfY.Length; i++){
            int currentValue = numOfN[i] + (numOfY[lastElement] - numOfY[i]);
            if (currentValue < value){
                index = i;
                value = currentValue;
            }
        }
        return index; 
    }
}
