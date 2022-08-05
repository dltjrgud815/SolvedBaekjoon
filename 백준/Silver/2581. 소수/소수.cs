using System.Text;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int M = Int32.Parse(Console.ReadLine());
        int N = Int32.Parse(Console.ReadLine());

        bool isPrime = true;
        int sum = 0;
        int min = Int32.MaxValue;
        
        for(int i = M; i <= N; i++)
        {
            if(i == 1)
                isPrime = false;
            else
                isPrime = true;
            
            for(int j = 2; j < i; j++)
            {
                if(i % j == 0)
                    isPrime = false;

            }
            if(isPrime)
            {
                sum += i;
                if(min > i)
                    min = i;
            }
                
        }
        if(sum == 0)
        {
            System.Console.WriteLine("-1");
        }
        else
        {
            System.Console.WriteLine(sum);
            System.Console.WriteLine(min);
        }
        
        

    }
}