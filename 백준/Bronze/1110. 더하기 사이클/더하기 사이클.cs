using System;


class SolvedBaekjoon
{
    static void Main()
    {


        int Pm = 0;
        int cnt = 0;
        int newNumber = 0;
        int temp = 0;
        int a = 0, b = 0, c = 0;
        Pm = Int32.Parse(Console.ReadLine());
        temp = Pm;
        do
        {
            if (temp < 10)
            {
                c = temp;
                newNumber = c * 10 + c;
            }
            else
            {
                a = temp / 10;
                b = temp % 10;
                c = a + b;
                if (c >= 10)
                    c %= 10;
                newNumber = b * 10 + c;
            }
            cnt++;
            temp = newNumber;
        } while (!(newNumber == Pm));

        Console.WriteLine(cnt);


    }
    
}