public class Solution {
    public int[] ReplaceElements(int[] arr) {
        //Array for storing the result
        int[] result = new int[arr.Length];
        // It's a rule that last element in each array will me -1 because no other values on the right
        result[arr.Length - 1] = -1;
        // Set the maximum value to the last element
        int mx = arr[arr.Length - 1];
        for (int i = arr.Length - 2; i >= 0; i--)
        {
            // Store the maximum in the result 
            result[i] = mx;
            // Check if there the current element is greater than maximum 
            mx = Math.Max(mx, arr[i]);    
        }

        return result;
    }
}