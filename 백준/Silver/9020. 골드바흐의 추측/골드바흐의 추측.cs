using System;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        int N = Int32.Parse(Console.ReadLine());
        int num = 0;
        int[] splitnum = new int[2];
        bool[] isPrime = CheckPrime(10000);
        StringBuilder sb = new StringBuilder();
        for(int i = 0 ; i < N; i++)
        {
            num = Int32.Parse(Console.ReadLine());
            splitnum[0] = num / 2;
            splitnum[1] = num/ 2;
            while(true)
            {
                if(!isPrime[splitnum[0]] && !isPrime[splitnum[1]])
                    break;
                else
                {
                    splitnum[0]--;
                    splitnum[1]++;
                }
            }
            sb.Append($"{splitnum[0]} {splitnum[1]}\n");
        }
        System.Console.WriteLine(sb);
       
    }
    public static bool[] CheckPrime(int k)
    {
        bool[] primearr = new bool[k + 1];
        primearr[1] = true;

        for(int i = 2; i <= MathF.Sqrt(k); i++)
        {
            if(primearr[i])
                continue;
            for(int j = i + i; j <= k; j += i)
            {
                primearr[j] = true;
            }
        }
        return primearr;

    }
    
}