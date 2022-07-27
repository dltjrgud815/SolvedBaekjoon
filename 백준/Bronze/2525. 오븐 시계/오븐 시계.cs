using System;


class SolvedBaekjoon
{
    static void Main()
    {
        string str;
        
        int H = 0, M = 0, Pm = 0;

        str = Console.ReadLine();
        string[] strArray = str.Split('\x020'); 
        H = Int32.Parse(strArray[0]);
        M = Int32.Parse(strArray[1]);
        Pm = Int32.Parse(Console.ReadLine());


        if ((M + Pm) >= 60)
        {
            int temp = (M + Pm) / 60;
            M = (M + Pm) % 60;
            H += temp;
            if (H > 23)
                H = H - 24;
        }
        else
        {
            M += Pm;
        }
        Console.WriteLine($"{H} {M}");

    }
    
}