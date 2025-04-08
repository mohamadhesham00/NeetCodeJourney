public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int i = 0, j = people.Length - 1;
        int result = 0;
        while(j >= i){
            if (people[i] + people[j] <= limit)
                i++;
            j--;
            result++;
        }
        return result;
    }
}
