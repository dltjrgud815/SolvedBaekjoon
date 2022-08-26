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
        string[] tempStr;
        StringBuilder sb = new StringBuilder();
        Dictionary<int, int> dInt = new Dictionary<int, int>();
        Hashtable hInt = new Hashtable();
        int N = Int32.Parse(reader.ReadLine());
        tempStr = reader.ReadLine().Split(' ');
        int[] nNum = new int[N];
        for(int i = 0; i < N; i++)
        {
            nNum[i] = Int32.Parse(tempStr[i]);
        }
        int M = Int32.Parse(reader.ReadLine());
        tempStr = reader.ReadLine().Split(' ');
        for(int i = 1; i <= M; i++)
        {
            dInt[i] = Int32.Parse(tempStr[i -1]);
        }
        int cnt = 0;

        Array.Sort(nNum);
        var a = dInt.OrderBy(x => x.Value);

        if(N == 1){
            
        }


        foreach (var item in a)
        {
            if(cnt > nNum.Length - 1)
            {
                dInt[item.Key] = 0;
            }
            else
            {
                while(true)
                {
                    if(nNum[cnt] > item.Value){
                        dInt[item.Key] = 0;
                        break;
                    }
                    else if(nNum[cnt] == item.Value){
                        cnt++;
                        dInt[item.Key] = 1;
                        break;
                    }
                    else{
                        if(cnt == nNum.Length - 1)
                        {
                            dInt[item.Key] = 0;
                            break;
                        }
                        else
                            cnt++;
                    }
                }      
            }
            
        }
        var b = dInt.OrderBy(x => x.Key);
        foreach (var item in b)
        {
            writer.Write(item.Value + " ");
        }
        writer.Write("\n");
        
        reader.Close();
        writer.Close();

    }
}