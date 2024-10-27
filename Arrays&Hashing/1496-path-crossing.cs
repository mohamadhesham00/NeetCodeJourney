using System.Collections.Generic;

public class Solution
{
    public bool IsPathCrossing(string path)
    {
        Dictionary<int, List<int>> visitedPoints = new Dictionary<int, List<int>>();
        visitedPoints.Add(0, new List<int> { 0 });
        int x = 0, y = 0;
        foreach (var point in path)
        {
            if (point == 'N')
                x++;
            else if (point == 'S')
                x--;
            else if (point == 'E')
                y++;
            else
                y--;
            if (visitedPoints.ContainsKey(x) && visitedPoints[x].Any(z => z == y))
                return true;
            if (visitedPoints.ContainsKey(x))
                visitedPoints[x].Add(y);
            else
                visitedPoints.Add(x, new List<int> { y });
        }
        return false;
    }
}