using System;
using System.Text;
using Microsoft.VisualBasic;


class SolvedBaekjoon
{
    static void Main()
    {
        int length = Int32.Parse(Console.ReadLine());
        float sum = 0f;
        float mean = 0f;
        float[] result = new float[length];
        int cnt = 0;
        for (int i = 0; i < length; i++)
        {
            string phrase = Console.ReadLine();
            string[] words = phrase.Split(' ');
            int StNum = Int32.Parse(words[0]);
            int[] score = new int[words.Length];
            for (int j = 1; j < words.Length; j++)
            {
                score[j] = Int32.Parse(words[j]);
                sum += score[j];
            }

            mean = (float)sum / (float)StNum;
            for (int j = 1; j < words.Length; j++)
            {
                if (mean < score[j])
                    cnt++;
            }

            result[i] = (float)cnt / (float)StNum * 100;

            cnt = 0;
            sum = 0;
            mean = 0;

        }

        float a;
        for (int i = 0; i < result.Length; i++)
        {
            a = MathF.Round(result[i], 3);
            Console.WriteLine("{0:F3}" + "%", result[i]);
        }



    }
    
}