using System.Collections.Generic;

public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        Dictionary<char, string> charMapper = new Dictionary<char, string>();
        Dictionary<string, char> stringMapper = new Dictionary<string, char>();
        string[] words = s.Split(' ');
        if (words.Length != pattern.Length)
            return false;
        for (int i = 0; i < pattern.Length; i++)
        {
            if (charMapper.ContainsKey(pattern[i]) && charMapper[pattern[i]] != words[i])
                return false;
            else if (stringMapper.ContainsKey(words[i]) && stringMapper[words[i]] != pattern[i])
                return false;
            charMapper[pattern[i]] = words[i];
            stringMapper[words[i]] = pattern[i];
        }

        return true;
    }
}