public class Solution
{
    public bool MakeEqual(string[] words)
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();
        foreach (string word in words)
        {
            foreach (char letter in word)
            {
                if (freq.ContainsKey(letter))
                    freq[letter]++;
                else
                    freq[letter] = 1;
            }
        }
        foreach (char letter in freq.Keys)
        {
            if (freq[letter] % words.Length != 0)
            {
                return false;
            }
        }
        return true;
    }
}