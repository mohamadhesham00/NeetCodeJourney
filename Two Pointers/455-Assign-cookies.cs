public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);
        int gIterator = 0, sIterator = 0;
        int numberOfContent = 0;
        while (gIterator < g.Length && sIterator < s.Length){
            if (s[sIterator] >= g[gIterator]){
                gIterator++;
                numberOfContent++;
            }
            sIterator++;
        }
        return numberOfContent;
    }
}
