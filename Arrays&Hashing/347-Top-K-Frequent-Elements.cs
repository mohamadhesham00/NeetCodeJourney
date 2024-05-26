public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Array for storing the result
        int[] result = new int[k];
        // Dictionary for storing the frequency of each number in the array
        Dictionary<int, int> numsFreq = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            // Check if the number exists on the dictionary we increase it 
            if (numsFreq.ContainsKey(nums[i])) numsFreq[nums[i]]++;
            // If not initialize it to 1
            else numsFreq[nums[i]] = 1;
        }
        // SortedDictionary for storing sorted frequent elements
        SortedDictionary<int, List<int>> mostFreqElements = new SortedDictionary<int, List<int>>();
        // Iterate over each number in the numbers to get its frequency
        foreach(KeyValuePair<int, int> kvp in numsFreq)
        {
            // If this number of frequency never existed before make a new list for it
            if (!mostFreqElements.ContainsKey(kvp.Value))
            {
                mostFreqElements[kvp.Value] = new List<int> ();
            }
            // Add the number to the list of its frequency
            mostFreqElements[kvp.Value].Add(kvp.Key);
        }
        // Iterator used to store the current index of result
        int iterator = 0;
        // Iterate over the Dictionary reversed to get the most frequent elements 
        foreach (KeyValuePair<int, List<int>> kvp in mostFreqElements.Reverse())
        {
            // List to store the values list so we can iterate over it
            List<int> values = kvp.Value;
            for(int j = 0; j < values.Count; j++)
            {
                //Store the most frequent elements in the result 
                result[iterator++] = values[j];
                k--;
                // Check if we stored most K frequent element in the array
                if (k == 0)
                {
                    return result;   
                }
            }
        }
        // This is just for c# complier to run we will never reach here
        return result;
    }
}