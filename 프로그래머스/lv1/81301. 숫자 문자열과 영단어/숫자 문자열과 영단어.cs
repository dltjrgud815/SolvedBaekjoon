using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public enum NUMBER
    {
        zero,
        one,
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine
    }

    public int solution(string s)
    {
        Dictionary<string, int> rDict = new Dictionary<string, int>();
        for(int i = 0; i < 10; i++)
        {
            NUMBER nUMBER = (NUMBER)i;
            rDict.Add(nUMBER.ToString(), i);
        }
        
        foreach (var item in rDict)
        {
            if(s.Contains(item.Key))
            {
                s = s.Replace(item.Key, item.Value.ToString());
            }
        }
        
        int answer = Int32.Parse(s);
        return answer;
    }
}