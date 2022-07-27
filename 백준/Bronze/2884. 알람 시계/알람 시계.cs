using System;


class SolvedBaekjoon
{
    static void Main()
    {
        string str;
        
        int H = 0, M = 0;

        str = Console.ReadLine();
        string[] strArray = str.Split('\x020'); 
        H = Int32.Parse(strArray[0]);
        M = Int32.Parse(strArray[1]);

        if ((M - 45) < 0)
        {
            M = 60 + (M - 45);
            H--;
            if (H < 0)
                H = 23;
        }
        else
            M -= 45;

        Console.WriteLine($"{H} {M}");

    }
    
}