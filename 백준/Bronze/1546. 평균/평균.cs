using System;
using System.Text;


class SolvedBaekjoon
{
    static void Main()
    {
        int length = Int32.Parse(Console.ReadLine());
        string phrase = Console.ReadLine();
        string[] words = phrase.Split(' ');
        float[] NewNum = new float[length];
        int[] Num = new int[length];
        int[] Rest = new int[10];
        int max = int.MinValue;
        float sum = 0;
        int cnt = 0;
        for (int i = 0; i < length; i++)
        {
            Num[i] = Int32.Parse(words[i]);
        }

        for (int i = 0; i < length; i++)
        {
            if (max < Num[i])
                max = Num[i];
        }

        for (int i = 0; i < length; i++)
        {
            NewNum[i] = (float)Num[i] / (float)max * 100f;
            sum += NewNum[i];
        }

        float result = sum / (float)length;
        Console.WriteLine(result);


    }
    
}