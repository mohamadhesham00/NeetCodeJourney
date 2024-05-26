public class Solution {
    //Function for sorting a string
    public string SortString(string s)
    {
    // Turn the string into char[] to be able to sort it
    char[] temp = new char[s.Length];
    temp = s.ToCharArray();
    Array.Sort(temp);
    // Turn it back to a stromg
    return new string(temp);
    }
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        // List of List to store the result 
        IList<IList<string>> result = new List<IList<string>>();
        // Dictionary for storing key-> sorted string , value -> list of matched anagrams
        Dictionary<string, List<string>> ExistingAnagrams = new Dictionary<string, List<string>>();
        // String for storing sorted string to use as a key
        string sortedStr;
        // Iterate over strings in array
        for(int i = 0; i <strs.Length; i++)
        {
            sortedStr = SortString(strs[i]);
            // Check if the string isn't in the dictionary we make a new list
            if (!ExistingAnagrams.ContainsKey(sortedStr))
            {
                ExistingAnagrams[sortedStr] = new List<string>();
            }
            // Add the original string to the list corresponding to the sorted string key
            ExistingAnagrams[sortedStr].Add(strs[i]);
        } 
        // Iterate over the dicionary to store the result   
        foreach(KeyValuePair<string, List<string>> kvp in ExistingAnagrams )
        {
            result.Add(kvp.Value);
        }

        return result;
    }
}