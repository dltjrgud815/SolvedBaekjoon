namespace BaekJoonTest;

class Program
{
    static void Main(string[] args)
    {
        using var reader = new StreamReader(Console.OpenStandardInput());
        using var writer = new StreamWriter(Console.OpenStandardOutput());
        
        Dictionary<string, int> dic = new();
        
        int N = int.Parse(reader.ReadLine());
        var firstLine = reader.ReadLine().Split(' ');
        
        for (int i = 0; i < N; i++)
        {
            if (dic.ContainsKey(firstLine[i]))
            {
                dic[firstLine[i]]++;
            }
            else
            {
                dic.Add(firstLine[i], 1);
            }
        }
        
        int M = int.Parse(reader.ReadLine());
        var secondLine = reader.ReadLine().Split(' ');
        
        for (int i = 0; i < M - 1; i++)
        {
            if (dic.ContainsKey(secondLine[i]))
            {
                writer.Write(dic[secondLine[i]] + " ");
            }
            else
            {
                writer.Write(0 + " ");
            }
        }
        
        writer.WriteLine(dic.ContainsKey(secondLine[M - 1]) ? dic[secondLine[M - 1]] : 0);
        
        reader.Close();
        writer.Close();
    }
}