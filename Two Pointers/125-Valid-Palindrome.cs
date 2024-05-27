using System.Text.RegularExpressions;
public class Solution {
    public bool IsPalindrome(string s) {
        // Clean the string from spaces and non-alphanumeic characters
        s = s.Replace(" ","").ToLower();
        s = Regex.Replace(s, "[^a-zA-Z0-9]", "");
        // Two pointers to check equality 
        int left = 0;
        int right = s.Length - 1;
        while(left < right)
        {
            if (s[left] != s[right])
                // This means not palindrome so return false directly
                return false;
            left++; right--;
        }
        return true;
    }
}