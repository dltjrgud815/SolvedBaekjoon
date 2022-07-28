using System;
using System.Text;
using Microsoft.VisualBasic;


class SolvedBaekjoon
{
    static void Main()
    {
        //int length = Int32.Parse(Console.ReadLine());
        int cnt = 0;
        string phrase = Console.ReadLine().Trim();
        string[] words = phrase.Split(" ");
        if (string.IsNullOrWhiteSpace(words[0]))
            cnt++;


        Console.WriteLine(words.Length - cnt);


    }

}