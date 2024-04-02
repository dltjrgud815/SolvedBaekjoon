namespace BaekJoonTest;

class Program
{
    static void Main(string[] args)
    {
        using var reader = new StreamReader(Console.OpenStandardInput());
        using var writer = new StreamWriter(Console.OpenStandardOutput());
        
        var tempStr = reader.ReadLine().Split(' ');
        int N = int.Parse(tempStr[0]);
        int M = int.Parse(tempStr[1]);
        
        HashSet<string> set = new();
        List<string> result = new();
        for (int i = 0; i < N; i++)
        {
            set.Add(reader.ReadLine());
        }
        
        for (int i = 0; i < M; i++)
        {
            var str = reader.ReadLine();
            if (set.Contains(str))
            {
                result.Add(str);
            }
        }
        
        writer.WriteLine(result.Count);
        
        if (result.Count > 0)
        {
            result.Sort();
        
            for (int i = 0 ; i < result.Count; i++)
            {
                if (i == result.Count - 1)
                {
                    writer.Write(result[i]);
                    continue;
                }
                writer.WriteLine(result[i]);
            }
        }
        
        reader.Close();
        writer.Close();
    }
}