public class Solution {
    public bool IsSubsequence(string s, string t) {
        // Check first if the s string is empty this means any string can be substring of it 
        if(s.Length == 0)
            return true;
        
        // Iterator over s string
        int i = 0;
        // Iterate over t string
        for(int j = 0; j < t.Length; j++)
        {
            if (s[i] == t[j])
            {
                // Check if it's the end of s string
                if(i + 1 == s.Length)
                    // Return true because we found the same chars with the same relative postions
                    return true;
                // If it's not the end increase the s string iterator
                i++;
            }
        }
        // Return false cause that means we didn't reach the end of s string ever 
        return false;
    }
}