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
        Dictionary<int, int> dStr = new Dictionary<int, int>();
        string[] tmpStr;
        string[] nameTemp = new string[N];
        for(int i = 0; i < N; i++)
        {
            tmpStr = reader.ReadLine().Split(' ');
            dStr[i] = Int32.Parse(tmpStr[0]);
            nameTemp[i] = tmpStr[1];;
           
        }
        

        var newdStr = dStr.OrderBy(x => x.Value);
        foreach (var item in newdStr)
        {
            writer.WriteLine(item.Value+" "+nameTemp[item.Key]);
        }
        reader.Close();
        writer.Close();
       
    }
    
}