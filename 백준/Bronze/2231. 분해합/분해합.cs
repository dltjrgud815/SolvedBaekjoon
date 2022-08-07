using System;
using System.Text;


class SolvedBaekjoon
{
    static void Main()
    {       
        //int[] cnNum = new int[10001];
        StringBuilder sb = new StringBuilder();
        int N = Int32.Parse(Console.ReadLine());
        int a = 0;
        for (int i = 1; i <= N; i++)
        {
            sb.Append(i);
            a = CheckNum(sb);
            if (a == N)
            {
                a = i;
                Console.WriteLine(i);
                break;
            }
            else if(i == N)
                Console.WriteLine("0");
            sb.Clear();
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