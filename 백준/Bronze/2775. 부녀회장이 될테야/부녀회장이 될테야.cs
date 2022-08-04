using System.Text;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int T = Int32.Parse(Console.ReadLine());
        int[] k = new int[14];
        int[,] result = new int[15, 14];
        int[] K = new int[T];
        int[] N = new int[T];

        
        for(int i = 0; i < 14; i++)
        {
            k[i] = i + 1;
            result[0, i] = (int)k[i];
        }

        for(int i = 0; i < T; i++)
        {
            K[i] = Int32.Parse(Console.ReadLine());
            N[i] = Int32.Parse(Console.ReadLine()) - 1;
        }
        for(int i = 1; i < 15; i++)
        {
            for(int j = 0; j < 14; j++)
            {
                for(int l = 0; l <= j; l++)
                {
                    result[i, j] += result[i-1, l];
                }
            }
        }
        for(int i = 0; i < T; i++)
        {
            System.Console.WriteLine(result[K[i],N[i]]);
        }
 
    }
}