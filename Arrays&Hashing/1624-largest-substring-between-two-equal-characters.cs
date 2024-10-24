public class Solution
{
    public int MaxLengthBetweenEqualCharacters(string s)
    {
        int answer = -1;
        Dictionary<char, int> indices = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (indices.ContainsKey(s[i]))
            {
                answer = Math.Max(answer, i - indices[s[i]] - 1);
            }
            else
            {
                indices.Add(s[i], i);
            }
        }
        return answer;
    }
}