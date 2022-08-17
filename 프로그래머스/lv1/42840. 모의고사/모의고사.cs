using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] answers)
    {

        int[] h1 = { 1, 2, 3, 4, 5 };
        int[] h2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] h3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
        int[] cnt = new int[3];
        int cnt1 = 0;
        int cnt2 = 0;



        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == h1[i % 5])
                cnt[0]++;
            if (answers[i] == h2[i % 8])
                cnt[1]++;
            if (answers[i] == h3[i % 10])
                cnt[2]++;
        }
        int max = cnt.Max();
        for (int i = 0; i < 3; i++)
        {
            if (cnt[i] == max)
                cnt1++;
        }
        int[] result = new int[cnt1];
        for (int i = 0; i < 3; i++)
        {
            if (cnt[i] == max)
            {
                result[cnt2] = i + 1;
                cnt2++;
            }
                
        }



        return result;
    }
}