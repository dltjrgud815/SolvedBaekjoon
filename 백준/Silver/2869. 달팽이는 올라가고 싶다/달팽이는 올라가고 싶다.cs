using System.Text;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] tempstr = Console.ReadLine().Split(" ");
        int A = Int32.Parse(tempstr[0]);
        int B = Int32.Parse(tempstr[1]);
        int V = Int32.Parse(tempstr[2]);

        int x = (V - A) / (A - B);
        if((V-A) % (A-B) != 0)
            x ++;

        System.Console.WriteLine(x + 1);

        
    }
}