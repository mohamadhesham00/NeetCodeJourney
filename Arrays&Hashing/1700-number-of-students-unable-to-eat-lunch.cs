public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        Queue<int> studentsQueue = new Queue<int>();
        Queue<int> sandwichesQueue = new Queue<int>();
        foreach(int i in students){
            studentsQueue.Enqueue(i);
        }
        foreach(int i in sandwiches){
            sandwichesQueue.Enqueue(i);
        }
        while(studentsQueue.Count != 0){
            int queueSize = studentsQueue.Count;
            for(int i = 0; i < studentsQueue.Count; i++){
                if (studentsQueue.First() == sandwichesQueue.First()){
                    studentsQueue.Dequeue();
                    sandwichesQueue.Dequeue();
                }
                else{
                    studentsQueue.Enqueue(studentsQueue.Dequeue());
                }
            }
            if (queueSize == studentsQueue.Count){
                return studentsQueue.Count;
            }
        }
        return 0;
    }
}
