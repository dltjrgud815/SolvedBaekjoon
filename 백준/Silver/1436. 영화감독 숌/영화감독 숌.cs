using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int N = Int32.Parse(Console.ReadLine());
        int result = 666;
        int cnt = 1;
        int temp = 0;

        while(cnt < N)
        {
            result ++;
            temp = result;
            while(temp != 0)
            {
                if(temp % 1000 == 666)
                {
                    cnt++;
                    break;
                }
                else
                    temp /= 10;
            }

        }

        System.Console.WriteLine(result);

    }
}