public class Solution
{
    public int FirstUniqChar(string s)
    {
        int mn = int.MaxValue;
        Dictionary<char, int> firstIndex = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (firstIndex.ContainsKey(s[i]))
                firstIndex[s[i]] = -1;
            else
                firstIndex[s[i]] = i;
        }
        foreach (var i in firstIndex)
        {
            if (i.Value != -1)
                mn = Math.Min(mn, i.Value);
        }
        return mn == int.MaxValue ? -1 : mn;
    }
}