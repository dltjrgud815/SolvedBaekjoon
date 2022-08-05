using System.Text;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int N = Int32.Parse(Console.ReadLine());

        string[] tempstr = Console.ReadLine().Split(" ");
        int[] prime = new int[N];
        bool isPrime = true;
        int cnt = 0;

        for(int i = 0; i < N; i++)
        {
            prime[i] = Int32.Parse(tempstr[i]);
        }

        for(int i = 0; i < N; i++)
        {
            if(prime[i] == 1)
                isPrime = false;
            else
                isPrime = true;
            
            for(int j = 2; j < prime[i]; j++)
            {
                if(prime[i] % j == 0)
                    isPrime = false;

            }
            if(isPrime)
                cnt++;
        }
        System.Console.WriteLine(cnt);
        

    }
}