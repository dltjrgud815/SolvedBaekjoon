namespace BaekJoonTest;

class Program
{
    static void Main(string[] args)
    {
        using var reader = new StreamReader(Console.OpenStandardInput());
        using var writer = new StreamWriter(Console.OpenStandardOutput());
        
        HashSet<string> set = new HashSet<string>();
        
        var S = reader.ReadLine();
        for (int i = 0; i < S.Length; i++)
        {
            for (int j = S.Length - 1; j >= i; j--)
            {
                if (!set.Contains(S.Substring(i, j - i + 1)))
                    set.Add(S.Substring(i, j - i + 1));
            }
        }
        
        writer.Write(set.Count);
        
        reader.Close();
        writer.Close();
    }
}