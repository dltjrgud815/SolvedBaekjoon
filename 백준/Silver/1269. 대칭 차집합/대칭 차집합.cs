namespace BaekJoonTest;

class Program
{
    static void Main(string[] args)
    {
        using var reader = new StreamReader(Console.OpenStandardInput());
        using var writer = new StreamWriter(Console.OpenStandardOutput());
        
        HashSet<string> set = new HashSet<string>();
        
        var tempStr = reader.ReadLine().Split(' ');
        int A = int.Parse(tempStr[0]);
        int B = int.Parse(tempStr[1]);
        
        var AList = reader.ReadLine().Split(' ');
        var BList = reader.ReadLine().Split(' ');

        if (A >= B)
        {
            for (int i = 0; i < A; i++)
            {
                set.Add(AList[i]);
            }
            
            for (int i = 0; i < B; i++)
            {
                if (set.Contains(BList[i]))
                {
                    set.Remove(BList[i]);
                }
                else
                {
                    set.Add(BList[i]);
                }
            }
        }
        else
        {
            for (int i = 0; i < B; i++)
            {
                set.Add(BList[i]);
            }
            
            for (int i = 0; i < A; i++)
            {
                if (set.Contains(AList[i]))
                {
                    set.Remove(AList[i]);
                }
                else
                {
                    set.Add(AList[i]);
                }
            }
        
        }
        
        writer.Write(set.Count);
        
        reader.Close();
        writer.Close();
    }
}