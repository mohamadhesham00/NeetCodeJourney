public class StartAndEnd
{
    public int? Start { get; set; }
    public int? End { get; set; }
}
public class Solution
{
    public int CountPalindromicSubsequence(string s)
    {
        int answer = 0;
        var list = new List<StartAndEnd>(26);
        for (int i = 0; i < list.Capacity; i++)
        {
            list.Add(new StartAndEnd());
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (list[s[i] - 'a'].Start == null)
                list[s[i] - 'a'].Start = i;

            else
                list[s[i] - 'a'].End = i;

        }
        foreach (var item in list)
        {
            if (item.Start.HasValue && item.End.HasValue)
            {
                var numOfChars = s.Substring(item.Start.Value + 1, item.End.Value - item.Start.Value - 1).Distinct().Count();
                answer += numOfChars;
            }
        }
        return answer;
    }
}