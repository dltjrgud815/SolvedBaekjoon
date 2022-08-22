using System;
using System.Text;


internal class Program
{
    private static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(Console.ReadLine());
        int[] a = new int[sb.Length];
        for(int i = 0; i < sb.Length; i++)
        {
            a[i] = Int32.Parse(sb[i].ToString());
        }
        Array.Sort(a);
        Array.Reverse(a);
        for(int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i]);
        }
        
    }
}