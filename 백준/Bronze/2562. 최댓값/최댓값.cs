using System;


class SolvedBaekjoon
{
    static void Main()
    {
        int[] Num = new int[9];
        for (int i = 0; i < 9; i++)
        {
            Num[i] = Int32.Parse(Console.ReadLine());
        }

        int max = int.MinValue;
        int index = 0;

        for (int i = 0; i < 9; i++)
        {
            if (max < Num[i])
            {
                max = Num[i];
                index = i+1;
            }
                
            
        }

        Console.WriteLine(max);
        Console.WriteLine(index);
    }
    
}