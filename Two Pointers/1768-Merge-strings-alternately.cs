public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int mxLength = Math.Max(word1.Length, word2.Length);
        char[] resultArray = new char[mxLength * 2];
        Array.Fill(resultArray,' ');
        int i = 0;
        foreach(char letter in word1){
            resultArray[i] = letter;
            i +=2;
        }
        i = 1;
        foreach(char letter in word2){
            resultArray[i] = letter;
            i +=2;
        }
        return new string(resultArray).Replace(" ","");
    }
}


// A better solution
public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder s = new();
        int maxsize = Math.Max(word1.Length,word2.Length);
        for(int i = 0; i < maxsize; i++){
            if(i < word1.Length) s.Append(word1[i]);
            if(i < word2.Length)s.Append(word2[i]);
        }
        return s.ToString();
    }
}
