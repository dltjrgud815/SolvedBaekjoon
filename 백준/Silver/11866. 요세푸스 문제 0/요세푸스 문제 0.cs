using System.Text;

namespace BaekJoonTest;

class Program
{
    static void Main(string[] args)
    {
        using var reader = new StreamReader(Console.OpenStandardInput());
        using var writer = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new();
        sb.Append("<");
        Queue<int> tempQueue = new();
        
        var tempStr = reader.ReadLine().Split(' ');
        int N = int.Parse(tempStr[0]);
        int K = int.Parse(tempStr[1]);
        
        for(int i = 1; i <= N ; i++)
        {
            tempQueue.Enqueue(i);
        }
        
        while (tempQueue.Count > 1)
        {
            for (int i = 0; i < K - 1; i++)
            {
                var value = tempQueue.Dequeue();
                tempQueue.Enqueue(value);
            }
            sb.Append(tempQueue.Dequeue() + ", ");
        }
        
        sb.Append(tempQueue.Dequeue() + ">");
        writer.Write(sb);
        reader.Close();
        writer.Close();
    }
}