public class Solution {
    public string FrequencySort(string s) {
        Dictionary<char, int> freq = new();
        SortedDictionary<int, List<char>> map = new();
        string result = ""; 
        foreach(char letter in s){
            if (!freq.ContainsKey(letter))
                freq[letter] = 1;
            else
                freq[letter]++;
        }
        foreach(var item in freq){
            if(!map.ContainsKey(item.Value)){
                map[item.Value] = new List<char>();
                map[item.Value].Add(item.Key);
            }
            else{
                map[item.Value].Add(item.Key);
            }
        }
        foreach(var item in map){
            var list = item.Value;
            foreach(char letter in list){
                int value = item.Key;
                while(value-- > 0){
                    result += letter;
                }
            }
        }
        char[] charArray = result.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
