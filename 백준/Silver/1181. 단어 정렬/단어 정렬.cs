using System;
using System.Text;
using System.IO;
using System.Collections;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        using var reader = new StreamReader(Console.OpenStandardInput());
        using var writer = new StreamWriter(Console.OpenStandardOutput());
        int N = Int32.Parse(reader.ReadLine());
        Dictionary<string, int> dStr = new Dictionary<string, int>();
        string[] str = new string[N];
        string[] tmpStr = new string[N];
        for(int i = 0; i < N; i++)
        {
            string temp = reader.ReadLine();
            dStr[temp] = temp.Length;
        }
        

        var newdStr = dStr.OrderBy(x => x.Value).ThenBy(x => x.Key);
        foreach (var item in newdStr)
        {
            writer.WriteLine(item.Key);
        }
        reader.Close();
        writer.Close();
       
    }
    
}