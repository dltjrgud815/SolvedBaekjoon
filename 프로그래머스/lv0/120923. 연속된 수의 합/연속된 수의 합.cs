using System;

public class Solution {
    public int[] solution(int num, int total) {
        int[] answer = new int[num];
        int startNum = 0;
        if (num % 2 == 0)
        {
            startNum = (total / num) - (num / 2) + 1;
        }
        else
        {
            startNum = (total / num) - (num / 2);
        }
        
        for (int i = 0; i < num; i++)
        {
            answer[i] = startNum + i;
        }
        
        return answer;
    }
}