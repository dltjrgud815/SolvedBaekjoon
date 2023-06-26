using System;

public class Solution {
    public int solution(int num1, int num2) {
        float a = (float)num1 / (float)num2 * 1000f;
        int answer = (int)a;
        return answer;
    }
}