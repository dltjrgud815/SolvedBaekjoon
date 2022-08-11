using System;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        int N = Int32.Parse(Console.ReadLine());
        int temp = N;
        int a = 2;
        while(temp > 1)
        {
            if(temp % a == 0 && !CheckPrime(a))
            {
                temp = temp / a;
                System.Console.WriteLine(a);
            }
            else
            {
                a++;
            }
        }            
    }
    public static bool CheckPrime(int k)
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
        return primearr[k];

    }
    
}