using System.Collections.Generic;
using System.Linq;
using System;

public class Solution
{
    public int CountCharacters(string[] words, string chars)
    {
        int size = 0;
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (var c in chars)
        {
            if (freq.ContainsKey(c))
            {
                freq[c]++;
            }
            else
            {
                freq[c] = 1;
            }
        }
        foreach (var word in words)
        {
            bool isValid = true;
            foreach (var c in word)
            {

                isValid = word.Count(x => x == c) <= (freq.ContainsKey(c) ? freq[c] : 0) ? true : false;
                if (!isValid)
                {
                    break;
                }
            }
            size = isValid ? size + word.Length : size;
            Console.WriteLine(size);
        }
        return size;
    }
}