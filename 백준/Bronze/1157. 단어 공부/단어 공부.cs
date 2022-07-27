using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        string a = Console.ReadLine().ToUpper();
        int temp = 0;
        int max = int.MinValue;
        int tempIndex = 0;
        int cnt = 0;
        sb.Append(a);
        int[] cntAlphabet = new int[27];

        for (int i = 0; i < sb.Length; i++)
        {
            cntAlphabet[(int)sb[i] - 'A']++;
        }

        for (int i = 0; i < cntAlphabet.Length; i++)
        {
            if (cntAlphabet[i] > max)
            {
                max = cntAlphabet[i];
                tempIndex = i;
            }
            
        }
        

        for (int i = 0; i < cntAlphabet.Length; i++)
        {
            if (cntAlphabet[i] == max)
                cnt++;
        }
        
        if (cnt > 1)
        {
            Console.Write("?");
        }
        else
        {
            Console.Write((char)(tempIndex + 'A'));
        }
            
        
    }
    
}