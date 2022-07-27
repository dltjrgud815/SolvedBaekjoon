using System;


class SolvedBaekjoon
{
    static void Main()
    {

        string phrase = Console.ReadLine();
        string[] words = phrase.Split(' ');
        
        int A = Int32.Parse(words[0]);
        int B = Int32.Parse(words[1]);

        Console.WriteLine(A + B);


    }
    
}