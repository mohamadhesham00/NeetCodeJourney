public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] == 0 
            &&(i == 0 || flowerbed[i - 1] == 0) 
            &&(i + 1 >= flowerbed.Length || flowerbed[i + 1] == 0))
            {
                Console.WriteLine(i);
                flowerbed[i] = 1;
                n--;                   
            }
        }

        if(n <= 0)return true;
        return false;
            }
}