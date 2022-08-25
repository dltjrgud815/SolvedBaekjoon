using System;
using System.Text;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        using var reader = new StreamReader(Console.OpenStandardInput());
        using var writer = new StreamWriter(Console.OpenStandardOutput());
        int N = Int32.Parse(reader.ReadLine());
        int[] tempInt = new int[N];
        int[] tempCnt = new int[4001];
        int[] tempMinusCnt = new int[4001];
        int sum = 0;
        for(int i = 0; i < N; i++)
        {
           tempInt[i] = Int32.Parse(reader.ReadLine());
           sum += tempInt[i];
            if(tempInt[i] >= 0)
                tempCnt[tempInt[i]]++;
            else
                tempMinusCnt[-tempInt[i]]++;

        }

        decimal mean;
        mean =  (decimal)Math.Round((decimal)sum / (decimal)N);
        Array.Sort(tempInt);
        int middle = tempInt[(int)N/2];
        int range;
        int cnt = 0;
        if(N==1)
            range = 0;
        else
            range = tempInt[N-1] - tempInt[0];

        int repeatSecondMax = 0;
        if(tempCnt.Max() > tempMinusCnt.Max())
        {
            for(int i = 0; i <= 4000; i++)
            {
                if(cnt < 2 && tempCnt.Max() == tempCnt[i])
                {
                    repeatSecondMax = i;
                    cnt++;
                }
            }
        }
        else if(tempCnt.Max() == tempMinusCnt.Max())
        {
            for(int i = 1; i <= 4000; i++)
            {
                if(cnt < 2 && tempMinusCnt.Max() == tempMinusCnt[4001 - i])
                {
                    repeatSecondMax = -(4001 - i);
                    cnt++;
                }
            }
            for(int i = 0; i <= 4000; i++)
            {
                if(cnt < 2 && tempCnt.Max() == tempCnt[i])
                {
                    repeatSecondMax = i;
                    cnt++;
                }
            }
  
        }
        else
        {
           for(int i = 1; i <= 4000; i++)
            {
                if(cnt < 2 && tempMinusCnt.Max() == tempMinusCnt[4001 - i])
                {
                    repeatSecondMax = -(4001 - i);
                    cnt++;
                }
            } 
        }


        System.Console.WriteLine(mean);
        writer.WriteLine(middle);
        writer.WriteLine(repeatSecondMax);
        writer.WriteLine(range);

        reader.Close();
        writer.Close();
       
    }
    
}