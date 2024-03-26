using System.Text;

namespace BaekJoonTest;

class Program
{
    static void Main(string[] args)
    {
        using var reader = new StreamReader(Console.OpenStandardInput());
        using var writer = new StreamWriter(Console.OpenStandardOutput());
        string[] tempStr;
        tempStr = reader.ReadLine().Split(' ');
        int N = int.Parse(tempStr[0]);
        int M = int.Parse(tempStr[1]);
        int[] basket = new int[N];
        
        for (int i = 0; i < N; i++)
        {
            basket[i] = i + 1;
        }

        for (int i = 0; i < M; i++)
        {
            var input = reader.ReadLine().Split(' ');
            var left = int.Parse(input[0]);
            var right = int.Parse(input[1]);
            var diff = right - left;
            
            if (diff == 0)
            {
                continue;
            }
            
            for (int j = 0; j < diff / (diff % 2 == 0 ? 2 : 2f); j++)
            {
                Exchange(ref basket[left - 1 + j], ref basket[right - 1 - j]);
            }
        }

        for (int i = 0; i < basket.Length; i++)
        {
            if (i != basket.Length - 1)
                writer.Write(basket[i] + " ");
            else
                writer.Write(basket[i]);
        }
        
        reader.Close();
        writer.Close();
    }
    
    static void Exchange(ref int a, ref int b)
    {
        (a, b) = (b, a);
    }
}