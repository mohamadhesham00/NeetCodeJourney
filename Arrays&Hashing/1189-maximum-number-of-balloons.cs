using System.Collections.Generic;
using System;

public class Solution
{
    public int MaxNumberOfBalloons(string text)
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();
        freq['b'] = 0;
        freq['a'] = 0;
        freq['l'] = 0;
        freq['o'] = 0;
        freq['n'] = 0;
        foreach (char c in text)
        {
            if (c == 'b' || c == 'a' || c == 'l' || c == 'o' || c == 'n')
            {
                freq[c]++;
            }
        }

        return Math.Min(freq['b'], Math.Min(freq['a'], Math.Min(freq['l'] / 2, Math.Min(freq['o'] / 2, freq['n']))));
    }
}