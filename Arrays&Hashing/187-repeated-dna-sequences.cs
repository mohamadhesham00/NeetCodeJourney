public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        Dictionary<string, int> freq = new();
        IList<string> result = new List<string>();
        for (int i = 0; i < s.Length - 9; i++){
            string substring = s.Substring(i, 10);
            if(!freq.ContainsKey(substring))
                freq[substring] = 1;
            else
                freq[substring]++;
        }
        foreach (var item in freq){
            if(item.Value > 1)
                result.Add(item.Key);
        }
        return result; 
    }
}
