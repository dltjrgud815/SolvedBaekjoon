using System;
using System.Text;


class SolvedBaekjoon
{
    static void Main()
    {

        int[] Count = new int[10];
        int[] Num = new int[3];
        int index = 0;
        for (int i = 0; i < 3; i++)
        {
            Num[i] = Int32.Parse(Console.ReadLine());
        }

        int total = Num[0] * Num[1] * Num[2];
        StringBuilder sb = new StringBuilder();
        sb.Append(total.ToString());
        for (int i = 0; i < sb.Length; i++)
        {
            Count[(int)sb[i] - '0']++;
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(Count[i]);
        }
    }
    
}