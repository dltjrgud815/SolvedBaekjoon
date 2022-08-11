using System;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        int cnt = 0;
        int temp = 0;
        List<int> intls = new List<int>();
        while(true)
        {
            int N = Int32.Parse(Console.ReadLine());
            if(N == 0)
                break;
            intls.Add(N);
            cnt++;
        }
        for(int i = 0; i < cnt; i++)
        {
            temp = intls[i];
            temp = CheckPrime(temp, temp*2);
            System.Console.WriteLine(temp);
        }   
    }
    public static int CheckPrime(int l, int k)
    {
        bool[] primearr = new bool[k + 1];
        primearr[1] = true;
        int cnt = 0;
        

        for(int i = 2; i <= MathF.Sqrt(k); i++)
        {
            if(primearr[i])
                continue;
            for(int j = i + i; j <= k; j += i)
            {
                primearr[j] = true;
            }
        }

        for(int i = l + 1; i <= k; i++)
        {
            if(!primearr[i])
                cnt++;
        }
        return cnt;

    }
    
}