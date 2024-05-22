public class Solution {
    public bool IsAnagram(string s, string t)
    {
        // If the lengths of the strings are different, they cannot be anagrams
        if (s.Length != t.Length)
        {
            return false;
        }

        // Use a dictionary to track the frequency of each letter in the first string
        Dictionary<char, int> letters = new();
        for (int i = 0; i < s.Length; i++)
        {
            // Initialize the key if not already present
            if (!letters.ContainsKey(s[i]))
            {
                letters[s[i]] = 1;
            }
            // Increment the frequency of the letter
            else
            {
                letters[s[i]]++;
            }
        }

        // Check the frequency of each letter in the second string
        for (int i = 0; i < t.Length; i++)
        {
            // If the letter is not found or the frequency is zero, return false
            if (!letters.ContainsKey(t[i]) || letters[t[i]] == 0)
            {
                return false;
            }
            // Decrement the frequency of the letter
            letters[t[i]]--;
        }

        // If all letters match, return true
        return true;
    }
}
