public class Solution
{
    public int MinOperations(string s)
    {
        //these are the possible solutions
        //'1010101010'
        //'010101010'
        int flag = 1;
        int onesAndZeros = 0;
        int zerosAndOnes = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] - '0' != flag)
                onesAndZeros++;
            else
                zerosAndOnes++;
            flag = 1 - flag;

        }
        return onesAndZeros > zerosAndOnes ? zerosAndOnes : onesAndZeros;

    }
}