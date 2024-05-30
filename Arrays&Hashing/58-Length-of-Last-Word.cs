public class Solution {
    public int LengthOfLastWord(string s) {
        // Var used to store the size of the last word in
        int size = 0;
        // Iterate over the string from the end to make it faster
        for(int i = s.Length - 1; i >= 0; i--)
        {
            // Check if it's space and size greater than zero (to avoid strings that ends with a space)
            if (s[i] == ' ' && size > 0)
            {
                // Already calculated the size of the last word so break from the loop
                break;
            }
            else if (char.IsLetter(s[i]))
            {
                size++;
            }
        }
        return size;
    }
}