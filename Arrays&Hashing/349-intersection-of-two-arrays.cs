public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var result = new List<int>();
        var existsInFirstArray = new Dictionary<int, bool>();
        int iterator = 0;
        foreach (var i in nums1)
        {
            existsInFirstArray[i] = true;
        }
        foreach (int i in nums2)
        {
            if (existsInFirstArray.GetValueOrDefault(i))
            {
                existsInFirstArray[i] = false;
                result.Add(i);
            }
        }
        return result.ToArray();
    }
}