using System.Text;

namespace BaekJoonTest;

class Program
{
    static void Main(string[] args)
    {
        using var reader = new StreamReader(Console.OpenStandardInput());
        using var writer = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();
        Stack<int> tempStack = new();
        List<int> currentList = new();
        
        int N = int.Parse(reader.ReadLine());
        var tempStr = reader.ReadLine().Split(' ');

        for (int i = 0; i < N; i++)
        {
            currentList.Add(int.Parse(tempStr[i]));
        }

        int currentOrder = 1;
        
        for (int i = 0; i < N; i++)
        {
            if (currentList[i] == currentOrder)
            {
                currentOrder++;
                continue;
            }

            if (tempStack.Count > 0)
            {
                while (tempStack.Count > 0)
                {
                    var temp = tempStack.Pop();
                    if (temp == currentOrder)
                    {
                        currentOrder++;
                        continue;
                    }

                    tempStack.Push(temp);
                    break;
                }
            }
            tempStack.Push(currentList[i]);
        }
        
        while (tempStack.Count > 0)
        {
            if (tempStack.Pop() == currentOrder)
            {
                currentOrder++;
                continue;
            }

            sb.Append("Sad");
            break;
        }
        
        if (sb.Length == 0)
        {
            sb.Append("Nice");
        }
        
        writer.Write(sb);
        reader.Close();
        writer.Close();
    }
}