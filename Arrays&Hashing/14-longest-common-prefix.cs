public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        // Get the smallest string to avoid IndexOutOfRangeException
        int mnSize = strs.Min(x => x.Length);
        // Initialze the result with an empty string
        string result ="";
        for(int i = 0; i < mnSize; i++){
            // Flag to break whenever a character doesn't exist in a string
            bool isExists = true;
            // Variable for storing the current checking char
            char c = ' ';
            for(int j = 0; ((j < strs.Length) && isExists) ; j++){
                // First time we enter the loop it's an empty char
                if(c == ' ')
                {
                    c = strs[j][i];
                }
                else
                {
                    // In case of it's false it breaks loop
                    isExists = strs[j][i]==c;
                }
            }
            // Add the char to the result
            if (isExists){
                result += c;
            }
            else{
                break;
            }
            c = ' ';
        }
        return result;
    }
}
