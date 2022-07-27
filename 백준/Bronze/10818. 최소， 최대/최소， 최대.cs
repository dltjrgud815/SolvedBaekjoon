using System;


class SolvedBaekjoon
{
    static void Main()
    {
        int length = Int32.Parse(Console.ReadLine());
        string phrase = Console.ReadLine();
        string[] words = phrase.Split(' ');

        int[] Num = new int[length];
        for (int i = 0; i < length; i++)
        {
            Num[i] = Int32.Parse(words[i]);
        }

        int min = int.MaxValue;
        int max = int.MinValue;

        for (int i = 0; i < length; i++)
        {
            if (min > Num[i])
                min = Num[i];
            if (max < Num[i])
                max = Num[i];
        }

        Console.WriteLine($"{min} {max}");
        // int A = Int32.Parse(words[0]);
        // int B = Int32.Parse(words[1]);



    }
    
}