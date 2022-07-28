using System;
using System.Text;
using Microsoft.VisualBasic;


class SolvedBaekjoon
{
    static void Main()
    {       
        int[] cnNum = new int[10001];
        StringBuilder sb = new StringBuilder();
        int a = 0;
        for (int i = 0; i < 10000; i++)
        {
            sb.Append(i);
            a = CheckNum(sb);
            if (a > 10000)
                a = 10000;
            cnNum[a]++;
            sb.Clear();
        }

        for (int i = 0; i < 10000; i++)
        {
            if(cnNum[i] == 0)
                Console.WriteLine(i);
        }
    }

    static int CheckNum(StringBuilder num)
    {
        int suNum = 0;
        for (int i = 0; i < num.Length; i++)
        {
            suNum += ((int)num[i] - '0');
        }

        suNum += Int32.Parse(num.ToString());

        return suNum;

    }
    
}