public class Solution {
    public string LargestNumber(int[] nums) {
        List<string> numsString = new();
        foreach(int num in nums){
            numsString.Add(num.ToString());
        }
        numsString.Sort((a,b) => (b + a).CompareTo(a + b));

        string result = "";
        foreach(string num in numsString){
            result += num;
        }
        if(result.Count(x => x== '0') == result.Length)
            return 0.ToString();
        return result;
    }
}
