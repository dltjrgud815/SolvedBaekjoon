using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int cnt = 0;
        int cnt0 = 0;
        int max = 0;
        int min = 0;
        for(int i = 0; i < lottos.Length; i++)
        {
            if (lottos[i] == 0)
                cnt0++;
            for(int j = 0; j < lottos.Length; j++)
            {
                if (lottos[i] == win_nums[j])
                    cnt++;
            }
        }

        switch(cnt0 + cnt)
        {
            case 1:
                max = 6;
                break;
            case 2:
                max = 5;
                break;
            case 3:
                max = 4;
                break;
            case 4:
                max = 3;
                break;
            case 5:
                max = 2;
                break;
            case 6:
                max = 1;
                break;
            default:
                max = 6;
                break;
        }

        switch (cnt)
        {
            case 1:
                min = 6;
                break;
            case 2:
                min = 5;
                break;
            case 3:
                min = 4;
                break;
            case 4:
                min = 3;
                break;
            case 5:
                min = 2;
                break;
            case 6:
                min = 1;
                break;
            default:
                min = 6;
                break;
        }


        int[] answer = new int[2] {max,min};
        return answer;
    }
}