using System.Text;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int T = Int32.Parse(Console.ReadLine());
        int a3 = T / 3;
        int b5 = T/ 5;
        int c8 = T / 8;
        int tmep = 0;
        int result = a3;
        int temp1 = T;
        bool isright = true;

        for(int i = 1; i <= T; i++)
        {
            if((T) % 5 != 0 && (T) % 3 != 0)
            {
                temp1 -= 5;
                if((temp1) % 5 != 0 && (temp1) % 3 != 0)
                {
                    temp1 += 2;
                }
                else
                {
                    isright = false;
                    break;
                }
            }
            else
            {
                isright = false;
                break;
            }
            if(temp1 <= 0)
                break;
    
        }
        if(isright)
            result = -1;
        else if(T % 5 == 0)
            result = b5;
        else
        {
            for(int i = 1; i <= a3; i++)
            {
                tmep = T - (i * 3);
                if(tmep % 5 == 0)
                {
                    result = (tmep / 5) + i;
                    break;
                }
            }
        }

        
        System.Console.WriteLine(result);

    }
}