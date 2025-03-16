public class Solution {
    public string ReverseString(string original){
        char[] charArray = original.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    public string ReverseWords(string s) {
        StringBuilder sb = new();
        string[] splitted = s.Split(' ');
        string[] reversed = splitted.Select(word => ReverseString(word)).ToArray();
        sb.AppendJoin(" ", reversed);
        return sb.ToString();
    }
}
// Another solution
public class Solution {
    public string ReverseWords(string s) {
        return string.Join(" ", s.Split(' ').Select(word => new string(word.Reverse().ToArray())));
    }
}
