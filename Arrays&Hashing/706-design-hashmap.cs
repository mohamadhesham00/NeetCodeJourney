using System.Collections.Generic;

public class MyHashMap
{

    private Dictionary<int, int> map;

    public MyHashMap()
    {
        map = new Dictionary<int, int>();
    }

    public void Put(int key, int value)
    {
        map[key] = value;
    }

    public int Get(int key)
    {
        return map.ContainsKey(key) ? map[key] : -1;
    }

    public void Remove(int key)
    {
        bool value = map.ContainsKey(key) ? map.Remove(key) : false;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */