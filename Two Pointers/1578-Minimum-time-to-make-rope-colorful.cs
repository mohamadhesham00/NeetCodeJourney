public class Solution {
    public int MinCost(string colors, int[] neededTime) {
        int answer = 0;
        int sum = 0;
        int mx = -1;
        for(int i = 0; i <= colors.Length - 1; i++){
            if(i != colors.Length - 1 && colors[i] == colors[i + 1]){
                sum += neededTime[i];
                mx = Math.Max(neededTime[i], mx);
                continue;
            }
            if (sum > 0){
                sum+= neededTime[i];
                mx = Math.Max(neededTime[i], mx);
                answer += (sum - mx);
            }
            sum = 0;
            mx = -1;
        }
        return answer;
    }
}
