using System.Collections.Generic;

public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        int[][] arrs = new int[rowIndex + 1][];
        arrs[0] = new int[1] { 1 };
        for (int i = 1; i < arrs.Length; i++)
        {
            int[] temp = new int[i + 1];
            temp[0] = 1;
            for (int j = 1; j < i; j++)
            {
                temp[j] = arrs[i - 1][j] + arrs[i - 1][j - 1];
            }
            temp[i] = 1;
            arrs[i] = temp;
        }
        return arrs[rowIndex];
    }
}