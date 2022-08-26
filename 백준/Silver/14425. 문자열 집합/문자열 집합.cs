using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        using var reader = new StreamReader(Console.OpenStandardInput());
        using var writer = new StreamWriter(Console.OpenStandardOutput());
        string[] tempStr = reader.ReadLine().Split(' ');
        int N = Int32.Parse(tempStr[0]);
        int M = Int32.Parse(tempStr[1]);

        HashSet<string> nStr = new HashSet<string>();
        for(int i = 0; i < N; i++)
        {
            nStr.Add(reader.ReadLine());
        }
        string[] mStr = new string[M];
        for(int i = 0; i < M; i++)
        {
            mStr[i] = reader.ReadLine();
        }
        
        int cnt = 0;
        for(int i = 0; i < M; i++)
        {
            if(nStr.Contains(mStr[i]))
                cnt++;
        }

        writer.WriteLine(cnt);

        reader.Close();
        writer.Close();

    }
}