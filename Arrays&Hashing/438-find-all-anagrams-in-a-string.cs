public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        IList<int> result = new List<int>();
        Queue<char> queue = new Queue<char>();
        Dictionary<char, int> freq = new();
        foreach (char letter in p){
            if (!freq.ContainsKey(letter))
                freq[letter] = 1;
            else
                freq[letter]++;
        }
        var temp = freq.ToDictionary(freq => freq.Key, freq => freq.Value);
        for (int i = 0; i < s.Length; i++){
            char letter = s[i];
            if (!temp.ContainsKey(letter)){
                temp = freq.ToDictionary(freq => freq.Key, freq => freq.Value);
                queue.Clear();
            }
            else {
                if (temp[letter] == 0){
                    while(true){
                        char first = queue.First();
                        if (first == letter){
                            queue.Enqueue(queue.Dequeue());
                            break;
                        }
                        else{
                            temp[first]++;
                            queue.Dequeue();
                        }
                    }
                }
                else {
                    queue.Enqueue(letter);
                    temp[letter]--;
                }
            }
            if(queue.Count() == p.Length){
                result.Add(i - p.Length + 1);
                temp[queue.Dequeue()]++;
            }
        }
        return result;
    }
}
