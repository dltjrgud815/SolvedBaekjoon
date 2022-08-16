using System;
using System.Collections;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        int[] answer = new int[id_list.Length];
        int[,] Charcnt = new int[id_list.Length, id_list.Length];
        int[] callcnt = new int[id_list.Length];
        Dictionary<string, int> id_Cnt = new Dictionary<string, int>();
        for(int i = 0; i < id_list.Length; i++)
        {
            id_Cnt.Add(id_list[i], i);
        }
        string[] tempStr;
        for (int i = 0; i < report.Length; i++)
        {
            tempStr = report[i].Split(' ');
            if(Charcnt[id_Cnt[tempStr[0]], id_Cnt[tempStr[1]]] == 0)
            {
                Charcnt[id_Cnt[tempStr[0]], id_Cnt[tempStr[1]]]++;
            }
                
            //callcnt[id_Cnt[tempStr[0]]]++;
        }
        for(int i = 0; i < id_list.Length; i++)
        {
            for(int j = 0; j < id_list.Length; j++) //Charcnt[신고자 , 신고당한사람 ]
            {
                callcnt[i] += Charcnt[j, i];
            }

            //Console.WriteLine(callcnt[i]);
            //if (callcnt[i] >= k)
            //    answer[i] = 0;

        }
        for (int i = 0; i < id_list.Length; i++)
        {
            if(callcnt[i] >= k)
            {
                for (int j = 0; j < id_list.Length; j++)
                {
                    if (Charcnt[j, i] == 1)
                        answer[j]++;
                }
                //answer[i] = 0;
            }
            

        }

        return answer;
    }
}