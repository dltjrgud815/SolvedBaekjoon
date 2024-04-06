namespace BaekJoonTest;

class Program
{
    static void Main(string[] args)
    {
        using var reader = new StreamReader(Console.OpenStandardInput());
        using var writer = new StreamWriter(Console.OpenStandardOutput());
        
        Dictionary<string, int> stringToInt = new();
        Dictionary<int, string> intToString = new();

        var tempStr = reader.ReadLine().Split(' ');
        int M = int.Parse(tempStr[0]);
        int N = int.Parse(tempStr[1]);

        for (int i = 0; i < M; i++)
        {
            var str = reader.ReadLine();
            stringToInt.Add(str, i + 1);
            intToString.Add(i + 1, str);
        }
        
        for (int i = 0; i < N; i++)
        {
            var str = reader.ReadLine();

            if (int.TryParse(str, out var number))
            {
                writer.WriteLine(intToString[number]);
            }
            else
            {
                writer.WriteLine(stringToInt[str]);
            }
        }
        
        reader.Close();
        writer.Close();
    }
}