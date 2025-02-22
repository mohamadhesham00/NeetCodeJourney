/*
This is my code and for a reason i get wrong answer even I tried this locally and it works fine
*/
public class Solution {
    public static IList<int> list = new List<int>() { 0, 1 };
    public static void IncreaseList()
    {
        if (list[list.Count - 1] == 9)
        {
            list.Add(0);
            for (int i = 1; i < list.Count; i++)
            {
                list[i] = i;
            }
            return;
        }
        for (int i = 1; i < list.Count; i++)
        {
            list[i] += 1;
        }
    }
    public static int GetNumber()
    {
        int number = 0;
        foreach (int i in list)
        {
            number = (number * 10) + i;
        }
        return number;
    }
    public IList<int> SequentialDigits(int low, int high)
    {
        IList<int> answers = new List<int>();
        int number = GetNumber();
        while (number <= high)
        {
            if (number >= low)
            {
                answers.Add(number);
            }
            IncreaseList();
            number = GetNumber();
        }
        return answers;
    }
}

/* 
This is the solution I found in solutions
*/
public class Solution {
    public IList<int> SequentialDigits(int low, int high) {
        List<int> result = [];

        for(int digit=1; digit<9; digit++){
            int num = digit;
            int nextDigit = num + 1;

            while(num <= high && nextDigit <= 9){
                num = (num * 10) + nextDigit;
                if(num >= low && num <= high) result.Add(num);

                nextDigit++;
            }
        }

        result.Sort();
        return result;
    }
}
