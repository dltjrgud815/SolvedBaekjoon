using System.Text;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int T = Int32.Parse(Console.ReadLine());
        int[] H = new int[T];
        int[] W = new int[T];
        int[] N = new int[T];
        int k = 0;
        int j = 0;
        for(int i = 0; i < T; i++)
        {
            string[] tempstr = Console.ReadLine().Split(" ");
            H[i] = Int32.Parse(tempstr[0]);
            W[i] = Int32.Parse(tempstr[1]);
            N[i] = Int32.Parse(tempstr[2]);
            
        }
        for(int i = 0; i < T; i++)
        {
            if(N[i] % H[i] == 0)
            {
                k = H[i];
                j = N[i]/H[i];
            }
            else
            {
                k = N[i] % H[i];
                j = N[i]/H[i] + 1;
            }
                


            if(j< 10)
                System.Console.WriteLine($"{k}0{j}");
            else
                System.Console.WriteLine($"{k}{j}");
        }


        
    }
}