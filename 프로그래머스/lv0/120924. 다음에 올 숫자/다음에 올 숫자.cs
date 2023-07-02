using System;

public class Solution {
    public int solution(int[] common) {
        int sub = common[1] - common[0];
        int mul = common[0] == 0 ? 0 : common[1] / common[0];
        bool isSub = false;
        
        for (int i = 1; i < common.Length - 1; i++)
        {
            if (common[i + 1] - common[i] == sub)
            {
                isSub = true;
            }
            
            if (mul == 0)
            {
                continue;
            }
            
            if (common[i + 1] / common[i] == mul)
            {
                isSub = false;
            }
        }
        
        int answer = 0;
        
        if (isSub)
        {
            answer = common[common.Length - 1] + sub;
            Console.WriteLine(answer);
        }
        else
        {
            answer = common[common.Length - 1] * mul;
        }
        
        return answer;
    }
}