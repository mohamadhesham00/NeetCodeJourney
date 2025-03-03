public class Solution {
    public int PartitionString(string s) {
        HashSet<char> uniqueChars = new();
        List<string> result = new();
        for (int i = 0; i < s.Length; i++){
            if(uniqueChars.Contains(s[i])){
                string subString = string.Concat(uniqueChars);  
                result.Add(subString);
                uniqueChars.Clear();
            }
            uniqueChars.Add(s[i]);
            // This is for handling the last character
            if (i == s.Length - 1){
                string subString = string.Concat(uniqueChars);  
                result.Add(subString);
            }
        }
        foreach(string word in result){
            Console.WriteLine(word);
        }
        return result.Count();
    }
}

// Better solution 
public class Solution {
    public int PartitionString(string s) {
        HashSet<char> uniqueChars = new();
        int result = 0;
        for (int i = 0; i < s.Length; i++){
            if(uniqueChars.Contains(s[i])){
                result++;
                uniqueChars.Clear();
            }
            uniqueChars.Add(s[i]);
            // This is for handling the last character
            if (i == s.Length - 1){
                result++;
            }
        }
        return result;
    }
}
