public class Solution {
    public bool IsPalindrome(string word){
        int i = 0;
        int j = word.Length - 1;
        while (i < j){
            if (word[i] != word[j])
                return false;
            i++;
            j--;
        }
        return true;
    }
    public string FirstPalindrome(string[] words) {
        foreach(string word in words){
            if(IsPalindrome(word))
                return word;
        }
        return "";
    }
}
