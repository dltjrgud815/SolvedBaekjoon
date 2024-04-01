namespace BaekJoonTest;

class Program
{
    static void Main(string[] args)
    {
        using var reader = new StreamReader(Console.OpenStandardInput());
        using var writer = new StreamWriter(Console.OpenStandardOutput());

        const string enter = "enter";
        const string leave = "leave";
        Dictionary<string, bool> workerInCompany = new();
        string workerName = string.Empty;
        
        int n = int.Parse(reader.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var tempStr = reader.ReadLine().Split(' ');
            if (workerInCompany.ContainsKey(tempStr[0]))
            {
                if (tempStr[1].Equals(leave))
                {
                    workerInCompany.Remove(tempStr[0]);
                }
            }
            else
            {
                if (tempStr[1].Equals(enter))
                {
                    workerInCompany.Add(tempStr[0], true);
                }
            }
        }
        
        List<string> workerList = workerInCompany.Keys.ToList();
        workerList.Sort();
        
        for (int i = workerList.Count - 1; i >= 0; i--)
        {
            if (i == 0)
                writer.Write(workerList[i]);
            else
                writer.WriteLine(workerList[i]);
        }
        
        reader.Close();
        writer.Close();
    }
}