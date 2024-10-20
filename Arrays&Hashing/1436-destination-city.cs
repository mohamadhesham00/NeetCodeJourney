using System.Collections.Generic;

public class Solution
{
    public string DestCity(IList<IList<string>> paths)
    {
        Dictionary<string, string> map = new Dictionary<string, string>();
        foreach (var path in paths)
        {
            map.Add(path[0], path[1]);
        }
        string key = map[paths[0][0]];
        while (map.ContainsKey(key))
        {
            key = map[key];
        }
        return key;
    }
}