public class Solution {
    public bool validPalindrome(string s, int? ignoredIndex){
        int i = 0, j = s.Length - 1;
        while (i < j){
            // Skip ignored index
            if (i == ignoredIndex) { i++; continue; }
            if (j == ignoredIndex) { j--; continue; }

            if(s[i] != s[j]){
                if(ignoredIndex == null)
                    return validPalindrome(s, i) || validPalindrome(s, j);
                    
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
    public bool ValidPalindrome(string s) {
        return validPalindrome(s, null);
    }
}
