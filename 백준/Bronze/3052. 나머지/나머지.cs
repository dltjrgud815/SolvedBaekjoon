using System;
using System.Text;


class SolvedBaekjoon
{
    static void Main()
    {
        int[] Count = new int[42];
        int[] Num = new int[10];
        int[] Rest = new int[10];
        int cnt = 0;
        for (int i = 0; i < 10; i++)
        {
            Num[i] = Int32.Parse(Console.ReadLine());
            Rest[i] = Num[i] % 42;
            Count[Rest[i]]++;
        }

        for (int i = 0; i < Count.Length; i++)
        {
            if (Count[i] > 0)
                cnt++;
        }

        Console.WriteLine(cnt);
    }
    
}