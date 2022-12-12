using System;
using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {

        int N = Int32.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        int[] number = new int[N];
        for(int i = 0; i < N; i++)
        {
            number[i] = Int32.Parse(Console.ReadLine());
        }
        Array.Sort(number);
        for(int i = 0; i < N; i++)
        {
            sb.Append(number[i] + "\n");
        }

        System.Console.Write(sb);

    }
}