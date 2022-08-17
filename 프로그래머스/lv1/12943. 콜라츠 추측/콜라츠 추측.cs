public class Solution {
    public int solution(int num) {
        int cnt = 0;
        while(true)
        {
            
            if(cnt > 500)
            {
                return -1;
                //break;
            }
            if(num % 2 == 0 && cnt < 500)
            {
                num /= 2;

            }
            else if(num % 2 == 1 && num != 1 && cnt < 500)
            {
                num = (num * 3) + 1;

            }
            else if(num == 1 && cnt < 500)
            {
                return cnt;
                //break;
            }
            cnt++;
                
            
        }
    }
}