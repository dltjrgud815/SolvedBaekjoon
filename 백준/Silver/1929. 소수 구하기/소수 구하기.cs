using System;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] tempstr = Console.ReadLine().Split(" ");
        int M = Int32.Parse(tempstr[0]);
        int N = Int32.Parse(tempstr[1]);
        bool[] temp = new bool[N + 1];
        temp = CheckPrime(M, N);
        StringBuilder sb = new StringBuilder();
        

        for(int i = M; i <= N; i++)
        {
            if(!temp[i])
                sb.Append(i + "\n");
        }
        System.Console.Write(sb);
        
            
    }
    public static bool[] CheckPrime(int n, int k)
    {
        bool[] primearr = new bool[k + 1];
        primearr[1] = true;
        
        // primearr[1] = false;
        // if(n == 2 || k == 2)
        //     primearr[2] = true;
        // for(int i = 3; i <= k; i+=2)
        // {
        //     primearr[i] = true;
        // }
        // for(int i = 3; i <= k; i += 2)
        // {
        //     if(primearr[i])
        //     {
        //         int j = i * i;
        //         if(j >= k)
        //             break;
        //         for(i *=2; j <= k; j+= i)
        //         {
        //             primearr[j] = false;
        //         }
        //         i/=2;
        //     }
        // }
        // for(int i = n; i <= k; i++)
        // {
        //     if(primearr[i])
        //         System.Console.WriteLine(i);
        // }

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