using System.Collections.Generic;

public class MyHashSet
{

    private readonly HashSet<int> _list;

    public MyHashSet()
    {
        _list = new HashSet<int>();
    }

    public void Add(int key)
    {
        _list.Add(key);
    }

    public void Remove(int key)
    {
        _list.Remove(key);
    }

    public bool Contains(int key)
    {
        return _list.Any(x => x == key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */