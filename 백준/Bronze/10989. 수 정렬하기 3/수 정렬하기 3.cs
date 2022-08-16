using System;
using System.Text;
using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        using var reader = new StreamReader(Console.OpenStandardInput());
        using var writer = new StreamWriter(Console.OpenStandardOutput());
        int N = Int32.Parse(reader.ReadLine());
        StringBuilder sb = new StringBuilder();
        int[] number = new int[10001];
        for(int i = 0; i < N; i++)
        {
            number[Int32.Parse(reader.ReadLine())]++;
        }

        for(int i = 0; i <= 10000; i++)
        {   
            if(number[i] != 0)
            {
                for(int j = 0; j < number[i]; j++)
                {
                    writer.WriteLine(i);   
                }
            }
            
            
        }

    }
}