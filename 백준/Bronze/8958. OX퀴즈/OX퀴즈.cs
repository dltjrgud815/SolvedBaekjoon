using System;
using System.Text;


class SolvedBaekjoon
{
    static void Main()
    {
        int length = Int32.Parse(Console.ReadLine());
        string[] sss = new string[length];
        // string phrase = Console.ReadLine();
        // string[] words = phrase.Split(' ');
        float[] NewNum = new float[length];
        StringBuilder sb = new StringBuilder();
        int[] score = new int[length];
        int[] Rest = new int[10];
        int max = int.MinValue;
        float sum = 0;
        int cnt = 0;
        for (int i = 0; i < length; i++)
        {
            sss[i] = Console.ReadLine();
            sb.Append(sss[i]);
            for (int j = 0; j < sb.Length; j++)
            {
                if (sb[j] == 'O')
                {
                    cnt++;
                    score[i] += cnt;

                }
                else
                    cnt = 0;

            }

            sb.Remove(0, sb.Length);
            cnt = 0;
        }

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(score[i]);
        }


    }
    
}