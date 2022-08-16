using System;

public class Solution {
    public int solution(int[] numbers) {
        int[] num = new int[10];
        int sum = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            num[numbers[i]]++;
        }
        for(int i = 0; i < 10; i++)
        {
            if(num[i] == 0)
            {
                sum+=i;
            }
                
        }
        return sum;
    }
}