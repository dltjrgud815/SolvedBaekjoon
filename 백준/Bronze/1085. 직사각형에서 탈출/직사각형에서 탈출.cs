using System;
using System.Text;
using System.IO;
//using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {

        using var reader = new StreamReader(Console.OpenStandardInput());
        using var writer = new StreamWriter(Console.OpenStandardOutput());
        string[] tempStr = reader.ReadLine().Split(' ');
        int[] distance = new int[4];
        distance[0] = Int32.Parse(tempStr[0]);
        distance[1] = Int32.Parse(tempStr[1]);
        distance[2] = Int32.Parse(tempStr[2]) - Int32.Parse(tempStr[0]);
        distance[3] = Int32.Parse(tempStr[3]) - Int32.Parse(tempStr[1]);
        
        writer.WriteLine(distance.Min());
        reader.Close();
        writer.Close();

    }
}