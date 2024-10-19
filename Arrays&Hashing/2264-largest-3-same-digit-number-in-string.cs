public class Solution
{
    public string LargestGoodInteger(string num)
    {
        string answer = "-1";
        string temp = num[0].ToString();
        for (int i = 1; i < num.Length; i++)
        {
            if (num[i] == num[i - 1])
                temp += num[i].ToString();
            else
                temp = num[i].ToString();
            if (temp.Length == 3)
                answer = int.Parse(temp) > int.Parse(answer) ? temp : answer;
        }
        if (answer == "-1") return string.Empty;
        return answer;
    }
}