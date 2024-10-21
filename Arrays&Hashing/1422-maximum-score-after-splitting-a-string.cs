using System;

public class Solution
{
    public int MaxScore(string s)
    {
        int mx = 0;
        int numOfOnes = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '1')
                numOfOnes++;
        }
        int zeroIncremental = 0;
        int oneIncremental = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == '0')
                zeroIncremental++;
            else
                oneIncremental++;
            int value = zeroIncremental + (numOfOnes - oneIncremental);
            mx = Math.Max(mx, value);
        }
        return mx;
    }
}