public class Solution {
    public bool HasAllCodes(string s, int k) {
        long mxNumber = (long)Math.Pow(2, k);
        Dictionary<string, int> map = new();
        for (int i = 0; i < s.Length - k + 1; i++){
            string subString = s.Substring(i, k);
            map[subString] = 1;
        }
        if (map.Count() == mxNumber)
            return true;
        return false;
        
    }
}
