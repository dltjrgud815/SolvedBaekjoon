using System;
using System.Text;
using Microsoft.VisualBasic;


class SolvedBaekjoon
{
    static void Main()
    {
        
        int cnt = 0;
        int length = Int32.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        StringBuilder sb1 = new StringBuilder();
        string[] result = new string[length];
        for (int i = 0; i < length; i++)
        {
            string phrase = Console.ReadLine();
            string[] words = phrase.Split(" ");
            cnt = Int32.Parse(words[0]);
            sb.Append(words[1]);
            for (int j = 0; j < sb.Length; j++)
            {
                for (int k = 0; k < cnt; k++)
                {
                    sb1.Append(sb[j]);
                }
            }

            result[i] = sb1.ToString();
            sb.Clear();
            sb1.Clear();
        }

        foreach (var VARIABLE in result)
        {
            Console.WriteLine(VARIABLE);
        }

    }

}