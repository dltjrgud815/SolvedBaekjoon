using System.Text;

namespace BaekJoonTest;

class Program
{
    static void Main(string[] args)
    {
        using var reader = new StreamReader(Console.OpenStandardInput());
        using var writer = new StreamWriter(Console.OpenStandardOutput());
        Queue<int> tempQueue = new();
        
        int N = int.Parse(reader.ReadLine());
        
        for(int i = 1; i <= N ; i++)
        {
            tempQueue.Enqueue(i);
        }
        
        while (tempQueue.Count > 1)
        {
            tempQueue.Dequeue();
            var value = tempQueue.Dequeue();
            tempQueue.Enqueue(value);
        }
        
        writer.Write(tempQueue.Dequeue());
        reader.Close();
        writer.Close();
    }
}