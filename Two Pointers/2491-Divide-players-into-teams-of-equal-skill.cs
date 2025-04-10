public class Solution {
    public long DividePlayers(int[] skill) {
        if (skill.Length == 2)return skill[0] * skill[1];
        int numberOfGroups = skill.Length / 2;
        int sum = skill.Sum();
        if (sum % numberOfGroups != 0)
            return -1; 
        int TeamSkill = sum / numberOfGroups;
        Dictionary<int, int> freq = new();
        long chemistry = 0;
        foreach(int i in skill){
            if(freq.ContainsKey(i))
                freq[i] += 1;
            else
                freq[i] = 1;
        }
        for(int i = 0; i < skill.Length; i++){
            int number = skill[i];
            int compliment = TeamSkill - number;
            if(freq.ContainsKey(compliment) && freq[compliment] == freq[number]){
                if(freq[compliment] <= 0)
                    continue;
                chemistry += (compliment * number);
                freq[compliment] -= 1;
                freq[number] -= 1;
            }
            else{
                return -1;
            }
        }
        return chemistry;
    }
}
