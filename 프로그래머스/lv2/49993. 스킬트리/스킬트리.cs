using System;

public class Solution {
    public int solution(string skill, string[] skill_trees)
    {
        string temp;
        bool isRight = true;
        int temp1 = -1;
        int result = 0;
        int[] cnt = new int[skill.Length];
        for(int i = 0; i < cnt.Length; i++)
        {
            cnt[i] = -1;
        }
        for(int i = 0; i < skill_trees.Length; i++)
        {
            for(int k = 0; k < skill.Length; k++)
            {
                temp = skill_trees[i];
                for(int j= 0; j < skill_trees[i].Length; j++)
                {
                    if (skill[k] == temp[j])
                    {
                        cnt[k] = j;
                    }
                    
                }
                //Console.WriteLine(cnt[k]);
            }
            for (int l = 0; l < cnt.Length -1; l++)
            {
                if (cnt[l] != -1)
                    temp1 = cnt[l];
                else if (cnt[l] == -1 && cnt[l+1] != -1)
                {
                    isRight = false;
                }
                if (cnt[l + 1 ] != -1)
                {
                    if (temp1 > cnt[l + 1])
                        isRight = false;
                }
                
            }
            if (isRight)
            {
                result++;
            }
                
            temp1 = -1;
            isRight = true;
            for (int q = 0; q < cnt.Length; q++)
            {
                cnt[q] = -1;
            }
        }

        return result;
    }
}