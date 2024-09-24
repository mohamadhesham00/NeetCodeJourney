public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char, char> sMapper = new();
        Dictionary<char, char> tMapper = new();
        // check mapping from s to t
        for(int i = 0; i< s.Length; i++)
        {
            if (sMapper.ContainsKey(s[i]))
            {
                if (sMapper[s[i]] == t[i])
                    continue;
                return false;
            }
            else {
                sMapper.Add(s[i], t[i]);
            }
        }
        // check mapping from t to s
        for(int i = 0; i< t.Length; i++)
        {
            if (tMapper.ContainsKey(t[i]))
            {
                if (tMapper[t[i]] == s[i])
                    continue;
                return false;
            }
            else {
                tMapper.Add(t[i], s[i]);
            }
        }

        return true;
    }
}