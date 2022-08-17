using System;

public class Solution {
    public int[] solution(int brown, int yellow)
    {
        int temp = brown + yellow;
        int[] answer = new int[2];
        int cal = (int)MathF.Sqrt(temp);
        int temp1 = temp / cal;
        int temp2 = cal;

        while (true)
        {
            if ((((temp1 - 2) * (temp2 - 2)) == yellow) && (temp1 * temp2 == temp))
                break;
            else
            {
                --temp2;
                temp1 = temp / temp2;

            }

        }


        answer[0] = temp1;
        answer[1] = temp2;
        return answer;
    }
}