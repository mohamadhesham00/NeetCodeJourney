// Good solution I found ("https://leetcode.com/problems/backspace-string-compare/solutions/5836675/optimal-solution/")
public class Solution {
    public bool BackspaceCompare(string s, string t) {
        Stack<char> stack = new();
        foreach(char letter in s){
            if (letter == '#' && stack.Count() != 0){
                stack.Pop();
            }
            else if (letter != '#')
                stack.Push(letter);
        }
        string sFixed = new string(stack.ToArray());
        stack.Clear();
        
        foreach(char letter in t){
            if (letter == '#' && stack.Count() != 0){
                stack.Pop();
            }
            else if (letter != '#')
                stack.Push(letter);
        }
        string tFixed = new string(stack.ToArray());
        return sFixed == tFixed;
    }
}
