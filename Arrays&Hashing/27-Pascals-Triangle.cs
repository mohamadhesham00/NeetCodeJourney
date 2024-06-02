public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        // List of list to store the result 
        IList<IList<int>> result = new List<IList<int>>();
        // List to get the previous list we made to make the new one and first list will always be 1
        List<int> previousList = new List<int> { 1 };
        // Add the first list to the result 
        result.Add(previousList);
        for (int i = 1; i < numRows; i++)
        {
            List<int> currentList = new List<int>();
            // First element will always be 1
            currentList.Add(1);
            // Iterate over the previous list to populate currentList
            for (int j = 1; j < previousList.Count; j++)
            {
                currentList.Add(previousList[j] + previousList[j - 1]);
            }
            // Last element will always be 1
            currentList.Add(1);
            // Add the current row to the result and update the previous row reference 
            previousList = currentList;
            result.Add(currentList);

        }
        return result;
    }
}