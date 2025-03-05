public class Solution {
    public long GetSumUpTo(int number){
        if(number == 1)
            return 1;
        return number + GetSumUpTo(number - 1);
    }
    public long InterchangeableRectangles(int[][] rectangles) {
        Dictionary<double, int> freq = new();
        int rows = rectangles.GetLength(0);
        long result = 0;
        for (int i = 0; i < rows; i++)
        {
            int width = rectangles[i][0];
            int height = rectangles[i][1];
            double value = (double)width / (double)height;
            if (!freq.ContainsKey(value)){
               freq[value] = 1; 
            }
            else{
                freq[value]++;
            }
        }
        foreach(var item in freq){
            if(item.Value > 1)
                result += GetSumUpTo(item.Value - 1);
        }
        return result;
    }
}
